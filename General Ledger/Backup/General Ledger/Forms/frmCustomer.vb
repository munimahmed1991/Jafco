Imports System.Data
Imports System.Data.SqlClient

Public Class frmCustomer
    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub frmCountry_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call SetControls(Actions.Initial)
        Call ClearControls()
        Call FormCenter(Me)
        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Country As New BindCombo(cmbCountry, "Select * From tblCountry", "Name", "Code", True, True)
        Dim City As New BindCombo(cmbCity, "Select * From tblCity", "Name", "Code", True, True)
        Dim Area As New BindCombo(cmbArea, "select * From tblAreaFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub ClearControls()
        txtCode.Text = ""
        txtName.Text = ""
        txtFatherHusbandName.Text = ""
        txtNIC1.Text = ""
        txtNIC2.Text = ""
        txtNIC3.Text = ""
        txtCityRes.Text = ""
        txtTelRes.Text = ""
        txtMobileCompany.Text = ""
        txtMobileNo.Text = ""
        txtMobileCompany2.Text = ""
        txtMobileNo2.Text = ""
        txtMobileCompany3.Text = ""
        txtMobileNo3.Text = ""
        txtAddress.Text = ""
        txtOccupation.Text = ""
        txtCompany.Text = ""
        txtDesignation.Text = ""
        txtAddressOffice.Text = ""
        txtCityOffice.Text = ""
        txtTelOffice.Text = ""
        txtEmail.Text = ""
        cmbCountry.SelectedValue = ""
        cmbCity.SelectedValue = ""
        cmbArea.SelectedValue = ""
        txtAddressOld1.Text = ""
        txtAddressOld2.Text = ""
        txtAddressOld3.Text = ""
        txtChangeDate1.Value = Nothing
        txtChangeDate2.Value = Nothing
        txtChangeDate3.Value = Nothing
        txtExpiryDate.Value = Nothing
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtCode.Enabled = True
                txtName.Enabled = False
                txtFatherHusbandName.Enabled = False
                txtNIC1.Enabled = False
                txtNIC2.Enabled = False
                txtNIC3.Enabled = False
                txtCityRes.Enabled = False
                txtTelRes.Enabled = False
                txtMobileCompany.Enabled = False
                txtMobileNo.Enabled = False
                txtMobileCompany2.Enabled = False
                txtMobileNo2.Enabled = False
                txtMobileCompany3.Enabled = False
                txtMobileNo3.Enabled = False
                txtAddress.Enabled = False
                txtOccupation.Enabled = False
                txtCompany.Enabled = False
                txtDesignation.Enabled = False
                txtAddressOffice.Enabled = False
                txtCityOffice.Enabled = False
                txtTelOffice.Enabled = False
                txtEmail.Enabled = False
                cmbCountry.Enabled = False
                cmbCity.Enabled = False
                cmbArea.Enabled = False
                txtExpiryDate.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtCode.Enabled = False
                txtName.Enabled = False
                txtFatherHusbandName.Enabled = False
                txtNIC1.Enabled = False
                txtNIC2.Enabled = False
                txtNIC3.Enabled = False
                txtCityRes.Enabled = False
                txtTelRes.Enabled = False
                txtMobileCompany.Enabled = False
                txtMobileNo.Enabled = False
                txtMobileCompany2.Enabled = False
                txtMobileNo2.Enabled = False
                txtMobileCompany3.Enabled = False
                txtMobileNo3.Enabled = False
                txtAddress.Enabled = False
                txtOccupation.Enabled = False
                txtCompany.Enabled = False
                txtDesignation.Enabled = False
                txtAddressOffice.Enabled = False
                txtCityOffice.Enabled = False
                txtTelOffice.Enabled = False
                txtEmail.Enabled = False
                cmbCountry.Enabled = False
                cmbCity.Enabled = False
                cmbArea.Enabled = False
                txtExpiryDate.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtCode.Enabled = False
                txtName.Enabled = True
                txtFatherHusbandName.Enabled = True
                txtNIC1.Enabled = True
                txtNIC2.Enabled = True
                txtNIC3.Enabled = True
                txtCityRes.Enabled = True
                txtTelRes.Enabled = True
                txtMobileCompany.Enabled = True
                txtMobileNo.Enabled = True
                txtMobileCompany2.Enabled = True
                txtMobileNo2.Enabled = True
                txtMobileCompany3.Enabled = True
                txtMobileNo3.Enabled = True
                txtAddress.Enabled = True
                txtOccupation.Enabled = True
                txtCompany.Enabled = True
                txtDesignation.Enabled = True
                txtAddressOffice.Enabled = True
                txtCityOffice.Enabled = True
                txtTelOffice.Enabled = True
                txtEmail.Enabled = True
                cmbCountry.Enabled = True
                cmbCity.Enabled = True
                cmbArea.Enabled = True
                txtExpiryDate.Enabled = True

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
        If CheckAccess("DeleteRights", UserId, "CUSTOMER FILE") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As dbOperations
                Dim DR As SqlDataReader

                DB = New dbOperations("Select * From tblReservationMst Where Customer = '" & txtCode.Text & "'")
                DR = DB.dbSelectQuery

                If DR.HasRows = True Then
                    MsgBox("Customer Cannot be Deleted Because it Exist in Reservation")
                    Exit Sub
                End If

                DB = New dbOperations("Select * From tblReservationMst Where IsNull(Customer2,'') = '" & txtCode.Text & "'")
                DR = DB.dbSelectQuery

                If DR.HasRows = True Then
                    MsgBox("Customer Cannot be Deleted Because it Exist in Reservation")
                    Exit Sub
                End If

                DB = New dbOperations("Delete From tblCustomer Where Code = '" & txtCode.Text & "'")
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
        If CheckAccess("EditRights", UserId, "CUSTOMER FILE") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "CUSTOMER FILE") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtCode.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblCustomer Where Code = '" & txtCode.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtCode.Text = DR!Code
                txtName.Text = RemoveNull(DR!Name, "")
                cmbSLT.Text = RemoveNull(DR!Slt, "")
                txtFatherHusbandName.Text = RemoveNull(DR!FatherHusbandName, "")

                txtNIC1.Text = Mid(RemoveNull(DR!NicNo, ""), 1, 5)
                txtNIC2.Text = Mid(RemoveNull(DR!NicNo, ""), 7, 7)
                txtNIC3.Text = Strings.Right(RemoveNull(DR!NicNo, ""), 1)

                txtCityRes.Text = Strings.Left(RemoveNull(DR!TelRes, ""), 4)
                txtTelRes.Text = Strings.Right(RemoveNull(DR!TelRes, ""), 7)

                txtMobileCompany.Text = Strings.Left(RemoveNull(DR!Mobile, ""), 4)
                txtMobileNo.Text = Strings.Right(RemoveNull(DR!Mobile, ""), 7)

                txtMobileCompany2.Text = Strings.Left(RemoveNull(DR!Mobile2, ""), 4)
                txtMobileNo2.Text = Strings.Right(RemoveNull(DR!Mobile2, ""), 7)

                txtMobileCompany3.Text = Strings.Left(RemoveNull(DR!Mobile3, ""), 4)
                txtMobileNo3.Text = Strings.Right(RemoveNull(DR!Mobile3, ""), 7)

                txtAddress.Text = RemoveNull(DR!Address, "")

                txtAddressOld1.Text = RemoveNull(DR!AddressOld1, "")
                txtAddressOld2.Text = RemoveNull(DR!AddressOld2, "")
                txtAddressOld3.Text = RemoveNull(DR!AddressOld3, "")

                txtChangeDate1.Value = RemoveNull(DR!ChangeDate1, Nothing)
                txtChangeDate2.Value = RemoveNull(DR!ChangeDate2, Nothing)
                txtChangeDate3.Value = RemoveNull(DR!ChangeDate3, Nothing)

                txtOccupation.Text = RemoveNull(DR!Occupation, "")
                txtCompany.Text = RemoveNull(DR!Company, "")
                txtDesignation.Text = RemoveNull(DR!Designation, "")
                txtAddressOffice.Text = RemoveNull(DR!AddressOffice, "")

                txtCityOffice.Text = Strings.Left(RemoveNull(DR!TelOffice, ""), 4)
                txtTelOffice.Text = Strings.Right(RemoveNull(DR!TelOffice, ""), 7)

                txtEmail.Text = RemoveNull(DR!Email, "")

                cmbCountry.SelectedValue = RemoveNull(DR!Country, "")
                cmbCity.SelectedValue = RemoveNull(DR!City, "")
                cmbArea.SelectedValue = RemoveNull(DR!Area, "")
                txtExpiryDate.Value = RemoveNull(DR!ExpiryDate, Nothing)

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

        Dim ContainsAlpha As Boolean

        If cmbSLT.Text = "" Then
            MsgBox("Please Select Salutation")
            cmbSLT.Focus()
            Exit Sub
        End If

        If txtName.Text = "" Then
            MsgBox("Please Enter Name - Cannot Save")
            Exit Sub
        End If

        If txtNIC1.Text = "" Then
            MsgBox("Please Enter NIC - Cannot Save")
            Exit Sub
        End If

        If txtNIC2.Text = "" Then
            MsgBox("Please Enter NIC - Cannot Save")
            Exit Sub
        End If

        If txtNIC3.Text = "" Then
            MsgBox("Please Enter NIC - Cannot Save")
            Exit Sub
        End If

        If txtMobileCompany.Text = "" Then
            MsgBox("Please Enter Mobile # - Cannot Save")
            Exit Sub
        End If

        If txtMobileNo.Text = "" Then
            MsgBox("Please Enter Mobile # - Cannot Save")
            'Exit Sub
        Else
            'If Mid(txtMobileCompany.Text, 1, 1) <> "+" Then
            '    If Len(txtMobileNo.Text) <> 7 Then
            '        MsgBox("Invalid Mobile # ")
            '        Exit Sub
            '    End If
            'End If
        End If

        'If txtMobileNo2.Text <> "" Then
        '    If Mid(txtMobileCompany2.Text, 1, 1) <> "+" Then
        '        If Len(txtMobileNo2.Text) <> 7 Then
        '            MsgBox("Invalid Mobile # 2")
        '            Exit Sub
        '        End If
        '    End If
        'End If

        'If txtMobileNo3.Text <> "" Then
        '    If Mid(txtMobileCompany3.Text, 1, 1) <> "+" Then
        '        If Len(txtMobileNo3.Text) <> 7 Then
        '            MsgBox("Invalid Mobile # 3")
        '            Exit Sub
        '        End If
        '    End If
        'End If

        ContainsAlpha = False

        For Each Character As Char In txtNIC1.Text + txtNIC2.Text + txtNIC3.Text
            If Char.IsLetter(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsWhiteSpace(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsSymbol(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsSeparator(Character) Then
                ContainsAlpha = True
            End If
        Next

        If ContainsAlpha = True Then
            MsgBox("Cannot Except Alpha Numeric Values in NIC Please Enter in Correct Format")
            Exit Sub
        End If

        ContainsAlpha = False

        For Each Character As Char In txtMobileCompany.Text + txtMobileNo.Text
            If Char.IsLetter(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsWhiteSpace(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsSymbol(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsSeparator(Character) Then
                ContainsAlpha = True
            End If
        Next

        If ContainsAlpha = True Then
            MsgBox("Cannot Except Alpha Numeric Values in Mobile # Please Enter in Correct Format")
            Exit Sub
        End If


        ContainsAlpha = False

        For Each Character As Char In txtCityRes.Text + txtTelRes.Text
            If Char.IsLetter(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsWhiteSpace(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsSymbol(Character) Then
                ContainsAlpha = True
            ElseIf Char.IsSeparator(Character) Then
                ContainsAlpha = True
            End If
        Next

        If ContainsAlpha = True Then
            MsgBox("Cannot Except Alpha Numeric Values in Tel # Please Enter in Correct Format")
            Exit Sub
        End If

        If txtCode.Text = "" Then
            txtCode.Text = NextSerial("Code", "tblCustomer", "00000000", "", "")

            cAdd = True


        Else
            cAdd = False
        End If

        If CheckDuplicate("tblCustomer", "NICNo", Trim(txtNIC1.Text) + "-" + Trim(txtNIC2.Text) + "-" + Trim(txtNIC3.Text), txtCode.Text, "Code") = True Then
            MsgBox("NIC # Already Exist")

            If cAdd = True Then
                txtCode.Text = ""
            End If

            Exit Sub
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblCustomer", "Code = '" & txtCode.Text & "'")
        Query.AddFields("Code", txtCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("SLT", cmbSLT.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Name", UCase(txtName.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("FatherHusbandName", UCase(txtFatherHusbandName.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("NICNo", Trim(txtNIC1.Text) + "-" + Trim(txtNIC2.Text) + "-" + Trim(txtNIC3.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("TelRes", Trim(txtCityRes.Text) + "-" + Trim(txtTelRes.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Mobile", Trim(txtMobileCompany.Text) + "-" + Trim(txtMobileNo.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Mobile2", Trim(txtMobileCompany2.Text) + "-" + Trim(txtMobileNo2.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Mobile3", Trim(txtMobileCompany3.Text) + "-" + Trim(txtMobileNo3.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Address", UCase(txtAddress.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Occupation", UCase(txtOccupation.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Company", UCase(txtCompany.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Designation", UCase(txtDesignation.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("AddressOffice", UCase(txtAddressOffice.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("TelOffice", Trim(txtCityOffice.Text) + "-" + Trim(txtTelOffice.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Email", LCase(txtEmail.Text), ActionQueryBuilder.DataType.aString)
        Query.AddFields("Country", cmbCountry.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("City", cmbCity.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Area", cmbArea.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("AddressOld1", txtAddressOld1.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("AddressOld2", txtAddressOld2.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("AddressOld3", txtAddressOld3.Text, ActionQueryBuilder.DataType.aString)

        If txtAddressOld1.Text <> "" Then
            Query.AddFields("ChangeDate1", txtChangeDate1.Value, ActionQueryBuilder.DataType.aDateTime)
        End If

        If txtAddressOld2.Text <> "" Then
            Query.AddFields("ChangeDate2", txtChangeDate2.Value, ActionQueryBuilder.DataType.aDateTime)
        End If

        If txtAddressOld3.Text <> "" Then
            Query.AddFields("ChangeDate3", txtChangeDate3.Value, ActionQueryBuilder.DataType.aDateTime)
        End If

        If RemoveNull(txtExpiryDate.Value, "1/1/2000") <> "1/1/2000" Then
            Query.AddFields("ExpiryDate", txtExpiryDate.Value, ActionQueryBuilder.DataType.aDateTime)
        End If

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
            MsgBox("Customer Code for New Customer Generated Is : " + txtCode.Text)
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
        txtCode.Text = ShowList("Select tblCustomer.Code,Ltrim(Rtrim(Slt)) + ' ' + Ltrim(Rtrim(tblCustomer.Name)) as Customer,FatherHusbandName,NicNo,ExpiryDate,TelRes,TelOffice,Mobile,tblCountry.Name as Country,tblCity.Name as City,tblAreaFile.Name as Area,1 as Customers,Occupation,Email,Address,Company,Designation,AddressOffice From tblCustomer Left Outer Join tblCountry On tblCountry.Code = tblCustomer.Country  Left Outer Join tblCity On tblCity.Code = tblCustomer.City  Left Outer Join tblAreaFile On tblAreaFile.Code = tblCustomer.Area Order By tblCustomer.Code", "List of Customers", 1, 0, "Customers")

        If txtCode.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub txtNIC1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIC1.TextChanged

    End Sub

    Private Sub txtNIC2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIC2.TextChanged

    End Sub

    Private Sub txtNIC3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNIC3.TextChanged

    End Sub

    Private Sub txtCityRes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtCityRes.TextChanged

    End Sub

    Private Sub txtTelRes_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtTelRes.TextChanged

    End Sub

    Private Sub txtMobileNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileNo.TextChanged

    End Sub

    Private Sub txtMobileCompany_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileCompany.TextChanged

    End Sub

    Private Sub cmdCityList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCityList.Click
        cmbCity.SelectedValue = ShowList("Select Code,Name From tblCity Where Country = '" & cmbCountry.SelectedValue & "'", "List of City", 1, 0)
    End Sub

    Private Sub cmdArea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdArea.Click
        cmbArea.SelectedValue = ShowList("Select Code,Name From tblAreaFile Where City = '" & cmbCity.SelectedValue & "'", "List of Area", 1, 0)
    End Sub


    Private Sub txtMobileNo2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileNo2.TextChanged

    End Sub

    Private Sub txtMobileNo3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileNo3.TextChanged

    End Sub

    Private Sub cmdChangeAddress_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChangeAddress.Click
        If txtAddressOld1.Text = "" Then
            txtAddressOld1.Text = txtAddress.Text

            txtChangeDate1.Value = Today.Date
        ElseIf txtAddressOld1.Text <> "" And txtAddressOld2.Text = "" Then
            txtAddressOld2.Text = txtAddress.Text

            txtChangeDate2.Value = Today.Date

        ElseIf txtAddressOld1.Text <> "" And txtAddressOld2.Text <> "" And txtAddressOld3.Text = "" Then
            txtAddressOld3.Text = txtAddress.Text

            txtChangeDate3.Value = Today.Date
        End If
    End Sub

    Private Sub txtMobileCompany2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileCompany2.TextChanged

    End Sub

    Private Sub txtMobileCompany3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtMobileCompany3.TextChanged

    End Sub

    Private Sub cmbCity_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbCity.TextChanged

    End Sub
End Class