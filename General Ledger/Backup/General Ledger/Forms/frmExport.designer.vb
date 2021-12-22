<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmExport
    Inherits System.Windows.Forms.Form
    Private pnlTop As System.Windows.Forms.Panel
    Private pnlBottom As System.Windows.Forms.Panel
    Private lblTitle As System.Windows.Forms.Label
    Private lblSubTitle As System.Windows.Forms.Label
    Private pnlFill As System.Windows.Forms.Panel
    Private WithEvents cboExportFormat As System.Windows.Forms.ComboBox
    Private lblExportFormat As System.Windows.Forms.Label
    Private lblFilename As System.Windows.Forms.Label
    Private txtFilename As System.Windows.Forms.TextBox
    Private WithEvents btnSaveFile As System.Windows.Forms.Button


    Private WithEvents btnOk As System.Windows.Forms.Button
    Private WithEvents btnCancel As System.Windows.Forms.Button
    Private pnlOptions As System.Windows.Forms.Panel

    'Required designer variable.
    Private components As System.ComponentModel.Container = Nothing
    Private PropertyGridExport As System.Windows.Forms.PropertyGrid

    Private export As Object = Nothing

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.pnlTop = New System.Windows.Forms.Panel
        Me.lblSubTitle = New System.Windows.Forms.Label
        Me.lblTitle = New System.Windows.Forms.Label
        Me.pnlBottom = New System.Windows.Forms.Panel
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOk = New System.Windows.Forms.Button
        Me.pnlFill = New System.Windows.Forms.Panel
        Me.pnlOptions = New System.Windows.Forms.Panel
        Me.PropertyGridExport = New System.Windows.Forms.PropertyGrid
        Me.btnSaveFile = New System.Windows.Forms.Button
        Me.txtFilename = New System.Windows.Forms.TextBox
        Me.lblFilename = New System.Windows.Forms.Label
        Me.lblExportFormat = New System.Windows.Forms.Label
        Me.cboExportFormat = New System.Windows.Forms.ComboBox
        Me.pnlTop.SuspendLayout()
        Me.pnlBottom.SuspendLayout()
        Me.pnlFill.SuspendLayout()
        Me.pnlOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlTop
        '
        Me.pnlTop.BackColor = System.Drawing.SystemColors.Window
        Me.pnlTop.Controls.Add(Me.lblSubTitle)
        Me.pnlTop.Controls.Add(Me.lblTitle)
        Me.pnlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.pnlTop.Location = New System.Drawing.Point(0, 0)
        Me.pnlTop.Name = "pnlTop"
        Me.pnlTop.Size = New System.Drawing.Size(458, 48)
        Me.pnlTop.TabIndex = 0
        '
        'lblSubTitle
        '
        Me.lblSubTitle.Location = New System.Drawing.Point(16, 24)
        Me.lblSubTitle.Name = "lblSubTitle"
        Me.lblSubTitle.Size = New System.Drawing.Size(360, 16)
        Me.lblSubTitle.TabIndex = 1
        Me.lblSubTitle.Text = "Select the export format and set export options."
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(0, 0)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(240, 20)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Export Report Document"
        '
        'pnlBottom
        '
        Me.pnlBottom.Controls.Add(Me.btnCancel)
        Me.pnlBottom.Controls.Add(Me.btnOk)
        Me.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlBottom.Location = New System.Drawing.Point(0, 200)
        Me.pnlBottom.Name = "pnlBottom"
        Me.pnlBottom.Size = New System.Drawing.Size(458, 40)
        Me.pnlBottom.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(360, 8)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(80, 24)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "&Cancel"
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(264, 8)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(80, 24)
        Me.btnOk.TabIndex = 0
        Me.btnOk.Text = "&OK"
        '
        'pnlFill
        '
        Me.pnlFill.Controls.Add(Me.pnlOptions)
        Me.pnlFill.Controls.Add(Me.btnSaveFile)
        Me.pnlFill.Controls.Add(Me.txtFilename)
        Me.pnlFill.Controls.Add(Me.lblFilename)
        Me.pnlFill.Controls.Add(Me.lblExportFormat)
        Me.pnlFill.Controls.Add(Me.cboExportFormat)
        Me.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pnlFill.Location = New System.Drawing.Point(0, 48)
        Me.pnlFill.Name = "pnlFill"
        Me.pnlFill.Size = New System.Drawing.Size(458, 152)
        Me.pnlFill.TabIndex = 2
        '
        'pnlOptions
        '
        Me.pnlOptions.Controls.Add(Me.PropertyGridExport)
        Me.pnlOptions.Location = New System.Drawing.Point(8, 56)
        Me.pnlOptions.Name = "pnlOptions"
        Me.pnlOptions.Size = New System.Drawing.Size(440, 88)
        Me.pnlOptions.TabIndex = 5
        '
        'PropertyGridExport
        '
        Me.PropertyGridExport.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PropertyGridExport.HelpVisible = False
        Me.PropertyGridExport.LineColor = System.Drawing.SystemColors.ScrollBar
        Me.PropertyGridExport.Location = New System.Drawing.Point(0, 0)
        Me.PropertyGridExport.Name = "PropertyGridExport"
        Me.PropertyGridExport.PropertySort = System.Windows.Forms.PropertySort.NoSort
        Me.PropertyGridExport.Size = New System.Drawing.Size(440, 88)
        Me.PropertyGridExport.TabIndex = 0
        Me.PropertyGridExport.ToolbarVisible = False
        '
        'btnSaveFile
        '
        Me.btnSaveFile.Location = New System.Drawing.Point(416, 32)
        Me.btnSaveFile.Name = "btnSaveFile"
        Me.btnSaveFile.Size = New System.Drawing.Size(32, 20)
        Me.btnSaveFile.TabIndex = 4
        Me.btnSaveFile.Text = "..."
        '
        'txtFilename
        '
        Me.txtFilename.Location = New System.Drawing.Point(96, 32)
        Me.txtFilename.Name = "txtFilename"
        Me.txtFilename.Size = New System.Drawing.Size(320, 20)
        Me.txtFilename.TabIndex = 3
        '
        'lblFilename
        '
        Me.lblFilename.Location = New System.Drawing.Point(8, 34)
        Me.lblFilename.Name = "lblFilename"
        Me.lblFilename.Size = New System.Drawing.Size(80, 16)
        Me.lblFilename.TabIndex = 2
        Me.lblFilename.Text = "Filename:"
        '
        'lblExportFormat
        '
        Me.lblExportFormat.Location = New System.Drawing.Point(8, 10)
        Me.lblExportFormat.Name = "lblExportFormat"
        Me.lblExportFormat.Size = New System.Drawing.Size(80, 16)
        Me.lblExportFormat.TabIndex = 1
        Me.lblExportFormat.Text = "Export Format:"
        '
        'cboExportFormat
        '
        Me.cboExportFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboExportFormat.Items.AddRange(New Object() {"HTML Format (HTM)", "Portable Document Format (PDF)", "Rich Text Format (RTF)", "TIFF Format (TIF)", "Text Format (TXT)", "Microsoft Excel (XLS)"})
        Me.cboExportFormat.Location = New System.Drawing.Point(96, 8)
        Me.cboExportFormat.Name = "cboExportFormat"
        Me.cboExportFormat.Size = New System.Drawing.Size(352, 21)
        Me.cboExportFormat.TabIndex = 0
        '
        'frmExport
        '
        Me.AcceptButton = Me.btnOk
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(458, 240)
        Me.Controls.Add(Me.pnlFill)
        Me.Controls.Add(Me.pnlBottom)
        Me.Controls.Add(Me.pnlTop)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmExport"
        Me.ShowInTaskbar = False
        Me.Text = "Export Report Document"
        Me.pnlTop.ResumeLayout(False)
        Me.pnlBottom.ResumeLayout(False)
        Me.pnlFill.ResumeLayout(False)
        Me.pnlFill.PerformLayout()
        Me.pnlOptions.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
End Class
