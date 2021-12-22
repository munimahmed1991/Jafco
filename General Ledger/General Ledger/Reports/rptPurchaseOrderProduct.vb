Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports



Public Class rptPurchaseOrderProduct
    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
        TextBox18.Value = TextBox7.Value - TextBox8.Value + TextBox11.Value + TextBox12.Value

        fldAmountinWords.Text = ToWords(Math.Round(TextBox18.Value, 2), "AMT")
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format

    End Sub

    Private Sub GroupHeader1_Format(sender As Object, e As EventArgs) Handles GroupHeader1.Format

    End Sub
End Class
