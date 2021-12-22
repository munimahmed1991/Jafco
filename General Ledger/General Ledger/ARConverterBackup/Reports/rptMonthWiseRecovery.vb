Imports DataDynamics.ActiveReports 
Imports DataDynamics.ActiveReports.Document 

Public Class rptMonthWiseRecovery

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        If fldTotalReceipt.Value <> 0 And fldReceipt1.Value <> 0 Then
            fldPer1.Value = (fldReceipt1.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt2.Value <> 0 Then
            fldPer2.Value = (fldReceipt2.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt3.Value <> 0 Then
            fldPer3.Value = (fldReceipt3.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt4.Value <> 0 Then
            fldPer4.Value = (fldReceipt4.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt5.Value <> 0 Then
            fldPer5.Value = (fldReceipt5.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt6.Value <> 0 Then
            fldPer6.Value = (fldReceipt6.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt7.Value <> 0 Then
            fldPer7.Value = (fldReceipt7.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt8.Value <> 0 Then
            fldPer8.Value = (fldReceipt8.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt9.Value <> 0 Then
            fldPer9.Value = (fldReceipt9.Value / fldTotalReceipt.Value) * 100
        End If

        If fldTotalReceipt.Value <> 0 And fldReceipt10.Value <> 0 Then
            fldPer10.Value = (fldReceipt10.Value / fldTotalReceipt.Value) * 100
        End If

        If fldOpeningBalance.Value <> 0 And fldTotalReceipt.Value <> 0 Then
            fldPerOpeningBalance.Value = (fldOpeningBalance.Value / fldTotalReceipt.Value) * 100
        End If
    End Sub
End Class
