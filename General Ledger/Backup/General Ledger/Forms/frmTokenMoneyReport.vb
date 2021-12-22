Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmTokenMoneyReport

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmTokenMoneyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCombo()
        Call FormCenter(Me)

        txtDateFrom.Value = Today.Date
        txtDateTo.Value = Today.Date

        cmbReportType.Text = "Both"
    End Sub

    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim cSql As String

        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project")
            Exit Sub
        End If

        cSql = "Select Case When ExpiryDate > GetDate() Then 'Active' Else 'Expired' End as TokenType,TokenNo,TokenDate,tblProjectFile.Name as Project,CustomerName,Mobile,TokenMoney,ExpiryDate,RefundAmount "
        cSql += "From  tblTokenMoney,tblProjectFile "
        cSql += "Where TokenDate Between '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "' "
        cSql += "And   tblTokenMoney.Project = tblProjectFile.Code "
        cSql += "and   Project = '" & cmbProject.SelectedValue & "' "

        If cmbReportType.Text <> "Both" Then
            cSql += "Case When ExpiryDate > GetDate() Then 'Active' Else 'Expired' End = '" & cmbReportType.Text & "' "
        End If

        cSql += "Order By TokenNo "

        ShowList(cSql, "List of Tokens", 1, 0, "TokenMoney,RefundAmount", , "Project,TokenType", "Report", "Project,TokenType")
    End Sub
End Class