Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports



Public Class rptInventorySummaryReport

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        If TextBox23.Value <> 0 And TextBox18.Value <> 0 Then
            fldPerBlockWise.Value = (TextBox18.Value / TextBox23.Value) * 100
        Else
            fldPerBlockWise.Value = 0
        End If
    End Sub

    Private Sub rptVoucher_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        fldDateTime.Text = Format(Date.Now, "dd-MMM-yyyy  hh:mm:ss")
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If TextBox8.Value <> 0 And TextBox2.Value <> 0 Then
            fldPerBooking.Value = (TextBox8.Value / TextBox2.Value) * 100
        Else
            fldPerBooking.Value = 0
        End If
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        If TextBox34.Value <> 0 And TextBox29.Value <> 0 Then
            fldTotalPer.Value = (TextBox29.Value / TextBox34.Value) * 100
        Else
            fldTotalPer.Value = 0
        End If
    End Sub
End Class
