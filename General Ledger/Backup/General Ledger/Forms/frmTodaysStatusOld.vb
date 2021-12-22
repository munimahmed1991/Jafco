Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmTodaysStatusOld
    Dim db As dbOperations
    Dim dr As SqlDataReader


    Private Sub frmTodaysStatus_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)

        txtEntryDate.Value = Today.Date
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
    End Sub

    Sub TodaysStatus()
        Dim cSql As String

        cSql = "Select Sum(1) as Rec From tblReservationMst Where ReservationDate = '" & Format(txtEntryDate.Value, "MM/dd/yyyy") & "' "

        If cmbProject.SelectedValue <> "" Then
            cSql = cSql + "and Project = '" & cmbProject.SelectedValue & "'"
        End If

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            lblBooking.Text = RemoveNull(dr!Rec, 0)
        Else
            lblBooking.Text = "No Booking"
        End If

        db.Close()
        dr.Close()

        cSql = "Select Sum(tblReceiptDtl.ReceiptAmount) as Amount From tblReceiptMst,tblReceiptDtl Where tblReceiptMst.ReceiptDate = '" & Format(txtEntryDate.Value, "MM/dd/yyyy") & "' and tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo and PaymentType = '0001'  and IsNull(tblReceiptMst.Cancel,0) = 0 "

        If cmbProject.SelectedValue <> "" Then
            cSql = cSql + "and Project = '" & cmbProject.SelectedValue & "'"
        End If

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            lblBookingAmount.Text = Format(RemoveNull(dr!Amount, 0), "###,###,##0")
        Else
            lblBookingAmount.Text = "No Recovery Against Booking"
        End If

        db.Close()
        dr.Close()

        cSql = "Select Sum(tblReceiptDtl.ReceiptAmount) as Amount From tblReceiptMst,tblReceiptDtl Where tblReceiptMst.ReceiptDate = '" & Format(txtEntryDate.Value, "MM/dd/yyyy") & "' and tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo and tblReceiptMst.ReceiptType = 'Cash'   and IsNull(tblReceiptMst.Cancel,0) = 0 "

        If cmbProject.SelectedValue <> "" Then
            cSql = cSql + "and Project = '" & cmbProject.SelectedValue & "'"
        End If

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            lblCashRecovery.Text = Format(RemoveNull(dr!Amount, 0), "###,###,##0")
        Else
            lblCashRecovery.Text = "No Cash Recovery"
        End If

        db.Close()
        dr.Close()

        cSql = "Select Sum(tblReceiptDtl.ReceiptAmount) as Amount From tblReceiptMst,tblReceiptDtl Where tblReceiptMst.ReceiptDate = '" & Format(txtEntryDate.Value, "MM/dd/yyyy") & "' and tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo and tblReceiptMst.ReceiptType <> 'Cash'   and IsNull(tblReceiptMst.Cancel,0) = 0 "

        If cmbProject.SelectedValue <> "" Then
            cSql = cSql + "and Project = '" & cmbProject.SelectedValue & "'"
        End If

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            lblChequeRecovery.Text = Format(RemoveNull(dr!Amount, 0), "###,###,##0")
        Else
            lblChequeRecovery.Text = "No Cheque Recovery"
        End If

        db.Close()
        dr.Close()

        cSql = "Select Sum(tblReceiptDtl.ReceiptAmount) as Amount From tblReceiptMst,tblReceiptDtl Where tblReceiptMst.ReceiptDate = '" & Format(txtEntryDate.Value, "MM/dd/yyyy") & "' and tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo and PaymentType <> '0001'   and IsNull(tblReceiptMst.Cancel,0) = 0 "

        If cmbProject.SelectedValue <> "" Then
            cSql = cSql + "and Project = '" & cmbProject.SelectedValue & "'"
        End If

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            lblTotalRecovery.Text = Format(RemoveNull(dr!Amount, 0), "###,###,##0")
        Else
            lblTotalRecovery.Text = "No Recovery"
        End If

        db.Close()
        dr.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Call TodaysStatus()
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Call TodaysStatus()
    End Sub
End Class