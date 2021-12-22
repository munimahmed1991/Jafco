<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmReceptionModule
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmReceptionModule))
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtEntryNo = New System.Windows.Forms.TextBox
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtCompletedRemarks = New System.Windows.Forms.RichTextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtRemarks = New System.Windows.Forms.RichTextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCompletedDate = New C1.Win.C1Input.C1DateEdit
        Me.chkCompleted = New System.Windows.Forms.CheckBox
        Me.txtContactDetails = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCustomer = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbTaskFor = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtGivenBy = New System.Windows.Forms.TextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.cmbTask = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtEntryDate = New C1.Win.C1Input.C1DateEdit
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtDeadlineDate = New C1.Win.C1Input.C1DateEdit
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtCompletedDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTaskFor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbTask, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeadlineDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(439, 9)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 56)
        Me.cmdAdd.TabIndex = 113
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(697, 9)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 56)
        Me.cmdExit.TabIndex = 119
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(646, 9)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(51, 56)
        Me.cmdUndo.TabIndex = 118
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(387, 9)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 114
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(491, 9)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(51, 56)
        Me.cmdEdit.TabIndex = 116
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(285, 61)
        Me.ToolStripLabel1.Text = "Reception Module"
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(543, 9)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 115
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(594, 9)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 117
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 9)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(744, 64)
        Me.ToolStrip1.TabIndex = 120
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(38, 101)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 122
        Me.Label1.Text = "Entry #"
        '
        'txtEntryNo
        '
        Me.txtEntryNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtEntryNo.Location = New System.Drawing.Point(147, 98)
        Me.txtEntryNo.Name = "txtEntryNo"
        Me.txtEntryNo.Size = New System.Drawing.Size(100, 20)
        Me.txtEntryNo.TabIndex = 121
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtDeadlineDate)
        Me.GroupBox2.Controls.Add(Me.txtCompletedRemarks)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtRemarks)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtCompletedDate)
        Me.GroupBox2.Controls.Add(Me.chkCompleted)
        Me.GroupBox2.Controls.Add(Me.txtContactDetails)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCustomer)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbTaskFor)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtGivenBy)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cmbTask)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtEntryDate)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 444)
        Me.GroupBox2.TabIndex = 123
        Me.GroupBox2.TabStop = False
        '
        'txtCompletedRemarks
        '
        Me.txtCompletedRemarks.Location = New System.Drawing.Point(141, 329)
        Me.txtCompletedRemarks.Name = "txtCompletedRemarks"
        Me.txtCompletedRemarks.Size = New System.Drawing.Size(498, 96)
        Me.txtCompletedRemarks.TabIndex = 288
        Me.txtCompletedRemarks.Text = ""
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(32, 371)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 13)
        Me.Label8.TabIndex = 287
        Me.Label8.Text = "Completion Remarks"
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(141, 175)
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(498, 96)
        Me.txtRemarks.TabIndex = 286
        Me.txtRemarks.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(32, 217)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 285
        Me.Label7.Text = "Remarks"
        '
        'txtCompletedDate
        '
        Me.txtCompletedDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtCompletedDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtCompletedDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtCompletedDate.Calendar.ClearText = "&Clear"
        Me.txtCompletedDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompletedDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtCompletedDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtCompletedDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtCompletedDate.Calendar.TodayText = "&Today"
        Me.txtCompletedDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtCompletedDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtCompletedDate.Culture = 1056
        Me.txtCompletedDate.CustomFormat = "dd/MM/yyyy"
        Me.txtCompletedDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtCompletedDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCompletedDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCompletedDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtCompletedDate.Location = New System.Drawing.Point(232, 294)
        Me.txtCompletedDate.Name = "txtCompletedDate"
        Me.txtCompletedDate.ReadOnly = True
        Me.txtCompletedDate.Size = New System.Drawing.Size(140, 19)
        Me.txtCompletedDate.TabIndex = 284
        Me.txtCompletedDate.Tag = Nothing
        Me.txtCompletedDate.TrimEnd = False
        Me.txtCompletedDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtCompletedDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtCompletedDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'chkCompleted
        '
        Me.chkCompleted.AutoSize = True
        Me.chkCompleted.Location = New System.Drawing.Point(141, 295)
        Me.chkCompleted.Name = "chkCompleted"
        Me.chkCompleted.Size = New System.Drawing.Size(76, 17)
        Me.chkCompleted.TabIndex = 283
        Me.chkCompleted.Text = "Completed"
        Me.chkCompleted.UseVisualStyleBackColor = True
        '
        'txtContactDetails
        '
        Me.txtContactDetails.BackColor = System.Drawing.Color.White
        Me.txtContactDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtContactDetails.Location = New System.Drawing.Point(450, 143)
        Me.txtContactDetails.Name = "txtContactDetails"
        Me.txtContactDetails.Size = New System.Drawing.Size(187, 20)
        Me.txtContactDetails.TabIndex = 282
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(354, 146)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 13)
        Me.Label6.TabIndex = 281
        Me.Label6.Text = "Contact Details"
        '
        'txtCustomer
        '
        Me.txtCustomer.BackColor = System.Drawing.Color.White
        Me.txtCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomer.Location = New System.Drawing.Point(141, 143)
        Me.txtCustomer.Name = "txtCustomer"
        Me.txtCustomer.Size = New System.Drawing.Size(187, 20)
        Me.txtCustomer.TabIndex = 280
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(31, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 279
        Me.Label5.Text = "Customer"
        '
        'cmbTaskFor
        '
        Me.cmbTaskFor.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTaskFor.Caption = ""
        Me.cmbTaskFor.CaptionHeight = 17
        Me.cmbTaskFor.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTaskFor.ColumnCaptionHeight = 17
        Me.cmbTaskFor.ColumnFooterHeight = 17
        Me.cmbTaskFor.ContentHeight = 15
        Me.cmbTaskFor.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTaskFor.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTaskFor.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTaskFor.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTaskFor.EditorHeight = 15
        Me.cmbTaskFor.Images.Add(CType(resources.GetObject("cmbTaskFor.Images"), System.Drawing.Image))
        Me.cmbTaskFor.ItemHeight = 15
        Me.cmbTaskFor.Location = New System.Drawing.Point(141, 51)
        Me.cmbTaskFor.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTaskFor.MaxDropDownItems = CType(5, Short)
        Me.cmbTaskFor.MaxLength = 32767
        Me.cmbTaskFor.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTaskFor.Name = "cmbTaskFor"
        Me.cmbTaskFor.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTaskFor.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTaskFor.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTaskFor.Size = New System.Drawing.Size(278, 21)
        Me.cmbTaskFor.TabIndex = 277
        Me.cmbTaskFor.PropBag = resources.GetString("cmbTaskFor.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(31, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 278
        Me.Label4.Text = "Task For"
        '
        'txtGivenBy
        '
        Me.txtGivenBy.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtGivenBy.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGivenBy.Location = New System.Drawing.Point(141, 114)
        Me.txtGivenBy.Name = "txtGivenBy"
        Me.txtGivenBy.ReadOnly = True
        Me.txtGivenBy.Size = New System.Drawing.Size(187, 20)
        Me.txtGivenBy.TabIndex = 276
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(31, 117)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(50, 13)
        Me.Label23.TabIndex = 275
        Me.Label23.Text = "Given By"
        '
        'cmbTask
        '
        Me.cmbTask.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbTask.Caption = ""
        Me.cmbTask.CaptionHeight = 17
        Me.cmbTask.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbTask.ColumnCaptionHeight = 17
        Me.cmbTask.ColumnFooterHeight = 17
        Me.cmbTask.ContentHeight = 15
        Me.cmbTask.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbTask.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbTask.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTask.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbTask.EditorHeight = 15
        Me.cmbTask.Images.Add(CType(resources.GetObject("cmbTask.Images"), System.Drawing.Image))
        Me.cmbTask.ItemHeight = 15
        Me.cmbTask.Location = New System.Drawing.Point(141, 82)
        Me.cmbTask.MatchEntryTimeout = CType(2000, Long)
        Me.cmbTask.MaxDropDownItems = CType(5, Short)
        Me.cmbTask.MaxLength = 32767
        Me.cmbTask.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbTask.Name = "cmbTask"
        Me.cmbTask.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbTask.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbTask.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbTask.Size = New System.Drawing.Size(278, 21)
        Me.cmbTask.TabIndex = 241
        Me.cmbTask.PropBag = resources.GetString("cmbTask.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(31, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 242
        Me.Label3.Text = "Task"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(354, 21)
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
        Me.txtEntryDate.Location = New System.Drawing.Point(450, 18)
        Me.txtEntryDate.Name = "txtEntryDate"
        Me.txtEntryDate.ReadOnly = True
        Me.txtEntryDate.Size = New System.Drawing.Size(126, 19)
        Me.txtEntryDate.TabIndex = 199
        Me.txtEntryDate.Tag = Nothing
        Me.txtEntryDate.TrimEnd = False
        Me.txtEntryDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtEntryDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtEntryDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(354, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 13)
        Me.Label9.TabIndex = 290
        Me.Label9.Text = "Deadline Date"
        '
        'txtDeadlineDate
        '
        Me.txtDeadlineDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer), CType(CType(239, Byte), Integer))
        Me.txtDeadlineDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDeadlineDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDeadlineDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDeadlineDate.Calendar.ClearText = "&Clear"
        Me.txtDeadlineDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeadlineDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDeadlineDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDeadlineDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDeadlineDate.Calendar.TodayText = "&Today"
        Me.txtDeadlineDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDeadlineDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDeadlineDate.Culture = 1056
        Me.txtDeadlineDate.CustomFormat = "dd/MM/yyyy"
        Me.txtDeadlineDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDeadlineDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDeadlineDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeadlineDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDeadlineDate.Location = New System.Drawing.Point(450, 116)
        Me.txtDeadlineDate.Name = "txtDeadlineDate"
        Me.txtDeadlineDate.Size = New System.Drawing.Size(126, 19)
        Me.txtDeadlineDate.TabIndex = 289
        Me.txtDeadlineDate.Tag = Nothing
        Me.txtDeadlineDate.TrimEnd = False
        Me.txtDeadlineDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDeadlineDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDeadlineDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmReceptionModule
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(752, 525)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtEntryNo)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "frmReceptionModule"
        Me.Text = "Reception Module"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtCompletedDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTaskFor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbTask, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeadlineDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtEntryNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtEntryDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbTask As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtGivenBy As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCompletedDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents chkCompleted As System.Windows.Forms.CheckBox
    Friend WithEvents txtContactDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCustomer As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbTaskFor As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtCompletedRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDeadlineDate As C1.Win.C1Input.C1DateEdit
End Class
