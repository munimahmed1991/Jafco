USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[TodaysStatus]    Script Date: 4/2/2016 4:33:59 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER Procedure [dbo].[TodaysStatus] @Date DateTime,@DateTo DateTime,@Project Varchar(4)

as

Set Nocount On 

Select	Project,Sum(1) as Booking,0 as BookingAmount,0 as CashAmount,0 as ChequeAmount
Into	#temp1
From	tblReservationMst 
Where	ReservationDate Between @Date and @DateTo 
And		Project = Case When @Project = '' Then Project Else @Project End 
And		IsNull(tblreservationMst.Cancel,0)  = 0 
Group By Project
Union All
Select	tblReceiptMst.Project,0 as Booking,Sum(tblReceiptDtl.ReceiptAmount) as BookingAmount,0 as CashAmount,0 as ChequeAmount 
From	tblReceiptMst,tblReceiptDtl,tblReservationMst 
Where	tblReceiptMst.ReceiptDate Between @Date and @DateTo 
And		tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo 
And		PaymentType = '0001'  
And		tblReceiptMst.Unit = tblReservationMst.Unit 
And		tblReceiptMst.Project = Case When @Project = '' Then tblReceiptMst.Project Else @Project End 
And		IsNull(tblReceiptMst.Cancel,0) = 0
And		ISNULL(tblReservationMst.Cancel,0) = 0 
And		tblReceiptMst.ReceiptType <> 'Transfer'
Group By tblReceiptMst.Project
Union All
Select	tblReceiptMst.Project,0 as Booking,0 as BookingAmount,Sum(tblReceiptDtl.ReceiptAmount) as CashAmount,0 as ChequeAmount 
From	tblReceiptMst,tblReceiptDtl,tblReservationMst  
Where	tblReceiptMst.ReceiptDate Between @Date and @DateTo
and		tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo 
and		tblReceiptMst.ReceiptType = 'Cash'   
And		tblReceiptMst.Project = Case When @Project = '' Then tblReceiptMst.Project Else @Project End 
And		ISNULL(tblReservationMst.Cancel,0) = 0 
and		IsNull(tblReceiptMst.Cancel,0) = 0 
And		tblReceiptMst.Unit = tblReservationMst.Unit 
Group By tblReceiptMst.Project
Union All
Select	tblReceiptMst.Project,0 as Booking,0 as BookingAmount,0 as CashAmount,Sum(tblReceiptDtl.ReceiptAmount) as ChequeAmount 
From	tblReceiptMst,tblReceiptDtl,tblReservationMst 
Where	tblReceiptMst.ReceiptDate Between @Date and @DateTo
and		tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo 
and		tblReceiptMst.ReceiptType <> 'Cash'   
and		IsNull(tblReceiptMst.Cancel,0) = 0
And		tblReceiptMst.ReceiptType <> 'Transfer'
And		tblReceiptMst.Project = Case When @Project = '' Then tblReceiptMst.Project Else @Project End 
And		ISNULL(tblReservationMst.Cancel,0) = 0 
And		tblReceiptMst.Unit = tblReservationMst.Unit 
Group By tblReceiptMst.Project

Select	'Total Recovery : ' as TotalRecovery,tblProjectFile.Name as Project,
		Sum(Booking) as Booking,
		Sum(BookingAmount) as BookingAmount,
		Sum(CashAmount) as CashAmount,
		Sum(ChequeAmount) as ChequeAmount,
		Sum(CashAmount + ChequeAmount) as TotalAmount
From	#temp1,tblProjectFile
Where	#temp1.Project = tblProjectFile.Code
Group By tblProjectFile.Name

Set Nocount Off




GO


