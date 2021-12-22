Imports System
Imports System.Data
Imports System.Data.SqlClient

Public Class frmCheckOfficial
    Public cUnit As String


    Private Sub frmCheckOfficial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
    End Sub

    Sub FillData()
        txtCashAmount.Value = 0
        txtCashAmountBalanced.Value = 0
        txtCashAmountCollected.Value = 0

        txtServiceAmount.Value = 0
        txtServiceAmountBalance.Value = 0
        txtServiceAmountCollected.Value = 0

        Dim cSql As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        cSql = "Select	Sum(ReceiptAmount) as ReceiptAmount,Max(tblReservationMst.OfficialCash) as OfficialCash "
        cSql = cSql + "From tblReceiptDtl, tblPaymentType, tblReceiptMst, tblReservationMst "
        cSql = cSql + "where tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo "
        cSql = cSql + "And		tblReceiptDtl.PaymentType = tblPaymentType.Code "
        cSql = cSql + "And		tblReceiptMst.Unit = '" & cUnit & "' "
        cSql = cSql + "And		Case When IsNull(ReceivedAs,'') = '' Then 'Cash' Else ReceivedAs End <> 'Utilities' "
        cSql = cSql + "And		IsNull(UnOfficial,0) = 0  and IsNull(tblReceiptMst.Cancel,0) = 0 and IsNull(tblReservationMst.Cancel,0) = 0 "
        cSql = cSql + "And		tblReceiptMst.Unit = tblReservationMst.Unit "

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            txtCashAmount.Value = RemoveNull(dr!OfficialCash, 0)
            txtCashAmountCollected.Value = RemoveNull(dr!ReceiptAmount, 0)
            txtCashAmountBalanced.Value = txtCashAmount.Value - txtCashAmountCollected.Value
        End If

        db.Close()
        dr.Close()

        cSql = "Select	Sum(ReceiptAmount) as ReceiptAmount,Max(tblReservationMst.AddOtherCharges * (OfficialService / 100)) as OfficialCash "
        cSql = cSql + "From tblReceiptDtl, tblPaymentType, tblReceiptMst, tblReservationMst "
        cSql = cSql + "where tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo "
        cSql = cSql + "And		tblReceiptDtl.PaymentType = tblPaymentType.Code "
        cSql = cSql + "And		tblReceiptMst.Unit = '" & cUnit & "' "
        cSql = cSql + "And		Case When IsNull(ReceivedAs,'') = '' Then 'Cash' Else ReceivedAs End = 'Utilities' "
        cSql = cSql + "And		IsNull(UnOfficial,0) = 0  and IsNull(tblReceiptMst.Cancel,0) = 0  and IsNull(tblReservationMst.Cancel,0) = 0 "
        cSql = cSql + "And		tblReceiptMst.Unit = tblReservationMst.Unit "

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()

            txtServiceAmount.Value = RemoveNull(dr!OfficialCash, 0)
            txtServiceAmountCollected.Value = RemoveNull(dr!ReceiptAmount, 0)
            txtServiceAmountBalance.Value = txtServiceAmount.Value - txtServiceAmountCollected.Value
        End If

        db.Close()
        dr.Close()
    End Sub
End Class