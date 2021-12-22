Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmReceiptReport

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmTokenMoneyReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillCombo()
        Call FormCenter(Me)

        txtDateFrom.Value = Today.Date
        txtDateTo.Value = Today.Date

        cmbLetterType.Text = "All"
    End Sub
    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdOk.Click
        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDateWiseReceiptReport


        Call ProgressBar(25)

        cSql = "Exec ReceiptReportEmpire '" & Format(txtDateFrom.Value, "MM/dd/yyyy") & "','" & Format(txtDateTo.Value, "MM/dd/yyyy") & "','" & cmbLetterType.Text & "'"

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "FabricSales")

        Call ProgressBar(50)

        'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("FabricSales")
        rReport.fldCompany.Text = cmbProject.Text
        rReport.fldTitle.Text = "RECEIPT REPORT FOR THE PERIOD FROM : " & Format(txtDateFrom.Value, "dd/MM/yyyy") & " TO : " & Format(txtDateTo.Value, "dd/MM/yyyy")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        fPreview.Show()

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub
End Class