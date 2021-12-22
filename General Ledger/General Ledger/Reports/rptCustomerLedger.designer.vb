<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptCustomerLedger
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
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
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader()
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter()
        Me.GroupHeader2 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupFooter2 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.GroupHeader3 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox7 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.GroupFooter3 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.GroupHeader4 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.GroupFooter4 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.fldCompany.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldCompany.Height = 0.4375!
        Me.fldCompany.Left = 0.1875!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "font-size: 18pt; font-weight: bold; text-align: center; vertical-align: middle; d" &
    "do-char-set: 0"
        Me.fldCompany.Text = "Company"
        Me.fldCompany.Top = 0.3125!
        Me.fldCompany.Width = 7.8085!
        '
        'fldTitle
        '
        Me.fldTitle.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldTitle.Height = 0.25!
        Me.fldTitle.Left = 0.1875!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "font-size: 14.25pt; font-weight: bold; text-align: center; vertical-align: middle" &
    "; ddo-char-set: 0"
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.75!
        Me.fldTitle.Width = 7.8085!
        '
        'Detail1
        '
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line24, Me.TextBox9, Me.TextBox2, Me.TextBox3, Me.TextBox5, Me.TextBox8, Me.TextBox1, Me.TextBox10})
        Me.Detail1.Height = 0.2270834!
        Me.Detail1.Name = "Detail1"
        '
        'Line24
        '
        Me.Line24.Height = 0!
        Me.Line24.Left = 0.187!
        Me.Line24.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0.202!
        Me.Line24.Width = 10.4375!
        Me.Line24.X1 = 0.187!
        Me.Line24.X2 = 10.6245!
        Me.Line24.Y1 = 0.202!
        Me.Line24.Y2 = 0.202!
        '
        'TextBox9
        '
        Me.TextBox9.DataField = "RefNo"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 0.1875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-size: 8.25pt"
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 0!
        Me.TextBox9.Width = 1.0625!
        '
        'TextBox2
        '
        Me.TextBox2.DataField = "RefDate"
        Me.TextBox2.Height = 0.1875!
        Me.TextBox2.Left = 1.265!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = "dd-MMM-yyyy"
        Me.TextBox2.Style = "font-size: 8.25pt"
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 0.8699999!
        '
        'TextBox3
        '
        Me.TextBox3.DataField = "DueAmount"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 4.425999!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = "###,###,##0"
        Me.TextBox3.Style = "font-size: 8.25pt; text-align: right"
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 1.213!
        '
        'TextBox5
        '
        Me.TextBox5.DataField = "ReceiveAmount"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 5.657!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = "###,###,##0"
        Me.TextBox5.Style = "font-size: 8.25pt; text-align: right"
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0!
        Me.TextBox5.Width = 1.141!
        '
        'TextBox8
        '
        Me.TextBox8.DataField = "Balance"
        Me.TextBox8.Height = 0.1875!
        Me.TextBox8.Left = 6.809!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = "#,##0;(#,##0)"
        Me.TextBox8.Style = "font-size: 8.25pt; text-align: right"
        Me.TextBox8.SummaryGroup = "GroupHeader4"
        Me.TextBox8.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox8.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 1.205!
        '
        'TextBox1
        '
        Me.TextBox1.DataField = "TotalRevenue"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 2.144999!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = "###,###,##0"
        Me.TextBox1.Style = "font-size: 8.25pt"
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0!
        Me.TextBox1.Width = 1.33!
        '
        'TextBox10
        '
        Me.TextBox10.DataField = "Installment"
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 3.486!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = "###,###,##0"
        Me.TextBox10.Style = "font-size: 8.25pt"
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0!
        Me.TextBox10.Width = 0.9290004!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label4, Me.TextBox4})
        Me.GroupHeader1.DataField = "Project"
        Me.GroupHeader1.Height = 0.2833333!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Label4
        '
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.187!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "font-family: Calibri; font-size: 10.2pt; font-weight: bold; text-align: left; tex" &
    "t-decoration: underline"
        Me.Label4.Text = "Project :"
        Me.Label4.Top = 0.045!
        Me.Label4.Width = 1.009!
        '
        'TextBox4
        '
        Me.TextBox4.DataField = "ProjectName"
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 1.261!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Style = "font-size: 9.75pt; font-weight: bold; text-decoration: underline"
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.04500001!
        Me.TextBox4.Width = 4.8245!
        '
        'Label5
        '
        Me.Label5.Height = 0.1875!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 0.162!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "font-size: 9.75pt; font-weight: bold; text-align: left; text-decoration: underlin" &
    "e"
        Me.Label5.Text = "Unit"
        Me.Label5.Top = 0.05400001!
        Me.Label5.Width = 1.033!
        '
        'Label1
        '
        Me.Label1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.176!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "font-size: 9pt; font-weight: bold; text-align: center; text-decoration: none"
        Me.Label1.Text = "Ref No."
        Me.Label1.Top = 0.395!
        Me.Label1.Width = 1.089!
        '
        'Label2
        '
        Me.Label2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Height = 0.1875!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.271833!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "font-size: 9pt; font-weight: bold; text-align: center; text-decoration: none"
        Me.Label2.Text = "Date"
        Me.Label2.Top = 0.395!
        Me.Label2.Width = 0.8699999!
        '
        'Label3
        '
        Me.Label3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.1875!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 3.4935!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "font-size: 9pt; font-weight: bold; text-align: center; text-decoration: none"
        Me.Label3.Text = "Installment"
        Me.Label3.Top = 0.395!
        Me.Label3.Width = 0.9290004!
        '
        'Label6
        '
        Me.Label6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.1875!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.433334!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "font-size: 9pt; font-weight: bold; text-align: center; text-decoration: none"
        Me.Label6.Text = "Due Amount"
        Me.Label6.Top = 0.395!
        Me.Label6.Width = 1.213!
        '
        'Label9
        '
        Me.Label9.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 5.657167!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 9pt; font-weight: bold; text-align: center; text-decoration: none"
        Me.Label9.Text = "Receive Amount"
        Me.Label9.Top = 0.395!
        Me.Label9.Width = 1.141!
        '
        'Label10
        '
        Me.Label10.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 6.809!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 9pt; font-weight: bold; text-align: center; text-decoration: none"
        Me.Label10.Text = "Balance Amount"
        Me.Label10.Top = 0.395!
        Me.Label10.Width = 1.205!
        '
        'Label11
        '
        Me.Label11.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 2.152667!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "font-size: 9pt; font-weight: bold; text-align: center; text-decoration: none"
        Me.Label11.Text = "Total Revenue"
        Me.Label11.Top = 0.395!
        Me.Label11.Width = 1.33!
        '
        'TextBox15
        '
        Me.TextBox15.DataField = "UnitNo"
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 1.236!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.Style = "font-size: 9.75pt; font-weight: bold; text-decoration: underline"
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.054!
        Me.TextBox15.Width = 1.25!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        'GroupHeader2
        '
        Me.GroupHeader2.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label7, Me.TextBox6})
        Me.GroupHeader2.DataField = "Customer"
        Me.GroupHeader2.Height = 0.3083333!
        Me.GroupHeader2.KeepTogether = True
        Me.GroupHeader2.Name = "GroupHeader2"
        Me.GroupHeader2.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Label7
        '
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 0.1700001!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "font-family: Calibri; font-size: 10.2pt; font-weight: bold; text-align: left; tex" &
    "t-decoration: underline"
        Me.Label7.Text = "Customer :"
        Me.Label7.Top = 0.04!
        Me.Label7.Width = 1.049!
        '
        'TextBox6
        '
        Me.TextBox6.DataField = "CustomerName"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 1.244!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "font-size: 9.75pt; font-weight: bold; text-decoration: underline"
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.04000001!
        Me.TextBox6.Width = 4.8245!
        '
        'GroupFooter2
        '
        Me.GroupFooter2.Height = 0!
        Me.GroupFooter2.Name = "GroupFooter2"
        Me.GroupFooter2.NewPage = GrapeCity.ActiveReports.SectionReportModel.NewPage.Before
        '
        'GroupHeader3
        '
        Me.GroupHeader3.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label8, Me.TextBox7})
        Me.GroupHeader3.DataField = "UnitType"
        Me.GroupHeader3.KeepTogether = True
        Me.GroupHeader3.Name = "GroupHeader3"
        Me.GroupHeader3.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'Label8
        '
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 0.162!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-family: Calibri; font-size: 10.2pt; font-weight: bold; text-align: left; tex" &
    "t-decoration: underline"
        Me.Label8.Text = "Unit Type :"
        Me.Label8.Top = -7.450581E-9!
        Me.Label8.Width = 1.033!
        '
        'TextBox7
        '
        Me.TextBox7.DataField = "UnitTypeName"
        Me.TextBox7.Height = 0.1875!
        Me.TextBox7.Left = 1.236!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "font-size: 9.75pt; font-weight: bold; text-decoration: underline"
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0!
        Me.TextBox7.Width = 4.8245!
        '
        'GroupFooter3
        '
        Me.GroupFooter3.Height = 0!
        Me.GroupFooter3.Name = "GroupFooter3"
        '
        'GroupHeader4
        '
        Me.GroupHeader4.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label5, Me.Label1, Me.Label2, Me.Label3, Me.Label6, Me.Label9, Me.Label10, Me.Label11, Me.TextBox15})
        Me.GroupHeader4.DataField = "Unit"
        Me.GroupHeader4.Height = 0.5916668!
        Me.GroupHeader4.KeepTogether = True
        Me.GroupHeader4.Name = "GroupHeader4"
        Me.GroupHeader4.RepeatStyle = GrapeCity.ActiveReports.SectionReportModel.RepeatStyle.OnPage
        '
        'GroupFooter4
        '
        Me.GroupFooter4.Height = 0!
        Me.GroupFooter4.Name = "GroupFooter4"
        '
        'rptCustomerLedger
        '
        Me.PageSettings.Collate = GrapeCity.ActiveReports.PageSettings.PrinterCollate.DontCollate
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Duplex = System.Drawing.Printing.Duplex.Simplex
        Me.PageSettings.Margins.Bottom = 0!
        Me.PageSettings.Margins.Left = 0!
        Me.PageSettings.Margins.Right = 0!
        Me.PageSettings.Margins.Top = 0!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 8.1375!
        Me.Sections.Add(Me.ReportHeader1)
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.GroupHeader2)
        Me.Sections.Add(Me.GroupHeader3)
        Me.Sections.Add(Me.GroupHeader4)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter4)
        Me.Sections.Add(Me.GroupFooter3)
        Me.Sections.Add(Me.GroupFooter2)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.Sections.Add(Me.ReportFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ddo-char-set: 204", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ddo-char-set: 204", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ddo-char-set: 204", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold", "Heading3", "Normal"))
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents fldCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Friend WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Friend WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
    Friend WithEvents Line24 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupHeader2 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupFooter2 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents GroupHeader3 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox7 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Private WithEvents GroupFooter3 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Private WithEvents GroupHeader4 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Private WithEvents GroupFooter4 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
End Class
