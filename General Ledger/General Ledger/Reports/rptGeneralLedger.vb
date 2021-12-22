Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System
Imports System.Data
Imports System.Data.SqlClient




Public Class rptGeneralLedger
    Dim db As dbOperations
    Dim dr As SqlDataReader

    Dim cDescription As String

    Dim cMasterDescription As String
    Private Sub Detail1_AfterPrint(ByVal sender As Object, ByVal e As System.EventArgs) Handles Detail1.AfterPrint

    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If RemoveNull(Me.Fields("Chequedate").Value, Nothing) = Nothing Then
            fldChequeDate.Text = ""
        Else
            If fldDescription.Text = "Balance B/F" Then
                fldChequeDate.Text = ""
            End If
        End If

        If fldDescription.Text = "Balance B/F" Then
            fldChequeDate.Text = ""
        End If

        If fldDebit.Value = 0 Then
            fldDebit.Value = ""
        ElseIf fldCredit.Value = 0 Then
            fldCredit.Value = ""
        End If
    End Sub

    Private Sub rptGeneralLedger_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        fldDateTime.Text = Format(Date.Now, "dd-MMM-yyyy  hh:mm:ss")
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format

    End Sub
End Class
