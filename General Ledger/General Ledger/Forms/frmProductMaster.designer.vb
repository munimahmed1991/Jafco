<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmProductMaster
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmProductMaster))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style11 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style12 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style13 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style14 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style15 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style16 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style17 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style18 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style19 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style20 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.tvwProduct = New System.Windows.Forms.TreeView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenChildAccountToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.OpenChildProductToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenProductAtSameLevelToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdUoMList = New System.Windows.Forms.Button()
        Me.cmbGSTCode = New C1.Win.C1List.C1Combo()
        Me.cmbProductAccount = New C1.Win.C1List.C1Combo()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmbLocation = New C1.Win.C1List.C1Combo()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtMaxInv = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMaxInv = New System.Windows.Forms.Label()
        Me.txtMinInv = New C1.Win.C1Input.C1NumericEdit()
        Me.lblMinInv = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.cmbProductType = New System.Windows.Forms.ComboBox()
        Me.txtMinOrder = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbStatus = New System.Windows.Forms.ComboBox()
        Me.cmbUoM = New C1.Win.C1List.C1Combo()
        Me.cmbProductName = New C1.Win.C1List.C1Combo()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProductLevel = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtProductCode = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUndo = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.tdbLocation = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.tdbGridOpening = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.tdbColor = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.cmbGSTCode, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMaxInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinInv, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtMinOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUoM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProductName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.tdbLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbGridOpening, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbColor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tvwProduct
        '
        Me.tvwProduct.BackColor = System.Drawing.Color.AliceBlue
        Me.tvwProduct.ContextMenuStrip = Me.ContextMenuStrip1
        Me.tvwProduct.ImageIndex = 0
        Me.tvwProduct.ImageList = Me.ImageList1
        Me.tvwProduct.Location = New System.Drawing.Point(9, 86)
        Me.tvwProduct.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tvwProduct.Name = "tvwProduct"
        Me.tvwProduct.SelectedImageIndex = 0
        Me.tvwProduct.Size = New System.Drawing.Size(363, 523)
        Me.tvwProduct.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditToolStripMenuItem, Me.OpenChildAccountToolStripMenuItem, Me.OpenChildProductToolStripMenuItem1, Me.OpenProductAtSameLevelToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(288, 100)
        '
        'EditToolStripMenuItem
        '
        Me.EditToolStripMenuItem.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.EditToolStripMenuItem.Name = "EditToolStripMenuItem"
        Me.EditToolStripMenuItem.Size = New System.Drawing.Size(287, 30)
        Me.EditToolStripMenuItem.Text = "Edit"
        '
        'OpenChildAccountToolStripMenuItem
        '
        Me.OpenChildAccountToolStripMenuItem.Name = "OpenChildAccountToolStripMenuItem"
        Me.OpenChildAccountToolStripMenuItem.Size = New System.Drawing.Size(284, 6)
        '
        'OpenChildProductToolStripMenuItem1
        '
        Me.OpenChildProductToolStripMenuItem1.Name = "OpenChildProductToolStripMenuItem1"
        Me.OpenChildProductToolStripMenuItem1.Size = New System.Drawing.Size(287, 30)
        Me.OpenChildProductToolStripMenuItem1.Text = "Open Child Accessory"
        '
        'OpenProductAtSameLevelToolStripMenuItem
        '
        Me.OpenProductAtSameLevelToolStripMenuItem.Name = "OpenProductAtSameLevelToolStripMenuItem"
        Me.OpenProductAtSameLevelToolStripMenuItem.Size = New System.Drawing.Size(287, 30)
        Me.OpenProductAtSameLevelToolStripMenuItem.Text = "Open Accessory at Same Level"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "BOOK01A.ICO")
        Me.ImageList1.Images.SetKeyName(1, "BOOKS02.ICO")
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdUoMList)
        Me.GroupBox4.Controls.Add(Me.cmbGSTCode)
        Me.GroupBox4.Controls.Add(Me.cmbProductAccount)
        Me.GroupBox4.Controls.Add(Me.Label7)
        Me.GroupBox4.Controls.Add(Me.cmbLocation)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Controls.Add(Me.Label4)
        Me.GroupBox4.Controls.Add(Me.txtMaxInv)
        Me.GroupBox4.Controls.Add(Me.lblMaxInv)
        Me.GroupBox4.Controls.Add(Me.txtMinInv)
        Me.GroupBox4.Controls.Add(Me.lblMinInv)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.cmbProductType)
        Me.GroupBox4.Controls.Add(Me.txtMinOrder)
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.cmbStatus)
        Me.GroupBox4.Controls.Add(Me.cmbUoM)
        Me.GroupBox4.Controls.Add(Me.cmbProductName)
        Me.GroupBox4.Controls.Add(Me.Label5)
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.cmbProductLevel)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txtProductCode)
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Location = New System.Drawing.Point(381, 80)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(711, 385)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        '
        'cmdUoMList
        '
        Me.cmdUoMList.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUoMList.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUoMList.Location = New System.Drawing.Point(293, 82)
        Me.cmdUoMList.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdUoMList.Name = "cmdUoMList"
        Me.cmdUoMList.Size = New System.Drawing.Size(29, 28)
        Me.cmdUoMList.TabIndex = 193
        Me.cmdUoMList.UseVisualStyleBackColor = True
        '
        'cmbGSTCode
        '
        Me.cmbGSTCode.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbGSTCode.Caption = ""
        Me.cmbGSTCode.CaptionHeight = 17
        Me.cmbGSTCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbGSTCode.ColumnCaptionHeight = 17
        Me.cmbGSTCode.ColumnFooterHeight = 17
        Me.cmbGSTCode.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbGSTCode.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbGSTCode.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbGSTCode.Images.Add(CType(resources.GetObject("cmbGSTCode.Images"), System.Drawing.Image))
        Me.cmbGSTCode.ItemHeight = 15
        Me.cmbGSTCode.Location = New System.Drawing.Point(129, 281)
        Me.cmbGSTCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbGSTCode.MatchEntryTimeout = CType(2000, Long)
        Me.cmbGSTCode.MaxDropDownItems = CType(5, Short)
        Me.cmbGSTCode.MaxLength = 32767
        Me.cmbGSTCode.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbGSTCode.Name = "cmbGSTCode"
        Me.cmbGSTCode.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbGSTCode.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbGSTCode.Size = New System.Drawing.Size(164, 23)
        Me.cmbGSTCode.TabIndex = 165
        Me.cmbGSTCode.PropBag = resources.GetString("cmbGSTCode.PropBag")
        '
        'cmbProductAccount
        '
        Me.cmbProductAccount.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProductAccount.Caption = ""
        Me.cmbProductAccount.CaptionHeight = 17
        Me.cmbProductAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProductAccount.ColumnCaptionHeight = 17
        Me.cmbProductAccount.ColumnFooterHeight = 17
        Me.cmbProductAccount.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProductAccount.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProductAccount.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProductAccount.Images.Add(CType(resources.GetObject("cmbProductAccount.Images"), System.Drawing.Image))
        Me.cmbProductAccount.ItemHeight = 15
        Me.cmbProductAccount.Location = New System.Drawing.Point(129, 345)
        Me.cmbProductAccount.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbProductAccount.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProductAccount.MaxDropDownItems = CType(5, Short)
        Me.cmbProductAccount.MaxLength = 32767
        Me.cmbProductAccount.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProductAccount.Name = "cmbProductAccount"
        Me.cmbProductAccount.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProductAccount.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProductAccount.Size = New System.Drawing.Size(516, 23)
        Me.cmbProductAccount.TabIndex = 164
        Me.cmbProductAccount.PropBag = resources.GetString("cmbProductAccount.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(9, 350)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(98, 17)
        Me.Label7.TabIndex = 163
        Me.Label7.Text = "Stock Account"
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
        Me.cmbLocation.Location = New System.Drawing.Point(129, 313)
        Me.cmbLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbLocation.MatchEntryTimeout = CType(2000, Long)
        Me.cmbLocation.MaxDropDownItems = CType(5, Short)
        Me.cmbLocation.MaxLength = 32767
        Me.cmbLocation.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbLocation.Name = "cmbLocation"
        Me.cmbLocation.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbLocation.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbLocation.Size = New System.Drawing.Size(516, 23)
        Me.cmbLocation.TabIndex = 162
        Me.cmbLocation.PropBag = resources.GetString("cmbLocation.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 318)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 17)
        Me.Label6.TabIndex = 161
        Me.Label6.Text = "Location"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 286)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 159
        Me.Label4.Text = "GST Code"
        '
        'txtMaxInv
        '
        Me.txtMaxInv.AutoSize = False
        Me.txtMaxInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtMaxInv.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMaxInv.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMaxInv.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMaxInv.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtMaxInv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMaxInv.Location = New System.Drawing.Point(365, 249)
        Me.txtMaxInv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMaxInv.Name = "txtMaxInv"
        Me.txtMaxInv.Size = New System.Drawing.Size(108, 25)
        Me.txtMaxInv.TabIndex = 158
        Me.txtMaxInv.Tag = Nothing
        Me.txtMaxInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMaxInv.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMaxInv.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtMaxInv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtMaxInv.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMaxInv.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblMaxInv
        '
        Me.lblMaxInv.AutoSize = True
        Me.lblMaxInv.Location = New System.Drawing.Point(289, 254)
        Me.lblMaxInv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMaxInv.Name = "lblMaxInv"
        Me.lblMaxInv.Size = New System.Drawing.Size(63, 17)
        Me.lblMaxInv.TabIndex = 157
        Me.lblMaxInv.Text = "Max. Inv."
        '
        'txtMinInv
        '
        Me.txtMinInv.AutoSize = False
        Me.txtMinInv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtMinInv.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMinInv.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMinInv.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMinInv.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtMinInv.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMinInv.Location = New System.Drawing.Point(129, 249)
        Me.txtMinInv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMinInv.Name = "txtMinInv"
        Me.txtMinInv.Size = New System.Drawing.Size(108, 25)
        Me.txtMinInv.TabIndex = 156
        Me.txtMinInv.Tag = Nothing
        Me.txtMinInv.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMinInv.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMinInv.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtMinInv.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtMinInv.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMinInv.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'lblMinInv
        '
        Me.lblMinInv.AutoSize = True
        Me.lblMinInv.Location = New System.Drawing.Point(9, 254)
        Me.lblMinInv.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblMinInv.Name = "lblMinInv"
        Me.lblMinInv.Size = New System.Drawing.Size(60, 17)
        Me.lblMinInv.TabIndex = 155
        Me.lblMinInv.Text = "Min. Inv."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 188)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 17)
        Me.Label12.TabIndex = 151
        Me.Label12.Text = "Type"
        '
        'cmbProductType
        '
        Me.cmbProductType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductType.FormattingEnabled = True
        Me.cmbProductType.Items.AddRange(New Object() {"Packing Material", "General", "Fixed Asset", "Construction Material", "Accessories", "Store & Spares", "Oil & Lubricants"})
        Me.cmbProductType.Location = New System.Drawing.Point(129, 183)
        Me.cmbProductType.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbProductType.Name = "cmbProductType"
        Me.cmbProductType.Size = New System.Drawing.Size(163, 24)
        Me.cmbProductType.TabIndex = 150
        '
        'txtMinOrder
        '
        Me.txtMinOrder.AutoSize = False
        Me.txtMinOrder.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtMinOrder.Calculator.BackColor = System.Drawing.Color.FromArgb(CType(CType(227, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtMinOrder.Calculator.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMinOrder.Calculator.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMinOrder.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtMinOrder.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtMinOrder.Location = New System.Drawing.Point(129, 217)
        Me.txtMinOrder.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtMinOrder.Name = "txtMinOrder"
        Me.txtMinOrder.Size = New System.Drawing.Size(108, 25)
        Me.txtMinOrder.TabIndex = 149
        Me.txtMinOrder.Tag = Nothing
        Me.txtMinOrder.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtMinOrder.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtMinOrder.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtMinOrder.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtMinOrder.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtMinOrder.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(9, 222)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(71, 17)
        Me.Label11.TabIndex = 148
        Me.Label11.Text = "Min Order"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 155)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(48, 17)
        Me.Label10.TabIndex = 147
        Me.Label10.Text = "Status"
        '
        'cmbStatus
        '
        Me.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbStatus.FormattingEnabled = True
        Me.cmbStatus.Items.AddRange(New Object() {"Active", "Dead"})
        Me.cmbStatus.Location = New System.Drawing.Point(129, 150)
        Me.cmbStatus.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbStatus.Name = "cmbStatus"
        Me.cmbStatus.Size = New System.Drawing.Size(163, 24)
        Me.cmbStatus.TabIndex = 146
        '
        'cmbUoM
        '
        Me.cmbUoM.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUoM.Caption = ""
        Me.cmbUoM.CaptionHeight = 17
        Me.cmbUoM.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUoM.ColumnCaptionHeight = 17
        Me.cmbUoM.ColumnFooterHeight = 17
        Me.cmbUoM.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUoM.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUoM.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUoM.Images.Add(CType(resources.GetObject("cmbUoM.Images"), System.Drawing.Image))
        Me.cmbUoM.ItemHeight = 15
        Me.cmbUoM.Location = New System.Drawing.Point(129, 84)
        Me.cmbUoM.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbUoM.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUoM.MaxDropDownItems = CType(5, Short)
        Me.cmbUoM.MaxLength = 32767
        Me.cmbUoM.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUoM.Name = "cmbUoM"
        Me.cmbUoM.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUoM.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUoM.Size = New System.Drawing.Size(164, 23)
        Me.cmbUoM.TabIndex = 138
        Me.cmbUoM.PropBag = resources.GetString("cmbUoM.PropBag")
        '
        'cmbProductName
        '
        Me.cmbProductName.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProductName.Caption = ""
        Me.cmbProductName.CaptionHeight = 17
        Me.cmbProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProductName.ColumnCaptionHeight = 17
        Me.cmbProductName.ColumnFooterHeight = 17
        Me.cmbProductName.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProductName.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProductName.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProductName.Images.Add(CType(resources.GetObject("cmbProductName.Images"), System.Drawing.Image))
        Me.cmbProductName.ItemHeight = 15
        Me.cmbProductName.Location = New System.Drawing.Point(129, 50)
        Me.cmbProductName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbProductName.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProductName.MaxDropDownItems = CType(5, Short)
        Me.cmbProductName.MaxLength = 32767
        Me.cmbProductName.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProductName.Name = "cmbProductName"
        Me.cmbProductName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProductName.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProductName.Size = New System.Drawing.Size(516, 23)
        Me.cmbProductName.TabIndex = 137
        Me.cmbProductName.PropBag = resources.GetString("cmbProductName.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 89)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(37, 17)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "UoM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 122)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(95, 17)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Product Level"
        '
        'cmbProductLevel
        '
        Me.cmbProductLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbProductLevel.FormattingEnabled = True
        Me.cmbProductLevel.Items.AddRange(New Object() {"Control", "Detail"})
        Me.cmbProductLevel.Location = New System.Drawing.Point(129, 117)
        Me.cmbProductLevel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmbProductLevel.Name = "cmbProductLevel"
        Me.cmbProductLevel.Size = New System.Drawing.Size(163, 24)
        Me.cmbProductLevel.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 55)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 17)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Product Name"
        '
        'txtProductCode
        '
        Me.txtProductCode.BackColor = System.Drawing.Color.AliceBlue
        Me.txtProductCode.Location = New System.Drawing.Point(129, 18)
        Me.txtProductCode.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtProductCode.Name = "txtProductCode"
        Me.txtProductCode.Size = New System.Drawing.Size(132, 22)
        Me.txtProductCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 23)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Product Code"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel2})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, -2)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1092, 86)
        Me.ToolStrip1.TabIndex = 12
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel2.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(386, 83)
        Me.ToolStripLabel2.Text = "Product Master File"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(285, 60)
        Me.ToolStripLabel1.Text = "Chart of Accounts"
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(1027, 1)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(68, 78)
        Me.cmdExit.TabIndex = 19
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(959, 1)
        Me.cmdUndo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(68, 78)
        Me.cmdUndo.TabIndex = 17
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(891, 1)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(68, 78)
        Me.cmdDelete.TabIndex = 16
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(821, 1)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(68, 78)
        Me.cmdSave.TabIndex = 15
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(753, 1)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(68, 78)
        Me.cmdEdit.TabIndex = 14
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(685, 1)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(68, 78)
        Me.cmdSearch.TabIndex = 13
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 60)
        Me.ToolStripButton1.Text = "Edit"
        Me.ToolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        '
        'tdbLocation
        '
        Me.tdbLocation.AllowColMove = True
        Me.tdbLocation.AllowColSelect = True
        Me.tdbLocation.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdbLocation.AlternatingRows = False
        Me.tdbLocation.CaptionStyle = Style1
        Me.tdbLocation.ColumnCaptionHeight = 17
        Me.tdbLocation.ColumnFooterHeight = 17
        Me.tdbLocation.ColumnSelectorStyle = Style2
        Me.tdbLocation.EvenRowStyle = Style3
        Me.tdbLocation.FetchRowStyles = False
        Me.tdbLocation.FooterStyle = Style4
        Me.tdbLocation.HeadingStyle = Style5
        Me.tdbLocation.HighLightRowStyle = Style6
        Me.tdbLocation.Images.Add(CType(resources.GetObject("tdbLocation.Images"), System.Drawing.Image))
        Me.tdbLocation.Location = New System.Drawing.Point(421, 460)
        Me.tdbLocation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tdbLocation.Name = "tdbLocation"
        Me.tdbLocation.OddRowStyle = Style7
        Me.tdbLocation.RecordSelectorStyle = Style8
        Me.tdbLocation.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbLocation.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbLocation.RowSelectorStyle = Style9
        Me.tdbLocation.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbLocation.ScrollTips = False
        Me.tdbLocation.Size = New System.Drawing.Size(517, 163)
        Me.tdbLocation.Style = Style10
        Me.tdbLocation.TabIndex = 236
        Me.tdbLocation.TabStop = False
        Me.tdbLocation.Text = "C1TrueDBDropdown1"
        Me.tdbLocation.UseCompatibleTextRendering = False
        Me.tdbLocation.ValueTranslate = True
        Me.tdbLocation.Visible = False
        Me.tdbLocation.PropBag = resources.GetString("tdbLocation.PropBag")
        '
        'tdbGridOpening
        '
        Me.tdbGridOpening.AllowAddNew = True
        Me.tdbGridOpening.AllowDelete = True
        Me.tdbGridOpening.ColumnFooters = True
        Me.tdbGridOpening.EmptyRows = True
        Me.tdbGridOpening.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbGridOpening.Images.Add(CType(resources.GetObject("tdbGridOpening.Images"), System.Drawing.Image))
        Me.tdbGridOpening.Images.Add(CType(resources.GetObject("tdbGridOpening.Images1"), System.Drawing.Image))
        Me.tdbGridOpening.Images.Add(CType(resources.GetObject("tdbGridOpening.Images2"), System.Drawing.Image))
        Me.tdbGridOpening.Location = New System.Drawing.Point(380, 470)
        Me.tdbGridOpening.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tdbGridOpening.Name = "tdbGridOpening"
        Me.tdbGridOpening.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbGridOpening.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbGridOpening.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbGridOpening.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.tdbGridOpening.PrintInfo.MeasurementPrinterName = Nothing
        Me.tdbGridOpening.PrintInfo.PageSettings = CType(resources.GetObject("tdbGridOpening.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbGridOpening.RecordSelectors = False
        Me.tdbGridOpening.Size = New System.Drawing.Size(710, 142)
        Me.tdbGridOpening.TabIndex = 237
        Me.tdbGridOpening.Text = "C1TrueDBGrid1"
        Me.tdbGridOpening.UseCompatibleTextRendering = False
        Me.tdbGridOpening.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdbGridOpening.WrapCellPointer = True
        Me.tdbGridOpening.PropBag = resources.GetString("tdbGridOpening.PropBag")
        '
        'tdbColor
        '
        Me.tdbColor.AllowColMove = True
        Me.tdbColor.AllowColSelect = True
        Me.tdbColor.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdbColor.AlternatingRows = False
        Me.tdbColor.CaptionStyle = Style11
        Me.tdbColor.ColumnCaptionHeight = 17
        Me.tdbColor.ColumnFooterHeight = 17
        Me.tdbColor.ColumnSelectorStyle = Style12
        Me.tdbColor.EvenRowStyle = Style13
        Me.tdbColor.FetchRowStyles = False
        Me.tdbColor.FooterStyle = Style14
        Me.tdbColor.HeadingStyle = Style15
        Me.tdbColor.HighLightRowStyle = Style16
        Me.tdbColor.Images.Add(CType(resources.GetObject("tdbColor.Images"), System.Drawing.Image))
        Me.tdbColor.Location = New System.Drawing.Point(575, 460)
        Me.tdbColor.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tdbColor.Name = "tdbColor"
        Me.tdbColor.OddRowStyle = Style17
        Me.tdbColor.RecordSelectorStyle = Style18
        Me.tdbColor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbColor.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbColor.RowSelectorStyle = Style19
        Me.tdbColor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbColor.ScrollTips = False
        Me.tdbColor.Size = New System.Drawing.Size(517, 163)
        Me.tdbColor.Style = Style20
        Me.tdbColor.TabIndex = 238
        Me.tdbColor.TabStop = False
        Me.tdbColor.Text = "C1TrueDBDropdown1"
        Me.tdbColor.UseCompatibleTextRendering = False
        Me.tdbColor.ValueTranslate = True
        Me.tdbColor.Visible = False
        Me.tdbColor.PropBag = resources.GetString("tdbColor.PropBag")
        '
        'frmProductMaster
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(1113, 639)
        Me.Controls.Add(Me.tdbColor)
        Me.Controls.Add(Me.tdbLocation)
        Me.Controls.Add(Me.tdbGridOpening)
        Me.Controls.Add(Me.tvwProduct)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.Name = "frmProductMaster"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Product Master File"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.cmbGSTCode, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMaxInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinInv, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtMinOrder, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUoM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProductName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.tdbLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbGridOpening, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbColor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tvwProduct As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbProductLevel As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtProductCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents EditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenChildAccountToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents OpenChildProductToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OpenProductAtSameLevelToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbUoM As C1.Win.C1List.C1Combo
    Friend WithEvents cmbProductName As C1.Win.C1List.C1Combo
    Friend WithEvents tdbLocation As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents tdbGridOpening As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbStatus As System.Windows.Forms.ComboBox
    Friend WithEvents txtMinOrder As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents tdbColor As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents cmbProductType As System.Windows.Forms.ComboBox
    Friend WithEvents txtMaxInv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMaxInv As Label
    Friend WithEvents txtMinInv As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents lblMinInv As Label
    Friend WithEvents cmbLocation As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbProductAccount As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As Label
    Friend WithEvents cmbGSTCode As C1.Win.C1List.C1Combo
    Friend WithEvents cmdUoMList As Button
End Class
