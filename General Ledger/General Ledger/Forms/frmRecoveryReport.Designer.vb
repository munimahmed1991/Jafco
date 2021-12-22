<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecoveryReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecoveryReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkIncludeRecovery = New System.Windows.Forms.CheckBox
        Me.cmbBlock = New C1.Win.C1List.C1Combo
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCustomerType = New System.Windows.Forms.ComboBox
        Me.cmbPaymentType = New C1.Win.C1List.C1Combo
        Me.Label24 = New System.Windows.Forms.Label
        Me.chkIncludePenalty = New System.Windows.Forms.CheckBox
        Me.cmbUnitNoClear = New System.Windows.Forms.Button
        Me.cmbUnitTypeClear = New System.Windows.Forms.Button
        Me.cmdUnit = New System.Windows.Forms.Button
        Me.cmbUnit = New C1.Win.C1List.C1Combo
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbReportType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.cmdUnitType = New System.Windows.Forms.Button
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.optRecoveryReportProvisional = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.optRecoveryReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator
        Me.optRecoveryReportTillDate = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.optAgingAnalysis = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator
        Me.optCustomerStatement = New System.Windows.Forms.ToolStripButton
        Me.optMonthWiseRecovery = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.optServiceRecoveryReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator
        Me.optCashRecoveryReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator
        Me.optLoanRecoveryReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator
        Me.optExtraChargesReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator
        Me.OptReceiptRecoveryReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator
        Me.optRecoveryReportCancel = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator
        Me.optRecoveryForecast = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtYear = New C1.Win.C1Input.C1NumericEdit
        Me.cmbMonth = New System.Windows.Forms.ComboBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkIncludeRecovery)
        Me.GroupBox1.Controls.Add(Me.cmbBlock)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbCustomerType)
        Me.GroupBox1.Controls.Add(Me.cmbPaymentType)
        Me.GroupBox1.Controls.Add(Me.Label24)
        Me.GroupBox1.Controls.Add(Me.chkIncludePenalty)
        Me.GroupBox1.Controls.Add(Me.cmbUnitNoClear)
        Me.GroupBox1.Controls.Add(Me.cmbUnitTypeClear)
        Me.GroupBox1.Controls.Add(Me.cmdUnit)
        Me.GroupBox1.Controls.Add(Me.cmbUnit)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbReportType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.cmdUnitType)
        Me.GroupBox1.Controls.Add(Me.cmbUnitType)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.cmbProject)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(217, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 259)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Filters"
        '
        'chkIncludeRecovery
        '
        Me.chkIncludeRecovery.AutoSize = True
        Me.chkIncludeRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncludeRecovery.Location = New System.Drawing.Point(339, 227)
        Me.chkIncludeRecovery.Name = "chkIncludeRecovery"
        Me.chkIncludeRecovery.Size = New System.Drawing.Size(110, 17)
        Me.chkIncludeRecovery.TabIndex = 284
        Me.chkIncludeRecovery.Text = "Include Recovery"
        Me.chkIncludeRecovery.UseVisualStyleBackColor = True
        '
        'cmbBlock
        '
        Me.cmbBlock.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBlock.Caption = ""
        Me.cmbBlock.CaptionHeight = 17
        Me.cmbBlock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBlock.ColumnCaptionHeight = 17
        Me.cmbBlock.ColumnFooterHeight = 17
        Me.cmbBlock.ContentHeight = 15
        Me.cmbBlock.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBlock.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBlock.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBlock.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBlock.EditorHeight = 15
        Me.cmbBlock.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBlock.Images.Add(CType(resources.GetObject("cmbBlock.Images"), System.Drawing.Image))
        Me.cmbBlock.ItemHeight = 15
        Me.cmbBlock.Location = New System.Drawing.Point(325, 151)
        Me.cmbBlock.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBlock.MaxDropDownItems = CType(5, Short)
        Me.cmbBlock.MaxLength = 32767
        Me.cmbBlock.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBlock.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBlock.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBlock.Size = New System.Drawing.Size(111, 21)
        Me.cmbBlock.TabIndex = 283
        Me.cmbBlock.PropBag = resources.GetString("cmbBlock.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(231, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 13)
        Me.Label6.TabIndex = 282
        Me.Label6.Text = "Block / Tower"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(231, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 281
        Me.Label5.Text = "CustomerType"
        '
        'cmbCustomerType
        '
        Me.cmbCustomerType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCustomerType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomerType.FormattingEnabled = True
        Me.cmbCustomerType.Items.AddRange(New Object() {"Active", "Non Active", "Both"})
        Me.cmbCustomerType.Location = New System.Drawing.Point(325, 189)
        Me.cmbCustomerType.Name = "cmbCustomerType"
        Me.cmbCustomerType.Size = New System.Drawing.Size(111, 21)
        Me.cmbCustomerType.TabIndex = 280
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPaymentType.Caption = ""
        Me.cmbPaymentType.CaptionHeight = 17
        Me.cmbPaymentType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPaymentType.ColumnCaptionHeight = 17
        Me.cmbPaymentType.ColumnFooterHeight = 17
        Me.cmbPaymentType.ContentHeight = 15
        Me.cmbPaymentType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPaymentType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPaymentType.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPaymentType.EditorHeight = 15
        Me.cmbPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentType.Images.Add(CType(resources.GetObject("cmbPaymentType.Images"), System.Drawing.Image))
        Me.cmbPaymentType.ItemHeight = 15
        Me.cmbPaymentType.Location = New System.Drawing.Point(101, 151)
        Me.cmbPaymentType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPaymentType.MaxDropDownItems = CType(5, Short)
        Me.cmbPaymentType.MaxLength = 32767
        Me.cmbPaymentType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPaymentType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.Size = New System.Drawing.Size(111, 21)
        Me.cmbPaymentType.TabIndex = 279
        Me.cmbPaymentType.PropBag = resources.GetString("cmbPaymentType.PropBag")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(7, 155)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 13)
        Me.Label24.TabIndex = 278
        Me.Label24.Text = "Payment Type"
        '
        'chkIncludePenalty
        '
        Me.chkIncludePenalty.AutoSize = True
        Me.chkIncludePenalty.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkIncludePenalty.Location = New System.Drawing.Point(234, 227)
        Me.chkIncludePenalty.Name = "chkIncludePenalty"
        Me.chkIncludePenalty.Size = New System.Drawing.Size(99, 17)
        Me.chkIncludePenalty.TabIndex = 277
        Me.chkIncludePenalty.Text = "Include Penalty"
        Me.chkIncludePenalty.UseVisualStyleBackColor = True
        '
        'cmbUnitNoClear
        '
        Me.cmbUnitNoClear.Location = New System.Drawing.Point(401, 109)
        Me.cmbUnitNoClear.Name = "cmbUnitNoClear"
        Me.cmbUnitNoClear.Size = New System.Drawing.Size(44, 23)
        Me.cmbUnitNoClear.TabIndex = 268
        Me.cmbUnitNoClear.Text = "Clear"
        Me.cmbUnitNoClear.UseVisualStyleBackColor = True
        '
        'cmbUnitTypeClear
        '
        Me.cmbUnitTypeClear.Location = New System.Drawing.Point(401, 70)
        Me.cmbUnitTypeClear.Name = "cmbUnitTypeClear"
        Me.cmbUnitTypeClear.Size = New System.Drawing.Size(44, 23)
        Me.cmbUnitTypeClear.TabIndex = 267
        Me.cmbUnitTypeClear.Text = "Clear"
        Me.cmbUnitTypeClear.UseVisualStyleBackColor = True
        '
        'cmdUnit
        '
        Me.cmdUnit.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnit.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnit.Location = New System.Drawing.Point(379, 111)
        Me.cmdUnit.Name = "cmdUnit"
        Me.cmdUnit.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnit.TabIndex = 266
        Me.cmdUnit.UseVisualStyleBackColor = True
        '
        'cmbUnit
        '
        Me.cmbUnit.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnit.Caption = ""
        Me.cmbUnit.CaptionHeight = 17
        Me.cmbUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnit.ColumnCaptionHeight = 17
        Me.cmbUnit.ColumnFooterHeight = 17
        Me.cmbUnit.ContentHeight = 15
        Me.cmbUnit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.EditorHeight = 15
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.Images.Add(CType(resources.GetObject("cmbUnit.Images"), System.Drawing.Image))
        Me.cmbUnit.ItemHeight = 15
        Me.cmbUnit.Location = New System.Drawing.Point(101, 111)
        Me.cmbUnit.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnit.MaxDropDownItems = CType(5, Short)
        Me.cmbUnit.MaxLength = 32767
        Me.cmbUnit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.ReadOnly = True
        Me.cmbUnit.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUnit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnit.Size = New System.Drawing.Size(278, 21)
        Me.cmbUnit.TabIndex = 264
        Me.cmbUnit.PropBag = resources.GetString("cmbUnit.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 115)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 265
        Me.Label21.Text = "Unit #"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 263
        Me.Label1.Text = "Report Type"
        '
        'cmbReportType
        '
        Me.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbReportType.FormattingEnabled = True
        Me.cmbReportType.Items.AddRange(New Object() {"Report", "Grid", "Excel"})
        Me.cmbReportType.Location = New System.Drawing.Point(101, 225)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(111, 21)
        Me.cmbReportType.TabIndex = 262
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 192)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(88, 13)
        Me.Label4.TabIndex = 261
        Me.Label4.Text = "Recovery Report"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Poor", "Good", "Excellent", "All"})
        Me.cmbStatus.Location = New System.Drawing.Point(101, 188)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(111, 21)
        Me.cmbStatus.TabIndex = 260
        '
        'cmdUnitType
        '
        Me.cmdUnitType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitType.Location = New System.Drawing.Point(379, 71)
        Me.cmdUnitType.Name = "cmdUnitType"
        Me.cmdUnitType.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnitType.TabIndex = 257
        Me.cmdUnitType.UseVisualStyleBackColor = True
        '
        'cmbUnitType
        '
        Me.cmbUnitType.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnitType.Caption = ""
        Me.cmbUnitType.CaptionHeight = 17
        Me.cmbUnitType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnitType.ColumnCaptionHeight = 17
        Me.cmbUnitType.ColumnFooterHeight = 17
        Me.cmbUnitType.ContentHeight = 15
        Me.cmbUnitType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnitType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnitType.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnitType.EditorHeight = 15
        Me.cmbUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitType.Images.Add(CType(resources.GetObject("cmbUnitType.Images"), System.Drawing.Image))
        Me.cmbUnitType.ItemHeight = 15
        Me.cmbUnitType.Location = New System.Drawing.Point(101, 71)
        Me.cmbUnitType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnitType.MaxDropDownItems = CType(5, Short)
        Me.cmbUnitType.MaxLength = 32767
        Me.cmbUnitType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnitType.Name = "cmbUnitType"
        Me.cmbUnitType.ReadOnly = True
        Me.cmbUnitType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUnitType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnitType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnitType.Size = New System.Drawing.Size(278, 21)
        Me.cmbUnitType.TabIndex = 255
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(7, 75)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 256
        Me.Label27.Text = "Unit Type"
        '
        'cmbProject
        '
        Me.cmbProject.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProject.Caption = ""
        Me.cmbProject.CaptionHeight = 17
        Me.cmbProject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProject.ColumnCaptionHeight = 17
        Me.cmbProject.ColumnFooterHeight = 17
        Me.cmbProject.ContentHeight = 15
        Me.cmbProject.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProject.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProject.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProject.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProject.EditorHeight = 15
        Me.cmbProject.Images.Add(CType(resources.GetObject("cmbProject.Images"), System.Drawing.Image))
        Me.cmbProject.ItemHeight = 15
        Me.cmbProject.Location = New System.Drawing.Point(101, 29)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 241
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(7, 34)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "Project"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(180, 6)
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.optRecoveryReportProvisional, Me.ToolStripSeparator6, Me.optRecoveryReport, Me.ToolStripSeparator14, Me.optRecoveryReportTillDate, Me.ToolStripSeparator1, Me.optAgingAnalysis, Me.ToolStripSeparator11, Me.optCustomerStatement, Me.ToolStripSeparator4, Me.optMonthWiseRecovery, Me.ToolStripSeparator3, Me.optServiceRecoveryReport, Me.ToolStripSeparator5, Me.optCashRecoveryReport, Me.ToolStripSeparator7, Me.optLoanRecoveryReport, Me.ToolStripSeparator8, Me.optExtraChargesReport, Me.ToolStripSeparator9, Me.OptReceiptRecoveryReport, Me.ToolStripSeparator10, Me.optRecoveryReportCancel, Me.ToolStripSeparator12, Me.optRecoveryForecast, Me.ToolStripSeparator13})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(214, 468)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'optRecoveryReportProvisional
        '
        Me.optRecoveryReportProvisional.AutoSize = False
        Me.optRecoveryReportProvisional.Checked = True
        Me.optRecoveryReportProvisional.CheckOnClick = True
        Me.optRecoveryReportProvisional.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optRecoveryReportProvisional.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optRecoveryReportProvisional.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optRecoveryReportProvisional.Name = "optRecoveryReportProvisional"
        Me.optRecoveryReportProvisional.Size = New System.Drawing.Size(180, 25)
        Me.optRecoveryReportProvisional.Text = "Recovery Report Provisional"
        Me.optRecoveryReportProvisional.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        'optRecoveryReport
        '
        Me.optRecoveryReport.AutoSize = False
        Me.optRecoveryReport.Checked = True
        Me.optRecoveryReport.CheckOnClick = True
        Me.optRecoveryReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optRecoveryReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optRecoveryReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optRecoveryReport.Name = "optRecoveryReport"
        Me.optRecoveryReport.Size = New System.Drawing.Size(180, 25)
        Me.optRecoveryReport.Text = "Recovery Report"
        Me.optRecoveryReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.AutoSize = False
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(180, 6)
        '
        'optRecoveryReportTillDate
        '
        Me.optRecoveryReportTillDate.AutoSize = False
        Me.optRecoveryReportTillDate.CheckOnClick = True
        Me.optRecoveryReportTillDate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optRecoveryReportTillDate.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optRecoveryReportTillDate.Name = "optRecoveryReportTillDate"
        Me.optRecoveryReportTillDate.Size = New System.Drawing.Size(180, 25)
        Me.optRecoveryReportTillDate.Text = "Recovery Report Before Month"
        Me.optRecoveryReportTillDate.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'optAgingAnalysis
        '
        Me.optAgingAnalysis.AutoSize = False
        Me.optAgingAnalysis.CheckOnClick = True
        Me.optAgingAnalysis.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optAgingAnalysis.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optAgingAnalysis.Name = "optAgingAnalysis"
        Me.optAgingAnalysis.Size = New System.Drawing.Size(220, 25)
        Me.optAgingAnalysis.Text = "Aging Analysis Report"
        Me.optAgingAnalysis.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(180, 6)
        '
        'optCustomerStatement
        '
        Me.optCustomerStatement.AutoSize = False
        Me.optCustomerStatement.Checked = True
        Me.optCustomerStatement.CheckOnClick = True
        Me.optCustomerStatement.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optCustomerStatement.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optCustomerStatement.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optCustomerStatement.Name = "optCustomerStatement"
        Me.optCustomerStatement.Size = New System.Drawing.Size(180, 25)
        Me.optCustomerStatement.Text = "Customer Statement"
        Me.optCustomerStatement.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'optMonthWiseRecovery
        '
        Me.optMonthWiseRecovery.AutoSize = False
        Me.optMonthWiseRecovery.Checked = True
        Me.optMonthWiseRecovery.CheckOnClick = True
        Me.optMonthWiseRecovery.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optMonthWiseRecovery.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optMonthWiseRecovery.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optMonthWiseRecovery.Name = "optMonthWiseRecovery"
        Me.optMonthWiseRecovery.Size = New System.Drawing.Size(180, 25)
        Me.optMonthWiseRecovery.Text = "Monthly Recovery Breakup"
        Me.optMonthWiseRecovery.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(180, 6)
        '
        'optServiceRecoveryReport
        '
        Me.optServiceRecoveryReport.AutoSize = False
        Me.optServiceRecoveryReport.Checked = True
        Me.optServiceRecoveryReport.CheckOnClick = True
        Me.optServiceRecoveryReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optServiceRecoveryReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optServiceRecoveryReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optServiceRecoveryReport.Name = "optServiceRecoveryReport"
        Me.optServiceRecoveryReport.Size = New System.Drawing.Size(180, 25)
        Me.optServiceRecoveryReport.Text = "Utilities Recovery Report"
        Me.optServiceRecoveryReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(180, 6)
        '
        'optCashRecoveryReport
        '
        Me.optCashRecoveryReport.AutoSize = False
        Me.optCashRecoveryReport.Checked = True
        Me.optCashRecoveryReport.CheckOnClick = True
        Me.optCashRecoveryReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optCashRecoveryReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optCashRecoveryReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optCashRecoveryReport.Name = "optCashRecoveryReport"
        Me.optCashRecoveryReport.Size = New System.Drawing.Size(180, 25)
        Me.optCashRecoveryReport.Text = "Cash Recovery Report"
        Me.optCashRecoveryReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(180, 6)
        '
        'optLoanRecoveryReport
        '
        Me.optLoanRecoveryReport.AutoSize = False
        Me.optLoanRecoveryReport.Checked = True
        Me.optLoanRecoveryReport.CheckOnClick = True
        Me.optLoanRecoveryReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optLoanRecoveryReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optLoanRecoveryReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optLoanRecoveryReport.Name = "optLoanRecoveryReport"
        Me.optLoanRecoveryReport.Size = New System.Drawing.Size(180, 25)
        Me.optLoanRecoveryReport.Text = "Loan Recovery Report"
        Me.optLoanRecoveryReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(180, 6)
        '
        'optExtraChargesReport
        '
        Me.optExtraChargesReport.AutoSize = False
        Me.optExtraChargesReport.Checked = True
        Me.optExtraChargesReport.CheckOnClick = True
        Me.optExtraChargesReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optExtraChargesReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optExtraChargesReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optExtraChargesReport.Name = "optExtraChargesReport"
        Me.optExtraChargesReport.Size = New System.Drawing.Size(180, 25)
        Me.optExtraChargesReport.Text = "Extra Charges Recovery Report"
        Me.optExtraChargesReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(180, 6)
        '
        'OptReceiptRecoveryReport
        '
        Me.OptReceiptRecoveryReport.AutoSize = False
        Me.OptReceiptRecoveryReport.Checked = True
        Me.OptReceiptRecoveryReport.CheckOnClick = True
        Me.OptReceiptRecoveryReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.OptReceiptRecoveryReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.OptReceiptRecoveryReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OptReceiptRecoveryReport.Name = "OptReceiptRecoveryReport"
        Me.OptReceiptRecoveryReport.Size = New System.Drawing.Size(180, 25)
        Me.OptReceiptRecoveryReport.Text = "Receipt Recovery Report"
        Me.OptReceiptRecoveryReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(180, 6)
        '
        'optRecoveryReportCancel
        '
        Me.optRecoveryReportCancel.AutoSize = False
        Me.optRecoveryReportCancel.Checked = True
        Me.optRecoveryReportCancel.CheckOnClick = True
        Me.optRecoveryReportCancel.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optRecoveryReportCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optRecoveryReportCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optRecoveryReportCancel.Name = "optRecoveryReportCancel"
        Me.optRecoveryReportCancel.Size = New System.Drawing.Size(180, 25)
        Me.optRecoveryReportCancel.Text = "Recovery Report Cancel"
        Me.optRecoveryReportCancel.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.AutoSize = False
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(180, 6)
        '
        'optRecoveryForecast
        '
        Me.optRecoveryForecast.AutoSize = False
        Me.optRecoveryForecast.CheckOnClick = True
        Me.optRecoveryForecast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optRecoveryForecast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optRecoveryForecast.Name = "optRecoveryForecast"
        Me.optRecoveryForecast.Size = New System.Drawing.Size(180, 25)
        Me.optRecoveryForecast.Text = "Recovery Forecast"
        Me.optRecoveryForecast.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.AutoSize = False
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(180, 6)
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtYear)
        Me.GroupBox2.Controls.Add(Me.cmbMonth)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtDateTo)
        Me.GroupBox2.Controls.Add(Me.txtDateFrom)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(217, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 77)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(432, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(29, 13)
        Me.Label8.TabIndex = 305
        Me.Label8.Text = "Year"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(236, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 304
        Me.Label2.Text = "Select Month"
        '
        'txtYear
        '
        Me.txtYear.AutoSize = False
        Me.txtYear.BackColor = System.Drawing.Color.White
        Me.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtYear.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtYear.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtYear.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYear.Location = New System.Drawing.Point(462, 18)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(50, 20)
        Me.txtYear.TabIndex = 303
        Me.txtYear.Tag = Nothing
        Me.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtYear.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtYear.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtYear.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtYear.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmbMonth
        '
        Me.cmbMonth.FormattingEnabled = True
        Me.cmbMonth.Items.AddRange(New Object() {"", "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbMonth.Location = New System.Drawing.Point(311, 18)
        Me.cmbMonth.Name = "cmbMonth"
        Me.cmbMonth.Size = New System.Drawing.Size(113, 21)
        Me.cmbMonth.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(13, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Upto :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(13, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(36, 13)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "From :"
        '
        'txtDateTo
        '
        Me.txtDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateTo.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.ClearText = "&Clear"
        Me.txtDateTo.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDateTo.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDateTo.Calendar.TodayText = "&Today"
        Me.txtDateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateTo.Culture = 1056
        Me.txtDateTo.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateTo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(59, 45)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(153, 21)
        Me.txtDateTo.TabIndex = 1
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.TrimEnd = False
        Me.txtDateTo.Value = New Date(2008, 7, 1, 0, 0, 0, 0)
        Me.txtDateTo.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtDateTo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.txtDateTo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'txtDateFrom
        '
        Me.txtDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateFrom.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDateFrom.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDateFrom.Calendar.ClearText = "&Clear"
        Me.txtDateFrom.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDateFrom.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDateFrom.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDateFrom.Calendar.TodayText = "&Today"
        Me.txtDateFrom.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateFrom.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateFrom.Culture = 1056
        Me.txtDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateFrom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.Location = New System.Drawing.Point(59, 18)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(153, 21)
        Me.txtDateFrom.TabIndex = 0
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.TrimEnd = False
        Me.txtDateFrom.Value = New Date(2008, 7, 1, 0, 0, 0, 0)
        Me.txtDateFrom.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtDateFrom.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.txtDateFrom.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.General_Ledger.My.Resources.Resources.folder_document
        Me.cmdPrint.Location = New System.Drawing.Point(586, 350)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(49, 56)
        Me.cmdPrint.TabIndex = 249
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdOk
        '
        Me.cmdOk.Image = Global.General_Ledger.My.Resources.Resources.folder_ok
        Me.cmdOk.Location = New System.Drawing.Point(636, 351)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(51, 54)
        Me.cmdOk.TabIndex = 17
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(690, 351)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 54)
        Me.cmdExit.TabIndex = 18
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmRecoveryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 468)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmRecoveryReport"
        Me.Text = "Recovery Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtYear, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdUnitType As System.Windows.Forms.Button
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optRecoveryReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents optAgingAnalysis As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents cmdUnit As System.Windows.Forms.Button
    Friend WithEvents cmbUnit As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents optCustomerStatement As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbUnitNoClear As System.Windows.Forms.Button
    Friend WithEvents cmbUnitTypeClear As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optMonthWiseRecovery As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbMonth As System.Windows.Forms.ComboBox
    Friend WithEvents txtYear As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chkIncludePenalty As System.Windows.Forms.CheckBox
    Friend WithEvents cmbPaymentType As C1.Win.C1List.C1Combo
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCustomerType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optServiceRecoveryReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator5 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optCashRecoveryReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator7 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optLoanRecoveryReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator8 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optExtraChargesReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmbBlock As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator9 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optRecoveryReportCancel As System.Windows.Forms.ToolStripButton
    Friend WithEvents OptReceiptRecoveryReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents optRecoveryReportProvisional As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator11 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripSeparator12 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optRecoveryForecast As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolStripSeparator14 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optRecoveryReportTillDate As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator13 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents chkIncludeRecovery As System.Windows.Forms.CheckBox
End Class
