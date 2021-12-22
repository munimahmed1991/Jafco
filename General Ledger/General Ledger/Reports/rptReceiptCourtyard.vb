Imports GrapeCity.ActiveReports.Document
Imports GrapeCity.ActiveReports.Document.Section
Imports GrapeCity.ActiveReports.SectionReportModel
Imports GrapeCity.ActiveReports.Controls
Imports GrapeCity.ActiveReports
Imports System.Data
Imports System.Data.SqlClient



Public Class rptReceiptCourtyard

    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim db As dbOperations
        Dim dr As SqlDataReader
        Dim cSql As String
        Dim cAccountOf As String

        fldAmountinWords.Text = ToWords(Math.Round(TextBox2.Value, 2), "AMT") + ")"

        cSql = "Select tblPaymentType.Name as PaymentType  "
        cSql = cSql + "From tblReceiptDtl, tblPaymentType "
        cSql = cSql + "Where tblReceiptDtl.PaymentType = tblPaymentType.Code "
        cSql = cSql + "And   tblReceiptDtl.ReceiptNo = '" & TextBox37.Text & "' and IsNull(ReceiptAmount,0) <> 0 "
        cSql = cSql + "Group By tblPaymentType.Name"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cAccountOf = dr!PaymentType

            For Each Row In dr
                cAccountOf = cAccountOf + ", " + dr!PaymentType
            Next
        End If

        TextBox6.Text = cAccountOf
    End Sub
End Class
