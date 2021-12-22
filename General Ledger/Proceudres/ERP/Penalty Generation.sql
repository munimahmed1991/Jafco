USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[PenaltyGeneration]    Script Date: 4/2/2016 4:32:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


ALTER Procedure [dbo].[PenaltyGeneration] @DateTo DateTime,@Project Varchar(4),@UnitType Varchar(4),@Unit Varchar(12)

as

Set Nocount On 

Select	InvoiceNo,DateAdd(Day,IsNull(tblReservationMst.CreditDays,0),InvoiceDate) as InvoiceDate,tblInvoice.Unit,IsNull(PaymentType,'') as PaymentType,IsNull(tblInvoice.ExtraCharges,'') as ExtraCharges,Amount as InvoiceAmount,0 as ReceiptAmount,Installment
Into	#Temp2
From	tblInvoice,tblReservationMst,tblProjectFile
Where	InvoiceDate <= @DateTo
And		tblInvoice.Unit = tblReservationMst.Unit
And		IsNull(tblReservationMst.Cancel,0) = 0 
And		tblInvoice.Project = tblProjectFile.Code 
And		IsNull(tblInvoice.Penalty,0) = Case When IsNull(tblProjectFile.PenaltyPolicy,'Normal') = 'Normal' Then 0 Else IsNull(tblInvoice.Penalty,0) End 
Union All
Select	InvoiceNo,Null InvoiceDate,Unit,IsNull(PaymentType,'') as PaymentType,IsNull(ExtraCharges,'') as ExtraCharges,0 as InvoiceAmount,ReceiptAmount,Installment
From	tblReceiptDtl Dtl,tblReceiptMst Mst
Where	Mst.ReceiptNo = Dtl.ReceiptNo
And		Mst.ReceiptDate <= @DateTo 
And		IsNull(Mst.Cancel,0) = 0 

Select	Unit,Sum(InvoiceAmount) as InvoiceAmount,Sum(ReceiptAmount) as ReceiptAmount,Sum(InvoiceAmount) - Sum(ReceiptAmount) as BalanceAmount 
Into	#Temp1
From	#Temp2
Group BY Unit
Having	Sum(InvoiceAmount) - Sum(ReceiptAmount) > 0 

Select	Project,Customer,Customer2,UnitType,tblDefaults.MarkupPaymentType as PaymentType,#Temp1.Unit,Sum(BalanceAmount) BalanceAmount,Case When IsNull(tblProjectFile.PenaltyPer,0) <> 0 Then ((Sum(BalanceAmount) * Case When IsNull(tblReservationMst.PenaltyPer,0) > 0 Then IsNull(tblReservationMst.PenaltyPer,0) Else IsNull(tblProjectFile.PenaltyPer,0) End / 100)) Else 0 End as Penalty
From	#Temp1,tblDefaults,tblReservationMst,tblProjectFile
Where	tblDefaults.CompanyId = '0001'
And		#Temp1.Unit = tblReservationMst.Unit
And		tblReservationMst.Project = Case When @Project = '' Then tblReservationMst.Project Else @Project End 
And		tblReservationMst.UnitType = Case When @UnitType = '' Then tblReservationMst.UnitType Else @UnitType End 
And		tblReservationMst.Unit = Case When @Unit = '' Then tblReservationMst.Unit Else @Unit End 
And		IsNull(tblReservationMst.Cancel,0) = 0 
And		tblReservationMst.Project = tblProjectFile.Code 
Group By #Temp1.Unit,MarkupRateMonth,Project,Customer,Customer2,UnitType,tblDefaults.MarkupPaymentType,tblProjectFile.PenaltyPer
Having Sum(BalanceAmount) > 0

Set Nocount Off


GO


