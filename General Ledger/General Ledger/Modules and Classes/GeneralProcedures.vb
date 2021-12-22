Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.Common
Imports System.Security.Cryptography
Imports System.IO.Stream
Imports System.IO
Imports System.Text
Imports System.DBNull
Imports System.Xml.Linq
Imports System.Xml
Imports System.Xml.XPath
Imports System
Imports System.Web
Imports System.Net
Imports System.Net.Mail

Public Module GeneralProcedures
    Public DefaultConString As String
    Public GLConString As String
    Public OnlineConstring As String
    Public PayRollConString As String
    Public strActiveForm As String
    Public ConString As String
    Public DateTo As Date
    Public DateFrom As Date
    Public UserId As String
    Public cCompany As String
    Public cCompanyId As String
    Public cCompanyName As String
    Public cDivision As String
    Public ServerSettingFilePath As String
    Public cUserProject As String
    Public cUserType As String
    Public cUserLocation As String
    Public cFinanceDepartment As Integer
    Public CurrentDate As Date
    Public cDbName As String

    'Public cLocationCode As String
    'Public cLocationName As String
    'Public cLocationPrefix As String

    'Public Sub SetLocaitons()
    '    Dim db As dbOperations
    '    Dim dr As SqlDataReader

    '    db = New dbOperations("Select Location,L.LocationName,L.Prefix From tblCompany Left Outer Join tblLocation L On tblCompany.Location = L.LocationCode Where CompanyCode = '" & cCompanyId & "'")
    '    dr = db.dbSelectQuery

    '    If dr.HasRows = True Then
    '        dr.Read()

    '        cLocationCode = RemoveNull(dr!Location, "")
    '        cLocationName = RemoveNull(dr!LocationName, "")
    '        cLocationPrefix = RemoveNull(dr!Prefix, "")
    '    Else
    '        MsgBox("No Location Defined in this Company : GTECH ")
    '        Exit Sub
    '    End If

    '    dr.Close()
    '    db.Close()
    'End Sub






    Public Sub Main()
        Dim doc As XElement = XElement.Load(ServerSettingFilePath)
        Dim d = From q In doc.Elements("dbSelection") Where q.@id = EncryptString(frmLogin.cmbYear.Text) Select q
        Dim Year As String = ""
        Dim Server As String = ""
        Dim GIDb As String = ""
        Dim InvDB As String = ""
        Dim SQLServerUser As String = ""
        Dim ToYear As String = ""
        Dim Pws As String = ""

        For Each item As XElement In d
            Year = DecryptString(item.Elements("Year").Value)
            Server = DecryptString(item.Elements("Server").Value)
            GIDb = DecryptString(item.Elements("GlDb").Value)
            InvDB = DecryptString(item.Elements("InvDb").Value)
            Pws = DecryptString(item.Elements("Pws").Value)
            SQLServerUser = DecryptString(item.Elements("FromYear").Value)
            ToYear = DecryptString(item.Elements("ToYear").Value)
        Next

        cDbName = InvDB + Trim(CStr(Year))
        Dim cGlName As String = GIDb + Trim(CStr(Year))
        Dim PRDbName As String = "PAYROLL" + Trim(CStr(Year))

        If Pws = "Cr3d3nti415" Then
            ConString = String.Format("Data Source={0};uid=gtech;pwd={1};Initial Catalog={2}", Server, Pws, cDbName)
            GLConString = String.Format("Data Source={0};uid=gtech;pwd={1};Initial Catalog={2}", Server, Pws, cGlName)
            DefaultConString = String.Format("Data Source={0};uid=gtech;pwd={1};Initial Catalog={2}", Server, Pws, cDbName)
            PayRollConString = String.Format("Data Source={0};uid=gtech;pwd={1};Initial Catalog={2}", Server, Pws, PRDbName)
        Else
            ConString = String.Format("Data Source={0};uid=sa;pwd={1};Initial Catalog={2}", Server, Pws, cDbName)
            GLConString = String.Format("Data Source={0};uid=sa;pwd={1};Initial Catalog={2}", Server, Pws, cGlName)
            DefaultConString = String.Format("Data Source={0};uid=sa;pwd={1};Initial Catalog={2}", Server, Pws, cDbName)
            PayRollConString = String.Format("Data Source={0};uid=sa;pwd={1};Initial Catalog={2}", Server, Pws, PRDbName)
        End If

        Try
            Dim cn As New SqlConnection(DefaultConString)
            cn.Open()
            cn.Close()
            frmLogin.cmdLogin.Enabled = True
        Catch ex As Exception
            MessageBox.Show("Connection Fail With Data Server" + vbCrLf + "Please Contact your Administrator for Assistance.", "G-Tech.", MessageBoxButtons.OK, MessageBoxIcon.Error)
            frmLogin.cmdLogin.Enabled = False
            Exit Sub
        Finally
        End Try
    End Sub

    Private mCSP As SymmetricAlgorithm = New TripleDESCryptoServiceProvider



    Public Function ReadXml(ByVal Path As String) As String
        Try
            Dim xml As XPathDocument
            xml = New XPathDocument(UserSettingFilePath)
            Dim navigator As XPathNavigator = xml.CreateNavigator()
            Dim result As XPathNavigator
            result = navigator.SelectSingleNode(Path)
            Return DecryptString(result.Value)
        Catch ex As Exception
            If System.IO.File.Exists(UserSettingFilePath) Then
                System.IO.File.Delete(UserSettingFilePath)
            End If
            Call UserSettingXml()
            Dim xml As XPathDocument
            xml = New XPathDocument(UserSettingFilePath)
            Dim navigator As XPathNavigator = xml.CreateNavigator()
            Dim result As XPathNavigator
            result = navigator.SelectSingleNode(Path)
            Return DecryptString(result.Value)
        End Try
    End Function

    Public Sub WriteXml(ByVal Path As String, ByVal Value As String)
        Try
            Dim xml As New XmlDocument
            xml.Load(UserSettingFilePath)
            xml.SelectNodes(Path)
            Dim a As XmlNode = xml.SelectSingleNode(Path)
            a.InnerText = EncryptString(Value)
            xml.Save(UserSettingFilePath)
        Catch ex As Exception
            If System.IO.File.Exists(UserSettingFilePath) Then
                System.IO.File.Delete(UserSettingFilePath)
            End If
            Call UserSettingXml()
            Dim xml As New XmlDocument
            xml.Load(UserSettingFilePath)
            xml.SelectNodes(Path)
            Dim a As XmlNode = xml.SelectSingleNode(Path)
            a.InnerText = EncryptString(Value)
            xml.Save(UserSettingFilePath)
        End Try
    End Sub

    Public Function EncryptString(ByVal Value As String) As String
        Dim ct As ICryptoTransform
        Dim ms As MemoryStream
        Dim cs As CryptoStream
        Dim byt() As Byte
        Dim a As Byte()

        Dim b As Byte() = {203, 199, 175, 106, 124, 124, 241, 151}
        a = Convert.FromBase64String("BUdtgwCPxY+eKhwRtgFMGArmmvGboYEb")

        ct = mCSP.CreateEncryptor(a, b)
        byt = Encoding.UTF8.GetBytes(Value)

        ms = New MemoryStream
        cs = New CryptoStream(ms, ct, CryptoStreamMode.Write)
        cs.Write(byt, 0, byt.Length)
        cs.FlushFinalBlock()

        cs.Close()

        Return Convert.ToBase64String(ms.ToArray())
    End Function

    Public Function DecryptString(ByVal Value As String) As String
        Dim ct As ICryptoTransform
        Dim ms As MemoryStream
        Dim cs As CryptoStream
        Dim byt() As Byte
        Dim b As Byte() = {203, 199, 175, 106, 124, 124, 241, 151}

        ct = mCSP.CreateDecryptor(Convert.FromBase64String("BUdtgwCPxY+eKhwRtgFMGArmmvGboYEb"), b)

        byt = Convert.FromBase64String(Value)

        ms = New MemoryStream
        cs = New CryptoStream(ms, ct, CryptoStreamMode.Write)
        cs.Write(byt, 0, byt.Length)
        cs.FlushFinalBlock()

        cs.Close()

        Return Encoding.UTF8.GetString(ms.ToArray())
    End Function
   
    Public Sub FormCenter(ByRef nForm As Form)
        If nForm.IsMdiChild Then
            nForm.Left = (frmMain.Width - nForm.Width) / 2 - (IIf(frmMain.TaskPane.Visible, frmMain.TaskPane.Width, 0) / 2) - 3
            nForm.Top = (frmMain.Height - nForm.Height) / 2 - (IIf(frmMain.StatusStrip.Visible, frmMain.StatusStrip.Height, 0) + 65 + IIf(frmMain.ToolStrip.Visible, frmMain.ToolStrip.Height, 0)) / 2
        Else
            nForm.Left = (frmMain.Width - nForm.Width) / 2 + (IIf(frmMain.TaskPane.Visible, frmMain.TaskPane.Width, 0) / 2)
            nForm.Top = (frmMain.Height - nForm.Height) / 2 + (IIf(frmMain.StatusStrip.Visible, frmMain.StatusStrip.Height, 0) + IIf(frmMain.ToolStrip.Visible, frmMain.ToolStrip.Height, 0)) / 2
        End If
    End Sub

    Public Function ToWords(ByVal tnetamt2 As Double, ByVal SymbolType As String) As String
        Dim sw9 = 0
        Dim netamt2 = tnetamt2
        Dim strDecimal
        If InStr(1, Str(netamt2), ".") > 0 Then
            strDecimal = Left("." & Mid(Str(netamt2), InStr(1, Str(netamt2), ".") + 1) & "00", 3)
        Else
            strDecimal = ".00"
        End If

        Dim figr = Right(Space(12) + Str(Int(netamt2)) + strDecimal, 12)

        Dim hndrd1 = Val(Mid(figr, 1, 1))
        Dim mill = Val(Mid(figr, 2, 2))
        Dim hndrd2 = Val(Mid(figr, 4, 1))
        Dim thsnd = Val(Mid(figr, 5, 2))
        Dim hndrd3 = Val(Mid(figr, 7, 1))
        Dim hndrd = Val(Mid(figr, 8, 2))
        Dim paisa = Val(Mid(figr, 11, 2))
        Dim sw = 1
        Dim descending = ""
        Dim vlue = 0
        Dim words = ""
        Dim figrdesc = ""
        Do While sw <> 8
            If sw = 7 Then
                vlue = paisa
                descending = Space(1)
            End If
            If sw = 6 Then
                vlue = hndrd
                descending = Space(1)
                If paisa > 0 Then
                    If SymbolType = "AMT" Then
                        descending = "AND SENTS "
                    ElseIf SymbolType = "QTY" Then
                        descending = "POINT "
                    End If
                End If
            End If
            If sw = 5 Then
                vlue = hndrd3
                descending = IIf(vlue > 0, "HUNDRED ", "")
            End If
            If sw = 4 Then
                vlue = thsnd
                descending = IIf(vlue > 0, "THOUSAND ", "")
            End If
            If sw = 3 Then
                vlue = hndrd2
                descending = IIf(vlue > 0, "HUNDRED ", "")
                If vlue > 0 And thsnd = 0 Then
                    descending = "HUNDRED THOUSANDS "
                End If
            End If
            If sw = 2 Then
                vlue = mill
                descending = IIf(vlue > 0, "MILLION ", "")
            End If
            If sw = 1 Then
                vlue = hndrd1
                descending = IIf(vlue > 0, "HUNDRED ", "")
            End If
            If vlue = 0 Then
                words = ""
            End If
            If vlue = 1 Then
                words = "ONE "
            End If
            If vlue = 2 Then
                words = "TWO "
            End If
            If vlue = 3 Then
                words = "THREE "
            End If
            If vlue = 4 Then
                words = "FOUR "
            End If
            If vlue = 5 Then
                words = "FIVE "
            End If
            If vlue = 6 Then
                words = "SIX "
            End If
            If vlue = 7 Then
                words = "SEVEN "
            End If
            If vlue = 8 Then
                words = "EIGHT "
            End If
            If vlue = 9 Then
                words = "NINE "
            End If
            If vlue = 10 Then
                words = "TEN "
            End If
            If vlue = 11 Then
                words = "ELEVEN "
            End If
            If vlue = 12 Then
                words = "TWELVE "
            End If
            If vlue = 13 Then
                words = "THIRTEEN "
            End If
            If vlue = 14 Then
                words = "FORTEEN "
            End If
            If vlue = 15 Then
                words = "FIFTEEN "
            End If
            If vlue = 16 Then
                words = "SIXTEEN "
            End If
            If vlue = 17 Then
                words = "SEVENTEEN "
            End If
            If vlue = 18 Then
                words = "EIGHTEEN "
            End If
            If vlue = 19 Then
                words = "NINETEEN "
            End If
            If vlue = 20 Then
                words = "TWENTY "
            End If
            If vlue = 21 Then
                words = "TWENTY ONE "
            End If
            If vlue = 22 Then
                words = "TWENTY TWO "
            End If
            If vlue = 23 Then
                words = "TWENTY THREE "
            End If
            If vlue = 24 Then
                words = "TWENTY FOUR "
            End If
            If vlue = 25 Then
                words = "TWENTY FIVE "
            End If
            If vlue = 26 Then
                words = "TWENTY SIX "
            End If
            If vlue = 27 Then
                words = "TWENTY SEVEN "
            End If
            If vlue = 28 Then
                words = "TWENTY EIGHT "
            End If
            If vlue = 29 Then
                words = "TWENTY NINE "
            End If
            If vlue = 30 Then
                words = "THIRTY "
            End If
            If vlue = 31 Then
                words = "THIRTY ONE "
            End If
            If vlue = 32 Then
                words = "THIRTY TWO "
            End If
            If vlue = 33 Then
                words = "THIRTY THREE "
            End If
            If vlue = 34 Then
                words = "THIRTY FOUR "
            End If
            If vlue = 35 Then
                words = "THIRTY FIVE "
            End If
            If vlue = 36 Then
                words = "THIRTY SIX "
            End If
            If vlue = 37 Then
                words = "THIRTY SEVEN "
            End If
            If vlue = 38 Then
                words = "THIRTY EIGHT "
            End If
            If vlue = 39 Then
                words = "THIRTY NINE "
            End If
            If vlue = 40 Then
                words = "FORTY "
            End If
            If vlue = 41 Then
                words = "FORTY ONE "
            End If
            If vlue = 42 Then
                words = "FORTY TWO "
            End If
            If vlue = 43 Then
                words = "FORTY THREE "
            End If
            If vlue = 44 Then
                words = "FORTY FOUR "
            End If
            If vlue = 45 Then
                words = "FORTY FIVE "
            End If
            If vlue = 46 Then
                words = "FORTY SIX "
            End If
            If vlue = 47 Then
                words = "FORTY SEVEN "
            End If
            If vlue = 48 Then
                words = "FORTY EIGHT "
            End If
            If vlue = 49 Then
                words = "FORTY NINE "
            End If
            If vlue = 50 Then
                words = "FIFTY "
            End If
            If vlue = 51 Then
                words = "FIFTY ONE "
            End If
            If vlue = 52 Then
                words = "FIFTY TWO "
            End If
            If vlue = 53 Then
                words = "FIFTY THREE "
            End If
            If vlue = 54 Then
                words = "FIFTY FOUR "
            End If
            If vlue = 55 Then
                words = "FIFTY FIVE "
            End If
            If vlue = 56 Then
                words = "FIFTY SIX "
            End If
            If vlue = 57 Then
                words = "FIFTY SEVEN "
            End If
            If vlue = 58 Then
                words = "FIFTYEIGHT "
            End If
            If vlue = 59 Then
                words = "FIFTYNINE "
            End If
            If vlue = 60 Then
                words = "SIXTY "
            End If
            If vlue = 61 Then
                words = "SIXTY ONE "
            End If
            If vlue = 62 Then
                words = "SIXTY TWO "
            End If
            If vlue = 63 Then
                words = "SIXTY THREE "
            End If
            If vlue = 64 Then
                words = "SIXTY FOUR "
            End If
            If vlue = 65 Then
                words = "SIXTY FIVE "
            End If
            If vlue = 66 Then
                words = "SIXTY SIX "
            End If
            If vlue = 67 Then
                words = "SIXTY SEVEN "
            End If
            If vlue = 68 Then
                words = "SIXTY EIGHT "
            End If
            If vlue = 69 Then
                words = "SIXTY NINE "
            End If
            If vlue = 70 Then
                words = "SEVENTY "
            End If
            If vlue = 71 Then
                words = "SEVENTY ONE "
            End If
            If vlue = 72 Then
                words = "SEVENTY TWO "
            End If
            If vlue = 73 Then
                words = "SEVENTY THREE "
            End If
            If vlue = 74 Then
                words = "SEVENTY FOUR "
            End If
            If vlue = 75 Then
                words = "SEVENTY FIVE "
            End If
            If vlue = 76 Then
                words = "SEVENTY SIX "
            End If
            If vlue = 77 Then
                words = "SEVENTY SEVEN "
            End If
            If vlue = 78 Then
                words = "SEVENTY EIGHT "
            End If
            If vlue = 79 Then
                words = "SEVENTY NINE "
            End If
            If vlue = 80 Then
                words = "EIGHTY "
            End If
            If vlue = 81 Then
                words = "EIGHTY ONE "
            End If
            If vlue = 82 Then
                words = "EIGHTY TWO "
            End If
            If vlue = 83 Then
                words = "EIGHTYTHREE "
            End If
            If vlue = 84 Then
                words = "EIGHTY FOUR "
            End If
            If vlue = 85 Then
                words = "EIGHTY FIVE "
            End If
            If vlue = 86 Then
                words = "EIGHTY SIX "
            End If
            If vlue = 87 Then
                words = "EIGHTY SEVEN "
            End If
            If vlue = 88 Then
                words = "EIGHTY EIGHT "
            End If
            If vlue = 89 Then
                words = "EIGHTY NINE "
            End If
            If vlue = 90 Then
                words = "NINETY "
            End If
            If vlue = 91 Then
                words = "NINETY ONE "
            End If
            If vlue = 92 Then
                words = "NINETY TWO "
            End If
            If vlue = 93 Then
                words = "NINETY THREE "
            End If
            If vlue = 94 Then
                words = "NINETY FOUR "
            End If
            If vlue = 95 Then
                words = "NINETY FIVE "
            End If
            If vlue = 96 Then
                words = "NINETY SIX "
            End If
            If vlue = 97 Then
                words = "NINETY SEVEN "
            End If
            If vlue = 98 Then
                words = "NINETY EIGHT "
            End If
            If vlue = 99 Then
                words = "NINETY NINE "
            End If
            If sw9 = 0 Then
                figrdesc = Trim(words)
                sw9 = 1
            Else
                figrdesc = figrdesc + words
            End If
            figrdesc = figrdesc + descending
            sw = sw + 1
        Loop

        figrdesc = Trim(figrdesc) + " ONLY"

        ToWords = Trim(figrdesc)
    End Function
    Public Sub ProgressBar(ByVal Value As Integer)
        'frmMain.Cursor = Cursors.WaitCursor
        frmMain.ToolStripProgressBar1.Visible = True
        frmMain.ToolStripProgressBar1.Enabled = True
        frmMain.ToolStripProgressBar1.Value = Value

        If Value = 100 Then
            frmMain.ToolStripProgressBar1.Visible = False
            frmMain.ToolStripProgressBar1.Enabled = False
            frmMain.Cursor = Cursors.Default
        End If
    End Sub
    Public Function CheckAccess(ByVal cFld As String, ByVal UserId As String, ByVal cOptionName As String) As Integer
        'Dim cSql As String
        Dim db As New dbOperations("Select * from tblUsers Where UserType = 'A' and userid = '" & UserId & "' and companyid = '" & cCompanyId & "'")

        Dim drCheckAdmn As SqlDataReader = db.dbSelectQuery

        If Not drCheckAdmn.HasRows Then

            db.SetQuery = "Select Min(IsNull(" & cFld & ",0)) as CheckAccess From tblUserDetail Where CompanyId = '" & cCompanyId & "' and UserId = '" & UserId & "' and OptionName = '" & cOptionName & "'"
            Dim drCheckAccess As SqlDataReader = db.dbSelectQuery


            If drCheckAccess.HasRows Then
                drCheckAccess.Read()
                CheckAccess = RemoveNull(drCheckAccess!CheckAccess, 0)
            Else
                drCheckAdmn.Close()
                drCheckAccess.Close()
                db.Close()
                CheckAccess = 0
            End If
        Else
            drCheckAdmn.Close()
            db.Close()
            CheckAccess = -1
        End If
    End Function
    Public Function RemoveNull(ByVal ValueToCheck As Object, ByVal ReturnValueWhenNull As Object, Optional ByVal RemoveEmpty As Boolean = False) As Object
        If IsDBNull(ValueToCheck) Then
            RemoveNull = ReturnValueWhenNull
        ElseIf RemoveEmpty = True And (CStr(ValueToCheck) = "" Or CStr(ValueToCheck) = Nothing) Then
            RemoveNull = ReturnValueWhenNull
        Else
            RemoveNull = ValueToCheck
        End If
    End Function
    Public Function DateFormat(ByVal dt As Object) As String
        If System.Globalization.CultureInfo.CurrentCulture.DateTimeFormat.ShortDatePattern.StartsWith("M") Then
            DateFormat = Format(dt, "MM/dd/yyyy")
        Else
            DateFormat = Format(dt, "dd/MM/yyyy")
        End If
    End Function

    Public Function NextSerial(ByVal fld As String, ByVal tbl As String, ByVal NumberFormat As String, Optional ByVal PreFix As String = Nothing, Optional ByVal Criteria As String = Nothing) As String
        Dim dr As SqlDataReader = Nothing
        Dim cSql As String = "Select isnull(Max(Cast(Substring(" & fld & ", " & Len(PreFix) + 1 & ", Len(" & fld & ")) as Numeric)),0) + 1 as NextNo From " & tbl & " Where Left(" & fld & "," & Len(PreFix) & ") = '" & PreFix & "'" & IIf(Criteria = Nothing, "", " And " + Criteria)
        Dim db As New dbOperations(cSql, dr)
        dr.Read()
        NextSerial = PreFix + Strings.Format(dr!NextNo, NumberFormat)
        db.Close()
    End Function

    Public Function NextOrder(ByVal fld As String, ByVal tbl As String, ByVal Department As String, ByVal Year As String, ByVal Prefix As String) As String
        Dim cDepartment As String
        Dim cNextOrder As String
        Dim cDeptNextOrder As String
        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblOrgDept Where Code = '" & Department & "'")

        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()
            cDepartment = dr!Prefix
        End If

        dr.Close()
        db.Close()

        csql = "Select Max(Cast(Right(" & fld & ",5) as Numeric(9))) + 1 as OrderNo From " & tbl & " Where Substring(" & fld & ",5,2) = '" & Year & "'"

        db = New dbOperations(csql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()
            cNextOrder = Right("00000" + Trim(Str(RemoveNull(dr!OrderNo, 1))), 5)
        Else
            cNextOrder = "00001"
        End If

        dr.Close()
        db.Close()

        csql = "Select Max(Cast(SubString(" & fld & ",8,4) as Numeric(9))) + 1 as OrderNo From " & tbl & " Where Substring(" & fld & ",5,2) = '" & Year & "' and Substring(" & fld & ",3,2) = '" & cDepartment & "'"

        db = New dbOperations(csql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()
            cDeptNextOrder = Right("0000" + Trim(Str(RemoveNull(dr!OrderNo, 1))), 4)
        Else
            cDeptNextOrder = "0001"
        End If

        dr.Close()
        db.Close()

        NextOrder = Prefix + cDepartment + Year + "/" + cDeptNextOrder + "/" + cNextOrder

        '        Dim dr As SqlDataReader = Nothing
        '        Dim cSql As String = "Select isnull(Max(Cast(Substring(" & fld & ", " & Len(PreFix) + 1 & ", Len(" & fld & ")) as Numeric)),0) + 1 as NextNo From " & tbl & " Where Left(" & fld & "," & Len(PreFix) & ") = '" & PreFix & "'" & IIf(Criteria = Nothing, "", " And " + Criteria)
        '        Dim db As New dbOperations(cSql, dr)
        '        dr.Read()
        '        NextSerial = PreFix + Strings.Format(dr!NextNo, NumberFormat)
        '        db.Close()
    End Function

    Public SearchReturnValue1 As String
    Public MultipleReturnValue As String

    'Public Function ShowList(ByVal cSql As String, ByVal Title As String, ByVal DefaultColumn As Integer, ByVal ValueReturnColumn1 As Integer, Optional ByVal GroupingSumColumns_CommaSeparated As String = "", Optional ByVal cConString As String = "", Optional ByVal GroupColoumn As String = "", Optional ByVal Type As String = "List", Optional ByVal cDefaultGrouping As String = "", Optional ByVal cEmail As String = "", Optional ByVal AllowPrint As String = "Yes") As Object
    '    If cConString = "" Then
    '        cConString = DefaultConString
    '    End If

    '    Dim frm As New frmList
    '    frm.QueryStr = (cSql)
    '    frm.grdList.Caption = Title
    '    frm.ConnectionString = cConString
    '    frm.DefaultCol = DefaultColumn
    '    frm.ListTitle = Title
    '    frm.MultiList = False
    '    frm.GroupingSumColumns = GroupingSumColumns_CommaSeparated
    '    frm.cGroupColumn = GroupColoumn
    '    frm.cListType = Type
    '    frm.cDefaultGrouping = cDefaultGrouping
    '    frm.cQueryString = cSql

    '    If AllowPrint = "No" Then
    '        frm.ToolStrip1.Visible = False
    '    End If

    '    SearchReturnValue1 = ""
    '    MultipleReturnValue = ""

    '    frm.ValueReturnColumn1 = ValueReturnColumn1


    '    If cEmail = "Yes" Then
    '        frm.Show()

    '        Dim i As Integer = 0

    '        While (i < frm.grdList.Splits(0).Rows.Count)
    '            If frm.grdList.Splits(0).Rows(i).RowType <> C1.Win.C1TrueDBGrid.RowTypeEnum.DataRow Then
    '                frm.grdList.ExpandGroupRow(i)
    '            End If
    '            i = i + 1
    '        End While

    '        frm.grdList.ExportToHTML("D:\Stock.Html")
    '        frm.Close()
    '    Else
    '        frm.ShowDialog()
    '    End If

    '    ShowList = SearchReturnValue1
    'End Function

    Public Function ShowList(ByVal cSql As String, ByVal Title As String, ByVal DefaultColumn As Integer, ByVal ValueReturnColumn1 As Integer, Optional ByVal GroupingSumColumns_CommaSeparated As String = "", Optional ByVal cConString As String = "", Optional ByVal GroupColoumn As String = "", Optional ByVal Type As String = "List", Optional ByVal cDefaultGrouping As String = "", Optional ByVal cEmail As String = "", Optional ByVal AllowPrint As String = "Yes", Optional ByVal AutoRefresh As String = "", Optional ByVal cDecimal As String = "Yes") As Object
        If cConString = "" Then
            cConString = DefaultConString
        End If

        Dim frm As New frmList
        frm.QueryStr = (cSql)
        frm.cAutoRefresh = AutoRefresh
        frm.grdList.Caption = Title
        frm.ConnectionString = cConString
        frm.DefaultCol = DefaultColumn
        frm.ListTitle = Title
        frm.MultiList = False
        frm.GroupingSumColumns = GroupingSumColumns_CommaSeparated
        frm.cGroupColumn = GroupColoumn
        frm.cListType = Type
        frm.cDefaultGrouping = cDefaultGrouping
        frm.cDecimal = cDecimal
        frm.cQueryString = cSql

        SearchReturnValue1 = ""
        MultipleReturnValue = ""

        frm.ValueReturnColumn1 = ValueReturnColumn1


        If cEmail = "Yes" Then
            frm.Show()

            Dim i As Integer = 0

            While (i < frm.grdList.Splits(0).Rows.Count)
                If frm.grdList.Splits(0).Rows(i).RowType <> C1.Win.C1TrueDBGrid.RowTypeEnum.DataRow Then
                    frm.grdList.ExpandGroupRow(i)
                End If
                i = i + 1
            End While

            frm.grdList.ExportToHTML("D:\Stock.Html")
            frm.Close()
        Else
            If Type = "List" Then
                frm.ShowDialog()
            Else
                frm.MdiParent = frmMain
                frm.Show()
            End If
        End If

        ShowList = SearchReturnValue1
    End Function


    'Public Function ShowList(ByVal cSql As String, ByVal Title As String, ByVal DefaultColumn As Integer, ByVal ValueReturnColumn1 As Integer, ByVal ParamArray MultiColummn() As Integer) As Object
    '    Dim frm As New frmList
    '    frm.QueryStr = cSql
    '    frm.DefaultCol = DefaultColumn
    '    frm.ListTitle = Title
    '    frm.MultiList = False
    '    SearchReturnValue1 = ""
    '    MultipleReturnValue = ""
    '    If MultiColummn.Length > 0 Then
    '        frm.MultiReturnColumn = MultiColummn
    '        frm.ValueReturnColumn1 = -1
    '        frm.ShowDialog()
    '        ShowList = MultipleReturnValue
    '    Else
    '        frm.ValueReturnColumn1 = ValueReturnColumn1
    '        frm.ShowDialog()
    '        ShowList = SearchReturnValue1
    '    End If
    'End Function
    Public MultiListDT As DataTable
    Public Function ShowListMulti(ByVal cSql As String, ByVal Title As String, Optional ByVal cConnectionString As String = "") As DataTable
        If cConnectionString = "" Then
            cConnectionString = DefaultConString
        End If

        Dim frm As New frmList
        MultiListDT = New DataTable
        frm.QueryStr = cSql
        frm.ListTitle = Title
        frm.MultiList = True
        frm.ConnectionString = cConnectionString
        frm.ShowDialog()
        ShowListMulti = MultiListDT
    End Function

    Public Sub ExportCSV(ByVal cSql As String)
        'New Routine Yousuf Bhai, Little Modified By MZ to Open File And AutoFit Columns
        Dim Excel As New Microsoft.Office.Interop.Excel.Application
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, DefaultConString)

        da.SelectCommand.CommandTimeout = 0
        da.Fill(ds, "ActivityReport")

        Dim sb As StringBuilder = New StringBuilder
        Dim dt As DataTable = ds.Tables("ActivityReport")

        Dim cColumns As String

        Dim name(dt.Columns.Count) As String
        Dim i As Integer = 0
        For Each column As DataColumn In dt.Columns
            name(i) = column.ColumnName
            i += 1

            sb.Append((WriteCSV(column.ColumnName) + ","))
        Next
        sb.AppendLine()

        For Each dr1 As DataRow In dt.Rows
            For Each dc As DataColumn In dt.Columns
                sb.Append((WriteCSV(dr1(dc.ColumnName).ToString) + ","))
            Next
            sb.Remove((sb.Length - 1), 1)
            sb.AppendLine()
        Next

        Dim cSaveFilePath As New SaveFileDialog
        cSaveFilePath.Filter = "CSV File|*.csv"
        cSaveFilePath.Title = "SAVE AS CSV FILE"
        cSaveFilePath.ShowDialog()

        Dim strFileName As String = cSaveFilePath.FileName '"C:\gtech\ExcelTransfer.xlsx"

        If strFileName <> "" Then
            File.WriteAllText(strFileName, sb.ToString)
            MsgBox("DATA EXPORTED TO CSV SUCCESSFULLY! : GTECH")
            wBook = Excel.Workbooks.Open(strFileName)
            wSheet = wBook.ActiveSheet
            wSheet.Columns.AutoFit()
            Excel.Visible = True

        End If

    End Sub
    Public Function WriteCSV(ByVal input As String) As String
        Try
            If input Is Nothing Then Return String.Empty
            Dim containsQuote As Boolean = False
            Dim containsComma As Boolean = False
            Dim len As Integer = input.Length
            Dim i As Integer = 0

            While i < len AndAlso (containsComma = False OrElse containsQuote = False)
                Dim ch As Char = input(i)

                If ch = """"c Then
                    containsQuote = True
                ElseIf ch = ","c Then
                    containsComma = True
                End If

                i += 1
            End While

            If containsQuote AndAlso containsComma Then input = input.Replace("""", """""")

            If containsComma Then
                Return """" & input & """"
            Else
                Return input
            End If
        Catch
            Throw
        End Try
    End Function
    Public Sub ShowGrid(ByVal cSql As String, ByVal Title As String, ByVal SelectButton As Boolean, ByVal ExitBuntton As Boolean, ByVal PrintToolBar As Boolean, ByVal AllowGroup As Boolean, ByVal FilterBar As Boolean, Optional ByVal DefaultColumn As Integer = 0)
        Dim frm As New frmList
        frm.QueryStr = cSql
        frm.DefaultCol = DefaultColumn
        frm.ListTitle = Title
        frm.cmdSelect.Visible = SelectButton
        If SelectButton = False And ExitBuntton = True Then
            frm.cmdExit.Location = frm.cmdSelect.Location
        End If
        frm.cmdExit.Visible = ExitBuntton
        frm.grdList.FilterBar = FilterBar
        frm.grdList.DataView = IIf(AllowGroup, C1.Win.C1TrueDBGrid.DataViewEnum.GroupBy, C1.Win.C1TrueDBGrid.DataViewEnum.Normal)
        frm.ToolStrip1.Visible = PrintToolBar

        frm.ShowDialog()
    End Sub

    Public Sub DeleteJvByInvoiceNo(ByVal InvNo As String, Optional ByVal CompanyID As String = Nothing)
        Dim dr As SqlDataReader = Nothing
        Dim db As dbOperations
        Dim Vno, Comp As String
        If CompanyID = Nothing Then
            db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & InvNo & "'", dr)
        Else
            db = New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & InvNo & "' And CompanyID = '" & CompanyID & "'", dr)
        End If
        If dr.Read Then
            Vno = dr!VoucherNo
            Comp = dr!CompanyID
            db.SetQuery = "Delete From tblJvDtl Where VoucherNo = '" & Vno & "' and CompanyId = '" & Comp & "'"
            db.dbActionQuery()
            db.SetQuery = "Delete From tblJvMst Where VoucherNo = '" & Vno & "' and CompanyId = '" & Comp & "'"
            db.dbActionQuery()
        Else
            db.Close()
        End If
        dr.Close()
    End Sub

    Public Sub DeleteJvByVoucherNo(ByVal VNo As String, ByVal CompanyId As String)
        Dim db As New dbOperations
        db.SetQuery = "Delete From tblJvDtl Where VoucherNo = '" & VNo & "' and CompanyId = '" & CompanyId & "'"
        db.dbActionQuery()
        db.SetQuery = "Delete From tblJvMst Where VoucherNo = '" & VNo & "' and CompanyId = '" & CompanyId & "'"
        db.dbActionQuery()
    End Sub

    Function ValidateEmail(ByVal email As String) As Boolean
        Dim emailRegex As New System.Text.RegularExpressions.Regex("^(?<user>[^@]+)@(?<host>.+)$")
        Dim emailMatch As System.Text.RegularExpressions.Match = emailRegex.Match(email)
        Return emailMatch.Success
    End Function

    Public Function CheckDuplicate(ByVal FileName As String, ByVal Field As String, ByVal ValueCheck As String, ByVal NotInclude As String, Optional ByVal NotIncludeVariable As String = "Code", Optional ByVal Condition As String = "") As Boolean
        Dim db As New dbOperations
        Dim dr As SqlDataReader

        If Condition = "" Then
            db = New dbOperations("Select * From " + FileName + " Where " + Field + " = '" + ValueCheck + "' and " + NotIncludeVariable + " <> '" + NotInclude + "'")
        Else
            db = New dbOperations("Select * From " + FileName + " Where " + Field + " = '" + ValueCheck + "' and " + NotIncludeVariable + " <> '" + NotInclude + "' and " + Condition)
        End If

        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            Return True
        Else
            Return False
        End If
    End Function

    Function CurrentDateTime() As Date
        CurrentDateTime = DateAdd(DateInterval.Day, DateDiff(DateInterval.Day, Date.Today, CurrentDate), Date.Now)
    End Function

    'Public Sub EMAIL(ByVal EmailTo As String, ByVal Subject As String, ByVal Body As String)
    '    Try
    '        Dim SmtpServer As New SmtpClient()
    '        Dim auth As New System.Net.NetworkCredential("mehtab_1979@yahoo.com", "syedmk1979")
    '        Dim mail As New MailMessage()
    '        SmtpServer.Credentials = auth
    '        SmtpServer.Port = 995
    '        SmtpServer.Host = "smtp.mail.yahoo.com"
    '        mail = New MailMessage()
    '        mail.From = New MailAddress("mehtab_1979@yahoo.com")
    '        mail.To.Add(EmailTo)
    '        mail.Subject = Subject
    '        mail.Body = Body
    '        SmtpServer.UseDefaultCredentials = True
    '        SmtpServer.EnableSsl = True
    '        SmtpServer.Send(mail)
    '        MsgBox("mail send")
    '    Catch ex As Exception
    '        MsgBox(ex.ToString)
    '    End Try

    'End Sub

    Public Sub Email(ByVal EmailTo As String, ByVal Subject As String, ByVal Body As String)
        Dim db As dbOperations
        Dim dr As SqlDataReader
        Dim cUserName As String
        Dim cPassword As String

        db = New dbOperations("Select * From tblDefaults Where CompanyId = '" & cCompanyId & "'")

        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cUserName = "cambshop@gmail.com"
            cPassword = "gtech2011"
        End If

        ' For Authentication
        Dim loginCredential As New NetworkCredential()
        loginCredential.UserName = cUserName
        loginCredential.Password = cPassword

        ' SMTP Setting
        Dim smtp As New SmtpClient("smtp.gmail.com")
        smtp.EnableSsl = True
        smtp.Credentials = loginCredential
        smtp.Port = 587

        ' Add Receipent and Compose Message
        Dim fromEmail As String = cUserName
        Dim from As New MailAddress(fromEmail)
        Dim mail As New MailMessage()

        mail.From = from
        mail.[To].Add(EmailTo)
        mail.Subject = Subject
        mail.Body = Body
        mail.IsBodyHtml = True

        'Finally Send Email
        smtp.Send(mail)
    End Sub

    Public Sub ExportExcel(ByVal cSql As String)
        Dim Excel As New Microsoft.Office.Interop.Excel.Application
        Dim adapter As New SqlDataAdapter(cSql, DefaultConString)
        Dim cn As SqlConnection = New SqlConnection(DefaultConString)
        Dim myDataSet As New DataSet()
        Dim wBook As Microsoft.Office.Interop.Excel.Workbook
        Dim wSheet As Microsoft.Office.Interop.Excel.Worksheet

        Try
            adapter.SelectCommand.CommandTimeout = 0
            adapter.Fill(myDataSet, "Customer")
        Catch ex As Exception
            MessageBox.Show(ex.ToString())
        End Try


        wBook = excel.Workbooks.Add()
        wSheet = wBook.ActiveSheet()

        Dim dc As System.Data.DataColumn
        Dim dr As System.Data.DataRow
        Dim colIndex As Integer = 0
        Dim rowIndex As Integer = 0

        For Each dc In myDataSet.Tables(0).Columns
            colIndex = colIndex + 1
            Excel.Cells(1, colIndex) = dc.ColumnName
        Next

        For Each dr In myDataSet.Tables(0).Rows
            rowIndex = rowIndex + 1
            colIndex = 0
            For Each dc In myDataSet.Tables(0).Columns
                colIndex = colIndex + 1
                Excel.Cells(rowIndex + 1, colIndex) = dr(dc.ColumnName)

            Next
        Next

        wSheet.Columns.AutoFit()
        Dim strFileName As String = "E:\ExcelTransfer.xlsx"
        Dim blnFileOpen As Boolean = False
        Try
            Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
            fileTemp.Close()
        Catch ex As Exception
            blnFileOpen = False
        End Try

        If System.IO.File.Exists(strFileName) Then
            System.IO.File.Delete(strFileName)
        End If

        wBook.SaveAs(strFileName)
        excel.Workbooks.Open(strFileName)
        Excel.Visible = True
    End Sub

    Public Function DeleteInfo(ByVal RefNo As String, Optional ByVal Description As String = Nothing) As String
        Dim db As New dbOperations("Insert Into tblDeleteInformation Select '" & RefNo & "','" & DateTime.Now & "','" & Description & "','" & UserId & "','" & Environment.MachineName.ToString & "','" & Environment.OSVersion.ToString & "','" & Environment.UserDomainName.ToString & "','" & IP & "','" & MacAddress & "','" & cCompanyId & "'")
        db.dbActionQuery()
        db.Close()
    End Function

    Public Function EditInfo(ByVal RefNo As String, Optional ByVal Description As String = Nothing) As String
        Dim db As New dbOperations("Insert Into tblEditInformation Select '" & RefNo & "','" & DateTime.Now & "','" & Description & "','" & UserId & "','" & Environment.MachineName.ToString & "','" & Environment.OSVersion.ToString & "','" & Environment.UserDomainName.ToString & "','" & IP & "','" & MacAddress & "','" & cCompanyId & "'")
        db.dbActionQuery()
        db.Close()
    End Function

    Public Function AddInfo(ByVal RefNo As String, Optional ByVal Description As String = Nothing) As String
        Dim db As New dbOperations("Insert Into tblAddInformation Select '" & RefNo & "','" & DateTime.Now & "','" & Description & "','" & UserId & "','" & Environment.MachineName.ToString & "','" & Environment.OSVersion.ToString & "','" & Environment.UserDomainName.ToString & "','" & IP & "','" & MacAddress & "','" & cCompanyId & "'")
        db.dbActionQuery()
        db.Close()
    End Function

    Public Function GetCC(ByVal _cUnit As String) As String
        Dim _Cc As String = ""
        Dim db As New dbOperations("SElect isnull(CC,'') as CC from tblReservationMst where unit = '" & _cUnit & "'")
        Dim dr As SqlDataReader = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            _Cc = RemoveNull(dr!CC, "")
        End If

        dr.Close()
        db.Close()


        Return _Cc
    End Function
End Module
