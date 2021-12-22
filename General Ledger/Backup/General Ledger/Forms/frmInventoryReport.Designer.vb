<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInventoryReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInventoryReport))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbReportType = New System.Windows.Forms.ComboBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbStatus = New System.Windows.Forms.ComboBox
        Me.cmbBlock = New C1.Win.C1List.C1Combo
        Me.Label28 = New System.Windows.Forms.Label
        Me.cmdUnitType = New System.Windows.Forms.Button
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.optPriceList = New System.Windows.Forms.ToolStripButton
        Me.optInventorySummaryReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator
        Me.optBookingReport = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.optPriceChangeReport = New System.Windows.Forms.ToolStripButton
        Me.cmdOk = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.cmbReportType)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbStatus)
        Me.GroupBox1.Controls.Add(Me.cmbBlock)
        Me.GroupBox1.Controls.Add(Me.Label28)
        Me.GroupBox1.Controls.Add(Me.cmdUnitType)
        Me.GroupBox1.Controls.Add(Me.cmbUnitType)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.cmbProject)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(217, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(524, 222)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Report Filters"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 188)
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
        Me.cmbReportType.Location = New System.Drawing.Point(91, 185)
        Me.cmbReportType.Name = "cmbReportType"
        Me.cmbReportType.Size = New System.Drawing.Size(111, 21)
        Me.cmbReportType.TabIndex = 262
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(7, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 261
        Me.Label4.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Booked", "Available", "Both"})
        Me.cmbStatus.Location = New System.Drawing.Point(91, 148)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(111, 21)
        Me.cmbStatus.TabIndex = 260
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
        Me.cmbBlock.Images.Add(CType(resources.GetObject("cmbBlock.Images"), System.Drawing.Image))
        Me.cmbBlock.ItemHeight = 15
        Me.cmbBlock.Location = New System.Drawing.Point(91, 107)
        Me.cmbBlock.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBlock.MaxDropDownItems = CType(5, Short)
        Me.cmbBlock.MaxLength = 32767
        Me.cmbBlock.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBlock.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBlock.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBlock.Size = New System.Drawing.Size(144, 21)
        Me.cmbBlock.TabIndex = 259
        Me.cmbBlock.PropBag = resources.GetString("cmbBlock.PropBag")
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.ForeColor = System.Drawing.Color.Black
        Me.Label28.Location = New System.Drawing.Point(7, 111)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(34, 13)
        Me.Label28.TabIndex = 258
        Me.Label28.Text = "Block"
        '
        'cmdUnitType
        '
        Me.cmdUnitType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitType.Location = New System.Drawing.Point(369, 67)
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
        Me.cmbUnitType.Location = New System.Drawing.Point(91, 67)
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
        Me.Label27.Location = New System.Drawing.Point(7, 70)
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
        Me.cmbProject.Location = New System.Drawing.Point(91, 25)
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
        Me.Label3.Location = New System.Drawing.Point(7, 29)
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
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.optPriceList, Me.ToolStripSeparator4, Me.optInventorySummaryReport, Me.ToolStripSeparator6, Me.optBookingReport, Me.ToolStripSeparator1, Me.optPriceChangeReport})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(214, 386)
        Me.ToolStrip1.TabIndex = 19
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'optPriceList
        '
        Me.optPriceList.AutoSize = False
        Me.optPriceList.Checked = True
        Me.optPriceList.CheckOnClick = True
        Me.optPriceList.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optPriceList.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optPriceList.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optPriceList.Name = "optPriceList"
        Me.optPriceList.Size = New System.Drawing.Size(180, 25)
        Me.optPriceList.Text = "Price List"
        Me.optPriceList.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'optInventorySummaryReport
        '
        Me.optInventorySummaryReport.AutoSize = False
        Me.optInventorySummaryReport.CheckOnClick = True
        Me.optInventorySummaryReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optInventorySummaryReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optInventorySummaryReport.Name = "optInventorySummaryReport"
        Me.optInventorySummaryReport.Size = New System.Drawing.Size(220, 25)
        Me.optInventorySummaryReport.Text = "Inventory && Sales Summary Report"
        Me.optInventorySummaryReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        'optBookingReport
        '
        Me.optBookingReport.AutoSize = False
        Me.optBookingReport.Checked = True
        Me.optBookingReport.CheckOnClick = True
        Me.optBookingReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optBookingReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optBookingReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optBookingReport.Name = "optBookingReport"
        Me.optBookingReport.Size = New System.Drawing.Size(180, 25)
        Me.optBookingReport.Text = "Booking Report"
        Me.optBookingReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'optPriceChangeReport
        '
        Me.optPriceChangeReport.AutoSize = False
        Me.optPriceChangeReport.Checked = True
        Me.optPriceChangeReport.CheckOnClick = True
        Me.optPriceChangeReport.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optPriceChangeReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optPriceChangeReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optPriceChangeReport.Name = "optPriceChangeReport"
        Me.optPriceChangeReport.Size = New System.Drawing.Size(180, 25)
        Me.optPriceChangeReport.Text = "Price Change Report"
        Me.optPriceChangeReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'cmdOk
        '
        Me.cmdOk.Image = Global.General_Ledger.My.Resources.Resources.folder_ok
        Me.cmdOk.Location = New System.Drawing.Point(636, 321)
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
        Me.cmdExit.Location = New System.Drawing.Point(690, 321)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 54)
        Me.cmdExit.TabIndex = 18
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtDateTo)
        Me.GroupBox2.Controls.Add(Me.txtDateFrom)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(217, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(524, 77)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Booking Date"
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
        Me.cmdPrint.Location = New System.Drawing.Point(585, 320)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(49, 56)
        Me.cmdPrint.TabIndex = 249
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'frmInventoryReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(750, 386)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmInventoryReport"
        Me.Text = "Inventory Report"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
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
    Friend WithEvents cmbBlock As C1.Win.C1List.C1Combo
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmbReportType As System.Windows.Forms.ComboBox
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optPriceList As System.Windows.Forms.ToolStripButton
    Friend WithEvents optInventorySummaryReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optBookingReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optPriceChangeReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
End Class
