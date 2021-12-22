<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCheckOfficial
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtCashAmount = New C1.Win.C1Input.C1NumericEdit
        Me.txtCashAmountCollected = New C1.Win.C1Input.C1NumericEdit
        Me.txtCashAmountBalanced = New C1.Win.C1Input.C1NumericEdit
        Me.txtServiceAmountBalance = New C1.Win.C1Input.C1NumericEdit
        Me.txtServiceAmountCollected = New C1.Win.C1Input.C1NumericEdit
        Me.txtServiceAmount = New C1.Win.C1Input.C1NumericEdit
        CType(Me.txtCashAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashAmountCollected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtCashAmountBalanced, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServiceAmountBalance, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServiceAmountCollected, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtServiceAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(35, 37)
        Me.Label1.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(178, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cash Amount Official"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Lime
        Me.Label2.Location = New System.Drawing.Point(35, 97)
        Me.Label2.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(151, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Amount Collected"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(35, 155)
        Me.Label3.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Amount Balanced"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(541, 154)
        Me.Label4.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(151, 20)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Amount Balanced"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Lime
        Me.Label5.Location = New System.Drawing.Point(541, 96)
        Me.Label5.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Amount Collected"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(541, 36)
        Me.Label6.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(196, 20)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Service Amount Official"
        '
        'txtCashAmount
        '
        Me.txtCashAmount.AutoSize = False
        Me.txtCashAmount.BackColor = System.Drawing.Color.Black
        Me.txtCashAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtCashAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCashAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCashAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashAmount.ForeColor = System.Drawing.Color.White
        Me.txtCashAmount.Location = New System.Drawing.Point(272, 34)
        Me.txtCashAmount.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCashAmount.Name = "txtCashAmount"
        Me.txtCashAmount.Size = New System.Drawing.Size(187, 31)
        Me.txtCashAmount.TabIndex = 272
        Me.txtCashAmount.Tag = Nothing
        Me.txtCashAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCashAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCashAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCashAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtCashAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCashAmountCollected
        '
        Me.txtCashAmountCollected.AutoSize = False
        Me.txtCashAmountCollected.BackColor = System.Drawing.Color.Black
        Me.txtCashAmountCollected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashAmountCollected.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtCashAmountCollected.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCashAmountCollected.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCashAmountCollected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashAmountCollected.ForeColor = System.Drawing.Color.Lime
        Me.txtCashAmountCollected.Location = New System.Drawing.Point(272, 91)
        Me.txtCashAmountCollected.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCashAmountCollected.Name = "txtCashAmountCollected"
        Me.txtCashAmountCollected.Size = New System.Drawing.Size(187, 31)
        Me.txtCashAmountCollected.TabIndex = 273
        Me.txtCashAmountCollected.Tag = Nothing
        Me.txtCashAmountCollected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCashAmountCollected.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCashAmountCollected.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCashAmountCollected.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtCashAmountCollected.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtCashAmountBalanced
        '
        Me.txtCashAmountBalanced.AutoSize = False
        Me.txtCashAmountBalanced.BackColor = System.Drawing.Color.Black
        Me.txtCashAmountBalanced.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCashAmountBalanced.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtCashAmountBalanced.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtCashAmountBalanced.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtCashAmountBalanced.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCashAmountBalanced.ForeColor = System.Drawing.Color.Red
        Me.txtCashAmountBalanced.Location = New System.Drawing.Point(272, 149)
        Me.txtCashAmountBalanced.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.txtCashAmountBalanced.Name = "txtCashAmountBalanced"
        Me.txtCashAmountBalanced.Size = New System.Drawing.Size(187, 31)
        Me.txtCashAmountBalanced.TabIndex = 274
        Me.txtCashAmountBalanced.Tag = Nothing
        Me.txtCashAmountBalanced.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtCashAmountBalanced.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtCashAmountBalanced.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtCashAmountBalanced.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtCashAmountBalanced.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtServiceAmountBalance
        '
        Me.txtServiceAmountBalance.AutoSize = False
        Me.txtServiceAmountBalance.BackColor = System.Drawing.Color.Black
        Me.txtServiceAmountBalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServiceAmountBalance.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtServiceAmountBalance.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtServiceAmountBalance.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtServiceAmountBalance.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceAmountBalance.ForeColor = System.Drawing.Color.Red
        Me.txtServiceAmountBalance.Location = New System.Drawing.Point(756, 145)
        Me.txtServiceAmountBalance.Margin = New System.Windows.Forms.Padding(5)
        Me.txtServiceAmountBalance.Name = "txtServiceAmountBalance"
        Me.txtServiceAmountBalance.Size = New System.Drawing.Size(187, 31)
        Me.txtServiceAmountBalance.TabIndex = 277
        Me.txtServiceAmountBalance.Tag = Nothing
        Me.txtServiceAmountBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtServiceAmountBalance.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtServiceAmountBalance.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtServiceAmountBalance.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtServiceAmountBalance.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtServiceAmountCollected
        '
        Me.txtServiceAmountCollected.AutoSize = False
        Me.txtServiceAmountCollected.BackColor = System.Drawing.Color.Black
        Me.txtServiceAmountCollected.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServiceAmountCollected.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtServiceAmountCollected.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtServiceAmountCollected.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtServiceAmountCollected.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceAmountCollected.ForeColor = System.Drawing.Color.Lime
        Me.txtServiceAmountCollected.Location = New System.Drawing.Point(756, 87)
        Me.txtServiceAmountCollected.Margin = New System.Windows.Forms.Padding(5)
        Me.txtServiceAmountCollected.Name = "txtServiceAmountCollected"
        Me.txtServiceAmountCollected.Size = New System.Drawing.Size(187, 31)
        Me.txtServiceAmountCollected.TabIndex = 276
        Me.txtServiceAmountCollected.Tag = Nothing
        Me.txtServiceAmountCollected.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtServiceAmountCollected.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtServiceAmountCollected.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtServiceAmountCollected.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtServiceAmountCollected.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'txtServiceAmount
        '
        Me.txtServiceAmount.AutoSize = False
        Me.txtServiceAmount.BackColor = System.Drawing.Color.Black
        Me.txtServiceAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtServiceAmount.DisplayFormat.CustomFormat = "###,###,##0"
        Me.txtServiceAmount.DisplayFormat.FormatType = C1.Win.C1Input.FormatTypeEnum.CustomFormat
        Me.txtServiceAmount.DisplayFormat.Inherit = CType(((C1.Win.C1Input.FormatInfoInheritFlags.NullText Or C1.Win.C1Input.FormatInfoInheritFlags.TrimStart) _
                    Or C1.Win.C1Input.FormatInfoInheritFlags.TrimEnd), C1.Win.C1Input.FormatInfoInheritFlags)
        Me.txtServiceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtServiceAmount.ForeColor = System.Drawing.Color.White
        Me.txtServiceAmount.Location = New System.Drawing.Point(756, 30)
        Me.txtServiceAmount.Margin = New System.Windows.Forms.Padding(5)
        Me.txtServiceAmount.Name = "txtServiceAmount"
        Me.txtServiceAmount.Size = New System.Drawing.Size(187, 31)
        Me.txtServiceAmount.TabIndex = 275
        Me.txtServiceAmount.Tag = Nothing
        Me.txtServiceAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtServiceAmount.Value = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtServiceAmount.VerticalAlign = C1.Win.C1Input.VerticalAlignEnum.Middle
        Me.txtServiceAmount.VisibleButtons = C1.Win.C1Input.DropDownControlButtonFlags.None
        Me.txtServiceAmount.VisualStyleBaseStyle = C1.Win.C1Input.VisualStyle.Office2007Blue
        '
        'frmCheckOfficial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1167, 220)
        Me.Controls.Add(Me.txtServiceAmountBalance)
        Me.Controls.Add(Me.txtServiceAmountCollected)
        Me.Controls.Add(Me.txtServiceAmount)
        Me.Controls.Add(Me.txtCashAmountBalanced)
        Me.Controls.Add(Me.txtCashAmountCollected)
        Me.Controls.Add(Me.txtCashAmount)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmCheckOfficial"
        CType(Me.txtCashAmount, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashAmountCollected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtCashAmountBalanced, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServiceAmountBalance, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServiceAmountCollected, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtServiceAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtCashAmount As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCashAmountCollected As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtCashAmountBalanced As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtServiceAmountBalance As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtServiceAmountCollected As C1.Win.C1Input.C1NumericEdit
    Friend WithEvents txtServiceAmount As C1.Win.C1Input.C1NumericEdit
End Class
