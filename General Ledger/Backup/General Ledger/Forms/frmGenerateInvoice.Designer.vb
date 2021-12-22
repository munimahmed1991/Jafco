<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGenerateInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGenerateInvoice))
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtDueDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtDueDateTo = New C1.Win.C1Input.C1DateEdit
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtInvoiceDate = New C1.Win.C1Input.C1DateEdit
        Me.cmdGenerate = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmbBlock = New C1.Win.C1List.C1Combo
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmdProjectType = New System.Windows.Forms.Button
        Me.cmdUnit = New System.Windows.Forms.Button
        Me.cmbUnit = New C1.Win.C1List.C1Combo
        Me.Label8 = New System.Windows.Forms.Label
        CType(Me.txtDueDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDueDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Blue
        Me.Label2.Location = New System.Drawing.Point(22, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Due Date"
        '
        'txtDueDateFrom
        '
        Me.txtDueDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDueDateFrom.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDueDateFrom.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDueDateFrom.Calendar.ClearText = "&Clear"
        Me.txtDueDateFrom.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDateFrom.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDueDateFrom.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDueDateFrom.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDueDateFrom.Calendar.TodayText = "&Today"
        Me.txtDueDateFrom.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDueDateFrom.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDueDateFrom.Culture = 1056
        Me.txtDueDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.txtDueDateFrom.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDueDateFrom.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDueDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDueDateFrom.Location = New System.Drawing.Point(64, 43)
        Me.txtDueDateFrom.Name = "txtDueDateFrom"
        Me.txtDueDateFrom.Size = New System.Drawing.Size(126, 19)
        Me.txtDueDateFrom.TabIndex = 197
        Me.txtDueDateFrom.Tag = Nothing
        Me.txtDueDateFrom.TrimEnd = False
        Me.txtDueDateFrom.Value = New Date(2018, 1, 30, 0, 0, 0, 0)
        Me.txtDueDateFrom.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDueDateFrom.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 199
        Me.Label1.Text = "From"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(20, 13)
        Me.Label3.TabIndex = 201
        Me.Label3.Text = "To"
        '
        'txtDueDateTo
        '
        Me.txtDueDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDueDateTo.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDueDateTo.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDueDateTo.Calendar.ClearText = "&Clear"
        Me.txtDueDateTo.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDateTo.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDueDateTo.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDueDateTo.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDueDateTo.Calendar.TodayText = "&Today"
        Me.txtDueDateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDueDateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDueDateTo.Culture = 1056
        Me.txtDueDateTo.CustomFormat = "dd/MM/yyyy"
        Me.txtDueDateTo.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDueDateTo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDueDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDueDateTo.Location = New System.Drawing.Point(64, 68)
        Me.txtDueDateTo.Name = "txtDueDateTo"
        Me.txtDueDateTo.Size = New System.Drawing.Size(126, 19)
        Me.txtDueDateTo.TabIndex = 200
        Me.txtDueDateTo.Tag = Nothing
        Me.txtDueDateTo.TrimEnd = False
        Me.txtDueDateTo.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDueDateTo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDueDateTo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Blue
        Me.Label4.Location = New System.Drawing.Point(390, 10)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 202
        Me.Label4.Text = "Invoice Date"
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
        Me.txtInvoiceDate.Location = New System.Drawing.Point(393, 32)
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Size = New System.Drawing.Size(126, 19)
        Me.txtInvoiceDate.TabIndex = 203
        Me.txtInvoiceDate.Tag = Nothing
        Me.txtInvoiceDate.TrimEnd = False
        Me.txtInvoiceDate.Value = New Date(2018, 1, 30, 0, 0, 0, 0)
        Me.txtInvoiceDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtInvoiceDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdGenerate
        '
        Me.cmdGenerate.Location = New System.Drawing.Point(515, 313)
        Me.cmdGenerate.Name = "cmdGenerate"
        Me.cmdGenerate.Size = New System.Drawing.Size(75, 23)
        Me.cmdGenerate.TabIndex = 204
        Me.cmdGenerate.Text = "Generate"
        Me.cmdGenerate.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(593, 313)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 205
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.UseVisualStyleBackColor = True
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
        Me.cmbProject.Location = New System.Drawing.Point(25, 146)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 241
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(22, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 242
        Me.Label5.Text = "Project"
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
        Me.cmbUnitType.Location = New System.Drawing.Point(25, 208)
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
        Me.cmbUnitType.TabIndex = 243
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Blue
        Me.Label6.Location = New System.Drawing.Point(22, 181)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(53, 13)
        Me.Label6.TabIndex = 244
        Me.Label6.Text = "Unit Type"
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
        Me.cmbBlock.Location = New System.Drawing.Point(393, 208)
        Me.cmbBlock.MatchEntryTimeout = CType(2000, Long)
        Me.cmbBlock.MaxDropDownItems = CType(5, Short)
        Me.cmbBlock.MaxLength = 32767
        Me.cmbBlock.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbBlock.Name = "cmbBlock"
        Me.cmbBlock.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbBlock.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbBlock.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbBlock.Size = New System.Drawing.Size(256, 21)
        Me.cmbBlock.TabIndex = 245
        Me.cmbBlock.PropBag = resources.GetString("cmbBlock.PropBag")
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Blue
        Me.Label7.Location = New System.Drawing.Point(390, 181)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 246
        Me.Label7.Text = "Block"
        '
        'cmdProjectType
        '
        Me.cmdProjectType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdProjectType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdProjectType.Location = New System.Drawing.Point(304, 208)
        Me.cmdProjectType.Name = "cmdProjectType"
        Me.cmdProjectType.Size = New System.Drawing.Size(22, 21)
        Me.cmdProjectType.TabIndex = 255
        Me.cmdProjectType.UseVisualStyleBackColor = True
        '
        'cmdUnit
        '
        Me.cmdUnit.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnit.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnit.Location = New System.Drawing.Point(303, 274)
        Me.cmdUnit.Name = "cmdUnit"
        Me.cmdUnit.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnit.TabIndex = 258
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
        Me.cmbUnit.Location = New System.Drawing.Point(25, 274)
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
        Me.cmbUnit.TabIndex = 256
        Me.cmbUnit.PropBag = resources.GetString("cmbUnit.PropBag")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Blue
        Me.Label8.Location = New System.Drawing.Point(22, 248)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 259
        Me.Label8.Text = "Unit #"
        '
        'frmGenerateInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(680, 348)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmdUnit)
        Me.Controls.Add(Me.cmbUnit)
        Me.Controls.Add(Me.cmdProjectType)
        Me.Controls.Add(Me.cmbBlock)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbUnitType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdGenerate)
        Me.Controls.Add(Me.txtInvoiceDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtDueDateTo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDueDateFrom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmGenerateInvoice"
        Me.Text = "Generate Invoice Automatically"
        CType(Me.txtDueDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDueDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbBlock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDueDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtDueDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtInvoiceDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmdGenerate As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbBlock As C1.Win.C1List.C1Combo
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdProjectType As System.Windows.Forms.Button
    Friend WithEvents cmdUnit As System.Windows.Forms.Button
    Friend WithEvents cmbUnit As C1.Win.C1List.C1Combo
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
