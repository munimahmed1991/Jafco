Imports System.Data
Imports System.Data.SqlClient
Imports System.Net
Imports System.Net.Mail
Imports System.IO

Public Class frmReceipt
    Dim dbGrid As BindGrid

    Enum Actions
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmReceipt_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim Unit As New BindCombo(cmbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim PaymentType As New BindCombo(tdbPaymentType, "Select Code,Name From tblPaymentType", "Name", "Code", True)
        Dim cBank As New BindCombo(cmbBank, "Select AccountName as Name,AccountCode as Code from tblAccounts Where (AccountType = 'Bank Book' or AccountType = 'Cash Book') and AccountLevel = 'Detail' order by AccountName", "Name", "Code", True, True, GLConString)
        Dim ExtraCharges As New BindCombo(tdbExtraCharges, "Select Code,Name From tblExtraCharges", "Name", "Code", True)
        Dim PaymentTypes As New BindCombo(cmbPaymentType, "Select Code,Name From tblPaymentType", "Name", "Code", True, True)
    End Sub

    Sub ClearControls()
        txtReceiptNo.Text = ""
        txtReceiptDate.Value = Today.Date
        cmbProject.SelectedValue = ""
        txtInstrumentNo.Text = ""
        txtInstrumentDate.Value = Today.Date
        txtBankName.Text = ""
        txtAmount.Value = 0
        cmbUnit.SelectedValue = ""
        cmbUnitType.SelectedValue = ""
        txtCustomerCode1.Text = ""
        txtCustomerCode2.Text = ""
        txtCustomerName1.Text = ""
        txtCustomerName2.Text = ""
        txtCustomerTel1.Text = ""
        txtCustomerTel2.Text = ""
        txtCustomerMobile1.Text = ""
        txtCustomerMobile2.Text = ""
        txtCustomerNIC1.Text = ""
        txtCustomerNIC2.Text = ""
        txtCustomerEmail1.Text = ""
        txtCustomerEmail2.Text = ""
        txtManualReceiptNo.Text = ""
        txtInvoiceDate.Value = Today.Date
        txtInstallment.Value = 1
        txtCancelDate.Value = Nothing
        cmbCancelReason.Text = ""
        chkUnOfficial.Checked = False
        cmbReceiptStatus.Text = "Process"

        tdbGridReceiptDetails.DataSource = Nothing
        tdbGridReceiptDetails.Columns("InvoiceAmount").FooterText = "0"
        tdbGridReceiptDetails.Columns("ReceiptAmount").FooterText = "0"
        tdbGridReceiptDetails.Columns("BalanceAmount").FooterText = "0"

        txtDateFrom.Value = DateFrom
        txtDateTo.Value = DateTo

        Call FillCombo()
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtReceiptNo.Enabled = True
                txtReceiptDate.Enabled = False
                cmbProject.Enabled = True
                cmbReceiptType.Enabled = False
                txtInstrumentNo.Enabled = False
                txtInstrumentDate.Enabled = False
                txtBankName.Enabled = False
                txtAmount.Enabled = False
                txtManualReceiptNo.Enabled = False
                cmbReceiptStatus.Enabled = False
                txtCancelDate.Enabled = False
                chkUnOfficial.Enabled = False

                cmdUnit.Enabled = False
                cmbCancelReason.Enabled = False

                tdbGridReceiptDetails.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtReceiptNo.Enabled = False
                txtReceiptDate.Enabled = False
                cmbProject.Enabled = False
                cmbReceiptType.Enabled = False
                txtInstrumentNo.Enabled = False
                txtInstrumentDate.Enabled = False
                txtBankName.Enabled = False
                txtAmount.Enabled = False
                txtManualReceiptNo.Enabled = False
                cmbReceiptStatus.Enabled = False
                txtCancelDate.Enabled = False
                chkUnOfficial.Enabled = False

                cmdUnit.Enabled = False
                cmbCancelReason.Enabled = False

                tdbGridReceiptDetails.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtReceiptNo.Enabled = False
                txtReceiptDate.Enabled = True
                cmbProject.Enabled = True
                cmbReceiptType.Enabled = True
                txtInstrumentNo.Enabled = True
                txtInstrumentDate.Enabled = True
                txtBankName.Enabled = True
                txtAmount.Enabled = True
                txtManualReceiptNo.Enabled = True
                cmbReceiptStatus.Enabled = True
                txtCancelDate.Enabled = True
                cmbCancelReason.Enabled = True
                chkUnOfficial.Enabled = True

                cmdUnit.Enabled = True

                tdbGridReceiptDetails.Enabled = True
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

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "RECEIPT") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "RECEIPT") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As dbOperations
                Dim DR As SqlDataReader

                Dim cVoucherNo As String

                DB = New dbOperations("Delete From tblReceiptDtl Where ReceiptNo = '" & txtReceiptNo.Text & "'")
                DB.dbActionQuery()

                DB = New dbOperations("Delete From tblReceiptMst Where ReceiptNo = '" & txtReceiptNo.Text & "'")
                DB.dbActionQuery()

                DB = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtReceiptNo.Text & "'")
                DR = DB.dbSelectQuery

                If DR.Read = True Then
                    DR.Close()

                    cVoucherNo = DR!VoucherNo
                End If

                DR.Close()
                DB.Close()

                DB = New dbOperations("Delete From tblJVDtl Where VoucherNo = '" & cVoucherNo & "'", GLConString)
                DB.dbActionQuery()

                DB = New dbOperations("Delete From tblJVMst Where VoucherNo = '" & cVoucherNo & "'", GLConString)
                DB.dbActionQuery()

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        cSql = "Select ReceiptNo,1 as Receipts,Case When IsNull(tblReceiptMst.Cancel,0) = 0 Then 'No' Else 'Yes' End as PaymentReturn,CancelReason as ReturnReason,tblReceiptMst.CancelDate as ReturnDate,Case When IsNull(tblReceiptMst.PDC,0) = 0 Then 'No' Else 'Yes' End as PDC,Case When IsNull(tblReceiptMst.PaymentInProcess,0) = 0 Then 'No' Else 'Yes' End as PaymentInProcess,Case When IsNull(tblReceiptMst.PaymentClear,0) = 0 Then 'No' Else 'Yes' End as PaymentClear,VoucherNo,Amount,ManualReceiptNo,ReceiptDate,tblProjectFile.Name as ProjectName,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit,ReceiptType,InstrumentNo,InstrumentDate,BankName,tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,tblCustomer.NICNo "
        cSql = cSql + "From tblReceiptMst,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile "
        cSql = cSql + "Where tblReceiptMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblReceiptMst.Customer = tblCustomer.Code "
        cSql = cSql + "And   tblReceiptMst.UnitType = tblUnitType.Code "
        cSql = cSql + "And   tblReceiptMst.Unit = tblUnitFile.Code "
        cSql = cSql + "And   tblReceiptMst.ReceiptDate Between '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "' "

        If cmbProject.SelectedValue <> "" Then
            cSql = cSql + "And tblReceiptMst.Project = '" & cmbProject.SelectedValue & "' "
        End If

        txtReceiptNo.Text = ShowList(cSql, "List of Receipt", 1, 0, "Receipts,Amount")

        If txtReceiptNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Sub DisplayRec()
        If txtReceiptNo.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblReceiptMst Where ReceiptNo = '" & txtReceiptNo.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtReceiptNo.Text = RemoveNull(DR!ReceiptNo, "")
                txtReceiptDate.Value = RemoveNull(DR!ReceiptDate, Today.Date)
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                cmbReceiptType.Text = RemoveNull(DR!ReceiptType, "")
                txtInstrumentNo.Text = RemoveNull(DR!InstrumentNo, "")
                txtInstrumentDate.Value = RemoveNull(DR!InstrumentDate, Today.Date)
                txtBankName.Text = RemoveNull(DR!BankName, "")
                txtAmount.Value = RemoveNull(DR!Amount, 0)
                txtManualReceiptNo.Text = RemoveNull(DR!ManualReceiptNo, "")

                If RemoveNull(DR!Cancel, 0) = 1 Then
                    cmbReceiptType.Text = "Return"
                End If

                If RemoveNull(DR!PaymentinProcess, 0) = 1 Then
                    cmbReceiptType.Text = "Process"
                End If


                If RemoveNull(DR!PaymentinProcess, 0) = 1 Then
                    cmbReceiptType.Text = "Process"
                End If

                If RemoveNull(DR!PaymentClear, 0) = 1 Then
                    cmbReceiptType.Text = "Clear"
                End If


                txtCancelDate.Value = RemoveNull(DR!CancelDate, Nothing)
                chkUnOfficial.Checked = RemoveNull(DR!UnOfficial, 0)

                cmbUnit.SelectedValue = RemoveNull(DR!Unit, "")
                cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")
                cmbCancelReason.Text = RemoveNull(DR!CancelReason, "")
                txtCC.Text = GetCC(cmbUnit.SelectedValue)


                txtCustomerCode1.Text = RemoveNull(DR!Customer, "")
                txtCustomerCode2.Text = RemoveNull(DR!Customer2, "")

                Call PickCustomerData1()
                Call PickCustomerData2()
                Call SetControls(Actions.Edit)
            Else
                MsgBox("Receipt Does Not Exist")
                Exit Sub
            End If
        Else
            Call SetControls(Actions.Entry)
            Call ClearControls()
        End If

        dbGrid = New BindGrid(tdbGridReceiptDetails, "Select ReceiptNo,InvoiceNo,InvoiceDate,PaymentType,ExtraCharges,Installment,InvoiceAmount,ReceiptAmount,BalanceAmount From tblReceiptDtl Where ReceiptNo = '" & txtReceiptNo.Text & "'")

        Call Totals()
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

    Sub Totals()
        Dim cTotalInvoiceAmount As Double
        Dim cTotalReceiptAmount As Double
        Dim cTotalBalanceAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalInvoiceAmount += Convert.ToDouble(RemoveNull(row("InvoiceAmount"), 0))
            cTotalReceiptAmount += Convert.ToDouble(RemoveNull(row("ReceiptAmount"), 0))
            cTotalBalanceAmount += Convert.ToDouble(RemoveNull(row("BalanceAmount"), 0))
        Next

        tdbGridReceiptDetails.Columns("InvoiceAmount").FooterText = Format(cTotalInvoiceAmount, "###,###,##0")
        tdbGridReceiptDetails.Columns("ReceiptAmount").FooterText = Format(cTotalReceiptAmount, "###,###,##0")
        tdbGridReceiptDetails.Columns("BalanceAmount").FooterText = Format(cTotalBalanceAmount, "###,###,##0")

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

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "RECEIPT") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean
        Dim db As dbOperations

        Dim dr As SqlDataReader

        Dim cTotalReceiptAmount As Double
        Dim cUnitAccount As String
        Dim cAccount As String
        Dim cSector As String

        Dim cForfeitedAccount As String

        If cmbReceiptStatus.Text = "Return" Then
            If txtCancelDate.Value = "Nothing" Then
                MsgBox("Please Input Return Date")
                Exit Sub
            End If
        End If

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalReceiptAmount += Convert.ToDouble(RemoveNull(row("ReceiptAmount"), 0))

            If row!BalanceAmount < 0 Then
                MsgBox("Receipt Cannot be Less Then Invoice Amount")
                Exit Sub
            End If
        Next

        If txtAmount.Value <> cTotalReceiptAmount Then
            MsgBox("Amount Must be Equal to the Receipt Amount")
            Exit Sub
        End If

        If cmbUnit.SelectedValue = "" Then
            MsgBox("Unit Cannot be Left Blank")
            Exit Sub
        End If

        If txtBankName.Text = "" Then
            MsgBox("Bank Cannot be Left Blank")
            Exit Sub
        End If

        If txtReceiptDate.Value >= DateFrom And txtReceiptDate.Value <= DateTo Then
            db = New dbOperations("Select * From tblUnitFile Where Code = '" & cmbUnit.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cUnitAccount = RemoveNull(dr!Account, "")
            End If

            db.Close()
            dr.Close()

            If cUnitAccount = "" Then
                MsgBox("Map Account for the Selected Unit - Contact Finance Department")
                Exit Sub
            End If

            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                If cmbReceiptType.Text = "Cash" Then
                    cAccount = RemoveNull(dr!CashAccount, "")
                Else
                    cAccount = RemoveNull(dr!ChequeAccount, "")
                End If

                cForfeitedAccount = RemoveNull(dr!ForfietAccount, "")
            End If

            'If cAccount = "" Then
            '    MsgBox("Please Map Cash & Cheque Account - Contact Finance Department")
            '    Exit Sub
            'End If

            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cSector = RemoveNull(dr!Sector, "")
            End If

            db.Close()
            dr.Close()

            'If cSector = "" Then
            '    MsgBox("Please Select Sector in Project File")
            '    Exit Sub
            'End If
        End If



        'If CheckDuplicate("txtManualReceiptNo", "ManualReceiptNo", txtManualReceiptNo.Text, txtReceiptNo.Text, "ReceiptNo", "Project = '" & cmbProject.SelectedValue & "'") = True Then
        '    MsgBox("Already Exist")
        '    Exit Sub
        'End If



        If txtReceiptNo.Text = "" Then
            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cPrefix = dr!Prefix
            End If

            If chkUnOfficial.Checked = True Then
                txtReceiptNo.Text = NextSerial("ReceiptNo", "tblReceiptMst", "00000000", "RCT" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")
            Else
                txtReceiptNo.Text = NextSerial("ReceiptNo", "tblReceiptMst", "00000000", "REC" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")
            End If

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblReceiptMst", "ReceiptNo = '" & txtReceiptNo.Text & "'")
        Query.AddFields("ReceiptNo", txtReceiptNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ReceiptDate", txtReceiptDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ReceiptType", cmbReceiptType.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("InstrumentNo", txtInstrumentNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("InstrumentDate", txtInstrumentDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("BankName", txtBankName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Amount", txtAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Unit", cmbUnit.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitType", cmbUnitType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer", txtCustomerCode1.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer2", txtCustomerCode2.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ManualReceiptNo", txtManualReceiptNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CC", txtCC.Text, ActionQueryBuilder.DataType.aString)

        If cmbReceiptStatus.Text = "Return" Then
            Query.AddFields("Cancel", 1, ActionQueryBuilder.DataType.aInteger)
        Else
            Query.AddFields("Cancel", 0, ActionQueryBuilder.DataType.aInteger)
        End If

        If cmbReceiptStatus.Text = "PDC" Then
            Query.AddFields("PDC", 1, ActionQueryBuilder.DataType.aInteger)
        Else
            Query.AddFields("PDC", 0, ActionQueryBuilder.DataType.aInteger)
        End If

        If cmbReceiptStatus.Text = "Process" Then
            Query.AddFields("PaymentinProcess", 1, ActionQueryBuilder.DataType.aInteger)
        Else
            Query.AddFields("PaymentinProcess", 0, ActionQueryBuilder.DataType.aInteger)
        End If

        If cmbReceiptStatus.Text = "Clear" Then
            Query.AddFields("PaymentClear", 1, ActionQueryBuilder.DataType.aInteger)
        Else
            Query.AddFields("PaymentClear", 0, ActionQueryBuilder.DataType.aInteger)
        End If

        Query.AddFields("CancelReason", cmbCancelReason.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnOfficial", chkUnOfficial.Checked, ActionQueryBuilder.DataType.aInteger)

        If cmbReceiptStatus.Text = "Return" Then
            Query.AddFields("CancelDate", txtCancelDate.Value, ActionQueryBuilder.DataType.aDate)
        End If

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
            CEmailTitle = cmbProject.Text + "-" + "Receipt Alert of Unit #" + cmbUnit.Text
            CEmailMessage = "Receipt# " + (txtReceiptNo.Text).ToString + " of " + txtAmount.Value.ToString + " paid on " + txtReceiptDate.Value.ToString + " by " + txtCustomerName1.Text.ToString + " in terms of " + cmbReceiptType.Text.ToString
            Call SendEmail(ToEmail, CEmailTitle, CEmailMessage, "", "", "")
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If


        dbGrid.SetCriteria = "ReceiptNo = '" & txtReceiptNo.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("ReceiptNo", txtReceiptNo.Text)
        dbGrid.Update()

        Dim cDescription As String

        If cmbReceiptStatus.Text = "Clear" Then
            If txtReceiptDate.Value >= DateFrom And txtReceiptDate.Value <= DateTo Then
                If RemoveNull(txtAmount.Value, 0) <> 0 Then
                    If cmbReceiptType.Text = "Cash" Then
                        cDescription = "Cash Recovery for Unit # : " + cmbUnit.Text + " from Customer : " + txtCustomerName1.Text
                        cVoucherNo = GenerateJV(txtReceiptNo.Text, txtReceiptDate.Value, cDescription, cSector, IIf(chkUnOfficial.Checked = True, "A", "B"))

                        If cmbBank.SelectedValue <> "" Then
                            GenerateJvDetails(cVoucherNo, RemoveNull(cmbBank.SelectedValue, ""), cDescription, txtReceiptNo.Text, txtReceiptDate.Value, txtAmount.Value, 0, "", cSector, GLConString, "", "")
                            GenerateJvDetails(cVoucherNo, cUnitAccount, cDescription, txtReceiptNo.Text, txtReceiptDate.Value, 0, txtAmount.Value, "", cSector, GLConString, "", "")
                        Else
                            GenerateJvDetails(cVoucherNo, cAccount, cDescription, txtReceiptNo.Text, txtReceiptDate.Value, txtAmount.Value, 0, "", cSector, GLConString, "", "")
                            GenerateJvDetails(cVoucherNo, cUnitAccount, cDescription, txtReceiptNo.Text, txtReceiptDate.Value, 0, txtAmount.Value, "", cSector, GLConString, "", "")
                        End If

                        dr.Close()
                        db.Close()

                        If MsgBox("Do You Want to See the Corresponding Voucher", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtReceiptNo.Text & "'", GLConString)
                            dr = db.dbSelectQuery()

                            If dr.Read() Then
                                Call frmMain.frmJvShow(dr!VoucherNo)
                            End If

                            db.Close()
                            dr.Close()
                        End If
                    Else
                        cDescription = cmbReceiptType.Text + " Recovery for Unit # : " + cmbUnit.Text + " from Customer : " + txtCustomerName1.Text
                        cVoucherNo = GenerateJV(txtReceiptNo.Text, txtReceiptDate.Value, cDescription, cSector, IIf(chkUnOfficial.Checked = True, "A", "B"))

                        If cmbBank.SelectedValue <> "" Then
                            GenerateJvDetails(cVoucherNo, RemoveNull(cmbBank.SelectedValue, ""), cDescription, txtInstrumentNo.Text, txtInstrumentDate.Value, txtAmount.Value, 0, "", cSector, GLConString, "", "")
                            GenerateJvDetails(cVoucherNo, cUnitAccount, cDescription, txtInstrumentNo.Text, txtInstrumentDate.Value, 0, txtAmount.Value, "", cSector, GLConString, "", "")
                        Else
                            GenerateJvDetails(cVoucherNo, cAccount, cDescription, txtInstrumentNo.Text, txtInstrumentDate.Value, txtAmount.Value, 0, "", cSector, GLConString, "", "")
                            GenerateJvDetails(cVoucherNo, cUnitAccount, cDescription, txtInstrumentNo.Text, txtInstrumentDate.Value, 0, txtAmount.Value, "", cSector, GLConString, "", "")
                        End If

                        dr.Close()
                        db.Close()

                        If MsgBox("Do You Want to See the Corresponding Voucher", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                            db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtReceiptNo.Text & "'", GLConString)
                            dr = db.dbSelectQuery()

                            If dr.Read() Then
                                Call frmMain.frmJvShow(dr!VoucherNo)
                            End If

                            db.Close()
                            dr.Close()
                        End If
                    End If

                    db = New dbOperations("Update tblReceiptMst Set VoucherNo = '" & cVoucherNo & "' Where ReceiptNo = '" & txtReceiptNo.Text & "'")
                    db.dbActionQuery()
                End If
            End If
        Else
            If txtReceiptDate.Value >= "10/1/2018" Then
                db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & txtReceiptNo.Text & "'", GLConString)
                dr = db.dbSelectQuery

                If dr.Read = True Then
                    dr.Close()

                    cVoucherNo = dr!VoucherNo
                End If

                dr.Close()
                db.Close()

                db = New dbOperations("Delete From tblJVDtl Where VoucherNo = '" & cVoucherNo & "'", GLConString)
                db.dbActionQuery()

                db = New dbOperations("Delete From tblJVMst Where VoucherNo = '" & cVoucherNo & "'", GLConString)
                db.dbActionQuery()
            End If
        End If

        If MsgBox("Do You Want to Print", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call Print("Yes")
        End If

        Call SetControls(Actions.Initial)
        Call ClearControls()
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

    Private Sub cmdUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnit.Click
        Dim cTotalRevenue As Double

        Dim cReservationNo As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        cSql = "Select ReservationNo,ReservationDate,tblProjectFile.Name as ProjectName,tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as Unit,tblReservationMst.CashAmount,tblReservationMst.LoanAmount,tblReservationMst.ExtraCharges,Discount,tblReservationMst.TotalRevenue,tblCustomer.NICNo,isnull(tblReservationMst.CC,'') as CC "
        cSql = cSql + "From tblReservationMst,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile "
        cSql = cSql + "Where tblReservationMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblReservationMst.Customer = tblCustomer.Code "
        cSql = cSql + "And   tblReservationMst.UnitType = tblUnitType.Code "
        cSql = cSql + "And   tblReservationMst.Unit = tblUnitFile.Code "
        cSql = cSql + "And   IsNull(tblReservationMst.Cancel,0) = 0 "
        cSql = cSql + "And   IsNull(tblUnitFile.Cancel,0) = 0 "
        cSql = cSql + "And   IsNull(tblReservationMst.Project,'') = '" & cmbProject.SelectedValue & "' "

        cReservationNo = ShowList(cSql, "List of Reservation", 0, 0)

        If cReservationNo <> "" Then
            db = New dbOperations("Select * From tblReservationMst Where ReservationNo = '" & cReservationNo & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cmbUnit.SelectedValue = RemoveNull(dr!Unit, "")
                cmbUnitType.SelectedValue = RemoveNull(dr!UnitType, "")

                txtReservationDate.Value = dr!ReservationDate
                txtCustomerCode1.Text = RemoveNull(dr!Customer, "")
                txtCustomerCode2.Text = RemoveNull(dr!Customer2, "")
                txtCC.Text = GetCC(cmbUnit.SelectedValue)
                cTotalRevenue = RemoveNull(dr!TotalRevenue, 0)

                Call PickCustomerData1()
                Call PickCustomerData2()
            End If

            db.Close()
            dr.Close()
        End If


        If cReservationNo <> "" Then
            Call RecoverUpto(cTotalRevenue)
        End If
    End Sub



    Sub RecoverUpto(ByVal cTotalRevenue As Double)
        Dim db As dbOperations
        Dim dr As SqlDataReader

        cSql = "Select SUM(Amount) as Amount From tblReceiptMst Where ReceiptNo <> '" & txtReceiptNo.Text & "' and Unit = '" & cmbUnit.SelectedValue & "' and IsNull(PDC,0) = 0 And IsNull(Cancel,0) = 0 and ReceiptDate <= '" & Format(txtReceiptDate.Value, "MM/dd/yyyy") & "'"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            If cTotalRevenue <> 0 And RemoveNull(dr!Amount, 0) <> 0 Then
                txtRecoveryUpto.Value = (dr!Amount / cTotalRevenue) * 100
            Else
                txtRecoveryUpto.Value = 0
            End If
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub cmdPickInvoices_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickInvoices.Click
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkIncludePenalty.Checked = True Then
            db = New dbOperations("Select InvoiceNo,Max(InvoiceDate) as InvoiceDate,PaymentType,ExtraCharges,Sum(InvoiceAmount) as InvoiceAmount,Sum(ReceiptAmount) as ReceiptAmount,Sum(InvoiceAmount) - Sum(ReceiptAmount) as BalanceAmount,Installment From BalanceReceipt Where Unit = '" & cmbUnit.SelectedValue & "' Group By InvoiceNo,ExtraCharges,PaymentType,Installment Having Sum(InvoiceAmount) - Sum(ReceiptAmount) <> 0 ")
            dr = db.dbSelectQuery
        Else
            db = New dbOperations("Select BalanceReceipt.InvoiceNo,Max(BalanceReceipt.InvoiceDate) as InvoiceDate,BalanceReceipt.PaymentType,BalanceReceipt.ExtraCharges,Sum(BalanceReceipt.InvoiceAmount) as InvoiceAmount,Sum(BalanceReceipt.ReceiptAmount) as ReceiptAmount,Sum(BalanceReceipt.InvoiceAmount) - Sum(BalanceReceipt.ReceiptAmount) as BalanceAmount,BalanceReceipt.Installment From BalanceReceipt,tblInvoice Where BalanceReceipt.InvoiceNo = tblInvoice.InvoiceNo and IsNull(tblInvoice.Penalty,0) = 0 and BalanceReceipt.Unit = '" & cmbUnit.SelectedValue & "' Group By BalanceReceipt.InvoiceNo,BalanceReceipt.ExtraCharges,BalanceReceipt.PaymentType,BalanceReceipt.Installment Having Sum(BalanceReceipt.InvoiceAmount) - Sum(BalanceReceipt.ReceiptAmount) <> 0 ")
            dr = db.dbSelectQuery
        End If


        If dr.HasRows = True Then
            dr.Read()

            Dim NewRow As DataRow = dbGrid.cDataTable.NewRow

            NewRow("ReceiptNo") = txtReceiptNo.Text
            NewRow("InvoiceNo") = dr!InvoiceNo
            NewRow("InvoiceDate") = dr!InvoiceDate
            NewRow("PaymentType") = dr!PaymentType
            NewRow("ExtraCharges") = dr!ExtraCharges
            NewRow("Installment") = dr!Installment
            NewRow("InvoiceAmount") = dr!BalanceAmount
            NewRow("ReceiptAmount") = 0
            NewRow("BalanceAmount") = dr!BalanceAmount

            dbGrid.cDataTable.Rows.Add(NewRow)

            For Each DataRow In dr
                Dim NewRow1 As DataRow = dbGrid.cDataTable.NewRow

                NewRow1("ReceiptNo") = txtReceiptNo.Text
                NewRow1("InvoiceNo") = dr!InvoiceNo
                NewRow1("InvoiceDate") = dr!InvoiceDate
                NewRow1("PaymentType") = dr!PaymentType
                NewRow1("ExtraCharges") = dr!ExtraCharges
                NewRow1("Installment") = dr!Installment
                NewRow1("InvoiceAmount") = dr!BalanceAmount
                NewRow1("ReceiptAmount") = 0
                NewRow1("BalanceAmount") = dr!BalanceAmount

                dbGrid.cDataTable.Rows.Add(NewRow1)
            Next
        End If

        Call Totals()
    End Sub

    Private Sub tdbGridReceiptDetails_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridReceiptDetails.AfterColUpdate
        tdbGridReceiptDetails.Columns("BalanceAmount").Value = RemoveNull(tdbGridReceiptDetails.Columns("InvoiceAmount").Value, 0) - RemoveNull(tdbGridReceiptDetails.Columns("ReceiptAmount").Value, 0)
        txtAmount.Text = RemoveNull(tdbGridReceiptDetails.Columns("ReceiptAmount").Value, 0)
        Call Totals()
    End Sub

    Sub Print(ByVal cPrint As String)
        Dim cSql As String

        cSql = "Select	1 as SNo,'Customer Copy' as ReceiptCopy,'' as ManualReceiptno,Mst.ReceiptNo,ReceiptDate,tblCustomer.Slt + ' ' + tblCustomer.Name + Case When Isnull(Customer2.Name,'') <> '' Then ' & ' Else '' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') as CustomerName,Mst.Amount,"
        cSql = cSql + "ReceiptType,Case When IsNull(ReceiptType,'') = 'Cash Cheque' Then 'Cash' Else InstrumentNo End as InstrumentNo,InstrumentDate,Case When IsNull(ReceiptType,'') = 'Cash Cheque' Then '' Else BankName End BankName,tblUnitFile.UnitNumber,Cast(tblUnitFile.Rooms as Varchar(10)) + ' Rooms' as Size,"
        cSql = cSql + "tblUnitType.Name as Type,tblBlock.Name as BlockName,tblUnitFile.Floors "
        cSql = cSql + "From	    tblReceiptMst Mst Left Outer Join tblCustomer Customer2 On Mst.Customer2 = Customer2.Code,tblCustomer,tblUnitFile,tblUnitType,tblBlock "
        cSql = cSql + "Where    Mst.Customer = tblCustomer.Code "
        cSql = cSql + "And		Mst.Unit = tblUnitFile.Code "
        cSql = cSql + "And		tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And		tblUnitFile.Block = tblBlock.Code "
        cSql = cSql + "And      Mst.ReceiptNo = '" & txtReceiptNo.Text & "' "
        cSql = cSql + "Union All "
        cSql = cSql + "Select	2 as SNo,'Office Copy' as ReceiptCopy,Mst.ManualReceiptno,Mst.ReceiptNo,ReceiptDate,tblCustomer.Slt + ' ' + tblCustomer.Name + Case When Isnull(Customer2.Name,'') <> '' Then ' & ' Else '' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') as CustomerName,Mst.Amount,"
        cSql = cSql + "ReceiptType,Case When IsNull(ReceiptType,'') = 'Cash Cheque' Then 'Cash' Else InstrumentNo End as InstrumentNo,InstrumentDate,Case When IsNull(ReceiptType,'') = 'Cash Cheque' Then '' Else BankName End BankName,tblUnitFile.UnitNumber,Cast(tblUnitFile.Rooms as Varchar(10)) + ' Rooms' as Size,"
        cSql = cSql + "tblUnitType.Name as Type,tblBlock.Name as BlockName,tblUnitFile.Floors "
        cSql = cSql + "From	    tblReceiptMst Mst Left Outer Join tblCustomer Customer2 On Mst.Customer2 = Customer2.Code,tblCustomer,tblUnitFile,tblUnitType,tblBlock "
        cSql = cSql + "Where    Mst.Customer = tblCustomer.Code "
        cSql = cSql + "And		Mst.Unit = tblUnitFile.code "
        cSql = cSql + "And		tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And		tblUnitFile.Block = tblBlock.Code "
        cSql = cSql + "And      Mst.ReceiptNo = '" & txtReceiptNo.Text & "' "
        'cSql = cSql + "Union All "
        'cSql = cSql + "Select	3 as SNo,Mst.ReceiptNo,ReceiptDate,tblCustomer.Slt + ' ' + tblCustomer.Name + Case When Isnull(Customer2.Name,'') <> '' Then ' & ' Else '' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') as CustomerName,Mst.Amount,"
        'cSql = cSql + "ReceiptType,Case When IsNull(ReceiptType,'') = 'Cash Cheque' Then 'Cash' Else InstrumentNo End as InstrumentNo,InstrumentDate,Case When IsNull(ReceiptType,'') = 'Cash Cheque' Then '' Else BankName End BankName,tblUnitFile.UnitNumber,Cast(tblUnitType.SqFeet as Varchar(10)) + ' Sq Feets' as SqFeet,"
        'cSql = cSql + "tblUnitType.Name as Type,tblBlock.Name as BlockName,tblUnitFile.Floors "
        'cSql = cSql + "From	    tblReceiptMst Mst Left Outer Join tblCustomer Customer2 On Mst.Customer2 = Customer2.Code,tblCustomer,tblUnitFile,tblUnitType,tblBlock "
        'cSql = cSql + "Where    Mst.Customer = tblCustomer.Code "
        'cSql = cSql + "And		Mst.Unit = tblUnitFile.code "
        'cSql = cSql + "And		tblUnitFile.UnitType = tblUnitType.Code "
        'cSql = cSql + "And		tblUnitFile.Block = tblBlock.Code "
        'cSql = cSql + "And      Mst.ReceiptNo = '" & txtReceiptNo.Text & "' "

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptReceipt

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

    Private Sub cmdPaymentType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPaymentType.Click
        Dim cReservationNo As String

        Dim db As New dbOperations("Select * From tblReservationMst Where Unit = '" & cmbUnit.SelectedValue & "' and IsNull(Cancel,0) = 0")
        Dim dr As SqlDataReader

        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cReservationNo = dr!ReservationNo
        End If

        db.Close()
        dr.Close()

        cmbPaymentType.SelectedValue = ShowList("Select tblReservationDtl.PaymentType as Code,tblPaymentType.Name as Name,tblReservationDtl.DueDate,Installment,Amount From tblReservationDtl,tblPaymentType Where tblReservationDtl.ReservationNo = '" & cReservationNo & "' and tblReservationDtl.PaymentType = tblPaymentType.Code and IsNull(tblReservationDtl.InvoiceNo,'') = ''", "List of Balance Payents", 0, 0)
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Select Project - Cannot Proceed")
            Exit Sub
        End If

        If txtInvoiceDate.Value = Nothing Then
            MsgBox("Input Invoice Date From - Cannot Proceed")
            Exit Sub
        End If


        Dim cSql As String
        Dim cInvoiceNo As String
        Dim cPrefix As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblInvoice Where Project = '" & cmbProject.SelectedValue & "' and Unit = '" & cmbUnit.SelectedValue & "' and PaymentType = '" & cmbPaymentType.SelectedValue & "' and Installment = " & txtInstallment.Value)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            MsgBox("Invoice Already Generated for the Selected Payment Type Invoice # : " + dr!InvoiceNo)
            Exit Sub
        End If

        db.Close()
        dr.Close()

        db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cPrefix = dr!Prefix
        End If

        db.Close()
        dr.Close()

        cSql = "Select	tblReservationMst.ReservationNo,Project,Customer,Customer2,UnitType,Unit,"
        cSql += "PaymentType, tblReservationDtl.ExtraCharges, Installment, DueDate, Amount "
        cSql += "From  tblReservationMst, tblReservationDtl "
        cSql += "Where tblReservationMst.ReservationNo = tblReservationDtl.ReservationNo "
        cSql += "And   tblReservationMst.Project = '" & cmbProject.SelectedValue & "' "
        cSql += "And   tblReservationMst.UnitType = '" & cmbUnitType.SelectedValue & "' "
        cSql += "And   tblReservationMst.Unit = '" & cmbUnit.SelectedValue & "' "
        cSql += "And   tblReservationDtl.PaymentType = '" & cmbPaymentType.SelectedValue & "' "
        cSql += "And   tblReservationDtl.Installment = " & txtInstallment.Value & " "
        cSql += "And   IsNull(tblReservationMst.Cancel,0) = 0 "

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cInvoiceNo = NextSerial("InvoiceNo", "tblInvoice", "00000000", "INV" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "' and IsNull(Penalty,0) = 0")

            cSql = "Insert Into tblInvoice(InvoiceNo,InvoiceDate,Project,Customer1,Customer2,UnitType,Unit,PaymentType,ExtraCharges,DueDate,Amount,Installment,NotDecided) Values('" & cInvoiceNo & "','" & Format(txtInvoiceDate.Value, "MM/dd/yyyy") & "','" & dr!Project & "','" & dr!Customer & "','" & dr!Customer2 & "','" & dr!UnitType & "','" & dr!Unit & "','" & dr!PaymentType & "','" & dr!ExtraCharges & "','" & Format(dr!DueDate, "MM/dd/yyyy") & "'," & dr!Amount & "," & dr!Installment & ",0)"


            db = New dbOperations(cSql)
            db.dbActionQuery()

            db = New dbOperations("Update tblReservationDtl Set InvoiceNo = '" & cInvoiceNo & "' Where PaymentType = '" & dr!PaymentType & "' and Installment = " & dr!Installment & " and ReservationNo In (Select ReservationNo From tbLReservationMst Where Unit = '" & dr!Unit & "')")
            db.dbActionQuery()

            For Each DataRow In dr
                cInvoiceNo = NextSerial("InvoiceNo", "tblInvoice", "00000000", "INV" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "' and IsNull(Penalty,0) = 0")

                cSql = "Insert Into tblInvoice(InvoiceNo,InvoiceDate,Project,Customer1,Customer2,UnitType,Unit,PaymentType,ExtraCharges,DueDate,Amount,Installment,NotDecided) Values('" & cInvoiceNo & "','" & Format(txtInvoiceDate.Value, "MM/dd/yyyy") & "','" & dr!Project & "','" & dr!Customer & "','" & dr!Customer2 & "','" & dr!UnitType & "','" & dr!Unit & "','" & dr!PaymentType & "','" & dr!ExtraCharges & "','" & Format(dr!DueDate, "MM/dd/yyyy") & "'," & dr!Amount & "," & dr!Installment & ",0)"

                db = New dbOperations(cSql)
                db.dbActionQuery()

                db = New dbOperations("Update tblReservationDtl Set InvoiceNo = '" & cInvoiceNo & "' Where PaymentType = '" & dr!PaymentType & "' and Installment = " & dr!Installment & " and ReservationNo In (Select ReservationNo From tbLReservationMst Where Unit = '" & dr!Unit & "')")
                db.dbActionQuery()
            Next

            MsgBox("Invoice Generated Successfully")
        End If
    End Sub

    Private Sub tdbGridReceiptDetails_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridReceiptDetails.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridReceiptDetails.RowCount > 0 Then
                tdbGridReceiptDetails.Delete()
                tdbGridReceiptDetails.UpdateData()
                Call Totals()
            End If
        End If
    End Sub

    Private Sub tdbGridReceiptDetails_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridReceiptDetails.Click

    End Sub

    Private Sub cmdInstallmentList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdInstallmentList.Click
        Dim cReservationNo As String

        Dim db As New dbOperations("Select * From tblReservationMst Where Unit = '" & cmbUnit.SelectedValue & "' and IsNull(Cancel,0) = 0")
        Dim dr As SqlDataReader

        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cReservationNo = dr!ReservationNo
        End If

        db.Close()
        dr.Close()

        txtInstallment.Value = ShowList("Select tblReservationDtl.PaymentType as Code,tblPaymentType.Name as Name,Installment,Amount From tblReservationDtl,tblPaymentType Where tblReservationDtl.PaymentType = '" & cmbPaymentType.SelectedValue & "' and tblReservationDtl.ReservationNo = '" & cReservationNo & "' and tblReservationDtl.PaymentType = tblPaymentType.Code and IsNull(tblReservationDtl.InvoiceNo,'') = ''", "List of Balance Payents", 0, 2)
    End Sub

    Private Sub cmdPickNextReceipt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPickNextReceipt.Click
        Dim cReceiptStart As String
        Dim cNextReceipt As String

        Dim cSql As String
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            If chkUnOfficial.Checked = True Then
                cReceiptStart = dr!UnOfficialReceiptStart
            Else
                cReceiptStart = dr!OfficialReceiptStart
            End If
        End If

        db.Close()
        dr.Close()

        If chkUnOfficial.Checked = True Then
            cSql = "Select Max(Cast(ManualReceiptNo as Numeric(9))) as ManualReceiptNo From tblReceiptMst Where Project = '" & cmbProject.SelectedValue & "' and IsNull(UnOfficial,0) = 1 and Substring(ManualReceiptNo,1,1) <> 'P'"

            db = New dbOperations(cSql)
            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                txtManualReceiptNo.Text = Strings.Right("000000" + Trim(Str(dr!ManualReceiptNo)), Len(cReceiptStart))
            Else
                txtManualReceiptNo.Text = cReceiptStart
            End If

            db.Close()
            dr.Close()
        Else
            cSql = "Select Max(Cast(ManualReceiptNo as Numeric(9))) as ManualReceiptNo From tblReceiptMst Where Project = '" & cmbProject.SelectedValue & "' and IsNull(UnOfficial,0) = 0  and Substring(ManualReceiptNo,1,1) <> 'P'"

            db = New dbOperations(cSql)
            dr = db.dbSelectQuery

            If dr.HasRows = True Then
                dr.Read()

                txtManualReceiptNo.Text = Strings.Right("000000" + Trim(Str(dr!ManualReceiptNo)), Len(cReceiptStart))
            Else
                txtManualReceiptNo.Text = cReceiptStart
            End If

            db.Close()
            dr.Close()
        End If
    End Sub

    Private Sub cmdPreview_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPreview.Click
        If cmbProject.Text = "EMPIRE BOULEVARD" Then
            Call Print("No")
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If cmbProject.Text = "EMPIRE BOULEVARD" Then
            Call Print("Yes")
        End If
    End Sub

    Private Sub cmdCheckOfficial_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCheckOfficial.Click
        If cmbUnit.SelectedValue = "" Then
            MsgBox("Unit Must be Selected")
            Exit Sub
        End If

        frmCheckOfficial.cUnit = cmbUnit.SelectedValue
        frmCheckOfficial.FillData()
        frmCheckOfficial.ShowDialog()
    End Sub

    Private Sub cmdLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLedger.Click
        Dim cSql As String

        Dim db As dbOperations
        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptGeneralLedger

        Call ProgressBar(25)

        Dim cAccount As String

        cSql = "Select * From tblUnitFile Where Code = '" & cmbUnit.SelectedValue & "'"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            cAccount = RemoveNull(dr!Account, "")
        End If

        dr.Close()
        db.Close()

        cSql = "Exec AccountingReports '0001','" & Format(DateFrom, "MM/dd/yyyy") & "','" & Format(txtReceiptDate.Value, "MM/dd/yyyy") & "','" & cAccount & "','" & cAccount & "','All','All','All','All',0,'General Ledger','','','',0,0,'Without Zero Balance','All','','','','Both','','','','',0,0,0,0,0,0,0,'1/1/2012','1/1/2012','1/1/2012','1/1/2012',1,'Voucher Date'"

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, GLConString)

        da.Fill(ds, "Receipt")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("Receipt")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)
        fPreview.Show()
        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cmbReceiptType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbReceiptType.SelectedIndexChanged

    End Sub
End Class