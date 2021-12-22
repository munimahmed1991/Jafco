<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptCustomerStatement
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptCustomerStatement))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.Label15 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.Label61 = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.fldChequeDate = New DataDynamics.ActiveReports.TextBox
        Me.Line25 = New DataDynamics.ActiveReports.Line
        Me.fldInvoiceNo = New DataDynamics.ActiveReports.TextBox
        Me.TextBox3 = New DataDynamics.ActiveReports.TextBox
        Me.fldReceiptDate = New DataDynamics.ActiveReports.TextBox
        Me.fldReceiptNo = New DataDynamics.ActiveReports.TextBox
        Me.TextBox6 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox7 = New DataDynamics.ActiveReports.TextBox
        Me.txtBalPer = New DataDynamics.ActiveReports.TextBox
        Me.Label45 = New DataDynamics.ActiveReports.Label
        Me.fldMaualReceiptNo = New DataDynamics.ActiveReports.TextBox
        Me.TextBox5 = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.ReportHeader1 = New DataDynamics.ActiveReports.ReportHeader
        Me.fldTitle = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.fldPage = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.fldPages = New DataDynamics.ActiveReports.TextBox
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Label16 = New DataDynamics.ActiveReports.Label
        Me.Label18 = New DataDynamics.ActiveReports.Label
        Me.Label19 = New DataDynamics.ActiveReports.Label
        Me.Label20 = New DataDynamics.ActiveReports.Label
        Me.Label21 = New DataDynamics.ActiveReports.Label
        Me.Label23 = New DataDynamics.ActiveReports.Label
        Me.Label24 = New DataDynamics.ActiveReports.Label
        Me.Label25 = New DataDynamics.ActiveReports.Label
        Me.Label26 = New DataDynamics.ActiveReports.Label
        Me.Label27 = New DataDynamics.ActiveReports.Label
        Me.Label28 = New DataDynamics.ActiveReports.Label
        Me.Label29 = New DataDynamics.ActiveReports.Label
        Me.Label30 = New DataDynamics.ActiveReports.Label
        Me.Label31 = New DataDynamics.ActiveReports.Label
        Me.Label32 = New DataDynamics.ActiveReports.Label
        Me.Label33 = New DataDynamics.ActiveReports.Label
        Me.Label34 = New DataDynamics.ActiveReports.Label
        Me.Label35 = New DataDynamics.ActiveReports.Label
        Me.Label36 = New DataDynamics.ActiveReports.Label
        Me.Label37 = New DataDynamics.ActiveReports.Label
        Me.Label38 = New DataDynamics.ActiveReports.Label
        Me.Label39 = New DataDynamics.ActiveReports.Label
        Me.Label41 = New DataDynamics.ActiveReports.Label
        Me.Label42 = New DataDynamics.ActiveReports.Label
        Me.Label44 = New DataDynamics.ActiveReports.Label
        Me.Label48 = New DataDynamics.ActiveReports.Label
        Me.Label50 = New DataDynamics.ActiveReports.Label
        Me.Label51 = New DataDynamics.ActiveReports.Label
        Me.Label52 = New DataDynamics.ActiveReports.Label
        Me.Label53 = New DataDynamics.ActiveReports.Label
        Me.Label54 = New DataDynamics.ActiveReports.Label
        Me.Label55 = New DataDynamics.ActiveReports.Label
        Me.txtCashAmount = New DataDynamics.ActiveReports.TextBox
        Me.Label56 = New DataDynamics.ActiveReports.Label
        Me.Label57 = New DataDynamics.ActiveReports.Label
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.Label58 = New DataDynamics.ActiveReports.Label
        Me.Label59 = New DataDynamics.ActiveReports.Label
        Me.TextBox10 = New DataDynamics.ActiveReports.TextBox
        Me.lblExtraLandCharges = New DataDynamics.ActiveReports.Label
        Me.lblSeperatorExtraLand = New DataDynamics.ActiveReports.Label
        Me.TextBox16 = New DataDynamics.ActiveReports.TextBox
        Me.Label62 = New DataDynamics.ActiveReports.Label
        Me.Label63 = New DataDynamics.ActiveReports.Label
        Me.Label64 = New DataDynamics.ActiveReports.Label
        Me.Label65 = New DataDynamics.ActiveReports.Label
        Me.TextBox17 = New DataDynamics.ActiveReports.TextBox
        Me.lblExtraCharges = New DataDynamics.ActiveReports.Label
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.Label66 = New DataDynamics.ActiveReports.Label
        Me.txtExtraLandCharges = New DataDynamics.ActiveReports.TextBox
        Me.lblExtraLandDescription = New DataDynamics.ActiveReports.Label
        Me.fldApplyExtraLand = New DataDynamics.ActiveReports.Label
        Me.Label46 = New DataDynamics.ActiveReports.Label
        Me.Label47 = New DataDynamics.ActiveReports.Label
        Me.Label60 = New DataDynamics.ActiveReports.Label
        Me.fldStatus = New DataDynamics.ActiveReports.Label
        Me.Label67 = New DataDynamics.ActiveReports.Label
        Me.Label68 = New DataDynamics.ActiveReports.Label
        Me.Label69 = New DataDynamics.ActiveReports.Label
        Me.TextBox1 = New DataDynamics.ActiveReports.TextBox
        Me.ReportFooter1 = New DataDynamics.ActiveReports.ReportFooter
        Me.Label22 = New DataDynamics.ActiveReports.Label
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.txtTotalReceipt = New DataDynamics.ActiveReports.TextBox
        Me.txtPerCash = New DataDynamics.ActiveReports.TextBox
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.TextBox4 = New DataDynamics.ActiveReports.TextBox
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Shape1 = New DataDynamics.ActiveReports.Shape
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        CType(Me.Label15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldInvoiceNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldReceiptDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldReceiptNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBalPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldMaualReceiptNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExtraLandCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblSeperatorExtraLand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExtraCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtExtraLandCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblExtraLandDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldApplyExtraLand, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalReceipt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPerCash, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label15, Me.Label2, Me.Label3, Me.Label4, Me.Label5, Me.Label6, Me.Label7, Me.Label10, Me.Label61})
        Me.PageHeader1.Height = 0.448!
        Me.PageHeader1.Name = "PageHeader1"
        '
        'Label15
        '
        Me.Label15.Border.BottomColor = System.Drawing.Color.Black
        Me.Label15.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.LeftColor = System.Drawing.Color.Black
        Me.Label15.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.RightColor = System.Drawing.Color.Black
        Me.Label15.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Border.TopColor = System.Drawing.Color.Black
        Me.Label15.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label15.Height = 0.375!
        Me.Label15.HyperLink = Nothing
        Me.Label15.Left = 0.125!
        Me.Label15.Name = "Label15"
        Me.Label15.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label15.Text = "Description of Installment"
        Me.Label15.Top = 0.0625!
        Me.Label15.Width = 1.1875!
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
        Me.Label2.Height = 0.375!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 1.3125!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label2.Text = "Invoice #"
        Me.Label2.Top = 0.0625!
        Me.Label2.Width = 0.875!
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
        Me.Label3.Height = 0.375!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 2.1875!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label3.Text = "Due Date"
        Me.Label3.Top = 0.0625!
        Me.Label3.Width = 0.8125!
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
        Me.Label4.Height = 0.375!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 3.0!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label4.Text = "Invoice Amount"
        Me.Label4.Top = 0.0625!
        Me.Label4.Width = 0.875!
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
        Me.Label5.Height = 0.375!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 3.875!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label5.Text = "Payment Date"
        Me.Label5.Top = 0.0625!
        Me.Label5.Width = 0.8125!
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
        Me.Label6.Height = 0.375!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 4.6875!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label6.Text = "Receipt No"
        Me.Label6.Top = 0.0625!
        Me.Label6.Width = 0.875!
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
        Me.Label7.Height = 0.375!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 6.0625!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label7.Text = "Receipt Amount"
        Me.Label7.Top = 0.0625!
        Me.Label7.Width = 0.875!
        '
        'Label10
        '
        Me.Label10.Border.BottomColor = System.Drawing.Color.Black
        Me.Label10.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.LeftColor = System.Drawing.Color.Black
        Me.Label10.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.RightColor = System.Drawing.Color.Black
        Me.Label10.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Border.TopColor = System.Drawing.Color.Black
        Me.Label10.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label10.Height = 0.375!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 6.9375!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label10.Text = "Balance"
        Me.Label10.Top = 0.0625!
        Me.Label10.Width = 1.125!
        '
        'Label61
        '
        Me.Label61.Border.BottomColor = System.Drawing.Color.Black
        Me.Label61.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label61.Border.LeftColor = System.Drawing.Color.Black
        Me.Label61.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label61.Border.RightColor = System.Drawing.Color.Black
        Me.Label61.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label61.Border.TopColor = System.Drawing.Color.Black
        Me.Label61.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.Solid
        Me.Label61.Height = 0.375!
        Me.Label61.HyperLink = Nothing
        Me.Label61.Left = 5.5625!
        Me.Label61.Name = "Label61"
        Me.Label61.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 8.25pt; font-f" & _
            "amily: Arial; vertical-align: middle; "
        Me.Label61.Text = "Manual Receipt"
        Me.Label61.Top = 0.0625!
        Me.Label61.Width = 0.5!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldChequeDate, Me.Line25, Me.fldInvoiceNo, Me.TextBox3, Me.fldReceiptDate, Me.fldReceiptNo, Me.TextBox6, Me.TextBox7, Me.txtBalPer, Me.Label45, Me.fldMaualReceiptNo, Me.TextBox5})
        Me.Detail1.Height = 0.3020833!
        Me.Detail1.Name = "Detail1"
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
        Me.fldChequeDate.DataField = "PaymentType"
        Me.fldChequeDate.Height = 0.25!
        Me.fldChequeDate.Left = 0.125!
        Me.fldChequeDate.Name = "fldChequeDate"
        Me.fldChequeDate.Style = "ddo-char-set: 0; text-align: left; font-size: 6.75pt; font-family: Arial; vertica" & _
            "l-align: middle; "
        Me.fldChequeDate.Text = Nothing
        Me.fldChequeDate.Top = 0.0!
        Me.fldChequeDate.Width = 1.1875!
        '
        'Line25
        '
        Me.Line25.Border.BottomColor = System.Drawing.Color.Black
        Me.Line25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.LeftColor = System.Drawing.Color.Black
        Me.Line25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.RightColor = System.Drawing.Color.Black
        Me.Line25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Border.TopColor = System.Drawing.Color.Black
        Me.Line25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line25.Height = 0.0!
        Me.Line25.Left = 0.125!
        Me.Line25.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line25.LineWeight = 1.0!
        Me.Line25.Name = "Line25"
        Me.Line25.Top = 0.2916667!
        Me.Line25.Width = 8.0!
        Me.Line25.X1 = 8.125!
        Me.Line25.X2 = 0.125!
        Me.Line25.Y1 = 0.2916667!
        Me.Line25.Y2 = 0.2916667!
        '
        'fldInvoiceNo
        '
        Me.fldInvoiceNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldInvoiceNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldInvoiceNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldInvoiceNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldInvoiceNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldInvoiceNo.DataField = "InvoiceNo"
        Me.fldInvoiceNo.Height = 0.25!
        Me.fldInvoiceNo.Left = 1.3125!
        Me.fldInvoiceNo.Name = "fldInvoiceNo"
        Me.fldInvoiceNo.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.fldInvoiceNo.Text = Nothing
        Me.fldInvoiceNo.Top = 0.0!
        Me.fldInvoiceNo.Width = 0.875!
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
        Me.TextBox3.DataField = "InvoiceAmount"
        Me.TextBox3.Height = 0.25!
        Me.TextBox3.Left = 3.0!
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.OutputFormat = resources.GetString("TextBox3.OutputFormat")
        Me.TextBox3.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.TextBox3.Text = Nothing
        Me.TextBox3.Top = 0.0!
        Me.TextBox3.Width = 0.875!
        '
        'fldReceiptDate
        '
        Me.fldReceiptDate.Border.BottomColor = System.Drawing.Color.Black
        Me.fldReceiptDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptDate.Border.LeftColor = System.Drawing.Color.Black
        Me.fldReceiptDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptDate.Border.RightColor = System.Drawing.Color.Black
        Me.fldReceiptDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptDate.Border.TopColor = System.Drawing.Color.Black
        Me.fldReceiptDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptDate.Height = 0.25!
        Me.fldReceiptDate.Left = 3.875!
        Me.fldReceiptDate.Name = "fldReceiptDate"
        Me.fldReceiptDate.OutputFormat = resources.GetString("fldReceiptDate.OutputFormat")
        Me.fldReceiptDate.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.fldReceiptDate.Text = Nothing
        Me.fldReceiptDate.Top = 0.0!
        Me.fldReceiptDate.Width = 0.8125!
        '
        'fldReceiptNo
        '
        Me.fldReceiptNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldReceiptNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldReceiptNo.Height = 0.25!
        Me.fldReceiptNo.Left = 4.6875!
        Me.fldReceiptNo.Name = "fldReceiptNo"
        Me.fldReceiptNo.Style = "ddo-char-set: 0; text-align: left; font-size: 6.75pt; font-family: Arial; vertica" & _
            "l-align: middle; "
        Me.fldReceiptNo.Text = Nothing
        Me.fldReceiptNo.Top = 0.0!
        Me.fldReceiptNo.Width = 0.875!
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
        Me.TextBox6.DataField = "ReceiptAmount"
        Me.TextBox6.Height = 0.25!
        Me.TextBox6.Left = 6.0625!
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.OutputFormat = resources.GetString("TextBox6.OutputFormat")
        Me.TextBox6.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.TextBox6.Text = Nothing
        Me.TextBox6.Top = 0.0!
        Me.TextBox6.Width = 0.875!
        '
        'TextBox7
        '
        Me.TextBox7.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox7.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox7.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox7.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox7.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox7.DataField = "Balance"
        Me.TextBox7.Height = 0.25!
        Me.TextBox7.Left = 6.9375!
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.OutputFormat = resources.GetString("TextBox7.OutputFormat")
        Me.TextBox7.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.TextBox7.Text = Nothing
        Me.TextBox7.Top = 0.0!
        Me.TextBox7.Width = 0.875!
        '
        'txtBalPer
        '
        Me.txtBalPer.Border.BottomColor = System.Drawing.Color.Black
        Me.txtBalPer.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalPer.Border.LeftColor = System.Drawing.Color.Black
        Me.txtBalPer.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalPer.Border.RightColor = System.Drawing.Color.Black
        Me.txtBalPer.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalPer.Border.TopColor = System.Drawing.Color.Black
        Me.txtBalPer.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtBalPer.Height = 0.25!
        Me.txtBalPer.Left = 7.8125!
        Me.txtBalPer.Name = "txtBalPer"
        Me.txtBalPer.OutputFormat = resources.GetString("txtBalPer.OutputFormat")
        Me.txtBalPer.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Arial; vertic" & _
            "al-align: middle; "
        Me.txtBalPer.SummaryGroup = "GroupHeader1"
        Me.txtBalPer.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.txtBalPer.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.txtBalPer.Text = Nothing
        Me.txtBalPer.Top = 0.0!
        Me.txtBalPer.Width = 0.1875!
        '
        'Label45
        '
        Me.Label45.Border.BottomColor = System.Drawing.Color.Black
        Me.Label45.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Border.LeftColor = System.Drawing.Color.Black
        Me.Label45.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Border.RightColor = System.Drawing.Color.Black
        Me.Label45.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Border.TopColor = System.Drawing.Color.Black
        Me.Label45.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label45.Height = 0.25!
        Me.Label45.HyperLink = Nothing
        Me.Label45.Left = 8.0!
        Me.Label45.Name = "Label45"
        Me.Label45.Style = "ddo-char-set: 0; text-align: justify; font-weight: normal; font-size: 6.75pt; fon" & _
            "t-family: Arial; vertical-align: middle; "
        Me.Label45.Text = "%"
        Me.Label45.Top = 0.0!
        Me.Label45.Width = 0.125!
        '
        'fldMaualReceiptNo
        '
        Me.fldMaualReceiptNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldMaualReceiptNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldMaualReceiptNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldMaualReceiptNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldMaualReceiptNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldMaualReceiptNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldMaualReceiptNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldMaualReceiptNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldMaualReceiptNo.Height = 0.25!
        Me.fldMaualReceiptNo.Left = 5.5625!
        Me.fldMaualReceiptNo.Name = "fldMaualReceiptNo"
        Me.fldMaualReceiptNo.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.fldMaualReceiptNo.Text = Nothing
        Me.fldMaualReceiptNo.Top = 0.0!
        Me.fldMaualReceiptNo.Width = 0.5!
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
        Me.TextBox5.DataField = "InvoiceDate"
        Me.TextBox5.Height = 0.25!
        Me.TextBox5.Left = 2.1875!
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.OutputFormat = resources.GetString("TextBox5.OutputFormat")
        Me.TextBox5.Style = "ddo-char-set: 0; text-align: center; font-size: 6.75pt; font-family: Arial; verti" & _
            "cal-align: middle; "
        Me.TextBox5.Text = Nothing
        Me.TextBox5.Top = 0.0!
        Me.TextBox5.Width = 0.8125!
        '
        'PageFooter1
        '
        Me.PageFooter1.Height = 0.0!
        Me.PageFooter1.Name = "PageFooter1"
        '
        'ReportHeader1
        '
        Me.ReportHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Shape1, Me.fldTitle, Me.Label8, Me.fldPage, Me.Label9, Me.fldPages, Me.Label11, Me.Label12, Me.Label13, Me.Label16, Me.Label18, Me.Label19, Me.Label20, Me.Label21, Me.Label23, Me.Label24, Me.Label25, Me.Label26, Me.Label27, Me.Label28, Me.Label29, Me.Label30, Me.Label31, Me.Label32, Me.Label33, Me.Label34, Me.Label35, Me.Label36, Me.Label37, Me.Label38, Me.Label39, Me.Label41, Me.Label42, Me.Label44, Me.Label48, Me.Label50, Me.Label51, Me.Label52, Me.Label53, Me.Label54, Me.Label55, Me.txtCashAmount, Me.Label56, Me.Label57, Me.TextBox9, Me.Label58, Me.Label59, Me.TextBox10, Me.lblExtraLandCharges, Me.lblSeperatorExtraLand, Me.TextBox16, Me.Label62, Me.Label63, Me.Label64, Me.Label65, Me.TextBox17, Me.lblExtraCharges, Me.Label14, Me.Label66, Me.txtExtraLandCharges, Me.lblExtraLandDescription, Me.fldApplyExtraLand, Me.Label46, Me.Label47, Me.Label60, Me.fldStatus, Me.Label67, Me.Label68, Me.Label69, Me.TextBox1, Me.Line1, Me.Line2, Me.Line3})
        Me.ReportHeader1.Height = 4.708333!
        Me.ReportHeader1.Name = "ReportHeader1"
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
        Me.fldTitle.Height = 0.375!
        Me.fldTitle.Left = 0.125!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 14.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.4375!
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
        Me.Label8.Left = 6.3125!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "ddo-char-set: 1; font-weight: bold; font-size: 9.25pt; font-family: Calibri; "
        Me.Label8.Text = "Page No."
        Me.Label8.Top = 0.1875!
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
        Me.fldPage.Left = 7.0!
        Me.fldPage.Name = "fldPage"
        Me.fldPage.Style = "ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9.25pt; font-fa" & _
            "mily: Calibri; "
        Me.fldPage.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.fldPage.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.fldPage.Text = "Page"
        Me.fldPage.Top = 0.1875!
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
        Me.Label9.Left = 7.375!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9.25pt; font-f" & _
            "amily: Calibri; "
        Me.Label9.Text = "of"
        Me.Label9.Top = 0.1875!
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
        Me.fldPages.Left = 7.5625!
        Me.fldPages.Name = "fldPages"
        Me.fldPages.Style = "ddo-char-set: 1; text-align: left; font-weight: bold; font-size: 9.25pt; font-fam" & _
            "ily: Calibri; "
        Me.fldPages.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.fldPages.Text = "Pages"
        Me.fldPages.Top = 0.1875!
        Me.fldPages.Width = 0.4375!
        '
        'Label11
        '
        Me.Label11.Border.BottomColor = System.Drawing.Color.Black
        Me.Label11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.LeftColor = System.Drawing.Color.Black
        Me.Label11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.RightColor = System.Drawing.Color.Black
        Me.Label11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Border.TopColor = System.Drawing.Color.Black
        Me.Label11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label11.Height = 0.1875!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.1875!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label11.Text = "Name"
        Me.Label11.Top = 1.3125!
        Me.Label11.Width = 0.5625!
        '
        'Label12
        '
        Me.Label12.Border.BottomColor = System.Drawing.Color.Black
        Me.Label12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.LeftColor = System.Drawing.Color.Black
        Me.Label12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.RightColor = System.Drawing.Color.Black
        Me.Label12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Border.TopColor = System.Drawing.Color.Black
        Me.Label12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label12.Height = 0.1875!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.1875!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label12.Text = "Address"
        Me.Label12.Top = 1.5!
        Me.Label12.Width = 0.5625!
        '
        'Label13
        '
        Me.Label13.Border.BottomColor = System.Drawing.Color.Black
        Me.Label13.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.LeftColor = System.Drawing.Color.Black
        Me.Label13.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.RightColor = System.Drawing.Color.Black
        Me.Label13.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Border.TopColor = System.Drawing.Color.Black
        Me.Label13.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label13.Height = 0.1875!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 0.1875!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label13.Text = "Phone #"
        Me.Label13.Top = 2.0!
        Me.Label13.Width = 0.5625!
        '
        'Label16
        '
        Me.Label16.Border.BottomColor = System.Drawing.Color.Black
        Me.Label16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.LeftColor = System.Drawing.Color.Black
        Me.Label16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.RightColor = System.Drawing.Color.Black
        Me.Label16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Border.TopColor = System.Drawing.Color.Black
        Me.Label16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label16.Height = 0.1875!
        Me.Label16.HyperLink = Nothing
        Me.Label16.Left = 0.1875!
        Me.Label16.Name = "Label16"
        Me.Label16.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label16.Text = "Mobile #"
        Me.Label16.Top = 2.1875!
        Me.Label16.Width = 0.5625!
        '
        'Label18
        '
        Me.Label18.Border.BottomColor = System.Drawing.Color.Black
        Me.Label18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.LeftColor = System.Drawing.Color.Black
        Me.Label18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.RightColor = System.Drawing.Color.Black
        Me.Label18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Border.TopColor = System.Drawing.Color.Black
        Me.Label18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label18.Height = 0.1875!
        Me.Label18.HyperLink = Nothing
        Me.Label18.Left = 0.8125!
        Me.Label18.Name = "Label18"
        Me.Label18.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label18.Text = ":"
        Me.Label18.Top = 1.3125!
        Me.Label18.Width = 0.0625!
        '
        'Label19
        '
        Me.Label19.Border.BottomColor = System.Drawing.Color.Black
        Me.Label19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.LeftColor = System.Drawing.Color.Black
        Me.Label19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.RightColor = System.Drawing.Color.Black
        Me.Label19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Border.TopColor = System.Drawing.Color.Black
        Me.Label19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label19.Height = 0.1875!
        Me.Label19.HyperLink = Nothing
        Me.Label19.Left = 0.8125!
        Me.Label19.Name = "Label19"
        Me.Label19.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label19.Text = ":"
        Me.Label19.Top = 1.5!
        Me.Label19.Width = 0.0625!
        '
        'Label20
        '
        Me.Label20.Border.BottomColor = System.Drawing.Color.Black
        Me.Label20.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.LeftColor = System.Drawing.Color.Black
        Me.Label20.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.RightColor = System.Drawing.Color.Black
        Me.Label20.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Border.TopColor = System.Drawing.Color.Black
        Me.Label20.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label20.Height = 0.1875!
        Me.Label20.HyperLink = Nothing
        Me.Label20.Left = 0.8125!
        Me.Label20.Name = "Label20"
        Me.Label20.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label20.Text = ":"
        Me.Label20.Top = 2.0!
        Me.Label20.Width = 0.0625!
        '
        'Label21
        '
        Me.Label21.Border.BottomColor = System.Drawing.Color.Black
        Me.Label21.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.LeftColor = System.Drawing.Color.Black
        Me.Label21.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.RightColor = System.Drawing.Color.Black
        Me.Label21.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Border.TopColor = System.Drawing.Color.Black
        Me.Label21.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label21.Height = 0.1875!
        Me.Label21.HyperLink = Nothing
        Me.Label21.Left = 0.8125!
        Me.Label21.Name = "Label21"
        Me.Label21.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label21.Text = ":"
        Me.Label21.Top = 2.1875!
        Me.Label21.Width = 0.0625!
        '
        'Label23
        '
        Me.Label23.Border.BottomColor = System.Drawing.Color.Black
        Me.Label23.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.LeftColor = System.Drawing.Color.Black
        Me.Label23.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.RightColor = System.Drawing.Color.Black
        Me.Label23.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Border.TopColor = System.Drawing.Color.Black
        Me.Label23.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label23.Height = 0.1875!
        Me.Label23.HyperLink = Nothing
        Me.Label23.Left = 4.5!
        Me.Label23.Name = "Label23"
        Me.Label23.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label23.Text = "Name"
        Me.Label23.Top = 1.3125!
        Me.Label23.Width = 0.5625!
        '
        'Label24
        '
        Me.Label24.Border.BottomColor = System.Drawing.Color.Black
        Me.Label24.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.LeftColor = System.Drawing.Color.Black
        Me.Label24.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.RightColor = System.Drawing.Color.Black
        Me.Label24.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Border.TopColor = System.Drawing.Color.Black
        Me.Label24.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label24.Height = 0.1875!
        Me.Label24.HyperLink = Nothing
        Me.Label24.Left = 5.125!
        Me.Label24.Name = "Label24"
        Me.Label24.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label24.Text = ":"
        Me.Label24.Top = 1.3125!
        Me.Label24.Width = 0.0625!
        '
        'Label25
        '
        Me.Label25.Border.BottomColor = System.Drawing.Color.Black
        Me.Label25.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.LeftColor = System.Drawing.Color.Black
        Me.Label25.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.RightColor = System.Drawing.Color.Black
        Me.Label25.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Border.TopColor = System.Drawing.Color.Black
        Me.Label25.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label25.Height = 0.1875!
        Me.Label25.HyperLink = Nothing
        Me.Label25.Left = 5.125!
        Me.Label25.Name = "Label25"
        Me.Label25.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label25.Text = ":"
        Me.Label25.Top = 1.5!
        Me.Label25.Width = 0.0625!
        '
        'Label26
        '
        Me.Label26.Border.BottomColor = System.Drawing.Color.Black
        Me.Label26.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.LeftColor = System.Drawing.Color.Black
        Me.Label26.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.RightColor = System.Drawing.Color.Black
        Me.Label26.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Border.TopColor = System.Drawing.Color.Black
        Me.Label26.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label26.Height = 0.1875!
        Me.Label26.HyperLink = Nothing
        Me.Label26.Left = 4.5!
        Me.Label26.Name = "Label26"
        Me.Label26.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label26.Text = "Address"
        Me.Label26.Top = 1.5!
        Me.Label26.Width = 0.5625!
        '
        'Label27
        '
        Me.Label27.Border.BottomColor = System.Drawing.Color.Black
        Me.Label27.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.LeftColor = System.Drawing.Color.Black
        Me.Label27.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.RightColor = System.Drawing.Color.Black
        Me.Label27.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Border.TopColor = System.Drawing.Color.Black
        Me.Label27.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label27.Height = 0.1875!
        Me.Label27.HyperLink = Nothing
        Me.Label27.Left = 4.5!
        Me.Label27.Name = "Label27"
        Me.Label27.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label27.Text = "Phone #"
        Me.Label27.Top = 2.0!
        Me.Label27.Width = 0.5625!
        '
        'Label28
        '
        Me.Label28.Border.BottomColor = System.Drawing.Color.Black
        Me.Label28.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.LeftColor = System.Drawing.Color.Black
        Me.Label28.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.RightColor = System.Drawing.Color.Black
        Me.Label28.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Border.TopColor = System.Drawing.Color.Black
        Me.Label28.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label28.Height = 0.1875!
        Me.Label28.HyperLink = Nothing
        Me.Label28.Left = 5.125!
        Me.Label28.Name = "Label28"
        Me.Label28.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label28.Text = ":"
        Me.Label28.Top = 2.0!
        Me.Label28.Width = 0.0625!
        '
        'Label29
        '
        Me.Label29.Border.BottomColor = System.Drawing.Color.Black
        Me.Label29.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.LeftColor = System.Drawing.Color.Black
        Me.Label29.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.RightColor = System.Drawing.Color.Black
        Me.Label29.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Border.TopColor = System.Drawing.Color.Black
        Me.Label29.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label29.Height = 0.1875!
        Me.Label29.HyperLink = Nothing
        Me.Label29.Left = 5.125!
        Me.Label29.Name = "Label29"
        Me.Label29.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label29.Text = ":"
        Me.Label29.Top = 2.1875!
        Me.Label29.Width = 0.0625!
        '
        'Label30
        '
        Me.Label30.Border.BottomColor = System.Drawing.Color.Black
        Me.Label30.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.LeftColor = System.Drawing.Color.Black
        Me.Label30.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.RightColor = System.Drawing.Color.Black
        Me.Label30.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Border.TopColor = System.Drawing.Color.Black
        Me.Label30.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label30.Height = 0.1875!
        Me.Label30.HyperLink = Nothing
        Me.Label30.Left = 4.5!
        Me.Label30.Name = "Label30"
        Me.Label30.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label30.Text = "Mobile #"
        Me.Label30.Top = 2.1875!
        Me.Label30.Width = 0.5625!
        '
        'Label31
        '
        Me.Label31.Border.BottomColor = System.Drawing.Color.Black
        Me.Label31.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.LeftColor = System.Drawing.Color.Black
        Me.Label31.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.RightColor = System.Drawing.Color.Black
        Me.Label31.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.Border.TopColor = System.Drawing.Color.Black
        Me.Label31.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label31.DataField = "CustomerName1"
        Me.Label31.Height = 0.1875!
        Me.Label31.HyperLink = Nothing
        Me.Label31.Left = 1.0!
        Me.Label31.Name = "Label31"
        Me.Label31.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label31.Text = "Name"
        Me.Label31.Top = 1.3125!
        Me.Label31.Width = 2.875!
        '
        'Label32
        '
        Me.Label32.Border.BottomColor = System.Drawing.Color.Black
        Me.Label32.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.LeftColor = System.Drawing.Color.Black
        Me.Label32.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.RightColor = System.Drawing.Color.Black
        Me.Label32.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.Border.TopColor = System.Drawing.Color.Black
        Me.Label32.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label32.DataField = "Address1"
        Me.Label32.Height = 0.5!
        Me.Label32.HyperLink = Nothing
        Me.Label32.Left = 1.0!
        Me.Label32.Name = "Label32"
        Me.Label32.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: top; "
        Me.Label32.Text = "Name"
        Me.Label32.Top = 1.5!
        Me.Label32.Width = 2.875!
        '
        'Label33
        '
        Me.Label33.Border.BottomColor = System.Drawing.Color.Black
        Me.Label33.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.LeftColor = System.Drawing.Color.Black
        Me.Label33.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.RightColor = System.Drawing.Color.Black
        Me.Label33.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.Border.TopColor = System.Drawing.Color.Black
        Me.Label33.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label33.DataField = "TelRes1"
        Me.Label33.Height = 0.1875!
        Me.Label33.HyperLink = Nothing
        Me.Label33.Left = 1.0!
        Me.Label33.Name = "Label33"
        Me.Label33.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label33.Text = "Name"
        Me.Label33.Top = 2.0!
        Me.Label33.Width = 2.875!
        '
        'Label34
        '
        Me.Label34.Border.BottomColor = System.Drawing.Color.Black
        Me.Label34.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.LeftColor = System.Drawing.Color.Black
        Me.Label34.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.RightColor = System.Drawing.Color.Black
        Me.Label34.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.Border.TopColor = System.Drawing.Color.Black
        Me.Label34.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label34.DataField = "Mobile1"
        Me.Label34.Height = 0.1875!
        Me.Label34.HyperLink = Nothing
        Me.Label34.Left = 1.0!
        Me.Label34.Name = "Label34"
        Me.Label34.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label34.Text = "Name"
        Me.Label34.Top = 2.1875!
        Me.Label34.Width = 2.875!
        '
        'Label35
        '
        Me.Label35.Border.BottomColor = System.Drawing.Color.Black
        Me.Label35.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.LeftColor = System.Drawing.Color.Black
        Me.Label35.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.RightColor = System.Drawing.Color.Black
        Me.Label35.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.Border.TopColor = System.Drawing.Color.Black
        Me.Label35.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label35.DataField = "CustomerName2"
        Me.Label35.Height = 0.1875!
        Me.Label35.HyperLink = Nothing
        Me.Label35.Left = 5.3125!
        Me.Label35.Name = "Label35"
        Me.Label35.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label35.Text = "Name"
        Me.Label35.Top = 1.3125!
        Me.Label35.Width = 2.625!
        '
        'Label36
        '
        Me.Label36.Border.BottomColor = System.Drawing.Color.Black
        Me.Label36.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.LeftColor = System.Drawing.Color.Black
        Me.Label36.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.RightColor = System.Drawing.Color.Black
        Me.Label36.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.Border.TopColor = System.Drawing.Color.Black
        Me.Label36.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label36.DataField = "Address2"
        Me.Label36.Height = 0.5!
        Me.Label36.HyperLink = Nothing
        Me.Label36.Left = 5.3125!
        Me.Label36.Name = "Label36"
        Me.Label36.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: top; "
        Me.Label36.Text = "Name"
        Me.Label36.Top = 1.5!
        Me.Label36.Width = 2.625!
        '
        'Label37
        '
        Me.Label37.Border.BottomColor = System.Drawing.Color.Black
        Me.Label37.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.LeftColor = System.Drawing.Color.Black
        Me.Label37.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.RightColor = System.Drawing.Color.Black
        Me.Label37.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.Border.TopColor = System.Drawing.Color.Black
        Me.Label37.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label37.DataField = "TelRes2"
        Me.Label37.Height = 0.1875!
        Me.Label37.HyperLink = Nothing
        Me.Label37.Left = 5.3125!
        Me.Label37.Name = "Label37"
        Me.Label37.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label37.Text = "Name"
        Me.Label37.Top = 2.0!
        Me.Label37.Width = 2.625!
        '
        'Label38
        '
        Me.Label38.Border.BottomColor = System.Drawing.Color.Black
        Me.Label38.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.LeftColor = System.Drawing.Color.Black
        Me.Label38.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.RightColor = System.Drawing.Color.Black
        Me.Label38.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.Border.TopColor = System.Drawing.Color.Black
        Me.Label38.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label38.DataField = "Mobile2"
        Me.Label38.Height = 0.1875!
        Me.Label38.HyperLink = Nothing
        Me.Label38.Left = 5.3125!
        Me.Label38.Name = "Label38"
        Me.Label38.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label38.Text = "Name"
        Me.Label38.Top = 2.1875!
        Me.Label38.Width = 2.625!
        '
        'Label39
        '
        Me.Label39.Border.BottomColor = System.Drawing.Color.Black
        Me.Label39.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.LeftColor = System.Drawing.Color.Black
        Me.Label39.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.RightColor = System.Drawing.Color.Black
        Me.Label39.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Border.TopColor = System.Drawing.Color.Black
        Me.Label39.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label39.Height = 0.25!
        Me.Label39.HyperLink = Nothing
        Me.Label39.Left = 0.1875!
        Me.Label39.Name = "Label39"
        Me.Label39.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label39.Text = "Unit #"
        Me.Label39.Top = 2.5!
        Me.Label39.Width = 0.5625!
        '
        'Label41
        '
        Me.Label41.Border.BottomColor = System.Drawing.Color.Black
        Me.Label41.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.LeftColor = System.Drawing.Color.Black
        Me.Label41.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.RightColor = System.Drawing.Color.Black
        Me.Label41.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.Border.TopColor = System.Drawing.Color.Black
        Me.Label41.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label41.DataField = "UnitNumber"
        Me.Label41.Height = 0.25!
        Me.Label41.HyperLink = Nothing
        Me.Label41.Left = 0.8125!
        Me.Label41.Name = "Label41"
        Me.Label41.Style = "ddo-char-set: 0; text-decoration: underline; text-align: justify; font-weight: bo" & _
            "ld; font-size: 9pt; font-family: Calibri; vertical-align: middle; "
        Me.Label41.Text = "Name"
        Me.Label41.Top = 2.5!
        Me.Label41.Width = 1.0625!
        '
        'Label42
        '
        Me.Label42.Border.BottomColor = System.Drawing.Color.Black
        Me.Label42.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.LeftColor = System.Drawing.Color.Black
        Me.Label42.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.RightColor = System.Drawing.Color.Black
        Me.Label42.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Border.TopColor = System.Drawing.Color.Black
        Me.Label42.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label42.Height = 0.25!
        Me.Label42.HyperLink = Nothing
        Me.Label42.Left = 2.0625!
        Me.Label42.Name = "Label42"
        Me.Label42.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label42.Text = "Size :"
        Me.Label42.Top = 2.5!
        Me.Label42.Width = 0.3125!
        '
        'Label44
        '
        Me.Label44.Border.BottomColor = System.Drawing.Color.Black
        Me.Label44.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.Border.LeftColor = System.Drawing.Color.Black
        Me.Label44.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.Border.RightColor = System.Drawing.Color.Black
        Me.Label44.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.Border.TopColor = System.Drawing.Color.Black
        Me.Label44.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label44.DataField = "SqYards"
        Me.Label44.Height = 0.25!
        Me.Label44.HyperLink = Nothing
        Me.Label44.Left = 2.4375!
        Me.Label44.Name = "Label44"
        Me.Label44.Style = "ddo-char-set: 0; text-decoration: underline; text-align: justify; font-weight: bo" & _
            "ld; font-size: 9pt; font-family: Calibri; vertical-align: middle; "
        Me.Label44.Text = "Name"
        Me.Label44.Top = 2.5!
        Me.Label44.Width = 0.8125!
        '
        'Label48
        '
        Me.Label48.Border.BottomColor = System.Drawing.Color.Black
        Me.Label48.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.LeftColor = System.Drawing.Color.Black
        Me.Label48.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.RightColor = System.Drawing.Color.Black
        Me.Label48.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Border.TopColor = System.Drawing.Color.Black
        Me.Label48.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label48.Height = 0.25!
        Me.Label48.HyperLink = Nothing
        Me.Label48.Left = 6.5625!
        Me.Label48.Name = "Label48"
        Me.Label48.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label48.Text = "Block :"
        Me.Label48.Top = 2.5!
        Me.Label48.Width = 0.4375!
        '
        'Label50
        '
        Me.Label50.Border.BottomColor = System.Drawing.Color.Black
        Me.Label50.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label50.Border.LeftColor = System.Drawing.Color.Black
        Me.Label50.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label50.Border.RightColor = System.Drawing.Color.Black
        Me.Label50.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label50.Border.TopColor = System.Drawing.Color.Black
        Me.Label50.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label50.DataField = "Block"
        Me.Label50.Height = 0.25!
        Me.Label50.HyperLink = Nothing
        Me.Label50.Left = 7.0625!
        Me.Label50.Name = "Label50"
        Me.Label50.Style = "ddo-char-set: 0; text-decoration: underline; text-align: justify; font-weight: bo" & _
            "ld; font-size: 9pt; font-family: Calibri; vertical-align: middle; "
        Me.Label50.Text = "Name"
        Me.Label50.Top = 2.5!
        Me.Label50.Width = 0.875!
        '
        'Label51
        '
        Me.Label51.Border.BottomColor = System.Drawing.Color.Black
        Me.Label51.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Border.LeftColor = System.Drawing.Color.Black
        Me.Label51.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Border.RightColor = System.Drawing.Color.Black
        Me.Label51.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Border.TopColor = System.Drawing.Color.Black
        Me.Label51.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label51.Height = 0.1875!
        Me.Label51.HyperLink = Nothing
        Me.Label51.Left = 0.1875!
        Me.Label51.Name = "Label51"
        Me.Label51.Style = "color: Blue; ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: " & _
            "9.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label51.Text = "Applicant - 1"
        Me.Label51.Top = 1.0!
        Me.Label51.Width = 1.25!
        '
        'Label52
        '
        Me.Label52.Border.BottomColor = System.Drawing.Color.Black
        Me.Label52.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Border.LeftColor = System.Drawing.Color.Black
        Me.Label52.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Border.RightColor = System.Drawing.Color.Black
        Me.Label52.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Border.TopColor = System.Drawing.Color.Black
        Me.Label52.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label52.Height = 0.1875!
        Me.Label52.HyperLink = Nothing
        Me.Label52.Left = 4.5!
        Me.Label52.Name = "Label52"
        Me.Label52.Style = "color: Blue; ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: " & _
            "9.25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label52.Text = "Applicant - 2"
        Me.Label52.Top = 1.0!
        Me.Label52.Width = 1.25!
        '
        'Label53
        '
        Me.Label53.Border.BottomColor = System.Drawing.Color.Black
        Me.Label53.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Border.LeftColor = System.Drawing.Color.Black
        Me.Label53.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Border.RightColor = System.Drawing.Color.Black
        Me.Label53.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Border.TopColor = System.Drawing.Color.Black
        Me.Label53.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label53.Height = 0.25!
        Me.Label53.HyperLink = Nothing
        Me.Label53.Left = 2.5!
        Me.Label53.Name = "Label53"
        Me.Label53.Style = "color: Blue; ddo-char-set: 1; text-align: center; font-weight: bold; font-size: 9" & _
            ".25pt; font-family: Calibri; vertical-align: middle; "
        Me.Label53.Text = "Unit Detail"
        Me.Label53.Top = 2.875!
        Me.Label53.Width = 2.75!
        '
        'Label54
        '
        Me.Label54.Border.BottomColor = System.Drawing.Color.Black
        Me.Label54.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Border.LeftColor = System.Drawing.Color.Black
        Me.Label54.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Border.RightColor = System.Drawing.Color.Black
        Me.Label54.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Border.TopColor = System.Drawing.Color.Black
        Me.Label54.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label54.Height = 0.1875!
        Me.Label54.HyperLink = Nothing
        Me.Label54.Left = 0.1875!
        Me.Label54.Name = "Label54"
        Me.Label54.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label54.Text = "Cash Amount"
        Me.Label54.Top = 2.875!
        Me.Label54.Width = 0.75!
        '
        'Label55
        '
        Me.Label55.Border.BottomColor = System.Drawing.Color.Black
        Me.Label55.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Border.LeftColor = System.Drawing.Color.Black
        Me.Label55.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Border.RightColor = System.Drawing.Color.Black
        Me.Label55.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Border.TopColor = System.Drawing.Color.Black
        Me.Label55.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label55.Height = 0.1875!
        Me.Label55.HyperLink = Nothing
        Me.Label55.Left = 1.25!
        Me.Label55.Name = "Label55"
        Me.Label55.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label55.Text = ":"
        Me.Label55.Top = 2.875!
        Me.Label55.Width = 0.0625!
        '
        'txtCashAmount
        '
        Me.txtCashAmount.Border.BottomColor = System.Drawing.Color.Black
        Me.txtCashAmount.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashAmount.Border.LeftColor = System.Drawing.Color.Black
        Me.txtCashAmount.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashAmount.Border.RightColor = System.Drawing.Color.Black
        Me.txtCashAmount.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashAmount.Border.TopColor = System.Drawing.Color.Black
        Me.txtCashAmount.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtCashAmount.DataField = "CashAmount"
        Me.txtCashAmount.Height = 0.1875!
        Me.txtCashAmount.Left = 1.3125!
        Me.txtCashAmount.Name = "txtCashAmount"
        Me.txtCashAmount.OutputFormat = resources.GetString("txtCashAmount.OutputFormat")
        Me.txtCashAmount.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9." & _
            "25pt; font-family: Calibri; vertical-align: middle; "
        Me.txtCashAmount.Text = Nothing
        Me.txtCashAmount.Top = 2.875!
        Me.txtCashAmount.Width = 1.125!
        '
        'Label56
        '
        Me.Label56.Border.BottomColor = System.Drawing.Color.Black
        Me.Label56.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Border.LeftColor = System.Drawing.Color.Black
        Me.Label56.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Border.RightColor = System.Drawing.Color.Black
        Me.Label56.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Border.TopColor = System.Drawing.Color.Black
        Me.Label56.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label56.Height = 0.1875!
        Me.Label56.HyperLink = Nothing
        Me.Label56.Left = 0.1875!
        Me.Label56.Name = "Label56"
        Me.Label56.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label56.Text = "Extra Charges"
        Me.Label56.Top = 3.375!
        Me.Label56.Width = 0.75!
        '
        'Label57
        '
        Me.Label57.Border.BottomColor = System.Drawing.Color.Black
        Me.Label57.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Border.LeftColor = System.Drawing.Color.Black
        Me.Label57.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Border.RightColor = System.Drawing.Color.Black
        Me.Label57.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Border.TopColor = System.Drawing.Color.Black
        Me.Label57.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label57.Height = 0.1875!
        Me.Label57.HyperLink = Nothing
        Me.Label57.Left = 1.25!
        Me.Label57.Name = "Label57"
        Me.Label57.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label57.Text = ":"
        Me.Label57.Top = 3.375!
        Me.Label57.Width = 0.0625!
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
        Me.TextBox9.DataField = "ExtraCharges"
        Me.TextBox9.Height = 0.1875!
        Me.TextBox9.Left = 1.3125!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.OutputFormat = resources.GetString("TextBox9.OutputFormat")
        Me.TextBox9.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9." & _
            "25pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox9.Text = Nothing
        Me.TextBox9.Top = 3.375!
        Me.TextBox9.Width = 1.125!
        '
        'Label58
        '
        Me.Label58.Border.BottomColor = System.Drawing.Color.Black
        Me.Label58.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Border.LeftColor = System.Drawing.Color.Black
        Me.Label58.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Border.RightColor = System.Drawing.Color.Black
        Me.Label58.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Border.TopColor = System.Drawing.Color.Black
        Me.Label58.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label58.Height = 0.1875!
        Me.Label58.HyperLink = Nothing
        Me.Label58.Left = 0.1875!
        Me.Label58.Name = "Label58"
        Me.Label58.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label58.Text = "Loan Amount"
        Me.Label58.Top = 3.125!
        Me.Label58.Width = 0.75!
        '
        'Label59
        '
        Me.Label59.Border.BottomColor = System.Drawing.Color.Black
        Me.Label59.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label59.Border.LeftColor = System.Drawing.Color.Black
        Me.Label59.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label59.Border.RightColor = System.Drawing.Color.Black
        Me.Label59.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label59.Border.TopColor = System.Drawing.Color.Black
        Me.Label59.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label59.Height = 0.1875!
        Me.Label59.HyperLink = Nothing
        Me.Label59.Left = 1.25!
        Me.Label59.Name = "Label59"
        Me.Label59.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label59.Text = ":"
        Me.Label59.Top = 3.125!
        Me.Label59.Width = 0.0625!
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
        Me.TextBox10.DataField = "LoanAmount"
        Me.TextBox10.Height = 0.1875!
        Me.TextBox10.Left = 1.3125!
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.OutputFormat = resources.GetString("TextBox10.OutputFormat")
        Me.TextBox10.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9." & _
            "25pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox10.Text = Nothing
        Me.TextBox10.Top = 3.125!
        Me.TextBox10.Width = 1.125!
        '
        'lblExtraLandCharges
        '
        Me.lblExtraLandCharges.Border.BottomColor = System.Drawing.Color.Black
        Me.lblExtraLandCharges.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandCharges.Border.LeftColor = System.Drawing.Color.Black
        Me.lblExtraLandCharges.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandCharges.Border.RightColor = System.Drawing.Color.Black
        Me.lblExtraLandCharges.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandCharges.Border.TopColor = System.Drawing.Color.Black
        Me.lblExtraLandCharges.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandCharges.Height = 0.1875!
        Me.lblExtraLandCharges.HyperLink = Nothing
        Me.lblExtraLandCharges.Left = 0.1875!
        Me.lblExtraLandCharges.Name = "lblExtraLandCharges"
        Me.lblExtraLandCharges.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.lblExtraLandCharges.Text = "Extra Land Charges"
        Me.lblExtraLandCharges.Top = 3.625!
        Me.lblExtraLandCharges.Width = 1.0625!
        '
        'lblSeperatorExtraLand
        '
        Me.lblSeperatorExtraLand.Border.BottomColor = System.Drawing.Color.Black
        Me.lblSeperatorExtraLand.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSeperatorExtraLand.Border.LeftColor = System.Drawing.Color.Black
        Me.lblSeperatorExtraLand.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSeperatorExtraLand.Border.RightColor = System.Drawing.Color.Black
        Me.lblSeperatorExtraLand.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSeperatorExtraLand.Border.TopColor = System.Drawing.Color.Black
        Me.lblSeperatorExtraLand.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblSeperatorExtraLand.Height = 0.1875!
        Me.lblSeperatorExtraLand.HyperLink = Nothing
        Me.lblSeperatorExtraLand.Left = 1.25!
        Me.lblSeperatorExtraLand.Name = "lblSeperatorExtraLand"
        Me.lblSeperatorExtraLand.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.lblSeperatorExtraLand.Text = ":"
        Me.lblSeperatorExtraLand.Top = 3.625!
        Me.lblSeperatorExtraLand.Width = 0.0625!
        '
        'TextBox16
        '
        Me.TextBox16.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox16.DataField = "Discount"
        Me.TextBox16.Height = 0.1875!
        Me.TextBox16.Left = 1.3125!
        Me.TextBox16.Name = "TextBox16"
        Me.TextBox16.OutputFormat = resources.GetString("TextBox16.OutputFormat")
        Me.TextBox16.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9." & _
            "25pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox16.Text = Nothing
        Me.TextBox16.Top = 3.875!
        Me.TextBox16.Width = 1.125!
        '
        'Label62
        '
        Me.Label62.Border.BottomColor = System.Drawing.Color.Black
        Me.Label62.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label62.Border.LeftColor = System.Drawing.Color.Black
        Me.Label62.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label62.Border.RightColor = System.Drawing.Color.Black
        Me.Label62.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label62.Border.TopColor = System.Drawing.Color.Black
        Me.Label62.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label62.Height = 0.1875!
        Me.Label62.HyperLink = Nothing
        Me.Label62.Left = 0.1875!
        Me.Label62.Name = "Label62"
        Me.Label62.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label62.Text = "Discount"
        Me.Label62.Top = 3.875!
        Me.Label62.Width = 0.75!
        '
        'Label63
        '
        Me.Label63.Border.BottomColor = System.Drawing.Color.Black
        Me.Label63.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label63.Border.LeftColor = System.Drawing.Color.Black
        Me.Label63.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label63.Border.RightColor = System.Drawing.Color.Black
        Me.Label63.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label63.Border.TopColor = System.Drawing.Color.Black
        Me.Label63.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label63.Height = 0.1875!
        Me.Label63.HyperLink = Nothing
        Me.Label63.Left = 1.25!
        Me.Label63.Name = "Label63"
        Me.Label63.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label63.Text = ":"
        Me.Label63.Top = 3.875!
        Me.Label63.Width = 0.0625!
        '
        'Label64
        '
        Me.Label64.Border.BottomColor = System.Drawing.Color.Black
        Me.Label64.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label64.Border.LeftColor = System.Drawing.Color.Black
        Me.Label64.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label64.Border.RightColor = System.Drawing.Color.Black
        Me.Label64.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label64.Border.TopColor = System.Drawing.Color.Black
        Me.Label64.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label64.Height = 0.1875!
        Me.Label64.HyperLink = Nothing
        Me.Label64.Left = 0.1875!
        Me.Label64.Name = "Label64"
        Me.Label64.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label64.Text = "Total Revenue"
        Me.Label64.Top = 4.375!
        Me.Label64.Width = 0.9375!
        '
        'Label65
        '
        Me.Label65.Border.BottomColor = System.Drawing.Color.Black
        Me.Label65.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label65.Border.LeftColor = System.Drawing.Color.Black
        Me.Label65.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label65.Border.RightColor = System.Drawing.Color.Black
        Me.Label65.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label65.Border.TopColor = System.Drawing.Color.Black
        Me.Label65.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label65.Height = 0.1875!
        Me.Label65.HyperLink = Nothing
        Me.Label65.Left = 1.25!
        Me.Label65.Name = "Label65"
        Me.Label65.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label65.Text = ":"
        Me.Label65.Top = 4.375!
        Me.Label65.Width = 0.0625!
        '
        'TextBox17
        '
        Me.TextBox17.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox17.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox17.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox17.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox17.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox17.DataField = "TotalRevenue"
        Me.TextBox17.Height = 0.1875!
        Me.TextBox17.Left = 1.3125!
        Me.TextBox17.Name = "TextBox17"
        Me.TextBox17.OutputFormat = resources.GetString("TextBox17.OutputFormat")
        Me.TextBox17.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9." & _
            "25pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox17.Text = Nothing
        Me.TextBox17.Top = 4.375!
        Me.TextBox17.Width = 1.125!
        '
        'lblExtraCharges
        '
        Me.lblExtraCharges.Border.BottomColor = System.Drawing.Color.Black
        Me.lblExtraCharges.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraCharges.Border.LeftColor = System.Drawing.Color.Black
        Me.lblExtraCharges.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraCharges.Border.RightColor = System.Drawing.Color.Black
        Me.lblExtraCharges.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraCharges.Border.TopColor = System.Drawing.Color.Black
        Me.lblExtraCharges.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraCharges.Height = 0.1875!
        Me.lblExtraCharges.HyperLink = Nothing
        Me.lblExtraCharges.Left = 2.5!
        Me.lblExtraCharges.Name = "lblExtraCharges"
        Me.lblExtraCharges.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.lblExtraCharges.Text = ""
        Me.lblExtraCharges.Top = 3.375!
        Me.lblExtraCharges.Width = 5.5!
        '
        'Label14
        '
        Me.Label14.Border.BottomColor = System.Drawing.Color.Black
        Me.Label14.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.LeftColor = System.Drawing.Color.Black
        Me.Label14.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.RightColor = System.Drawing.Color.Black
        Me.Label14.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Border.TopColor = System.Drawing.Color.Black
        Me.Label14.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label14.Height = 0.25!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 3.4375!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label14.Text = "Type :"
        Me.Label14.Top = 2.5!
        Me.Label14.Width = 0.375!
        '
        'Label66
        '
        Me.Label66.Border.BottomColor = System.Drawing.Color.Black
        Me.Label66.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label66.Border.LeftColor = System.Drawing.Color.Black
        Me.Label66.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label66.Border.RightColor = System.Drawing.Color.Black
        Me.Label66.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label66.Border.TopColor = System.Drawing.Color.Black
        Me.Label66.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label66.DataField = "UnitType"
        Me.Label66.Height = 0.25!
        Me.Label66.HyperLink = Nothing
        Me.Label66.Left = 3.875!
        Me.Label66.Name = "Label66"
        Me.Label66.Style = "ddo-char-set: 0; text-decoration: underline; text-align: justify; font-weight: bo" & _
            "ld; font-size: 9pt; font-family: Calibri; vertical-align: middle; "
        Me.Label66.Text = "Name"
        Me.Label66.Top = 2.5!
        Me.Label66.Width = 2.5625!
        '
        'txtExtraLandCharges
        '
        Me.txtExtraLandCharges.Border.BottomColor = System.Drawing.Color.Black
        Me.txtExtraLandCharges.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExtraLandCharges.Border.LeftColor = System.Drawing.Color.Black
        Me.txtExtraLandCharges.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExtraLandCharges.Border.RightColor = System.Drawing.Color.Black
        Me.txtExtraLandCharges.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExtraLandCharges.Border.TopColor = System.Drawing.Color.Black
        Me.txtExtraLandCharges.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtExtraLandCharges.Height = 0.1875!
        Me.txtExtraLandCharges.Left = 1.3125!
        Me.txtExtraLandCharges.Name = "txtExtraLandCharges"
        Me.txtExtraLandCharges.OutputFormat = resources.GetString("txtExtraLandCharges.OutputFormat")
        Me.txtExtraLandCharges.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9." & _
            "25pt; font-family: Calibri; vertical-align: middle; "
        Me.txtExtraLandCharges.Text = Nothing
        Me.txtExtraLandCharges.Top = 3.625!
        Me.txtExtraLandCharges.Width = 1.125!
        '
        'lblExtraLandDescription
        '
        Me.lblExtraLandDescription.Border.BottomColor = System.Drawing.Color.Black
        Me.lblExtraLandDescription.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandDescription.Border.LeftColor = System.Drawing.Color.Black
        Me.lblExtraLandDescription.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandDescription.Border.RightColor = System.Drawing.Color.Black
        Me.lblExtraLandDescription.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandDescription.Border.TopColor = System.Drawing.Color.Black
        Me.lblExtraLandDescription.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.lblExtraLandDescription.Height = 0.1875!
        Me.lblExtraLandDescription.HyperLink = Nothing
        Me.lblExtraLandDescription.Left = 2.5!
        Me.lblExtraLandDescription.Name = "lblExtraLandDescription"
        Me.lblExtraLandDescription.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.lblExtraLandDescription.Text = ""
        Me.lblExtraLandDescription.Top = 3.625!
        Me.lblExtraLandDescription.Width = 5.5!
        '
        'fldApplyExtraLand
        '
        Me.fldApplyExtraLand.Border.BottomColor = System.Drawing.Color.Black
        Me.fldApplyExtraLand.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldApplyExtraLand.Border.LeftColor = System.Drawing.Color.Black
        Me.fldApplyExtraLand.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldApplyExtraLand.Border.RightColor = System.Drawing.Color.Black
        Me.fldApplyExtraLand.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldApplyExtraLand.Border.TopColor = System.Drawing.Color.Black
        Me.fldApplyExtraLand.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldApplyExtraLand.DataField = "ApplyExtraLand"
        Me.fldApplyExtraLand.Height = 0.1875!
        Me.fldApplyExtraLand.HyperLink = Nothing
        Me.fldApplyExtraLand.Left = 0.125!
        Me.fldApplyExtraLand.Name = "fldApplyExtraLand"
        Me.fldApplyExtraLand.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.fldApplyExtraLand.Text = ""
        Me.fldApplyExtraLand.Top = 0.1875!
        Me.fldApplyExtraLand.Visible = False
        Me.fldApplyExtraLand.Width = 1.25!
        '
        'Label46
        '
        Me.Label46.Border.BottomColor = System.Drawing.Color.Black
        Me.Label46.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.LeftColor = System.Drawing.Color.Black
        Me.Label46.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.RightColor = System.Drawing.Color.Black
        Me.Label46.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.Border.TopColor = System.Drawing.Color.Black
        Me.Label46.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label46.DataField = "ExtraLandCharges"
        Me.Label46.Height = 0.1875!
        Me.Label46.HyperLink = Nothing
        Me.Label46.Left = 1.4375!
        Me.Label46.Name = "Label46"
        Me.Label46.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label46.Text = ""
        Me.Label46.Top = 0.1875!
        Me.Label46.Visible = False
        Me.Label46.Width = 1.3125!
        '
        'Label47
        '
        Me.Label47.Border.BottomColor = System.Drawing.Color.Black
        Me.Label47.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.LeftColor = System.Drawing.Color.Black
        Me.Label47.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.RightColor = System.Drawing.Color.Black
        Me.Label47.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.Border.TopColor = System.Drawing.Color.Black
        Me.Label47.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label47.DataField = "ExtraSqFeetYds"
        Me.Label47.Height = 0.1875!
        Me.Label47.HyperLink = Nothing
        Me.Label47.Left = 2.8125!
        Me.Label47.Name = "Label47"
        Me.Label47.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label47.Text = ""
        Me.Label47.Top = 0.1875!
        Me.Label47.Visible = False
        Me.Label47.Width = 1.375!
        '
        'Label60
        '
        Me.Label60.Border.BottomColor = System.Drawing.Color.Black
        Me.Label60.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label60.Border.LeftColor = System.Drawing.Color.Black
        Me.Label60.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label60.Border.RightColor = System.Drawing.Color.Black
        Me.Label60.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label60.Border.TopColor = System.Drawing.Color.Black
        Me.Label60.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label60.DataField = "PerSqFeetCharges"
        Me.Label60.Height = 0.1875!
        Me.Label60.HyperLink = Nothing
        Me.Label60.Left = 4.25!
        Me.Label60.Name = "Label60"
        Me.Label60.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label60.Text = ""
        Me.Label60.Top = 0.1875!
        Me.Label60.Visible = False
        Me.Label60.Width = 1.125!
        '
        'fldStatus
        '
        Me.fldStatus.Border.BottomColor = System.Drawing.Color.Black
        Me.fldStatus.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldStatus.Border.LeftColor = System.Drawing.Color.Black
        Me.fldStatus.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldStatus.Border.RightColor = System.Drawing.Color.Black
        Me.fldStatus.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldStatus.Border.TopColor = System.Drawing.Color.Black
        Me.fldStatus.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldStatus.Height = 0.1875!
        Me.fldStatus.HyperLink = Nothing
        Me.fldStatus.Left = 3.1875!
        Me.fldStatus.Name = "fldStatus"
        Me.fldStatus.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.fldStatus.Text = ""
        Me.fldStatus.Top = 3.9375!
        Me.fldStatus.Width = 4.8125!
        '
        'Label67
        '
        Me.Label67.Border.BottomColor = System.Drawing.Color.Black
        Me.Label67.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label67.Border.LeftColor = System.Drawing.Color.Black
        Me.Label67.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label67.Border.RightColor = System.Drawing.Color.Black
        Me.Label67.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label67.Border.TopColor = System.Drawing.Color.Black
        Me.Label67.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label67.Height = 0.1875!
        Me.Label67.HyperLink = Nothing
        Me.Label67.Left = 2.5!
        Me.Label67.Name = "Label67"
        Me.Label67.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label67.Text = "Status"
        Me.Label67.Top = 3.9375!
        Me.Label67.Width = 0.6875!
        '
        'Label68
        '
        Me.Label68.Border.BottomColor = System.Drawing.Color.Black
        Me.Label68.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label68.Border.LeftColor = System.Drawing.Color.Black
        Me.Label68.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label68.Border.RightColor = System.Drawing.Color.Black
        Me.Label68.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label68.Border.TopColor = System.Drawing.Color.Black
        Me.Label68.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label68.Height = 0.1875!
        Me.Label68.HyperLink = Nothing
        Me.Label68.Left = 0.1875!
        Me.Label68.Name = "Label68"
        Me.Label68.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label68.Text = "Utlities Charges"
        Me.Label68.Top = 4.125!
        Me.Label68.Width = 0.9375!
        '
        'Label69
        '
        Me.Label69.Border.BottomColor = System.Drawing.Color.Black
        Me.Label69.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label69.Border.LeftColor = System.Drawing.Color.Black
        Me.Label69.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label69.Border.RightColor = System.Drawing.Color.Black
        Me.Label69.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label69.Border.TopColor = System.Drawing.Color.Black
        Me.Label69.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Label69.Height = 0.1875!
        Me.Label69.HyperLink = Nothing
        Me.Label69.Left = 1.25!
        Me.Label69.Name = "Label69"
        Me.Label69.Style = "ddo-char-set: 1; text-align: justify; font-weight: bold; font-size: 9.25pt; font-" & _
            "family: Calibri; vertical-align: middle; "
        Me.Label69.Text = ":"
        Me.Label69.Top = 4.125!
        Me.Label69.Width = 0.0625!
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
        Me.TextBox1.DataField = "AddOtherCharges"
        Me.TextBox1.Height = 0.1875!
        Me.TextBox1.Left = 1.3125!
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.OutputFormat = resources.GetString("TextBox1.OutputFormat")
        Me.TextBox1.Style = "color: Blue; ddo-char-set: 1; text-align: right; font-weight: bold; font-size: 9." & _
            "25pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox1.Text = Nothing
        Me.TextBox1.Top = 4.125!
        Me.TextBox1.Width = 1.125!
        '
        'ReportFooter1
        '
        Me.ReportFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label22, Me.TextBox11, Me.txtTotalReceipt, Me.txtPerCash, Me.Label1, Me.TextBox4})
        Me.ReportFooter1.Height = 0.4270833!
        Me.ReportFooter1.Name = "ReportFooter1"
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
            "8.25pt; font-family: Arial Narrow; vertical-align: middle; "
        Me.Label22.Text = "Total"
        Me.Label22.Top = 0.0625!
        Me.Label22.Width = 0.5!
        '
        'TextBox11
        '
        Me.TextBox11.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox11.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox11.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox11.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox11.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox11.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox11.DataField = "InvoiceAmount"
        Me.TextBox11.Height = 0.25!
        Me.TextBox11.Left = 3.0!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "ddo-char-set: 1; text-decoration: none; text-align: right; font-weight: bold; fon" & _
            "t-size: 7pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox11.SummaryGroup = "GroupHeader1"
        Me.TextBox11.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox11.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox11.Text = "332324234234999"
        Me.TextBox11.Top = 0.0625!
        Me.TextBox11.Width = 0.875!
        '
        'txtTotalReceipt
        '
        Me.txtTotalReceipt.Border.BottomColor = System.Drawing.Color.Black
        Me.txtTotalReceipt.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txtTotalReceipt.Border.LeftColor = System.Drawing.Color.Black
        Me.txtTotalReceipt.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalReceipt.Border.RightColor = System.Drawing.Color.Black
        Me.txtTotalReceipt.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalReceipt.Border.TopColor = System.Drawing.Color.Black
        Me.txtTotalReceipt.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtTotalReceipt.DataField = "ReceiptAmount"
        Me.txtTotalReceipt.Height = 0.25!
        Me.txtTotalReceipt.Left = 6.0!
        Me.txtTotalReceipt.Name = "txtTotalReceipt"
        Me.txtTotalReceipt.OutputFormat = resources.GetString("txtTotalReceipt.OutputFormat")
        Me.txtTotalReceipt.Style = "ddo-char-set: 1; text-decoration: none; text-align: right; font-weight: bold; fon" & _
            "t-size: 7pt; font-family: Calibri; vertical-align: middle; "
        Me.txtTotalReceipt.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtTotalReceipt.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtTotalReceipt.Text = "332324234234999"
        Me.txtTotalReceipt.Top = 0.0625!
        Me.txtTotalReceipt.Width = 0.875!
        '
        'txtPerCash
        '
        Me.txtPerCash.Border.BottomColor = System.Drawing.Color.Black
        Me.txtPerCash.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.txtPerCash.Border.LeftColor = System.Drawing.Color.Black
        Me.txtPerCash.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPerCash.Border.RightColor = System.Drawing.Color.Black
        Me.txtPerCash.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPerCash.Border.TopColor = System.Drawing.Color.Black
        Me.txtPerCash.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtPerCash.Height = 0.25!
        Me.txtPerCash.Left = 7.75!
        Me.txtPerCash.Name = "txtPerCash"
        Me.txtPerCash.OutputFormat = resources.GetString("txtPerCash.OutputFormat")
        Me.txtPerCash.Style = "ddo-char-set: 1; text-decoration: none; text-align: right; font-weight: bold; fon" & _
            "t-size: 7pt; font-family: Calibri; vertical-align: middle; "
        Me.txtPerCash.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.txtPerCash.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.txtPerCash.Text = "12.22"
        Me.txtPerCash.Top = 0.0625!
        Me.txtPerCash.Width = 0.3125!
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
        Me.Label1.Height = 0.25!
        Me.Label1.HyperLink = Nothing
        Me.Label1.Left = 8.114583!
        Me.Label1.Name = "Label1"
        Me.Label1.Style = "ddo-char-set: 0; text-align: justify; font-weight: bold; font-size: 6.75pt; font-" & _
            "family: Arial; vertical-align: middle; "
        Me.Label1.Text = "%"
        Me.Label1.Top = 0.07291666!
        Me.Label1.Width = 0.0625!
        '
        'TextBox4
        '
        Me.TextBox4.Border.BottomColor = System.Drawing.Color.Black
        Me.TextBox4.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.[Double]
        Me.TextBox4.Border.LeftColor = System.Drawing.Color.Black
        Me.TextBox4.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.RightColor = System.Drawing.Color.Black
        Me.TextBox4.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.Border.TopColor = System.Drawing.Color.Black
        Me.TextBox4.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.TextBox4.DataField = "Balance"
        Me.TextBox4.Height = 0.25!
        Me.TextBox4.Left = 6.875!
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.OutputFormat = resources.GetString("TextBox4.OutputFormat")
        Me.TextBox4.Style = "ddo-char-set: 1; text-decoration: none; text-align: right; font-weight: bold; fon" & _
            "t-size: 7pt; font-family: Calibri; vertical-align: middle; "
        Me.TextBox4.SummaryGroup = "GroupHeader1"
        Me.TextBox4.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.TextBox4.SummaryType = DataDynamics.ActiveReports.SummaryType.GrandTotal
        Me.TextBox4.Text = "332324234234999"
        Me.TextBox4.Top = 0.0625!
        Me.TextBox4.Width = 0.875!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.DataField = "UnitNumber"
        Me.GroupHeader1.Height = 0.0!
        Me.GroupHeader1.Name = "GroupHeader1"
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Height = 0.0!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.Line1.Height = 1.5!
        Me.Line1.Left = 4.1875!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.9375!
        Me.Line1.Width = 0.0!
        Me.Line1.X1 = 4.1875!
        Me.Line1.X2 = 4.1875!
        Me.Line1.Y1 = 2.4375!
        Me.Line1.Y2 = 0.9375!
        '
        'Shape1
        '
        Me.Shape1.Border.BottomColor = System.Drawing.Color.Black
        Me.Shape1.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.LeftColor = System.Drawing.Color.Black
        Me.Shape1.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.RightColor = System.Drawing.Color.Black
        Me.Shape1.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Border.TopColor = System.Drawing.Color.Black
        Me.Shape1.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Shape1.Height = 3.6875!
        Me.Shape1.Left = 0.0625!
        Me.Shape1.Name = "Shape1"
        Me.Shape1.RoundingRadius = 10.0!
        Me.Shape1.Top = 0.9375!
        Me.Shape1.Width = 8.0!
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
        Me.Line2.Left = 0.0625!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 2.4375!
        Me.Line2.Width = 8.0!
        Me.Line2.X1 = 0.0625!
        Me.Line2.X2 = 8.0625!
        Me.Line2.Y1 = 2.4375!
        Me.Line2.Y2 = 2.4375!
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
        Me.Line3.Left = 0.0625!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 2.822917!
        Me.Line3.Width = 8.0!
        Me.Line3.X1 = 0.0625!
        Me.Line3.X2 = 8.0625!
        Me.Line3.Y1 = 2.822917!
        Me.Line3.Y2 = 2.822917!
        '
        'rptCustomerStatement
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
        Me.PrintWidth = 8.21875!
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
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label61, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldInvoiceNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldReceiptDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldReceiptNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBalPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label45, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldMaualReceiptNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPages, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label18, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label19, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label20, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label21, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label23, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label24, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label25, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label26, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label27, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label28, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label29, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label30, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label31, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label32, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label33, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label34, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label35, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label36, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label37, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label38, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label39, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label41, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label42, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label44, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label48, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label51, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label52, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label53, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label54, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label55, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label56, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label57, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label58, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label59, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExtraLandCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblSeperatorExtraLand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox16, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label62, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label63, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label64, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label65, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox17, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExtraCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label66, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtExtraLandCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblExtraLandDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldApplyExtraLand, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label46, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label47, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label60, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label67, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label68, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label69, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label22, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalReceipt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPerCash, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents ReportHeader1 As DataDynamics.ActiveReports.ReportHeader
    Friend WithEvents ReportFooter1 As DataDynamics.ActiveReports.ReportFooter
    Friend WithEvents Line25 As DataDynamics.ActiveReports.Line
    Friend WithEvents fldChequeDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldInvoiceNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox3 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldReceiptDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldReceiptNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox6 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox7 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtBalPer As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label45 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldMaualReceiptNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label15 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label61 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldTitle As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldPage As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldPages As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label16 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label18 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label19 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label20 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label21 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label23 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label24 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label25 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label26 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label27 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label28 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label29 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label30 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label31 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label32 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label33 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label34 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label35 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label36 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label37 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label38 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label39 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label41 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label42 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label44 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label48 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label50 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label51 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label52 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label53 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label54 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label55 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtCashAmount As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label56 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label57 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label58 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label59 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox10 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblExtraLandCharges As DataDynamics.ActiveReports.Label
    Friend WithEvents lblSeperatorExtraLand As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox16 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label62 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label63 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label64 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label65 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox17 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblExtraCharges As DataDynamics.ActiveReports.Label
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label66 As DataDynamics.ActiveReports.Label
    Friend WithEvents txtExtraLandCharges As DataDynamics.ActiveReports.TextBox
    Friend WithEvents lblExtraLandDescription As DataDynamics.ActiveReports.Label
    Friend WithEvents fldApplyExtraLand As DataDynamics.ActiveReports.Label
    Friend WithEvents Label46 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label47 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label60 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldStatus As DataDynamics.ActiveReports.Label
    Friend WithEvents Label67 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label22 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtTotalReceipt As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtPerCash As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label68 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label69 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox1 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox4 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox5 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Shape1 As DataDynamics.ActiveReports.Shape
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
End Class
