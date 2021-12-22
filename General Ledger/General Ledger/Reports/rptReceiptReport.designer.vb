Imports GrapeCity.ActiveReports
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptReceiptReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptReceiptReport))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader
        Me.fldCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldDateTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldPage = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldPages = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label24 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox35 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox25 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox39 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox22 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldCompany, Me.fldTitle, Me.Label1, Me.fldDateTime, Me.Label8, Me.fldPage, Me.Label9, Me.fldPages, Me.Label2, Me.Label3, Me.Label4, Me.Label18, Me.Label19, Me.Label13, Me.Label6, Me.Label24, Me.Label7, Me.Label10})
        Me.PageHeader1.Height = 1.447917!
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
        Me.fldCompany.Height = 0.375!
        Me.fldCompany.Left = 0.1875!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 15.75pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.fldCompany.Text = "Company"
        Me.fldCompany.Top = 0.375!
        Me.fldCompany.Width = 10.8125!
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
        Me.fldTitle.Height = 0.3125!
        Me.fldTitle.Left = 0.1875!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 15.75pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.7604167!
        Me.fldTitle.Width = 10.8125!
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
        Me.Label1.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8.75pt; font-family: Calibri; "
        Me.Label1.Text = "Print Date & Time :"
        Me.Label1.Top = 0.125!
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
        Me.fldDateTime.OutputFormat = resources.GetString("fldDateTime.OutputFormat")
        Me.fldDateTime.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8.75pt; font-family: Calibri; "
        Me.fldDateTime.Text = "DateTime"
        Me.fldDateTime.Top = 0.125!
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
        Me.Label8.Left = 9.4375!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; font-size: 8.75pt; font-family: Calibri; "
        Me.Label8.Text = "Page No."
        Me.Label8.Top = 0.125!
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
        Me.fldPage.Left = 10.0!
        Me.fldPage.Name = "fldPage"
        Me.fldPage.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8.75pt; font-fa" & _
            "mily: Calibri; "
        Me.fldPage.SummaryGroup = "GroupHeader1"
        Me.fldPage.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.fldPage.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.fldPage.Text = "Page"
        Me.fldPage.Top = 0.125!
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
        Me.Label9.Left = 10.375!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; "
        Me.Label9.Text = "of"
        Me.Label9.Top = 0.125!
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
        Me.fldPages.Left = 10.5625!
        Me.fldPages.Name = "fldPages"
        Me.fldPages.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 8.75pt; font-fam" & _
            "ily: Calibri; "
        Me.fldPages.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.fldPages.Text = "Pages"
        Me.fldPages.Top = 0.125!
        Me.fldPages.Width = 0.4375!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Height = 0.25!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.25!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label2.Text = "Unit #"
        Me.Label2.Top = 1.1875!
        Me.Label2.Width = 0.8125!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.25!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 1.0625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label3.Text = "Receipt No"
        Me.Label3.Top = 1.1875!
        Me.Label3.Width = 1.25!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.25!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 9.8125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label4.Text = "Receipt Amount"
        Me.Label4.Top = 1.1875!
        Me.Label4.Width = 1.1875!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label18.Height = 0.25!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 2.3125!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label18.Text = "Receipt Date"
        Me.Label18.Top = 1.1875!
        Me.Label18.Width = 1.0!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label19.Height = 0.25!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 3.3125!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label19.Text = "Invoice No"
        Me.Label19.Top = 1.1875!
        Me.Label19.Width = 1.125!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label13.Height = 0.25!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 8.5625!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label13.Text = "Invocie Amount"
        Me.Label13.Top = 1.1875!
        Me.Label13.Width = 1.25!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.25!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 5.375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label6.Text = "Receipt Type"
        Me.Label6.Top = 1.1875!
        Me.Label6.Width = 1.1875!
        '
        'Label24
        '
        Me.Label24.Border.BottomColor = System.Drawing.Color.Black
        Me.Label24.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.LeftColor = System.Drawing.Color.Black
        Me.Label24.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.RightColor = System.Drawing.Color.Black
        Me.Label24.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Border.TopColor = System.Drawing.Color.Black
        Me.Label24.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label24.Height = 0.25!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 4.4375!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label24.Text = "Manual Receipt#"
        Me.Label24.Top = 1.1875!
        Me.Label24.Width = 0.9375!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.25!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.5625!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label7.Text = "Payment Type"
        Me.Label7.Top = 1.1875!
        Me.Label7.Width = 1.375!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.25!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 7.9375!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8.75pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label10.Text = "Installment"
        Me.Label10.Top = 1.1875!
        Me.Label10.Width = 0.625!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox35, Me.TextBox25, Me.TextBox39, Me.TextBox10})
        Me.Detail1.Height = 0.2604167!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.DataField = "UnitNo"
        Me.TextBox1.Height = 0.25!
        Me.TextBox1.Left = 0.25!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" & _
            "-family: Calibri; vertical-align: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.8125!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.DataField = "ReceiptNo"
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 1.0625!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" & _
            "-family: Calibri; vertical-align: middle; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 1.25!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.DataField = "ReceiptType"
        Me.TextBox3.Height = 0.25!
        Me.TextBox3.Left = 5.375!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" & _
            "-family: Calibri; vertical-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 1.1875!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.DataField = "PaymentType"
        Me.TextBox4.Height = 0.25!
        Me.TextBox4.Left = 6.5625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.375!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.DataField = "InvoiceAmount"
        Me.TextBox5.Height = 0.25!
        Me.TextBox5.Left = 8.5625!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8pt; font-famil" & _
            "y: Calibri; vertical-align: middle; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 1.25!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.DataField = "ReceiptAmount"
        Me.TextBox6.Height = 0.25!
        Me.TextBox6.Left = 9.8125!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8p" & _
            "t; font-family: Calibri; vertical-align: middle; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 1.1875!
        '
        'TextBox35
        '
        Me.TextBox35.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox35.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox35.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox35.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox35.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox35.DataField = "Installment"
        Me.TextBox35.Height = 0.25!
        Me.TextBox35.Left = 7.9375!
        Me.TextBox35.Name = "TextBox35"
        Me.TextBox35.OutputFormat = resources.GetString("TextBox35.OutputFormat")
        Me.TextBox35.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 8pt; font-fami" & _
            "ly: Calibri; vertical-align: middle; "
        Me.TextBox35.Text = Nothing
        Me.TextBox35.Top = 0.0!
        Me.TextBox35.Width = 0.625!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox25.DataField = "ReceiptDate"
        Me.TextBox25.Height = 0.25!
        Me.TextBox25.Left = 2.3125!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.OutputFormat = resources.GetString("TextBox25.OutputFormat")
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" & _
            "-family: Calibri; vertical-align: middle; "
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 0.0!
        Me.TextBox25.Width = 1.0!
        '
        'TextBox39
        '
        Me.TextBox39.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox39.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox39.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox39.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox39.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox39.DataField = "InvoiceNo"
        Me.TextBox39.Height = 0.25!
        Me.TextBox39.Left = 3.3125!
        Me.TextBox39.Name = "TextBox39"
        Me.TextBox39.OutputFormat = resources.GetString("TextBox39.OutputFormat")
        Me.TextBox39.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" & _
            "-family: Calibri; vertical-align: middle; "
        Me.TextBox39.Text = Nothing
        Me.TextBox39.Top = 0.0!
        Me.TextBox39.Width = 1.125!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.TextBox10.DataField = "ManualReceiptNo"
        Me.TextBox10.Height = 0.25!
        Me.TextBox10.Left = 4.4375!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: center; font-weight: normal; font-size: 8.25pt; font" & _
            "-family: Calibri; vertical-align: middle; "
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.9375!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.01041667!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox8, Me.Label5})
        Me.GroupHeader1.DataField = "UnitNo"
        Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.GroupHeader1.Height = 0.3125!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.TextBox8.DataField = "CustomerName"
        Me.TextBox8.Height = 0.25!
        Me.TextBox8.Left = 1.28125!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 0; text-decoration: underline; text-align: left; font-weight: bold;" & _
            " font-size: 9.75pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.03125!
        Me.TextBox8.Width = 3.75!
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
        Me.Label5.Height = 0.25!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.25!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 8.75pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label5.Text = "Customer Name : "
        Me.Label5.Top = 0.03125!
        Me.Label5.Width = 1.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line13, Me.Label22, Me.TextBox15, Me.TextBox16})
        Me.GroupFooter1.Height = 0.3645833!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Line13.Height = 0.0!
        Me.Line13.Left = 0.25!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.0!
        Me.Line13.Width = 10.75!
        Me.Line13.X1 = 11.0!
        Me.Line13.X2 = 0.25!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.0!
        '
        'Label22
        '
        Me.Label22.Border.BottomColor = System.Drawing.Color.Black
        Me.Label22.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.LeftColor = System.Drawing.Color.Black
        Me.Label22.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.RightColor = System.Drawing.Color.Black
        Me.Label22.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.TopColor = System.Drawing.Color.Black
        Me.Label22.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label22.Height = 0.25!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.25!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "color: Blue; ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: " & _
            "8.75pt; font-family: Calibri; vertical-align: middle; "
        Me.Label22.Text = "Unit Total"
        Me.Label22.Top = 0.04166667!
        Me.Label22.Width = 0.625!
        '
        'TextBox15
        '
        Me.TextBox15.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox15.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox15.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox15.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox15.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox15.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox15.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox15.DataField = "InvoiceAmount"
        Me.TextBox15.Height = 0.25!
        Me.TextBox15.Left = 8.5625!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8.75pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.TextBox15.SummaryGroup = "GroupHeader1"
        Me.TextBox15.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox15.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.04166667!
        Me.TextBox15.Width = 1.25!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox16.DataField = "ReceiptAmount"
        Me.TextBox16.Height = 0.25!
        Me.TextBox16.Left = 9.8125!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8.75pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.TextBox16.SummaryGroup = "GroupHeader1"
        Me.TextBox16.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox16.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.04166667!
        Me.TextBox16.Width = 1.1875!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label17, Me.TextBox22, Me.TextBox7, Me.Line1})
        Me.ReportFooter1.Height = 0.3854167!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Label17.Left = 0.25!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Blue; ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: " & _
            "8.75pt; font-family: Calibri; vertical-align: middle; "
        Me.Label17.Text = "Grand Total"
        Me.Label17.Top = 0.0625!
        Me.Label17.Width = 0.6875!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox22.DataField = "ReceiptAmount"
        Me.TextBox22.Height = 0.3125!
        Me.TextBox22.Left = 9.8125!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.OutputFormat = resources.GetString("TextBox22.OutputFormat")
        Me.TextBox22.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8.75pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.TextBox22.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox22.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox22.Text = Nothing
        Me.TextBox22.Top = 0.02083333!
        Me.TextBox22.Width = 1.1875!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox7.DataField = "InvoiceAmount"
        Me.TextBox7.Height = 0.3125!
        Me.TextBox7.Left = 8.5625!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 8.75pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.TextBox7.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox7.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.02083333!
        Me.TextBox7.Width = 1.25!
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
        Me.Line1.Left = 0.25!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0!
        Me.Line1.Width = 10.75!
        Me.Line1.X1 = 11.0!
        Me.Line1.X2 = 0.25!
        Me.Line1.Y1 = 0.0!
        Me.Line1.Y2 = 0.0!
        '
        'rptReceiptReportEmpire
        '
        Me.MasterReport = False
        Me.PageSettings.Collate = GrapeCity.ActiveReports.PageSettings.PrinterCollate.DontCollate
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Duplex = System.Drawing.Printing.Duplex.Simplex
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.4!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 11.09375!
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
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents fldCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Friend WithEvents Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents fldDateTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPage As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPages As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Friend WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
    Friend WithEvents Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox22 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox35 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox25 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox39 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label24 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
End Class
