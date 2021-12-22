USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[DemandNotice]    Script Date: 4/2/2016 4:31:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





ALTER Procedure [dbo].[DemandNotice] @DaysFrom Numeric(9),@DaysTo Numeric(9),@Project Varchar(4),@LetterType Varchar(50),@GenerateDate DateTime,@Penalty Numeric(9) = 0 

as

Set Nocount On 

Select	InvoiceNo,InvoiceDate,Unit,tblPaymentType.Name as PaymentType,Amount as InvoiceAmount,0 as ReceiptAmount,Installment
Into	#TempRecovery
From	tblInvoice,tblPaymentType
Where	tblInvoice.PaymentType = tblPaymentType.Code 
And		tblInvoice.InvoiceDate <= @GenerateDate 
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
Union All 
Select	tblReceiptDtl.InvoiceNo,tblInvoice.InvoiceDate,tblReceiptMst.Unit,tblPaymentType.Name as PaymentType,0 as Amount,ReceiptAmount,tblReceiptDtl.Installment
From	tblReceiptMst,tblReceiptDtl,tblInvoice,tblPaymentType
Where	tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo
And		tblReceiptDtl.InvoiceNo = tblInvoice.InvoiceNo
And		tblPaymentType.Code = tblReceiptDtl.PaymentType
And		tblReceiptDtl.ReceiptAmount > 0
And		tblReceiptMst.ReceiptDate <= @GenerateDate 
And		IsNull(tblReceiptMst.Cancel,0) = 0 
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End

Select	#TempRecovery.InvoiceNo,Max(#TempRecovery.InvoiceDate) as InvoiceDate,DateDiff(Day,Max(#TempRecovery.InvoiceDate),@GenerateDate) as Days,#TempRecovery.Unit,#TempRecovery.PaymentType,
		Sum(#TempRecovery.InvoiceAmount) as InvoiceAmount,Sum(#TempRecovery.ReceiptAmount) as ReceiptAmount,Sum(#TempRecovery.InvoiceAmount) - Sum(#TempRecovery.ReceiptAmount) as Balance
Into	Temp1
From	#TempRecovery,tblInvoice
Where	#TempRecovery.InvoiceNo = tblInvoice.InvoiceNo 
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
And		tblInvoice.InvoiceDate <= @GenerateDate
Group By #TempRecovery.InvoiceNo,#TempRecovery.Unit,#TempRecovery.PaymentType
Having Sum(#TempRecovery.InvoiceAmount) - Sum(#TempRecovery.ReceiptAmount) > 0 

Select	Unit,Max(Days) as Days
Into	#Temp2
From	#Temp1
Group By Unit
Having Max(Days) > @DaysFrom and Max(Days) <= @DaysTo

Select	InvoiceNo,Max(InvoiceDate) as InvoiceDate,DateDiff(Day,Max(InvoiceDate),@GenerateDate) as Days,#Temp1.Unit,#Temp1.PaymentType,
		Sum(InvoiceAmount) as InvoiceAmount,Sum(ReceiptAmount) as ReceiptAmount,Sum(InvoiceAmount) - Sum(ReceiptAmount) as Balance
Into	#Temp3
From	#Temp1,#Temp2
Where	#Temp1.Unit = #Temp2.Unit
Group By InvoiceNo,#Temp1.Unit,PaymentType
Having Sum(InvoiceAmount) - Sum(ReceiptAmount) > 0 

Select	0 as Generate,@GenerateDate as GenerateDate,
		tblReservationMst.Unit,tblUnitFile.UnitNumber,
		tblReservationMst.Customer,tblReservationMst.Customer2,tblCustomer.Name as CustomerName,tblCustomer.Mobile,tblCustomer.TelRes,tblCustomer.Address,
		tblReservationMst.UnitType,tblUnitType.Name as UnitTypeName,tblScheme.Name as Scheme,
		Sum(Case When Days > @DaysFrom and Days < @DaysTo Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
		Sum(InvoiceAmount) - Sum(ReceiptAmount) as TotalBalance,tblReservationMst.Project,tblProjectFile.Name as ProjectName
From	#Temp3,tblReservationMst Left Outer Join tblScheme On tblScheme.Code = tblReservationMst.Scheme,tblUnitFile,tblCustomer,tblUnitType,tblProjectFile
Where	#Temp3.Unit = tblReservationmst.Unit
And		#Temp3.Unit = tblUnitFile.Code
And		tblCustomer.Code = tblReservationMst.Customer
And		tblUnitFile.UnitType = tblUnitType.Code
And		tblReservationMst.Project = Case When @Project = '' Then tblReservationMst.Project Else @Project End 
And		tblReservationMst.Project = tblProjectFile.Code 
And		IsNull(tblReservationMst.Cancel,0) = 0 
And		IsNull(tblReservationMst.NonActive,0) = 0 
And		tblReservationMst.Unit Not In (Select Unit From tblLetters Where Cast(DatePart(Month,@GenerateDate) as Varchar(2)) + '-' + Cast(DatePart(Year,@GenerateDate) as Varchar(4))  = Cast(DatePart(Month,EntryDate) as Varchar(2)) + '-' + Cast(DatePart(Year,EntryDate) as Varchar(4)))
And		InvoiceDate <= @GenerateDate
GRoup By tblReservationMst.Unit,tblUnitFile.UnitNumber,
		 tblReservationMst.Customer,tblReservationMst.Customer2,tblCustomer.Name,tblCustomer.Mobile,tblCustomer.TelRes,tblCustomer.Address,
		 tblReservationMst.UnitType,tblUnitType.Name,tblScheme.Name,tblReservationMst.Project,tblProjectFile.Name
		
Set Nocount Off






GO


