<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class rptGeneralLedger 
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
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(rptGeneralLedger))
        Me.PageHeader1 = New DataDynamics.ActiveReports.PageHeader
        Me.fldTitle = New DataDynamics.ActiveReports.TextBox
        Me.fldCompany = New DataDynamics.ActiveReports.TextBox
        Me.txtProject = New DataDynamics.ActiveReports.Label
        Me.Detail1 = New DataDynamics.ActiveReports.Detail
        Me.fldDescription = New DataDynamics.ActiveReports.TextBox
        Me.fldChequeDate = New DataDynamics.ActiveReports.TextBox
        Me.fldChequeNo = New DataDynamics.ActiveReports.TextBox
        Me.fldCredit = New DataDynamics.ActiveReports.TextBox
        Me.fldVoucherDate = New DataDynamics.ActiveReports.TextBox
        Me.fldVoucherNo = New DataDynamics.ActiveReports.TextBox
        Me.fldDebit = New DataDynamics.ActiveReports.TextBox
        Me.fldBalance = New DataDynamics.ActiveReports.TextBox
        Me.PageFooter1 = New DataDynamics.ActiveReports.PageFooter
        Me.Label1 = New DataDynamics.ActiveReports.Label
        Me.fldDateTime = New DataDynamics.ActiveReports.TextBox
        Me.Label8 = New DataDynamics.ActiveReports.Label
        Me.fldPage = New DataDynamics.ActiveReports.TextBox
        Me.Label10 = New DataDynamics.ActiveReports.Label
        Me.fldDivision = New DataDynamics.ActiveReports.TextBox
        Me.fldUserID = New DataDynamics.ActiveReports.TextBox
        Me.Label9 = New DataDynamics.ActiveReports.Label
        Me.GroupHeader1 = New DataDynamics.ActiveReports.GroupHeader
        Me.Label5 = New DataDynamics.ActiveReports.Label
        Me.Label7 = New DataDynamics.ActiveReports.Label
        Me.Label6 = New DataDynamics.ActiveReports.Label
        Me.Label2 = New DataDynamics.ActiveReports.Label
        Me.Label3 = New DataDynamics.ActiveReports.Label
        Me.Label4 = New DataDynamics.ActiveReports.Label
        Me.Line2 = New DataDynamics.ActiveReports.Line
        Me.Line3 = New DataDynamics.ActiveReports.Line
        Me.Line4 = New DataDynamics.ActiveReports.Line
        Me.Line5 = New DataDynamics.ActiveReports.Line
        Me.Line6 = New DataDynamics.ActiveReports.Line
        Me.Line7 = New DataDynamics.ActiveReports.Line
        Me.Line1 = New DataDynamics.ActiveReports.Line
        Me.Line8 = New DataDynamics.ActiveReports.Line
        Me.Label11 = New DataDynamics.ActiveReports.Label
        Me.TextBox9 = New DataDynamics.ActiveReports.TextBox
        Me.Line16 = New DataDynamics.ActiveReports.Line
        Me.Line10 = New DataDynamics.ActiveReports.Line
        Me.Label13 = New DataDynamics.ActiveReports.Label
        Me.Line12 = New DataDynamics.ActiveReports.Line
        Me.Label14 = New DataDynamics.ActiveReports.Label
        Me.txtAccountType = New DataDynamics.ActiveReports.TextBox
        Me.GroupFooter1 = New DataDynamics.ActiveReports.GroupFooter
        Me.TextBox2 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox12 = New DataDynamics.ActiveReports.TextBox
        Me.TextBox11 = New DataDynamics.ActiveReports.TextBox
        Me.Label12 = New DataDynamics.ActiveReports.Label
        Me.Line18 = New DataDynamics.ActiveReports.Line
        Me.Line19 = New DataDynamics.ActiveReports.Line
        Me.Line9 = New DataDynamics.ActiveReports.Line
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDescription, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldChequeNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldVoucherDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldVoucherNo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldDivision, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.fldUserID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAccountType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'PageHeader1
        '
        Me.PageHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldTitle, Me.fldCompany, Me.txtProject})
        Me.PageHeader1.Height = 1.458333!
        Me.PageHeader1.Name = "PageHeader1"
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
        Me.fldTitle.Left = 0.4375!
        Me.fldTitle.Name = "fldTitle"
        Me.fldTitle.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 14.25pt; verti" & _
            "cal-align: middle; "
        Me.fldTitle.Text = "Title"
        Me.fldTitle.Top = 0.875!
        Me.fldTitle.Width = 10.3125!
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
        Me.fldCompany.Height = 0.375!
        Me.fldCompany.Left = 0.4375!
        Me.fldCompany.Name = "fldCompany"
        Me.fldCompany.Style = "ddo-char-set: 0; text-align: center; font-weight: bold; font-size: 18pt; vertical" & _
            "-align: middle; "
        Me.fldCompany.Text = "Company"
        Me.fldCompany.Top = 0.5!
        Me.fldCompany.Width = 10.3125!
        '
        'txtProject
        '
        Me.txtProject.Border.BottomColor = System.Drawing.Color.Black
        Me.txtProject.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProject.Border.LeftColor = System.Drawing.Color.Black
        Me.txtProject.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProject.Border.RightColor = System.Drawing.Color.Black
        Me.txtProject.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProject.Border.TopColor = System.Drawing.Color.Black
        Me.txtProject.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtProject.Height = 0.25!
        Me.txtProject.HyperLink = Nothing
        Me.txtProject.Left = 0.4375!
        Me.txtProject.Name = "txtProject"
        Me.txtProject.Style = "ddo-char-set: 0; text-align: justify; font-weight: normal; font-size: 6.75pt; fon" & _
            "t-family: Microsoft Sans Serif; vertical-align: middle; "
        Me.txtProject.Text = "Project :"
        Me.txtProject.Top = 1.1875!
        Me.txtProject.Width = 3.9375!
        '
        'Detail1
        '
        Me.Detail1.ColumnSpacing = 0.0!
        Me.Detail1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.fldDescription, Me.fldChequeDate, Me.fldChequeNo, Me.fldCredit, Me.fldVoucherDate, Me.fldVoucherNo, Me.fldDebit, Me.fldBalance, Me.Line9})
        Me.Detail1.Height = 0.2604167!
        Me.Detail1.Name = "Detail1"
        '
        'fldDescription
        '
        Me.fldDescription.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDescription.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDescription.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDescription.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDescription.Border.RightColor = System.Drawing.Color.Black
        Me.fldDescription.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDescription.Border.TopColor = System.Drawing.Color.Black
        Me.fldDescription.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDescription.DataField = "Description"
        Me.fldDescription.Height = 0.25!
        Me.fldDescription.Left = 4.375!
        Me.fldDescription.Name = "fldDescription"
        Me.fldDescription.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.fldDescription.Text = "Description"
        Me.fldDescription.Top = 0.0!
        Me.fldDescription.Width = 3.5!
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
        Me.fldChequeDate.CanGrow = False
        Me.fldChequeDate.DataField = "ChequeDate"
        Me.fldChequeDate.Height = 0.25!
        Me.fldChequeDate.Left = 3.625!
        Me.fldChequeDate.Name = "fldChequeDate"
        Me.fldChequeDate.OutputFormat = resources.GetString("fldChequeDate.OutputFormat")
        Me.fldChequeDate.Style = "ddo-char-set: 0; font-size: 8.25pt; vertical-align: middle; "
        Me.fldChequeDate.Text = "ChequeDate"
        Me.fldChequeDate.Top = 0.0!
        Me.fldChequeDate.Width = 0.75!
        '
        'fldChequeNo
        '
        Me.fldChequeNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldChequeNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldChequeNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldChequeNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldChequeNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldChequeNo.DataField = "ChequeNo"
        Me.fldChequeNo.Height = 0.25!
        Me.fldChequeNo.Left = 2.5625!
        Me.fldChequeNo.Name = "fldChequeNo"
        Me.fldChequeNo.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; font-family: Microsoft S" & _
            "ans Serif; vertical-align: middle; "
        Me.fldChequeNo.Text = Nothing
        Me.fldChequeNo.Top = 0.0!
        Me.fldChequeNo.Width = 1.0625!
        '
        'fldCredit
        '
        Me.fldCredit.Border.BottomColor = System.Drawing.Color.Black
        Me.fldCredit.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCredit.Border.LeftColor = System.Drawing.Color.Black
        Me.fldCredit.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCredit.Border.RightColor = System.Drawing.Color.Black
        Me.fldCredit.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCredit.Border.TopColor = System.Drawing.Color.Black
        Me.fldCredit.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldCredit.DataField = "Credit"
        Me.fldCredit.Height = 0.25!
        Me.fldCredit.Left = 8.8125!
        Me.fldCredit.Name = "fldCredit"
        Me.fldCredit.OutputFormat = resources.GetString("fldCredit.OutputFormat")
        Me.fldCredit.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.fldCredit.Text = "Credit"
        Me.fldCredit.Top = 0.0!
        Me.fldCredit.Width = 0.9375!
        '
        'fldVoucherDate
        '
        Me.fldVoucherDate.Border.BottomColor = System.Drawing.Color.Black
        Me.fldVoucherDate.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherDate.Border.LeftColor = System.Drawing.Color.Black
        Me.fldVoucherDate.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherDate.Border.RightColor = System.Drawing.Color.Black
        Me.fldVoucherDate.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherDate.Border.TopColor = System.Drawing.Color.Black
        Me.fldVoucherDate.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherDate.CanGrow = False
        Me.fldVoucherDate.DataField = "VoucherDate"
        Me.fldVoucherDate.Height = 0.25!
        Me.fldVoucherDate.Left = 1.75!
        Me.fldVoucherDate.Name = "fldVoucherDate"
        Me.fldVoucherDate.OutputFormat = resources.GetString("fldVoucherDate.OutputFormat")
        Me.fldVoucherDate.Style = "ddo-char-set: 0; font-size: 8.25pt; font-family: Microsoft Sans Serif; vertical-a" & _
            "lign: middle; "
        Me.fldVoucherDate.Text = "VoucherDate"
        Me.fldVoucherDate.Top = 0.0!
        Me.fldVoucherDate.Width = 0.8125!
        '
        'fldVoucherNo
        '
        Me.fldVoucherNo.Border.BottomColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.Border.LeftColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.Border.RightColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.Border.TopColor = System.Drawing.Color.Black
        Me.fldVoucherNo.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldVoucherNo.DataField = "VoucherNo"
        Me.fldVoucherNo.Height = 0.25!
        Me.fldVoucherNo.Left = 0.4375!
        Me.fldVoucherNo.Name = "fldVoucherNo"
        Me.fldVoucherNo.Style = "ddo-char-set: 0; font-weight: normal; font-size: 8.25pt; font-family: Microsoft S" & _
            "ans Serif; vertical-align: middle; "
        Me.fldVoucherNo.Text = "VoucherNo"
        Me.fldVoucherNo.Top = 0.0!
        Me.fldVoucherNo.Width = 1.3125!
        '
        'fldDebit
        '
        Me.fldDebit.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDebit.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDebit.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDebit.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDebit.Border.RightColor = System.Drawing.Color.Black
        Me.fldDebit.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDebit.Border.TopColor = System.Drawing.Color.Black
        Me.fldDebit.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDebit.DataField = "Debit"
        Me.fldDebit.Height = 0.25!
        Me.fldDebit.Left = 7.875!
        Me.fldDebit.Name = "fldDebit"
        Me.fldDebit.OutputFormat = resources.GetString("fldDebit.OutputFormat")
        Me.fldDebit.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.fldDebit.Text = "Debit"
        Me.fldDebit.Top = 0.0!
        Me.fldDebit.Width = 0.9375!
        '
        'fldBalance
        '
        Me.fldBalance.Border.BottomColor = System.Drawing.Color.Black
        Me.fldBalance.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBalance.Border.LeftColor = System.Drawing.Color.Black
        Me.fldBalance.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBalance.Border.RightColor = System.Drawing.Color.Black
        Me.fldBalance.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBalance.Border.TopColor = System.Drawing.Color.Black
        Me.fldBalance.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldBalance.DataField = "Balance"
        Me.fldBalance.Height = 0.25!
        Me.fldBalance.Left = 9.75!
        Me.fldBalance.Name = "fldBalance"
        Me.fldBalance.OutputFormat = resources.GetString("fldBalance.OutputFormat")
        Me.fldBalance.Style = "ddo-char-set: 0; text-align: right; font-size: 6.75pt; font-family: Microsoft San" & _
            "s Serif; vertical-align: middle; "
        Me.fldBalance.SummaryGroup = "GroupHeader1"
        Me.fldBalance.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.Group
        Me.fldBalance.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.fldBalance.Text = "Balance"
        Me.fldBalance.Top = 0.0!
        Me.fldBalance.Width = 1.0!
        '
        'PageFooter1
        '
        Me.PageFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label1, Me.fldDateTime, Me.Label8, Me.fldPage, Me.Label10, Me.fldDivision, Me.fldUserID, Me.Label9})
        Me.PageFooter1.Height = 0.78125!
        Me.PageFooter1.Name = "PageFooter1"
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
        Me.Label1.Left = 0.25!
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
        Me.fldDateTime.Left = 1.5!
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
        Me.Label8.Left = 8.75!
        Me.Label8.Name = "Label8"
        Me.Label8.Style = "font-size: 8.25pt; "
        Me.Label8.Text = "Page No."
        Me.Label8.Top = 0.0!
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
        Me.fldPage.Left = 9.5!
        Me.fldPage.Name = "fldPage"
        Me.fldPage.Style = "text-align: right; font-size: 8.25pt; "
        Me.fldPage.SummaryGroup = "GroupHeader1"
        Me.fldPage.SummaryRunning = DataDynamics.ActiveReports.SummaryRunning.All
        Me.fldPage.SummaryType = DataDynamics.ActiveReports.SummaryType.PageCount
        Me.fldPage.Text = "Page"
        Me.fldPage.Top = 0.0!
        Me.fldPage.Width = 0.375!
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
        Me.Label10.Height = 0.1875!
        Me.Label10.HyperLink = Nothing
        Me.Label10.Left = 8.75!
        Me.Label10.Name = "Label10"
        Me.Label10.Style = "font-size: 8.25pt; "
        Me.Label10.Text = "Division"
        Me.Label10.Top = 0.1875!
        Me.Label10.Width = 0.5625!
        '
        'fldDivision
        '
        Me.fldDivision.Border.BottomColor = System.Drawing.Color.Black
        Me.fldDivision.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDivision.Border.LeftColor = System.Drawing.Color.Black
        Me.fldDivision.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDivision.Border.RightColor = System.Drawing.Color.Black
        Me.fldDivision.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDivision.Border.TopColor = System.Drawing.Color.Black
        Me.fldDivision.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldDivision.Height = 0.1875!
        Me.fldDivision.Left = 9.5!
        Me.fldDivision.Name = "fldDivision"
        Me.fldDivision.Style = "text-align: left; font-size: 8.25pt; "
        Me.fldDivision.Text = "Division"
        Me.fldDivision.Top = 0.1875!
        Me.fldDivision.Width = 1.0625!
        '
        'fldUserID
        '
        Me.fldUserID.Border.BottomColor = System.Drawing.Color.Black
        Me.fldUserID.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Border.LeftColor = System.Drawing.Color.Black
        Me.fldUserID.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Border.RightColor = System.Drawing.Color.Black
        Me.fldUserID.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Border.TopColor = System.Drawing.Color.Black
        Me.fldUserID.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.fldUserID.Height = 0.1875!
        Me.fldUserID.Left = 9.5!
        Me.fldUserID.Name = "fldUserID"
        Me.fldUserID.Style = "text-align: justify; "
        Me.fldUserID.Text = "user"
        Me.fldUserID.Top = 0.375!
        Me.fldUserID.Width = 1.0625!
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
        Me.Label9.Left = 8.75!
        Me.Label9.Name = "Label9"
        Me.Label9.Style = "font-size: 8.25pt; "
        Me.Label9.Text = "User :"
        Me.Label9.Top = 0.375!
        Me.Label9.Width = 0.5625!
        '
        'GroupHeader1
        '
        Me.GroupHeader1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.Label5, Me.Label7, Me.Label6, Me.Label2, Me.Label3, Me.Label4, Me.Line2, Me.Line3, Me.Line4, Me.Line5, Me.Line6, Me.Line7, Me.Line1, Me.Line8, Me.Label11, Me.TextBox9, Me.Line16, Me.Line10, Me.Label13, Me.Line12, Me.Label14, Me.txtAccountType})
        Me.GroupHeader1.DataField = "AccountCode"
        Me.GroupHeader1.Height = 0.8854167!
        Me.GroupHeader1.Name = "GroupHeader1"
        Me.GroupHeader1.NewPage = DataDynamics.ActiveReports.NewPage.Before
        Me.GroupHeader1.RepeatStyle = DataDynamics.ActiveReports.RepeatStyle.OnPageIncludeNoDetail
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
        Me.Label5.Height = 0.375!
        Me.Label5.HyperLink = Nothing
        Me.Label5.Left = 8.8125!
        Me.Label5.Name = "Label5"
        Me.Label5.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label5.Text = "Credit"
        Me.Label5.Top = 0.4375!
        Me.Label5.Width = 0.9375!
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
        Me.Label7.Height = 0.375!
        Me.Label7.HyperLink = Nothing
        Me.Label7.Left = 9.75!
        Me.Label7.Name = "Label7"
        Me.Label7.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label7.Text = "Balance"
        Me.Label7.Top = 0.4375!
        Me.Label7.Width = 1.0!
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
        Me.Label6.Height = 0.375!
        Me.Label6.HyperLink = Nothing
        Me.Label6.Left = 2.5625!
        Me.Label6.Name = "Label6"
        Me.Label6.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label6.Text = "Cheque / Invoice #"
        Me.Label6.Top = 0.4375!
        Me.Label6.Width = 1.0!
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
        Me.Label2.Height = 0.375!
        Me.Label2.HyperLink = Nothing
        Me.Label2.Left = 0.4375!
        Me.Label2.Name = "Label2"
        Me.Label2.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label2.Text = "Voucher No."
        Me.Label2.Top = 0.4375!
        Me.Label2.Width = 1.3125!
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
        Me.Label3.Height = 0.375!
        Me.Label3.HyperLink = Nothing
        Me.Label3.Left = 4.375!
        Me.Label3.Name = "Label3"
        Me.Label3.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label3.Text = "Description"
        Me.Label3.Top = 0.4375!
        Me.Label3.Width = 3.5!
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
        Me.Label4.Height = 0.375!
        Me.Label4.HyperLink = Nothing
        Me.Label4.Left = 7.875!
        Me.Label4.Name = "Label4"
        Me.Label4.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label4.Text = "Debit"
        Me.Label4.Top = 0.4375!
        Me.Label4.Width = 0.9375!
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
        Me.Line2.Height = 0.5!
        Me.Line2.Left = 0.4375!
        Me.Line2.LineWeight = 1.0!
        Me.Line2.Name = "Line2"
        Me.Line2.Top = 0.375!
        Me.Line2.Width = 0.0!
        Me.Line2.X1 = 0.4375!
        Me.Line2.X2 = 0.4375!
        Me.Line2.Y1 = 0.375!
        Me.Line2.Y2 = 0.875!
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
        Me.Line3.Height = 0.5!
        Me.Line3.Left = 10.75!
        Me.Line3.LineWeight = 1.0!
        Me.Line3.Name = "Line3"
        Me.Line3.Top = 0.375!
        Me.Line3.Width = 0.0!
        Me.Line3.X1 = 10.75!
        Me.Line3.X2 = 10.75!
        Me.Line3.Y1 = 0.375!
        Me.Line3.Y2 = 0.875!
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
        Me.Line4.Height = 0.5!
        Me.Line4.Left = 8.8125!
        Me.Line4.LineWeight = 1.0!
        Me.Line4.Name = "Line4"
        Me.Line4.Top = 0.375!
        Me.Line4.Width = 0.0!
        Me.Line4.X1 = 8.8125!
        Me.Line4.X2 = 8.8125!
        Me.Line4.Y1 = 0.375!
        Me.Line4.Y2 = 0.875!
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
        Me.Line5.Height = 0.5!
        Me.Line5.Left = 2.5625!
        Me.Line5.LineWeight = 1.0!
        Me.Line5.Name = "Line5"
        Me.Line5.Top = 0.375!
        Me.Line5.Width = 0.0!
        Me.Line5.X1 = 2.5625!
        Me.Line5.X2 = 2.5625!
        Me.Line5.Y1 = 0.375!
        Me.Line5.Y2 = 0.875!
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
        Me.Line6.Height = 0.5!
        Me.Line6.Left = 7.875!
        Me.Line6.LineWeight = 1.0!
        Me.Line6.Name = "Line6"
        Me.Line6.Top = 0.375!
        Me.Line6.Width = 0.0!
        Me.Line6.X1 = 7.875!
        Me.Line6.X2 = 7.875!
        Me.Line6.Y1 = 0.375!
        Me.Line6.Y2 = 0.875!
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
        Me.Line7.Height = 0.5!
        Me.Line7.Left = 4.375!
        Me.Line7.LineWeight = 1.0!
        Me.Line7.Name = "Line7"
        Me.Line7.Top = 0.375!
        Me.Line7.Width = 0.0!
        Me.Line7.X1 = 4.375!
        Me.Line7.X2 = 4.375!
        Me.Line7.Y1 = 0.375!
        Me.Line7.Y2 = 0.875!
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
        Me.Line1.Left = 0.4375!
        Me.Line1.LineWeight = 1.0!
        Me.Line1.Name = "Line1"
        Me.Line1.Top = 0.375!
        Me.Line1.Width = 10.3125!
        Me.Line1.X1 = 10.75!
        Me.Line1.X2 = 0.4375!
        Me.Line1.Y1 = 0.375!
        Me.Line1.Y2 = 0.375!
        '
        'Line8
        '
        Me.Line8.Border.BottomColor = System.Drawing.Color.Black
        Me.Line8.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.LeftColor = System.Drawing.Color.Black
        Me.Line8.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.RightColor = System.Drawing.Color.Black
        Me.Line8.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Border.TopColor = System.Drawing.Color.Black
        Me.Line8.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line8.Height = 0.5!
        Me.Line8.Left = 9.75!
        Me.Line8.LineWeight = 1.0!
        Me.Line8.Name = "Line8"
        Me.Line8.Top = 0.375!
        Me.Line8.Width = 0.0!
        Me.Line8.X1 = 9.75!
        Me.Line8.X2 = 9.75!
        Me.Line8.Y1 = 0.375!
        Me.Line8.Y2 = 0.875!
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
        Me.Label11.Height = 0.25!
        Me.Label11.HyperLink = Nothing
        Me.Label11.Left = 0.4375!
        Me.Label11.Name = "Label11"
        Me.Label11.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label11.Text = "Account Name :"
        Me.Label11.Top = 0.0625!
        Me.Label11.Width = 1.125!
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
        Me.TextBox9.DataField = "AccountName"
        Me.TextBox9.Height = 0.25!
        Me.TextBox9.Left = 1.625!
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Style = "font-weight: bold; vertical-align: middle; "
        Me.TextBox9.Text = "AccountName"
        Me.TextBox9.Top = 0.0625!
        Me.TextBox9.Width = 4.625!
        '
        'Line16
        '
        Me.Line16.Border.BottomColor = System.Drawing.Color.Black
        Me.Line16.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.LeftColor = System.Drawing.Color.Black
        Me.Line16.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.RightColor = System.Drawing.Color.Black
        Me.Line16.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Border.TopColor = System.Drawing.Color.Black
        Me.Line16.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line16.Height = 0.0!
        Me.Line16.Left = 0.4375!
        Me.Line16.LineWeight = 1.0!
        Me.Line16.Name = "Line16"
        Me.Line16.Top = 0.875!
        Me.Line16.Width = 10.3125!
        Me.Line16.X1 = 10.75!
        Me.Line16.X2 = 0.4375!
        Me.Line16.Y1 = 0.875!
        Me.Line16.Y2 = 0.875!
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
        Me.Line10.Height = 0.5!
        Me.Line10.Left = 3.5625!
        Me.Line10.LineWeight = 1.0!
        Me.Line10.Name = "Line10"
        Me.Line10.Top = 0.375!
        Me.Line10.Width = 0.0!
        Me.Line10.X1 = 3.5625!
        Me.Line10.X2 = 3.5625!
        Me.Line10.Y1 = 0.375!
        Me.Line10.Y2 = 0.875!
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
        Me.Label13.Height = 0.375!
        Me.Label13.HyperLink = Nothing
        Me.Label13.Left = 3.5625!
        Me.Label13.Name = "Label13"
        Me.Label13.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label13.Text = "Cheque Date"
        Me.Label13.Top = 0.4375!
        Me.Label13.Width = 0.8125!
        '
        'Line12
        '
        Me.Line12.Border.BottomColor = System.Drawing.Color.Black
        Me.Line12.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.LeftColor = System.Drawing.Color.Black
        Me.Line12.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.RightColor = System.Drawing.Color.Black
        Me.Line12.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Border.TopColor = System.Drawing.Color.Black
        Me.Line12.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line12.Height = 0.5!
        Me.Line12.Left = 1.75!
        Me.Line12.LineWeight = 1.0!
        Me.Line12.Name = "Line12"
        Me.Line12.Top = 0.375!
        Me.Line12.Width = 0.0!
        Me.Line12.X1 = 1.75!
        Me.Line12.X2 = 1.75!
        Me.Line12.Y1 = 0.375!
        Me.Line12.Y2 = 0.875!
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
        Me.Label14.Height = 0.375!
        Me.Label14.HyperLink = Nothing
        Me.Label14.Left = 1.75!
        Me.Label14.Name = "Label14"
        Me.Label14.Style = "text-align: center; font-weight: bold; font-size: 9.75pt; vertical-align: middle;" & _
            " "
        Me.Label14.Text = "Voucher Date"
        Me.Label14.Top = 0.4375!
        Me.Label14.Width = 0.8125!
        '
        'txtAccountType
        '
        Me.txtAccountType.Border.BottomColor = System.Drawing.Color.Black
        Me.txtAccountType.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAccountType.Border.LeftColor = System.Drawing.Color.Black
        Me.txtAccountType.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAccountType.Border.RightColor = System.Drawing.Color.Black
        Me.txtAccountType.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAccountType.Border.TopColor = System.Drawing.Color.Black
        Me.txtAccountType.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.txtAccountType.DataField = "AccountType"
        Me.txtAccountType.Height = 0.25!
        Me.txtAccountType.Left = 6.375!
        Me.txtAccountType.Name = "txtAccountType"
        Me.txtAccountType.Style = "font-weight: bold; vertical-align: middle; "
        Me.txtAccountType.Text = "AccountName"
        Me.txtAccountType.Top = 0.0625!
        Me.txtAccountType.Visible = False
        Me.txtAccountType.Width = 1.125!
        '
        'GroupFooter1
        '
        Me.GroupFooter1.Controls.AddRange(New DataDynamics.ActiveReports.ARControl() {Me.TextBox2, Me.TextBox12, Me.TextBox11, Me.Label12, Me.Line18, Me.Line19})
        Me.GroupFooter1.Height = 0.46875!
        Me.GroupFooter1.Name = "GroupFooter1"
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
        Me.TextBox2.DataField = "Balance"
        Me.TextBox2.Height = 0.25!
        Me.TextBox2.Left = 9.75!
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.OutputFormat = resources.GetString("TextBox2.OutputFormat")
        Me.TextBox2.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
            "l-align: middle; "
        Me.TextBox2.SummaryGroup = "GroupHeader1"
        Me.TextBox2.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox2.Text = "Credit"
        Me.TextBox2.Top = 0.125!
        Me.TextBox2.Width = 1.0!
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
        Me.TextBox12.DataField = "Credit"
        Me.TextBox12.Height = 0.25!
        Me.TextBox12.Left = 8.8125!
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.OutputFormat = resources.GetString("TextBox12.OutputFormat")
        Me.TextBox12.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
            "l-align: middle; "
        Me.TextBox12.SummaryGroup = "GroupHeader1"
        Me.TextBox12.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox12.Text = "Credit"
        Me.TextBox12.Top = 0.125!
        Me.TextBox12.Width = 0.9375!
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
        Me.TextBox11.DataField = "Debit"
        Me.TextBox11.Height = 0.25!
        Me.TextBox11.Left = 7.875!
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.OutputFormat = resources.GetString("TextBox11.OutputFormat")
        Me.TextBox11.Style = "ddo-char-set: 0; text-align: right; font-weight: bold; font-size: 8.25pt; vertica" & _
            "l-align: middle; "
        Me.TextBox11.SummaryGroup = "GroupHeader1"
        Me.TextBox11.SummaryType = DataDynamics.ActiveReports.SummaryType.SubTotal
        Me.TextBox11.Text = "Debit"
        Me.TextBox11.Top = 0.125!
        Me.TextBox11.Width = 0.9375!
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
        Me.Label12.Height = 0.25!
        Me.Label12.HyperLink = Nothing
        Me.Label12.Left = 0.4375!
        Me.Label12.Name = "Label12"
        Me.Label12.Style = "text-align: justify; font-weight: bold; font-size: 9.75pt; vertical-align: middle" & _
            "; "
        Me.Label12.Text = "Total"
        Me.Label12.Top = 0.125!
        Me.Label12.Width = 2.1875!
        '
        'Line18
        '
        Me.Line18.Border.BottomColor = System.Drawing.Color.Black
        Me.Line18.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.LeftColor = System.Drawing.Color.Black
        Me.Line18.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.RightColor = System.Drawing.Color.Black
        Me.Line18.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Border.TopColor = System.Drawing.Color.Black
        Me.Line18.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line18.Height = 0.0!
        Me.Line18.Left = 0.4375!
        Me.Line18.LineWeight = 1.0!
        Me.Line18.Name = "Line18"
        Me.Line18.Top = 0.125!
        Me.Line18.Width = 10.3125!
        Me.Line18.X1 = 10.75!
        Me.Line18.X2 = 0.4375!
        Me.Line18.Y1 = 0.125!
        Me.Line18.Y2 = 0.125!
        '
        'Line19
        '
        Me.Line19.Border.BottomColor = System.Drawing.Color.Black
        Me.Line19.Border.BottomStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.LeftColor = System.Drawing.Color.Black
        Me.Line19.Border.LeftStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.RightColor = System.Drawing.Color.Black
        Me.Line19.Border.RightStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Border.TopColor = System.Drawing.Color.Black
        Me.Line19.Border.TopStyle = DataDynamics.ActiveReports.BorderLineStyle.None
        Me.Line19.Height = 0.0!
        Me.Line19.Left = 0.4375!
        Me.Line19.LineWeight = 1.0!
        Me.Line19.Name = "Line19"
        Me.Line19.Top = 0.375!
        Me.Line19.Width = 10.3125!
        Me.Line19.X1 = 10.75!
        Me.Line19.X2 = 0.4375!
        Me.Line19.Y1 = 0.375!
        Me.Line19.Y2 = 0.375!
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
        Me.Line9.Height = 0.0!
        Me.Line9.Left = 0.4375!
        Me.Line9.LineStyle = DataDynamics.ActiveReports.LineStyle.Dash
        Me.Line9.LineWeight = 1.0!
        Me.Line9.Name = "Line9"
        Me.Line9.Top = 0.25!
        Me.Line9.Width = 10.3125!
        Me.Line9.X1 = 10.75!
        Me.Line9.X2 = 0.4375!
        Me.Line9.Y1 = 0.25!
        Me.Line9.Y2 = 0.25!
        '
        'rptGeneralLedger
        '
        Me.MasterReport = False
        Me.PageSettings.DefaultPaperSize = False
        Me.PageSettings.Margins.Bottom = 0.0!
        Me.PageSettings.Margins.Left = 0.0!
        Me.PageSettings.Margins.Right = 0.0!
        Me.PageSettings.Margins.Top = 0.0!
        Me.PageSettings.Orientation = DataDynamics.ActiveReports.Document.PageOrientation.Landscape
        Me.PageSettings.PaperHeight = 11.69291!
        Me.PageSettings.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.PageSettings.PaperWidth = 8.267716!
        Me.PrintWidth = 10.78125!
        Me.Sections.Add(Me.PageHeader1)
        Me.Sections.Add(Me.GroupHeader1)
        Me.Sections.Add(Me.Detail1)
        Me.Sections.Add(Me.GroupFooter1)
        Me.Sections.Add(Me.PageFooter1)
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Arial; font-style: normal; text-decoration: none; font-weight: norma" & _
                    "l; font-size: 10pt; color: Black; ", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 16pt; font-weight: bold; ", "Heading1", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-family: Times New Roman; font-size: 14pt; font-weight: bold; font-style: ita" & _
                    "lic; ", "Heading2", "Normal"))
        Me.StyleSheet.Add(New DDCssLib.StyleSheetRule("font-size: 13pt; font-weight: bold; ", "Heading3", "Normal"))
        CType(Me.fldTitle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDescription, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldChequeDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldChequeNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldVoucherDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldVoucherNo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDebit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDateTime, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldPage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldDivision, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.fldUserID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAccountType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TextBox11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Label12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub
    Friend WithEvents fldDateTime As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldTitle As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label1 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldCompany As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label8 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldPage As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label10 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldDivision As DataDynamics.ActiveReports.TextBox
    Friend WithEvents GroupHeader1 As DataDynamics.ActiveReports.GroupHeader
    Friend WithEvents Label2 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label3 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label4 As DataDynamics.ActiveReports.Label
    Friend WithEvents Label5 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line1 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line2 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line3 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line4 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line5 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line6 As DataDynamics.ActiveReports.Line
    Friend WithEvents GroupFooter1 As DataDynamics.ActiveReports.GroupFooter
    Friend WithEvents Label6 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line7 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line8 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label7 As DataDynamics.ActiveReports.Label
    Friend WithEvents fldChequeDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldChequeNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldCredit As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldBalance As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldDescription As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldVoucherDate As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldVoucherNo As DataDynamics.ActiveReports.TextBox
    Friend WithEvents fldDebit As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label11 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox9 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line16 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label12 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line18 As DataDynamics.ActiveReports.Line
    Friend WithEvents Line19 As DataDynamics.ActiveReports.Line
    Friend WithEvents TextBox12 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents TextBox11 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtProject As DataDynamics.ActiveReports.Label
    Friend WithEvents fldUserID As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Label9 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line10 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label13 As DataDynamics.ActiveReports.Label
    Friend WithEvents Line12 As DataDynamics.ActiveReports.Line
    Friend WithEvents Label14 As DataDynamics.ActiveReports.Label
    Friend WithEvents TextBox2 As DataDynamics.ActiveReports.TextBox
    Friend WithEvents txtAccountType As DataDynamics.ActiveReports.TextBox
    Friend WithEvents Line9 As DataDynamics.ActiveReports.Line
End Class
