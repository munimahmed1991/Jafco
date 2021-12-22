<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmC1Preview
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmC1Preview))
        Me.CPPC = New C1.Win.C1Preview.C1PrintPreviewControl
        Me.Button1 = New System.Windows.Forms.Button
        CType(Me.CPPC, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CPPC.PreviewPane, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CPPC.SuspendLayout()
        Me.SuspendLayout()
        '
        'CPPC
        '
        Me.CPPC.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPPC.ImageSet = C1.Win.C1Preview.ImageSetEnum.XP2
        Me.CPPC.Location = New System.Drawing.Point(0, 0)
        Me.CPPC.Name = "CPPC"
        '
        'CPPC.OutlineView
        '
        Me.CPPC.PreviewOutlineView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPPC.PreviewOutlineView.Location = New System.Drawing.Point(0, 0)
        Me.CPPC.PreviewOutlineView.Name = "OutlineView"
        Me.CPPC.PreviewOutlineView.Size = New System.Drawing.Size(165, 427)
        Me.CPPC.PreviewOutlineView.TabIndex = 0
        '
        'CPPC.PreviewPane
        '
        Me.CPPC.PreviewPane.IntegrateExternalTools = True
        Me.CPPC.PreviewPane.TabIndex = 0
        '
        'CPPC.PreviewTextSearchPanel
        '
        Me.CPPC.PreviewTextSearchPanel.Dock = System.Windows.Forms.DockStyle.Right
        Me.CPPC.PreviewTextSearchPanel.Location = New System.Drawing.Point(530, 0)
        Me.CPPC.PreviewTextSearchPanel.MinimumSize = New System.Drawing.Size(200, 240)
        Me.CPPC.PreviewTextSearchPanel.Name = "PreviewTextSearchPanel"
        Me.CPPC.PreviewTextSearchPanel.Size = New System.Drawing.Size(200, 453)
        Me.CPPC.PreviewTextSearchPanel.TabIndex = 0
        Me.CPPC.PreviewTextSearchPanel.Visible = False
        '
        'CPPC.ThumbnailView
        '
        Me.CPPC.PreviewThumbnailView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.CPPC.PreviewThumbnailView.HideSelection = False
        Me.CPPC.PreviewThumbnailView.Location = New System.Drawing.Point(0, 0)
        Me.CPPC.PreviewThumbnailView.Name = "ThumbnailView"
        Me.CPPC.PreviewThumbnailView.OwnerDraw = True
        Me.CPPC.PreviewThumbnailView.Size = New System.Drawing.Size(165, 475)
        Me.CPPC.PreviewThumbnailView.TabIndex = 0
        Me.CPPC.PreviewThumbnailView.ThumbnailSize = New System.Drawing.Size(96, 96)
        Me.CPPC.PreviewThumbnailView.UseImageAsThumbnail = False
        Me.CPPC.Size = New System.Drawing.Size(648, 548)
        Me.CPPC.TabIndex = 0
        Me.CPPC.Text = "C1PrintPreviewControl1"
        '
        '
        '
        Me.CPPC.ToolBars.File.Open.Image = CType(resources.GetObject("CPPC.ToolBars.File.Open.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.File.Open.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.File.Open.Name = "btnFileOpen"
        Me.CPPC.ToolBars.File.Open.Size = New System.Drawing.Size(32, 22)
        Me.CPPC.ToolBars.File.Open.Tag = "C1PreviewActionEnum.FileOpen"
        Me.CPPC.ToolBars.File.Open.ToolTipText = "Open File"
        '
        '
        '
        Me.CPPC.ToolBars.File.PageSetup.Image = CType(resources.GetObject("CPPC.ToolBars.File.PageSetup.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.File.PageSetup.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.File.PageSetup.Name = "btnPageSetup"
        Me.CPPC.ToolBars.File.PageSetup.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.File.PageSetup.Tag = "C1PreviewActionEnum.PageSetup"
        Me.CPPC.ToolBars.File.PageSetup.ToolTipText = "Page Setup"
        '
        '
        '
        Me.CPPC.ToolBars.File.Print.Image = CType(resources.GetObject("CPPC.ToolBars.File.Print.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.File.Print.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.File.Print.Name = "btnPrint"
        Me.CPPC.ToolBars.File.Print.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.File.Print.Tag = "C1PreviewActionEnum.Print"
        Me.CPPC.ToolBars.File.Print.ToolTipText = "Print"
        '
        '
        '
        Me.CPPC.ToolBars.File.Reflow.Image = CType(resources.GetObject("CPPC.ToolBars.File.Reflow.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.File.Reflow.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.File.Reflow.Name = "btnReflow"
        Me.CPPC.ToolBars.File.Reflow.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.File.Reflow.Tag = "C1PreviewActionEnum.Reflow"
        Me.CPPC.ToolBars.File.Reflow.ToolTipText = "Reflow"
        '
        '
        '
        Me.CPPC.ToolBars.File.Save.Image = CType(resources.GetObject("CPPC.ToolBars.File.Save.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.File.Save.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.File.Save.Name = "btnFileSave"
        Me.CPPC.ToolBars.File.Save.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.File.Save.Tag = "C1PreviewActionEnum.FileSave"
        Me.CPPC.ToolBars.File.Save.ToolTipText = "Save File"
        '
        '
        '
        Me.CPPC.ToolBars.Navigation.GoFirst.Image = CType(resources.GetObject("CPPC.ToolBars.Navigation.GoFirst.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Navigation.GoFirst.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Navigation.GoFirst.Name = "btnGoFirst"
        Me.CPPC.ToolBars.Navigation.GoFirst.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Navigation.GoFirst.Tag = "C1PreviewActionEnum.GoFirst"
        Me.CPPC.ToolBars.Navigation.GoFirst.ToolTipText = "Go To First Page"
        '
        '
        '
        Me.CPPC.ToolBars.Navigation.GoLast.Image = CType(resources.GetObject("CPPC.ToolBars.Navigation.GoLast.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Navigation.GoLast.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Navigation.GoLast.Name = "btnGoLast"
        Me.CPPC.ToolBars.Navigation.GoLast.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Navigation.GoLast.Tag = "C1PreviewActionEnum.GoLast"
        Me.CPPC.ToolBars.Navigation.GoLast.ToolTipText = "Go To Last Page"
        '
        '
        '
        Me.CPPC.ToolBars.Navigation.GoNext.Image = CType(resources.GetObject("CPPC.ToolBars.Navigation.GoNext.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Navigation.GoNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Navigation.GoNext.Name = "btnGoNext"
        Me.CPPC.ToolBars.Navigation.GoNext.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Navigation.GoNext.Tag = "C1PreviewActionEnum.GoNext"
        Me.CPPC.ToolBars.Navigation.GoNext.ToolTipText = "Go To Next Page"
        '
        '
        '
        Me.CPPC.ToolBars.Navigation.GoPrev.Image = CType(resources.GetObject("CPPC.ToolBars.Navigation.GoPrev.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Navigation.GoPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Navigation.GoPrev.Name = "btnGoPrev"
        Me.CPPC.ToolBars.Navigation.GoPrev.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Navigation.GoPrev.Tag = "C1PreviewActionEnum.GoPrev"
        Me.CPPC.ToolBars.Navigation.GoPrev.ToolTipText = "Go To Previous Page"
        '
        '
        '
        Me.CPPC.ToolBars.Navigation.HistoryNext.Image = CType(resources.GetObject("CPPC.ToolBars.Navigation.HistoryNext.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Navigation.HistoryNext.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Navigation.HistoryNext.Name = "btnHistoryNext"
        Me.CPPC.ToolBars.Navigation.HistoryNext.Size = New System.Drawing.Size(32, 22)
        Me.CPPC.ToolBars.Navigation.HistoryNext.Tag = "C1PreviewActionEnum.HistoryNext"
        Me.CPPC.ToolBars.Navigation.HistoryNext.ToolTipText = "Next View"
        '
        '
        '
        Me.CPPC.ToolBars.Navigation.HistoryPrev.Image = CType(resources.GetObject("CPPC.ToolBars.Navigation.HistoryPrev.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Navigation.HistoryPrev.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Navigation.HistoryPrev.Name = "btnHistoryPrev"
        Me.CPPC.ToolBars.Navigation.HistoryPrev.Size = New System.Drawing.Size(32, 22)
        Me.CPPC.ToolBars.Navigation.HistoryPrev.Tag = "C1PreviewActionEnum.HistoryPrev"
        Me.CPPC.ToolBars.Navigation.HistoryPrev.ToolTipText = "Previous View"
        Me.CPPC.ToolBars.Navigation.ToolTipPageNo = Nothing
        '
        '
        '
        Me.CPPC.ToolBars.Page.Continuous.Checked = True
        Me.CPPC.ToolBars.Page.Continuous.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CPPC.ToolBars.Page.Continuous.Image = CType(resources.GetObject("CPPC.ToolBars.Page.Continuous.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Page.Continuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Page.Continuous.Name = "btnPageContinuous"
        Me.CPPC.ToolBars.Page.Continuous.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Page.Continuous.Tag = "C1PreviewActionEnum.PageContinuous"
        Me.CPPC.ToolBars.Page.Continuous.ToolTipText = "Continuous View"
        '
        '
        '
        Me.CPPC.ToolBars.Page.Facing.Image = CType(resources.GetObject("CPPC.ToolBars.Page.Facing.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Page.Facing.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Page.Facing.Name = "btnPageFacing"
        Me.CPPC.ToolBars.Page.Facing.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Page.Facing.Tag = "C1PreviewActionEnum.PageFacing"
        Me.CPPC.ToolBars.Page.Facing.ToolTipText = "Pages Facing View"
        '
        '
        '
        Me.CPPC.ToolBars.Page.FacingContinuous.Image = CType(resources.GetObject("CPPC.ToolBars.Page.FacingContinuous.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Page.FacingContinuous.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Page.FacingContinuous.Name = "btnPageFacingContinuous"
        Me.CPPC.ToolBars.Page.FacingContinuous.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Page.FacingContinuous.Tag = "C1PreviewActionEnum.PageFacingContinuous"
        Me.CPPC.ToolBars.Page.FacingContinuous.ToolTipText = "Pages Facing Continuous View"
        '
        '
        '
        Me.CPPC.ToolBars.Page.Single.Image = CType(resources.GetObject("CPPC.ToolBars.Page.Single.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Page.Single.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Page.Single.Name = "btnPageSingle"
        Me.CPPC.ToolBars.Page.Single.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Page.Single.Tag = "C1PreviewActionEnum.PageSingle"
        Me.CPPC.ToolBars.Page.Single.ToolTipText = "Single Page View"
        '
        '
        '
        Me.CPPC.ToolBars.Text.Find.Image = CType(resources.GetObject("CPPC.ToolBars.Text.Find.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Text.Find.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Text.Find.Name = "btnFind"
        Me.CPPC.ToolBars.Text.Find.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Text.Find.Tag = "C1PreviewActionEnum.Find"
        Me.CPPC.ToolBars.Text.Find.ToolTipText = "Find Text"
        '
        '
        '
        Me.CPPC.ToolBars.Text.Hand.Checked = True
        Me.CPPC.ToolBars.Text.Hand.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CPPC.ToolBars.Text.Hand.Image = CType(resources.GetObject("CPPC.ToolBars.Text.Hand.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Text.Hand.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Text.Hand.Name = "btnHandTool"
        Me.CPPC.ToolBars.Text.Hand.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Text.Hand.Tag = "C1PreviewActionEnum.HandTool"
        Me.CPPC.ToolBars.Text.Hand.ToolTipText = "Hand Tool"
        '
        '
        '
        Me.CPPC.ToolBars.Text.SelectText.Image = CType(resources.GetObject("CPPC.ToolBars.Text.SelectText.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Text.SelectText.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Text.SelectText.Name = "btnSelectTextTool"
        Me.CPPC.ToolBars.Text.SelectText.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Text.SelectText.Tag = "C1PreviewActionEnum.SelectTextTool"
        Me.CPPC.ToolBars.Text.SelectText.ToolTipText = "Text Select Tool"
        Me.CPPC.ToolBars.Zoom.ToolTipZoomFactor = Nothing
        '
        '
        '
        Me.CPPC.ToolBars.Zoom.ZoomIn.Image = CType(resources.GetObject("CPPC.ToolBars.Zoom.ZoomIn.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Zoom.ZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Zoom.ZoomIn.Name = "btnZoomIn"
        Me.CPPC.ToolBars.Zoom.ZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Zoom.ZoomIn.Tag = "C1PreviewActionEnum.ZoomIn"
        Me.CPPC.ToolBars.Zoom.ZoomIn.ToolTipText = "Zoom In"
        '
        '
        '
        Me.CPPC.ToolBars.Zoom.ZoomOut.Image = CType(resources.GetObject("CPPC.ToolBars.Zoom.ZoomOut.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Zoom.ZoomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Zoom.ZoomOut.Name = "btnZoomOut"
        Me.CPPC.ToolBars.Zoom.ZoomOut.Size = New System.Drawing.Size(23, 22)
        Me.CPPC.ToolBars.Zoom.ZoomOut.Tag = "C1PreviewActionEnum.ZoomOut"
        Me.CPPC.ToolBars.Zoom.ZoomOut.ToolTipText = "Zoom Out"
        '
        '
        '
        Me.CPPC.ToolBars.Zoom.ZoomTool.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CPPC.ToolBars.Zoom.ZoomInTool, Me.CPPC.ToolBars.Zoom.ZoomOutTool})
        Me.CPPC.ToolBars.Zoom.ZoomTool.Image = CType(resources.GetObject("CPPC.ToolBars.Zoom.ZoomTool.Image"), System.Drawing.Image)
        Me.CPPC.ToolBars.Zoom.ZoomTool.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CPPC.ToolBars.Zoom.ZoomTool.Name = "btnZoomTool"
        Me.CPPC.ToolBars.Zoom.ZoomTool.Size = New System.Drawing.Size(32, 22)
        Me.CPPC.ToolBars.Zoom.ZoomTool.Tag = "C1PreviewActionEnum.ZoomInTool"
        Me.CPPC.ToolBars.Zoom.ZoomTool.ToolTipText = "Zoom In Tool"
        '
        'Button1
        '
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Location = New System.Drawing.Point(3, 506)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 14)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmC1Preview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(648, 548)
        Me.Controls.Add(Me.CPPC)
        Me.Name = "FrmC1Preview"
        Me.Text = "Print Preview"
        CType(Me.CPPC.PreviewPane, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CPPC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CPPC.ResumeLayout(False)
        Me.CPPC.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CPPC As C1.Win.C1Preview.C1PrintPreviewControl
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
