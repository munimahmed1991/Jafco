<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptProductLedger
    Inherits GrapeCity.ActiveReports.SectionReport

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents PageHeader1 As GrapeCity.ActiveReports.SectionReportModel.PageHeader
    Private WithEvents Detail1 As GrapeCity.ActiveReports.SectionReportModel.Detail
    Private WithEvents PageFooter1 As GrapeCity.ActiveReports.SectionReportModel.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptProductLedger))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.fldCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.fldTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.fldBalQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.fldRate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.fldAmount = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldBalQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldRate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldCompany, Me.fldTitle})
        Me.PageHeader1.Height = 1.041667!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'fldCompany
        '
        Me.fldCompany.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCompany.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCompany.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Border.RightColor = System.Drawing.Color.Black
        Me.fldCompany.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Border.TopColor = System.Drawing.Color.Black
        Me.fldCompany.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Height = 0.4375!
        Me.fldCompany.Left = 0.1875!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 18pt; vertical" &
    "-align: middle; "
        Me.fldCompany.Text = "Company"
        Me.fldCompany.Top = 0.3125!
        Me.fldCompany.Width = 10.375!
        '
        'fldTitle
        '
        Me.fldTitle.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTitle.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTitle.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Border.RightColor = System.Drawing.Color.Black
        Me.fldTitle.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Border.TopColor = System.Drawing.Color.Black
        Me.fldTitle.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Height = 0.25!
        Me.fldTitle.Left = 0.1875!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; verti" &
    "cal-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.75!
        Me.fldTitle.Width = 10.375!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line24, Me.TextBox9, Me.TextBox2, Me.TextBox3, Me.TextBox5, Me.TextBox8, Me.TextBox10, Me.fldBalQty, Me.fldRate, Me.fldAmount, Me.TextBox13})
        Me.Detail1.Height = 0.2604167!
        Me.Detail1.Name = "Detail1"
        '
        'Line24
        '
        Me.Line24.Border.BottomColor = System.Drawing.Color.Black
        Me.Line24.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.LeftColor = System.Drawing.Color.Black
        Me.Line24.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.RightColor = System.Drawing.Color.Black
        Me.Line24.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.TopColor = System.Drawing.Color.Black
        Me.Line24.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line24.Height = 0!
        Me.Line24.Left = 0.1875!
        Me.Line24.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0.25!
        Me.Line24.Width = 10.4375!
        Me.Line24.X1 = 0.1875!
        Me.Line24.X2 = 10.625!
        Me.Line24.Y1 = 0.25!
        Me.Line24.Y2 = 0.25!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox9.DataField = "RefNo"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 0.1875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-size: 8.25pt; "
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0!
        Me.TextBox9.Width = 1.0625!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "RefDate"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 1.25!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "font-size: 8.25pt; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 0.75!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "Description"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 2.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "font-size: 8.25pt; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 3.4375!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox5.DataField = "LocationName"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 5.4375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "font-size: 8.25pt; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 1.375!
        '
        'TextBox8
        '
        Me.TextBox8.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox8.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox8.DataField = "RecQty"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 6.8125!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "text-align: right; font-size: 8.25pt; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 0.6875!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox10.DataField = "IssQty"
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 7.5!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "text-align: right; font-size: 8.25pt; "
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0!
        Me.TextBox10.Width = 0.6875!
        '
        'fldBalQty
        '
        Me.fldBalQty.Border.BottomColor = System.Drawing.Color.Black
        Me.fldBalQty.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldBalQty.Border.LeftColor = System.Drawing.Color.Black
        Me.fldBalQty.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldBalQty.Border.RightColor = System.Drawing.Color.Black
        Me.fldBalQty.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldBalQty.Border.TopColor = System.Drawing.Color.Black
        Me.fldBalQty.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldBalQty.DataField = "BalQty"
        Me.fldBalQty.Height = 0.1875!
        Me.fldBalQty.Left = 8.1875!
        Me.fldBalQty.Name = "fldBalQty"
        Me.fldBalQty.OutputFormat = resources.GetString("fldBalQty.OutputFormat")
        Me.fldBalQty.Style = "text-align: right; font-size: 8.25pt; "
        Me.fldBalQty.SummaryGroup = "GroupHeader1"
        Me.fldBalQty.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.fldBalQty.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.fldBalQty.Text = Nothing
        Me.fldBalQty.Top = 0!
        Me.fldBalQty.Width = 0.6875!
        '
        'fldRate
        '
        Me.fldRate.Border.BottomColor = System.Drawing.Color.Black
        Me.fldRate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRate.Border.LeftColor = System.Drawing.Color.Black
        Me.fldRate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRate.Border.RightColor = System.Drawing.Color.Black
        Me.fldRate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRate.Border.TopColor = System.Drawing.Color.Black
        Me.fldRate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRate.Height = 0.1875!
        Me.fldRate.Left = 8.875!
        Me.fldRate.Name = "fldRate"
        Me.fldRate.OutputFormat = resources.GetString("fldRate.OutputFormat")
        Me.fldRate.Style = "text-align: right; font-size: 8.25pt; "
        Me.fldRate.Text = Nothing
        Me.fldRate.Top = 0!
        Me.fldRate.Width = 0.5!
        '
        'fldAmount
        '
        Me.fldAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.fldAmount.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.fldAmount.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmount.Border.RightColor = System.Drawing.Color.Black
        Me.fldAmount.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmount.Border.TopColor = System.Drawing.Color.Black
        Me.fldAmount.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmount.DataField = "Amount"
        Me.fldAmount.Height = 0.1875!
        Me.fldAmount.Left = 9.875!
        Me.fldAmount.Name = "fldAmount"
        Me.fldAmount.OutputFormat = resources.GetString("fldAmount.OutputFormat")
        Me.fldAmount.Style = "text-align: right; font-size: 8.25pt; "
        Me.fldAmount.SummaryGroup = "GroupHeader1"
        Me.fldAmount.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.fldAmount.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.fldAmount.Text = Nothing
        Me.fldAmount.Top = 0!
        Me.fldAmount.Width = 0.75!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox13.DataField = "ActualRate"
        Me.TextBox13.Height = 0.1875!
        Me.TextBox13.Left = 9.375!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "text-align: right; font-size: 8.25pt; "
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0!
        Me.TextBox13.Width = 0.5!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape2, Me.Line3, Me.Label5, Me.TextBox1, Me.Label1, Me.Label2, Me.Line1, Me.Label3, Me.Line4, Me.Label6, Me.Line7, Me.Label9, Me.Line8, Me.Line9, Me.Label10, Me.Label11, Me.Line10, Me.Label12, Me.Line11, Me.Label13, Me.Line14, Me.Label15, Me.TextBox15})
        Me.GroupHeader1.DataField = "ProductCode"
        Me.GroupHeader1.Height = 0.9583333!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.4375!
        Me.Line3.Left = 1.25!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.5!
        Me.Line3.Width = 0!
        Me.Line3.X1 = 1.25!
        Me.Line3.X2 = 1.25!
        Me.Line3.Y1 = 0.5!
        Me.Line3.Y2 = 0.9375!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.1875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "text-decoration: underline; text-align: left; font-weight: bold; font-size: 9.75p" &
    "t; "
        Me.Label5.Text = "Product"
        Me.Label5.Top = 0.1875!
        Me.Label5.Width = 1.375!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "ProductName"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 2.9375!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "text-decoration: underline; font-weight: bold; font-size: 9.75pt; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.1875!
        Me.TextBox1.Width = 3.5!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.1875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label1.Text = "Ref No."
        Me.Label1.Top = 0.625!
        Me.Label1.Width = 1.0625!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.25!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label2.Text = "Date"
        Me.Label2.Top = 0.625!
        Me.Label2.Width = 0.75!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.4375!
        Me.Line1.Left = 2.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.5!
        Me.Line1.Width = 0!
        Me.Line1.X1 = 2.0!
        Me.Line1.X2 = 2.0!
        Me.Line1.Y1 = 0.5!
        Me.Line1.Y2 = 0.9375!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.0!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label3.Text = "Description"
        Me.Label3.Top = 0.625!
        Me.Label3.Width = 3.4375!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.4375!
        Me.Line4.Left = 5.4375!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.5!
        Me.Line4.Width = 0!
        Me.Line4.X1 = 5.4375!
        Me.Line4.X2 = 5.4375!
        Me.Line4.Y1 = 0.5!
        Me.Line4.Y2 = 0.9375!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 5.4375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label6.Text = "Location"
        Me.Label6.Top = 0.625!
        Me.Label6.Width = 1.375!
        '
        'Line7
        '
        Me.Line7.Border.BottomColor = System.Drawing.Color.Black
        Me.Line7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.LeftColor = System.Drawing.Color.Black
        Me.Line7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.RightColor = System.Drawing.Color.Black
        Me.Line7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.TopColor = System.Drawing.Color.Black
        Me.Line7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line7.Height = 0.4375!
        Me.Line7.Left = 6.8125!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.5!
        Me.Line7.Width = 0!
        Me.Line7.X1 = 6.8125!
        Me.Line7.X2 = 6.8125!
        Me.Line7.Y1 = 0.5!
        Me.Line7.Y2 = 0.9375!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 6.8125!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label9.Text = "Rec Qty"
        Me.Label9.Top = 0.625!
        Me.Label9.Width = 0.6875!
        '
        'Line8
        '
        Me.Line8.Border.BottomColor = System.Drawing.Color.Black
        Me.Line8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.LeftColor = System.Drawing.Color.Black
        Me.Line8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.RightColor = System.Drawing.Color.Black
        Me.Line8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.TopColor = System.Drawing.Color.Black
        Me.Line8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line8.Height = 0.4375!
        Me.Line8.Left = 7.5!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.5!
        Me.Line8.Width = 0!
        Me.Line8.X1 = 7.5!
        Me.Line8.X2 = 7.5!
        Me.Line8.Y1 = 0.5!
        Me.Line8.Y2 = 0.9375!
        '
        'Line9
        '
        Me.Line9.Border.BottomColor = System.Drawing.Color.Black
        Me.Line9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.LeftColor = System.Drawing.Color.Black
        Me.Line9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.RightColor = System.Drawing.Color.Black
        Me.Line9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.TopColor = System.Drawing.Color.Black
        Me.Line9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line9.Height = 0.4375!
        Me.Line9.Left = 8.125!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.5!
        Me.Line9.Width = 0!
        Me.Line9.X1 = 8.125!
        Me.Line9.X2 = 8.125!
        Me.Line9.Y1 = 0.5!
        Me.Line9.Y2 = 0.9375!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 7.5!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label10.Text = "Iss Qty"
        Me.Label10.Top = 0.625!
        Me.Label10.Width = 0.625!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 8.125!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label11.Text = "Bal Qty"
        Me.Label11.Top = 0.625!
        Me.Label11.Width = 0.6875!
        '
        'Line10
        '
        Me.Line10.Border.BottomColor = System.Drawing.Color.Black
        Me.Line10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.LeftColor = System.Drawing.Color.Black
        Me.Line10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.RightColor = System.Drawing.Color.Black
        Me.Line10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.TopColor = System.Drawing.Color.Black
        Me.Line10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line10.Height = 0.4375!
        Me.Line10.Left = 8.8125!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.5!
        Me.Line10.Width = 0!
        Me.Line10.X1 = 8.8125!
        Me.Line10.X2 = 8.8125!
        Me.Line10.Y1 = 0.5!
        Me.Line10.Y2 = 0.9375!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 8.8125!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label12.Text = "Rate"
        Me.Label12.Top = 0.625!
        Me.Label12.Width = 0.5625!
        '
        'Line11
        '
        Me.Line11.Border.BottomColor = System.Drawing.Color.Black
        Me.Line11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.LeftColor = System.Drawing.Color.Black
        Me.Line11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.RightColor = System.Drawing.Color.Black
        Me.Line11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.TopColor = System.Drawing.Color.Black
        Me.Line11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line11.Height = 0.4375!
        Me.Line11.Left = 9.875!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.5!
        Me.Line11.Width = 0!
        Me.Line11.X1 = 9.875!
        Me.Line11.X2 = 9.875!
        Me.Line11.Y1 = 0.5!
        Me.Line11.Y2 = 0.9375!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 9.875!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label13.Text = "Amount"
        Me.Label13.Top = 0.625!
        Me.Label13.Width = 0.75!
        '
        'Line14
        '
        Me.Line14.Border.BottomColor = System.Drawing.Color.Black
        Me.Line14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.LeftColor = System.Drawing.Color.Black
        Me.Line14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.RightColor = System.Drawing.Color.Black
        Me.Line14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line14.Border.TopColor = System.Drawing.Color.Black
        Me.Line14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line14.Height = 0.4375!
        Me.Line14.Left = 9.375!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.5!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 9.375!
        Me.Line14.X2 = 9.375!
        Me.Line14.Y1 = 0.5!
        Me.Line14.Y2 = 0.9375!
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.3125!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 9.375!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "text-decoration: none; text-align: center; font-weight: bold; font-size: 9pt; "
        Me.Label15.Text = "Act. Rate"
        Me.Label15.Top = 0.5625!
        Me.Label15.Width = 0.5!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox11, Me.TextBox12, Me.Line12, Me.Line13, Me.Label14})
        Me.GroupFooter1.Height = 0.46875!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox11.DataField = "RecQty"
        Me.TextBox11.Height = 0.1875!
        Me.TextBox11.Left = 6.8125!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "text-align: right; font-size: 8.25pt; "
        Me.TextBox11.SummaryGroup = "GroupHeader1"
        Me.TextBox11.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox11.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.125!
        Me.TextBox11.Width = 0.6875!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox12.DataField = "IssQty"
        Me.TextBox12.Height = 0.1875!
        Me.TextBox12.Left = 7.5!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "text-align: right; font-size: 8.25pt; "
        Me.TextBox12.SummaryGroup = "GroupHeader1"
        Me.TextBox12.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox12.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.125!
        Me.TextBox12.Width = 0.6875!
        '
        'Line12
        '
        Me.Line12.Border.BottomColor = System.Drawing.Color.Black
        Me.Line12.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.LeftColor = System.Drawing.Color.Black
        Me.Line12.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.RightColor = System.Drawing.Color.Black
        Me.Line12.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.TopColor = System.Drawing.Color.Black
        Me.Line12.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line12.Height = 0!
        Me.Line12.Left = 0.1875!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.0625!
        Me.Line12.Width = 10.375!
        Me.Line12.X1 = 0.1875!
        Me.Line12.X2 = 10.5625!
        Me.Line12.Y1 = 0.0625!
        Me.Line12.Y2 = 0.0625!
        '
        'Line13
        '
        Me.Line13.Border.BottomColor = System.Drawing.Color.Black
        Me.Line13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.LeftColor = System.Drawing.Color.Black
        Me.Line13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.RightColor = System.Drawing.Color.Black
        Me.Line13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.TopColor = System.Drawing.Color.Black
        Me.Line13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line13.Height = 0!
        Me.Line13.Left = 0.1875!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.375!
        Me.Line13.Width = 10.375!
        Me.Line13.X1 = 0.1875!
        Me.Line13.X2 = 10.5625!
        Me.Line13.Y1 = 0.375!
        Me.Line13.Y2 = 0.375!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.1875!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 0.25!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "text-decoration: none; text-align: justify; font-weight: bold; font-size: 9pt; "
        Me.Label14.Text = "Total"
        Me.Label14.Top = 0.125!
        Me.Label14.Width = 0.9375!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'Shape2
        '
        Me.Shape2.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.RightColor = System.Drawing.Color.Black
        Me.Shape2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape2.Border.TopColor = System.Drawing.Color.Black
        Me.Shape2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape2.Height = 0.4375!
        Me.Shape2.Left = 0.1875!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!)
        Me.Shape2.Top = 0.5!
        Me.Shape2.Width = 10.4375!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox15.DataField = "ProductCode"
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 1.625!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "text-decoration: underline; font-weight: bold; font-size: 9.75pt; "
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.1875!
        Me.TextBox15.Width = 1.25!
        '
        'rptProductLedger
        '
        Me.MasterReport = False
        Me.PageSettings.Collate = GrapeCity.ActiveReports.PageSettings.PrinterCollate.DontCollate
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Duplex = System.Drawing.Printing.Duplex.Simplex
        Me.PageSettings.Margins.Bottom = 0!
        Me.PageSettings.Margins.Left = 0!
        Me.PageSettings.Margins.Right = 0!
        Me.PageSettings.Margins.Top = 0!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.6875!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ddo-char-set: 204; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldBalQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldRate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents fldCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Friend WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Friend WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
    Friend WithEvents Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldBalQty As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldRate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldAmount As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Friend WithEvents TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
