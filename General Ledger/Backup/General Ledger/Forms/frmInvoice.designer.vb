<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInvoice
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInvoice))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox
        Me.cmdUnitType = New System.Windows.Forms.Button
        Me.cmbUnitType = New C1.Win.C1List.C1Combo
        Me.Label27 = New System.Windows.Forms.Label
        Me.cmdUnit = New System.Windows.Forms.Button
        Me.cmbUnit = New C1.Win.C1List.C1Combo
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtInvoiceDate = New C1.Win.C1Input.C1DateEdit
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.txtCustomerEmail2 = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCustomerNIC2 = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtCustomerMobile2 = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtCustomerTel2 = New System.Windows.Forms.TextBox
        Me.Label14 = New System.Windows.Forms.Label
        Me.txtCustomerName2 = New System.Windows.Forms.TextBox
        Me.Label15 = New System.Windows.Forms.Label
        Me.txtCustomerCode2 = New System.Windows.Forms.TextBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.txtCustomerEmail1 = New System.Windows.Forms.TextBox
        Me.Label17 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.txtCustomerNIC1 = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.txtCustomerMobile1 = New System.Windows.Forms.TextBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtCustomerTel1 = New System.Windows.Forms.TextBox
        Me.Label19 = New System.Windows.Forms.Label
        Me.txtCustomerName1 = New System.Windows.Forms.TextBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.txtCustomerCode1 = New System.Windows.Forms.TextBox
        Me.Label22 = New System.Windows.Forms.Label
        Me.Label23 = New System.Windows.Forms.Label
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.chkNotDecided = New System.Windows.Forms.CheckBox
        Me.cmdPaymentType = New System.Windows.Forms.Button
        Me.cmdExtraCharges = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtInstallments = New C1.Win.C1Input.C1NumericEdit
        Me.txtAmount = New C1.Win.C1Input.C1NumericEdit
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtDueDate = New C1.Win.C1Input.C1DateEdit
        Me.cmbExtraCharges = New C1.Win.C1List.C1Combo
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbPaymentType = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.txtInstallments, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDueDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbExtraCharges, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 4)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(841, 64)
        Me.ToolStrip1.TabIndex = 112
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(124, 61)
        Me.ToolStripLabel1.Text = "Invoice"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox2.Controls.Add(Me.cmdUnitType)
        Me.GroupBox2.Controls.Add(Me.cmbUnitType)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.cmdUnit)
        Me.GroupBox2.Controls.Add(Me.cmbUnit)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmbProject)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtInvoiceDate)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(4, 69)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(839, 130)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Unit Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 259
        Me.Label1.Text = "Invoice #"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(108, 18)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(134, 20)
        Me.txtInvoiceNo.TabIndex = 258
        '
        'cmdUnitType
        '
        Me.cmdUnitType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnitType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnitType.Location = New System.Drawing.Point(386, 69)
        Me.cmdUnitType.Name = "cmdUnitType"
        Me.cmdUnitType.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnitType.TabIndex = 257
        Me.cmdUnitType.UseVisualStyleBackColor = True
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
        Me.cmbUnitType.Location = New System.Drawing.Point(108, 69)
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
        Me.cmbUnitType.TabIndex = 255
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(17, 74)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(53, 13)
        Me.Label27.TabIndex = 256
        Me.Label27.Text = "Unit Type"
        '
        'cmdUnit
        '
        Me.cmdUnit.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnit.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnit.Location = New System.Drawing.Point(386, 96)
        Me.cmdUnit.Name = "cmdUnit"
        Me.cmdUnit.Size = New System.Drawing.Size(22, 21)
        Me.cmdUnit.TabIndex = 254
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
        Me.cmbUnit.Location = New System.Drawing.Point(108, 96)
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
        Me.cmbUnit.TabIndex = 252
        Me.cmbUnit.PropBag = resources.GetString("cmbUnit.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 101)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(36, 13)
        Me.Label21.TabIndex = 253
        Me.Label21.Text = "Unit #"
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
        Me.cmbProject.Location = New System.Drawing.Point(108, 42)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(278, 21)
        Me.cmbProject.TabIndex = 239
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 47)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 240
        Me.Label3.Text = "Project"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(310, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 198
        Me.Label2.Text = "Invoice Date"
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
        Me.txtInvoiceDate.Location = New System.Drawing.Point(406, 20)
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Size = New System.Drawing.Size(126, 19)
        Me.txtInvoiceDate.TabIndex = 197
        Me.txtInvoiceDate.Tag = Nothing
        Me.txtInvoiceDate.TrimEnd = False
        Me.txtInvoiceDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtInvoiceDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtInvoiceDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(528, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 56)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(786, 4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(51, 56)
        Me.cmdExit.TabIndex = 7
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(735, 4)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(51, 56)
        Me.cmdUndo.TabIndex = 5
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(476, 4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(580, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(51, 56)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(632, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(683, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtCustomerEmail2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.txtCustomerNIC2)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtCustomerMobile2)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txtCustomerTel2)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName2)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txtCustomerCode2)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.txtCustomerEmail1)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtCustomerNIC1)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txtCustomerMobile1)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtCustomerTel1)
        Me.GroupBox1.Controls.Add(Me.Label19)
        Me.GroupBox1.Controls.Add(Me.txtCustomerName1)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.txtCustomerCode1)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.Label23)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(4, 208)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(837, 164)
        Me.GroupBox1.TabIndex = 296
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Customer Information"
        '
        'txtCustomerEmail2
        '
        Me.txtCustomerEmail2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerEmail2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail2.Location = New System.Drawing.Point(517, 138)
        Me.txtCustomerEmail2.Name = "txtCustomerEmail2"
        Me.txtCustomerEmail2.ReadOnly = True
        Me.txtCustomerEmail2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerEmail2.TabIndex = 258
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(425, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 257
        Me.Label6.Text = "Email"
        '
        'txtCustomerNIC2
        '
        Me.txtCustomerNIC2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerNIC2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNIC2.Location = New System.Drawing.Point(517, 117)
        Me.txtCustomerNIC2.Name = "txtCustomerNIC2"
        Me.txtCustomerNIC2.ReadOnly = True
        Me.txtCustomerNIC2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerNIC2.TabIndex = 255
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(425, 120)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 254
        Me.Label7.Text = "NIC #"
        '
        'txtCustomerMobile2
        '
        Me.txtCustomerMobile2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerMobile2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerMobile2.Location = New System.Drawing.Point(517, 96)
        Me.txtCustomerMobile2.Name = "txtCustomerMobile2"
        Me.txtCustomerMobile2.ReadOnly = True
        Me.txtCustomerMobile2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerMobile2.TabIndex = 253
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(425, 99)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 13)
        Me.Label8.TabIndex = 252
        Me.Label8.Text = "Mobile #"
        '
        'txtCustomerTel2
        '
        Me.txtCustomerTel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerTel2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerTel2.Location = New System.Drawing.Point(517, 75)
        Me.txtCustomerTel2.Name = "txtCustomerTel2"
        Me.txtCustomerTel2.ReadOnly = True
        Me.txtCustomerTel2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerTel2.TabIndex = 251
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(425, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 13)
        Me.Label14.TabIndex = 250
        Me.Label14.Text = "Tel # "
        '
        'txtCustomerName2
        '
        Me.txtCustomerName2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerName2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName2.Location = New System.Drawing.Point(517, 54)
        Me.txtCustomerName2.Name = "txtCustomerName2"
        Me.txtCustomerName2.ReadOnly = True
        Me.txtCustomerName2.Size = New System.Drawing.Size(302, 20)
        Me.txtCustomerName2.TabIndex = 249
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(425, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 248
        Me.Label15.Text = "Customer Name"
        '
        'txtCustomerCode2
        '
        Me.txtCustomerCode2.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCustomerCode2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode2.Location = New System.Drawing.Point(517, 32)
        Me.txtCustomerCode2.Name = "txtCustomerCode2"
        Me.txtCustomerCode2.ReadOnly = True
        Me.txtCustomerCode2.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerCode2.TabIndex = 247
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(425, 35)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(79, 13)
        Me.Label18.TabIndex = 246
        Me.Label18.Text = "Customer Code"
        '
        'txtCustomerEmail1
        '
        Me.txtCustomerEmail1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerEmail1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail1.Location = New System.Drawing.Point(100, 138)
        Me.txtCustomerEmail1.Name = "txtCustomerEmail1"
        Me.txtCustomerEmail1.ReadOnly = True
        Me.txtCustomerEmail1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerEmail1.TabIndex = 245
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(8, 141)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(32, 13)
        Me.Label17.TabIndex = 244
        Me.Label17.Text = "Email"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Blue
        Me.Label16.Location = New System.Drawing.Point(423, 17)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(71, 13)
        Me.Label16.TabIndex = 12
        Me.Label16.Text = "Applicant 2"
        '
        'txtCustomerNIC1
        '
        Me.txtCustomerNIC1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerNIC1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNIC1.Location = New System.Drawing.Point(100, 117)
        Me.txtCustomerNIC1.Name = "txtCustomerNIC1"
        Me.txtCustomerNIC1.ReadOnly = True
        Me.txtCustomerNIC1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerNIC1.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(8, 120)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "NIC #"
        '
        'txtCustomerMobile1
        '
        Me.txtCustomerMobile1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerMobile1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerMobile1.Location = New System.Drawing.Point(100, 96)
        Me.txtCustomerMobile1.Name = "txtCustomerMobile1"
        Me.txtCustomerMobile1.ReadOnly = True
        Me.txtCustomerMobile1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerMobile1.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(8, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mobile #"
        '
        'txtCustomerTel1
        '
        Me.txtCustomerTel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerTel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerTel1.Location = New System.Drawing.Point(100, 75)
        Me.txtCustomerTel1.Name = "txtCustomerTel1"
        Me.txtCustomerTel1.ReadOnly = True
        Me.txtCustomerTel1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerTel1.TabIndex = 7
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(8, 78)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(35, 13)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Tel # "
        '
        'txtCustomerName1
        '
        Me.txtCustomerName1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerName1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName1.Location = New System.Drawing.Point(100, 54)
        Me.txtCustomerName1.Name = "txtCustomerName1"
        Me.txtCustomerName1.ReadOnly = True
        Me.txtCustomerName1.Size = New System.Drawing.Size(317, 20)
        Me.txtCustomerName1.TabIndex = 5
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(8, 57)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(82, 13)
        Me.Label20.TabIndex = 4
        Me.Label20.Text = "Customer Name"
        '
        'txtCustomerCode1
        '
        Me.txtCustomerCode1.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCustomerCode1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode1.Location = New System.Drawing.Point(100, 32)
        Me.txtCustomerCode1.Name = "txtCustomerCode1"
        Me.txtCustomerCode1.ReadOnly = True
        Me.txtCustomerCode1.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerCode1.TabIndex = 3
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(8, 35)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(79, 13)
        Me.Label22.TabIndex = 2
        Me.Label22.Text = "Customer Code"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(8, 17)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(71, 13)
        Me.Label23.TabIndex = 1
        Me.Label23.Text = "Applicant 1"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.chkNotDecided)
        Me.GroupBox3.Controls.Add(Me.cmdPaymentType)
        Me.GroupBox3.Controls.Add(Me.cmdExtraCharges)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txtInstallments)
        Me.GroupBox3.Controls.Add(Me.txtAmount)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.txtDueDate)
        Me.GroupBox3.Controls.Add(Me.cmbExtraCharges)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.cmbPaymentType)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(12, 378)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(831, 152)
        Me.GroupBox3.TabIndex = 297
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Payment Details"
        '
        'chkNotDecided
        '
        Me.chkNotDecided.AutoSize = True
        Me.chkNotDecided.Enabled = False
        Me.chkNotDecided.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkNotDecided.Location = New System.Drawing.Point(251, 80)
        Me.chkNotDecided.Name = "chkNotDecided"
        Me.chkNotDecided.Size = New System.Drawing.Size(86, 17)
        Me.chkNotDecided.TabIndex = 308
        Me.chkNotDecided.Text = "Not Decided"
        Me.chkNotDecided.UseVisualStyleBackColor = True
        '
        'cmdPaymentType
        '
        Me.cmdPaymentType.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdPaymentType.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdPaymentType.Location = New System.Drawing.Point(375, 24)
        Me.cmdPaymentType.Name = "cmdPaymentType"
        Me.cmdPaymentType.Size = New System.Drawing.Size(22, 21)
        Me.cmdPaymentType.TabIndex = 307
        Me.cmdPaymentType.UseVisualStyleBackColor = True
        '
        'cmdExtraCharges
        '
        Me.cmdExtraCharges.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdExtraCharges.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdExtraCharges.Location = New System.Drawing.Point(375, 51)
        Me.cmdExtraCharges.Name = "cmdExtraCharges"
        Me.cmdExtraCharges.Size = New System.Drawing.Size(22, 21)
        Me.cmdExtraCharges.TabIndex = 306
        Me.cmdExtraCharges.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(248, 106)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 13)
        Me.Label13.TabIndex = 305
        Me.Label13.Text = "Installment"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(8, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(43, 13)
        Me.Label12.TabIndex = 304
        Me.Label12.Text = "Amount"
        '
        'txtInstallments
        '
        Me.txtInstallments.AutoSize = False
        Me.txtInstallments.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtInstallments.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtInstallments.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtInstallments.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtInstallments.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtInstallments.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInstallments.Location = New System.Drawing.Point(322, 104)
        Me.txtInstallments.Name = "txtInstallments"
        Me.txtInstallments.ReadOnly = True
        Me.txtInstallments.Size = New System.Drawing.Size(50, 20)
        Me.txtInstallments.TabIndex = 303
        Me.txtInstallments.Tag = Nothing
        Me.txtInstallments.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtInstallments.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtInstallments.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtInstallments.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtInstallments.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtAmount
        '
        Me.txtAmount.AutoSize = False
        Me.txtAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmount.Location = New System.Drawing.Point(96, 104)
        Me.txtAmount.Name = "txtAmount"
        Me.txtAmount.ReadOnly = True
        Me.txtAmount.Size = New System.Drawing.Size(127, 20)
        Me.txtAmount.TabIndex = 302
        Me.txtAmount.Tag = Nothing
        Me.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(8, 82)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(50, 13)
        Me.Label11.TabIndex = 301
        Me.Label11.Text = "DueDate"
        '
        'txtDueDate
        '
        Me.txtDueDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDueDate.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDueDate.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDueDate.Calendar.ClearText = "&Clear"
        Me.txtDueDate.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDate.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDueDate.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDueDate.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDueDate.Calendar.TodayText = "&Today"
        Me.txtDueDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDueDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDueDate.Culture = 1056
        Me.txtDueDate.CustomFormat = "dd/MM/yyyy"
        Me.txtDueDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDueDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDueDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDueDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDueDate.Location = New System.Drawing.Point(97, 78)
        Me.txtDueDate.Name = "txtDueDate"
        Me.txtDueDate.ReadOnly = True
        Me.txtDueDate.Size = New System.Drawing.Size(126, 19)
        Me.txtDueDate.TabIndex = 300
        Me.txtDueDate.Tag = Nothing
        Me.txtDueDate.TrimEnd = False
        Me.txtDueDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDueDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDueDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmbExtraCharges
        '
        Me.cmbExtraCharges.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbExtraCharges.Caption = ""
        Me.cmbExtraCharges.CaptionHeight = 17
        Me.cmbExtraCharges.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbExtraCharges.ColumnCaptionHeight = 17
        Me.cmbExtraCharges.ColumnFooterHeight = 17
        Me.cmbExtraCharges.ContentHeight = 15
        Me.cmbExtraCharges.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbExtraCharges.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbExtraCharges.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExtraCharges.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbExtraCharges.EditorHeight = 15
        Me.cmbExtraCharges.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbExtraCharges.Images.Add(CType(resources.GetObject("cmbExtraCharges.Images"), System.Drawing.Image))
        Me.cmbExtraCharges.ItemHeight = 15
        Me.cmbExtraCharges.Location = New System.Drawing.Point(97, 51)
        Me.cmbExtraCharges.MatchEntryTimeout = CType(2000, Long)
        Me.cmbExtraCharges.MaxDropDownItems = CType(5, Short)
        Me.cmbExtraCharges.MaxLength = 32767
        Me.cmbExtraCharges.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbExtraCharges.Name = "cmbExtraCharges"
        Me.cmbExtraCharges.ReadOnly = True
        Me.cmbExtraCharges.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbExtraCharges.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbExtraCharges.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbExtraCharges.Size = New System.Drawing.Size(278, 21)
        Me.cmbExtraCharges.TabIndex = 298
        Me.cmbExtraCharges.PropBag = resources.GetString("cmbExtraCharges.PropBag")
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(8, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 13)
        Me.Label5.TabIndex = 299
        Me.Label5.Text = "Extra Charges"
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
        Me.cmbPaymentType.Location = New System.Drawing.Point(97, 26)
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
        Me.cmbPaymentType.TabIndex = 296
        Me.cmbPaymentType.PropBag = resources.GetString("cmbPaymentType.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(8, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 297
        Me.Label4.Text = "Payment Type"
        '
        'frmInvoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(848, 542)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmInvoice"
        Me.Text = "Invoice"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.txtInstallments, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDueDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbExtraCharges, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbPaymentType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmbUnit As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmdUnitType As System.Windows.Forms.Button
    Friend WithEvents cmdUnit As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtCustomerEmail2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNIC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerMobile2 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel2 As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName2 As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode2 As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerEmail1 As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNIC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerMobile1 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel1 As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName1 As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode1 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdPaymentType As System.Windows.Forms.Button
    Friend WithEvents cmdExtraCharges As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtInstallments As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtDueDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbExtraCharges As C1.Win.C1List.C1Combo
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbPaymentType As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents chkNotDecided As System.Windows.Forms.CheckBox
    'Friend WithEvents CachedReport1 As CrystalDecisions.ReportSource.CachedReport
End Class
