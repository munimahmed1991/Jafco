Imports GrapeCity.ActiveReports
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptAgingAnalysis
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptAgingAnalysis))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader
        Me.fldCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldDateTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldPage = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldPages = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line24 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.fldChequeDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldCompany, Me.fldTitle, Me.Label1, Me.fldDateTime, Me.Label8, Me.fldPage, Me.Label9, Me.fldPages, Me.Label15, Me.Line5, Me.Line1, Me.Line23, Me.Line10, Me.Line24, Me.Line3, Me.Label2, Me.Line4, Me.Label3, Me.Line6, Me.Label4, Me.Label5, Me.Line7, Me.Label6, Me.Line8, Me.Label7, Me.Line9, Me.Label10, Me.Line11, Me.Label11, Me.Line12, Me.Label12, Me.Line13, Me.Label13})
        Me.PageHeader1.Height = 1.708333!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'fldCompany
        '
        Me.fldCompany.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCompany.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCompany.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Border.RightColor = System.Drawing.Color.Black
        Me.fldCompany.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Border.TopColor = System.Drawing.Color.Black
        Me.fldCompany.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Height = 0.4375!
        Me.fldCompany.Left = 0.1875!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 18pt; vertical" & _
            "-align: middle; "
        Me.fldCompany.Text = "Company"
        Me.fldCompany.Top = 0.3125!
        Me.fldCompany.Width = 10.0!
        '
        'fldTitle
        '
        Me.fldTitle.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTitle.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTitle.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Border.RightColor = System.Drawing.Color.Black
        Me.fldTitle.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Border.TopColor = System.Drawing.Color.Black
        Me.fldTitle.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Height = 0.25!
        Me.fldTitle.Left = 0.1875!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; verti" & _
            "cal-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.75!
        Me.fldTitle.Width = 10.0!
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
        Me.Label1.Style = ""
        Me.Label1.Text = "Print Date & Time :"
        Me.Label1.Top = 0.0625!
        Me.Label1.Width = 1.25!
        '
        'fldDateTime
        '
        Me.fldDateTime.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Border.RightColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Border.TopColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Height = 0.1875!
        Me.fldDateTime.Left = 1.4375!
        Me.fldDateTime.Name = "fldDateTime"
        Me.fldDateTime.Style = ""
        Me.fldDateTime.Text = "DateTime"
        Me.fldDateTime.Top = 0.0625!
        Me.fldDateTime.Width = 1.8125!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 8.375!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8.25pt; "
        Me.Label8.Text = "Page No."
        Me.Label8.Top = 0.0625!
        Me.Label8.Width = 0.5625!
        '
        'fldPage
        '
        Me.fldPage.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPage.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPage.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPage.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPage.Border.RightColor = System.Drawing.Color.Black
        Me.fldPage.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPage.Border.TopColor = System.Drawing.Color.Black
        Me.fldPage.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPage.Height = 0.1875!
        Me.fldPage.Left = 9.125!
        Me.fldPage.Name = "fldPage"
        Me.fldPage.Style = "text-align: right; font-size: 8.25pt; "
        Me.fldPage.SummaryGroup = "GroupHeader1"
        Me.fldPage.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.fldPage.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.fldPage.Text = "Page"
        Me.fldPage.Top = 0.0625!
        Me.fldPage.Width = 0.375!
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
        Me.Label9.Left = 9.5!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "text-align: center; font-size: 8.25pt; "
        Me.Label9.Text = "of"
        Me.Label9.Top = 0.0625!
        Me.Label9.Width = 0.1875!
        '
        'fldPages
        '
        Me.fldPages.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPages.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPages.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPages.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPages.Border.RightColor = System.Drawing.Color.Black
        Me.fldPages.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPages.Border.TopColor = System.Drawing.Color.Black
        Me.fldPages.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPages.Height = 0.1875!
        Me.fldPages.Left = 9.6875!
        Me.fldPages.Name = "fldPages"
        Me.fldPages.Style = "text-align: left; font-size: 8.25pt; "
        Me.fldPages.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.fldPages.Text = "Pages"
        Me.fldPages.Top = 0.0625!
        Me.fldPages.Width = 0.4375!
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
        Me.Label15.Height = 0.4375!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.1875!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label15.Text = "Unit Type"
        Me.Label15.Top = 1.1875!
        Me.Label15.Width = 1.3125!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.5625!
        Me.Line5.Left = 1.5625!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.125!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 1.5625!
        Me.Line5.X2 = 1.5625!
        Me.Line5.Y1 = 1.125!
        Me.Line5.Y2 = 1.6875!
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
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.1875!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 1.125!
        Me.Line1.Width = 10.5!
        Me.Line1.X1 = 10.6875!
        Me.Line1.X2 = 0.1875!
        Me.Line1.Y1 = 1.125!
        Me.Line1.Y2 = 1.125!
        '
        'Line23
        '
        Me.Line23.Border.BottomColor = System.Drawing.Color.Black
        Me.Line23.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.LeftColor = System.Drawing.Color.Black
        Me.Line23.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.RightColor = System.Drawing.Color.Black
        Me.Line23.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.TopColor = System.Drawing.Color.Black
        Me.Line23.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line23.Height = 0.0!
        Me.Line23.Left = 0.1875!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 1.6875!
        Me.Line23.Width = 10.5!
        Me.Line23.X1 = 10.6875!
        Me.Line23.X2 = 0.1875!
        Me.Line23.Y1 = 1.6875!
        Me.Line23.Y2 = 1.6875!
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
        Me.Line10.Height = 0.5625!
        Me.Line10.Left = 0.1875!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 1.125!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 0.1875!
        Me.Line10.X2 = 0.1875!
        Me.Line10.Y1 = 1.125!
        Me.Line10.Y2 = 1.6875!
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
        Me.Line24.Height = 0.5625!
        Me.Line24.Left = 10.6875!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 1.125!
        Me.Line24.Width = 0.0!
        Me.Line24.X1 = 10.6875!
        Me.Line24.X2 = 10.6875!
        Me.Line24.Y1 = 1.125!
        Me.Line24.Y2 = 1.6875!
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
        Me.Line3.Height = 0.5625!
        Me.Line3.Left = 2.375!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.125!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 2.375!
        Me.Line3.X2 = 2.375!
        Me.Line3.Y1 = 1.125!
        Me.Line3.Y2 = 1.6875!
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
        Me.Label2.Height = 0.4375!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.625!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label2.Text = "Unit Number"
        Me.Label2.Top = 1.1875!
        Me.Label2.Width = 0.6875!
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
        Me.Line4.Height = 0.5625!
        Me.Line4.Left = 3.6875!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.125!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 3.6875!
        Me.Line4.X2 = 3.6875!
        Me.Line4.Y1 = 1.125!
        Me.Line4.Y2 = 1.6875!
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
        Me.Label3.Height = 0.4375!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.4375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label3.Text = "Customer Name"
        Me.Label3.Top = 1.1875!
        Me.Label3.Width = 1.1875!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.5625!
        Me.Line6.Left = 4.6875!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.125!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 4.6875!
        Me.Line6.X2 = 4.6875!
        Me.Line6.Y1 = 1.125!
        Me.Line6.Y2 = 1.6875!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.4375!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.75!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label4.Text = "Tel Res"
        Me.Label4.Top = 1.1875!
        Me.Label4.Width = 0.875!
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
        Me.Label5.Height = 0.4375!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 4.75!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label5.Text = "Mobile"
        Me.Label5.Top = 1.1875!
        Me.Label5.Width = 0.875!
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
        Me.Line7.Height = 0.5625!
        Me.Line7.Left = 6.5625!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 1.125!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 6.5625!
        Me.Line7.X2 = 6.5625!
        Me.Line7.Y1 = 1.125!
        Me.Line7.Y2 = 1.6875!
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
        Me.Label6.Height = 0.4375!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 6.625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label6.Text = "30 Days"
        Me.Label6.Top = 1.1875!
        Me.Label6.Width = 0.6875!
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
        Me.Line8.Height = 0.5625!
        Me.Line8.Left = 7.375!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.125!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 7.375!
        Me.Line8.X2 = 7.375!
        Me.Line8.Y1 = 1.125!
        Me.Line8.Y2 = 1.6875!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.4375!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 7.4375!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label7.Text = "60 Days"
        Me.Label7.Top = 1.1875!
        Me.Label7.Width = 0.6875!
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
        Me.Line9.Height = 0.5625!
        Me.Line9.Left = 8.1875!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.125!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 8.1875!
        Me.Line9.X2 = 8.1875!
        Me.Line9.Y1 = 1.125!
        Me.Line9.Y2 = 1.6875!
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
        Me.Label10.Height = 0.4375!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 8.25!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label10.Text = "90 Days"
        Me.Label10.Top = 1.1875!
        Me.Label10.Width = 0.6875!
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
        Me.Line11.Height = 0.5625!
        Me.Line11.Left = 9.0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 1.125!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 9.0!
        Me.Line11.X2 = 9.0!
        Me.Line11.Y1 = 1.125!
        Me.Line11.Y2 = 1.6875!
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
        Me.Label11.Height = 0.4375!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 9.0625!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label11.Text = "After 90"
        Me.Label11.Top = 1.1875!
        Me.Label11.Width = 0.6875!
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
        Me.Line12.Height = 0.5625!
        Me.Line12.Left = 9.8125!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 1.125!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 9.8125!
        Me.Line12.X2 = 9.8125!
        Me.Line12.Y1 = 1.125!
        Me.Line12.Y2 = 1.6875!
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
        Me.Label12.Height = 0.4375!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 9.875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label12.Text = "Total"
        Me.Label12.Top = 1.1875!
        Me.Label12.Width = 0.75!
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
        Me.Line13.Height = 0.5625!
        Me.Line13.Left = 5.6875!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 1.125!
        Me.Line13.Width = 0.0!
        Me.Line13.X1 = 5.6875!
        Me.Line13.X2 = 5.6875!
        Me.Line13.Y1 = 1.125!
        Me.Line13.Y2 = 1.6875!
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
        Me.Label13.Height = 0.4375!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 5.75!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label13.Text = "Last Payment Date"
        Me.Label13.Top = 1.1875!
        Me.Label13.Width = 0.75!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldChequeDate, Me.Line25, Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox15})
        Me.Detail1.Height = 0.3229167!
        Me.Detail1.Name = "Detail1"
        '
        'fldChequeDate
        '
        Me.fldChequeDate.Border.BottomColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.Border.LeftColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.Border.RightColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.Border.TopColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.DataField = "UnitTypeName"
        Me.fldChequeDate.Height = 0.25!
        Me.fldChequeDate.Left = 0.25!
        Me.fldChequeDate.Name = "fldChequeDate"
        Me.fldChequeDate.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.fldChequeDate.Text = Nothing
        Me.fldChequeDate.Top = 0.0!
        Me.fldChequeDate.Width = 1.3125!
        '
        'Line25
        '
        Me.Line25.Border.BottomColor = System.Drawing.Color.Black
        Me.Line25.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.LeftColor = System.Drawing.Color.Black
        Me.Line25.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.RightColor = System.Drawing.Color.Black
        Me.Line25.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.TopColor = System.Drawing.Color.Black
        Me.Line25.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 0.1875!
        Me.Line25.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.3125!
        Me.Line25.Width = 10.5!
        Me.Line25.X1 = 10.6875!
        Me.Line25.X2 = 0.1875!
        Me.Line25.Y1 = 0.3125!
        Me.Line25.Y2 = 0.3125!
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
        Me.TextBox1.DataField = "UnitNumber"
        Me.TextBox1.Height = 0.25!
        Me.TextBox1.Left = 1.625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.6875!
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
        Me.TextBox2.DataField = "CustomerName"
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 2.4375!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.25!
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
        Me.TextBox3.DataField = "TelRes"
        Me.TextBox3.Height = 0.25!
        Me.TextBox3.Left = 3.75!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.9375!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox4.DataField = "Mobile"
        Me.TextBox4.Height = 0.25!
        Me.TextBox4.Left = 4.75!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.9375!
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
        Me.TextBox5.DataField = "Days30"
        Me.TextBox5.Height = 0.25!
        Me.TextBox5.Left = 6.625!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.75!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox6.DataField = "Days60"
        Me.TextBox6.Height = 0.25!
        Me.TextBox6.Left = 7.4375!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.75!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox7.DataField = "Days90"
        Me.TextBox7.Height = 0.25!
        Me.TextBox7.Left = 8.25!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.75!
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
        Me.TextBox8.DataField = "After90Days"
        Me.TextBox8.Height = 0.25!
        Me.TextBox8.Left = 9.0625!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.75!
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
        Me.TextBox9.DataField = "Amount"
        Me.TextBox9.Height = 0.25!
        Me.TextBox9.Left = 9.875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-weight: normal; font-size: 8.25pt; font-" & _
            "family: Arial; vertical-align: middle; "
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.75!
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
        Me.TextBox15.DataField = "LastReceiptDate"
        Me.TextBox15.Height = 0.25!
        Me.TextBox15.Left = 5.75!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.0!
        Me.TextBox15.Width = 0.8125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.3854167!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line2, Me.Line17, Me.Label17, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.TextBox13, Me.TextBox14})
        Me.ReportFooter1.Height = 0.8854167!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.1875!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.1875!
        Me.Line2.Width = 10.5!
        Me.Line2.X1 = 10.6875!
        Me.Line2.X2 = 0.1875!
        Me.Line2.Y1 = 0.1875!
        Me.Line2.Y2 = 0.1875!
        '
        'Line17
        '
        Me.Line17.Border.BottomColor = System.Drawing.Color.Black
        Me.Line17.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.LeftColor = System.Drawing.Color.Black
        Me.Line17.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.RightColor = System.Drawing.Color.Black
        Me.Line17.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line17.Border.TopColor = System.Drawing.Color.Black
        Me.Line17.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line17.Height = 0.0!
        Me.Line17.Left = 0.1875!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.5625!
        Me.Line17.Width = 10.5!
        Me.Line17.X1 = 10.6875!
        Me.Line17.X2 = 0.1875!
        Me.Line17.Y1 = 0.5625!
        Me.Line17.Y2 = 0.5625!
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label17.Height = 0.25!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.3125!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Blue; ddo-char-set: 0; text-align: justify; font-weight: bold; font-size: " & _
            "9pt; font-family: Arial Narrow; vertical-align: middle; "
        Me.Label17.Text = "Grand Total"
        Me.Label17.Top = 0.25!
        Me.Label17.Width = 1.625!
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
        Me.TextBox10.DataField = "Days30"
        Me.TextBox10.Height = 0.25!
        Me.TextBox10.Left = 6.625!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "color: Blue; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9p" & _
            "t; font-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.TextBox10.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox10.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.25!
        Me.TextBox10.Width = 0.75!
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
        Me.TextBox11.DataField = "Days60"
        Me.TextBox11.Height = 0.25!
        Me.TextBox11.Left = 7.4375!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "color: Blue; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9p" & _
            "t; font-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.TextBox11.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox11.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.25!
        Me.TextBox11.Width = 0.75!
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
        Me.TextBox12.DataField = "Days90"
        Me.TextBox12.Height = 0.25!
        Me.TextBox12.Left = 8.25!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
        Me.TextBox12.Style = "color: Blue; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9p" & _
            "t; font-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.TextBox12.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox12.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.25!
        Me.TextBox12.Width = 0.75!
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
        Me.TextBox13.DataField = "After90Days"
        Me.TextBox13.Height = 0.25!
        Me.TextBox13.Left = 9.0625!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "color: Blue; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9p" & _
            "t; font-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.TextBox13.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox13.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.25!
        Me.TextBox13.Width = 0.75!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox14.DataField = "Amount"
        Me.TextBox14.Height = 0.25!
        Me.TextBox14.Left = 9.875!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "color: Blue; ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 9p" & _
            "t; font-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.TextBox14.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox14.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0.25!
        Me.TextBox14.Width = 0.75!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'rptAgingAnalysis
        '
        Me.MasterReport = False
        Me.PageSettings.Collate = GrapeCity.ActiveReports.PageSettings.PrinterCollate.DontCollate
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Duplex = System.Drawing.Printing.Duplex.Simplex
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.70833!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ddo-char-set: 204; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ddo-char-set: 204; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents fldCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldDateTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPage As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPages As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Friend WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
    Friend WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents fldChequeDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Friend WithEvents Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
