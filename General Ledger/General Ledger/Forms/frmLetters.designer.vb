<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLetters
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLetters))
        Me.txtEntryNo = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtLetterRef = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtPrintDate = New C1.Win.C1Input.C1DateEdit
        Me.chkLetterPrint = New System.Windows.Forms.CheckBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.txtSentDate = New C1.Win.C1Input.C1DateEdit
        Me.chkSent = New System.Windows.Forms.CheckBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.TextBox
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmbUnit = New C1.Win.C1List.C1Combo
        Me.Label21 = New System.Windows.Forms.Label
        Me.txtCustomerEmail1 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.txtCustomerNIC1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCustomerMobile1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCustomerTel1 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCustomerName1 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCustomerCode1 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtLetterType = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEntryDate = New C1.Win.C1Input.C1DateEdit
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        Me.Label13 = New System.Windows.Forms.Label
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSearchCancel = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtPrintDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSentDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEntryNo
        '
        Me.txtEntryNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtEntryNo.Location = New System.Drawing.Point(114, 20)
        Me.txtEntryNo.Name = "txtEntryNo"
        Me.txtEntryNo.Size = New System.Drawing.Size(147, 20)
        Me.txtEntryNo.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Entry #"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 64)
        Me.ToolStrip1.TabIndex = 112
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(283, 61)
        Me.ToolStripLabel1.Text = "LETTERS HISTORY"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtLetterRef)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtPrintDate)
        Me.GroupBox2.Controls.Add(Me.chkLetterPrint)
        Me.GroupBox2.Controls.Add(Me.Label34)
        Me.GroupBox2.Controls.Add(Me.txtSentDate)
        Me.GroupBox2.Controls.Add(Me.chkSent)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtRemarks)
        Me.GroupBox2.Controls.Add(Me.cmbProject)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbUnitType)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cmbUnit)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.txtCustomerEmail1)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtCustomerNIC1)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtCustomerMobile1)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCustomerTel1)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCustomerName1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCustomerCode1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtLetterType)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtEntryDate)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtEntryNo)
        Me.GroupBox2.Location = New System.Drawing.Point(7, 98)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(732, 386)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 308)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(59, 13)
        Me.Label12.TabIndex = 284
        Me.Label12.Text = "Letters Ref"
        '
        'txtLetterRef
        '
        Me.txtLetterRef.BackColor = System.Drawing.Color.White
        Me.txtLetterRef.Location = New System.Drawing.Point(114, 305)
        Me.txtLetterRef.Name = "txtLetterRef"
        Me.txtLetterRef.Size = New System.Drawing.Size(454, 20)
        Me.txtLetterRef.TabIndex = 283
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(116, 362)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 282
        Me.Label11.Text = "Print Date"
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
        Me.txtPrintDate.Enabled = False
        Me.txtPrintDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPrintDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtPrintDate.Location = New System.Drawing.Point(187, 359)
        Me.txtPrintDate.Name = "txtPrintDate"
        Me.txtPrintDate.ReadOnly = True
        Me.txtPrintDate.Size = New System.Drawing.Size(126, 19)
        Me.txtPrintDate.TabIndex = 281
        Me.txtPrintDate.Tag = Nothing
        Me.txtPrintDate.TrimEnd = False
        Me.txtPrintDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtPrintDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtPrintDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'chkLetterPrint
        '
        Me.chkLetterPrint.AutoSize = True
        Me.chkLetterPrint.Enabled = False
        Me.chkLetterPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkLetterPrint.Location = New System.Drawing.Point(25, 361)
        Me.chkLetterPrint.Name = "chkLetterPrint"
        Me.chkLetterPrint.Size = New System.Drawing.Size(78, 17)
        Me.chkLetterPrint.TabIndex = 280
        Me.chkLetterPrint.Text = "Letter Sent"
        Me.chkLetterPrint.UseVisualStyleBackColor = True
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label34.Location = New System.Drawing.Point(116, 337)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(55, 13)
        Me.Label34.TabIndex = 279
        Me.Label34.Text = "Sent Date"
        '
        'txtSentDate
        '
        Me.txtSentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtSentDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtSentDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtSentDate.Calendar.ClearText = "&Clear"
        Me.txtSentDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSentDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtSentDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtSentDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtSentDate.Calendar.TodayText = "&Today"
        Me.txtSentDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtSentDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtSentDate.Culture = 1056
        Me.txtSentDate.CustomFormat = "dd/MM/yyyy"
        Me.txtSentDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtSentDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtSentDate.Enabled = False
        Me.txtSentDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSentDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtSentDate.Location = New System.Drawing.Point(187, 334)
        Me.txtSentDate.Name = "txtSentDate"
        Me.txtSentDate.ReadOnly = True
        Me.txtSentDate.Size = New System.Drawing.Size(126, 19)
        Me.txtSentDate.TabIndex = 278
        Me.txtSentDate.Tag = Nothing
        Me.txtSentDate.TrimEnd = False
        Me.txtSentDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtSentDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtSentDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'chkSent
        '
        Me.chkSent.AutoSize = True
        Me.chkSent.Enabled = False
        Me.chkSent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkSent.Location = New System.Drawing.Point(25, 336)
        Me.chkSent.Name = "chkSent"
        Me.chkSent.Size = New System.Drawing.Size(78, 17)
        Me.chkSent.TabIndex = 277
        Me.chkSent.Text = "Letter Sent"
        Me.chkSent.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 281)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 267
        Me.Label5.Text = "Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.BackColor = System.Drawing.Color.White
        Me.txtRemarks.Location = New System.Drawing.Point(114, 278)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(454, 20)
        Me.txtRemarks.TabIndex = 266
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
        Me.cmbProject.Location = New System.Drawing.Point(114, 72)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.ReadOnly = True
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 264
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 13)
        Me.Label4.TabIndex = 265
        Me.Label4.Text = "Project"
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
        Me.cmbUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitType.Images.Add(CType(resources.GetObject("cmbUnitType.Images"), System.Drawing.Image))
        Me.cmbUnitType.ItemHeight = 15
        Me.cmbUnitType.Location = New System.Drawing.Point(114, 224)
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
        Me.cmbUnitType.TabIndex = 262
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(20, 228)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 263
        Me.Label27.Text = "Unit Type"
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
        Me.cmbUnit.Location = New System.Drawing.Point(114, 251)
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
        Me.cmbUnit.TabIndex = 260
        Me.cmbUnit.PropBag = resources.GetString("cmbUnit.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(20, 255)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 261
        Me.Label21.Text = "Unit #"
        '
        'txtCustomerEmail1
        '
        Me.txtCustomerEmail1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail1.Location = New System.Drawing.Point(114, 198)
        Me.txtCustomerEmail1.Name = "txtCustomerEmail1"
        Me.txtCustomerEmail1.ReadOnly = True
        Me.txtCustomerEmail1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerEmail1.TabIndex = 259
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(22, 201)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 258
        Me.Label17.Text = "Email"
        '
        'txtCustomerNIC1
        '
        Me.txtCustomerNIC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerNIC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNIC1.Location = New System.Drawing.Point(306, 173)
        Me.txtCustomerNIC1.Name = "txtCustomerNIC1"
        Me.txtCustomerNIC1.ReadOnly = True
        Me.txtCustomerNIC1.Size = New System.Drawing.Size(125, 20)
        Me.txtCustomerNIC1.TabIndex = 256
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(265, 176)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 255
        Me.Label10.Text = "NIC #"
        '
        'txtCustomerMobile1
        '
        Me.txtCustomerMobile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerMobile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerMobile1.Location = New System.Drawing.Point(114, 173)
        Me.txtCustomerMobile1.Name = "txtCustomerMobile1"
        Me.txtCustomerMobile1.ReadOnly = True
        Me.txtCustomerMobile1.Size = New System.Drawing.Size(125, 20)
        Me.txtCustomerMobile1.TabIndex = 254
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 176)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 253
        Me.Label9.Text = "Mobile #"
        '
        'txtCustomerTel1
        '
        Me.txtCustomerTel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerTel1.Location = New System.Drawing.Point(114, 149)
        Me.txtCustomerTel1.Name = "txtCustomerTel1"
        Me.txtCustomerTel1.ReadOnly = True
        Me.txtCustomerTel1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerTel1.TabIndex = 252
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 152)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 251
        Me.Label8.Text = "Tel # "
        '
        'txtCustomerName1
        '
        Me.txtCustomerName1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName1.Location = New System.Drawing.Point(114, 125)
        Me.txtCustomerName1.Name = "txtCustomerName1"
        Me.txtCustomerName1.ReadOnly = True
        Me.txtCustomerName1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerName1.TabIndex = 250
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 128)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 249
        Me.Label7.Text = "Customer Name"
        '
        'txtCustomerCode1
        '
        Me.txtCustomerCode1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode1.Location = New System.Drawing.Point(114, 99)
        Me.txtCustomerCode1.Name = "txtCustomerCode1"
        Me.txtCustomerCode1.ReadOnly = True
        Me.txtCustomerCode1.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerCode1.TabIndex = 248
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(22, 102)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 247
        Me.Label6.Text = "Customer Code"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 202
        Me.Label3.Text = "Letter Type"
        '
        'txtLetterType
        '
        Me.txtLetterType.BackColor = System.Drawing.Color.White
        Me.txtLetterType.Location = New System.Drawing.Point(114, 46)
        Me.txtLetterType.Name = "txtLetterType"
        Me.txtLetterType.ReadOnly = True
        Me.txtLetterType.Size = New System.Drawing.Size(199, 20)
        Me.txtLetterType.TabIndex = 201
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(373, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 200
        Me.Label2.Text = "Entry Date"
        '
        'txtEntryDate
        '
        Me.txtEntryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtEntryDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtEntryDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtEntryDate.Calendar.ClearText = "&Clear"
        Me.txtEntryDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtEntryDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtEntryDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtEntryDate.Calendar.TodayText = "&Today"
        Me.txtEntryDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtEntryDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtEntryDate.Culture = 1056
        Me.txtEntryDate.CustomFormat = "dd/MM/yyyy"
        Me.txtEntryDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtEntryDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtEntryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEntryDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtEntryDate.Location = New System.Drawing.Point(442, 19)
        Me.txtEntryDate.Name = "txtEntryDate"
        Me.txtEntryDate.Size = New System.Drawing.Size(126, 19)
        Me.txtEntryDate.TabIndex = 199
        Me.txtEntryDate.Tag = Nothing
        Me.txtEntryDate.TrimEnd = False
        Me.txtEntryDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtEntryDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtEntryDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(690, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 56)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(484, 4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(639, 4)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(51, 56)
        Me.cmdUndo.TabIndex = 5
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(587, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(536, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(51, 56)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtDateTo)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txtDateFrom)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(732, 37)
        Me.GroupBox1.TabIndex = 114
        Me.GroupBox1.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(211, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 13)
        Me.Label14.TabIndex = 203
        Me.Label14.Text = "Date To"
        '
        'txtDateTo
        '
        Me.txtDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateTo.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.ClearText = "&Clear"
        Me.txtDateTo.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDateTo.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDateTo.Calendar.TodayText = "&Today"
        Me.txtDateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateTo.Culture = 1056
        Me.txtDateTo.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(268, 12)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(126, 19)
        Me.txtDateTo.TabIndex = 202
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.TrimEnd = False
        Me.txtDateTo.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDateTo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 16)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(56, 13)
        Me.Label13.TabIndex = 201
        Me.Label13.Text = "Date From"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateFrom.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDateFrom.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDateFrom.Calendar.ClearText = "&Clear"
        Me.txtDateFrom.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDateFrom.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDateFrom.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDateFrom.Calendar.TodayText = "&Today"
        Me.txtDateFrom.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateFrom.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateFrom.Culture = 1056
        Me.txtDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.Location = New System.Drawing.Point(76, 12)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(126, 19)
        Me.txtDateFrom.TabIndex = 200
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.TrimEnd = False
        Me.txtDateFrom.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDateFrom.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateFrom.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(431, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 115
        Me.cmdDelete.Text = "&Cancel"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSearchCancel
        '
        Me.cmdSearchCancel.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearchCancel.Location = New System.Drawing.Point(340, 4)
        Me.cmdSearchCancel.Name = "cmdSearchCancel"
        Me.cmdSearchCancel.Size = New System.Drawing.Size(89, 56)
        Me.cmdSearchCancel.TabIndex = 116
        Me.cmdSearchCancel.Text = "Searc&h Cancel"
        Me.cmdSearchCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearchCancel.UseVisualStyleBackColor = True
        '
        'frmLetters
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 485)
        Me.Controls.Add(Me.cmdSearchCancel)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmLetters"
        Me.Text = "Letters History"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtPrintDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSentDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents txtEntryNo As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEntryDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLetterType As System.Windows.Forms.TextBox
    Friend WithEvents txtCustomerEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNIC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerMobile1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents txtSentDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkSent As System.Windows.Forms.CheckBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtPrintDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkLetterPrint As System.Windows.Forms.CheckBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtLetterRef As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSearchCancel As System.Windows.Forms.Button
    'Friend WithEvents CachedReport1 As CrystalDecisions.ReportSource.CachedReport
End Class
