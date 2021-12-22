USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[CustomerStatement]    Script Date: 4/2/2016 4:31:22 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER Procedure [dbo].[CustomerStatement] @DateTo DateTime,@Project Varchar(4),@UnitType Varchar(10),@Unit Varchar(12),@ReportType Varchar(20) = 'All',@Penalty NUmeric(9) = 0,@PaymentType Varchar(4) = ''

as

Set Nocount On 

Select	Customer1.Name as CustomerName1,Customer1.Address as Address1,Customer1.TelRes as TelRes1,Customer1.Mobile as Mobile1,
		Customer2.Name as CustomerName2,Customer2.Address as Address2,Customer2.TelRes as TelRes2,Customer2.Mobile as Mobile2,
		tblReservationmst.Unit,tblUnitFile.UnitNumber,tblUnitType.Name as UnitType,Case When tblUnitType.SqYards > 0 Then Cast(tblUnitType.SqYards as Varchar(4)) + ' Sq Yards' Else Cast(tblUnitType.SqFeet as Varchar(4)) + ' Sq Ft' End as SqYards, tblBlock.Name as Block,
		tblReservationMst.CashAmount,tblReservationMst.LoanAmount,tblReservationMst.ExtraCharges,tblReservationMst.Discount,tblReservationMst.AddOtherCharges,tblReservationMst.TotalRevenue,
		tblReservationMst.Project,tblProjectFile.Name as ProjectName,tblReservationMst.ExtraLandCharges,tblReservationMst.ExtraSqFeetYds,tblReservationMst.PerSqFeetCharges,IsNull(tblReservationMst.ApplyExtraLand,0) as ApplyExtraLand
Into	#Temp1
From	tblReservationMst Left Outer Join tblCustomer Customer2 On Customer2.Code = tblReservationMst.Customer2,tblCustomer Customer1,tblUnitFile,tblUnitType,tblBlock,tblProjectFile
Where	tblReservationMst.Unit = tblUnitFile.Code
And		tblUnitFile.UnitType = tblUnitType.Code
And		tblUnitFile.Block = tblBlock.Code
And		tblReservationMst.Customer = Customer1.Code 
And		tblReservationMst.Project = tblProjectFile.Code
And		tblReservationMst.Project = Case When @Project = '' Then tblReservationMst.Project Else @Project End
And		tblReservationmst.Unit = Case When @Unit = '' Then tblReservationMst.Unit Else @Unit End
And		tblUnitFile.UnitType = Case When @UnitType = '' Then tblUnitFile.UnitType Else @UnitType End 
And		IsNull(tblReservationMst.Cancel,0) = 0 

Select	InvoiceNo,InvoiceDate,Unit,tblPaymentType.Name as PaymentType,Amount,0 as ReceiptAmount,0 as PDCAmount,Installment
Into	#Temp2
From	tblInvoice,tblPaymentType
Where	tblInvoice.PaymentType = tblPaymentType.Code 
And		tblInvoice.InvoiceDate <= @DateTo
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End
Union All 
Select	tblReceiptDtl.InvoiceNo,tblInvoice.InvoiceDate,tblReceiptMst.Unit,tblPaymentType.Name as PaymentType,0 as Amount,Case WHen IsNull(PDC,0) = 0 Then ReceiptAmount Else 0 End as ReceiptAmount,Case When IsNull(PDC,0) = 1 Then ReceiptAmount Else 0 End as PDCAmount,tblReceiptDtl.Installment
From	tblReceiptMst,tblReceiptDtl,tblInvoice,tblPaymentType
Where	tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo
And		tblReceiptDtl.InvoiceNo = tblInvoice.InvoiceNo
And		tblPaymentType.Code = tblReceiptDtl.PaymentType
And		tblReceiptDtl.ReceiptAmount > 0
And		tblReceiptMst.ReceiptDate <= @DateTo
And		IsNull(tblReceiptMst.Cancel,0) = 0 
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End

