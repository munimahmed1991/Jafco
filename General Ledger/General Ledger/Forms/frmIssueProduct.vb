Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmIssueProduct
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
        Dim Product As New BindCombo(tdbProduct, "Select ProductCode,ProductName as ProductName From tblProductMaster", "ProductName", "ProductCode", True)
        Dim Department As New BindCombo(cmbLevel, "Select Code,Name From tblOrgDept Order By Name", "Name", "Code", True, True)
        Dim TransactionType As New BindCombo(cmbTransactionType, "Select Code,Name From tblTransactionType Order By Name", "Name", "Code", True, True)
        Dim Location As New BindCombo(tdbLocation, "Select LocationCode,LocationName From tblLocation  Order By LocationName", "LocationName", "LocationCode", True)
        Dim Sector As New BindCombo(cmbSector, "Select Code,Name From tblSector Order By Name", "Name", "Code", True, True, GLConString)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile Order BY Name", "Name", "Code", True, True)
        Dim cBlock As New BindCombo(cmbBlock, "Select Code,Name From tblBlock Order By Name", "Name", "Code", True, True)
        Dim cLevel As New BindCombo(cmbLevel, "Select Code,Name From tblLevel Order By Name", "Name", "Code", True, True)
    End Sub

    Sub ClearControls()
        txtIssNo.Text = ""
        txtIssDate.Value = Today.Date
        txtDescription.Text = ""
        cmbTransactionType.SelectedValue = ""
        cmbSector.SelectedValue = ""
        cmbLevel.SelectedValue = ""
        cmbBlock.SelectedValue = ""
        cmbProject.SelectedValue = ""

        tdbGridProductDetail.DataSource = Nothing
        tdbGridProductDetail.Columns("Qty").FooterText = ""
        tdbGridProductDetail.Columns("Amount").FooterText = ""
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtIssNo.Enabled = True
                txtIssDate.Enabled = False
                txtDescription.Enabled = False
                cmbTransactionType.Enabled = False
                cmbSector.Enabled = False
                cmbLevel.Enabled = False
                cmbBlock.Enabled = False
                tdbGridProductDetail.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtIssNo.Enabled = False
                txtIssDate.Enabled = False
                txtDescription.Enabled = False
                cmbTransactionType.Enabled = False
                cmbSector.Enabled = False
                cmbLevel.Enabled = False
                cmbBlock.Enabled = False
                tdbGridProductDetail.Enabled = True

            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtIssNo.Enabled = False
                txtIssDate.Enabled = True
                txtDescription.Enabled = True
                cmbLevel.Enabled = True
                cmbBlock.Enabled = True
                cmbTransactionType.Enabled = True
                cmbSector.Enabled = True
                tdbGridProductDetail.Enabled = True
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

                cmdVoucher.Enabled = False
                cmdPrint.Enabled = False
            Case Actions.Edit
                cmdAdd.Enabled = False
                cmdSearch.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                cmdVoucher.Enabled = True
                cmdPrint.Enabled = True
            Case Actions.Entry
                cmdAdd.Enabled = False
                cmdSearch.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                cmdVoucher.Enabled = False
                cmdPrint.Enabled = False
        End Select
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "ISSUE PRODUCT") = -1 Then

            If txtIssDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtIssDate.Value > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Edit Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "ISSUE PRODUCT") = -1 Then

            If txtIssDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtIssDate.Value > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Delete Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Query = New ActionQueryBuilder

                dbGrid.SetCriteria = "IssNo = '" & txtIssNo.Text & "'"
                dbGrid.Delete()

                Query.Refresh()
                Query.SetQueryInformation("tblIssueProductMst", "IssNo = '" & txtIssNo.Text & "'")
                Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete)

                DeleteInfo(txtIssNo.Text, "Delete Record Issue Product General Department " + "" + cmbLevel.Text)

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtIssNo.Text <> "" Then
            Dim db As New dbOperations("Select * From tblIssueProductMst Where IssNo = '" & txtIssNo.Text & "'")
            Dim dr As SqlDataReader

            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                txtIssNo.Text = dr!IssNo
                txtIssDate.Value = dr!IssDate
                txtDescription.Text = RemoveNull(dr!Description, "")
                cmbLevel.SelectedValue = RemoveNull(dr!Level, "")
                cmbBlock.SelectedValue = RemoveNull(dr!Block, "")
                cmbTransactionType.SelectedValue = RemoveNull(dr!TransactionType, "")
                cmbSector.SelectedValue = RemoveNull(dr!Sector, "")
                cmbProject.SelectedValue = RemoveNull(dr!Project, "")

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Invalid Entry Number")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If

        dbGrid = New BindGrid(tdbGridProductDetail, "Select Project,IssNo,GRNNo,ProductCode,BalQty,StockQty,Qty,Rate,Amount,Location From tblIssueProductDtl Where IssNo = '" & txtIssNo.Text & "'")
        dbGrid.SetPrimaryKey("ProductCode")

        Call Totals()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "ISSUE PRODUCT") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cAdd As Boolean

        If dbGrid.cDataTable.Rows.Count = 0 Then
            MsgBox("Must Be Enter Some Entries in Grid", vbInformation, cCompany)
            Exit Sub
        End If

        If cmbSector.SelectedValue = "" Then
            MsgBox("Sector Cannot be Left Blank")
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


        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Input Project")
            cmbProject.Focus()
            Exit Sub
        End If

        If cmbTransactionType.SelectedValue = "" Then
            MsgBox("Transaction Type Cannot be Left Blank")
            Exit Sub
        End If

        If txtIssDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtIssDate.Value > Format(DateTo, "MM/dd/yyy") Then
            MsgBox("Cannot Save Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
            Exit Sub
        End If

        If txtIssNo.Text = "" Then
            txtIssNo.Text = NextSerial("IssNo", "tblIssueProductMst", "000000", "ISP-", "")

            cAdd = True
        Else
            cAdd = False
        End If

        For Each row In dbGrid.cDataTableCollection(0).Select

            If RemoveNull(row!Qty, 0) > RemoveNull(row!StockQty, 0) Then
                MsgBox("Cannot Allocate Product more then Available in Balance")
                Exit Sub
            End If
        Next

        Query.Refresh()
        Query.SetQueryInformation("tblIssueProductMst", "IssNo = '" & txtIssNo.Text & "'")
        Query.AddFields("IssNo", txtIssNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("IssDate", txtIssDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Level", cmbLevel.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Block", cmbBlock.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Description", txtDescription.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("TransactionType", cmbTransactionType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Sector", cmbSector.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
            AddInfo(txtIssNo.Text, "Add Record Issue Product General Department " + "" + cmbLevel.Text)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
            EditInfo(txtIssNo.Text, "Edit Record Issue Product General Department " + "" + cmbLevel.Text)
        End If

        dbGrid.SetCriteria = "IssNo = '" & txtIssNo.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("IssNo", txtIssNo.Text)
        dbGrid.Update()

        If MsgBox("Do You Want to Print the Issue Challan", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call Print()
        End If

        Dim cProductStock As String

        Dim db As New dbOperations("Select * From tblDefaults Where CompanyId = '0001'")
        Dim dr As SqlDataReader

        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            cProductStock = RemoveNull(dr!ProductStock, "")
        End If

        dr.Close()
        db.Close()


        Dim cTransactionAccount As String

        If cmbTransactionType.SelectedValue <> "" Then
            db = New dbOperations("Select * From tblTransactionType Where Code = '" & cmbTransactionType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cTransactionAccount = RemoveNull(dr!Account, "")
            End If

            db.Close()
            dr.Close()
        End If

        cSql = "Select tblProductMaster.ProductAccount,Sum(Qty * tblIssueProductDtl.Rate) as Amount From tblIssueProductDtl,tblProductMaster Where IssNo = '" & txtIssNo.Text & "' and tblProductMaster.ProductCode = tblIssueProductDtl.ProductCode Group by tblProductMaster.ProductAccount"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            cVoucherNo = GenerateJV(txtIssNo.Text, txtIssDate.Value, "Product Stock Credit against " + cmbTransactionType.Text)

            While dr.Read()
                If RemoveNull(dr!Amount, 0) <> 0 Then
                    GenerateJvDetails(cVoucherNo, RemoveNull(dr!ProductAccount, ""), "Product Stock Credit against " + cmbTransactionType.Text, txtIssNo.Text, txtIssDate.Value, 0, dr!Amount, "", cmbSector.SelectedValue, GLConString, "", "", "")
                    GenerateJvDetails(cVoucherNo, cTransactionAccount, "Product Stock Credit against " + cmbTransactionType.Text, txtIssNo.Text, txtIssDate.Value, dr!Amount, 0, "", cmbSector.SelectedValue, GLConString, "", "")
                End If
            End While

            dr.Close()
            db.Close()
        End If

        If MsgBox("Do You Want to See the Corresponding Voucher", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtIssNo.Text & "'", GLConString)

            dr = db.dbSelectQuery()
            If dr.Read() Then
                Call frmMain.frmJvShow(dr!VoucherNo)
            End If
            db.Close()
            dr.Close()
        End If


        db = New dbOperations("Update tblIssueProductMst Set VoucherNo = '" & cVoucherNo & "' Where IssNo = '" & txtIssNo.Text & "'")
        db.dbActionQuery()


        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cIssNo As String
        Dim cSql As String

        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Input Project")
            cmbProject.Focus()
            Exit Sub
        End If

        cSql = " Select Mst.IssNo,Mst.VoucherNo,Mst.IssDate,tblBlock.Name As Block,tblLevel.Name As Level,tblProductMaster.ProductName,tblProductMaster.SourceCode,tblProductMaster.UoM,Qty,Sector.Name As Sector "
        cSql += " From tblProductMaster, tblIssueProductDtl Dtl, tblIssueProductMst Mst, tblBlock, tblLevel, JAFCOGl2021.dbo.tblSector Sector"
        cSql += " Where Mst.Issno = Dtl.IssNo"
        cSql += " And    Dtl.ProductCode= tblProductMaster.ProductCode  "
        cSql += " And Mst.Project = Dtl.Project"
        cSql += " And    Mst.Level =  tblLevel.Code "
        cSql += " And Mst.Block = tblBlock.Code "
        cSql += " And    Mst.Project =  '0001' "
        cSql += " And Sector.Code = Mst.Sector"
        cSql += " And   Mst.Project =  '" & cmbProject.SelectedValue & "'"
        cSql += " Order By Mst.IssNo, tblProductMaster.ProductName "

        cIssNo = ShowList(cSql, "List of Issue Product", 0, 0)

        txtIssNo.Text = cIssNo

        If cIssNo <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub tdbGridOrderDetail_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridProductDetail.AfterColUpdate
        If RemoveNull(tdbGridProductDetail.Columns("Qty").Value, 0) > RemoveNull(tdbGridProductDetail.Columns("StockQty").Value, 0) Then
            MsgBox("Qty Cannot be greater than balance qty")
            tdbGridProductDetail.Columns("Qty").Value = RemoveNull(tdbGridProductDetail.Columns("StockQty").Value, 0)
            Exit Sub
        End If


        tdbGridProductDetail.Columns("Amount").Value = RemoveNull(tdbGridProductDetail.Columns("Qty").Value, 0) * RemoveNull(tdbGridProductDetail.Columns("Rate").Value, 0)

        Call Totals()
    End Sub

    Private Sub tdbGridOrderDetail_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridProductDetail.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridProductDetail.RowCount > 0 Then
                tdbGridProductDetail.Delete()
            End If
        End If
    End Sub

    Private Sub cmdPickAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickAccessories.Click
        Dim cSql As String

        If cmbLevel.SelectedValue = "" Then
            MsgBox("Level Cannot be Left Blank")
            Exit Sub
        End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Cannot be Left Blank")
            Exit Sub
        End If

        If cmbBlock.SelectedValue = "" Then
            MsgBox("Block Cannot be Left Blank")
            Exit Sub
        End If

        cSql = "Select Project, GrnNo as GRNNo,ProductBalance.ProductName,ProductBalance.BlockName,PRoductBalance.LevelName,tblLocation.LocationName,Sum(ProductBalance.GRNQty) as GRNQty,Sum(ProductBalance.AllocQty) as AllocQty,Sum(ProductBalance.GRNQty - ProductBalance.AllocQty) as BalQty,Case When Sum(ProductBalance.GRNQty - ProductBalance.AllocQty) <> 0 and Sum(Amount) <> 0 Then Round(Sum(Amount) / Sum(ProductBalance.GRNQty - ProductBalance.AllocQty),2) Else 0 End as Rate,ProductBalance.ProductCode,ProductBalance.Location "
        cSql = cSql + "FrOm ProductBalance,tblLocation "
        cSql = cSql + "Where ProductBalance.Location = tblLocation.LocationCode "
        cSql = cSql + "And ProductBalance.Block ='" & cmbBlock.SelectedValue & "' "
        cSql = cSql + "And ProductBalance.Level = '" & cmbLevel.SelectedValue & "' "
        cSql = cSql + "And ProductBalance.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "Group By Project,GRNNo,Location,LocationName,ProductCode,ProductName,ProductBalance.BlockName,PRoductBalance.LevelName  Having Sum(GRNQty) - Sum(AllocQty) > 0 "

        Dim dt As DataTable = ShowListMulti(cSql, "List of Product")

        If dt.Rows.Count > 0 Then
            For Each Row As DataRow In dt.Rows
                Dim newRow As DataRow = dbGrid.cDataTable.NewRow
                newRow("IssNo") = txtIssNo.Text
                newRow("GRNNo") = Row!GRNNo
                newRow("ProductCode") = Row!ProductCode
                newRow("Qty") = 0
                newRow("StockQty") = Row!BalQty
                newRow("Rate") = Row!Rate
                newRow("Amount") = 0
                newRow("Location") = Row!Location
                newRow("BalQty") = Row!BalQty
                newRow("Project") = Row!Project

                Try : dbGrid.cDataTable.Rows.Add(newRow)
                Catch ex As Exception : MsgBox("Record is Already Selected.", MsgBoxStyle.Information) : End Try
            Next

        End If
        Call Totals()
    End Sub

    Sub Totals()
        Dim cTotalQty As Double
        Dim cTotalAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalQty += Convert.ToDouble(RemoveNull(row("Qty"), 0))
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
        Next

        tdbGridProductDetail.Columns("Qty").FooterText = Format(cTotalQty, "###,###,##0.00")
        tdbGridProductDetail.Columns("Amount").FooterText = Format(cTotalAmount, "###,###,##0.00")
    End Sub
    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call Print()
    End Sub

    Sub Print()
        Dim cSql As String
        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptIssueProduct

        cSql = "Select * From IssueProduct "
        cSql = cSql + "Where IssNo = '" & txtIssNo.Text & "'"

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "IssueProduct")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("IssueProduct")
        rReport.fldCompany.Text = cCompanyName
        rReport.fldTitle.Text = "ISSUE PRODUCT"
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        fPreview.Show()
        rReport.Run(True)
        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdVoucher_Click(sender As Object, e As EventArgs) Handles cmdVoucher.Click
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtIssNo.Text & "'", GLConString)
        dr = db.dbSelectQuery()

        If dr.Read() Then
            Call frmMain.frmJvShow(dr!VoucherNo)
        End If

        db.Close()
        dr.Close()
    End Sub
End Class