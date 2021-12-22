Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports



Public Class rptProductValuation

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If fldAmount.Value > 0 And fldBalQty.Value > 0 Then
            fldRate.Value = fldAmount.Value / fldBalQty.Value
        End If
    End Sub
End Class
