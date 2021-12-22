Imports System
Imports System.Data.SqlClient

Public Class frmUpdateUnitPrices

    Private Sub frmUpdateUnitPrices_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call FillCombo()

        txtEffectFrom.Value = "1/1/2000"
    End Sub

    Sub FillCombo()
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Private Sub cmdUnitType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnitType.Click
        cmbUnitType.SelectedValue = ShowList("Select tblUnitType.Code,tblUnitType.Name as UnitType,tblProjectFile.Name as Project,CashAmount,LoanAmount,TotalRevenue From tblUnitType,tblProjectFile Where tblUnitType.Project = '" & cmbProject.SelectedValue & "' and tblUnitType.Project = tblProjectFile.Code Order By tblUnitType.Code", "List of Unit Type", 1, 0)
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub cmdUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUpdate.Click
        If txtEffectFrom.Value = "1/1/2000" Then
            MsgBox("Please Input Correct Date in W.E.F")
            Exit Sub
        End If

        Dim db As dbOperations
        Dim dr As SqlDataReader

        Dim cSql As String

        Dim cCashAmount As Double
        Dim cLoanAmount As Double
        Dim cTotalRevenue As Double
        Dim cExtraCharges1 As Double
        Dim cExtraCharges2 As Double
        Dim cExtraCharges3 As Double
        Dim cExtraCharges4 As Double
        Dim cExtraCharges5 As Double
        Dim cExtraCharges6 As Double
        Dim cExtraCharges7 As Double
        Dim cExtraCharges8 As Double
        Dim cExtraCharges9 As Double
        Dim cExtraCharges10 As Double
        Dim cExtraCharges11 As Double
        Dim cExtraCharges12 As Double
        Dim cExtraCharges13 As Double
        Dim cExtraCharges14 As Double
        Dim cExtraCharges15 As Double

        db = New dbOperations("Select * From tblUnitType Where Code = '" & cmbUnitType.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cCashAmount = RemoveNull(dr!CashAmount, 0)
            cLoanAmount = RemoveNull(dr!LoanAmount, 0)
            cTotalRevenue = RemoveNull(dr!TotalRevenue, 0)
            cExtraCharges1 = RemoveNull(dr!ExtraChargesAmount1, 0)
            cExtraCharges2 = RemoveNull(dr!ExtraChargesAmount2, 0)
            cExtraCharges3 = RemoveNull(dr!ExtraChargesAmount3, 0)
            cExtraCharges4 = RemoveNull(dr!ExtraChargesAmount4, 0)
            cExtraCharges5 = RemoveNull(dr!ExtraChargesAmount5, 0)
            cExtraCharges6 = RemoveNull(dr!ExtraChargesAmount6, 0)
            cExtraCharges7 = RemoveNull(dr!ExtraChargesAmount7, 0)
            cExtraCharges8 = RemoveNull(dr!ExtraChargesAmount8, 0)
            cExtraCharges9 = RemoveNull(dr!ExtraChargesAmount9, 0)
            cExtraCharges10 = RemoveNull(dr!ExtraChargesAmount10, 0)
            cExtraCharges11 = RemoveNull(dr!ExtraChargesAmount11, 0)
            cExtraCharges12 = RemoveNull(dr!ExtraChargesAmount12, 0)
            cExtraCharges13 = RemoveNull(dr!ExtraChargesAmount13, 0)
            cExtraCharges14 = RemoveNull(dr!ExtraChargesAmount14, 0)
            cExtraCharges15 = RemoveNull(dr!ExtraChargesAmount15, 0)
        End If

        db.Close()
        dr.Close()


        cSql = "Select * From tblUnitFile where Code Not IN (select Unit From tblReservationMst Where IsNull(Cancel,0) = 0) and UnitType = '" & cmbUnitType.SelectedValue & "'"

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            db = New dbOperations("Insert Into tblPriceChange(ChangeDate,UnitType,Project,OldCashAmount,OldLoanAmount,OldTotalRevenue,NewCashAmount,NewLoanAmount,NewTotalRevenue) Values('" & Format(txtEffectFrom.Value, "MM/dd/yyyy") & "','" & cmbUnitType.SelectedValue & "','" & cmbProject.SelectedValue & "'," & dr!CashAmount & "," & dr!LoanAmount & "," & dr!CashAmount + dr!LoanAmount & "," & cCashAmount & "," & cLoanAmount & "," & cTotalRevenue & ")")
            db.dbActionQuery()

            db = New dbOperations("Update tblUnitFile Set ExtraCharges1 = " & cExtraCharges1 & ",ExtraCharges2 = " & cExtraCharges2 & ",ExtraCharges3 = " & cExtraCharges3 & ",ExtraCharges4 = " & cExtraCharges4 & ",ExtraCharges5 = " & cExtraCharges5 & ",ExtraCharges6 = " & cExtraCharges6 & ",ExtraCharges7 = " & cExtraCharges7 & ",ExtraCharges8 = " & cExtraCharges8 & ",ExtraCharges9 = " & cExtraCharges9 & ",ExtraCharges10 = " & cExtraCharges10 & ",ExtraCharges11 = " & cExtraCharges11 & ",ExtraCharges12 = " & cExtraCharges12 & ",ExtraCharges13 = " & cExtraCharges13 & ",ExtraCharges14 = " & cExtraCharges14 & ",ExtraCharges15 = " & cExtraCharges15 & ",CashAmount = " & cCashAmount & ",LoanAmount = " & cLoanAmount & ",TotalRevenue = " & cTotalRevenue & " Where Code = '" & dr!Code & "'")
            db.dbActionQuery()

            For Each DataRow In dr
                db = New dbOperations("Update tblUnitFile Set ExtraCharges1 = " & cExtraCharges1 & ",ExtraCharges2 = " & cExtraCharges2 & ",ExtraCharges3 = " & cExtraCharges3 & ",ExtraCharges4 = " & cExtraCharges4 & ",ExtraCharges5 = " & cExtraCharges5 & ",ExtraCharges6 = " & cExtraCharges6 & ",ExtraCharges7 = " & cExtraCharges7 & ",ExtraCharges8 = " & cExtraCharges8 & ",ExtraCharges9 = " & cExtraCharges9 & ",ExtraCharges10 = " & cExtraCharges10 & ",ExtraCharges11 = " & cExtraCharges11 & ",ExtraCharges12 = " & cExtraCharges12 & ",ExtraCharges13 = " & cExtraCharges13 & ",ExtraCharges14 = " & cExtraCharges14 & ",ExtraCharges15 = " & cExtraCharges15 & ",CashAmount = " & cCashAmount & ",LoanAmount = " & cLoanAmount & ",TotalRevenue = " & cTotalRevenue & " Where Code = '" & dr!Code & "'")
                db.dbActionQuery()
            Next
        End If

        MsgBox("Price Updated Successfully")
    End Sub
End Class