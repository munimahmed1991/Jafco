Imports System.Data
Imports System.Data.SqlClient

Public Class FrmSecurityFile
    Private dbGridInput As BindGrid
    Private dbGridReport As BindGrid
    Private dbModule As BindGrid
    Private EditButtonPress As Boolean
    Dim MasterQuery As ActionQueryBuilder

    Private Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum
    Private Sub FrmSecurityFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call ClearControls()
        Call SetControls(Actions.Initial)
        Call InitControls()
    End Sub

    Private Sub DisplayRec()
        Dim dr As SqlDataReader = Nothing
        Dim cSql As String = "Select * from tblUsers Where Userid = '" & txtUserID.Text & "' and CompanyId = '" & cCompanyId & "'"
        Dim db As New dbOperations(cSql, dr)
        If dr.HasRows Then
            dr.Read()
            txtUserName.Text = dr!UserName
            txtPassword.Text = dr!Password

            If dr!UserType = "A" Then
                cmbUserType.SelectedIndex = 0
            ElseIf dr!UserType = "U" Then
                cmbUserType.SelectedIndex = 1
            ElseIf dr!UserType = "V" Then
                cmbUserType.SelectedIndex = 2
            ElseIf dr!UserType = "T" Then
                cmbUserType.SelectedIndex = 3
            ElseIf dr!UserType = "P" Then
                cmbUserType.SelectedIndex = 4
            End If

            Call SetControls(Actions.Edit)
        Else
            Call SetControls(Actions.Initial)
        End If

        dbGridInput = New BindGrid(TDBGrid1, "Select * from tblUserDetail Where UserId = '" & txtUserID.Text & "' and CompanyId = '" & cCompanyId & "' and OptionType = 'INPUT'")
        dbGridReport = New BindGrid(TDBGrid2, "Select * from tblUserDetail Where UserId = '" & txtUserID.Text & "' and CompanyId = '" & cCompanyId & "' and OptionType = 'REPORT'")

        Call FillGrid()
        Call FilterGrid()
    End Sub

    Private Sub FilterGrid()
        Dim cModulePrefix As String

        cModulePrefix = tdbList.Columns(0).Value
        dbGridInput.cDataView.RowFilter = "ModuleName = '" & cModulePrefix & "'"

        If cModulePrefix = "GL" Then
            TDBGrid1.Splits(0).DisplayColumns(5).Visible = True
            TDBGrid1.Splits(0).DisplayColumns(6).Visible = True
            TDBGrid1.Splits(0).DisplayColumns(7).Visible = True
            TDBGrid1.Splits(0).DisplayColumns(8).Visible = True

            TDBGrid1.Columns(6).Caption = "Cheque Edit"
            TDBGrid1.Columns(7).Caption = "Account Edit"
            TDBGrid1.Columns(8).Caption = "Amount Edit"
        ElseIf cModulePrefix = "ADMN" Then
            TDBGrid1.Splits(0).DisplayColumns(5).Visible = False
            TDBGrid1.Splits(0).DisplayColumns(6).Visible = False
            TDBGrid1.Splits(0).DisplayColumns(7).Visible = False
            TDBGrid1.Splits(0).DisplayColumns(8).Visible = False
        End If

        dbGridReport.cDataView.RowFilter = "ModuleName = '" & cModulePrefix & "'"
    End Sub
    Private Sub FillGrid()
        Dim dr As SqlDataReader = Nothing
        Dim db As New dbOperations("Select * From tblOptionDetail Where ModuleName + OptionName Not In(Select ModuleName + OptionName From tblUserDetail Where CompanyId = '" & cCompanyId & "' and UserId = '" & txtUserID.Text & "')", dr)

        While dr.Read
            If UCase(dr!OptionType) = "REPORT" Then
                Dim Row As DataRow = dbGridReport.cDataTable.NewRow
                Row("OptionName") = dr!OptionName
                Row("ModuleName") = dr!ModuleName
                dbGridReport.cDataTable.Rows.Add(Row)
            Else
                Dim Row As DataRow = dbGridInput.cDataTable.NewRow
                Row("OptionName") = dr!OptionName
                Row("ModuleName") = dr!ModuleName
                dbGridInput.cDataTable.Rows.Add(Row)
            End If
        End While
        dr.Close()
        db.Close()
    End Sub

    Private Sub InitControls()
        dbModule = New BindGrid(tdbList, "Select * from tblModule")
    End Sub
    Private Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtUserID.Enabled = False
                txtPassword.Enabled = False
                txtUserName.Enabled = False
                cmbUserType.Enabled = False
                TDBGrid1.Enabled = False
                TDBGrid2.Enabled = False
                EditButtonPress = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtUserID.Enabled = False
                txtPassword.Enabled = False
                txtUserName.Enabled = False
                cmbUserType.Enabled = False
                TDBGrid1.Enabled = False
                TDBGrid2.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtUserID.Enabled = False
                txtPassword.Enabled = True
                txtUserName.Enabled = True
                cmbUserType.Enabled = True
                TDBGrid1.Enabled = True
                TDBGrid2.Enabled = True
        End Select
    End Sub

    Private Sub SetButtons(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                cmdAdd.Enabled = True
                cmdSearch.Enabled = True
                cmdPrint.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = False
                cmdUndo.Enabled = False
                cmdExit.Enabled = True
            Case Actions.Edit
                cmdAdd.Enabled = False
                cmdSearch.Enabled = True
                cmdPrint.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = False
            Case Actions.Entry
                cmdAdd.Enabled = False
                cmdSearch.Enabled = False
                cmdPrint.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False
        End Select
    End Sub
   
    Private Sub ClearControls()
        txtUserID.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        cmbUserType.SelectedIndex = 1

        Call DisplayRec()
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtUserID.Text = ShowList("Select Userid,UserName,UserType From tblUsers Where CompanyId = '" & cCompanyId & "'", "List of Users", 1, 0).ToString

        If txtUserID.Text = Nothing Then
            txtUserID.Focus()
        Else
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        Call ClearControls()
        EditButtonPress = False
        cmdUndo.Enabled = True
        txtUserID.Enabled = True
        txtUserID.Focus()
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        If e.KeyChar = ChrW(Keys.Return) And Not txtUserID.Text = "" And Not Trim(txtUserID.Text) = "" Then
            Dim dr As SqlDataReader = Nothing
            Dim db As New dbOperations("Select * From tblUsers Where UserId = '" & txtUserID.Text & "' And CompanyID = '" & cCompanyId & "'", dr)
            If dr.HasRows Then
                MsgBox("This user name already taken by Some one Please choose other one.", MsgBoxStyle.Information)
                txtUserID.Text = ""
                txtUserID.Focus()
            Else
                txtUserID.Enabled = False
                txtUserID.Text = LTrim(txtUserID.Text)
                Call SetControls(Actions.Entry)
                txtUserName.Focus()
            End If
        End If
    End Sub

    Private Sub TDBGrid1_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles TDBGrid1.AfterColEdit
        If TDBGrid1.Col >= 1 Then
            TDBGrid1.UpdateData()
        End If
    End Sub

    Private Sub TDBGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDBGrid1.Click
        TDBGrid1.UpdateData()
    End Sub

    Private Sub TDBGrid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDBGrid1.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            TDBGrid1.UpdateData()
        End If
    End Sub

    Private Sub TDBGrid2_AfterColEdit(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles TDBGrid2.AfterColEdit
        If TDBGrid2.Col >= 1 Then

            TDBGrid2.UpdateData()
        End If
    End Sub

    Private Sub TDBGrid2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDBGrid2.Click
        TDBGrid2.UpdateData()
    End Sub

    Private Sub TDBGrid2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDBGrid2.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            TDBGrid2.UpdateData()
        End If
    End Sub

    Private Sub tdbList_RowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.RowColChangeEventArgs) Handles tdbList.RowColChange
        Call FilterGrid()
    End Sub
    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If txtUserID.Text <> Nothing Or txtUserID.Text <> "" Then
            EditButtonPress = True
            Call SetControls(Actions.Entry)
            txtUserName.Focus()
        Else
            MsgBox("No Record Selected for Edit")
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click

        If txtUserID.Text = Nothing Then
            MsgBox("No Record for Save")
            Exit Sub
        End If
        Dim dr As SqlDataReader = Nothing

        Dim db As New dbOperations("Select * From tblUsers Where UserId = '" & txtUserID.Text & "' And CompanyID = '" & cCompanyId & "'", dr)
        If dr.HasRows And EditButtonPress = False Then
            MsgBox("This user name already taken by Some one Please choose other one.", MsgBoxStyle.Information)
            txtUserID.Text = ""
            txtUserID.Focus()
        Else
            txtUserID.Enabled = False
            Call SetControls(Actions.Entry)
            txtUserName.Focus()
        End If

        '----------Master File

        MasterQuery = New ActionQueryBuilder
        MasterQuery.SetQueryInformation("tblUsers", "UserId = '" & txtUserID.Text & "' and CompanyId = '" & cCompanyId & "'")
        MasterQuery.AddFields("CompanyID", cCompanyId, ActionQueryBuilder.DataType.aString)
        MasterQuery.AddFields("UserID", txtUserID.Text, ActionQueryBuilder.DataType.aString)
        MasterQuery.AddFields("UserName", txtUserName.Text, ActionQueryBuilder.DataType.aString)
        MasterQuery.AddFields("Password", txtPassword.Text, ActionQueryBuilder.DataType.aString)
        MasterQuery.AddFields("UserType", IIf(cmbUserType.SelectedIndex = 0, "A", IIf(cmbUserType.SelectedIndex = 1, "U", IIf(cmbUserType.SelectedIndex = 2, "V", IIf(cmbUserType.SelectedIndex = 3, "T", "P")))), ActionQueryBuilder.DataType.aString)

        If EditButtonPress = False Then
            MasterQuery.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        ElseIf EditButtonPress = True Then
            MasterQuery.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        '-----------Detail File
        dbGridInput.RefreshKeyColumns()
        dbGridInput.SetCriteria = "UserId = '" & txtUserID.Text & "' and CompanyId = '" & cCompanyId & "' and OptionType = 'INPUT'"
        dbGridInput.AddKeyCol("CompanyId", cCompanyId)
        dbGridInput.AddKeyCol("UserID", txtUserID.Text)
        dbGridInput.AddKeyCol("OptionType", "INPUT")

        dbGridReport.RefreshKeyColumns()
        dbGridReport.SetCriteria = "UserId = '" & txtUserID.Text & "' and CompanyId = '" & cCompanyId & "' and OptionType = 'REPORT'"
        dbGridReport.AddKeyCol("CompanyId", cCompanyId)
        dbGridReport.AddKeyCol("UserID", txtUserID.Text)
        dbGridReport.AddKeyCol("OptionType", "REPORT")

        dbGridInput.Update()
        dbGridReport.Update()

        Call SetControls(Actions.Initial)
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtPassword.Focus()
        End If
    End Sub

    Private Sub cmbUserType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbUserType.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            cmdSave.Focus()
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            cmbUserType.Focus()
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If txtUserID.Text <> Nothing Or txtUserID.Text <> "" Then

            cmdAdd.Focus()
            MasterQuery = New ActionQueryBuilder
            MasterQuery.SetQueryInformation("tblUsers", "Userid = '" & txtUserID.Text & "' and CompanyId = '" & cCompanyId & "'")
            MasterQuery.ExecuteQuery(ActionQueryBuilder.Actions.Delete)

            dbGridInput.Delete()
            dbGridReport.Delete()

            Call SetControls(Actions.Initial)
            Call ClearControls()

        Else
            MsgBox("No Record Selected for Delete")
        End If
    End Sub
End Class