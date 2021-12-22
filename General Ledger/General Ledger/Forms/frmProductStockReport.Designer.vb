<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductStockReport
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductStockReport))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.optProductLedger = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.optAccessoryValuationReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.optActivityReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.optGridValuationReport = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbItemFilter = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmbActiveDead = New System.Windows.Forms.ComboBox()
        Me.cmbReportFilter = New System.Windows.Forms.ComboBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmbProductLevel = New System.Windows.Forms.ComboBox()
        Me.cmbLocation = New C1.Win.C1List.C1Combo()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmbGroupProduct = New C1.Win.C1List.C1Combo()
        Me.cmdAccessorySelectionTo = New System.Windows.Forms.Button()
        Me.cmbProductTo = New C1.Win.C1List.C1Combo()
        Me.cmdProductFrom = New System.Windows.Forms.Button()
        Me.cmbProductFrom = New C1.Win.C1List.C1Combo()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbGroupProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator2, Me.optProductLedger, Me.ToolStripSeparator4, Me.optAccessoryValuationReport, Me.ToolStripSeparator6, Me.optActivityReport, Me.ToolStripSeparator1, Me.optGridValuationReport, Me.ToolStripButton2})
        Me.ToolStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.VerticalStackWithOverflow
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(214, 482)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(180, 6)
        '
        'optProductLedger
        '
        Me.optProductLedger.AutoSize = False
        Me.optProductLedger.Checked = True
        Me.optProductLedger.CheckOnClick = True
        Me.optProductLedger.CheckState = System.Windows.Forms.CheckState.Checked
        Me.optProductLedger.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optProductLedger.Image = CType(resources.GetObject("optProductLedger.Image"), System.Drawing.Image)
        Me.optProductLedger.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optProductLedger.Name = "optProductLedger"
        Me.optProductLedger.Size = New System.Drawing.Size(180, 25)
        Me.optProductLedger.Text = "Product Ledger"
        Me.optProductLedger.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(180, 6)
        '
        'optAccessoryValuationReport
        '
        Me.optAccessoryValuationReport.AutoSize = False
        Me.optAccessoryValuationReport.CheckOnClick = True
        Me.optAccessoryValuationReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optAccessoryValuationReport.Image = CType(resources.GetObject("optAccessoryValuationReport.Image"), System.Drawing.Image)
        Me.optAccessoryValuationReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optAccessoryValuationReport.Name = "optAccessoryValuationReport"
        Me.optAccessoryValuationReport.Size = New System.Drawing.Size(180, 25)
        Me.optAccessoryValuationReport.Text = "Product Valuation Report"
        Me.optAccessoryValuationReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(180, 6)
        '
        'optActivityReport
        '
        Me.optActivityReport.AutoSize = False
        Me.optActivityReport.CheckOnClick = True
        Me.optActivityReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optActivityReport.Image = CType(resources.GetObject("optActivityReport.Image"), System.Drawing.Image)
        Me.optActivityReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optActivityReport.Name = "optActivityReport"
        Me.optActivityReport.Size = New System.Drawing.Size(180, 25)
        Me.optActivityReport.Text = "Activity Report"
        Me.optActivityReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(180, 6)
        '
        'optGridValuationReport
        '
        Me.optGridValuationReport.AutoSize = False
        Me.optGridValuationReport.CheckOnClick = True
        Me.optGridValuationReport.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.optGridValuationReport.Image = CType(resources.GetObject("optGridValuationReport.Image"), System.Drawing.Image)
        Me.optGridValuationReport.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.optGridValuationReport.Name = "optGridValuationReport"
        Me.optGridValuationReport.Size = New System.Drawing.Size(180, 25)
        Me.optGridValuationReport.Text = "Dynamic Valuation Report"
        Me.optGridValuationReport.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.AutoSize = False
        Me.ToolStripButton2.CheckOnClick = True
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(180, 25)
        Me.ToolStripButton2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtDateTo)
        Me.GroupBox1.Controls.Add(Me.txtDateFrom)
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(217, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(475, 77)
        Me.GroupBox1.TabIndex = 18
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Date"
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
        Me.txtDateTo.AllowSpinLoop = False
        Me.txtDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateTo.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtDateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.txtDateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.txtDateTo.Culture = 1056
        Me.txtDateTo.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateTo.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.ImagePadding = New System.Windows.Forms.Padding(0)
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
        Me.txtDateFrom.AllowSpinLoop = False
        Me.txtDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateFrom.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtDateFrom.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.txtDateFrom.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.txtDateFrom.Culture = 1056
        Me.txtDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateFrom.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.ImagePadding = New System.Windows.Forms.Padding(0)
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
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbItemFilter)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtPrefix)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmbActiveDead)
        Me.GroupBox2.Controls.Add(Me.cmbReportFilter)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.cmbProductLevel)
        Me.GroupBox2.Controls.Add(Me.cmbLocation)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.cmbGroupProduct)
        Me.GroupBox2.Controls.Add(Me.cmdAccessorySelectionTo)
        Me.GroupBox2.Controls.Add(Me.cmbProductTo)
        Me.GroupBox2.Controls.Add(Me.cmdProductFrom)
        Me.GroupBox2.Controls.Add(Me.cmbProductFrom)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(217, 81)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(475, 335)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Selections Criteria"
        '
        'cmbItemFilter
        '
        Me.cmbItemFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbItemFilter.FormattingEnabled = True
        Me.cmbItemFilter.Items.AddRange(New Object() {"Packing Material", "General", "Fixed Asset", "Construction Material", "Accessories", "Store & Spares", "Oil & Lubricants", "All"})
        Me.cmbItemFilter.Location = New System.Drawing.Point(269, 308)
        Me.cmbItemFilter.Name = "cmbItemFilter"
        Me.cmbItemFilter.Size = New System.Drawing.Size(176, 21)
        Me.cmbItemFilter.TabIndex = 246
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(269, 287)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(83, 13)
        Me.Label3.TabIndex = 245
        Me.Label3.Text = "Product Type"
        '
        'txtPrefix
        '
        Me.txtPrefix.Location = New System.Drawing.Point(13, 307)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.Size = New System.Drawing.Size(105, 20)
        Me.txtPrefix.TabIndex = 244
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(11, 287)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(39, 13)
        Me.Label21.TabIndex = 243
        Me.Label21.Text = "Prefix"
        '
        'cmbActiveDead
        '
        Me.cmbActiveDead.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbActiveDead.FormattingEnabled = True
        Me.cmbActiveDead.Items.AddRange(New Object() {"Active", "Dead", "Both"})
        Me.cmbActiveDead.Location = New System.Drawing.Point(269, 251)
        Me.cmbActiveDead.Name = "cmbActiveDead"
        Me.cmbActiveDead.Size = New System.Drawing.Size(176, 21)
        Me.cmbActiveDead.TabIndex = 215
        '
        'cmbReportFilter
        '
        Me.cmbReportFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbReportFilter.FormattingEnabled = True
        Me.cmbReportFilter.Items.AddRange(New Object() {"Only Zero Balance", "Without Zero Balance", "With Zero Balance"})
        Me.cmbReportFilter.Location = New System.Drawing.Point(13, 251)
        Me.cmbReportFilter.Name = "cmbReportFilter"
        Me.cmbReportFilter.Size = New System.Drawing.Size(176, 21)
        Me.cmbReportFilter.TabIndex = 214
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(266, 117)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(86, 13)
        Me.Label24.TabIndex = 213
        Me.Label24.Text = "Product Level"
        '
        'cmbProductLevel
        '
        Me.cmbProductLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductLevel.FormattingEnabled = True
        Me.cmbProductLevel.Items.AddRange(New Object() {"Level 1", "Level 2", "Level 3", "Level 4", "Level 5", "Level 6", "Level 7"})
        Me.cmbProductLevel.Location = New System.Drawing.Point(269, 137)
        Me.cmbProductLevel.Name = "cmbProductLevel"
        Me.cmbProductLevel.Size = New System.Drawing.Size(176, 21)
        Me.cmbProductLevel.TabIndex = 212
        '
        'cmbLocation
        '
        Me.cmbLocation.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbLocation.Caption = ""
        Me.cmbLocation.CaptionHeight = 17
        Me.cmbLocation.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbLocation.ColumnCaptionHeight = 17
        Me.cmbLocation.ColumnFooterHeight = 17
        Me.cmbLocation.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbLocation.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbLocation.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLocation.Images.Add(CType(resources.GetObject("cmbLocation.Images"), System.Drawing.Image))
        Me.cmbLocation.ItemHeight = 15
        Me.cmbLocation.Location = New System.Drawing.Point(13, 193)
        Me.cmbLocation.MatchEntryTimeout = CType(2000, Long)
        Me.cmbLocation.MaxDropDownItems = CType(5, Short)
        Me.cmbLocation.MaxLength = 32767
        Me.cmbLocation.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbLocation.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbLocation.Size = New System.Drawing.Size(219, 21)
        Me.cmbLocation.TabIndex = 211
        Me.cmbLocation.PropBag = resources.GetString("cmbLocation.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 170)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 13)
        Me.Label2.TabIndex = 210
        Me.Label2.Text = "Location"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(269, 230)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 208
        Me.Label1.Text = "Active / Dead"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Black
        Me.Label22.Location = New System.Drawing.Point(13, 230)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(77, 13)
        Me.Label22.TabIndex = 206
        Me.Label22.Text = "Report Filter"
        '
        'cmbGroupProduct
        '
        Me.cmbGroupProduct.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGroupProduct.Caption = ""
        Me.cmbGroupProduct.CaptionHeight = 17
        Me.cmbGroupProduct.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGroupProduct.ColumnCaptionHeight = 17
        Me.cmbGroupProduct.ColumnFooterHeight = 17
        Me.cmbGroupProduct.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGroupProduct.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGroupProduct.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGroupProduct.Images.Add(CType(resources.GetObject("cmbGroupProduct.Images"), System.Drawing.Image))
        Me.cmbGroupProduct.ItemHeight = 15
        Me.cmbGroupProduct.Location = New System.Drawing.Point(13, 137)
        Me.cmbGroupProduct.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGroupProduct.MaxDropDownItems = CType(5, Short)
        Me.cmbGroupProduct.MaxLength = 32767
        Me.cmbGroupProduct.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGroupProduct.Name = "cmbGroupProduct"
        Me.cmbGroupProduct.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGroupProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGroupProduct.Size = New System.Drawing.Size(219, 21)
        Me.cmbGroupProduct.TabIndex = 201
        Me.cmbGroupProduct.PropBag = resources.GetString("cmbGroupProduct.PropBag")
        '
        'cmdAccessorySelectionTo
        '
        Me.cmdAccessorySelectionTo.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdAccessorySelectionTo.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdAccessorySelectionTo.Location = New System.Drawing.Point(419, 73)
        Me.cmdAccessorySelectionTo.Name = "cmdAccessorySelectionTo"
        Me.cmdAccessorySelectionTo.Size = New System.Drawing.Size(22, 23)
        Me.cmdAccessorySelectionTo.TabIndex = 200
        Me.cmdAccessorySelectionTo.UseVisualStyleBackColor = True
        '
        'cmbProductTo
        '
        Me.cmbProductTo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProductTo.Caption = ""
        Me.cmbProductTo.CaptionHeight = 17
        Me.cmbProductTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProductTo.ColumnCaptionHeight = 17
        Me.cmbProductTo.ColumnFooterHeight = 17
        Me.cmbProductTo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProductTo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProductTo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProductTo.Images.Add(CType(resources.GetObject("cmbProductTo.Images"), System.Drawing.Image))
        Me.cmbProductTo.ItemHeight = 15
        Me.cmbProductTo.Location = New System.Drawing.Point(59, 74)
        Me.cmbProductTo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProductTo.MaxDropDownItems = CType(5, Short)
        Me.cmbProductTo.MaxLength = 32767
        Me.cmbProductTo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProductTo.Name = "cmbProductTo"
        Me.cmbProductTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProductTo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProductTo.Size = New System.Drawing.Size(361, 21)
        Me.cmbProductTo.TabIndex = 199
        Me.cmbProductTo.PropBag = resources.GetString("cmbProductTo.PropBag")
        '
        'cmdProductFrom
        '
        Me.cmdProductFrom.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdProductFrom.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdProductFrom.Location = New System.Drawing.Point(419, 49)
        Me.cmdProductFrom.Name = "cmdProductFrom"
        Me.cmdProductFrom.Size = New System.Drawing.Size(22, 22)
        Me.cmdProductFrom.TabIndex = 198
        Me.cmdProductFrom.UseVisualStyleBackColor = True
        '
        'cmbProductFrom
        '
        Me.cmbProductFrom.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProductFrom.Caption = ""
        Me.cmbProductFrom.CaptionHeight = 17
        Me.cmbProductFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProductFrom.ColumnCaptionHeight = 17
        Me.cmbProductFrom.ColumnFooterHeight = 17
        Me.cmbProductFrom.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProductFrom.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProductFrom.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProductFrom.Images.Add(CType(resources.GetObject("cmbProductFrom.Images"), System.Drawing.Image))
        Me.cmbProductFrom.ItemHeight = 15
        Me.cmbProductFrom.Location = New System.Drawing.Point(59, 50)
        Me.cmbProductFrom.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProductFrom.MaxDropDownItems = CType(5, Short)
        Me.cmbProductFrom.MaxLength = 32767
        Me.cmbProductFrom.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProductFrom.Name = "cmbProductFrom"
        Me.cmbProductFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProductFrom.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProductFrom.Size = New System.Drawing.Size(361, 21)
        Me.cmbProductFrom.TabIndex = 197
        Me.cmbProductFrom.PropBag = resources.GetString("cmbProductFrom.PropBag")
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(13, 114)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(89, 13)
        Me.Label19.TabIndex = 12
        Me.Label19.Text = "Product Group"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(13, 78)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(36, 13)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Upto :"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(13, 54)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(36, 13)
        Me.Label17.TabIndex = 10
        Me.Label17.Text = "From :"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(13, 27)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(108, 13)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Product Selection"
        '
        'cmdOk
        '
        Me.cmdOk.Image = Global.General_Ledger.My.Resources.Resources.folder_ok
        Me.cmdOk.Location = New System.Drawing.Point(587, 422)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(51, 56)
        Me.cmdOk.TabIndex = 20
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(641, 422)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 56)
        Me.cmdExit.TabIndex = 21
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'frmProductStockReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(701, 482)
        Me.Controls.Add(Me.cmdOk)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.MaximizeBox = False
        Me.Name = "frmProductStockReport"
        Me.Text = "frmAccessoryStockReport"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbGroupProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optProductLedger As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents optAccessoryValuationReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator6 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmbGroupProduct As C1.Win.C1List.C1Combo
    Friend WithEvents cmdAccessorySelectionTo As System.Windows.Forms.Button
    Friend WithEvents cmbProductTo As C1.Win.C1List.C1Combo
    Friend WithEvents cmdProductFrom As System.Windows.Forms.Button
    Friend WithEvents cmbProductFrom As C1.Win.C1List.C1Combo
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents optGridValuationReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents cmbLocation As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbActiveDead As System.Windows.Forms.ComboBox
    Friend WithEvents cmbReportFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmbProductLevel As System.Windows.Forms.ComboBox
    Friend WithEvents optActivityReport As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbItemFilter As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
