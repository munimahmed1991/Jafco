Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmProductStockReport
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmAccessoryStockReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCombo()
        Call FormCenter(Me)

        optProductLedger.Checked = True
        optProductLedger.Checked = True
        cmbReportFilter.SelectedIndex = 2
        cmbActiveDead.SelectedIndex = 2

        txtDateFrom.Value = DateFrom
        txtDateTo.Value = DateTo
        cmbProductLevel.SelectedIndex = 6
        cmbItemFilter.Text = "All"

        For Each a As Object In ToolStrip1.Items
            If TypeOf a Is ToolStripButton Then
                If a.Checked Then a.Checked = False
            End If
        Next
    End Sub

    Sub FillCombo()
        Dim ProductFrom As New BindCombo(cmbProductFrom, "Select ProductCode,ProductName from tblProductMaster Where tblProductMaster.ProductLevel = 'Detail' Order By ProductName", "ProductName", "ProductCode", True, True)
        Dim ProductTo As New BindCombo(cmbProductTo, "Select ProductCode,ProductName from tblProductMaster Where tblProductMaster.ProductLevel = 'Detail' Order By ProductName", "ProductName", "ProductCode", True, True)

        Dim ControlAccessory As New BindCombo(cmbGroupProduct, "Select ProductCode,ProductName From tblProductMaster Where tblProductMaster.Productlevel  = 'Control' Order By ProductName", "ProductName", "ProductCode", True, True)

        Dim Location As New BindCombo(cmbLocation, "Select LocationCode,LocationName From tblLocation Where LocationLevel = 'Detail'", "LocationName", "LocationCode", True, True)
    End Sub

    Private Sub cmdAccessorySelectionTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAccessorySelectionTo.Click
        cmbProductTo.SelectedValue = ShowList("Select tblProductMaster.ProductCode, tblProductMaster.ProductName, tblProductMaster.UoM, GroupName.ProductName As ControlProduct, tblProductMaster.ProductLevel From tblProductMaster As GroupName, tblProductMaster Where tblProductMaster.GroupProduct = GroupName.ProductCode And tblProductMaster.ProductLevel  = 'Detail' Order by tblProductMaster.ProductCode", "List of Product", 1, 0)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Call ProgressBar(5)
        Dim cSql As String = ""
        Dim fPreview As New frmPreview
        Dim rReport As Object = Nothing
        Dim cTitle As String = ""
        Dim cReportType As String = Nothing
        Dim cDigit As Double

        Call ProgressBar(10)

        Select Case cmbProductLevel.SelectedIndex
            Case 0
                cDigit = cProductLevel1
            Case 1
                cDigit = cProductLevel1 + cProductLevel2
            Case 2
                cDigit = cProductLevel1 + cProductLevel2 + cProductLevel3
            Case 3
                cDigit = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4
            Case 4
                cDigit = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5
            Case 5
                cDigit = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6
            Case 6
                cDigit = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7
        End Select

        If optProductLedger.Checked = True Then
            cReportType = "Ledger"
            rReport = New rptProductLedger
            cTitle = "PRODUCT LEDGER FROM :- " & Format(txtDateFrom.Value, "dd-MMM-yyyy") & " TO :- " & Format(txtDateTo.Value, "dd-MMM-yyyy")
            CType(rReport, rptProductLedger).fldCompany.Text = cCompanyName
            CType(rReport, rptProductLedger).fldTitle.Text = cTitle
            fPreview.rTitle = "Accessory Ledger"

            cSql = "Exec ProductStockReport '" & Format(txtDateFrom.Value, "MM/dd/yy") & "','" & Format(txtDateTo.Value, "MM/dd/yy") & "','" & IIf(cmbProductFrom.SelectedValue = "", "00000000000000", cmbProductFrom.SelectedValue) & "','" & IIf(cmbProductTo.SelectedValue = "", "zzzzzzzzzzzzzz", cmbProductTo.SelectedValue) & "','" & cmbGroupProduct.SelectedValue & "','" & cmbLocation.SelectedValue & "','Ledger','" & cmbActiveDead.Text & "','" & cmbReportFilter.Text & "'," & cDigit & ",'" & txtPrefix.Text & "','" & cmbItemFilter.Text & "'"
        ElseIf optAccessoryValuationReport.Checked = True Then
            cReportType = "StockValuation"
            rReport = New rptProductValuation
            cTitle = "PRODUCT STOCK VALUATION FROM :- " & Format(txtDateFrom.Value, "dd-MMM-yyyy") & " TO :- " & Format(txtDateTo.Value, "dd-MMM-yyyy")
            CType(rReport, rptProductValuation).fldCompany.Text = cCompanyName
            CType(rReport, rptProductValuation).fldTitle.Text = cTitle

            cSql = "Exec ProductStockReport '" & Format(txtDateFrom.Value, "MM/dd/yy") & "','" & Format(txtDateTo.Value, "MM/dd/yy") & "','" & IIf(cmbProductFrom.SelectedValue = "", "00000000000000", cmbProductFrom.SelectedValue) & "','" & IIf(cmbProductTo.SelectedValue = "", "zzzzzzzzzzzzzz", cmbProductTo.SelectedValue) & "','" & cmbGroupProduct.SelectedValue & "','" & cmbLocation.SelectedValue & "','StockValuation','" & cmbActiveDead.Text & "','" & cmbReportFilter.Text & "'," & cDigit & ",'" & txtPrefix.Text & "','" & cmbItemFilter.Text & "'"
        ElseIf optGridValuationReport.Checked = True Then
            cReportType = "ConsolidiatedStockReport"

            cSql = "Exec ProductStockReport '" & Format(txtDateFrom.Value, "MM/dd/yy") & "','" & Format(txtDateTo.Value, "MM/dd/yy") & "','" & IIf(cmbProductFrom.SelectedValue = "", "00000000000000", cmbProductFrom.SelectedValue) & "','" & IIf(cmbProductTo.SelectedValue = "", "zzzzzzzzzzzzzz", cmbProductTo.SelectedValue) & "','" & cmbGroupProduct.SelectedValue & "','" & cmbLocation.SelectedValue & "','StockValuation','" & cmbActiveDead.Text & "','" & cmbReportFilter.Text & "'," & cDigit & ",'" & txtPrefix.Text & "','" & cmbItemFilter.Text & "'"
        ElseIf optActivityReport.Checked = True Then
            cReportType = "Activity"

            cSql = "Exec ProductStockReport '" & Format(txtDateFrom.Value, "MM/dd/yy") & "','" & Format(txtDateTo.Value, "MM/dd/yy") & "','" & IIf(cmbProductFrom.SelectedValue = "", "00000000000000", cmbProductFrom.SelectedValue) & "','" & IIf(cmbProductTo.SelectedValue = "", "zzzzzzzzzzzzzz", cmbProductTo.SelectedValue) & "','" & cmbGroupProduct.SelectedValue & "','" & cmbLocation.SelectedValue & "','Activity','" & cmbActiveDead.Text & "','" & cmbReportFilter.Text & "'," & cDigit & ",'" & txtPrefix.Text & "','" & cmbItemFilter.Text & "'"
        End If

        Call ProgressBar(25)

        If optGridValuationReport.Checked = True Then
            ShowList(cSql, "Stock Valuation Report", 0, 0, "Opening,RecQty,IssQty,BalQty,Amount",,, "Report")
        ElseIf optActivityReport.Checked = True Then
            ShowList(cSql, "Activity Report", 0, 0, "Qty,Amount", "", "", "Report", "", "", "Yes", "", "Yes")
        Else
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)
            da.Fill(ds, "AccessoryReport")
            Dim rsReport As New DataView(ds.Tables("AccessoryReport"))

            Try
                If ds.Tables("AccessoryReport").Rows.Count = 0 Then
                    Call ProgressBar(100)
                    MsgBox("No Records To Show ")
                    Exit Sub
                End If

                Call ProgressBar(50)

                'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
                rReport.DataSource = rsReport
                fPreview.arv.Document = rReport.Document
                fPreview.Text = cTitle

                Call ProgressBar(75)

                Call ProgressBar(90)
                fPreview.MdiParent = frmMain

                fPreview.Show()
                rReport.Run(True)
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                Call ProgressBar(100)
                da.Dispose()
                ds.Dispose()
            End Try
        End If

    End Sub

    Private Sub optAccessoryLedger_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optProductLedger.Click
        optProductLedger.Checked = True
        optAccessoryValuationReport.Checked = False
        optGridValuationReport.Checked = False
    End Sub

    Private Sub optAccessoryValuationReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optAccessoryValuationReport.Click
        optProductLedger.Checked = False
        optAccessoryValuationReport.Checked = True
        optGridValuationReport.Checked = False
    End Sub

    Private Sub optGridValuationReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optGridValuationReport.Click
        optProductLedger.Checked = False
        optAccessoryValuationReport.Checked = False
        optGridValuationReport.Checked = True
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked
        For Each a As Object In ToolStrip1.Items
            If TypeOf a Is ToolStripButton Then
                If a.Checked Then a.Checked = False
            End If
        Next
    End Sub

    Private Sub cmdProductFrom_Click(sender As Object, e As EventArgs) Handles cmdProductFrom.Click
        cmbProductFrom.SelectedValue = ShowList("Select tblProductMaster.ProductCode,tblProductMaster.ProductName,tblProductMaster.UoM,GroupName.ProductName as ControlProduct,tblProductMaster.ProductLevel From tblProductMaster as GroupName,tblProductMaster Where tblProductMaster.GroupProduct = GroupName.ProductCode and tblProductMaster.ProductLevel  = 'Detail' Order by tblProductMaster.ProductCode", "List of Product", 1, 0)

        cmbProductTo.SelectedValue = cmbProductFrom.SelectedValue
    End Sub
End Class