<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmList
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmList))
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdSelect = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton4 = New System.Windows.Forms.ToolStripButton
        Me.ToolStripButton5 = New System.Windows.Forms.ToolStripButton
        Me.radioExpandAll = New System.Windows.Forms.RadioButton
        Me.radioCollapseAll = New System.Windows.Forms.RadioButton
        Me.grdList = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.ToolStrip1.SuspendLayout()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(93, 377)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 1
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSelect
        '
        Me.cmdSelect.Location = New System.Drawing.Point(12, 377)
        Me.cmdSelect.Name = "cmdSelect"
        Me.cmdSelect.Size = New System.Drawing.Size(75, 23)
        Me.cmdSelect.TabIndex = 2
        Me.cmdSelect.Text = "&Select"
        Me.cmdSelect.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripButton2, Me.ToolStripButton3, Me.ToolStripButton4, Me.ToolStripButton5})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(793, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = Global.General_Ledger.My.Resources.Resources.AddPrint
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(159, 22)
        Me.ToolStripButton1.Text = "Add To Print Preview List"
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = Global.General_Ledger.My.Resources.Resources.Preview
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(96, 22)
        Me.ToolStripButton2.Text = "Print Preview"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Image = Global.General_Ledger.My.Resources.Resources.Delete
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(147, 22)
        Me.ToolStripButton3.Text = "Clear Print Preview List"
        '
        'ToolStripButton4
        '
        Me.ToolStripButton4.Image = Global.General_Ledger.My.Resources.Resources.excel_icon
        Me.ToolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton4.Name = "ToolStripButton4"
        Me.ToolStripButton4.Size = New System.Drawing.Size(103, 22)
        Me.ToolStripButton4.Text = "Export to Excel"
        '
        'ToolStripButton5
        '
        Me.ToolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton5.Name = "ToolStripButton5"
        Me.ToolStripButton5.Size = New System.Drawing.Size(82, 22)
        Me.ToolStripButton5.Text = "Export to PDF"
        '
        'radioExpandAll
        '
        Me.radioExpandAll.AutoSize = True
        Me.radioExpandAll.Location = New System.Drawing.Point(710, 5)
        Me.radioExpandAll.Name = "radioExpandAll"
        Me.radioExpandAll.Size = New System.Drawing.Size(75, 17)
        Me.radioExpandAll.TabIndex = 5
        Me.radioExpandAll.Text = "Expand All"
        Me.radioExpandAll.UseVisualStyleBackColor = True
        '
        'radioCollapseAll
        '
        Me.radioCollapseAll.AutoSize = True
        Me.radioCollapseAll.Checked = True
        Me.radioCollapseAll.Location = New System.Drawing.Point(625, 5)
        Me.radioCollapseAll.Name = "radioCollapseAll"
        Me.radioCollapseAll.Size = New System.Drawing.Size(79, 17)
        Me.radioCollapseAll.TabIndex = 6
        Me.radioCollapseAll.TabStop = True
        Me.radioCollapseAll.Text = "Collapse All"
        Me.radioCollapseAll.UseVisualStyleBackColor = True
        '
        'grdList
        '
        Me.grdList.AllowFilter = False
        Me.grdList.AllowUpdate = False
        Me.grdList.AllowUpdateOnBlur = False
        Me.grdList.AlternatingRows = True
        Me.grdList.CaptionHeight = 17
        Me.grdList.DataView = C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy
        Me.grdList.EmptyRows = True
        Me.grdList.FilterBar = True
        Me.grdList.GroupByCaption = "Drag a column header here to group by that column"
        Me.grdList.Images.Add(CType(resources.GetObject("grdList.Images"), System.Drawing.Image))
        Me.grdList.Location = New System.Drawing.Point(12, 28)
        Me.grdList.MarqueeStyle = C1.Win.C1TrueDBGrid.MarqueeEnum.HighlightRow
        Me.grdList.Name = "grdList"
        Me.grdList.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.grdList.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.grdList.PreviewInfo.ZoomFactor = 75
        Me.grdList.PrintInfo.PageSettings = CType(resources.GetObject("grdList.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.grdList.RowHeight = 20
        Me.grdList.Size = New System.Drawing.Size(773, 339)
        Me.grdList.TabIndex = 3
        Me.grdList.Text = "C1TrueDBGrid1"
        Me.grdList.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Blue
        Me.grdList.PropBag = resources.GetString("grdList.PropBag")
        '
        'frmList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(793, 412)
        Me.Controls.Add(Me.radioCollapseAll)
        Me.Controls.Add(Me.radioExpandAll)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.grdList)
        Me.Controls.Add(Me.cmdSelect)
        Me.Controls.Add(Me.cmdExit)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "frmList"
        Me.ShowInTaskbar = False
        Me.Text = "Search"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.grdList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdSelect As System.Windows.Forms.Button
    Friend WithEvents grdList As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents radioExpandAll As System.Windows.Forms.RadioButton
    Friend WithEvents radioCollapseAll As System.Windows.Forms.RadioButton
    Friend WithEvents ToolStripButton4 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton5 As System.Windows.Forms.ToolStripButton
End Class
