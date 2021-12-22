Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReceptionModule
    Dim cSql As String

    Dim db As dbOperations
    Dim dr As SqlDataReader

    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub FillCombo()
        Dim Task As New BindCombo(cmbTask, "select Code,Name From tblTaskFile", "Name", "Code", True, True)
        Dim TaskFor As New BindCombo(cmbTaskFor, "Select UserID from tblUsers", "UserID", "UserID", True, True)
    End Sub

    Sub ClearControls()
        txtEntryNo.Text = ""
        txtEntryDate.Value = Today.Date
        cmbTask.SelectedValue = ""
        cmbTaskFor.SelectedValue = ""
        txtGivenBy.Text = ""
        txtCustomer.Text = ""
        txtContactDetails.Text = ""
        chkCompleted.Checked = False
        txtCompletedDate.Value = Nothing
        txtRemarks.Text = ""
        txtCompletedRemarks.Text = ""
        txtDeadlineDate.Value = Today.Date
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


    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtEntryNo.Enabled = True
                txtEntryDate.Enabled = False
                cmbTask.Enabled = False
                cmbTaskFor.Enabled = False
                txtGivenBy.Enabled = False
                txtCustomer.Enabled = False
                txtContactDetails.Enabled = False
                chkCompleted.Enabled = False
                txtCompletedDate.Enabled = False
                txtRemarks.Enabled = False
                txtCompletedRemarks.Enabled = False
                txtDeadlineDate.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtEntryNo.Enabled = False
                txtEntryDate.Enabled = False
                cmbTask.Enabled = False
                cmbTaskFor.Enabled = False
                txtGivenBy.Enabled = False
                txtCustomer.Enabled = False
                txtContactDetails.Enabled = False
                chkCompleted.Enabled = False
                txtCompletedDate.Enabled = False
                txtRemarks.Enabled = False
                txtCompletedRemarks.Enabled = False
                txtDeadlineDate.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtEntryNo.Enabled = False
                txtEntryDate.Enabled = True
                cmbTask.Enabled = True
                cmbTaskFor.Enabled = True
                txtGivenBy.Enabled = True
                txtCustomer.Enabled = True
                txtContactDetails.Enabled = True
                chkCompleted.Enabled = True
                txtCompletedDate.Enabled = True
                txtRemarks.Enabled = True
                txtCompletedRemarks.Enabled = True
                txtDeadlineDate.Enabled = True
        End Select
    End Sub

    Private Sub frmReceptionModule_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCombo()
        Call ClearControls()
        Call SetControls(Actions.Initial)
        Call FormCenter(Me)
    End Sub


    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, "RECEPTION MODULE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblReception Where EntryNo = '" & txtEntryNo.Text & "'")

                DB.dbActionQuery()

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "RECEPTION MODULE") = -1 Then
            Call DisplayRec()

            chkCompleted.Enabled = False
            txtCompletedDate.Enabled = False
            txtCompletedRemarks.Enabled = False

            txtGivenBy.Text = UserId
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtEntryNo.Text <> "" Then
            cSql = "Select * from tblReception Where EntryNo = '" & txtEntryNo.Text & "'"

            db = New dbOperations(cSql)
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtEntryNo.Text = dr!EntryNo
                txtEntryDate.Value = dr!EntryDate
                cmbTaskFor.SelectedValue = dr!TaskFor
                cmbTask.SelectedValue = dr!Task
                txtGivenBy.Text = RemoveNull(dr!GivenBy, "")
                txtCustomer.Text = RemoveNull(dr!Customer, "")
                txtContactDetails.Text = RemoveNull(dr!ContactDetails, "")
                chkCompleted.Checked = RemoveNull(dr!Completed, 0)
                txtCompletedDate.Value = RemoveNull(dr!completedDate, Nothing)
                txtRemarks.Text = RemoveNull(dr!Remarks, "")
                txtCompletedRemarks.Text = RemoveNull(dr!CompletedRemarks, "")
                txtDeadlineDate.Value = RemoveNull(dr!DeadlineDate, Nothing)

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Entry # Does Not Exist")
                Exit Sub
            End If
        Else
            Call ClearControls()
            Call SetControls(Actions.Entry)
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "RECEPTION MODULE") = -1 Then
            Call SetControls(Actions.Entry)

            If txtGivenBy.Text = UserId Then
                chkCompleted.Enabled = False
                txtCompletedDate.Enabled = False
                txtCompletedRemarks.Enabled = False
            Else
                cmbTask.Enabled = False
                cmbTaskFor.Enabled = False
                txtCustomer.Enabled = False
                txtContactDetails.Enabled = False
                txtRemarks.Enabled = False

                chkCompleted.Enabled = True
                txtCompletedDate.Enabled = True
                txtCompletedRemarks.Enabled = True
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean

        If cmbTask.SelectedValue = "" Then
            MsgBox("Task Cannot be Left Blank")
            Exit Sub
        End If

        If cmbTaskFor.SelectedValue = "" Then
            MsgBox("Task For Cannot be Left Blank")
            Exit Sub
        End If

        If txtEntryNo.Text = "" Then
            txtEntryNo.Text = NextSerial("EntryNo", "tblReception", "000000", "RCP-")

            MsgBox("Entry # Generated is " & txtEntryNo.Text)

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblReception", "EntryNo = '" & txtEntryNo.Text & "'")

        Query.AddFields("EntryNo", txtEntryNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("EntryDate", txtEntryDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Task", cmbTask.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("TaskFor", cmbTaskFor.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("GivenBy", txtGivenBy.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Customer", txtCustomer.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ContactDetails", txtContactDetails.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Completed", chkCompleted.Checked, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("DeadlineDate", txtDeadlineDate.Value, ActionQueryBuilder.DataType.aDate)

        If chkCompleted.Checked = True Then
            Query.AddFields("CompletedDate", txtCompletedDate.Value, ActionQueryBuilder.DataType.aString)
        End If

        Query.AddFields("Remarks", txtRemarks.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CompletedRemarks", txtCompletedRemarks.Text, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub chkCompleted_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCompleted.CheckedChanged
        If chkCompleted.Checked = True Then
            txtCompletedDate.Value = Today.Date
        Else
            txtCompletedDate.Value = Nothing
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtEntryNo.Text = ShowList("Select EntryNo,EntryDate,tblTaskFile.Name as Task,TaskFor,GivenBy,Customer,ContactDetails,Case When IsNull(Completed,0) = 0 Then 'No' Else 'Yes' End as Completed,CompletedDate,Remarks From tblReception,tblTaskFile Where tblReception.Task = tblTaskFile.Code", "List of Reception Module", 0, 0, "", "", "TaskFor,Completed,GivenBy", "List")

        If txtEntryNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub
End Class