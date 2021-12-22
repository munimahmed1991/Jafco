Imports GrapeCity.ActiveReports
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptVoucher
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptVoucher))
        Me.PageHeader1 = New GrapeCity.ActiveReports.SectionReportModel.PageHeader
        Me.fldCompany = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldTitle = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label1 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldDateTime = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label8 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldPage = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label9 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldPages = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label10 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldDivision = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldUserID = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Detail1 = New GrapeCity.ActiveReports.SectionReportModel.Detail
        Me.TextBox6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox10 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox11 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldChequeDate = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line8 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line9 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line10 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line11 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line12 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line19 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.TextBox12 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox14 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line7 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line21 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.PageFooter1 = New GrapeCity.ActiveReports.SectionReportModel.PageFooter
        Me.GroupHeader1 = New GrapeCity.ActiveReports.SectionReportModel.GroupHeader
        Me.Label2 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label4 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label5 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line3 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line4 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.fldVoucherNo = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label11 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label13 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox8 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label14 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.TextBox9 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label15 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Label16 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line5 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label3 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line1 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line18 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line6 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line20 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line2 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.lblPaidTo = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.txtPaidTo = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line23 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.GroupFooter1 = New GrapeCity.ActiveReports.SectionReportModel.GroupFooter
        Me.Line13 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.fldTotalDebit = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.TextBox13 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Line14 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line16 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Line17 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.Label6 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.fldAmountInWords = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.Label7 = New GrapeCity.ActiveReports.SectionReportModel.Label
        Me.Line15 = New GrapeCity.ActiveReports.SectionReportModel.Line
        Me.fldSignature2 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldSignature3 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldSignature4 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldSignature5 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldSignature6 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.fldSignature1 = New GrapeCity.ActiveReports.SectionReportModel.TextBox
        Me.ReportHeader1 = New GrapeCity.ActiveReports.SectionReportModel.ReportHeader
        Me.ReportFooter1 = New GrapeCity.ActiveReports.SectionReportModel.ReportFooter
        Me.Label17 = New GrapeCity.ActiveReports.SectionReportModel.Label
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldVoucherNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblPaidTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPaidTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTotalDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldAmountInWords, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSignature1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldCompany, Me.fldTitle, Me.Label1, Me.fldDateTime, Me.Label8, Me.fldPage, Me.Label9, Me.fldPages, Me.Label10, Me.fldDivision})
        Me.PageHeader1.Height = 1.28125!
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
        Me.fldCompany.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 18pt; vertical" & _
            "-align: middle; "
        Me.fldCompany.Text = "Company"
        Me.fldCompany.Top = 0.5!
        Me.fldCompany.Width = 7.75!
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
        Me.fldTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; verti" & _
            "cal-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 1.0!
        Me.fldTitle.Width = 7.75!
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
        Me.Label1.Top = 0.25!
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
        Me.fldDateTime.Top = 0.25!
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
        Me.Label8.Left = 6.1875!
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
        Me.fldPage.Left = 6.9375!
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
        Me.Label9.Left = 7.3125!
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
        Me.fldPages.Left = 7.5!
        Me.fldPages.Name = "fldPages"
        Me.fldPages.Style = "text-align: left; font-size: 8.25pt; "
        Me.fldPages.SummaryGroup = "GroupHeader1"
        Me.fldPages.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.PageCount
        Me.fldPages.Text = "Pages"
        Me.fldPages.Top = 0.0625!
        Me.fldPages.Width = 0.4375!
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
        Me.Label10.Left = 6.1875!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 8.25pt; "
        Me.Label10.Text = "Division"
        Me.Label10.Top = 0.25!
        Me.Label10.Width = 0.5!
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
        Me.fldDivision.Height = 0.1875!
        Me.fldDivision.Left = 6.9375!
        Me.fldDivision.Name = "fldDivision"
        Me.fldDivision.Style = "text-align: center; font-size: 8.25pt; "
        Me.fldDivision.Text = "Division"
        Me.fldDivision.Top = 0.25!
        Me.fldDivision.Width = 1.0!
        '
        'fldUserID
        '
        Me.fldUserID.Border.BottomColor = System.Drawing.Color.Black
        Me.fldUserID.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Border.LeftColor = System.Drawing.Color.Black
        Me.fldUserID.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Border.RightColor = System.Drawing.Color.Black
        Me.fldUserID.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Border.TopColor = System.Drawing.Color.Black
        Me.fldUserID.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Height = 0.1875!
        Me.fldUserID.Left = 0.25!
        Me.fldUserID.Name = "fldUserID"
        Me.fldUserID.Style = "text-align: center; font-size: 8pt; "
        Me.fldUserID.Text = "user"
        Me.fldUserID.Top = 0.0625!
        Me.fldUserID.Width = 1.6875!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.TextBox6, Me.TextBox5, Me.TextBox3, Me.TextBox10, Me.TextBox11, Me.TextBox1, Me.TextBox2, Me.fldChequeDate, Me.TextBox4, Me.Line8, Me.Line9, Me.Line10, Me.Line11, Me.Line12, Me.Line19, Me.TextBox12, Me.TextBox14, Me.Line7, Me.Line21})
        Me.Detail1.Height = 0.5104167!
        Me.Detail1.Name = "Detail1"
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
        Me.TextBox6.DataField = "ChequeDate"
        Me.TextBox6.Height = 0.25!
        Me.TextBox6.Left = 0.25!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox6.Text = "ChequeDate"
        Me.TextBox6.Top = 0.25!
        Me.TextBox6.Width = 0.75!
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
        Me.TextBox5.Height = 0.25!
        Me.TextBox5.Left = 0.25!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "background-color: Gainsboro; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 7.75!
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
        Me.TextBox3.DataField = "Debit"
        Me.TextBox3.Height = 0.25!
        Me.TextBox3.Left = 6.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.TextBox3.Text = "Debit"
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.9375!
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
        Me.TextBox10.DataField = "Sector"
        Me.TextBox10.Height = 0.25!
        Me.TextBox10.Left = 4.8125!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox10.Text = "Sector"
        Me.TextBox10.Top = 0.0!
        Me.TextBox10.Width = 1.1875!
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
        Me.TextBox11.DataField = "Tag"
        Me.TextBox11.Height = 0.25!
        Me.TextBox11.Left = 4.8125!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox11.Text = "Tag"
        Me.TextBox11.Top = 0.25!
        Me.TextBox11.Width = 1.1875!
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
        Me.TextBox1.Height = 0.25!
        Me.TextBox1.Left = 1.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "font-size: 6.75pt; vertical-align: middle; "
        Me.TextBox1.Text = "Description"
        Me.TextBox1.Top = 0.25!
        Me.TextBox1.Width = 2.875!
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
        Me.TextBox2.DataField = "AccountName"
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 1.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox2.Text = "AccountName"
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 2.875!
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
        Me.fldChequeDate.DataField = "ChequeNo"
        Me.fldChequeDate.Height = 0.25!
        Me.fldChequeDate.Left = 0.25!
        Me.fldChequeDate.Name = "fldChequeDate"
        Me.fldChequeDate.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.fldChequeDate.Text = "ChequeNo"
        Me.fldChequeDate.Top = 0.0!
        Me.fldChequeDate.Width = 0.75!
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
        Me.TextBox4.DataField = "Credit"
        Me.TextBox4.Height = 0.25!
        Me.TextBox4.Left = 7.0!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.TextBox4.Text = "Credit"
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.9375!
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
        Me.Line8.Left = 0.25!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.0!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 0.25!
        Me.Line8.X2 = 0.25!
        Me.Line8.Y1 = 0.0!
        Me.Line8.Y2 = 0.5625!
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
        Me.Line9.Left = 6.0!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.0!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 6.0!
        Me.Line9.X2 = 6.0!
        Me.Line9.Y1 = 0.0!
        Me.Line9.Y2 = 0.5625!
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
        Me.Line10.Left = 8.0!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.0!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 8.0!
        Me.Line10.X2 = 8.0!
        Me.Line10.Y1 = 0.0!
        Me.Line10.Y2 = 0.5625!
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
        Me.Line11.Left = 7.0!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.0!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 7.0!
        Me.Line11.X2 = 7.0!
        Me.Line11.Y1 = 0.0!
        Me.Line11.Y2 = 0.5625!
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
        Me.Line12.Left = 1.0!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.0!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 1.0!
        Me.Line12.X2 = 1.0!
        Me.Line12.Y1 = 0.0!
        Me.Line12.Y2 = 0.5625!
        '
        'Line19
        '
        Me.Line19.Border.BottomColor = System.Drawing.Color.Black
        Me.Line19.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.LeftColor = System.Drawing.Color.Black
        Me.Line19.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.RightColor = System.Drawing.Color.Black
        Me.Line19.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.TopColor = System.Drawing.Color.Black
        Me.Line19.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line19.Height = 0.5625!
        Me.Line19.Left = 3.875!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.0!
        Me.Line19.Width = 0.0!
        Me.Line19.X1 = 3.875!
        Me.Line19.X2 = 3.875!
        Me.Line19.Y1 = 0.0!
        Me.Line19.Y2 = 0.5625!
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
        Me.TextBox12.DataField = "Location"
        Me.TextBox12.Height = 0.25!
        Me.TextBox12.Left = 3.875!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox12.Text = "Location"
        Me.TextBox12.Top = 0.25!
        Me.TextBox12.Width = 0.9375!
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
        Me.TextBox14.DataField = "Project"
        Me.TextBox14.Height = 0.25!
        Me.TextBox14.Left = 3.875!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox14.Text = "Project"
        Me.TextBox14.Top = 0.0!
        Me.TextBox14.Width = 0.9375!
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
        Me.Line7.Height = 0.0!
        Me.Line7.Left = 0.25!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.0!
        Me.Line7.Width = 7.75!
        Me.Line7.X1 = 8.0!
        Me.Line7.X2 = 0.25!
        Me.Line7.Y1 = 0.0!
        Me.Line7.Y2 = 0.0!
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
        Me.Line21.Height = 0.5625!
        Me.Line21.Left = 4.8125!
        Me.Line21.LineWeight = 1.0!
        Me.Line21.Name = "Line21"
        Me.Line21.Top = 0.0!
        Me.Line21.Width = 0.0!
        Me.Line21.X1 = 4.8125!
        Me.Line21.X2 = 4.8125!
        Me.Line21.Y1 = 0.0!
        Me.Line21.Y2 = 0.5625!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Label2, Me.Label4, Me.Label5, Me.Line3, Me.Line4, Me.fldVoucherNo, Me.Label11, Me.Label13, Me.TextBox8, Me.Label14, Me.TextBox9, Me.Label15, Me.Label16, Me.Line5, Me.Label3, Me.Line1, Me.Line18, Me.Line6, Me.Line20, Me.Line2, Me.lblPaidTo, Me.txtPaidTo, Me.Line23})
        Me.GroupHeader1.DataField = "Auto"
        Me.GroupHeader1.Height = 1.072917!
        Me.GroupHeader1.Name = "GroupHeader1"
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
        Me.Label2.Height = 0.375!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 3.875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label2.Text = "Project &   Location"
        Me.Label2.Top = 0.6875!
        Me.Label2.Width = 0.9375!
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
        Me.Label4.Height = 0.375!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 6.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label4.Text = "Debit"
        Me.Label4.Top = 0.6875!
        Me.Label4.Width = 1.0!
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
        Me.Label5.Height = 0.375!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 7.0!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label5.Text = "Credit"
        Me.Label5.Top = 0.6875!
        Me.Label5.Width = 1.0!
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
        Me.Line3.Height = 0.375!
        Me.Line3.Left = 8.0!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.6875!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 8.0!
        Me.Line3.X2 = 8.0!
        Me.Line3.Y1 = 0.6875!
        Me.Line3.Y2 = 1.0625!
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
        Me.Line4.Height = 0.375!
        Me.Line4.Left = 7.0!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.6875!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 7.0!
        Me.Line4.X2 = 7.0!
        Me.Line4.Y1 = 0.6875!
        Me.Line4.Y2 = 1.0625!
        '
        'fldVoucherNo
        '
        Me.fldVoucherNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.CanGrow = False
        Me.fldVoucherNo.DataField = "VoucherNo"
        Me.fldVoucherNo.Height = 0.25!
        Me.fldVoucherNo.Left = 1.375!
        Me.fldVoucherNo.Name = "fldVoucherNo"
        Me.fldVoucherNo.OutputFormat = resources.GetString("fldVoucherNo.OutputFormat")
        Me.fldVoucherNo.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.fldVoucherNo.Text = "VoucherNo"
        Me.fldVoucherNo.Top = 0.0!
        Me.fldVoucherNo.Width = 1.6875!
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
        Me.Label11.Height = 0.25!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.25!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.Label11.Text = "Voucher No :"
        Me.Label11.Top = 0.0!
        Me.Label11.Width = 1.0!
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
        Me.Label13.Height = 0.25!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 4.5625!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.Label13.Text = "Entry Location :"
        Me.Label13.Top = 0.375!
        Me.Label13.Width = 1.0!
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
        Me.TextBox8.DataField = "EntryLocation"
        Me.TextBox8.Height = 0.25!
        Me.TextBox8.Left = 5.6875!
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.OutputFormat = resources.GetString("TextBox8.OutputFormat")
        Me.TextBox8.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox8.Text = "EntryLocation"
        Me.TextBox8.Top = 0.375!
        Me.TextBox8.Width = 2.0!
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
        Me.Label14.Height = 0.25!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 4.5625!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.Label14.Text = "Voucher Date :"
        Me.Label14.Top = 0.0!
        Me.Label14.Width = 1.0!
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
        Me.TextBox9.CanGrow = False
        Me.TextBox9.DataField = "VoucherDate"
        Me.TextBox9.Height = 0.25!
        Me.TextBox9.Left = 5.6875!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.TextBox9.Text = "VoucherDate"
        Me.TextBox9.Top = 0.0!
        Me.TextBox9.Width = 1.6875!
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
        Me.Label15.Height = 0.375!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.25!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label15.Text = "Cheq. / Inv. No. & Date"
        Me.Label15.Top = 0.6875!
        Me.Label15.Width = 0.75!
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
        Me.Label16.Height = 0.375!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 1.0!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label16.Text = "Account Name & Description"
        Me.Label16.Top = 0.6875!
        Me.Label16.Width = 2.875!
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
        Me.Line5.Height = 0.375!
        Me.Line5.Left = 1.0!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.6875!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 1.0!
        Me.Line5.X2 = 1.0!
        Me.Line5.Y1 = 0.6875!
        Me.Line5.Y2 = 1.0625!
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
        Me.Label3.Height = 0.375!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.8125!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label3.Text = "Sector & Tag"
        Me.Label3.Top = 0.6875!
        Me.Label3.Width = 1.1875!
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
        Me.Line1.Top = 0.6875!
        Me.Line1.Width = 7.75!
        Me.Line1.X1 = 8.0!
        Me.Line1.X2 = 0.25!
        Me.Line1.Y1 = 0.6875!
        Me.Line1.Y2 = 0.6875!
        '
        'Line18
        '
        Me.Line18.Border.BottomColor = System.Drawing.Color.Black
        Me.Line18.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.LeftColor = System.Drawing.Color.Black
        Me.Line18.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.RightColor = System.Drawing.Color.Black
        Me.Line18.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.TopColor = System.Drawing.Color.Black
        Me.Line18.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line18.Height = 0.375!
        Me.Line18.Left = 3.875!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.6875!
        Me.Line18.Width = 0.0!
        Me.Line18.X1 = 3.875!
        Me.Line18.X2 = 3.875!
        Me.Line18.Y1 = 0.6875!
        Me.Line18.Y2 = 1.0625!
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
        Me.Line6.Height = 0.375!
        Me.Line6.Left = 6.0!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.6875!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 6.0!
        Me.Line6.X2 = 6.0!
        Me.Line6.Y1 = 0.6875!
        Me.Line6.Y2 = 1.0625!
        '
        'Line20
        '
        Me.Line20.Border.BottomColor = System.Drawing.Color.Black
        Me.Line20.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.LeftColor = System.Drawing.Color.Black
        Me.Line20.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.RightColor = System.Drawing.Color.Black
        Me.Line20.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line20.Border.TopColor = System.Drawing.Color.Black
        Me.Line20.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.Line20.Height = 0.375!
        Me.Line20.Left = 4.8125!
        Me.Line20.LineWeight = 1.0!
        Me.Line20.Name = "Line20"
        Me.Line20.Top = 0.6875!
        Me.Line20.Width = 0.0!
        Me.Line20.X1 = 4.8125!
        Me.Line20.X2 = 4.8125!
        Me.Line20.Y1 = 0.6875!
        Me.Line20.Y2 = 1.0625!
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
        Me.Line2.Height = 0.375!
        Me.Line2.Left = 0.25!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.6875!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 0.25!
        Me.Line2.X2 = 0.25!
        Me.Line2.Y1 = 0.6875!
        Me.Line2.Y2 = 1.0625!
        '
        'lblPaidTo
        '
        Me.lblPaidTo.Border.BottomColor = System.Drawing.Color.Black
        Me.lblPaidTo.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.lblPaidTo.Border.LeftColor = System.Drawing.Color.Black
        Me.lblPaidTo.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.lblPaidTo.Border.RightColor = System.Drawing.Color.Black
        Me.lblPaidTo.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.lblPaidTo.Border.TopColor = System.Drawing.Color.Black
        Me.lblPaidTo.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.lblPaidTo.Height = 0.25!
        Me.lblPaidTo.HyperLink = Nothing
        Me.lblPaidTo.Left = 0.25!
        Me.lblPaidTo.Name = "lblPaidTo"
        Me.lblPaidTo.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.lblPaidTo.Text = "Paid To :"
        Me.lblPaidTo.Top = 0.375!
        Me.lblPaidTo.Width = 1.0!
        '
        'txtPaidTo
        '
        Me.txtPaidTo.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPaidTo.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.txtPaidTo.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPaidTo.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.txtPaidTo.Border.RightColor = System.Drawing.Color.Black
        Me.txtPaidTo.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.txtPaidTo.Border.TopColor = System.Drawing.Color.Black
        Me.txtPaidTo.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.txtPaidTo.CanGrow = False
        Me.txtPaidTo.DataField = "PaidTo"
        Me.txtPaidTo.Height = 0.25!
        Me.txtPaidTo.Left = 1.375!
        Me.txtPaidTo.Name = "txtPaidTo"
        Me.txtPaidTo.OutputFormat = resources.GetString("txtPaidTo.OutputFormat")
        Me.txtPaidTo.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.txtPaidTo.Text = "Paid To"
        Me.txtPaidTo.Top = 0.375!
        Me.txtPaidTo.Width = 3.0625!
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
        Me.Line23.Left = 0.25!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 1.0625!
        Me.Line23.Width = 7.75!
        Me.Line23.X1 = 8.0!
        Me.Line23.X2 = 0.25!
        Me.Line23.Y1 = 1.0625!
        Me.Line23.Y2 = 1.0625!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.Line13, Me.fldTotalDebit, Me.TextBox13, Me.Line14, Me.Line16, Me.Line17, Me.Label6, Me.fldAmountInWords, Me.Label7, Me.Line15})
        Me.GroupFooter1.Height = 0.6666667!
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
        Me.Line13.Width = 7.75!
        Me.Line13.X1 = 8.0!
        Me.Line13.X2 = 0.25!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.0!
        '
        'fldTotalDebit
        '
        Me.fldTotalDebit.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTotalDebit.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalDebit.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTotalDebit.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalDebit.Border.RightColor = System.Drawing.Color.Black
        Me.fldTotalDebit.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalDebit.Border.TopColor = System.Drawing.Color.Black
        Me.fldTotalDebit.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldTotalDebit.DataField = "Debit"
        Me.fldTotalDebit.Height = 0.25!
        Me.fldTotalDebit.Left = 6.0!
        Me.fldTotalDebit.Name = "fldTotalDebit"
        Me.fldTotalDebit.OutputFormat = resources.GetString("fldTotalDebit.OutputFormat")
        Me.fldTotalDebit.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.fldTotalDebit.SummaryGroup = "GroupHeader1"
        Me.fldTotalDebit.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.fldTotalDebit.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.fldTotalDebit.Text = "Debit"
        Me.fldTotalDebit.Top = 0.0625!
        Me.fldTotalDebit.Width = 0.9375!
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
        Me.TextBox13.DataField = "Credit"
        Me.TextBox13.Height = 0.25!
        Me.TextBox13.Left = 7.0!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.OutputFormat = resources.GetString("TextBox13.OutputFormat")
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.TextBox13.SummaryGroup = "GroupHeader1"
        Me.TextBox13.SummaryRunning = GrapeCity.ActiveReports.SectionReportModel.SummaryRunning.Group
        Me.TextBox13.SummaryType = GrapeCity.ActiveReports.SectionReportModel.SummaryType.SubTotal
        Me.TextBox13.Text = "Credit"
        Me.TextBox13.Top = 0.0625!
        Me.TextBox13.Width = 0.9375!
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
        Me.Line14.Height = 0.0!
        Me.Line14.Left = 6.0!
        Me.Line14.LineWeight = 1.0!
        Me.Line14.Name = "Line14"
        Me.Line14.Top = 0.375!
        Me.Line14.Width = 2.0!
        Me.Line14.X1 = 8.0!
        Me.Line14.X2 = 6.0!
        Me.Line14.Y1 = 0.375!
        Me.Line14.Y2 = 0.375!
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
        Me.Line16.Height = 0.375!
        Me.Line16.Left = 8.0!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.0!
        Me.Line16.Width = 0.0!
        Me.Line16.X1 = 8.0!
        Me.Line16.X2 = 8.0!
        Me.Line16.Y1 = 0.0!
        Me.Line16.Y2 = 0.375!
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
        Me.Line17.Height = 0.375!
        Me.Line17.Left = 7.0!
        Me.Line17.LineWeight = 1.0!
        Me.Line17.Name = "Line17"
        Me.Line17.Top = 0.0!
        Me.Line17.Width = 0.0!
        Me.Line17.X1 = 7.0!
        Me.Line17.X2 = 7.0!
        Me.Line17.Y1 = 0.0!
        Me.Line17.Y2 = 0.375!
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
        Me.Label6.Height = 0.25!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 0.1875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.Label6.Text = "Amount in words :"
        Me.Label6.Top = 0.375!
        Me.Label6.Width = 1.0625!
        '
        'fldAmountInWords
        '
        Me.fldAmountInWords.Border.BottomColor = System.Drawing.Color.Black
        Me.fldAmountInWords.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmountInWords.Border.LeftColor = System.Drawing.Color.Black
        Me.fldAmountInWords.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmountInWords.Border.RightColor = System.Drawing.Color.Black
        Me.fldAmountInWords.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmountInWords.Border.TopColor = System.Drawing.Color.Black
        Me.fldAmountInWords.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldAmountInWords.Height = 0.25!
        Me.fldAmountInWords.Left = 1.3125!
        Me.fldAmountInWords.Name = "fldAmountInWords"
        Me.fldAmountInWords.Style = "text-decoration: none; ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft" & _
            " Sans Serif; vertical-align: middle; "
        Me.fldAmountInWords.Text = "AmountInWords"
        Me.fldAmountInWords.Top = 0.375!
        Me.fldAmountInWords.Width = 4.5625!
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
        Me.Label7.Height = 0.25!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 5.5!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; font-weight: bold; font-size: 8.25pt; font-family: Microsoft San" & _
            "s Serif; "
        Me.Label7.Text = "Total :"
        Me.Label7.Top = 0.0625!
        Me.Label7.Width = 0.4375!
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
        Me.Line15.Height = 0.375!
        Me.Line15.Left = 6.0!
        Me.Line15.LineWeight = 1.0!
        Me.Line15.Name = "Line15"
        Me.Line15.Top = 0.0!
        Me.Line15.Width = 0.0!
        Me.Line15.X1 = 6.0!
        Me.Line15.X2 = 6.0!
        Me.Line15.Y1 = 0.0!
        Me.Line15.Y2 = 0.375!
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
        Me.fldSignature2.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldSignature2.Height = 0.1875!
        Me.fldSignature2.Left = 3.1875!
        Me.fldSignature2.Name = "fldSignature2"
        Me.fldSignature2.Style = "text-align: center; font-size: 8pt; "
        Me.fldSignature2.Text = "Signature2"
        Me.fldSignature2.Top = 0.25!
        Me.fldSignature2.Width = 1.6875!
        '
        'fldSignature3
        '
        Me.fldSignature3.Border.BottomColor = System.Drawing.Color.Black
        Me.fldSignature3.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature3.Border.LeftColor = System.Drawing.Color.Black
        Me.fldSignature3.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature3.Border.RightColor = System.Drawing.Color.Black
        Me.fldSignature3.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature3.Border.TopColor = System.Drawing.Color.Black
        Me.fldSignature3.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldSignature3.Height = 0.1875!
        Me.fldSignature3.Left = 6.25!
        Me.fldSignature3.Name = "fldSignature3"
        Me.fldSignature3.Style = "text-align: center; font-size: 8pt; "
        Me.fldSignature3.Text = "Signature3"
        Me.fldSignature3.Top = 0.25!
        Me.fldSignature3.Width = 1.6875!
        '
        'fldSignature4
        '
        Me.fldSignature4.Border.BottomColor = System.Drawing.Color.Black
        Me.fldSignature4.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature4.Border.LeftColor = System.Drawing.Color.Black
        Me.fldSignature4.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature4.Border.RightColor = System.Drawing.Color.Black
        Me.fldSignature4.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature4.Border.TopColor = System.Drawing.Color.Black
        Me.fldSignature4.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldSignature4.Height = 0.1875!
        Me.fldSignature4.Left = 0.25!
        Me.fldSignature4.Name = "fldSignature4"
        Me.fldSignature4.Style = "text-align: center; font-size: 8pt; "
        Me.fldSignature4.Text = "Signature4"
        Me.fldSignature4.Top = 0.875!
        Me.fldSignature4.Width = 1.6875!
        '
        'fldSignature5
        '
        Me.fldSignature5.Border.BottomColor = System.Drawing.Color.Black
        Me.fldSignature5.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature5.Border.LeftColor = System.Drawing.Color.Black
        Me.fldSignature5.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature5.Border.RightColor = System.Drawing.Color.Black
        Me.fldSignature5.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature5.Border.TopColor = System.Drawing.Color.Black
        Me.fldSignature5.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldSignature5.Height = 0.1875!
        Me.fldSignature5.Left = 3.1875!
        Me.fldSignature5.Name = "fldSignature5"
        Me.fldSignature5.Style = "text-align: center; font-size: 8pt; "
        Me.fldSignature5.Text = "Signature5"
        Me.fldSignature5.Top = 0.875!
        Me.fldSignature5.Width = 1.6875!
        '
        'fldSignature6
        '
        Me.fldSignature6.Border.BottomColor = System.Drawing.Color.Black
        Me.fldSignature6.Border.BottomStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature6.Border.LeftColor = System.Drawing.Color.Black
        Me.fldSignature6.Border.LeftStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature6.Border.RightColor = System.Drawing.Color.Black
        Me.fldSignature6.Border.RightStyle = GrapeCity.ActiveReports.BorderLineStyle.None
        Me.fldSignature6.Border.TopColor = System.Drawing.Color.Black
        Me.fldSignature6.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldSignature6.Height = 0.1875!
        Me.fldSignature6.Left = 6.25!
        Me.fldSignature6.Name = "fldSignature6"
        Me.fldSignature6.Style = "text-align: center; font-size: 8pt; "
        Me.fldSignature6.Text = "Signature6"
        Me.fldSignature6.Top = 0.875!
        Me.fldSignature6.Width = 1.6875!
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
        Me.fldSignature1.Border.TopStyle = GrapeCity.ActiveReports.BorderLineStyle.Solid
        Me.fldSignature1.Height = 0.1875!
        Me.fldSignature1.Left = 0.25!
        Me.fldSignature1.Name = "fldSignature1"
        Me.fldSignature1.Style = "text-align: center; font-size: 8pt; "
        Me.fldSignature1.Text = "Signature1"
        Me.fldSignature1.Top = 0.25!
        Me.fldSignature1.Width = 1.6875!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New GrapeCity.ActiveReports.SectionReportModel.ARControl() {Me.fldSignature1, Me.fldSignature3, Me.fldSignature4, Me.fldSignature5, Me.fldSignature6, Me.fldUserID, Me.fldSignature2, Me.Label17})
        Me.ReportFooter1.Height = 1.3125!
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
        Me.Label17.Height = 0.125!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 6.9375!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: MidnightBlue; ddo-char-set: 0; font-weight: normal; font-size: 6.75pt; fon" & _
            "t-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.Label17.Text = "PAYROLL VOUCHER"
        Me.Label17.Top = 1.125!
        Me.Label17.Width = 1.0!
        '
        'rptVoucher
        '
        Me.MasterReport = False
        Me.PageSettings.Collate = GrapeCity.ActiveReports.PageSettings.PrinterCollate.DontCollate
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Duplex = System.Drawing.Printing.Duplex.Simplex
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.Orientation = GrapeCity.ActiveReports.Document.Section.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 8.114583!
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
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldVoucherNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblPaidTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPaidTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTotalDebit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldAmountInWords, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSignature1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents fldCompany As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldTitle As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldUserID As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldChequeDate As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label1 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents GroupHeader1 As GrapeCity.ActiveReports.SectionReportModel.GroupHeader
    Friend WithEvents Label4 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label5 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line1 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line2 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents GroupFooter1 As GrapeCity.ActiveReports.SectionReportModel.GroupFooter
    Friend WithEvents Line3 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line4 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line5 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line6 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line7 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents TextBox4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line8 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line9 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line10 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line11 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents TextBox5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line12 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line13 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents fldSignature1 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldSignature2 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldSignature3 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldSignature4 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldSignature5 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldSignature6 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldTotalDebit As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox13 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line14 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line15 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line16 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line17 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label6 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldAmountInWords As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label7 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldDateTime As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label8 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPage As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label9 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldPages As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label10 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents fldDivision As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents fldVoucherNo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label11 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label13 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox8 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label14 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents TextBox9 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox10 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox11 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Label15 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label16 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Label3 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line18 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Line19 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents TextBox12 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents TextBox14 As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line21 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label2 As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents Line20 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents ReportHeader1 As GrapeCity.ActiveReports.SectionReportModel.ReportHeader
    Friend WithEvents ReportFooter1 As GrapeCity.ActiveReports.SectionReportModel.ReportFooter
    Friend WithEvents lblPaidTo As GrapeCity.ActiveReports.SectionReportModel.Label
    Friend WithEvents txtPaidTo As GrapeCity.ActiveReports.SectionReportModel.TextBox
    Friend WithEvents Line23 As GrapeCity.ActiveReports.SectionReportModel.Line
    Friend WithEvents Label17 As GrapeCity.ActiveReports.SectionReportModel.Label
End Class
