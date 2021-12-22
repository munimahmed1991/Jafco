Imports System.Data
Imports System.Data.SqlClient

Public Class frmTokenMoney
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
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub ClearControls()
        txtTokenNo.Text = ""
        txtCustomerName.Text = ""
        txtTokenDate.Value = Today.Date
        txtMobile.Text = ""
        txtTokenMoney.Value = 0
        txtExpiryDate.Value = Today.Date
        txtRefundAmount.Value = 0
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                txtTokenNo.Enabled = True
                txtTokenDate.Enabled = False
                txtCustomerName.Enabled = False
                txtMobile.Enabled = False
                txtTokenMoney.Enabled = False
                txtExpiryDate.Enabled = False
                txtRefundAmount.Enabled = False
                cmbProject.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                txtTokenNo.Enabled = True
                txtTokenDate.Enabled = False
                txtCustomerName.Enabled = False
                txtMobile.Enabled = False
                txtTokenMoney.Enabled = False
                txtExpiryDate.Enabled = False
                txtRefundAmount.Enabled = False
                cmbProject.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                txtTokenNo.Enabled = False
                txtTokenDate.Enabled = True
                txtCustomerName.Enabled = True
                txtMobile.Enabled = True
                txtTokenMoney.Enabled = True
                txtExpiryDate.Enabled = True
                txtRefundAmount.Enabled = True
                cmbProject.Enabled = True
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
        If CheckAccess("DeleteRights", UserId, "TOKEN MONEY") = -1 Then
            If MsgBox("Do You Want to Delete this Record", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim DB As New dbOperations("Delete From tblTokenMoney Where TokenNo = '" & txtTokenNo.Text & "'")

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
        If CheckAccess("EditRights", UserId, "TOKEN MONEY") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click
        If CheckAccess("AddRights", UserId, "TOKEN MONEY") = -1 Then
            Call DisplayRec()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Sub DisplayRec()
        If txtTokenNo.Text <> "" Then
            Dim DB As New dbOperations("Select * From tblTokenMoney Where TokenNo = '" & txtTokenNo.Text & "'")
            Dim DR As SqlDataReader

            DR = DB.dbSelectQuery

            If DR.HasRows Then
                DR.Read()

                txtTokenNo.Text = DR!TokenNo
                txtCustomerName.Text = RemoveNull(DR!CustomerName, "")
                txtMobile.Text = RemoveNull(DR!Mobile, "")
                txtTokenDate.Value = RemoveNull(DR!TokenDate, Today.Date)
                txtTokenMoney.Value = RemoveNull(DR!TokenMoney, 0)
                txtExpiryDate.Value = RemoveNull(DR!ExpiryDate, Today.Date)
                txtRefundAmount.Value = RemoveNull(DR!RefundAmount, 0)
                cmbProject.SelectedValue = RemoveNull(DR!Project, "")

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

        If txtCustomerName.Text = "" Then
            MsgBox("Customer Name Cannot be Left Blank")
            Exit Sub
        End If

        If txtMobile.Text = "" Then
            MsgBox("Mobile # Cannot be Left Blank")
            Exit Sub
        End If

        If txtTokenMoney.Value = 0 Then
            MsgBox("Token Money Cannot be Left Blank")
            Exit Sub
        End If

        If cmbProject.SelectedValue = "" Then
            MsgBox("Project Cannot be Left Blank")
            Exit Sub
        End If

        If txtTokenNo.Text = "" Then
            txtTokenNo.Text = NextSerial("TokenNo", "tblTokenMoney", "000000", "T-", "")

            cAdd = True
        Else
            cAdd = False
        End If

        Query.Refresh()
        Query.SetQueryInformation("tblTokenMoney", "TokenNo = '" & txtTokenNo.Text & "'")
        Query.AddFields("TokenNo", txtTokenNo.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("CustomerName", txtCustomerName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("TokenDate", txtTokenDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("Mobile", txtMobile.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("TokenMoney", txtTokenMoney.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ExpiryDate", txtExpiryDate.Value, ActionQueryBuilder.DataType.aDate)
        Query.AddFields("RefundAmount", txtRefundAmount.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)

        If cAdd = True Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        End If

        If MsgBox("Do You Want to Print", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Call Print()
        End If

        Call SetControls(Actions.Initial)
        Call ClearControls()
    End Sub

    Private Sub txtCode_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtTokenNo.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtTokenNo.Text = ShowList("Select 'Token' as Type,TokenNo,TokenDate,tblProjectFile.Name as Project,CustomerName,Mobile,TokenMoney,ExpiryDate,RefundAmount From tblTokenMoney,tblProjectFile Where tblTokenMoney.Project = tblProjectFile.Code Order By TokenNo", "List of Tokens", 1, 1, "TokenMoney,RefundAmount")

        If txtTokenNo.Text <> "" Then
            Call DisplayRec()
        End If
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call Print()
    End Sub

    Sub Print()
        Dim cSql As String

        cSql = "Select	1 as SNo,'Customer Copy' as ReceiptCopy,*"
        cSql = cSql + "From	    tblTokenMoney "
        cSql = cSql + "Where      TokenNo = '" & txtTokenNo.Text & "' "
        cSql = cSql + "Union All "
        cSql = cSql + "Select	2 as SNo,'Office Copy' as ReceiptCopy,*"
        cSql = cSql + "From	    tblTokenMoney "
        cSql = cSql + "Where      TokenNo = '" & txtTokenNo.Text & "' "

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptToken

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "Receipt")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("Receipt")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        fPreview.Show()

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

End Class