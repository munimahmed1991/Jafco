Imports GrapeCity.ActiveReports
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPreview
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.arv = New GrapeCity.ActiveReports.Viewer.Win.Viewer()
        Me.cmdExportPDFPrint = New System.Windows.Forms.Button()
        Me.dlgPrint = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'arv
        '
        Me.arv.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.arv.CurrentPage = 0
        Me.arv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arv.Location = New System.Drawing.Point(0, 0)
        Me.arv.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.arv.Name = "arv"
        Me.arv.PreviewPages = 0
        '
        '
        '
        '
        '
        '
        Me.arv.Sidebar.ParametersPanel.ContextMenu = Nothing
        Me.arv.Sidebar.ParametersPanel.Width = 200
        '
        '
        '
        Me.arv.Sidebar.SearchPanel.ContextMenu = Nothing
        Me.arv.Sidebar.SearchPanel.Width = 200
        '
        '
        '
        Me.arv.Sidebar.ThumbnailsPanel.ContextMenu = Nothing
        Me.arv.Sidebar.ThumbnailsPanel.Width = 200
        Me.arv.Sidebar.ThumbnailsPanel.Zoom = 0.1R
        '
        '
        '
        Me.arv.Sidebar.TocPanel.ContextMenu = Nothing
        Me.arv.Sidebar.TocPanel.Expanded = True
        Me.arv.Sidebar.TocPanel.Text = "Table Of Contents"
        Me.arv.Sidebar.TocPanel.Width = 200
        Me.arv.Sidebar.Width = 200
        Me.arv.Size = New System.Drawing.Size(1143, 821)
        Me.arv.TabIndex = 0
        Me.arv.TouchMode = GrapeCity.Viewer.Common.Model.TouchMode.[Auto]
        '
        'cmdExportPDFPrint
        '
        Me.cmdExportPDFPrint.Location = New System.Drawing.Point(1063, 2)
        Me.cmdExportPDFPrint.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmdExportPDFPrint.Name = "cmdExportPDFPrint"
        Me.cmdExportPDFPrint.Size = New System.Drawing.Size(71, 28)
        Me.cmdExportPDFPrint.TabIndex = 4
        Me.cmdExportPDFPrint.Text = "PDF"
        Me.cmdExportPDFPrint.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(984, 2)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 28)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "EXCEL"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(905, 2)
        Me.Button2.Margin = New System.Windows.Forms.Padding(4)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(71, 28)
        Me.Button2.TabIndex = 4
        Me.Button2.Text = "HTML"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1143, 821)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdExportPDFPrint)
        Me.Controls.Add(Me.arv)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmPreview"
        Me.Text = "Preview"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents arv As GrapeCity.ActiveReports.Viewer.Win.Viewer
    Friend WithEvents cmdExportPDFPrint As System.Windows.Forms.Button
    Private WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Private WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
