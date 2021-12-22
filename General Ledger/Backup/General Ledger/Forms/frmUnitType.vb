Imports System.Data
Imports System.Data.SqlClient

Public Class frmUnitType
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
        txtName.Text = ""
        cmbProject.SelectedValue = ""
        txtCashAmount.Value = 0
        txtLoanAmount.Value = 0
        txtTotalRevenue.Value = 0
        txtSqYards.Value = 0
        txtSqFeet.Value = 0

        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges2.SelectedValue = ""
        cmbExtraCharges3.SelectedValue = ""
        cmbExtraCharges4.SelectedValue = ""
        cmbExtraCharges5.SelectedValue = ""
        cmbExtraCharges6.SelectedValue = ""
        cmbExtraCharges7.SelectedValue = ""
        cmbExtraCharges8.SelectedValue = ""
        cmbExtraCharges9.SelectedValue = ""
        cmbExtraCharges10.SelectedValue = ""
        cmbExtraCharges11.SelectedValue = ""
        cmbExtraCharges12.SelectedValue = ""
        cmbExtraCharges13.SelectedValue = ""
        cmbExtraCharges14.SelectedValue = ""
        cmbExtraCharges15.SelectedValue = ""

        txtAmount1.Value = 0
        txtAmount2.Value = 0
        txtAmount3.Value = 0
        txtAmount4.Value = 0
        txtAmount5.Value = 0
        txtAmount6.Value = 0
        txtAmount7.Value = 0
        txtAmount8.Value = 0
        txtAmount9.Value = 0
        txtAmount10.Value = 0
        txtAmount11.Value = 0
        txtAmount12.Value = 0
        txtAmount13.Value = 0
        txtAmount14.Value = 0
        txtAmount15.Value = 0

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Name As New BindCombo(txtName, "Select Name From tblUnitType", "Name", "Name", True, True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)

        Dim ExtraCharges1 As New BindCombo(cmbExtraCharges1, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges2 As New BindCombo(cmbExtraCharges2, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges3 As New BindCombo(cmbExtraCharges3, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges4 As New BindCombo(cmbExtraCharges4, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges5 As New BindCombo(cmbExtraCharges5, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges6 As New BindCombo(cmbExtraCharges6, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges7 As New BindCombo(cmbExtraCharges7, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges8 As New BindCombo(cmbExtraCharges8, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges9 As New BindCombo(cmbExtraCharges9, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges10 As New BindCombo(cmbExtraCharges10, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges11 As New BindCombo(cmbExtraCharges11, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges12 As New BindCombo(cmbExtraCharges12, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges13 As New BindCombo(cmbExtraCharges13, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges14 As New BindCombo(cmbExtraCharges14, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
        Dim ExtraCharges15 As New BindCombo(cmbExtraCharges15, "Select Code,Name From tblExtraCharges", "Name", "Code", True, True)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                txtName.Enabled = False
                cmbProject.Enabled = False
                txtCashAmount.Enabled = False
                txtLoanAmount.Enabled = False
                txtTotalRevenue.Enabled = False
                txtSqYards.Enabled = False
                txtSqFeet.Enabled = False

                cmbExtraCharges1.Enabled = False
                cmbExtraCharges2.Enabled = False
                cmbExtraCharges3.Enabled = False
                cmbExtraCharges4.Enabled = False
                cmbExtraCharges5.Enabled = False
                cmbExtraCharges6.Enabled = False
                cmbExtraCharges7.Enabled = False
                cmbExtraCharges8.Enabled = False
                cmbExtraCharges9.Enabled = False
                cmbExtraCharges10.Enabled = False
                cmbExtraCharges11.Enabled = False
                cmbExtraCharges12.Enabled = False
                cmbExtraCharges13.Enabled = False
                cmbExtraCharges14.Enabled = False
                cmbExtraCharges15.Enabled = False

                txtAmount1.Enabled = False
                txtAmount2.Enabled = False
                txtAmount3.Enabled = False
                txtAmount4.Enabled = False
                txtAmount5.Enabled = False
                txtAmount6.Enabled = False
                txtAmount7.Enabled = False
                txtAmount8.Enabled = False
                txtAmount9.Enabled = False
                txtAmount10.Enabled = False
                txtAmount11.Enabled = False
                txtAmount12.Enabled = False
                txtAmount13.Enabled = False
                txtAmount14.Enabled = False
                txtAmount15.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                txtName.Enabled = False
                cmbProject.Enabled = False
                txtCashAmount.Enabled = False
                txtLoanAmount.Enabled = False
                txtTotalRevenue.Enabled = False
                txtSqYards.Enabled = False
                txtSqFeet.Enabled = False

                cmbExtraCharges1.Enabled = False
                cmbExtraCharges2.Enabled = False
                cmbExtraCharges3.Enabled = False
                cmbExtraCharges4.Enabled = False
                cmbExtraCharges5.Enabled = False
                cmbExtraCharges6.Enabled = False
                cmbExtraCharges7.Enabled = False
                cmbExtraCharges8.Enabled = False
                cmbExtraCharges9.Enabled = False
                cmbExtraCharges10.Enabled = False
                cmbExtraCharges11.Enabled = False
                cmbExtraCharges12.Enabled = False
                cmbExtraCharges13.Enabled = False
                cmbExtraCharges14.Enabled = False
                cmbExtraCharges15.Enabled = False

                txtAmount1.Enabled = False
                txtAmount2.Enabled = False
                txtAmount3.Enabled = False
                txtAmount4.Enabled = False
                txtAmount5.Enabled = False
                txtAmount6.Enabled = False
                txtAmount7.Enabled = False
                txtAmount8.Enabled = False
                txtAmount9.Enabled = False
                txtAmount10.Enabled = False
                txtAmount11.Enabled = False
                txtAmount12.Enabled = False
                txtAmount13.Enabled = False
                txtAmount14.Enabled = False
                txtAmount15.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                txtName.Enabled = True
                cmbProject.Enabled = True
                txtCashAmount.Enabled = True
                txtLoanAmount.Enabled = True
                txtTotalRevenue.Enabled = True
                txtSqYards.Enabled = True
                txtSqFeet.Enabled = True

                cmbExtraCharges1.Enabled = True
                cmbExtraCharges2.Enabled = True
                cmbExtraCharges3.Enabled = True
                cmbExtraCharges4.Enabled = True
                cmbExtraCharges5.Enabled = True
                cmbExtraCharges6.Enabled = True
                cmbExtraCharges7.Enabled = True
                cmbExtraCharges8.Enabled = True
                cmbExtraCharges9.Enabled = True
                cmbExtraCharges10.Enabled = True
                cmbExtraCharges11.Enabled = True
                cmbExtraCharges12.Enabled = True
                cmbExtraCharges13.Enabled = True
                cmbExtraCharges14.Enabled = True
                cmbExtraCharges15.Enabled = True

                txtAmount1.Enabled = True
                txtAmount2.Enabled = True
                txtAmount3.Enabled = True
                txtAmount4.Enabled = True
                txtAmount5.Enabled = True
                txtAmount6.Enabled = True
                txtAmount7.Enabled = True
                txtAmount8.Enabled = True
                txtAmount9.Enabled = True
                txtAmount10.Enabled = True
                txtAmount11.Enabled = True
                txtAmount12.Enabled = True
                txtAmount13.Enabled = True
                txtAmount14.Enabled = True
                txtAmount15.Enabled = True

                txtName.Focus()
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
        If CheckAccess("DeleteRights", UserId, "UNIT TYPE FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblUnitType Where Code = '" & txtCode.Text & "'")

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
        If CheckAccess("EditRights", UserId, "UNIT TYPE FILE") = -1 Then
            Call SetControls(Actions.Entry)
            cmbProject.Enabled = False

            If RemoveNull(cmbExtraCharges1.SelectedValue, "") = "" Then
                txtAmount1.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges2.SelectedValue, "") = "" Then
                txtAmount2.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges3.SelectedValue, "") = "" Then
                txtAmount3.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges4.SelectedValue, "") = "" Then
                txtAmount4.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges5.SelectedValue, "") = "" Then
                txtAmount5.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges6.SelectedValue, "") = "" Then
                txtAmount6.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges7.SelectedValue, "") = "" Then
                txtAmount7.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges8.SelectedValue, "") = "" Then
                txtAmount8.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges9.SelectedValue, "") = "" Then
                txtAmount9.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges10.SelectedValue, "") = "" Then
                txtAmount10.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges11.SelectedValue, "") = "" Then
                txtAmount11.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges12.SelectedValue, "") = "" Then
                txtAmount12.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges13.SelectedValue, "") = "" Then
                txtAmount13.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges14.SelectedValue, "") = "" Then
                txtAmount14.Enabled = False
            End If

            If RemoveNull(cmbExtraCharges15.SelectedValue, "") = "" Then
                txtAmount15.Enabled = False
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "UNIT TYPE FILE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblUnitType Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code
                txtName.Text = RemoveNull(DR!Name, "")
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                txtCashAmount.Value = RemoveNull(DR!CashAmount, 0)
                txtLoanAmount.Value = RemoveNull(DR!LoanAmount, 0)
                txtTotalRevenue.Value = RemoveNull(DR!TotalRevenue, 0)
                txtSqYards.Value = RemoveNull(DR!SqYards, 0)
                txtSqFeet.Value = RemoveNull(DR!SqFeet, 0)

                cmbExtraCharges1.SelectedValue = RemoveNull(DR!ExtraCharges1, "")
                cmbExtraCharges2.SelectedValue = RemoveNull(DR!ExtraCharges2, "")
                cmbExtraCharges3.SelectedValue = RemoveNull(DR!ExtraCharges3, "")
                cmbExtraCharges4.SelectedValue = RemoveNull(DR!ExtraCharges4, "")
                cmbExtraCharges5.SelectedValue = RemoveNull(DR!ExtraCharges5, "")
                cmbExtraCharges6.SelectedValue = RemoveNull(DR!ExtraCharges6, "")
                cmbExtraCharges7.SelectedValue = RemoveNull(DR!ExtraCharges7, "")
                cmbExtraCharges8.SelectedValue = RemoveNull(DR!ExtraCharges8, "")
                cmbExtraCharges9.SelectedValue = RemoveNull(DR!ExtraCharges9, "")
                cmbExtraCharges10.SelectedValue = RemoveNull(DR!ExtraCharges10, "")
                cmbExtraCharges11.SelectedValue = RemoveNull(DR!ExtraCharges11, "")
                cmbExtraCharges12.SelectedValue = RemoveNull(DR!ExtraCharges12, "")
                cmbExtraCharges13.SelectedValue = RemoveNull(DR!ExtraCharges13, "")
                cmbExtraCharges14.SelectedValue = RemoveNull(DR!ExtraCharges14, "")
                cmbExtraCharges15.SelectedValue = RemoveNull(DR!ExtraCharges15, "")

                txtAmount1.Value = RemoveNull(DR!ExtraChargesAmount1, 0)
                txtAmount2.Value = RemoveNull(DR!ExtraChargesAmount2, 0)
                txtAmount3.Value = RemoveNull(DR!ExtraChargesAmount3, 0)
                txtAmount4.Value = RemoveNull(DR!ExtraChargesAmount4, 0)
                txtAmount5.Value = RemoveNull(DR!ExtraChargesAmount5, 0)
                txtAmount6.Value = RemoveNull(DR!ExtraChargesAmount6, 0)
                txtAmount7.Value = RemoveNull(DR!ExtraChargesAmount7, 0)
                txtAmount8.Value = RemoveNull(DR!ExtraChargesAmount8, 0)
                txtAmount9.Value = RemoveNull(DR!ExtraChargesAmount9, 0)
                txtAmount10.Value = RemoveNull(DR!ExtraChargesAmount10, 0)
                txtAmount11.Value = RemoveNull(DR!ExtraChargesAmount11, 0)
                txtAmount12.Value = RemoveNull(DR!ExtraChargesAmount12, 0)
                txtAmount13.Value = RemoveNull(DR!ExtraChargesAmount13, 0)
                txtAmount14.Value = RemoveNull(DR!ExtraChargesAmount14, 0)
                txtAmount15.Value = RemoveNull(DR!ExtraChargesAmount15, 0)

                DB.Close()

                Call PickExtraCharges()
                Call SetControls(Actions.Edit)
            Else
                MsgBox("Unit Type Code Does Not Exist")
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
        Dim cPrefix As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        If txtCode.Text = "" Then
            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cPrefix = dr!Prefix
            End If

            txtCode.Text = NextSerial("Code", "tblUnitType", "000", "TYP" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")

            cAdd = True
        Else
            cAdd = False
        End If

        If CheckDuplicate("tblUnitType", "Name", txtName.Text, txtCode.Text, "Code") = True Then
            MsgBox("Already Exist")

            If cAdd = True Then
                txtCode.Text = ""
            End If

            Exit Sub
        End If

        txtTotalRevenue.Value = txtCashAmount.Value + txtLoanAmount.Value

        Query.Refresh()
        Query.SetQueryInformation("tblUnitType", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Name", txtName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CashAmount", txtCashAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("LoanAmount", txtLoanAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("TotalRevenue", txtTotalRevenue.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraCharges1", cmbExtraCharges1.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges2", cmbExtraCharges2.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges3", cmbExtraCharges3.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges4", cmbExtraCharges4.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges5", cmbExtraCharges5.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges6", cmbExtraCharges6.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges7", cmbExtraCharges7.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges8", cmbExtraCharges8.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges9", cmbExtraCharges9.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges10", cmbExtraCharges10.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges11", cmbExtraCharges11.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges12", cmbExtraCharges12.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges13", cmbExtraCharges13.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges14", cmbExtraCharges14.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ExtraCharges15", cmbExtraCharges15.SelectedValue, ActionQueryBuilder.DataType.aString)

        Query.AddFields("ExtraChargesAmount1", txtAmount1.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount2", txtAmount2.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount3", txtAmount3.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount4", txtAmount4.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount5", txtAmount5.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount6", txtAmount6.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount7", txtAmount7.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount8", txtAmount8.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount9", txtAmount9.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount10", txtAmount10.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount11", txtAmount11.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount12", txtAmount12.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount13", txtAmount13.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount14", txtAmount14.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExtraChargesAmount15", txtAmount15.Value, ActionQueryBuilder.DataType.aDecimal)

        Query.AddFields("SqYards", txtSqYards.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("SqFeet", txtSqFeet.Value, ActionQueryBuilder.DataType.aDecimal)

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
        txtCode.Text = ShowList("Select tblUnitType.Code,tblUnitType.Name as UnitType,tblProjectFile.Name as Project,CashAmount,LoanAmount,TotalRevenue From tblUnitType,tblProjectFile Where tblUnitType.Project = tblProjectFile.Code Order By tblUnitType.Code", "List of Unit Type", 1, 0)

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub txtCashAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCashAmount.LostFocus
        txtTotalRevenue.Value = txtCashAmount.Value + txtLoanAmount.Value
    End Sub

    Private Sub txtLoanAmount_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtLoanAmount.LostFocus
        txtTotalRevenue.Value = txtCashAmount.Value + txtLoanAmount.Value
    End Sub

    Private Sub cmbProject_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbProject.LostFocus
        Call PickExtraCharges()
    End Sub

    Sub PickExtraCharges()
        Dim db As New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        Dim dr As SqlDataReader

        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            If RemoveNull(cmbExtraCharges1.SelectedValue, "") = "" Then
                cmbExtraCharges1.SelectedValue = RemoveNull(dr!ExtraCharges1, "")
            End If

            If RemoveNull(cmbExtraCharges2.SelectedValue, "") = "" Then
                cmbExtraCharges2.SelectedValue = RemoveNull(dr!ExtraCharges2, "")
            End If

            If RemoveNull(cmbExtraCharges3.SelectedValue, "") = "" Then
                cmbExtraCharges3.SelectedValue = RemoveNull(dr!ExtraCharges3, "")
            End If

            If RemoveNull(cmbExtraCharges4.SelectedValue, "") = "" Then
                cmbExtraCharges4.SelectedValue = RemoveNull(dr!ExtraCharges4, "")
            End If

            If RemoveNull(cmbExtraCharges5.SelectedValue, "") = "" Then
                cmbExtraCharges5.SelectedValue = RemoveNull(dr!ExtraCharges5, "")
            End If

            If RemoveNull(cmbExtraCharges6.SelectedValue, "") = "" Then
                cmbExtraCharges6.SelectedValue = RemoveNull(dr!ExtraCharges6, "")
            End If

            If RemoveNull(cmbExtraCharges7.SelectedValue, "") = "" Then
                cmbExtraCharges7.SelectedValue = RemoveNull(dr!ExtraCharges7, "")
            End If

            If RemoveNull(cmbExtraCharges8.SelectedValue, "") = "" Then
                cmbExtraCharges8.SelectedValue = RemoveNull(dr!ExtraCharges8, "")
            End If

            If RemoveNull(cmbExtraCharges9.SelectedValue, "") = "" Then
                cmbExtraCharges9.SelectedValue = RemoveNull(dr!ExtraCharges9, "")
            End If

            If RemoveNull(cmbExtraCharges10.SelectedValue, "") = "" Then
                cmbExtraCharges10.SelectedValue = RemoveNull(dr!ExtraCharges10, "")
            End If

            If RemoveNull(cmbExtraCharges11.SelectedValue, "") = "" Then
                cmbExtraCharges11.SelectedValue = RemoveNull(dr!ExtraCharges11, "")
            End If

            If RemoveNull(cmbExtraCharges12.SelectedValue, "") = "" Then
                cmbExtraCharges12.SelectedValue = RemoveNull(dr!ExtraCharges12, "")
            End If

            If RemoveNull(cmbExtraCharges13.SelectedValue, "") = "" Then
                cmbExtraCharges13.SelectedValue = RemoveNull(dr!ExtraCharges13, "")
            End If

            If RemoveNull(cmbExtraCharges14.SelectedValue, "") = "" Then
                cmbExtraCharges14.SelectedValue = RemoveNull(dr!ExtraCharges14, "")
            End If

            If RemoveNull(cmbExtraCharges15.SelectedValue, "") = "" Then
                cmbExtraCharges15.SelectedValue = RemoveNull(dr!ExtraCharges15, "")
            End If
        End If

        If RemoveNull(cmbExtraCharges1.SelectedValue, "") = "" Then
            txtAmount1.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges2.SelectedValue, "") = "" Then
            txtAmount2.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges3.SelectedValue, "") = "" Then
            txtAmount3.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges4.SelectedValue, "") = "" Then
            txtAmount4.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges5.SelectedValue, "") = "" Then
            txtAmount5.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges6.SelectedValue, "") = "" Then
            txtAmount6.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges7.SelectedValue, "") = "" Then
            txtAmount7.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges8.SelectedValue, "") = "" Then
            txtAmount8.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges9.SelectedValue, "") = "" Then
            txtAmount9.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges10.SelectedValue, "") = "" Then
            txtAmount10.Enabled = False
        End If
        If RemoveNull(cmbExtraCharges11.SelectedValue, "") = "" Then
            txtAmount11.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges12.SelectedValue, "") = "" Then
            txtAmount12.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges13.SelectedValue, "") = "" Then
            txtAmount13.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges14.SelectedValue, "") = "" Then
            txtAmount14.Enabled = False
        End If

        If RemoveNull(cmbExtraCharges15.SelectedValue, "") = "" Then
            txtAmount15.Enabled = False
        End If
    End Sub

    Private Sub cmbProject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbProject.TextChanged

    End Sub
End Class