Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmRecoveryReport
    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim Unit As New BindCombo(cmbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)
        Dim PaymentType As New BindCombo(cmbPaymentType, "Select Code,Name From tblPaymentType", "Name", "Code", True, True)
        Dim Block As New BindCombo(cmbBlock, "Select Code,Name From tblBlock Order By Name", "Name", "Code", True, True)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Please  Select Project")
            Exit Sub
        End If

      

        Dim cDateFrom As String
        Dim cDateTo As String

        If optMonthWiseRecovery.Checked = True Then
            cDateFrom = CStr(cmbMonth.SelectedIndex) + "/01/" + CStr(txtYear.Value)

            txtDateFrom.Value = CDate(cDateFrom)

            If cmbMonth.SelectedIndex = 12 Then
                cDateTo = "01/01/" + CStr(txtYear.Value + 1)
            Else
                cDateTo = CStr(cmbMonth.SelectedIndex + 1) + "/01/" + CStr(txtYear.Value)
            End If

            txtDateTo.Value = DateAdd(DateInterval.Day, -1, CDate(cDateTo))

            Call MonthWiseRecovery("No")
        End If

        If optRecoveryReportProvisional.Checked = True Then
            Call RecoveryReportProvisional("No")
        End If

        If optRecoveryReport.Checked = True Then
            Call RecoveryReport("No")
        End If

        If optRecoveryReportTillDate.Checked = True Then
            Call RecoveryReportTillDate("No")
        End If

        If optRecoveryReportCancel.Checked = True Then
            Call RecoveryReportCancel("No")
        End If

        If optServiceRecoveryReport.Checked = True Then
            Call ServiceRecoveryReport("No")
        End If

        If optAgingAnalysis.Checked = True Then
            Call AgingAnalysis("No")
        End If

        If optCashRecoveryReport.Checked = True Then
            Call CashRecoveryReport("No")
        End If

        If optLoanRecoveryReport.Checked = True Then
            Call LoanRecoveryReport("No")
        End If

        If optExtraChargesReport.Checked = True Then
            Call ExtraRecoveryReport("No")
        End If

        If optCustomerStatement.Checked = True Then
            Call CustomerStatement("No")
        End If

        If OptReceiptRecoveryReport.Checked = True Then
            Call ReceiptRecovery("No")
        End If

        If optRecoveryForecast.Checked = True Then
            Call RecoveryForecast("No")
        End If
    End Sub

    Sub RecoveryForecast(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptRecoveryReportForecast


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            If chkIncludeRecovery.Checked = True Then
                rReport.fldReceiveAmoun.Visible = True
                rReport.fldTypeReceiveAmount.Visible = True
                rReport.fldGrandReceiveAmount.Visible = True

                rReport.TextBox2.Visible = False
            Else
                rReport.fldReceiveAmoun.Visible = False
                rReport.fldTypeReceiveAmount.Visible = False
                rReport.fldGrandReceiveAmount.Visible = False

                rReport.TextBox2.Visible = True
            End If

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "CashAmount,LoanAmount,ExtraCharges,Discount,NetSalesValue,DueTillDate,AmountReceivedCash,AmountReceivedLoan,BalanceTillDate,DueforthePeriod,ReceivedForThePeriod,BalanceForThePeriod", , "UnitTypeName,UnitNumber", "Report")
        Else
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Call ExportExcel(cSql)
        End If
    End Sub


    Sub CashRecoveryReport(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec [CashCharges] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptServiceRecoveryReport


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec [CashCharges] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "CASH RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "TotalCharges,DueTillDate,AmountReceived,Balance", , "UnitNumber", "Report")
        End If
    End Sub

    Sub ExtraRecoveryReport(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec ExtraCharges '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptServiceRecoveryReport


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.Label10.Visible = False
            rReport.TextBox7.Visible = False
            rReport.fldTitle.Text = "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec ExtraCharges '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "EXTRA CHARGES RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "TotalCharges,DueTillDate,AmountReceived,Balance", , "UnitNumber", "Report")
        End If
    End Sub

    Sub LoanRecoveryReport(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec [LoanCharges] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptServiceRecoveryReport


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec [LoanCharges] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "LOAN RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "TotalCharges,DueTillDate,AmountReceived,Balance", , "UnitNumber", "Report")
        End If
    End Sub

    Sub MonthWiseRecovery(ByVal cPrint As String)
        Dim cCurrentMonth As DateTime

        Dim cDate1 As DateTime
        Dim cDate2 As DateTime
        Dim cDate3 As DateTime
        Dim cDate4 As DateTime
        Dim cDate5 As DateTime
        Dim cDate6 As DateTime
        Dim cDate7 As DateTime
        Dim cDate8 As DateTime
        Dim cDate9 As DateTime
        Dim cDate10 As DateTime

        cCurrentMonth = txtDateTo.Value

        cDate10 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -9, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -9, cCurrentMonth))))
        cDate9 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -8, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -8, cCurrentMonth))))
        cDate8 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -7, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -7, cCurrentMonth))))
        cDate7 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -6, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -6, cCurrentMonth))))
        cDate6 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -5, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -5, cCurrentMonth))))
        cDate5 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -4, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -4, cCurrentMonth))))
        cDate4 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -3, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -3, cCurrentMonth))))
        cDate3 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -2, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -2, cCurrentMonth))))
        cDate2 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -1, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -1, cCurrentMonth))))
        cDate1 = Trim(CStr(DatePart(DateInterval.Month, DateAdd(DateInterval.Month, -0, cCurrentMonth)))) + "/01/" + Trim(CStr(DatePart(DateInterval.Year, DateAdd(DateInterval.Month, -0, cCurrentMonth))))

        cHeading1 = MonthName(DatePart(DateInterval.Month, cCurrentMonth)) + "-" + Str(DatePart(DateInterval.Year, cCurrentMonth))
        cHeading2 = MonthName(DatePart(DateInterval.Month, cDate2)) + "-" + Str(DatePart(DateInterval.Year, cDate2))
        cHeading3 = MonthName(DatePart(DateInterval.Month, cDate3)) + "-" + Str(DatePart(DateInterval.Year, cDate3))
        cHeading4 = MonthName(DatePart(DateInterval.Month, cDate4)) + "-" + Str(DatePart(DateInterval.Year, cDate4))
        cHeading5 = MonthName(DatePart(DateInterval.Month, cDate5)) + "-" + Str(DatePart(DateInterval.Year, cDate5))
        cHeading6 = MonthName(DatePart(DateInterval.Month, cDate6)) + "-" + Str(DatePart(DateInterval.Year, cDate6))
        cHeading7 = MonthName(DatePart(DateInterval.Month, cDate7)) + "-" + Str(DatePart(DateInterval.Year, cDate7))
        cHeading8 = MonthName(DatePart(DateInterval.Month, cDate8)) + "-" + Str(DatePart(DateInterval.Year, cDate8))
        cHeading9 = MonthName(DatePart(DateInterval.Month, cDate9)) + "-" + Str(DatePart(DateInterval.Year, cDate9))
        cHeading10 = MonthName(DatePart(DateInterval.Month, cDate10)) + "-" + Str(DatePart(DateInterval.Year, cDate10))

        If cmbMonth.Text = "" Then
            MsgBox("Please Select Month")
            Exit Sub
        End If

        cSql = "Exec [MonthWiseRecovery] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & Format(cDate1, "MM/dd/yyyy") & "','" & Format(cDate2, "MM/dd/yyyy") & "','" & Format(cDate3, "MM/dd/yyyy") & "','" & Format(cDate4, "MM/dd/yyyy") & "','" & Format(cDate5, "MM/dd/yyyy") & "','" & Format(cDate6, "MM/dd/yyyy") & "','" & Format(cDate7, "MM/dd/yyyy") & "','" & Format(cDate8, "MM/dd/yyyy") & "','" & Format(cDate9, "MM/dd/yyyy") & "','" & Format(cDate10, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnit.SelectedValue & "','" & cmbUnitType.SelectedValue & "'"

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptMonthWiseRecovery


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "FabricSales")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("FabricSales")
        'rReport.fldCompany.Text = cmbProject.Text
        CType(rReport, rptMonthWiseRecovery).fldCompany.Text = cmbProject.Text
        CType(rReport, rptMonthWiseRecovery).fldTitle.Text = "MONTH WISE RECOVERY BREAKUP FOR THE MONTH OF " + cmbMonth.Text + "-" + Trim(CStr(txtYear.Value))
        CType(rReport, rptMonthWiseRecovery).lblHeading10.Text = cHeading10
        CType(rReport, rptMonthWiseRecovery).lblHeading9.Text = cHeading9
        CType(rReport, rptMonthWiseRecovery).lblHeading8.Text = cHeading8
        CType(rReport, rptMonthWiseRecovery).lblHeading7.Text = cHeading7
        CType(rReport, rptMonthWiseRecovery).lblHeading6.Text = cHeading6
        CType(rReport, rptMonthWiseRecovery).lblHeading5.Text = cHeading5
        CType(rReport, rptMonthWiseRecovery).lblHeading4.Text = cHeading4
        CType(rReport, rptMonthWiseRecovery).lblHeading3.Text = cHeading3
        CType(rReport, rptMonthWiseRecovery).lblHeading2.Text = cHeading2
        CType(rReport, rptMonthWiseRecovery).lblHeading1.Text = cHeading1

        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
           fPreview.arv.Document.Printer.Print()
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub
    Sub CustomerStatementSpecific(ByVal cPrint As String, ByVal Hyperlink As String)

        Dim DB As dbOperations
        Dim DR1 As SqlDataReader

        Dim cUnitCode As String

        cSql = "Select Code from tblUnitFile Where UnitNumber = '" & Hyperlink & "'"
        DB = New dbOperations(cSql)
        DR1 = DB.dbSelectQuery

        If DR1.HasRows Then
            DR1.Read()

            cUnitCode = RemoveNull(DR1!Code, "")
        End If

        DB.Close()
        DR1.Close()

        cSql = "Exec [CustomerStatement] '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cUnitCode & "','All'," & Val(chkIncludePenalty.Checked) & ",'" & cmbPaymentType.SelectedValue & "'"

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptCustomerStatement


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "FabricSales")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("FabricSales")
        'rReport.fldCompany.Text = cmbProject.Text
        rReport.fldTitle.Text = "CUSTOMER STATEMENT UPTO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
           fPreview.arv.Document.Printer.Print()
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub CustomerStatement(ByVal cPrint As String)

        cSql = "Exec [CustomerStatement] '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','All'," & Val(chkIncludePenalty.Checked) & ",'" & cmbPaymentType.SelectedValue & "'"

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptCustomerStatement


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "FabricSales")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("FabricSales")
        'rReport.fldCompany.Text = cmbProject.Text
        rReport.fldTitle.Text = "CUSTOMER STATEMENT UPTO : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & "-" & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))

        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
           fPreview.arv.Document.Printer.Print()
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub ReceiptRecovery(ByVal cPrint As String)
        cSql = "Exec [ReceiptReport] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','" & cmbPaymentType.SelectedValue & "'"

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptReceiptReportEmpire


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "FabricSales")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("FabricSales")
        rReport.fldCompany.Text = cmbProject.Text
        rReport.fldTitle.Text = "RECEIPT STATEMENT UPTO : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & "-" & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
           fPreview.arv.Document.Printer.Print()
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub


    Sub RecoveryReportCancel(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec RecoveryReportCancel '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptRecoveryReport


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "RECOVERY REPORT Cancel FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "CashAmount,LoanAmount,ExtraCharges,Discount,NetSalesValue,DueTillDate,AmountReceivedCash,AmountReceivedLoan,BalanceTillDate,DueforthePeriod,ReceivedForThePeriod,BalanceForThePeriod", , "UnitTypeName,UnitNumber", "Report")
        Else
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Call ExportExcel(cSql)
        End If
    End Sub

    Sub RecoveryReportTillDate(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','ReportByMonth','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptRecoveryReportTillDateEmpire

            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "LAST RECEIVED BEFORE " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','ReportByMonth','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "CashAmount,LoanAmount,ExtraCharges,Discount,NetSalesValue,DueTillDate,AmountReceivedCash,AmountReceivedLoan,BalanceTillDate,DueforthePeriod,ReceivedForThePeriod,BalanceForThePeriod", , "UnitTypeName,UnitNumber", "Report")
        Else
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','ReportByMonth','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Call ExportExcel(cSql)
        End If

    End Sub

    Sub RecoveryReport(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptRecoveryReportEmpire


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "CashAmount,LoanAmount,ExtraCharges,Discount,NetSalesValue,DueTillDate,AmountReceivedCash,AmountReceivedLoan,BalanceTillDate,DueforthePeriod,ReceivedForThePeriod,BalanceForThePeriod", , "UnitTypeName,UnitNumber", "Report")
        Else
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Call ExportExcel(cSql)
        End If
    End Sub

    Sub RecoveryReportProvisional(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec RecoveryReportProvisional '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptRecoveryReportProvisionalEmpire


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "RECOVERY REPORT PROVISIONAL FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "CashAmount,LoanAmount,ExtraCharges,Discount,NetSalesValue,DueTillDate,AmountReceivedCash,AmountReceivedLoan,BalanceTillDate,DueforthePeriod,ReceivedForThePeriod,BalanceForThePeriod", , "UnitTypeName,UnitNumber", "Report")
        Else
            cSql = "Exec RecoveryReport '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Call ExportExcel(cSql)
        End If
    End Sub

    Sub ServiceRecoveryReport(ByVal cPrint As String)
        If cmbReportType.Text = "Report" Then
            cSql = "Exec [UtilitiesCharges] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Report','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptServiceRecoveryReport


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If

            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec [UtilitiesCharges] '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','" & cmbStatus.Text & "'," & IIf(cmbPaymentType.SelectedValue = "", Val(chkIncludePenalty.Checked), 1) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

            ShowList(cSql, "UTILITIES RECOVERY REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "TotalCharges,DueTillDate,AmountReceived,Balance,OfficialReceived,UnOfficialReceived", , "UnitNumber", "Report")
        End If
    End Sub

    Sub AgingAnalysis(ByVal cPrint As String)
        cSql = "Exec AgingReport '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','" & IIf(cmbReportType.Text = "Excel", "Grid", cmbReportType.Text) & "','Aging'," & Val(chkIncludePenalty.Checked) & ",'" & cmbPaymentType.SelectedValue & "','" & cmbCustomerType.Text & "'"

        If cmbReportType.Text = "Report" Then
            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptAgingAnalysis


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "AGING ANALYSIS REPORT FOR THE PERIOD UPTO : " & Format(txtDateTo.Value, "dd/MM/yyyy") + IIf(cmbPaymentType.SelectedValue = "", "", UCase(cmbPaymentType.Text))
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            rReport.Run(True)

            If cPrint = "No" Then
                fPreview.Show()
            Else
               fPreview.arv.Document.Printer.Print()
            End If


            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        ElseIf cmbReportType.Text = "Grid" Then
            cSql = "Exec AgingReport '" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & cmbUnitType.SelectedValue & "','" & cmbUnit.SelectedValue & "','Grid','Aging'"

            ShowList(cSql, "AGING ANALYSIS REPORT FOR THE PERIOD UPTO : " & Format(txtDateTo.Value, "dd/MM/yyyy") & " PROJECT : " + cmbProject.Text, 0, 1, "Days30,Days60,Days90,After90Days,Amount", , "UnitTypeName,Total", "Report")
        Else
            Call ExportExcel(cSql)
        End If
    End Sub

    Private Sub cmdUnitType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitType.Click
        cmbUnitType.SelectedValue = ShowList("Select Code,Name From tblUnitType Where Project = '" & cmbProject.SelectedValue & "'", "List of Unit Type", 1, 0)
    End Sub

    Private Sub frmPriceList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCombo()
        Call FormCenter(Me)

        txtDateFrom.Value = DateFrom
        txtDateTo.Value = DateTo

        cmbReportType.Text = "Report"
        cmbStatus.Text = "Both"
        cmbStatus.Text = "All"
        cmbCustomerType.Text = "Both"
        cmbProject.SelectedValue = "0001"

        optAgingAnalysis.Checked = False
        optRecoveryReport.Checked = True
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportProvisional.Checked = False

        For Each a As Object In ToolStrip1.Items
            If TypeOf a Is ToolStripButton Then
                If a.Checked Then a.Checked = False
            End If
        Next
    End Sub

    Private Sub optPriceList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRecoveryReport.Click
        optAgingAnalysis.Checked = False
        optRecoveryReport.Checked = True
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        optRecoveryReportProvisional.Checked = False
        optRecoveryReportTillDate.Checked = False

        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub optInventorySummaryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAgingAnalysis.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = True
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        optRecoveryReportProvisional.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub cmdUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnit.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project First in Search")
            Exit Sub
        End If

        Dim cSql As String
        Dim cProject As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * from tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()
        Else
            MsgBox("No Entries Found for the Select Project in Project File")
            Exit Sub
        End If

        cSql = "Select tblUnitFile.Code,tblProjectFile.Name as Project,tblUnitFile.UnitNumber,tblBlock.Name as Block,tblUnitType.Name as UnitType,1 as Unit,tblUnitFile.CashAmount,tblUnitFile.LoanAmount,tblUnitFile.TotalRevenue, "
        cSql = cSql + "IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as ExtraCharges,"
        cSql = cSql + "tblUnitFile.TotalRevenue + IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as GrossTotal"

        If RemoveNull(dr!ExtraCharges1, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges1Apply,0) = 1 Then Charges1.Name Else '' End as ExtraCharges1,IsNull(tblUnitFile.ExtraChargesAmount1,0) as ExtraChargesAmount1 "
        End If

        If RemoveNull(dr!ExtraCharges2, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges2Apply,0) = 1 Then Charges2.Name Else '' End as ExtraCharges2,IsNull(tblUnitFile.ExtraChargesAmount2,0) as ExtraChargesAmount2 "
        End If

        If RemoveNull(dr!ExtraCharges3, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges3Apply,0) = 1 Then Charges3.Name Else '' End as ExtraCharges3,IsNull(tblUnitFile.ExtraChargesAmount3,0) as ExtraChargesAmount3 "
        End If

        If RemoveNull(dr!ExtraCharges4, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges4Apply,0) = 1 Then Charges4.Name Else '' End as ExtraCharges4,IsNull(tblUnitFile.ExtraChargesAmount4,0) as ExtraChargesAmount4 "
        End If

        If RemoveNull(dr!ExtraCharges5, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges5Apply,0) = 1 Then Charges5.Name Else '' End as ExtraCharges5,IsNull(tblUnitFile.ExtraChargesAmount5,0) as ExtraChargesAmount5 "
        End If

        If RemoveNull(dr!ExtraCharges6, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges6Apply,0) = 1 Then Charges6.Name Else '' End as ExtraCharges6,IsNull(tblUnitFile.ExtraChargesAmount6,0) as ExtraChargesAmount6 "
        End If

        If RemoveNull(dr!ExtraCharges7, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges7Apply,0) = 1 Then Charges7.Name Else '' End as ExtraCharges7,IsNull(tblUnitFile.ExtraChargesAmount7,0) as ExtraChargesAmount7 "
        End If

        If RemoveNull(dr!ExtraCharges8, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges8Apply,0) = 1 Then Charges8.Name Else '' End as ExtraCharges8,IsNull(tblUnitFile.ExtraChargesAmount8,0) as ExtraChargesAmount8 "
        End If

        If RemoveNull(dr!ExtraCharges9, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges9Apply,0) = 1 Then Charges9.Name Else '' End as ExtraCharges9,IsNull(tblUnitFile.ExtraChargesAmount9,0) as ExtraChargesAmount9 "
        End If

        If RemoveNull(dr!ExtraCharges10, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges10Apply,0) = 1 Then Charges10.Name Else '' End as ExtraCharges10,IsNull(tblUnitFile.ExtraChargesAmount10,0) as ExtraChargesAmount10 "
        End If

        If RemoveNull(dr!ExtraCharges11, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges11Apply,0) = 1 Then Charges11.Name Else '' End as ExtraCharges11,IsNull(tblUnitFile.ExtraChargesAmount11,0) as ExtraChargesAmount11 "
        End If

        If RemoveNull(dr!ExtraCharges12, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges12Apply,0) = 1 Then Charges12.Name Else '' End as ExtraCharges12,IsNull(tblUnitFile.ExtraChargesAmount12,0) as ExtraChargesAmount12 "
        End If

        If RemoveNull(dr!ExtraCharges13, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges13Apply,0) = 1 Then Charges13.Name Else '' End as ExtraCharges13,IsNull(tblUnitFile.ExtraChargesAmount13,0) as ExtraChargesAmount13 "
        End If

        If RemoveNull(dr!ExtraCharges14, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges14Apply,0) = 1 Then Charges14.Name Else '' End as ExtraCharges14,IsNull(tblUnitFile.ExtraChargesAmount14,0) as ExtraChargesAmount14  "
        End If

        If RemoveNull(dr!ExtraCharges15, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges15Apply,0) = 1 Then Charges15.Name Else '' End as ExtraCharges15,IsNull(tblUnitFile.ExtraChargesAmount15,0) as ExtraChargesAmount15 "
        End If

        cSql = cSql + "From tblUnitFile "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges1 On Charges1.Code = tblUnitFile.ExtraCharges1 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges2 On Charges2.Code = tblUnitFile.ExtraCharges2 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges3 On Charges3.Code = tblUnitFile.ExtraCharges3 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges4 On Charges4.Code = tblUnitFile.ExtraCharges4 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges5 On Charges5.Code = tblUnitFile.ExtraCharges5 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges6 On Charges6.Code = tblUnitFile.ExtraCharges6 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges7 On Charges7.Code = tblUnitFile.ExtraCharges7 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges8 On Charges8.Code = tblUnitFile.ExtraCharges8 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges9 On Charges9.Code = tblUnitFile.ExtraCharges9 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges10 On Charges10.Code = tblUnitFile.ExtraCharges10 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges11 On Charges11.Code = tblUnitFile.ExtraCharges11 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges12 On Charges12.Code = tblUnitFile.ExtraCharges12 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges13 On Charges13.Code = tblUnitFile.ExtraCharges13 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges14 On Charges14.Code = tblUnitFile.ExtraCharges14 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges15 On Charges15.Code = tblUnitFile.ExtraCharges15 "
        cSql = cSql + ",tblProjectFile,tblUnitType,tblBlock "
        cSql = cSql + "Where tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And tblUnitFile.Project = tblProjectFile.Code "
        cSql = cSql + "And tblUnitFile.Block = tblBlock.Code "
        cSql = cSql + "And tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And tblUnitfile.Code In (Select Unit From tblReservationMst Where IsNull(cancel,0) = 0 ) "
        cSql = cSql + "And IsNull(Cancel,0) = 0 "
        cSql = cSql + "Order By tblUnitFile.Code "

        cmbUnit.SelectedValue = ShowList(cSql, "List of Units", 1, 0)
    End Sub

    Private Sub optCustomerStatement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCustomerStatement.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = True
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub cmbUnitTypeClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnitTypeClear.Click
        cmbUnitType.SelectedValue = ""
    End Sub

    Private Sub cmbUnitNoClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnitNoClear.Click
        cmbUnit.SelectedValue = ""
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbMonth.SelectedIndexChanged

    End Sub

    Private Sub optMonthWiseRecovery_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optMonthWiseRecovery.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = True
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = False
        txtDateTo.Enabled = False

        cmbMonth.Enabled = True
        txtYear.Enabled = True
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project")
            Exit Sub
        End If

        Dim cDateFrom As String
        Dim cDateTo As String

        If optMonthWiseRecovery.Checked = True Then
            cDateFrom = CStr(cmbMonth.SelectedIndex) + "/01/" + CStr(txtYear.Value)

            txtDateFrom.Value = CDate(cDateFrom)

            If cmbMonth.SelectedIndex = 12 Then
                cDateTo = "01/01/" + CStr(txtYear.Value + 1)
            Else
                cDateTo = CStr(cmbMonth.SelectedIndex + 1) + "/01/" + CStr(txtYear.Value)
            End If

            txtDateTo.Value = DateAdd(DateInterval.Day, -1, CDate(cDateTo))

            Call MonthWiseRecovery("Yes")
        End If

        If optRecoveryReport.Checked = True Then
            Call RecoveryReport("Yes")
        End If

        If optAgingAnalysis.Checked = True Then
            Call AgingAnalysis("Yes")
        End If

        If optCustomerStatement.Checked = True Then
            Call CustomerStatement("Yes")
        End If
    End Sub

    Private Sub optServiceRecoveryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optServiceRecoveryReport.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = True
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub optCashRecoveryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optCashRecoveryReport.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = True
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub optLoanRecoveryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optLoanRecoveryReport.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = True
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub optExtraChargesReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optExtraChargesReport.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = True
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        For Each a As Object In ToolStrip1.Items
            If TypeOf a Is ToolStripButton Then
                If a.Checked Then a.Checked = False
            End If
        Next
    End Sub

    Private Sub optRecoveryReportCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRecoveryReportCancel.Click
        optAgingAnalysis.Checked = False
        optRecoveryReport.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = True
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportTillDate.Checked = False
        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub OptReceiptRecoveryReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OptReceiptRecoveryReport.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = True
        optRecoveryReportTillDate.Checked = False


        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub optRecoveryReportProvisional_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRecoveryReportProvisional.Click
        optRecoveryReport.Checked = False
        optAgingAnalysis.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        OptReceiptRecoveryReport.Checked = False
        optRecoveryReportProvisional.Checked = True
        optRecoveryReportTillDate.Checked = False


        txtDateFrom.Enabled = True
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False
    End Sub

    Private Sub optRecoveryReportTillDate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optRecoveryReportTillDate.Click

        optAgingAnalysis.Checked = False
        optRecoveryReport.Checked = False
        optCustomerStatement.Checked = False
        optMonthWiseRecovery.Checked = False
        optServiceRecoveryReport.Checked = False
        optCashRecoveryReport.Checked = False
        optLoanRecoveryReport.Checked = False
        optExtraChargesReport.Checked = False
        optRecoveryReportCancel.Checked = False
        optRecoveryReportProvisional.Checked = False
        optRecoveryReportTillDate.Checked = True

        txtDateFrom.Enabled = False
        txtDateTo.Enabled = True

        cmbMonth.Enabled = False
        txtYear.Enabled = False

    End Sub
End Class