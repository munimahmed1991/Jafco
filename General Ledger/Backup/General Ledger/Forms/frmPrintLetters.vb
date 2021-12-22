Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmPrintLetters
    Dim cSql As String

    Dim db As dbOperations
    Dim dr As SqlDataReader
    Dim dbGrid As BindGrid

    Private Sub frmPrintLetters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)

        cmbPrintOption.Text = "Pending"
        cmbGenerationMonth.SelectedIndex = Month(Today.Date)
        cmbGenerationYear.Text = Year(Today.Date)
        txtPrintDate.Value = Today.Date

        Dim LetterType As New BindCombo(cmbLetterType, "Select LetterType From tblLetters Group By LetterType", "LetterType", "LetterType", True, True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        cSql = "Select  '' as EntryNo,Getdate() as EntryDate,'' as LetterType,'' as Customer,'' as CustomerName,'' as TelRes,'' as Mobile,'' as Address,"
        cSql = cSql + "'' as Unit,'' as UnitNumber,'' as UnitType,'' as UnitTypeName,0 as LetterPrint,GetDate() as PrintDate,'' as PaymentInstruction,'' as DespatchNo,'' as ReceivedBy,'' as PreviousLetters "
        cSql = cSql + "From tblDefaults Where Companyid = 'All'"

        dbGrid = New BindGrid(tdbGridLetters, cSql)

        cSql = "Select	tblLetters.EntryNo,tblLetters.EntryDate,tblLetters.LetterType,"
        cSql = cSql + "Customer,tblCustomer.Name as CustomerName,tblCustomer.TelRes,tblCustomer.Mobile,tblCustomer.Address,"
        cSql = cSql + "tblLetters.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType,tblUnitType.Name as UnitTypeName,"
        cSql = cSql + "IsNull(LetterPrint,0) as LetterPrint,Case When IsNull(LetterPrint,0) = 0 Then '" & Format(txtPrintDate.Value, "MM/dd/yyyy") & "' Else PrintDate End as PrintDate,PaymentInstruction,DespatchNo,ReceivedBy,PreviousLetters "
        cSql = cSql + "From     tblLetters, tblCustomer, tblUnitFile, tblUnitType "
        cSql = cSql + "Where    tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And		tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And		tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And		Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And		Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And		tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And		tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And		IsNull(tblLetters.LetterPrint,0) = 0 "
        ElseIf cmbPrintOption.Text = "Printed" Then
            cSql = cSql + "And		IsNull(tblLetters.LetterPrint,0) = 1 "
        End If

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()
            Dim NewRow As DataRow = dbGrid.cDataTable.NewRow

            NewRow("LetterPrint") = RemoveNull(dr!LetterPrint, 0)
            NewRow("PrintDate") = dr!PrintDate
            NewRow("EntryNo") = RemoveNull(dr!EntryNo, "")
            NewRow("EntryDate") = RemoveNull(dr!EntryDate, "")
            NewRow("Unit") = RemoveNull(dr!Unit, "")
            NewRow("UnitNumber") = RemoveNull(dr!UnitNumber, "")
            NewRow("CustomerName") = RemoveNull(dr!CustomerName, "")
            NewRow("Address") = RemoveNull(dr!Address, "")
            NewRow("Mobile") = RemoveNull(dr!Mobile, "")
            NewRow("TelRes") = RemoveNull(dr!TelRes, "")
            NewRow("UnitTypeName") = RemoveNull(dr!UnitTypeName, "")
            NewRow("PaymentInstruction") = RemoveNull(dr!PaymentInstruction, "")
            NewRow("DespatchNo") = RemoveNull(dr!Despatchno, "")
            NewRow("PreviousLetters") = RemoveNull(dr!PreviousLetters, "")
            NewRow("ReceivedBy") = RemoveNull(dr!ReceivedBy, "")

            dbGrid.cDataTable.Rows.Add(NewRow)

            For Each row In dr
                Dim NewRow1 As DataRow = dbGrid.cDataTable.NewRow

                NewRow1("LetterPrint") = RemoveNull(dr!LetterPrint, 0)
                NewRow1("PrintDate") = dr!PrintDate
                NewRow1("EntryNo") = RemoveNull(dr!EntryNo, "")
                NewRow1("EntryDate") = RemoveNull(dr!EntryDate, "")
                NewRow1("Unit") = RemoveNull(dr!Unit, "")
                NewRow1("UnitNumber") = RemoveNull(dr!UnitNumber, "")
                NewRow1("CustomerName") = RemoveNull(dr!CustomerName, "")
                NewRow1("Address") = RemoveNull(dr!Address, "")
                NewRow1("Mobile") = RemoveNull(dr!Mobile, "")
                NewRow1("TelRes") = RemoveNull(dr!TelRes, "")
                NewRow1("UnitTypeName") = RemoveNull(dr!UnitTypeName, "")
                NewRow1("PaymentInstruction") = RemoveNull(dr!PaymentInstruction, "")
                NewRow1("DespatchNo") = RemoveNull(dr!Despatchno, "")
                NewRow1("PreviousLetters") = RemoveNull(dr!PreviousLetters, "")
                NewRow1("ReceivedBy") = RemoveNull(dr!ReceivedBy, "")

                dbGrid.cDataTable.Rows.Add(NewRow1)
            Next
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            If RemoveNull(row!LetterPrint, 0) = 1 Then
                db = New dbOperations("Update tblLetters Set LetterPrint = 1,PrintDate = '" & Format(row!PrintDate, "MM/dd/yyyy") & "',PrintSystemDate = '" & Format(Today.Date, "MM/dd/yyyy") & "',PaymentInstruction = '" & RemoveNull(row!PaymentInstruction, "") & "',PreviousLetters = '" & RemoveNull(row!PreviousLetters, "") & "',ReceivedBy = '" & RemoveNull(row!ReceivedBy, "") & "',DespatchNo = '" & RemoveNull(row!DespatchNo, "") & "' Where EntryNo = '" & row!EntryNo & "'")
                db.dbActionQuery()
            Else
                db = New dbOperations("Update tblLetters Set LetterPrint = 0 Where EntryNo = '" & row!EntryNo & "'")
                db.dbActionQuery()
            End If
        Next

        If cmbLetterType.Text = "Welcome Letter" Then
            Call PrintWelcomeLetter("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call PrintWelcomeLetter("Yes")
            End If
        End If

        If cmbLetterType.Text = "Reminder Notice 1" Then
            Call PrintReminderNotice1("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call PrintWelcomeLetter("Yes")
            End If
        End If


        If cmbLetterType.Text = "Construction Letter" Then
            Call PrintConstructionLetter("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call PrintConstructionLetter("Yes")
            End If
        End If

        If UCase(Mid(cmbProject.SelectedText, 1, 14)) = "CHAPAL SKYMARK" Then
            If cmbLetterType.Text = "Demand Notice 1" Then
                Call PrintDemandNotice1Skymark("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call PrintDemandNotice1Skymark("Yes")
                End If
            End If
        Else
            If cmbLetterType.Text = "Demand Notice 1" Then
                Call PrintDemandNotice1("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call PrintDemandNotice1("Yes")
                End If
            End If
        End If

        If UCase(Mid(cmbProject.SelectedText, 1, 14)) = "CHAPAL SKYMARK" Then
            If cmbLetterType.Text = "Demand Notice 2" Then
                Call PrintDemandNotice2Skymark("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call PrintDemandNotice2Skymark("Yes")
                End If
            End If
        Else
            If cmbLetterType.Text = "Demand Notice 2" Then
                Call PrintDemandNotice2("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call PrintDemandNotice2("Yes")
                End If
            End If
        End If

        If UCase(Mid(cmbProject.SelectedText, 1, 14)) = "CHAPAL SKYMARK" Then
            If cmbLetterType.Text = "Demand Notice 3" Then
                Call PrintDemandNotice3Skymark("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call PrintDemandNotice3Skymark("Yes")
                End If
            End If
        Else
            If cmbLetterType.Text = "Demand Notice 3" Then
                Call PrintDemandNotice3("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call PrintDemandNotice3("Yes")
                End If
            End If
        End If

        If cmbLetterType.Text = "Demand Notice 4" Then
            Call PrintDemandNotice3("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call PrintDemandNotice3("Yes")
            End If
        End If

        If cmbLetterType.Text = "Demand Notice 5" Then
            Call PrintDemandNotice3("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call PrintDemandNotice3("Yes")
            End If
        End If

        If cmbLetterType.Text = "Demand Notice 6" Then
            Call PrintDemandNotice3("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call PrintDemandNotice3("Yes")
            End If
        End If

        If UCase(Mid(cmbProject.SelectedText, 1, 14)) = "CHAPAL SKYMARK" Then
            If cmbLetterType.Text = "Final Notice" Then
                Call PrintFinalNoticeSkymark("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call PrintFinalNoticeSkymark("Yes")
                End If
            End If
        Else
            If cmbLetterType.Text = "Demand Notice Final" Then
                Call FinalNotice("No")

                If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    Call FinalNotice("Yes")
                End If
            End If
        End If

        If cmbLetterType.Text = "Due Service Letter" Then
            Call DueServiceLetter("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call DueServiceLetter("Yes")
            End If
        End If

        If cmbLetterType.Text = "Due Service Letter 1" Then
            Call DueServiceLetter1("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call DueServiceLetter1("Yes")
            End If
        End If

        If cmbLetterType.Text = "Due Service Letter 2" Then
            Call DueServiceLetter2("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call DueServiceLetter2("Yes")
            End If
        End If

        If cmbLetterType.Text = "Due Service Letter 3" Then
            Call DueServiceLetter3("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call DueServiceLetter3("Yes")
            End If
        End If

        If cmbLetterType.Text = "Due Service Letter 4" Then
            Call DueServiceLetter4("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call DueServiceLetter4("Yes")
            End If
        End If

        If cmbLetterType.Text = "Due Service Letter 5" Then
            Call DueServiceLetter5("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call DueServiceLetter5("Yes")
            End If
        End If

        If cmbLetterType.Text = "HBFC Loan" Then
            Call HBFCLoan("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call HBFCLoan("Yes")
            End If
        End If

        If cmbLetterType.Text = "HBFC Loan 1" Then
            Call HBFCLoan1("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call HBFCLoan1("Yes")
            End If
        End If

        If cmbLetterType.Text = "HBFC Loan 2" Then
            Call HBFCLoan2("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call HBFCLoan2("Yes")
            End If
        End If

        If cmbLetterType.Text = "HBFC Loan 3" Then
            Call HBFCLoan3("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call HBFCLoan3("Yes")
            End If
        End If

        If cmbLetterType.Text = "HBFC Loan 4" Then
            Call HBFCLoan4("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call HBFCLoan4("Yes")
            End If
        End If

        If cmbLetterType.Text = "Due Service Letter 3" Then
            Call DueServiceLetter3("No")

            If MsgBox("Do You Want to Print Letter", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Call DueServiceLetter3("Yes")
            End If
        End If

        tdbGridLetters.DataSource = Nothing
    End Sub

    Sub DueServiceLetter1(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequence to our previous letter Dated : ' + PreviousLetters + ' on the above subject, we remind you agiain that we are in Process of receiving the ESTIMATES of Electricity, Gas, Water Sewerage, other utilities / services and Development Charges of concerned departments which are to be paid immediatly. You are aware that after the payment of those estimates, the departments will take considerable time to execute the work for the laying . connection of services in the Project.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4 "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDueforService1

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub DueServiceLetter2(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequence to our previous letter Dated : ' + PreviousLetters + ' on the above subject, we remind you agiain that we are in Process of receiving the ESTIMATES of Electricity, Gas, Water Sewerage, other utilities / services and Development Charges of concerned departments which are to be paid immediatly. You are aware that after the payment of those estimates, the departments will take considerable time to execute the work for the laying . connection of services in the Project.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4 "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDueforService2

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub DueServiceLetter4(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequent to our previous letters dated : ' + PreviousLetters + ' on the above subject,this is to intimate you again to make payment of Electricity, Gas, Water, Sewerage, other utilities / services connection and Development Charges for your respective unit within ten (10) days of this letter.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Payment Due for Services / Utilites Connection / Development Charges for your Unit No. ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDueforService4

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub DueServiceLetter5(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequent to our previous letters Dated : ' + PreviousLetters + ' on the above subject, this is to intimate you again to make payment of Electricity, Gas, Water, Sewerage, other utilities / services connection and Development Charges for your respective unit. Our representatives have already notified and intimated you several times over the phone with regards to these charges.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Payment Due for Services / Utilites Connection / Development Charges for your Unit No. ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDueforService5

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub


    Sub DueServiceLetter3(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequent to our previous letters Dated : ' + PreviousLetters + ' on the above subject, this is to intimate you again to make payment of Electricity, Gas, Water, Severage, other utilities / services connection and Development Charges of your respective unit within ten (10) days of this letter.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Payment Due for Services / Utilites Connection / Development Charges for your Unit No. ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDueforService3

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub DueServiceLetter(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequence to our previous letter Dated : ' + PreviousLetters + ' on the above subject, we remind you agiain that we are in Process of receiving the ESTIMATES of Electricity, Gas, Water Sewerage, other utilities / services and Development Charges of concerned departments which are to be paid immediatly. You are aware that after the payment of those estimates, the departments will take considerable time to execute the work for the laying . connection of services in the Project.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4 "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"



        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDueforService

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub HBFCLoan(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequence to our previous letter Dated : ' + PreviousLetters + ' on the above subject, we remind you agiain that we are in Process of receiving the ESTIMATES of Electricity, Gas, Water Sewerage, other utilities / services and Development Charges of concerned departments which are to be paid immediatly. You are aware that after the payment of those estimates, the departments will take considerable time to execute the work for the laying . connection of services in the Project.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Processsing Loan from House Building Finance Corporation (HBFC) for your Unit No: ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"


        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptHBFCLoan

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub HBFCLoan1(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequence to our previous letter Dated : ' + PreviousLetters + ' on the above subject, we remind you agiain that we are in Process of receiving the ESTIMATES of Electricity, Gas, Water Sewerage, other utilities / services and Development Charges of concerned departments which are to be paid immediatly. You are aware that after the payment of those estimates, the departments will take considerable time to execute the work for the laying . connection of services in the Project.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Processsing Loan from House Building Finance Corporation (HBFC) for your Unit No: ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"


        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptHBFCLoan1

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub HBFCLoan2(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequence to our previous letter Dated : ' + PreviousLetters + ' on the above subject, we remind you agiain that we are in Process of receiving the ESTIMATES of Electricity, Gas, Water Sewerage, other utilities / services and Development Charges of concerned departments which are to be paid immediatly. You are aware that after the payment of those estimates, the departments will take considerable time to execute the work for the laying . connection of services in the Project.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Processsing Loan from House Building Finance Corporation (HBFC) for your Unit No: ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject,PaymentInstruction "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"


        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptHBFCLoan2

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub HBFCLoan3(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequent to our previous letters Dated : ' + PreviousLetters + ' on the above subject, this is to intimate you again that due to your constant failures to fulfill the formalities of HBFC Loan and not starting the loan process within the extended allocated time, the loan amount in your payment plan had already been converted to Cash amount payable immediately as per Terms & Conditions.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Payment due of Loan Amount of House Building Finance Corporation (HBFC) for your Unit No: ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject,PaymentInstruction "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"


        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptHBFCLoan3

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub HBFCLoan4(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'Subsequent to our previous letters Dated : ' + PreviousLetters + ' on the above subject,this is to intimate you again that due to your constant failures to fulfill the formalities of HBFC Loan and not starting the loan process within the extended allocated time, the loan amount in your payment plan had already been converted to Cash amount payable immediately as per Terms & Conditions.' as Paragraph1, "
        cSql = cSql + "'The project construction is in full swing and getting timely services will benefit the project immensely. Therefore we request you to pay the utilities / services connection charges at your earliest to avoid any delays in getting all the services to the project.' as Paragraph2, "
        cSql = cSql + "'The get your estimate kindly contact our Customer Care Department on 021-34991114, 34986437 or UAN: 111-CHAPAL (242725)' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4, "
        cSql = cSql + "'Payment due of Loan Amount of House Building Finance Corporation (HBFC) for your Unit No: ' + tblUnitFile.UnitNumber + ' in Project ' + tblProjectFile.Name as Subject,PaymentInstruction "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"


        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptHBFCLoan4

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub


    Sub PrintWelcomeLetter(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address, "
        cSql = cSql + "'With a heartwarming welcome to you, we are glad to entertain your interest in our Project ' + tblProjectFile.Name + ' and appreciate your booking of Unit # ' + tblUnitFile.UnitNumber as Paragraph1, "
        cSql = cSql + "'As you are well aware of the payment schedule that was agreed upon at the time of booking, your monthly installment will start one month after booking. As a result, we positively hope that you will be prompt enough to regulate your participation by paying installments/ payments on or before the 10th of each month without any intimation by us. If you have any payable amounts due, kindly clear them along with your monthly installment as mentioned above' as Paragraph2, "
        cSql = cSql + "'We ensure you that your cordial support and encouragement will truly help us in speeding up our earnest efforts to serve you professionally and passionately as always.' as Paragraph3, "
        cSql = cSql + "'Moreover, our Customer Care Department on UAN 111-CHAPAL (242 725) will gladly assist you with any further queries that you may have. We assurre you of an excellent service all the times.' as Paragraph4 "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptWelcomeLetter


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "WelcomeLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("WelcomeLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintConstructionLetter(ByVal cPrint As String)
        cSql = "Select EntryNo + '/' + DespatchNo as EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName,tblCustomer.Address,tblUnitFile.UnitNumber, "
        cSql = cSql + "' ' as Paragraph1, "
        cSql = cSql + "' ' as Paragraph2, "
        cSql = cSql + "' ' as Paragraph3, "
        cSql = cSql + "' ' as Paragraph4 "
        cSql = cSql + "From tblLetters Left Outer Join tblCustomer Customer2 On tblLetters.Customer2 = Customer2.Code, tblCustomer, tblUnitFile, tblProjectFile "
        cSql = cSql + "Where tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And	 tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And	 tblProjectFile.Code = tblLetters.Project "
        cSql = cSql + "And	 Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And	 Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And	 tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And	 tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And   IsNull(tblLetters.LetterPrint,0) = 1"

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And PrintSystemDate  = '" & Format(Today.Date, "MM/dd/yyyy") & "' "
        End If

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptConstructionLetter

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "ConstructionLetter")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("ConstructionLetter")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintDemandNotice2Skymark(ByVal cPrint As String)
        cSql = "Exec [DemandNoticeSkymarkPrint] '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDemandNotice2SkyMark

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "DemandNotice1")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice1")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintFinalNoticeSkymark(ByVal cPrint As String)
        cSql = "Exec [DemandNoticeSkymarkPrint] '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptFinalNoticeSkyMark

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "DemandNotice1")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice1")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintDemandNotice1Skymark(ByVal cPrint As String)
        cSql = "Exec [DemandNoticeSkymarkPrint] '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDemandNotice1SkyMark

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "DemandNotice1")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice1")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintReminderNotice1(ByVal cPrint As String)
        cSql = "Exec ReminderNoticePrint '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptReminderNotice1

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "DemandNotice1")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice1")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintDemandNotice1(ByVal cPrint As String)
        cSql = "Exec DemandNoticePrint '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDemandNotice1


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "DemandNotice1")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice1")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub


    Sub PrintDemandNotice2(ByVal cPrint As String)
        cSql = "Exec DemandNoticePrint '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDemandNotice2


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.Fill(ds, "DemandNotice2")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice2")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintDemandNotice3Skymark(ByVal cPrint As String)
        cSql = "Exec [DemandNoticeSkymarkPrint] '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDemandNotice3SkyMark

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.SelectCommand.CommandTimeout = 0
        da.Fill(ds, "DemandNotice3")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice3")
        rReport.TextBox44.Text = cmbLetterType.Text
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub PrintDemandNotice3(ByVal cPrint As String)
        cSql = "Exec DemandNoticePrint '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptDemandNotice3

        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.SelectCommand.CommandTimeout = 0
        da.Fill(ds, "DemandNotice3")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("DemandNotice3")
        rReport.TextBox44.Text = cmbLetterType.Text
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub

    Sub FinalNotice(ByVal cPrint As String)
        cSql = "Exec FinalNotice '" & cmbProject.SelectedValue & "'," & cmbGenerationMonth.SelectedIndex & "," & cmbGenerationYear.Text & ",'" & cmbLetterType.Text & "','" & cmbPrintOption.Text & "','" & Format(Today.Date, "MM/dd/yyyy") & "'," & Val(chkIncludePenalty.Checked)

        Dim dr As SqlDataReader = Nothing
        Call ProgressBar(10)
        Dim fPreview As New frmPreview
        Dim rReport As New rptFinalNotice


        Call ProgressBar(25)

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, ConString)

        da.SelectCommand.CommandTimeout = 0
        da.Fill(ds, "FinalNotice")

        Call ProgressBar(50)

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("FinalNotice")
        fPreview.arv.Document = rReport.Document

        Call ProgressBar(75)

        Call ProgressBar(90)
        fPreview.MdiParent = frmMain

        rReport.Run(True)

        If cPrint = "No" Then
            fPreview.Show()
        Else
            fPreview.arv.Document.Print(False, False)
        End If

        Call ProgressBar(100)
        Me.Cursor = Cursors.Default
    End Sub



    Private Sub tdbGridLetters_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridLetters.AfterColUpdate
        If tdbGridLetters.Columns("LetterPrint").Value = 1 Then
            tdbGridLetters.Columns("PrintDate").Value = txtPrintDate.Value
        Else
            tdbGridLetters.Columns("PrintDate").Value = Nothing
        End If
    End Sub

    Private Sub cmdUpdateRecoveryStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdateRecoveryStatus.Click
        Dim db As dbOperations
        Dim dr As SqlDataReader

        Dim cRecoveryAmount As Double

        If dbGrid.cDataTableCollection(0).Rows.Count Then
            For Each row In dbGrid.cDataTableCollection(0).Select
                cSql = "Exec RecoveryReport '" & Format(DateFrom, "MM/dd/yyyy") & "','" & Format(row!PrintDate, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','" & row!Unit & "','Report','All'"

                db = New dbOperations(cSql)
                dr = db.dbSelectQuery

                If dr.HasRows = True Then
                    dr.Read()

                    cRecoveryAmount = RemoveNull(dr!BalanceTillDate, 0)
                End If

                db.Close()
                dr.Close()

                If cRecoveryAmount <> 0 Then
                    db = New dbOperations("Update tblLetters Set DueAmount = " & cRecoveryAmount & " Where EntryNo = '" & row!EntryNo & "'")
                    db.dbActionQuery()
                End If
            Next
        End If
    End Sub

    Private Sub tdbGridLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridLetters.Click

    End Sub

    Private Sub cmdApply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdApply.Click
        For Each row In dbGrid.cDataTableCollection(0).Select
            row!PaymentInstruction = txtPaymentInstruction.Text
        Next
    End Sub
End Class