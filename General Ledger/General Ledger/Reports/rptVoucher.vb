Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports



Public Class rptVoucher

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        fldAmountInWords.Text = ToWords(Math.Round(fldTotalDebit.Value, 2), "AMT")

        If fldSignature1.Text = Nothing Then
            fldSignature1.Visible = False
        End If

        If fldSignature2.Text = Nothing Then
            fldSignature2.Visible = False
        End If

        If fldSignature3.Text = Nothing Then
            fldSignature3.Visible = False
        End If

        If fldSignature4.Text = Nothing Then
            fldSignature4.Visible = False
        End If

        If fldSignature5.Text = Nothing Then
            fldSignature5.Visible = False
        End If

        If fldSignature6.Text = Nothing Then
            fldSignature6.Visible = False
        End If
    End Sub

    Private Sub rptVoucher_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        fldDateTime.Text = Format(Date.Now, "dd-MMM-yyyy  hh:mm:ss")

    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format

    End Sub
End Class
