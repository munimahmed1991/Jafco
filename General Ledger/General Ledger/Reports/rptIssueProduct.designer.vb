Imports GrapeCity.ActiveReports
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class rptIssueProduct
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptIssueProduct))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader()
        Me.fldTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.fldCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail()
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.fldRecQty = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter()
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.fldDivision = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label28 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label31 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox18 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.fldUser = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label12 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label36 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox20 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.fldDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label37 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label38 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader()
        Me.Shape2 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label18 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label19 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox15 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox16 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox17 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Shape1 = New GrapeCity.ActiveReports.SectionReportModel.Shape()
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label25 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label32 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label34 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label20 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter()
        Me.fldSignature1 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.fldSignature2 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.fldPreparedBy = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        Me.Label33 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line()
        Me.Label21 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.Label22 = New GrapeCity.ActiveReports.SectionReportModel.Label()
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldRecQty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldUser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPreparedBy, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldTitle, Me.fldCompany})
        Me.PageHeader1.Height = 0.875!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.fldTitle.ClassName = "Heading1"
        Me.fldTitle.Height = 0.25!
        Me.fldTitle.Left = 0.125!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "color: background; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 14.25pt; font-family: Arial; text-decoration: none; vertical-align: middle;" &
    " "
        Me.fldTitle.Text = "title"
        Me.fldTitle.Top = 0.5625!
        Me.fldTitle.Width = 7.75!
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
        Me.fldCompany.ClassName = "Heading1"
        Me.fldCompany.Height = 0.3125!
        Me.fldCompany.Left = 0.125!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "color: background; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 15.75pt; font-family: Arial; text-decoration: underline; vertical-align: mi" &
    "ddle; "
        Me.fldCompany.Text = "Comapny"
        Me.fldCompany.Top = 0.25!
        Me.fldCompany.Width = 7.75!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line12, Me.fldRecQty, Me.TextBox2, Me.TextBox3, Me.TextBox8})
        Me.Detail1.Height = 0.3229167!
        Me.Detail1.Name = "Detail1"
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
        Me.Line12.Left = 0.125!
        Me.Line12.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.3125!
        Me.Line12.Width = 7.75!
        Me.Line12.X1 = 0.125!
        Me.Line12.X2 = 7.875!
        Me.Line12.Y1 = 0.3125!
        Me.Line12.Y2 = 0.3125!
        '
        'fldRecQty
        '
        Me.fldRecQty.Border.BottomColor = System.Drawing.Color.Black
        Me.fldRecQty.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRecQty.Border.LeftColor = System.Drawing.Color.Black
        Me.fldRecQty.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRecQty.Border.RightColor = System.Drawing.Color.Black
        Me.fldRecQty.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRecQty.Border.TopColor = System.Drawing.Color.Black
        Me.fldRecQty.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldRecQty.CanGrow = False
        Me.fldRecQty.DataField = "UoM"
        Me.fldRecQty.Height = 0.3125!
        Me.fldRecQty.Left = 6.375!
        Me.fldRecQty.Name = "fldRecQty"
        Me.fldRecQty.OutputFormat = resources.GetString("fldRecQty.OutputFormat")
        Me.fldRecQty.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Arial; vertical" &
    "-align: middle; "
        Me.fldRecQty.Text = Nothing
        Me.fldRecQty.Top = 0!
        Me.fldRecQty.Width = 0.625!
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
        Me.TextBox2.CanGrow = False
        Me.TextBox2.DataField = "ProductName"
        Me.TextBox2.Height = 0.3125!
        Me.TextBox2.Left = 0.125!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0!
        Me.TextBox2.Width = 6.25!
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
        Me.TextBox3.CanGrow = False
        Me.TextBox3.DataField = "Qty"
        Me.TextBox3.Height = 0.3125!
        Me.TextBox3.Left = 7.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Arial; vertical-" &
    "align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0!
        Me.TextBox3.Width = 0.875!
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
        Me.TextBox8.CanGrow = False
        Me.TextBox8.DataField = "ShortQty"
        Me.TextBox8.Height = 0.3125!
        Me.TextBox8.Left = 45.375!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 0; text-align: right; font-size: 9pt; font-family: Arial; vertical-" &
    "align: middle; "
        Me.TextBox8.Text = Nothing
        Me.TextBox8.Top = 0!
        Me.TextBox8.Width = 0.8125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line9, Me.fldDivision, Me.Label28, Me.Label31, Me.TextBox18, Me.Label7, Me.Label10, Me.fldUser, Me.Label12, Me.Label13, Me.Label36, Me.TextBox20, Me.fldDate, Me.Label37, Me.Label38})
        Me.PageFooter1.Height = 0.5!
        Me.PageFooter1.Name = "PageFooter1"
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
        Me.Line9.Height = 0!
        Me.Line9.Left = 0.125!
        Me.Line9.LineStyle = GrapeCity.ActiveReports.SectionReportModel.LineStyle.Dash
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0!
        Me.Line9.Width = 7.6875!
        Me.Line9.X1 = 0.125!
        Me.Line9.X2 = 7.8125!
        Me.Line9.Y1 = 0!
        Me.Line9.Y2 = 0!
        '
        'fldDivision
        '
        Me.fldDivision.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDivision.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDivision.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDivision.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDivision.Border.RightColor = System.Drawing.Color.Black
        Me.fldDivision.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDivision.Border.TopColor = System.Drawing.Color.Black
        Me.fldDivision.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDivision.CanGrow = False
        Me.fldDivision.Height = 0.1875!
        Me.fldDivision.Left = 4.75!
        Me.fldDivision.Name = "fldDivision"
        Me.fldDivision.OutputFormat = resources.GetString("fldDivision.OutputFormat")
        Me.fldDivision.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Microsoft Sans Se" &
    "rif; vertical-align: middle; "
        Me.fldDivision.Text = Nothing
        Me.fldDivision.Top = 0.0625!
        Me.fldDivision.Width = 1.25!
        '
        'Label28
        '
        Me.Label28.Border.BottomColor = System.Drawing.Color.Black
        Me.Label28.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.LeftColor = System.Drawing.Color.Black
        Me.Label28.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.RightColor = System.Drawing.Color.Black
        Me.Label28.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.TopColor = System.Drawing.Color.Black
        Me.Label28.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label28.Height = 0.1875!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 3.8125!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label28.Text = "Division"
        Me.Label28.Top = 0.0625!
        Me.Label28.Width = 0.75!
        '
        'Label31
        '
        Me.Label31.Border.BottomColor = System.Drawing.Color.Black
        Me.Label31.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.LeftColor = System.Drawing.Color.Black
        Me.Label31.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.RightColor = System.Drawing.Color.Black
        Me.Label31.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.TopColor = System.Drawing.Color.Black
        Me.Label31.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label31.Height = 0.1875!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 4.5625!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label31.Text = ":"
        Me.Label31.Top = 0.0625!
        Me.Label31.Width = 0.125!
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
        Me.TextBox18.CanGrow = False
        Me.TextBox18.Height = 0.1875!
        Me.TextBox18.Left = 6.9375!
        Me.TextBox18.Name = "TextBox18"
        Me.TextBox18.OutputFormat = resources.GetString("TextBox18.OutputFormat")
        Me.TextBox18.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Microsoft Sans " &
    "Serif; vertical-align: middle; "
        Me.TextBox18.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.All
        Me.TextBox18.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.TextBox18.Text = Nothing
        Me.TextBox18.Top = 0.0625!
        Me.TextBox18.Width = 0.3125!
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
        Me.Label7.Height = 0.1875!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.0625!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label7.Text = "Page #"
        Me.Label7.Top = 0.0625!
        Me.Label7.Width = 0.6875!
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
        Me.Label10.Left = 6.75!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label10.Text = ":"
        Me.Label10.Top = 0.0625!
        Me.Label10.Width = 0.125!
        '
        'fldUser
        '
        Me.fldUser.Border.BottomColor = System.Drawing.Color.Black
        Me.fldUser.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUser.Border.LeftColor = System.Drawing.Color.Black
        Me.fldUser.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUser.Border.RightColor = System.Drawing.Color.Black
        Me.fldUser.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUser.Border.TopColor = System.Drawing.Color.Black
        Me.fldUser.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUser.CanGrow = False
        Me.fldUser.Height = 0.1875!
        Me.fldUser.Left = 2.8125!
        Me.fldUser.Name = "fldUser"
        Me.fldUser.OutputFormat = resources.GetString("fldUser.OutputFormat")
        Me.fldUser.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Microsoft Sans Se" &
    "rif; vertical-align: middle; "
        Me.fldUser.Text = Nothing
        Me.fldUser.Top = 0.0625!
        Me.fldUser.Width = 0.9375!
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
        Me.Label12.Left = 2.0625!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label12.Text = "User ID"
        Me.Label12.Top = 0.0625!
        Me.Label12.Width = 0.5625!
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
        Me.Label13.Left = 2.625!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label13.Text = ":"
        Me.Label13.Top = 0.0625!
        Me.Label13.Width = 0.125!
        '
        'Label36
        '
        Me.Label36.Border.BottomColor = System.Drawing.Color.Black
        Me.Label36.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.LeftColor = System.Drawing.Color.Black
        Me.Label36.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.RightColor = System.Drawing.Color.Black
        Me.Label36.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.TopColor = System.Drawing.Color.Black
        Me.Label36.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label36.Height = 0.1875!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 7.3125!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: normal; font" &
    "-size: 9pt; font-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label36.Text = "/"
        Me.Label36.Top = 0.0625!
        Me.Label36.Width = 0.125!
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
        Me.TextBox20.CanGrow = False
        Me.TextBox20.Height = 0.1875!
        Me.TextBox20.Left = 7.5!
        Me.TextBox20.Name = "TextBox20"
        Me.TextBox20.OutputFormat = resources.GetString("TextBox20.OutputFormat")
        Me.TextBox20.Style = "ddo-char-set: 0; text-align: center; font-size: 9pt; font-family: Microsoft Sans " &
    "Serif; vertical-align: middle; "
        Me.TextBox20.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.TextBox20.Text = Nothing
        Me.TextBox20.Top = 0.0625!
        Me.TextBox20.Width = 0.3125!
        '
        'fldDate
        '
        Me.fldDate.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDate.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDate.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDate.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDate.Border.RightColor = System.Drawing.Color.Black
        Me.fldDate.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDate.Border.TopColor = System.Drawing.Color.Black
        Me.fldDate.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldDate.CanGrow = False
        Me.fldDate.Height = 0.1875!
        Me.fldDate.Left = 0.875!
        Me.fldDate.Name = "fldDate"
        Me.fldDate.OutputFormat = resources.GetString("fldDate.OutputFormat")
        Me.fldDate.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.fldDate.Text = Nothing
        Me.fldDate.Top = 0.0625!
        Me.fldDate.Width = 1.125!
        '
        'Label37
        '
        Me.Label37.Border.BottomColor = System.Drawing.Color.Black
        Me.Label37.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.LeftColor = System.Drawing.Color.Black
        Me.Label37.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.RightColor = System.Drawing.Color.Black
        Me.Label37.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.TopColor = System.Drawing.Color.Black
        Me.Label37.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label37.Height = 0.1875!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 0.125!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label37.Text = "Print Date"
        Me.Label37.Top = 0.0625!
        Me.Label37.Width = 0.625!
        '
        'Label38
        '
        Me.Label38.Border.BottomColor = System.Drawing.Color.Black
        Me.Label38.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.LeftColor = System.Drawing.Color.Black
        Me.Label38.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.RightColor = System.Drawing.Color.Black
        Me.Label38.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.TopColor = System.Drawing.Color.Black
        Me.Label38.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label38.Height = 0.1875!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 0.75!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 11.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label38.Text = ":"
        Me.Label38.Top = 0.0625!
        Me.Label38.Width = 0.125!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Shape2, Me.Label2, Me.Label15, Me.Label5, Me.Label6, Me.Label18, Me.Label19, Me.Label8, Me.Label9, Me.TextBox14, Me.TextBox15, Me.TextBox16, Me.TextBox17, Me.Shape1, Me.Line13, Me.Line14, Me.Label25, Me.Label32, Me.Label34, Me.TextBox1, Me.Label1, Me.Label3, Me.Label4, Me.Label11, Me.TextBox5, Me.Label14, Me.Label16, Me.TextBox4, Me.TextBox6, Me.Label17, Me.Label20})
        Me.GroupHeader1.DataField = "IssNo"
        Me.GroupHeader1.Height = 2.125!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.Shape2.Height = 1.5625!
        Me.Shape2.Left = 0.125!
        Me.Shape2.Name = "Shape2"
        Me.Shape2.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!)
        Me.Shape2.Top = 0.0625!
        Me.Shape2.Width = 7.75!
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
        Me.Label2.Left = 0.1875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label2.Text = "Iss #"
        Me.Label2.Top = 0.125!
        Me.Label2.Width = 0.875!
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
        Me.Label15.Height = 0.1875!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 1.0625!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label15.Text = ":"
        Me.Label15.Top = 0.125!
        Me.Label15.Width = 0.125!
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
        Me.Label5.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label5.Text = "Department"
        Me.Label5.Top = 0.375!
        Me.Label5.Width = 0.875!
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
        Me.Label6.Left = 1.0625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label6.Text = ":"
        Me.Label6.Top = 0.375!
        Me.Label6.Width = 0.125!
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
        Me.Label18.Left = 5.6875!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label18.Text = "Iss Date"
        Me.Label18.Top = 0.125!
        Me.Label18.Width = 0.9375!
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
        Me.Label19.Left = 6.625!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label19.Text = ":"
        Me.Label19.Top = 0.125!
        Me.Label19.Width = 0.125!
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
        Me.Label8.Left = 0.1875!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label8.Text = "Tran. Type"
        Me.Label8.Top = 0.625!
        Me.Label8.Width = 0.875!
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
        Me.Label9.Left = 1.0625!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label9.Text = ":"
        Me.Label9.Top = 0.625!
        Me.Label9.Width = 0.125!
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
        Me.TextBox14.CanGrow = False
        Me.TextBox14.DataField = "IssNo"
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 1.25!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0.125!
        Me.TextBox14.Width = 1.1875!
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
        Me.TextBox15.CanGrow = False
        Me.TextBox15.DataField = "Department"
        Me.TextBox15.Height = 0.1875!
        Me.TextBox15.Left = 1.25!
        Me.TextBox15.Name = "TextBox15"
        Me.TextBox15.OutputFormat = resources.GetString("TextBox15.OutputFormat")
        Me.TextBox15.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox15.Text = Nothing
        Me.TextBox15.Top = 0.375!
        Me.TextBox15.Width = 3.625!
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
        Me.TextBox16.CanGrow = False
        Me.TextBox16.DataField = "TransactionType"
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 1.25!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 0.625!
        Me.TextBox16.Width = 3.625!
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
        Me.TextBox17.CanGrow = False
        Me.TextBox17.DataField = "IssDate"
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 6.75!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 0.125!
        Me.TextBox17.Width = 1.0625!
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
        Me.Shape1.Height = 0.4375!
        Me.Shape1.Left = 0.125!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = New GrapeCity.ActiveReports.Controls.CornersRadius(9.999999!)
        Me.Shape1.Top = 1.625!
        Me.Shape1.Width = 7.75!
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
        Me.Line13.Height = 0.4375!
        Me.Line13.Left = 6.375!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 1.625!
        Me.Line13.Width = 0!
        Me.Line13.X1 = 6.375!
        Me.Line13.X2 = 6.375!
        Me.Line13.Y1 = 1.625!
        Me.Line13.Y2 = 2.0625!
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
        Me.Line14.Left = 7.0!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 1.625!
        Me.Line14.Width = 0!
        Me.Line14.X1 = 7.0!
        Me.Line14.X2 = 7.0!
        Me.Line14.Y1 = 1.625!
        Me.Line14.Y2 = 2.0625!
        '
        'Label25
        '
        Me.Label25.Border.BottomColor = System.Drawing.Color.Black
        Me.Label25.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.LeftColor = System.Drawing.Color.Black
        Me.Label25.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.RightColor = System.Drawing.Color.Black
        Me.Label25.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.TopColor = System.Drawing.Color.Black
        Me.Label25.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label25.Height = 0.1875!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 0.1875!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label25.Text = "Product"
        Me.Label25.Top = 1.75!
        Me.Label25.Width = 6.125!
        '
        'Label32
        '
        Me.Label32.Border.BottomColor = System.Drawing.Color.Black
        Me.Label32.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.LeftColor = System.Drawing.Color.Black
        Me.Label32.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.RightColor = System.Drawing.Color.Black
        Me.Label32.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.TopColor = System.Drawing.Color.Black
        Me.Label32.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label32.Height = 0.3125!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 6.4375!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label32.Text = "UoM"
        Me.Label32.Top = 1.6875!
        Me.Label32.Width = 0.5!
        '
        'Label34
        '
        Me.Label34.Border.BottomColor = System.Drawing.Color.Black
        Me.Label34.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.LeftColor = System.Drawing.Color.Black
        Me.Label34.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.RightColor = System.Drawing.Color.Black
        Me.Label34.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.TopColor = System.Drawing.Color.Black
        Me.Label34.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label34.Height = 0.3125!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 7.0625!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label34.Text = "Qty"
        Me.Label34.Top = 1.6875!
        Me.Label34.Width = 0.75!
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
        Me.TextBox1.CanGrow = False
        Me.TextBox1.DataField = "Description"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 1.25!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.875!
        Me.TextBox1.Width = 3.625!
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
        Me.Label1.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label1.Text = "Description"
        Me.Label1.Top = 0.875!
        Me.Label1.Width = 0.875!
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
        Me.Label3.Left = 1.0625!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label3.Text = ":"
        Me.Label3.Top = 0.875!
        Me.Label3.Width = 0.125!
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
        Me.Label4.Height = 0.1875!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 0.1875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label4.Text = "Asset Code"
        Me.Label4.Top = 1.125!
        Me.Label4.Width = 0.875!
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
        Me.Label11.Left = 1.0625!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label11.Text = ":"
        Me.Label11.Top = 1.125!
        Me.Label11.Width = 0.125!
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
        Me.TextBox5.CanGrow = False
        Me.TextBox5.DataField = "AssetCode"
        Me.TextBox5.Height = 0.1875!
        Me.TextBox5.Left = 1.25!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 1.125!
        Me.TextBox5.Width = 3.625!
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
        Me.Label14.Left = 0.1875!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label14.Text = "PC #"
        Me.Label14.Top = 1.375!
        Me.Label14.Width = 0.875!
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
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 1.0625!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label16.Text = ":"
        Me.Label16.Top = 1.375!
        Me.Label16.Width = 0.125!
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
        Me.TextBox4.CanGrow = False
        Me.TextBox4.DataField = "ProductionCardNo"
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 1.25!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 1.375!
        Me.TextBox4.Width = 1.125!
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
        Me.TextBox6.CanGrow = False
        Me.TextBox6.DataField = "DesignNo"
        Me.TextBox6.Height = 0.1875!
        Me.TextBox6.Left = 3.75!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: left; font-size: 9pt; font-family: Arial; vertical-a" &
    "lign: middle; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 1.375!
        Me.TextBox6.Width = 1.125!
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
        Me.Label17.Height = 0.1875!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 3.5625!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: buttontext; ddo-char-set: 0; text-align: center; font-weight: bold; font-s" &
    "ize: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label17.Text = ":"
        Me.Label17.Top = 1.375!
        Me.Label17.Width = 0.125!
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
        Me.Label20.Height = 0.1875!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 2.6875!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "color: buttontext; ddo-char-set: 0; text-align: left; font-weight: bold; font-siz" &
    "e: 9pt; font-family: Arial; vertical-align: middle; "
        Me.Label20.Text = "Design #"
        Me.Label20.Top = 1.375!
        Me.Label20.Width = 0.875!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldSignature1, Me.Line21, Me.fldSignature2, Me.fldPreparedBy, Me.Label33, Me.Line1, Me.Line2, Me.Label21, Me.Label22, Me.TextBox11})
        Me.GroupFooter1.Height = 1.135417!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'fldSignature1
        '
        Me.fldSignature1.Border.BottomColor = System.Drawing.Color.Black
        Me.fldSignature1.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature1.Border.LeftColor = System.Drawing.Color.Black
        Me.fldSignature1.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature1.Border.RightColor = System.Drawing.Color.Black
        Me.fldSignature1.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature1.Border.TopColor = System.Drawing.Color.Black
        Me.fldSignature1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature1.Height = 0.1875!
        Me.fldSignature1.HyperLink = Nothing
        Me.fldSignature1.Left = 0.125!
        Me.fldSignature1.Name = "fldSignature1"
        Me.fldSignature1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Arial; vertical-align: middle; "
        Me.fldSignature1.Text = "Prepared By"
        Me.fldSignature1.Top = 0.9375!
        Me.fldSignature1.Width = 2.25!
        '
        'Line21
        '
        Me.Line21.Border.BottomColor = System.Drawing.Color.Black
        Me.Line21.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.LeftColor = System.Drawing.Color.Black
        Me.Line21.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.RightColor = System.Drawing.Color.Black
        Me.Line21.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line21.Border.TopColor = System.Drawing.Color.Black
        Me.Line21.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line21.Height = 0!
        Me.Line21.Left = 0.125!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.9375!
        Me.Line21.Width = 2.25!
        Me.Line21.X1 = 0.125!
        Me.Line21.X2 = 2.375!
        Me.Line21.Y1 = 0.9375!
        Me.Line21.Y2 = 0.9375!
        '
        'fldSignature2
        '
        Me.fldSignature2.Border.BottomColor = System.Drawing.Color.Black
        Me.fldSignature2.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature2.Border.LeftColor = System.Drawing.Color.Black
        Me.fldSignature2.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature2.Border.RightColor = System.Drawing.Color.Black
        Me.fldSignature2.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature2.Border.TopColor = System.Drawing.Color.Black
        Me.fldSignature2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature2.Height = 0.1875!
        Me.fldSignature2.HyperLink = Nothing
        Me.fldSignature2.Left = 5.6875!
        Me.fldSignature2.Name = "fldSignature2"
        Me.fldSignature2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Arial; vertical-align: middle; "
        Me.fldSignature2.Text = "Received By"
        Me.fldSignature2.Top = 0.9375!
        Me.fldSignature2.Width = 2.0625!
        '
        'fldPreparedBy
        '
        Me.fldPreparedBy.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPreparedBy.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPreparedBy.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPreparedBy.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPreparedBy.Border.RightColor = System.Drawing.Color.Black
        Me.fldPreparedBy.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPreparedBy.Border.TopColor = System.Drawing.Color.Black
        Me.fldPreparedBy.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldPreparedBy.CanGrow = False
        Me.fldPreparedBy.DataField = "UserId"
        Me.fldPreparedBy.Height = 0.1875!
        Me.fldPreparedBy.Left = 0.125!
        Me.fldPreparedBy.Name = "fldPreparedBy"
        Me.fldPreparedBy.OutputFormat = resources.GetString("fldPreparedBy.OutputFormat")
        Me.fldPreparedBy.Style = "ddo-char-set: 0; text-align: center; font-size: 9.75pt; font-family: Calibri; ver" &
    "tical-align: middle; "
        Me.fldPreparedBy.Text = Nothing
        Me.fldPreparedBy.Top = 0.6875!
        Me.fldPreparedBy.Width = 2.25!
        '
        'Label33
        '
        Me.Label33.Border.BottomColor = System.Drawing.Color.Black
        Me.Label33.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.LeftColor = System.Drawing.Color.Black
        Me.Label33.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.RightColor = System.Drawing.Color.Black
        Me.Label33.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.TopColor = System.Drawing.Color.Black
        Me.Label33.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Label33.Height = 0.1875!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 3.0!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 9pt; font-fami" &
    "ly: Arial; vertical-align: middle; "
        Me.Label33.Text = "Checked By"
        Me.Label33.Top = 0.9375!
        Me.Label33.Width = 2.1875!
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
        Me.Line1.Height = 0!
        Me.Line1.Left = 3.0!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.9375!
        Me.Line1.Width = 2.1875!
        Me.Line1.X1 = 3.0!
        Me.Line1.X2 = 5.1875!
        Me.Line1.Y1 = 0.9375!
        Me.Line1.Y2 = 0.9375!
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
        Me.Line2.Height = 0!
        Me.Line2.Left = 5.6875!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.9375!
        Me.Line2.Width = 2.0625!
        Me.Line2.X1 = 5.6875!
        Me.Line2.X2 = 7.75!
        Me.Line2.Y1 = 0.9375!
        Me.Line2.Y2 = 0.9375!
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
        Me.Label21.Left = 0.125!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; vertical-align: middle; "
        Me.Label21.Text = "Remarks"
        Me.Label21.Top = 0.1875!
        Me.Label21.Width = 1.0!
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
        Me.Label22.Left = 1.125!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "ddo-char-set: 0; font-weight: bold; font-size: 9.75pt; vertical-align: middle; "
        Me.Label22.Text = " :"
        Me.Label22.Top = 0.1875!
        Me.Label22.Width = 0.125!
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
        Me.TextBox11.DataField = "Remarks"
        Me.TextBox11.Height = 0.25!
        Me.TextBox11.Left = 1.25!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "vertical-align: middle; "
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.1875!
        Me.TextBox11.Width = 6.5!
        '
        'rptIssueProduct
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Gutter = 0.1!
        Me.PageSettings.Margins.Bottom = 0.1!
        Me.PageSettings.Margins.Left = 0.1!
        Me.PageSettings.Margins.Right = 0.1!
        Me.PageSettings.Margins.Top = 0.1!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 7.927067!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" &
            "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" &
            "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldRecQty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldUser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPreparedBy, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents fldTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents fldRecQty As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label18 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label19 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldSignature1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents fldSignature2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPreparedBy As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label33 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldDivision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label28 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label31 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox18 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldUser As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label12 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label36 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox20 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label37 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label38 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label21 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label22 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Shape2 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Friend WithEvents TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox15 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox16 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox17 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Shape1 As GrapeCity.ActiveReports.SectionReportModel.Shape
    Friend WithEvents Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label25 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label32 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label34 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label20 As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
