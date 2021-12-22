USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[AgingReport]    Script Date: 4/2/2016 4:30:16 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER Procedure [dbo].[AgingReport] @DateTo DateTime,@Project Varchar(4),@UnitType Varchar(10),@Unit Varchar(12),@ReportType Varchar(20),@Report Varchar(20),@Penalty Numeric(9) = 0,@PaymentType Varchar(4) = '',@CustomerType Varchar(50) = 'Both'

as

Set Nocount Off

Select  MAX(ReceiptDate) as ReceiptDate,Unit Into #LastReceipt From tblReceiptMst Where ReceiptDate < @DateTo Group By Unit

Select	tblReservationMst.Customer as Customer1,Customer1.Name as CustomerName1,Customer1.Address as Address1,Customer1.TelRes as TelRes1,Customer1.Mobile as Mobile1,Customer1.Email,
		tblReservationMst.Customer2 as Customer2,Customer2.Name as CustomerName2,Customer2.Address as Address2,Customer2.TelRes as TelRes2,Customer2.Mobile as Mobile2,
		tblReservationmst.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType,tblUnitType.Name as UnitTypeName,Case When tblUnitType.SqYards > 0 Then Cast(tblUnitType.SqYards as Varchar(4)) + ' Sq Yards' Else Cast(tblUnitType.SqFeet as Varchar(4)) + ' Sq Ft' End as SqYards, tblBlock.Name as Block,
		tblReservationMst.CashAmount,tblReservationMst.LoanAmount,tblReservationMst.ExtraCharges,tblReservationMst.Discount,tblReservationMst.TotalRevenue,
		tblReservationmst.Project,tblProjectFile.Name as ProjectName
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
And		ISNULL(tblReservationMst.NonActive,0) = Case When @CustomerType = 'Non Active' Then 1 Else Case When @CustomerType = 'Active' Then 0 Else ISNULL(tblReservationMst.NonActive,0) End End

Select	InvoiceNo,InvoiceDate,Unit,tblPaymentType.Name as PaymentType,Amount,0 as ReceiptAmount,Installment
Into	#Temp2
From	tblInvoice,tblPaymentType
Where	tblInvoice.PaymentType = tblPaymentType.Code 
And		tblInvoice.InvoiceDate <= @DateTo
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
Union All 
Select	tblReceiptDtl.InvoiceNo,tblInvoice.InvoiceDate,tblReceiptMst.Unit,tblPaymentType.Name as PaymentType,0 as Amount,ReceiptAmount,tblReceiptDtl.Installment
From	tblReceiptMst,tblReceiptDtl,tblInvoice,tblPaymentType
Where	tblReceiptMst.ReceiptNo = tblReceiptDtl.ReceiptNo
And		tblReceiptDtl.InvoiceNo = tblInvoice.InvoiceNo
And		tblPaymentType.Code = tblReceiptDtl.PaymentType
And		tblReceiptDtl.ReceiptAmount > 0
And		tblReceiptMst.ReceiptDate <= @DateTo
And		IsNull(tblReceiptMst.Cancel,0) = 0 
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
And		IsNull(tblInvoice.PaymentType,'') = Case When @PaymentType = '' Then IsNull(tblInvoice.PaymentType,'') Else @PaymentType End

Select	#Temp1.Customer1,#Temp1.CustomerName1 as CustomerName,#Temp1.Address1 as Address,#Temp1.TelRes1 as TelRes,#Temp1.Mobile1 as Mobile,#Temp1.Email,
		#Temp1.Project,#Temp1.ProjectName,#Temp1.UnitNumber,#Temp1.Unit,#Temp1.UnitType,#Temp1.UnitTypeName,#Temp1.SqYards,#Temp1.Block,
		#Temp1.CashAmount,#Temp1.LoanAmount,#Temp1.ExtraCharges,#Temp1.Discount,#Temp1.TotalRevenue,
		#Temp2.InvoiceNo,#Temp2.InvoiceDate,#Temp2.PaymentType,Sum(Amount) as InvoiceAmount,Sum(ReceiptAmount) as ReceiptAmount,Sum(Amount) - Sum(ReceiptAmount) as Amount,#LastReceipt.ReceiptDate  as LastReceiptDate,#Temp1.Customer2
Into	#Temp3
From	#Temp1 Left Outer Join #Temp2 On #Temp1.Unit = #Temp2.Unit		
Left Outer Join #LastReceipt On #Temp1.Unit = #LastReceipt.Unit 
Group By #Temp1.CustomerName1,#Temp1.Address1,#Temp1.TelRes1,#Temp1.Mobile1,
		#Temp1.CustomerName2,#Temp1.Address2,#Temp1.TelRes2,#Temp1.Mobile2,
		#Temp1.Project,#Temp1.ProjectName,#Temp1.UnitNumber,#Temp1.UnitType,#Temp1.SqYards,#Temp1.Block,
		#Temp1.CashAmount,#Temp1.LoanAmount,#Temp1.ExtraCharges,#Temp1.Discount,#Temp1.TotalRevenue,
		#Temp2.InvoiceNo,#Temp2.InvoiceDate,#Temp2.PaymentType,#Temp1.Unit,#Temp1.UnitTypeName,#Temp1.Customer1,#Temp1.Email,#LastReceipt.ReceiptDate,#Temp1.Customer2,#Temp1.Project
