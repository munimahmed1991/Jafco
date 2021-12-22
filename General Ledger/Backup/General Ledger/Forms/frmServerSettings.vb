Imports System.Security.Cryptography
Imports System.IO.Stream
Imports System.IO
Imports System.Xml
Imports System.Xml.XPath
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient

Public Class frmServerSettings
    Private Data As ArrayList
    Private index As Integer
    Private NewClick As Boolean = False
    Private xmlSettingFilePath As String
    Private Document As New XmlDocument
    Private Navigator As XPathNavigator

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LoadFile()
    End Sub
    Private Sub LoadFile()
        xmlSettingFilePath = Application.StartupPath + "\Settings\ServerSettings.GTECH"
        Try
            Dim Doc As XElement = XElement.Load(xmlSettingFilePath)
            Call FillData()
            Call GetData(0)
        Catch ex As Exception
            For Each Control As Windows.Forms.Control In Me.Controls
                Control.Enabled = False
            Next

            MsgBox("Settings File Not Found")
            Me.cmdCreatFile.Visible = True
            Me.cmdCreatFile.Enabled = True
        End Try
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Application.Restart()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        If txtServer.Text = Nothing Then
            MsgBox("Server name is mandatory")
            Exit Sub
        ElseIf txtYear.Text = Nothing Then
            MsgBox("Year is mandatory")
            Exit Sub
        End If
        If NewClick = False And Data.Count = 0 Then
            MsgBox("there is no record for modify pls Press new button and save record.")
            Exit Sub
        End If
        If NewClick = True Then

            Dim Doc As XDocument = XDocument.Load(xmlSettingFilePath)
            Dim Setting = Doc.<Settings>(0)
            Dim dbSelection As XElement = _
                        New XElement("dbSelection", New XAttribute("id", EncryptString(txtYear.Text + "-" + txtServer.Text)), _
                        New XElement("Year", EncryptString(txtYear.Text)), _
                        New XElement("Server", EncryptString(txtServer.Text)), _
                        New XElement("GlDb", EncryptString(txtGlDb.Text)), _
                        New XElement("InvDb", EncryptString(txtInvDb.Text)), _
                        New XElement("Pws", EncryptString(txtPws.Text)), _
                        New XElement("FromYear", EncryptString(txtFromYear.Text)), _
                        New XElement("ToYear", EncryptString(txtToYear.Text)) _
                    )

            Setting.AddFirst(dbSelection)
            Setting.Save(xmlSettingFilePath)
            NewClick = False

        ElseIf NewClick = False Then
            'Edit Mode
            ' First Delete Record
            Document.Load(xmlSettingFilePath)
            Navigator = Document.CreateNavigator
            Navigator.MoveToRoot()
            Navigator.MoveToFirstChild()
            Navigator.MoveToFirstChild()

            While Navigator.HasChildren

                'Navigator.MoveToFirstChild()
                Do
                    Dim id As String = DecryptString(Navigator.GetAttribute("id", ""))
                    If id = txtID.Text Then
                        Navigator.DeleteSelf()
                        Exit While
                    End If

                Loop While (Navigator.MoveToNext())
                Navigator.MoveToNext()
            End While
            Document.Save(xmlSettingFilePath)



            'Second Insert new Record
            Dim Doc As XDocument = XDocument.Load(xmlSettingFilePath)
            Dim Setting = Doc.<Settings>(0)
            Dim dbSelection As XElement = _
                        New XElement("dbSelection", New XAttribute("id", EncryptString(txtYear.Text + "-" + txtServer.Text)), _
                        New XElement("Year", EncryptString(txtYear.Text)), _
                        New XElement("Server", EncryptString(txtServer.Text)), _
                        New XElement("GlDb", EncryptString(txtGlDb.Text)), _
                        New XElement("InvDb", EncryptString(txtInvDb.Text)), _
                        New XElement("Pws", EncryptString(txtPws.Text)), _
                        New XElement("FromYear", EncryptString(txtFromYear.Text)), _
                        New XElement("ToYear", EncryptString(txtToYear.Text)) _
                    )

            Setting.AddFirst(dbSelection)
            Setting.Save(xmlSettingFilePath)
        End If

        Call FillData()
        Call GetData(0)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        Pb.Visible = True
        Pb.Value = 3
        Try
            Pb.Value = 3
            Dim ConString As String
            Pb.Value = 10
            Dim cDbName As String = txtGlDb.Text + Trim(CStr(txtYear.Text))
            Pb.Value = 20
            ConString = String.Format("Data Source={0};uid=sa;pwd={1};Initial Catalog={2}", txtServer.Text, txtPws.Text, cDbName)
            Pb.Value = 30
            Dim cn As SqlConnection = New SqlConnection(ConString)
            Pb.Value = 35
            cn.Close()
            Pb.Value = 45
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            Pb.Value = 65
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            Pb.Value = 85
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            cn.Open()
            cn.Close()
            Pb.Value = 100

            MsgBox("Sever Connectivity checking is Successfully Completed.", MsgBoxStyle.OkOnly)
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        End Try
        Pb.Visible = False
    End Sub

    Public Sub FillData()

        'Array.Clear(DB, 0, DB.Length)

        Data = New ArrayList
        index = 0

        Dim Doc As XElement = XElement.Load(xmlSettingFilePath)
        Dim xml = From q In Doc.Elements("dbSelection") Select q
        For Each x As System.Xml.Linq.XElement In xml
            Dim db As New Database
            db.Id = DecryptString(x.@id) 'x.Elements("Year").Value) + "-" + DecryptString(x.Elements("Server").Value)
            db.Year = DecryptString(x.Elements("Year").Value)
            db.Server = DecryptString(x.Elements("Server").Value)
            db.GlDb = DecryptString(x.Elements("GlDb").Value)
            db.InvDb = DecryptString(x.Elements("InvDb").Value)
            db.Pws = DecryptString(x.Elements("Pws").Value)
            db.FromYear = DecryptString(x.Elements("FromYear").Value)
            db.ToYear = DecryptString(x.Elements("ToYear").Value)
            Data.Add(db)
        Next
    End Sub

    Public Sub GetData(ByVal i As Integer)
        If Data.Count < 1 Then
            MsgBox("No record Available")
            Call ClearData()
            Exit Sub
        End If
        If i >= Data.Count Then
            MsgBox("Invalid Index No.")
            Exit Sub
        End If
        If i < 0 Then
            MsgBox("Invalid Index No.")
            Exit Sub
        End If

        Dim d As Database = Data(i)
        txtID.Text = d.Id
        txtServer.Text = d.Server
        txtGlDb.Text = d.GlDb
        txtInvDb.Text = d.InvDb
        txtYear.Text = d.Year
        txtFromYear.Text = d.FromYear
        txtToYear.Text = d.ToYear
        txtPws.Text = d.Pws

    End Sub
   
    Private Sub cmdNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNext.Click
        If Not index = Data.Count - 1 Then
            index += 1

        End If
        GetData(index)
    End Sub

    Private Sub cmdPrevious_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrevious.Click
        If Not index = 0 Then
            index -= 1
        End If
        GetData(index)
    End Sub

    Private Sub cmdNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdNew.Click
        Call ClearData()
        NewClick = True
        txtServer.Focus()
    End Sub

    Public Sub ClearData()
        txtFromYear.Text = ""
        txtGlDb.Text = ""
        txtID.Text = ""
        txtInvDb.Text = ""
        txtPws.Text = ""
        txtServer.Text = ""
        txtToYear.Text = ""
        txtYear.Text = ""
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If Data.Count = 0 Then
            MsgBox("There is no record for delete.")
            Exit Sub
        End If
        If MsgBox("Are sure that you want to delete this record", MsgBoxStyle.YesNo + MsgBoxStyle.Question) = MsgBoxResult.Yes Then
            Document.Load(xmlSettingFilePath)
            Navigator = Document.CreateNavigator
            Navigator.MoveToRoot()
            Navigator.MoveToFirstChild()
            Navigator.MoveToFirstChild()

            While Navigator.HasChildren

                'Navigator.MoveToFirstChild()
                Do
                    Dim id As String = DecryptString(Navigator.GetAttribute("id", ""))
                    If id = txtID.Text Then
                        Navigator.DeleteSelf()
                        Exit While
                    End If

                Loop While (Navigator.MoveToNext())
                Navigator.MoveToNext()
            End While
            Document.Save(xmlSettingFilePath)

            Call FillData()
            Call GetData(0)
        End If

    End Sub

    Private Sub cmdCreatFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCreatFile.Click
        For Each Control As Windows.Forms.Control In Me.Controls
            Control.Enabled = True
        Next
        Me.txtID.Enabled = False
        Me.cmdCreatFile.Visible = False
        Me.cmdCreatFile.Enabled = False

        Dim xml = <?xml version="1.0" encoding="utf-8"?>
                  <Settings>

                  </Settings>
        My.Computer.FileSystem.CreateDirectory(Application.StartupPath + "\Settings")
        xml.Save(Application.StartupPath + "\Settings\ServerSettings.GTECH")

        Call LoadFile()

        Call ClearData()
        NewClick = True
        txtServer.Focus()
    End Sub
