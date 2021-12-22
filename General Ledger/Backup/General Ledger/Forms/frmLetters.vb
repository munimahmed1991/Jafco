Imports System.Data
Imports System.Data.SqlClient

Public Class frmLetters
    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmCurrency_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
        txtLetterType.Text = ""
        cmbProject.SelectedValue = ""
        txtCustomerCode1.Text = ""
        txtCustomerEmail1.Text = ""
        txtCustomerMobile1.Text = ""
        txtCustomerName1.Text = ""
        txtCustomerNIC1.Text = ""
        txtCustomerTel1.Text = ""
        cmbUnitType.SelectedValue = ""
        cmbUnit.SelectedValue = ""
        txtRemarks.Text = ""
        txtLetterRef.Text = ""

        txtDateFrom.Value = DateFrom
        txtDateTo.Value = DateTo

        chkSent.Checked = False
        txtSentDate.Value = Nothing

        chkLetterPrint.Checked = False
        txtPrintDate.Value = Nothing

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

                txtEntryNo.Enabled = False
                txtEntryDate.Enabled = False
                txtLetterType.Enabled = False
                cmbProject.ReadOnly = False
                txtCustomerCode1.Enabled = False
                txtCustomerEmail1.Enabled = False
                txtCustomerMobile1.Enabled = False
                txtCustomerName1.Enabled = False
                txtCustomerNIC1.Enabled = False
                txtCustomerTel1.Enabled = False
                cmbUnitType.Enabled = False
                cmbUnit.Enabled = False
                txtRemarks.Enabled = False
                chkSent.Enabled = False
                txtSentDate.Enabled = False

                chkLetterPrint.Enabled = False
                txtPrintDate.Enabled = False
                txtLetterRef.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtEntryNo.Enabled = False
                txtEntryDate.Enabled = False
                txtLetterType.Enabled = False
                cmbProject.ReadOnly = False
                txtCustomerCode1.Enabled = False
                txtCustomerEmail1.Enabled = False
                txtCustomerMobile1.Enabled = False
                txtCustomerName1.Enabled = False
                txtCustomerNIC1.Enabled = False
                txtCustomerTel1.Enabled = False
                cmbUnitType.Enabled = False
                cmbUnit.Enabled = False
                txtRemarks.Enabled = False
                chkSent.Enabled = False
                txtSentDate.Enabled = False
                chkLetterPrint.Enabled = False
                txtPrintDate.Enabled = False
                txtLetterRef.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtEntryNo.Enabled = False
                txtEntryDate.Enabled = False
                txtLetterType.Enabled = False
                cmbProject.ReadOnly = False
                txtCustomerCode1.Enabled = False
                txtCustomerEmail1.Enabled = False
                txtCustomerMobile1.Enabled = False
                txtCustomerName1.Enabled = False
                txtCustomerNIC1.Enabled = False
                txtCustomerTel1.Enabled = False
                cmbUnitType.Enabled = False
                cmbUnit.Enabled = False
                txtRemarks.Enabled = True
                chkSent.Enabled = False
                txtSentDate.Enabled = False
                chkLetterPrint.Enabled = False
                txtPrintDate.Enabled = False
                txtLetterRef.Enabled = True
        End Select
    End Sub

    Public Sub SetButtons(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                cmdSearch.Enabled = True
                cmdEdit.Enabled = False
                cmdSave.Enabled = False
                cmdUndo.Enabled = False
                cmdExit.Enabled = True
            Case Actions.Edit
                cmdSearch.Enabled = True
                cmdEdit.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = False
            Case Actions.Entry
                cmdSearch.Enabled = False
                cmdEdit.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False
        End Select
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("DeleteRights", UserId, "LETTER HISTORY") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblCurrency Where Code = '" & txtEntryNo.Text & "'")

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
        If CheckAccess("EditRights", UserId, "LETTER HISTORY") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtEntryNo.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblLetters Where EntryNo = '" & txtEntryNo.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtEntryNo.Text = DR!EntryNo
                txtEntryDate.Value = RemoveNull(DR!EntryDate, Today.Date)
                txtLetterType.Text = RemoveNull(DR!LetterType, "")
                txtCustomerCode1.Text = RemoveNull(DR!Customer, "")
                cmbUnit.SelectedValue = RemoveNull(DR!Unit, "")
                txtRemarks.Text = RemoveNull(DR!Remarks, "")
                chkSent.Checked = RemoveNull(DR!SenttoCustomer, 0)
                txtLetterRef.Text = RemoveNull(DR!PreviousLetters, "")

                If RemoveNull(DR!SenttoCustomer, 0) = 1 Then
                    txtSentDate.Value = DR!SentDate
                End If

                chkLetterPrint.Checked = RemoveNull(DR!LetterPrint, 0)

                If RemoveNull(DR!LetterPrint, 0) = 1 Then
                    txtPrintDate.Value = DR!PrintDate
                End If

                cmbProject.SelectedValue = RemoveNull(DR!Project, "")

                DB.Close()

                DB = New dbOperations("Select * From tblCustomer Where Code = '" & txtCustomerCode1.Text & "'")
                DR = DB.dbSelectQuery

                If DR.HasRows Then
                    DR.Read()

                    txtCustomerEmail1.Text = RemoveNull(DR!Email, "")
                    txtCustomerMobile1.Text = RemoveNull(DR!Mobile, "")
                    txtCustomerName1.Text = RemoveNull(DR!Name, "")
                    txtCustomerNIC1.Text = RemoveNull(DR!NICNo, "")
                    txtCustomerTel1.Text = RemoveNull(DR!TelRes, "")
                End If

                DR.Close()
                DB.Close()

                DB = New dbOperations("Select * From tblUnitFile Where Code = '" & cmbUnit.SelectedValue & "'")
                DR = DB.dbSelectQuery

                If DR.HasRows Then
                    DR.Read()

                    cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")
                End If

                DB.Close()
                DR.Close()

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Letter Does Not Exist")
                Exit Sub
            End If
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder

        Query.Refresh()
        Query.SetQueryInformation("tblLetters", "EntryNo = '" & txtEntryNo.Text & "'")
        Query.AddFields("Remarks", txtRemarks.Text, ActionQueryBuilder.DataType.aString)

        Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtEntryNo.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Dim cSql As String

        cSql = "Select tblLetters.EntryNo,tblLetters.EntryDate,Cast(DatePart(Year,EntryDate) as Varchar(4)) + '-' + Right('0' + Cast(DatePart(Month,EntryDate) as Varchar(2)),2) as LetterMonth,tblLetters.LetterType,"
        cSql += "tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,"
        cSql += "tblUnitfile.UnitNumber,tblUnitType.Name as UnitType,"
        cSql += "Case When IsNull(SenttoCustomer,0) = 0 Then 'No' Else 'Yes' End as LetterSent,SentDate,"
        cSql += "Case When IsNull(LetterPrint,0) = 0 Then 'No' Else 'Yes' End as LetterPrint,PrintDate,"
        cSql += "Remarks,tblProjectFile.Name as ProjectName,IsNull(DueAmount,0) as DueAmount,1 as Total "
        cSql += "From  tblLetters, tblCustomer, tblUnitFile, tblUnitType, tblProjectFile "
        cSql += "Where tblLetters.Customer = tblCustomer.Code "
        cSql += "And   tblLetters.Unit = tblUnitFile.Code "
        cSql += "And   tblUnitFile.UnitType = tblUnitType.Code "
        cSql += "And   tblLetters.Project = tblProjectFile.Code "

        If cmbProject.SelectedValue <> "" Then
            cSql += "And tblProjectFile.Name = '" & cmbProject.Text & "' "
        End If

        cSql += "And   tblLetters.EntryDate Between '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "'"

        txtEntryNo.Text = ShowList(cSql, "List of Letters", 1, 0, "DueAmount,Total")

        If txtEntryNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtEntryNo.TextChanged

    End Sub

    Private Sub cmbName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub cmdDelete_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "LETTER HISTORY") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim db As dbOperations

                db = New dbOperations("Insert Into tblCancelLetters Select * From tblLetters Where EntryNo = '" & txtEntryNo.Text & "'")
                db.dbActionQuery()

                db = New dbOperations("Delete From tblLetters Where EntryNo = '" & txtEntryNo.Text & "'")
                db.dbActionQuery()

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSearchCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchCancel.Click
        cSql = "Select tblCancelLetters.EntryNo,tblCancelLetters.EntryDate,Cast(DatePart(Year,EntryDate) as Varchar(4)) + '-' + Right('0' + Cast(DatePart(Month,EntryDate) as Varchar(2)),2) as LetterMonth,tblCancelLetters.LetterType,"
        cSql += "tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,"
        cSql += "tblUnitfile.UnitNumber,tblUnitType.Name as UnitType,"
        cSql += "Case When IsNull(SenttoCustomer,0) = 0 Then 'No' Else 'Yes' End as LetterSent,SentDate,"
        cSql += "Case When IsNull(LetterPrint,0) = 0 Then 'No' Else 'Yes' End as LetterPrint,PrintDate,"
        cSql += "Remarks,tblProjectFile.Name as ProjectName,IsNull(DueAmount,0) as DueAmount,1 as Total "
        cSql += "From  tblCancelLetters, tblCustomer, tblUnitFile, tblUnitType, tblProjectFile "
        cSql += "Where tblCancelLetters.Customer = tblCustomer.Code "
        cSql += "And   tblCancelLetters.Unit = tblUnitFile.Code "
        cSql += "And   tblUnitFile.UnitType = tblUnitType.Code "
        cSql += "And   tblCancelLetters.Project = tblProjectFile.Code "

        If cmbProject.SelectedValue <> "" Then
            cSql += "And tblProjectFile.Name = '" & cmbProject.Text & "' "
        End If

        cSql += "And   tblCancelLetters.EntryDate Between '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "'"

        ShowList(cSql, "List of Letters", 1, 0, "DueAmount,Total")
    End Sub
End Class