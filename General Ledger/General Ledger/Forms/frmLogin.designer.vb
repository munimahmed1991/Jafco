<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmLogin))
        Me.txtUse = New System.Windows.Forms.TextBox()
        Me.txtPas = New System.Windows.Forms.TextBox()
        Me.cmbCompany = New C1.Win.C1List.C1Combo()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.C1PictureBox1 = New C1.Win.C1Input.C1PictureBox()
        Me.cmdLogin = New C1.Win.C1Input.C1Button()
        Me.cmdExit = New C1.Win.C1Input.C1Button()
        Me.cmbYear = New System.Windows.Forms.ComboBox()
        CType(Me.cmbCompany, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.C1PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdLogin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtUse
        '
        Me.txtUse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtUse.Location = New System.Drawing.Point(339, 413)
        Me.txtUse.Name = "txtUse"
        Me.txtUse.Size = New System.Drawing.Size(142, 21)
        Me.txtUse.TabIndex = 4
        '
        'txtPas
        '
        Me.txtPas.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtPas.Location = New System.Drawing.Point(339, 440)
        Me.txtPas.Name = "txtPas"
        Me.txtPas.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtPas.Size = New System.Drawing.Size(142, 21)
        Me.txtPas.TabIndex = 0
        '
        'cmbCompany
        '
        Me.cmbCompany.AddItemSeparator = Global.Microsoft.VisualBasic.ChrW(59)
        Me.cmbCompany.AutoCompletion = True
        Me.cmbCompany.AutoDropDown = True
        Me.cmbCompany.AutoSelect = True
        Me.cmbCompany.Caption = ""
        Me.cmbCompany.CaptionHeight = 17
        Me.cmbCompany.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal
        Me.cmbCompany.ColumnCaptionHeight = 17
        Me.cmbCompany.ColumnFooterHeight = 17
        Me.cmbCompany.ColumnHeaders = False
        Me.cmbCompany.ComboStyle = C1.Win.C1List.ComboStyleEnum.DropdownList
        Me.cmbCompany.DeadAreaBackColor = System.Drawing.Color.Empty
        Me.cmbCompany.DropdownPosition = C1.Win.C1List.DropdownPositionEnum.LeftDown
        Me.cmbCompany.EditorBackColor = System.Drawing.SystemColors.Window
        Me.cmbCompany.EditorFont = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbCompany.EditorForeColor = System.Drawing.SystemColors.WindowText
        Me.cmbCompany.Images.Add(CType(resources.GetObject("cmbCompany.Images"), System.Drawing.Image))
        Me.cmbCompany.ItemHeight = 15
        Me.cmbCompany.Location = New System.Drawing.Point(194, 386)
        Me.cmbCompany.MatchEntryTimeout = CType(2000, Long)
        Me.cmbCompany.MaxDropDownItems = CType(5, Short)
        Me.cmbCompany.MaxLength = 32767
        Me.cmbCompany.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbCompany.Name = "cmbCompany"
        Me.cmbCompany.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbCompany.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbCompany.Size = New System.Drawing.Size(287, 21)
        Me.cmbCompany.TabIndex = 2
        Me.cmbCompany.VisualStyle = C1.Win.C1List.VisualStyle.Office2007Blue
        Me.cmbCompany.PropBag = resources.GetString("cmbCompany.PropBag")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.SteelBlue
        Me.Label4.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label4.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(247, 415)
        Me.Label4.Name = "Label4"
        Me.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label4.Size = New System.Drawing.Size(87, 18)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "User Name  :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label3.Font = New System.Drawing.Font("Trebuchet MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(247, 440)
        Me.Label3.Name = "Label3"
        Me.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Label3.Size = New System.Drawing.Size(88, 18)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Password  :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'C1PictureBox1
        '
        Me.C1PictureBox1.BackgroundImage = CType(resources.GetObject("C1PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.C1PictureBox1.Location = New System.Drawing.Point(0, 7)
        Me.C1PictureBox1.Name = "C1PictureBox1"
        Me.C1PictureBox1.Size = New System.Drawing.Size(667, 585)
        Me.C1PictureBox1.TabIndex = 5
        Me.C1PictureBox1.TabStop = False
        '
        'cmdLogin
        '
        Me.cmdLogin.Enabled = False
        Me.cmdLogin.Location = New System.Drawing.Point(258, 475)
        Me.cmdLogin.Name = "cmdLogin"
        Me.cmdLogin.Size = New System.Drawing.Size(75, 23)
        Me.cmdLogin.TabIndex = 6
        Me.cmdLogin.Text = "&Login"
        Me.cmdLogin.UseVisualStyleBackColor = True
        Me.cmdLogin.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdLogin.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Location = New System.Drawing.Point(339, 475)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(75, 23)
        Me.cmdExit.TabIndex = 6
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        Me.cmdExit.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.cmdExit.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'cmbYear
        '
        Me.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbYear.FormattingEnabled = True
        Me.cmbYear.Location = New System.Drawing.Point(339, 359)
        Me.cmbYear.Name = "cmbYear"
        Me.cmbYear.Size = New System.Drawing.Size(142, 21)
        Me.cmbYear.TabIndex = 8
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(678, 593)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmbYear)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdLogin)
        Me.Controls.Add(Me.txtUse)
        Me.Controls.Add(Me.txtPas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmbCompany)
        Me.Controls.Add(Me.C1PictureBox1)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmLogin"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User's Login Authentication"
        Me.TransparencyKey = System.Drawing.SystemColors.Control
        CType(Me.cmbCompany, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.C1PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdLogin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cmdExit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtUse As System.Windows.Forms.TextBox
    Friend WithEvents txtPas As System.Windows.Forms.TextBox
    Friend WithEvents cmbCompany As C1.Win.C1List.C1Combo
    Public WithEvents Label4 As System.Windows.Forms.Label
    Public WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents C1PictureBox1 As C1.Win.C1Input.C1PictureBox
    Friend WithEvents cmdLogin As C1.Win.C1Input.C1Button
    Friend WithEvents cmdExit As C1.Win.C1Input.C1Button
    Friend WithEvents cmbYear As System.Windows.Forms.ComboBox
End Class
