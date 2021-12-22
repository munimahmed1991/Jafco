Imports System.Data
Imports System.Data.SqlClient
Imports C1.Win
Imports C1.Win.C1List
Imports System.IO
Imports System.Linq
Imports System.Xml.Linq
Public Class frmLogin
    Private LCounter As Integer = 0
    Dim Painting As Boolean
    Private Sub cmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLogin.Click

        Dim db As New dbOperations("SELECT * FROM tblUsers where Userid = '" & txtUse.Text & "' and Password = '" & txtPas.Text & "' And CompanyID = '" & cmbCompany.Columns(1).Text & "'")
        Dim dr As SqlDataReader = db.dbSelectQuery()

        If dr.HasRows Then
            dr.Read()
            cUserProject = RemoveNull(dr!Project, "")
            cUserType = dr!UserType
            cFinanceDepartment = RemoveNull(dr!FinanceDepartment, 0)
            Me.Cursor = Cursors.WaitCursor
            UserId = txtUse.Text
            cCompanyName = cmbCompany.Text
            cCompanyId = cmbCompany.Columns(1).Text
            cDivision = cmbCompany.Columns(2).Text

            '-------Task Pan Setting ---------------

            frmMain.ToolStripLabel7.Text = "        User   :  " & txtUse.Text
            frmMain.ToolStripLabel6.Text = "        Time   :  " & TimeOfDay
            frmMain.ToolStripLabel14.Text = "        Data Year     :  " & Strings.Left(cmbYear.Text, 4)
            frmMain.ToolStripLabel18.Text = "        Data Server :  " & Strings.Mid(cmbYear.Text, 6)
            frmMain.ToolStripLabel9.Text = "User : " & Mid(cmbYear.SelectedItem, 5, Len(cmbYear.SelectedItem.ToString)) & "\" & txtUse.Text
            frmMain.Text += " - [" + cCompanyName + "] - " + cDivision

            '-------- Save Setting for Current User---------
            WriteXml("Settings/CurrentUser/Database[text()]", cmbYear.SelectedItem.ToString)
            WriteXml("Settings/CurrentUser/UserName[text()]", txtUse.Text)
            '-------- End Save Setting for Current User---------

            '----------Load User Settings
            frmMain.ToolBarToolStripMenuItem.Checked = CBool(ReadXml("Settings/CurrentUser/View/Toolbar[text()]"))
            frmMain.ToolStrip.Visible = frmMain.ToolBarToolStripMenuItem.Checked

            frmMain.StatusBarToolStripMenuItem.Checked = CBool(ReadXml("Settings/CurrentUser/View/StatusBar[text()]"))
            frmMain.StatusStrip.Visible = frmMain.StatusBarToolStripMenuItem.Checked

            frmMain.ToolStripMenuItem1.Checked = CBool(ReadXml("Settings/CurrentUser/View/TaskPane[text()]"))
            frmMain.TaskPane.Visible = frmMain.ToolStripMenuItem1.Checked
            '----------End Load User Settings

            '---------- Status Bar Setting ----------
            frmMain.ToolStripLabel3.Text = "        Date :  " & Format(Date.Today(), "MMM dd, yyyy")
            frmMain.ToolStripLabel4.Text = "        Time :  " & TimeOfDay
            frmMain.ToolStripLabel13.Text = "Date : " & Format(Date.Today(), "MMM dd, yyyy")
            frmMain.ToolStripLabel12.Text = "Time : " & TimeOfDay
            frmMain.ToolStripLabel10.Enabled = My.Computer.Keyboard.CapsLock
            frmMain.ToolStripLabel17.Enabled = My.Computer.Keyboard.NumLock
            frmMain.ToolStripLabel16.Enabled = My.Computer.Keyboard.ScrollLock

            '----------Status Bar Setting--------------
            db.Close()
            dr.Close()
            Call SetDefaults()

            'Dim cLastUpdated As Date

            'cLastUpdated = "12/9/2011"

            'db = New dbOperations("Select LastUpdated,Case When LastUpdated = '" & Format(cLastUpdated, "MM/dd/yyyy") & "' Then 'Yes' Else 'No' End as Updated From tblDefaults Where CompanyId = '" & cCompanyId & "'")
            'dr = db.dbSelectQuery

            'If dr.HasRows Then
            '    dr.Read()

            '    If dr!Updated = "No" Then
            '        MsgBox("Please Update Exe Dated : " & Format(dr!LastUpdated, "dd/MM/yyyy"))
            '        Exit Sub
            '    End If
            'End If

            frmMain.Show()
            Me.Cursor = Cursors.Default
            Me.Close()

        Else
            LCounter += 1
            If LCounter >= 3 Then
                MsgBox("You have entered three times wrong password now application will be close.", MsgBoxStyle.Information, "Invalid Password")
                Me.Close()
                db.Close()
                Application.Exit()
            Else
                MsgBox("Invalid Password or User Name." & vbCrLf & "If you will enter wrong password for three time Application will be Closed.", MsgBoxStyle.Information, "Invalid Password")
                txtPas.Text = ""
                txtPas.Focus()
            End If
        End If
        'User.Close()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        If MsgBox("Are you realy want to Exit From Application", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
            Me.Close()
            End
            Application.Exit()
        End If
    End Sub

    Private Sub frmLogin_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call UserSettingXml()

        '-------------- Fill Year Combo From XML through Linq
        Painting = True
        ServerSettingFilePath = Application.StartupPath + "\Settings\ServerSettings.GTECH" ' \..\..\Settings
        Try

            Dim doc As XElement = XElement.Load(ServerSettingFilePath)
            Dim ids = From c In doc.<dbSelection> _
                        Select c.@id
            For Each id As String In ids
                cmbYear.Items.Add(DecryptString(id.ToString))
            Next

            cmbYear.Sorted = True
            'cmbYear.SelectedIndex = cmbYear.Items.Count - 1
            cmbYear.SelectedItem = ReadXml("Settings/CurrentUser/Database[text()]")

        Catch ex As Exception
            MsgBox("Error in Setting File" + vbCrLf + "Please : Contact your Administrator or software vendor.")
            Exit Sub
        End Try
        Painting = False
        '--------------------

        Call Main()
        If Me.cmdLogin.Enabled = True Then
            Call FillCombo()
        Else
            cmbYear.Focus()
            Exit Sub
        End If

        txtUse.Text = ReadXml("Settings/CurrentUser/UserName[text()]")
        If txtUse.Text = "" Then
            txtUse.TabIndex = 0
        Else
            txtPas.TabIndex = 0
        End If
    End Sub
    Sub FillCombo()
        Try
            Dim ds As New DataSet
            Dim Sql As String = "Select CompanyName, CompanyCode, Division From tblCompany Where CompanyCode <> 'CONS'"
            Dim da As New SqlDataAdapter(Sql, DefaultConString)
            da.Fill(ds, "tblCompany")
            cmbCompany.DataSource = ds
            cmbCompany.DataMember = "tblCompany"
            cmbCompany.ValueMember = "CompanyCode"
            cmbCompany.DisplayMember = "CompanyName"
            For Each dc As C1DisplayColumn In cmbCompany.Splits(0).DisplayColumns
                dc.AutoSize()
            Next
            cmbCompany.Splits(0).DisplayColumns(2).Width = 0
            da.Dispose()
            'ds.Dispose()
        Catch ex As Exception
            MsgBox("Connection Failed." + vbCrLf + "Please Select Another Data Year")
            Me.cmdLogin.Enabled = False
        End Try
    End Sub

    Private Sub txtUse_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUse.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtPas.Focus()
        End If
    End Sub

    Private Sub txtPas_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPas.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            cmdLogin.Focus()
        End If
    End Sub

    Private Sub cmbYear_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbYear.SelectedIndexChanged
        If Painting = False Then
            cmdLogin.Enabled = False
            Call Main()
            If cmdLogin.Enabled = True Then
                Call FillCombo()
            Else
                cmbYear.Focus()
                Exit Sub
            End If
        End If
    End Sub

    Private Sub C1PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles C1PictureBox1.DoubleClick
        If txtPas.Text = "gtech" Then
            frmServerSettings.Show()
            Me.Close()
        End If
    End Sub

    Private Sub C1PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles C1PictureBox1.Click

    End Sub
End Class