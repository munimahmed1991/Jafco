USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[FinalNotice]    Script Date: 4/2/2016 4:32:11 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO








ALTER Procedure [dbo].[FinalNotice] @Project Varchar(4),@Month Numeric(9),@Year Numeric(9),@LetterType Varchar(50),@ReportType Varchar(20),@CurrentDate DateTime,@Penalty Numeric(9) = 0 

as

Set Nocount On

Select	EntryNo,EntryDate,tblCustomer.SLT + ' ' + tblCustomer.Name + ' ' + IsNull(tblCustomer.FatherHusbandName,'') + Case When IsNull(Customer2.Name,'') <> '' Then ' & ' Else ' ' End + IsNull(Customer2.SLT,'') + ' ' + IsNull(Customer2.Name,'') + ' ' + IsNull(Customer2.FatherHusbandName,'') as CustomerName,tblCustomer.Address,tblUnitFile.UnitNumber,tblProjectFile.Name as ProjectName ,tblLetters.Unit,PrintSystemDate,tblLetters.PaymentInstruction,tblBlock.Name as BlockName,
		'Subject : Final Demand Notice of Unit No. ' + tblUnitFile.UnitNumber + ', ' + tblBlock.Name + ' in Project ' + tblProjectFile.Name as Subject,
		'Reference to the above mentioned subject, we would like to inform you that there are outstanding payments for the above said unit that have not been cleared within due dates. Inspite of several demand notices sent to you to make payments vide our letters dated ' + IsNull(tblLetters.PreviousLetters,'') + ', our record reveals that you are in default and it appears as if the matter is not taken seriously' as ParagraphDF1,
		'Though you have already defaulted in making payments by extensive and prolonged periods of time, we would like to give you a final opportunity to clear out all your dues/installments along with penalty chages within (15) days from the date of the letter. In case of failre to clear all dues and if the payment is not recived at our end with in the above noted period, we shall be compelled to cancel the booking of the said unit without any further intimation and/or notice, in accordance with the terms and condition, including the recovery cost and losses that we may suffer as a result of cancelling the booking of the said unit. Please note that this letters as a Final notice and is valid for a period of fifteen (15) days frin the date of this letter. For further inquiry will be glad to assist you and assure you of our excellent service at all times.' as FD3
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
And		Cast(Month(BalanceReceipt.InvoiceDate) as Varchar(2)) + Cast(Year(BalanceReceipt.InvoiceDate) as Varchar(4)) = Cast(@Month as Varchar(2)) + Cast(@Year as Varchar(4))
Group By BalanceReceipt.Unit,tblPaymentGroup.Name,tblPaymentGroup.Code,BalanceReceipt.InvoiceNo
Having Sum(InvoiceAmount) - Sum(ReceiptAmount) > 0 

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


Select	#BalancePayment1.Unit,Sum(BalanceAmount) as BalanceAmount,PaymentTypeCode
Into	#BalancePayment
From	#BalancePayment1,#Temp1
Where	#BalancePayment1.InvoiceDate <= #Temp1.EntryDate
And		#Temp1.Unit = #BalancePayment1.Unit
Group BY #BalancePayment1.Unit,PaymentTypeCode

Select	#Temp1.*,BalanceAmount
From	#Temp1,#BalancePayment
Where	#Temp1.Unit = #BalancePayment.Unit
Order By #Temp1.Unit

Set Nocount Off











GO