if @ReportType = 'All' 
	Begin
		Select	#Temp1.CustomerName1,#Temp1.Address1,#Temp1.TelRes1,#Temp1.Mobile1,
				#Temp1.CustomerName2,#Temp1.Address2,#Temp1.TelRes2,#Temp1.Mobile2,
				#Temp1.Project,#Temp1.ProjectName,#Temp1.UnitNumber,#Temp1.UnitType,#Temp1.SqYards,#Temp1.Block,
				#Temp1.ExtraLandCharges,#Temp1.ExtraSqFeetYds,#Temp1.PerSqFeetCharges,#Temp1.ApplyExtraLand,
				#Temp1.CashAmount,#Temp1.LoanAmount,#Temp1.ExtraCharges,#Temp1.Discount,#Temp1.AddOtherCharges,#Temp1.TotalRevenue,
				#Temp2.InvoiceNo,#Temp2.InvoiceDate,#Temp2.PaymentType,Sum(Amount) as InvoiceAmount,Sum(ReceiptAmount) as ReceiptAmount,Sum(PDCAmount) as PDCAmount,Sum(Amount) - Sum(ReceiptAmount) as Balance
		From	#Temp1 Left Outer Join #Temp2 On #Temp1.Unit = #Temp2.Unit		
		Group By #Temp1.CustomerName1,#Temp1.Address1,#Temp1.TelRes1,#Temp1.Mobile1,
				#Temp1.CustomerName2,#Temp1.Address2,#Temp1.TelRes2,#Temp1.Mobile2,
				#Temp1.Project,#Temp1.ProjectName,#Temp1.UnitNumber,#Temp1.UnitType,#Temp1.SqYards,#Temp1.Block,
				#Temp1.CashAmount,#Temp1.LoanAmount,#Temp1.ExtraCharges,#Temp1.Discount,#Temp1.AddOtherCharges,#Temp1.TotalRevenue,
				#Temp2.InvoiceNo,#Temp2.InvoiceDate,#Temp2.PaymentType,
				#Temp1.ExtraLandCharges,#Temp1.ExtraSqFeetYds,#Temp1.PerSqFeetCharges,#Temp1.ApplyExtraLand
		Order By #Temp1.UnitNumber,InvoiceDate
	End

if @ReportType = 'Pending' 
	Begin
		Select	#Temp1.CustomerName1,#Temp1.Address1,#Temp1.TelRes1,#Temp1.Mobile1,
				#Temp1.CustomerName2,#Temp1.Address2,#Temp1.TelRes2,#Temp1.Mobile2,
				#Temp1.Project,#Temp1.ProjectName,#Temp1.UnitNumber,#Temp1.UnitType,#Temp1.SqYards,#Temp1.Block,
				#Temp1.CashAmount,#Temp1.LoanAmount,#Temp1.ExtraCharges,#Temp1.Discount,#Temp1.AddOtherCharges,#Temp1.TotalRevenue,
				#Temp2.InvoiceNo,#Temp2.InvoiceDate,#Temp2.PaymentType,Sum(Amount) as InvoiceAmount,Sum(ReceiptAmount) as ReceiptAmount,Sum(PDCAmount) as PDCAmount,Sum(Amount) - Sum(ReceiptAmount) as Balance,
				#Temp1.ExtraLandCharges,#Temp1.ExtraSqFeetYds,#Temp1.PerSqFeetCharges,#Temp1.ApplyExtraLand
		From	#Temp1 Left Outer Join #Temp2 On #Temp1.Unit = #Temp2.Unit		
		Group By #Temp1.CustomerName1,#Temp1.Address1,#Temp1.TelRes1,#Temp1.Mobile1,
				#Temp1.CustomerName2,#Temp1.Address2,#Temp1.TelRes2,#Temp1.Mobile2,
				#Temp1.Project,#Temp1.ProjectName,#Temp1.UnitNumber,#Temp1.UnitType,#Temp1.SqYards,#Temp1.Block,
				#Temp1.CashAmount,#Temp1.LoanAmount,#Temp1.ExtraCharges,#Temp1.Discount,#Temp1.AddOtherCharges,#Temp1.TotalRevenue,
				#Temp2.InvoiceNo,#Temp2.InvoiceDate,#Temp2.PaymentType,
				#Temp1.ExtraLandCharges,#Temp1.ExtraSqFeetYds,#Temp1.PerSqFeetCharges,#Temp1.ApplyExtraLand
		Having	Sum(Amount) - Sum(ReceiptAmount) > 0 
		Order By #Temp1.UnitNumber,InvoiceDate
	End

Set Nocount Off




GO


