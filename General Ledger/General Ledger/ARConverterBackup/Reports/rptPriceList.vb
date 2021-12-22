Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptPriceList
    Dim cSNo As Double

    Private Sub GroupFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupFooter1.Format
    End Sub

    Private Sub rptVoucher_ReportStart(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.ReportStart
        fldDateTime.Text = Format(Date.Now, "dd-MMM-yyyy  hh:mm:ss")

    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format
        cSNo = 1
    End Sub

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        lblSNo.Value = cSNo

        cSNo = cSNo + 1
    End Sub
End Class
