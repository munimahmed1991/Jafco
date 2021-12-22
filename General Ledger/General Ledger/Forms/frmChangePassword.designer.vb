<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChangePassword
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
        Me.cmdCancel = New System.Windows.Forms.Button
        Me.cmdChange = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtUserName = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtCurrentPassword = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtNewPassword = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtRetypeNewPassword = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'cmdCancel
        '
        Me.cmdCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdCancel.Location = New System.Drawing.Point(224, 153)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(60, 24)
        Me.cmdCancel.TabIndex = 4
        Me.cmdCancel.Text = "Cance&l"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdChange
        '
        Me.cmdChange.Location = New System.Drawing.Point(158, 151)
        Me.cmdChange.Name = "cmdChange"
        Me.cmdChange.Size = New System.Drawing.Size(60, 26)
        Me.cmdChange.TabIndex = 3
        Me.cmdChange.Text = "&Change"
        Me.cmdChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.cmdChange.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User Name"
        '
        'txtUserName
        '
        Me.txtUserName.Enabled = False
        Me.txtUserName.Location = New System.Drawing.Point(132, 39)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(152, 20)
        Me.txtUserName.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Current Password"
        '
        'txtCurrentPassword
        '
        Me.txtCurrentPassword.Location = New System.Drawing.Point(132, 65)
        Me.txtCurrentPassword.Name = "txtCurrentPassword"
        Me.txtCurrentPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtCurrentPassword.Size = New System.Drawing.Size(152, 20)
        Me.txtCurrentPassword.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "New Password"
        '
        'txtNewPassword
        '
        Me.txtNewPassword.Location = New System.Drawing.Point(132, 91)
        Me.txtNewPassword.Name = "txtNewPassword"
        Me.txtNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtNewPassword.Size = New System.Drawing.Size(152, 20)
        Me.txtNewPassword.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Retype New Password"
        '
        'txtRetypeNewPassword
        '
        Me.txtRetypeNewPassword.Location = New System.Drawing.Point(132, 117)
        Me.txtRetypeNewPassword.Name = "txtRetypeNewPassword"
        Me.txtRetypeNewPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(9679)
        Me.txtRetypeNewPassword.Size = New System.Drawing.Size(152, 20)
        Me.txtRetypeNewPassword.TabIndex = 2
        '
        'frmChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.cmdCancel
        Me.ClientSize = New System.Drawing.Size(301, 189)
        Me.Controls.Add(Me.txtRetypeNewPassword)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtNewPassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtCurrentPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmdChange)
        Me.Controls.Add(Me.cmdCancel)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmChangePassword"
        Me.ShowInTaskbar = False
        Me.Text = "Change Password"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmdCancel As System.Windows.Forms.Button
    Friend WithEvents cmdChange As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCurrentPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtNewPassword As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtRetypeNewPassword As System.Windows.Forms.TextBox
End Class
