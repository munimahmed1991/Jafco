<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmServerSettings

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmServerSettings))
        Me.txtServer = New System.Windows.Forms.TextBox
        Me.txtGlDb = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtInvDb = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.txtYear = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtFromYear = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.txtToYear = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtPws = New System.Windows.Forms.TextBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Button3 = New System.Windows.Forms.Button
        Me.Pb = New System.Windows.Forms.ProgressBar
        Me.Label9 = New System.Windows.Forms.Label
        Me.txtID = New System.Windows.Forms.TextBox
        Me.cmdPrevious = New System.Windows.Forms.Button
        Me.Label10 = New System.Windows.Forms.Label
        Me.cmdCreatFile = New System.Windows.Forms.Button
        Me.cmdNext = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmdNew = New System.Windows.Forms.Button
        Me.cmdDelete = New System.Windows.Forms.Button
        Me.cmdSave = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'txtServer
        '
        Me.txtServer.Location = New System.Drawing.Point(126, 84)
        Me.txtServer.Name = "txtServer"
        Me.txtServer.Size = New System.Drawing.Size(187, 20)
        Me.txtServer.TabIndex = 8
        '
        'txtGlDb
        '
        Me.txtGlDb.Location = New System.Drawing.Point(126, 110)
        Me.txtGlDb.Name = "txtGlDb"
        Me.txtGlDb.Size = New System.Drawing.Size(187, 20)
        Me.txtGlDb.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(31, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "GlDb"
        '
        'txtInvDb
        '
        Me.txtInvDb.Location = New System.Drawing.Point(126, 136)
        Me.txtInvDb.Name = "txtInvDb"
        Me.txtInvDb.Size = New System.Drawing.Size(187, 20)
        Me.txtInvDb.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(53, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "InvDb"
        '
        'txtYear
        '
        Me.txtYear.Location = New System.Drawing.Point(126, 162)
        Me.txtYear.Name = "txtYear"
        Me.txtYear.Size = New System.Drawing.Size(187, 20)
        Me.txtYear.TabIndex = 11
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(60, 165)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Year"
        '
        'txtFromYear
        '
        Me.txtFromYear.Location = New System.Drawing.Point(126, 188)
        Me.txtFromYear.Name = "txtFromYear"
        Me.txtFromYear.Size = New System.Drawing.Size(187, 20)
        Me.txtFromYear.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(60, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "User"
        '
        'txtToYear
        '
        Me.txtToYear.Location = New System.Drawing.Point(126, 214)
        Me.txtToYear.Name = "txtToYear"
        Me.txtToYear.Size = New System.Drawing.Size(187, 20)
        Me.txtToYear.TabIndex = 13
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(47, 217)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(42, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "ToYear"
        '
        'txtPws
        '
        Me.txtPws.Location = New System.Drawing.Point(126, 240)
        Me.txtPws.Name = "txtPws"
        Me.txtPws.Size = New System.Drawing.Size(187, 20)
        Me.txtPws.TabIndex = 14
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 243)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Pws"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(54, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Sever"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(11, 373)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(357, 23)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Check Server Connectivity"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Pb
        '
        Me.Pb.Location = New System.Drawing.Point(11, 400)
        Me.Pb.Name = "Pb"
        Me.Pb.Size = New System.Drawing.Size(357, 27)
        Me.Pb.TabIndex = 4
        Me.Pb.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(73, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 13)
        Me.Label9.TabIndex = 6
        Me.Label9.Text = "ID"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtID.Location = New System.Drawing.Point(126, 58)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(187, 20)
        Me.txtID.TabIndex = 7
        '
        'cmdPrevious
        '
        Me.cmdPrevious.Image = Global.General_Ledger.My.Resources.Resources.boutons_player_retour_3D
        Me.cmdPrevious.Location = New System.Drawing.Point(12, 323)
        Me.cmdPrevious.Name = "cmdPrevious"
        Me.cmdPrevious.Size = New System.Drawing.Size(174, 44)
        Me.cmdPrevious.TabIndex = 4
        Me.cmdPrevious.Text = "<<== Previous Record"
        Me.cmdPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage
        Me.cmdPrevious.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label10.Location = New System.Drawing.Point(6, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(365, 35)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "G-Tech Server Setup Utility"
        '
        'cmdCreatFile
        '
        Me.cmdCreatFile.Location = New System.Drawing.Point(11, 402)
        Me.cmdCreatFile.Name = "cmdCreatFile"
        Me.cmdCreatFile.Size = New System.Drawing.Size(357, 23)
        Me.cmdCreatFile.TabIndex = 6
        Me.cmdCreatFile.Text = "Create Server Setting File"
        Me.cmdCreatFile.UseVisualStyleBackColor = True
        Me.cmdCreatFile.Visible = False
        '
        'cmdNext
        '
        Me.cmdNext.Image = Global.General_Ledger.My.Resources.Resources.boutons_player_avance_3D
        Me.cmdNext.Location = New System.Drawing.Point(192, 323)
        Me.cmdNext.Name = "cmdNext"
        Me.cmdNext.Size = New System.Drawing.Size(173, 44)
        Me.cmdNext.TabIndex = 5
        Me.cmdNext.Text = "Next Record ==>>"
        Me.cmdNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNext.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmdExit.Image = Global.General_Ledger.My.Resources.Resources.folder_out
        Me.cmdExit.Location = New System.Drawing.Point(280, 273)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(85, 41)
        Me.cmdExit.TabIndex = 3
        Me.cmdExit.Text = "&Exit"
        Me.cmdExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'cmdNew
        '
        Me.cmdNew.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdNew.Location = New System.Drawing.Point(12, 273)
        Me.cmdNew.Name = "cmdNew"
        Me.cmdNew.Size = New System.Drawing.Size(85, 41)
        Me.cmdNew.TabIndex = 0
        Me.cmdNew.Text = "&New"
        Me.cmdNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdNew.UseVisualStyleBackColor = True
        '
        'cmdDelete
        '
        Me.cmdDelete.Image = Global.General_Ledger.My.Resources.Resources.folder_delete
        Me.cmdDelete.Location = New System.Drawing.Point(192, 273)
        Me.cmdDelete.Name = "cmdDelete"
        Me.cmdDelete.Size = New System.Drawing.Size(85, 41)
        Me.cmdDelete.TabIndex = 2
        Me.cmdDelete.Text = "&Delete"
        Me.cmdDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdDelete.UseVisualStyleBackColor = True
        '
        'cmdSave
        '
        Me.cmdSave.Image = Global.General_Ledger.My.Resources.Resources.folder_new
        Me.cmdSave.Location = New System.Drawing.Point(101, 273)
        Me.cmdSave.Name = "cmdSave"
        Me.cmdSave.Size = New System.Drawing.Size(85, 41)
        Me.cmdSave.TabIndex = 1
        Me.cmdSave.Text = "&Save"
        Me.cmdSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.cmdSave.UseVisualStyleBackColor = True
        '
        'frmServerSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.CancelButton = Me.cmdExit
        Me.ClientSize = New System.Drawing.Size(377, 435)
        Me.Controls.Add(Me.cmdCreatFile)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmdPrevious)
        Me.Controls.Add(Me.cmdNext)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.Pb)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdNew)
        Me.Controls.Add(Me.cmdDelete)
        Me.Controls.Add(Me.cmdSave)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtPws)
        Me.Controls.Add(Me.txtToYear)
        Me.Controls.Add(Me.txtFromYear)
        Me.Controls.Add(Me.txtYear)
        Me.Controls.Add(Me.txtInvDb)
        Me.Controls.Add(Me.txtGlDb)
        Me.Controls.Add(Me.txtServer)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmServerSettings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "G-Tech Server Settings Utility"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtServer As System.Windows.Forms.TextBox
    Friend WithEvents txtGlDb As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtInvDb As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtYear As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtFromYear As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtToYear As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPws As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmdSave As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Pb As System.Windows.Forms.ProgressBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents cmdNext As System.Windows.Forms.Button
    Friend WithEvents cmdPrevious As System.Windows.Forms.Button
    Friend WithEvents cmdNew As System.Windows.Forms.Button
    Friend WithEvents cmdDelete As System.Windows.Forms.Button
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmdCreatFile As System.Windows.Forms.Button

End Class
