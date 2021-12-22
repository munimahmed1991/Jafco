Imports GrapeCity.ActiveReports
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptInventorySummaryReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptInventorySummaryReport))
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
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape
        Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.fldChequeDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line25 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldPerBooking = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line26 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox17 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox18 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox19 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox20 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox21 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox22 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox23 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldPerBlockWise = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox24 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox25 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox26 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox27 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox28 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox29 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox30 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox31 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox32 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox33 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox34 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldTotalPer = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label23 = New GrapeCity.ActiveReports.SectionReportModel.Label
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPerBooking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPerBlockWise, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTotalPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldCompany, Me.fldTitle, Me.Label1, Me.fldDateTime, Me.Label8, Me.fldPage, Me.Label9, Me.fldPages, Me.Label15, Me.Line5, Me.Line1, Me.Line23, Me.Line10, Me.Line24, Me.Label3, Me.Line4, Me.Line6, Me.Label4, Me.Label5, Me.Line7, Me.Label6, Me.Label7, Me.Line8, Me.Line9, Me.Label10, Me.Label11, Me.Label12, Me.Label13, Me.Label14, Me.Line11, Me.Line12, Me.Line14, Me.Line15, Me.Label16, Me.Line16, Me.Shape1, Me.Shape2, Me.Label18, Me.Label19, Me.Line3, Me.Label2})
        Me.PageHeader1.Height = 2.0625!
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
        Me.fldCompany.Width = 10.375!
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
        Me.fldTitle.Width = 10.375!
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
        Me.Label8.Left = 8.8125!
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
        Me.fldPage.Left = 9.5625!
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
        Me.Label9.Left = 9.9375!
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
        Me.fldPages.Left = 10.125!
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
        Me.Label15.Top = 1.5625!
        Me.Label15.Width = 1.5!
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
        Me.Line5.Left = 1.75!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 1.5!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 1.75!
        Me.Line5.X2 = 1.75!
        Me.Line5.Y1 = 1.5!
        Me.Line5.Y2 = 2.0625!
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
        Me.Line1.Top = 1.5!
        Me.Line1.Width = 10.5!
        Me.Line1.X1 = 10.6875!
        Me.Line1.X2 = 0.1875!
        Me.Line1.Y1 = 1.5!
        Me.Line1.Y2 = 1.5!
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
        Me.Line23.Top = 2.0625!
        Me.Line23.Width = 10.5!
        Me.Line23.X1 = 10.6875!
        Me.Line23.X2 = 0.1875!
        Me.Line23.Y1 = 2.0625!
        Me.Line23.Y2 = 2.0625!
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
        Me.Line10.Top = 1.5!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 0.1875!
        Me.Line10.X2 = 0.1875!
        Me.Line10.Y1 = 1.5!
        Me.Line10.Y2 = 2.0625!
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
        Me.Line24.Top = 1.5!
        Me.Line24.Width = 0.0!
        Me.Line24.X1 = 10.6875!
        Me.Line24.X2 = 10.6875!
        Me.Line24.Y1 = 1.5!
        Me.Line24.Y2 = 2.0625!
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
        Me.Label3.Left = 1.8125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label3.Text = "No. of Units"
        Me.Label3.Top = 1.5625!
        Me.Label3.Width = 0.375!
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
        Me.Line4.Left = 2.25!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 1.5!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 2.25!
        Me.Line4.X2 = 2.25!
        Me.Line4.Y1 = 1.5!
        Me.Line4.Y2 = 2.0625!
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
        Me.Line6.Left = 3.0625!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 1.5!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 3.0625!
        Me.Line6.X2 = 3.0625!
        Me.Line6.Y1 = 1.5!
        Me.Line6.Y2 = 2.0625!
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
        Me.Label4.Left = 2.3125!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label4.Text = "Cash Amount"
        Me.Label4.Top = 1.5625!
        Me.Label4.Width = 0.6875!
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
        Me.Label5.Left = 3.125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label5.Text = "Loan Amount"
        Me.Label5.Top = 1.5625!
        Me.Label5.Width = 0.6875!
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
        Me.Line7.Left = 3.875!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 1.5!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 3.875!
        Me.Line7.X2 = 3.875!
        Me.Line7.Y1 = 1.5!
        Me.Line7.Y2 = 2.0625!
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
        Me.Label6.Left = 3.9375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label6.Text = "Extra Charges"
        Me.Label6.Top = 1.5625!
        Me.Label6.Width = 0.6875!
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
        Me.Label7.Left = 4.75!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label7.Text = "Total Revenue Including Extra Charges"
        Me.Label7.Top = 1.5625!
        Me.Label7.Width = 0.6875!
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
        Me.Line8.Left = 4.6875!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 1.5!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 4.6875!
        Me.Line8.X2 = 4.6875!
        Me.Line8.Y1 = 1.5!
        Me.Line8.Y2 = 2.0625!
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
        Me.Line9.Left = 5.5!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 1.5!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 5.5!
        Me.Line9.X2 = 5.5!
        Me.Line9.Y1 = 1.5!
        Me.Line9.Y2 = 2.0625!
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
        Me.Label10.Left = 5.5625!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label10.Text = "No. of Units"
        Me.Label10.Top = 1.5625!
        Me.Label10.Width = 0.4375!
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
        Me.Label11.Left = 6.6875!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label11.Text = "Cash Amount"
        Me.Label11.Top = 1.5625!
        Me.Label11.Width = 0.6875!
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
        Me.Label12.Left = 7.5!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label12.Text = "Loan Amount"
        Me.Label12.Top = 1.5625!
        Me.Label12.Width = 0.6875!
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
        Me.Label13.Left = 8.3125!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label13.Text = "Extra Charges"
        Me.Label13.Top = 1.5625!
        Me.Label13.Width = 0.5625!
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
        Me.Label14.Height = 0.4375!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 9.6875!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label14.Text = "Total Revenue Incl. Extra Charges Net of Discount"
        Me.Label14.Top = 1.5625!
        Me.Label14.Width = 0.9375!
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
        Me.Line11.Left = 6.625!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 1.5!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 6.625!
        Me.Line11.X2 = 6.625!
        Me.Line11.Y1 = 1.5!
        Me.Line11.Y2 = 2.0625!
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
        Me.Line12.Left = 7.4375!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 1.5!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 7.4375!
        Me.Line12.X2 = 7.4375!
        Me.Line12.Y1 = 1.5!
        Me.Line12.Y2 = 2.0625!
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
        Me.Line14.Height = 0.5625!
        Me.Line14.Left = 8.25!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 1.5!
        Me.Line14.Width = 0.0!
        Me.Line14.X1 = 8.25!
        Me.Line14.X2 = 8.25!
        Me.Line14.Y1 = 1.5!
        Me.Line14.Y2 = 2.0625!
        '
        'Line15
        '
        Me.Line15.Border.BottomColor = System.Drawing.Color.Black
        Me.Line15.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.LeftColor = System.Drawing.Color.Black
        Me.Line15.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.RightColor = System.Drawing.Color.Black
        Me.Line15.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line15.Border.TopColor = System.Drawing.Color.Black
        Me.Line15.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line15.Height = 0.5625!
        Me.Line15.Left = 8.9375!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 1.5!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 8.9375!
        Me.Line15.X2 = 8.9375!
        Me.Line15.Y1 = 1.5!
        Me.Line15.Y2 = 2.0625!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.4375!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 9.0!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label16.Text = "Discount"
        Me.Label16.Top = 1.5625!
        Me.Label16.Width = 0.5625!
        '
        'Line16
        '
        Me.Line16.Border.BottomColor = System.Drawing.Color.Black
        Me.Line16.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.LeftColor = System.Drawing.Color.Black
        Me.Line16.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.RightColor = System.Drawing.Color.Black
        Me.Line16.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.TopColor = System.Drawing.Color.Black
        Me.Line16.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line16.Height = 0.5625!
        Me.Line16.Left = 9.625!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 1.5!
        Me.Line16.Width = 0.0!
        Me.Line16.X1 = 9.625!
        Me.Line16.X2 = 9.625!
        Me.Line16.Y1 = 1.5!
        Me.Line16.Y2 = 2.0625!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 0.3125!
        Me.Shape1.Left = 1.75!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!)
        Me.Shape1.Top = 1.1875!
        Me.Shape1.Width = 3.75!
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
        Me.Shape2.Height = 0.3125!
        Me.Shape2.Left = 5.5!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!)
        Me.Shape2.Top = 1.1875!
        Me.Shape2.Width = 5.1875!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label18.Height = 0.1875!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 1.8125!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: Blue; text-align: center; font-weight: bold; "
        Me.Label18.Text = "Total Inventory"
        Me.Label18.Top = 1.25!
        Me.Label18.Width = 3.625!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.1875!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 5.5625!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: Blue; text-align: center; font-weight: bold; "
        Me.Label19.Text = "Booked Units"
        Me.Label19.Top = 1.25!
        Me.Label19.Width = 5.0625!
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
        Me.Line3.Left = 6.0625!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 1.5!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 6.0625!
        Me.Line3.X2 = 6.0625!
        Me.Line3.Y1 = 1.5!
        Me.Line3.Y2 = 2.0625!
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
        Me.Label2.Left = 6.125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label2.Text = "% of Booking"
        Me.Label2.Top = 1.5625!
        Me.Label2.Width = 0.4375!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldChequeDate, Me.Line25, Me.TextBox2, Me.TextBox3, Me.TextBox4, Me.TextBox5, Me.TextBox6, Me.TextBox7, Me.TextBox8, Me.TextBox9, Me.TextBox10, Me.TextBox11, Me.TextBox12, Me.fldPerBooking, Me.Label20})
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
        Me.fldChequeDate.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.fldChequeDate.Text = Nothing
        Me.fldChequeDate.Top = 0.0!
        Me.fldChequeDate.Width = 1.5!
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
        Me.TextBox2.DataField = "Unit"
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 1.8125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.375!
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
        Me.TextBox3.DataField = "CashAmount"
        Me.TextBox3.Height = 0.25!
        Me.TextBox3.Left = 2.25!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.8125!
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
        Me.TextBox4.DataField = "LoanAmount"
        Me.TextBox4.Height = 0.25!
        Me.TextBox4.Left = 3.0625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.8125!
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
        Me.TextBox5.DataField = "TotalExtraCharges"
        Me.TextBox5.Height = 0.25!
        Me.TextBox5.Left = 3.875!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.8125!
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
        Me.TextBox6.DataField = "TotalAmount"
        Me.TextBox6.Height = 0.25!
        Me.TextBox6.Left = 4.6875!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.8125!
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
        Me.TextBox7.DataField = "ReserveCashAmount"
        Me.TextBox7.Height = 0.25!
        Me.TextBox7.Left = 6.625!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.8125!
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
        Me.TextBox8.DataField = "Booked"
        Me.TextBox8.Height = 0.25!
        Me.TextBox8.Left = 5.5625!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0.0!
        Me.TextBox8.Width = 0.4375!
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
        Me.TextBox9.DataField = "ReserveLoanAmount"
        Me.TextBox9.Height = 0.25!
        Me.TextBox9.Left = 7.4375!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 0.8125!
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
        Me.TextBox10.DataField = "ReserveExtraCharges"
        Me.TextBox10.Height = 0.25!
        Me.TextBox10.Left = 8.25!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 0.625!
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
        Me.TextBox11.DataField = "ReserveDiscount"
        Me.TextBox11.Height = 0.25!
        Me.TextBox11.Left = 8.9375!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.0!
        Me.TextBox11.Width = 0.625!
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
        Me.TextBox12.DataField = "TotalReserveAmount"
        Me.TextBox12.Height = 0.25!
        Me.TextBox12.Left = 9.625!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 0.0!
        Me.TextBox12.Width = 1.0!
        '
        'fldPerBooking
        '
        Me.fldPerBooking.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPerBooking.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBooking.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPerBooking.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBooking.Border.RightColor = System.Drawing.Color.Black
        Me.fldPerBooking.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBooking.Border.TopColor = System.Drawing.Color.Black
        Me.fldPerBooking.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBooking.Height = 0.25!
        Me.fldPerBooking.Left = 6.125!
        Me.fldPerBooking.Name = "fldPerBooking"
        Me.fldPerBooking.OutputFormat = resources.GetString("fldPerBooking.OutputFormat")
        Me.fldPerBooking.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.fldPerBooking.Text = Nothing
        Me.fldPerBooking.Top = 0.0!
        Me.fldPerBooking.Width = 0.3125!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label20.Height = 0.25!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 6.4375!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label20.Text = "%"
        Me.Label20.Top = 0.0!
        Me.Label20.Width = 0.125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.46875!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox1})
        Me.GroupHeader1.DataField = "BlockName"
        Me.GroupHeader1.GroupKeepTogether = GrapeCity.ActiveReports.SectionReportModel.GroupKeepTogether.All
        Me.GroupHeader1.Height = 0.3229167!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.TextBox1.DataField = "BlockName"
        Me.TextBox1.Height = 0.25!
        Me.TextBox1.Left = 0.25!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; color: Blue; text-decoration: underline; text-align: left; font-" & _
            "weight: bold; font-size: 12pt; font-family: Arial; vertical-align: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 2.0!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line13, Me.Line26, Me.Label22, Me.TextBox13, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.TextBox18, Me.TextBox19, Me.TextBox20, Me.TextBox21, Me.TextBox22, Me.TextBox23, Me.fldPerBlockWise, Me.Label21})
        Me.GroupFooter1.Height = 0.5729167!
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
        Me.Line13.Left = 0.1875!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.125!
        Me.Line13.Width = 10.5!
        Me.Line13.X1 = 10.6875!
        Me.Line13.X2 = 0.1875!
        Me.Line13.Y1 = 0.125!
        Me.Line13.Y2 = 0.125!
        '
        'Line26
        '
        Me.Line26.Border.BottomColor = System.Drawing.Color.Black
        Me.Line26.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.LeftColor = System.Drawing.Color.Black
        Me.Line26.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.RightColor = System.Drawing.Color.Black
        Me.Line26.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.TopColor = System.Drawing.Color.Black
        Me.Line26.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line26.Height = 0.0!
        Me.Line26.Left = 0.1875!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.5!
        Me.Line26.Width = 10.5!
        Me.Line26.X1 = 10.6875!
        Me.Line26.X2 = 0.1875!
        Me.Line26.Y1 = 0.5!
        Me.Line26.Y2 = 0.5!
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
        Me.Label22.Style = "color: Blue; ddo-char-set: 0; text-align: justify; font-weight: bold; font-size: " & _
            "8.25pt; font-family: Arial Narrow; vertical-align: middle; "
        Me.Label22.Text = "Block Wise Total"
        Me.Label22.Top = 0.1875!
        Me.Label22.Width = 1.4375!
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
        Me.TextBox13.DataField = "TotalReserveAmount"
        Me.TextBox13.Height = 0.25!
        Me.TextBox13.Left = 9.625!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox13.SummaryGroup = "GroupHeader1"
        Me.TextBox13.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox13.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox13.Text = Nothing
        Me.TextBox13.Top = 0.1875!
        Me.TextBox13.Width = 1.0!
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
        Me.TextBox14.DataField = "ReserveDiscount"
        Me.TextBox14.Height = 0.25!
        Me.TextBox14.Left = 8.9375!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox14.SummaryGroup = "GroupHeader1"
        Me.TextBox14.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox14.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0.1875!
        Me.TextBox14.Width = 0.625!
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
        Me.TextBox15.DataField = "ReserveExtraCharges"
        Me.TextBox15.Height = 0.25!
        Me.TextBox15.Left = 8.25!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox15.SummaryGroup = "GroupHeader1"
        Me.TextBox15.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox15.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.1875!
        Me.TextBox15.Width = 0.625!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox16.DataField = "ReserveLoanAmount"
        Me.TextBox16.Height = 0.25!
        Me.TextBox16.Left = 7.4375!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox16.SummaryGroup = "GroupHeader1"
        Me.TextBox16.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox16.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.1875!
        Me.TextBox16.Width = 0.8125!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox17.DataField = "ReserveCashAmount"
        Me.TextBox17.Height = 0.25!
        Me.TextBox17.Left = 6.625!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox17.SummaryGroup = "GroupHeader1"
        Me.TextBox17.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox17.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.1875!
        Me.TextBox17.Width = 0.8125!
        '
        'TextBox18
        '
        Me.TextBox18.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox18.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox18.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox18.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox18.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox18.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox18.DataField = "Booked"
        Me.TextBox18.Height = 0.25!
        Me.TextBox18.Left = 5.5625!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.TextBox18.SummaryGroup = "GroupHeader1"
        Me.TextBox18.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox18.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0.1875!
        Me.TextBox18.Width = 0.4375!
        '
        'TextBox19
        '
        Me.TextBox19.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox19.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox19.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox19.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox19.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox19.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox19.DataField = "TotalAmount"
        Me.TextBox19.Height = 0.25!
        Me.TextBox19.Left = 4.6875!
        Me.TextBox19.Name = "TextBox19"
        Me.TextBox19.OutputFormat = resources.GetString("TextBox19.OutputFormat")
        Me.TextBox19.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox19.SummaryGroup = "GroupHeader1"
        Me.TextBox19.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox19.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox19.Text = Nothing
        Me.TextBox19.Top = 0.1875!
        Me.TextBox19.Width = 0.8125!
        '
        'TextBox20
        '
        Me.TextBox20.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox20.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox20.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox20.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox20.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox20.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox20.DataField = "TotalExtraCharges"
        Me.TextBox20.Height = 0.25!
        Me.TextBox20.Left = 3.875!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.OutputFormat = resources.GetString("TextBox20.OutputFormat")
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox20.SummaryGroup = "GroupHeader1"
        Me.TextBox20.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox20.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.1875!
        Me.TextBox20.Width = 0.8125!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox21.DataField = "LoanAmount"
        Me.TextBox21.Height = 0.25!
        Me.TextBox21.Left = 3.0625!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.OutputFormat = resources.GetString("TextBox21.OutputFormat")
        Me.TextBox21.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox21.SummaryGroup = "GroupHeader1"
        Me.TextBox21.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox21.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 0.1875!
        Me.TextBox21.Width = 0.8125!
        '
        'TextBox22
        '
        Me.TextBox22.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox22.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox22.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox22.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox22.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox22.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox22.DataField = "CashAmount"
        Me.TextBox22.Height = 0.25!
        Me.TextBox22.Left = 2.25!
        Me.TextBox22.Name = "TextBox22"
        Me.TextBox22.OutputFormat = resources.GetString("TextBox22.OutputFormat")
        Me.TextBox22.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox22.SummaryGroup = "GroupHeader1"
        Me.TextBox22.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox22.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox22.Text = Nothing
        Me.TextBox22.Top = 0.1875!
        Me.TextBox22.Width = 0.8125!
        '
        'TextBox23
        '
        Me.TextBox23.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox23.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox23.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox23.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox23.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox23.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox23.DataField = "Unit"
        Me.TextBox23.Height = 0.25!
        Me.TextBox23.Left = 1.8125!
        Me.TextBox23.Name = "TextBox23"
        Me.TextBox23.OutputFormat = resources.GetString("TextBox23.OutputFormat")
        Me.TextBox23.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.TextBox23.SummaryGroup = "GroupHeader1"
        Me.TextBox23.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox23.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox23.Text = Nothing
        Me.TextBox23.Top = 0.1875!
        Me.TextBox23.Width = 0.375!
        '
        'fldPerBlockWise
        '
        Me.fldPerBlockWise.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPerBlockWise.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBlockWise.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPerBlockWise.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBlockWise.Border.RightColor = System.Drawing.Color.Black
        Me.fldPerBlockWise.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBlockWise.Border.TopColor = System.Drawing.Color.Black
        Me.fldPerBlockWise.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPerBlockWise.DataField = "Booked"
        Me.fldPerBlockWise.Height = 0.25!
        Me.fldPerBlockWise.Left = 6.125!
        Me.fldPerBlockWise.Name = "fldPerBlockWise"
        Me.fldPerBlockWise.OutputFormat = resources.GetString("fldPerBlockWise.OutputFormat")
        Me.fldPerBlockWise.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.fldPerBlockWise.SummaryGroup = "GroupHeader1"
        Me.fldPerBlockWise.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.fldPerBlockWise.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.fldPerBlockWise.Text = Nothing
        Me.fldPerBlockWise.Top = 0.1875!
        Me.fldPerBlockWise.Width = 0.3125!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.Black
        Me.Label21.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.LeftColor = System.Drawing.Color.Black
        Me.Label21.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.RightColor = System.Drawing.Color.Black
        Me.Label21.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.TopColor = System.Drawing.Color.Black
        Me.Label21.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label21.Height = 0.25!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 6.4375!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label21.Text = "%"
        Me.Label21.Top = 0.1875!
        Me.Label21.Width = 0.125!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line2, Me.Line17, Me.Label17, Me.TextBox24, Me.TextBox25, Me.TextBox26, Me.TextBox27, Me.TextBox28, Me.TextBox29, Me.TextBox30, Me.TextBox31, Me.TextBox32, Me.TextBox33, Me.TextBox34, Me.fldTotalPer, Me.Label23})
        Me.ReportFooter1.Height = 0.8125!
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
            "8.25pt; font-family: Arial Narrow; vertical-align: middle; "
        Me.Label17.Text = "Grand Total"
        Me.Label17.Top = 0.25!
        Me.Label17.Width = 1.3125!
        '
        'TextBox24
        '
        Me.TextBox24.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox24.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox24.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox24.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox24.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox24.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox24.DataField = "TotalReserveAmount"
        Me.TextBox24.Height = 0.25!
        Me.TextBox24.Left = 9.625!
        Me.TextBox24.Name = "TextBox24"
        Me.TextBox24.OutputFormat = resources.GetString("TextBox24.OutputFormat")
        Me.TextBox24.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox24.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox24.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox24.Text = Nothing
        Me.TextBox24.Top = 0.25!
        Me.TextBox24.Width = 1.0625!
        '
        'TextBox25
        '
        Me.TextBox25.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox25.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox25.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox25.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox25.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox25.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox25.DataField = "ReserveDiscount"
        Me.TextBox25.Height = 0.25!
        Me.TextBox25.Left = 8.9375!
        Me.TextBox25.Name = "TextBox25"
        Me.TextBox25.OutputFormat = resources.GetString("TextBox25.OutputFormat")
        Me.TextBox25.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox25.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox25.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox25.Text = Nothing
        Me.TextBox25.Top = 0.25!
        Me.TextBox25.Width = 0.625!
        '
        'TextBox26
        '
        Me.TextBox26.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox26.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox26.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox26.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox26.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox26.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox26.DataField = "ReserveExtraCharges"
        Me.TextBox26.Height = 0.25!
        Me.TextBox26.Left = 8.25!
        Me.TextBox26.Name = "TextBox26"
        Me.TextBox26.OutputFormat = resources.GetString("TextBox26.OutputFormat")
        Me.TextBox26.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox26.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox26.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox26.Text = Nothing
        Me.TextBox26.Top = 0.25!
        Me.TextBox26.Width = 0.625!
        '
        'TextBox27
        '
        Me.TextBox27.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox27.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox27.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox27.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox27.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox27.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox27.DataField = "ReserveLoanAmount"
        Me.TextBox27.Height = 0.25!
        Me.TextBox27.Left = 7.4375!
        Me.TextBox27.Name = "TextBox27"
        Me.TextBox27.OutputFormat = resources.GetString("TextBox27.OutputFormat")
        Me.TextBox27.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox27.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox27.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox27.Text = Nothing
        Me.TextBox27.Top = 0.25!
        Me.TextBox27.Width = 0.8125!
        '
        'TextBox28
        '
        Me.TextBox28.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox28.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox28.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox28.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox28.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox28.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox28.DataField = "ReserveCashAmount"
        Me.TextBox28.Height = 0.25!
        Me.TextBox28.Left = 6.625!
        Me.TextBox28.Name = "TextBox28"
        Me.TextBox28.OutputFormat = resources.GetString("TextBox28.OutputFormat")
        Me.TextBox28.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox28.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox28.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox28.Text = Nothing
        Me.TextBox28.Top = 0.25!
        Me.TextBox28.Width = 0.8125!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox29.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox29.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox29.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox29.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox29.DataField = "Booked"
        Me.TextBox29.Height = 0.25!
        Me.TextBox29.Left = 5.5!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.TextBox29.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox29.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 0.25!
        Me.TextBox29.Width = 0.4375!
        '
        'TextBox30
        '
        Me.TextBox30.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox30.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox30.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox30.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox30.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox30.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox30.DataField = "TotalAmount"
        Me.TextBox30.Height = 0.25!
        Me.TextBox30.Left = 4.625!
        Me.TextBox30.Name = "TextBox30"
        Me.TextBox30.OutputFormat = resources.GetString("TextBox30.OutputFormat")
        Me.TextBox30.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox30.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox30.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox30.Text = Nothing
        Me.TextBox30.Top = 0.25!
        Me.TextBox30.Width = 0.8125!
        '
        'TextBox31
        '
        Me.TextBox31.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox31.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox31.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox31.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox31.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox31.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox31.DataField = "TotalExtraCharges"
        Me.TextBox31.Height = 0.25!
        Me.TextBox31.Left = 3.8125!
        Me.TextBox31.Name = "TextBox31"
        Me.TextBox31.OutputFormat = resources.GetString("TextBox31.OutputFormat")
        Me.TextBox31.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox31.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox31.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox31.Text = Nothing
        Me.TextBox31.Top = 0.25!
        Me.TextBox31.Width = 0.8125!
        '
        'TextBox32
        '
        Me.TextBox32.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox32.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox32.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox32.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox32.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox32.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox32.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox32.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox32.DataField = "LoanAmount"
        Me.TextBox32.Height = 0.25!
        Me.TextBox32.Left = 3.0!
        Me.TextBox32.Name = "TextBox32"
        Me.TextBox32.OutputFormat = resources.GetString("TextBox32.OutputFormat")
        Me.TextBox32.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox32.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox32.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox32.Text = Nothing
        Me.TextBox32.Top = 0.25!
        Me.TextBox32.Width = 0.8125!
        '
        'TextBox33
        '
        Me.TextBox33.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox33.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox33.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox33.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox33.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox33.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox33.DataField = "CashAmount"
        Me.TextBox33.Height = 0.25!
        Me.TextBox33.Left = 2.1875!
        Me.TextBox33.Name = "TextBox33"
        Me.TextBox33.OutputFormat = resources.GetString("TextBox33.OutputFormat")
        Me.TextBox33.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Arial Narrow;" & _
            " vertical-align: middle; "
        Me.TextBox33.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox33.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox33.Text = Nothing
        Me.TextBox33.Top = 0.25!
        Me.TextBox33.Width = 0.8125!
        '
        'TextBox34
        '
        Me.TextBox34.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox34.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox34.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox34.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox34.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox34.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.TextBox34.DataField = "Unit"
        Me.TextBox34.Height = 0.25!
        Me.TextBox34.Left = 1.8125!
        Me.TextBox34.Name = "TextBox34"
        Me.TextBox34.OutputFormat = resources.GetString("TextBox34.OutputFormat")
        Me.TextBox34.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.TextBox34.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox34.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.TextBox34.Text = Nothing
        Me.TextBox34.Top = 0.25!
        Me.TextBox34.Width = 0.375!
        '
        'fldTotalPer
        '
        Me.fldTotalPer.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTotalPer.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalPer.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTotalPer.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalPer.Border.RightColor = System.Drawing.Color.Black
        Me.fldTotalPer.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalPer.Border.TopColor = System.Drawing.Color.Black
        Me.fldTotalPer.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalPer.DataField = "Booked"
        Me.fldTotalPer.Height = 0.25!
        Me.fldTotalPer.Left = 6.125!
        Me.fldTotalPer.Name = "fldTotalPer"
        Me.fldTotalPer.OutputFormat = resources.GetString("fldTotalPer.OutputFormat")
        Me.fldTotalPer.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Arial Narrow" & _
            "; vertical-align: middle; "
        Me.fldTotalPer.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.fldTotalPer.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.GrandTotal
        Me.fldTotalPer.Text = Nothing
        Me.fldTotalPer.Top = 0.25!
        Me.fldTotalPer.Width = 0.3125!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = System.Drawing.Color.Black
        Me.Label23.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.LeftColor = System.Drawing.Color.Black
        Me.Label23.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.RightColor = System.Drawing.Color.Black
        Me.Label23.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.TopColor = System.Drawing.Color.Black
        Me.Label23.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label23.Height = 0.25!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 6.4375!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial Narrow; vertical-align: middle; "
        Me.Label23.Text = "%"
        Me.Label23.Top = 0.25!
        Me.Label23.Width = 0.125!
        '
        'rptInventorySummaryReport
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
        Me.PrintWidth = 10.72917!
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
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPerBooking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPerBlockWise, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTotalPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Line25 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line26 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents fldChequeDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
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
    Friend WithEvents TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox17 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox18 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox19 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox20 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox21 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox22 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox23 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox24 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox25 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox26 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox27 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox28 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox29 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox30 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox31 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox32 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox33 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox34 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Friend WithEvents Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Friend WithEvents Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPerBooking As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldPerBlockWise As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldTotalPer As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label23 As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
