Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmRecoveryFollowup

    Dim dbGrid As BindGrid

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmRecoveryFollowup_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call FillCombo()

        txtDate.Value = Today.Date
    End Sub

    Sub FillCombo()
        Dim cUnit As New BindCombo(tdbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True)
        Dim cUnitType As New BindCombo(tdbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True)
        Dim cCustomer As New BindCombo(tdbCustomer, "Select Code,Name From tblCustomer", "Name", "Code", True)
        Dim cMobile As New BindCombo(tdbMobile, "Select Code,Case When IsNull(Mobile,'') = '' Then '-' Else IsNull(Mobile,'-') End as Mobile From tblCustomer", "Mobile", "Code", True)
        Dim cPhone As New BindCombo(tdbPhone, "Select Code,Case When IsNull(TelRes,'') = '' Then '-' Else IsNull(TelRes,'-') End as Phone From tblCustomer", "Phone", "Code", True)
        Dim cEmail As New BindCombo(tdbEmail, "Select Code,Case When IsNull(Email,'') = '' Then '-' Else IsNull(Email,'-') End as Email From tblCustomer", "Email", "Code", True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name from tblProjectFile Order By Name", "Name", "Code", True, True)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project")
            Exit Sub
        End If

        Call DisplayRec()
    End Sub

    Sub DisplayRec()
        Dim cSql As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        Dim db1 As dbOperations
        Dim dr1 As SqlDataReader

        Dim cReceiptDate As String
        Dim cLastLetterDate As String

        cSql = "Select * From tblRecoveryFollowup Where FollowupDate = '" & Format(txtDate.Value, "MM/dd/yyyy") & "' and FollowupType = '" & cmbFollowupType.Text & "' and Project= '" & cmbProject.SelectedValue & "'"

        dbGrid = New BindGrid(tdbGridFollowup, csql)

        If dbGrid.cDataTableCollection(0).Rows.Count <= 0 Then
            If cmbFollowupType.Text = "30 Days" Then
                cSql = "Exec AgingReport '" & Format(txtDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','30 Days'"
            ElseIf cmbFollowupType.Text = "60 Days" Then
                cSql = "Exec AgingReport '" & Format(txtDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','60 Days'"
            ElseIf cmbFollowupType.Text = "90 Days" Then
                cSql = "Exec AgingReport '" & Format(txtDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','90 Days'"
            ElseIf cmbFollowupType.Text = "Over 90 Days" Then
                cSql = "Exec AgingReport '" & Format(txtDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','','','Over 90 Days'"
            End If

            db = New dbOperations(cSql)
            dr = db.dbSelectQuery

            If dr.HasRows Then
                dr.Read()

                Dim newRow As DataRow = dbGrid.cDataTable.NewRow
                newRow("FollowupDate") = txtDate.Value
                newRow("FollowupType") = cmbFollowupType.Text
                newRow("Unit") = dr!Unit
                newRow("UnitType") = dr!UnitType
                newRow("Customer") = dr!Customer
                newRow("Thirtydays") = RemoveNull(dr!Days30, 0)
                newRow("Sixtydays") = RemoveNull(dr!Days60, 0)
                newRow("NinetyDays") = RemoveNull(dr!Days90, 0)
                newRow("OverNinetyDays") = RemoveNull(dr!After90Days, 0)
                newRow("TotalAmount") = RemoveNull(dr!Amount, 0)

                db1 = New dbOperations("Select Max(ReceiptDate) as ReceiptDate From tblReceiptMst Mst Where Unit = '" & RemoveNull(dr!Unit, 0) & "'")
                dr1 = db1.dbSelectQuery

                If dr1.HasRows = True Then
                    dr1.Read()

                    cReceiptDate = RemoveNull(dr1!ReceiptDate, Nothing)

                    If cReceiptDate <> Nothing Then
                        newRow("LastPaymentDate") = cReceiptDate
                    End If

                    db1.Close()
                    dr1.Close()

                    db1 = New dbOperations("Select Amount From tblReceiptMst Mst Where ReceiptDate = '" & cReceiptDate & "' And Unit = '" & RemoveNull(dr!Unit, 0) & "'")
                    dr1 = db1.dbSelectQuery

                    If dr1.HasRows = True Then
                        dr1.Read()

                        newRow("LastPaymentAmount") = RemoveNull(dr1!Amount, 0)
                    End If

                    db1.Close()
                    dr1.Close()
                End If

                cSql = "Select Max(FollowupDate) as FollowupDate From tblRecoveryFollowup Where Unit = '" & RemoveNull(dr!Unit, "") & "'"

                db1 = New dbOperations(cSql)
                dr1 = db1.dbSelectQuery

                If dr1.HasRows Then
                    dr1.Read()

                    If RemoveNull(dr1!FollowupDate, Nothing) <> Nothing Then
                        newRow("LastFollowupDate") = dr1!FollowupDate
                    End If
                End If

                db1.Close()
                dr1.Close()

                cSql = "Select Remarks From tblRecoveryFollowup Where FollowupDate = '" & RemoveNull(newRow("LastFollowupDate"), Nothing) & "' and Unit = '" & RemoveNull(dr!Unit, "") & "'"

                db1 = New dbOperations(cSql)
                dr1 = db1.dbSelectQuery

                If dr1.HasRows Then
                    dr1.Read()

                    newRow("LastFollowupRemarks") = RemoveNull(dr1!Remarks, Nothing)
                End If

                db1.Close()
                dr1.Close()

                cSql = "Select Max(EntryDate) as LetterDate From tblLetters Where Unit = '" & RemoveNull(dr!Unit, "") & "' and Substring(LetterType,1,6) = 'Demand'"

                db1 = New dbOperations(cSql)
                dr1 = db1.dbSelectQuery

                If dr1.HasRows Then
                    dr1.Read()

                    cLastLetterDate = RemoveNull(dr1!LetterDate, Nothing)

                    If RemoveNull(cLastLetterDate, Nothing) <> Nothing Then
                        newRow("LastLetterDate") = RemoveNull(cLastLetterDate, Nothing)
                    End If
                End If

                db1.Close()
                dr1.Close()

                cSql = "Select LetterType From tblLetters Where EntryDate = '" & RemoveNull(cLastLetterDate, Nothing) & "' and Substring(LetterType,1,6) = 'Demand' and Unit = '" & RemoveNull(dr!Unit, "") & "'"

                db1 = New dbOperations(cSql)
                dr1 = db1.dbSelectQuery

                If dr1.HasRows Then
                    dr1.Read()

                    newRow("LastLetter") = RemoveNull(dr1!LetterType, "")
                End If

                db1.Close()
                dr1.Close()

                dbGrid.cDataTable.Rows.Add(newRow)

                For Each DataRow In dr
                    Dim newRow1 As DataRow = dbGrid.cDataTable.NewRow
                    newRow1("FollowupDate") = txtDate.Value
                    newRow1("FollowupType") = cmbFollowupType.Text
                    newRow1("Unit") = dr!Unit
                    newRow1("UnitType") = dr!UnitType
                    newRow1("Customer") = dr!Customer
                    newRow1("Thirtydays") = RemoveNull(dr!Days30, 0)
                    newRow1("Sixtydays") = RemoveNull(dr!Days60, 0)
                    newRow1("NinetyDays") = RemoveNull(dr!Days90, 0)
                    newRow1("OverNinetyDays") = RemoveNull(dr!After90Days, 0)
                    newRow1("TotalAmount") = RemoveNull(dr!Amount, 0)

                    db1 = New dbOperations("Select Max(ReceiptDate) as ReceiptDate From tblReceiptMst Mst Where Unit = '" & RemoveNull(dr!Unit, 0) & "'")
                    dr1 = db1.dbSelectQuery

                    If dr1.HasRows = True Then
                        dr1.Read()

                        cReceiptDate = RemoveNull(dr1!ReceiptDate, Nothing)

                        If cReceiptDate <> Nothing Then
                            newRow1("LastPaymentDate") = cReceiptDate
                        End If

                        db1.Close()
                        dr1.Close()

                        db1 = New dbOperations("Select Amount From tblReceiptMst Mst Where ReceiptDate = '" & cReceiptDate & "' And Unit = '" & RemoveNull(dr!Unit, 0) & "'")
                        dr1 = db1.dbSelectQuery

                        If dr1.HasRows = True Then
                            dr1.Read()

                            newRow1("LastPaymentAmount") = RemoveNull(dr1!Amount, 0)
                        End If

                        db1.Close()
                        dr1.Close()
                    End If

                    cSql = "Select Max(FollowupDate) as FollowupDate From tblRecoveryFollowup Where Unit = '" & RemoveNull(dr!Unit, "") & "'"

                    db1 = New dbOperations(cSql)
                    dr1 = db1.dbSelectQuery

                    If dr1.HasRows Then
                        dr1.Read()
                        If RemoveNull(dr1!FollowupDate, Nothing) <> Nothing Then
                            newRow1("LastFollowupDate") = dr1!FollowupDate
                        End If
                    End If

                    db1.Close()
                    dr1.Close()

                    cSql = "Select Remarks From tblRecoveryFollowup Where FollowupDate = '" & RemoveNull(newRow1("LastFollowupDate"), Nothing) & "' and Unit = '" & RemoveNull(dr!Unit, "") & "'"

                    db1 = New dbOperations(cSql)
                    dr1 = db1.dbSelectQuery

                    If dr1.HasRows Then
                        dr1.Read()

                        newRow1("LastFollowupRemarks") = RemoveNull(dr1!Remarks, Nothing)
                    End If

                    db1.Close()
                    dr1.Close()

                    cSql = "Select Max(EntryDate) as LetterDate From tblLetters Where Unit = '" & RemoveNull(dr!Unit, "") & "' and Substring(LetterType,1,6) = 'Demand'"

                    db1 = New dbOperations(cSql)
                    dr1 = db1.dbSelectQuery

                    If dr1.HasRows Then
                        dr1.Read()

                        cLastLetterDate = RemoveNull(dr1!LetterDate, Nothing)

                        If RemoveNull(cLastLetterDate, Nothing) <> Nothing Then
                            newRow1("LastLetterDate") = RemoveNull(cLastLetterDate, Nothing)
                        End If
                    End If

                    db1.Close()
                    dr1.Close()

                    cSql = "Select LetterType From tblLetters Where EntryDate = '" & RemoveNull(cLastLetterDate, Nothing) & "' and Unit = '" & RemoveNull(dr!Unit, "") & "' and Substring(LetterType,1,6) = 'Demand'"

                    db1 = New dbOperations(cSql)
                    dr1 = db1.dbSelectQuery

                    If dr1.HasRows Then
                        dr1.Read()

                        newRow1("LastLetter") = RemoveNull(dr1!LetterType, Nothing)
                    End If

                    db1.Close()
                    dr1.Close()

                    dbGrid.cDataTable.Rows.Add(newRow1)
                Next
            End If
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        dbGrid.SetCriteria = "Followupdate = '" & Format(txtDate.Value, "MM/dd/yyyy") & "' and FollowupType = '" & cmbFollowupType.Text & "'"

        If MsgBox("Do You Want to Delete Data Without Remarks for Todays Followup", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            For Each ROW In dbGrid.cDataTableCollection(0).Select
                If RemoveNull(ROW!Remarks, "") = "" Then
                    ROW.Delete()
                End If
            Next
        End If

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("FollowupDate", txtDate.Value)
        dbGrid.AddKeyCol("FollowupType", cmbFollowupType.Text)
        dbGrid.AddKeyCol("Project", cmbProject.SelectedValue)
        dbGrid.Update()

        Me.Close()
    End Sub

    Private Sub tdbGridFollowup_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridFollowup.ButtonClick
        Dim cSql As String = ""
        Dim cTitle As String = ""
        Dim cReportType As String = Nothing

        If e.ColIndex = 21 Then
            cSql = "Exec [CustomerStatement] '" & Format(txtDate.Value, "MM/dd/yyyy") & "','" & cmbProject.SelectedValue & "','','" & tdbGridFollowup.Columns("Unit").Value & "','Pending'"

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
            'rReport.fldCompany.Text = cmbProject.Text
            rReport.fldTitle.Text = "CUSTOMER STATEMENT UPTO : " & Format(txtDate.Value, "dd/MM/yyyy")
            fPreview.arv.Document = rReport.Document

            Call ProgressBar(75)

            Call ProgressBar(90)
            fPreview.MdiParent = frmMain

            fPreview.Show()
            rReport.Run(True)
            Call ProgressBar(100)
            Me.Cursor = Cursors.Default
        End If

        If e.ColIndex = 22 Then
            cSql = "Select FollowupDate,FollowupType,tblProjectFile.Name as Project,tblUnitType.Name as UnitType,tblUnitFile.UnitNumber as UnitNumber,tblCustomer.Name as Customer,Mobile,TotalAmount,LastPaymentDate,LastPaymentAmount,LastLetter,LastFollowupDate,LastFollowupRemarks,CallStatus,tblRecoveryFollowup.Remarks,CommitmentDate From tblRecoveryFollowup,tblUnitFile,tblUnitType,tblCustomer,tblProjectFile Where tblRecoveryFollowup.Project = tblProjectFile.Code and tblRecoveryFollowup.Customer = tblCustomer.Code and tblUnitFile.UnitType = tblUnitType.Code and tblRecoveryFollowup.Unit = tblUnitFile.Code and tblRecoveryFollowup.Unit = '" & tdbGridFollowup.Columns("Unit").Value & "' Order By FollowupDate Desc"

            ShowList(cSql, "Followup History", 0, 0, , , , "Report")
        End If
    End Sub

    Private Sub tdbGridFollowup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridFollowup.Click

    End Sub
End Class