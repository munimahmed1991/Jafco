Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptProductLedger

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        If fldAmount.Value > 0 And fldBalQty.Value > 0 Then
            fldRate.Value = Math.Round(fldAmount.Value / fldBalQty.Value, 4)
        End If
    End Sub
End Class
