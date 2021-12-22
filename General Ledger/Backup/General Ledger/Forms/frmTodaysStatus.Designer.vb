<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTodaysStatus
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTodaysStatus))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbProject = New C1.Win.C1List.C1Combo
        Me.Label6 = New System.Windows.Forms.Label
        Me.cmdRefresh = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.txtEntryDate = New C1.Win.C1Input.C1DateEdit
        Me.Label1 = New System.Windows.Forms.Label
        Me.txtDateTo = New C1.Win.C1Input.C1DateEdit
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.Label7.Text = "From"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(192, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(20, 13)
        Me.Label1.TabIndex = 245
        Me.Label1.Text = "To"
        '
        'txtDateTo
        '
        Me.txtDateTo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        '
        '
        '
        Me.txtDateTo.Calendar.AnnuallyBoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.BoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.ClearText = "&Clear"
        Me.txtDateTo.Calendar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.Calendar.Margin = New System.Windows.Forms.Padding(0)
        Me.txtDateTo.Calendar.MonthlyBoldedDates = New Date(-1) {}
        Me.txtDateTo.Calendar.SelectedDate = New Date(2008, 7, 11, 0, 0, 0, 0)
        Me.txtDateTo.Calendar.TodayText = "&Today"
        Me.txtDateTo.Calendar.VisualStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateTo.Calendar.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.System
        Me.txtDateTo.Culture = 1056
        Me.txtDateTo.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.CustomFormat = "dd/MM/yyyy"
        Me.txtDateTo.DisplayFormat.Inherit = CType(((((C1.Win.C1Input.FormatInfoInheritFlags.FormatType Or C1.Win.C1Input.FormatInfoInheritFlags.NullText) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.EmptyAsNull) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtDateTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDateTo.FormatType = C1.Win.C1Input.FormatTypeEnum.ShortDate
        Me.txtDateTo.Location = New System.Drawing.Point(219, 10)
        Me.txtDateTo.Name = "txtDateTo"
        Me.txtDateTo.Size = New System.Drawing.Size(126, 19)
        Me.txtDateTo.TabIndex = 244
        Me.txtDateTo.Tag = Nothing
        Me.txtDateTo.TrimEnd = False
        Me.txtDateTo.Value = New Date(2007, 8, 22, 0, 0, 0, 0)
        Me.txtDateTo.VisualStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        Me.txtDateTo.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmTodaysStatus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 87)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtDateTo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtEntryDate)
        Me.Controls.Add(Me.cmdRefresh)
        Me.Controls.Add(Me.cmbProject)
        Me.Controls.Add(Me.Label6)
        Me.MaximizeBox = False
        Me.Name = "frmTodaysStatus"
        Me.Text = "Todays Status"
        CType(Me.cmbProject, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtEntryDate, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDateTo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmbProject As C1.Win.C1List.C1Combo
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdRefresh As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtEntryDate As C1.Win.C1Input.C1DateEdit
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtDateTo As C1.Win.C1Input.C1DateEdit
End Class
