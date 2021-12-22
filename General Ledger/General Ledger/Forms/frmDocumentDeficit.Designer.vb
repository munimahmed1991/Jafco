<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDocumentDeficit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDocumentDeficit))
        Me.tdbGridLetters = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        CType(Me.tdbGridLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tdbGridLetters
        '
        Me.tdbGridLetters.AllowAddNew = True
        Me.tdbGridLetters.AllowDelete = True
        Me.tdbGridLetters.ColumnFooters = True
        Me.tdbGridLetters.EmptyRows = True
        Me.tdbGridLetters.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbGridLetters.Images.Add(CType(resources.GetObject("tdbGridLetters.Images"), System.Drawing.Image))
        Me.tdbGridLetters.Location = New System.Drawing.Point(7, 29)
        Me.tdbGridLetters.Name = "tdbGridLetters"
        Me.tdbGridLetters.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbGridLetters.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbGridLetters.PreviewInfo.ZoomFactor = 75
        Me.tdbGridLetters.PrintInfo.PageSettings = CType(resources.GetObject("tdbGridLetters.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbGridLetters.RecordSelectors = False
        Me.tdbGridLetters.Size = New System.Drawing.Size(958, 450)
        Me.tdbGridLetters.TabIndex = 243
        Me.tdbGridLetters.Text = "C1TrueDBGrid1"
        Me.tdbGridLetters.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdbGridLetters.WrapCellPointer = True
        Me.tdbGridLetters.PropBag = resources.GetString("tdbGridLetters.PropBag")
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(883, 3)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(75, 23)
        Me.cmdGenerate.TabIndex = 244
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(889, 485)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 245
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(812, 485)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(75, 23)
        Me.cmdSave.TabIndex = 246
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.UseVisualStyleBackColor = True
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
        Me.cmbProject.Location = New System.Drawing.Point(52, 3)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 247
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 248
        Me.Label3.Text = "Project"
        '
        'frmDocumentDeficit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(970, 512)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.tdbGridLetters)
        Me.Name = "frmDocumentDeficit"
        Me.Text = "Document Deficit"
        CType(Me.tdbGridLetters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tdbGridLetters As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
