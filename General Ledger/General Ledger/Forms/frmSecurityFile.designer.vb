<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmSecurityFile
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmSecurityFile))
        Me.TabControl1 = New System.Windows.Forms.TabControl
        Me.TabPage1 = New System.Windows.Forms.TabPage
        Me.TDBGrid1 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.TabPage2 = New System.Windows.Forms.TabPage
        Me.TDBGrid2 = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.txtUserID = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.cmbUserType = New System.Windows.Forms.ComboBox
        Me.tdbList = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdPrint = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tdbList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(269, 212)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(554, 307)
        Me.TabControl1.TabIndex = 10
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TDBGrid1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(546, 281)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "  Inputs  "
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TDBGrid1
        '
        Me.TDBGrid1.AllowColMove = False
        Me.TDBGrid1.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.TDBGrid1.AlternatingRows = True
        Me.TDBGrid1.CaptionHeight = 17
        Me.TDBGrid1.EmptyRows = True
        Me.TDBGrid1.GroupByCaption = "Drag a column header here to group by that column"
        Me.TDBGrid1.Images.Add(CType(resources.GetObject("TDBGrid1.Images"), System.Drawing.Image))
        Me.TDBGrid1.Location = New System.Drawing.Point(6, 6)
        Me.TDBGrid1.Name = "TDBGrid1"
        Me.TDBGrid1.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDBGrid1.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDBGrid1.PreviewInfo.ZoomFactor = 75
        Me.TDBGrid1.PrintInfo.PageSettings = CType(resources.GetObject("TDBGrid1.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDBGrid1.RowHeight = 16
        Me.TDBGrid1.Size = New System.Drawing.Size(534, 269)
        Me.TDBGrid1.TabIndex = 0
        Me.TDBGrid1.Text = "C1TrueDBGrid1"
        Me.TDBGrid1.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.TDBGrid1.WrapCellPointer = True
        Me.TDBGrid1.PropBag = resources.GetString("TDBGrid1.PropBag")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TDBGrid2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(546, 281)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "  Reports  "
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TDBGrid2
        '
        Me.TDBGrid2.AllowColMove = False
        Me.TDBGrid2.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.TDBGrid2.AlternatingRows = True
        Me.TDBGrid2.CaptionHeight = 17
        Me.TDBGrid2.EmptyRows = True
        Me.TDBGrid2.GroupByCaption = "Drag a column header here to group by that column"
        Me.TDBGrid2.Images.Add(CType(resources.GetObject("TDBGrid2.Images"), System.Drawing.Image))
        Me.TDBGrid2.Location = New System.Drawing.Point(6, 6)
        Me.TDBGrid2.Name = "TDBGrid2"
        Me.TDBGrid2.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.TDBGrid2.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.TDBGrid2.PreviewInfo.ZoomFactor = 75
        Me.TDBGrid2.PrintInfo.PageSettings = CType(resources.GetObject("TDBGrid2.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.TDBGrid2.RowHeight = 16
        Me.TDBGrid2.Size = New System.Drawing.Size(534, 269)
        Me.TDBGrid2.TabIndex = 0
        Me.TDBGrid2.Text = "C1TrueDBGrid1"
        Me.TDBGrid2.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.TDBGrid2.WrapCellPointer = True
        Me.TDBGrid2.PropBag = resources.GetString("TDBGrid2.PropBag")
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(1, 8)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(832, 75)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(252, 72)
        Me.ToolStripLabel1.Text = "  Security Panel"
        '
        'txtUserID
        '
        Me.txtUserID.Location = New System.Drawing.Point(123, 10)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.Size = New System.Drawing.Size(100, 20)
        Me.txtUserID.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User ID :"
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(123, 34)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(337, 20)
        Me.txtUserName.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(37, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "User Name :"
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(123, 58)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPassword.Size = New System.Drawing.Size(337, 20)
        Me.txtPassword.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(37, 61)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 13)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(35, 86)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "User Type :"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmbUserType)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtUserID)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(273, 96)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(543, 110)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        '
        'cmbUserType
        '
        Me.cmbUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUserType.FormattingEnabled = True
        Me.cmbUserType.Items.AddRange(New Object() {"Administor", "Data Entry User", "Data Verification User", "Data Autorized User", "Data Posting User"})
        Me.cmbUserType.Location = New System.Drawing.Point(123, 83)
        Me.cmbUserType.Name = "cmbUserType"
        Me.cmbUserType.Size = New System.Drawing.Size(291, 21)
        Me.cmbUserType.TabIndex = 3
        '
        'tdbList
        '
        Me.tdbList.AllowColMove = False
        Me.tdbList.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.None
        Me.tdbList.AllowUpdate = False
        Me.tdbList.AlternatingRows = True
        Me.tdbList.CaptionHeight = 17
        Me.tdbList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.tdbList.EmptyRows = True
        Me.tdbList.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbList.Images.Add(CType(resources.GetObject("tdbList.Images"), System.Drawing.Image))
        Me.tdbList.Location = New System.Drawing.Point(12, 96)
        Me.tdbList.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.tdbList.Name = "tdbList"
        Me.tdbList.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbList.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbList.PreviewInfo.ZoomFactor = 75
        Me.tdbList.PrintInfo.PageSettings = CType(resources.GetObject("tdbList.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbList.Size = New System.Drawing.Size(251, 423)
        Me.tdbList.TabIndex = 9
        Me.tdbList.Text = "C1TrueDBGrid1"
        Me.tdbList.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.tdbList.PropBag = resources.GetString("tdbList.PropBag")
        '
        'cmdAdd
        '
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(455, 17)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 56)
        Me.cmdAdd.TabIndex = 1
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(762, 16)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 57)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(660, 17)
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
        Me.cmdSearch.Location = New System.Drawing.Point(404, 17)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 0
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(507, 17)
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
        Me.cmdDelete.Location = New System.Drawing.Point(609, 17)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.General_Ledger.My.Resources.Resources.folder_document
        Me.cmdPrint.Location = New System.Drawing.Point(711, 16)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(51, 57)
        Me.cmdPrint.TabIndex = 6
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(558, 17)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 3
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'FrmSecurityFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(828, 527)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.tdbList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "FrmSecurityFile"
        Me.ShowInTaskbar = False
        Me.Text = "Security File"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.TDBGrid1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.TDBGrid2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tdbList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents txtUserID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbUserType As System.Windows.Forms.ComboBox
    Friend WithEvents TDBGrid1 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents tdbList As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents TDBGrid2 As C1.Win.C1TrueDBGrid.C1TrueDBGrid
End Class
