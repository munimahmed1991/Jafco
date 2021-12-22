<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrintLetters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPrintLetters))
        Me.cmbLetterType = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbGenerationMonth = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbGenerationYear = New System.Windows.Forms.ComboBox
        Me.tdbGridLetters = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtPrintDate = New C1.Win.C1Input.C1DateEdit
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbPrintOption = New System.Windows.Forms.ComboBox
        Me.chkIncludePenalty = New System.Windows.Forms.CheckBox
        Me.cmdUpdateRecoveryStatus = New System.Windows.Forms.Button
        Me.txtPaymentInstruction = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdApply = New System.Windows.Forms.Button
        CType(Me.cmbLetterType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbGridLetters, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmbLetterType
        '
        Me.cmbLetterType.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbLetterType.Caption = ""
        Me.cmbLetterType.CaptionHeight = 17
        Me.cmbLetterType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbLetterType.ColumnCaptionHeight = 17
        Me.cmbLetterType.ColumnFooterHeight = 17
        Me.cmbLetterType.ContentHeight = 15
        Me.cmbLetterType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbLetterType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbLetterType.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbLetterType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLetterType.EditorHeight = 15
        Me.cmbLetterType.Images.Add(CType(resources.GetObject("cmbLetterType.Images"), System.Drawing.Image))
        Me.cmbLetterType.ItemHeight = 15
        Me.cmbLetterType.Location = New System.Drawing.Point(82, 30)
        Me.cmbLetterType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbLetterType.MaxDropDownItems = CType(5, Short)
        Me.cmbLetterType.MaxLength = 32767
        Me.cmbLetterType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbLetterType.Name = "cmbLetterType"
        Me.cmbLetterType.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbLetterType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbLetterType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbLetterType.Size = New System.Drawing.Size(278, 21)
        Me.cmbLetterType.TabIndex = 266
        Me.cmbLetterType.PropBag = resources.GetString("cmbLetterType.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 34)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 267
        Me.Label4.Text = "Letter Type"
        '
        'cmbGenerationMonth
        '
        Me.cmbGenerationMonth.FormattingEnabled = True
        Me.cmbGenerationMonth.Items.AddRange(New Object() {"", "January", "Febuary", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December"})
        Me.cmbGenerationMonth.Location = New System.Drawing.Point(475, 29)
        Me.cmbGenerationMonth.Name = "cmbGenerationMonth"
        Me.cmbGenerationMonth.Size = New System.Drawing.Size(113, 21)
        Me.cmbGenerationMonth.TabIndex = 268
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(387, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 269
        Me.Label1.Text = "Generate Month"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(616, 34)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 271
        Me.Label2.Text = "Generate Year"
        '
        'cmbGenerationYear
        '
        Me.cmbGenerationYear.FormattingEnabled = True
        Me.cmbGenerationYear.Items.AddRange(New Object() {"", "2011", "2012", "2013", "2014", "2015", "2016", "2017", "2018", "2019", "2020", "2021", "2022", "2023", "2024", "2025", "2026", "2027", "2028", "2029", "2030"})
        Me.cmbGenerationYear.Location = New System.Drawing.Point(706, 29)
        Me.cmbGenerationYear.Name = "cmbGenerationYear"
        Me.cmbGenerationYear.Size = New System.Drawing.Size(110, 21)
        Me.cmbGenerationYear.TabIndex = 270
        '
        'tdbGridLetters
        '
        Me.tdbGridLetters.AllowAddNew = True
        Me.tdbGridLetters.AllowDelete = True
        Me.tdbGridLetters.ColumnFooters = True
        Me.tdbGridLetters.EmptyRows = True
        Me.tdbGridLetters.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbGridLetters.Images.Add(CType(resources.GetObject("tdbGridLetters.Images"), System.Drawing.Image))
        Me.tdbGridLetters.Location = New System.Drawing.Point(-1, 88)
        Me.tdbGridLetters.Name = "tdbGridLetters"
        Me.tdbGridLetters.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbGridLetters.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbGridLetters.PreviewInfo.ZoomFactor = 75
        Me.tdbGridLetters.PrintInfo.PageSettings = CType(resources.GetObject("tdbGridLetters.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbGridLetters.RecordSelectors = False
        Me.tdbGridLetters.Size = New System.Drawing.Size(959, 372)
        Me.tdbGridLetters.TabIndex = 272
        Me.tdbGridLetters.Text = "C1TrueDBGrid1"
        Me.tdbGridLetters.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdbGridLetters.WrapCellPointer = True
        Me.tdbGridLetters.PropBag = resources.GetString("tdbGridLetters.PropBag")
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
        Me.cmbProject.Location = New System.Drawing.Point(82, 3)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 273
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 274
        Me.Label3.Text = "Project"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(883, 63)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(75, 23)
        Me.cmdRefresh.TabIndex = 275
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 7)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 277
        Me.Label5.Text = "Print Date"
        '
        'txtPrintDate
        '
        Me.txtPrintDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtPrintDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtPrintDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtPrintDate.Calendar.ClearText = "&Clear"
        Me.txtPrintDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrintDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtPrintDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtPrintDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtPrintDate.Calendar.TodayText = "&Today"
        Me.txtPrintDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtPrintDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtPrintDate.Culture = 1056
        Me.txtPrintDate.CustomFormat = "dd/MM/yyyy"
        Me.txtPrintDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtPrintDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtPrintDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrintDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtPrintDate.Location = New System.Drawing.Point(475, 4)
        Me.txtPrintDate.Name = "txtPrintDate"
        Me.txtPrintDate.Size = New System.Drawing.Size(126, 19)
        Me.txtPrintDate.TabIndex = 276
        Me.txtPrintDate.Tag = Nothing
        Me.txtPrintDate.TrimEnd = False
        Me.txtPrintDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtPrintDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtPrintDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdSave
        '
        Me.cmdSave.Location = New System.Drawing.Point(806, 467)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(78, 23)
        Me.cmdSave.TabIndex = 279
        Me.cmdSave.Text = "&Save && Print"
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(886, 467)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 278
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(616, 7)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Print Option"
        '
        'cmbPrintOption
        '
        Me.cmbPrintOption.FormattingEnabled = True
        Me.cmbPrintOption.Items.AddRange(New Object() {"Pending", "Printed", "All"})
        Me.cmbPrintOption.Location = New System.Drawing.Point(704, 2)
        Me.cmbPrintOption.Name = "cmbPrintOption"
        Me.cmbPrintOption.Size = New System.Drawing.Size(113, 21)
        Me.cmbPrintOption.TabIndex = 280
        '
        'chkIncludePenalty
        '
        Me.chkIncludePenalty.AutoSize = True
        Me.chkIncludePenalty.Location = New System.Drawing.Point(837, 7)
        Me.chkIncludePenalty.Name = "chkIncludePenalty"
        Me.chkIncludePenalty.Size = New System.Drawing.Size(99, 17)
        Me.chkIncludePenalty.TabIndex = 282
        Me.chkIncludePenalty.Text = "Include Penalty"
        Me.chkIncludePenalty.UseVisualStyleBackColor = True
        '
        'cmdUpdateRecoveryStatus
        '
        Me.cmdUpdateRecoveryStatus.Location = New System.Drawing.Point(670, 467)
        Me.cmdUpdateRecoveryStatus.Name = "cmdUpdateRecoveryStatus"
        Me.cmdUpdateRecoveryStatus.Size = New System.Drawing.Size(136, 23)
        Me.cmdUpdateRecoveryStatus.TabIndex = 283
        Me.cmdUpdateRecoveryStatus.Text = "&Update Recovery Status"
        Me.cmdUpdateRecoveryStatus.UseVisualStyleBackColor = True
        '
        'txtPaymentInstruction
        '
        Me.txtPaymentInstruction.BackColor = System.Drawing.Color.White
        Me.txtPaymentInstruction.Location = New System.Drawing.Point(82, 57)
        Me.txtPaymentInstruction.Name = "txtPaymentInstruction"
        Me.txtPaymentInstruction.Size = New System.Drawing.Size(506, 20)
        Me.txtPaymentInstruction.TabIndex = 284
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 60)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 285
        Me.Label7.Text = "Payment Inst."
        '
        'cmdApply
        '
        Me.cmdApply.Location = New System.Drawing.Point(590, 56)
        Me.cmdApply.Name = "cmdApply"
        Me.cmdApply.Size = New System.Drawing.Size(75, 23)
        Me.cmdApply.TabIndex = 286
        Me.cmdApply.Text = "Apply to All"
        Me.cmdApply.UseVisualStyleBackColor = True
        '
        'frmPrintLetters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(967, 493)
        Me.Controls.Add(Me.cmdApply)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtPaymentInstruction)
        Me.Controls.Add(Me.cmdUpdateRecoveryStatus)
        Me.Controls.Add(Me.chkIncludePenalty)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbPrintOption)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPrintDate)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tdbGridLetters)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cmbGenerationYear)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbGenerationMonth)
        Me.Controls.Add(Me.cmbLetterType)
        Me.Controls.Add(Me.Label4)
        Me.Name = "frmPrintLetters"
        Me.Text = "Print Letters"
        CType(Me.cmbLetterType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbGridLetters, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbLetterType As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbGenerationMonth As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbGenerationYear As System.Windows.Forms.ComboBox
    Friend WithEvents tdbGridLetters As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtPrintDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbPrintOption As System.Windows.Forms.ComboBox
    Friend WithEvents chkIncludePenalty As System.Windows.Forms.CheckBox
    Friend WithEvents cmdUpdateRecoveryStatus As System.Windows.Forms.Button
    Friend WithEvents txtPaymentInstruction As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdApply As System.Windows.Forms.Button
End Class
