Imports System.Data
Imports System.Data.SqlClient

Public Class frmUnitFile
    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmCountry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetControls(Actions.Initial)
        Call ClearControls()
        Call FormCenter(Me)

        Dim SearchProject As New BindCombo(cmbSearchProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub ClearControls()
        txtCode.Text = ""
        cmbUnitNumber.Text = ""
        cmbProject.SelectedValue = ""
        cmbUnitType.SelectedValue = ""

        cmbBlock.SelectedValue = ""
        txtCashAmount.Value = 0
        txtLoanAmount.Value = 0
        txtTotalRevenue.Value = 0
        txtFloors.Value = 0
        txtRooms.Text = ""
        txtCancelDate.Value = Nothing

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
        cmbUnitAccount.SelectedValue = ""

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
        txtCancelCharges.Value = 0

        chkApply1.Checked = False
        chkApply2.Checked = False
        chkApply3.Checked = False
        chkApply4.Checked = False
        chkApply5.Checked = False
        chkApply6.Checked = False
        chkApply7.Checked = False
        chkApply8.Checked = False
        chkApply9.Checked = False
        chkApply10.Checked = False
        chkApply11.Checked = False
        chkApply12.Checked = False
        chkApply13.Checked = False
        chkApply14.Checked = False
        chkApply15.Checked = False
        chkCancel.Checked = False

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim UnitNumber As New BindCombo(cmbUnitNumber, "Select UnitNumber From tblUnitFile", "UnitNumber", "UnitNumber", True, True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim Block As New BindCombo(cmbBlock, "Select Code,Name From tblBlock", "Name", "Code", True, True)

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

        Dim UnitAccount As New BindCombo(cmbUnitAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail'", "AccountName", "AccountCode", True, True, GLConString)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                cmbUnitNumber.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False
                txtCashAmount.Enabled = False
                txtLoanAmount.Enabled = False
                txtTotalRevenue.Enabled = False
                txtFloors.Enabled = False
                txtRooms.Enabled = False
                cmbBlock.Enabled = False
                txtCancelDate.Enabled = False
                cmbUnitAccount.Enabled = False

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

                chkApply1.Enabled = False
                chkApply2.Enabled = False
                chkApply3.Enabled = False
                chkApply4.Enabled = False
                chkApply5.Enabled = False
                chkApply6.Enabled = False
                chkApply7.Enabled = False
                chkApply8.Enabled = False
                chkApply9.Enabled = False
                chkApply10.Enabled = False
                chkApply11.Enabled = False
                chkApply12.Enabled = False
                chkApply13.Enabled = False
                chkApply14.Enabled = False
                chkApply15.Enabled = False
                chkCancel.Enabled = False

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
                txtCancelCharges.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                cmbUnitNumber.Enabled = False
                cmbProject.Enabled = False
                cmbUnitType.Enabled = False
                txtCashAmount.Enabled = False
                txtLoanAmount.Enabled = False
                txtTotalRevenue.Enabled = False
                txtFloors.Enabled = False
                txtRooms.Enabled = False
                cmbBlock.Enabled = False
                txtCancelDate.Enabled = False
                cmbUnitAccount.Enabled = False

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

                chkApply1.Enabled = False
                chkApply2.Enabled = False
                chkApply3.Enabled = False
                chkApply4.Enabled = False
                chkApply5.Enabled = False
                chkApply6.Enabled = False
                chkApply7.Enabled = False
                chkApply8.Enabled = False
                chkApply9.Enabled = False
                chkApply10.Enabled = False
                chkApply11.Enabled = False
                chkApply12.Enabled = False
                chkApply13.Enabled = False
                chkApply14.Enabled = False
                chkApply15.Enabled = False
                chkCancel.Enabled = False

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
                txtCancelCharges.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                cmbUnitNumber.Enabled = True
                cmbProject.Enabled = True
                cmbUnitType.Enabled = True
                txtCashAmount.Enabled = True
                txtLoanAmount.Enabled = True
                txtTotalRevenue.Enabled = True
                txtFloors.Enabled = True
                txtRooms.Enabled = True
                cmbBlock.Enabled = True
                txtCancelCharges.Enabled = True
                cmbUnitAccount.Enabled = True

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

                chkApply1.Enabled = True
                chkApply2.Enabled = True
                chkApply3.Enabled = True
                chkApply4.Enabled = True
                chkApply5.Enabled = True
                chkApply6.Enabled = True
                chkApply7.Enabled = True
                chkApply8.Enabled = True
                chkApply9.Enabled = True
                chkApply10.Enabled = True
                chkApply11.Enabled = True
                chkApply12.Enabled = True
                chkApply13.Enabled = True
                chkApply14.Enabled = True
                chkApply15.Enabled = True
                chkCancel.Enabled = True

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
                txtCancelCharges.Enabled = True
                txtCancelDate.Enabled = True

                cmbUnitNumber.Focus()
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
        If CheckAccess("DeleteRights", UserId, "UNIT FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblUnitFile Where Code = '" & txtCode.Text & "'")

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
        If CheckAccess("EditRights", UserId, "UNIT FILE") = -1 Then
            Call SetControls(Actions.Entry)
            cmbProject.Enabled = False

            cmdUnitList.Enabled = True

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
        If CheckAccess("AddRights", UserId, "UNIT FILE") = -1 Then
            Call DisplayRec()

            chkCancel.Enabled = False
            txtCancelCharges.Enabled = False
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblUnitFile Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code
                cmbUnitNumber.Text = RemoveNull(DR!UnitNumber, "")
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")
                cmbUnitType.SelectedValue = RemoveNull(DR!UnitType, "")
                txtCashAmount.Value = RemoveNull(DR!CashAmount, 0)
                txtLoanAmount.Value = RemoveNull(DR!LoanAmount, 0)
                txtTotalRevenue.Value = RemoveNull(DR!TotalRevenue, 0)
                txtFloors.Value = RemoveNull(DR!Floors, 0)
                txtRooms.Text = RemoveNull(DR!Rooms, "")
                cmbBlock.SelectedValue = RemoveNull(DR!Block, "")
                cmbUnitAccount.SelectedValue = RemoveNull(DR!Account, "")

                If RemoveNull(DR!Cancel, 0) <> 0 Then
                    txtCancelDate.Value = RemoveNull(DR!CancelDate, Nothing)
                End If

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

                chkApply1.Checked = RemoveNull(DR!ExtraCharges1Apply, 0)
                chkApply2.Checked = RemoveNull(DR!ExtraCharges2Apply, 0)
                chkApply3.Checked = RemoveNull(DR!ExtraCharges3Apply, 0)
                chkApply4.Checked = RemoveNull(DR!ExtraCharges4Apply, 0)
                chkApply5.Checked = RemoveNull(DR!ExtraCharges5Apply, 0)
                chkApply6.Checked = RemoveNull(DR!ExtraCharges6Apply, 0)
                chkApply7.Checked = RemoveNull(DR!ExtraCharges7Apply, 0)
                chkApply8.Checked = RemoveNull(DR!ExtraCharges8Apply, 0)
                chkApply9.Checked = RemoveNull(DR!ExtraCharges9Apply, 0)
                chkApply10.Checked = RemoveNull(DR!ExtraCharges10Apply, 0)
                chkApply11.Checked = RemoveNull(DR!ExtraCharges11Apply, 0)
                chkApply12.Checked = RemoveNull(DR!ExtraCharges12Apply, 0)
                chkApply13.Checked = RemoveNull(DR!ExtraCharges13Apply, 0)
                chkApply14.Checked = RemoveNull(DR!ExtraCharges14Apply, 0)
                chkApply15.Checked = RemoveNull(DR!ExtraCharges15Apply, 0)
                chkCancel.Checked = RemoveNull(DR!Cancel, 0)

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
                txtCancelCharges.Value = RemoveNull(DR!CancelCharges, 0)

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

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Cannot be Left Blank")
            Exit Sub
        End If

        If cmbUnitType.SelectedValue = "" Then
            MsgBox("Unit Type Cannot be Left Blank")
            Exit Sub
        End If

        If cmbBlock.SelectedValue = "" Then
            MsgBox("Block Cannot be Left Blank")
            Exit Sub
        End If

        If txtCode.Text = "" Then
            db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                cPrefix = dr!Prefix
            End If

            txtCode.Text = NextSerial("Code", "tblUnitFile", "00000", "UNT" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "'")

            If chkCancel.Checked = 1 Then
                MsgBox("Unit Cannot Be Cancelled in Add Mode Remove Cancel Check")
                Exit Sub
            End If

            cAdd = True
        Else
            cAdd = False
        End If

        If chkCancel.Checked = False Then
            If CheckDuplicate("tblUnitFile", "UnitNumber", cmbUnitNumber.Text, txtCode.Text, "Code", "IsNull(Cancel,0) = 0 and Project= '" & cmbProject.SelectedValue & "'") = True Then
                MsgBox("Already Exist")

                If cAdd = True Then
                    txtCode.Text = ""
                End If

                'Exit Sub
            End If
        End If

        txtTotalRevenue.Value = txtCashAmount.Value + txtLoanAmount.Value

        Query.Refresh()
        Query.SetQueryInformation("tblUnitFile", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitNumber", cmbUnitNumber.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnitType", cmbUnitType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CashAmount", txtCashAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("LoanAmount", txtLoanAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("TotalRevenue", txtTotalRevenue.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Rooms", txtRooms.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Floors", txtFloors.Value, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("Block", cmbBlock.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Cancel", chkCancel.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("Account", cmbUnitAccount.SelectedValue, ActionQueryBuilder.DataType.aString)

        If chkCancel.Checked = True Then
            Query.AddFields("CancelDate", txtCancelDate.Value, ActionQueryBuilder.DataType.aDate)
            Query.AddFields("CancelCharges", txtCancelCharges.Value, ActionQueryBuilder.DataType.aDecimal)
        End If

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

        Query.AddFields("ExtraCharges1Apply", chkApply1.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges2Apply", chkApply2.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges3Apply", chkApply3.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges4Apply", chkApply4.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges5Apply", chkApply5.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges6Apply", chkApply6.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges7Apply", chkApply7.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges8Apply", chkApply8.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges9Apply", chkApply9.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges10Apply", chkApply10.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges11Apply", chkApply11.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges12Apply", chkApply12.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges13Apply", chkApply13.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges14Apply", chkApply14.Checked, ActionQueryBuilder.DataType.aInteger)
        Query.AddFields("ExtraCharges15Apply", chkApply15.Checked, ActionQueryBuilder.DataType.aInteger)

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

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        Dim cCode As String
        Dim cSql As String

        If chkCancel.Checked = True Then
            db = New dbOperations("Update tblReservationMst Set Cancel = 1,CancelDate = '" & Format(txtCancelDate.Value, "MM/dd/yyyy") & "',CancelCharges = '" & txtCancelCharges.Value & "' Where Unit = '" & txtCode.Text & "'")
            db.dbActionQuery()

            db = New dbOperations("Select * From tblUnitFile Where UnitNumber = '" & cmbUnitNumber.Text & "' and IsNull(Cancel,0) = 0")
            dr = db.dbSelectQuery

            If dr.HasRows = False Then
                MsgBox("Unit Cancelled Successfully Please Save Again to Add in Inventory")

                txtCode.Text = ""
                txtCashAmount.Value = 0
                txtLoanAmount.Value = 0
                txtTotalRevenue.Value = 0

                chkCancel.Checked = False
                txtCancelDate.Value = Nothing

                Call PickExtraCharges()

                Exit Sub
            End If
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
        If cmbSearchProject.SelectedValue = "" Then
            MsgBox("Please Select Project First in Search")
            Exit Sub
        End If

        Dim cSql As String
        Dim cProject As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * from tblProjectFile Where Code = '" & cmbSearchProject.SelectedValue & "'")
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
        cSql = cSql + "And tblUnitFile.Project = '" & cmbSearchProject.SelectedValue & "' "
        cSql = cSql + "And IsNull(tblUnitFile.Cancel,0) = 0 "
        cSql = cSql + "Order By tblUnitFile.Code "

        txtCode.Text = ShowList(cSql, "List of Unit Type", 1, 0, "Unit,CashAmount,LoanAmount,TotalRevenue,ExtraCharges,GrossTotal,ExtraChargesAmount1,ExtraChargesAmount2,ExtraChargesAmount3,ExtraChargesAmount4,ExtraChargesAmount5,ExtraChargesAmount6,ExtraChargesAmount7,ExtraChargesAmount8,ExtraChargesAmount9,ExtraChargesAmount10,ExtraChargesAmount11,ExtraChargesAmount12,ExtraChargesAmount13,ExtraChargesAmount14,ExtraChargesAmount15")

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

    Sub PickExtraCharges()
        Dim db As New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
        Dim dr As SqlDataReader

        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            If txtCashAmount.Value = 0 Then
                txtCashAmount.Value = RemoveNull(dr!CashAmount, 0)
            Else
                txtCashAmount.Value = RemoveNull(dr!CashAmount, 0)
            End If



            If txtLoanAmount.Value = 0 Then
                txtLoanAmount.Value = RemoveNull(dr!LoanAmount, 0)
            Else
                txtLoanAmount.Value = RemoveNull(dr!LoanAmount, 0)
            End If

            If txtTotalRevenue.Value = 0 Then
                txtTotalRevenue.Value = RemoveNull(dr!TotalRevenue, 0)
            Else
                txtTotalRevenue.Value = RemoveNull(dr!TotalRevenue, 0)
            End If

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

    Private Sub cmbUnitType_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmbUnitType.LostFocus
        Call PickExtraCharges()
    End Sub

    Private Sub chkApply1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply1.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply1.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount1.Value = RemoveNull(dr!ExtraChargesAmount1, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount1.Value = 0
        End If
    End Sub

    Private Sub chkApply2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply2.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply2.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount2.Value = RemoveNull(dr!ExtraChargesAmount2, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount2.Value = 0
        End If
    End Sub

    Private Sub chkApply3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply3.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply3.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount3.Value = RemoveNull(dr!ExtraChargesAmount3, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount3.Value = 0
        End If

    End Sub

    Private Sub chkApply4_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply4.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply4.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount4.Value = RemoveNull(dr!ExtraChargesAmount4, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount4.Value = 0
        End If
    End Sub

    Private Sub chkApply5_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply5.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply5.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount5.Value = RemoveNull(dr!ExtraChargesAmount5, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount5.Value = 0
        End If
    End Sub

    Private Sub chkApply6_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply6.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply6.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount6.Value = RemoveNull(dr!ExtraChargesAmount6, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount6.Value = 0
        End If
    End Sub

    Private Sub chkApply7_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply7.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply7.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount7.Value = RemoveNull(dr!ExtraChargesAmount7, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount7.Value = 0
        End If
    End Sub

    Private Sub chkApply8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply8.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply8.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount8.Value = RemoveNull(dr!ExtraChargesAmount8, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount8.Value = 0
        End If
    End Sub

    Private Sub chkApply9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply9.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply9.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount9.Value = RemoveNull(dr!ExtraChargesAmount9, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount9.Value = 0
        End If
    End Sub

    Private Sub chkApply10_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply10.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply10.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount10.Value = RemoveNull(dr!ExtraChargesAmount10, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount10.Value = 0
        End If
    End Sub

    Private Sub cmdUnitList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitList.Click
        cmbUnitType.SelectedValue = ShowList("Select Code,Name From tblUnitType Where Project = '" & cmbProject.SelectedValue & "'", "List of Unit Type", 1, 0)

        Call PickExtraCharges()
    End Sub

    Private Sub chkApply11_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply11.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply11.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount11.Value = RemoveNull(dr!ExtraChargesAmount11, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount11.Value = 0
        End If
    End Sub

    Private Sub chkApply12_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply12.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply12.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount12.Value = RemoveNull(dr!ExtraChargesAmount11, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount12.Value = 0
        End If
    End Sub

    Private Sub chkApply13_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply13.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply13.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount13.Value = RemoveNull(dr!ExtraChargesAmount11, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount13.Value = 0
        End If

    End Sub

    Private Sub chkApply14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply14.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply14.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount14.Value = RemoveNull(dr!ExtraChargesAmount11, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount14.Value = 0
        End If
    End Sub

    Private Sub chkApply15_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkApply15.CheckedChanged
        Dim db As dbOperations
        Dim dr As SqlDataReader

        If chkApply15.Checked = True Then
            db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                txtAmount15.Value = RemoveNull(dr!ExtraChargesAmount11, 0)
            End If

            db.Close()
            dr.Close()
        Else
            txtAmount15.Value = 0
        End If
    End Sub

    Private Sub cmbUnitType_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnitType.TextChanged
        Call PickExtraCharges()
    End Sub

    Private Sub Label27_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub cmbBlock_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbBlock.TextChanged

    End Sub

    Private Sub Label28_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub txtCashAmount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCashAmount.TextChanged

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub GroupBox2_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub chkCancel_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkCancel.CheckedChanged
        If chkCancel.Checked = True Then
            txtCancelDate.Value = Today.Date
        Else
            txtCancelDate.Value = Nothing
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cmdCancelUnits_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancelUnits.Click
        If cmbSearchProject.SelectedValue = "" Then
            MsgBox("Please Select Project First in Search")
            Exit Sub
        End If

        Dim cSql As String
        Dim cProject As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * from tblProjectFile Where Code = '" & cmbSearchProject.SelectedValue & "'")
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
        cSql = cSql + "And tblUnitFile.Project = '" & cmbSearchProject.SelectedValue & "' "
        cSql = cSql + "And IsNull(tblUnitFile.Cancel,0) = 1 "
        cSql = cSql + "Order By tblUnitFile.Code "

        txtCode.Text = ShowList(cSql, "List of Unit Type", 1, 0, "Unit,CashAmount,LoanAmount,TotalRevenue,ExtraCharges,GrossTotal,ExtraChargesAmount1,ExtraChargesAmount2,ExtraChargesAmount3,ExtraChargesAmount4,ExtraChargesAmount5,ExtraChargesAmount6,ExtraChargesAmount7,ExtraChargesAmount8,ExtraChargesAmount9,ExtraChargesAmount10,ExtraChargesAmount11,ExtraChargesAmount12,ExtraChargesAmount13,ExtraChargesAmount14,ExtraChargesAmount15")

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub
End Class