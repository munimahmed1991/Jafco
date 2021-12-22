<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmScheme
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmScheme))
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmdUnitType = New System.Windows.Forms.Button
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label27 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtTotalRevenue = New C1.Win.C1Input.C1NumericEdit
        Me.txtLoanAmount = New C1.Win.C1Input.C1NumericEdit
        Me.txtCashAmount = New C1.Win.C1Input.C1NumericEdit
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbName = New C1.Win.C1List.C1Combo
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtTotalRevenue, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLoanAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(498, 9)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 56)
        Me.cmdAdd.TabIndex = 113
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(756, 9)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 56)
        Me.cmdExit.TabIndex = 119
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(705, 9)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(51, 56)
        Me.cmdUndo.TabIndex = 118
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(446, 9)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 114
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(602, 9)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 116
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(801, 64)
        Me.ToolStrip1.TabIndex = 120
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(209, 61)
        Me.ToolStripLabel1.Text = "SCHEME FILE"
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(550, 9)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(51, 56)
        Me.cmdEdit.TabIndex = 115
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(653, 9)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 117
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmdUnitType)
        Me.GroupBox1.Controls.Add(Me.cmbUnitType)
        Me.GroupBox1.Controls.Add(Me.Label27)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtTotalRevenue)
        Me.GroupBox1.Controls.Add(Me.txtLoanAmount)
        Me.GroupBox1.Controls.Add(Me.txtCashAmount)
        Me.GroupBox1.Controls.Add(Me.cmbProject)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cmbName)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCode)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(798, 210)
        Me.GroupBox1.TabIndex = 123
        Me.GroupBox1.TabStop = False
        '
        'cmdUnitType
        '
        Me.cmdUnitType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitType.Location = New System.Drawing.Point(382, 100)
        Me.cmdUnitType.Name = "cmdUnitType"
        Me.cmdUnitType.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnitType.TabIndex = 239
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
        Me.cmbUnitType.Location = New System.Drawing.Point(104, 100)
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
        Me.cmbUnitType.TabIndex = 237
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(12, 104)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 238
        Me.Label27.Text = "Unit Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 163
        Me.Label5.Text = "Total Revenue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 13)
        Me.Label4.TabIndex = 162
        Me.Label4.Text = "Loan Amount"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 13)
        Me.Label3.TabIndex = 161
        Me.Label3.Text = "Cash Amount"
        '
        'txtTotalRevenue
        '
        Me.txtTotalRevenue.AutoSize = False
        Me.txtTotalRevenue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalRevenue.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtTotalRevenue.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtTotalRevenue.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtTotalRevenue.Location = New System.Drawing.Point(104, 181)
        Me.txtTotalRevenue.Name = "txtTotalRevenue"
        Me.txtTotalRevenue.ReadOnly = True
        Me.txtTotalRevenue.Size = New System.Drawing.Size(88, 20)
        Me.txtTotalRevenue.TabIndex = 160
        Me.txtTotalRevenue.Tag = Nothing
        Me.txtTotalRevenue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtTotalRevenue.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtTotalRevenue.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtTotalRevenue.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtTotalRevenue.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtTotalRevenue.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.AutoSize = False
        Me.txtLoanAmount.BackColor = System.Drawing.Color.White
        Me.txtLoanAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLoanAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtLoanAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtLoanAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtLoanAmount.Location = New System.Drawing.Point(104, 154)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(88, 20)
        Me.txtLoanAmount.TabIndex = 158
        Me.txtLoanAmount.Tag = Nothing
        Me.txtLoanAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLoanAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLoanAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtLoanAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtLoanAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCashAmount
        '
        Me.txtCashAmount.AutoSize = False
        Me.txtCashAmount.BackColor = System.Drawing.Color.White
        Me.txtCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtCashAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCashAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCashAmount.Location = New System.Drawing.Point(104, 128)
        Me.txtCashAmount.Name = "txtCashAmount"
        Me.txtCashAmount.Size = New System.Drawing.Size(88, 20)
        Me.txtCashAmount.TabIndex = 157
        Me.txtCashAmount.Tag = Nothing
        Me.txtCashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCashAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCashAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCashAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtCashAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.cmbProject.Location = New System.Drawing.Point(104, 73)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 156
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 13)
        Me.Label2.TabIndex = 159
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
        Me.cmbName.Location = New System.Drawing.Point(104, 46)
        Me.cmbName.MatchEntryTimeout = CType(2000, Long)
        Me.cmbName.MaxDropDownItems = CType(5, Short)
        Me.cmbName.MaxLength = 32767
        Me.cmbName.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbName.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbName.Size = New System.Drawing.Size(278, 21)
        Me.cmbName.TabIndex = 155
        Me.cmbName.PropBag = resources.GetString("cmbName.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 154
        Me.Label6.Text = "Name"
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(104, 19)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 152
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 153
        Me.Label1.Text = "Code"
        '
        'frmScheme
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(811, 291)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmScheme"
        Me.Text = "Scheme File"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtTotalRevenue, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLoanAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtTotalRevenue As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtLoanAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCashAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbName As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdUnitType As System.Windows.Forms.Button
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As System.Windows.Forms.Label
End Class
