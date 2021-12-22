USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[DemandNoticePrint]    Script Date: 4/2/2016 4:31:44 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO







Alter Procedure [dbo].[DemandNoticePrint] @Project Varchar(4),@Month Numeric(9),@Year Numeric(9),@LetterType Varchar(50),@ReportType Varchar(20),@CurrentDate DateTime,@Penalty Numeric(9) = 0 

as

Set Nocount On

Select	EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblCustomer.Address,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName ,tblLetters.Unit,PrintSystemDate,tblLetters.PaymentInstruction,tblBlock.Name as BlockName,
		'Subject : Due Payment of Unit No. ' + tblUnitFile.UnitNumber + ', ' + tblBlock.Name + ' in Project ' + tblProjectFile.Name as Subject,
		'Subject : Over Due Payment of Unit No. ' + tblUnitFile.UnitNumber + ', ' + tblBlock.Name + ' in Project ' + tblProjectFile.Name as Subject1,
		'With reference to your booking mentioned above in the subject line we request you to clear your following outstanding dues:' as ParagraphD11,
		'The above payment should be made on or before ' + IsNull(PaymentInstruction,'') + '. We will thoroughly appreciate an immediate response regarding the above from you.' as ParagraphD12,
		'For further queries, kindly contact our Customer Care Department on UAN 111-CHAPAL (242 725). We will gladly assist you and assure you of an excellent service at all times.' as ParagraphD13,
		'With reference to your booking mentioned above in the subject line and our earlier correspondence vide our letter dated ' + IsNull(tblLetters.PreviousLetters,'') + ' , our records reveal that you have still not paid your previous dues. We urge you to clear all your outstanding dues, including the dues of current month as mentioned below:' as ParagraphD21,
		'The above payment(s) should be made on or before ' + IsNull(PaymentInstruction,'') + '. We will appreciate an immediate action regarding the above from you since this payment schedule was agreed upon at the time of booking with your affirmation. We would also like to inform you that the construction work is in full swing on site and your timely payments will only boost up the construction activities. ' as ParagraphD22,
		'For further queries, kindly contact our “Customer Care Department” on UAN 111-CHAPAL (242 725). We will gladly assist you and assure you of an excellent service at all times. ' as ParagraphD23,
		
		'With reference to your booking mentioned above in the subject line and subsequent to our repeated correspondence vide our letters dated '  + IsNull(PreviousLetters,'') + ', we demand you to clear all your outstanding dues which are delayed considerably along with the penalty charges as per the terms and conditions signed by you, including the dues of current month. The dues are as follows: ' as ParagraphD31,
		'The above payment(s) should be made on or before ' + IsNull(PaymentInstruction,'') + '. We urge you to respond and take rapid action without any further delay from your end. Continuous delay of payments from your end may cause hindrance in the ongoing construction work on the site. Please Note that, if you have not paid your dues on time since the date of booking as per payment schedule, these delayed payments are subject to penalty charges of 3%  compounded monthly as per terms and conditions signed by you. If these penalty charges including all other dues are not paid, the penalty charges will keep on increasing till the time that all the dues and penalty charges have been cleared. In your own best interest and smooth & timely completion of your unit we would like to urge you that you must pay your dues/charges on time to avoid such situations. ' as ParagraphD32,
		'Further delay in timely payments from you could lead to further necessary action from the management.' as ParagraphD33,
		'For further queries, kindly contact our “Customer Care Department” on UAN 111-CHAPAL (242 725). We will gladly assist you and assure you of an excellent service at all times.' as ParagraphD34	
Into	#Temp1
From	tblLetters Left Outer Join tblCustomer Customer2 On Customer2.Code = tblLetters.Customer2, tblCustomer, tblUnitFile, tblProjectFile, tblBlock 
Where	tblLetters.Customer = tblCustomer.Code 
And		tblLetters.Unit = tblUnitFile.Code 
And		tblProjectFile.Code = tblLetters.Project 
And		Month(tblLetters.EntryDate) = @Month
And		Year(tblLetters.EntryDate) = @Year
And		tblLetters.LetterType = @LetterType
And		tblUnitFile.Project = @Project
And		IsNull(tblLetters.LetterPrint,0) = 1
And		PrintSystemDate = Case When @ReportType = 'Pending' Then @CurrentDate Else PrintSystemDate End 
And		tblUnitFile.Block = tblBlock.Code 

