Imports System.Data
Imports System.Data.SqlClient

Public Class frmInvoice
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
        txtInvoiceNo.Text = ""
        txtInvoiceDate.Value = Today.Date
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

        cmbPaymentType.SelectedValue = ""
        cmbExtraCharges.SelectedValue = ""
        txtDueDate.Value = Nothing
        txtAmount.Value = 0
        txtInstallments.Value = 0

        chkNotDecided.Checked = False

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim Unit As New BindCombo(cmbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)
        Dim PaymentType As New BindCombo(cmbPaymentType, "Select Code,Name From tblPaymentType", "Name", "Code", True, True)
        Dim ExtraCharges As New BindCombo(cmbExtraCharges, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtInvoiceNo.Enabled = True
                txtInvoiceDate.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False
                cmbUnit.Enabled = False
                cmbPaymentType.Enabled = False
                cmbExtraCharges.Enabled = False
                txtDueDate.Enabled = False
                txtAmount.Enabled = False
                txtInstallments.Enabled = False

                cmdUnitType.Enabled = False
                cmdUnit.Enabled = False
                cmbPaymentType.Enabled = False
                cmdExtraCharges.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtInvoiceNo.Enabled = False
                txtInvoiceDate.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False
                cmbUnit.Enabled = False
                cmbPaymentType.Enabled = False
                cmbExtraCharges.Enabled = False
                txtDueDate.Enabled = False
                txtAmount.Enabled = False
                txtInstallments.Enabled = False

                cmdUnitType.Enabled = False
                cmdUnit.Enabled = False
                cmbPaymentType.Enabled = False
                cmdExtraCharges.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtInvoiceNo.Enabled = False
                txtInvoiceDate.Enabled = True
                cmbProject.Enabled = True
                cmbUnitType.Enabled = True
                cmbUnit.Enabled = True
                cmbPaymentType.Enabled = True
                cmbExtraCharges.Enabled = True
                txtDueDate.Enabled = True
                txtAmount.Enabled = True
                txtInstallments.Enabled = True

                cmdUnitType.Enabled = True
                cmdUnit.Enabled = True
                cmbPaymentType.Enabled = True
                cmdExtraCharges.Enabled = True
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

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "INVOICE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As dbOperations
                Dim DR As SqlDataReader

                DB = New dbOperations("Select * From tblReceiptDtl Where InvoiceNo = '" & txtInvoiceNo.Text & "' and ReceiptAmount > 0 ")
                dr = DB.dbSelectQuery

                If DR.HasRows = True Then
                    MsgBox("Invoice Cannot be Deleted Receipt Already Generated")
                    Exit Sub
                End If


                DB = New dbOperations("Update tblReservationDtl Set InvoiceNo = '' Where PaymentType = '" & cmbPaymentType.SelectedValue & "' and Installment = " & txtInstallments.Value & " and ReservationNo In (Select ReservationNo From tbLReservationMst Where Unit = '" & cmbUnit.SelectedValue & "')")
                DB.dbActionQuery()

                DB = New dbOperations("Delete From tblInvoice Where InvoiceNo = '" & txtInvoiceNo.Text & "'")
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
        If CheckAccess("EditRights", UserId, "INVOICE") = -1 Then
            Call SetControls(Actions.Entry)
            cmbProject.Enabled = False
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "INVOICE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtInvoiceNo.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblInvoice Where InvoiceNo = '" & txtInvoiceNo.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtInvoiceNo.Text = DR!InvoiceNo
                txtInvoiceDate.Value = RemoveNull(DR!InvoiceDate, Nothing)
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")
                cmbUnit.SelectedValue = RemoveNull(DR!Unit, "")
                txtCustomerCode1.Text = RemoveNull(DR!Customer1, "")
                txtCustomerCode2.Text = RemoveNull(DR!Customer2, "")
                cmbPaymentType.SelectedValue = RemoveNull(DR!PaymentType, "")
                cmbExtraCharges.SelectedValue = RemoveNull(DR!ExtraCharges, "")
                txtDueDate.Value = RemoveNull(DR!DueDate, Nothing)
                txtAmount.Value = RemoveNull(DR!Amount, 0)
                txtInstallments.Value = RemoveNull(DR!Installment, 0)
                chkNotDecided.Checked = RemoveNull(DR!NotDecided, 0)

                Call PickCustomerData1()
                Call PickCustomerData2()

                DB.Close()

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Country Code Does Not Exist")
                Exit Sub
            End If
        Else
            Call SetControls(Actions.Entry)
            Call ClearControls()
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
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean

        Dim db As dbOperations
        Dim dr As SqlDataReader


        If txtInvoiceNo.Text = "" Then
            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cPrefix = dr!Prefix
            End If

            txtInvoiceNo.Text = NextSerial("InvoiceNo", "tblInvoice", "00000000", "INV" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")

            MsgBox("InvoiceNo Generated is " & txtInvoiceNo.Text)

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblInvoice", "InvoiceNo = '" & txtInvoiceNo.Text & "'")
        Query.AddFields("InvoiceNo", txtInvoiceNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("InvoiceDate", txtInvoiceDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitType", cmbUnitType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Unit", cmbUnit.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer1", txtCustomerCode1.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer2", txtCustomerCode2.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("PaymentType", cmbPaymentType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges", cmbExtraCharges.SelectedValue, ActionQueryBuilder.DataType.aString)

        If chkNotDecided.Checked = False Then
            Query.AddFields("DueDate", txtDueDate.Value, ActionQueryBuilder.DataType.aDate)
        Else
            Query.AddFields("DueDate", txtInvoiceDate.Value, ActionQueryBuilder.DataType.aDate)
        End If

        Query.AddFields("Amount", txtAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Installment", txtInstallments.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("NotDecided", chkNotDecided.Checked, ActionQueryBuilder.DataType.aInteger)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        db = New dbOperations("Update tblReservationDtl Set InvoiceNo = '" & txtInvoiceNo.Text & "' Where PaymentType = '" & cmbPaymentType.SelectedValue & "' and Installment = " & txtInstallments.Value & " and ReservationNo In (Select ReservationNo From tbLReservationMst Where Unit = '" & cmbUnit.SelectedValue & "')")
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

        cSql = "Select InvoiceNo,InvoiceDate,Cast(Month(InvoiceDate) as Varchar(2)) + '-' + Cast(Year(InvoiceDate) as Varchar(4)) as InvoiceMonth,tblProjectFile.Name as ProjectName,tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit,tblPaymentType.Name as PaymentType,tblInvoice.Installment,tblInvoice.Amount "
        cSql = cSql + "From tblInvoice,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile,tblPaymentType "
        cSql = cSql + "Where tblInvoice.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblInvoice.Customer1 = tblCustomer.Code "
        cSql = cSql + "And   tblInvoice.UnitType = tblUnitType.Code "
        cSql = cSql + "And   tblInvoice.Unit = tblUnitFile.Code "
        cSql = cSql + "And   tblInvoice.PaymentType = tblPaymentType.Code "


        txtInvoiceNo.Text = ShowList(cSql, "List of Invoices", 1, 0, "Amount", , "InvoiceMonth,ProjectName")

        If txtInvoiceNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdUnitType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitType.Click
        If cmbUnit.SelectedValue <> "" Then
            MsgBox("Unit Type Cannot be Changed - Unit Already Selected")
            Exit Sub
        End If

        cmbUnitType.SelectedValue = ShowList("Select tblUnitType.Code,tblUnitType.Name as UnitType,tblProjectFile.Name as Project,CashAmount,LoanAmount,TotalRevenue From tblUnitType,tblProjectFile Where tblUnitType.Project = '" & cmbProject.SelectedValue & "' and tblUnitType.Project = tblProjectFile.Code Order By tblUnitType.Code", "List of Unit Type", 1, 0)
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

        cSql = "Select tblUnitFile.Code,tblProjectFile.Name as Project,tblUnitFile.UnitNumber,tblBlock.Name as Block,tblUnitType.Name as UnitType,1 as Unit,tblUnitFile.CashAmount,tblUnitFile.LoanAmount,tblUnitFile.TotalRevenue, "
        cSql = cSql + "IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as ExtraCharges,"
        cSql = cSql + "tblUnitFile.TotalRevenue + IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as GrossTotal"

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
        cSql = cSql + ",tblReservationMst,tblProjectFile,tblUnitType,tblBlock "
        cSql = cSql + "Where tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And tblUnitFile.Project = tblProjectFile.Code "
        cSql = cSql + "And tblUnitFile.Block = tblBlock.Code "
        cSql = cSql + "And tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And tblUnitFile.UnitType = '" & cmbUnitType.SelectedValue & "' "
        cSql = cSql + "And tblUnitFile.Code = tblReservationMst.Unit "
        cSql = cSql + "And IsNull(tblUnitFile.Cancel,0) = 0 "
        cSql = cSql + "Order By tblUnitFile.Code "

        cmbUnit.SelectedValue = ShowList(cSql, "List of Units", 1, 0)

        Call PickUnitInformation()
        Call PickCustomerData1()
        Call PickCustomerData2()
    End Sub

    Sub PickUnitInformation()
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * from tblReservationMst Where Unit = '" & cmbUnit.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            txtCustomerCode1.Text = dr!Customer
            txtCustomerCode2.Text = dr!Customer2
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub cmdPaymentType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaymentType.Click
        Dim cSql As String
        Dim cKeyColumn As String

        cSql = "Select Unit,PaymentType as Code,tblPaymentType.Name as PaymentType,Installment,DueDate,Amount,NotDecided,Ltrim(Rtrim(PaymentType)) + ' ' + Ltrim(Rtrim(Cast(Installment as Varchar(2)))) as KeyColumn "
        cSql = cSql + "From  tblReservationMst,tblReservationDtl,tblPaymentType "
        cSql = cSql + "Where tblReservationMst.ReservationNo = tblReservationDtl.ReservationNo "
        cSql = cSql + "And   tblReservationDtl.PaymentType = tblPaymentType.Code "
        cSql = cSql + "And   tblReservationMst.Unit = '" & cmbUnit.SelectedValue & "' "
        cSql = cSql + "And   Ltrim(Rtrim(PaymentType)) + ' ' + Ltrim(Rtrim(Cast(Installment as Varchar(2))))  Not In (Select Ltrim(Rtrim(PaymentType)) + ' ' + Ltrim(Rtrim(Cast(Installment as Varchar(2)))) as KeyColumn from tblInvoice Where Unit = '" & cmbUnit.SelectedValue & "') "

        cKeyColumn = ShowList(cSql, "List of Balance Payment", 0, 7)

        If cKeyColumn <> "" Then
            Dim db As dbOperations
            Dim dr As SqlDataReader

            cSql = "Select Unit,PaymentType as Code,tblPaymentType.Name as PaymentType,Installment,DueDate,Amount,NotDecided,Ltrim(Rtrim(PaymentType)) + ' ' + Ltrim(Rtrim(Cast(Installment as Varchar(2)))) as KeyColumn "
            cSql = cSql + "From  tblReservationMst,tblReservationDtl,tblPaymentType "
            cSql = cSql + "Where tblReservationMst.ReservationNo = tblReservationDtl.ReservationNo "
            cSql = cSql + "And   tblReservationDtl.PaymentType = tblPaymentType.Code "
            cSql = cSql + "And   tblReservationMst.Unit = '" & cmbUnit.SelectedValue & "' "
            cSql = cSql + "And   Ltrim(Rtrim(PaymentType)) + ' ' + Ltrim(Rtrim(Cast(Installment as Varchar(2)))) = '" & cKeyColumn & "'"

            db = New dbOperations(cSql)
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cmbPaymentType.SelectedValue = dr!Code
                chkNotDecided.Checked = RemoveNull(dr!NotDecided, 0)
                txtDueDate.Value = RemoveNull(dr!DueDate, txtInvoiceDate.Value)
                txtAmount.Value = RemoveNull(dr!Amount, 0)
                txtInstallments.Value = RemoveNull(dr!Installment, 0)
            End If

            db.Close()
            dr.Close()
        End If
    End Sub

    Private Sub cmdExtraCharges_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExtraCharges.Click
        Dim cSql As String
        Dim cKeyColumn As String

        cSql = "Select Unit,ExtrCharges as Code,tblExtraCharges.Name as ExtraCharges,Installment,DueDate,Amount,NotDecided,Ltrim(Rtrim(ExtrCharges)) as KeyColumn "
        cSql = cSql + "From  tblReservationMst,tblReservationDtl,tblExtraCharges "
        cSql = cSql + "Where tblReservationMst.ReservationNo = tblReservationDtl.ReservationNo "
        cSql = cSql + "And   tblReservationDtl.PaymentType = tblExtraCharges.Code "
        cSql = cSql + "And   tblReservationMst.Unit = '" & cmbUnit.SelectedValue & "' "
        cSql = cSql + "And   Ltrim(Rtrim(ExtrCharges)) Not In (Select Ltrim(Rtrim(ExtrCharges)) as KeyColumn from tblInvoice Where Unit = '" & cmbUnit.SelectedValue & "') "

        cKeyColumn = ShowList(cSql, "List of Balance Payment", 0, 7)

        Dim db As dbOperations
        Dim dr As SqlDataReader

        cSql = "Select Unit,ExtrCharges as Code,tblExtraCharges.Name as PaymentType,Installment,DueDate,Amount,NotDecided,Ltrim(Rtrim(ExtrCharges)) as KeyColumn "
        cSql = cSql + "From  tblReservationMst,tblReservationDtl,tblExtraCharges "
        cSql = cSql + "Where tblReservationMst.ReservationNo = tblReservationDtl.ReservationNo "
        cSql = cSql + "And   tblReservationDtl.PaymentType = tblExtraCharges.Code "
        cSql = cSql + "And   tblReservationMst.Unit = '" & cmbUnit.SelectedValue & "' "
        cSql = cSql + "And   Ltrim(Rtrim(ExtrCharges)) = '" & cKeyColumn & "'"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cmbExtraCharges.SelectedValue = dr!Code
            chkNotDecided.Checked = RemoveNull(dr!NotDecided, 0)
            txtDueDate.Value = RemoveNull(dr!DueDate, txtInvoiceDate.Value)
            txtAmount.Value = RemoveNull(dr!Amount, 0)
            txtInstallments.Value = RemoveNull(dr!Installment, 0)
        End If

        db.Close()
        dr.Close()
    End Sub
End Class