Imports System.Data
Imports System.Data.SqlClient

Public Class frmProjectFile
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
        txtAddress.Text = ""
        txtPrefix.Text = ""
        cmbProjectType.SelectedValue = ""
        cmbProjectPurpose.SelectedValue = ""
        cmbRegion.SelectedValue = ""
        cmbCountry.SelectedValue = ""
        cmbCity.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges1.SelectedValue = ""
        cmbExtraCharges9.SelectedValue = ""
        cmbExtraCharges10.SelectedValue = ""
        cmbExtraCharges11.SelectedValue = ""
        cmbExtraCharges12.SelectedValue = ""
        cmbExtraCharges13.SelectedValue = ""
        cmbExtraCharges14.SelectedValue = ""
        cmbExtraCharges15.SelectedValue = ""
        txtPenaltyPer.Value = 0
        cmbPenaltyPolicy.Text = "Normal"
        cmbCashAccount.SelectedValue = ""
        cmbChequeAccount.SelectedValue = ""
        cmbForfietAccount.SelectedValue = ""
        cmbProjectAccount.SelectedValue = ""
        txtOfficialReceiptStart.Text = ""
        txtUnOfficialReceiptStart.Text = ""
        chkLoanNotApplicable.Checked = False

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Name As New BindCombo(cmbName, "Select Name From tblProjectFile", "Name", "Name", True, True)
        Dim ProjectType As New BindCombo(cmbProjectType, "Select Code,Name From tblProjectType", "Name", "Code", True, True)
        Dim ProjectPurpose As New BindCombo(cmbProjectPurpose, "Select Code,Name From tblProjectPurpose", "Name", "Code", True, True)
        Dim Region As New BindCombo(cmbRegion, "Select Code,Name From tblRegion", "Name", "Code", True, True)
        Dim Country As New BindCombo(cmbCountry, "Select Code,Name From tblCountry", "Name", "Code", True, True)
        Dim City As New BindCombo(cmbCity, "Select Code,Name From tblCity", "Name", "Code", True, True)

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

        cSql = "select s.Code, P.Name + ' - ' + L.Name + ' - ' + s.Name as Sector from tblSector s Left Outer Join tblLocation l on s.Location = l.code Left outer Join tblProject P on L.Project = P.Code  Order By P.Name"

        Dim Sector As New BindCombo(cmbSector, cSql, "Sector", "Code", True, True, GLConString)

        Dim CashAccount As New BindCombo(cmbCashAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' and (AccountType = 'Cash Book' or AccountType = 'Bank Book')", "AccountName", "AccountCode", True, True, GLConString)
        Dim ChequeAccount As New BindCombo(cmbChequeAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' and (AccountType = 'Cash Book' or AccountType = 'Bank Book')", "AccountName", "AccountCode", True, True, GLConString)
        Dim FortfietAccount As New BindCombo(cmbForfietAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' and (AccountType = 'Cash Book' or AccountType = 'Bank Book')", "AccountName", "AccountCode", True, True, GLConString)
        Dim Project As New BindCombo(cmbProjectAccount, "Select Code,Name From tblProject Order BY Name", "Name", "Code", True, True, GLConString)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                cmbName.Enabled = False
                txtAddress.Enabled = False
                cmbProjectPurpose.Enabled = False
                cmbProjectType.Enabled = False
                cmbRegion.Enabled = False
                cmbCountry.Enabled = False
                cmbCity.Enabled = False
                txtPrefix.Enabled = False
                txtPenaltyPer.Enabled = False
                cmbPenaltyPolicy.Enabled = False
                txtOfficialReceiptStart.Enabled = False
                txtUnOfficialReceiptStart.Enabled = False

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
                cmbSector.Enabled = False
                cmbCashAccount.Enabled = False
                cmbChequeAccount.Enabled = False
                cmbForfietAccount.Enabled = False
                cmbProjectAccount.Enabled = False
                chkLoanNotApplicable.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                cmbName.Enabled = False
                txtAddress.Enabled = False
                cmbProjectPurpose.Enabled = False
                cmbProjectType.Enabled = False
                cmbRegion.Enabled = False
                cmbCountry.Enabled = False
                cmbCity.Enabled = False
                txtPrefix.Enabled = False
                txtPenaltyPer.Enabled = False
                txtOfficialReceiptStart.Enabled = False
                txtUnOfficialReceiptStart.Enabled = False

                cmbPenaltyPolicy.Enabled = False

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
                cmbSector.Enabled = False
                cmbCashAccount.Enabled = False
                cmbChequeAccount.Enabled = False
                cmbForfietAccount.Enabled = False
                cmbProjectAccount.Enabled = False
                chkLoanNotApplicable.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                cmbName.Enabled = True
                txtAddress.Enabled = True
                cmbProjectPurpose.Enabled = True
                cmbProjectType.Enabled = True
                cmbRegion.Enabled = True
                cmbCountry.Enabled = True
                cmbCity.Enabled = True
                txtPrefix.Enabled = True
                txtPenaltyPer.Enabled = True
                cmbPenaltyPolicy.Enabled = True
                txtOfficialReceiptStart.Enabled = True
                txtUnOfficialReceiptStart.Enabled = True

                cmbName.Focus()

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
                cmbSector.Enabled = True
                cmbCashAccount.Enabled = True
                cmbChequeAccount.Enabled = True
                cmbForfietAccount.Enabled = True
                cmbProjectAccount.Enabled = True
                chkLoanNotApplicable.Enabled = True
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
        If CheckAccess("DeleteRights", UserId, "PROJECT FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblProjectFile Where Code = '" & txtCode.Text & "'")

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
        If CheckAccess("EditRights", UserId, "PROJECT FILE") = -1 Then
            Call SetControls(Actions.Entry)

            Dim db As New dbOperations("Select * From tblUnitType Where Project = '" & txtCode.Text & "'")
            Dim dr As SqlDataReader

            dr = db.dbSelectQuery

            If dr.HasRows Then
                If cmbExtraCharges1.SelectedValue <> "" Then
                    cmbExtraCharges1.Enabled = False
                End If

                If cmbExtraCharges2.SelectedValue <> "" Then
                    cmbExtraCharges2.Enabled = False
                End If

                If cmbExtraCharges3.SelectedValue <> "" Then
                    cmbExtraCharges3.Enabled = False
                End If

                If cmbExtraCharges4.SelectedValue <> "" Then
                    cmbExtraCharges4.Enabled = False
                End If

                If cmbExtraCharges5.SelectedValue <> "" Then
                    cmbExtraCharges5.Enabled = False
                End If

                If cmbExtraCharges6.SelectedValue <> "" Then
                    cmbExtraCharges6.Enabled = False
                End If

                If cmbExtraCharges7.SelectedValue <> "" Then
                    cmbExtraCharges7.Enabled = False
                End If

                If cmbExtraCharges8.SelectedValue <> "" Then
                    cmbExtraCharges8.Enabled = False
                End If

                If cmbExtraCharges9.SelectedValue <> "" Then
                    cmbExtraCharges9.Enabled = False
                End If

                If cmbExtraCharges10.SelectedValue <> "" Then
                    cmbExtraCharges10.Enabled = False
                End If

                If cmbExtraCharges11.SelectedValue <> "" Then
                    cmbExtraCharges11.Enabled = False
                End If

                If cmbExtraCharges12.SelectedValue <> "" Then
                    cmbExtraCharges12.Enabled = False
                End If

                If cmbExtraCharges13.SelectedValue <> "" Then
                    cmbExtraCharges13.Enabled = False
                End If

                If cmbExtraCharges14.SelectedValue <> "" Then
                    cmbExtraCharges14.Enabled = False
                End If

                If cmbExtraCharges15.SelectedValue <> "" Then
                    cmbExtraCharges15.Enabled = False
                End If
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "PROJECT FILE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblProjectFile Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code
                cmbName.Text = RemoveNull(DR!Name, "")
                txtAddress.Text = RemoveNull(DR!Address, "")
                txtPrefix.Text = RemoveNull(DR!Prefix, "")
                cmbProjectType.SelectedValue = RemoveNull(DR!ProjectType, "")
                cmbProjectPurpose.SelectedValue = RemoveNull(DR!ProjectPurpose, "")
                cmbRegion.SelectedValue = RemoveNull(DR!Region, "")
                cmbCountry.SelectedValue = RemoveNull(DR!Country, "")
                cmbCity.SelectedValue = RemoveNull(DR!City, "")
                txtOfficialReceiptStart.Text = RemoveNull(DR!OfficialReceiptStart, "")
                txtUnOfficialReceiptStart.Text = RemoveNull(DR!UnOfficialreceiptStart, "")
                chkLoanNotApplicable.Checked = RemoveNull(DR!LoanNotApplicable, 0)

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

                cmbSector.SelectedValue = RemoveNull(DR!Sector, "")

                txtPenaltyPer.Value = RemoveNull(DR!PenaltyPer, 0)
                cmbPenaltyPolicy.Text = RemoveNull(DR!PenaltyPolicy, "Normal")

                cmbCashAccount.SelectedValue = RemoveNull(DR!CashAccount, "")
                cmbChequeAccount.SelectedValue = RemoveNull(DR!ChequeAccount, "")
                cmbForfietAccount.SelectedValue = RemoveNull(DR!ForfietAccount, "")
                cmbProjectAccount.SelectedValue = RemoveNull(DR!ProjectAccount, "")

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
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim Query As New ActionQueryBuilder
        Dim cAdd As Boolean

        If cmbName.Text = "" Then
            MsgBox("Name Cannot be Left Blank")
            Exit Sub
        End If

        If txtPrefix.Text = "" Then
            MsgBox("Prefix Cannot be Left Blank")
            Exit Sub
        End If

        If cmbProjectType.SelectedValue = "" Then
            MsgBox("Project Type Cannot be Left Blank")
            Exit Sub
        End If

        If cmbProjectPurpose.SelectedValue = "" Then
            MsgBox("Project Purpose Cannot be Left Blank")
            Exit Sub
        End If

        If cmbRegion.SelectedValue = "" Then
            MsgBox("Region Cannot Be Left Blank")
            Exit Sub
        End If

        If cmbCountry.SelectedValue = "" Then
            MsgBox("Country Cannot Be Left Blank")
            Exit Sub
        End If

        If cmbCity.SelectedValue = "" Then
            MsgBox("City Cannot Be Left Blank")
            Exit Sub
        End If
        If txtCode.Text = "" Then
            txtCode.Text = NextSerial("Code", "tblProjectFile", "0000", "", "")

            cAdd = True
        Else
            cAdd = False
        End If

        If CheckDuplicate("tblProjectFile", "Name", cmbName.Text, txtCode.Text, "Code") = True Then
            MsgBox("Already Exist")

            If cAdd = True Then
                txtCode.Text = ""
            End If

            Exit Sub
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblProjectFile", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Name", cmbName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Address", txtAddress.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Prefix", txtPrefix.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ProjectType", cmbProjectType.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ProjectPurpose", cmbProjectPurpose.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Region", cmbRegion.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Country", cmbCountry.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("City", cmbCity.SelectedValue, ActionQueryBuilder.DataType.aString)
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
        Query.AddFields("Sector", cmbSector.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("PenaltyPer", txtPenaltyPer.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("PenaltyPolicy", cmbPenaltyPolicy.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ProjectAccount", cmbProjectAccount.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CashAccount", cmbCashAccount.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ChequeAccount", cmbChequeAccount.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ForfietAccount", cmbForfietAccount.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("OfficialReceiptStart", txtOfficialReceiptStart.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UnOfficialReceiptStart", txtUnOfficialReceiptStart.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("LoanNotApplicable", chkLoanNotApplicable.Checked, ActionQueryBuilder.DataType.aDecimal)

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
        txtCode.Text = ShowList("Select tblProjectFile.Code,tblProjectFile.Name,Prefix,tblProjectType.Name as ProjectType,tblProjectPurpose.Name as ProjectPurpose,tblRegion.Name as Region,tblCountry.Name as Country,tblCity.Name as City From tblProjectFile,tblProjectType,tblProjectPurpose,tblRegion,tblCountry,tblCity Where tblProjectFile.ProjectType = tblProjectType.Code and tblProjectFile.ProjectPurpose = tblProjectPurpose.Code and  tblProjectFile.Region = tblRegion.Code and tblProjectFile.Country = tblCountry.Code and tblProjectFile.City = tblCity.Code Order By tblProjectfile.Code", "List of Country", 1, 0)

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdCityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCityList.Click
        cmbCity.SelectedValue = ShowList("Select Code,Name From tblCity Where Country = '" & cmbCountry.SelectedValue & "'", "List of City", 1, 0)
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class