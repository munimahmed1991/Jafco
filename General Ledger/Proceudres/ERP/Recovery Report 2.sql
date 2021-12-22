USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[RecoveryReport2]    Script Date: 4/2/2016 4:33:48 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





ALTER Procedure [dbo].[RecoveryReport2] @DateFrom DateTime,@DateTo DateTime,@Project Varchar(4),@UnitType Varchar(10),@UnitNumber Varchar(14),@ReportType Varchar(50),@PaymentStatus Varchar(20),@Penalty Numeric(9) = 0 ,@PaymentType Varchar(4) = ''

as

Set Nocount On

Select	tblInvoice.InvoiceNo,Max(ReceiptDate) as LastReceipt 
Into	#LastReceiptDate
From	tblReceiptMst,tblInvoice,tblReceiptDtl
Where	tblReceiptDtl.ReceiptNo = tblReceiptMst.ReceiptNo
And		tblReceiptDtl.InvoiceNo = tblInvoice.InvoiceNo
And		ReceiptAmount <> 0 
And		IsNull(tblReceiptMst.Cancel,0) = 0 
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End
Group BY tblInvoice.InvoiceNo

Select	tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,Max(IsNull(Mst.CashAmount,0)) as CashAmount,Max(IsNull(Mst.ExtraCharges,0)) as ExtraCharges,Max(IsNull(Mst.LoanAmount,0)) as LoanAmount,0 as DueTillDate,0 as AmountReceived,0 as AmountReceivedLoan,0 as Ontime,0 as Late,0 as TotalPayment,MAX(IsNull(Discount,0)) as Discount
Into	#Temp1
From	tblReservationMst Mst,tblUnitFile,tblReservationDtl Dtl
Where	Mst.Unit = tblUnitFile.Code
And		Mst.ReservationNo = Dtl.ReservationNo
And		IsNull(Mst.Project,'') = @Project
And		IsNull(Dtl.PaymentType,'') = Case When @PaymentType = '' Then IsNull(Dtl.PaymentType,'') Else @PaymentType End
Group BY tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber
Union All
Select	tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,0 as CashAmount,0 as ExtraCharges,0 as LoanAmount,Sum(Amount) as DueTillDate,0 as AmountReceived,0 as AmountReceivedLoan,Sum(Case When DateAdd(Day,IsNull(tblReservationMst.CreditDays,0),Mst.InvoiceDate) >= IsNull(#LastReceiptDate.LastReceipt,GetDate()) Then 1 Else 0 End) as OnTime,Sum(Case When DateAdd(Day,IsNull(tblReservationMst.CreditDays,0),Mst.InvoiceDate) < IsNull(#LastReceiptDate.LastReceipt,GetDate()) Then 1 Else 0 End) as Late,Sum(1) as TotalPayment,0 as Discount
From	tblInvoice Mst Left Outer Join #LastReceiptDate On #LastReceiptDate.InvoiceNo = Mst.InvoiceNo,tblUnitFile,tblReservationMst
Where	Mst.Unit = tblUnitFile.Code
And		Mst.InvoiceDate <= @DateTo 
And		IsNull(Mst.Project,'') = @Project
And		Mst.Unit = tblReservationMst.Unit
And		IsNull(tblreservationmst.cancel,0) = 0 
And		Isnull(Mst.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(Mst.Penalty,0) End
And		IsNull(Mst.PaymentType,'') = Case When @PaymentType = '' Then IsNull(Mst.PaymentType,'') Else @PaymentType End
Group By Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType
Union All
Select	tblUnitFile.UnitType,Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,0 as CashAmount,0 as ExtraCharges,0 as LoanAmount,0 as DueTillDate,Sum(Case When IsNull(tblPaymentType.ReceivedAs,'Cash') <> 'Loan' Then Dtl.ReceiptAmount Else 0 End) as AmountReceived,Sum(Case When IsNull(tblPaymentType.ReceivedAs,'Cash') = 'Loan' Then Dtl.ReceiptAmount Else 0 End) as AmountReceivedLoan,0 as OnTime,0 as Late,0 as TotalPayment,0 as Discount
From	tblReceiptMst Mst,tblUnitFile,tblInvoice,tblReservationMst,tblReceiptDtl Dtl,tblPaymentType
Where	Mst.Unit = tblUnitFile.Code
And		Dtl.InvoiceNo = tblInvoice.InvoiceNo
And		Mst.Unit = tblReservationMst.Unit
And		IsNull(tblReservationMst.cancel,0) = 0 
And		Mst.ReceiptNo = Dtl.ReceiptNo
And		Dtl.ReceiptAmount <> 0 
And		Mst.ReceiptDate <= @DateTo
And		IsNull(Mst.Project,'') = @Project
And		IsNull(Mst.Cancel,0) = 0 
And		Dtl.PaymentType = tblPaymentType.Code
--And		tblUnitFile.UnitNumber = '12A-1'
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End
Group By Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType

Select	Project,UnitType,Unit,UnitNumber,
		Sum(CashAmount) as CashAmount,Sum(ExtraCharges) as ExtraCharges,Sum(LoanAmount) as LoanAmount,Sum(DueTillDate) as DueTillDate,Sum(AmountReceived) as AmountReceived,Sum(AmountReceivedLoan) as AmountReceivedLoan,
		Sum(DueTillDate) - Sum(AmountReceived) - Sum(AmountReceivedLoan) as BalanceTillDate,Max(OnTime) as OnTime,Max(Late) as Late,Max(TotalPayment) as TotalPayment,MAX(Discount) as Discount
Into	#Temp2
From	#Temp1
Group By Project,Unit,UnitNumber,UnitType

Select	Mst.Project,tblUnitFile.UnitType,Mst.Unit,tblUnitFile.UnitNumber,Sum(Amount) as DueforThePeriod,0 as ReceivedForThePeriod
Into	#Temp3
From	tblInvoice Mst,tblUnitFile
Where	Mst.Unit = tblUnitFile.Code
And		Mst.InvoiceDate Between @DateFrom and @DateTo
And		IsNull(Mst.Project,'') = @Project
And		Isnull(Mst.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(Mst.Penalty,0) End
And		IsNull(Mst.PaymentType,'') = Case When @PaymentType = '' Then IsNull(Mst.PaymentType,'') Else @PaymentType End
Group By Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType
Union All
Select	Mst.Project,tblUnitFile.UnitType,Mst.Unit,tblUnitFile.UnitNumber,0 as DueforThePeriod,Sum(ReceiptAmount) as ReceivedForThePeriod
From	tblReceiptMst Mst,tblReceiptDtl Dtl,tblUnitFile,tblInvoice,tblReservationMst
Where	Mst.Unit = tblUnitFile.Code
And		Mst.ReceiptNo = Dtl.ReceiptNo
And		Dtl.InvoiceNo = tblInvoice.InvoiceNo
And		Mst.ReceiptDate Between @DateFrom and @DateTo
And		IsNull(Mst.Project,'') = @Project
And		IsNull(Mst.Cancel,0) = 0 
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End
And		IsNull(tblReservationMst.Cancel,0) = 0 
And		Mst.Unit = tblReservationMst.Unit
Group By Mst.Project,Mst.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType

Select	Project,UnitType,Unit,UnitNumber,Sum(DueforthePeriod) as DueForThePeriod,Sum(ReceivedForThePeriod) as ReceivedForThePeriod,Sum(DueforThePeriod) - Sum(ReceivedForThePeriod) as BalanceforThePeriod
Into	#Temp4
From	#Temp3
GRoup By Project,UnitType,Unit,UnitNumber

Select	Project,UnitType,Unit,UnitNumber,
		CashAmount,LoanAmount,Discount,ExtraCharges,DueTillDate,AmountReceived,AmountReceivedLoan,BalanceTillDate,
		0 as DueForThePeriod,0 as ReceivedForThePeriod,0 as BalanceforThePeriod,OnTime,Late,TotalPayment
Into	#Temp5
From	#Temp2
Union All
Select	Project,UnitType,Unit,UnitNumber,
		0 as CashAmount,0 as LoanAmount,0 as Discount,0 as ExtraCharges,0 as DueTillDate,0 as AmountReceived,0 as AmountReceivedLoan,0 as BalanceTillDate,
		DueForThePeriod,ReceivedForThePeriod,BalanceforThePeriod,0 as OnTime,0 as Late,0 as TotalPayment
From	#Temp4

Select	#Temp5.Project,#Temp5.UnitType,#Temp5.Unit,#Temp5.UnitNumber,
		Sum(#Temp5.CashAmount) as CashAmount,Sum(Discount) as Discount,Sum(ExtraCharges) as ExtraCharges,Sum(#Temp5.LoanAmount) as LoanAmount,Sum(#Temp5.DueTillDate) as DueTillDate,Sum(#Temp5.AmountReceived) as AmountReceived,Sum(#Temp5.AmountReceivedLoan) as AmountReceivedLoan,Sum(#Temp5.BalanceTillDate) as BalanceTillDate,
		Sum(#Temp5.DueForThePeriod) as DueForThePeriod,Sum(#Temp5.ReceivedForThePeriod) as ReceivedForThePeriod,Sum(#Temp5.BalanceforThePeriod) as BalanceForThePeriod,
		Max(Cast(OnTime as Numeric(9,2))) as OnTime,Max(Cast(Late as Numeric(9,2))) as Late
Into	#Temp6
From	#Temp5,tblUnitFile
Where	#Temp5.Unit = tblUnitFile.Code
And		IsNull(tblUnitFile.Cancel,0) = 0 
GRoup By #Temp5.Project,#Temp5.UnitType,#Temp5.Unit,#Temp5.UnitNumber

Select	Max(ReceiptDate) as ReceiptDate,Unit 
Into	#LastReceipt
from	tblReceiptMst
Group By Unit

Select	UnitType,tblUnitType.Name as UnitTypeName,UnitNumber,ReceiptDate as LastReceiptDate,
		#Temp6.CashAmount,Case When @PaymentType = '' Then #Temp6.LoanAmount Else 0 End as LoanAmount,#Temp6.ExtraCharges,DueTillDate,AmountReceived as AmountReceivedCash,AmountReceivedLoan,BalanceTillDate,
		Case When AmountReceived > 0 and #Temp6.CashAmount > 0 Then (#Temp6.AmountReceived / #Temp6.CashAmount) * 100 Else 0 End as RecoveryPerCash,
		Case When IsNull(#Temp6.LoanAmount,0) > 0 and IsNull(#Temp6.AmountReceivedLoan,0) > 0 Then (#Temp6.AmountReceivedLoan / #Temp6.LoanAmount) * 100 else 0 End As RecoverPerLoan,
		DueforthePeriod,ReceivedForThePeriod,BalanceForThePeriod,Case When ReceivedForThePeriod > 0 and DueforthePeriod > 0 Then (ReceivedForThePeriod / DueforthePeriod) * 100 Else 0 End as RecoveryPerPeriod,
		OnTime,Late,Case When IsNull(OnTime,0) > 0 Then Round((OnTime / (OnTime + Late)) * 100,0) Else 0 End as OnTimePer,Discount
Into	#Temp8
From	#Temp6 Left Outer Join #LastReceipt On #LastReceipt.Unit = #Temp6.Unit,tblUnitType
Where	#Temp6.UnitType = tblUnitType.Code
And		#Temp6.Project = @Project
And		#Temp6.UnitType = Case When @UnitType <> '' Then @UnitType Else #Temp6.UnitType End
And		#Temp6.Unit = Case When @UnitNumber <> '' Then @UnitNumber Else #Temp6.Unit End

Select *,Case When OnTimePer >= 80 Then 'Excellent' Else Case When OnTimePer >= 60 and OnTimePer < 80 Then 'Good' Else 'Poor' End End as PaymentStatus,RecoveryPerCash + RecoverPerLoan as RecoverPer,AmountReceivedCash + AmountReceivedLoan as AmountReceived Into #Temp7 From #Temp8 

if @ReportType = 'Report' 
	Begin
		Select * From #Temp7 Where PaymentStatus = Case When @PaymentStatus <> 'All' Then @PaymentStatus Else PaymentStatus End Order BY UnitType
	ENd

if @ReportType = 'Grid'
	Begin
		Select	UnitTypeName,UnitNumber,LastReceiptDate,
				CashAmount - ExtraCharges as CashAmount,Case When @PaymentType = '' Then LoanAmount Else 0 End as LoanAmount,ExtraCharges,DueTillDate,AmountReceivedCash,AmountReceivedLoan,BalanceTillDate,RecoveryPerCash,RecoverPerLoan,RecoverPer,
				DueforthePeriod,ReceivedForThePeriod,BalanceForThePeriod,RecoveryPerPeriod,
				OnTime,Late,Case When OnTimePer >= 80 Then 'Excellent' Else Case When OnTimePer >= 60 and OnTimePer < 80 Then 'Good' Else 'Poor' End End as PaymentStatus
		From	#Temp7
		Order By UnitType
	End

Set Nocount Off



GO


