<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAgent))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtCommPer = New C1.Win.C1Input.C1NumericEdit
        Me.Label39 = New System.Windows.Forms.Label
        Me.txtCollection2 = New C1.Win.C1Input.C1NumericEdit
        Me.Label38 = New System.Windows.Forms.Label
        Me.txtCollection1 = New C1.Win.C1Input.C1NumericEdit
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmbAgentCompany = New C1.Win.C1List.C1Combo
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.cmbName = New C1.Win.C1List.C1Combo
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCommPer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCollection2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAgentCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 64)
        Me.ToolStrip1.TabIndex = 112
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(169, 61)
        Me.ToolStripLabel1.Text = "Agent File"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCommPer)
        Me.GroupBox2.Controls.Add(Me.Label39)
        Me.GroupBox2.Controls.Add(Me.txtCollection2)
        Me.GroupBox2.Controls.Add(Me.Label38)
        Me.GroupBox2.Controls.Add(Me.txtCollection1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.cmbAgentCompany)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Controls.Add(Me.cmbName)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 207)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(24, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 294
        Me.Label3.Text = "Comm %"
        '
        'txtCommPer
        '
        Me.txtCommPer.AutoSize = False
        Me.txtCommPer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCommPer.DisplayFormat.CustomFormat = "###,###,##0.00"
        Me.txtCommPer.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCommPer.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCommPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCommPer.Location = New System.Drawing.Point(113, 133)
        Me.txtCommPer.Name = "txtCommPer"
        Me.txtCommPer.Size = New System.Drawing.Size(88, 20)
        Me.txtCommPer.TabIndex = 293
        Me.txtCommPer.Tag = Nothing
        Me.txtCommPer.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCommPer.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCommPer.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCommPer.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtCommPer.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(300, 175)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(161, 13)
        Me.Label39.TabIndex = 292
        Me.Label39.Text = "Final Release on Collection Upto"
        '
        'txtCollection2
        '
        Me.txtCollection2.AutoSize = False
        Me.txtCollection2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollection2.DisplayFormat.CustomFormat = "###,###,##0.00"
        Me.txtCollection2.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCollection2.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCollection2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollection2.Location = New System.Drawing.Point(469, 171)
        Me.txtCollection2.Name = "txtCollection2"
        Me.txtCollection2.Size = New System.Drawing.Size(51, 20)
        Me.txtCollection2.TabIndex = 291
        Me.txtCollection2.Tag = Nothing
        Me.txtCollection2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCollection2.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCollection2.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCollection2.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtCollection2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(24, 173)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(158, 13)
        Me.Label38.TabIndex = 290
        Me.Label38.Text = "First Release on Collection Upto"
        '
        'txtCollection1
        '
        Me.txtCollection1.AutoSize = False
        Me.txtCollection1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCollection1.DisplayFormat.CustomFormat = "###,###,##0.00"
        Me.txtCollection1.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCollection1.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCollection1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCollection1.Location = New System.Drawing.Point(183, 171)
        Me.txtCollection1.Name = "txtCollection1"
        Me.txtCollection1.Size = New System.Drawing.Size(88, 20)
        Me.txtCollection1.TabIndex = 289
        Me.txtCollection1.Tag = Nothing
        Me.txtCollection1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCollection1.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCollection1.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCollection1.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtCollection1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 140
        Me.Label6.Text = "Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "Code"
        '
        'cmbAgentCompany
        '
        Me.cmbAgentCompany.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbAgentCompany.Caption = ""
        Me.cmbAgentCompany.CaptionHeight = 17
        Me.cmbAgentCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbAgentCompany.ColumnCaptionHeight = 17
        Me.cmbAgentCompany.ColumnFooterHeight = 17
        Me.cmbAgentCompany.ContentHeight = 15
        Me.cmbAgentCompany.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbAgentCompany.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbAgentCompany.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbAgentCompany.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAgentCompany.EditorHeight = 15
        Me.cmbAgentCompany.Images.Add(CType(resources.GetObject("cmbAgentCompany.Images"), System.Drawing.Image))
        Me.cmbAgentCompany.ItemHeight = 15
        Me.cmbAgentCompany.Location = New System.Drawing.Point(112, 96)
        Me.cmbAgentCompany.MatchEntryTimeout = CType(2000, Long)
        Me.cmbAgentCompany.MaxDropDownItems = CType(5, Short)
        Me.cmbAgentCompany.MaxLength = 32767
        Me.cmbAgentCompany.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbAgentCompany.Name = "cmbAgentCompany"
        Me.cmbAgentCompany.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbAgentCompany.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbAgentCompany.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbAgentCompany.Size = New System.Drawing.Size(278, 21)
        Me.cmbAgentCompany.TabIndex = 138
        Me.cmbAgentCompany.PropBag = resources.GetString("cmbAgentCompany.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Agent Company"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(112, 23)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 136
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
        Me.cmbName.Location = New System.Drawing.Point(112, 59)
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
        Me.cmdAdd.Location = New System.Drawing.Point(432, 4)
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
        Me.cmdExit.Location = New System.Drawing.Point(690, 4)
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
        Me.cmdUndo.Location = New System.Drawing.Point(639, 4)
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
        Me.cmdSearch.Location = New System.Drawing.Point(380, 4)
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
        Me.cmdEdit.Location = New System.Drawing.Point(484, 4)
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
        Me.cmdSave.Location = New System.Drawing.Point(536, 4)
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
        Me.cmdDelete.Location = New System.Drawing.Point(587, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'frmAgent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 283)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmAgent"
        Me.Text = "Agent File"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCommPer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCollection2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCollection1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAgentCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbName As C1.Win.C1List.C1Combo
    Friend WithEvents cmbAgentCompany As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtCommPer As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents txtCollection2 As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents txtCollection1 As C1.Win.C1Input.C1NumericEdit
    'Friend WithEvents CachedReport1 As CrystalDecisions.ReportSource.CachedReport
End Class
