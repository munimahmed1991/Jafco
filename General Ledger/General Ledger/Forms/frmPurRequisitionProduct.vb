Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail

Public Class frmPurRequisitionProduct
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
        Dim cSupplier As New BindCombo(tdbSupplier, "Select Code,Name From tblSupplier  Order By Name", "Name", "Code", True)
        Dim cProject As New BindCombo(cmbProject, "Select Code,Name From tblProjectfile  Order By Name", "Name", "Code", True, True)
        Dim cLevel As New BindCombo(cmbLevel, "Select Code,Name From tblLevel Order By Name", "Name", "Code", True, True)
        Dim cLocation As New BindCombo(cmbDeliveryLocation, "Select LocationCode,LocationName From tblLocation Order By LocationName", "LocationName", "LocationCode", True, True)
        Dim cProduct As New BindCombo(tdbProduct, "Select ProductCode,ProductName as ProductName From tblProductMaster where ProductLevel = 'Detail' Order by ProductName", "ProductName", "ProductCode", True)
        Dim cBlock As New BindCombo(cmbBlock, "Select Code,Name From tblBlock Order By Name", "Name", "Code", True, True)
    End Sub

    Sub ClearControls()
        txtReqNo.Text = ""
        txtReqDate.Value = Today.Date
        cmbBlock.SelectedValue = ""
        cmbLevel.SelectedValue = ""
        cmbDeliveryLocation.SelectedValue = ""
        txtDescription.Text = ""
        txtNeedByDate.Value = Today.Date
        txtGeneratedBy.Text = ""
        cmbBlock.SelectedValue = ""
        cmbProject.SelectedValue = ""

        chkCancel.Checked = False
        txtCancelDate.Value = Nothing
        txtCancelUser.Text = ""
        txtCancelRemarks.Text = ""

        txtManualSlipNo.Text = ""
        txtEngrName.Text = ""
        cmbBlock.SelectedValue = ""

        tdbGridOrderDetail.DataSource = Nothing

        tdbGridOrderDetail.Columns("Qty").FooterText = ""
        tdbGridOrderDetail.Columns("Amount").FooterText = ""
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtReqNo.Enabled = True
                txtReqDate.Enabled = False
                cmbBlock.Enabled = False
                cmbLevel.Enabled = False
                cmbDeliveryLocation.Enabled = False
                txtDescription.Enabled = False
                txtManualSlipNo.Enabled = False
                txtEngrName.Enabled = False
                txtNeedByDate.Enabled = False
                txtGeneratedBy.Enabled = False
                cmbProject.Enabled = False
                chkCancel.Enabled = False
                txtCancelDate.Enabled = False
                txtCancelUser.Enabled = False
                txtCancelRemarks.Enabled = False

                tdbGridOrderDetail.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtReqNo.Enabled = False
                txtReqDate.Enabled = False
                cmbBlock.Enabled = False
                cmbLevel.Enabled = False
                cmbDeliveryLocation.Enabled = False
                txtDescription.Enabled = False
                txtNeedByDate.Enabled = False
                txtGeneratedBy.Enabled = False
                cmbProject.Enabled = False
                txtManualSlipNo.Enabled = False
                txtEngrName.Enabled = False
                chkCancel.Enabled = False
                txtCancelDate.Enabled = False
                txtCancelUser.Enabled = False
                txtCancelRemarks.Enabled = False

                tdbGridOrderDetail.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)
                txtReqNo.Enabled = False
                txtReqDate.Enabled = True
                cmbBlock.Enabled = True
                cmbLevel.Enabled = True
                cmbDeliveryLocation.Enabled = True
                txtDescription.Enabled = True
                txtNeedByDate.Enabled = True
                txtGeneratedBy.Enabled = True
                cmbProject.Enabled = True
                chkCancel.Enabled = False
                txtCancelDate.Enabled = False
                txtCancelUser.Enabled = False
                txtCancelRemarks.Enabled = False
                txtManualSlipNo.Enabled = True
                txtEngrName.Enabled = True
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
            Case Actions.Edit
                cmdAdd.Enabled = False
                cmdSearch.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = False
            Case Actions.Entry
                cmdAdd.Enabled = False
                cmdSearch.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False
        End Select
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "PURCHASE REQ PRODUCT") = -1 Then

            If chkCancel.Checked = True Then
                MsgBox("Cannot Edit Transaction Already Cancel")
                Exit Sub
            End If

            Call SetControls(Actions.Entry)
            cmbBlock.Enabled = False
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "PURCHASE REQ PRODUCT") = -1 Then
            If txtReqDate.Value < Format(DateFrom, "MM/dd/yyy") Or txtReqDate.Value > Format(DateTo, "MM/dd/yyy") Then
                MsgBox("Cannot Delete Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
                Exit Sub
            End If

            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Query = New ActionQueryBuilder

                dbGrid.SetCriteria = "ReqNo = '" & txtReqNo.Text & "'"
                dbGrid.Delete()

                Query.Refresh()
                Query.SetQueryInformation("tblPurReqProductMst", "ReqNo = '" & txtReqNo.Text & "'")
                Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete)

                DeleteInfo(txtReqNo.Text, "Delete Record Purchase Requisition Product Department Name " + "" + cmbBlock.Text)

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtReqNo.Text <> "" Then
            Dim db As New dbOperations("Select * From tblPurReqProductMst Where ReqNo = '" & txtReqNo.Text & "'")
            Dim dr As SqlDataReader

            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                txtReqNo.Text = dr!ReqNo
                txtReqDate.Value = dr!ReqDate
                cmbBlock.SelectedValue = RemoveNull(dr!Block, "")
                cmbLevel.SelectedValue = RemoveNull(dr!Level, "")
                cmbDeliveryLocation.SelectedValue = RemoveNull(dr!DeliveryLocation, "")
                txtDescription.Text = dr!Description
                txtManualSlipNo.Text = RemoveNull(dr!ManualSlipNo, "")
                txtEngrName.Text = RemoveNull(dr!EngrName, "")
                txtNeedByDate.Value = RemoveNull(dr!NeedByDate, Today.Date)
                txtGeneratedBy.Text = RemoveNull(dr!GeneratedBy, "")
                cmbProject.SelectedValue = RemoveNull(dr!Project, "")
                chkCancel.Checked = RemoveNull(dr!Cancel, 0)
                txtCancelUser.Text = RemoveNull(dr!CancelUser, "")
                txtCancelDate.Value = RemoveNull(dr!CancelDate, Nothing)
                txtCancelRemarks.Text = RemoveNull(dr!CancelRemarks, "")

                Call SetControls(Actions.Edit)

                If chkCancel.Checked = True Then
                    lblFlag.Text = "REQUISITION CANCELLED BY " + txtCancelUser.Text
                Else
                    lblFlag.Text = "NOT APPROVED - GENERATED BY " + txtGeneratedBy.Text
                End If
            Else
                MsgBox("Invalid Po Number")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If

        dbGrid = New BindGrid(tdbGridOrderDetail, "Select Project,ReqNo,ProductCode,Stock,MinInv,MaxInv,LastSupplier,Supplier,Qty,Rate,Amount From tblPurReqProductDtl Where ReqNo = '" & txtReqNo.Text & "'")
        dbGrid.SetPrimaryKey("ProductCode")
        Call Totals()
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "PURCHASE REQ PRODUCT") = -1 Then
            Call DisplayRec()

            lblFlag.Text = "NEW ENTRY"
            txtGeneratedBy.Text = UserId
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

        If txtReqDate.Value < DateFrom Or txtReqDate.Value > DateTo Then
            MsgBox("Cannot Save Entry because the date is out of Period (From : " & Format(DateFrom, "dd/MM/yyyy") & " To : " & Format(DateTo, "dd/MM/yyyy"))
            Exit Sub
        End If

        'If cmbBlock.SelectedValue = "" Then
        '    MsgBox("Block Cannot Be Left Blank")
        '    Exit Sub
        'End If

        If cmbLevel.SelectedValue = "" Then
            MsgBox("Level Cannot be Left Blank")
            Exit Sub
        End If

        If cmbDeliveryLocation.SelectedValue = "" Then
            MsgBox("Delivery Location Cannot be Left Blank")
            Exit Sub
        End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Cannot be Left Blank")
            Exit Sub
        End If

        For Each row In dbGrid.cDataTableCollection(0).Select
            If RemoveNull(row!Qty, 0) = 0 Then
                MsgBox("Qty Cannot be Zero")
                Exit Sub
            End If

            If RemoveNull(row!ProductCode, "") = "" Then
                MsgBox("Product Code Cannot Be Left Blank")
                Exit Sub
            End If
        Next

        If txtReqNo.Text = "" Then
            txtReqNo.Text = NextSerial("ReqNo", "tblPurReqProductMst", "000000", "PRP-")

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblPurReqProductMst", "ReqNo = '" & txtReqNo.Text & "'")
        Query.AddFields("ReqNo", txtReqNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ReqDate", txtReqDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.AddFields("GeneratedBy", txtGeneratedBy.Text, ActionQueryBuilder.DataType.aString)
        End If

        Query.AddFields("Description", txtDescription.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ManualSlipNo", txtManualSlipNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("EngrName", txtEngrName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Block", cmbBlock.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Level", cmbLevel.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("DeliveryLocation", cmbDeliveryLocation.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("NeedByDate", txtNeedByDate.Value, ActionQueryBuilder.DataType.aDate)

        Query.AddFields("Cancel", chkCancel.Checked, ActionQueryBuilder.DataType.aInteger)

        If RemoveNull(txtCancelDate.Value, Nothing) <> Nothing Then
            Query.AddFields("CancelDate", txtCancelDate.Value, ActionQueryBuilder.DataType.aDate)
            Query.AddFields("CancelUser", txtCancelUser.Text, ActionQueryBuilder.DataType.aString)
        End If

        Query.AddFields("CancelRemarks", txtCancelRemarks.Text, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)

            AddInfo(txtReqNo.Text, "Add Record Purchase Requisition Product Department Name " + "" + cmbBlock.Text)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)

            EditInfo(txtReqNo.Text, "Add Record Purchase Requisition Product Department Name " + "" + cmbBlock.Text)
        End If

        dbGrid.SetCriteria = "ReqNo = '" & txtReqNo.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("ReqNo", txtReqNo.Text)
        dbGrid.Update()

        'If MsgBox("Do You Want to Print this Purchase Order", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
        '    Call Print()
        'End If

        Call ClearControls()
        Call SetControls(Actions.Initial)

        lblFlag.Text = ""
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cReqNo As String
        Dim cSql As String

        cSql = "Select tblProjectFile.Name as Project,Mst.ReqNo,GeneratedBy,Mst.ManualSlipNo,Mst.EngrName,Case When IsNull(Cancel,0) = 0 Then 'No' Else 'Yes' End as Cancel,CancelDate,CancelUser,CancelRemarks,tblLevel.Name as Level,tblLocation.LocationName as DeliveryLocation,ReqDate,tblProductMaster.ProductName,NeedByDate,Stock,Dtl.MinInv,Dtl.MaxInv,Qty,Dtl.Rate,Amount "
        cSql = cSql + "From tblPurReqProductMst Mst,tblLocation,tblProductMaster,tblPurReqProductDtl Dtl,tblProjectFile,tblLevel "
        cSql = cSql + "Where Mst.ReqNo = Dtl.ReqNo "

        cSql = cSql + "And   Mst.DeliveryLocation = tblLocation.LocationCode "
        cSql = cSql + "And   Dtl.ProductCode= tblProductMaster.ProductCode "
        cSql = cSql + "And   Mst.Project = tblProjectFile.Code "
        cSql = cSql + "And   Mst.Level = tblLevel.Code "
        cSql = cSql + "Order By Mst.ReqNo,tblProductMaster.ProductName "

        cReqNo = ShowList(cSql, "List of Purchase Requistion Product", 0, 1, "Qty,Amount")

        txtReqNo.Text = cReqNo

        If cReqNo <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub tdbGridOrderDetail_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridOrderDetail.AfterColUpdate
        tdbGridOrderDetail.Columns("Amount").Value = RemoveNull(tdbGridOrderDetail.Columns("Qty").Value, 0) * RemoveNull(tdbGridOrderDetail.Columns("Rate").Value, 0)

        Call Totals()
    End Sub

    Private Sub tdbGridOrderDetail_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridOrderDetail.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridOrderDetail.RowCount > 0 Then
                tdbGridOrderDetail.Delete()
            End If
        End If

        If e.ColIndex = 2 Then
            cSql = "Select Mst.PoNo,PoType,tblOrgDept.Name as Department,PoDate,tblSupplier.Name as Supplier,tblProductMaster.SourceCode,tblProductMaster.ProductName,Qty,Dtl.Rate,Amount "
            cSql = cSql + "From tblPurOrdProductMst Mst Left Outer Join tblOrgDept On tblOrgDept.Code = Mst.Department,tblSupplier,tblProductMaster,tblPurOrdProductDtl Dtl "
            cSql = cSql + "Where Mst.PoNo = Dtl.PoNo "
            cSql = cSql + "And   Mst.Supplier = tblSupplier.Code "
            cSql = cSql + "And   Dtl.ProductCode= tblProductMaster.ProductCode "
            cSql = cSql + "And   IsNull(Mst.SecondApproval,0) = 1 and IsNull(Cancel,0) = 0 "
            cSql = cSql + "Order By Mst.PoNO,tblProductMaster.ProductName "

            ShowList(cSql, "History of Purchase Order Product", 0, 1, "Qty,Amount", "", "", "Report", "", "", "Yes", "", "Yes")
        End If
    End Sub

    Sub Totals()
        Dim cTotalQty As Double
        Dim cTotalAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalQty += Convert.ToDouble(RemoveNull(row("Qty"), 0))
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
        Next

        tdbGridOrderDetail.Columns("Qty").FooterText = Format(cTotalQty, "###,###,##0.00")
        tdbGridOrderDetail.Columns("Amount").FooterText = Format(cTotalAmount, "###,###,##0.00")
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        'Call Print()

        Call SendEmail("munimahmed1991@gmail.com", "check", "", "", "", "")
    End Sub

    Public Function SendEmail(ByVal ToEmail As [String], ByVal Subject As [String], ByVal Message As String, ByVal AttachmentPath As String, ByVal CCEmail As [String], ByVal BCCEmail As [String]) As Boolean
        Try
            'Get Sender Email From Web.Config

            Dim FromEmail As String = "billing@groveresidency.com"
            Dim Host As String = "mail.groveresidency.com"
            Dim Password As String = "P@k!stn786"
            Dim Port As Integer = 25

            Dim mailMessage As New MailMessage()
            mailMessage.From = New MailAddress(FromEmail)
            mailMessage.Subject = Subject
            mailMessage.Body = Message
            mailMessage.IsBodyHtml = True

            'for Attachment
            If AttachmentPath <> "" Then
                Dim attachment As System.Net.Mail.Attachment
                attachment = New System.Net.Mail.Attachment(AttachmentPath)
                mailMessage.Attachments.Add(attachment)
            End If
            'Adding Multiple recipient email 
            Dim Multiple As String() = ToEmail.Split(","c)
            For Each MultiEmail As String In Multiple
                mailMessage.[To].Add(New MailAddress(MultiEmail))
            Next

            If CCEmail <> "" Then
                Dim MultipleCCEmails As String() = CCEmail.Split(","c)
                For Each MultiEmail As String In MultipleCCEmails
                    mailMessage.CC.Add(New MailAddress(MultiEmail))
                Next
            End If

            If BCCEmail <> "" Then
                Dim MultipleBCCEmails As String() = BCCEmail.Split(","c)
                For Each MultiEmail As String In MultipleBCCEmails
                    mailMessage.Bcc.Add(New MailAddress(MultiEmail))
                Next
            End If

            Dim smtp As New SmtpClient()
            smtp.Host = Host

            smtp.Timeout = 0
            smtp.EnableSsl = False

            Dim NetworkCred As New NetworkCredential()
            'NetworkCred.UserName = "munimahmed1991@gmail.com"
            'NetworkCred.Password = "wgwbpbfljzurtjha"
            smtp.UseDefaultCredentials = False
            NetworkCred.UserName = FromEmail
            NetworkCred.Password = Password
            smtp.Credentials = NetworkCred
            smtp.Port = Port
            smtp.Send(mailMessage)
            '  mailMessage.Dispose()

            Return True

        Catch generatedExceptionName As Exception
            Return False
        End Try
    End Function

    Sub Print()

        Dim cSql As String
        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptPurRequisitionProduct

        cSql = "Select Mst.ReqNo,GeneratedBy,Mst.ReqDate,tblOrgDept.Name As Department,Mst.Level, Mst.Description,tblProductMaster.ProductName,tblSupplier.Name As Supplier,"
        cSql = cSql + "Stock,Dtl.MaxInv,Dtl.MinInv,Qty,tblProductMaster.UoM,Rate,Amount,FirstApproval,FirstApprovalUser,FirstApprovalDate,"
        cSql = cSql + "SecondApproval,SecondApprovalUser,SecondApprovalDate "
        cSql = cSql + "From tblPurReqProductMst Mst, tblPurReqProductDtl Dtl Left Outer Join tblSupplier On tblSupplier.Code = Dtl.Supplier,tblOrgDept,tblProductMaster "
        cSql = cSql + "Where Mst.ReqNo = Dtl.ReqNo "
        cSql = cSql + "And	 Mst.Department = tblOrgDept.Code  "
        cSql = cSql + "And	 Dtl.ProductCode = tblProductMaster.ProductCode "
        cSql = cSql + "And   Mst.ReqNo = '" & txtReqNo.Text & "' "

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "POProduct")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("POProduct")
        rReport.fldCompany.Text = cCompanyName

        rReport.fldTitle.Text = "PURCHASE REQUISITION PRODUCT"

        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        fPreview.Show()
        rReport.Run(True)
        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPickAccessories_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickProduct.Click
        Dim cSql As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        If cmbProject.SelectedValue <> "" Then

            cSql = "Select tblProductMaster.ProductName,Sum(IsNull(GRNQty,0)) as GRNQty,Sum(IsNull(AllocQty,0)) as AllocQty,Sum(IsNull(GRNQty,0) - IsNull(AllocQty,0)) as BalQty,tblProductMaster.MinInv,tblProductMaster.MaxInv,tblProductMaster.ProductCode "
            cSql = cSql + "From tblProductMaster Left Outer Join ProductBalance "
            cSql = cSql + "On ProductBalance.ProductCode = tblProductMaster.ProductCode "
            cSql = cSql + "Where tblProductMaster.ProductLevel = 'Detail' "
            cSql = cSql + "Group By tblProductMaster.ProductCode, tblProductMaster.ProductName, MaxInv, MinInv "

            Dim dt As DataTable = ShowListMulti(cSql, "List of Article")

            If dt.Rows.Count > 0 Then
                For Each Row As DataRow In dt.Rows
                    Dim newRow As DataRow = dbGrid.cDataTable.NewRow
                    newRow("ReqNo") = txtReqNo.Text
                    newRow("ProductCode") = Row!ProductCode
                    newRow("Stock") = RemoveNull(Row!BalQty, 0)
                    newRow("MinInv") = RemoveNull(Row!MinInv, 0)
                    newRow("MaxInv") = RemoveNull(Row!MaxInv, 0)
                    newRow("Project") = RemoveNull(cmbProject.SelectedValue, 0)

                    cSql = "Select Mst.Supplier "
                    cSql = cSql + "From tblPurOrdProductMst Mst, tblPurOrdProductDtl Dtl "
                    cSql = cSql + "Where Mst.PoNo = Dtl.PoNo "
                    cSql = cSql + "And		ProductCode = '" & Row!ProductCode & "' "
                    cSql = cSql + "Order By Mst.PODate Desc "

                    db = New dbOperations(cSql)
                    dr = db.dbSelectQuery

                    If dr.HasRows = True Then
                        dr.Read()

                        newRow("LastSupplier") = RemoveNull(dr!Supplier, "")
                    End If

                    dr.Close()
                    db.Close()

                    Try : dbGrid.cDataTable.Rows.Add(newRow)
                    Catch ex As Exception : MsgBox("Record is Already Selected.", MsgBoxStyle.Information) : End Try
                Next

            End If
        Else
            MsgBox("Project cannot be left Blank ")
            cmbProject.Focus()
            Exit Sub
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

    Private Sub cmdPending1_Click(sender As Object, e As EventArgs)
        Dim cReqNo As String
        Dim cSql As String

        cSql = "Select Mst.ReqNo,GeneratedBy,Case When IsNull(FirstApproval,0) = 0 Then 'No' Else 'Yes' End as FirstApproval,FirstApprovalDate,FirstApprovalUser,Case When IsNull(SecondApproval,0) = 0 Then 'No' Else 'Yes' End as SecondApproval,SecondApprovalDate,SecondApprovalUser,Case When IsNull(Cancel,0) = 0 Then 'No' Else 'Yes' End as Cancel,CancelDate,CancelUser,CancelRemarks,tblOrgDept.Name as Department,Level,tblLocation.LocationName as DeliveryLocation,ReqDate,tblProductMaster.ProductName,Stock,Dtl.MinInv,Dtl.MaxInv,Qty,Dtl.Rate,Amount "
        cSql = cSql + "From tblPurReqProductMst Mst,tblOrgDept,tblLocation,tblProductMaster,tblPurReqProductDtl Dtl "
        cSql = cSql + "Where Mst.ReqNo = Dtl.ReqNo "
        cSql = cSql + "And   tblOrgDept.Code = Mst.Department "
        cSql = cSql + "And   Mst.DeliveryLocation = tblLocation.LocationCode "
        cSql = cSql + "And   Dtl.ProductCode= tblProductMaster.ProductCode "
        cSql = cSql + "And   IsNull(FirstApproval,0) = 0 "
        cSql = cSql + "And   IsNull(Cancel,0) = 0 "
        cSql = cSql + "Order By Mst.ReqNo,tblProductMaster.ProductName "

        cReqNo = ShowList(cSql, "List of Purchase Requistion Product", 0, 0, "Qty,Amount")

        txtReqNo.Text = cReqNo

        If cReqNo <> "" Then
            Call DisplayRec()
        End If

    End Sub

    Private Sub cmdCancel_Click(sender As Object, e As EventArgs) Handles cmdCancel.Click
        If CheckAccess("AccessRight", UserId, "CANCEL REQ PRODUCT") = 0 Then
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

        Call SetControls(Actions.Edit)
        Call SetButtons(Actions.Entry)

        chkCancel.Enabled = True
    End Sub

    Private Sub tdbGridOrderDetail_Click(sender As Object, e As EventArgs) Handles tdbGridOrderDetail.Click

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
End Class