<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDemandNotice3
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
    Private WithEvents PageHeader1 As DataDynamics.ActiveReports.PageHeader
    Private WithEvents Detail1 As DataDynamics.ActiveReports.Detail
    Private WithEvents PageFooter1 As DataDynamics.ActiveReports.PageFooter
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDemandNotice3))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.TextBox37 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox40 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox43 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox44 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox45 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox13 = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox66 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox67 = New DataDynamics.ActiveReports.TextBox
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.TextBox68 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox69 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox14 = New DataDynamics.ActiveReports.TextBox
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Height = 1.885417!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox3, Me.TextBox4})
        Me.Detail1.Height = 0.1875!
        Me.Detail1.Name = "Detail1"
        '
        'TextBox3
        '
        Me.TextBox3.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox3.DataField = "PaymentType"
        Me.TextBox3.Height = 0.1875!
        Me.TextBox3.Left = 1.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; font-famil" & _
            "y: Calibri; vertical-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 3.1875!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.DataField = "BalanceAmount"
        Me.TextBox4.Height = 0.1875!
        Me.TextBox4.Left = 4.25!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 0; text-decoration: none; text-align: right; font-weight: bold; fon" & _
            "t-size: 12pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 1.1875!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.25!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'GroupHeader1
        '
        Me.GroupHeader1.ColumnGroupKeepTogether = True
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox37, Me.TextBox40, Me.TextBox43, Me.TextBox44, Me.TextBox1, Me.TextBox45, Me.TextBox11, Me.TextBox2, Me.TextBox13})
        Me.GroupHeader1.DataField = "EntryNo"
        Me.GroupHeader1.GroupKeepTogether = DataDynamics.ActiveReports.GroupKeepTogether.All
        Me.GroupHeader1.Height = 2.583333!
        Me.GroupHeader1.KeepTogether = True
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.NewPage = DataDynamics.ActiveReports.NewPage.Before
        '
        'TextBox37
        '
        Me.TextBox37.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox37.DataField = "EntryNo"
        Me.TextBox37.Height = 0.25!
        Me.TextBox37.Left = 1.3125!
        Me.TextBox37.Name = "TextBox37"
        Me.TextBox37.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 12pt; font-fam" & _
            "ily: Calibri; vertical-align: middle; "
        Me.TextBox37.Text = Nothing
        Me.TextBox37.Top = 0.0625!
        Me.TextBox37.Width = 1.25!
        '
        'TextBox40
        '
        Me.TextBox40.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox40.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox40.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox40.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox40.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox40.DataField = "EntryDate"
        Me.TextBox40.Height = 0.25!
        Me.TextBox40.Left = 6.3125!
        Me.TextBox40.Name = "TextBox40"
        Me.TextBox40.OutputFormat = resources.GetString("TextBox40.OutputFormat")
        Me.TextBox40.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 12pt; font-fam" & _
            "ily: Calibri; vertical-align: middle; "
        Me.TextBox40.Text = Nothing
        Me.TextBox40.Top = 0.0625!
        Me.TextBox40.Width = 1.125!
        '
        'TextBox43
        '
        Me.TextBox43.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox43.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox43.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox43.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox43.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox43.DataField = "CustomerName"
        Me.TextBox43.Height = 0.25!
        Me.TextBox43.Left = 1.0!
        Me.TextBox43.Name = "TextBox43"
        Me.TextBox43.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; font-famil" & _
            "y: Calibri; vertical-align: middle; "
        Me.TextBox43.Text = Nothing
        Me.TextBox43.Top = 0.375!
        Me.TextBox43.Width = 3.9375!
        '
        'TextBox44
        '
        Me.TextBox44.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox44.Height = 0.25!
        Me.TextBox44.Left = 1.0!
        Me.TextBox44.Name = "TextBox44"
        Me.TextBox44.Style = "text-decoration: underline; ddo-char-set: 0; text-align: center; font-weight: bol" & _
            "d; font-size: 12pt; font-family: Calibri; "
        Me.TextBox44.Text = "Demand Notice"
        Me.TextBox44.Top = 1.0!
        Me.TextBox44.Width = 6.4375!
        '
        'TextBox1
        '
        Me.TextBox1.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox1.DataField = "Subject1"
        Me.TextBox1.Height = 0.25!
        Me.TextBox1.Left = 1.0!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; font-famil" & _
            "y: Calibri; vertical-align: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 1.25!
        Me.TextBox1.Width = 6.4375!
        '
        'TextBox45
        '
        Me.TextBox45.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox45.Height = 0.25!
        Me.TextBox45.Left = 1.0!
        Me.TextBox45.Name = "TextBox45"
        Me.TextBox45.Style = "ddo-char-set: 0; font-weight: normal; font-size: 12pt; font-family: Calibri; "
        Me.TextBox45.Text = "Dear Customer (s),"
        Me.TextBox45.Top = 1.5625!
        Me.TextBox45.Width = 1.375!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.DataField = "Address"
        Me.TextBox11.Height = 0.3125!
        Me.TextBox11.Left = 1.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 9pt; font-family" & _
            ": Calibri; vertical-align: top; "
        Me.TextBox11.Text = Nothing
        Me.TextBox11.Top = 0.6875!
        Me.TextBox11.Width = 6.4375!
        '
        'TextBox2
        '
        Me.TextBox2.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox2.DataField = "ParagraphD31"
        Me.TextBox2.Height = 0.6875!
        Me.TextBox2.Left = 1.0!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: justify; font-weight: normal; font-size: 12pt; font-" & _
            "family: Calibri; vertical-align: top; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 1.875!
        Me.TextBox2.Width = 6.4375!
        '
        'TextBox13
        '
        Me.TextBox13.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox13.Height = 0.25!
        Me.TextBox13.Left = 1.0!
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Style = "ddo-char-set: 0; text-align: left; font-weight: normal; font-size: 12pt; font-fam" & _
            "ily: Calibri; vertical-align: middle; "
        Me.TextBox13.Text = "D3/"
        Me.TextBox13.Top = 0.0625!
        Me.TextBox13.Width = 0.3125!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox66, Me.TextBox67, Me.Line2, Me.TextBox68, Me.TextBox69, Me.TextBox5, Me.TextBox6, Me.TextBox9, Me.TextBox10, Me.Line1, Me.Line3, Me.Line4, Me.TextBox12, Me.TextBox14})
        Me.GroupFooter1.Height = 3.802083!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'TextBox66
        '
        Me.TextBox66.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox66.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox66.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox66.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox66.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox66.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox66.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox66.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox66.Height = 0.25!
        Me.TextBox66.Left = 1.0!
        Me.TextBox66.Name = "TextBox66"
        Me.TextBox66.Style = "ddo-char-set: 0; font-weight: normal; font-size: 12pt; font-family: Calibri; "
        Me.TextBox66.Text = "Thanking You"
        Me.TextBox66.Top = 2.25!
        Me.TextBox66.Width = 6.3125!
        '
        'TextBox67
        '
        Me.TextBox67.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox67.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox67.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox67.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox67.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox67.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox67.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox67.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox67.Height = 0.25!
        Me.TextBox67.Left = 1.0!
        Me.TextBox67.Name = "TextBox67"
        Me.TextBox67.Style = "ddo-char-set: 0; font-weight: normal; font-size: 12pt; font-family: Calibri; "
        Me.TextBox67.Text = "Truly Yours"
        Me.TextBox67.Top = 2.5!
        Me.TextBox67.Width = 6.3125!
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
        Me.Line2.Left = 1.0!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 3.0625!
        Me.Line2.Width = 3.5625!
        Me.Line2.X1 = 1.0!
        Me.Line2.X2 = 4.5625!
        Me.Line2.Y1 = 3.0625!
        Me.Line2.Y2 = 3.0625!
        '
        'TextBox68
        '
        Me.TextBox68.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox68.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox68.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox68.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox68.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox68.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox68.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox68.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox68.Height = 0.25!
        Me.TextBox68.Left = 1.0!
        Me.TextBox68.Name = "TextBox68"
        Me.TextBox68.Style = "ddo-char-set: 0; font-weight: bold; font-size: 12pt; font-family: Calibri; "
        Me.TextBox68.Text = "Management "
        Me.TextBox68.Top = 3.125!
        Me.TextBox68.Width = 1.0625!
        '
        'TextBox69
        '
        Me.TextBox69.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox69.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox69.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox69.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox69.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox69.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox69.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox69.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox69.DataField = "ProjectName"
        Me.TextBox69.Height = 0.25!
        Me.TextBox69.Left = 2.0625!
        Me.TextBox69.Name = "TextBox69"
        Me.TextBox69.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; font-famil" & _
            "y: Calibri; vertical-align: middle; "
        Me.TextBox69.Text = Nothing
        Me.TextBox69.Top = 3.125!
        Me.TextBox69.Width = 2.4375!
        '
        'TextBox5
        '
        Me.TextBox5.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox5.DataField = "ParagraphD32"
        Me.TextBox5.Height = 1.0!
        Me.TextBox5.Left = 1.0!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: justify; font-weight: normal; font-size: 12pt; font-" & _
            "family: Calibri; vertical-align: top; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.4375!
        Me.TextBox5.Width = 6.4375!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox6.DataField = "ParagraphD33"
        Me.TextBox6.Height = 0.375!
        Me.TextBox6.Left = 1.0!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: justify; font-weight: normal; font-size: 12pt; font-" & _
            "family: Calibri; vertical-align: top; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 1.4375!
        Me.TextBox6.Width = 6.4375!
        '
        'TextBox9
        '
        Me.TextBox9.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox9.Height = 0.25!
        Me.TextBox9.Left = 1.0!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "ddo-char-set: 0; text-align: left; font-weight: bold; font-size: 12pt; font-famil" & _
            "y: Calibri; vertical-align: middle; "
        Me.TextBox9.Text = "Total Dues"
        Me.TextBox9.Top = 0.0625!
        Me.TextBox9.Width = 3.1875!
        '
        'TextBox10
        '
        Me.TextBox10.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox10.DataField = "BalanceAmount"
        Me.TextBox10.Height = 0.25!
        Me.TextBox10.Left = 4.25!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "text-decoration: none; ddo-char-set: 0; text-align: right; font-weight: bold; fon" & _
            "t-size: 12pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox10.SummaryGroup = "GroupHeader1"
        Me.TextBox10.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.TextBox10.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 0.0625!
        Me.TextBox10.Width = 1.1875!
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
        Me.Line1.Left = 4.25!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.0625!
        Me.Line1.Width = 1.1875!
        Me.Line1.X1 = 4.25!
        Me.Line1.X2 = 5.4375!
        Me.Line1.Y1 = 0.0625!
        Me.Line1.Y2 = 0.0625!
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
        Me.Line3.Left = 4.25!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.3125!
        Me.Line3.Width = 1.1875!
        Me.Line3.X1 = 4.25!
        Me.Line3.X2 = 5.4375!
        Me.Line3.Y1 = 0.3125!
        Me.Line3.Y2 = 0.3125!
        '
        'Line4
        '
        Me.Line4.Border.BottomColor = System.Drawing.Color.Black
        Me.Line4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.LeftColor = System.Drawing.Color.Black
        Me.Line4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.RightColor = System.Drawing.Color.Black
        Me.Line4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Border.TopColor = System.Drawing.Color.Black
        Me.Line4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line4.Height = 0.0!
        Me.Line4.Left = 4.25!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.375!
        Me.Line4.Width = 1.1875!
        Me.Line4.X1 = 4.25!
        Me.Line4.X2 = 5.4375!
        Me.Line4.Y1 = 0.375!
        Me.Line4.Y2 = 0.375!
        '
        'TextBox12
        '
        Me.TextBox12.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox12.DataField = "ParagraphD34"
        Me.TextBox12.Height = 0.375!
        Me.TextBox12.Left = 1.0!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: justify; font-weight: normal; font-size: 12pt; font-" & _
            "family: Calibri; vertical-align: top; "
        Me.TextBox12.Text = Nothing
        Me.TextBox12.Top = 1.8125!
        Me.TextBox12.Width = 6.4375!
        '
        'TextBox14
        '
        Me.TextBox14.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox14.Height = 0.1875!
        Me.TextBox14.Left = 1.0!
        Me.TextBox14.Name = "TextBox14"
        Me.TextBox14.Style = "ddo-char-set: 0; text-align: justify; font-weight: normal; font-size: 9.75pt; fon" & _
            "t-family: Calibri; "
        Me.TextBox14.Text = "*    If you have already paid for the above, kindly ignore this letter."
        Me.TextBox14.Top = 3.5!
        Me.TextBox14.Width = 5.8125!
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.0!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Height = 0.0!
        Me.ReportFooter1.Name = "ReportFooter1"
        '
        'rptDemandNotice3
        '
        Me.MasterReport = False
        Me.PageSettings.Collate = DataDynamics.ActiveReports.PageSettings.PrinterCollate.DontCollate
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Duplex = System.Drawing.Printing.Duplex.Simplex
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Portrait
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 8.135417!
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
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox40, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox43, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents TextBox37 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox40 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox43 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox44 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox45 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox66 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox67 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox68 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox69 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox13 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox14 As DataDynamics.ActiveReports.TextBox
End Class
