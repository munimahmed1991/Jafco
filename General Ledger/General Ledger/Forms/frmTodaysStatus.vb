Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmTodaysStatus
    Dim db As dbOperations
    Dim dr As SqlDataReader

    Dim cSql As String

    Private Sub frmTodaysStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)

        txtEntryDate.Value = Today.Date
        txtDateTo.Value = Today.Date

        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub


    Sub TodaysStatus()
        cSql = "Exec TodaysStatus '" & Format(txtEntryDate.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "'"

        ShowList(cSql, "Todays Status Dated From : " + Format(txtEntryDate.Value, "dd-MMM-yyyy") & " To : " & Format(txtDateTo.Value, "dd-MMM-yyyy") & " Project : " + IIf(cmbProject.Text = "", "All", cmbProject.Text), 0, 0, "Booking,BookingAmount,CashAmount,ChequeAmount,TotalAmount", , , "Report", "TotalRecovery")
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call TodaysStatus()
    End Sub
End Class