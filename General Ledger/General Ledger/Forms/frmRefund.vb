Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmRefund
    Dim cSql As String

    Dim db As dbOperations
    Dim dr As SqlDataReader

    Enum Actions
        Initial
        Edit
        Entry
    End Enum
    Private Sub frmTransferPlot_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call ClearControls()
        Call SetControls(Actions.Initial)
        Call FillCombo()
    End Sub
    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitTypeFrom As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim UnitFrom As New BindCombo(cmbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)
        Dim cDebit As New BindCombo(cmbDebit, "Select AccountName as Name,AccountCode as Code from tblAccounts Where (AccountType = 'Bank Book' or AccountType = 'Cash Book') and AccountLevel = 'Detail' order by AccountName", "Name", "Code", True, True, GLConString)
        Dim cCredit As New BindCombo(cmbCredit, "Select AccountName as Name,AccountCode as Code from tblAccounts Where (AccountType = 'Bank Book' or AccountType = 'Cash Book') and AccountLevel = 'Detail' order by AccountName", "Name", "Code", True, True, GLConString)
    End Sub
    Sub ClearControls()

        cmbProject.SelectedValue = ""
        cmbUnit.SelectedValue = ""
        cmbUnitType.SelectedValue = ""
        cmbCredit.SelectedValue = ""
        cmbDebit.SelectedValue = ""

        txtCode.Text = ""
        txtDate.Value = Today.Date
        txtCC.Text = ""
        txtCustomerCode.Text = ""
        txtCustomerName.Text = ""
        txtCustomerTel.Text = ""
        txtCustomerMobile.Text = ""
        txtCustomerNIC.Text = ""
        txtCustomerEmail.Text = ""
        txtRemarks.Text = ""

        txtRefundAmount.Value = 0
        txtDeductionAmount.Value = 0
        txtReceiptAmount.Value = 0
    End Sub
    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                txtDate.Enabled = False
                txtCC.Enabled = False
                txtCustomerCode.Enabled = False
                txtCustomerName.Enabled = False
                txtCustomerTel.Enabled = False
                txtCustomerMobile.Enabled = False
                txtCustomerNIC.Enabled = False
                txtCustomerEmail.Enabled = False
                txtRemarks.Enabled = False
                txtRefundAmount.Enabled = False
                txtDeductionAmount.Enabled = False
                txtReceiptAmount.Enabled = False

                cmbProject.Enabled = False
                cmbUnit.Enabled = False
                cmbUnitType.Enabled = False
                cmbCredit.Enabled = False
                cmbDebit.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                txtDate.Enabled = False
                txtCC.Enabled = False
                txtCustomerCode.Enabled = False
                txtCustomerName.Enabled = False
                txtCustomerTel.Enabled = False
                txtCustomerMobile.Enabled = False
                txtCustomerNIC.Enabled = False
                txtCustomerEmail.Enabled = False
                txtRemarks.Enabled = False
                txtRefundAmount.Enabled = False
                txtDeductionAmount.Enabled = False
                txtReceiptAmount.Enabled = False

                cmbProject.Enabled = False
                cmbUnit.Enabled = False
                cmbUnitType.Enabled = False
                cmbCredit.Enabled = False
                cmbDebit.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                txtDate.Enabled = True
                txtCC.Enabled = True
                txtCustomerCode.Enabled = True
                txtCustomerName.Enabled = True
                txtCustomerTel.Enabled = True
                txtCustomerMobile.Enabled = True
                txtCustomerNIC.Enabled = True
                txtCustomerEmail.Enabled = True
                txtRemarks.Enabled = True
                txtRefundAmount.Enabled = True
                txtDeductionAmount.Enabled = True
                txtReceiptAmount.Enabled = True

                cmbProject.Enabled = True
                cmbUnit.Enabled = True
                cmbUnitType.Enabled = True
                cmbCredit.Enabled = True
                cmbDebit.Enabled = True
        End Select
    End Sub
    Sub SetButtons(ByVal a As Actions)
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

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "REFUND") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "REFUND") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub
    Sub DisplayRec()
        If txtCode.Text <> "" Then
            db = New dbOperations("Select * From tblRefund Where Code = '" & txtCode.Text & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cmbProject.SelectedValue = RemoveNull(dr!Project, "")
                cmbUnit.SelectedValue = RemoveNull(dr!Unit, "")
                cmbUnitType.SelectedValue = RemoveNull(dr!UnitType, "")
                cmbCredit.SelectedValue = RemoveNull(dr!Credit, "")
                cmbDebit.SelectedValue = RemoveNull(dr!Debit, "")

                txtCode.Text = RemoveNull(dr!Code, "")
                txtDate.Value = Today.Date
                txtCC.Text = GetCC(cmbUnit.SelectedValue)
                txtCustomerCode.Text = RemoveNull(dr!CustomerCode, "")
                txtCustomerName.Text = RemoveNull(dr!CustomerName, "")
                txtCustomerTel.Text = RemoveNull(dr!CustomerTel, "")
                txtCustomerMobile.Text = RemoveNull(dr!CustomerMobile, "")
                txtCustomerNIC.Text = RemoveNull(dr!CustomerNic, "")
                txtCustomerEmail.Text = RemoveNull(dr!CustomerEmail, "")
                txtRemarks.Text = RemoveNull(dr!Remarks, "")
                txtRefundAmount.Value = RemoveNull(dr!RefundAmount, 0)
                txtDeductionAmount.Value = RemoveNull(dr!DeductionAmount, 0)
                txtReceiptAmount.Value = RemoveNull(dr!ReceiptAmount, 0)

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Refund Code # Not Found")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "REFUND") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblRefund Where Code = '" & txtCode.Text & "'")

                DB.dbActionQuery()

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Cannot be Left Blank")
            Exit Sub
        End If

        If cmbCredit.SelectedValue = "" Then
            MsgBox("Credit Account be Left Blank")
            Exit Sub
        End If

        If cmbDebit.SelectedValue = "" Then
            MsgBox("Debit Account Cannot be Left Blank")
            Exit Sub
        End If

        If txtCode.Text = "" Then
            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cPrefix = dr!Prefix
            End If

            txtCode.Text = NextSerial("Code", "tblRefund", "000000", "RF" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblRefund", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Date", txtDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Unit", cmbUnit.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitType", cmbUnitType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CC", txtCC.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer", txtCustomerCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Description", txtRemarks.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Debit", cmbDebit.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Credit", cmbCredit.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("RefundAmount", txtRefundAmount.Value, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("DeductionAmount", txtDeductionAmount.Value, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ReceiptAmount", txtReceiptAmount.Value, ActionQueryBuilder.DataType.aInteger)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        Dim cvoucherno As String

        If chkPostToFinance.Checked = True Then
            'If txtEntryDate.Value >= DateFrom And DateTo <= dr!DateTo Then
            cvoucherno = GenerateJV(txtCode.Text, txtDate.Value, " Refund Entry # : " + txtCode.Text + " Against Unit # : " + cmbUnit.Text + " Unit Type # : " & cmbUnitType.Text & " By Customer: " & txtCustomerName.Text)

            'Credit
            GenerateJvDetails(cvoucherno, cmbCredit.SelectedValue, " Refund Entry # : " + txtCode.Text + " Against Unit # : " + cmbUnit.Text + " Unit Type # : " & cmbUnitType.Text & " By Customer: " & txtCustomerName.Text, txtCode.Text, txtDate.Value, 0, txtRefundAmount.Value, "", "", GLConString)

            'Debit
            GenerateJvDetails(cvoucherno, cmbDebit.SelectedValue, " Refund Entry # : " + txtCode.Text + " Against Unit # : " + cmbUnit.Text + " Unit Type # : " & cmbUnitType.Text & " By Customer: " & txtCustomerName.Text, txtCode.Text, txtDate.Value, txtRefundAmount.Value, 0, "", "", GLConString)

            ' End If
        End If

        cSql = "update tblJvMst Set Finalize = 1 Where InvoiceNo = '" & txtCode.Text & "' "
        DB1 = New dbOperations(cSql, GLConString)
        DB1.dbActionQuery()
        DB1.Close()

        If MsgBox("Do You Want to See the Corresponding Voucher", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then

            cSql = "Select * From tblJVMst Where InvoiceNo = '" & txtCode.Text & "'"
            db = New dbOperations(cSql, GLConString)
            dr = db.dbSelectQuery()

            If dr.HasRows = True Then
                dr.Read()

                Call frmMain.frmJvShow(dr!VoucherNo)
            End If

            db.Close()
            dr.Close()
        End If

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub
    Private Sub cmdUnitFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnit.Click
        Dim cReservationNo As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        cSql = "Select ReservationNo,ReservationDate,tblProjectFile.Name as ProjectName,isnull(tblReservationMst.CC,'') as CC,tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit,tblReservationMst.CashAmount,tblReservationMst.LoanAmount,tblReservationMst.ExtraCharges,Discount,tblReservationMst.TotalRevenue,tblCustomer.NICNo "
        cSql = cSql + "From tblReservationMst,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile "
        cSql = cSql + "Where tblReservationMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblReservationMst.Customer = tblCustomer.Code "
        cSql = cSql + "And   tblReservationMst.UnitType = tblUnitType.Code "
        cSql = cSql + "And   tblReservationMst.Unit = tblUnitFile.Code "
        cSql = cSql + "And   tblReservationMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   isnull(tblReservationMst.Cancel,0) = 0"

        cReservationNo = ShowList(cSql, "List of Reservation", 0, 0)

        If cReservationNo <> "" Then
            db = New dbOperations("Select * From tblReservationMst Where ReservationNo = '" & cReservationNo & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cmbUnit.SelectedValue = RemoveNull(dr!Unit, "")
                cmbUnitType.SelectedValue = RemoveNull(dr!UnitType, "")
                txtCC.Text = RemoveNull(dr!CC, "")
                txtCustomerCode.Text = RemoveNull(dr!Customer, "")

            End If
        End If
    End Sub
    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        cSql = "Select TransferNo,TransferDate,tblProjectFile.Name as ProjectName,Amount as Charges,isnull(tblReservationMst.CC,'') as CC,UnitFrom.UnitNumber as UnitFrom, UnitTypeFrom.Name as UnitTypeFrom,UnitTo.UnitNumber as UnitTo,UnitTypeTo.Name as UnitTypeTo,Remarks "
        cSql += " From tblTransferPlot "
        cSql += " Left Outer Join tblUnitFile UnitTo "
        cSql += " Left Outer Join tblUnitType UnitTypeTo "
        cSql += " On UnitTo.UnitType = UnitTypeTo.Code "
        cSql += " On tblTransferPlot.UnitTo = UnitTo.Code,"
        cSql += " tblProjectFile,tblUnitFile UnitFrom Left Outer Join tblReservationMst on tblReservationMst.Unit = UnitFrom.Code,tblUnitType UnitTypeFrom "
        cSql += " Where tblTransferPlot.Project = tblProjectFile.Code "
        cSql += " And   tblTransferPlot.UnitFrom = UnitFrom.Code "
        cSql += " And   UnitFrom.UnitType = UnitTypeFrom.Code "

        txtCode.Text = ShowList(cSql, "List of Transfer Plot", 0, 0)

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub
End Class