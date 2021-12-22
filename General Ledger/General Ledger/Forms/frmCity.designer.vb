<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCity
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCity))
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.cmbRegion = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmbCountryList = New System.Windows.Forms.Button
        Me.cmbCountry = New C1.Win.C1List.C1Combo
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbName = New C1.Win.C1List.C1Combo
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbRegion, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(84, 108)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 111)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 150)
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
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 64)
        Me.ToolStrip1.TabIndex = 112
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(160, 61)
        Me.ToolStripLabel1.Text = "CITY FILE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmbRegion)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmbCountryList)
        Me.GroupBox2.Controls.Add(Me.cmbCountry)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbName)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 192)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'cmbRegion
        '
        Me.cmbRegion.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbRegion.Caption = ""
        Me.cmbRegion.CaptionHeight = 17
        Me.cmbRegion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbRegion.ColumnCaptionHeight = 17
        Me.cmbRegion.ColumnFooterHeight = 17
        Me.cmbRegion.ContentHeight = 15
        Me.cmbRegion.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbRegion.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbRegion.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbRegion.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbRegion.EditorHeight = 15
        Me.cmbRegion.Images.Add(CType(resources.GetObject("cmbRegion.Images"), System.Drawing.Image))
        Me.cmbRegion.ItemHeight = 15
        Me.cmbRegion.Location = New System.Drawing.Point(84, 158)
        Me.cmbRegion.MatchEntryTimeout = CType(2000, Long)
        Me.cmbRegion.MaxDropDownItems = CType(5, Short)
        Me.cmbRegion.MaxLength = 32767
        Me.cmbRegion.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbRegion.Name = "cmbRegion"
        Me.cmbRegion.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbRegion.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbRegion.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbRegion.Size = New System.Drawing.Size(278, 21)
        Me.cmbRegion.TabIndex = 140
        Me.cmbRegion.PropBag = resources.GetString("cmbRegion.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 139
        Me.Label3.Text = "Region"
        '
        'cmbCountryList
        '
        Me.cmbCountryList.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmbCountryList.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmbCountryList.Location = New System.Drawing.Point(363, 117)
        Me.cmbCountryList.Name = "cmbCountryList"
        Me.cmbCountryList.Size = New System.Drawing.Size(22, 21)
        Me.cmbCountryList.TabIndex = 138
        Me.cmbCountryList.UseVisualStyleBackColor = True
        '
        'cmbCountry
        '
        Me.cmbCountry.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCountry.Caption = ""
        Me.cmbCountry.CaptionHeight = 17
        Me.cmbCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCountry.ColumnCaptionHeight = 17
        Me.cmbCountry.ColumnFooterHeight = 17
        Me.cmbCountry.ContentHeight = 15
        Me.cmbCountry.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCountry.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCountry.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCountry.EditorHeight = 15
        Me.cmbCountry.Images.Add(CType(resources.GetObject("cmbCountry.Images"), System.Drawing.Image))
        Me.cmbCountry.ItemHeight = 15
        Me.cmbCountry.Location = New System.Drawing.Point(84, 117)
        Me.cmbCountry.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCountry.MaxDropDownItems = CType(5, Short)
        Me.cmbCountry.MaxLength = 32767
        Me.cmbCountry.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCountry.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCountry.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCountry.Size = New System.Drawing.Size(278, 21)
        Me.cmbCountry.TabIndex = 137
        Me.cmbCountry.PropBag = resources.GetString("cmbCountry.PropBag")
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 121)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Country"
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
        Me.cmbName.Location = New System.Drawing.Point(84, 74)
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
        'frmCity
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 275)
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
        Me.Name = "frmCity"
        Me.Text = "City File"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbRegion, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents cmbCountry As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbCountryList As System.Windows.Forms.Button
    Friend WithEvents cmbRegion As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    'Friend WithEvents CachedReport1 As CrystalDecisions.ReportSource.CachedReport
End Class
