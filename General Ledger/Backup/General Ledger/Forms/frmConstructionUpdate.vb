Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmConstructionUpdate
    Dim dbGrid As BindGrid
    Dim cSql As String

    Dim db As dbOperations
    Dim dr As SqlDataReader

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        cSql = "Select	0 as Generate,'" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "' as GenerateDate,'Construction Letter' as LetterType,"
        cSql += "tblReservationMst.Project,tblProjectFile.Name as ProjectName,"
        cSql += "Customer,tblCustomer.Name as CustomerName,Mobile,TelRes,tblCustomer.Address,"
        cSql += "ReservationDate,IsNull(tblScheme.Name,'') as Scheme,"
        cSql += "tblReservationMst.UnitType,tblUnitType.Name as UnitTypeName,"
        cSql += "Unit,tblUnitFile.UnitNumber as UnitNumber,tblReservationMst.Customer2 "
        cSql += "From	tblReservationMst Left Outer Join tblScheme On tblScheme.Code = tblReservationMst.Scheme,tblProjectFile,tblCustomer,tblUnitType,tblUnitFile "
        cSql += "Where  tblReservationMst.Project = tblProjectFile.Code "
        cSql += "And	tblReservationMst.Customer = tblCustomer.Code "
        cSql += "And	tblReservationMst.UnitType = tblUnitType.Code "
        cSql += "And	tblReservationMst.Unit = tblUnitFile.Code "
        cSql += "And	IsNull(tblReservationMst.Cancel,0) = 0 "
        cSql += "And    tblReservationMst.Project = '" & cmbProject.SelectedValue & "' "
        cSql += "And    tblReservationMst.ReservationDate <= '" & Format(txtGenerateDate.Value, "MM/dd/yyyy") & "' "

        dbGrid = New BindGrid(tdbGridLetters, cSql)
    End Sub

    Private Sub tdbGridLetters_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridLetters.AfterColUpdate
        If tdbGridLetters.Columns("Generate").Value = 1 Then
            tdbGridLetters.Columns("GenerateDate").Value = txtGenerateDate.Value
        Else
            tdbGridLetters.Columns("GenerateDate").Value = Nothing
        End If
    End Sub

    Private Sub tdbGridLetters_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tdbGridLetters.Click

    End Sub

    Private Sub frmWelcomeLetter_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)

        txtGenerateDate.Value = Today.Date

        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim cNextNo As String
        Dim cPrefix As String

        db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cPrefix = dr!Prefix
        End If

        db.Close()
        dr.Close()

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            If RemoveNull(row!Generate, 0) = 1 Then
                cNextNo = NextSerial("EntryNo", "tblLetters", "000", cPrefix + "/" + Trim(row!UnitNumber) + "/", "Unit = '" & row!Unit & "'")

                cSql = "Insert Into tblLetters(EntryNo,EntryDate,LetterType,Customer,Customer2,Unit,Project,GenerateSystemDate) Values('" & cNextNo & "','" & row!GenerateDate & "','Construction Letter','" & row!Customer & "','" & row!Customer2 & "','" & row!Unit & "','" & row!Project & "','" & Format(Today.Date, "MM/dd/yyyy") & "')"

                db = New dbOperations(cSql)
                db.dbActionQuery()
            End If
        Next

        MsgBox("Construction Letter Generated Successfully")

        tdbGridLetters.DataSource = Nothing
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
End Class