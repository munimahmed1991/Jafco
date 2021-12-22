Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmTransferPlot
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

        Dim UnitTypeFrom As New BindCombo(cmbUnitTypeFrom, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim UnitFrom As New BindCombo(cmbUnitFrom, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)

        Dim UnitTypeTo As New BindCombo(cmbUnitTypeTo, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim UnitTo As New BindCombo(cmbUnitTo, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)

        Dim PaymentType As New BindCombo(cmbPaymentType, "Select Code,Name From tblPaymentType", "Name", "Code", True, True)
    End Sub

    Sub ClearControls()
        txtTransferNo.Text = ""
        txtTransferDate.Value = Today.Date
        cmbProject.SelectedValue = ""
        txtAmount.Value = 0

        cmbUnitFrom.SelectedValue = ""
        cmbUnitTypeFrom.SelectedValue = ""
        cmbUnitTo.SelectedValue = ""
        cmbUnitTypeTo.SelectedValue = ""
        cmbPaymentType.SelectedValue = ""

        txtCustomerCode1.Text = ""
        txtCustomerName1.Text = ""
        txtCustomerTel1.Text = ""
        txtCustomerMobile1.Text = ""
        txtCustomerNIC1.Text = ""
        txtCustomerEmail1.Text = ""
        txtRemarks.Text = ""

        txtCustomerCode2.Text = ""
        txtCustomerName2.Text = ""
        txtCustomerTel2.Text = ""
        txtCustomerMobile2.Text = ""
        txtCustomerNIC2.Text = ""
        txtCustomerEmail2.Text = ""

        chkAmountTransfer.Checked = 0
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtTransferNo.Enabled = True
                txtTransferDate.Enabled = False
                cmbProject.Enabled = False
                txtAmount.Enabled = False
                cmbPaymentType.Enabled = False
                txtRemarks.Enabled = False

                cmdUnitFrom.Enabled = False
                cmdUnitTo.Enabled = False
                chkAmountTransfer.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtTransferNo.Enabled = False
                txtTransferDate.Enabled = False
                cmbProject.Enabled = False
                txtAmount.Enabled = False
                cmbPaymentType.Enabled = False
                txtRemarks.Enabled = False

                cmdUnitFrom.Enabled = False
                cmdUnitTo.Enabled = False
                chkAmountTransfer.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtTransferNo.Enabled = False
                txtTransferDate.Enabled = True
                cmbProject.Enabled = True
                txtAmount.Enabled = True
                cmbPaymentType.Enabled = True
                txtRemarks.Enabled = True

                cmdUnitFrom.Enabled = True
                cmdUnitTo.Enabled = True
                chkAmountTransfer.Enabled = True
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
        If CheckAccess("EditRights", UserId, "TRANSFER PLOT") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "TRANSFER PLOT") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtTransferNo.Text <> "" Then
            db = New dbOperations("Select * From tblTransferPlot Where TransferNo = '" & txtTransferNo.Text & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtTransferNo.Text = dr!TransferNo
                txtTransferDate.Value = dr!TransferDate
                cmbProject.SelectedValue = RemoveNull(dr!Project, "")
                txtAmount.Value = RemoveNull(dr!Amount, 0)
                cmbUnitFrom.SelectedValue = RemoveNull(dr!UnitFrom, "")
                cmbUnitTo.SelectedValue = RemoveNull(dr!UnitTo, "")
                txtCustomerCode1.Text = RemoveNull(dr!Customer1, "")
                txtCustomerCode2.Text = RemoveNull(dr!Customer2, "")
                cmbPaymentType.SelectedValue = RemoveNull(dr!PaymentType, "")
                chkAmountTransfer.Checked = RemoveNull(dr!AmountTransfer, 0)
                txtRemarks.Text = RemoveNull(dr!Remarks, "")

                Call UnitFromInformation()
                Call UnitToInformation()
                Call PickCustomerData1()
                Call PickCustomerData2()

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Transfer # Not Found")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "TRANSFER PLOT") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblTransferPlot Where TransferNo = '" & txtTransferNo.Text & "'")

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

        If cmbPaymentType.SelectedValue = "" Then
            MsgBox("Payment Cannot be Left Blank")
            Exit Sub
        End If

        If cmbUnitFrom.SelectedValue = "" Then
            MsgBox("Unit From Cannot be Left Blank")
            Exit Sub
        End If

        If txtCustomerCode2.Text = "" Then
            If cmbUnitTo.SelectedValue = "" Then
                MsgBox("Unit To Cannot be Left Blank")
                Exit Sub
            End If
        End If

        If txtTransferNo.Text = "" Then
            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cPrefix = dr!Prefix
            End If

            txtTransferNo.Text = NextSerial("TransferNo", "tblTransferPlot", "00000", "TU" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblTransferPlot", "TransferNo = '" & txtTransferNo.Text & "'")
        Query.AddFields("TransferNo", txtTransferNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("TransferDate", txtTransferDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Amount", txtAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("UnitFrom", cmbUnitFrom.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitTo", cmbUnitTo.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer1", txtCustomerCode1.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer2", txtCustomerCode2.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("PaymentType", cmbPaymentType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("AmountTransfer", chkAmountTransfer.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("Remarks", txtRemarks.Text, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        If chkAmountTransfer.Checked = True Then
            db = New dbOperations("Update tblReservationMst Set Cancel = 1,CancelDate = '" & Format(txtTransferDate.Value, "MM/dd/yyyy") & "',CancelCharges = 0 Where Unit = '" & cmbUnitFrom.SelectedValue & "'")
            db.dbActionQuery()

            db = New dbOperations("Update tblUnitFile Set Cancel = 1,CancelDate = '" & Format(txtTransferDate.Value, "MM/dd/yyyy") & "',CancelCharges = 0 Where Code = '" & cmbUnitFrom.SelectedValue & "'")
            db.dbActionQuery()

            db = New dbOperations("Select * From tblUnitFile Where Code = '" & cmbUnitFrom.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                MsgBox("Unit Cancelled Successfully Please Save Again to Add in Inventory")

                dr.Read()

                frmUnitFile.MdiParent = frmMain
                frmUnitFile.Show()

                frmUnitFile.txtCode.Text = dr!Code

                frmUnitFile.DisplayRec()

                frmUnitFile.txtCode.Text = ""
                frmUnitFile.txtCashAmount.Value = 0
                frmUnitFile.txtLoanAmount.Value = 0
                frmUnitFile.txtTotalRevenue.Value = 0

                frmUnitFile.chkCancel.Checked = False
                frmUnitFile.txtCancelDate.Value = Nothing

                Call frmUnitFile.SetControls(frmUnitFile.Actions.Entry)

                Call frmUnitFile.PickExtraCharges()

                Call UpdateReservation()
                Call UpdateInvoices()
                Call UpdateReceipts()
            End If
        Else
            If txtCustomerCode2.Text = "" Then
                Call UpdateReservation()
                Call UpdateInvoices()
                Call UpdateReceipts()
            Else
                db = New dbOperations("Update tblReservationMst Set Customer = '" & txtCustomerCode2.Text & "' Where Unit = '" & cmbUnitFrom.SelectedValue & "'")
                db.dbActionQuery()
            End If
        End If

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Sub UpdateReceipts()
        If cmbPaymentType.SelectedValue <> "" Then
            db = New dbOperations("Update tblReceiptDtl Set PaymentType = '" & cmbPaymentType.SelectedValue & "' Where ReceiptNo In (Select ReceiptNo From tblReceiptMst Where Unit = '" & cmbUnitFrom.SelectedValue & "')")
            db.dbActionQuery()
        End If

        db = New dbOperations("Update tblReceiptMst Set Unit = '" & cmbUnitTo.SelectedValue & "',UnitType = '" & cmbUnitTypeTo.SelectedValue & "' Where Unit = '" & cmbUnitFrom.SelectedValue & "'")
        db.dbActionQuery()
    End Sub

    Sub UpdateInvoices()
        If cmbPaymentType.SelectedValue <> "" Then
            db = New dbOperations("Update tblInvoice Set Unit = '" & cmbUnitTo.SelectedValue & "',PaymentType = '" & cmbPaymentType.SelectedValue & "',UnitType = '" & cmbUnitTypeTo.SelectedValue & "' Where Unit = '" & cmbUnitFrom.SelectedValue & "'")
            db.dbActionQuery()
        Else
            db = New dbOperations("Update tblInvoice Set Unit = '" & cmbUnitTo.SelectedValue & "',UnitType = '" & cmbUnitTypeTo.SelectedValue & "' Where Unit = '" & cmbUnitFrom.SelectedValue & "'")
            db.dbActionQuery()
        End If
    End Sub

    Sub UpdateReservation()
        Dim cCashAmount As Double
        Dim cLoanAmount As Double
        Dim cExtraCharges As Double

        cSql = "Select * From tblUnitFile Where Code = '" & cmbUnitTo.SelectedValue & "' and IsNull(Cancel,0) = 0"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            cCashAmount = RemoveNull(dr!CashAmount, 0)
            cLoanAmount = RemoveNull(dr!LoanAmount, 0)
            cExtraCharges = RemoveNull(dr!ExtraChargesAmount1, 0) + RemoveNull(dr!ExtraChargesAmount2, 0) + RemoveNull(dr!ExtraChargesAmount3, 0) + RemoveNull(dr!ExtraChargesAmount4, 0) + RemoveNull(dr!ExtraChargesAmount5, 0) + RemoveNull(dr!ExtraChargesAmount6, 0) + RemoveNull(dr!ExtraChargesAmount7, 0) + RemoveNull(dr!ExtraChargesAmount8, 0) + RemoveNull(dr!ExtraChargesAmount9, 0) + RemoveNull(dr!ExtraChargesAmount10, 0) + RemoveNull(dr!ExtraChargesAmount11, 0) + RemoveNull(dr!ExtraChargesAmount12, 0) + RemoveNull(dr!ExtraChargesAmount13, 0) + RemoveNull(dr!ExtraChargesAmount14, 0) + RemoveNull(dr!ExtraChargesAmount15, 0)

            db.Close()
            dr.Close()

            cSql = "Select * From tblReservationMst Where Unit = '" & cmbUnitFrom.SelectedValue & "'"

            db = New dbOperations(cSql)
            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                cSql = "Update tblReservationMst Set Unit = '" & cmbUnitTo.SelectedValue & "',UnitType = '" & cmbUnitTypeTo.SelectedValue & "',CashAmount = " & cCashAmount & ",LoanAmount = " & cLoanAmount & ",ExtraCharges = " & cExtraCharges & ",TotalRevenue = " & cCashAmount + cLoanAmount + cExtraCharges - RemoveNull(dr!Discount, 0) & " Where ReservationNo = '" & dr!ReservationNo & "'"

                db = New dbOperations(cSql)
                db.dbActionQuery()

                If cmbPaymentType.SelectedValue <> "" Then
                    cSql = "Update tblReservationDtl Set PaymentType = '" & cmbPaymentType.SelectedValue & "' Where ReservationNo = '" & dr!ReservationNo & "'"

                    db = New dbOperations(cSql)
                    db.dbActionQuery()
                End If

                cSql = "Delete From tblReservationDtl Where IsNull(Invoiceno,'') = '' and ReservationNo = '" & dr!ReservationNo & "'"

                db = New dbOperations(cSql)
                db.dbActionQuery()
            End If

            db.Close()
            dr.Close()
        End If
    End Sub

    Private Sub cmdUnitFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitFrom.Click
        Dim cReservationNo As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        cSql = "Select ReservationNo,ReservationDate,tblProjectFile.Name as ProjectName,tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit,tblReservationMst.CashAmount,tblReservationMst.LoanAmount,tblReservationMst.ExtraCharges,Discount,tblReservationMst.TotalRevenue,tblCustomer.NICNo "
        cSql = cSql + "From tblReservationMst,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile "
        cSql = cSql + "Where tblReservationMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblReservationMst.Customer = tblCustomer.Code "
        cSql = cSql + "And   tblReservationMst.UnitType = tblUnitType.Code "
        cSql = cSql + "And   tblReservationMst.Unit = tblUnitFile.Code "
        cSql = cSql + "And   tblReservationMst.Project = tblProjectFile.Code "

        cReservationNo = ShowList(cSql, "List of Reservation", 0, 0)


        If cReservationNo <> "" Then
            db = New dbOperations("Select * From tblReservationMst Where ReservationNo = '" & cReservationNo & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cmbUnitFrom.SelectedValue = RemoveNull(dr!Unit, "")
                cmbUnitTypeFrom.SelectedValue = RemoveNull(dr!UnitType, "")

                txtCustomerCode1.Text = RemoveNull(dr!Customer, "")

                Call PickCustomerData1()
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

    Private Sub cmdUnitTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitTo.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project First in Search")
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
        cSql = cSql + ",tblProjectFile,tblUnitType,tblBlock "
        cSql = cSql + "Where tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And tblUnitFile.Project = tblProjectFile.Code "
        cSql = cSql + "And tblUnitFile.Block = tblBlock.Code "
        cSql = cSql + "And IsNull(tblUnitFile.Cancel,0) = 0 "
        cSql = cSql + "And tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "

        If chkAmountTransfer.Checked = False Then
            cSql = cSql + "And tblUnitfile.Code Not In (Select Unit From tblReservationMst Where IsNull(Cancel,0) = 0) "
        End If

        cSql = cSql + "Order By tblUnitFile.Code "

        cmbUnitTo.SelectedValue = ShowList(cSql, "List of Units", 1, 0)

        Call UnitToInformation()
    End Sub

    Sub UnitToInformation()
        db = New dbOperations("Select * From tblUnitFile Where Code = '" & cmbUnitTo.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            cmbUnitTypeTo.SelectedValue = RemoveNull(dr!UnitType, "")
        End If

        db.Close()
        dr.Close()
    End Sub

    Sub UnitFromInformation()
        db = New dbOperations("Select * From tblUnitFile Where Code = '" & cmbUnitFrom.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            cmbUnitTypeFrom.SelectedValue = RemoveNull(dr!UnitType, "")
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        cSql = "Select TransferNo,TransferDate,tblProjectFile.Name as ProjectName,Amount as Charges,UnitFrom.UnitNumber as UnitFrom,UnitTypeFrom.Name as UnitTypeFrom,UnitTo.UnitNumber as UnitTo,UnitTypeTo.Name as UnitTypeTo,Remarks "
        cSql += "From tblTransferPlot Left Outer Join tblUnitFile UnitTo Left Outer Join tblUnitType UnitTypeTo On UnitTo.UnitType = UnitTypeTo.Code On tblTransferPlot.UnitTo = UnitTo.Code,tblProjectFile,tblUnitFile UnitFrom,tblUnitType UnitTypeFrom "
        cSql += "Where tblTransferPlot.Project = tblProjectFile.Code "
        cSql += "And   tblTransferPlot.UnitFrom = UnitFrom.Code "
        cSql += "And   UnitFrom.UnitType = UnitTypeFrom.Code "

        txtTransferNo.Text = ShowList(cSql, "List of Transfer Plot", 0, 0)

        If txtTransferNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cmdCustomerToList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCustomerToList.Click
        txtCustomerCode2.Text = ShowList("Select tblCustomer.Code,Ltrim(Rtrim(Slt)) + Ltrim(Rtrim(tblCustomer.Name)) as Customer,FatherHusbandName,NicNo,TelRes,TelOffice,Mobile,tblCountry.Name as Country,tblCity.Name as City,tblAreaFile.Name as Area,1 as Customers,Occupation,Email,Address,Company,Designation,AddressOffice From tblCustomer Left Outer Join tblCountry On tblCountry.Code = tblCustomer.Country  Left Outer Join tblCity On tblCity.Code = tblCustomer.City  Left Outer Join tblAreaFile On tblAreaFile.Code = tblCustomer.Area Order By tblCustomer.Code", "List of Country", 1, 0, "Customers")

        Call PickCustomerData2()
    End Sub

    Private Sub cmdClearApplicant_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClearApplicant.Click
        txtCustomerCode2.Text = ""
        txtCustomerName2.Text = ""
        txtCustomerEmail2.Text = ""
        txtCustomerMobile2.Text = ""
        txtCustomerEmail2.Text = ""
        txtCustomerNIC2.Text = ""
    End Sub
End Class