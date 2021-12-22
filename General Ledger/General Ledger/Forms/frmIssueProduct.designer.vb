<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmIssueProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIssueProduct))
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmbBlock = New C1.Win.C1List.C1Combo()
        Me.cmbProject = New C1.Win.C1List.C1Combo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.cmbSector = New C1.Win.C1List.C1Combo()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmbTransactionType = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbLevel = New C1.Win.C1List.C1Combo()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtIssDate = New C1.Win.C1Input.C1DateEdit()
        Me.txtIssNo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUndo = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tdbLocation = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cmdPickAccessories = New System.Windows.Forms.Button()
        Me.tdbProduct = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.tdbGridProductDetail = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmdVoucher = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSector, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTransactionType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLevel, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtIssDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.tdbLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbGridProductDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbBlock)
        Me.GroupBox1.Controls.Add(Me.cmbProject)
        Me.GroupBox1.Controls.Add(Me.Label21)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.cmbSector)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.cmbTransactionType)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cmbLevel)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtIssDate)
        Me.GroupBox1.Controls.Add(Me.txtIssNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 126)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1009, 188)
        Me.GroupBox1.TabIndex = 177
        Me.GroupBox1.TabStop = False
        '
        'cmbBlock
        '
        Me.cmbBlock.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBlock.Caption = ""
        Me.cmbBlock.CaptionHeight = 17
        Me.cmbBlock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBlock.ColumnCaptionHeight = 17
        Me.cmbBlock.ColumnFooterHeight = 17
        Me.cmbBlock.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBlock.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBlock.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBlock.Images.Add(CType(resources.GetObject("cmbBlock.Images"), System.Drawing.Image))
        Me.cmbBlock.ItemHeight = 15
        Me.cmbBlock.Location = New System.Drawing.Point(98, 121)
        Me.cmbBlock.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbBlock.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBlock.MaxDropDownItems = CType(5, Short)
        Me.cmbBlock.MaxLength = 32767
        Me.cmbBlock.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBlock.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBlock.Size = New System.Drawing.Size(301, 23)
        Me.cmbBlock.TabIndex = 301
        Me.cmbBlock.PropBag = resources.GetString("cmbBlock.PropBag")
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
        Me.cmbProject.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProject.Images.Add(CType(resources.GetObject("cmbProject.Images"), System.Drawing.Image))
        Me.cmbProject.ItemHeight = 15
        Me.cmbProject.Location = New System.Drawing.Point(98, 16)
        Me.cmbProject.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(436, 23)
        Me.cmbProject.TabIndex = 266
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 124)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(42, 17)
        Me.Label21.TabIndex = 302
        Me.Label21.Text = "Block"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(8, 19)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 17)
        Me.Label18.TabIndex = 267
        Me.Label18.Text = "Project"
        '
        'cmbSector
        '
        Me.cmbSector.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSector.Caption = ""
        Me.cmbSector.CaptionHeight = 17
        Me.cmbSector.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSector.ColumnCaptionHeight = 17
        Me.cmbSector.ColumnFooterHeight = 17
        Me.cmbSector.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSector.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSector.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSector.Images.Add(CType(resources.GetObject("cmbSector.Images"), System.Drawing.Image))
        Me.cmbSector.ItemHeight = 15
        Me.cmbSector.Location = New System.Drawing.Point(654, 16)
        Me.cmbSector.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSector.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSector.MaxDropDownItems = CType(5, Short)
        Me.cmbSector.MaxLength = 32767
        Me.cmbSector.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSector.Name = "cmbSector"
        Me.cmbSector.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSector.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSector.Size = New System.Drawing.Size(301, 23)
        Me.cmbSector.TabIndex = 264
        Me.cmbSector.PropBag = resources.GetString("cmbSector.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 89)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 17)
        Me.Label8.TabIndex = 300
        Me.Label8.Text = "Level"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(576, 19)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(49, 17)
        Me.Label15.TabIndex = 265
        Me.Label15.Text = "Sector"
        '
        'cmbTransactionType
        '
        Me.cmbTransactionType.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTransactionType.Caption = ""
        Me.cmbTransactionType.CaptionHeight = 17
        Me.cmbTransactionType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTransactionType.ColumnCaptionHeight = 17
        Me.cmbTransactionType.ColumnFooterHeight = 17
        Me.cmbTransactionType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTransactionType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTransactionType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTransactionType.Images.Add(CType(resources.GetObject("cmbTransactionType.Images"), System.Drawing.Image))
        Me.cmbTransactionType.ItemHeight = 15
        Me.cmbTransactionType.Location = New System.Drawing.Point(654, 86)
        Me.cmbTransactionType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbTransactionType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTransactionType.MaxDropDownItems = CType(5, Short)
        Me.cmbTransactionType.MaxLength = 32767
        Me.cmbTransactionType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTransactionType.Name = "cmbTransactionType"
        Me.cmbTransactionType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTransactionType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTransactionType.Size = New System.Drawing.Size(301, 23)
        Me.cmbTransactionType.TabIndex = 238
        Me.cmbTransactionType.PropBag = resources.GetString("cmbTransactionType.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(576, 89)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 17)
        Me.Label3.TabIndex = 239
        Me.Label3.Text = "Tran. Type"
        '
        'cmbLevel
        '
        Me.cmbLevel.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbLevel.Caption = ""
        Me.cmbLevel.CaptionHeight = 17
        Me.cmbLevel.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbLevel.ColumnCaptionHeight = 17
        Me.cmbLevel.ColumnFooterHeight = 17
        Me.cmbLevel.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbLevel.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbLevel.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLevel.Images.Add(CType(resources.GetObject("cmbLevel.Images"), System.Drawing.Image))
        Me.cmbLevel.ItemHeight = 15
        Me.cmbLevel.Location = New System.Drawing.Point(98, 86)
        Me.cmbLevel.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLevel.MatchEntryTimeout = CType(2000, Long)
        Me.cmbLevel.MaxDropDownItems = CType(5, Short)
        Me.cmbLevel.MaxLength = 32767
        Me.cmbLevel.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbLevel.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbLevel.Size = New System.Drawing.Size(301, 23)
        Me.cmbLevel.TabIndex = 236
        Me.cmbLevel.PropBag = resources.GetString("cmbLevel.PropBag")
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(98, 156)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(857, 22)
        Me.txtDescription.TabIndex = 235
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 159)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 17)
        Me.Label6.TabIndex = 234
        Me.Label6.Text = "Description"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(576, 54)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 17)
        Me.Label2.TabIndex = 193
        Me.Label2.Text = "Iss Date"
        '
        'txtIssDate
        '
        Me.txtIssDate.AllowSpinLoop = False
        Me.txtIssDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtIssDate.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtIssDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtIssDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtIssDate.Culture = 1056
        Me.txtIssDate.CustomFormat = "dd/MM/yyyy"
        Me.txtIssDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtIssDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtIssDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtIssDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtIssDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtIssDate.Location = New System.Drawing.Point(654, 51)
        Me.txtIssDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIssDate.Name = "txtIssDate"
        Me.txtIssDate.Size = New System.Drawing.Size(168, 22)
        Me.txtIssDate.TabIndex = 194
        Me.txtIssDate.Tag = Nothing
        Me.txtIssDate.TrimEnd = False
        Me.txtIssDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtIssDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtIssDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtIssNo
        '
        Me.txtIssNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtIssNo.Location = New System.Drawing.Point(98, 51)
        Me.txtIssNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtIssNo.Name = "txtIssNo"
        Me.txtIssNo.Size = New System.Drawing.Size(171, 22)
        Me.txtIssNo.TabIndex = 178
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 54)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(37, 17)
        Me.Label1.TabIndex = 176
        Me.Label1.Text = "Iss #"
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(618, 4)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(67, 69)
        Me.cmdAdd.TabIndex = 170
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(953, 4)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(67, 69)
        Me.cmdExit.TabIndex = 176
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(886, 4)
        Me.cmdUndo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(67, 69)
        Me.cmdUndo.TabIndex = 175
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(551, 4)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(67, 69)
        Me.cmdSearch.TabIndex = 171
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(685, 4)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(67, 69)
        Me.cmdEdit.TabIndex = 173
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(752, 4)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(67, 69)
        Me.cmdSave.TabIndex = 172
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(819, 4)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(67, 69)
        Me.cmdDelete.TabIndex = 174
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(12, -1)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1011, 74)
        Me.ToolStrip1.TabIndex = 169
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 21.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(240, 71)
        Me.ToolStripLabel1.Text = "Issue Product"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Location = New System.Drawing.Point(16, 319)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1009, 327)
        Me.TabControl1.TabIndex = 178
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tdbLocation)
        Me.TabPage1.Controls.Add(Me.cmdPickAccessories)
        Me.TabPage1.Controls.Add(Me.tdbProduct)
        Me.TabPage1.Controls.Add(Me.tdbGridProductDetail)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1001, 298)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transaction Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tdbLocation
        '
        Me.tdbLocation.AllowColMove = True
        Me.tdbLocation.AllowColSelect = True
        Me.tdbLocation.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdbLocation.AlternatingRows = False
        Me.tdbLocation.CaptionHeight = 19
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
        Me.tdbLocation.Location = New System.Drawing.Point(277, 48)
        Me.tdbLocation.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbLocation.Name = "tdbLocation"
        Me.tdbLocation.OddRowStyle = Style7
        Me.tdbLocation.RecordSelectorStyle = Style8
        Me.tdbLocation.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbLocation.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbLocation.RowHeight = 17
        Me.tdbLocation.RowSelectorStyle = Style9
        Me.tdbLocation.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbLocation.ScrollTips = False
        Me.tdbLocation.Size = New System.Drawing.Size(517, 108)
        Me.tdbLocation.Style = Style10
        Me.tdbLocation.TabIndex = 191
        Me.tdbLocation.TabStop = False
        Me.tdbLocation.Text = "C1TrueDBDropdown1"
        Me.tdbLocation.UseCompatibleTextRendering = False
        Me.tdbLocation.ValueTranslate = True
        Me.tdbLocation.Visible = False
        Me.tdbLocation.PropBag = resources.GetString("tdbLocation.PropBag")
        '
        'cmdPickAccessories
        '
        Me.cmdPickAccessories.Location = New System.Drawing.Point(9, 257)
        Me.cmdPickAccessories.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPickAccessories.Name = "cmdPickAccessories"
        Me.cmdPickAccessories.Size = New System.Drawing.Size(147, 28)
        Me.cmdPickAccessories.TabIndex = 187
        Me.cmdPickAccessories.Text = "Pick Product"
        Me.cmdPickAccessories.UseVisualStyleBackColor = True
        '
        'tdbProduct
        '
        Me.tdbProduct.AllowColMove = True
        Me.tdbProduct.AllowColSelect = True
        Me.tdbProduct.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdbProduct.AlternatingRows = False
        Me.tdbProduct.CaptionHeight = 19
        Me.tdbProduct.CaptionStyle = Style11
        Me.tdbProduct.ColumnCaptionHeight = 17
        Me.tdbProduct.ColumnFooterHeight = 17
        Me.tdbProduct.ColumnSelectorStyle = Style12
        Me.tdbProduct.EvenRowStyle = Style13
        Me.tdbProduct.FetchRowStyles = False
        Me.tdbProduct.FooterStyle = Style14
        Me.tdbProduct.HeadingStyle = Style15
        Me.tdbProduct.HighLightRowStyle = Style16
        Me.tdbProduct.Images.Add(CType(resources.GetObject("tdbProduct.Images"), System.Drawing.Image))
        Me.tdbProduct.Location = New System.Drawing.Point(19, 48)
        Me.tdbProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbProduct.Name = "tdbProduct"
        Me.tdbProduct.OddRowStyle = Style17
        Me.tdbProduct.RecordSelectorStyle = Style18
        Me.tdbProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbProduct.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbProduct.RowHeight = 17
        Me.tdbProduct.RowSelectorStyle = Style19
        Me.tdbProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbProduct.ScrollTips = False
        Me.tdbProduct.Size = New System.Drawing.Size(517, 108)
        Me.tdbProduct.Style = Style20
        Me.tdbProduct.TabIndex = 186
        Me.tdbProduct.TabStop = False
        Me.tdbProduct.Text = "C1TrueDBDropdown1"
        Me.tdbProduct.UseCompatibleTextRendering = False
        Me.tdbProduct.ValueTranslate = True
        Me.tdbProduct.Visible = False
        Me.tdbProduct.PropBag = resources.GetString("tdbProduct.PropBag")
        '
        'tdbGridProductDetail
        '
        Me.tdbGridProductDetail.AllowDelete = True
        Me.tdbGridProductDetail.CaptionHeight = 19
        Me.tdbGridProductDetail.ColumnFooters = True
        Me.tdbGridProductDetail.EmptyRows = True
        Me.tdbGridProductDetail.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbGridProductDetail.Images.Add(CType(resources.GetObject("tdbGridProductDetail.Images"), System.Drawing.Image))
        Me.tdbGridProductDetail.Images.Add(CType(resources.GetObject("tdbGridProductDetail.Images1"), System.Drawing.Image))
        Me.tdbGridProductDetail.Images.Add(CType(resources.GetObject("tdbGridProductDetail.Images2"), System.Drawing.Image))
        Me.tdbGridProductDetail.Location = New System.Drawing.Point(9, 11)
        Me.tdbGridProductDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbGridProductDetail.Name = "tdbGridProductDetail"
        Me.tdbGridProductDetail.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbGridProductDetail.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbGridProductDetail.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbGridProductDetail.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.tdbGridProductDetail.PrintInfo.MeasurementPrinterName = Nothing
        Me.tdbGridProductDetail.PrintInfo.PageSettings = CType(resources.GetObject("tdbGridProductDetail.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbGridProductDetail.RecordSelectors = False
        Me.tdbGridProductDetail.RowHeight = 17
        Me.tdbGridProductDetail.Size = New System.Drawing.Size(982, 241)
        Me.tdbGridProductDetail.TabIndex = 179
        Me.tdbGridProductDetail.Text = "C1TrueDBGrid1"
        Me.tdbGridProductDetail.UseCompatibleTextRendering = False
        Me.tdbGridProductDetail.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdbGridProductDetail.WrapCellPointer = True
        Me.tdbGridProductDetail.PropBag = resources.GetString("tdbGridProductDetail.PropBag")
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.General_Ledger.My.Resources.Resources.folder_document
        Me.cmdPrint.Location = New System.Drawing.Point(484, 4)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(67, 69)
        Me.cmdPrint.TabIndex = 183
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDateTo)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtDateFrom)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(16, 80)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1008, 49)
        Me.GroupBox2.TabIndex = 199
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "Searching Criterea"
        '
        'txtDateTo
        '
        Me.txtDateTo.AllowSpinLoop = False
        Me.txtDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateTo.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtDateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.Culture = 1056
        Me.txtDateTo.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDateTo.Location = New System.Drawing.Point(378, 18)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(168, 22)
        Me.txtDateTo.TabIndex = 197
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.TrimEnd = False
        Me.txtDateTo.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDateTo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(297, 21)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 18)
        Me.Label9.TabIndex = 196
        Me.Label9.Text = "Date  To :"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.AllowSpinLoop = False
        Me.txtDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateFrom.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtDateFrom.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateFrom.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateFrom.Culture = 1056
        Me.txtDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDateFrom.Location = New System.Drawing.Point(113, 18)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(168, 22)
        Me.txtDateFrom.TabIndex = 195
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.TrimEnd = False
        Me.txtDateFrom.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDateFrom.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateFrom.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(7, 21)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(91, 18)
        Me.Label10.TabIndex = 177
        Me.Label10.Text = "Date  From :"
        '
        'cmdVoucher
        '
        Me.cmdVoucher.Image = Global.General_Ledger.My.Resources.Resources.folder_document
        Me.cmdVoucher.Location = New System.Drawing.Point(402, 4)
        Me.cmdVoucher.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdVoucher.Name = "cmdVoucher"
        Me.cmdVoucher.Size = New System.Drawing.Size(82, 69)
        Me.cmdVoucher.TabIndex = 204
        Me.cmdVoucher.Text = "&Voucher"
        Me.cmdVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdVoucher.UseVisualStyleBackColor = True
        '
        'frmIssueProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1033, 646)
        Me.Controls.Add(Me.cmdVoucher)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmIssueProduct"
        Me.Text = "Issue Product"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSector, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTransactionType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLevel, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtIssDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.tdbLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbGridProductDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtIssDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtIssNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tdbProduct As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents tdbGridProductDetail As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdPickAccessories As System.Windows.Forms.Button
    Friend WithEvents tdbLocation As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbLevel As C1.Win.C1List.C1Combo
    Friend WithEvents cmbTransactionType As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label10 As Label
    Friend WithEvents cmdVoucher As Button
    Friend WithEvents cmbSector As C1.Win.C1List.C1Combo
    Friend WithEvents Label15 As Label
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label18 As Label
    Friend WithEvents cmbBlock As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As Label
    Friend WithEvents Label8 As Label
End Class
