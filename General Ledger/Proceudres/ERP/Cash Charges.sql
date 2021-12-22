USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[CashCharges]    Script Date: 4/2/2016 4:30:51 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO











ALTER Procedure [dbo].[CashCharges] @DateFrom DateTime,@DateTo DateTime,@Project Varchar(4),@UnitType Varchar(10),@UnitNumber Varchar(14),@ReportType Varchar(50),@PaymentStatus Varchar(20),@Penalty Numeric(9) = 0 ,@PaymentType Varchar(4) = '',@CustomerType Varchar(50) = 'Both'

as

Set Nocount On

Select	tblInvoice.InvoiceNo,Max(ReceiptDate) as LastReceipt 
Into	#LastReceiptDate
From	tblReceiptMst,tblInvoice,tblReceiptDtl,tblPaymentType
Where	tblReceiptDtl.ReceiptNo = tblReceiptMst.ReceiptNo
And		tblReceiptDtl.InvoiceNo = tblInvoice.InvoiceNo
And		ReceiptAmount <> 0 
And		IsNull(tblReceiptMst.Cancel,0) = 0 
And		tblReceiptDtl.PaymentType = tblPaymentType.Code 
And		Case when IsNull(tblPaymentType.ReceivedAs,'') = '' Then 'Cash' Else tblPaymentType.ReceivedAs End = 'Cash'
Group BY tblInvoice.InvoiceNo

Select	tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,Max(IsNull(Mst.CashAmount,0)) as TotalCharges,0 as DueTillDate,0 as AmountReceived
Into	#Temp1
From	tblReservationMst Mst,tblUnitFile,tblReservationDtl Dtl,tblPaymentType
Where	Mst.Unit = tblUnitFile.Code
And		Mst.ReservationNo = Dtl.ReservationNo
And		IsNull(Mst.Project,'') = @Project
And		IsNull(Dtl.PaymentType,'') = Case When @PaymentType = '' Then IsNull(Dtl.PaymentType,'') Else @PaymentType End
And		Dtl.PaymentType = tblPaymentType.Code 
And		Case when IsNull(tblPaymentType.ReceivedAs,'') = '' Then 'Cash' Else tblPaymentType.ReceivedAs End = 'Cash'
Group BY tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber
Union All
Select	tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,0 as TotalCharges,Sum(Amount) as DueTillDate,0 as AmountReceived
From	tblInvoice Mst Left Outer Join #LastReceiptDate On #LastReceiptDate.InvoiceNo = Mst.InvoiceNo,tblUnitFile,tblReservationMst,tblPaymentType
Where	Mst.Unit = tblUnitFile.Code
And		Mst.InvoiceDate Between @DateFrom and @DateTo 
And		IsNull(Mst.Project,'') = @Project
And		Mst.Unit = tblReservationMst.Unit
And		IsNull(tblreservationmst.cancel,0) = 0 
And		Case when IsNull(tblPaymentType.ReceivedAs,'') = '' Then 'Cash' Else tblPaymentType.ReceivedAs End = 'Cash'
And		Mst.PaymentType = tblPaymentType.Code 
Group By Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType
Union All
Select	tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,0 as TotalCharges,0 as DueTillDate,Sum(Dtl.ReceiptAmount) as AmountReceived
From	tblReceiptMst Mst,tblUnitFile,tblInvoice,tblReservationMst,tblReceiptDtl Dtl,tblPaymentType
Where	Mst.Unit = tblUnitFile.Code
And		Dtl.InvoiceNo = tblInvoice.InvoiceNo
And		Mst.Unit = tblReservationMst.Unit
And		IsNull(tblReservationMst.cancel,0) = 0 
And		Mst.ReceiptNo = Dtl.ReceiptNo
And		Dtl.ReceiptAmount <> 0 
And		Mst.ReceiptDate Between @DateFrom and @DateTo 
And		IsNull(Mst.Project,'') = @Project
And		IsNull(Mst.Cancel,0) = 0 
And		Dtl.PaymentType = tblPaymentType.Code
And		Case when IsNull(tblPaymentType.ReceivedAs,'') = '' Then 'Cash' Else tblPaymentType.ReceivedAs End = 'Cash'
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End
Group By Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType

Select	Project,UnitType,Unit,UnitNumber,
		Sum(TotalCharges) as TotalCharges,
		Sum(DueTillDate) as DueTillDate,
		Sum(AmountReceived) as AmountReceived,
		Sum(DueTillDate) - Sum(AmountReceived) as Balance
Into	#Temp2
From	#Temp1
Group By Project,Unit,UnitNumber,UnitType

Select	Project,UnitType,Unit,UnitNumber,
		TotalCharges,DueTillDate,AmountReceived,Balance
Into	#Temp5
From	#Temp2

Select	tblProjectFile.Name as Project,#Temp5.UnitNumber,#Temp5.Unit,
		Sum(#Temp5.TotalCharges) as TotalCharges,Sum(#Temp5.DueTillDate) as DueTillDate,Sum(#Temp5.AmountReceived) as AmountReceived,Sum(#Temp5.Balance) as Balance
Into	#Temp6
From	#Temp5,tblUnitFile,tblProjectFile
Where	#Temp5.Unit = tblUnitFile.Code
And		IsNull(tblUnitFile.Cancel,0) = 0 
And		#Temp5.Project = tblProjectFile.Code 
GRoup By #Temp5.Project,#Temp5.UnitType,#Temp5.Unit,#Temp5.UnitNumber,tblProjectFile.Name

Select	Max(ReceiptDate) as ReceiptDate,Unit 
Into	#LastReceipt
from	tblReceiptMst,tblReceiptDtl,tblPaymentType
Where	tblReceiptDtl.ReceiptNo = tblReceiptMst.ReceiptNo
And		tblReceiptDtl.PaymentType = tblPaymentType.Code 
And		Case when IsNull(tblPaymentType.ReceivedAs,'') = '' Then 'Cash' Else tblPaymentType.ReceivedAs End = 'Cash'
Group By Unit

Select	Unit,Max(EntryNo) as EntryNo 
Into	#LastLetter1
From	tblLetters
Where	EntryDate <= @DateTo
And		Substring(tblLetters.LetterType,1,11) <> 'Due Service' and Substring(tblLetters.LetterType,1,4) <> 'HBFC'
Group By Unit

Select	#LastLetter1.*,tblLetters.LetterType 
Into	#LastLetter
From	#LastLetter1,tblLetters 
Where	#LastLetter1.EntryNo = tblLetters.EntryNo


if @ReportType = 'Report' 
	Begin
		Select #Temp6.*,#LastLetter.LetterType From #Temp6 Left Outer Join #LastLetter On #LastLetter.Unit = #Temp6.Unit 
	ENd

if @ReportType = 'Grid'
	Begin
		Select	*
		From	#Temp6  Left Outer Join #LastLetter On #LastLetter.Unit = #Temp6.Unit
	End

Set Nocount Off











GO


