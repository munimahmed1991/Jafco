Imports System.Data
Imports System.Data.SqlClient
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 


Public Class rptDateWiseReceiptReport
    Dim cSNo As Double

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        cSNo = cSNo + 1

        fldSNo.Text = cSNo
    End Sub

    Private Sub ReportHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub
End Class
