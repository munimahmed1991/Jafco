Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmScheme
    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmScheme_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCombo()
        Call ClearControls()
        Call FormCenter(Me)
        Call SetControls(Actions.Initial)
    End Sub

    Sub FillCombo()
        Dim Name As New BindCombo(cmbName, "Select Name From tblScheme", "Name", "Name", True, True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
    End Sub

    Sub ClearControls()
        txtCode.Text = ""

        cmbName.Text = ""
        cmbProject.SelectedValue = ""
        cmbUnitType.SelectedValue = ""

        txtCashAmount.Value = 0
        txtLoanAmount.Value = 0
        txtTotalRevenue.Value = 0
    End Sub

    Sub SetControls(ByVal A As Actions)
        Select Case A
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True

                cmbName.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False

                txtCashAmount.Enabled = False
                txtLoanAmount.Enabled = False
                txtTotalRevenue.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False

                cmbName.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False

                txtCashAmount.Enabled = False
                txtLoanAmount.Enabled = False
                txtTotalRevenue.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False

                cmbName.Enabled = True
                cmbProject.Enabled = True
                cmbUnitType.Enabled = True

                txtCashAmount.Enabled = True
                txtLoanAmount.Enabled = True
                txtTotalRevenue.Enabled = True
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

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "SCHEME FILE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblScheme Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code

                cmbName.Text = RemoveNull(DR!Name, "")
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")

                txtCashAmount.Value = RemoveNull(DR!CashAmount, 0)
                txtLoanAmount.Value = RemoveNull(DR!LoanAmount, 0)
                txtTotalRevenue.Value = RemoveNull(DR!TotalAmount, 0)

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Unit Type Code Does Not Exist")
                Exit Sub
            End If

            DB.Close()
            DR.Close()
        Else
            Call SetControls(Actions.Entry)
            Call ClearControls()
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "SCHEME FILE") = -1 Then
            Call SetControls(Actions.Entry)
            cmbProject.Enabled = False
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "SCHEME FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblScheme Where Code = '" & txtCode.Text & "'")

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
        Dim cPrefix As String

        Call CalcTotal()

        Dim db As dbOperations
        Dim dr As SqlDataReader

        If txtCode.Text = "" Then
            txtCode.Text = NextSerial("Code", "tblScheme", "0000")

            cAdd = True
        Else
            cAdd = False
        End If

        'If CheckDuplicate("tblScheme", "Name", cmbName.Text, txtCode.Text, "Code") = True Then
        '    MsgBox("Already Exist")

        '    If cAdd = True Then
        '        txtCode.Text = ""
        '    End If

        '    Exit Sub
        'End If

        txtTotalRevenue.Value = txtCashAmount.Value + txtLoanAmount.Value

        Query.Refresh()
        Query.SetQueryInformation("tblScheme", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)

        Query.AddFields("Name", cmbName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitType", cmbUnitType.SelectedValue, ActionQueryBuilder.DataType.aString)

        Query.AddFields("CashAmount", txtCashAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("LoanAmount", txtLoanAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("TotalAmount", txtTotalRevenue.Value, ActionQueryBuilder.DataType.aDecimal)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtCode.Text = ShowList("Select tblScheme.Code,tblScheme.Name,tblProjectFile.Name as Project,tblUnitType.Name as UnitType,tblScheme.CashAmount,tblScheme.LoanAmount,tblScheme.TotalAmount From tblScheme,tblProjectFile,tblUnitType Where tblScheme.UnitType = tblUnitType.Code and tblScheme.Project = tblProjectFile.Code", "List of Scheme", 1, 0)

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub txtLoanAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoanAmount.LostFocus
        Call CalcTotal()
    End Sub

    Sub CalcTotal()
        txtTotalRevenue.Value = RemoveNull(txtCashAmount.Value, 0) + RemoveNull(txtLoanAmount.Value, 0)
    End Sub

    Private Sub txtCashAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashAmount.LostFocus
        Call CalcTotal()
    End Sub

    Private Sub cmdUnitType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitType.Click
        cmbUnitType.SelectedValue = ShowList("Select Code,Name From tblUnitType Where Project = '" & cmbProject.SelectedValue & "'", "List of Unit Type", 1, 0)
    End Sub
End Class