Having	Sum(Amount) - Sum(ReceiptAmount) > 0 
Order By #Temp1.UnitNumber,InvoiceDate

Select #Temp3.*,DateDiff(Day,InvoiceDate,@DateTo) as Days Into #Temp4 From #Temp3

if @Report = 'Detail'
	Begin
		if @ReportType = 'Report'
			Begin
				Select	InvoiceNo,InvoiceDate,UnitTypeName,UnitNumber,
						CustomerName,TelRes,Mobile,Address,
						Sum(Case When Days <=30 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
						Sum(Case When Days > 30 and Days <=60 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
						Sum(Case When Days > 60 and Days <=90 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
						Sum(Case When Days > 90 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
						Sum(InvoiceAmount - ReceiptAmount) as Amount
				From	#Temp4
				Group By InvoiceNo,InvoiceDate,UnitTypeName,UnitNumber,CustomerName,TelRes,Mobile,Address
				Order BY UnitNumber,InvoiceDate 
			End
		
		if @ReportType = 'Grid'
			Begin
				Select	InvoiceNo,InvoiceDate,UnitTypeName,UnitNumber,
						CustomerName,TelRes,Mobile,Address,
						Sum(Case When Days <=30 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
						Sum(Case When Days > 30 and Days <=60 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
						Sum(Case When Days > 60 and Days <=90 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
						Sum(Case When Days > 90 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
						Sum(InvoiceAmount - ReceiptAmount) as Amount
				From	#Temp4
				Group By InvoiceNo,InvoiceDate,UnitTypeName,UnitNumber,CustomerName,TelRes,Mobile,Address
				Order BY UnitNumber,InvoiceDate 
			End
	End
if @Report = 'Aging'
	Begin
		if @ReportType = 'Report'
			Begin
				Select	UnitTypeName,UnitNumber,
						CustomerName,TelRes,Mobile,Address,LastReceiptDate,
						Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
						Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
						Sum(Case When Days > 62and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
						Sum(Case When Days > 92 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
						Sum(InvoiceAmount - ReceiptAmount) as Amount
				From	#Temp4
				Group By UnitTypeName,UnitNumber,CustomerName,TelRes,Mobile,Address,LastReceiptDate
				Order BY UnitNumber 
			End
		
		if @ReportType = 'Grid'
			Begin
				Select	'' as Total,UnitTypeName,UnitNumber,
						CustomerName,TelRes,Mobile,Address,
						Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
						Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
						Sum(Case When Days > 62and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
						Sum(Case When Days > 92 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
						Sum(InvoiceAmount - ReceiptAmount) as Amount,LastReceiptDate
				From	#Temp4
				Group By UnitTypeName,UnitNumber,CustomerName,TelRes,Mobile,Address,LastReceiptDate
				Order BY UnitNumber 
			End
	End

if @Report = '30 Days'
	Begin
		Select	UnitType,UnitTypeName,'' as Scheme,Project,ProjectName,
				Unit,UnitNumber,
				Customer1 as Customer,Customer2,CustomerName,TelRes,Mobile,Address,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
				Sum(InvoiceAmount - ReceiptAmount) as Amount,
				Sum(InvoiceAmount - ReceiptAmount) as TotalBalance
		Into	#ThirtyDays
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email,Project,Customer2,ProjectName,Address
		Order BY UnitNumber 		

		Select * from #ThirtyDays Where IsNull(Days30,0) > 0 and IsNull(Days60,0) + IsNull(Days90,0) + IsNull(After90Days,0) = 0 
	End

if @Report = '60 Days'
	Begin
		Select	UnitType,UnitTypeName,'' as Scheme,Project,ProjectName,
				Unit,UnitNumber,
				Customer1 as Customer,Customer2,CustomerName,TelRes,Mobile,Address,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
				Sum(InvoiceAmount - ReceiptAmount) as Amount,
				Sum(InvoiceAmount - ReceiptAmount) as TotalBalance
		Into	#SixtyDays
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email,Project,Customer2,ProjectName,Address
		Order BY UnitNumber 		

		Select * from #SixtyDays Where IsNull(Days60,0) > 0 and IsNull(Days90,0) + IsNull(After90Days,0) = 0 
	End

if @Report = '90 Days'
	Begin
		Select	UnitType,UnitTypeName,'' as Scheme,Project,ProjectName,
				Unit,UnitNumber,
				Customer1 as Customer,Customer2,CustomerName,TelRes,Mobile,Address,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
				Sum(Case When Days > 62and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
				Sum(InvoiceAmount - ReceiptAmount) as Amount,
				Sum(InvoiceAmount - ReceiptAmount) as TotalBalance
		Into	#NinetyDays
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email,Project,Customer2,ProjectName,Address
		Order BY UnitNumber 		

		Select * from #NinetyDays Where IsNull(Days90,0) > 0 and IsNull(After90Days,0) = 0 
	End

if @Report = '120 Days'
	Begin
		Select	UnitType,UnitTypeName,'' as Scheme,Project,ProjectName,
				Unit,UnitNumber,
				Customer1 as Customer,Customer2,CustomerName,TelRes,Mobile,Address,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62 and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 and days <= 122 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days120,
				Sum(Case When Days > 122  Then InvoiceAmount - ReceiptAmount Else 0 End) as After120,
				Sum(Case When Days > 92and Days <=122 Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
				Sum(InvoiceAmount - ReceiptAmount) as Amount,
				Sum(InvoiceAmount - ReceiptAmount) as TotalBalance
		Into	#OneTwentyDays
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email,Project,Customer2,ProjectName,Address
		Order BY UnitNumber 		

		Select * from #OneTwentyDays Where IsNull(Days120,0) > 0 and IsNull(After120,0) = 0 
	End

if @Report = '150 Days'
	Begin
		Select	UnitType,UnitTypeName,'' as Scheme,Project,ProjectName,
				Unit,UnitNumber,
				Customer1 as Customer,Customer2,CustomerName,TelRes,Mobile,Address,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62 and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 and days <= 122 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days120,
				Sum(Case When Days > 122 and Days <= 152 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days150,
				Sum(Case When Days > 152 Then InvoiceAmount - ReceiptAmount Else 0 End) as After150,
				Sum(Case When Days > 122 and Days <=152 Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
				Sum(InvoiceAmount - ReceiptAmount) as Amount,
				Sum(InvoiceAmount - ReceiptAmount) as TotalBalance
		Into	#OneFiftyDays
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email,Project,Customer2,ProjectName,Address
		Order BY UnitNumber 		

		Select * from #OneFiftyDays Where IsNull(Days150,0) > 0 and IsNull(After150,0) = 0 
	End

if @Report = '180 Days'
	Begin
		Select	UnitType,UnitTypeName,'' as Scheme,Project,ProjectName,
				Unit,UnitNumber,
				Customer1 as Customer,Customer2,CustomerName,TelRes,Mobile,Address,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62 and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 and days <= 122 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days120,
				Sum(Case When Days > 122 and Days <= 152 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days150,
				Sum(Case When Days > 152 and Days <= 182 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days180,
				Sum(Case When Days > 182 Then InvoiceAmount - ReceiptAmount Else 0 End) as After180,
				Sum(Case When Days > 152 and Days <= 182 Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
				Sum(InvoiceAmount - ReceiptAmount) as Amount,
				Sum(InvoiceAmount - ReceiptAmount) as TotalBalance
		Into	#OneEighty
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email,Project,Customer2,ProjectName,Address
		Order BY UnitNumber 		

		Select * from #OneEighty Where IsNull(Days180,0) > 0 and IsNull(After180,0) = 0 
	End

if @Report = 'After 180'
	Begin
		Select	UnitType,UnitTypeName,'' as Scheme,Project,ProjectName,
				Unit,UnitNumber,
				Customer1 as Customer,Customer2,CustomerName,TelRes,Mobile,Address,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62 and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 and days <= 122 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days120,
				Sum(Case When Days > 122 and Days <= 152 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days150,
				Sum(Case When Days > 152 and Days <= 182 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days180,
				Sum(Case When Days > 182 Then InvoiceAmount - ReceiptAmount Else 0 End) as After180,
				Sum(Case When Days > 182 Then InvoiceAmount - ReceiptAmount Else 0 End) as Balance,
				Sum(InvoiceAmount - ReceiptAmount) as Amount,
				Sum(InvoiceAmount - ReceiptAmount) as TotalBalance
		Into	#After180
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email,Project,Customer2,ProjectName,Address
		Order BY UnitNumber 		

		Select * from #After180 Where IsNull(After180,0) > 0 
	End

if @Report = 'Over 90 Days'
	Begin
		Select	UnitType,UnitTypeName,
				Unit,UnitNumber,
				Customer1 as Customer,CustomerName,TelRes,Mobile,Email,
				Sum(Case When Days <=32 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days30,
				Sum(Case When Days > 32 and Days <=62 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days60,
				Sum(Case When Days > 62and Days <=92 Then InvoiceAmount - ReceiptAmount Else 0 End) as Days90,
				Sum(Case When Days > 92 Then InvoiceAmount - ReceiptAmount Else 0 End) as After90Days,
				Sum(InvoiceAmount - ReceiptAmount) as Amount
		Into	#OverNinety
		From	#Temp4
		Group By UnitType,UnitTypeName,Unit,UnitNumber,Customer1,CustomerName,TelRes,Mobile,Email
		Order BY UnitNumber 		

		Select * from #OverNinety Where IsNull(After90Days,0) > 0 
	End
Set Nocount Off




GO


