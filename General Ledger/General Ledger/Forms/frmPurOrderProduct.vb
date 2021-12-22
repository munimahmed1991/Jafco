Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPurOrderProduct
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

    Private Sub frmPurOrderFabirc_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call SetControls(Actions.Initial)
        Call ClearControls()
        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Supplier As New BindCombo(cmbSupplier, "Select Code,Name From tblSupplier  Order By Name", "Name", "Code", True, True)
        Dim Currency As New BindCombo(cmbCurrency, "Select Code,Name From tblCurrency Order BY Name", "Name", "Code", True, True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile Order BY Name", "Name", "Code", True, True)
        Dim Product As New BindCombo(tdbProduct, "Select ProductCode,Ltrim(Rtrim(IsNull(SourceCode,''))) + '-' + Ltrim(Rtrim(ProductName)) + '-' + UoM as ProductName From tblProductMaster where ProductLevel = 'Detail' Order by ProductName", "ProductName", "ProductCode", True)
        Dim Color As New BindCombo(tdbColor, "Select Code,Name From tblColor Order By Name", "Name", "Code", True)
        Dim cLevel As New BindCombo(cmbLevel, "Select Code,Name From tblLevel Order By Name", "Name", "Code", True, True)
        Dim PaymentTerms As New BindCombo(cmbPaymentTerms, "Select Code,Name From tblPaymentTerms Order By Name", "Name", "Code", True, True)
        Dim PackingType As New BindCombo(cmbPackingType, "Select Code,Name From tblPackingType Order By Name", "Name", "Code", True, True)
        Dim cBlock As New BindCombo(cmbBlock, "Select Code,Name From tblBlock Order By Name", "Name", "Code", True, True)
    End Sub

    Sub ClearControls()
        txtPoNo.Text = ""
        txtPoDate.Value = Today.Date
        txtDeliveryTerms.Text = ""
        txtDescription.Text = ""
        txtETD.Value = Today.Date
        txtETA.Value = Today.Date
        cmbPackingType.SelectedValue = ""
        txtSpecialInstructions.Text = ""
        txtAdvancePer.Value = 0
        txtAdvanceAmount.Value = 0
        chkWithoutGST.Checked = 0
        txtGeneratedBy.Text = ""
        lblFlag.Text = ""
        cmbPaymentTerms.SelectedValue = ""
        cmbProject.SelectedValue = ""
        chkFinalized.Checked = False
        cmbBlock.SelectedValue = ""

        chkCancel.Checked = False
        txtCancelUser.Text = ""
        txtCancelRemarks.Text = ""

        chkClosed.Checked = False
        txtCloseDate.Value = Nothing
        txtCloseUser.Text = ""

        cmbSupplier.SelectedValue = ""
        cmbCurrency.SelectedValue = ""
        cmbLevel.SelectedValue = ""

        txtManualPoNo.Text = ""
        txtGrossAmount.Value = 0
        txtDiscount.Value = 0
        txtSalesTax.Value = 0
        txtTransportationCharges.Value = 0
        txtNetAmount.Value = 0
        txtAdvancePer.Value = 0
        txtAdvanceAmount.Value = 0
        txtBalancePayment.Value = 0

        tdbGridOrderDetail.DataSource = Nothing
        cmbLocalImport.Text = "Local"

        tdbGridOrderDetail.Columns("Qty").FooterText = ""
        tdbGridOrderDetail.Columns("Amount").FooterText = ""
        tdbGridOrderDetail.Columns("DiscAmount").FooterText = ""
        tdbGridOrderDetail.Columns("SalesTaxAmount").FooterText = ""
        tdbGridOrderDetail.Columns("NetAmount").FooterText = ""
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtPoNo.Enabled = True
                txtPoDate.Enabled = False
                cmbPaymentTerms.Enabled = False
                txtDeliveryTerms.Enabled = False
                txtDescription.Enabled = False
                txtETD.Enabled = False
                txtETA.Enabled = False
                cmbPackingType.Enabled = False
                txtSpecialInstructions.Enabled = False
                txtAdvancePer.Enabled = False
                txtAdvanceAmount.Enabled = False
                txtTransportationCharges.Enabled = False
                txtGeneratedBy.Enabled = False
                chkFinalized.Enabled = False
                cmbProject.Enabled = False
                cmbBlock.Enabled = False
                txtManualPoNo.Enabled = False
                chkClosed.Enabled = False
                txtCloseDate.Enabled = False
                txtCloseUser.Enabled = False
                chkWithoutGST.Enabled = False
                cmbSupplier.Enabled = False
                cmbCurrency.Enabled = False
                cmbLevel.Enabled = False
                cmbLocalImport.Enabled = False
                tdbGridOrderDetail.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtPoNo.Enabled = False
                txtPoDate.Enabled = False
                cmbPaymentTerms.Enabled = False
                txtDeliveryTerms.Enabled = False
                txtDescription.Enabled = False
                txtETD.Enabled = False
                txtETA.Enabled = False
                cmbPackingType.Enabled = False
                txtSpecialInstructions.Enabled = False
                cmbLocalImport.Enabled = False
                txtAdvancePer.Enabled = False
                txtAdvanceAmount.Enabled = False
                txtTransportationCharges.Enabled = False
                txtGeneratedBy.Enabled = False
                chkFinalized.Enabled = False
                cmbProject.Enabled = False
                cmbBlock.Enabled = False
                chkClosed.Enabled = False
                txtCloseDate.Enabled = False
                txtCloseUser.Enabled = False
                txtManualPoNo.Enabled = False
                chkWithoutGST.Enabled = False

                chkCancel.Enabled = False
                txtCancelUser.Enabled = False
                txtCancelRemarks.Enabled = False

                cmbSupplier.Enabled = False
                cmbLevel.Enabled = False
                cmbCurrency.Enabled = False

                tdbGridOrderDetail.Enabled = True
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtPoNo.Enabled = False
                txtPoDate.Enabled = True
                cmbPaymentTerms.Enabled = True
                txtDeliveryTerms.Enabled = True
                txtDescription.Enabled = True
                txtETD.Enabled = True
                txtETA.Enabled = True
                cmbPackingType.Enabled = True
                txtSpecialInstructions.Enabled = True
                cmbLocalImport.Enabled = True
                txtAdvancePer.Enabled = True
                txtAdvanceAmount.Enabled = True
                txtTransportationCharges.Enabled = True
                txtGeneratedBy.Enabled = True
                chkFinalized.Enabled = True
                cmbProject.Enabled = True
                cmbBlock.Enabled = True
                chkClosed.Enabled = False
                txtCloseDate.Enabled = False
                txtCloseUser.Enabled = False
                txtManualPoNo.Enabled = True
                chkWithoutGST.Enabled = True

                chkCancel.Enabled = False
                txtCancelUser.Enabled = False
                txtCancelRemarks.Enabled = False

                cmbSupplier.Enabled = True
                cmbCurrency.Enabled = True
                cmbLevel.Enabled = True

                tdbGridOrderDetail.Enabled = True
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
            Case Actions.Edit
                cmdAdd.Enabled = False
                cmdSearch.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                cmdVendorList.Enabled = False
            Case Actions.Entry
                cmdAdd.Enabled = False
                cmdSearch.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                cmdVendorList.Enabled = True
        End Select
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "PURCHASE ORDER PRODUCT") = -1 Then
            If chkFinalized.Checked = True Then
                MsgBox("Entry Finalized Cannot be Edited")
                Exit Sub
            End If

            If chkCancel.Checked = True Then
                MsgBox("Cancel PO Cannot be Edited")
                Exit Sub
            End If

            If cUserType <> "A" Then
                If txtGeneratedBy.Text = UserId Then
                    MsgBox("Purchase Order Can only be Edited By User who initiated it")
                    Exit Sub
                End If
            End If

            Call SetControls(Actions.Entry)

            cmbLevel.Enabled = False
            txtPoDate.Enabled = False
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "PURCHASE ORDER PRODUCT") = -1 Then
            If txtPoDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtPoDate.Value > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Delete Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            If chkCancel.Checked = True Then
                MsgBox("Cancel PO Cannot be Edited")
                Exit Sub
            End If

            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Query = New ActionQueryBuilder

                dbGrid.SetCriteria = "PoNo = '" & txtPoNo.Text & "'"
                dbGrid.Delete()

                Query.Refresh()
                Query.SetQueryInformation("tblPurOrdProductMst", "PoNo = '" & txtPoNo.Text & "'")
                Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete)

                DeleteInfo(txtPoNo.Text, "Delete Record Purchase Order Product Supplier Name " + "" + cmbSupplier.Text)

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdVendorList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdVendorList.Click
        cmbSupplier.SelectedValue = ShowList("Select Code,Name,Address From tblSupplier order by Name ", "List of Suppliers", 1, 0)
    End Sub

    Sub DisplayRec()
        If txtPoNo.Text <> "" Then
            Dim db As New dbOperations("Select * From tblPurOrdProductMst Where PoNo = '" & txtPoNo.Text & "'")
            Dim dr As SqlDataReader

            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                txtPoNo.Text = dr!PoNO
                txtPoDate.Value = dr!PoDate
                cmbSupplier.SelectedValue = dr!Supplier
                cmbProject.SelectedValue = dr!Project
                cmbCurrency.SelectedValue = dr!Currency
                cmbPaymentTerms.SelectedValue = dr!PaymentTerms
                txtDeliveryTerms.Text = dr!DeliveryTerms
                txtDescription.Text = dr!Description
                txtGeneratedBy.Text = RemoveNull(dr!GeneratedBy, "")
                chkFinalized.Checked = RemoveNull(dr!Finalized, 0)
                txtETD.Value = dr!ETD
                txtETA.Value = dr!ETA
                cmbPackingType.SelectedValue = dr!PackingType
                txtSpecialInstructions.Text = dr!SpecialInstruction
                cmbCurrency.SelectedValue = dr!Currency
                cmbLevel.SelectedValue = RemoveNull(dr!Level, "")
                cmbBlock.SelectedValue = RemoveNull(dr!Block, "")
                chkClosed.Checked = RemoveNull(dr!Closed, 0)
                txtCloseDate.Value = RemoveNull(dr!ClosedDate, Nothing)
                txtCloseUser.Text = RemoveNull(dr!ClosedUser, "")
                cmbLocalImport.Text = RemoveNull(dr!POType, "")
                chkCancel.Checked = RemoveNull(dr!Cancel, 0)
                txtCancelUser.Text = RemoveNull(dr!CancelUser, "")
                txtCancelRemarks.Text = RemoveNull(dr!CancelRemarks, "")
                txtAdvancePer.Value = RemoveNull(dr!AdvancePer, 0)
                txtAdvanceAmount.Value = RemoveNull(dr!AdvanceAmount, 0)
                txtTransportationCharges.Value = RemoveNull(dr!TransportationCharges, 0)
                chkWithoutGST.Checked = RemoveNull(dr!WithoutGST, 0)
                txtManualPoNo.Text = RemoveNull(dr!ManualPoNo, "")

                If chkCancel.Checked = True Then
                    lblFlag.Text = "PURCHASE ORDER CANCELLED BY " + txtCancelUser.Text
                Else
                    lblFlag.Text = "NOT APPROVED - GENERATED BY " + txtGeneratedBy.Text
                End If

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Invalid Po Number")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If

        dbGrid = New BindGrid(tdbGridOrderDetail, "Select Project,PoNo,ProductCode,Qty,Rate,Amount,DiscPer,DiscAmount,SalesTaxPer,SalesTaxAmount,NetAmount,ReqQty,ReqNo From tblPurOrdProductDtl Where PoNo = '" & txtPoNo.Text & "'")
        dbGrid.SetPrimaryKey("ProductCode", "ReqNo")

        Call Totals()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "PURCHASE ORDER PRODUCT") = -1 Then
            Call DisplayRec()

            lblFlag.Text = "NEW ENTRY"
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

        cmbProject.SelectedValue = "0001"
        cmbPackingType.SelectedValue = "0001"
        cmbCurrency.SelectedValue = "0001"
        cmbPaymentTerms.SelectedValue = "0001"
        txtDeliveryTerms.Text = "-"
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cAdd As Boolean

        If dbGrid.cDataTableCollection(0).Rows.Count = 0 Then
            MsgBox("There Must be Some Rows in Grid")
            Exit Sub
        End If

        'If cmbPaymentTerms.SelectedValue = "" Then
        '    MsgBox("Please Input Payment Terms")
        '    Exit Sub
        'End If

        If cmbLevel.SelectedValue = "" Then
            MsgBox("Please Input Level")
            cmbLevel.Focus()
            Exit Sub
        End If

        'If cmbPackingType.SelectedValue = "" Then
        '    MsgBox("Please Input Packing Type")
        '    Exit Sub
        'End If

        If cmbSupplier.SelectedValue = "" Then
            MsgBox("Please Input Supplier")
            Exit Sub
        End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Input Project")
            cmbProject.Focus()
            Exit Sub
        End If

        'If cmbBlock.SelectedValue = "" Then
        '    MsgBox("Please Input Block")
        '    cmbBlock.Focus()
        '    Exit Sub
        'End If

        If chkWithoutGST.Checked = True Then
            If dbGrid.cDataTableCollection(0).Rows.Count > 0 Then
                For Each row In dbGrid.cDataTableCollection(0).Select
                    row!SalesTaxPer = 0
                    row!SalesTaxAmount = 0
                    row!NetAmount = RemoveNull(row!Amount, 0) - RemoveNull(row!DiscAmount, 0)
                Next
            End If
        End If

        Dim cReqNo As String

        For Each row In dbGrid.cDataTableCollection(0).Select
            cReqNo = RemoveNull(row!ReqNo, "")

            If RemoveNull(row!DiscPer, 0) < 0 Then
                MsgBox("Discount Cannot be In Negative")
                Exit Sub
            End If

            If RemoveNull(row!SalesTaxPer, 0) < 0 Then
                MsgBox("Discount Cannot be In Negative")
                Exit Sub
            End If

            'If RemoveNull(row!Rate, 0) <= 0 Then
            '    MsgBox("Rate Must be Greater Then zero")
            '    Exit Sub
            'End If

            If cReqNo <> RemoveNull(row!ReqNo, "") Then
                MsgBox("PO Can only be Generated of One Requisition")
                Exit Sub
            End If
        Next

        Call Totals()

        If dbGrid.cDataTable.Rows.Count = 0 Then
            MsgBox("Must Be Enter Some Entries in Grid", vbInformation, cCompany)
            Exit Sub
        End If

        If txtPoDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtPoDate.Value > Format(DateTo, "MM/dd/yyy") Then
            MsgBox("Cannot Save Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
            Exit Sub
        End If

        'If cmbCurrency.SelectedValue = "" Then
        '    MsgBox("Please Select Currency")
        '    Exit Sub
        'End If

        If cmbLevel.SelectedValue = "" Then
            MsgBox("Level Cannot Be Left Blank")
            Exit Sub
        End If

        'If cmbPaymentTerms.SelectedValue = "" Then
        '    MsgBox("Payment Terms Cannot be Left Blank")
        '    Exit Sub
        'End If

        'If txtDeliveryTerms.Text = "" Then
        '    MsgBox("Delivery Terms Cannot be Left Blank")
        '    Exit Sub
        'End If

        If txtPoNo.Text = "" Then
            If chkWithoutGST.Checked = True Then
                txtPoNo.Text = NextSerial("PONo", "tblPurOrdProductMst", "000000", "POW-")
            Else
                txtPoNo.Text = NextSerial("PONo", "tblPurOrdProductMst", "000000", "POP-")
            End If

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblPurOrdProductMst", "PoNo = '" & txtPoNo.Text & "'")
        Query.AddFields("PoNo", txtPoNo.Text, ActionQueryBuilder.DataType.aString)

        Query.AddFields("Finalized", chkFinalized.Checked, ActionQueryBuilder.DataType.aDecimal)

        If cAdd = True Then
            Query.AddFields("GeneratedBy", txtGeneratedBy.Text, ActionQueryBuilder.DataType.aString)
        End If

        Query.AddFields("PoDate", txtPoDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Supplier", cmbSupplier.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("PaymentTerms", cmbPaymentTerms.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("DeliveryTerms", txtDeliveryTerms.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Description", txtDescription.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ETA", txtETA.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("ETD", txtETD.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("PackingType", cmbPackingType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("SpecialInstruction", txtSpecialInstructions.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Currency", cmbCurrency.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Level", cmbLevel.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Block", cmbBlock.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("POType", cmbLocalImport.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("AdvancePer", txtAdvancePer.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("AdvanceAmount", txtAdvanceAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("TransportationCharges", txtTransportationCharges.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("WithoutGST", chkWithoutGST.Checked, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ManualPoNo", txtManualPoNo.Text, ActionQueryBuilder.DataType.aString)

        Query.AddFields("Closed", chkClosed.Checked, ActionQueryBuilder.DataType.aInteger)

        If RemoveNull(txtCloseDate.Value, Nothing) <> Nothing Then
            Query.AddFields("ClosedDate", txtCloseDate.Value, ActionQueryBuilder.DataType.aDate)
            Query.AddFields("ClosedUser", txtCloseUser.Text, ActionQueryBuilder.DataType.aString)
        End If

        Query.AddFields("Cancel", chkCancel.Checked, ActionQueryBuilder.DataType.aInteger)

        If RemoveNull(txtCancelDate.Value, Nothing) <> Nothing Then
            Query.AddFields("CancelDate", txtCancelDate.Value, ActionQueryBuilder.DataType.aDate)
            Query.AddFields("CancelUser", txtCancelUser.Text, ActionQueryBuilder.DataType.aString)
            Query.AddFields("CancelRemarks", txtCancelRemarks.Text, ActionQueryBuilder.DataType.aString)
        End If

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)

            AddInfo(txtPoNo.Text, "Add Record Purchase Order Product Supplier Name " + "" + cmbSupplier.Text)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)

            EditInfo(txtPoNo.Text, "Add Record Purchase Order Product Supplier Name " + "" + cmbSupplier.Text)
        End If

        dbGrid.SetCriteria = "PoNo = '" & txtPoNo.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("PoNo", txtPoNo.Text)
        dbGrid.Update()

        If MsgBox("Do You Want to Print this Purchase Order", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call Print()
        End If

        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cPoNo As String
        Dim cSql As String

        cSql = "  Select tblProjectFile.Name as ProjectName, Mst.PoNo,isnull(ManualPoNo,'') as ManualPoNo,Case When IsNull(Finalized,0) = 0 Then 'No' Else 'Yes' End as Finalize,GeneratedBy, "
        cSql += " Case When IsNull(WithoutGST,0) = 0 Then 'With GST' Else 'Without GST' End as GST,Case When IsNull(Closed,0) = 0 Then 'No' Else 'Yes' End as Closed, "
        cSql += " ClosedDate,ClosedUser,Case When IsNull(Cancel,0) = 0 Then 'No' Else 'Yes' End as Cancel,"
        cSql += " CancelDate,CancelUser,CancelRemarks,PoType,tblLevel.Name as Level,PoDate,tblSupplier.Name as Supplier,tblProductMaster.SourceCode,"
        cSql += " Dtl.ReqNo,tblProductMaster.ProductName,Qty,Dtl.Rate,Amount,DiscPer,DiscAmount,Dtl.SalesTaxPer,SalesTaxAmount,NetAmount,AdvancePer,AdvanceAmount "
        cSql += " From tblPurOrdProductMst Mst,tblSupplier,tblProjectFile,tblProductMaster,tblPurOrdProductDtl Dtl,tblLevel"
        cSql += " Where Mst.PoNo = Dtl.PoNo "
        cSql += " And	Mst.LEvel = tblLevel.Code "
        cSql += " And   Mst.Supplier = tblSupplier.Code  "
        cSql += " And   Dtl.ProductCode= tblProductMaster.ProductCode"
        cSql += " And   Mst.Project= tblProjectFile.Code"
        cSql += " Order By Mst.PoNO,tblProductMaster.ProductName "

        cPoNo = ShowList(cSql, "List of Purchase Order Product", 0, 1)

        txtPoNo.Text = cPoNo

        If cPoNo <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub tdbGridOrderDetail_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridOrderDetail.AfterColUpdate
        tdbGridOrderDetail.Columns("Amount").Value = RemoveNull(tdbGridOrderDetail.Columns("Qty").Value, 0) * RemoveNull(tdbGridOrderDetail.Columns("Rate").Value, 0)

        If RemoveNull(tdbGridOrderDetail.Columns("DiscPer").Value, 0) <> 0 And RemoveNull(tdbGridOrderDetail.Columns("DiscPer").Value, 0) <> 0 Then
            tdbGridOrderDetail.Columns("DiscAmount").Value = RemoveNull(tdbGridOrderDetail.Columns("Amount").Value, 0) * (RemoveNull(tdbGridOrderDetail.Columns("DiscPer").Value, 0) / 100)
        Else
            tdbGridOrderDetail.Columns("DiscAmount").Value = 0
        End If

        If chkWithoutGST.Checked = False Then
            If RemoveNull(tdbGridOrderDetail.Columns("Amount").Value, 0) <> 0 And RemoveNull(tdbGridOrderDetail.Columns("SalesTaxPer").Value, 0) <> 0 Then
                tdbGridOrderDetail.Columns("SalesTaxAmount").Value = (RemoveNull(tdbGridOrderDetail.Columns("Amount").Value, 0) - RemoveNull(tdbGridOrderDetail.Columns("DiscAmount").Value, 0)) * (RemoveNull(tdbGridOrderDetail.Columns("SalesTaxPer").Value, 0) / 100)
            Else
                tdbGridOrderDetail.Columns("SalesTaxAmount").Value = 0
            End If
        Else
            tdbGridOrderDetail.Columns("SalesTaxPer").Value = 0
            tdbGridOrderDetail.Columns("SalesTaxAmount").Value = 0
        End If

        tdbGridOrderDetail.Columns("NetAmount").Value = RemoveNull(tdbGridOrderDetail.Columns("Amount").Value, 0) - RemoveNull(tdbGridOrderDetail.Columns("DiscAmount").Value, 0) + RemoveNull(tdbGridOrderDetail.Columns("SalesTaxAmount").Value, 0)

        Call Totals()
    End Sub

    Private Sub tdbGridOrderDetail_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridOrderDetail.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridOrderDetail.RowCount > 0 Then
                tdbGridOrderDetail.Delete()
            End If
        End If

        If e.ColIndex = 3 Then
            cSql = "Select	Mst.PoNo,PoDate,tblSupplier.Name as Supplier,"
            cSql += "tblProductMaster.SourceCode,tblProductMaster.ProductName,"
            cSql += "Sum(Qty) as Qty,Dtl.Rate,Sum(Qty * Dtl.Rate) as Amount "
            cSql += "From  tblPurOrdProductMst Mst,tblSupplier,tblProductMaster,tblPurOrdProductDtl Dtl "
            cSql += "Where Mst.PoNo = Dtl.PoNo "
            cSql += "And   Dtl.ProductCode = tblProductMaster.ProductCode "
            cSql += "And   tblSupplier.Code  = Mst.Supplier "
            cSql += "And   tblProductMaster.ProductCode = '" & tdbGridOrderDetail.Columns("ProductCode").Value & "' "
            cSql += "And   Mst.PoNo <> '" & txtPoNo.Text & "' "
            cSql += "Group By Mst.PoNo,PoDate,tblSupplier.Name,tblProductMaster.SourceCode,tblProductMaster.ProductName,tblColor.Name,Dtl.Rate "
            cSql += "Order By PODate Desc "

            ShowList(cSql, "History of Purchase Order Product", 0, 1, "Qty,Amount", "", "", "Report", "", "", "Yes", "", "Yes")
        End If
    End Sub

    Sub Totals()
        Dim cTotalQty As Double
        Dim cTotalAmount As Double
        Dim cTotalDiscAmount As Double
        Dim cTotalSalesTaxAmount As Double
        Dim cNetAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalQty += Convert.ToDouble(RemoveNull(row("Qty"), 0))
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
            cTotalDiscAmount += Convert.ToDouble(RemoveNull(row("DiscAmount"), 0))
            cTotalSalesTaxAmount += Convert.ToDouble(RemoveNull(row("SalesTaxAmount"), 0))
            cNetAmount += Convert.ToDouble(RemoveNull(row("NetAmount"), 0))
        Next

        tdbGridOrderDetail.Columns("Qty").FooterText = Format(cTotalQty, "###,###,##0.00")
        tdbGridOrderDetail.Columns("Amount").FooterText = Format(cTotalAmount, "###,###,##0.00")
        tdbGridOrderDetail.Columns("DiscAmount").FooterText = Format(cTotalDiscAmount, "###,###,##0.00")
        tdbGridOrderDetail.Columns("SalesTaxAmount").FooterText = Format(cTotalSalesTaxAmount, "###,###,##0.00")
        tdbGridOrderDetail.Columns("NetAmount").FooterText = Format(cNetAmount, "###,###,##0.00")

        txtGrossAmount.Value = cTotalAmount
        txtDiscount.Value = cTotalDiscAmount
        txtSalesTax.Value = cTotalSalesTaxAmount
        txtNetAmount.Value = cTotalAmount - cTotalDiscAmount + cTotalSalesTaxAmount + txtTransportationCharges.Value

        If dbGrid.cDataTableCollection(0).Rows.Count > 0 Then
            If txtAdvancePer.Value > 0 And RemoveNull(cTotalAmount, 0) > 0 Then
                txtAdvanceAmount.Value = Math.Round((txtNetAmount.Value) * (txtAdvancePer.Value / 100), 0)
            End If
        End If

        txtBalancePayment.Value = txtNetAmount.Value - txtAdvanceAmount.Value
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call Print()
    End Sub

    Sub Print()
        Dim cSql As String
        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptPurchaseOrderProduct

        cSql = "Select * From PurchaseOrderProduct "
        cSql = cSql + "Where PoNo = '" & txtPoNo.Text & "' Order By ProductCode"

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "POProduct")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("POProduct")
        rReport.fldCompany.Text = cCompanyName

        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        fPreview.Show()
        rReport.Run(True)
        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPickAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickRequisition.Click
        If cmbLevel.SelectedValue = "" Then
            MsgBox("Level Cannot be Left Blank")
            Exit Sub
        End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Cannot be Left Blank")
            Exit Sub
        End If

        'If cmbBlock.SelectedValue = "" Then
        '    MsgBox("Block Cannot be Left Blank")
        '    Exit Sub
        'End If

        Dim cSql As String

        Dim cSalesTaxPer As Double

        cSql = "Select  tblProjectFile.Code as Project,tblProjectfile.Name as ProjectName,ReqNo,BalancePurchaseRequisition.ProductCode,"
        cSql += " tblProductMaster.ProductName,Sum(Qty) As Qty,Max(BalancePurchaseRequisition.Rate) As Rate "
        cSql += " From	BalancePurchaseRequisition,tblProjectFile, tblProductMaster  "
        cSql += " Where BalancePurchaseRequisition.ProductCode = tblProductMaster.ProductCode "
        cSql += " And BalancePurchaseRequisition.Project = tblProjectFile.Code "
        cSql += " And BalancePurchaseRequisition.Project =  '" & cmbProject.SelectedValue & "' "
        cSql += " Group By ReqNo, BalancePurchaseRequisition.ProductCode,tblProjectFile.Name, tblProjectfile.Code,tblProductMaster.ProductName "
        cSql += " Having Sum(Qty) > 0 And Max(ReqDate) <= '" & Format(txtPoDate.Value, "MM/dd/yyyy") & "' "
        cSql += " And (Max(Level) = '" & cmbLevel.SelectedValue & "')"
        cSql += " Order by ReqNo"

        'cSql += " And (Max(Block) = '" & cmbBlock.SelectedValue & "' or Max(Block) = '') "

        Dim dt As DataTable = ShowListMulti(cSql, "List of Article")

        If dt.Rows.Count > 0 Then
            For Each Row As DataRow In dt.Rows
                Dim newRow As DataRow = dbGrid.cDataTable.NewRow

                'cGSTCode = RemoveNull(Row!GSTCode, "")

                newRow("PoNo") = txtPoNo.Text
                newRow("ProductCode") = Row!ProductCode
                newRow("ReqNo") = Row!ReqNo
                newRow("ReqQty") = Row!Qty
                newRow("Qty") = Row!Qty
                newRow("Rate") = Row!Rate
                newRow("Amount") = Row!Qty * Row!Rate
                newRow("DiscPer") = 0
                newRow("DiscAmount") = 0
                newRow("Project") = cmbProject.SelectedValue

                If chkWithoutGST.Checked = True Then
                    newRow("SalesTaxPer") = 0
                    newRow("SalesTaxAmount") = 0
                    newRow("NetAmount") = (Row!Qty * Row!Rate) + newRow("SalesTaxAmount")
                Else

                    'cSql = "Select * From tblGSTSetupDtl Where Code = '" & cGSTCode & "' and '" & Format(txtPoDate.Value, "MM/dd/yyyy") & "' Between DateFrom and DateTo "

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
                        newRow("SalesTaxAmount") = RemoveNull(Row!Qty * Row!Rate, 0) * (RemoveNull(cSalesTaxPer, 0) / 100)
                    Else
                        newRow("SalesTaxAmount") = 0
                    End If

                    newRow("NetAmount") = (Row!Qty * Row!Rate) - newRow("DiscAmount") + newRow("SalesTaxAmount")
                End If

                Try : dbGrid.cDataTable.Rows.Add(newRow)
                Catch ex As Exception : MsgBox("Record is Already Selected.", MsgBoxStyle.Information) : End Try
            Next

            cmbLevel.Enabled = False
            txtPoDate.Enabled = False

            If dbGrid.cDataTable.Rows.Count > 0 Then
                Call Totals()
            End If
        End If
    End Sub

    Private Sub chkCancel_CheckedChanged(sender As Object, e As EventArgs) Handles chkCancel.CheckedChanged
        If chkCancel.Checked = True Then
            txtCancelDate.Value = Today.Date
            txtCancelUser.Text = UserId
        Else
            txtCancelDate.Value = Nothing
            txtCancelUser.Text = ""
        End If
    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click

        If CheckAccess("AccessRight", UserId, "CANCEL PO PRODUCT") = 0 Then
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

        Dim db As New dbOperations("Select * From tblGRNProductDtl Where PONo = '" & txtPoNo.Text & "'")
        Dim dr As SqlDataReader

        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            If RemoveNull(dr!Qty, "") <> "" Then
                MsgBox("Challan Already Generated GRN # " + dr!GRNNo)
                Exit Sub
            End If
        End If

        dr.Close()
        db.Close()

        db = New dbOperations("Select * From tblPurBillServiceDtl Where PONo = '" & txtPoNo.Text & "'")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            If RemoveNull(dr!Qty, "") <> "" Then
                MsgBox("Invoice Already Generated GRN # " + dr!GRNNo)
                Exit Sub
            End If
        End If

        dr.Close()
        db.Close()

        Call SetControls(Actions.Edit)
        Call SetButtons(Actions.Entry)

        chkCancel.Enabled = True
    End Sub

    Private Sub txtAdvancePer_LostFocus(sender As Object, e As EventArgs) Handles txtAdvancePer.LostFocus
        Call Totals()
    End Sub

    Private Sub chkWithoutGST_CheckedChanged(sender As Object, e As EventArgs) Handles chkWithoutGST.CheckedChanged
        'If chkWithoutGST.Checked = True Then
        '    If dbGrid.cDataTableCollection(0).Rows.Count > 0 Then
        '        For Each row In dbGrid.cDataTableCollection(0).Select
        '            row!SalesTaxPer = 0
        '            row!SalesTaxAmount = 0
        '            row!NetAmount = RemoveNull(row!Amount, 0) - RemoveNull(row!DiscAmount, 0)
        '        Next
        '    End If

        '    Call Totals()
        'End If
    End Sub

    Private Sub txtTransportationCharges_LostFocus(sender As Object, e As EventArgs) Handles txtTransportationCharges.LostFocus
        Call Totals()
    End Sub

    Private Sub cmdClosed_Click(sender As Object, e As EventArgs) Handles cmdClosed.Click
        If CheckAccess("AccessRight", UserId, "CLOSE PO PRODUCT") = 0 Then
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

        If chkClosed.Checked = True Then
            MsgBox("Order Already Closed")
            Exit Sub
        End If

        If chkCancel.Checked = True Then
            MsgBox("Cannot Approved PO Already Cancel")
            Exit Sub
        End If

        Call SetControls(Actions.Edit)
        Call SetButtons(Actions.Entry)

        chkClosed.Enabled = True
    End Sub

    Private Sub chkClosed_CheckedChanged(sender As Object, e As EventArgs) Handles chkClosed.CheckedChanged
        If chkCancel.Checked = True Then
            If chkClosed.Checked = True Then
                MsgBox("Please First Un Check Cancel Mark")
                txtCloseDate.Value = Nothing
            End If
        Else
            If chkClosed.Checked = True Then
                txtCloseDate.Value = Today.Date
                txtCloseUser.Text = UserId
            Else
                txtCloseDate.Value = Nothing
                txtCloseUser.Text = ""
            End If
        End If
    End Sub

    Private Sub chkFinalized_CheckedChanged(sender As Object, e As EventArgs) Handles chkFinalized.CheckedChanged
        If chkCancel.Checked = True Then
            If chkCancel.Checked = True Then
                MsgBox("Please First Un Check Cancel Mark")
                Exit Sub
            End If
        Else
            If chkFinalized.Checked = True Then
                txtGeneratedBy.Text = UserId
            Else
                txtGeneratedBy.Text = ""
            End If
        End If
    End Sub

    Private Sub tdbGridOrderDetail_Click(sender As Object, e As EventArgs) Handles tdbGridOrderDetail.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtAdvancePer_ValueChanged(sender As Object, e As EventArgs) Handles txtAdvancePer.ValueChanged

    End Sub

    Private Sub txtDeliveryTerms_TextChanged(sender As Object, e As EventArgs) Handles txtDeliveryTerms.TextChanged, txtManualPoNo.TextChanged

    End Sub
End Class