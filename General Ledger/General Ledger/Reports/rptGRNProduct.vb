Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports



Public Class rptGRNProduct
    Dim cSNo As Integer = 0
    Dim cSql As String

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        'cSNo += 1
        'fldSNo.Value = cSNo
    End Sub

    Private Sub PageFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageFooter1.Format
        fldDate.Value = Now.Date
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub

    Private Sub rptGRNFabric_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format

    End Sub
End Class
