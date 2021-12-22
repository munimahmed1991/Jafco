<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStandardPaymentPlan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmStandardPaymentPlan))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmdScheme = New System.Windows.Forms.Button
        Me.cmbScheme = New C1.Win.C1List.C1Combo
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdUnitType = New System.Windows.Forms.Button
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbName = New C1.Win.C1List.C1Combo
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.chkNotDecided = New System.Windows.Forms.CheckBox
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.txtDueDays = New C1.Win.C1Input.C1NumericEdit
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtInstallments = New C1.Win.C1Input.C1NumericEdit
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtAmount = New C1.Win.C1Input.C1NumericEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbPaymentType = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.tdbGridPaymentPlan = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.tdbPaymentType = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbScheme, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDueDays, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInstallments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbGridPaymentPlan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(105, 87)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(801, 64)
        Me.ToolStrip1.TabIndex = 112
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(407, 61)
        Me.ToolStripLabel1.Text = "STANDARD PAYMENT PLAN"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmdScheme)
        Me.GroupBox2.Controls.Add(Me.cmbScheme)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmdUnitType)
        Me.GroupBox2.Controls.Add(Me.cmbUnitType)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cmbProject)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbName)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(797, 146)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'cmdScheme
        '
        Me.cmdScheme.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdScheme.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdScheme.Location = New System.Drawing.Point(381, 119)
        Me.cmdScheme.Name = "cmdScheme"
        Me.cmdScheme.Size = New System.Drawing.Size(22, 21)
        Me.cmdScheme.TabIndex = 239
        Me.cmdScheme.UseVisualStyleBackColor = True
        '
        'cmbScheme
        '
        Me.cmbScheme.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbScheme.Caption = ""
        Me.cmbScheme.CaptionHeight = 17
        Me.cmbScheme.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbScheme.ColumnCaptionHeight = 17
        Me.cmbScheme.ColumnFooterHeight = 17
        Me.cmbScheme.ContentHeight = 15
        Me.cmbScheme.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbScheme.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbScheme.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbScheme.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbScheme.EditorHeight = 15
        Me.cmbScheme.Images.Add(CType(resources.GetObject("cmbScheme.Images"), System.Drawing.Image))
        Me.cmbScheme.ItemHeight = 15
        Me.cmbScheme.Location = New System.Drawing.Point(103, 119)
        Me.cmbScheme.MatchEntryTimeout = CType(2000, Long)
        Me.cmbScheme.MaxDropDownItems = CType(5, Short)
        Me.cmbScheme.MaxLength = 32767
        Me.cmbScheme.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbScheme.Name = "cmbScheme"
        Me.cmbScheme.ReadOnly = True
        Me.cmbScheme.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbScheme.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbScheme.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbScheme.Size = New System.Drawing.Size(278, 21)
        Me.cmbScheme.TabIndex = 237
        Me.cmbScheme.PropBag = resources.GetString("cmbScheme.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 123)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(46, 13)
        Me.Label8.TabIndex = 238
        Me.Label8.Text = "Scheme"
        '
        'cmdUnitType
        '
        Me.cmdUnitType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitType.Location = New System.Drawing.Point(381, 95)
        Me.cmdUnitType.Name = "cmdUnitType"
        Me.cmdUnitType.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnitType.TabIndex = 236
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
        Me.cmbUnitType.Images.Add(CType(resources.GetObject("cmbUnitType.Images"), System.Drawing.Image))
        Me.cmbUnitType.ItemHeight = 15
        Me.cmbUnitType.Location = New System.Drawing.Point(103, 95)
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
        Me.cmbUnitType.TabIndex = 234
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(11, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 235
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
        Me.cmbProject.Location = New System.Drawing.Point(103, 67)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 232
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 233
        Me.Label2.Text = "Project"
        '
        'cmbName
        '
        Me.cmbName.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbName.Caption = ""
        Me.cmbName.CaptionHeight = 17
        Me.cmbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbName.ColumnCaptionHeight = 17
        Me.cmbName.ColumnFooterHeight = 17
        Me.cmbName.ContentHeight = 15
        Me.cmbName.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbName.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbName.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.EditorHeight = 15
        Me.cmbName.Images.Add(CType(resources.GetObject("cmbName.Images"), System.Drawing.Image))
        Me.cmbName.ItemHeight = 15
        Me.cmbName.Location = New System.Drawing.Point(103, 40)
        Me.cmbName.MatchEntryTimeout = CType(2000, Long)
        Me.cmbName.MaxDropDownItems = CType(5, Short)
        Me.cmbName.MaxLength = 32767
        Me.cmbName.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbName.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbName.Size = New System.Drawing.Size(278, 21)
        Me.cmbName.TabIndex = 135
        Me.cmbName.PropBag = resources.GetString("cmbName.PropBag")
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(491, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 56)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(749, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 56)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(698, 4)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(51, 56)
        Me.cmdUndo.TabIndex = 5
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(439, 4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(543, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(51, 56)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(595, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(646, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.chkNotDecided)
        Me.GroupBox1.Controls.Add(Me.cmdGenerate)
        Me.GroupBox1.Controls.Add(Me.txtDueDays)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtInstallments)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtAmount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbPaymentType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(3, 220)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(797, 44)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Payment Generation (from Date of Reservation)"
        '
        'chkNotDecided
        '
        Me.chkNotDecided.AutoSize = True
        Me.chkNotDecided.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotDecided.Location = New System.Drawing.Point(645, 20)
        Me.chkNotDecided.Name = "chkNotDecided"
        Me.chkNotDecided.Size = New System.Drawing.Size(86, 17)
        Me.chkNotDecided.TabIndex = 144
        Me.chkNotDecided.Text = "Not Decided"
        Me.chkNotDecided.UseVisualStyleBackColor = True
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdGenerate.Location = New System.Drawing.Point(732, 16)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(60, 23)
        Me.cmdGenerate.TabIndex = 143
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'txtDueDays
        '
        Me.txtDueDays.AutoSize = False
        Me.txtDueDays.BackColor = System.Drawing.Color.White
        Me.txtDueDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDueDays.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtDueDays.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtDueDays.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDueDays.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDays.Location = New System.Drawing.Point(591, 18)
        Me.txtDueDays.Name = "txtDueDays"
        Me.txtDueDays.Size = New System.Drawing.Size(47, 20)
        Me.txtDueDays.TabIndex = 142
        Me.txtDueDays.Tag = Nothing
        Me.txtDueDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDueDays.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDueDays.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtDueDays.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtDueDays.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(524, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 13)
        Me.Label7.TabIndex = 141
        Me.Label7.Text = "Due in Days"
        '
        'txtInstallments
        '
        Me.txtInstallments.AutoSize = False
        Me.txtInstallments.BackColor = System.Drawing.Color.White
        Me.txtInstallments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstallments.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtInstallments.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtInstallments.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtInstallments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallments.Location = New System.Drawing.Point(469, 18)
        Me.txtInstallments.Name = "txtInstallments"
        Me.txtInstallments.Size = New System.Drawing.Size(52, 20)
        Me.txtInstallments.TabIndex = 140
        Me.txtInstallments.Tag = Nothing
        Me.txtInstallments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtInstallments.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtInstallments.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtInstallments.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtInstallments.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(381, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(84, 13)
        Me.Label5.TabIndex = 139
        Me.Label5.Text = "# of Installments"
        '
        'txtAmount
        '
        Me.txtAmount.AutoSize = False
        Me.txtAmount.BackColor = System.Drawing.Color.White
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(303, 18)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(74, 20)
        Me.txtAmount.TabIndex = 138
        Me.txtAmount.Tag = Nothing
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(257, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 13)
        Me.Label4.TabIndex = 137
        Me.Label4.Text = "Amount"
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
        Me.cmbPaymentType.Location = New System.Drawing.Point(82, 18)
        Me.cmbPaymentType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPaymentType.MaxDropDownItems = CType(5, Short)
        Me.cmbPaymentType.MaxLength = 32767
        Me.cmbPaymentType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPaymentType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.Size = New System.Drawing.Size(174, 21)
        Me.cmbPaymentType.TabIndex = 136
        Me.cmbPaymentType.PropBag = resources.GetString("cmbPaymentType.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Payment Type"
        '
        'tdbGridPaymentPlan
        '
        Me.tdbGridPaymentPlan.AllowAddNew = True
        Me.tdbGridPaymentPlan.AllowDelete = True
        Me.tdbGridPaymentPlan.ColumnFooters = True
        Me.tdbGridPaymentPlan.EmptyRows = True
        Me.tdbGridPaymentPlan.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbGridPaymentPlan.Images.Add(CType(resources.GetObject("tdbGridPaymentPlan.Images"), System.Drawing.Image))
        Me.tdbGridPaymentPlan.Images.Add(CType(resources.GetObject("tdbGridPaymentPlan.Images1"), System.Drawing.Image))
        Me.tdbGridPaymentPlan.Images.Add(CType(resources.GetObject("tdbGridPaymentPlan.Images2"), System.Drawing.Image))
        Me.tdbGridPaymentPlan.Location = New System.Drawing.Point(3, 267)
        Me.tdbGridPaymentPlan.Name = "tdbGridPaymentPlan"
        Me.tdbGridPaymentPlan.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbGridPaymentPlan.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbGridPaymentPlan.PreviewInfo.ZoomFactor = 75
        Me.tdbGridPaymentPlan.PrintInfo.PageSettings = CType(resources.GetObject("tdbGridPaymentPlan.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbGridPaymentPlan.RecordSelectors = False
        Me.tdbGridPaymentPlan.Size = New System.Drawing.Size(591, 222)
        Me.tdbGridPaymentPlan.TabIndex = 238
        Me.tdbGridPaymentPlan.Text = "C1TrueDBGrid1"
        Me.tdbGridPaymentPlan.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdbGridPaymentPlan.WrapCellPointer = True
        Me.tdbGridPaymentPlan.PropBag = resources.GetString("tdbGridPaymentPlan.PropBag")
        '
        'tdbPaymentType
        '
        Me.tdbPaymentType.AllowColMove = True
        Me.tdbPaymentType.AllowColSelect = True
        Me.tdbPaymentType.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdbPaymentType.AlternatingRows = False
        Me.tdbPaymentType.CaptionStyle = Style1
        Me.tdbPaymentType.ColumnCaptionHeight = 17
        Me.tdbPaymentType.ColumnFooterHeight = 17
        Me.tdbPaymentType.EvenRowStyle = Style2
        Me.tdbPaymentType.FetchRowStyles = False
        Me.tdbPaymentType.FooterStyle = Style3
        Me.tdbPaymentType.HeadingStyle = Style4
        Me.tdbPaymentType.HighLightRowStyle = Style5
        Me.tdbPaymentType.Images.Add(CType(resources.GetObject("tdbPaymentType.Images"), System.Drawing.Image))
        Me.tdbPaymentType.Location = New System.Drawing.Point(18, 301)
        Me.tdbPaymentType.Name = "tdbPaymentType"
        Me.tdbPaymentType.OddRowStyle = Style6
        Me.tdbPaymentType.RecordSelectorStyle = Style7
        Me.tdbPaymentType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbPaymentType.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbPaymentType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbPaymentType.ScrollTips = False
        Me.tdbPaymentType.Size = New System.Drawing.Size(388, 180)
        Me.tdbPaymentType.Style = Style8
        Me.tdbPaymentType.TabIndex = 239
        Me.tdbPaymentType.TabStop = False
        Me.tdbPaymentType.Text = "C1TrueDBDropdown1"
        Me.tdbPaymentType.ValueTranslate = True
        Me.tdbPaymentType.Visible = False
        Me.tdbPaymentType.PropBag = resources.GetString("tdbPaymentType.PropBag")
        '
        'frmStandardPaymentPlan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(804, 490)
        Me.Controls.Add(Me.tdbPaymentType)
        Me.Controls.Add(Me.tdbGridPaymentPlan)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmStandardPaymentPlan"
        Me.Text = "Standard Payment Plan"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbScheme, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDueDays, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInstallments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbGridPaymentPlan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbName As C1.Win.C1List.C1Combo
    Friend WithEvents cmdUnitType As System.Windows.Forms.Button
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbPaymentType As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents txtDueDays As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtInstallments As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents tdbGridPaymentPlan As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tdbPaymentType As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents chkNotDecided As System.Windows.Forms.CheckBox
    Friend WithEvents cmdScheme As System.Windows.Forms.Button
    Friend WithEvents cmbScheme As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
    'Friend WithEvents CachedReport1 As CrystalDecisions.ReportSource.CachedReport
End Class
