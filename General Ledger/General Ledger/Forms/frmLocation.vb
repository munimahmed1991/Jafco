Imports System.Data
Imports System.Data.SqlClient

Public Class frmLocation
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
        txtCode.Text = ""
        cmbName.Text = ""

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Name As New BindCombo(cmbName, "Select LocationName From tblLocation", "LocationName", "LocationName", True, True)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                cmbName.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                cmbName.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                cmbName.Enabled = True

                cmbName.Focus()
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
        If CheckAccess("DeleteRights", UserId, "LOCATION FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblLocation Where LocationCode = '" & txtCode.Text & "'")

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
        If CheckAccess("EditRights", UserId, "LOCATION FILE") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "LOCATION FILE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblLocation Where LocationCode = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!LocationCode
                cmbName.Text = RemoveNull(DR!LocationName, "")

                DB.Close()

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Location Code Does Not Exist")
                Exit Sub
            End If
        Else
            Call SetControls(Actions.Entry)
            Call ClearControls()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean

        If txtCode.Text = "" Then
            txtCode.Text = NextSerial("LocationCode", "tblLocation", "0000", "", "")

            cAdd = True
        Else
            cAdd = False
        End If

        If CheckDuplicate("tblLocation", "LocationName", cmbName.Text, txtCode.Text, "LocationCode") = True Then
            MsgBox("Already Exist")

            If cAdd = True Then
                txtCode.Text = ""
            End If

            Exit Sub
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblLocation", "Code = '" & txtCode.Text & "'")
        Query.AddFields("LocationCode", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("LocationName", cmbName.Text, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtCode.Text = ShowList("Select * From tblLocation Order By LocationCode", "List of Location", 1, 0)

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub txtCode_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCode.TextChanged

    End Sub

    Private Sub cmbName_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class