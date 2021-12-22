<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCustomer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCustomer))
        Me.txtCode = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.txtExpiryDate = New C1.Win.C1Input.C1DateEdit()
        Me.cmdChangeAddress = New System.Windows.Forms.Button()
        Me.txtChangeDate3 = New C1.Win.C1Input.C1DateEdit()
        Me.txtChangeDate2 = New C1.Win.C1Input.C1DateEdit()
        Me.txtChangeDate1 = New C1.Win.C1Input.C1DateEdit()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtAddressOld3 = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.txtAddressOld2 = New System.Windows.Forms.TextBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.txtAddressOld1 = New System.Windows.Forms.TextBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtMobileNo3 = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txtMobileCompany3 = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.txtMobileNo2 = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txtMobileCompany2 = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmdArea = New System.Windows.Forms.Button()
        Me.cmbArea = New C1.Win.C1List.C1Combo()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmdCityList = New System.Windows.Forms.Button()
        Me.cmbCity = New C1.Win.C1List.C1Combo()
        Me.cmbCountry = New C1.Win.C1List.C1Combo()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtTelOffice = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtCityOffice = New System.Windows.Forms.TextBox()
        Me.txtAddressOffice = New System.Windows.Forms.TextBox()
        Me.txtDesignation = New System.Windows.Forms.TextBox()
        Me.txtCompany = New System.Windows.Forms.TextBox()
        Me.txtOccupation = New System.Windows.Forms.TextBox()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtMobileNo = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtMobileCompany = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtTelRes = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtCityRes = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtNIC3 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtNIC2 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNIC1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtFatherHusbandName = New System.Windows.Forms.TextBox()
        Me.txtCC = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbSLT = New System.Windows.Forms.ComboBox()
        Me.cmdAdd = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.cmdUndo = New System.Windows.Forms.Button()
        Me.cmdSearch = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.cmdSave = New System.Windows.Forms.Button()
        Me.cmdDelete = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.txtExpiryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChangeDate3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChangeDate2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtChangeDate1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbArea, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCity, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmbCountry, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCode
        '
        Me.txtCode.BackColor = System.Drawing.Color.FromArgb(CType(CType(234, Byte), Integer), CType(CType(242, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.txtCode.Location = New System.Drawing.Point(159, 20)
        Me.txtCode.Name = "txtCode"
        Me.txtCode.Size = New System.Drawing.Size(100, 20)
        Me.txtCode.TabIndex = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
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
        Me.ToolStripLabel1.Size = New System.Drawing.Size(380, 61)
        Me.ToolStripLabel1.Text = "CUSTOMER MASTER FILE"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label29)
        Me.GroupBox2.Controls.Add(Me.txtExpiryDate)
        Me.GroupBox2.Controls.Add(Me.cmdChangeAddress)
        Me.GroupBox2.Controls.Add(Me.txtChangeDate3)
        Me.GroupBox2.Controls.Add(Me.txtChangeDate2)
        Me.GroupBox2.Controls.Add(Me.txtChangeDate1)
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.Label20)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label30)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtAddressOld3)
        Me.GroupBox2.Controls.Add(Me.Label28)
        Me.GroupBox2.Controls.Add(Me.txtAddressOld2)
        Me.GroupBox2.Controls.Add(Me.Label27)
        Me.GroupBox2.Controls.Add(Me.txtAddressOld1)
        Me.GroupBox2.Controls.Add(Me.Label26)
        Me.GroupBox2.Controls.Add(Me.txtMobileNo3)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.txtMobileCompany3)
        Me.GroupBox2.Controls.Add(Me.Label25)
        Me.GroupBox2.Controls.Add(Me.txtMobileNo2)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.txtMobileCompany2)
        Me.GroupBox2.Controls.Add(Me.Label23)
        Me.GroupBox2.Controls.Add(Me.cmdArea)
        Me.GroupBox2.Controls.Add(Me.cmbArea)
        Me.GroupBox2.Controls.Add(Me.Label21)
        Me.GroupBox2.Controls.Add(Me.cmdCityList)
        Me.GroupBox2.Controls.Add(Me.cmbCity)
        Me.GroupBox2.Controls.Add(Me.cmbCountry)
        Me.GroupBox2.Controls.Add(Me.txtEmail)
        Me.GroupBox2.Controls.Add(Me.txtTelOffice)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.txtCityOffice)
        Me.GroupBox2.Controls.Add(Me.txtAddressOffice)
        Me.GroupBox2.Controls.Add(Me.txtDesignation)
        Me.GroupBox2.Controls.Add(Me.txtCompany)
        Me.GroupBox2.Controls.Add(Me.txtOccupation)
        Me.GroupBox2.Controls.Add(Me.txtAddress)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.txtMobileNo)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.txtMobileCompany)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.txtTelRes)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.txtCityRes)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txtNIC3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtNIC2)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNIC1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtFatherHusbandName)
        Me.GroupBox2.Controls.Add(Me.txtCC)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmbSLT)
        Me.GroupBox2.Controls.Add(Me.txtCode)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 516)
        Me.GroupBox2.TabIndex = 113
        Me.GroupBox2.TabStop = False
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(494, 100)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(61, 13)
        Me.Label29.TabIndex = 207
        Me.Label29.Text = "Expiry Date"
        '
        'txtExpiryDate
        '
        Me.txtExpiryDate.AllowSpinLoop = False
        Me.txtExpiryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtExpiryDate.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtExpiryDate.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtExpiryDate.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtExpiryDate.Culture = 1056
        Me.txtExpiryDate.CustomFormat = "dd/MM/yyyy"
        Me.txtExpiryDate.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtExpiryDate.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtExpiryDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtExpiryDate.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtExpiryDate.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtExpiryDate.Location = New System.Drawing.Point(561, 96)
        Me.txtExpiryDate.Name = "txtExpiryDate"
        Me.txtExpiryDate.Size = New System.Drawing.Size(126, 19)
        Me.txtExpiryDate.TabIndex = 206
        Me.txtExpiryDate.Tag = Nothing
        Me.txtExpiryDate.TrimEnd = False
        Me.txtExpiryDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtExpiryDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtExpiryDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdChangeAddress
        '
        Me.cmdChangeAddress.Location = New System.Drawing.Point(625, 219)
        Me.cmdChangeAddress.Name = "cmdChangeAddress"
        Me.cmdChangeAddress.Size = New System.Drawing.Size(113, 23)
        Me.cmdChangeAddress.TabIndex = 205
        Me.cmdChangeAddress.Text = "Change Address"
        Me.cmdChangeAddress.UseVisualStyleBackColor = True
        '
        'txtChangeDate3
        '
        Me.txtChangeDate3.AllowSpinLoop = False
        Me.txtChangeDate3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtChangeDate3.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtChangeDate3.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate3.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate3.Culture = 1056
        Me.txtChangeDate3.CustomFormat = "dd/MM/yyyy"
        Me.txtChangeDate3.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtChangeDate3.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtChangeDate3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeDate3.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtChangeDate3.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtChangeDate3.Location = New System.Drawing.Point(626, 292)
        Me.txtChangeDate3.Name = "txtChangeDate3"
        Me.txtChangeDate3.ReadOnly = True
        Me.txtChangeDate3.Size = New System.Drawing.Size(108, 19)
        Me.txtChangeDate3.TabIndex = 204
        Me.txtChangeDate3.Tag = Nothing
        Me.txtChangeDate3.TrimEnd = False
        Me.txtChangeDate3.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtChangeDate3.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate3.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChangeDate2
        '
        Me.txtChangeDate2.AllowSpinLoop = False
        Me.txtChangeDate2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtChangeDate2.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtChangeDate2.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate2.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate2.Culture = 1056
        Me.txtChangeDate2.CustomFormat = "dd/MM/yyyy"
        Me.txtChangeDate2.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtChangeDate2.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtChangeDate2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeDate2.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtChangeDate2.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtChangeDate2.Location = New System.Drawing.Point(626, 269)
        Me.txtChangeDate2.Name = "txtChangeDate2"
        Me.txtChangeDate2.ReadOnly = True
        Me.txtChangeDate2.Size = New System.Drawing.Size(108, 19)
        Me.txtChangeDate2.TabIndex = 203
        Me.txtChangeDate2.Tag = Nothing
        Me.txtChangeDate2.TrimEnd = False
        Me.txtChangeDate2.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtChangeDate2.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate2.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtChangeDate1
        '
        Me.txtChangeDate1.AllowSpinLoop = False
        Me.txtChangeDate1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtChangeDate1.Calendar.Font = New System.Drawing.Font("Tahoma", 8.0!)
        Me.txtChangeDate1.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate1.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate1.Culture = 1056
        Me.txtChangeDate1.CustomFormat = "dd/MM/yyyy"
        Me.txtChangeDate1.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtChangeDate1.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
            Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtChangeDate1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtChangeDate1.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtChangeDate1.ImagePadding = New System.Windows.Forms.Padding(0)
        Me.txtChangeDate1.Location = New System.Drawing.Point(626, 245)
        Me.txtChangeDate1.Name = "txtChangeDate1"
        Me.txtChangeDate1.ReadOnly = True
        Me.txtChangeDate1.Size = New System.Drawing.Size(108, 19)
        Me.txtChangeDate1.TabIndex = 202
        Me.txtChangeDate1.Tag = Nothing
        Me.txtChangeDate1.TrimEnd = False
        Me.txtChangeDate1.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtChangeDate1.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtChangeDate1.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(26, 346)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(24, 13)
        Me.Label19.TabIndex = 200
        Me.Label19.Text = "City"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(26, 320)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(43, 13)
        Me.Label20.TabIndex = 199
        Me.Label20.Text = "Country"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(26, 493)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(32, 13)
        Me.Label18.TabIndex = 198
        Me.Label18.Text = "Email"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(26, 469)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(95, 13)
        Me.Label17.TabIndex = 197
        Me.Label17.Text = "Telephone (Office)"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(26, 445)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(82, 13)
        Me.Label15.TabIndex = 196
        Me.Label15.Text = "Address (Office)"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(26, 421)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(63, 13)
        Me.Label14.TabIndex = 195
        Me.Label14.Text = "Designation"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(26, 396)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 13)
        Me.Label13.TabIndex = 194
        Me.Label13.Text = "Company"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(26, 372)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(62, 13)
        Me.Label12.TabIndex = 193
        Me.Label12.Text = "Occupation"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(26, 49)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 192
        Me.Label6.Text = "Customer Name"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(303, 23)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(21, 13)
        Me.Label30.TabIndex = 191
        Me.Label30.Text = "CC"
        Me.Label30.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(26, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 191
        Me.Label1.Text = "Customer Code"
        '
        'txtAddressOld3
        '
        Me.txtAddressOld3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddressOld3.Location = New System.Drawing.Point(159, 292)
        Me.txtAddressOld3.MaxLength = 150
        Me.txtAddressOld3.Name = "txtAddressOld3"
        Me.txtAddressOld3.ReadOnly = True
        Me.txtAddressOld3.Size = New System.Drawing.Size(466, 20)
        Me.txtAddressOld3.TabIndex = 189
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(26, 295)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(73, 13)
        Me.Label28.TabIndex = 190
        Me.Label28.Text = "Address Old 3"
        '
        'txtAddressOld2
        '
        Me.txtAddressOld2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddressOld2.Location = New System.Drawing.Point(159, 268)
        Me.txtAddressOld2.MaxLength = 150
        Me.txtAddressOld2.Name = "txtAddressOld2"
        Me.txtAddressOld2.ReadOnly = True
        Me.txtAddressOld2.Size = New System.Drawing.Size(464, 20)
        Me.txtAddressOld2.TabIndex = 187
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(26, 271)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(73, 13)
        Me.Label27.TabIndex = 188
        Me.Label27.Text = "Address Old 2"
        '
        'txtAddressOld1
        '
        Me.txtAddressOld1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddressOld1.Location = New System.Drawing.Point(159, 244)
        Me.txtAddressOld1.MaxLength = 150
        Me.txtAddressOld1.Name = "txtAddressOld1"
        Me.txtAddressOld1.ReadOnly = True
        Me.txtAddressOld1.Size = New System.Drawing.Size(466, 20)
        Me.txtAddressOld1.TabIndex = 185
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(26, 247)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(73, 13)
        Me.Label26.TabIndex = 186
        Me.Label26.Text = "Address Old 1"
        '
        'txtMobileNo3
        '
        Me.txtMobileNo3.Location = New System.Drawing.Point(250, 197)
        Me.txtMobileNo3.MaxLength = 14
        Me.txtMobileNo3.Name = "txtMobileNo3"
        Me.txtMobileNo3.Size = New System.Drawing.Size(104, 20)
        Me.txtMobileNo3.TabIndex = 14
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(237, 200)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(10, 13)
        Me.Label24.TabIndex = 184
        Me.Label24.Text = "-"
        '
        'txtMobileCompany3
        '
        Me.txtMobileCompany3.Location = New System.Drawing.Point(159, 197)
        Me.txtMobileCompany3.MaxLength = 10
        Me.txtMobileCompany3.Name = "txtMobileCompany3"
        Me.txtMobileCompany3.Size = New System.Drawing.Size(72, 20)
        Me.txtMobileCompany3.TabIndex = 13
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(26, 200)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(57, 13)
        Me.Label25.TabIndex = 183
        Me.Label25.Text = "Mobile # 3"
        '
        'txtMobileNo2
        '
        Me.txtMobileNo2.Location = New System.Drawing.Point(250, 173)
        Me.txtMobileNo2.MaxLength = 14
        Me.txtMobileNo2.Name = "txtMobileNo2"
        Me.txtMobileNo2.Size = New System.Drawing.Size(104, 20)
        Me.txtMobileNo2.TabIndex = 12
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(237, 176)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(10, 13)
        Me.Label22.TabIndex = 180
        Me.Label22.Text = "-"
        '
        'txtMobileCompany2
        '
        Me.txtMobileCompany2.Location = New System.Drawing.Point(159, 173)
        Me.txtMobileCompany2.MaxLength = 10
        Me.txtMobileCompany2.Name = "txtMobileCompany2"
        Me.txtMobileCompany2.Size = New System.Drawing.Size(72, 20)
        Me.txtMobileCompany2.TabIndex = 11
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(26, 176)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(57, 13)
        Me.Label23.TabIndex = 179
        Me.Label23.Text = "Mobile # 2"
        '
        'cmdArea
        '
        Me.cmdArea.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdArea.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdArea.Location = New System.Drawing.Point(626, 342)
        Me.cmdArea.Name = "cmdArea"
        Me.cmdArea.Size = New System.Drawing.Size(22, 21)
        Me.cmdArea.TabIndex = 18
        Me.cmdArea.UseVisualStyleBackColor = True
        '
        'cmbArea
        '
        Me.cmbArea.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbArea.Caption = ""
        Me.cmbArea.CaptionHeight = 17
        Me.cmbArea.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbArea.ColumnCaptionHeight = 17
        Me.cmbArea.ColumnFooterHeight = 17
        Me.cmbArea.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbArea.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbArea.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbArea.Images.Add(CType(resources.GetObject("cmbArea.Images"), System.Drawing.Image))
        Me.cmbArea.ItemHeight = 15
        Me.cmbArea.Location = New System.Drawing.Point(429, 342)
        Me.cmbArea.MatchEntryTimeout = CType(2000, Long)
        Me.cmbArea.MaxDropDownItems = CType(5, Short)
        Me.cmbArea.MaxLength = 32767
        Me.cmbArea.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbArea.Name = "cmbArea"
        Me.cmbArea.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbArea.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbArea.Size = New System.Drawing.Size(195, 21)
        Me.cmbArea.TabIndex = 176
        Me.cmbArea.PropBag = resources.GetString("cmbArea.PropBag")
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(386, 346)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(29, 13)
        Me.Label21.TabIndex = 175
        Me.Label21.Text = "Area"
        '
        'cmdCityList
        '
        Me.cmdCityList.Font = New System.Drawing.Font("Wingdings", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(2, Byte))
        Me.cmdCityList.Image = Global.General_Ledger.My.Resources.Resources.Find_Small
        Me.cmdCityList.Location = New System.Drawing.Point(355, 342)
        Me.cmdCityList.Name = "cmdCityList"
        Me.cmdCityList.Size = New System.Drawing.Size(22, 21)
        Me.cmdCityList.TabIndex = 17
        Me.cmdCityList.UseVisualStyleBackColor = True
        '
        'cmbCity
        '
        Me.cmbCity.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCity.Caption = ""
        Me.cmbCity.CaptionHeight = 17
        Me.cmbCity.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCity.ColumnCaptionHeight = 17
        Me.cmbCity.ColumnFooterHeight = 17
        Me.cmbCity.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCity.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCity.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCity.Images.Add(CType(resources.GetObject("cmbCity.Images"), System.Drawing.Image))
        Me.cmbCity.ItemHeight = 15
        Me.cmbCity.Location = New System.Drawing.Point(159, 342)
        Me.cmbCity.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCity.MaxDropDownItems = CType(5, Short)
        Me.cmbCity.MaxLength = 32767
        Me.cmbCity.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCity.Name = "cmbCity"
        Me.cmbCity.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCity.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCity.Size = New System.Drawing.Size(195, 21)
        Me.cmbCity.TabIndex = 173
        Me.cmbCity.PropBag = resources.GetString("cmbCity.PropBag")
        '
        'cmbCountry
        '
        Me.cmbCountry.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCountry.Caption = ""
        Me.cmbCountry.CaptionHeight = 17
        Me.cmbCountry.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCountry.ColumnCaptionHeight = 17
        Me.cmbCountry.ColumnFooterHeight = 17
        Me.cmbCountry.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCountry.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCountry.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCountry.Images.Add(CType(resources.GetObject("cmbCountry.Images"), System.Drawing.Image))
        Me.cmbCountry.ItemHeight = 15
        Me.cmbCountry.Location = New System.Drawing.Point(159, 316)
        Me.cmbCountry.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCountry.MaxDropDownItems = CType(5, Short)
        Me.cmbCountry.MaxLength = 32767
        Me.cmbCountry.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCountry.Name = "cmbCountry"
        Me.cmbCountry.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCountry.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCountry.Size = New System.Drawing.Size(195, 21)
        Me.cmbCountry.TabIndex = 16
        Me.cmbCountry.PropBag = resources.GetString("cmbCountry.PropBag")
        '
        'txtEmail
        '
        Me.txtEmail.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmail.Location = New System.Drawing.Point(159, 489)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(333, 20)
        Me.txtEmail.TabIndex = 25
        '
        'txtTelOffice
        '
        Me.txtTelOffice.Location = New System.Drawing.Point(250, 465)
        Me.txtTelOffice.MaxLength = 40
        Me.txtTelOffice.Name = "txtTelOffice"
        Me.txtTelOffice.Size = New System.Drawing.Size(243, 20)
        Me.txtTelOffice.TabIndex = 24
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(234, 469)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(10, 13)
        Me.Label16.TabIndex = 166
        Me.Label16.Text = "-"
        '
        'txtCityOffice
        '
        Me.txtCityOffice.Location = New System.Drawing.Point(159, 465)
        Me.txtCityOffice.MaxLength = 4
        Me.txtCityOffice.Name = "txtCityOffice"
        Me.txtCityOffice.Size = New System.Drawing.Size(72, 20)
        Me.txtCityOffice.TabIndex = 23
        '
        'txtAddressOffice
        '
        Me.txtAddressOffice.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddressOffice.Location = New System.Drawing.Point(159, 441)
        Me.txtAddressOffice.MaxLength = 150
        Me.txtAddressOffice.Name = "txtAddressOffice"
        Me.txtAddressOffice.Size = New System.Drawing.Size(573, 20)
        Me.txtAddressOffice.TabIndex = 22
        '
        'txtDesignation
        '
        Me.txtDesignation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtDesignation.Location = New System.Drawing.Point(159, 417)
        Me.txtDesignation.MaxLength = 50
        Me.txtDesignation.Name = "txtDesignation"
        Me.txtDesignation.Size = New System.Drawing.Size(333, 20)
        Me.txtDesignation.TabIndex = 21
        '
        'txtCompany
        '
        Me.txtCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCompany.Location = New System.Drawing.Point(159, 392)
        Me.txtCompany.MaxLength = 50
        Me.txtCompany.Name = "txtCompany"
        Me.txtCompany.Size = New System.Drawing.Size(333, 20)
        Me.txtCompany.TabIndex = 20
        '
        'txtOccupation
        '
        Me.txtOccupation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOccupation.Location = New System.Drawing.Point(159, 368)
        Me.txtOccupation.MaxLength = 50
        Me.txtOccupation.Name = "txtOccupation"
        Me.txtOccupation.Size = New System.Drawing.Size(333, 20)
        Me.txtOccupation.TabIndex = 19
        '
        'txtAddress
        '
        Me.txtAddress.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtAddress.Location = New System.Drawing.Point(159, 221)
        Me.txtAddress.MaxLength = 150
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(465, 20)
        Me.txtAddress.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(26, 224)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(73, 13)
        Me.Label11.TabIndex = 154
        Me.Label11.Text = "Address (Res)"
        '
        'txtMobileNo
        '
        Me.txtMobileNo.Location = New System.Drawing.Point(250, 147)
        Me.txtMobileNo.MaxLength = 14
        Me.txtMobileNo.Name = "txtMobileNo"
        Me.txtMobileNo.Size = New System.Drawing.Size(104, 20)
        Me.txtMobileNo.TabIndex = 10
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(237, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 152
        Me.Label10.Text = "-"
        '
        'txtMobileCompany
        '
        Me.txtMobileCompany.Location = New System.Drawing.Point(159, 147)
        Me.txtMobileCompany.MaxLength = 10
        Me.txtMobileCompany.Name = "txtMobileCompany"
        Me.txtMobileCompany.Size = New System.Drawing.Size(72, 20)
        Me.txtMobileCompany.TabIndex = 9
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(26, 150)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(48, 13)
        Me.Label9.TabIndex = 150
        Me.Label9.Text = "Mobile #"
        '
        'txtTelRes
        '
        Me.txtTelRes.Location = New System.Drawing.Point(250, 121)
        Me.txtTelRes.MaxLength = 14
        Me.txtTelRes.Name = "txtTelRes"
        Me.txtTelRes.Size = New System.Drawing.Size(104, 20)
        Me.txtTelRes.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(237, 124)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(10, 13)
        Me.Label8.TabIndex = 148
        Me.Label8.Text = "-"
        '
        'txtCityRes
        '
        Me.txtCityRes.Location = New System.Drawing.Point(159, 121)
        Me.txtCityRes.MaxLength = 10
        Me.txtCityRes.Name = "txtCityRes"
        Me.txtCityRes.Size = New System.Drawing.Size(72, 20)
        Me.txtCityRes.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(26, 124)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 13)
        Me.Label7.TabIndex = 146
        Me.Label7.Text = "Telephone (Res)"
        '
        'txtNIC3
        '
        Me.txtNIC3.Location = New System.Drawing.Point(376, 97)
        Me.txtNIC3.MaxLength = 1
        Me.txtNIC3.Name = "txtNIC3"
        Me.txtNIC3.Size = New System.Drawing.Size(32, 20)
        Me.txtNIC3.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(360, 100)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(10, 13)
        Me.Label5.TabIndex = 144
        Me.Label5.Text = "-"
        '
        'txtNIC2
        '
        Me.txtNIC2.Location = New System.Drawing.Point(250, 97)
        Me.txtNIC2.MaxLength = 7
        Me.txtNIC2.Name = "txtNIC2"
        Me.txtNIC2.Size = New System.Drawing.Size(104, 20)
        Me.txtNIC2.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(10, 13)
        Me.Label4.TabIndex = 142
        Me.Label4.Text = "-"
        '
        'txtNIC1
        '
        Me.txtNIC1.AcceptsReturn = True
        Me.txtNIC1.AcceptsTab = True
        Me.txtNIC1.Location = New System.Drawing.Point(159, 97)
        Me.txtNIC1.MaxLength = 5
        Me.txtNIC1.Name = "txtNIC1"
        Me.txtNIC1.Size = New System.Drawing.Size(72, 20)
        Me.txtNIC1.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 140
        Me.Label3.Text = "Computerized NIC #"
        '
        'txtFatherHusbandName
        '
        Me.txtFatherHusbandName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtFatherHusbandName.Location = New System.Drawing.Point(159, 72)
        Me.txtFatherHusbandName.MaxLength = 50
        Me.txtFatherHusbandName.Name = "txtFatherHusbandName"
        Me.txtFatherHusbandName.Size = New System.Drawing.Size(333, 20)
        Me.txtFatherHusbandName.TabIndex = 3
        '
        'txtCC
        '
        Me.txtCC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtCC.Location = New System.Drawing.Point(328, 21)
        Me.txtCC.MaxLength = 50
        Me.txtCC.Name = "txtCC"
        Me.txtCC.Size = New System.Drawing.Size(164, 20)
        Me.txtCC.TabIndex = 2
        Me.txtCC.Visible = False
        '
        'txtName
        '
        Me.txtName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtName.Location = New System.Drawing.Point(237, 46)
        Me.txtName.MaxLength = 50
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(255, 20)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 13)
        Me.Label2.TabIndex = 137
        Me.Label2.Text = "Father / Husband Name"
        '
        'cmbSLT
        '
        Me.cmbSLT.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbSLT.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbSLT.FormattingEnabled = True
        Me.cmbSLT.Items.AddRange(New Object() {"MR", "MRS", "MISS", "M/S", "DR"})
        Me.cmbSLT.Location = New System.Drawing.Point(159, 45)
        Me.cmbSLT.Name = "cmbSLT"
        Me.cmbSLT.Size = New System.Drawing.Size(72, 21)
        Me.cmbSLT.TabIndex = 1
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
        'frmCustomer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(747, 591)
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
        Me.Name = "frmCustomer"
        Me.Text = "Customer Master File"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.txtExpiryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChangeDate3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChangeDate2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtChangeDate1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbArea, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCity, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmbCountry, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmdAdd As System.Windows.Forms.Button
    Friend WithEvents cmdUndo As System.Windows.Forms.Button
    Friend WithEvents cmdEdit As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents txtCode As System.Windows.Forms.TextBox
    Friend WithEvents cmdSearch As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmbSLT As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtNIC3 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtNIC2 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNIC1 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtFatherHusbandName As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents txtTelOffice As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtCityOffice As System.Windows.Forms.TextBox
    Friend WithEvents txtAddressOffice As System.Windows.Forms.TextBox
    Friend WithEvents txtDesignation As System.Windows.Forms.TextBox
    Friend WithEvents txtCompany As System.Windows.Forms.TextBox
    Friend WithEvents txtOccupation As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtMobileCompany As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtTelRes As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtCityRes As System.Windows.Forms.TextBox
    Friend WithEvents cmdCityList As System.Windows.Forms.Button
    Friend WithEvents cmbCity As C1.Win.C1List.C1Combo
    Friend WithEvents cmbCountry As C1.Win.C1List.C1Combo
    Friend WithEvents cmdArea As System.Windows.Forms.Button
    Friend WithEvents cmbArea As C1.Win.C1List.C1Combo
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo2 As System.Windows.Forms.TextBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txtMobileCompany2 As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txtMobileNo3 As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txtMobileCompany3 As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents txtAddressOld2 As System.Windows.Forms.TextBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents txtAddressOld1 As System.Windows.Forms.TextBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtAddressOld3 As System.Windows.Forms.TextBox
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents txtChangeDate3 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtChangeDate2 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents txtChangeDate1 As C1.Win.C1Input.C1DateEdit
    Friend WithEvents cmdChangeAddress As System.Windows.Forms.Button
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents txtExpiryDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label30 As Label
    Friend WithEvents txtCC As TextBox
    'Friend WithEvents CachedReport1 As CrystalDecisions.ReportSource.CachedReport
End Class
