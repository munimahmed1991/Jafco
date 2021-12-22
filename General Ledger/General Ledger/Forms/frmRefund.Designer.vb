<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmRefund
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRefund))
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUndo = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cmbUnitType = New C1.Win.C1List.C1Combo()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmdUnit = New System.Windows.Forms.Button()
        Me.cmbUnit = New C1.Win.C1List.C1Combo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.txtCustomerEmail = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.txtCustomerNIC = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtCustomerMobile = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtCustomerTel = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCustomerCode = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmbCredit = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmbDebit = New C1.Win.C1List.C1Combo()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.txtRemarks = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDeductionAmount = New C1.Win.C1Input.C1NumericEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtReceiptAmount = New C1.Win.C1Input.C1NumericEdit()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtRefundAmount = New C1.Win.C1Input.C1NumericEdit()
        Me.cmbProject = New C1.Win.C1List.C1Combo()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtDate = New C1.Win.C1Input.C1DateEdit()
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.chkPostToFinance = New System.Windows.Forms.CheckBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbCredit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbDebit, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDeductionAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtReceiptAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtRefundAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(414, 4)
        Me.cmdAdd.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(68, 65)
        Me.cmdAdd.TabIndex = 120
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(758, 4)
        Me.cmdExit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(68, 65)
        Me.cmdExit.TabIndex = 126
        Me.cmdExit.Text = "E&xit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdUndo
        '
        Me.cmdUndo.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdUndo.Location = New System.Drawing.Point(690, 4)
        Me.cmdUndo.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdUndo.Name = "cmdUndo"
        Me.cmdUndo.Size = New System.Drawing.Size(68, 65)
        Me.cmdUndo.TabIndex = 125
        Me.cmdUndo.Text = "&Undo"
        Me.cmdUndo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdUndo.UseVisualStyleBackColor = True
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(345, 4)
        Me.cmdSearch.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(68, 65)
        Me.cmdSearch.TabIndex = 121
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(484, 4)
        Me.cmdEdit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(68, 65)
        Me.cmdEdit.TabIndex = 123
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(553, 4)
        Me.cmdSave.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(68, 65)
        Me.cmdSave.TabIndex = 122
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(621, 4)
        Me.cmdDelete.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(68, 65)
        Me.cmdDelete.TabIndex = 124
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(834, 79)
        Me.ToolStrip1.TabIndex = 127
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Font = New System.Drawing.Font("Trebuchet MS", 24.0!, System.Drawing.FontStyle.Bold)
        Me.ToolStripLabel1.ForeColor = System.Drawing.SystemColors.Desktop
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(184, 76)
        Me.ToolStripLabel1.Text = "REFUND "
        '
        'cmbUnitType
        '
        Me.cmbUnitType.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbUnitType.Caption = ""
        Me.cmbUnitType.CaptionHeight = 17
        Me.cmbUnitType.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbUnitType.ColumnCaptionHeight = 17
        Me.cmbUnitType.ColumnFooterHeight = 17
        Me.cmbUnitType.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnitType.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnitType.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnitType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnitType.Images.Add(CType(resources.GetObject("cmbUnitType.Images"), System.Drawing.Image))
        Me.cmbUnitType.ItemHeight = 15
        Me.cmbUnitType.Location = New System.Drawing.Point(135, 125)
        Me.cmbUnitType.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnitType.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnitType.MaxDropDownItems = CType(5, Short)
        Me.cmbUnitType.MaxLength = 32767
        Me.cmbUnitType.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnitType.Name = "cmbUnitType"
        Me.cmbUnitType.ReadOnly = True
        Me.cmbUnitType.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnitType.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnitType.Size = New System.Drawing.Size(158, 24)
        Me.cmbUnitType.TabIndex = 252
        Me.cmbUnitType.PropBag = resources.GetString("cmbUnitType.PropBag")
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label27.Location = New System.Drawing.Point(12, 129)
        Me.Label27.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(68, 18)
        Me.Label27.TabIndex = 253
        Me.Label27.Text = "Unit Type"
        '
        'cmdUnit
        '
        Me.cmdUnit.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdUnit.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdUnit.Location = New System.Drawing.Point(292, 91)
        Me.cmdUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmdUnit.Name = "cmdUnit"
        Me.cmdUnit.Size = New System.Drawing.Size(29, 26)
        Me.cmdUnit.TabIndex = 251
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
        Me.cmbUnit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbUnit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbUnit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbUnit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit.Images.Add(CType(resources.GetObject("cmbUnit.Images"), System.Drawing.Image))
        Me.cmbUnit.ItemHeight = 15
        Me.cmbUnit.Location = New System.Drawing.Point(135, 92)
        Me.cmbUnit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbUnit.MatchEntryTimeout = CType(2000, Long)
        Me.cmbUnit.MaxDropDownItems = CType(5, Short)
        Me.cmbUnit.MaxLength = 32767
        Me.cmbUnit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbUnit.Name = "cmbUnit"
        Me.cmbUnit.ReadOnly = True
        Me.cmbUnit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbUnit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbUnit.Size = New System.Drawing.Size(158, 24)
        Me.cmbUnit.TabIndex = 249
        Me.cmbUnit.PropBag = resources.GetString("cmbUnit.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label21.Location = New System.Drawing.Point(12, 96)
        Me.Label21.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(48, 18)
        Me.Label21.TabIndex = 250
        Me.Label21.Text = "Unit # "
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label20.Location = New System.Drawing.Point(333, 96)
        Me.Label20.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(24, 18)
        Me.Label20.TabIndex = 246
        Me.Label20.Text = "CC"
        '
        'txtCC
        '
        Me.txtCC.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCC.Location = New System.Drawing.Point(391, 93)
        Me.txtCC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCC.Name = "txtCC"
        Me.txtCC.ReadOnly = True
        Me.txtCC.Size = New System.Drawing.Size(165, 23)
        Me.txtCC.TabIndex = 247
        '
        'txtCustomerEmail
        '
        Me.txtCustomerEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerEmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerEmail.Location = New System.Drawing.Point(135, 318)
        Me.txtCustomerEmail.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerEmail.Name = "txtCustomerEmail"
        Me.txtCustomerEmail.ReadOnly = True
        Me.txtCustomerEmail.Size = New System.Drawing.Size(421, 23)
        Me.txtCustomerEmail.TabIndex = 245
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label17.Location = New System.Drawing.Point(12, 321)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(42, 18)
        Me.Label17.TabIndex = 244
        Me.Label17.Text = "Email"
        '
        'txtCustomerNIC
        '
        Me.txtCustomerNIC.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerNIC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerNIC.Location = New System.Drawing.Point(135, 286)
        Me.txtCustomerNIC.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerNIC.Name = "txtCustomerNIC"
        Me.txtCustomerNIC.ReadOnly = True
        Me.txtCustomerNIC.Size = New System.Drawing.Size(158, 23)
        Me.txtCustomerNIC.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label10.Location = New System.Drawing.Point(12, 289)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 18)
        Me.Label10.TabIndex = 10
        Me.Label10.Text = "NIC #"
        '
        'txtCustomerMobile
        '
        Me.txtCustomerMobile.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerMobile.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerMobile.Location = New System.Drawing.Point(135, 254)
        Me.txtCustomerMobile.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerMobile.Name = "txtCustomerMobile"
        Me.txtCustomerMobile.ReadOnly = True
        Me.txtCustomerMobile.Size = New System.Drawing.Size(158, 23)
        Me.txtCustomerMobile.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(12, 257)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(63, 18)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Mobile #"
        '
        'txtCustomerTel
        '
        Me.txtCustomerTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerTel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerTel.Location = New System.Drawing.Point(135, 222)
        Me.txtCustomerTel.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerTel.Name = "txtCustomerTel"
        Me.txtCustomerTel.ReadOnly = True
        Me.txtCustomerTel.Size = New System.Drawing.Size(158, 23)
        Me.txtCustomerTel.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(12, 225)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 18)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Tel # "
        '
        'txtCustomerName
        '
        Me.txtCustomerName.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.txtCustomerName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerName.Location = New System.Drawing.Point(135, 190)
        Me.txtCustomerName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.ReadOnly = True
        Me.txtCustomerName.Size = New System.Drawing.Size(421, 23)
        Me.txtCustomerName.TabIndex = 5
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(12, 193)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(108, 18)
        Me.Label7.TabIndex = 4
        Me.Label7.Text = "Customer Name"
        '
        'txtCustomerCode
        '
        Me.txtCustomerCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCustomerCode.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCustomerCode.Location = New System.Drawing.Point(135, 158)
        Me.txtCustomerCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCustomerCode.Name = "txtCustomerCode"
        Me.txtCustomerCode.ReadOnly = True
        Me.txtCustomerCode.Size = New System.Drawing.Size(158, 23)
        Me.txtCustomerCode.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label6.Location = New System.Drawing.Point(12, 161)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(103, 18)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Customer Code"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chkPostToFinance)
        Me.GroupBox2.Controls.Add(Me.cmbCredit)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbDebit)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.cmbUnitType)
        Me.GroupBox2.Controls.Add(Me.txtRemarks)
        Me.GroupBox2.Controls.Add(Me.txtCustomerEmail)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.txtDeductionAmount)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtCustomerNIC)
        Me.GroupBox2.Controls.Add(Me.txtReceiptAmount)
        Me.GroupBox2.Controls.Add(Me.cmdUnit)
        Me.GroupBox2.Controls.Add(Me.Label31)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtRefundAmount)
        Me.GroupBox2.Controls.Add(Me.cmbUnit)
        Me.GroupBox2.Controls.Add(Me.cmbProject)
        Me.GroupBox2.Controls.Add(Me.txtCustomerMobile)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.txtDate)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Controls.Add(Me.txtCC)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtCustomerTel)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.txtCustomerName)
        Me.GroupBox2.Controls.Add(Me.txtCustomerCode)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 83)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(821, 498)
        Me.GroupBox2.TabIndex = 130
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Refund Details"
        '
        'cmbCredit
        '
        Me.cmbCredit.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCredit.Caption = ""
        Me.cmbCredit.CaptionHeight = 17
        Me.cmbCredit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCredit.ColumnCaptionHeight = 17
        Me.cmbCredit.ColumnFooterHeight = 17
        Me.cmbCredit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCredit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCredit.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCredit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCredit.Images.Add(CType(resources.GetObject("cmbCredit.Images"), System.Drawing.Image))
        Me.cmbCredit.ItemHeight = 15
        Me.cmbCredit.Location = New System.Drawing.Point(135, 419)
        Me.cmbCredit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbCredit.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCredit.MaxDropDownItems = CType(5, Short)
        Me.cmbCredit.MaxLength = 32767
        Me.cmbCredit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCredit.Name = "cmbCredit"
        Me.cmbCredit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCredit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCredit.Size = New System.Drawing.Size(419, 24)
        Me.cmbCredit.TabIndex = 288
        Me.cmbCredit.PropBag = resources.GetString("cmbCredit.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(12, 423)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(99, 18)
        Me.Label4.TabIndex = 289
        Me.Label4.Text = "Credit Account"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'cmbDebit
        '
        Me.cmbDebit.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbDebit.Caption = ""
        Me.cmbDebit.CaptionHeight = 17
        Me.cmbDebit.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbDebit.ColumnCaptionHeight = 17
        Me.cmbDebit.ColumnFooterHeight = 17
        Me.cmbDebit.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbDebit.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbDebit.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbDebit.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbDebit.Images.Add(CType(resources.GetObject("cmbDebit.Images"), System.Drawing.Image))
        Me.cmbDebit.ItemHeight = 15
        Me.cmbDebit.Location = New System.Drawing.Point(135, 385)
        Me.cmbDebit.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbDebit.MatchEntryTimeout = CType(2000, Long)
        Me.cmbDebit.MaxDropDownItems = CType(5, Short)
        Me.cmbDebit.MaxLength = 32767
        Me.cmbDebit.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbDebit.Name = "cmbDebit"
        Me.cmbDebit.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbDebit.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbDebit.Size = New System.Drawing.Size(419, 24)
        Me.cmbDebit.TabIndex = 286
        Me.cmbDebit.PropBag = resources.GetString("cmbDebit.PropBag")
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label30.Location = New System.Drawing.Point(12, 389)
        Me.Label30.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(95, 18)
        Me.Label30.TabIndex = 287
        Me.Label30.Text = "Debit Account"
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'txtRemarks
        '
        Me.txtRemarks.Location = New System.Drawing.Point(135, 351)
        Me.txtRemarks.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRemarks.MaxLength = 200
        Me.txtRemarks.Name = "txtRemarks"
        Me.txtRemarks.Size = New System.Drawing.Size(672, 26)
        Me.txtRemarks.TabIndex = 277
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label19.Location = New System.Drawing.Point(12, 354)
        Me.Label19.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(61, 18)
        Me.Label19.TabIndex = 276
        Me.Label19.Text = "Remarks"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.Location = New System.Drawing.Point(570, 457)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 18)
        Me.Label2.TabIndex = 272
        Me.Label2.Text = "Deduction Amount"
        '
        'txtDeductionAmount
        '
        Me.txtDeductionAmount.AutoSize = False
        Me.txtDeductionAmount.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtDeductionAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtDeductionAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtDeductionAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtDeductionAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDeductionAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDeductionAmount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDeductionAmount.Location = New System.Drawing.Point(702, 453)
        Me.txtDeductionAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDeductionAmount.Name = "txtDeductionAmount"
        Me.txtDeductionAmount.Size = New System.Drawing.Size(105, 25)
        Me.txtDeductionAmount.TabIndex = 271
        Me.txtDeductionAmount.Tag = Nothing
        Me.txtDeductionAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtDeductionAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtDeductionAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtDeductionAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtDeductionAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(333, 457)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(108, 18)
        Me.Label1.TabIndex = 272
        Me.Label1.Text = "Receipt Amount"
        '
        'txtReceiptAmount
        '
        Me.txtReceiptAmount.AutoSize = False
        Me.txtReceiptAmount.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtReceiptAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtReceiptAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtReceiptAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtReceiptAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtReceiptAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtReceiptAmount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtReceiptAmount.Location = New System.Drawing.Point(449, 453)
        Me.txtReceiptAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtReceiptAmount.Name = "txtReceiptAmount"
        Me.txtReceiptAmount.ReadOnly = True
        Me.txtReceiptAmount.Size = New System.Drawing.Size(105, 25)
        Me.txtReceiptAmount.TabIndex = 271
        Me.txtReceiptAmount.Tag = Nothing
        Me.txtReceiptAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtReceiptAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtReceiptAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtReceiptAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtReceiptAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label31.Location = New System.Drawing.Point(12, 457)
        Me.Label31.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(106, 18)
        Me.Label31.TabIndex = 272
        Me.Label31.Text = "Refund Amount"
        '
        'txtRefundAmount
        '
        Me.txtRefundAmount.AutoSize = False
        Me.txtRefundAmount.BorderColor = System.Drawing.SystemColors.WindowFrame
        Me.txtRefundAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtRefundAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtRefundAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtRefundAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtRefundAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRefundAmount.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtRefundAmount.Location = New System.Drawing.Point(135, 453)
        Me.txtRefundAmount.Margin = New System.Windows.Forms.Padding(4)
        Me.txtRefundAmount.Name = "txtRefundAmount"
        Me.txtRefundAmount.Size = New System.Drawing.Size(158, 25)
        Me.txtRefundAmount.TabIndex = 271
        Me.txtRefundAmount.Tag = Nothing
        Me.txtRefundAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtRefundAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtRefundAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtRefundAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtRefundAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
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
        Me.cmbProject.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbProject.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbProject.Images.Add(CType(resources.GetObject("cmbProject.Images"), System.Drawing.Image))
        Me.cmbProject.ItemHeight = 15
        Me.cmbProject.Location = New System.Drawing.Point(135, 59)
        Me.cmbProject.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(420, 24)
        Me.cmbProject.TabIndex = 237
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.Location = New System.Drawing.Point(12, 63)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 18)
        Me.Label3.TabIndex = 238
        Me.Label3.Text = "Project"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label24.Location = New System.Drawing.Point(333, 30)
        Me.Label24.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(37, 18)
        Me.Label24.TabIndex = 196
        Me.Label24.Text = "Date"
        '
        'txtDate
        '
        Me.txtDate.AllowSpinLoop = False
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDate.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDate.Culture = 1056
        Me.txtDate.CustomFormat = "dd/MM/yyyy"
        Me.txtDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtDate.Location = New System.Drawing.Point(391, 28)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(164, 22)
        Me.txtDate.TabIndex = 195
        Me.txtDate.Tag = Nothing
        Me.txtDate.TrimEnd = False
        Me.txtDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(135, 26)
        Me.txtCode.Margin = New System.Windows.Forms.Padding(4)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(158, 26)
        Me.txtCode.TabIndex = 0
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold)
        Me.Label25.Location = New System.Drawing.Point(12, 30)
        Me.Label25.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(40, 18)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Code"
        '
        'chkPostToFinance
        '
        Me.chkPostToFinance.AutoSize = True
        Me.chkPostToFinance.Location = New System.Drawing.Point(619, 28)
        Me.chkPostToFinance.Name = "chkPostToFinance"
        Me.chkPostToFinance.Size = New System.Drawing.Size(125, 22)
        Me.chkPostToFinance.TabIndex = 309
        Me.chkPostToFinance.Text = "Post To Finance"
        Me.chkPostToFinance.UseVisualStyleBackColor = True
        '
        'frmRefund
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(834, 588)
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
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "frmRefund"
        Me.Text = "REFUND "
        Me.TopMost = True
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.cmbUnitType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbUnit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbCredit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbDebit, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDeductionAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtReceiptAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtRefundAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents cmbUnitType As C1.Win.C1List.C1Combo
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents cmdUnit As System.Windows.Forms.Button
    Friend WithEvents cmbUnit As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerNIC As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerMobile As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerTel As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerName As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtCustomerCode As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents txtRefundAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtRemarks As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As Label
    Friend WithEvents txtCC As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDeductionAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents txtReceiptAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents cmbCredit As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As Label
    Friend WithEvents cmbDebit As C1.Win.C1List.C1Combo
    Friend WithEvents Label30 As Label
    Friend WithEvents chkPostToFinance As CheckBox
End Class
