<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptRecoveryReportForecast
    Inherits DataDynamics.ActiveReports.ActiveReport3

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
        End If
        MyBase.Dispose(disposing)
    End Sub

    'NOTE: The following procedure is required by the ActiveReports Designer
    'It can be modified using the ActiveReports Designer.
    'Do not modify it using the code editor.
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptRecoveryReportForecast))
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.fldUnitNo = New DataDynamics.ActiveReports.TextBox
        Me.TextBox29 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.fldReceiveAmoun = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.fldChequeDate = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Label17 = New DataDynamics.ActiveReports.Label
        Me.TextBox21 = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.fldCompany = New DataDynamics.ActiveReports.TextBox
        Me.fldTitle = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.fldDateTime = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.fldPage = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.fldPages = New DataDynamics.ActiveReports.TextBox
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.fldTypeReceiveAmount = New DataDynamics.ActiveReports.TextBox
        Me.fldGrandReceiveAmount = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        CType(Me.fldUnitNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldReceiveAmoun, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTypeReceiveAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldGrandReceiveAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldUnitNo, Me.TextBox29, Me.TextBox5, Me.TextBox1, Me.TextBox3, Me.fldReceiveAmoun, Me.TextBox4, Me.TextBox2})
        Me.Detail1.Height = 0.2604167!
        Me.Detail1.Name = "Detail1"
        '
        'fldUnitNo
        '
        Me.fldUnitNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldUnitNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldUnitNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldUnitNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldUnitNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldUnitNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldUnitNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldUnitNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldUnitNo.DataField = "UnitNumber"
        Me.fldUnitNo.Height = 0.25!
        Me.fldUnitNo.Left = 0.1875!
        Me.fldUnitNo.Name = "fldUnitNo"
        Me.fldUnitNo.Style = "ddo-char-set: 1; text-align: center; font-size: 7.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.fldUnitNo.Text = Nothing
        Me.fldUnitNo.Top = 0.0!
        Me.fldUnitNo.Width = 0.8125!
        '
        'TextBox29
        '
        Me.TextBox29.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox29.DataField = "Customer"
        Me.TextBox29.Height = 0.25!
        Me.TextBox29.Left = 1.0!
        Me.TextBox29.Name = "TextBox29"
        Me.TextBox29.Style = "ddo-char-set: 1; text-align: center; font-size: 7.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.TextBox29.Text = Nothing
        Me.TextBox29.Top = 0.0!
        Me.TextBox29.Width = 2.3125!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox5.DataField = "BalanceTillDate"
        Me.TextBox5.Height = 0.25!
        Me.TextBox5.Left = 3.9375!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 1; text-align: right; font-size: 7.25pt; font-family: Calibri; vert" & _
            "ical-align: middle; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.8125!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox1.Height = 0.25!
        Me.TextBox1.Left = 6.1875!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "ddo-char-set: 1; text-align: right; font-size: 7.25pt; font-family: Calibri; vert" & _
            "ical-align: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 1.8125!
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox3.Height = 0.25!
        Me.TextBox3.Left = 4.75!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 1; text-align: right; font-size: 7.25pt; font-family: Calibri; vert" & _
            "ical-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.6875!
        '
        'fldReceiveAmoun
        '
        Me.fldReceiveAmoun.Border.BottomColor = System.Drawing.Color.Black
        Me.fldReceiveAmoun.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiveAmoun.Border.LeftColor = System.Drawing.Color.Black
        Me.fldReceiveAmoun.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiveAmoun.Border.RightColor = System.Drawing.Color.Black
        Me.fldReceiveAmoun.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiveAmoun.Border.TopColor = System.Drawing.Color.Black
        Me.fldReceiveAmoun.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiveAmoun.DataField = "ReceivedForThePeriod"
        Me.fldReceiveAmoun.Height = 0.25!
        Me.fldReceiveAmoun.Left = 5.4375!
        Me.fldReceiveAmoun.Name = "fldReceiveAmoun"
        Me.fldReceiveAmoun.OutputFormat = resources.GetString("fldReceiveAmoun.OutputFormat")
        Me.fldReceiveAmoun.Style = "ddo-char-set: 1; text-align: right; font-size: 7.25pt; font-family: Calibri; vert" & _
            "ical-align: middle; "
        Me.fldReceiveAmoun.Text = Nothing
        Me.fldReceiveAmoun.Top = 0.0!
        Me.fldReceiveAmoun.Width = 0.75!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox4.DataField = "RecoverPer"
        Me.TextBox4.Height = 0.25!
        Me.TextBox4.Left = 3.3125!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 1; text-align: center; font-size: 7.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.625!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldChequeDate})
        Me.GroupHeader1.DataField = "UnitType"
        Me.GroupHeader1.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.GroupHeader1.Height = 0.3333333!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'fldChequeDate
        '
        Me.fldChequeDate.Border.BottomColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.Border.LeftColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.Border.RightColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.Border.TopColor = System.Drawing.Color.Black
        Me.fldChequeDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeDate.DataField = "UnitTypeName"
        Me.fldChequeDate.Height = 0.25!
        Me.fldChequeDate.Left = 0.1875!
        Me.fldChequeDate.Name = "fldChequeDate"
        Me.fldChequeDate.Style = "color: Blue; ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12p" & _
            "t; font-family: Calibri; vertical-align: middle; "
        Me.fldChequeDate.Text = Nothing
        Me.fldChequeDate.Top = 0.0625!
        Me.fldChequeDate.Width = 4.8125!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line13, Me.Label22, Me.TextBox14, Me.Line1, Me.fldTypeReceiveAmount})
        Me.GroupFooter1.Height = 0.4166667!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Line13
        '
        Me.Line13.Border.BottomColor = System.Drawing.Color.Black
        Me.Line13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.LeftColor = System.Drawing.Color.Black
        Me.Line13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.RightColor = System.Drawing.Color.Black
        Me.Line13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Border.TopColor = System.Drawing.Color.Black
        Me.Line13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line13.Height = 0.0!
        Me.Line13.Left = 0.1875!
        Me.Line13.LineWeight = 1.0!
        Me.Line13.Name = "Line13"
        Me.Line13.Top = 0.0!
        Me.Line13.Width = 6.0625!
        Me.Line13.X1 = 6.25!
        Me.Line13.X2 = 0.1875!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.0!
        '
        'Label22
        '
        Me.Label22.Border.BottomColor = System.Drawing.Color.Black
        Me.Label22.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.LeftColor = System.Drawing.Color.Black
        Me.Label22.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.RightColor = System.Drawing.Color.Black
        Me.Label22.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Border.TopColor = System.Drawing.Color.Black
        Me.Label22.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label22.Height = 0.25!
        Me.Label22.HyperLink = Nothing
        Me.Label22.Left = 0.1875!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "color: Blue; ddo-char-set: 0; text-align: justify; font-weight: bold; font-size: " & _
            "8.25pt; font-family: Arial; vertical-align: middle; "
        Me.Label22.Text = "Type Total"
        Me.Label22.Top = 0.0625!
        Me.Label22.Width = 0.625!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.DataField = "BalanceTillDate"
        Me.TextBox14.Height = 0.25!
        Me.TextBox14.Left = 4.0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.OutputFormat = resources.GetString("TextBox14.OutputFormat")
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.TextBox14.SummaryGroup = "GroupHeader1"
        Me.TextBox14.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox14.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox14.Text = Nothing
        Me.TextBox14.Top = 0.0625!
        Me.TextBox14.Width = 0.75!
        '
        'Line1
        '
        Me.Line1.Border.BottomColor = System.Drawing.Color.Black
        Me.Line1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.LeftColor = System.Drawing.Color.Black
        Me.Line1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.RightColor = System.Drawing.Color.Black
        Me.Line1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Border.TopColor = System.Drawing.Color.Black
        Me.Line1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line1.Height = 0.0!
        Me.Line1.Left = 0.1875!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.375!
        Me.Line1.Width = 6.0625!
        Me.Line1.X1 = 6.25!
        Me.Line1.X2 = 0.1875!
        Me.Line1.Y1 = 0.375!
        Me.Line1.Y2 = 0.375!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label17, Me.TextBox21, Me.Line2, Me.Line3, Me.fldGrandReceiveAmount})
        Me.ReportFooter1.Height = 0.625!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'Label17
        '
        Me.Label17.Border.BottomColor = System.Drawing.Color.Black
        Me.Label17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.LeftColor = System.Drawing.Color.Black
        Me.Label17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.RightColor = System.Drawing.Color.Black
        Me.Label17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Border.TopColor = System.Drawing.Color.Black
        Me.Label17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label17.Height = 0.25!
        Me.Label17.HyperLink = Nothing
        Me.Label17.Left = 0.1875!
        Me.Label17.Name = "Label17"
        Me.Label17.Style = "color: Blue; ddo-char-set: 0; text-align: justify; font-weight: bold; font-size: " & _
            "8.25pt; font-family: Arial; vertical-align: middle; "
        Me.Label17.Text = "Grand Total"
        Me.Label17.Top = 0.0625!
        Me.Label17.Width = 0.6875!
        '
        'TextBox21
        '
        Me.TextBox21.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox21.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox21.DataField = "BalanceTillDate"
        Me.TextBox21.Height = 0.25!
        Me.TextBox21.Left = 4.0!
        Me.TextBox21.Name = "TextBox21"
        Me.TextBox21.OutputFormat = resources.GetString("TextBox21.OutputFormat")
        Me.TextBox21.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7.25pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.TextBox21.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox21.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox21.Text = Nothing
        Me.TextBox21.Top = 0.0625!
        Me.TextBox21.Width = 0.75!
        '
        'Line2
        '
        Me.Line2.Border.BottomColor = System.Drawing.Color.Black
        Me.Line2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.LeftColor = System.Drawing.Color.Black
        Me.Line2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.RightColor = System.Drawing.Color.Black
        Me.Line2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Border.TopColor = System.Drawing.Color.Black
        Me.Line2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line2.Height = 0.0!
        Me.Line2.Left = 0.1875!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.375!
        Me.Line2.Width = 6.0625!
        Me.Line2.X1 = 6.25!
        Me.Line2.X2 = 0.1875!
        Me.Line2.Y1 = 0.375!
        Me.Line2.Y2 = 0.375!
        '
        'Line3
        '
        Me.Line3.Border.BottomColor = System.Drawing.Color.Black
        Me.Line3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.LeftColor = System.Drawing.Color.Black
        Me.Line3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.RightColor = System.Drawing.Color.Black
        Me.Line3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Border.TopColor = System.Drawing.Color.Black
        Me.Line3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line3.Height = 0.0!
        Me.Line3.Left = 0.1875!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.0!
        Me.Line3.Width = 6.0625!
        Me.Line3.X1 = 6.25!
        Me.Line3.X2 = 0.1875!
        Me.Line3.Y1 = 0.0!
        Me.Line3.Y2 = 0.0!
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldCompany, Me.fldTitle, Me.Label1, Me.fldDateTime, Me.Label8, Me.fldPage, Me.Label9, Me.fldPages, Me.Label2, Me.Label16, Me.Label6, Me.Label3, Me.Label4, Me.Label5, Me.Label7})
        Me.PageHeader1.Height = 1.708333!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'fldCompany
        '
        Me.fldCompany.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCompany.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCompany.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Border.RightColor = System.Drawing.Color.Black
        Me.fldCompany.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Border.TopColor = System.Drawing.Color.Black
        Me.fldCompany.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCompany.Height = 0.4375!
        Me.fldCompany.Left = 0.125!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 18pt; vertical" & _
            "-align: middle; "
        Me.fldCompany.Text = "Company"
        Me.fldCompany.Top = 0.375!
        Me.fldCompany.Width = 7.875!
        '
        'fldTitle
        '
        Me.fldTitle.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTitle.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTitle.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Border.RightColor = System.Drawing.Color.Black
        Me.fldTitle.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Border.TopColor = System.Drawing.Color.Black
        Me.fldTitle.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTitle.Height = 0.25!
        Me.fldTitle.Left = 0.125!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; verti" & _
            "cal-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.8125!
        Me.fldTitle.Width = 7.875!
        '
        'Label1
        '
        Me.Label1.Border.BottomColor = System.Drawing.Color.Black
        Me.Label1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.LeftColor = System.Drawing.Color.Black
        Me.Label1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.RightColor = System.Drawing.Color.Black
        Me.Label1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Border.TopColor = System.Drawing.Color.Black
        Me.Label1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label1.Height = 0.1875!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 0.125!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = ""
        Me.Label1.Text = "Print Date & Time :"
        Me.Label1.Top = 0.125!
        Me.Label1.Width = 1.25!
        '
        'fldDateTime
        '
        Me.fldDateTime.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Border.RightColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Border.TopColor = System.Drawing.Color.Black
        Me.fldDateTime.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDateTime.Height = 0.1875!
        Me.fldDateTime.Left = 1.375!
        Me.fldDateTime.Name = "fldDateTime"
        Me.fldDateTime.Style = ""
        Me.fldDateTime.Text = "DateTime"
        Me.fldDateTime.Top = 0.125!
        Me.fldDateTime.Width = 1.8125!
        '
        'Label8
        '
        Me.Label8.Border.BottomColor = System.Drawing.Color.Black
        Me.Label8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.LeftColor = System.Drawing.Color.Black
        Me.Label8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.RightColor = System.Drawing.Color.Black
        Me.Label8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Border.TopColor = System.Drawing.Color.Black
        Me.Label8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label8.Height = 0.1875!
        Me.Label8.HyperLink = Nothing
        Me.Label8.Left = 6.1875!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8.25pt; "
        Me.Label8.Text = "Page No."
        Me.Label8.Top = 0.125!
        Me.Label8.Width = 0.5625!
        '
        'fldPage
        '
        Me.fldPage.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPage.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPage.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPage.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPage.Border.RightColor = System.Drawing.Color.Black
        Me.fldPage.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPage.Border.TopColor = System.Drawing.Color.Black
        Me.fldPage.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPage.Height = 0.1875!
        Me.fldPage.Left = 6.9375!
        Me.fldPage.Name = "fldPage"
        Me.fldPage.Style = "text-align: right; font-size: 8.25pt; "
        Me.fldPage.SummaryGroup = "GroupHeader1"
        Me.fldPage.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.fldPage.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.fldPage.Text = "Page"
        Me.fldPage.Top = 0.125!
        Me.fldPage.Width = 0.375!
        '
        'Label9
        '
        Me.Label9.Border.BottomColor = System.Drawing.Color.Black
        Me.Label9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.LeftColor = System.Drawing.Color.Black
        Me.Label9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.RightColor = System.Drawing.Color.Black
        Me.Label9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Border.TopColor = System.Drawing.Color.Black
        Me.Label9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label9.Height = 0.1875!
        Me.Label9.HyperLink = Nothing
        Me.Label9.Left = 7.3125!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "text-align: center; font-size: 8.25pt; "
        Me.Label9.Text = "of"
        Me.Label9.Top = 0.125!
        Me.Label9.Width = 0.1875!
        '
        'fldPages
        '
        Me.fldPages.Border.BottomColor = System.Drawing.Color.Black
        Me.fldPages.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPages.Border.LeftColor = System.Drawing.Color.Black
        Me.fldPages.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPages.Border.RightColor = System.Drawing.Color.Black
        Me.fldPages.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPages.Border.TopColor = System.Drawing.Color.Black
        Me.fldPages.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldPages.Height = 0.1875!
        Me.fldPages.Left = 7.5!
        Me.fldPages.Name = "fldPages"
        Me.fldPages.Style = "text-align: left; font-size: 8.25pt; "
        Me.fldPages.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.fldPages.Text = "Pages"
        Me.fldPages.Top = 0.125!
        Me.fldPages.Width = 0.4375!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label2.Height = 0.4375!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.1875!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label2.Text = "Unit #"
        Me.Label2.Top = 1.25!
        Me.Label2.Width = 0.8125!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label16.Height = 0.4375!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 1.0!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label16.Text = "Name"
        Me.Label16.Top = 1.25!
        Me.Label16.Width = 2.3125!
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label6.Height = 0.4375!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 3.9375!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label6.Text = "Outstanding Balance"
        Me.Label6.Top = 1.25!
        Me.Label6.Width = 0.8125!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label3.Height = 0.4375!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 6.1875!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label3.Text = "Remarks"
        Me.Label3.Top = 1.25!
        Me.Label3.Width = 1.8125!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label4.Height = 0.4375!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 4.75!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label4.Text = "Expected Amount"
        Me.Label4.Top = 1.25!
        Me.Label4.Width = 0.6875!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label5.Height = 0.4375!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 5.4375!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label5.Text = "Receive Amount"
        Me.Label5.Top = 1.25!
        Me.Label5.Width = 0.75!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label7.Height = 0.4375!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 3.3125!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label7.Text = "Recovery %"
        Me.Label7.Top = 1.25!
        Me.Label7.Width = 0.625!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'fldTypeReceiveAmount
        '
        Me.fldTypeReceiveAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.fldTypeReceiveAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.fldTypeReceiveAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.fldTypeReceiveAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTypeReceiveAmount.Border.RightColor = System.Drawing.Color.Black
        Me.fldTypeReceiveAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTypeReceiveAmount.Border.TopColor = System.Drawing.Color.Black
        Me.fldTypeReceiveAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldTypeReceiveAmount.DataField = "ReceivedForThePeriod"
        Me.fldTypeReceiveAmount.Height = 0.25!
        Me.fldTypeReceiveAmount.Left = 5.4375!
        Me.fldTypeReceiveAmount.Name = "fldTypeReceiveAmount"
        Me.fldTypeReceiveAmount.OutputFormat = resources.GetString("fldTypeReceiveAmount.OutputFormat")
        Me.fldTypeReceiveAmount.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.fldTypeReceiveAmount.SummaryGroup = "GroupHeader1"
        Me.fldTypeReceiveAmount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.fldTypeReceiveAmount.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.fldTypeReceiveAmount.Text = Nothing
        Me.fldTypeReceiveAmount.Top = 0.0625!
        Me.fldTypeReceiveAmount.Width = 0.75!
        '
        'fldGrandReceiveAmount
        '
        Me.fldGrandReceiveAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.fldGrandReceiveAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.fldGrandReceiveAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.fldGrandReceiveAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldGrandReceiveAmount.Border.RightColor = System.Drawing.Color.Black
        Me.fldGrandReceiveAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldGrandReceiveAmount.Border.TopColor = System.Drawing.Color.Black
        Me.fldGrandReceiveAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldGrandReceiveAmount.DataField = "ReceivedForThePeriod"
        Me.fldGrandReceiveAmount.Height = 0.25!
        Me.fldGrandReceiveAmount.Left = 5.4375!
        Me.fldGrandReceiveAmount.Name = "fldGrandReceiveAmount"
        Me.fldGrandReceiveAmount.OutputFormat = resources.GetString("fldGrandReceiveAmount.OutputFormat")
        Me.fldGrandReceiveAmount.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 7.25pt; font-fa" & _
            "mily: Calibri; vertical-align: middle; "
        Me.fldGrandReceiveAmount.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.fldGrandReceiveAmount.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.fldGrandReceiveAmount.Text = Nothing
        Me.fldGrandReceiveAmount.Top = 0.0625!
        Me.fldGrandReceiveAmount.Width = 0.75!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 5.4375!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 1; text-align: right; font-size: 7.25pt; font-family: Calibri; vert" & _
            "ical-align: middle; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.75!
        '
        'rptRecoveryReportForecast
        '
        Me.MasterReport = False
        Me.PageSettings.Collate = DataDynamics.ActiveReports.PageSettings.PrinterCollate.DontCollate
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Duplex = System.Drawing.Printing.Duplex.Simplex
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.4!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 8.093743!
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
        CType(Me.fldUnitNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldReceiveAmoun, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTypeReceiveAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldGrandReceiveAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Line13 As DataDynamics.ActiveReports.Line
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldUnitNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label17 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox21 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldChequeDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox29 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Friend WithEvents fldCompany As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldTitle As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldDateTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldPage As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldPages As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldReceiveAmoun As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldTypeReceiveAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldGrandReceiveAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
End Class
