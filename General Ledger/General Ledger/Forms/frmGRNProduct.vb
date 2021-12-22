Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmGRNProduct
    Dim dbGrid As BindGrid

    Dim Query As New ActionQueryBuilder

    Enum Actions
        Initial
        Edit
        Entry
    End Enum

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmGRNFabirc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call SetControls(Actions.Initial)
        Call ClearControls()
        Call FillCombo()

        txtDateFrom.Value = DateFrom
        txtDateTo.Value = DateTo
    End Sub

    Sub FillCombo()
        Dim Supplier As New BindCombo(cmbSupplier, "Select Code,Name From tblSupplier Order By Name", "Name", "Code", True, True)
        Dim Product As New BindCombo(tdbProduct, "Select ProductCode,ProductName as ProductName From tblProductMaster", "ProductName", "ProductCode", True)
        Dim UoM As New BindCombo(tdbUoM, "Select ProductCode,UoM From tblProductMaster Order By UoM", "UoM", "ProductCode", True)
        Dim Location As New BindCombo(tdbLocation, "Select LocationCode,LocationName From tblLocation  Order By LocationName", "LocationName", "LocationCode", True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile Order BY Name", "Name", "Code", True, True)
        Dim cBlock As New BindCombo(cmbBlock, "Select Code,Name From tblBlock Order By Name", "Name", "Code", True, True)
        Dim cLevel As New BindCombo(cmbLevel, "Select Code,Name From tblLevel Order By Name", "Name", "Code", True, True)
    End Sub

    Sub ClearControls()
        txtGRNNo.Text = ""
        txtEntryDate.Value = Today.Date
        txtGRNDate.Value = Nothing
        txtDCNo.Text = ""

        cmbSupplier.SelectedValue = ""
        cmbProject.SelectedValue = ""

        tdbGridGRNDetail.DataSource = Nothing
        txtDescription.Text = ""
        tdbGridGRNDetail.Columns("Qty").FooterText = ""
        tdbGridGRNDetail.Columns("Amount").FooterText = ""
        cmbLevel.SelectedValue = ""
        cmbBlock.SelectedValue = ""

        txtEntryUser.Text = ""
        txtGRNUser.Text = ""
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtGRNNo.Enabled = True
                txtEntryDate.Enabled = False
                txtGRNDate.Enabled = False
                txtDCNo.Enabled = False
                cmbProject.Enabled = False
                cmbLevel.Enabled = False
                cmbBlock.Enabled = False
                cmbSupplier.Enabled = False

                tdbGridGRNDetail.Splits(0).Locked = True
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtGRNNo.Enabled = False
                txtEntryDate.Enabled = False
                txtGRNDate.Enabled = False
                txtDCNo.Enabled = False
                cmbProject.Enabled = False
                cmbSupplier.Enabled = False
                cmbLevel.Enabled = False
                cmbBlock.Enabled = False
                tdbGridGRNDetail.Splits(0).Locked = True
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtGRNNo.Enabled = False
                txtEntryDate.Enabled = True
                txtGRNDate.Enabled = True
                txtDCNo.Enabled = True
                cmbProject.Enabled = True
                cmbSupplier.Enabled = True
                cmbLevel.Enabled = True
                cmbBlock.Enabled = True
                tdbGridGRNDetail.Splits(0).Locked = False

                'tdbGridGRNDetail.Splits(0).DisplayColumns("Qty").Locked = True
                'tdbGridGRNDetail.Splits(0).DisplayColumns("RejectQty").Locked = True
                'tdbGridGRNDetail.Splits(0).DisplayColumns("ExcessShort").Locked = True
                'tdbGridGRNDetail.Splits(0).DisplayColumns("ChallanQty").Locked = False
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

                cmdVendorList.Enabled = False
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

                cmdVendorList.Enabled = False
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

                cmdVendorList.Enabled = True
                cmdPrint.Enabled = False
                cmdVoucher.Enabled = False
        End Select
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "GRN PRODUCT") = -1 Then

            If RemoveNull(txtGRNDate.Value, txtEntryDate.Value) < Format(DateFrom, "MM/dd/yyy") Or RemoveNull(txtGRNDate.Value, txtEntryDate.Value) > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Edit Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            cmbSupplier.Enabled = False
            cmdVendorList.Enabled = False

            Call SetButtons(Actions.Entry)

            If txtGRNUser.Text = "" Then
                txtGRNDate.Value = Today.Date
                txtGRNUser.Text = UserId
            End If

            tdbGridGRNDetail.Splits(0).Locked = False
            tdbGridGRNDetail.Splits(0).DisplayColumns("ChallanQty").Locked = True
            tdbGridGRNDetail.Splits(0).DisplayColumns("Qty").Locked = False
            tdbGridGRNDetail.Splits(0).DisplayColumns("RejectQty").Locked = False
            tdbGridGRNDetail.Splits(0).DisplayColumns("ExcessShort").Locked = False
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "GRN PRODUCT") = -1 Then
            If RemoveNull(txtGRNDate.Value, txtEntryDate.Value) < Format(DateFrom, "MM/dd/yyy") Or RemoveNull(txtGRNDate.Value, txtEntryDate.Value) > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Delete Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim db As dbOperations

                db = New dbOperations("Delete From tblJVDtl Where VoucherNo In (Select VoucherNo From tblJVMst Where InvoiceNo = '" & txtGRNNo.Text & "')", GLConString)
                db.dbActionQuery()
                db.Close()

                db = New dbOperations("Delete From tblJvMst Where InvoiceNo = '" & txtGRNNo.Text & "'", GLConString)
                db.dbActionQuery()
                db.Close()

                Query = New ActionQueryBuilder

                dbGrid.SetCriteria = "GRNNo = '" & txtGRNNo.Text & "'"
                dbGrid.Delete()

                Query.Refresh()
                Query.SetQueryInformation("tblGRNProductMst", "GRNNo = '" & txtGRNNo.Text & "'")
                Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete)

                DeleteInfo(txtGRNNo.Text, "Delete Record GRN Product Supplier Name " + "" + cmbSupplier.Text)

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdVendorList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVendorList.Click
        cmbSupplier.SelectedValue = ShowList("Select tblSupplier.Code,tblSupplier.Name From tblSupplier Order By tblSupplier.Code", "List of Suppliers", 1, 0)
    End Sub

    Sub DisplayRec()
        If txtGRNNo.Text <> "" Then
            Dim db As New dbOperations("Select * From tblGRNProductMst Where GRNNo = '" & txtGRNNo.Text & "'")
            Dim dr As SqlDataReader

            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                txtGRNNo.Text = dr!GRNNo

                txtEntryDate.Value = RemoveNull(dr!EntryDate, Today.Date)
                txtEntryUser.Text = RemoveNull(dr!EntryUser, "")
                txtGRNUser.Text = RemoveNull(dr!GRNUser, "")
                cmbProject.SelectedValue = RemoveNull(dr!Project, "")
                cmbLevel.SelectedValue = RemoveNull(dr!Level, "")
                cmbBlock.SelectedValue = RemoveNull(dr!Block, "")

                If txtGRNUser.Text <> "" Then
                    txtGRNDate.Value = RemoveNull(dr!GRNDate, "")
                End If

                cmbSupplier.SelectedValue = dr!Supplier
                txtDescription.Text = RemoveNull(dr!Description, "")
                txtDCNo.Text = RemoveNull(dr!DCNo, "")

                Call SetControls(Actions.Edit)
                Else
                    MsgBox("Invalid GRN Number")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If

        dbGrid = New BindGrid(tdbGridGRNDetail, "Select Project,GRNNo,PoNo,ProductCode,Qty,Rate,Amount,Location,PoQty,ChallanQty,RejectQty,ExcessShort,RejectStore From tblGRNProductDtl Where GRNNo = '" & txtGRNNo.Text & "'")

        Call Totals()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "GRN PRODUCT") = -1 Then
            Call DisplayRec()

            txtEntryUser.Text = UserId
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cAdd As Boolean

        'If RemoveNull(txtGRNDate.Value, "1/1/2000") <> "1/1/2000" Then
        '    If txtEntryDate.Value > txtGRNDate.Value Then
        '        MsgBox("GRN Date Cannot be Less then that of Challan Date")
        '        Exit Sub
        '    End If
        'End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Select Project first !!!! ")
            cmbProject.Focus()
            Exit Sub
        End If

        If cmbLevel.SelectedValue = "" Then
            MsgBox("Please Input Level")
            cmbLevel.Focus()
            Exit Sub
        End If

        If cmbBlock.SelectedValue = "" Then
            MsgBox("Please Input Block")
            cmbBlock.Focus()
            Exit Sub
        End If

        If dbGrid.cDataTable.Rows.Count = 0 Then
            MsgBox("Must Be Enter Some Entries in Grid", vbInformation, cCompany)
            Exit Sub
        End If

        If txtGRNUser.Text <> "" Then
            If RemoveNull(txtGRNDate.Value, txtEntryDate.Value) < Format(DateFrom, "MM/dd/yyy") Or RemoveNull(txtGRNDate.Value, txtEntryDate.Value) > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Save Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If
        End If

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            If RemoveNull(row!Location, "") = "" Then
                MsgBox("Location Cannot be Left Blank")
                Exit Sub
            End If

            If RemoveNull(row!Qty, 0) + RemoveNull(row!RejectQty, 0) + RemoveNull(row!ExcessShort, 0) > 0 Then
                If RemoveNull(row!Qty, 0) + RemoveNull(row!RejectQty, 0) + RemoveNull(row!ExcessShort, 0) <> RemoveNull(row!ChallanQty, 0) Then
                    MsgBox("Challan Qty Must be Equal to the breakup of Accept + Reject + Excess Qty")
                    Exit Sub
                End If
            End If

            If RemoveNull(row!ChallanQty, 0) > RemoveNull(row!POQty, 0) Then
                MsgBox("Challan Qty Cannot be Greater Then That of PO Qty")
                Exit Sub
            End If

            If RemoveNull(row!Qty, 0) > RemoveNull(row!POQty, 0) Then
                MsgBox("Accept Qty Cannot be Greater Then That of PO Qty")
                Exit Sub
            End If
        Next

        If txtGRNNo.Text = "" Then
            txtGRNNo.Text = NextSerial("GRNNo", "tblGRNProductMst", "000000", "GRP-", "")

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblGRNProductMst", "GRNNo = '" & txtGRNNo.Text & "'")
        Query.AddFields("GRNNo", txtGRNNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("EntryDate", txtEntryDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("EntryUser", txtEntryUser.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)

        If txtGRNUser.Text <> "" Then
            Query.AddFields("GRNDate", txtGRNDate.Value, ActionQueryBuilder.DataType.aDate)
            Query.AddFields("GRNUser", txtGRNUser.Text, ActionQueryBuilder.DataType.aString)
        End If

        Query.AddFields("Supplier", cmbSupplier.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Description", txtDescription.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("DCNo", txtDCNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Level", cmbLevel.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Block", cmbBlock.SelectedValue, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)

            AddInfo(txtGRNNo.Text, "Add Record GRN Product Supplier Name " + "" + cmbSupplier.Text)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)

            EditInfo(txtGRNNo.Text, "Edit Record GRN Product Supplier Name " + "" + cmbSupplier.Text)
        End If

        dbGrid.SetCriteria = "GRNNo = '" & txtGRNNo.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("GRNNo", txtGRNNo.Text)
        dbGrid.Update()

        If MsgBox("Do You want to Print the GRN", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call Print()
        End If

        If CDec(RemoveNull(tdbGridGRNDetail.Columns("Amount").FooterText, 0)) > 0 Then
            Dim cProductStock As String
            Dim cAccrualProduct As String

            'Dim db As New dbOperations("Select * From tblDefaults Where CompanyId = '0001'")
            'Dim dr As SqlDataReader

            'dr = db.dbSelectQuery

            'If dr.HasRows = True Then
            '    dr.Read()

            '    cProductStock = dr!ProductStock
            '    cAccrualProduct = dr!AccruedProduct
            'End If

            'dr.Close()
            'db.Close()

            Dim cSupplierAccount As String

            If cmbSupplier.SelectedValue <> "" Then
                db = New dbOperations("Select * From tblSupplier Where Code = '" & cmbSupplier.SelectedValue & "'")
                dr = db.dbSelectQuery

                If dr.HasRows Then
                    dr.Read()

                    cSupplierAccount = RemoveNull(dr!SupplierAccount, "")
                End If

                db.Close()
                dr.Close()
            End If

            cSql = "Select PONo,tblProductMaster.ProductAccount,Sum(Qty * tblGRNProductDtl.Rate) as Amount,Sum((IsNull(RejectQty,0) + IsNull(ExcessShort,0)) * tblGRNProductDtl.Rate) as RejectAmount From tblGRNProductDtl,tblProductMaster Where GrnNo = '" & txtGRNNo.Text & "' and tblProductMaster.ProductCode = tblGRNProductDtl.ProductCode Group by tblProductMaster.ProductAccount,PONo"

            db = New dbOperations(cSql)
            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                cVoucherNo = GenerateJV(txtGRNNo.Text, txtGRNDate.Value, "Product Stock Debited against Receiving of Product From " + cmbSupplier.SelectedText, cSupplierAccount)

                While dr.Read()
                    If RemoveNull(dr!Amount, 0) <> 0 Then
                        GenerateJvDetails(cVoucherNo, RemoveNull(dr!ProductAccount, ""), "Product Stock Debited against Receiving of Product From " + cmbSupplier.Text + " Against PO # " + RemoveNull(dr!PONO, ""), txtGRNNo.Text, txtGRNDate.Value, dr!Amount, 0, "", cDefaultSector, GLConString, "", "", "")
                        GenerateJvDetails(cVoucherNo, RemoveNull(cAccrualProduct, ""), "Product Stock Debited against Receiving of Product From " + cmbSupplier.Text + " Against PO # " + RemoveNull(dr!PONO, ""), txtGRNNo.Text, txtGRNDate.Value, 0, dr!Amount, "", cDefaultSector, GLConString, "", "", "")
                    End If
                End While

                dr.Close()
                db.Close()
            End If

            If MsgBox("Do You Want to See the Corresponding Voucher", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtGRNNo.Text & "'", GLConString)

                dr = db.dbSelectQuery()
                If dr.Read() Then
                    Call frmMain.frmJvShow(dr!VoucherNo)
                End If
                db.Close()
                dr.Close()
            End If

            db = New dbOperations("Update tblGRNProductMst Set VoucherNo = '" & cVoucherNo & "' Where GRNNo = '" & txtGRNNo.Text & "'")
            db.dbActionQuery()
        End If

        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cGRNNo As String
        Dim cSql As String


        cSql = "Select tblProjectFile.Name as ProjectName,Mst.GRNNo,Mst.VoucherNo,GRNDate,tblSupplier.Name as Supplier,Dtl.PoNo,tblProductMaster.SourceCode,tblProductMaster.ProductName,Qty,Dtl.Rate,Amount "
        cSql = cSql + "From tblGRNProductMst Mst,tblSupplier,tblProductMaster,tblGRNProductDtl Dtl,tblProjectFile "
        cSql = cSql + "Where Mst.GRNNo = Dtl.GRNNo "
        cSql = cSql + "And   Mst.Supplier = tblSupplier.Code "
        cSql = cSql + "And   Dtl.ProductCode= tblProductMaster.ProductCode "
        cSql = cSql + "And   Mst.Project= tblProjectFile.Code "
        cSql = cSql + "And   Mst.EntryDate Between '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "' "
        cSql = cSql + "Order By Mst.GRNNo,tblProductMaster.ProductName "

        cGRNNo = ShowList(cSql, "List of GRN Product", 0, 1, "Qty,Amount", "", "", "List", "", "", "Yes", "", "Yes")

        txtGRNNo.Text = cGRNNo

        If cGRNNo <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub tdbGridOrderDetail_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridGRNDetail.AfterColUpdate
        If RemoveNull(tdbGridGRNDetail.Columns("Qty").Value, 0) > RemoveNull(tdbGridGRNDetail.Columns("PoQty").Value, 0) Then
            MsgBox("Qty cannot be greater Po Qty")
            tdbGridGRNDetail.Columns("Qty").Value = RemoveNull(tdbGridGRNDetail.Columns("POQty").Value, 0)
            Exit Sub
        End If

        tdbGridGRNDetail.Columns("Amount").Value = RemoveNull(tdbGridGRNDetail.Columns("Qty").Value, 0) * RemoveNull(tdbGridGRNDetail.Columns("Rate").Value, 0)

        Call Totals()
    End Sub

    Private Sub tdbGridOrderDetail_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridGRNDetail.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridGRNDetail.RowCount > 0 Then
                tdbGridGRNDetail.Delete()
            End If
        End If
    End Sub

    Sub Totals()
        Dim cTotalQty As Double
        Dim cTotalAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalQty += Convert.ToDouble(RemoveNull(row("Qty"), 0))
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
        Next

        tdbGridGRNDetail.Columns("Qty").FooterText = Format(cTotalQty, "###,###,##0.00")
        tdbGridGRNDetail.Columns("Amount").FooterText = Format(cTotalAmount, "###,###,##0.00")
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call Print()
    End Sub

    Sub Print()
        Dim cSql As String
        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptGRNProduct

        cSql = "Select * From GRNProduct "
        cSql = cSql + "Where GRNNo = '" & txtGRNNo.Text & "'"

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "GRNProduct")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("GRNProduct")
        rReport.fldCompany.Text = cCompanyName
        rReport.fldTitle.Text = "GRN Product"
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        fPreview.Show()
        rReport.Run(True)
        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub chkInspection_CheckedChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub cmdPending_Click(sender As Object, e As EventArgs) Handles cmdPending.Click
        Dim cGRNNo As String
        Dim cSql As String

        cSql = "Select Mst.GRNNo,Mst.VoucherNo,GRNDate,tblSupplier.Name as Supplier,Dtl.PoNo,tblProductMaster.SourceCode,tblProductMaster.ProductName,Qty,Dtl.Rate,Amount "
        cSql = cSql + "From tblGRNProductMst Mst,tblSupplier,tblProductMaster,tblGRNProductDtl Dtl "
        cSql = cSql + "Where Mst.GRNNo = Dtl.GRNNo "
        cSql = cSql + "And   Mst.Supplier = tblSupplier.Code "
        cSql = cSql + "And   Dtl.ProductCode= tblProductMaster.ProductCode "
        cSql = cSql + "And   IsNull(Dtl.Qty,0) + IsNull(Dtl.RejectQty,0) + IsNull(Dtl.ExcessShort,0) = 0 "
        cSql = cSql + "And   Mst.GRNDate Between '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "' "
        cSql = cSql + "Order By Mst.GRNNo,tblProductMaster.ProductName "

        cGRNNo = ShowList(cSql, "List of GRN Product", 0, 0, "Qty,Amount", "", "", "List", "", "", "Yes", "", "Yes")

        txtGRNNo.Text = cGRNNo

        If cGRNNo <> "" Then
            Call DisplayRec()
        End If

    End Sub

    Private Sub cmdInspection_Click(sender As Object, e As EventArgs) Handles cmdInspection.Click
        If CheckAccess("EditRights", UserId, "PRODUCT INSPECTION") = -1 Then
            Call SetControls(Actions.Edit)
            Call SetButtons(Actions.Entry)

            If txtGRNUser.Text = "" Then
                txtGRNDate.Value = Today.Date
                txtGRNUser.Text = UserId
            End If

            tdbGridGRNDetail.Splits(0).Locked = False
            tdbGridGRNDetail.Splits(0).DisplayColumns("ChallanQty").Locked = True
            tdbGridGRNDetail.Splits(0).DisplayColumns("Qty").Locked = False
            tdbGridGRNDetail.Splits(0).DisplayColumns("RejectQty").Locked = False
            tdbGridGRNDetail.Splits(0).DisplayColumns("ExcessShort").Locked = False
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdPickProduct_Click(sender As Object, e As EventArgs) Handles cmdPickProduct.Click
        Dim cSql As String

        If cmbSupplier.SelectedValue = "" Then
            MsgBox("Select Supplier")
            cmbSupplier.Focus()
            Exit Sub
        End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Select Project !!!")
            cmbProject.Focus()
            Exit Sub
        End If

        If cmbLevel.SelectedValue = "" Then
            MsgBox("Select lEVEL !!!")
            cmbLevel.Focus()
            Exit Sub
        End If

        If cmbBlock.SelectedValue = "" Then
            MsgBox("Select Block !!!")
            cmbLevel.Focus()
            Exit Sub
        End If

        cSql = "Select PurOrdBalanceProduct.Project,tblProjectFile.Name as ProjectName, PurOrdBalanceProduct.PoNo,PurOrdBalanceProduct.ProductCode,PurOrdBalanceProduct.ProductName,Sum(PoQty) as PoQty,Sum(GrnQty) as GrnQty,Sum(PoQty - GrnQty) as BalQty,Max(Rate) as Rate,tblProductMaster.ProductAccount,tblProductMaster.DefaultLocation "
        cSql += " From  PurOrdBalanceProduct,tblProductMaster,tblProjectFile,tblBlock,tblLevel "
        cSql += " Where PurOrdBalanceProduct.Supplier =  '" & cmbSupplier.SelectedValue & "' "
        cSql += " And   PurOrdBalanceProduct.Level =  tblLevel.Code "
        cSql += " And   PurOrdBalanceProduct.Block =  tblBlock.Code "
        cSql += " And   PurOrdBalanceProduct.Block =  '" & cmbBlock.SelectedValue & "' "
        cSql += " And   PurOrdBalanceProduct.Level =  '" & cmbLevel.SelectedValue & "' "
        cSql += " And   PurOrdBalanceProduct.ProductCode = tblProductMaster.ProductCode "
        cSql += " And   PurOrdBalanceProduct.Project = tblProjectFile.Code "
        cSql += " Group By PurOrdBalanceProduct.Project,tblProjectFile.Name,PurOrdBalanceProduct.PoNo,PurOrdBalanceProduct.ProductCode,PurOrdBalanceProduct.ProductName,tblProductMaster.ProductAccount,tblProductMaster.DefaultLocation Having Sum(PoQty) - Sum(GrnQty) > 0  And Max(PODate) <= '" & Format(txtEntryDate.Value, "MM/dd/yyyy") & "' "

        Dim dt As DataTable = ShowListMulti(cSql, "List of Product")

        If dt.Rows.Count > 0 Then
            For Each Row As DataRow In dt.Rows
                Dim newRow As DataRow = dbGrid.cDataTable.NewRow
                newRow("GRNNo") = txtGRNNo.Text
                newRow("PoNo") = Row!PoNo
                newRow("ProductCode") = Row!ProductCode
                newRow("ChallanQty") = Row!BalQty
                newRow("Qty") = 0
                newRow("RejectQty") = 0
                newRow("ExcessShort") = 0
                newRow("PoQty") = Row!BalQty
                newRow("Rate") = Row!Rate
                newRow("Amount") = 0
                newRow("Project") = Row!Project

                newRow("Location") = RemoveNull(Row!DefaultLocation, "")
                newRow("Project") = cmbProject.SelectedValue
                newRow("RejectStore") = RemoveNull(cRejectStoreProduct, "")

                If RemoveNull(Row!ProductAccount, "") = "" Then
                    MsgBox("Account Code Not Define in Product " + Row!ProductName)
                    Exit Sub
                End If

                Try : dbGrid.cDataTable.Rows.Add(newRow)
                Catch ex As Exception : MsgBox("Record is Already Selected.", MsgBoxStyle.Information) : End Try

                cmbSupplier.Enabled = False
                cmdVendorList.Enabled = False
            Next
        End If
    End Sub

    Private Sub tdbGridGRNDetail_Click(sender As Object, e As EventArgs) Handles tdbGridGRNDetail.Click

    End Sub

    Private Sub tdbProduct_Click(sender As Object, e As EventArgs) Handles tdbProduct.Click

    End Sub

    Private Sub cmdVoucher_Click(sender As Object, e As EventArgs) Handles cmdVoucher.Click
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtGRNNo.Text & "'", GLConString)
        dr = db.dbSelectQuery()

        If dr.Read() Then
            Call frmMain.frmJvShow(dr!VoucherNo)
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub txtDCNo_TextChanged(sender As Object, e As EventArgs) Handles txtDCNo.TextChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class