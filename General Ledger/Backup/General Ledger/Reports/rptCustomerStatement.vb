Imports System.Data
Imports System.Data.SqlClient
Imports DataDynamics.ActiveReports
Imports DataDynamics.ActiveReports.Document 
Public Class rptCustomerStatement
    Dim db As dbOperations
    Dim dr As SqlDataReader
    Dim cSql As String


    Private Sub Detail1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Detail1.Format
        Dim db As dbOperations
        Dim dr As SqlDataReader

        Dim cReceiptNo As String
        Dim cManualReceipt As String
        Dim cReceiptDate As String

        cReceiptNo = ""

        db = New dbOperations("Select Dtl.ReceiptNo,Mst.ReceiptDate,ManualReceiptNo From tblReceiptMst Mst,tblReceiptDtl Dtl Where Mst.ReceiptNo = Dtl.ReceiptNo and Dtl.InvoiceNo = '" & fldInvoiceNo.Text & "' and Dtl.ReceiptAmount <> 0 ")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cReceiptNo = dr!ReceiptNo
            cReceiptDate = Format(dr!ReceiptDate, "dd/MM/yyyy")
            cManualReceipt = RemoveNull(dr!ManualReceiptNo, "")

            For Each Row In dr
                cReceiptNo = cReceiptNo + ", " + dr!ReceiptNo
                cReceiptDate = cReceiptDate + ", " + Format(dr!ReceiptDate, "dd/MM/yyyy")
                cManualReceipt = cManualReceipt + ", " + RemoveNull(dr!ManualReceiptNo, "")
            Next
        Else
            cReceiptNo = ""
            cReceiptDate = ""
            cManualReceipt = ""
        End If

        fldReceiptNo.Text = cReceiptNo
        fldReceiptDate.Text = cReceiptDate
        fldMaualReceiptNo.Text = cManualReceipt

        If RemoveNull(TextBox6.Value, 0) <> 0 And RemoveNull(TextBox3.Value, 0) <> 0 Then
            txtBalPer.Value = (TextBox6.Value / TextBox3.Value) * 100
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub ReportHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportHeader1.Format
        cSql = "Select	tblUnitFile.Code,"
        cSql = cSql + "Case When IsNull(ExtraCharges1Apply,0) = 1 Then Extra1.Name Else '' End as Extra1,"
        cSql = cSql + "Case When IsNull(ExtraCharges2Apply,0) = 1 Then Extra2.Name Else '' End as Extra2,"
        cSql = cSql + "Case When IsNull(ExtraCharges3Apply,0) = 1 Then Extra3.Name Else '' End as Extra3,"
        cSql = cSql + "Case When IsNull(ExtraCharges4Apply,0) = 1 Then Extra4.Name Else '' End as Extra4,"
        cSql = cSql + "Case When IsNull(ExtraCharges5Apply,0) = 1 Then Extra5.Name Else '' End as Extra5,"
        cSql = cSql + "Case When IsNull(ExtraCharges6Apply,0) = 1 Then Extra6.Name Else '' End as Extra6,"
        cSql = cSql + "Case When IsNull(ExtraCharges7Apply,0) = 1 Then Extra7.Name Else '' End as Extra7,"
        cSql = cSql + "Case When IsNull(ExtraCharges8Apply,0) = 1 Then Extra8.Name Else '' End as Extra8,"
        cSql = cSql + "Case When IsNull(ExtraCharges9Apply,0) = 1 Then Extra9.Name Else '' End as Extra9,"
        cSql = cSql + "Case When IsNull(ExtraCharges10Apply,0) = 1 Then Extra10.Name Else '' End as Extra10,"
        cSql = cSql + "Case When IsNull(ExtraCharges11Apply,0) = 1 Then Extra11.Name Else '' End as Extra11,"
        cSql = cSql + "Case When IsNull(ExtraCharges12Apply,0) = 1 Then Extra12.Name Else '' End as Extra12,"
        cSql = cSql + "Case When IsNull(ExtraCharges13Apply,0) = 1 Then Extra13.Name Else '' End as Extra13,"
        cSql = cSql + "Case When IsNull(ExtraCharges14Apply,0) = 1 Then Extra14.Name Else '' End as Extra14,"
        cSql = cSql + "Case When IsNull(ExtraCharges15Apply,0) = 1 Then Extra15.Name Else '' End as Extra15,"
        cSql = cSql + "Case When IsNull(ExtraCharges1Apply,0) = 1 Then ExtraChargesAmount1 Else 0 End as ExtraAmount1,"
        cSql = cSql + "Case When IsNull(ExtraCharges2Apply,0) = 1 Then ExtraChargesAmount2 Else 0 End as ExtraAmount2,"
        cSql = cSql + "Case When IsNull(ExtraCharges3Apply,0) = 1 Then ExtraChargesAmount3 Else 0 End as ExtraAmount3,"
        cSql = cSql + "Case When IsNull(ExtraCharges4Apply,0) = 1 Then ExtraChargesAmount4 Else 0 End as ExtraAmount4,"
        cSql = cSql + "Case When IsNull(ExtraCharges5Apply,0) = 1 Then ExtraChargesAmount5 Else 0 End as ExtraAmount5,"
        cSql = cSql + "Case When IsNull(ExtraCharges6Apply,0) = 1 Then ExtraChargesAmount6 Else 0 End as ExtraAmount6,"
        cSql = cSql + "Case When IsNull(ExtraCharges7Apply,0) = 1 Then ExtraChargesAmount7 Else 0 End as ExtraAmount7,"
        cSql = cSql + "Case When IsNull(ExtraCharges8Apply,0) = 1 Then ExtraChargesAmount8 Else 0 End as ExtraAmount8,"
        cSql = cSql + "Case When IsNull(ExtraCharges9Apply,0) = 1 Then ExtraChargesAmount9 Else 0 End as ExtraAmount9,"
        cSql = cSql + "Case When IsNull(ExtraCharges10Apply,0) = 1 Then ExtraChargesAmount10 Else 0 End as ExtraAmount10,"
        cSql = cSql + "Case When IsNull(ExtraCharges11Apply,0) = 1 Then ExtraChargesAmount11 Else 0 End as ExtraAmount11,"
        cSql = cSql + "Case When IsNull(ExtraCharges12Apply,0) = 1 Then ExtraChargesAmount12 Else 0 End as ExtraAmount12,"
        cSql = cSql + "Case When IsNull(ExtraCharges13Apply,0) = 1 Then ExtraChargesAmount13 Else 0 End as ExtraAmount13,"
        cSql = cSql + "Case When IsNull(ExtraCharges14Apply,0) = 1 Then ExtraChargesAmount14 Else 0 End as ExtraAmount14,"
        cSql = cSql + "Case When IsNull(ExtraCharges15Apply,0) = 1 Then ExtraChargesAmount15 Else 0 End as ExtraAmount15 "
        cSql = cSql + "From tblUnitFile "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra1 On Extra1.Code = ExtraCharges1 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra2 On Extra2.Code = ExtraCharges2 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra3 On Extra3.Code = ExtraCharges3 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra4 On Extra4.Code = ExtraCharges4 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra5 On Extra5.Code = ExtraCharges5 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra6 On Extra6.Code = ExtraCharges6 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra7 On Extra7.Code = ExtraCharges7 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra8 On Extra8.Code = ExtraCharges8 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra9 On Extra9.Code = ExtraCharges9 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra10 On Extra10.Code = ExtraCharges10 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra11 On Extra11.Code = ExtraCharges11 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra12 On Extra12.Code = ExtraCharges12 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra13 On Extra13.Code = ExtraCharges13 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra14 On Extra14.Code = ExtraCharges14 "
        cSql = cSql + "Left Outer Join tblExtraCharges Extra15 On Extra15.Code = ExtraCharges15 "
        cSql = cSql + "Where IsNull(Cancel,0) = 0 "
        cSql = cSql + "And UnitNumber = '" & Label41.Text & "'"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            lblExtraCharges.Text = IIf(RemoveNull(dr!ExtraAmount1, 0) <> 0, dr!Extra1 + " = " + Format(dr!ExtraAmount1, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount2, 0) <> 0, dr!Extra2 + " = " + Format(dr!ExtraAmount2, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount3, 0) <> 0, dr!Extra3 + " = " + Format(dr!ExtraAmount3, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount4, 0) <> 0, dr!Extra4 + " = " + Format(dr!ExtraAmount4, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount5, 0) <> 0, dr!Extra5 + " = " + Format(dr!ExtraAmount5, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount6, 0) <> 0, dr!Extra6 + " = " + Format(dr!ExtraAmount6, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount7, 0) <> 0, dr!Extra7 + " = " + Format(dr!ExtraAmount7, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount8, 0) <> 0, dr!Extra8 + " = " + Format(dr!ExtraAmount8, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount9, 0) <> 0, dr!Extra9 + " = " + Format(dr!ExtraAmount9, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount10, 0) <> 0, dr!Extra10 + " = " + Format(dr!ExtraAmount10, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount11, 0) <> 0, dr!Extra11 + " = " + Format(dr!ExtraAmount11, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount12, 0) <> 0, dr!Extra12 + " = " + Format(dr!ExtraAmount12, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount13, 0) <> 0, dr!Extra13 + " = " + Format(dr!ExtraAmount13, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount14, 0) <> 0, dr!Extra14 + " = " + Format(dr!ExtraAmount14, "###,###,##0"), "")
            lblExtraCharges.Text = lblExtraCharges.Text + " " + IIf(RemoveNull(dr!ExtraAmount15, 0) <> 0, dr!Extra15 + " = " + Format(dr!ExtraAmount15, "###,###,##0"), "")
        End If

        db.Close()
        dr.Close()

        If fldApplyExtraLand.Value = 0 Then
            lblExtraLandCharges.Text = "Other Charges"
            txtExtraLandCharges.Value = 0
        Else
            txtExtraLandCharges.Value = Label46.Value
            lblExtraLandDescription.Value = "Extra Sq Feet : " + Format(Label47.Value, "###,###,##0")
        End If

        Dim cRemarks As String

        db = New dbOperations("Select Remarks From tblTransferPlot,tblUnitFile Where UnitTo = tblUnitFile.Code and tblUnitFile.UnitNumber = '" & Label41.Text & "' Order By TransferDate")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            cRemarks = "(" + RemoveNull(dr!Remarks, "") + "), "

            For Each Row In dr
                cRemarks = cRemarks + "(" + RemoveNull(dr!Remarks, "") + "), "
            Next

            fldStatus.Text = cRemarks
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub ReportFooter1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportFooter1.Format
        txtPerCash.Value = IIf(txtTotalReceipt.Value <> 0 And TextBox17.Value <> 0, (txtTotalReceipt.Value / TextBox17.Value) * 100, 0)
    End Sub

    Private Sub GroupHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupHeader1.Format

    End Sub

    Private Sub PageHeader1_Format(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PageHeader1.Format

    End Sub

    Private Sub rptCustomerStatement_ReportStart(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.ReportStart

    End Sub
End Class
