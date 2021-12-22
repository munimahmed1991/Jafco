<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCustomerLedger
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomerLedger))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.cmdOk = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmdCustomerClear = New System.Windows.Forms.Button()
        Me.cmbUnitNoClear = New System.Windows.Forms.Button()
        Me.cmbUnitTypeClear = New System.Windows.Forms.Button()
        Me.cmdCustomer = New System.Windows.Forms.Button()
        Me.cmdUnit = New System.Windows.Forms.Button()
        Me.cmbUnit = New C1.Win.C1List.C1Combo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmdUnitType = New System.Windows.Forms.Button()
        Me.cmbUnitType = New C1.Win.C1List.C1Combo()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmbCustomer = New C1.Win.C1List.C1Combo()
        Me.cmbProject = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCustomer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(338, 38)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(61, 18)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date To :"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(13, 38)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 18)
        Me.Label16.TabIndex = 6
        Me.Label16.Text = "Date From :"
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
        Me.txtDateTo.Location = New System.Drawing.Point(408, 35)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(183, 24)
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
        Me.txtDateFrom.Location = New System.Drawing.Point(111, 35)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(162, 24)
        Me.txtDateFrom.TabIndex = 0
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.TrimEnd = False
        Me.txtDateFrom.Value = New Date(2008, 7, 1, 0, 0, 0, 0)
        Me.txtDateFrom.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtDateFrom.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        Me.txtDateFrom.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Silver
        '
        'cmdOk
        '
        Me.cmdOk.ForeColor = System.Drawing.Color.Black
        Me.cmdOk.Image = Global.General_Ledger.My.Resources.Resources.folder_ok
        Me.cmdOk.Location = New System.Drawing.Point(447, 265)
        Me.cmdOk.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdOk.Name = "cmdOk"
        Me.cmdOk.Size = New System.Drawing.Size(68, 66)
        Me.cmdOk.TabIndex = 24
        Me.cmdOk.Text = "&OK"
        Me.cmdOk.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdOk.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.ForeColor = System.Drawing.Color.Black
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(523, 265)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(68, 66)
        Me.cmdExit.TabIndex = 25
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtCC)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.cmdExit)
        Me.GroupBox3.Controls.Add(Me.cmdOk)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.txtDateTo)
        Me.GroupBox3.Controls.Add(Me.txtDateFrom)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.cmdCustomerClear)
        Me.GroupBox3.Controls.Add(Me.cmbUnitNoClear)
        Me.GroupBox3.Controls.Add(Me.cmbUnitTypeClear)
        Me.GroupBox3.Controls.Add(Me.cmdCustomer)
        Me.GroupBox3.Controls.Add(Me.cmdUnit)
        Me.GroupBox3.Controls.Add(Me.cmbUnit)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbStatus)
        Me.GroupBox3.Controls.Add(Me.cmdUnitType)
        Me.GroupBox3.Controls.Add(Me.cmbUnitType)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.cmbCustomer)
        Me.GroupBox3.Controls.Add(Me.cmbProject)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox3.Location = New System.Drawing.Point(12, 14)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox3.Size = New System.Drawing.Size(606, 339)
        Me.GroupBox3.TabIndex = 26
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Report Filters"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Black
        Me.Label24.Location = New System.Drawing.Point(13, 186)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(68, 18)
        Me.Label24.TabIndex = 278
        Me.Label24.Text = "Customer"
        '
        'cmdCustomerClear
        '
        Me.cmdCustomerClear.Location = New System.Drawing.Point(535, 181)
        Me.cmdCustomerClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCustomerClear.Name = "cmdCustomerClear"
        Me.cmdCustomerClear.Size = New System.Drawing.Size(59, 28)
        Me.cmdCustomerClear.TabIndex = 268
        Me.cmdCustomerClear.Text = "Clear"
        Me.cmdCustomerClear.UseVisualStyleBackColor = True
        '
        'cmbUnitNoClear
        '
        Me.cmbUnitNoClear.Location = New System.Drawing.Point(535, 144)
        Me.cmbUnitNoClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnitNoClear.Name = "cmbUnitNoClear"
        Me.cmbUnitNoClear.Size = New System.Drawing.Size(59, 28)
        Me.cmbUnitNoClear.TabIndex = 268
        Me.cmbUnitNoClear.Text = "Clear"
        Me.cmbUnitNoClear.UseVisualStyleBackColor = True
        '
        'cmbUnitTypeClear
        '
        Me.cmbUnitTypeClear.Location = New System.Drawing.Point(535, 107)
        Me.cmbUnitTypeClear.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnitTypeClear.Name = "cmbUnitTypeClear"
        Me.cmbUnitTypeClear.Size = New System.Drawing.Size(59, 28)
        Me.cmbUnitTypeClear.TabIndex = 267
        Me.cmbUnitTypeClear.Text = "Clear"
        Me.cmbUnitTypeClear.UseVisualStyleBackColor = True
        '
        'cmdCustomer
        '
        Me.cmdCustomer.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdCustomer.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdCustomer.Location = New System.Drawing.Point(505, 182)
        Me.cmdCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdCustomer.Name = "cmdCustomer"
        Me.cmdCustomer.Size = New System.Drawing.Size(29, 26)
        Me.cmdCustomer.TabIndex = 266
        Me.cmdCustomer.UseVisualStyleBackColor = True
        '
        'cmdUnit
        '
        Me.cmdUnit.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnit.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnit.Location = New System.Drawing.Point(505, 145)
        Me.cmdUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdUnit.Name = "cmdUnit"
        Me.cmdUnit.Size = New System.Drawing.Size(29, 26)
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
        Me.cmbUnit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.Images.Add(CType(resources.GetObject("cmbUnit.Images"), System.Drawing.Image))
        Me.cmbUnit.ItemHeight = 15
        Me.cmbUnit.Location = New System.Drawing.Point(111, 146)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnit.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnit.MaxDropDownItems = CType(5, Short)
        Me.cmbUnit.MaxLength = 32767
        Me.cmbUnit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.ReadOnly = True
        Me.cmbUnit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnit.Size = New System.Drawing.Size(391, 24)
        Me.cmbUnit.TabIndex = 264
        Me.cmbUnit.PropBag = resources.GetString("cmbUnit.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(13, 149)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(45, 18)
        Me.Label21.TabIndex = 265
        Me.Label21.Text = "Unit #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(13, 260)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 18)
        Me.Label2.TabIndex = 263
        Me.Label2.Text = "Report Type"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"General Ledger", "Consolidated"})
        Me.cmbStatus.Location = New System.Drawing.Point(111, 257)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(162, 25)
        Me.cmbStatus.TabIndex = 260
        '
        'cmdUnitType
        '
        Me.cmdUnitType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitType.Location = New System.Drawing.Point(505, 108)
        Me.cmdUnitType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdUnitType.Name = "cmdUnitType"
        Me.cmdUnitType.Size = New System.Drawing.Size(29, 26)
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
        Me.cmbUnitType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnitType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnitType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitType.Images.Add(CType(resources.GetObject("cmbUnitType.Images"), System.Drawing.Image))
        Me.cmbUnitType.ItemHeight = 15
        Me.cmbUnitType.Location = New System.Drawing.Point(111, 109)
        Me.cmbUnitType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnitType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnitType.MaxDropDownItems = CType(5, Short)
        Me.cmbUnitType.MaxLength = 32767
        Me.cmbUnitType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnitType.Name = "cmbUnitType"
        Me.cmbUnitType.ReadOnly = True
        Me.cmbUnitType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnitType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnitType.Size = New System.Drawing.Size(391, 24)
        Me.cmbUnitType.TabIndex = 255
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(13, 112)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 18)
        Me.Label27.TabIndex = 256
        Me.Label27.Text = "Unit Type"
        '
        'cmbCustomer
        '
        Me.cmbCustomer.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCustomer.Caption = ""
        Me.cmbCustomer.CaptionHeight = 17
        Me.cmbCustomer.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCustomer.ColumnCaptionHeight = 17
        Me.cmbCustomer.ColumnFooterHeight = 17
        Me.cmbCustomer.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCustomer.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCustomer.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCustomer.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCustomer.Images.Add(CType(resources.GetObject("cmbCustomer.Images"), System.Drawing.Image))
        Me.cmbCustomer.ItemHeight = 15
        Me.cmbCustomer.Location = New System.Drawing.Point(111, 183)
        Me.cmbCustomer.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCustomer.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCustomer.MaxDropDownItems = CType(5, Short)
        Me.cmbCustomer.MaxLength = 32767
        Me.cmbCustomer.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCustomer.Name = "cmbCustomer"
        Me.cmbCustomer.ReadOnly = True
        Me.cmbCustomer.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCustomer.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCustomer.Size = New System.Drawing.Size(391, 24)
        Me.cmbCustomer.TabIndex = 241
        Me.cmbCustomer.PropBag = resources.GetString("cmbCustomer.PropBag")
        '
        'cmbProject
        '
        Me.cmbProject.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProject.Caption = ""
        Me.cmbProject.CaptionHeight = 17
        Me.cmbProject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProject.ColumnCaptionHeight = 17
        Me.cmbProject.ColumnFooterHeight = 17
        Me.cmbProject.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProject.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProject.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProject.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProject.Images.Add(CType(resources.GetObject("cmbProject.Images"), System.Drawing.Image))
        Me.cmbProject.ItemHeight = 15
        Me.cmbProject.Location = New System.Drawing.Point(111, 72)
        Me.cmbProject.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(480, 24)
        Me.cmbProject.TabIndex = 241
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(13, 75)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 18)
        Me.Label8.TabIndex = 242
        Me.Label8.Text = "Project"
        '
        'txtCC
        '
        Me.txtCC.BackColor = System.Drawing.Color.White
        Me.txtCC.Location = New System.Drawing.Point(111, 221)
        Me.txtCC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(162, 22)
        Me.txtCC.TabIndex = 279
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(13, 223)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(24, 18)
        Me.Label1.TabIndex = 280
        Me.Label1.Text = "CC"
        '
        'frmCustomerLedger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(635, 361)
        Me.Controls.Add(Me.GroupBox3)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmCustomerLedger"
        Me.Text = "Customer Ledger"
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCustomer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdOk As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label24 As Label
    Friend WithEvents cmbUnitNoClear As Button
    Friend WithEvents cmbUnitTypeClear As Button
    Friend WithEvents cmdUnit As Button
    Friend WithEvents cmbUnit As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmbStatus As ComboBox
    Friend WithEvents cmdUnitType As Button
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As Label
    Friend WithEvents cmbCustomer As C1.Win.C1List.C1Combo
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As Label
    Friend WithEvents cmdCustomerClear As Button
    Friend WithEvents cmdCustomer As Button
    Friend WithEvents txtCC As TextBox
    Friend WithEvents Label1 As Label
End Class
