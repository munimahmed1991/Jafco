Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class frmReservation
    Dim dbGrid As BindGrid
    Public CEmailTitle As String
    Public CEmailMessage As String
    Public cFormType As String

    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmCountry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetControls(Actions.Initial)
        Call ClearControls()
        Call FormCenter(Me)

        If cFormType = "Cancel" Then
            Me.Text = "Cancel Units"
            ToolStripLabel1.Text = "Cancel Units"

            lblRefundAmount.Visible = True
            txtRefundAmount.Visible = True
            lblRefundPaid.Visible = True
            txtRefundPaid.Visible = True
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub ClearControls()
        txtReservationNo.Text = ""
        txtReservationDate.Value = Today.Date
        cmbProject.SelectedValue = ""

        txtCustomerCode1.Text = ""
        txtCustomerName1.Text = ""
        txtCustomerTel1.Text = ""
        txtCustomerMobile1.Text = ""
        txtCustomerNIC1.Text = ""
        txtCustomerEmail1.Text = ""

        txtCustomerCode2.Text = ""
        txtCustomerName2.Text = ""
        txtCustomerTel2.Text = ""
        txtCustomerMobile2.Text = ""
        txtCustomerNIC2.Text = ""
        txtCustomerEmail2.Text = ""

        txtCC.Text = ""
        cmbUnitType.SelectedValue = ""
        cmbUnit.SelectedValue = ""
        cmbScheme.SelectedValue = ""
        txtStandardPlanNo.Text = ""
        txtCreditDays.Value = 0
        txtCashAmount.Value = 0
        txtLoanAmount.Value = 0
        txtExtraCharges.Value = 0
        txtTotalRevenue.Value = 0
        txtDiscount.Value = 0
        txtAddOtherCharges.Value = 0
        txtAmount.Value = 0
        txtDelayDays.Value = 0
        txtDueDays.Value = 0
        txtInstallments.Value = 0
        cmbPaymentType.SelectedValue = ""
        cmbExtraCharges.SelectedValue = ""
        chkNotDecided.Checked = False
        chkCancel.Checked = False
        txtCancelCharges.Value = 0
        txtCancelDate.Value = Nothing
        txtPenaltyPer.Value = 0
        txtRefundAmount.Value = 0
        txtRefundPaid.Value = 0
        txtExtraLandCharges.Value = 0
        txtExtraSqFeetYds.Value = 0
        txtPerSqFeetCharges.Value = 0
        chkApplyExtraLand.Checked = False
        cmbAgent.SelectedValue = ""
        cmbAreaIn.Text = "Sq. Feet"
        chkNonActive.Checked = False
        txtOfficialCash.Value = 0
        txtOfficialService.Value = 0
        txtNoofMonths.Value = 0
        chkBlockLetters.Checked = False

        txtNomineeName.Text = ""
        txtNomineeMobile.Text = ""
        txtNomineeNIC.Text = ""
        txtNomineeRelation.Text = ""
        txtNomineeFather.Text = ""
        txtCC.Text = ""

        chkCustomerNIC.Checked = False
        chkNICMakingBooking.Checked = False
        chkPassport.Checked = False
        chkPhotograph.Checked = False
        chkAuthorityLetter.Checked = False

        tdbGridPaymentPlan.DataSource = Nothing

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblDefaults")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            txtCreditDays.Value = dr!DefaultCreditDays
        End If

        db.Close()
        dr.Close()

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name,Project From tblUnitType", "Name", "Code", True, True)
        Dim Unit As New BindCombo(cmbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)
        Dim PaymentType As New BindCombo(cmbPaymentType, "Select Code,Name From tblPaymentType", "Name", "Code", True, True)
        Dim ExtraCharges As New BindCombo(cmbExtraCharges, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim Scheme As New BindCombo(cmbScheme, "Select Code,Name From tblScheme", "Name", "Code", True, True)
        Dim Agent As New BindCombo(cmbAgent, "Select Code,Name From tblAgent", "Name", "Code", True, True)


        Dim cPaymentType As New BindCombo(tdbPaymentType, "Select Code,Name From tblPaymentType", "Name", "Code", True)
        Dim cExtraCharges As New BindCombo(tdbExtraCharges, "Select Code,Name From tblExtraCharges", "Name", "Code", True)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtReservationNo.Enabled = True
                txtReservationDate.Enabled = False
                cmbProject.Enabled = True

                cmdCustomerList1.Enabled = False
                cmdCustomerList2.Enabled = False
                cmdUnitType.Enabled = False
                cmdUnit.Enabled = False
                cmdStandardPaymentPlan.Enabled = False
                cmdPickPlan.Enabled = False
                cmbPaymentPlan.Enabled = False
                cmbScheme.Enabled = False
                cmbAgent.Enabled = False
                cmbAreaIn.Enabled = False
                txtCC.Enabled = False
                cmbPaymentType.Enabled = False
                cmbExtraCharges.Enabled = False
                txtAmount.Enabled = False
                txtInstallments.Enabled = False
                txtDueDays.Enabled = False
                chkNotDecided.Enabled = False
                chkCancel.Enabled = False
                txtCancelCharges.Enabled = False
                txtCancelDate.Enabled = False
                txtAddOtherCharges.Enabled = False
                txtCreditDays.Enabled = False
                chkCustomerNIC.Enabled = False
                chkNICMakingBooking.Enabled = False
                chkPhotograph.Enabled = False
                chkPassport.Enabled = False
                chkAuthorityLetter.Enabled = False
                txtPenaltyPer.Enabled = False
                txtRefundAmount.Enabled = False
                txtRefundPaid.Enabled = False
                txtExtraLandCharges.Enabled = False
                txtExtraSqFeetYds.Enabled = False
                txtPerSqFeetCharges.Enabled = False
                chkApplyExtraLand.Enabled = False
                chkNonActive.Enabled = False
                txtOfficialCash.Enabled = False
                txtOfficialService.Enabled = False
                txtNoofMonths.Enabled = False
                chkBlockLetters.Checked = False
                txtNomineeName.Enabled = False
                txtNomineeMobile.Enabled = False
                txtNomineeNIC.Enabled = False
                txtNomineeRelation.Enabled = False
                txtNomineeFather.Enabled = False
                cmdGenerate.Enabled = False
                cmdUpdate.Enabled = False
                cmdDeletePlan.Enabled = False
                cmdRescheduleDelete.Enabled = False
                cmdRescheduleAdd.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtReservationNo.Enabled = False
                txtReservationDate.Enabled = False
                cmbProject.Enabled = True
                txtCC.Enabled = False
                cmdCustomerList1.Enabled = False
                cmdCustomerList2.Enabled = False
                cmdUnitType.Enabled = False
                cmdUnit.Enabled = False
                cmdStandardPaymentPlan.Enabled = False
                cmdPickPlan.Enabled = False
                cmbPaymentPlan.Enabled = False
                cmbScheme.Enabled = False
                cmbAgent.Enabled = False
                cmbAreaIn.Enabled = False
                txtNomineeName.Enabled = False
                txtNomineeMobile.Enabled = False
                txtNomineeNIC.Enabled = False
                txtNomineeRelation.Enabled = False
                txtNomineeFather.Enabled = False
                cmbPaymentType.Enabled = False
                cmbExtraCharges.Enabled = False
                txtAmount.Enabled = False
                txtInstallments.Enabled = False
                txtDueDays.Enabled = False
                chkNotDecided.Enabled = False
                chkCancel.Enabled = False
                txtCancelCharges.Enabled = False
                txtCancelDate.Enabled = False
                txtCreditDays.Enabled = False
                txtAddOtherCharges.Enabled = False
                chkCustomerNIC.Enabled = False
                chkNICMakingBooking.Enabled = False
                chkPhotograph.Enabled = False
                chkPassport.Enabled = False
                chkAuthorityLetter.Enabled = False
                txtPenaltyPer.Enabled = False
                txtRefundAmount.Enabled = False
                txtRefundPaid.Enabled = False
                txtExtraLandCharges.Enabled = False
                txtExtraSqFeetYds.Enabled = False
                txtPerSqFeetCharges.Enabled = False
                chkApplyExtraLand.Enabled = False
                chkNonActive.Enabled = False
                txtOfficialCash.Enabled = False
                txtOfficialService.Enabled = False
                txtNoofMonths.Enabled = False
                chkBlockLetters.Checked = False

                cmdGenerate.Enabled = False
                cmdUpdate.Enabled = False
                cmdDeletePlan.Enabled = False
                cmdRescheduleDelete.Enabled = False
                cmdRescheduleAdd.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtReservationNo.Enabled = False
                txtReservationDate.Enabled = True
                cmbProject.Enabled = True
                txtCC.Enabled = True
                cmdCustomerList1.Enabled = True
                cmdCustomerList2.Enabled = True
                cmdUnitType.Enabled = True
                cmdUnit.Enabled = True
                cmdStandardPaymentPlan.Enabled = True
                cmdPickPlan.Enabled = True
                cmbPaymentPlan.Enabled = True
                cmbScheme.Enabled = True
                cmbAgent.Enabled = True
                cmbAreaIn.Enabled = True
                txtNomineeName.Enabled = True
                txtNomineeMobile.Enabled = True
                txtNomineeNIC.Enabled = True
                txtNomineeRelation.Enabled = True
                txtNomineeFather.Enabled = True
                cmbPaymentType.Enabled = True
                cmbExtraCharges.Enabled = True
                txtAmount.Enabled = True
                txtInstallments.Enabled = True
                txtDueDays.Enabled = True
                chkNotDecided.Enabled = True
                chkCancel.Enabled = False
                txtCancelCharges.Enabled = False
                txtCancelDate.Enabled = False
                txtAddOtherCharges.Enabled = True
                txtCreditDays.Enabled = True
                chkCustomerNIC.Enabled = True
                chkNICMakingBooking.Enabled = True
                chkPhotograph.Enabled = True
                chkPassport.Enabled = True
                chkAuthorityLetter.Enabled = True
                txtPenaltyPer.Enabled = True
                txtRefundAmount.Enabled = True
                txtRefundPaid.Enabled = True
                txtExtraLandCharges.Enabled = True
                txtExtraSqFeetYds.Enabled = True
                txtPerSqFeetCharges.Enabled = True
                chkApplyExtraLand.Enabled = True
                chkNonActive.Enabled = True
                txtOfficialCash.Enabled = True
                txtOfficialService.Enabled = True
                txtNoofMonths.Enabled = True
                chkBlockLetters.Checked = True

                If cUserType <> "A" Then
                    txtCashAmount.Enabled = False
                    txtLoanAmount.Enabled = False
                Else
                    txtCashAmount.Enabled = True
                    txtLoanAmount.Enabled = True
                End If

                cmdGenerate.Enabled = True
                cmdUpdate.Enabled = True
                cmdDeletePlan.Enabled = True
                cmdRescheduleDelete.Enabled = True
                cmdRescheduleAdd.Enabled = True
        End Select
    End Sub

    Public Sub SetButtons(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                If cFormType <> "Cancel" Then
                    cmdAdd.Enabled = True
                Else
                    cmdAdd.Enabled = True
                End If

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

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "RESERVATION FORM") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As dbOperations

                DB = New dbOperations("Delete From tblReservationDtl Where ReservationNo = '" & txtReservationNo.Text & "'")
                DB.dbActionQuery()

                DB = New dbOperations("Delete From tblReservationMst Where ReservationNo = '" & txtReservationNo.Text & "'")
                DB.dbActionQuery()

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "RESERVATION FORM") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "RESERVATION FORM") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Public Shared Function SendEmail(ByVal ToEmail As [String], ByVal Subject As [String], ByVal Message As String, ByVal AttachmentPath As String, ByVal CCEmail As [String], ByVal BCCEmail As [String]) As Boolean
        Try
            'Get Sender Email From Web.Config

            Dim FromEmail As String
            Dim cPassword As String
            Dim Host As String = "smtp.gmail.com"


            Dim db1 As New dbOperations("Select * From tblDefaults ")
            Dim dr1 As SqlDataReader

            dr1 = db1.dbSelectQuery

            If dr1.HasRows = True Then
                dr1.Read()
                'ToEmail = dr1!EmailPasswordEncrypt
                FromEmail = dr1!EmailFrom
                cPassword = dr1!EmailPasswordEncrypt

            End If

            Dim Password As String = cPassword
            Dim Port As Integer = 587

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


            smtp.EnableSsl = True
            Dim NetworkCred As New NetworkCredential()
            NetworkCred.UserName = mailMessage.From.Address
            NetworkCred.Password = Password
            '  smtp.UseDefaultCredentials = true;
            smtp.Credentials = NetworkCred
            smtp.Port = Port
            smtp.Send(mailMessage)
            Return True
        Catch generatedExceptionName As Exception

            Return False
        End Try
    End Function

    Sub DisplayRec()
        If txtReservationNo.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblReservationMst Where ReservationNo = '" & txtReservationNo.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtReservationNo.Text = DR!ReservationNo
                txtReservationDate.Value = RemoveNull(DR!ReservationDate, Nothing)
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                txtCustomerCode1.Text = RemoveNull(DR!Customer, "")
                txtCustomerCode2.Text = RemoveNull(DR!Customer2, "")
                cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")
                cmbUnit.SelectedValue = RemoveNull(DR!Unit, "")
                cmbScheme.SelectedValue = RemoveNull(DR!Scheme, "")
                cmbAgent.SelectedValue = RemoveNull(DR!Agent, "")
                cmbAreaIn.Text = RemoveNull(DR!AreaIn, "Sq. Feet")
                txtCC.Text = RemoveNull(DR!CC, "")

                If RemoveNull(DR!PaymentPlan, "") <> "" Then
                    cmbPaymentPlan.Text = RemoveNull(DR!PaymentPlan, "")
                End If

                txtStandardPlanNo.Text = RemoveNull(DR!StandardPlanNo, "")
                txtCashAmount.Value = RemoveNull(DR!CashAmount, 0)
                txtLoanAmount.Value = RemoveNull(DR!LoanAmount, 0)
                txtExtraCharges.Value = RemoveNull(DR!ExtraCharges, 0)
                txtDiscount.Value = RemoveNull(DR!Discount, 0)
                txtTotalRevenue.Value = RemoveNull(DR!TotalRevenue, 0)
                chkCancel.Checked = RemoveNull(DR!Cancel, 0)
                txtCancelCharges.Value = RemoveNull(DR!CancelCharges, 0)
                txtCancelDate.Value = RemoveNull(DR!CancelDate, Today.Date)
                txtAddOtherCharges.Value = RemoveNull(DR!AddOtherCharges, 0)
                txtCreditDays.Value = RemoveNull(DR!CreditDays, 0)
                txtPenaltyPer.Value = RemoveNull(DR!PenaltyPer, 0)
                txtRefundAmount.Value = RemoveNull(DR!RefundAmount, 0)
                txtRefundPaid.Value = RemoveNull(DR!RefundPaid, 0)
                txtExtraLandCharges.Value = RemoveNull(DR!ExtraLandCharges, 0)
                txtExtraSqFeetYds.Value = RemoveNull(DR!ExtraSqFeetYds, 0)
                txtPerSqFeetCharges.Value = RemoveNull(DR!PerSqFeetCharges, 0)
                chkApplyExtraLand.Checked = RemoveNull(DR!ApplyExtraLand, 0)
                txtOfficialCash.Value = RemoveNull(DR!OfficialCash, 0)
                txtOfficialService.Value = RemoveNull(DR!OfficialService, 0)
                txtNoofMonths.Value = RemoveNull(DR!NoofMonths, 0)
                chkNonActive.Checked = RemoveNull(DR!NonActive, 0)
                chkCustomerNIC.Checked = RemoveNull(DR!CustomerNIC, 0)
                chkNICMakingBooking.Checked = RemoveNull(DR!NICMakingBooking, 0)
                chkPassport.Checked = RemoveNull(DR!Passport, 0)
                chkPhotograph.Checked = RemoveNull(DR!Photograph, 0)
                chkAuthorityLetter.Checked = RemoveNull(DR!AuthorityLetter, 0)
                txtNoofMonths.Value = RemoveNull(DR!NoofMonths, 0)
                chkBlockLetters.Checked = RemoveNull(DR!BlockLetters, 0)
                txtNomineeName.Text = RemoveNull(DR!NomineeName, "")
                txtNomineeMobile.Text = RemoveNull(DR!NomineeMobile, "")
                txtNomineeNIC.Text = RemoveNull(DR!NomineeNIC, "")
                txtNomineeRelation.Text = RemoveNull(DR!NomineeRelation, "")
                txtNomineeFather.Text = RemoveNull(DR!NomineeFatherName, "")

                DB.Close()

                Call PickCustomerData1()
                Call PickCustomerData2()
                Call SetControls(Actions.Edit)
            Else
                MsgBox("Reservation Does Not Exist")
                Exit Sub
            End If
        Else
            Call SetControls(Actions.Entry)
            Call ClearControls()
        End If

        dbGrid = New BindGrid(tdbGridPaymentPlan, "Select ReservationNo,PaymentType,ExtraCharges,Installment,DueDays,DueDate,Amount,NotDecided,InvoiceNo From tblReservationDtl Where ReservationNo = '" & txtReservationNo.Text & "'")

        If dbGrid.cDataTable.Rows.Count > 0 Then
            Call Totals()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If txtCustomerCode1.Text = "" Then
            MsgBox("Customer Cannot be Left Blank")
            Exit Sub
        End If

        If cmbUnitType.SelectedValue = "" Then
            MsgBox("Unit Type Cannot be Left Blank")
            Exit Sub
        End If

        If cmbUnit.SelectedValue = "" Then
            MsgBox("Unit  Cannot be Left Blank")
            Exit Sub
        End If


        Dim cTotalAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
        Next

        Call Totals()

        If RemoveNull(txtCashAmount.Value, 0) + RemoveNull(txtExtraCharges.Value, 0) - RemoveNull(txtDiscount.Value, 0) + RemoveNull(txtLoanAmount.Value, 0) + RemoveNull(txtExtraLandCharges.Value, 0) > cTotalAmount Then
            MsgBox("Please Make The Payment Plan Equivalent to Cash Amount + Extra Charges")
            Exit Sub
        End If


        If txtReservationNo.Text = "" Then
            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cPrefix = dr!Prefix
            End If

            txtReservationNo.Text = NextSerial("ReservationNo", "tblReservationMst", "00000", "RS" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")

            cAdd = True
        Else
            cAdd = False
        End If


        Query.Refresh()
        Query.SetQueryInformation("tblReservationMst", "ReservationNo = '" & txtReservationNo.Text & "'")
        Query.AddFields("ReservationNo", txtReservationNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ReservationDate", txtReservationDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer", txtCustomerCode1.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer2", txtCustomerCode2.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitType", cmbUnitType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Unit", cmbUnit.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("PaymentPlan", cmbPaymentPlan.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("StandardPlanNo", txtStandardPlanNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Cashamount", txtCashAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("LoanAmount", txtLoanAmount.Text, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraCharges", txtExtraCharges.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Discount", txtDiscount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("TotalRevenue", txtTotalRevenue.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Scheme", cmbScheme.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CustomerNIC", chkCustomerNIC.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("NICMakingBooking", chkNICMakingBooking.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("Passport", chkPassport.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("Photograph", chkPhotograph.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("AuthorityLetter", chkAuthorityLetter.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("PenaltyPer", txtPenaltyPer.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("RefundAmount", txtRefundAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("RefundPaid", txtRefundPaid.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraLandCharges", txtExtraLandCharges.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraSqFeetYds", txtExtraSqFeetYds.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("PerSqFeetCharges", txtPerSqFeetCharges.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ApplyExtraLand", chkApplyExtraLand.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("Agent", cmbAgent.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("AreaIn", cmbAreaIn.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("NonActive", chkNonActive.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("OfficialCash", txtOfficialCash.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("OfficialService", txtOfficialService.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("NoofMonths", txtNoofMonths.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("BlockLetters", chkBlockLetters.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("NomineeName", txtNomineeName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("NomineeMobile", txtNomineeMobile.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("NomineeNIC", txtNomineeNIC.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("NomineeRelation", txtNomineeRelation.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("NomineeFatherName", txtNomineeFather.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CC", txtCC.Text, ActionQueryBuilder.DataType.aString)

        If chkCancel.Checked = True Then
            Query.AddFields("Cancel", chkCancel.Checked, ActionQueryBuilder.DataType.aInteger)
            Query.AddFields("CancelDate", txtCancelDate.Value, ActionQueryBuilder.DataType.aDate)
            Query.AddFields("CancelCharges", txtCancelCharges.Value, ActionQueryBuilder.DataType.aDecimal)
        End If

        Query.AddFields("AddOtherCharges", txtAddOtherCharges.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("CreditDays", txtCreditDays.Value, ActionQueryBuilder.DataType.aDecimal)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)

            Dim ToEmail As String

            Dim db2 As New dbOperations("Select * From tblDefaults ")
            Dim dr2 As SqlDataReader

            dr2 = db2.dbSelectQuery

            If dr2.HasRows = True Then
                dr2.Read()
                ToEmail = dr2!EmailTo
            Else
                MsgBox("Please Define Email Addresses On Which Email Need to be Sent")
                Exit Sub

            End If
            CEmailTitle = cmbProject.Text + "-" + "Reservation Alert of Unit#" + cmbUnit.Text
            CEmailMessage = "Unit# " + cmbUnit.Text + " of " + cmbProject.Text + " has been reserved on " + txtReservationDate.Text + " by " + txtCustomerName1.Text + " at total Price of " + txtTotalRevenue.Text
            Call SendEmail(ToEmail, CEmailTitle, CEmailMessage, "", "", "")
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If


        dbGrid.SetCriteria = "ReservationNo = '" & txtReservationNo.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("ReservationNo", txtReservationNo.Text)
        dbGrid.Update()

        db = New dbOperations("Update tblUnitFile set CashAmount = " & txtCashAmount.Value & ",LoanAmount = " & txtLoanAmount.Value & " Where Code = '" & cmbUnit.SelectedValue & "'")
        db.dbActionQuery()

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtReservationNo.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cSql As String

        If cFormType <> "Cancel" Then
            cSql = "Select ReservationNo,1 as Reservation,ReservationDate,tblProjectFile.Name as ProjectName,tblCustomer.Name as CustomerName,isnull(tblReservationMst.CC,'') as CC,tblReservationMst.NomineeNAme,NomineeMobile,NomineeNIC,NomineeFatherName,NomineeRelation,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit,PaymentPlan,NoofMonths,tblReservationMst.CashAmount,tblReservationMst.LoanAmount,tblReservationMst.ExtraCharges,Discount,tblReservationMst.TotalRevenue,tblCustomer.Mobile,tblCustomer.TelRes,tblAgent.Name as AgentName,tblAgentCompany.Name as AgentCompany,RefundAmount,RefundPaid,tblCustomer.NICNo,AddOtherCharges "
        Else
            cSql = "Select ReservationNo,1 as Reservation,ReservationDate,tblReservationMst.CancelDate,tblProjectFile.Name as ProjectName,tblCustomer.Name as CustomerName,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit,PaymentPlan,NoofMonths,isnull(tblReservationMst.CC,'') as CC,tblReservationMst.CashAmount,tblReservationMst.LoanAmount,tblReservationMst.ExtraCharges,Discount,tblReservationMst.TotalRevenue,tblCustomer.Mobile,tblCustomer.TelRes,tblAgent.Name as AgentName,tblAgentCompany.Name as AgentCompany,RefundAmount,RefundPaid,tblCustomer.NICNo,AddOtherCharges "
        End If

        cSql = cSql + "From tblReservationMst Left Outer Join tblAgent Left Outer Join tblAgentCompany On tblAgentCompany.Code = tblAgent.AgentCompany On tblAgent.Code = tblReservationMst.Agent Left Outer Join tblScheme On tblScheme.Code = tblReservationMst.Scheme,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile "
        cSql = cSql + "Where tblReservationMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblReservationMst.Customer = tblCustomer.Code "
        cSql = cSql + "And   tblReservationMst.UnitType = tblUnitType.Code "
        cSql = cSql + "And   tblReservationMst.Unit = tblUnitFile.Code "

        If cmbProject.SelectedValue <> "" Then
            cSql = cSql + "And tblReservationMst.Project = '" & cmbProject.SelectedValue & "' "
        End If

        If cFormType <> "Cancel" Then
            cSql = cSql + "And   IsNull(tblReservationMst.Cancel,0) = 0 "
        Else
            cSql = cSql + "And   IsNull(tblReservationMst.Cancel,0) = 1 "
        End If

        txtReservationNo.Text = ShowList(cSql, "List of Reservations", 1, 0, "CashAmount,LoanAmount,ExtraCharges,Discount,TotalRevenue,Reservation", , "ProjectName", , "ProjectName")

        If txtReservationNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdCustomerList1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomerList1.Click
        txtCustomerCode1.Text = ShowList("Select tblCustomer.Code,Ltrim(Rtrim(Slt)) + ' ' + Ltrim(Rtrim(tblCustomer.Name)) as Customer,FatherHusbandName,NicNo,TelRes,TelOffice,Mobile,tblCountry.Name as Country,tblCity.Name as City,tblAreaFile.Name as Area,1 as Customers,Occupation,Email,Address,Company,Designation,AddressOffice,CC From tblCustomer Left Outer Join tblCountry On tblCountry.Code = tblCustomer.Country  Left Outer Join tblCity On tblCity.Code = tblCustomer.City  Left Outer Join tblAreaFile On tblAreaFile.Code = tblCustomer.Area Order By tblCustomer.Code", "List of Country", 1, 0, "Customers")

        Call PickCustomerData1()
    End Sub

    Sub PickCustomerData1()
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select tblCustomer.Code,Ltrim(Rtrim(Slt)) + ' ' + Ltrim(Rtrim(tblCustomer.Name)) as Customer,CC,FatherHusbandName,NicNo,TelRes,TelOffice,Mobile,tblCountry.Name as Country,tblCity.Name as City,tblAreaFile.Name as Area,1 as Customers,Occupation,Email,Address,Company,Designation,AddressOffice From tblCustomer Left Outer Join tblCountry On tblCountry.Code = tblCustomer.Country  Left Outer Join tblCity On tblCity.Code = tblCustomer.City  Left Outer Join tblAreaFile On tblAreaFile.Code = tblCustomer.Area Where tblCustomer.Code = '" & txtCustomerCode1.Text & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            txtCustomerName1.Text = dr!Customer
            txtCustomerTel1.Text = RemoveNull(dr!TelRes, "")
            txtCustomerMobile1.Text = RemoveNull(dr!Mobile, "")
            txtCustomerEmail1.Text = RemoveNull(dr!Email, "")
            txtCustomerNIC1.Text = RemoveNull(dr!NICNo, "")

        End If

        dr.Close()
        db.Close()
    End Sub


    Private Sub cmdUnitType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitType.Click
        If cmbUnit.SelectedValue <> "" Then
            MsgBox("Unit Type Cannot be Changed - Unit Already Selected")
            Exit Sub
        End If

        Dim cSql As String = "Select tblUnitType.Code,tblUnitType.Name As UnitType,tblProjectFile.Name As Project,CashAmount,LoanAmount,TotalRevenue From tblUnitType,tblProjectFile Where tblUnitType.Project = '" & cmbProject.SelectedValue & "' and tblUnitType.Project = tblProjectFile.Code Order By tblUnitType.Code"
        cmbUnitType.SelectedValue = ShowList(cSql, "List of Unit Type", 1, 0)
    End Sub

    Private Sub txtDiscount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtDiscount.LostFocus
        Call Totals()
    End Sub

    Sub Totals()
        On Error Resume Next

        txtExtraLandCharges.Value = txtExtraSqFeetYds.Value * txtPerSqFeetCharges.Value
        txtTotalRevenue.Value = RemoveNull(txtCashAmount.Value, 0) + RemoveNull(txtLoanAmount.Value, 0) + RemoveNull(txtExtraCharges.Value, 0) - RemoveNull(txtDiscount.Value, 0) + RemoveNull(txtAddOtherCharges.Value, 0)

        If chkApplyExtraLand.Checked = True Then
            txtTotalRevenue.Value = txtTotalRevenue.Value + txtExtraLandCharges.Value
        End If

        Dim cTotalAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
        Next

        tdbGridPaymentPlan.Columns("Amount").FooterText = Format(cTotalAmount, "###,###,##0")
    End Sub

    Private Sub txtDiscount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtDiscount.TextChanged
        If txtDiscount.Value <> 0 Then
            Call Totals()
        End If
    End Sub

    Private Sub cmdUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnit.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project First in Search")
            Exit Sub
        End If

        If cmbUnitType.SelectedValue = "" Then
            MsgBox("Please Select Unit Type First in Search")
            Exit Sub
        End If

        Dim cSql As String
        Dim cProject As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * from tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()
        Else
            MsgBox("No Entries Found for the Select Project in Project File")
            Exit Sub
        End If

        cSql = "Select tblUnitFile.Code,tblProjectFile.Name as Project,tblUnitFile.UnitNumber,tblBlock.Name as Block,tblUnitType.Name as UnitType,tblUnitFile.Category,tblUnitFile.Floors,tblUnitFile.CashAmount,tblUnitFile.LoanAmount,tblUnitFile.TotalRevenue, "
        cSql = cSql + " IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as ExtraCharges,"
        cSql = cSql + " tblUnitFile.TotalRevenue + IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as GrossTotal"

        If RemoveNull(dr!ExtraCharges1, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges1Apply,0) = 1 Then Charges1.Name Else '' End as ExtraCharges1,IsNull(tblUnitFile.ExtraChargesAmount1,0) as ExtraChargesAmount1 "
        End If

        If RemoveNull(dr!ExtraCharges2, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges2Apply,0) = 1 Then Charges2.Name Else '' End as ExtraCharges2,IsNull(tblUnitFile.ExtraChargesAmount2,0) as ExtraChargesAmount2 "
        End If

        If RemoveNull(dr!ExtraCharges3, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges3Apply,0) = 1 Then Charges3.Name Else '' End as ExtraCharges3,IsNull(tblUnitFile.ExtraChargesAmount3,0) as ExtraChargesAmount3 "
        End If

        If RemoveNull(dr!ExtraCharges4, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges4Apply,0) = 1 Then Charges4.Name Else '' End as ExtraCharges4,IsNull(tblUnitFile.ExtraChargesAmount4,0) as ExtraChargesAmount4 "
        End If

        If RemoveNull(dr!ExtraCharges5, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges5Apply,0) = 1 Then Charges5.Name Else '' End as ExtraCharges5,IsNull(tblUnitFile.ExtraChargesAmount5,0) as ExtraChargesAmount5 "
        End If

        If RemoveNull(dr!ExtraCharges6, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges6Apply,0) = 1 Then Charges6.Name Else '' End as ExtraCharges6,IsNull(tblUnitFile.ExtraChargesAmount6,0) as ExtraChargesAmount6 "
        End If

        If RemoveNull(dr!ExtraCharges7, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges7Apply,0) = 1 Then Charges7.Name Else '' End as ExtraCharges7,IsNull(tblUnitFile.ExtraChargesAmount7,0) as ExtraChargesAmount7 "
        End If

        If RemoveNull(dr!ExtraCharges8, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges8Apply,0) = 1 Then Charges8.Name Else '' End as ExtraCharges8,IsNull(tblUnitFile.ExtraChargesAmount8,0) as ExtraChargesAmount8 "
        End If

        If RemoveNull(dr!ExtraCharges9, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges9Apply,0) = 1 Then Charges9.Name Else '' End as ExtraCharges9,IsNull(tblUnitFile.ExtraChargesAmount9,0) as ExtraChargesAmount9 "
        End If

        If RemoveNull(dr!ExtraCharges10, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges10Apply,0) = 1 Then Charges10.Name Else '' End as ExtraCharges10,IsNull(tblUnitFile.ExtraChargesAmount10,0) as ExtraChargesAmount10 "
        End If

        If RemoveNull(dr!ExtraCharges11, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges11Apply,0) = 1 Then Charges11.Name Else '' End as ExtraCharges11,IsNull(tblUnitFile.ExtraChargesAmount11,0) as ExtraChargesAmount11 "
        End If

        If RemoveNull(dr!ExtraCharges12, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges12Apply,0) = 1 Then Charges12.Name Else '' End as ExtraCharges12,IsNull(tblUnitFile.ExtraChargesAmount12,0) as ExtraChargesAmount12 "
        End If

        If RemoveNull(dr!ExtraCharges13, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges13Apply,0) = 1 Then Charges13.Name Else '' End as ExtraCharges13,IsNull(tblUnitFile.ExtraChargesAmount13,0) as ExtraChargesAmount13 "
        End If

        If RemoveNull(dr!ExtraCharges14, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges14Apply,0) = 1 Then Charges14.Name Else '' End as ExtraCharges14,IsNull(tblUnitFile.ExtraChargesAmount14,0) as ExtraChargesAmount14  "
        End If

        If RemoveNull(dr!ExtraCharges15, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges15Apply,0) = 1 Then Charges15.Name Else '' End as ExtraCharges15,IsNull(tblUnitFile.ExtraChargesAmount15,0) as ExtraChargesAmount15 "
        End If

        cSql = cSql + "From tblUnitFile "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges1 On Charges1.Code = tblUnitFile.ExtraCharges1 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges2 On Charges2.Code = tblUnitFile.ExtraCharges2 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges3 On Charges3.Code = tblUnitFile.ExtraCharges3 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges4 On Charges4.Code = tblUnitFile.ExtraCharges4 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges5 On Charges5.Code = tblUnitFile.ExtraCharges5 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges6 On Charges6.Code = tblUnitFile.ExtraCharges6 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges7 On Charges7.Code = tblUnitFile.ExtraCharges7 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges8 On Charges8.Code = tblUnitFile.ExtraCharges8 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges9 On Charges9.Code = tblUnitFile.ExtraCharges9 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges10 On Charges10.Code = tblUnitFile.ExtraCharges10 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges11 On Charges11.Code = tblUnitFile.ExtraCharges11 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges12 On Charges12.Code = tblUnitFile.ExtraCharges12 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges13 On Charges13.Code = tblUnitFile.ExtraCharges13 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges14 On Charges14.Code = tblUnitFile.ExtraCharges14 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges15 On Charges15.Code = tblUnitFile.ExtraCharges15 "
        cSql = cSql + ",tblProjectFile,tblUnitType,tblBlock "
        cSql = cSql + "Where tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And tblUnitFile.Project = tblProjectFile.Code "
        cSql = cSql + "And tblUnitFile.Block = tblBlock.Code "
        cSql = cSql + "And tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And tblUnitFile.UnitType = '" & cmbUnitType.SelectedValue & "' "
        cSql = cSql + "And isnull(tblUnitFile.Cancel,0) = 0 "

        ' cSql = cSql + "And tblUnitfile.Code Not In (Select Unit From tblReservationMst) "
        cSql = cSql + "Order By tblUnitFile.Code "

        cmbUnit.SelectedValue = ShowList(cSql, "List of Units", 1, 0)

        Call PickUnitInformation()
    End Sub

    Sub PickUnitInformation()
        Dim db As dbOperations
        Dim dr As SqlDataReader

        csql = "Select * from tblUnitFile Where Code = '" & cmbUnit.SelectedValue & "'"

        db = New dbOperations(csql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            txtCashAmount.Value = RemoveNull(dr!CashAmount, 0)
            txtLoanAmount.Value = RemoveNull(dr!LoanAmount, 0)
            txtExtraCharges.Value = RemoveNull(dr!ExtraChargesAmount1, 0) + RemoveNull(dr!ExtraChargesAmount2, 0) + RemoveNull(dr!ExtraChargesAmount3, 0) + RemoveNull(dr!ExtraChargesAmount4, 0) + RemoveNull(dr!ExtraChargesAmount5, 0) + RemoveNull(dr!ExtraChargesAmount6, 0) + RemoveNull(dr!ExtraChargesAmount7, 0) + RemoveNull(dr!ExtraChargesAmount8, 0) + RemoveNull(dr!ExtraChargesAmount9, 0) + RemoveNull(dr!ExtraChargesAmount10, 0) + RemoveNull(dr!ExtraChargesAmount11, 0) + RemoveNull(dr!ExtraChargesAmount12, 0) + RemoveNull(dr!ExtraChargesAmount13, 0) + RemoveNull(dr!ExtraChargesAmount14, 0) + RemoveNull(dr!ExtraChargesAmount15, 0)
        End If

        db.Close()
        dr.Close()

        If RemoveNull(cmbScheme.SelectedValue, "") <> "" Then
            csql = "Select * from tblScheme Where Code = '" & cmbScheme.SelectedValue & "' and UnitType = '" & cmbUnitType.SelectedValue & "'"
        End If

        db = New dbOperations(csql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            txtCashAmount.Value = RemoveNull(dr!CashAmount, 0)
            txtLoanAmount.Value = RemoveNull(dr!LoanAmount, 0)
        End If

        db.Close()
        dr.Close()

        Call Totals()
    End Sub

    Private Sub cmdCustomerList2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomerList2.Click
        txtCustomerCode2.Text = ShowList("Select tblCustomer.Code,Ltrim(Rtrim(Slt)) + Ltrim(Rtrim(tblCustomer.Name)) as Customer,FatherHusbandName,NicNo,TelRes,TelOffice,Mobile,tblCountry.Name as Country,tblCity.Name as City,tblAreaFile.Name as Area,1 as Customers,Occupation,Email,Address,Company,Designation,AddressOffice From tblCustomer Left Outer Join tblCountry On tblCountry.Code = tblCustomer.Country  Left Outer Join tblCity On tblCity.Code = tblCustomer.City  Left Outer Join tblAreaFile On tblAreaFile.Code = tblCustomer.Area Order By tblCustomer.Code", "List of Country", 1, 0, "Customers")

        Call PickCustomerData2()
    End Sub

    Sub PickCustomerData2()
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select tblCustomer.Code,Ltrim(Rtrim(Slt)) + ' ' + Ltrim(Rtrim(tblCustomer.Name)) as Customer,FatherHusbandName,NicNo,TelRes,TelOffice,Mobile,tblCountry.Name as Country,tblCity.Name as City,tblAreaFile.Name as Area,1 as Customers,Occupation,Email,Address,Company,Designation,AddressOffice From tblCustomer Left Outer Join tblCountry On tblCountry.Code = tblCustomer.Country  Left Outer Join tblCity On tblCity.Code = tblCustomer.City  Left Outer Join tblAreaFile On tblAreaFile.Code = tblCustomer.Area Where tblCustomer.Code = '" & txtCustomerCode2.Text & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            txtCustomerName2.Text = dr!Customer
            txtCustomerTel2.Text = RemoveNull(dr!TelRes, "")
            txtCustomerMobile2.Text = RemoveNull(dr!Mobile, "")
            txtCustomerEmail2.Text = RemoveNull(dr!Email, "")
            txtCustomerNIC2.Text = RemoveNull(dr!NICNo, "")
        End If

        dr.Close()
        db.Close()
    End Sub

    Private Sub cmdExtraCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExtraCharges.Click
        cmbExtraCharges.SelectedValue = ShowList("Select * From ExtraChargesUnit Where Unit = '" & cmbUnit.SelectedValue & "'", "Extra Charges", 1, 1)

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From ExtraChargesUnit Where Unit = '" & cmbUnit.SelectedValue & "' and Code = '" & cmbExtraCharges.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            txtAmount.Value = RemoveNull(dr!Amount, 0)
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub cmdStandardPaymentPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStandardPaymentPlan.Click
        txtStandardPlanNo.Text = ShowList("Select tblStandardPaymentPlanMst.Code,tblStandardPaymentPlanMst.Name,tblProjectFile.Name as Project,tblUnitType.Name as UnitType From tblStandardPaymentPlanMst,tblProjectFile,tblUnitType Where tblStandardPaymentPlanMst.UnitType = '" & cmbUnitType.SelectedValue & "' and tblStandardPaymentPlanMst.Project = tblProjectFile.Code and tblStandardPaymentPlanMst.UnitType = tblUnitType.Code and Scheme = '" & cmbScheme.SelectedValue & "' Order By tblStandardPaymentPlanMst.Code", "List of Standard Payment Plans", 1, 0)
    End Sub

    Private Sub cmdPickPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickPlan.Click
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select PaymentType,Amount,Max(Installment) as Installment,Min(DueDays) as DueDays,Max(NotDecided) as NotDecided From tblStandardPaymentPlanDtl where Code = '" & txtStandardPlanNo.Text & "' Group By PaymentType,Amount")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cmbPaymentType.SelectedValue = RemoveNull(dr!PaymentType, "")
            txtAmount.Value = RemoveNull(dr!Amount, 0)
            txtInstallments.Value = RemoveNull(dr!Installment, 0)
            txtDueDays.Value = RemoveNull(dr!DueDays, 0)
            chkNotDecided.Checked = RemoveNull(dr!NotDecided, 0)

            Call GeneratePaymenPlan()

            For Each DataRow In dr
                cmbPaymentType.SelectedValue = RemoveNull(dr!PaymentType, "")
                txtAmount.Value = RemoveNull(dr!Amount, 0)
                txtInstallments.Value = RemoveNull(dr!Installment, 0)
                txtDueDays.Value = RemoveNull(dr!DueDays, 0)
                chkNotDecided.Checked = RemoveNull(dr!NotDecided, 0)

                Call GeneratePaymenPlan()
            Next
        End If

        db.Close()
        dr.Close()

        Call Totals()
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        Call GeneratePaymenPlan()
    End Sub

    Sub GeneratePaymenPlan()
        If cmbExtraCharges.SelectedValue <> "" And cmbPaymentType.SelectedValue <> "" Then
            MsgBox("Please Select Either Payment Type or Extra Charges")
            Exit Sub
        End If

        If txtInstallments.Value = 0 Then
            MsgBox("Please Input Installment")
            Exit Sub
        End If

        Dim cInstallment As Integer
        Dim cYear As Double
        Dim cMonth As Double
        Dim cTotalMonths As Double

        cInstallment = 1

        cYear = Year(DateAdd(DateInterval.Day, txtDelayDays.Value + txtDueDays.Value, txtReservationDate.Value))
        cMonth = Month(DateAdd(DateInterval.Day, txtDelayDays.Value + txtDueDays.Value, txtReservationDate.Value))
        cTotalMonths = Month(DateAdd(DateInterval.Day, txtDelayDays.Value + txtDueDays.Value, txtReservationDate.Value))

        While cInstallment <= txtInstallments.Value
            For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
                If RemoveNull(row!PaymentType, "") = cmbPaymentType.SelectedValue And row!Installment = cInstallment And RemoveNull(row!PaymentType, "") <> "" Then
                    MsgBox("Payment Already found cannot insert duplicate")
                    Exit Sub
                End If
            Next

            Dim NewRow As DataRow = dbGrid.cDataTable.NewRow
            NewRow("ReservationNo") = txtReservationNo.Text

            If RemoveNull(cmbPaymentType.SelectedValue, "") <> "" Then
                NewRow("PaymentType") = cmbPaymentType.SelectedValue
            End If

            If RemoveNull(cmbExtraCharges.SelectedValue, "") <> "" Then
                NewRow("ExtraCharges") = cmbExtraCharges.SelectedValue
            End If

            Dim cDueDate As DateTime

            NewRow("Amount") = txtAmount.Value
            NewRow("Installment") = cInstallment
            NewRow("DueDays") = IIf(txtInstallments.Value > 1, RemoveNull(txtDelayDays.Value, 0) + (cInstallment * txtDueDays.Value), cInstallment * txtDueDays.Value)
            NewRow("NotDecided") = chkNotDecided.Checked

            If txtInstallments.Value > 1 Then
                If cInstallment > 1 Then
                    cMonth = cMonth + Math.Round(txtDueDays.Value / 30, 0)
                End If

                If cMonth >= 13 And cMonth < 25 Then
                    cMonth = cMonth - 12
                    cYear = cYear + 1
                End If

                ' cDueDate = Convert.ToDateTime("01" + "/" + Trim(Str(cMonth)) + "/" + Trim(Str(cYear)))
                cDueDate = Convert.ToDateTime(Trim(Str(cMonth)) + "/" + "01" + "/" + Trim(Str(cYear)))

                NewRow("DueDate") = cDueDate
            Else
                NewRow("DueDate") = DateAdd(DateInterval.Day, NewRow("DueDays"), txtReservationDate.Value)
            End If

            cInstallment = cInstallment + 1
            dbGrid.cDataTable.Rows.Add(NewRow)
        End While

        Call Totals()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            If cmbPaymentType.SelectedValue = RemoveNull(row!PaymentType, "") And RemoveNull(row!PaymentType, "") <> "" And RemoveNull(row!InvoiceNo, "") = "" Then
                row!Amount = txtAmount.Value
            End If

            If cmbExtraCharges.SelectedValue = RemoveNull(row!ExtraCharges, "") And RemoveNull(row!ExtraCharges, "") <> "" And RemoveNull(row!InvoiceNo, "") = "" Then
                row!Amount = txtAmount.Value
            End If
        Next

        Call Totals()
    End Sub

    Private Sub cmdDeletePlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDeletePlan.Click
        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            If cmbPaymentType.SelectedValue <> "" Then
                If RemoveNull(row!PaymentType, "") = RemoveNull(cmbPaymentType.SelectedValue, "") And RemoveNull(row!PaymentType, "") <> "" And RemoveNull(row!InvoiceNo, "") = "" Then
                    row.Delete()
                End If
            End If

            If cmbExtraCharges.SelectedValue <> "" Then
                If RemoveNull(row!ExtraCharges, "") = RemoveNull(cmbExtraCharges.SelectedValue, "") And RemoveNull(row!ExtraCharges, "") <> "" And RemoveNull(row!InvoiceNo, "") = "" Then
                    row.Delete()
                End If
            End If
        Next

        Call Totals()
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        cmbExtraCharges.SelectedValue = ""
    End Sub

    Private Sub cmdScheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScheme.Click
        cmbScheme.SelectedValue = ShowList("Select Code,Name,CashAmount,LoanAmount,TotalAmount From tblScheme Where UnitType = '" & cmbUnitType.SelectedValue & "' and  Project = '" & cmbProject.SelectedValue & "'", "List of Scheme", 1, 0)

        If cmbScheme.SelectedValue <> "" Then
            Call PickUnitInformation()
        End If
    End Sub

    Private Sub GroupBox3_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub cmdReschedule_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRescheduleDelete.Click
        If MsgBox("Do You Want to Reschedule the Payment Plan for the Current Unit", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim db As dbOperations
            Dim dr As SqlDataReader

            For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
                If RemoveNull(row!InvoiceNo, "") = "" Then
                    row.Delete()
                Else
                    db = New dbOperations("Select * From tblReceiptDtl Where InvoiceNo = '" & RemoveNull(row!InvoiceNo, "") & "' and ReceiptAmount <> 0")
                    dr = db.dbSelectQuery

                    If dr.HasRows = False Then
                        db = New dbOperations("Delete From tblInvoice Where InvoiceNo = '" & RemoveNull(row!InvoiceNo, "") & "'")
                        db.dbActionQuery()

                        row.Delete()
                    End If
                End If
            Next

            db = New dbOperations("Select Max(ReceiptDate) as ReceiptDate From tblReceiptMst Where Unit = '" & cmbUnit.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtLastPaymentDate.Value = dr!ReceiptDate
            End If

            db.Close()
            dr.Close()

            Dim cTotalAmount As Double

            For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
                cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
            Next

            txtAmount.Value = txtCashAmount.Value + txtAddOtherCharges.Value - txtDiscount.Value - cTotalAmount

            Call Totals()
        End If
    End Sub

    Private Sub cmdRescheduleAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRescheduleAdd.Click
        If cmbExtraCharges.SelectedValue <> "" And cmbPaymentType.SelectedValue <> "" Then
            MsgBox("Please Select Either Payment Type or Extra Charges")
            Exit Sub
        End If

        If txtInstallments.Value = 0 Then
            MsgBox("Please Input Installment")
            Exit Sub
        End If

        Dim cInstallment As Integer
        Dim cYear As Double
        Dim cMonth As Double
        Dim cTotalMonths As Double

        cInstallment = 1

        cYear = Year(DateAdd(DateInterval.Day, txtDelayDays.Value + txtDueDays.Value, txtLastPaymentDate.Value))
        cMonth = Month(DateAdd(DateInterval.Day, txtDelayDays.Value + txtDueDays.Value, txtLastPaymentDate.Value))
        cTotalMonths = Month(DateAdd(DateInterval.Day, txtDelayDays.Value + txtDueDays.Value, txtLastPaymentDate.Value))

        While cInstallment <= txtInstallments.Value
            For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
                If RemoveNull(row!PaymentType, "") = cmbPaymentType.SelectedValue And row!Installment = cInstallment And RemoveNull(row!PaymentType, "") <> "" Then
                    MsgBox("Payment Already found cannot insert duplicate")
                    Exit Sub
                End If
            Next

            Dim NewRow As DataRow = dbGrid.cDataTable.NewRow
            NewRow("ReservationNo") = txtReservationNo.Text

            If RemoveNull(cmbPaymentType.SelectedValue, "") <> "" Then
                NewRow("PaymentType") = cmbPaymentType.SelectedValue
            End If

            If RemoveNull(cmbExtraCharges.SelectedValue, "") <> "" Then
                NewRow("ExtraCharges") = cmbExtraCharges.SelectedValue
            End If

            Dim cDueDate As DateTime

            NewRow("Amount") = txtAmount.Value
            NewRow("Installment") = cInstallment
            NewRow("DueDays") = IIf(txtInstallments.Value > 1, RemoveNull(txtDelayDays.Value, 0) + (cInstallment * txtDueDays.Value), cInstallment * txtDueDays.Value)
            NewRow("NotDecided") = chkNotDecided.Checked

            If txtInstallments.Value > 1 Then
                If cInstallment > 1 Then
                    cMonth = cMonth + Math.Round(txtDueDays.Value / 30, 0)
                End If

                If cMonth >= 13 And cMonth < 25 Then
                    cMonth = cMonth - 12
                    cYear = cYear + 1
                End If

                cDueDate = Convert.ToDateTime(Trim(Str(cMonth)) + "/" + "01" + "/" + Trim(Str(cYear)))

                NewRow("DueDate") = cDueDate
            Else
                NewRow("DueDate") = DateAdd(DateInterval.Day, NewRow("DueDays"), txtLastPaymentDate.Value)
            End If



            cInstallment = cInstallment + 1

            dbGrid.cDataTable.Rows.Add(NewRow)
        End While

        Call Totals()
    End Sub

    Private Sub tdbGridPaymentPlan_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridPaymentPlan.AfterColUpdate
        If e.ColIndex = 6 Then
            Call Totals()
        End If
    End Sub

    Private Sub tdbGridPaymentPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridPaymentPlan.Click

    End Sub

    Private Sub cmdClearApplicant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        txtCustomerCode2.Text = ""
        txtCustomerName2.Text = ""
        txtCustomerEmail2.Text = ""
        txtCustomerMobile2.Text = ""
        txtCustomerEmail2.Text = ""
        txtCustomerNIC2.Text = ""
    End Sub

    Private Sub txtAddOtherCharges_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtAddOtherCharges.LostFocus
        Call Totals()
    End Sub

    Private Sub txtAddOtherCharges_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAddOtherCharges.TextChanged

    End Sub

    Private Sub chkApplyExtraLand_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApplyExtraLand.CheckedChanged
        Call Totals()
    End Sub

    Private Sub txtExtraSqFeetYds_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtExtraSqFeetYds.LostFocus
        Call Totals()
    End Sub

    Private Sub txtPerSqFeetCharges_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPerSqFeetCharges.LostFocus
        Call Totals()
    End Sub

    Private Sub cmdAgent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAgent.Click
        cmbAgent.SelectedValue = ShowList("Select tblAgent.Code,tblAgent.Name,tblAgentCompany.Name as Company,CommPer From tblAgent,tblAgentCompany Where tblAgent.AgentCompany = tblAgentCompany.Code Order By tblAgent.Name", "List of Agents", 1, 0)
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        Call Print("No")
    End Sub

    Sub Print(ByVal cPrint As String)
        Dim cSql As String

        cSql = "Select Mst.ReservationNo,Mst.ReservationDate,tblProjectFile.Name as Project,tblProjectType.Name as ProjectType,"
        cSql = cSql + "tblProjectPurpose.Name as ProjectPurpose,IsNull(tblCustomer.SLT,'') + ' ' + IsNull(tblCustomer.Name,'') as Customer,	tblCustomer.Address,tblCustomer.Mobile,tblCustomer.TelRes,tblCustomer.NICNo,"
        cSql = cSql + "tblUnitType.Name as UnitType,tblUnitFile.UnitNumber,Mst.CashAmount,Mst.LoanAmount,Mst.ExtraCharges,Mst.Discount,Mst.TotalRevenue,tblPaymentType.Name as PaymentType,Installment,DueDate,Amount,Case When IsNull(NotDecided,0) = 0 Then 'No' Else 'Yes' End as NotDecided,InvoiceNo,Mst.AddOtherCharges "
        cSql = cSql + "From	    tblReservationMst Mst,tblCustomer,tblProjectFile,tblProjectType,tblProjectPurpose,tblUnitFile,tblUnitType,tblReservationDtl Dtl,tblPaymentType "
        cSql = cSql + "Where    Mst.ReservationNo = Dtl.ReservationNo "
        cSql = cSql + "And		Mst.Customer = tblCustomer.Code "
        cSql = cSql + "And		Mst.Project = tblProjectFile.Code "
        cSql = cSql + "And		tblProjectFile.ProjectType = tblProjectType.Code "
        cSql = cSql + "And		tblProjectFile.ProjectPurpose = tblProjectPurpose.Code "
        cSql = cSql + "And		Mst.Unit = tblUnitFile.Code "
        cSql = cSql + "And		tblUnitFile.UnitType = tblUnitType.Code  "
        cSql = cSql + "And		Dtl.PaymentType = tblPaymentType.Code "
        cSql = cSql + "And      Mst.ReservationNo = '" & txtReservationNo.Text & "'"
        cSql = cSql + "Order By DueDate "

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptPaymentPlan

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "Receipt")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("Receipt")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
           fPreview.arv.Document.Printer.Print()
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call Print("Yes")
    End Sub

    Private Sub txtCashAmount_Leave(sender As Object, e As EventArgs) Handles txtCashAmount.LostFocus, txtLoanAmount.LostFocus, txtExtraCharges.LostFocus, txtDiscount.LostFocus, txtAddOtherCharges.LostFocus
        Call Totals()
    End Sub

    Private Sub txtCC_Leave(sender As Object, e As EventArgs) Handles txtCC.LostFocus

        db = New dbOperations("Select CC from tblReservationMst where isnull(CC,'') = '" & txtCC.Text & "' and Project = '" & cmbProject.SelectedValue & "' and isnull(Cancel,0) = 0")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            MsgBox("CC Already Exist")
            txtCC.Text = ""
            txtCC.Focus()
            Exit Sub
        End If
    End Sub

    Private Sub tdbGridPaymentPlan_ButtonClick(sender As Object, e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridPaymentPlan.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridPaymentPlan.RowCount > 0 Then
                tdbGridPaymentPlan.Delete()
                tdbGridPaymentPlan.UpdateData()
                Call Totals()
            End If
        End If
    End Sub
End Class