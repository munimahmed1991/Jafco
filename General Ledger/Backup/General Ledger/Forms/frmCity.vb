Imports System.Data
Imports System.Data.SqlClient

Public Class frmCity
    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmCityFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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

        cmbCountry.SelectedValue = ""
        cmbRegion.SelectedValue = ""

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Name As New BindCombo(cmbName, "Select Name From tblCity", "Name", "Name", True, True)
        Dim Country As New BindCombo(cmbCountry, "Select Code,Name From tblCountry", "Name", "Code", True, True)
        Dim Region As New BindCombo(cmbRegion, "Select Code,Name From tblRegion", "Name", "Code", True, True)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True

                cmbName.Enabled = False
                cmbCountry.Enabled = False
                cmbRegion.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False

                cmbName.Enabled = False
                cmbCountry.Enabled = False
                cmbRegion.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False

                cmbName.Enabled = True
                cmbCountry.Enabled = True
                cmbRegion.Enabled = True

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
        If CheckAccess("DeleteRights", UserId, "CITY FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblCity Where Code = '" & txtCode.Text & "'")

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
        If CheckAccess("EditRights", UserId, "CITY FILE") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "CITY FILE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblCity Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code

                cmbName.Text = RemoveNull(DR!Name, "")
                cmbCountry.SelectedValue = RemoveNull(DR!Country, "")
                cmbRegion.SelectedValue = RemoveNull(DR!Region, "")

                DB.Close()

                Call SetControls(Actions.Edit)
            Else
                MsgBox("City Code Does Not Exist")
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

        If cmbCountry.SelectedValue = "" Then
            MsgBox("Country Cannot be Left Blank")
            Exit Sub
        End If

        If txtCode.Text = "" Then
            txtCode.Text = NextSerial("Code", "tblCity", "0000", "", "")

            cAdd = True
        Else
            cAdd = False
        End If

        If CheckDuplicate("tblCity", "Name", cmbName.Text, txtCode.Text, "Code") = True Then
            MsgBox("Already Exist")

            If cAdd = True Then
                txtCode.Text = ""
            End If

            Exit Sub
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblCity", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Name", cmbName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Country", cmbCountry.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Region", cmbRegion.SelectedValue, ActionQueryBuilder.DataType.aString)

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
        txtCode.Text = ShowList("Select tblCity.Code,tblCity.Name,tblCountry.Name as Country From tblCity,tblCountry Where tblCity.Country = tblCountry.Code Order By tblCity.Code", "List of City", 1, 0)

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdCountryList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCountryList.Click
        cmbCountry.SelectedValue = ShowList("Select Code,Name From tblCountry Order By Code", "List of Country", 1, 0)
    End Sub
End Class