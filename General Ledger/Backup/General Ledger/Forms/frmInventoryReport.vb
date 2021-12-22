Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmInventoryReport

    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim Block As New BindCombo(cmbBlock, "Select Code,Name From tblBlock", "Name", "Code", True, True)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim cSql As String

        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project")
            Exit Sub
        End If

        If optPriceList.Checked = True Then
            Call PriceList("No")
        End If

        If optInventorySummaryReport.Checked = True Then
            Call InventorySummary("No")
        End If

        If optBookingReport.Checked = True Then
            Call Booking("No")
        End If

        If optPriceChangeReport.Checked = True Then
            Call PriceChangeReport()
        End If
    End Sub

    Sub Booking(ByVal cPrint As String)
        cSql = "Exec PriceList '" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbBlock.SelectedValue & "','Booked','" & IIf(cmbReportType.Text = "Excel", "Grid", cmbReportType.Text) & "','Booking','" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "'"

        If cmbReportType.Text = "Report" Then
            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptPriceList


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "Booking")

            Call ProgressBar(50)

            rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("Booking")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "Booking Report Date From : " + Format(txtDateFrom.Value, "dd-MMM-yyyy") + " To : " + Format(txtDateTo.Value, "dd-MMM-yyyy")
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
                fPreview.arv.Document.Print(False, False)
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            ShowList(cSql, "Booking Report Date From : " + Format(txtDateFrom.Value, "dd-MMM-yyyy") + " To : " + Format(txtDateTo.Value, "dd-MMM-yyyy") + " PROJECT : " + cmbProject.Text, 0, 1, "CashAmount,LoanAmount,TotalExclExtraCharges,ExtraChargesAmount1,ExtraChargesAmount2,ExtraChargesAmount3,ExtraChargesAmount4,ExtraChargesAmount5,ExtraChargesAmount6,ExtraChargesAmount7,ExtraChargesAmount8,ExtraChargesAmount9,TotalExtraCharges,TotalInclExtraCharges", , "UnitTypeName,BlockName,Status", "Report")
        Else
            Call ExportExcel(cSql)
        End If
    End Sub

    Sub PriceList(ByVal cPrint As String)
        cSql = "Exec PriceList '" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbBlock.SelectedValue & "','" & cmbStatus.Text & "','" & IIf(cmbReportType.Text = "Excel", "Grid", cmbReportType.Text) & "','Price List'"

        If cmbReportType.Text = "Report" Then
            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptPriceList


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "PriceList")

            Call ProgressBar(50)

            rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("PriceList")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "INVENTORY PRICE LIST "
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
                fPreview.arv.Document.Print(False, False)
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            ShowList(cSql, "PRICE LIST FOR PROJECT : " + cmbProject.Text, 0, 1, "CashAmount,LoanAmount,TotalExclExtraCharges,ExtraChargesAmount1,ExtraChargesAmount2,ExtraChargesAmount3,ExtraChargesAmount4,ExtraChargesAmount5,ExtraChargesAmount6,ExtraChargesAmount7,ExtraChargesAmount8,ExtraChargesAmount9,TotalExtraCharges,TotalInclExtraCharges", , "UnitTypeName,BlockName,Status", "Report")
        Else
            Call ExportExcel(cSql)
        End If
    End Sub

    Sub InventorySummary(ByVal cPrint As String)
        cSql = "Exec PriceList '" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbBlock.SelectedValue & "','" & cmbStatus.Text & "','" & IIf(cmbReportType.Text = "Excel", "Grid", cmbReportType.Text) & "','Summary'"

        If cmbReportType.Text = "Report" Then
            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptInventorySummaryReport


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "InvSummaryReport")

            Call ProgressBar(50)

            rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("InvSummaryReport")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "INVENTORY SUMMARY & BOOKING ANALYSIS REPORT"
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
                fPreview.arv.Document.Print(False, False)
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            ShowList(cSql, "INVENTORY & SALES SUMMARY REPORTFOR PROJECT : " + cmbProject.Text, 0, 1, "Unit,CashAmount,LoanAmount,TotalExtraCharges,TotalAmount,Booked,ReserveCashAmount,ReserveLoanAmount,ReserveExtraCharges,ReserveDiscount,TotalReserveAmount", , "UnitTypeName,BlockName", "Report", "BlockName")
        Else
            Call ExportExcel(cSql)
        End If
    End Sub

    Sub PriceChangeReport()
        cSql = "Exec PriceChangeReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "'"

        ShowList(cSql, "PRICE CHANGE REPORT FOR PROJECT : " + cmbProject.Text, 0, 1, "OldCashAmount,NewCashAmount,ChangeCashAmount,OldLoanAmount,NewLoanAmount,ChangeLoanAmount,OldTotalRevenue,NewTotalRevenue,ChangeTotalRevenue", , "", "Report", "")
    End Sub

    Private Sub cmdUnitType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitType.Click
        cmbUnitType.SelectedValue = ShowList("Select Code,Name From tblUnitType Where Project = '" & cmbProject.SelectedValue & "'", "List of Unit Type", 1, 0)
    End Sub

    Private Sub frmPriceList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCombo()
        Call FormCenter(Me)

        cmbReportType.Text = "Report"
        cmbStatus.Text = "Both"

        txtDateFrom.Value = DateFrom
        txtDateTo.Value = DateTo

        txtDateFrom.Enabled = False
        txtDateTo.Enabled = False

        optPriceList.Checked = True
        optBookingReport.Checked = False
        optInventorySummaryReport.Checked = False
        optPriceChangeReport.Checked = False
    End Sub

    Private Sub optPriceList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPriceList.Click
        optInventorySummaryReport.Checked = False
        optPriceList.Checked = True
        optBookingReport.Checked = False
        optPriceChangeReport.Checked = False

        txtDateFrom.Enabled = False
        txtDateTo.Enabled = False
    End Sub

    Private Sub optInventorySummaryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optInventorySummaryReport.Click
        optPriceList.Checked = False
        optInventorySummaryReport.Checked = True
        optBookingReport.Checked = False
        optPriceChangeReport.Checked = False

        txtDateFrom.Enabled = False
        txtDateTo.Enabled = False
    End Sub

    Private Sub optBookingReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBookingReport.Click
        optPriceList.Checked = False
        optInventorySummaryReport.Checked = False
        optBookingReport.Checked = True
        optPriceChangeReport.Checked = False

        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbStatus.Text = "Booked"
    End Sub

    Private Sub optPriceChangeReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optPriceChangeReport.Click
        optPriceList.Checked = False
        optInventorySummaryReport.Checked = False
        optBookingReport.Checked = False
        optPriceChangeReport.Checked = True

        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If optPriceList.Checked = True Then
            Call PriceList("Yes")
        End If

        If optInventorySummaryReport.Checked = True Then
            Call InventorySummary("Yes")
        End If

        If optBookingReport.Checked = True Then
            Call Booking("Yes")
        End If
    End Sub
End Class