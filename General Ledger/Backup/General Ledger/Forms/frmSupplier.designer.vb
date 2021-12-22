<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSupplier
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSupplier))
        Me.cmdAdd = New System.Windows.Forms.Button
        Me.cmdUndo = New System.Windows.Forms.Button
        Me.cmdEdit = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.txtCode = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.cmdSearch = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.txtKBCode = New System.Windows.Forms.TextBox
        Me.Label21 = New System.Windows.Forms.Label
        Me.cmbSupplierAccount = New C1.Win.C1List.C1Combo
        Me.Label14 = New System.Windows.Forms.Label
        Me.cmdNewCity = New System.Windows.Forms.Button
        Me.cmdNewCountry = New System.Windows.Forms.Button
        Me.cmdNewOrgin = New System.Windows.Forms.Button
        Me.Label13 = New System.Windows.Forms.Label
        Me.cmbCategory = New System.Windows.Forms.ComboBox
        Me.cmdCity = New System.Windows.Forms.Button
        Me.cmdCountryList = New System.Windows.Forms.Button
        Me.cmdOriginList = New System.Windows.Forms.Button
        Me.txtNTNNo = New System.Windows.Forms.TextBox
        Me.Label12 = New System.Windows.Forms.Label
        Me.txtStaxRegNo = New System.Windows.Forms.TextBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.txtWebsite = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmbOrigin = New C1.Win.C1List.C1Combo
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtEmail = New System.Windows.Forms.TextBox
        Me.Label8 = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.cmbCity = New C1.Win.C1List.C1Combo
        Me.Label4 = New System.Windows.Forms.Label
        Me.cmbCountry = New C1.Win.C1List.C1Combo
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtAddress = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.cmbName = New C1.Win.C1List.C1Combo
        Me.tdbGridContact = New C1.Win.C1TrueDBGrid.C1TrueDBGrid
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbSupplierAccount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbOrigin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tdbGridContact, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmdAdd
        '
        Me.cmdAdd.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdAdd.Image = Global.General_Ledger.My.Resources.Resources.folder_add
        Me.cmdAdd.Location = New System.Drawing.Point(432, 4)
        Me.cmdAdd.Name = "cmdAdd"
        Me.cmdAdd.Size = New System.Drawing.Size(51, 56)
        Me.cmdAdd.TabIndex = 0
        Me.cmdAdd.Text = "&Add"
        Me.cmdAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdAdd.UseVisualStyleBackColor = True
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
        'cmdEdit
        '
        Me.cmdEdit.Image = Global.General_Ledger.My.Resources.Resources.folder_edit
        Me.cmdEdit.Location = New System.Drawing.Point(484, 4)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(51, 56)
        Me.cmdEdit.TabIndex = 2
        Me.cmdEdit.Text = "&Edit"
        Me.cmdEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(587, 4)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(51, 56)
        Me.cmdDelete.TabIndex = 4
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(536, 4)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(51, 56)
        Me.cmdSave.TabIndex = 2
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(120, 85)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Code"
        '
        'cmdSearch
        '
        Me.cmdSearch.Image = Global.General_Ledger.My.Resources.Resources.folder_view
        Me.cmdSearch.Location = New System.Drawing.Point(380, 4)
        Me.cmdSearch.Name = "cmdSearch"
        Me.cmdSearch.Size = New System.Drawing.Size(51, 56)
        Me.cmdSearch.TabIndex = 1
        Me.cmdSearch.Text = "Searc&h"
        Me.cmdSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdSearch.UseVisualStyleBackColor = True
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
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 115)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Name"
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(232, 61)
        Me.ToolStripLabel1.Text = "SUPPLIER FILE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtKBCode)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmbSupplierAccount)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cmdNewCity)
        Me.GroupBox2.Controls.Add(Me.cmdNewCountry)
        Me.GroupBox2.Controls.Add(Me.cmdNewOrgin)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cmbCategory)
        Me.GroupBox2.Controls.Add(Me.cmdCity)
        Me.GroupBox2.Controls.Add(Me.cmdCountryList)
        Me.GroupBox2.Controls.Add(Me.cmdOriginList)
        Me.GroupBox2.Controls.Add(Me.txtNTNNo)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.txtStaxRegNo)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtWebsite)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.cmbOrigin)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtFax)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtPhone)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmbCity)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmbCountry)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbName)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 68)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 255)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'txtKBCode
        '
        Me.txtKBCode.Location = New System.Drawing.Point(275, 17)
        Me.txtKBCode.MaxLength = 2
        Me.txtKBCode.Name = "txtKBCode"
        Me.txtKBCode.Size = New System.Drawing.Size(40, 20)
        Me.txtKBCode.TabIndex = 244
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(225, 20)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(49, 13)
        Me.Label21.TabIndex = 245
        Me.Label21.Text = "KB Code"
        '
        'cmbSupplierAccount
        '
        Me.cmbSupplierAccount.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbSupplierAccount.Caption = ""
        Me.cmbSupplierAccount.CaptionHeight = 17
        Me.cmbSupplierAccount.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbSupplierAccount.ColumnCaptionHeight = 17
        Me.cmbSupplierAccount.ColumnFooterHeight = 17
        Me.cmbSupplierAccount.ContentHeight = 15
        Me.cmbSupplierAccount.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbSupplierAccount.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbSupplierAccount.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSupplierAccount.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbSupplierAccount.EditorHeight = 15
        Me.cmbSupplierAccount.Images.Add(CType(resources.GetObject("cmbSupplierAccount.Images"), System.Drawing.Image))
        Me.cmbSupplierAccount.ItemHeight = 15
        Me.cmbSupplierAccount.Location = New System.Drawing.Point(118, 67)
        Me.cmbSupplierAccount.MatchEntryTimeout = CType(2000, Long)
        Me.cmbSupplierAccount.MaxDropDownItems = CType(5, Short)
        Me.cmbSupplierAccount.MaxLength = 32767
        Me.cmbSupplierAccount.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbSupplierAccount.Name = "cmbSupplierAccount"
        Me.cmbSupplierAccount.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbSupplierAccount.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbSupplierAccount.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbSupplierAccount.Size = New System.Drawing.Size(278, 21)
        Me.cmbSupplierAccount.TabIndex = 165
        Me.cmbSupplierAccount.PropBag = resources.GetString("cmbSupplierAccount.PropBag")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(88, 13)
        Me.Label14.TabIndex = 164
        Me.Label14.Text = "Supplier Account"
        '
        'cmdNewCity
        '
        Me.cmdNewCity.Location = New System.Drawing.Point(422, 148)
        Me.cmdNewCity.Name = "cmdNewCity"
        Me.cmdNewCity.Size = New System.Drawing.Size(37, 23)
        Me.cmdNewCity.TabIndex = 163
        Me.cmdNewCity.Text = "New"
        Me.cmdNewCity.UseVisualStyleBackColor = True
        '
        'cmdNewCountry
        '
        Me.cmdNewCountry.Location = New System.Drawing.Point(422, 120)
        Me.cmdNewCountry.Name = "cmdNewCountry"
        Me.cmdNewCountry.Size = New System.Drawing.Size(37, 23)
        Me.cmdNewCountry.TabIndex = 162
        Me.cmdNewCountry.Text = "New"
        Me.cmdNewCountry.UseVisualStyleBackColor = True
        '
        'cmdNewOrgin
        '
        Me.cmdNewOrgin.Location = New System.Drawing.Point(422, 119)
        Me.cmdNewOrgin.Name = "cmdNewOrgin"
        Me.cmdNewOrgin.Size = New System.Drawing.Size(37, 23)
        Me.cmdNewOrgin.TabIndex = 161
        Me.cmdNewOrgin.Text = "New"
        Me.cmdNewOrgin.UseVisualStyleBackColor = True
        Me.cmdNewOrgin.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(402, 42)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(90, 13)
        Me.Label13.TabIndex = 160
        Me.Label13.Text = "Supplier Category"
        '
        'cmbCategory
        '
        Me.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbCategory.FormattingEnabled = True
        Me.cmbCategory.Items.AddRange(New Object() {"Fabric", "Woven", "Knits", "Accessories", "Washing", "Services", "Garments", "Other"})
        Me.cmbCategory.Location = New System.Drawing.Point(498, 39)
        Me.cmbCategory.Name = "cmbCategory"
        Me.cmbCategory.Size = New System.Drawing.Size(215, 21)
        Me.cmbCategory.TabIndex = 159
        '
        'cmdCity
        '
        Me.cmdCity.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdCity.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdCity.Location = New System.Drawing.Point(398, 149)
        Me.cmdCity.Name = "cmdCity"
        Me.cmdCity.Size = New System.Drawing.Size(22, 21)
        Me.cmdCity.TabIndex = 158
        Me.cmdCity.UseVisualStyleBackColor = True
        '
        'cmdCountryList
        '
        Me.cmdCountryList.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdCountryList.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdCountryList.Location = New System.Drawing.Point(398, 121)
        Me.cmdCountryList.Name = "cmdCountryList"
        Me.cmdCountryList.Size = New System.Drawing.Size(22, 21)
        Me.cmdCountryList.TabIndex = 157
        Me.cmdCountryList.UseVisualStyleBackColor = True
        '
        'cmdOriginList
        '
        Me.cmdOriginList.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdOriginList.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdOriginList.Location = New System.Drawing.Point(398, 120)
        Me.cmdOriginList.Name = "cmdOriginList"
        Me.cmdOriginList.Size = New System.Drawing.Size(22, 21)
        Me.cmdOriginList.TabIndex = 156
        Me.cmdOriginList.UseVisualStyleBackColor = True
        Me.cmdOriginList.Visible = False
        '
        'txtNTNNo
        '
        Me.txtNTNNo.Location = New System.Drawing.Point(473, 228)
        Me.txtNTNNo.MaxLength = 50
        Me.txtNTNNo.Name = "txtNTNNo"
        Me.txtNTNNo.Size = New System.Drawing.Size(240, 20)
        Me.txtNTNNo.TabIndex = 155
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(420, 231)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(40, 13)
        Me.Label12.TabIndex = 154
        Me.Label12.Text = "NTN #"
        '
        'txtStaxRegNo
        '
        Me.txtStaxRegNo.Location = New System.Drawing.Point(118, 228)
        Me.txtStaxRegNo.MaxLength = 50
        Me.txtStaxRegNo.Name = "txtStaxRegNo"
        Me.txtStaxRegNo.Size = New System.Drawing.Size(278, 20)
        Me.txtStaxRegNo.TabIndex = 153
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 231)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(87, 13)
        Me.Label11.TabIndex = 152
        Me.Label11.Text = "Sales Tax Reg #"
        '
        'txtWebsite
        '
        Me.txtWebsite.Location = New System.Drawing.Point(473, 202)
        Me.txtWebsite.MaxLength = 50
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(240, 20)
        Me.txtWebsite.TabIndex = 151
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(420, 205)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(46, 13)
        Me.Label10.TabIndex = 150
        Me.Label10.Text = "Website"
        '
        'cmbOrigin
        '
        Me.cmbOrigin.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbOrigin.Caption = ""
        Me.cmbOrigin.CaptionHeight = 17
        Me.cmbOrigin.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbOrigin.ColumnCaptionHeight = 17
        Me.cmbOrigin.ColumnFooterHeight = 17
        Me.cmbOrigin.ContentHeight = 15
        Me.cmbOrigin.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbOrigin.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbOrigin.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbOrigin.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbOrigin.EditorHeight = 15
        Me.cmbOrigin.Images.Add(CType(resources.GetObject("cmbOrigin.Images"), System.Drawing.Image))
        Me.cmbOrigin.ItemHeight = 15
        Me.cmbOrigin.Location = New System.Drawing.Point(118, 120)
        Me.cmbOrigin.MatchEntryTimeout = CType(2000, Long)
        Me.cmbOrigin.MaxDropDownItems = CType(5, Short)
        Me.cmbOrigin.MaxLength = 32767
        Me.cmbOrigin.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbOrigin.Name = "cmbOrigin"
        Me.cmbOrigin.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbOrigin.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbOrigin.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbOrigin.Size = New System.Drawing.Size(278, 21)
        Me.cmbOrigin.TabIndex = 149
        Me.cmbOrigin.Visible = False
        Me.cmbOrigin.PropBag = resources.GetString("cmbOrigin.PropBag")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 124)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 148
        Me.Label9.Text = "Origin"
        Me.Label9.Visible = False
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(118, 202)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(278, 20)
        Me.txtEmail.TabIndex = 147
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 205)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 146
        Me.Label8.Text = "Email"
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(473, 177)
        Me.txtFax.MaxLength = 50
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(240, 20)
        Me.txtFax.TabIndex = 145
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(420, 180)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(24, 13)
        Me.Label7.TabIndex = 144
        Me.Label7.Text = "Fax"
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(118, 177)
        Me.txtPhone.MaxLength = 50
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(278, 20)
        Me.txtPhone.TabIndex = 143
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 180)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 142
        Me.Label5.Text = "Phone"
        '
        'cmbCity
        '
        Me.cmbCity.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCity.Caption = ""
        Me.cmbCity.CaptionHeight = 17
        Me.cmbCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCity.ColumnCaptionHeight = 17
        Me.cmbCity.ColumnFooterHeight = 17
        Me.cmbCity.ContentHeight = 15
        Me.cmbCity.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCity.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCity.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCity.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCity.EditorHeight = 15
        Me.cmbCity.Images.Add(CType(resources.GetObject("cmbCity.Images"), System.Drawing.Image))
        Me.cmbCity.ItemHeight = 15
        Me.cmbCity.Location = New System.Drawing.Point(118, 149)
        Me.cmbCity.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCity.MaxDropDownItems = CType(5, Short)
        Me.cmbCity.MaxLength = 32767
        Me.cmbCity.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.ReadOnly = True
        Me.cmbCity.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCity.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCity.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCity.Size = New System.Drawing.Size(278, 21)
        Me.cmbCity.TabIndex = 141
        Me.cmbCity.PropBag = resources.GetString("cmbCity.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(23, 153)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(24, 13)
        Me.Label4.TabIndex = 140
        Me.Label4.Text = "City"
        '
        'cmbCountry
        '
        Me.cmbCountry.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCountry.Caption = ""
        Me.cmbCountry.CaptionHeight = 17
        Me.cmbCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCountry.ColumnCaptionHeight = 17
        Me.cmbCountry.ColumnFooterHeight = 17
        Me.cmbCountry.ContentHeight = 15
        Me.cmbCountry.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCountry.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCountry.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCountry.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCountry.EditorHeight = 15
        Me.cmbCountry.Images.Add(CType(resources.GetObject("cmbCountry.Images"), System.Drawing.Image))
        Me.cmbCountry.ItemHeight = 15
        Me.cmbCountry.Location = New System.Drawing.Point(118, 122)
        Me.cmbCountry.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCountry.MaxDropDownItems = CType(5, Short)
        Me.cmbCountry.MaxLength = 32767
        Me.cmbCountry.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbCountry.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCountry.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCountry.Size = New System.Drawing.Size(278, 21)
        Me.cmbCountry.TabIndex = 139
        Me.cmbCountry.PropBag = resources.GetString("cmbCountry.PropBag")
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 13)
        Me.Label3.TabIndex = 138
        Me.Label3.Text = "Country"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(118, 94)
        Me.txtAddress.MaxLength = 100
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(595, 20)
        Me.txtAddress.TabIndex = 137
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 136
        Me.Label2.Text = "Address"
        '
        'cmbName
        '
        Me.cmbName.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbName.Caption = ""
        Me.cmbName.CaptionHeight = 17
        Me.cmbName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbName.ColumnCaptionHeight = 17
        Me.cmbName.ColumnFooterHeight = 17
        Me.cmbName.ContentHeight = 15
        Me.cmbName.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbName.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbName.EditorFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbName.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbName.EditorHeight = 15
        Me.cmbName.Images.Add(CType(resources.GetObject("cmbName.Images"), System.Drawing.Image))
        Me.cmbName.ItemHeight = 15
        Me.cmbName.Location = New System.Drawing.Point(118, 41)
        Me.cmbName.MatchEntryTimeout = CType(2000, Long)
        Me.cmbName.MaxDropDownItems = CType(5, Short)
        Me.cmbName.MaxLength = 32767
        Me.cmbName.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbName.Name = "cmbName"
        Me.cmbName.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbName.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbName.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbName.Size = New System.Drawing.Size(278, 21)
        Me.cmbName.TabIndex = 135
        Me.cmbName.PropBag = resources.GetString("cmbName.PropBag")
        '
        'tdbGridContact
        '
        Me.tdbGridContact.AllowAddNew = True
        Me.tdbGridContact.AllowDelete = True
        Me.tdbGridContact.ColumnFooters = True
        Me.tdbGridContact.EmptyRows = True
        Me.tdbGridContact.GroupByCaption = "Drag a column header here to group by that column"
        Me.tdbGridContact.Images.Add(CType(resources.GetObject("tdbGridContact.Images"), System.Drawing.Image))
        Me.tdbGridContact.Images.Add(CType(resources.GetObject("tdbGridContact.Images1"), System.Drawing.Image))
        Me.tdbGridContact.Images.Add(CType(resources.GetObject("tdbGridContact.Images2"), System.Drawing.Image))
        Me.tdbGridContact.Location = New System.Drawing.Point(3, 326)
        Me.tdbGridContact.Name = "tdbGridContact"
        Me.tdbGridContact.PreviewInfo.Location = New System.Drawing.Point(0, 0)
        Me.tdbGridContact.PreviewInfo.Size = New System.Drawing.Size(0, 0)
        Me.tdbGridContact.PreviewInfo.ZoomFactor = 75
        Me.tdbGridContact.PrintInfo.PageSettings = CType(resources.GetObject("tdbGridContact.PrintInfo.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.tdbGridContact.RecordSelectors = False
        Me.tdbGridContact.Size = New System.Drawing.Size(738, 174)
        Me.tdbGridContact.TabIndex = 117
        Me.tdbGridContact.Text = "C1TrueDBGrid1"
        Me.tdbGridContact.VisualStyle = C1.Win.C1TrueDBGrid.VisualStyle.Office2007Silver
        Me.tdbGridContact.WrapCellPointer = True
        Me.tdbGridContact.PropBag = resources.GetString("tdbGridContact.PropBag")
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Image = Global.General_Ledger.My.Resources.Resources.folder_refresh
        Me.cmdRefresh.Location = New System.Drawing.Point(317, 4)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(61, 56)
        Me.cmdRefresh.TabIndex = 134
        Me.cmdRefresh.Text = "&Refresh"
        Me.cmdRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'frmSupplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 506)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.tdbGridContact)
        Me.Controls.Add(Me.cmdAdd)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmdUndo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdSearch)
        Me.Controls.Add(Me.txtCode)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.GroupBox2)
        Me.MaximizeBox = False
        Me.Name = "frmSupplier"
        Me.Text = "Supplier File"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbSupplierAccount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbOrigin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbName, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tdbGridContact, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbName As C1.Win.C1List.C1Combo
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtNTNNo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtStaxRegNo As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtWebsite As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbOrigin As C1.Win.C1List.C1Combo
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmbCity As C1.Win.C1List.C1Combo
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmbCountry As C1.Win.C1List.C1Combo
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents tdbGridContact As C1.Win.C1TrueDBGrid.C1TrueDBGrid
    Friend WithEvents cmdCity As System.Windows.Forms.Button
    Friend WithEvents cmdCountryList As System.Windows.Forms.Button
    Friend WithEvents cmdOriginList As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cmbCategory As System.Windows.Forms.ComboBox
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents cmdNewCity As System.Windows.Forms.Button
    Friend WithEvents cmdNewCountry As System.Windows.Forms.Button
    Friend WithEvents cmdNewOrgin As System.Windows.Forms.Button
    Friend WithEvents cmbSupplierAccount As C1.Win.C1List.C1Combo
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtKBCode As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    'Friend WithEvents CachedReport1 As CrystalDecisions.ReportSource.CachedReport
End Class
