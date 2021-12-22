<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPreview
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
        Me.arv = New DataDynamics.ActiveReports.Viewer.Viewer
        Me.cmdExportPDFPrint = New System.Windows.Forms.Button
        Me.dlgPrint = New System.Windows.Forms.PrintDialog
        Me.PrintDocument = New System.Drawing.Printing.PrintDocument
        Me.SuspendLayout()
        '
        'arv
        '
        Me.arv.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.arv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.arv.Document = New DataDynamics.ActiveReports.Document.Document("ARNet Document")
        Me.arv.Location = New System.Drawing.Point(0, 0)
        Me.arv.Name = "arv"
        Me.arv.ReportViewer.CurrentPage = 0
        Me.arv.ReportViewer.MultiplePageCols = 3
        Me.arv.ReportViewer.MultiplePageRows = 2
        Me.arv.ReportViewer.RulerVisible = False
        Me.arv.ReportViewer.ViewType = DataDynamics.ActiveReports.Viewer.ViewType.Normal
        Me.arv.Size = New System.Drawing.Size(857, 667)
        Me.arv.TabIndex = 0
        Me.arv.TableOfContents.Text = "Table Of Contents"
        Me.arv.TableOfContents.Width = 200
        Me.arv.TabTitleLength = 35
        Me.arv.Toolbar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        '
        'cmdExportPDFPrint
        '
        Me.cmdExportPDFPrint.Location = New System.Drawing.Point(718, 2)
        Me.cmdExportPDFPrint.Name = "cmdExportPDFPrint"
        Me.cmdExportPDFPrint.Size = New System.Drawing.Size(133, 23)
        Me.cmdExportPDFPrint.TabIndex = 4
        Me.cmdExportPDFPrint.Text = "Export to PDF && Print"
        Me.cmdExportPDFPrint.UseVisualStyleBackColor = True
        '
        'frmPreview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(857, 667)
        Me.Controls.Add(Me.cmdExportPDFPrint)
        Me.Controls.Add(Me.arv)
        Me.Name = "frmPreview"
        Me.Text = "Preview"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents arv As DataDynamics.ActiveReports.Viewer.Viewer
    Friend WithEvents cmdExportPDFPrint As System.Windows.Forms.Button
    Private WithEvents dlgPrint As System.Windows.Forms.PrintDialog
    Private WithEvents PrintDocument As System.Drawing.Printing.PrintDocument
End Class
