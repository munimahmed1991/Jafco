Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptBillsFormat

    Private Sub rptVoucher_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        fldDateTime.Text = Format(Date.Now, "dd-MMM-yyyy  hh:mm:ss")

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub
End Class
