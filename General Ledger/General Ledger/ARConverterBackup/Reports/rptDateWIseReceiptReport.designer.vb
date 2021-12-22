<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptDateWiseReceiptReport
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptDateWiseReceiptReport))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Line23 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Line24 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.fldCompany = New DataDynamics.ActiveReports.TextBox
        Me.fldTitle = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.fldPage = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.fldPages = New DataDynamics.ActiveReports.TextBox
        Me.Line11 = New DataDynamics.ActiveReports.Line
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.fldSNo = New DataDynamics.ActiveReports.TextBox
        Me.fldInvoiceNo = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.fldReceiptNo = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Line13 = New DataDynamics.ActiveReports.Line
        Me.Line26 = New DataDynamics.ActiveReports.Line
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldSNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldReceiptNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label15, Me.Line23, Me.Line10, Me.Line24, Me.Line3, Me.Label2, Me.Line4, Me.Line7, Me.Line9, Me.Label4, Me.Label7, Me.Label10, Me.Line2, Me.Line1, Me.fldCompany, Me.fldTitle, Me.Label8, Me.fldPage, Me.Label9, Me.fldPages, Me.Line11, Me.Label3, Me.Label1, Me.Line5, Me.Label5, Me.Label6, Me.Line6})
        Me.PageHeader1.Height = 1.510417!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label15.Height = 0.4375!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.125!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label15.Text = "S #"
        Me.Label15.Top = 1.0!
        Me.Label15.Width = 0.3125!
        '
        'Line23
        '
        Me.Line23.Border.BottomColor = System.Drawing.Color.Black
        Me.Line23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.LeftColor = System.Drawing.Color.Black
        Me.Line23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.RightColor = System.Drawing.Color.Black
        Me.Line23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Border.TopColor = System.Drawing.Color.Black
        Me.Line23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line23.Height = 0.0!
        Me.Line23.Left = 0.125!
        Me.Line23.LineWeight = 1.0!
        Me.Line23.Name = "Line23"
        Me.Line23.Top = 1.5!
        Me.Line23.Width = 8.0!
        Me.Line23.X1 = 8.125!
        Me.Line23.X2 = 0.125!
        Me.Line23.Y1 = 1.5!
        Me.Line23.Y2 = 1.5!
        '
        'Line10
        '
        Me.Line10.Border.BottomColor = System.Drawing.Color.Black
        Me.Line10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.LeftColor = System.Drawing.Color.Black
        Me.Line10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.RightColor = System.Drawing.Color.Black
        Me.Line10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Border.TopColor = System.Drawing.Color.Black
        Me.Line10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line10.Height = 0.5625!
        Me.Line10.Left = 0.125!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.9375!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 0.125!
        Me.Line10.X2 = 0.125!
        Me.Line10.Y1 = 0.9375!
        Me.Line10.Y2 = 1.5!
        '
        'Line24
        '
        Me.Line24.Border.BottomColor = System.Drawing.Color.Black
        Me.Line24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.LeftColor = System.Drawing.Color.Black
        Me.Line24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.RightColor = System.Drawing.Color.Black
        Me.Line24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Border.TopColor = System.Drawing.Color.Black
        Me.Line24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line24.Height = 0.5625!
        Me.Line24.Left = 8.125!
        Me.Line24.LineWeight = 1.0!
        Me.Line24.Name = "Line24"
        Me.Line24.Top = 0.9375!
        Me.Line24.Width = 0.0!
        Me.Line24.X1 = 8.125!
        Me.Line24.X2 = 8.125!
        Me.Line24.Y1 = 0.9375!
        Me.Line24.Y2 = 1.5!
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
        Me.Line3.Height = 0.5625!
        Me.Line3.Left = 1.5625!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.9375!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 1.5625!
        Me.Line3.X2 = 1.5625!
        Me.Line3.Y1 = 0.9375!
        Me.Line3.Y2 = 1.5!
        '
        'Label2
        '
        Me.Label2.Border.BottomColor = System.Drawing.Color.Black
        Me.Label2.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.LeftColor = System.Drawing.Color.Black
        Me.Label2.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.RightColor = System.Drawing.Color.Black
        Me.Label2.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Border.TopColor = System.Drawing.Color.Black
        Me.Label2.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label2.Height = 0.4375!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.5!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label2.Text = "Receipt #"
        Me.Label2.Top = 1.0!
        Me.Label2.Width = 1.0!
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
        Me.Line4.Height = 0.5625!
        Me.Line4.Left = 2.1875!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.9375!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 2.1875!
        Me.Line4.X2 = 2.1875!
        Me.Line4.Y1 = 0.9375!
        Me.Line4.Y2 = 1.5!
        '
        'Line7
        '
        Me.Line7.Border.BottomColor = System.Drawing.Color.Black
        Me.Line7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.LeftColor = System.Drawing.Color.Black
        Me.Line7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.RightColor = System.Drawing.Color.Black
        Me.Line7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Border.TopColor = System.Drawing.Color.Black
        Me.Line7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line7.Height = 0.5625!
        Me.Line7.Left = 3.625!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.9375!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 3.625!
        Me.Line7.X2 = 3.625!
        Me.Line7.Y1 = 0.9375!
        Me.Line7.Y2 = 1.5!
        '
        'Line9
        '
        Me.Line9.Border.BottomColor = System.Drawing.Color.Black
        Me.Line9.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.LeftColor = System.Drawing.Color.Black
        Me.Line9.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.RightColor = System.Drawing.Color.Black
        Me.Line9.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Border.TopColor = System.Drawing.Color.Black
        Me.Line9.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line9.Height = 0.5625!
        Me.Line9.Left = 5.125!
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.9375!
        Me.Line9.Width = 0.0!
        Me.Line9.X1 = 5.125!
        Me.Line9.X2 = 5.125!
        Me.Line9.Y1 = 0.9375!
        Me.Line9.Y2 = 1.5!
        '
        'Label4
        '
        Me.Label4.Border.BottomColor = System.Drawing.Color.Black
        Me.Label4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.LeftColor = System.Drawing.Color.Black
        Me.Label4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.RightColor = System.Drawing.Color.Black
        Me.Label4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Border.TopColor = System.Drawing.Color.Black
        Me.Label4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label4.Height = 0.4375!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 1.625!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label4.Text = "Unit #"
        Me.Label4.Top = 1.0!
        Me.Label4.Width = 0.5!
        '
        'Label7
        '
        Me.Label7.Border.BottomColor = System.Drawing.Color.Black
        Me.Label7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.LeftColor = System.Drawing.Color.Black
        Me.Label7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.RightColor = System.Drawing.Color.Black
        Me.Label7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Border.TopColor = System.Drawing.Color.Black
        Me.Label7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label7.Height = 0.4375!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 4.3125!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label7.Text = "Amount"
        Me.Label7.Top = 1.0!
        Me.Label7.Width = 0.75!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label10.Height = 0.4375!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 5.1875!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label10.Text = "Bank"
        Me.Label10.Top = 1.0!
        Me.Label10.Width = 1.375!
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
        Me.Line2.Height = 0.5625!
        Me.Line2.Left = 4.25!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.9375!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 4.25!
        Me.Line2.X2 = 4.25!
        Me.Line2.Y1 = 0.9375!
        Me.Line2.Y2 = 1.5!
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
        Me.Line1.Left = 0.125!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.9375!
        Me.Line1.Width = 8.0!
        Me.Line1.X1 = 8.125!
        Me.Line1.X2 = 0.125!
        Me.Line1.Y1 = 0.9375!
        Me.Line1.Y2 = 0.9375!
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
        Me.fldCompany.DataField = "Project"
        Me.fldCompany.Height = 0.3125!
        Me.fldCompany.Left = 0.1875!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.fldCompany.Text = "Title"
        Me.fldCompany.Top = 0.3125!
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
        Me.fldTitle.Left = 0.1875!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 12pt; font-fam" & _
            "ily: Calibri; vertical-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.625!
        Me.fldTitle.Width = 7.875!
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
        Me.Label8.Left = 6.375!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8.25pt; "
        Me.Label8.Text = "Page No."
        Me.Label8.Top = 0.0625!
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
        Me.fldPage.Left = 7.0625!
        Me.fldPage.Name = "fldPage"
        Me.fldPage.Style = "text-align: right; font-size: 8.25pt; "
        Me.fldPage.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.fldPage.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.fldPage.Text = "Page"
        Me.fldPage.Top = 0.0625!
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
        Me.Label9.Left = 7.4375!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "text-align: center; font-size: 8.25pt; "
        Me.Label9.Text = "of"
        Me.Label9.Top = 0.0625!
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
        Me.fldPages.Left = 7.625!
        Me.fldPages.Name = "fldPages"
        Me.fldPages.Style = "text-align: left; font-size: 8.25pt; "
        Me.fldPages.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.fldPages.Text = "Pages"
        Me.fldPages.Top = 0.0625!
        Me.fldPages.Width = 0.4375!
        '
        'Line11
        '
        Me.Line11.Border.BottomColor = System.Drawing.Color.Black
        Me.Line11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.LeftColor = System.Drawing.Color.Black
        Me.Line11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.RightColor = System.Drawing.Color.Black
        Me.Line11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Border.TopColor = System.Drawing.Color.Black
        Me.Line11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line11.Height = 0.5625!
        Me.Line11.Left = 0.5!
        Me.Line11.LineWeight = 1.0!
        Me.Line11.Name = "Line11"
        Me.Line11.Top = 0.9375!
        Me.Line11.Width = 0.0!
        Me.Line11.X1 = 0.5!
        Me.Line11.X2 = 0.5!
        Me.Line11.Y1 = 0.9375!
        Me.Line11.Y2 = 1.5!
        '
        'Label3
        '
        Me.Label3.Border.BottomColor = System.Drawing.Color.Black
        Me.Label3.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.LeftColor = System.Drawing.Color.Black
        Me.Label3.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.RightColor = System.Drawing.Color.Black
        Me.Label3.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Border.TopColor = System.Drawing.Color.Black
        Me.Label3.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label3.Height = 0.4375!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.25!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label3.Text = "Customer"
        Me.Label3.Top = 1.0!
        Me.Label3.Width = 1.3125!
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
        Me.Label1.Height = 0.4375!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 3.6875!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label1.Text = "Status"
        Me.Label1.Top = 1.0!
        Me.Label1.Width = 0.5!
        '
        'Line5
        '
        Me.Line5.Border.BottomColor = System.Drawing.Color.Black
        Me.Line5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.LeftColor = System.Drawing.Color.Black
        Me.Line5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.RightColor = System.Drawing.Color.Black
        Me.Line5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Border.TopColor = System.Drawing.Color.Black
        Me.Line5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line5.Height = 0.5625!
        Me.Line5.Left = 6.625!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.9375!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 6.625!
        Me.Line5.X2 = 6.625!
        Me.Line5.Y1 = 0.9375!
        Me.Line5.Y2 = 1.5!
        '
        'Label5
        '
        Me.Label5.Border.BottomColor = System.Drawing.Color.Black
        Me.Label5.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.LeftColor = System.Drawing.Color.Black
        Me.Label5.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.RightColor = System.Drawing.Color.Black
        Me.Label5.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Border.TopColor = System.Drawing.Color.Black
        Me.Label5.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label5.Height = 0.4375!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 6.6875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label5.Text = "Cancel Status"
        Me.Label5.Top = 1.0!
        Me.Label5.Width = 0.5!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldSNo, Me.fldInvoiceNo, Me.TextBox3, Me.fldReceiptNo, Me.TextBox6, Me.TextBox4, Me.TextBox7, Me.TextBox1, Me.TextBox2})
        Me.Detail1.Height = 0.3229167!
        Me.Detail1.Name = "Detail1"
        '
        'fldSNo
        '
        Me.fldSNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldSNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldSNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldSNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldSNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldSNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldSNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldSNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldSNo.DataField = "PaymentType"
        Me.fldSNo.Height = 0.3125!
        Me.fldSNo.Left = 0.125!
        Me.fldSNo.Name = "fldSNo"
        Me.fldSNo.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.fldSNo.Text = Nothing
        Me.fldSNo.Top = 0.0!
        Me.fldSNo.Width = 0.375!
        '
        'fldInvoiceNo
        '
        Me.fldInvoiceNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldInvoiceNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldInvoiceNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldInvoiceNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldInvoiceNo.DataField = "UnitNumber"
        Me.fldInvoiceNo.Height = 0.3125!
        Me.fldInvoiceNo.Left = 0.5!
        Me.fldInvoiceNo.Name = "fldInvoiceNo"
        Me.fldInvoiceNo.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.fldInvoiceNo.Text = "RCTEBD-00000001"
        Me.fldInvoiceNo.Top = 0.0!
        Me.fldInvoiceNo.Width = 1.0625!
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
        Me.TextBox3.DataField = "UnitNumber"
        Me.TextBox3.Height = 0.3125!
        Me.TextBox3.Left = 1.5625!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.625!
        '
        'fldReceiptNo
        '
        Me.fldReceiptNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiptNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiptNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiptNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.fldReceiptNo.DataField = "Customer"
        Me.fldReceiptNo.Height = 0.3125!
        Me.fldReceiptNo.Left = 2.1875!
        Me.fldReceiptNo.Name = "fldReceiptNo"
        Me.fldReceiptNo.OutputFormat = resources.GetString("fldReceiptNo.OutputFormat")
        Me.fldReceiptNo.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.fldReceiptNo.Text = Nothing
        Me.fldReceiptNo.Top = 0.0!
        Me.fldReceiptNo.Width = 1.4375!
        '
        'TextBox6
        '
        Me.TextBox6.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox6.DataField = "Amount"
        Me.TextBox6.Height = 0.3125!
        Me.TextBox6.Left = 4.25!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" & _
            "ical-align: middle; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.875!
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
        Me.TextBox4.DataField = "Status"
        Me.TextBox4.Height = 0.3125!
        Me.TextBox4.Left = 3.625!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 0; text-align: right; font-size: 8.25pt; font-family: Calibri; vert" & _
            "ical-align: middle; "
        Me.TextBox4.Text = Nothing
        Me.TextBox4.Top = 0.0!
        Me.TextBox4.Width = 0.625!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.TextBox7.DataField = "Bank"
        Me.TextBox7.Height = 0.3125!
        Me.TextBox7.Left = 5.125!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 1.5!
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
        Me.TextBox1.DataField = "CancelStatus"
        Me.TextBox1.Height = 0.3125!
        Me.TextBox1.Left = 6.625!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 0.0!
        Me.TextBox1.Width = 0.625!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.05208333!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Height = 0.5520833!
        Me.ReportHeader1.Name = "ReportHeader1"
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Line13, Me.Line26, Me.Label22, Me.TextBox5})
        Me.ReportFooter1.Height = 0.625!
        Me.ReportFooter1.Name = "ReportFooter1"
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
        Me.Line13.Width = 8.0!
        Me.Line13.X1 = 8.1875!
        Me.Line13.X2 = 0.1875!
        Me.Line13.Y1 = 0.0!
        Me.Line13.Y2 = 0.0!
        '
        'Line26
        '
        Me.Line26.Border.BottomColor = System.Drawing.Color.Black
        Me.Line26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.LeftColor = System.Drawing.Color.Black
        Me.Line26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.RightColor = System.Drawing.Color.Black
        Me.Line26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Border.TopColor = System.Drawing.Color.Black
        Me.Line26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line26.Height = 0.0!
        Me.Line26.Left = 0.1875!
        Me.Line26.LineWeight = 1.0!
        Me.Line26.Name = "Line26"
        Me.Line26.Top = 0.375!
        Me.Line26.Width = 8.0!
        Me.Line26.X1 = 8.1875!
        Me.Line26.X2 = 0.1875!
        Me.Line26.Y1 = 0.375!
        Me.Line26.Y2 = 0.375!
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
        Me.Label22.Left = 0.25!
        Me.Label22.Name = "Label22"
        Me.Label22.Style = "color: Blue; ddo-char-set: 0; text-align: justify; font-weight: bold; font-size: " & _
            "8.25pt; font-family: Arial Narrow; vertical-align: middle; "
        Me.Label22.Text = "Total"
        Me.Label22.Top = 0.0625!
        Me.Label22.Width = 1.625!
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
        Me.TextBox5.DataField = "Amount"
        Me.TextBox5.Height = 0.25!
        Me.TextBox5.Left = 4.25!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; font-fa" & _
            "mily: Microsoft Sans Serif; vertical-align: middle; "
        Me.TextBox5.SummaryGroup = "GroupHeader1"
        Me.TextBox5.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox5.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0625!
        Me.TextBox5.Width = 0.875!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.DataField = "UnitNumber"
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.02083333!
        Me.GroupFooter1.Name = "GroupFooter1"
        '
        'Label6
        '
        Me.Label6.Border.BottomColor = System.Drawing.Color.Black
        Me.Label6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.LeftColor = System.Drawing.Color.Black
        Me.Label6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.RightColor = System.Drawing.Color.Black
        Me.Label6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Border.TopColor = System.Drawing.Color.Black
        Me.Label6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label6.Height = 0.4375!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 7.3125!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Calibri; vertical-align: middle; "
        Me.Label6.Text = "Last Letter"
        Me.Label6.Top = 1.0!
        Me.Label6.Width = 0.75!
        '
        'Line6
        '
        Me.Line6.Border.BottomColor = System.Drawing.Color.Black
        Me.Line6.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.LeftColor = System.Drawing.Color.Black
        Me.Line6.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.RightColor = System.Drawing.Color.Black
        Me.Line6.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Border.TopColor = System.Drawing.Color.Black
        Me.Line6.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line6.Height = 0.5625!
        Me.Line6.Left = 7.25!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.9375!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 7.25!
        Me.Line6.X2 = 7.25!
        Me.Line6.Y1 = 0.9375!
        Me.Line6.Y2 = 1.5!
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
        Me.TextBox2.DataField = "LetterType"
        Me.TextBox2.Height = 0.3125!
        Me.TextBox2.Left = 7.25!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: center; font-size: 8.25pt; font-family: Calibri; ver" & _
            "tical-align: middle; "
        Me.TextBox2.Text = Nothing
        Me.TextBox2.Top = 0.0!
        Me.TextBox2.Width = 0.875!
        '
        'rptDateWiseReceiptReport
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
        Me.PrintWidth = 8.208333!
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
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldSNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldReceiptNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents fldSNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldInvoiceNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldReceiptNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line23 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line24 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line7 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line9 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line13 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line26 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents fldCompany As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldTitle As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldPage As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldPages As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line11 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
End Class
