Imports System.Data
Imports System.Data.SqlClient

Public Class frmChangePassword
    Dim Query As ActionQueryBuilder
    Private Sub frmChangePassword_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        txtUserName.Text = UserId
        txtCurrentPassword.Text = ""
        txtNewPassword.Text = ""
        txtRetypeNewPassword.Text = ""

    End Sub

    Private Sub cmdChange_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdChange.Click
        Dim dr As SqlDataReader = Nothing
        Dim db As New dbOperations("Select * from tblUsers Where UserID = '" & txtUserName.Text & "' And Password = '" & txtCurrentPassword.Text & "'And CompanyID = '" & cCompanyId & "'", dr)
        If dr.Read Then
            If txtNewPassword.Text = txtRetypeNewPassword.Text Then
                Query = New ActionQueryBuilder
                Query.SetQueryInformation("tblUsers", "UserID = '" & txtUserName.Text & "' And Password = '" & txtCurrentPassword.Text & "'And CompanyID = '" & cCompanyId & "'")
                Query.AddFields("Password", txtNewPassword.Text, ActionQueryBuilder.DataType.aString)
                Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
                Me.Close()
            Else
                MsgBox("New Password and retype password are not matching.")
                txtNewPassword.Focus()
            End If
        Else
            MsgBox("Invalid Current Password")
            txtCurrentPassword.Focus()
        End If
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub txtCurrentPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCurrentPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtNewPassword.Focus()
        End If
    End Sub

    Private Sub txtNewPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtNewPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtRetypeNewPassword.Focus()
        End If
    End Sub

    Private Sub txtRetypeNewPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtRetypeNewPassword.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            cmdChange.Focus()
        End If
    End Sub
End Class