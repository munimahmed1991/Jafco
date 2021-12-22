Imports System.Data
Imports System.Data.SqlClient

Public Class frmStandardPaymentPlan
    Dim dbGrid As BindGrid

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
        txtCode.Text = ""
        cmbName.Text = ""
        cmbProject.SelectedValue = ""
        cmbUnitType.SelectedValue = ""
        cmbScheme.SelectedValue = ""

        cmbPaymentType.SelectedValue = ""

        txtAmount.Value = 0
        txtInstallments.Value = 0
        txtDueDays.Value = 0

        chkNotDecided.Checked = False

        tdbGridPaymentPlan.DataSource = Nothing
        tdbGridPaymentPlan.Columns("Amount").FooterText = "0.00"

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Name As New BindCombo(cmbName, "Select Name From tblStandardPaymentPlanMst", "Name", "Name", True, True)
        Dim Project As New BindCombo(cmbProject, "select Code,Name From tblProjectFile Order By Name", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType Order By Name", "Name", "Code", True, True)
        Dim Scheme As New BindCombo(cmbScheme, "Select Code,Name From tblScheme Order By Name", "Name", "Code", True, True)

        Dim PaymentType As New BindCombo(cmbPaymentType, "Select Code,Name From tblPaymentType Order By Name", "Name", "Code", True, True)
        Dim cPaymentType As New BindCombo(tdbPaymentType, "select Code,Name From tblPaymentType Order By Name", "Name", "Code", True)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                cmbName.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False
                cmbScheme.Enabled = False
                cmbPaymentType.Enabled = False

                txtAmount.Enabled = False
                txtDueDays.Enabled = False
                txtInstallments.Enabled = False
                chkNotDecided.Enabled = False

                tdbGridPaymentPlan.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                cmbName.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False
                cmbScheme.Enabled = False
                cmbPaymentType.Enabled = False

                txtAmount.Enabled = False
                txtDueDays.Enabled = False
                txtInstallments.Enabled = False
                chkNotDecided.Enabled = False

                tdbGridPaymentPlan.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                cmbName.Enabled = True
                cmbProject.Enabled = True
                cmbUnitType.Enabled = True
                cmbScheme.Enabled = True
                cmbPaymentType.Enabled = True

                txtAmount.Enabled = True
                txtDueDays.Enabled = True
                txtInstallments.Enabled = True
                chkNotDecided.Enabled = True

                tdbGridPaymentPlan.Enabled = True

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
        If CheckAccess("DeleteRights", UserId, "STANDARD PAYMENT PLAN") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As dbOperations

                DB = New dbOperations("Delete From tblStandardPaymentPlanDtl Where Code = '" & txtCode.Text & "'")
                DB.dbActionQuery()

                DB = New dbOperations("Delete From tblStandardPaymentPlanMst Where Code = '" & txtCode.Text & "'")
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
        If CheckAccess("EditRights", UserId, "STANDARD PAYMENT PLAN") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "STANDARD PAYMENT PLAN") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblStandardPaymentPlanMst Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code
                cmbName.Text = RemoveNull(DR!Name, "")
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")
                cmbScheme.SelectedValue = RemoveNull(DR!Scheme, "")

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

        dbGrid = New BindGrid(tdbGridPaymentPlan, "Select Code,PaymentType,Installment,DueDays,Amount,NotDecided From tblStandardPaymentPlanDtl Where Code = '" & txtCode.Text & "'")

        Call Totals()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean

        If txtCode.Text = "" Then
            txtCode.Text = NextSerial("Code", "tblStandardPaymentPlanMst", "0000", "", "")

            cAdd = True
        Else
            cAdd = False
        End If

        If CheckDuplicate("tblStandardPaymentPlanMst", "Name", cmbName.Text, txtCode.Text, "Code") = True Then
            MsgBox("Already Exist")

            If cAdd = True Then
                txtCode.Text = ""
            End If

            Exit Sub
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblStandardPaymentPlanMst", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Name", cmbName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitType", cmbUnitType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Scheme", cmbScheme.SelectedValue, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        dbGrid.SetCriteria = "Code = '" & txtCode.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("Code", txtCode.Text)
        dbGrid.Update()

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCode.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtCode.Text = ShowList("Select tblStandardPaymentPlanMst.Code,tblStandardPaymentPlanMst.Name,tblProjectFile.Name as Project,tblUnitType.Name as UnitType From tblStandardPaymentPlanMst,tblProjectFile,tblUnitType Where tblStandardPaymentPlanMst.Project = tblProjectFile.Code and tblStandardPaymentPlanMst.UnitType = tblUnitType.Code Order By tblStandardPaymentPlanMst.Code", "List of Standard Payment Plans", 1, 0)

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdUnitType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitType.Click
        cmbUnitType.SelectedValue = ShowList("Select Code,Name From tblUnitType Where Project = '" & cmbProject.SelectedValue & "'", "List of Unit Type", 1, 0)
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click

        Dim cInstallment As Integer

        cInstallment = 1

        While cInstallment <= txtInstallments.Value
            For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
                If row!PaymentType = cmbPaymentType.SelectedValue And row!Installment = cInstallment Then
                    MsgBox("Payment Already found cannot insert duplicate")
                    Exit Sub
                End If
            Next

            Dim NewRow As DataRow = dbGrid.cDataTable.NewRow
            NewRow("Code") = txtCode.Text
            NewRow("PaymentType") = cmbPaymentType.SelectedValue
            NewRow("Amount") = txtAmount.Value
            NewRow("Installment") = cInstallment
            NewRow("DueDays") = cInstallment * txtDueDays.Value
            NewRow("NotDecided") = chkNotDecided.Checked

            cInstallment = cInstallment + 1

            dbGrid.cDataTable.Rows.Add(NewRow)
        End While

        Call Totals()
    End Sub

    Sub Totals()
        Dim cTotalAmount As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalAmount += Convert.ToDouble(RemoveNull(row("Amount"), 0))
        Next

        tdbGridPaymentPlan.Columns("Amount").FooterText = Format(cTotalAmount, "###,###,##0")
    End Sub

    Private Sub tdbGridPaymentPlan_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridPaymentPlan.AfterColUpdate
        Call Totals()
    End Sub

    Private Sub tdbGridPaymentPlan_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridPaymentPlan.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridPaymentPlan.RowCount > 0 Then
                tdbGridPaymentPlan.Delete()
            End If
        End If
    End Sub

    Private Sub tdbGridPaymentPlan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridPaymentPlan.Click

    End Sub

    Private Sub cmdScheme_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdScheme.Click
        cmbScheme.SelectedValue = ShowList("Select Code,Name,CashAmount,LoanAmount,TotalAmount From tblScheme Where UnitType = '" & cmbUnitType.SelectedValue & "' and  Project = '" & cmbProject.SelectedValue & "'", "List of Scheme", 1, 0)
    End Sub
End Class