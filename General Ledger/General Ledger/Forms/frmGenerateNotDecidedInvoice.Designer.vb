<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateNotDecidedInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerateNotDecidedInvoice))
        Me.Label8 = New System.Windows.Forms.Label
        Me.cmdUnit = New System.Windows.Forms.Button
        Me.cmbUnit = New C1.Win.C1List.C1Combo
        Me.cmdProjectType = New System.Windows.Forms.Button
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtInvoiceDate = New C1.Win.C1Input.C1DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.cmbBlock = New C1.Win.C1List.C1Combo
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmbPaymentType = New C1.Win.C1List.C1Combo
        Me.Label24 = New System.Windows.Forms.Label
        Me.cmdPaymentType = New System.Windows.Forms.Button
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(360, 129)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 269
        Me.Label8.Text = "Unit #"
        '
        'cmdUnit
        '
        Me.cmdUnit.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnit.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnit.Location = New System.Drawing.Point(641, 155)
        Me.cmdUnit.Name = "cmdUnit"
        Me.cmdUnit.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnit.TabIndex = 268
        Me.cmdUnit.UseVisualStyleBackColor = True
        '
        'cmbUnit
        '
        Me.cmbUnit.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnit.Caption = ""
        Me.cmbUnit.CaptionHeight = 17
        Me.cmbUnit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnit.ColumnCaptionHeight = 17
        Me.cmbUnit.ColumnFooterHeight = 17
        Me.cmbUnit.ContentHeight = 15
        Me.cmbUnit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.EditorHeight = 15
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.Images.Add(CType(resources.GetObject("cmbUnit.Images"), System.Drawing.Image))
        Me.cmbUnit.ItemHeight = 15
        Me.cmbUnit.Location = New System.Drawing.Point(360, 155)
        Me.cmbUnit.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnit.MaxDropDownItems = CType(5, Short)
        Me.cmbUnit.MaxLength = 32767
        Me.cmbUnit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.ReadOnly = True
        Me.cmbUnit.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbUnit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnit.Size = New System.Drawing.Size(278, 21)
        Me.cmbUnit.TabIndex = 267
        Me.cmbUnit.PropBag = resources.GetString("cmbUnit.PropBag")
        '
        'cmdProjectType
        '
        Me.cmdProjectType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdProjectType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdProjectType.Location = New System.Drawing.Point(290, 156)
        Me.cmdProjectType.Name = "cmdProjectType"
        Me.cmdProjectType.Size = New System.Drawing.Size(22, 21)
        Me.cmdProjectType.TabIndex = 266
        Me.cmdProjectType.UseVisualStyleBackColor = True
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
        Me.cmbUnitType.Location = New System.Drawing.Point(12, 156)
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
        Me.cmbUnitType.TabIndex = 264
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(12, 129)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 265
        Me.Label6.Text = "Unit Type"
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
        Me.cmbProject.Location = New System.Drawing.Point(12, 94)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 262
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(12, 67)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 263
        Me.Label5.Text = "Project"
        '
        'txtInvoiceDate
        '
        Me.txtInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtInvoiceDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtInvoiceDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtInvoiceDate.Calendar.ClearText = "&Clear"
        Me.txtInvoiceDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtInvoiceDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtInvoiceDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtInvoiceDate.Calendar.TodayText = "&Today"
        Me.txtInvoiceDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtInvoiceDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtInvoiceDate.Culture = 1056
        Me.txtInvoiceDate.CustomFormat = "dd/MM/yyyy"
        Me.txtInvoiceDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtInvoiceDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtInvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtInvoiceDate.Location = New System.Drawing.Point(12, 31)
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Size = New System.Drawing.Size(126, 19)
        Me.txtInvoiceDate.TabIndex = 261
        Me.txtInvoiceDate.Tag = Nothing
        Me.txtInvoiceDate.TrimEnd = False
        Me.txtInvoiceDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtInvoiceDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtInvoiceDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 260
        Me.Label4.Text = "Invoice Date"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(587, 299)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 271
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(509, 299)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(75, 23)
        Me.cmdGenerate.TabIndex = 270
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'cmbBlock
        '
        Me.cmbBlock.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbBlock.Caption = ""
        Me.cmbBlock.CaptionHeight = 17
        Me.cmbBlock.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbBlock.ColumnCaptionHeight = 17
        Me.cmbBlock.ColumnFooterHeight = 17
        Me.cmbBlock.ContentHeight = 15
        Me.cmbBlock.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbBlock.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbBlock.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbBlock.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbBlock.EditorHeight = 15
        Me.cmbBlock.Images.Add(CType(resources.GetObject("cmbBlock.Images"), System.Drawing.Image))
        Me.cmbBlock.ItemHeight = 15
        Me.cmbBlock.Location = New System.Drawing.Point(360, 94)
        Me.cmbBlock.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBlock.MaxDropDownItems = CType(5, Short)
        Me.cmbBlock.MaxLength = 32767
        Me.cmbBlock.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBlock.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBlock.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBlock.Size = New System.Drawing.Size(256, 21)
        Me.cmbBlock.TabIndex = 272
        Me.cmbBlock.PropBag = resources.GetString("cmbBlock.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(357, 67)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 273
        Me.Label7.Text = "Block"
        '
        'cmbPaymentType
        '
        Me.cmbPaymentType.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbPaymentType.Caption = ""
        Me.cmbPaymentType.CaptionHeight = 17
        Me.cmbPaymentType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbPaymentType.ColumnCaptionHeight = 17
        Me.cmbPaymentType.ColumnFooterHeight = 17
        Me.cmbPaymentType.ContentHeight = 15
        Me.cmbPaymentType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbPaymentType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbPaymentType.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbPaymentType.EditorHeight = 15
        Me.cmbPaymentType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbPaymentType.Images.Add(CType(resources.GetObject("cmbPaymentType.Images"), System.Drawing.Image))
        Me.cmbPaymentType.ItemHeight = 15
        Me.cmbPaymentType.Location = New System.Drawing.Point(12, 226)
        Me.cmbPaymentType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbPaymentType.MaxDropDownItems = CType(5, Short)
        Me.cmbPaymentType.MaxLength = 32767
        Me.cmbPaymentType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbPaymentType.Name = "cmbPaymentType"
        Me.cmbPaymentType.ReadOnly = True
        Me.cmbPaymentType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbPaymentType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbPaymentType.Size = New System.Drawing.Size(278, 21)
        Me.cmbPaymentType.TabIndex = 274
        Me.cmbPaymentType.PropBag = resources.GetString("cmbPaymentType.PropBag")
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(12, 205)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(75, 13)
        Me.Label24.TabIndex = 275
        Me.Label24.Text = "Payment Type"
        '
        'cmdPaymentType
        '
        Me.cmdPaymentType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdPaymentType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdPaymentType.Location = New System.Drawing.Point(290, 226)
        Me.cmdPaymentType.Name = "cmdPaymentType"
        Me.cmdPaymentType.Size = New System.Drawing.Size(22, 21)
        Me.cmdPaymentType.TabIndex = 276
        Me.cmdPaymentType.UseVisualStyleBackColor = True
        '
        'frmGenerateNotDecidedInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(674, 334)
        Me.Controls.Add(Me.cmdPaymentType)
        Me.Controls.Add(Me.cmbPaymentType)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.cmbBlock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdUnit)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.cmdProjectType)
        Me.Controls.Add(Me.cmbUnitType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtInvoiceDate)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmGenerateNotDecidedInvoice"
        Me.Text = "Generate Invoices not Decided"
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmdUnit As System.Windows.Forms.Button
    Friend WithEvents cmbUnit As C1.Win.C1List.C1Combo
    Friend WithEvents cmdProjectType As System.Windows.Forms.Button
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmbBlock As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmbPaymentType As C1.Win.C1List.C1Combo
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents cmdPaymentType As System.Windows.Forms.Button
End Class
