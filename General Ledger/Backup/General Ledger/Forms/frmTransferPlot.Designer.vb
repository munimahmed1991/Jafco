<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransferPlot
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTransferPlot))
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmbUnitTypeTo = New C1.Win.C1List.C1Combo
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdUnitTo = New System.Windows.Forms.Button
        Me.cmbUnitTo = New C1.Win.C1List.C1Combo
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbUnitTypeFrom = New C1.Win.C1List.C1Combo
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmdUnitFrom = New System.Windows.Forms.Button
        Me.cmbUnitFrom = New C1.Win.C1List.C1Combo
        Me.Label21 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdClearApplicant = New System.Windows.Forms.Button
        Me.cmdCustomerToList = New System.Windows.Forms.Button
        Me.txtCustomerEmail2 = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtCustomerNIC2 = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtCustomerMobile2 = New System.Windows.Forms.TextBox
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtCustomerTel2 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCustomerName2 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCustomerCode2 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtCustomerEmail1 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCustomerNIC1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCustomerMobile1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCustomerTel1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCustomerName1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCustomerCode1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.chkAmountTransfer = New System.Windows.Forms.CheckBox
        Me.cmbPaymentType = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.txtAmount = New C1.Win.C1Input.C1NumericEdit
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.txtTransferDate = New C1.Win.C1Input.C1DateEdit
        Me.txtTransferNo = New System.Windows.Forms.TextBox
        Me.Label25 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.cmbUnitTypeTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitTypeFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTransferDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(523, 12)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 56)
        Me.cmdAdd.TabIndex = 120
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(781, 12)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 56)
        Me.cmdExit.TabIndex = 126
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(730, 12)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(51, 56)
        Me.cmdUndo.TabIndex = 125
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(471, 12)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 121
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(575, 12)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(51, 56)
        Me.cmdEdit.TabIndex = 123
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(627, 12)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 122
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(678, 12)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 124
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(833, 64)
        Me.ToolStrip1.TabIndex = 127
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(253, 61)
        Me.ToolStripLabel1.Text = "TRANSFER UNIT"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.cmbUnitTypeTo)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.cmdUnitTo)
        Me.GroupBox3.Controls.Add(Me.cmbUnitTo)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.cmbUnitTypeFrom)
        Me.GroupBox3.Controls.Add(Me.Label27)
        Me.GroupBox3.Controls.Add(Me.cmdUnitFrom)
        Me.GroupBox3.Controls.Add(Me.cmbUnitFrom)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(7, 211)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(834, 66)
        Me.GroupBox3.TabIndex = 128
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Unit Details"
        '
        'cmbUnitTypeTo
        '
        Me.cmbUnitTypeTo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnitTypeTo.Caption = ""
        Me.cmbUnitTypeTo.CaptionHeight = 17
        Me.cmbUnitTypeTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnitTypeTo.ColumnCaptionHeight = 17
        Me.cmbUnitTypeTo.ColumnFooterHeight = 17
        Me.cmbUnitTypeTo.ContentHeight = 15
        Me.cmbUnitTypeTo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnitTypeTo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnitTypeTo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitTypeTo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnitTypeTo.EditorHeight = 15
        Me.cmbUnitTypeTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitTypeTo.Images.Add(CType(resources.GetObject("cmbUnitTypeTo.Images"), System.Drawing.Image))
        Me.cmbUnitTypeTo.ItemHeight = 15
        Me.cmbUnitTypeTo.Location = New System.Drawing.Point(536, 40)
        Me.cmbUnitTypeTo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnitTypeTo.MaxDropDownItems = CType(5, Short)
        Me.cmbUnitTypeTo.MaxLength = 32767
        Me.cmbUnitTypeTo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnitTypeTo.Name = "cmbUnitTypeTo"
        Me.cmbUnitTypeTo.ReadOnly = True
        Me.cmbUnitTypeTo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUnitTypeTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnitTypeTo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnitTypeTo.Size = New System.Drawing.Size(196, 21)
        Me.cmbUnitTypeTo.TabIndex = 258
        Me.cmbUnitTypeTo.PropBag = resources.GetString("cmbUnitTypeTo.PropBag")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(466, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 13)
        Me.Label1.TabIndex = 259
        Me.Label1.Text = "Unit Type"
        '
        'cmdUnitTo
        '
        Me.cmdUnitTo.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitTo.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitTo.Location = New System.Drawing.Point(734, 16)
        Me.cmdUnitTo.Name = "cmdUnitTo"
        Me.cmdUnitTo.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnitTo.TabIndex = 257
        Me.cmdUnitTo.UseVisualStyleBackColor = True
        '
        'cmbUnitTo
        '
        Me.cmbUnitTo.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnitTo.Caption = ""
        Me.cmbUnitTo.CaptionHeight = 17
        Me.cmbUnitTo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnitTo.ColumnCaptionHeight = 17
        Me.cmbUnitTo.ColumnFooterHeight = 17
        Me.cmbUnitTo.ContentHeight = 15
        Me.cmbUnitTo.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnitTo.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnitTo.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitTo.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnitTo.EditorHeight = 15
        Me.cmbUnitTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitTo.Images.Add(CType(resources.GetObject("cmbUnitTo.Images"), System.Drawing.Image))
        Me.cmbUnitTo.ItemHeight = 15
        Me.cmbUnitTo.Location = New System.Drawing.Point(536, 16)
        Me.cmbUnitTo.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnitTo.MaxDropDownItems = CType(5, Short)
        Me.cmbUnitTo.MaxLength = 32767
        Me.cmbUnitTo.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnitTo.Name = "cmbUnitTo"
        Me.cmbUnitTo.ReadOnly = True
        Me.cmbUnitTo.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUnitTo.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnitTo.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnitTo.Size = New System.Drawing.Size(197, 21)
        Me.cmbUnitTo.TabIndex = 255
        Me.cmbUnitTo.PropBag = resources.GetString("cmbUnitTo.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(466, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 256
        Me.Label2.Text = "Unit # To"
        '
        'cmbUnitTypeFrom
        '
        Me.cmbUnitTypeFrom.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnitTypeFrom.Caption = ""
        Me.cmbUnitTypeFrom.CaptionHeight = 17
        Me.cmbUnitTypeFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnitTypeFrom.ColumnCaptionHeight = 17
        Me.cmbUnitTypeFrom.ColumnFooterHeight = 17
        Me.cmbUnitTypeFrom.ContentHeight = 15
        Me.cmbUnitTypeFrom.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnitTypeFrom.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnitTypeFrom.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitTypeFrom.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnitTypeFrom.EditorHeight = 15
        Me.cmbUnitTypeFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitTypeFrom.Images.Add(CType(resources.GetObject("cmbUnitTypeFrom.Images"), System.Drawing.Image))
        Me.cmbUnitTypeFrom.ItemHeight = 15
        Me.cmbUnitTypeFrom.Location = New System.Drawing.Point(112, 40)
        Me.cmbUnitTypeFrom.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnitTypeFrom.MaxDropDownItems = CType(5, Short)
        Me.cmbUnitTypeFrom.MaxLength = 32767
        Me.cmbUnitTypeFrom.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnitTypeFrom.Name = "cmbUnitTypeFrom"
        Me.cmbUnitTypeFrom.ReadOnly = True
        Me.cmbUnitTypeFrom.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUnitTypeFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnitTypeFrom.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnitTypeFrom.Size = New System.Drawing.Size(196, 21)
        Me.cmbUnitTypeFrom.TabIndex = 252
        Me.cmbUnitTypeFrom.PropBag = resources.GetString("cmbUnitTypeFrom.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(9, 44)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 253
        Me.Label27.Text = "Unit Type"
        '
        'cmdUnitFrom
        '
        Me.cmdUnitFrom.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitFrom.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitFrom.Location = New System.Drawing.Point(310, 17)
        Me.cmdUnitFrom.Name = "cmdUnitFrom"
        Me.cmdUnitFrom.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnitFrom.TabIndex = 251
        Me.cmdUnitFrom.UseVisualStyleBackColor = True
        '
        'cmbUnitFrom
        '
        Me.cmbUnitFrom.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnitFrom.Caption = ""
        Me.cmbUnitFrom.CaptionHeight = 17
        Me.cmbUnitFrom.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnitFrom.ColumnCaptionHeight = 17
        Me.cmbUnitFrom.ColumnFooterHeight = 17
        Me.cmbUnitFrom.ContentHeight = 15
        Me.cmbUnitFrom.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnitFrom.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnitFrom.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitFrom.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnitFrom.EditorHeight = 15
        Me.cmbUnitFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitFrom.Images.Add(CType(resources.GetObject("cmbUnitFrom.Images"), System.Drawing.Image))
        Me.cmbUnitFrom.ItemHeight = 15
        Me.cmbUnitFrom.Location = New System.Drawing.Point(112, 16)
        Me.cmbUnitFrom.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnitFrom.MaxDropDownItems = CType(5, Short)
        Me.cmbUnitFrom.MaxLength = 32767
        Me.cmbUnitFrom.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnitFrom.Name = "cmbUnitFrom"
        Me.cmbUnitFrom.ReadOnly = True
        Me.cmbUnitFrom.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUnitFrom.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnitFrom.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnitFrom.Size = New System.Drawing.Size(197, 21)
        Me.cmbUnitFrom.TabIndex = 249
        Me.cmbUnitFrom.PropBag = resources.GetString("cmbUnitFrom.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(9, 21)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(62, 13)
        Me.Label21.TabIndex = 250
        Me.Label21.Text = "Unit # From"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdClearApplicant)
        Me.GroupBox1.Controls.Add(Me.cmdCustomerToList)
        Me.GroupBox1.Controls.Add(Me.txtCustomerEmail2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txtCustomerNIC2)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txtCustomerMobile2)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtCustomerTel2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCustomerCode2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtCustomerEmail1)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtCustomerNIC1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCustomerMobile1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCustomerTel1)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCustomerCode1)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 282)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(831, 164)
        Me.GroupBox1.TabIndex = 129
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'cmdClearApplicant
        '
        Me.cmdClearApplicant.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClearApplicant.Location = New System.Drawing.Point(640, 30)
        Me.cmdClearApplicant.Name = "cmdClearApplicant"
        Me.cmdClearApplicant.Size = New System.Drawing.Size(39, 23)
        Me.cmdClearApplicant.TabIndex = 260
        Me.cmdClearApplicant.Text = "Clear"
        Me.cmdClearApplicant.UseVisualStyleBackColor = True
        '
        'cmdCustomerToList
        '
        Me.cmdCustomerToList.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdCustomerToList.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdCustomerToList.Location = New System.Drawing.Point(618, 31)
        Me.cmdCustomerToList.Name = "cmdCustomerToList"
        Me.cmdCustomerToList.Size = New System.Drawing.Size(22, 21)
        Me.cmdCustomerToList.TabIndex = 259
        Me.cmdCustomerToList.UseVisualStyleBackColor = True
        '
        'txtCustomerEmail2
        '
        Me.txtCustomerEmail2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail2.Location = New System.Drawing.Point(517, 138)
        Me.txtCustomerEmail2.Name = "txtCustomerEmail2"
        Me.txtCustomerEmail2.ReadOnly = True
        Me.txtCustomerEmail2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerEmail2.TabIndex = 258
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(425, 141)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 13)
        Me.Label11.TabIndex = 257
        Me.Label11.Text = "Email"
        '
        'txtCustomerNIC2
        '
        Me.txtCustomerNIC2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerNIC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNIC2.Location = New System.Drawing.Point(517, 117)
        Me.txtCustomerNIC2.Name = "txtCustomerNIC2"
        Me.txtCustomerNIC2.ReadOnly = True
        Me.txtCustomerNIC2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerNIC2.TabIndex = 255
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(425, 120)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 254
        Me.Label12.Text = "NIC #"
        '
        'txtCustomerMobile2
        '
        Me.txtCustomerMobile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerMobile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerMobile2.Location = New System.Drawing.Point(517, 96)
        Me.txtCustomerMobile2.Name = "txtCustomerMobile2"
        Me.txtCustomerMobile2.ReadOnly = True
        Me.txtCustomerMobile2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerMobile2.TabIndex = 253
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(425, 99)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 13)
        Me.Label13.TabIndex = 252
        Me.Label13.Text = "Mobile #"
        '
        'txtCustomerTel2
        '
        Me.txtCustomerTel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerTel2.Location = New System.Drawing.Point(517, 75)
        Me.txtCustomerTel2.Name = "txtCustomerTel2"
        Me.txtCustomerTel2.ReadOnly = True
        Me.txtCustomerTel2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerTel2.TabIndex = 251
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(425, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 250
        Me.Label14.Text = "Tel # "
        '
        'txtCustomerName2
        '
        Me.txtCustomerName2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName2.Location = New System.Drawing.Point(517, 54)
        Me.txtCustomerName2.Name = "txtCustomerName2"
        Me.txtCustomerName2.ReadOnly = True
        Me.txtCustomerName2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerName2.TabIndex = 249
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(425, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 248
        Me.Label15.Text = "Customer Name"
        '
        'txtCustomerCode2
        '
        Me.txtCustomerCode2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCustomerCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode2.Location = New System.Drawing.Point(517, 32)
        Me.txtCustomerCode2.Name = "txtCustomerCode2"
        Me.txtCustomerCode2.ReadOnly = True
        Me.txtCustomerCode2.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerCode2.TabIndex = 247
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(425, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 246
        Me.Label18.Text = "Customer Code"
        '
        'txtCustomerEmail1
        '
        Me.txtCustomerEmail1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail1.Location = New System.Drawing.Point(100, 138)
        Me.txtCustomerEmail1.Name = "txtCustomerEmail1"
        Me.txtCustomerEmail1.ReadOnly = True
        Me.txtCustomerEmail1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerEmail1.TabIndex = 245
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 244
        Me.Label17.Text = "Email"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(423, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(79, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Applicant To"
        '
        'txtCustomerNIC1
        '
        Me.txtCustomerNIC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerNIC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNIC1.Location = New System.Drawing.Point(100, 117)
        Me.txtCustomerNIC1.Name = "txtCustomerNIC1"
        Me.txtCustomerNIC1.ReadOnly = True
        Me.txtCustomerNIC1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerNIC1.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "NIC #"
        '
        'txtCustomerMobile1
        '
        Me.txtCustomerMobile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerMobile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerMobile1.Location = New System.Drawing.Point(100, 96)
        Me.txtCustomerMobile1.Name = "txtCustomerMobile1"
        Me.txtCustomerMobile1.ReadOnly = True
        Me.txtCustomerMobile1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerMobile1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mobile #"
        '
        'txtCustomerTel1
        '
        Me.txtCustomerTel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerTel1.Location = New System.Drawing.Point(100, 75)
        Me.txtCustomerTel1.Name = "txtCustomerTel1"
        Me.txtCustomerTel1.ReadOnly = True
        Me.txtCustomerTel1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerTel1.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Tel # "
        '
        'txtCustomerName1
        '
        Me.txtCustomerName1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName1.Location = New System.Drawing.Point(100, 54)
        Me.txtCustomerName1.Name = "txtCustomerName1"
        Me.txtCustomerName1.ReadOnly = True
        Me.txtCustomerName1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerName1.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(8, 57)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Customer Name"
        '
        'txtCustomerCode1
        '
        Me.txtCustomerCode1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCustomerCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode1.Location = New System.Drawing.Point(100, 32)
        Me.txtCustomerCode1.Name = "txtCustomerCode1"
        Me.txtCustomerCode1.ReadOnly = True
        Me.txtCustomerCode1.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerCode1.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(8, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Customer Code"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(8, 17)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(91, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Applicant From"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtRemarks)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.chkAmountTransfer)
        Me.GroupBox2.Controls.Add(Me.cmbPaymentType)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.txtAmount)
        Me.GroupBox2.Controls.Add(Me.cmbProject)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtTransferDate)
        Me.GroupBox2.Controls.Add(Me.txtTransferNo)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(7, 77)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(834, 127)
        Me.GroupBox2.TabIndex = 130
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Receipt Details"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(101, 99)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(651, 20)
        Me.txtRemarks.TabIndex = 277
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(9, 102)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(49, 13)
        Me.Label19.TabIndex = 276
        Me.Label19.Text = "Remarks"
        '
        'chkAmountTransfer
        '
        Me.chkAmountTransfer.AutoSize = True
        Me.chkAmountTransfer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAmountTransfer.Location = New System.Drawing.Point(416, 75)
        Me.chkAmountTransfer.Name = "chkAmountTransfer"
        Me.chkAmountTransfer.Size = New System.Drawing.Size(104, 17)
        Me.chkAmountTransfer.TabIndex = 275
        Me.chkAmountTransfer.Text = "Amount Transfer"
        Me.chkAmountTransfer.UseVisualStyleBackColor = True
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
        Me.cmbPaymentType.Images.Add(CType(resources.GetObject("cmbPaymentType.Images"), System.Drawing.Image))
        Me.cmbPaymentType.ItemHeight = 15
        Me.cmbPaymentType.Location = New System.Drawing.Point(509, 47)
        Me.cmbPaymentType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPaymentType.MaxDropDownItems = CType(5, Short)
        Me.cmbPaymentType.MaxLength = 32767
        Me.cmbPaymentType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPaymentType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.Size = New System.Drawing.Size(243, 21)
        Me.cmbPaymentType.TabIndex = 273
        Me.cmbPaymentType.PropBag = resources.GetString("cmbPaymentType.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(413, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 274
        Me.Label4.Text = "Payment Type"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(9, 76)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(85, 13)
        Me.Label31.TabIndex = 272
        Me.Label31.Text = "Transfer Amount"
        '
        'txtAmount
        '
        Me.txtAmount.AutoSize = False
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(101, 73)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.Size = New System.Drawing.Size(88, 20)
        Me.txtAmount.TabIndex = 271
        Me.txtAmount.Tag = Nothing
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.cmbProject.Location = New System.Drawing.Point(101, 47)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(243, 21)
        Me.cmbProject.TabIndex = 237
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(9, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Project"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(413, 24)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 13)
        Me.Label24.TabIndex = 196
        Me.Label24.Text = "Transfer Date"
        '
        'txtTransferDate
        '
        Me.txtTransferDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtTransferDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtTransferDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtTransferDate.Calendar.ClearText = "&Clear"
        Me.txtTransferDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtTransferDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtTransferDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtTransferDate.Calendar.TodayText = "&Today"
        Me.txtTransferDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtTransferDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtTransferDate.Culture = 1056
        Me.txtTransferDate.CustomFormat = "dd/MM/yyyy"
        Me.txtTransferDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtTransferDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTransferDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransferDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtTransferDate.Location = New System.Drawing.Point(509, 20)
        Me.txtTransferDate.Name = "txtTransferDate"
        Me.txtTransferDate.Size = New System.Drawing.Size(126, 19)
        Me.txtTransferDate.TabIndex = 195
        Me.txtTransferDate.Tag = Nothing
        Me.txtTransferDate.TrimEnd = False
        Me.txtTransferDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtTransferDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTransferDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtTransferNo
        '
        Me.txtTransferNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtTransferNo.Location = New System.Drawing.Point(101, 21)
        Me.txtTransferNo.Name = "txtTransferNo"
        Me.txtTransferNo.Size = New System.Drawing.Size(179, 20)
        Me.txtTransferNo.TabIndex = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(9, 24)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(56, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Transfer #"
        '
        'frmTransferPlot
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(846, 453)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmTransferPlot"
        Me.Text = "Transfer Unit"
        Me.TopMost = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.cmbUnitTypeTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitTypeFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTransferDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUnitTypeFrom As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmdUnitFrom As System.Windows.Forms.Button
    Friend WithEvents cmbUnitFrom As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbUnitTypeTo As C1.Win.C1List.C1Combo
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdUnitTo As System.Windows.Forms.Button
    Friend WithEvents cmbUnitTo As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerEmail2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNIC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerMobile2 As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNIC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerMobile1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtTransferDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtTransferNo As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cmbPaymentType As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkAmountTransfer As System.Windows.Forms.CheckBox
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents cmdCustomerToList As System.Windows.Forms.Button
    Friend WithEvents cmdClearApplicant As System.Windows.Forms.Button
End Class
