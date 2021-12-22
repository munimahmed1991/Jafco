Imports System.Data
Imports System.Data.SqlClient
Module GeneralLedger

    '---Variable Declarations
    Public dPaymentSector As String
    Public cEntryLocation As String

    Public cGSTPer As Integer

    Public cAccessoryLevel1 As Byte
    Public cAccessoryLevel2 As Byte
    Public cAccessoryLevel3 As Byte
    Public cAccessoryLevel4 As Byte
    Public cAccessoryLevel5 As Byte
    Public cAccessoryLevel6 As Byte
    Public cAccessoryLevel7 As Byte

    Public cYarnLevel1 As Byte
    Public cYarnLevel2 As Byte
    Public cYarnLevel3 As Byte
    Public cYarnLevel4 As Byte
    Public cYarnLevel5 As Byte
    Public cYarnLevel6 As Byte
    Public cYarnLevel7 As Byte

    Public cDefaultSector As String

    Public UserSettingFilePath As String

    Public cFabricLevel1 As Byte
    Public cFabricLevel2 As Byte
    Public cFabricLevel3 As Byte
    Public cFabricLevel4 As Byte
    Public cFabricLevel5 As Byte
    Public cFabricLevel6 As Byte
    Public cFabricLevel7 As Byte

    Public cLocationLevel1 As Byte
    Public cLocationLevel2 As Byte
    Public cLocationLevel3 As Byte
    Public cLocationLevel4 As Byte
    Public cLocationLevel5 As Byte
    Public cLocationLevel6 As Byte
    Public cLocationLevel7 As Byte

    Public cClientLevel1 As Byte
    Public cClientLevel2 As Byte
    Public cClientLevel3 As Byte
    Public cClientLevel4 As Byte
    Public cClientLevel5 As Byte
    Public cClientLevel6 As Byte
    Public cClientLevel7 As Byte

    Public cDepGainLossAccount As String
    Public cHOAccount As String
    Public cFabricStock As String
    Public cAccessoryStock As String
    Public cFabricTag As String
    Public cAccessoryTag As String
    Public cAccruedLiability As String
    Public cSalesTaxAccount As String
    Public cExciseAccount As String

    Public cAddress As String
    Public cPhoneNo As String
    Public cFaxNo As String
    Public cEmail As String
    Public VoucherSerialCutOfDate As New Date(2009, 9, 15)


    Public Sub SetDefaults()
        Dim db As New dbOperations("Select * from tblDefaults Where CompanyId = '" & cCompanyId & "'")
        Dim dr As SqlDataReader = db.dbSelectQuery()
        dr.Read()
        If dr.HasRows Then
            cAccessoryLevel1 = RemoveNull(dr.Item("AccessoryLevel1"), 0)
            cAccessoryLevel2 = RemoveNull(dr.Item("AccessoryLevel2"), 0)
            cAccessoryLevel3 = RemoveNull(dr.Item("AccessoryLevel3"), 0)
            cAccessoryLevel4 = RemoveNull(dr.Item("AccessoryLevel4"), 0)
            cAccessoryLevel5 = RemoveNull(dr.Item("AccessoryLevel5"), 0)
            cAccessoryLevel6 = RemoveNull(dr.Item("AccessoryLevel6"), 0)
            cAccessoryLevel7 = RemoveNull(dr.Item("AccessoryLevel7"), 0)

            cFabricLevel1 = RemoveNull(dr.Item("FabricLevel1"), 0)
            cFabricLevel2 = RemoveNull(dr.Item("FabricLevel2"), 0)
            cFabricLevel3 = RemoveNull(dr.Item("FabricLevel3"), 0)
            cFabricLevel4 = RemoveNull(dr.Item("FabricLevel4"), 0)
            cFabricLevel5 = RemoveNull(dr.Item("FabricLevel5"), 0)
            cFabricLevel6 = RemoveNull(dr.Item("FabricLevel6"), 0)
            cFabricLevel7 = RemoveNull(dr.Item("FabricLevel7"), 0)

            cYarnLevel1 = RemoveNull(dr.Item("YarnLevel1"), 0)
            cYarnLevel2 = RemoveNull(dr.Item("YarnLevel2"), 0)
            cYarnLevel3 = RemoveNull(dr.Item("YarnLevel3"), 0)
            cYarnLevel4 = RemoveNull(dr.Item("YarnLevel4"), 0)
            cYarnLevel5 = RemoveNull(dr.Item("YarnLevel5"), 0)
            cYarnLevel6 = RemoveNull(dr.Item("YarnLevel6"), 0)
            cYarnLevel7 = RemoveNull(dr.Item("YarnLevel7"), 0)

            cLocationLevel1 = dr.Item("LocationLevel1")
            cLocationLevel2 = dr.Item("LocationLevel2")
            cLocationLevel3 = dr.Item("LocationLevel3")
            cLocationLevel4 = dr.Item("LocationLevel4")
            cLocationLevel5 = dr.Item("LocationLevel5")
            cLocationLevel6 = RemoveNull(dr.Item("LocationLevel6"), 0)
            cLocationLevel7 = RemoveNull(dr.Item("LocationLevel7"), 0)

            cClientLevel1 = RemoveNull(dr.Item("ClientLevel1"), 0)
            cClientLevel2 = RemoveNull(dr.Item("ClientLevel2"), 0)
            cClientLevel3 = RemoveNull(dr.Item("ClientLevel3"), 0)
            cClientLevel4 = RemoveNull(dr.Item("ClientLevel4"), 0)
            cClientLevel5 = RemoveNull(dr.Item("ClientLevel5"), 0)
            cClientLevel6 = RemoveNull(dr.Item("ClientLevel6"), 0)
            cClientLevel7 = RemoveNull(dr.Item("ClientLevel7"), 0)

            DateFrom = dr.Item("DateFrom")
            DateTo = dr.Item("DateTo")
            cEntryLocation = RemoveNull(dr!EntryLocation, "")
            dPaymentSector = RemoveNull(dr!PaymentSector, "")

            cAddress = RemoveNull(dr.Item("Address1"), "")
            cPhoneNo = RemoveNull(dr.Item("PhoneNo"), "")
            cFaxNo = RemoveNull(dr.Item("Fax"), "")
            cEmail = RemoveNull(dr.Item("Email"), "")

            cGSTPer = RemoveNull(dr.Item("GSTP"), 0)

            cDepGainLossAccount = RemoveNull(dr.Item("GainLossFA"), "")
            cHOAccount = RemoveNull(dr.Item("HOAccount"), "")
            cDefaultSector = RemoveNull(dr.Item("Sector"), "")
            cFabricStock = RemoveNull(dr.Item("FabricStock"), "")
            cAccessoryStock = RemoveNull(dr.Item("AccessoryStock"), "")
            cFabricTag = RemoveNull(dr.Item("FabricTag"), "")
            cAccessoryTag = RemoveNull(dr.Item("AccessoryTag"), "")
            cAccruedLiability = RemoveNull(dr.Item("AccruedLiability"), "")
            cSalesTaxAccount = RemoveNull(dr.Item("SalesTaxAccount"), "")
            cExciseAccount = RemoveNull(dr.Item("ExciseAccount"), "")
            CurrentDate = RemoveNull(dr.Item("CurrentDate"), Today.Date)

            If RemoveNull(dr!OnlineServer, "") <> "" And RemoveNull(dr!OnlineUser, "") <> "" And RemoveNull(dr!OnlinePWS, "") <> "" Then
                OnlineConstring = String.Format("Data Source={0};uid=" & dr!OnlineUser & ";pwd={1};Initial Catalog={2}", dr!OnlineServer, dr!OnlinePWS, dr!OnlineDatabase)

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
            End If
        End If
        db.Close()
    End Sub

    Public Sub UserSettingXml()
        '------- user setting xml file---------------
        UserSettingFilePath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\UserSettings.GTECH" ' 

        If Not My.Computer.FileSystem.FileExists(UserSettingFilePath) Then
            Dim xml = <?xml version="1.0" encoding="utf-8"?>
                      <Settings>
                          <CurrentUser>
                              <UserName><%= EncryptString(Environment.UserName) %></UserName>
                              <Database><%= EncryptString("") %></Database>
                              <View>
                                  <Toolbar><%= EncryptString("True") %></Toolbar>
                                  <TaskPane><%= EncryptString("True") %></TaskPane>
                                  <StatusBar><%= EncryptString("True") %></StatusBar>
                              </View>
                          </CurrentUser>
                      </Settings>

            xml.Save(UserSettingFilePath)

        End If

        '-------User Settings-------------------
    End Sub

    Public Sub AddActBalance(ByVal cAccountCode As String, ByVal cAmount As Double)
        Dim db As New dbOperations("Update tblAccounts Set ClosingBalance = IsNull(ClosingBalance,0) + " & cAmount & " Where AccountCode = '" & cAccountCode & "'")
        db.dbActionQuery()
        db.Close()
    End Sub

    Public Sub DelActBalance(ByVal cAccountCode As String, ByVal cAmount As Double)
        Dim db As New dbOperations("Update tblAccounts Set ClosingBalance = IsNull(ClosingBalance,0) + " & cAmount & " Where AccountCode = '" & cAccountCode & "'")
        db.dbActionQuery()
        db.Close()
    End Sub

    Function CashBankVoucher(ByVal EntryLocation As String, ByVal FileName1 As String, ByVal FileName2 As String, ByVal VoucherDate As Date, ByVal VoucherType As String, ByVal FrmPrefix As String) As String
        Dim dbMaxMulti As New dbOperations()
        Dim drMaxMulti As SqlDataReader

        If VoucherDate >= VoucherSerialCutOfDate Then
            dbMaxMulti.SetQuery = "select isnull(Max(cast(right(voucherno,9) as Numeric(9))) + 1,1) as NextVoucherNo From " & FileName2 & " Where VoucherDate >= '" & Format(VoucherSerialCutOfDate, "MM/dd/yyyy") & "' and CompanyId = '" & cCompanyId & "' and VoucherType = '" & VoucherType & "' And Substring(VoucherNo,4,3) = '" & EntryLocation & "' and Len(VoucherNo) = 16"
        Else
            dbMaxMulti.SetQuery = "select isnull(Max(cast(right(voucherno,3) as Numeric(9))) + 1,1) as NextVoucherNo From " & FileName2 & " Where VoucherDate = '" & Format(VoucherDate, "MM/dd/yyyy") & "' and CompanyId = '" & cCompanyId & "' and VoucherType = '" & VoucherType & "' And Substring(VoucherNo,4,3) = '" & EntryLocation & "'"
        End If
        
        drMaxMulti = dbMaxMulti.dbSelectQuery
        drMaxMulti.Read()

        If VoucherDate >= VoucherSerialCutOfDate Then
            CashBankVoucher = FrmPrefix + IIf(VoucherType = "R", "R", "P") + EntryLocation + "-" + Right("0000000000" + Trim(Str(drMaxMulti!NextVoucherNo)), 9)
        Else
            CashBankVoucher = FrmPrefix + IIf(VoucherType = "R", "R", "P") + EntryLocation + "-" + Right(Format(VoucherDate, "dd/MM/yyyy"), 2) + Mid(Format(VoucherDate, "dd/MM/yyyy"), 4, 2) + Left(Format(VoucherDate, "dd/MM/yyyy"), 2) + "-" + Right("000" + Trim(Str(drMaxMulti!NextVoucherNo)), 3)
        End If

        dbMaxMulti.Close()
        drMaxMulti.Close()
    End Function

    Public Function OtherVoucher(ByVal EntryLocation As String, ByVal FileName1 As String, ByVal VoucherDate As Date, ByVal FrmPrefix As String) As String
        OtherVoucher = NextSerial("VoucherNo", FileName1, "000000000", FrmPrefix + "-", "CompanyId = '" & cCompanyId & "' and VoucherDate >= '" & VoucherSerialCutOfDate & "'")
    End Function

    Public Function GenerateJV(ByVal BillNo As String, ByVal BillDate As DateTime, ByVal Description As String, Optional ByVal cSector As String = "", Optional ByVal cVoucherCategory As String = "B") As String
        Dim cVoucherNo As String
        Dim cAdd As Boolean
        Dim JVMst As New ActionQueryBuilder
        Dim JVDtl As New ActionQueryBuilder
        Dim db As dbOperations
        Dim cVoucherGeneration As String
        Dim cVoucherSequence As String

        Dim Query As New dbOperations("Select * From tblJVMst Where InvoiceNo = '" & BillNo & "' and CompanyId = '" & cCompanyId & "'", GLConString)
        Dim Dr As SqlDataReader

        Dr = Query.dbSelectQuery()

        Dr.Read()

        If Dr.HasRows Then
            cVoucherNo = Dr!VoucherNo
            cAdd = False
        Else
            cSql = "Select * From tblDefaults Where CompanyId = '0001'"

            db = New dbOperations(cSql, GLConString)
            Dr = db.dbSelectQuery

            If Dr.HasRows = True Then
                Dr.Read()

                cVoucherGeneration = RemoveNull(Dr!VoucherGeneration, "")
                cVoucherSequence = RemoveNull(Dr!VoucherSequence, "")
            End If

            If cVoucherGeneration = "ProjectWise" Then
                cSql = "select s.Code, P.Prefix , P.Name + ' - ' + L.Name + ' - ' + s.Name as Sector from tblSector s Left Outer Join tblLocation l on s.Location = l.code Left outer Join tblProject P on L.Project = P.Code Where S.Code = '" & cSector & "' Order By P.Name "

                db = New dbOperations(cSql, GLConString)
                Dr = db.dbSelectQuery

                If Dr.HasRows = True Then
                    Dr.Read()

                    cPrefix = RemoveNull(Dr!Prefix, "")
                End If
            End If

            Dim cDateFormat As String

            If cVoucherSequence = "DayWise" Then
                cDateFormat = Right(Trim(Str(Year(BillDate))), 2) + IIf(Len(Trim(Str(Month(BillDate)))) = 1, "0" + Trim(Str(Month(BillDate))), Trim(Str(Month(BillDate)))) + Left(Trim(Format(BillDate, "dd/MM/yyyy")), 2)

                If cPrefix <> "" Then
                    cSql = "Select IsNull(Max(Cast(Right(VoucherNo,4) as Numeric(14))) + 1,1) as NextVoucherNo From tblJvMst Where CompanyId = '0001' and substring(VoucherNo,3,2) = '" & cPrefix & "' and EntryDate = '" & Format(BillDate, "MM/dd/yyyy") & "'"

                    db = New dbOperations(cSql, GLConString)
                    Dr = db.dbSelectQuery

                    If Dr.HasRows Then
                        Dr.Read()
                    End If

                    cVoucherNo = "JV" + cPrefix + "-" + cDateFormat + "-" + Right("000000000" + Trim(Str(Dr!NextVoucherNo)), 4)
                Else
                    cSql = "Select IsNull(Max(Cast(Right(VoucherNo,4) as Numeric(14))) + 1,1) as NextVoucherNo From tblJvMst Where CompanyId = '0001' and EntryDate = '" & Format(BillDate, "MM/dd/yyyy") & "'"

                    db = New dbOperations(cSql, GLConString)
                    Dr = db.dbSelectQuery

                    If Dr.HasRows Then
                        Dr.Read()
                    End If

                    cVoucherNo = "JV-" + cDateFormat + "-" + Right("000000000" + Trim(Str(Dr!NextVoucherNo)), 4)
                End If
            Else
                If cPrefix <> "" Then
                    If cVoucherCategory = "B" Then
                        cSql = "Select IsNull(Max(Cast(Right(VoucherNo,9) as Numeric(14))) + 1,1) as NextVoucherNo From tblJvMst Where CompanyId = '0001' and substring(VoucherNo,3,2) = '" & cPrefix & "' and Len(VoucherNo) = 14 and Substring(VoucherNo,1,2) = 'JV'"

                        db = New dbOperations(cSql, GLConString)
                        Dr = db.dbSelectQuery

                        If Dr.HasRows Then
                            Dr.Read()
                        End If

                        cVoucherNo = "JV" + cPrefix + "-" + Right("000000000" + Trim(Str(Dr!NextVoucherNo)), 9)
                    Else
                        cSql = "Select IsNull(Max(Cast(Right(VoucherNo,9) as Numeric(14))) + 1,1) as NextVoucherNo From tblJvMst Where CompanyId = '0001' and substring(VoucherNo,3,2) = '" & cPrefix & "' and Len(VoucherNo) = 14 and Substring(VoucherNo,1,2) = 'GV'"

                        db = New dbOperations(cSql, GLConString)
                        Dr = db.dbSelectQuery

                        If Dr.HasRows Then
                            Dr.Read()
                        End If

                        cVoucherNo = "GV" + cPrefix + "-" + Right("000000000" + Trim(Str(Dr!NextVoucherNo)), 9)
                    End If
                Else
                    cSql = "Select IsNull(Max(Cast(Right(VoucherNo,9) as Numeric(14))) + 1,1) as NextVoucherNo From tblJvMst Where CompanyId = '0001'"

                    db = New dbOperations(cSql, GLConString)
                    Dr = db.dbSelectQuery

                    If Dr.HasRows Then
                        Dr.Read()
                    End If

                    cVoucherNo = "JV-" + Right("000000000" + Trim(Str(Dr!NextVoucherNo)), 9)
                End If
            End If

            cAdd = True
        End If

        JVMst.Refresh()
        JVMst.SetQueryInformation("tblJVMst", "CompanyId = '" & cCompanyId & "' and VoucherNo = '" & cVoucherNo & "'")

        JVMst.AddFields("CompanyId", cCompanyId, ActionQueryBuilder.DataType.aString)
        JVMst.AddFields("VoucherNo", cVoucherNo, ActionQueryBuilder.DataType.aString)
        JVMst.AddFields("VoucherDate", BillDate, ActionQueryBuilder.DataType.aDate)
        JVMst.AddFields("Description", Description, ActionQueryBuilder.DataType.aString)
        JVMst.AddFields("EntryDate", BillDate, ActionQueryBuilder.DataType.aDate)
        JVMst.AddFields("InvoiceNo", BillNo, ActionQueryBuilder.DataType.aString)
        JVMst.AddFields("InvoiceDate", BillDate, ActionQueryBuilder.DataType.aDate)
        JVMst.AddFields("Finalize", 1, ActionQueryBuilder.DataType.aInteger)

        If cAdd = True Then
            JVMst.ExecuteQuery(ActionQueryBuilder.Actions.Insert, GLConString)
        Else
            JVMst.ExecuteQuery(ActionQueryBuilder.Actions.Update, GLConString)

            JVDtl.Refresh()
            JVDtl.SetQueryInformation("tblJVDtl", "CompanyId = '" & cCompanyId & "' and VoucherNo = '" & cVoucherNo & "'")
            JVDtl.ExecuteQuery(ActionQueryBuilder.Actions.Delete, GLConString)
        End If

        Return cVoucherNo
    End Function

    Public Sub GenerateJvDetails(ByVal VoucherNo As String, ByVal AccountCode As String, ByVal DescriptionEntry As String, ByVal BillNo As String, ByVal BillDate As String, ByVal Debit As Integer, ByVal Credit As Integer, ByVal EmployeeCode As String, ByVal Sector As String, Optional ByVal cnString As String = "", Optional ByVal Tag As String = "", Optional ByVal AgainstAccount As String = "")
        Dim JVDtl As New ActionQueryBuilder

        JVDtl.Refresh()
        JVDtl.SetQueryInformation("tblJVDtl", "CompanyId = '" & cCompanyId & "' and VoucherNo = '" & VoucherNo & "'")
        JVDtl.AddFields("CompanyId", cCompanyId, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("VoucherNo", VoucherNo, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("AccountCode", AccountCode, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("DescriptionEntry", DescriptionEntry, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("ChequeNo", BillNo, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("ChequeDate", BillDate, ActionQueryBuilder.DataType.aDate)
        JVDtl.AddFields("Debit", Debit, ActionQueryBuilder.DataType.aInteger)
        JVDtl.AddFields("Credit", Credit, ActionQueryBuilder.DataType.aInteger)
        JVDtl.AddFields("EmployeeCode", EmployeeCode, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("Sector", Sector, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("Tag", Tag, ActionQueryBuilder.DataType.aString)
        JVDtl.AddFields("AgainstAccount", AgainstAccount, ActionQueryBuilder.DataType.aString)

        JVDtl.ExecuteQuery(ActionQueryBuilder.Actions.Insert, GLConString)
    End Sub
End Module
