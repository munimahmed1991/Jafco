Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmDemandNotice
    Dim dbGrid As BindGrid
    Dim cSql As String

    Dim db As dbOperations
    Dim dr As SqlDataReader

    Public cDaysFrom As Double
    Public cDaysTo As Double
    Public cDemandString As String
    Public cLetterPrefix As String

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        Dim dbPreviousLetter As dbOperations
        Dim drPreviousLetter As SqlDataReader
        Dim cPreviousLetter As String

        cSql = "Select 0 as Generate,GetDate() as GenerateDate,'' as Unit,'' as UnitNumber,'' as Customer,'' as Customer2,'' as CustomerName,'' as Mobile,'' as TelRes,'' as Address,"
        cSql += "'' as UnitType,'' as UnitTypeName,'' as Scheme,0 as Balance,0 as TotalBalance,'' as Project,'' as ProjectName,'' as LetterType,'' as PreviousLetters "
        cSql += "From tblDefaults "
        'cSql += "Where CompanyId = '' "

        dbGrid = New BindGrid(cSql, tdbGridLetters)

        Dim cLetterType As String

        If cLetterPrefix = "D1" Then
            cLetterType = "Demand Notice 1"

            cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','Report','OutstandingLetter',0,'','Active'"
        ElseIf cLetterPrefix = "D2" Then
            cLetterType = "Demand Notice 2"

            cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','60 Days',0,'','Active'"
        ElseIf cLetterPrefix = "D3" Then
            cLetterType = "Demand Notice 3"

            cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','90 Days',0,'','Active'"
        ElseIf cLetterPrefix = "D4" Then
            cLetterType = "Demand Notice 4"

            cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','120 Days',0,'','Active'"
        ElseIf cLetterPrefix = "D5" Then
            cLetterType = "Demand Notice 5"

            cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','150 Days',0,'','Active'"
        ElseIf cLetterPrefix = "D6" Then
            cLetterType = "Demand Notice 6"

            cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','180 Days',0,'','Active'"
        ElseIf cLetterPrefix = "D7" Then
            cLetterType = "Demand Notice Final"

            cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','Report','OutstandingLetter',0,'','Active'"
        End If

        '        cSql = "Exec DemandNotice " & cDaysFrom & "," & cDaysTo & ",'" & cmbProject.SelectedValue & "','Demand Notice (1-30 Days)','" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)
        '        cSql = "Exec AgingReport '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','30 Days'"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            Dim NewRow As DataRow = dbGrid.cDataTable.NewRow


            NewRow("Generate") = 1
            NewRow("GenerateDate") = txtGenerateDate.Value
            NewRow("Unit") = RemoveNull(dr!Unit, "")
            NewRow("UnitNumber") = RemoveNull(dr!UnitNumber, "")
            NewRow("Customer") = RemoveNull(dr!Customer, "")
            NewRow("Customer2") = RemoveNull(dr!Customer2, "")
            NewRow("CustomerName") = RemoveNull(dr!CustomerName, "")
            NewRow("Address") = RemoveNull(dr!Address, "")
            NewRow("Mobile") = RemoveNull(dr!Mobile, "")
            NewRow("TelRes") = RemoveNull(dr!TelRes, "")
            NewRow("UnitType") = RemoveNull(dr!UnitType, "")
            NewRow("UnitTypeName") = RemoveNull(dr!UnitTypeName, "")
            NewRow("Scheme") = RemoveNull(dr!Scheme, "")
            NewRow("Project") = RemoveNull(dr!Project, "")
            NewRow("ProjectName") = RemoveNull(dr!ProjectName, "")
            NewRow("Balance") = RemoveNull(dr!Balance, 0)
            NewRow("TotalBalance") = RemoveNull(dr!TotalBalance, 0)
            NewRow("LetterType") = cLetterType
            'IIf(cLetterPrefix = "D1", "Demand Notice 1", IIf(cLetterPrefix = "D2", "Demand Notice 2", IIf(cLetterPrefix = "D3", "Demand Notice 3", "Demand Notice 3")))

            dbGrid.cDataTable.Rows.Add(NewRow)

            For Each row In dr
                Dim NewRow1 As DataRow = dbGrid.cDataTable.NewRow

                NewRow1("Generate") = 1
                NewRow1("GenerateDate") = txtGenerateDate.Value
                NewRow1("Unit") = RemoveNull(dr!Unit, "")
                NewRow1("UnitNumber") = RemoveNull(dr!UnitNumber, "")
                NewRow1("Customer") = RemoveNull(dr!Customer, "")
                NewRow1("Customer2") = RemoveNull(dr!Customer2, "")
                NewRow1("CustomerName") = RemoveNull(dr!CustomerName, "")
                NewRow1("Address") = RemoveNull(dr!Address, "")
                NewRow1("Mobile") = RemoveNull(dr!Mobile, "")
                NewRow1("TelRes") = RemoveNull(dr!TelRes, "")
                NewRow1("UnitType") = RemoveNull(dr!UnitType, "")
                NewRow1("UnitTypeName") = RemoveNull(dr!UnitTypeName, "")
                NewRow1("Scheme") = RemoveNull(dr!Scheme, "")
                NewRow1("Project") = RemoveNull(dr!Project, "")
                NewRow1("ProjectName") = RemoveNull(dr!ProjectName, "")
                NewRow1("Balance") = RemoveNull(dr!Balance, 0)
                NewRow1("TotalBalance") = RemoveNull(dr!TotalBalance, 0)
                NewRow1("LetterType") = cLetterType
                'IIf(cLetterPrefix = "D1", "Demand Notice 1", IIf(cLetterPrefix = "D2", "Demand Notice 2", IIf(cLetterPrefix = "D3", "Demand Notice 3", "Demand Notice 3")))


                'NewRow1("PreviousLetters") = cPreviousLetter

                dbGrid.cDataTable.Rows.Add(NewRow1)
            Next
        End If
    End Sub

    Private Sub tdbGridLetters_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridLetters.AfterColUpdate
        If tdbGridLetters.Columns("Generate").Value = 1 Then
            tdbGridLetters.Columns("GenerateDate").Value = txtGenerateDate.Value
        Else
            tdbGridLetters.Columns("GenerateDate").Value = Nothing
        End If
    End Sub

    Private Sub tdbGridLetters_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridLetters.ButtonClick
        If e.ColIndex = 4 Then
            cSql = "Exec [CustomerStatement] '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','" & tdbGridLetters.Columns("UnitType").Value & "','" & tdbGridLetters.Columns("Unit").Value & "'"

            Dim dr As SqlDataReader = Nothing
            Call ProgressBar(10)
            Dim fPreview As New frmPreview
            Dim rReport As New rptCustomerStatement


            Call ProgressBar(25)

            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)

            da.Fill(ds, "FabricSales")

            Call ProgressBar(50)

            'rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
            rReport.DataSource = ds.Tables("FabricSales")
            '            rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "CUSTOMER STATEMENT UPTO : " & Format(txtGenerateDate.Value, "dd/MM/yyyy")
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            fPreview.Show()
            rReport.Run(True)
            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub tdbGridLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridLetters.Click

    End Sub

    Private Sub frmWelcomeLetter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)

        Me.Text = cDemandString

        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)

        txtGenerateDate.Value = Today.Date

        cSql = "Select 0 as Generate,GetDate() as GenerateDate,'' as Unit,'' as UnitNumber,'' as Customer,'' as Customer2,'' as CustomerName,'' as Mobile,'' as TelRes,'' as Address,"
        cSql += "'' as UnitType,'' as UnitTypeName,'' as Scheme,0 as Balance,0 as TotalBalance,'' as Project,'' as ProjectName,'' as LetterType,'' as PreviousLetters "
        cSql += "From tblDefaults "
        cSql += "Where CompanyId = '' "

        dbGrid = New BindGrid(cSql, tdbGridLetters)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cNextNo As String
        Dim cPrefix As String
        Dim cPreviousLetter As String

        db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cPrefix = dr!Prefix
        End If

        db.Close()
        dr.Close()

        For Each row1 As DataRow In dbGrid.cDataTableCollection(0).Select
            If RemoveNull(row1!Generate, 0) = 1 Then
                If RemoveNull(row1!LetterType, "") = "Demand Notice 2" Then
                    dbPreviousLetter = New dbOperations("Select Max(EntryDate) as EntryDate From tblLetters Where Unit = '" & row1!Unit & "' and Upper(Substring(LetterType,1,9)) <> 'HBFC LOAN' and Upper(Substring(LetterType,1,18)) <> 'DUE SERVICE LETTER'")
                    drPreviousLetter = dbPreviousLetter.dbSelectQuery

                    If drPreviousLetter.HasRows Then
                        drPreviousLetter.Read()

                        If RemoveNull(drPreviousLetter!EntryDate, "1/1/2000") <> "1/1/2000" Then
                            cPreviousLetter = Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))
                        End If
                    End If

                    dbPreviousLetter.Close()
                    drPreviousLetter.Close()
                ElseIf RemoveNull(row1!LetterType, "") = "Demand Notice 3" Then
                    dbPreviousLetter = New dbOperations("Select EntryDate as EntryDate From tblLetters Where Unit = '" & row1!Unit & "'  and Upper(Substring(LetterType,1,9)) <> 'HBFC LOAN' and Upper(Substring(LetterType,1,18)) <> 'DUE SERVICE LETTER' Order By EntryDate Desc")
                    drPreviousLetter = dbPreviousLetter.dbSelectQuery

                    If drPreviousLetter.HasRows Then
                        drPreviousLetter.Read()

                        cPreviousLetter = Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))
                    End If

                    dbPreviousLetter.Close()
                    drPreviousLetter.Close()
                ElseIf RemoveNull(row1!LetterType, "") = "Demand Notice 4" Then
                    dbPreviousLetter = New dbOperations("Select EntryDate as EntryDate From tblLetters Where Unit = '" & row1!Unit & "'  and Upper(Substring(LetterType,1,9)) <> 'HBFC LOAN' and Upper(Substring(LetterType,1,18)) <> 'DUE SERVICE LETTER' Order By EntryDate Desc")
                    drPreviousLetter = dbPreviousLetter.dbSelectQuery

                    If drPreviousLetter.HasRows Then
                        drPreviousLetter.Read()

                        cPreviousLetter = Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))
                    End If

                    dbPreviousLetter.Close()
                    drPreviousLetter.Close()
                ElseIf RemoveNull(row1!LetterType, "") = "Demand Notice 5" Then
                    dbPreviousLetter = New dbOperations("Select EntryDate as EntryDate From tblLetters Where Unit = '" & row1!Unit & "'  and Upper(Substring(LetterType,1,9)) <> 'HBFC LOAN' and Upper(Substring(LetterType,1,18)) <> 'DUE SERVICE LETTER' Order By EntryDate Desc")
                    drPreviousLetter = dbPreviousLetter.dbSelectQuery

                    If drPreviousLetter.HasRows Then
                        drPreviousLetter.Read()

                        cPreviousLetter = Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))
                    End If

                    dbPreviousLetter.Close()
                    drPreviousLetter.Close()
                ElseIf RemoveNull(row1!LetterType, "") = "Demand Notice 6" Then
                    dbPreviousLetter = New dbOperations("Select EntryDate as EntryDate From tblLetters Where Unit = '" & row1!Unit & "'  and Upper(Substring(LetterType,1,9)) <> 'HBFC LOAN' and Upper(Substring(LetterType,1,18)) <> 'DUE SERVICE LETTER' Order By EntryDate Desc")
                    drPreviousLetter = dbPreviousLetter.dbSelectQuery

                    If drPreviousLetter.HasRows Then
                        drPreviousLetter.Read()

                        cPreviousLetter = Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))
                    End If

                    dbPreviousLetter.Close()
                    drPreviousLetter.Close()
                ElseIf RemoveNull(row1!LetterType, "") = "Final Notice" Then
                    dbPreviousLetter = New dbOperations("Select EntryDate as EntryDate From tblLetters Where Unit = '" & row1!Unit & "'  and Upper(Substring(LetterType,1,9)) <> 'HBFC LOAN' and Upper(Substring(LetterType,1,18)) <> 'DUE SERVICE LETTER' Order By EntryDate Desc")
                    drPreviousLetter = dbPreviousLetter.dbSelectQuery

                    If drPreviousLetter.HasRows = True Then
                        drPreviousLetter.Read()

                        cPreviousLetter = Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))

                        On Error Resume Next

                        drPreviousLetter.Read()

                        cPreviousLetter = cPreviousLetter + ", " + Trim(CStr(DatePart(DateInterval.Day, drPreviousLetter!EntryDate))) + " " + Trim(MonthName(DatePart(DateInterval.Month, drPreviousLetter!EntryDate))) + " " + Trim(CStr(DatePart(DateInterval.Year, drPreviousLetter!EntryDate)))
                    End If
                End If


                cNextNo = NextSerial("EntryNo", "tblLetters", "000", cPrefix + "/" + Trim(row1!UnitNumber) + "/")

                cSql = "Insert Into tblLetters(EntryNo,EntryDate,LetterType,Customer,Customer2,Unit,Project,GenerateSystemDate,PreviousLetters,DueAmount) Values('" & cNextNo & "','" & Format(row1!GenerateDate, "MM/dd/yyyy") & "','" & row1!LetterType & "','" & row1!Customer & "','" & row1!Customer2 & "','" & row1!Unit & "','" & row1!Project & "','" & Format(Today.Date, "MM/dd/yyyy") & "','" & cPreviousLetter & "'," & RemoveNull(row1!Balance, 0) & ")"

                db = New dbOperations(cSql)
                db.dbActionQuery()
            End If
        Next

        MsgBox(cDemandString + " Generated Successfully")
        tdbGridLetters.DataSource = Nothing
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdAddCustomers_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAddCustomers.Click
        If cLetterPrefix = "D1" Then
            cLetterType = "Demand Notice 1"
        ElseIf cLetterPrefix = "D2" Then
            cLetterType = "Demand Notice 2"
        ElseIf cLetterPrefix = "D3" Then
            cLetterType = "Demand Notice 3"
        ElseIf cLetterPrefix = "D4" Then
            cLetterType = "Demand Notice 4"
        ElseIf cLetterPrefix = "D5" Then
            cLetterType = "Demand Notice 5"
        ElseIf cLetterPrefix = "D6" Then
            cLetterType = "Demand Notice 6"
        ElseIf cLetterPrefix = "D7" Then
            cLetterType = "Demand Notice Final"
        End If

        cSql = "Select  tblUnitFile.UnitNumber,tblCustomer.Name as CustomerName,tblCustomer.Address,tblCustomer.Mobile,tblCustomer.TelRes,tblUnitType.Name as UnitTypeName,tblProjectFile.Name as ProjectName,0 as Balance,0 as TotalBalance,"
        cSql = cSql + "tblReservationMst.Unit, tblReservationMst.Customer, tblReservationMst.Customer2, tblReservationMst.UnitType, tblReservationmst.Scheme, tblReservationMst.Project "
        cSql = cSql + "From tblReservationMst, tblUnitFile, tblCustomer, tblUnitType, tblProjectFile "
        cSql = cSql + "Where tblReservationMst.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblReservationMst.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblReservationMst.UnitType = tblUnitType.Code "
        cSql = cSql + "And	 tblReservationMst.Project = tblProjectFile.Code "
        cSql = cSql + "And   tblReservationMst.Project = '" & cmbProject.SelectedValue & "' "

        Dim dt As DataTable = ShowListMulti(cSql, "List of Purchase Orders")
        If dt.Rows.Count > 0 Then
            For Each Row As DataRow In dt.Rows
                Dim newRow As DataRow = dbGrid.cDataTable.NewRow

                newRow("Generate") = 1
                newRow("GenerateDate") = txtGenerateDate.Value
                newRow("Unit") = RemoveNull(Row!Unit, "")
                newRow("UnitNumber") = RemoveNull(Row!UnitNumber, "")
                newRow("Customer") = RemoveNull(Row!Customer, "")
                newRow("Customer2") = RemoveNull(Row!Customer2, "")
                newRow("CustomerName") = RemoveNull(Row!CustomerName, "")
                newRow("Address") = RemoveNull(Row!Address, "")
                newRow("Mobile") = RemoveNull(Row!Mobile, "")
                newRow("TelRes") = RemoveNull(Row!TelRes, "")
                newRow("UnitType") = RemoveNull(Row!UnitType, "")
                newRow("UnitTypeName") = RemoveNull(Row!UnitTypeName, "")
                newRow("Scheme") = RemoveNull(Row!Scheme, "")
                newRow("Project") = RemoveNull(Row!Project, "")
                newRow("ProjectName") = RemoveNull(Row!ProjectName, "")
                newRow("Balance") = 0
                newRow("TotalBalance") = 0
                newRow("LetterType") = cLetterType
                'IIf(cLetterPrefix = "D1", "Demand Notice 1", IIf(cLetterPrefix = "D2", "Demand Notice 2", IIf(cLetterPrefix = "D3", "Demand Notice 3", "Demand Notice 3")))

                dbGrid.cDataTable.Rows.Add(newRow)

                'Try : dbGrid.cDataTable.Rows.Add(newRow) : Catch ex As Exception : MsgBox("Record is Already Selected.", MsgBoxStyle.Information) : End Try
            Next
        End If

    End Sub
End Class