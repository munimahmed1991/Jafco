Imports System.Data
Imports System.Data.SqlClient

Public Class frmSupplier
    Dim dbGrid As BindGrid
    Dim Query As New ActionQueryBuilder

    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmSupplierFile_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetControls(Actions.Initial)
        Call ClearControls()
        Call FormCenter(Me)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub ClearControls()
        txtCode.Text = ""
        txtAddress.Text = ""
        txtPhone.Text = ""
        txtFax.Text = ""
        txtEmail.Text = ""
        txtWebsite.Text = ""
        txtStaxRegNo.Text = ""
        txtNTNNo.Text = ""
        txtKBCode.Text = ""

        cmbName.Text = ""
        cmbOrigin.SelectedValue = ""
        cmbCountry.SelectedValue = ""
        cmbCity.SelectedValue = ""
        cmbCategory.SelectedText = "Other"
        cmbSupplierAccount.SelectedValue = ""

        tdbGridContact.DataSource = Nothing

        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Name As New BindCombo(cmbName, "Select Name From tblSupplier", "Name", "Name", True, True)
        Dim Origin As New BindCombo(cmbOrigin, "Select Code,Name From tblOrigin Order By Name", "Name", "Code", True, True)
        Dim Country As New BindCombo(cmbCountry, "Select Code,Name From tblCountry Order By Name", "Name", "Code", True, True)
        Dim City As New BindCombo(cmbCity, "Select Code,Name From tblCity Order By Name", "Name", "Code", True, True)
        Dim SupplierAccount As New BindCombo(cmbSupplierAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' and AccountType = 'Supplier' Order By AccountName", "AccountName", "AccountCode", True, True, GLConString)
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                txtAddress.Enabled = False
                txtPhone.Enabled = False
                txtFax.Enabled = False
                txtEmail.Enabled = False
                txtWebsite.Enabled = False
                txtStaxRegNo.Enabled = False
                txtNTNNo.Enabled = False
                txtKBCode.Enabled = False

                cmbName.Enabled = False
                cmbOrigin.Enabled = False
                cmbCountry.Enabled = False
                cmbCity.Enabled = False
                cmbCategory.Enabled = False
                cmbSupplierAccount.Enabled = False

                tdbGridContact.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                txtAddress.Enabled = False
                txtPhone.Enabled = False
                txtFax.Enabled = False
                txtEmail.Enabled = False
                txtWebsite.Enabled = False
                txtStaxRegNo.Enabled = False
                txtNTNNo.Enabled = False
                txtKBCode.Enabled = False

                cmbName.Enabled = False
                cmbOrigin.Enabled = False
                cmbCountry.Enabled = False
                cmbCity.Enabled = False
                cmbCategory.Enabled = False
                cmbSupplierAccount.Enabled = False

                tdbGridContact.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                txtAddress.Enabled = True
                txtPhone.Enabled = True
                txtFax.Enabled = True
                txtEmail.Enabled = True
                txtWebsite.Enabled = True
                txtStaxRegNo.Enabled = True
                txtNTNNo.Enabled = True
                txtKBCode.Enabled = True

                cmbName.Enabled = True
                cmbOrigin.Enabled = True
                cmbCountry.Enabled = True
                cmbCity.Enabled = True
                cmbCategory.Enabled = True
                cmbSupplierAccount.Enabled = True

                tdbGridContact.Enabled = True

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
        If CheckAccess("DeleteRights", UserId, "SUPPLIER FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Query = New ActionQueryBuilder

                dbGrid.SetCriteria = "Code = '" & txtCode.Text & "'"
                dbGrid.Delete()

                Query.Refresh()
                Query.SetQueryInformation("tblSupplier", "Code = '" & txtCode.Text & "'")
                Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete)

                Call SetControls(Actions.Initial)
                Call ClearControls()
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "SUPPLIER FILE") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "SUPPLIER FILE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblSupplier Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code
                txtAddress.Text = RemoveNull(DR!Address, "")
                txtPhone.Text = RemoveNull(DR!Phone, "")
                txtEmail.Text = RemoveNull(DR!Email, "")
                txtWebsite.Text = RemoveNull(DR!Website, "")
                txtStaxRegNo.Text = RemoveNull(DR!StaxRegNo, "")
                txtNTNNo.Text = RemoveNull(DR!NtnNo, "")
                txtKBCode.Text = RemoveNull(DR!KBCode, "")

                cmbName.Text = RemoveNull(DR!Name, "")
                cmbOrigin.SelectedValue = RemoveNull(DR!Origin, "")
                cmbCountry.SelectedValue = RemoveNull(DR!Country, "")
                cmbCity.SelectedValue = RemoveNull(DR!City, "")
                cmbCategory.SelectedText = RemoveNull(DR!Category, "Other")
                cmbSupplierAccount.SelectedValue = RemoveNull(DR!SupplierAccount, "")

                DB.Close()

                Call SetControls(Actions.Edit)
            Else
                MsgBox("Supplier Code Does Not Exist")
                Exit Sub
            End If
        Else
            Call SetControls(Actions.Entry)
            Call ClearControls()
        End If

        dbGrid = New BindGrid(tdbGridContact, "Select Code,ContactPerson,Mobile,Phone,Email From tblSupplierContact Where Code = '" & txtCode.Text & "' Order By RowID")
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cAdd As Boolean

        If txtAddress.Text = "" Then
            MsgBox("Address Cannot be Left Blank")
            Exit Sub
        End If

        'If cmbOrigin.SelectedValue = "" Then
        '    MsgBox("Origin Cannot be Left Blank")
        '    Exit Sub
        'End If

        If cmbCountry.SelectedValue = "" Then
            MsgBox("Country Cannot be Left Blank")
            Exit Sub
        End If

        If cmbCity.SelectedValue = "" Then
            MsgBox("City Cannot be Left Blank")
            Exit Sub
        End If

        If txtPhone.Text = "" Then
            MsgBox("Phone Cannot be Left Blank")
            Exit Sub
        End If

        If txtEmail.Text = "" Then
            MsgBox("Email Cannot be Left Blank")
            Exit Sub
        End If

        If txtCode.Text = "" Then
            txtCode.Text = NextSerial("Code", "tblSupplier", "00000000", "S-", "")

            cAdd = True
        Else
            cAdd = False
        End If

        If CheckDuplicate("tblSupplier", "Name", cmbName.Text, txtCode.Text, "Code") = True Then
            MsgBox("Already Exist")

            If cAdd = True Then
                txtCode.Text = ""
            End If

            Exit Sub
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblSupplier", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Name", cmbName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Category", cmbCategory.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Origin", cmbOrigin.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Country", cmbCountry.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("City", cmbCity.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Address", txtAddress.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Phone", txtPhone.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Fax", txtFax.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Email", txtEmail.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Website", txtWebsite.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("StaxRegNo", txtStaxRegNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("NTNNo", txtNTNNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("SupplierAccount", cmbSupplierAccount.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("KBCode", txtKBCode.Text, ActionQueryBuilder.DataType.aString)

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

        txtCode.Text = ShowList("Select tblSupplier.Code,tblSupplier.Name,Category,Address,tblCOuntry.Name as Country,tblCity.Name as City,Phone,Fax,Email,Website,StaxRegNo,NTNNo From tblSupplier,tblCountry,tblCity Where tblSupplier.Country = tblCountry.Code and tblSupplier.City = tblCity.Code Order By tblSupplier.Code", "List of Suppliers", 1, 0, "", "", "", "List", "", "", "No")

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdOriginList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOriginList.Click
        cmbOrigin.SelectedValue = ShowList("Select Code,Name From tblOrigin Order By Code", "List of Origin", 1, 0)
    End Sub

    Private Sub cmdCountryList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCountryList.Click
        cmbCountry.SelectedValue = ShowList("Select Code,Name From tblCountry Order By Code", "List of Country", 1, 0)
    End Sub

    Private Sub cmdCity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCity.Click
        cmbCity.SelectedValue = ShowList("Select Code,Name From tblCity Where Country = '" & cmbCountry.SelectedValue & "' Order By Code", "List of Cities", 1, 0)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Dim cOrigin As String
        Dim cCountry As String
        Dim cCity As String

        cOrigin = cmbOrigin.SelectedValue
        cCountry = cmbCountry.SelectedValue
        cCity = cmbCity.SelectedValue

        Call FillCombo()

        If RemoveNull(cOrigin, "") <> "" Then
            cmbOrigin.SelectedValue = cOrigin
        End If

        If RemoveNull(cCountry, "") <> "" Then
            cmbCountry.SelectedValue = cCountry
        End If

        If RemoveNull(cCity, "") <> "" Then
            cmbCity.SelectedValue = cCity
        End If
    End Sub

    Private Sub cmdNewCountry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewCountry.Click
        frmCountry.MdiParent = frmMain
        frmCountry.Show()

        frmCountry.DisplayRec()
    End Sub

    Private Sub cmdNewCity_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNewCity.Click
        frmCity.MdiParent = frmMain
        frmCity.Show()

        frmCity.DisplayRec()

        frmCity.cmbCountry.SelectedValue = cmbCountry.SelectedValue
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub
End Class