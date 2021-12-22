<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodaysStatusOld
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTodaysStatusOld))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.lblBookingAmount = New System.Windows.Forms.Label
        Me.lblBooking = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lblTotalRecovery = New System.Windows.Forms.Label
        Me.lblChequeRecovery = New System.Windows.Forms.Label
        Me.lblCashRecovery = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtEntryDate = New C1.Win.C1Input.C1DateEdit
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblBookingAmount)
        Me.GroupBox1.Controls.Add(Me.lblBooking)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox1.Location = New System.Drawing.Point(12, 76)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(328, 82)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking "
        '
        'lblBookingAmount
        '
        Me.lblBookingAmount.AutoSize = True
        Me.lblBookingAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBookingAmount.ForeColor = System.Drawing.Color.Blue
        Me.lblBookingAmount.Location = New System.Drawing.Point(152, 55)
        Me.lblBookingAmount.Name = "lblBookingAmount"
        Me.lblBookingAmount.Size = New System.Drawing.Size(111, 15)
        Me.lblBookingAmount.TabIndex = 8
        Me.lblBookingAmount.Text = "Booking Amount"
        '
        'lblBooking
        '
        Me.lblBooking.AutoSize = True
        Me.lblBooking.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBooking.ForeColor = System.Drawing.Color.Blue
        Me.lblBooking.Location = New System.Drawing.Point(152, 23)
        Me.lblBooking.Name = "lblBooking"
        Me.lblBooking.Size = New System.Drawing.Size(59, 15)
        Me.lblBooking.TabIndex = 7
        Me.lblBooking.Text = "Booking"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(10, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Booking Amount"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(10, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Booking"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblTotalRecovery)
        Me.GroupBox2.Controls.Add(Me.lblChequeRecovery)
        Me.GroupBox2.Controls.Add(Me.lblCashRecovery)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(12, 164)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 126)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Recovery Except Booking"
        '
        'lblTotalRecovery
        '
        Me.lblTotalRecovery.AutoSize = True
        Me.lblTotalRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalRecovery.ForeColor = System.Drawing.Color.Blue
        Me.lblTotalRecovery.Location = New System.Drawing.Point(152, 95)
        Me.lblTotalRecovery.Name = "lblTotalRecovery"
        Me.lblTotalRecovery.Size = New System.Drawing.Size(59, 15)
        Me.lblTotalRecovery.TabIndex = 11
        Me.lblTotalRecovery.Text = "Booking"
        '
        'lblChequeRecovery
        '
        Me.lblChequeRecovery.AutoSize = True
        Me.lblChequeRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChequeRecovery.ForeColor = System.Drawing.Color.Blue
        Me.lblChequeRecovery.Location = New System.Drawing.Point(152, 63)
        Me.lblChequeRecovery.Name = "lblChequeRecovery"
        Me.lblChequeRecovery.Size = New System.Drawing.Size(111, 15)
        Me.lblChequeRecovery.TabIndex = 10
        Me.lblChequeRecovery.Text = "Booking Amount"
        '
        'lblCashRecovery
        '
        Me.lblCashRecovery.AutoSize = True
        Me.lblCashRecovery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCashRecovery.ForeColor = System.Drawing.Color.Blue
        Me.lblCashRecovery.Location = New System.Drawing.Point(152, 31)
        Me.lblCashRecovery.Name = "lblCashRecovery"
        Me.lblCashRecovery.Size = New System.Drawing.Size(59, 15)
        Me.lblCashRecovery.TabIndex = 9
        Me.lblCashRecovery.Text = "Booking"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(10, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 15)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Total Recovery"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(10, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(118, 15)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Cheque Recovery"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(10, 31)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Cash Recovery"
        '
        'Timer1
        '
        Me.Timer1.Interval = 3000
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
        Me.cmbProject.Location = New System.Drawing.Point(59, 41)
        Me.cmbProject.MatchEntryTimeout = CType(2000, Long)
        Me.cmbProject.MaxDropDownItems = CType(5, Short)
        Me.cmbProject.MaxLength = 32767
        Me.cmbProject.MouseCursor = System.Windows.Forms.Cursors.Default
        Me.cmbProject.Name = "cmbProject"
        Me.cmbProject.RowDivider.Color = System.Drawing.Color.DarkGray
        Me.cmbProject.RowDivider.Style = C1.Win.C1List.LineStyleEnum.None
        Me.cmbProject.RowSubDividerColor = System.Drawing.Color.DarkGray
        Me.cmbProject.Size = New System.Drawing.Size(223, 21)
        Me.cmbProject.TabIndex = 239
        Me.cmbProject.PropBag = resources.GetString("cmbProject.PropBag")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(13, 45)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(40, 13)
        Me.Label6.TabIndex = 240
        Me.Label6.Text = "Project"
        '
        'cmdRefresh
        '
        Me.cmdRefresh.Location = New System.Drawing.Point(281, 40)
        Me.cmdRefresh.Name = "cmdRefresh"
        Me.cmdRefresh.Size = New System.Drawing.Size(54, 23)
        Me.cmdRefresh.TabIndex = 241
        Me.cmdRefresh.Text = "Refresh"
        Me.cmdRefresh.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 16)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 243
        Me.Label7.Text = "Date"
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
        Me.txtEntryDate.Location = New System.Drawing.Point(59, 12)
        Me.txtEntryDate.Name = "txtEntryDate"
        Me.txtEntryDate.Size = New System.Drawing.Size(126, 19)
        Me.txtEntryDate.TabIndex = 242
        Me.txtEntryDate.Tag = Nothing
        Me.txtEntryDate.TrimEnd = False
        Me.txtEntryDate.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtEntryDate.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtEntryDate.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmTodaysStatusOld
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(352, 296)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEntryDate)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmTodaysStatusOld"
        Me.Text = "Todays Status"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblBookingAmount As System.Windows.Forms.Label
    Friend WithEvents lblBooking As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lblTotalRecovery As System.Windows.Forms.Label
    Friend WithEvents lblChequeRecovery As System.Windows.Forms.Label
    Friend WithEvents lblCashRecovery As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEntryDate As C1.Win.C1Input.C1DateEdit
End Class
