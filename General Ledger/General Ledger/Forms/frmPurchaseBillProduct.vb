Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPurchaseBillProduct
    Dim dbGrid As BindGrid
    Dim Query As New ActionQueryBuilder
    Dim cVoucherNo As String

    Enum Actions
        Initial
        Entry
        Edit
    End Enum

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmImportBillFabric_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call SetControls(Actions.Initial)
        Call FillCombo()

        txtDateFrom.Value = DateFrom
        txtDateTo.Value = DateTo
    End Sub

    Sub FillCombo()
        Dim Supplier As New BindCombo(cmbSupplier, "Select Code,Name From tblSupplier  Order By Code", "Name", "Code", True, True)
        Dim SupplierAccount As New BindCombo(cmbSupplierAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' and AccountType = 'Supplier' Order By AccountName", "AccountName", "AccountCode", True, True, GLConString)
        Dim LessOtherAccount As New BindCombo(cmbLessOtherAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' Order By AccountName", "AccountName", "AccountCode", True, True, GLConString)
        Dim AddOtherAccount As New BindCombo(cmbAddOtherAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail'  Order By AccountName", "AccountName", "AccountCode", True, True, GLConString)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile Order BY Name", "Name", "Code", True, True)

        Dim Product As New BindCombo(tdbProduct, "Select ProductCode,ProductName From tblProductMaster", "ProductName", "ProductCode", True)
    End Sub

    Sub ClearControls()
        txtBillNo.Text = ""
        txtBillDate.Value = Today.Date
        cmbSupplierAccount.SelectedValue = ""
        txtDescription.Text = ""
        txtGrossAmount.Value = 0
        txtSalesTax.Value = 0
        txtDiscount.Value = 0
        txtAddOther.Value = 0
        txtLessOther.Value = 0
        txtNetAmount.Value = 0
        txtInvoiceNo.Text = ""
        txtInvoiceDate.Value = Today.Date

        cmbSupplier.SelectedValue = ""
        cmbAddOtherAccount.SelectedValue = ""
        cmbLessOtherAccount.SelectedValue = ""
        cmbProject.SelectedValue = ""

        tdbGridBillDetail.DataSource = Nothing

        tdbGridBillDetail.Columns("Qty").FooterText = ""
        tdbGridBillDetail.Columns("Amount").FooterText = ""
        tdbGridBillDetail.Columns("DiscAmount").FooterText = ""
        tdbGridBillDetail.Columns("SalesTaxAmount").FooterText = ""
        tdbGridBillDetail.Columns("NetAmount").FooterText = ""
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtBillNo.Enabled = True
                txtBillDate.Enabled = False
                txtDescription.Enabled = False
                txtAddOther.Enabled = False
                cmbAddOtherAccount.Enabled = False
                txtLessOther.Enabled = False
                cmbLessOtherAccount.Enabled = False
                txtInvoiceNo.Enabled = False
                txtInvoiceDate.Enabled = False


                cmbSupplier.Enabled = False
                cmbSupplierAccount.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtBillNo.Enabled = False
                txtBillDate.Enabled = False
                txtDescription.Enabled = False
                txtAddOther.Enabled = False
                cmbAddOtherAccount.Enabled = False
                txtLessOther.Enabled = False
                cmbLessOtherAccount.Enabled = False
                txtInvoiceNo.Enabled = False
                txtInvoiceDate.Enabled = False


                cmbSupplier.Enabled = False
                cmbSupplierAccount.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtBillNo.Enabled = False
                txtBillDate.Enabled = True
                txtDescription.Enabled = True
                txtAddOther.Enabled = True
                cmbAddOtherAccount.Enabled = True
                txtLessOther.Enabled = True
                cmbLessOtherAccount.Enabled = True
                txtInvoiceNo.Enabled = True
                txtInvoiceDate.Enabled = True


                cmbSupplier.Enabled = True
                cmbSupplierAccount.Enabled = True
        End Select
    End Sub

    Public Sub SetButtons(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                cmdAdd.Enabled = True
                cmdSearch.Enabled = True
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = False
                cmdUndo.Enabled = False
                cmdExit.Enabled = True

                cmdPrint.Enabled = False
                cmdVoucher.Enabled = False
            Case Actions.Edit
                cmdAdd.Enabled = False
                cmdSearch.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                cmdPrint.Enabled = True
                cmdVoucher.Enabled = True
            Case Actions.Entry
                cmdAdd.Enabled = False
                cmdSearch.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                cmdPrint.Enabled = False
                cmdVoucher.Enabled = False
        End Select
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "PURCHASE BILL PRODUCT") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "PURCHASE BILL PRODUCT") = -1 Then

            If txtBillDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtBillDate.Value > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Edit Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            Dim db As dbOperations
            Dim dr As SqlDataReader

            db = New dbOperations("Select * From tblPaymentVoucherDtl Where InvoiceNo = '" & txtBillNo.Text & "'")
            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                If RemoveNull(dr!EntryNo, "") <> "" Then
                    MsgBox("Payment Voucher Already Generated Cannot Edit")
                    Exit Sub
                End If
            End If

            dr.Close()
            db.Close()

            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "PURCHASE BILL PRODUCT") = -1 Then

            If txtBillDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtBillDate.Value > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Delete Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            Dim db As dbOperations
            Dim dr As SqlDataReader

            db = New dbOperations("Select * From tblPaymentVoucherDtl Where InvoiceNo = '" & txtBillNo.Text & "'")
            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                If RemoveNull(dr!EntryNo, "") <> "" Then
                    MsgBox("Payment Voucher Already Generated Cannot Delete")
                    Exit Sub
                End If
            End If

            dr.Close()
            db.Close()

            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                db = New dbOperations("Delete From tblJVDtl Where VoucherNo In (Select VoucherNo From tblJVMst Where InvoiceNo = '" & txtBillNo.Text & "')", GLConString)
                db.dbActionQuery()

                db.Close()

                db = New dbOperations("Delete From tblJvMst Where InvoiceNo = '" & txtBillNo.Text & "'", GLConString)
                db.dbActionQuery()

                db.Close()

                Query = New ActionQueryBuilder

                dbGrid.SetCriteria = "BillNo = '" & txtBillNo.Text & "'"
                dbGrid.Delete()

                Query.Refresh()
                Query.SetQueryInformation("tblPurBillProductMst", "BillNo = '" & txtBillNo.Text & "'")
                Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete)

                DeleteInfo(txtBillNo.Text, "Delete Record Local Bill Product Supplier Name " + "" + cmbSupplier.Text)

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtBillNo.Text <> "" Then
            Dim db As New dbOperations("Select * From tblPurBillProductMst Where BillNo = '" & txtBillNo.Text & "'")
            Dim dr As SqlDataReader

            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                txtBillNo.Text = dr!Billno
                txtBillDate.Value = dr!BillDate
                txtDescription.Text = dr!Description
                txtGrossAmount.Value = RemoveNull(dr!GrossAmount, 0)
                txtSalesTax.Value = RemoveNull(dr!SalesTax, 0)
                txtDiscount.Value = RemoveNull(dr!Discount, 0)
                txtLessOther.Value = RemoveNull(dr!LessOther, 0)
                cmbLessOtherAccount.SelectedValue = RemoveNull(dr!LessOtherAccount, "")
                txtAddOther.Value = RemoveNull(dr!AddOther, 0)
                cmbAddOtherAccount.SelectedValue = RemoveNull(dr!AddotherAccount, "")
                txtNetAmount.Value = RemoveNull(dr!NetAmount, 0)
                txtInvoiceNo.Text = RemoveNull(dr!InvoiceNo, "")
                txtInvoiceDate.Value = RemoveNull(dr!InvoiceDate, Today.Date)
                cmbProject.SelectedValue = RemoveNull(dr!Project, "")

                cmbSupplier.SelectedValue = dr!Supplier
                cmbSupplierAccount.SelectedValue = dr!SupplierAccount

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Invalid Po Number")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If

        dbGrid = New BindGrid(tdbGridBillDetail, "Select Project,BillNo,GRNNo,PoNo,ProductCode,Qty,Rate,Amount,GrossAmount,DiscPer,DiscAmount,SalesTaxPer,SalesTaxAmount,NetAmount,Location,GrnQty,GRNRate,GRNAmount,DiffAmount From tblPurBillProductDtl Where BillNo = '" & txtBillNo.Text & "'")

        Call Totals()
    End Sub
    Sub Totals()
        Dim cTotalQty As Double
        Dim cTotalGRNQty As Double
        Dim cTotalGRNAmount As Double
        Dim cTotalAmount As Double
        Dim cTotalDiff As Double
        Dim cTotalSalesTax As Double
        Dim cTotalDiscount As Double
        Dim cNetAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalQty += Convert.ToDouble(RemoveNull(row("Qty"), 0))
            cTotalGRNQty += Convert.ToDouble(RemoveNull(row("GRNQty"), 0))
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
            cTotalGRNAmount += Convert.ToDouble(RemoveNull(row("GRNAmount"), 0))
            cTotalDiff += Convert.ToDouble(RemoveNull(row("DiffAmount"), 0))
            cTotalSalesTax += Convert.ToDouble(RemoveNull(row("SalesTaxAmount"), 0))
            cTotalDiscount += Convert.ToDouble(RemoveNull(row("DiscAmount"), 0))
            cNetAmount += Convert.ToDouble(RemoveNull(row("NetAmount"), 0))
        Next

        tdbGridBillDetail.Columns("Qty").FooterText = Format(cTotalQty, "###,###,##0.00")
        tdbGridBillDetail.Columns("GRNQty").FooterText = Format(cTotalGRNQty, "###,###,##0.00")
        tdbGridBillDetail.Columns("Amount").FooterText = Format(cTotalAmount, "###,###,##0.00")
        tdbGridBillDetail.Columns("GRNAmount").FooterText = Format(cTotalGRNAmount, "###,###,##0.00")
        tdbGridBillDetail.Columns("DiffAmount").FooterText = Format(cTotalDiff, "###,###,##0.00")
        tdbGridBillDetail.Columns("SalesTaxAmount").FooterText = Format(cTotalSalesTax, "###,###,##0.00")
        tdbGridBillDetail.Columns("DiscAmount").FooterText = Format(cTotalDiscount, "###,###,##0.00")
        tdbGridBillDetail.Columns("NetAmount").FooterText = Format(cNetAmount, "###,###,##0.00")

        txtGrossAmount.Value = Math.Round(cTotalAmount, 2)
        txtSalesTax.Value = Math.Round(cTotalSalesTax, 2)
        txtDiscount.Value = Math.Round(cTotalDiscount, 2)
        txtNetAmount.Value = Math.Round(cNetAmount, 2)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cAdd As Boolean

        Dim db As dbOperations
        Dim dr As SqlDataReader

        If dbGrid.cDataTable.Rows.Count = 0 Then
            MsgBox("Must Be Enter Some Entries in Grid", vbInformation, cCompany)
            Exit Sub
        End If

        If cmbSupplierAccount.SelectedValue = "" Then
            MsgBox("Supplier Account Cannot Left Blank")
            Exit Sub
        End If

        If txtBillDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtBillDate.Value > Format(DateTo, "MM/dd/yyy") Then
            MsgBox("Cannot Save Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
            Exit Sub
        End If

        If txtBillDate.Value < DateFrom Or txtBillDate.Value > DateTo Then
            MsgBox("Cannot Save Transaction it Must Fall with in the Accounting Period")
            Exit Sub
        End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Field Cannot Left Blank ")
            Exit Sub
        End If


        If txtAddOther.Value <> 0 Then
            If cmbAddOtherAccount.SelectedValue = "" Then
                MsgBox("Add Other Account Must be Selected")
                Exit Sub
            End If
        End If

        If txtLessOther.Value <> 0 Then
            If cmbAddOtherAccount.SelectedValue = "" Then
                MsgBox("Add Other Account Must be Selected")
                Exit Sub
            End If
        End If

        Dim cPONo As String = ""

        Dim cSql As String

        For Each row In dbGrid.cDataTableCollection(0).Select
            If cPONo = "" Then
                cPONo = RemoveNull(row!PoNo, "")
            End If

            If RemoveNull(row!PoNo, "") <> cPONo Then
                MsgBox("Invoice Can Only be Generated of One Po at a Time")
                Exit Sub

            End If
            row!Amount = row!Qty * row!Rate

            If RemoveNull(row!Amount, 0) <> 0 And RemoveNull(row!DiscPer, 0) <> 0 Then
                row!DiscAmount = Math.Round(row!Amount * (row!DiscPer / 100), 2)
            Else
                row!DiscAmount = 0
            End If

            row!GrossAmount = RemoveNull(row!Amount, 0) - RemoveNull(row!DiscAmount, 0)

            If RemoveNull(row!GrossAmount, 0) <> 0 And RemoveNull(row!SalesTaxPer, 0) <> 0 Then
                row!SalesTaxAmount = Math.Round(row!GrossAmount * (row!SalesTaxPer / 100), 2)
            Else
                row!SalesTaxAmount = 0
            End If

            row!NetAmount = row!Amount - row!DiscAmount + row!SalesTaxAmount
        Next

        Call Totals()

        If txtBillNo.Text = "" Then
            txtBillNo.Text = NextSerial("BillNo", "tblPurBillProductMst", "000000", "PBP-", "")

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblPurBillProductMst", "BillNo = '" & txtBillNo.Text & "'")
        Query.AddFields("BillNo", txtBillNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("BillDate", txtBillDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Description", txtDescription.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("BillType", "L", ActionQueryBuilder.DataType.aString)
        Query.AddFields("GrossAmount", txtGrossAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("SalesTax", txtSalesTax.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Discount", txtDiscount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("AddOther", txtAddOther.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("LessOther", txtLessOther.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("NetAmount", txtNetAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("AddOtherAccount", cmbAddOtherAccount.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("LessOtherAccount", cmbLessOtherAccount.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("InvoiceNo", txtInvoiceNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("InvoiceDate", txtInvoiceDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)

        Query.AddFields("Supplier", cmbSupplier.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("SupplierAccount", cmbSupplierAccount.SelectedValue, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)

            AddInfo(txtBillNo.Text, "Add Record Local Bill Product Supplier Name " + "" + cmbSupplier.Text)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)

            EditInfo(txtBillNo.Text, "Add Record Local Bill Product Supplier Name " + "" + cmbSupplier.Text)
        End If

        dbGrid.SetCriteria = "BillNo = '" & txtBillNo.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("BillNo", txtBillNo.Text)
        dbGrid.Update()

        db = New dbOperations("Select * From tblDefaults Where CompanyId = '0001'")

        Dim cAccruedFinish As String
        Dim cDiscAccount As String

        dr = db.dbSelectQuery


        If dr.HasRows = True Then
            dr.Read()

            cAccruedFinish = RemoveNull(dr!AccruedProduct, "")
            cDiscAccount = RemoveNull(dr!DiscAccount, "")
            cRoundingAccount = RemoveNull(dr!RoundingAccount, "")
        End If

        db.Close()
        dr.Close()

        cVoucherNo = GenerateJV(txtBillNo.Text, txtBillDate.Value, txtDescription.Text, cmbSupplierAccount.SelectedValue)

        Dim cDiffAmount As Double
        Dim cGRNAmount As Double

        Dim cPurRateVariance As Double

        Dim cDescription As String


        cSql = "Select Sum(Case When Qty <= GRNQty Then Qty Else GRNQty End * GRNRate) as GRNAmount,Sum(DiffAmount) as DiffAmount,isnull(tblDefaults.PurRateVariance,0) as PurRateVariance  From tblPurBillProductDtl,tblDefaults Where  BillNo = '" & txtBillNo.Text & "'  Group By tblDefaults.PurRateVariance"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            cDiffAmount = RemoveNull(dr!DiffAmount, 0)
            cGRNAmount = RemoveNull(dr!GRNAmount, 0)
            cPurRateVariance = RemoveNull(dr!PurRateVariance, 0)
        End If

        dr.Close()
        db.Close()

        cDescription = "Supplier : " + cmbSupplier.Text + " " + txtDescription.Text

        If RemoveNull(cDiffAmount, 0) > 0 Then
            GenerateJvDetails(cVoucherNo, cPurRateVariance, cDescription, txtBillNo.Text, txtBillDate.Value, cDiffAmount, 0, "", cDefaultSector, GLConString)
        ElseIf RemoveNull(cDiffAmount, 0) < 0 Then
            GenerateJvDetails(cVoucherNo, cPurRateVariance, cDescription, txtBillNo.Text, txtBillDate.Value, 0, cDiffAmount * -1, "", cDefaultSector, GLConString)
        End If

        GenerateJvDetails(cVoucherNo, cAccruedFinish, cDescription, txtBillNo.Text, txtBillDate.Value, cGRNAmount, 0, "", cDefaultSector, GLConString)

        If CDec(tdbGridBillDetail.Columns("SalesTaxAmount").FooterText) > 0 Then
            GenerateJvDetails(cVoucherNo, cSalesTaxAccount, cDescription, txtBillNo.Text, txtBillDate.Value, CDec(tdbGridBillDetail.Columns("SalesTaxAmount").FooterText), 0, "", cDefaultSector, GLConString)
        End If

        If CDec(tdbGridBillDetail.Columns("DiscAmount").FooterText) > 0 Then
            GenerateJvDetails(cVoucherNo, cDiscAccount, cDescription, txtBillNo.Text, txtBillDate.Value, 0, CDec(tdbGridBillDetail.Columns("DiscAmount").FooterText), "", cDefaultSector, GLConString)
        End If

        If txtAddOther.Value > 0 Then
            GenerateJvDetails(cVoucherNo, cmbAddOtherAccount.SelectedValue, cDescription, txtBillNo.Text, txtBillDate.Value, txtAddOther.Value, 0, "", cDefaultSector, GLConString)
        End If

        If txtLessOther.Value > 0 Then
            GenerateJvDetails(cVoucherNo, cmbLessOtherAccount.SelectedValue, cDescription, txtBillNo.Text, txtBillDate.Value, 0, txtLessOther.Value, "", cDefaultSector, GLConString)
        End If

        GenerateJvDetails(cVoucherNo, cmbSupplierAccount.SelectedValue, cDescription, txtBillNo.Text, txtBillDate.Value, 0, txtNetAmount.Value, "", cDefaultSector, GLConString)

        Call BalanceVoucher(cVoucherNo, cRoundingAccount, "", txtInvoiceNo.Text, txtInvoiceDate.Value, cDefaultSector)

        If MsgBox("Do You Want to See the Corresponding Voucher", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim Query As New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtBillNo.Text & "'", GLConString)
            dr = Query.dbSelectQuery()
            If dr.Read() Then
                Call frmMain.frmJvShow(dr!VoucherNo)
            End If
            Query.Close()
            dr.Close()
        End If

        db = New dbOperations("Delete From tblBills Where BillNo = '" & txtBillNo.Text & "'", GLConString)
        db.dbActionQuery()
        db.Close()

        db = New dbOperations("Insert Into tblBills(AccountCode,BillNo,BillDate,BillAmount,DueDate,InvNo) Values('" & cmbSupplierAccount.SelectedValue & "','" & txtBillNo.Text & "','" & txtBillDate.Value & "','" & txtNetAmount.Value & "','" & txtBillDate.Value & "','" & cPONo & "')", GLConString)
        db.dbActionQuery()
        db.Close()


        db = New dbOperations("Update tblPurBillProductMst Set VoucherNo = '" & cVoucherNo & "' Where Billno = '" & txtBillNo.Text & "'")
        db.dbActionQuery()

        Call ClearControls()
        Call SetControls(Actions.Initial)

    End Sub



    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cBillNo As String
        Dim cSql As String

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Field Cannot Left Blank ")
            Exit Sub
        End If

        cSql = "Select tblProjectFile.Name as Project , Mst.BillNo,Mst.VoucherNo,BillDate,Cast(DatePart(Year,BillDate) as Varchar(4)) + '-' + Right('0' + Cast(DatePart(Month,BillDate) as Varchar(2)),2) as BillMonth,Dtl.PONo,Dtl.GRNNo,InvoiceNo,InvoiceDate,tblSupplier.Name as Supplier,ProductName,Qty,Dtl.Rate,Amount "
        cSql = cSql + "From tblPurBillProductMst Mst,tblSupplier,tblProductMaster,tblPurBillProductDtl Dtl,tblProjectFile "
        cSql = cSql + "Where Mst.BillNo = Dtl.BillNo "
        cSql = cSql + "And   Mst.Supplier = tblSupplier.Code "
        cSql = cSql + "And   Dtl.ProductCode = tblProductMaster.ProductCode "
        cSql = cSql + "And   Mst.Project = Dtl.Project "
        cSql = cSql + "And   Mst.Project = tblProjectFile.Code "
        cSql = cSql + "And   Mst.BillType = 'L' "
        cSql = cSql + "And   Mst.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   Mst.BillDate Between '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "' "
        cSql = cSql + "Order By Mst.BillNo,ProductName "

        cBillNo = ShowList(cSql, "List of Bill Product", 0, 0, "Qty,Amount")

        txtBillNo.Text = cBillNo

        If cBillNo <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub tdbGridBillDetail_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridBillDetail.AfterColUpdate
        tdbGridBillDetail.Columns("Amount").Value = RemoveNull(tdbGridBillDetail.Columns("Qty").Value, 0) * RemoveNull(tdbGridBillDetail.Columns("Rate").Value, 0)

        Dim cDiffAmount As Double = 0

        Dim cGRNAmount As Double = 0
        Dim cInvAmount As Double = 0

        If RemoveNull(tdbGridBillDetail.Columns("Qty").Value, 0) < RemoveNull(tdbGridBillDetail.Columns("GRNQty").Value, 0) Then
            cDiffAmount = RemoveNull(tdbGridBillDetail.Columns("Rate").Value, 0) * (RemoveNull(tdbGridBillDetail.Columns("Qty").Value, 0) - RemoveNull(tdbGridBillDetail.Columns("GRNQty").Value, 0))
        ElseIf RemoveNull(tdbGridBillDetail.Columns("Qty").Value, 0) > RemoveNull(tdbGridBillDetail.Columns("GRNQty").Value, 0) And RemoveNull(tdbGridBillDetail.Columns("Rate").Value, 0) < RemoveNull(tdbGridBillDetail.Columns("GRNRate").Value, 0) Then
            cDiffAmount = RemoveNull(tdbGridBillDetail.Columns("Rate").Value, 0) * (RemoveNull(tdbGridBillDetail.Columns("Qty").Value, 0) - RemoveNull(tdbGridBillDetail.Columns("GRNQty").Value, 0))
        Else
            cGRNAmount = RemoveNull(tdbGridBillDetail.Columns("GRNQty").Value, 0) * RemoveNull(tdbGridBillDetail.Columns("GRNRate").Value, 0)
            cInvAmount = RemoveNull(tdbGridBillDetail.Columns("Qty").Value, 0) * RemoveNull(tdbGridBillDetail.Columns("Rate").Value, 0)
            cDiffAmount = cInvAmount - cGRNAmount
        End If

        tdbGridBillDetail.Columns("DiffAmount").Value = cDiffAmount

        If RemoveNull(tdbGridBillDetail.Columns("DiscPer").Value, 0) > 0 Then
            tdbGridBillDetail.Columns("DiscAmount").Value = (RemoveNull(tdbGridBillDetail.Columns("Amount").Value, 0) * (tdbGridBillDetail.Columns("DiscPer").Value / 100))
        End If

        tdbGridBillDetail.Columns("GrossAmount").Value = RemoveNull(tdbGridBillDetail.Columns("Amount").Value, 0) - RemoveNull(tdbGridBillDetail.Columns("DiscAmount").Value, 0)

        If RemoveNull(tdbGridBillDetail.Columns("SalesTaxPer").Value, 0) > 0 Then
            tdbGridBillDetail.Columns("SalesTaxAmount").Value = (RemoveNull(tdbGridBillDetail.Columns("GrossAmount").Value, 0) * (tdbGridBillDetail.Columns("SalesTaxPer").Value / 100))
        End If

        tdbGridBillDetail.Columns("NetAmount").Value = RemoveNull(tdbGridBillDetail.Columns("GrossAmount").Value, 0) + RemoveNull(tdbGridBillDetail.Columns("SalesTaxAmount").Value, 0)

        Call Totals()
    End Sub

    Private Sub tdbGridBillDetail_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridBillDetail.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridBillDetail.RowCount > 0 Then
                tdbGridBillDetail.Delete()
                Call Totals()
            End If
        End If
    End Sub

    Private Sub txtLessOther_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLessOther.LostFocus
        Call Totals()
    End Sub

    Private Sub txtAddOther_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddOther.LostFocus
        Call Totals()
    End Sub

    Private Sub cmdPickArticle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickArticle.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Select Project First !!!")
            cmbProject.Focus()
            Exit Sub
        End If

        If cmbSupplier.SelectedValue = "" Then
            MsgBox("Select Supplier First !!!")
            cmbSupplier.Focus()
            Exit Sub
        End If

        Dim cSql As String

        cSql = "Select PoNo,ProductBillBalance.GrnNo,Max(GRNDate) as GRNDate,ProductName,Sum(GRNQty) as GRNQty,Sum(BillQty) as BillQty,Sum(GRNQty - BillQty) as BalQty,Max(Rate) as Rate,Sum(GRNQty - BillQty) * Max(Rate) as Amount,ProductCode,Location,Max(IsNull(GSTCode,'')) as GSTCode,Max(IsNull(DiscPer,0)) as DiscPer,Max(IsNull(WithoutGST,0)) as WithoutGST,Project "
        cSql = cSql + "From ProductBillBalance,tblSupplier "
        cSql = cSql + "Where ProductBillBalance.Supplier =  '" & cmbSupplier.SelectedValue & "' "
        cSql = cSql + "And   ProductBillBalance.Supplier = tblSupplier.Code "
        cSql = cSql + "And   ProductBillBalance.Project ='" & cmbProject.SelectedValue & "' "
        cSql = cSql + "Group By PoNo,ProductBillBalance.GRNNo,ProductName,Project,ProductCode,Location Having Sum(GRNQty) - Sum(BillQty) <> 0 "
        cSql = cSql + "And Max(ProductBillBalance.GRNDate) <= '" & Format(txtInvoiceDate.Value, "MM/dd/yyyy") & "'"

        Dim dt As DataTable = ShowListMulti(cSql, "List of Product")

        If dt.Rows.Count > 0 Then
            For Each Row As DataRow In dt.Rows
                Dim newRow As DataRow = dbGrid.cDataTable.NewRow
                newRow("BillNo") = txtBillNo.Text
                newRow("GRNNo") = Row!GRNNo
                newRow("PoNo") = Row!PoNo
                newRow("ProductCode") = Row!ProductCode
                newRow("Qty") = Row!BalQty
                newRow("GrnQty") = Row!BalQty
                newRow("Rate") = Row!Rate
                newRow("GRNRate") = Row!Rate
                newRow("Amount") = Row!Rate * Row!BalQty
                newRow("GRNAmount") = Row!Rate * Row!BalQty
                newRow("DiffAmount") = 0
                newRow("Project") = Row!Project
                newRow("DiscPer") = RemoveNull(Row!DiscPer, 0)

                If RemoveNull(Row!DiscPer, 0) > 0 And RemoveNull(Row!Amount, 0) > 0 Then
                    newRow("DiscAmount") = RemoveNull(Row!Amount, 0) * (Row!DiscPer / 100)
                Else
                    newRow("DiscAmount") = 0
                End If

                newRow("GrossAmount") = newRow("Amount") - newRow("DiscAmount")

                Dim cGSTCode As String

                cGSTCode = RemoveNull(Row!GSTCode, "")

                If RemoveNull(Row!WithoutGST, 0) = 1 Then
                    newRow("SalesTaxPer") = 0
                    newRow("SalesTaxAmount") = 0
                Else
                    If cGSTCode = "" Then
                        MsgBox("GST Code Not Mapped in Selected Product") '
                        Exit Sub
                    End If

                    Dim cSalesTaxPer As Double = 0

                    'cSql = "Select * From tblGSTSetupDtl Where Code = '" & cGSTCode & "' and '" & Format(txtInvoiceDate.Value, "MM/dd/yyyy") & "' Between DateFrom and DateTo "

                    'db = New dbOperations(cSql)
                    'dr = db.dbSelectQuery

                    'If dr.HasRows = True Then
                    '    dr.Read()

                    '    cSalesTaxPer = RemoveNull(dr!SalesTaxPer, 0)
                    'Else
                    '    MsgBox("Sales Tax % Not Found for the selected Period")
                    '    Exit Sub
                    'End If

                    'dr.Close()
                    'db.Close()

                    newRow("SalesTaxPer") = RemoveNull(cSalesTaxPer, 0)

                    If RemoveNull(newRow("Amount"), 0) <> 0 Then
                        newRow("SalesTaxAmount") = RemoveNull(Row!BalQty * Row!Rate, 0) * (RemoveNull(cSalesTaxPer, 0) / 100)
                    Else
                        newRow("SalesTaxAmount") = 0
                    End If
                End If

                newRow("NetAmount") = Math.Round((Row!Rate * Row!BalQty) - newRow("DiscAmount") + newRow("SalesTaxAmount"), 2)
                newRow("Location") = Row!Location

                Try : dbGrid.cDataTable.Rows.Add(newRow)
                Catch ex As Exception : MsgBox("Record is Already Selected.", MsgBoxStyle.Information) : End Try
            Next
        End If

        Call Totals()
    End Sub

    Private Sub cmbSupplier_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbSupplier.LostFocus, cmbProject.LostFocus
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If cmbSupplier.SelectedValue <> "" Then
            db = New dbOperations("Select * From tblSupplier Where Code = '" & cmbSupplier.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cmbSupplierAccount.SelectedValue = RemoveNull(dr!SupplierAccount, "")
            End If

            db.Close()
            dr.Close()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Dim cSql As String
        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptPurchaseBillProduct

        cSql = "Select	Mst.BillNo,Mst.BillDate,tblSupplier.Name as SupplierName,"
        cSql = cSql + "Mst.InvoiceNo,Mst.InvoiceDate,Mst.Description,"
        cSql = cSql + "Dtl.PoNo,Dtl.GRNNo,GroupProduct.ProductName as GroupProduct,"
        cSql = cSql + "tblProductMaster.ProductName + '-' + Ltrim(Rtrim(IsNull(tblColor.Name,''))) + '-' + Sizes as ProductName,tblProductMaster.UoM,"
        cSql = cSql + "Dtl.Qty, Dtl.Rate, Dtl.Amount, Mst.SalesTax, Mst.Excise, Mst.AddOther, Mst.LessOther, Mst.NetAmount, Mst.AdvanceTax "
        cSql = cSql + "From	tblPurBillProductMst Mst,tblPurBillProductDtl Dtl Left Outer Join tblColor On tblColor.Code = Dtl.Color,tblProductMaster GroupProduct,tblProductMaster,tblSupplier "
        cSql = cSql + "Where Mst.BillNo = Dtl.BillNo "
        cSql = cSql + "And		Mst.Supplier = tblSupplier.Code "
        cSql = cSql + "And		GroupProduct.ProductCode = tblProductMaster.GroupProduct "
        cSql = cSql + "And		Dtl.ProductCode = tblProductMaster.ProductCode "
        cSql = cSql + "And      Mst.BillNo = '" & txtBillNo.Text & "' "
        cSql = cSql + "Order BY GroupProduct.ProductName"

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "GRNFabric")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("GRNFabric")
        rReport.fldCompany.Text = cCompanyName
        rReport.fldTitle.Text = "PURCHASE BILL Product"
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        fPreview.Show()
        rReport.Run(True)
        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub tdbGridBillDetail_Click(sender As Object, e As EventArgs) Handles tdbGridBillDetail.Click

    End Sub

    Private Sub cmdVoucher_Click(sender As Object, e As EventArgs) Handles cmdVoucher.Click
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtBillNo.Text & "'", GLConString)
        dr = db.dbSelectQuery()

        If dr.Read() Then
            Call frmMain.frmJvShow(dr!VoucherNo)
        End If

        db.Close()
        dr.Close()
    End Sub
End Class