End Class

Public Class Database
    'Public Sub New()

    'End Sub
    Private _Id As String
    Public Property Id() As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property

    Private _Year As String
    Public Property Year() As String
        Get
            Return _Year
        End Get
        Set(ByVal value As String)
            _Year = value
        End Set
    End Property


    Private _Server As String
    Public Property Server() As String
        Get
            Return _Server
        End Get
        Set(ByVal value As String)
            _Server = value
        End Set
    End Property


    Private _GlDb As String
    Public Property GlDb() As String
        Get
            Return _GlDb
        End Get
        Set(ByVal value As String)
            _GlDb = value
        End Set
    End Property


    Private _InvDb As String
    Public Property InvDb() As String
        Get
            Return _InvDb
        End Get
        Set(ByVal value As String)
            _InvDb = value
        End Set
    End Property

    Private _FromYear As String
    Public Property FromYear() As String
        Get
            Return _FromYear
        End Get
        Set(ByVal value As String)
            _FromYear = value
        End Set
    End Property


    Private _ToYear As String
    Public Property ToYear() As String
        Get
            Return _ToYear
        End Get
        Set(ByVal value As String)
            _ToYear = value
        End Set
    End Property


    Private _Pws As String
    Public Property Pws() As String
        Get
            Return _Pws
        End Get
        Set(ByVal value As String)
            _Pws = value
        End Set
    End Property



End Class