Select	BalanceReceipt.Unit,'CURRENT MONTH : ' + IsNull(tblPaymentGroup.Name,'') as PaymentType,BalanceReceipt.InvoiceNo,Max(BalanceReceipt.InvoiceDate) as InvoiceDate,tblPaymentGroup.Code as PaymentTypeCode,
		Sum(BalanceReceipt.InvoiceAmount) as InvoiceAmount,Sum(BalanceReceipt.ReceiptAmount) as ReceiptAmount,Sum(BalanceReceipt.InvoiceAmount - BalanceReceipt.ReceiptAmount) as BalanceAmount
Into	#CurrentBalanceReceipt
From	BalanceReceipt,tblPaymentType Left Outer Join tblPaymentGroup On tblPaymentGroup.Code = tblPaymentType.PaymentGroup,tblInvoice
Where	BalanceReceipt.PaymentType = tblPaymentType.Code
And		BalanceReceipt.InvoiceNo = tblInvoice.InvoiceNo
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
Group By BalanceReceipt.Unit,tblPaymentGroup.Name,tblPaymentGroup.Code,BalanceReceipt.InvoiceNo
Having Sum(InvoiceAmount) - Sum(ReceiptAmount) > 0 
And		Cast(Month(Max(BalanceReceipt.InvoiceDate)) as Varchar(2)) + Cast(Year(Max(BalanceReceipt.InvoiceDate)) as Varchar(4)) = Cast(@Month as Varchar(2)) + Cast(@Year as Varchar(4))

Select * Into #BalancePayment1 From #CurrentBalanceReceipt
Union All
Select	BalanceReceipt.Unit,'PREVIOUS MONTH : ' + IsNull(tblPaymentGroup.Name,'') as PaymentType,BalanceReceipt.InvoiceNo,Max(BalanceReceipt.InvoiceDate) as InvoiceDate,tblPaymentGroup.Code as PaymentTypeCode,
		Sum(BalanceReceipt.InvoiceAmount) as InvoiceAmount,Sum(BalanceReceipt.ReceiptAmount) as ReceiptAmount,Sum(BalanceReceipt.InvoiceAmount - BalanceReceipt.ReceiptAmount) as BalanceAmount 
From	BalanceReceipt,tblPaymentType Left Outer Join tblPaymentGroup On tblPaymentGroup.Code = tblPaymentType.PaymentGroup,tblInvoice
Where	BalanceReceipt.PaymentType = tblPaymentType.Code
And		BalanceReceipt.InvoiceNo = tblInvoice.InvoiceNo
And		Isnull(tblInvoice.Penalty,0) = Case When @Penalty = 0 Then 0 Else IsNull(tblInvoice.Penalty,0) End
aND		BalanceReceipt.InvoiceNo Not In (Select InvoiceNo From #CurrentBalanceReceipt)
Group By BalanceReceipt.Unit,tblPaymentGroup.Name,tblPaymentGroup.Code,BalanceReceipt.InvoiceNo
Having Sum(InvoiceAmount) - Sum(ReceiptAmount) > 0 


Select	#BalancePayment1.Unit,PaymentType,Sum(BalanceAmount) as BalanceAmount,PaymentTypeCode
Into	#BalancePayment
From	#BalancePayment1,#Temp1
Where	#BalancePayment1.InvoiceDate <= #Temp1.EntryDate
And		#Temp1.Unit = #BalancePayment1.Unit
Group BY #BalancePayment1.Unit,PaymentType,PaymentTypeCode

Select	#Temp1.*,PaymentType,BalanceAmount
From	#Temp1,#BalancePayment
Where	#Temp1.Unit = #BalancePayment.Unit
Order By #Temp1.Unit,PaymentTypeCode

Set Nocount Off










GO


