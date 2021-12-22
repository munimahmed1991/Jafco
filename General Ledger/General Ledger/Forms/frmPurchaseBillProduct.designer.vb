<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPurchaseBillProduct
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPurchaseBillProduct))
        Dim Style1 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style2 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style3 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style4 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style5 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style6 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style7 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style8 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style9 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Dim Style10 As C1.Win.C1TrueDBGrid.Style = New C1.Win.C1TrueDBGrid.Style()
        Me.cmdRefresh = New System.Windows.Forms.Button()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUndo = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtInvoiceDate = New C1.Win.C1Input.C1DateEdit()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtInvoiceNo = New System.Windows.Forms.TextBox()
        Me.txtDescription = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbSupplierAccount = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbProject = New C1.Win.C1List.C1Combo()
        Me.cmbSupplier = New C1.Win.C1List.C1Combo()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtBillDate = New C1.Win.C1Input.C1DateEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBillNo = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.tdbProduct = New C1.Win.C1TrueDBGrid.C1TrueDBDropdown()
        Me.cmdPickArticle = New System.Windows.Forms.Button()
        Me.tdbGridBillDetail = New C1.Win.C1TrueDBGrid.C1TrueDBGrid()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtAdvanceTax = New C1.Win.C1Input.C1NumericEdit()
        Me.cmbAddOtherAccount = New C1.Win.C1List.C1Combo()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmbLessOtherAccount = New C1.Win.C1List.C1Combo()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAddOther = New C1.Win.C1Input.C1NumericEdit()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtNetAmount = New C1.Win.C1Input.C1NumericEdit()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtLessOther = New C1.Win.C1Input.C1NumericEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtDiscount = New C1.Win.C1Input.C1NumericEdit()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtSalesTax = New C1.Win.C1Input.C1NumericEdit()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtGrossAmount = New C1.Win.C1Input.C1NumericEdit()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtDateFrom = New C1.Win.C1Input.C1DateEdit()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.cmdPrint = New System.Windows.Forms.Button()
        Me.cmdVoucher = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupplierAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbSupplier, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtBillDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.tdbProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbGridBillDetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.txtAdvanceTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbAddOtherAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbLessOtherAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAddOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtNetAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtLessOther, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtSalesTax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtGrossAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdRefresh.Location = New System.Drawing.Point(495, 7)
        Me.cmdRefresh.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(73, 69)
        Me.cmdRefresh.TabIndex = 150
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(704, 7)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(68, 69)
        Me.cmdAdd.TabIndex = 143
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(1043, 7)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(68, 69)
        Me.cmdExit.TabIndex = 149
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(976, 7)
        Me.cmdUndo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(68, 69)
        Me.cmdUndo.TabIndex = 148
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(569, 7)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(68, 69)
        Me.cmdSearch.TabIndex = 144
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(772, 7)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(68, 69)
        Me.cmdEdit.TabIndex = 146
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(840, 7)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(68, 69)
        Me.cmdSave.TabIndex = 145
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(358, 76)
        Me.ToolStripLabel1.Text = "Purchase Bill Product"
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(908, 7)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(68, 69)
        Me.cmdDelete.TabIndex = 147
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(1119, 79)
        Me.ToolStrip1.TabIndex = 142
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceDate)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txtInvoiceNo)
        Me.GroupBox1.Controls.Add(Me.txtDescription)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cmbSupplierAccount)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmbProject)
        Me.GroupBox1.Controls.Add(Me.cmbSupplier)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtBillDate)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtBillNo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1099, 205)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(297, 81)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 17)
        Me.Label3.TabIndex = 214
        Me.Label3.Text = "Invoice Date"
        '
        'txtInvoiceDate
        '
        Me.txtInvoiceDate.AllowSpinLoop = False
        Me.txtInvoiceDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtInvoiceDate.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtInvoiceDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtInvoiceDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtInvoiceDate.Culture = 1056
        Me.txtInvoiceDate.CustomFormat = "dd/MM/yyyy"
        Me.txtInvoiceDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtInvoiceDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtInvoiceDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtInvoiceDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtInvoiceDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtInvoiceDate.Location = New System.Drawing.Point(404, 78)
        Me.txtInvoiceDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceDate.Name = "txtInvoiceDate"
        Me.txtInvoiceDate.Size = New System.Drawing.Size(183, 22)
        Me.txtInvoiceDate.TabIndex = 215
        Me.txtInvoiceDate.Tag = Nothing
        Me.txtInvoiceDate.TrimEnd = False
        Me.txtInvoiceDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtInvoiceDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtInvoiceDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 81)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(64, 17)
        Me.Label16.TabIndex = 213
        Me.Label16.Text = "Invoice #"
        '
        'txtInvoiceNo
        '
        Me.txtInvoiceNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtInvoiceNo.Location = New System.Drawing.Point(139, 78)
        Me.txtInvoiceNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtInvoiceNo.Name = "txtInvoiceNo"
        Me.txtInvoiceNo.Size = New System.Drawing.Size(132, 22)
        Me.txtInvoiceNo.TabIndex = 212
        '
        'txtDescription
        '
        Me.txtDescription.BackColor = System.Drawing.Color.White
        Me.txtDescription.Location = New System.Drawing.Point(139, 168)
        Me.txtDescription.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDescription.MaxLength = 25
        Me.txtDescription.Name = "txtDescription"
        Me.txtDescription.Size = New System.Drawing.Size(448, 22)
        Me.txtDescription.TabIndex = 207
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 171)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 17)
        Me.Label5.TabIndex = 206
        Me.Label5.Text = "Description"
        '
        'cmbSupplierAccount
        '
        Me.cmbSupplierAccount.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSupplierAccount.Caption = ""
        Me.cmbSupplierAccount.CaptionHeight = 17
        Me.cmbSupplierAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSupplierAccount.ColumnCaptionHeight = 17
        Me.cmbSupplierAccount.ColumnFooterHeight = 17
        Me.cmbSupplierAccount.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSupplierAccount.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSupplierAccount.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSupplierAccount.Images.Add(CType(resources.GetObject("cmbSupplierAccount.Images"), System.Drawing.Image))
        Me.cmbSupplierAccount.ItemHeight = 15
        Me.cmbSupplierAccount.Location = New System.Drawing.Point(139, 138)
        Me.cmbSupplierAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSupplierAccount.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSupplierAccount.MaxDropDownItems = CType(5, Short)
        Me.cmbSupplierAccount.MaxLength = 32767
        Me.cmbSupplierAccount.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSupplierAccount.Name = "cmbSupplierAccount"
        Me.cmbSupplierAccount.ReadOnly = True
        Me.cmbSupplierAccount.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSupplierAccount.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSupplierAccount.Size = New System.Drawing.Size(448, 23)
        Me.cmbSupplierAccount.TabIndex = 203
        Me.cmbSupplierAccount.PropBag = resources.GetString("cmbSupplierAccount.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(9, 141)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 17)
        Me.Label4.TabIndex = 204
        Me.Label4.Text = "Supplier Account"
        '
        'cmbProject
        '
        Me.cmbProject.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbProject.Caption = ""
        Me.cmbProject.CaptionHeight = 17
        Me.cmbProject.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbProject.ColumnCaptionHeight = 17
        Me.cmbProject.ColumnFooterHeight = 17
        Me.cmbProject.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbProject.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbProject.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProject.Images.Add(CType(resources.GetObject("cmbProject.Images"), System.Drawing.Image))
        Me.cmbProject.ItemHeight = 15
        Me.cmbProject.Location = New System.Drawing.Point(139, 18)
        Me.cmbProject.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(447, 23)
        Me.cmbProject.TabIndex = 197
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'cmbSupplier
        '
        Me.cmbSupplier.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSupplier.Caption = ""
        Me.cmbSupplier.CaptionHeight = 17
        Me.cmbSupplier.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSupplier.ColumnCaptionHeight = 17
        Me.cmbSupplier.ColumnFooterHeight = 17
        Me.cmbSupplier.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSupplier.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSupplier.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSupplier.Images.Add(CType(resources.GetObject("cmbSupplier.Images"), System.Drawing.Image))
        Me.cmbSupplier.ItemHeight = 15
        Me.cmbSupplier.Location = New System.Drawing.Point(139, 108)
        Me.cmbSupplier.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbSupplier.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSupplier.MaxDropDownItems = CType(5, Short)
        Me.cmbSupplier.MaxLength = 32767
        Me.cmbSupplier.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSupplier.Name = "cmbSupplier"
        Me.cmbSupplier.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSupplier.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSupplier.Size = New System.Drawing.Size(448, 23)
        Me.cmbSupplier.TabIndex = 197
        Me.cmbSupplier.PropBag = resources.GetString("cmbSupplier.PropBag")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 21)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(52, 17)
        Me.Label18.TabIndex = 198
        Me.Label18.Text = "Project"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 111)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 17)
        Me.Label6.TabIndex = 198
        Me.Label6.Text = "Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(297, 51)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 17)
        Me.Label2.TabIndex = 195
        Me.Label2.Text = "Bill Date"
        '
        'txtBillDate
        '
        Me.txtBillDate.AllowSpinLoop = False
        Me.txtBillDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtBillDate.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtBillDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtBillDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtBillDate.Culture = 1056
        Me.txtBillDate.CustomFormat = "dd/MM/yyyy"
        Me.txtBillDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtBillDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtBillDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBillDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtBillDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtBillDate.Location = New System.Drawing.Point(404, 48)
        Me.txtBillDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBillDate.Name = "txtBillDate"
        Me.txtBillDate.Size = New System.Drawing.Size(183, 22)
        Me.txtBillDate.TabIndex = 196
        Me.txtBillDate.Tag = Nothing
        Me.txtBillDate.TrimEnd = False
        Me.txtBillDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtBillDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtBillDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 51)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 17)
        Me.Label1.TabIndex = 145
        Me.Label1.Text = "Bill #"
        '
        'txtBillNo
        '
        Me.txtBillNo.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtBillNo.Location = New System.Drawing.Point(139, 48)
        Me.txtBillNo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtBillNo.Name = "txtBillNo"
        Me.txtBillNo.Size = New System.Drawing.Size(132, 22)
        Me.txtBillNo.TabIndex = 144
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 340)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1099, 321)
        Me.TabControl1.TabIndex = 152
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tdbProduct)
        Me.TabPage1.Controls.Add(Me.cmdPickArticle)
        Me.TabPage1.Controls.Add(Me.tdbGridBillDetail)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage1.Size = New System.Drawing.Size(1091, 292)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Item Details"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'tdbProduct
        '
        Me.tdbProduct.AllowColMove = True
        Me.tdbProduct.AllowColSelect = True
        Me.tdbProduct.AllowRowSizing = C1.Win.C1TrueDBGrid.RowSizingEnum.AllRows
        Me.tdbProduct.AlternatingRows = False
        Me.tdbProduct.CaptionHeight = 19
        Me.tdbProduct.CaptionStyle = Style1
        Me.tdbProduct.ColumnCaptionHeight = 17
        Me.tdbProduct.ColumnFooterHeight = 17
        Me.tdbProduct.ColumnSelectorStyle = Style2
        Me.tdbProduct.EvenRowStyle = Style3
        Me.tdbProduct.FetchRowStyles = False
        Me.tdbProduct.FooterStyle = Style4
        Me.tdbProduct.HeadingStyle = Style5
        Me.tdbProduct.HighLightRowStyle = Style6
        Me.tdbProduct.Images.Add(CType(resources.GetObject("tdbProduct.Images"), System.Drawing.Image))
        Me.tdbProduct.Location = New System.Drawing.Point(59, 94)
        Me.tdbProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbProduct.Name = "tdbProduct"
        Me.tdbProduct.OddRowStyle = Style7
        Me.tdbProduct.RecordSelectorStyle = Style8
        Me.tdbProduct.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.tdbProduct.RowDivider.Style = C1.Win.C1TrueDBGrid.LineStyleEnum.[Single]
        Me.tdbProduct.RowHeight = 17
        Me.tdbProduct.RowSelectorStyle = Style9
        Me.tdbProduct.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.tdbProduct.ScrollTips = False
        Me.tdbProduct.Size = New System.Drawing.Size(940, 101)
        Me.tdbProduct.Style = Style10
        Me.tdbProduct.TabIndex = 199
        Me.tdbProduct.TabStop = False
        Me.tdbProduct.Text = "C1TrueDBDropdown1"
        Me.tdbProduct.UseCompatibleTextRendering = False
        Me.tdbProduct.ValueTranslate = True
        Me.tdbProduct.Visible = False
        Me.tdbProduct.PropBag = resources.GetString("tdbProduct.PropBag")
        '
        'cmdPickArticle
        '
        Me.cmdPickArticle.Location = New System.Drawing.Point(5, 252)
        Me.cmdPickArticle.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPickArticle.Name = "cmdPickArticle"
        Me.cmdPickArticle.Size = New System.Drawing.Size(147, 28)
        Me.cmdPickArticle.TabIndex = 198
        Me.cmdPickArticle.Text = "Pick Product"
        Me.cmdPickArticle.UseVisualStyleBackColor = True
        '
        'tdbGridBillDetail
        '
        Me.tdbGridBillDetail.AllowDelete = True
        Me.tdbGridBillDetail.CaptionHeight = 19
        Me.tdbGridBillDetail.ColumnFooters = True
        Me.tdbGridBillDetail.EmptyRows = True
        Me.tdbGridBillDetail.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbGridBillDetail.Images.Add(CType(resources.GetObject("tdbGridBillDetail.Images"), System.Drawing.Image))
        Me.tdbGridBillDetail.Images.Add(CType(resources.GetObject("tdbGridBillDetail.Images1"), System.Drawing.Image))
        Me.tdbGridBillDetail.Images.Add(CType(resources.GetObject("tdbGridBillDetail.Images2"), System.Drawing.Image))
        Me.tdbGridBillDetail.Location = New System.Drawing.Point(9, 7)
        Me.tdbGridBillDetail.Margin = New System.Windows.Forms.Padding(4)
        Me.tdbGridBillDetail.Name = "tdbGridBillDetail"
        Me.tdbGridBillDetail.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbGridBillDetail.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbGridBillDetail.PreviewInfo.ZoomFactor = 75.0R
        Me.tdbGridBillDetail.PrintInfo.MeasurementDevice = C1.Win.C1TrueDBGrid.PrintInfo.MeasurementDeviceEnum.Screen
        Me.tdbGridBillDetail.PrintInfo.MeasurementPrinterName = Nothing
        Me.tdbGridBillDetail.PrintInfo.PageSettings = CType(resources.GetObject("tdbGridBillDetail.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbGridBillDetail.RecordSelectors = False
        Me.tdbGridBillDetail.RowHeight = 17
        Me.tdbGridBillDetail.Size = New System.Drawing.Size(1069, 241)
        Me.tdbGridBillDetail.TabIndex = 197
        Me.tdbGridBillDetail.Text = "c"
        Me.tdbGridBillDetail.UseCompatibleTextRendering = False
        Me.tdbGridBillDetail.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdbGridBillDetail.WrapCellPointer = True
        Me.tdbGridBillDetail.PropBag = resources.GetString("tdbGridBillDetail.PropBag")
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label19)
        Me.TabPage2.Controls.Add(Me.txtAdvanceTax)
        Me.TabPage2.Controls.Add(Me.cmbAddOtherAccount)
        Me.TabPage2.Controls.Add(Me.Label14)
        Me.TabPage2.Controls.Add(Me.cmbLessOtherAccount)
        Me.TabPage2.Controls.Add(Me.Label13)
        Me.TabPage2.Controls.Add(Me.Label12)
        Me.TabPage2.Controls.Add(Me.txtAddOther)
        Me.TabPage2.Controls.Add(Me.Label11)
        Me.TabPage2.Controls.Add(Me.txtNetAmount)
        Me.TabPage2.Controls.Add(Me.Label10)
        Me.TabPage2.Controls.Add(Me.txtLessOther)
        Me.TabPage2.Controls.Add(Me.Label9)
        Me.TabPage2.Controls.Add(Me.txtDiscount)
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.txtSalesTax)
        Me.TabPage2.Controls.Add(Me.Label15)
        Me.TabPage2.Controls.Add(Me.txtGrossAmount)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(4)
        Me.TabPage2.Size = New System.Drawing.Size(1091, 292)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Bill Summary"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(11, 217)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(123, 17)
        Me.Label19.TabIndex = 268
        Me.Label19.Text = "Add: Advance Tax"
        '
        'txtAdvanceTax
        '
        Me.txtAdvanceTax.AutoSize = False
        Me.txtAdvanceTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtAdvanceTax.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtAdvanceTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAdvanceTax.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtAdvanceTax.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtAdvanceTax.Location = New System.Drawing.Point(163, 214)
        Me.txtAdvanceTax.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAdvanceTax.Name = "txtAdvanceTax"
        Me.txtAdvanceTax.ReadOnly = True
        Me.txtAdvanceTax.Size = New System.Drawing.Size(117, 25)
        Me.txtAdvanceTax.TabIndex = 267
        Me.txtAdvanceTax.Tag = Nothing
        Me.txtAdvanceTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAdvanceTax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAdvanceTax.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtAdvanceTax.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtAdvanceTax.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmbAddOtherAccount
        '
        Me.cmbAddOtherAccount.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbAddOtherAccount.Caption = ""
        Me.cmbAddOtherAccount.CaptionHeight = 17
        Me.cmbAddOtherAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbAddOtherAccount.ColumnCaptionHeight = 17
        Me.cmbAddOtherAccount.ColumnFooterHeight = 17
        Me.cmbAddOtherAccount.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbAddOtherAccount.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbAddOtherAccount.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbAddOtherAccount.Images.Add(CType(resources.GetObject("cmbAddOtherAccount.Images"), System.Drawing.Image))
        Me.cmbAddOtherAccount.ItemHeight = 15
        Me.cmbAddOtherAccount.Location = New System.Drawing.Point(369, 175)
        Me.cmbAddOtherAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbAddOtherAccount.MatchEntryTimeout = CType(2000, Long)
        Me.cmbAddOtherAccount.MaxDropDownItems = CType(5, Short)
        Me.cmbAddOtherAccount.MaxLength = 32767
        Me.cmbAddOtherAccount.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbAddOtherAccount.Name = "cmbAddOtherAccount"
        Me.cmbAddOtherAccount.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbAddOtherAccount.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbAddOtherAccount.Size = New System.Drawing.Size(272, 23)
        Me.cmbAddOtherAccount.TabIndex = 265
        Me.cmbAddOtherAccount.PropBag = resources.GetString("cmbAddOtherAccount.PropBag")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(297, 180)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 17)
        Me.Label14.TabIndex = 266
        Me.Label14.Text = "Account"
        '
        'cmbLessOtherAccount
        '
        Me.cmbLessOtherAccount.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbLessOtherAccount.Caption = ""
        Me.cmbLessOtherAccount.CaptionHeight = 17
        Me.cmbLessOtherAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbLessOtherAccount.ColumnCaptionHeight = 17
        Me.cmbLessOtherAccount.ColumnFooterHeight = 17
        Me.cmbLessOtherAccount.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbLessOtherAccount.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbLessOtherAccount.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbLessOtherAccount.Images.Add(CType(resources.GetObject("cmbLessOtherAccount.Images"), System.Drawing.Image))
        Me.cmbLessOtherAccount.ItemHeight = 15
        Me.cmbLessOtherAccount.Location = New System.Drawing.Point(369, 133)
        Me.cmbLessOtherAccount.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbLessOtherAccount.MatchEntryTimeout = CType(2000, Long)
        Me.cmbLessOtherAccount.MaxDropDownItems = CType(5, Short)
        Me.cmbLessOtherAccount.MaxLength = 32767
        Me.cmbLessOtherAccount.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbLessOtherAccount.Name = "cmbLessOtherAccount"
        Me.cmbLessOtherAccount.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbLessOtherAccount.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbLessOtherAccount.Size = New System.Drawing.Size(272, 23)
        Me.cmbLessOtherAccount.TabIndex = 263
        Me.cmbLessOtherAccount.PropBag = resources.GetString("cmbLessOtherAccount.PropBag")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(297, 138)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(59, 17)
        Me.Label13.TabIndex = 264
        Me.Label13.Text = "Account"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 180)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(138, 17)
        Me.Label12.TabIndex = 262
        Me.Label12.Text = "Add : Other Charges"
        '
        'txtAddOther
        '
        Me.txtAddOther.AutoSize = False
        Me.txtAddOther.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtAddOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddOther.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtAddOther.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtAddOther.Location = New System.Drawing.Point(163, 175)
        Me.txtAddOther.Margin = New System.Windows.Forms.Padding(4)
        Me.txtAddOther.Name = "txtAddOther"
        Me.txtAddOther.Size = New System.Drawing.Size(117, 25)
        Me.txtAddOther.TabIndex = 261
        Me.txtAddOther.Tag = Nothing
        Me.txtAddOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtAddOther.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtAddOther.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtAddOther.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtAddOther.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(11, 256)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(82, 17)
        Me.Label11.TabIndex = 260
        Me.Label11.Text = "Net Amount"
        '
        'txtNetAmount
        '
        Me.txtNetAmount.AutoSize = False
        Me.txtNetAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtNetAmount.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtNetAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNetAmount.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtNetAmount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtNetAmount.Location = New System.Drawing.Point(163, 254)
        Me.txtNetAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtNetAmount.Name = "txtNetAmount"
        Me.txtNetAmount.ReadOnly = True
        Me.txtNetAmount.Size = New System.Drawing.Size(117, 25)
        Me.txtNetAmount.TabIndex = 259
        Me.txtNetAmount.Tag = Nothing
        Me.txtNetAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtNetAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtNetAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtNetAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtNetAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 138)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(143, 17)
        Me.Label10.TabIndex = 258
        Me.Label10.Text = "Less : Other Charges"
        '
        'txtLessOther
        '
        Me.txtLessOther.AutoSize = False
        Me.txtLessOther.BackColor = System.Drawing.Color.White
        Me.txtLessOther.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtLessOther.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLessOther.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtLessOther.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtLessOther.Location = New System.Drawing.Point(163, 133)
        Me.txtLessOther.Margin = New System.Windows.Forms.Padding(4)
        Me.txtLessOther.Name = "txtLessOther"
        Me.txtLessOther.Size = New System.Drawing.Size(117, 25)
        Me.txtLessOther.TabIndex = 257
        Me.txtLessOther.Tag = Nothing
        Me.txtLessOther.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtLessOther.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtLessOther.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtLessOther.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtLessOther.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(11, 95)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(105, 17)
        Me.Label9.TabIndex = 256
        Me.Label9.Text = "Less : Discount"
        '
        'txtDiscount
        '
        Me.txtDiscount.AutoSize = False
        Me.txtDiscount.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtDiscount.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDiscount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDiscount.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDiscount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDiscount.Location = New System.Drawing.Point(163, 92)
        Me.txtDiscount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.ReadOnly = True
        Me.txtDiscount.Size = New System.Drawing.Size(117, 25)
        Me.txtDiscount.TabIndex = 255
        Me.txtDiscount.Tag = Nothing
        Me.txtDiscount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDiscount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDiscount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtDiscount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtDiscount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 57)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(107, 17)
        Me.Label8.TabIndex = 254
        Me.Label8.Text = "Add : Sales Tax"
        '
        'txtSalesTax
        '
        Me.txtSalesTax.AutoSize = False
        Me.txtSalesTax.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtSalesTax.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtSalesTax.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSalesTax.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtSalesTax.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtSalesTax.Location = New System.Drawing.Point(163, 54)
        Me.txtSalesTax.Margin = New System.Windows.Forms.Padding(4)
        Me.txtSalesTax.Name = "txtSalesTax"
        Me.txtSalesTax.ReadOnly = True
        Me.txtSalesTax.Size = New System.Drawing.Size(117, 25)
        Me.txtSalesTax.TabIndex = 253
        Me.txtSalesTax.Tag = Nothing
        Me.txtSalesTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtSalesTax.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtSalesTax.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtSalesTax.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtSalesTax.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(11, 20)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 17)
        Me.Label15.TabIndex = 252
        Me.Label15.Text = "Gross Amount"
        '
        'txtGrossAmount
        '
        Me.txtGrossAmount.AutoSize = False
        Me.txtGrossAmount.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtGrossAmount.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtGrossAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtGrossAmount.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.CustomFormat) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtGrossAmount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtGrossAmount.Location = New System.Drawing.Point(163, 17)
        Me.txtGrossAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtGrossAmount.Name = "txtGrossAmount"
        Me.txtGrossAmount.ReadOnly = True
        Me.txtGrossAmount.Size = New System.Drawing.Size(117, 25)
        Me.txtGrossAmount.TabIndex = 251
        Me.txtGrossAmount.Tag = Nothing
        Me.txtGrossAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtGrossAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtGrossAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtGrossAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtGrossAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtDateTo)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtDateFrom)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(11, 84)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(1101, 49)
        Me.GroupBox2.TabIndex = 201
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Tag = ""
        Me.GroupBox2.Text = "Searching Criterea"
        '
        'txtDateTo
        '
        Me.txtDateTo.AllowSpinLoop = False
        Me.txtDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateTo.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtDateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.Culture = 1056
        Me.txtDateTo.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDateTo.Location = New System.Drawing.Point(404, 18)
        Me.txtDateTo.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(183, 22)
        Me.txtDateTo.TabIndex = 197
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.TrimEnd = False
        Me.txtDateTo.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDateTo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(297, 21)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 18)
        Me.Label7.TabIndex = 196
        Me.Label7.Text = "Date  To :"
        '
        'txtDateFrom
        '
        Me.txtDateFrom.AllowSpinLoop = False
        Me.txtDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateFrom.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtDateFrom.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateFrom.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateFrom.Culture = 1056
        Me.txtDateFrom.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateFrom.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateFrom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateFrom.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateFrom.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDateFrom.Location = New System.Drawing.Point(113, 18)
        Me.txtDateFrom.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDateFrom.Name = "txtDateFrom"
        Me.txtDateFrom.Size = New System.Drawing.Size(168, 22)
        Me.txtDateFrom.TabIndex = 195
        Me.txtDateFrom.Tag = Nothing
        Me.txtDateFrom.TrimEnd = False
        Me.txtDateFrom.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDateFrom.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateFrom.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 21)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(91, 18)
        Me.Label17.TabIndex = 177
        Me.Label17.Text = "Date  From :"
        '
        'cmdPrint
        '
        Me.cmdPrint.Image = Global.General_Ledger.My.Resources.Resources.folder_document
        Me.cmdPrint.Location = New System.Drawing.Point(637, 7)
        Me.cmdPrint.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdPrint.Name = "cmdPrint"
        Me.cmdPrint.Size = New System.Drawing.Size(68, 69)
        Me.cmdPrint.TabIndex = 202
        Me.cmdPrint.Text = "&Print"
        Me.cmdPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdPrint.UseVisualStyleBackColor = True
        '
        'cmdVoucher
        '
        Me.cmdVoucher.Image = Global.General_Ledger.My.Resources.Resources.folder_document
        Me.cmdVoucher.Location = New System.Drawing.Point(412, 7)
        Me.cmdVoucher.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdVoucher.Name = "cmdVoucher"
        Me.cmdVoucher.Size = New System.Drawing.Size(83, 69)
        Me.cmdVoucher.TabIndex = 205
        Me.cmdVoucher.Text = "&Voucher"
        Me.cmdVoucher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdVoucher.UseVisualStyleBackColor = True
        '
        'frmPurchaseBillProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1119, 674)
        Me.Controls.Add(Me.cmdVoucher)
        Me.Controls.Add(Me.cmdPrint)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmPurchaseBillProduct"
        Me.Text = "Purchase Bill Accessory"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.txtInvoiceDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupplierAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbSupplier, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtBillDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.tdbProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbGridBillDetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.txtAdvanceTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbAddOtherAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbLessOtherAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAddOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtNetAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtLessOther, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtSalesTax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtGrossAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateFrom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtBillNo As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtBillDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmbSupplier As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbSupplierAccount As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDescription As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents tdbProduct As C1.Win.C1TrueDBGrid.C1TrueDBDropdown
    Friend WithEvents cmdPickArticle As System.Windows.Forms.Button
    Friend WithEvents tdbGridBillDetail As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents cmbAddOtherAccount As C1.Win.C1List.C1Combo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmbLessOtherAccount As C1.Win.C1List.C1Combo
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAddOther As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtNetAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtLessOther As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtDiscount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtSalesTax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtGrossAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtInvoiceNo As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtDateFrom As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents cmdPrint As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtAdvanceTax As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmdVoucher As Button
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label18 As Label
End Class
