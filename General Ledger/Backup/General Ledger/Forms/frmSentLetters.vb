Imports System
Imports System.Data
Imports System.Data.SqlClient
Public Class frmSentLetters
    Dim cSql As String

    Dim db As dbOperations
    Dim dr As SqlDataReader
    Dim dbGrid As BindGrid

    Private Sub frmPrintLetters_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)

        cmbPrintOption.Text = "Pending"
        cmbGenerationMonth.SelectedIndex = Month(Today.Date)
        cmbGenerationYear.Text = Year(Today.Date)
        txtSentDate.Value = Today.Date

        Dim LetterType As New BindCombo(cmbLetterType, "Select LetterType From tblLetters Group By LetterType", "LetterType", "LetterType", True, True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        cSql = "Select  '' as EntryNo,Getdate() as EntryDate,'' as LetterType,'' as Customer,'' as CustomerName,'' as TelRes,'' as Mobile,'' as Address,"
        cSql = cSql + "'' as Unit,'' as UnitNumber,'' as UnitType,'' as UnitTypeName,0 as SenttoCustomer,GetDate() as SentDate,GetDate() as PrintDate "
        cSql = cSql + "From tblDefaults Where Companyid = 'All'"

        dbGrid = New BindGrid(tdbGridLetters, cSql)

        cSql = "Select	tblLetters.EntryNo,tblLetters.EntryDate,tblLetters.LetterType,"
        cSql = cSql + "Customer,tblCustomer.Name as CustomerName,tblCustomer.TelRes,tblCustomer.Mobile,tblCustomer.Address,"
        cSql = cSql + "tblLetters.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType,tblUnitType.Name as UnitTypeName,"
        cSql = cSql + "IsNull(SentToCustomer,0) as SenttoCustomer,Case When IsNull(SentToCustomer,0) = 0 Then '" & Format(txtSentDate.Value, "MM/dd/yyyy") & "' Else SentDate End as SentDate,PrintDate "
        cSql = cSql + "From     tblLetters, tblCustomer, tblUnitFile, tblUnitType "
        cSql = cSql + "Where    tblLetters.Customer = tblCustomer.Code "
        cSql = cSql + "And		tblLetters.Unit = tblUnitFile.Code "
        cSql = cSql + "And		tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And		Month(tblLetters.EntryDate) = " & cmbGenerationMonth.SelectedIndex & " "
        cSql = cSql + "And		Year(tblLetters.EntryDate) = " & cmbGenerationYear.Text & " "
        cSql = cSql + "And		tblLetters.LetterType = '" & cmbLetterType.Text & "' "
        cSql = cSql + "And		tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And      IsNull(LetterPrint,0) = 1 "

        If cmbPrintOption.Text = "Pending" Then
            cSql = cSql + "And		IsNull(tblLetters.SentToCustomer,0) = 0 "
        ElseIf cmbPrintOption.Text = "Sent" Then
            cSql = cSql + "And		IsNull(tblLetters.SentToCustomer,0) = 1 "
        End If

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()
            Dim NewRow As DataRow = dbGrid.cDataTable.NewRow

            NewRow("SentToCustomer") = RemoveNull(dr!SentToCustomer, 0)
            NewRow("SentDate") = dr!SentDate
            NewRow("PrintDate") = dr!PrintDate
            NewRow("EntryNo") = RemoveNull(dr!EntryNo, "")
            NewRow("EntryDate") = RemoveNull(dr!EntryDate, "")
            NewRow("UnitNumber") = RemoveNull(dr!UnitNumber, "")
            NewRow("CustomerName") = RemoveNull(dr!CustomerName, "")
            NewRow("Address") = RemoveNull(dr!Address, "")
            NewRow("Mobile") = RemoveNull(dr!Mobile, "")
            NewRow("TelRes") = RemoveNull(dr!TelRes, "")
            NewRow("UnitTypeName") = RemoveNull(dr!UnitTypeName, "")

            dbGrid.cDataTable.Rows.Add(NewRow)

            For Each row In dr
                Dim NewRow1 As DataRow = dbGrid.cDataTable.NewRow

                NewRow1("SentToCustomer") = RemoveNull(dr!SentToCustomer, 0)
                NewRow1("SentDate") = dr!SentDate
                NewRow1("PrintDate") = dr!PrintDate
                NewRow1("EntryNo") = RemoveNull(dr!EntryNo, "")
                NewRow1("EntryDate") = RemoveNull(dr!EntryDate, "")
                NewRow1("UnitNumber") = RemoveNull(dr!UnitNumber, "")
                NewRow1("CustomerName") = RemoveNull(dr!CustomerName, "")
                NewRow1("Address") = RemoveNull(dr!Address, "")
                NewRow1("Mobile") = RemoveNull(dr!Mobile, "")
                NewRow1("TelRes") = RemoveNull(dr!TelRes, "")
                NewRow1("UnitTypeName") = RemoveNull(dr!UnitTypeName, "")

                dbGrid.cDataTable.Rows.Add(NewRow1)
            Next
        End If
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            If RemoveNull(row!SentToCustomer, 0) = 1 Then
                db = New dbOperations("Update tblLetters Set SenttoCustomer = 1,SentDate = '" & Format(row!SentDate, "MM/dd/yyyy") & "',SentSystemDate = '" & Format(Today.Date, "MM/dd/yyyy") & "' Where EntryNo = '" & row!EntryNo & "'")
                db.dbActionQuery()
            End If
        Next

        tdbGridLetters.DataSource = Nothing
    End Sub

    Private Sub tdbGridLetters_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridLetters.AfterColUpdate
        If RemoveNull(tdbGridLetters.Columns("SenttoCustomer").Value, 0) = 1 Then
            tdbGridLetters.Columns("SentDate").Value = txtSentDate.Value
        Else
            tdbGridLetters.Columns("SentDate").Value = Nothing
        End If
    End Sub

    Private Sub tdbGridLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridLetters.Click

    End Sub
End Class