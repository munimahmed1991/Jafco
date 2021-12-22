Imports System.Data
Imports System.Data.SqlClient

Public Class frmDocumentAudit
    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmCountry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetControls(Actions.Initial)
        Call ClearControls()
        Call FormCenter(Me)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub ClearControls()
        txtEntryNo.Text = ""
        txtEntryDate.Value = Today.Date
        cmbProject.SelectedValue = ""
        cmbUnitType.SelectedValue = ""
        cmbUnit.SelectedValue = ""

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

        chkAllReceiptFile.Checked = False
        chkAppartmentLayoutSigned.Checked = False
        chkFinalPriceMatchSystem.Checked = False
        chkLoanNotDecided.Checked = False
        chkNIC.Checked = False
        chkPaymentMatchSystem.Checked = False
        chkPaymentScheduleSigned.Checked = False
        chkPhotos.Checked = False
        chkUndertakingSigned.Checked = False
        txtDocumentRemarks.Text = ""

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim Unit As New BindCombo(cmbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtEntryNo.Enabled = True
                txtEntryDate.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False
                cmbUnit.Enabled = False

                chkAllReceiptFile.Enabled = False
                chkAppartmentLayoutSigned.Enabled = False
                chkFinalPriceMatchSystem.Enabled = False
                chkLoanNotDecided.Enabled = False
                chkNIC.Enabled = False
                chkPaymentMatchSystem.Enabled = False
                chkPaymentScheduleSigned.Enabled = False
                chkPhotos.Enabled = False
                chkUndertakingSigned.Enabled = False
                txtDocumentRemarks.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtEntryNo.Enabled = False
                txtEntryDate.Enabled = True
                cmbProject.Enabled = True
                cmbUnitType.Enabled = True
                cmbUnit.Enabled = True

                chkAllReceiptFile.Enabled = True
                chkAppartmentLayoutSigned.Enabled = True
                chkFinalPriceMatchSystem.Enabled = True
                chkLoanNotDecided.Enabled = True
                chkNIC.Enabled = True
                chkPaymentMatchSystem.Enabled = True
                chkPaymentScheduleSigned.Enabled = True
                chkPhotos.Enabled = True
                chkUndertakingSigned.Enabled = True
                txtDocumentRemarks.Enabled = True
        End Select
    End Sub

    Public Sub SetButtons(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                cmdSearch.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = False
                cmdExit.Enabled = True
            Case Actions.Entry
                cmdSearch.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False
        End Select
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Sub DisplayRec()
        If txtEntryNo.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblReservationMst Where ReservationNo = '" & txtEntryNo.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtEntryNo.Text = DR!ReservationNo
                txtEntryDate.Value = RemoveNull(DR!ReservationDate, Nothing)
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")
                cmbUnit.SelectedValue = RemoveNull(DR!Unit, "")
                txtCustomerCode1.Text = RemoveNull(DR!Customer, "")
                txtCustomerCode2.Text = RemoveNull(DR!Customer2, "")

                chkAllReceiptFile.Checked = RemoveNull(DR!AllReceiptFile, 0)
                chkAppartmentLayoutSigned.Checked = RemoveNull(DR!AppartmentLayoutSigned, 0)
                chkFinalPriceMatchSystem.Checked = RemoveNull(DR!FinalPriceMatchSystem, 0)
                chkLoanNotDecided.Checked = RemoveNull(DR!LoanNotDecided, 0)
                chkNIC.Checked = RemoveNull(DR!NIC, 0)
                chkPaymentMatchSystem.Checked = RemoveNull(DR!PaymentMatchSystem, 0)
                chkPaymentScheduleSigned.Checked = RemoveNull(DR!PaymentScheduleSigned, 0)
                chkPhotos.Checked = RemoveNull(DR!Photos, 0)
                chkUndertakingSigned.Checked = RemoveNull(DR!UndertakingSigned, 0)
                txtDocumentRemarks.Text = RemoveNull(DR!DocumentRemarks, "")

                Call PickCustomerData1()
                Call PickCustomerData2()

                DB.Close()

                Call SetControls(Actions.Entry)
            Else
                MsgBox("Document Code Does Not Exist")
                Exit Sub
            End If
        End If
    End Sub

    Sub PickCustomerData1()
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select tblCustomer.Code,Ltrim(Rtrim(Slt)) + ' ' + Ltrim(Rtrim(tblCustomer.Name)) as Customer,FatherHusbandName,NicNo,TelRes,TelOffice,Mobile,tblCountry.Name as Country,tblCity.Name as City,tblAreaFile.Name as Area,1 as Customers,Occupation,Email,Address,Company,Designation,AddressOffice From tblCustomer Left Outer Join tblCountry On tblCountry.Code = tblCustomer.Country  Left Outer Join tblCity On tblCity.Code = tblCustomer.City  Left Outer Join tblAreaFile On tblAreaFile.Code = tblCustomer.Area Where tblCustomer.Code = '" & txtCustomerCode1.Text & "'")
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

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim db As dbOperations
        Dim dr As SqlDataReader

        Dim cSql As String

        cSql = "Update tblReservationMst Set UndertakingSigned = " & IIf(chkUndertakingSigned.Checked = False, 0, 1) & ","
        cSql = cSql + "LoanNotDecided = " & IIf(chkLoanNotDecided.Checked = False, 0, 1) & ","
        cSql = cSql + "NIC = " & IIf(chkNIC.Checked = False, 0, 1) & ","
        cSql = cSql + "Photos = " & IIf(chkPhotos.Checked = False, 0, 1) & ","
        cSql = cSql + "PaymentScheduleSigned = " & IIf(chkPaymentScheduleSigned.Checked = False, 0, 1) & ","
        cSql = cSql + "AppartmentLayoutSigned = " & IIf(chkAppartmentLayoutSigned.Checked = False, 0, 1) & ","
        cSql = cSql + "FinalPriceMatchSystem = " & IIf(chkFinalPriceMatchSystem.Checked = False, 0, 1) & ","
        cSql = cSql + "AllReceiptFile = " & IIf(chkAllReceiptFile.Checked = False, 0, 1) & ","
        cSql = cSql + "PaymentMatchSystem = " & IIf(chkPaymentMatchSystem.Checked = False, 0, 1) & ","
        cSql = cSql + "DocumentRemarks = '" & txtDocumentRemarks.Text & "' "
        cSql = cSql + "Where ReservationNo = '" & txtEntryNo.Text & "'"

        db = New dbOperations(cSql)
        db.dbActionQuery()

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = ChrW(Keys.Return) Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cSql As String

        cSql = "Select ReservationNo,1 as Reservation,ReservationDate,tblProjectFile.Name as ProjectName,tblCustomer.Name as CustomerName,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit, "
        cSql = cSql + "Case When IsNull(UndertakingSigned,0) = 0 Then 'No' Else 'Yes' End as [Undertaking Signed],"
        cSql = cSql + "Case When IsNull(LoanNotDecided,0) = 0 Then 'No' Else 'Yes' End as [Loan Not Decided],"
        cSql = cSql + "Case When IsNull(NIC,0) = 0 Then 'No' Else 'Yes' End as [NIC],"
        cSql = cSql + "Case When IsNull(Photos,0) = 0 Then 'No' Else 'Yes' End as [2 Photos],"
        cSql = cSql + "Case When IsNull(PaymentScheduleSigned,0) = 0 Then 'No' Else 'Yes' End as [Payment Schedule Signed],"
        cSql = cSql + "Case When IsNull(AppartmentLayoutSigned,0) = 0 Then 'No' Else 'Yes' End as [Appartment Layout Signed],"
        cSql = cSql + "Case When IsNull(FinalPriceMatchSystem,0) = 0 Then 'No' Else 'Yes' End as [Final Price Match with System],"
        cSql = cSql + "Case When IsNull(AllReceiptFile,0) = 0 Then 'No' Else 'Yes' End as [All Receipt in File],"
        cSql = cSql + "DocumentRemarks "
        cSql = cSql + "From tblReservationMst Left Outer Join tblAgent Left Outer Join tblAgentCompany On tblAgentCompany.Code = tblAgent.AgentCompany On tblAgent.Code = tblReservationMst.Agent Left Outer Join tblScheme On tblScheme.Code = tblReservationMst.Scheme,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile "
        cSql = cSql + "Where tblReservationMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblReservationMst.Customer = tblCustomer.Code "
        cSql = cSql + "And   tblReservationMst.UnitType = tblUnitType.Code "
        cSql = cSql + "And   tblReservationMst.Unit = tblUnitFile.Code "
        cSql = cSql + "And   IsNull(tblReservationMst.Cancel,0) = 0 "

        txtEntryNo.Text = ShowList(cSql, "List of Reservations", 1, 0, "", , "ProjectName", , "ProjectName")

        If txtEntryNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub
End Class