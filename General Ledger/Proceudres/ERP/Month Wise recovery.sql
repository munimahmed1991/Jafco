USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[MonthWiseRecovery]    Script Date: 4/2/2016 4:32:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER Procedure [dbo].[MonthWiseRecovery]	@DateFrom DateTime,@DateTo DateTime,
									@Date1 DateTime,@Date2 DateTime,@Date3 DateTime,@Date4 DateTime,@Date5 DateTime,
									@Date6 DateTime,@Date7 DateTime,@Date8 DateTime,@Date9 DateTime,@Date10 DateTime,
									@Project Varchar(4),@Unit Varchar(12),@UnitType Varchar(10)

as

Set Nocount On

Select	Mst.ReceiptNo,Mst.ReceiptDate,tblCustomer.Name as Customer,
		Mst.Unit,tblUnitFile.UnitNumber,tblUnitType.Name as UnitType,
		Dtl.InvoiceNo,IsNull(tblInvoice.InvoiceDate,Dtl.InvoiceDate) as InvoiceDate,ReceiptAmount
Into	#Temp1
From	tblReceiptMst Mst,tblReceiptDtl Dtl Left Outer Join tblInvoice On tblInvoice.InvoiceNo = Dtl.InvoiceNo,tblUnitFile,tblUnitType,tblCustomer,tblReservationMst
Where	Mst.ReceiptNo = Dtl.ReceiptNo
And		Mst.Unit = tblUnitFile.Code
And		Mst.UnitType = tblUnitType.Code
And		tblReservationMst.Unit = Mst.Unit
And		tblReservationMst.Customer = tblCustomer.Code
And		IsNull(tblReservationMst.Cancel,0) = 0 
And		IsNull(Mst.Cancel,0) = 0 
And		Mst.ReceiptDate Between @DateFrom and @DateTO
And		Mst.Project = @Project
And		tblUnitFile.Code = Case When @Unit <> '' Then @Unit Else tblUnitFile.Code End
And		Mst.UnitType = Case When @UnitType <> '' Then @UnitType Else Mst.UnitType ENd 
Order By Mst.Unit

select	Unit,UnitNumber,UnitType,Customer,ReceiptAmount,
		Case When InvoiceDate >= @Date1 and InvoiceDate  < @DateTo Then ReceiptAmount Else 0 End as CurrentReceipt,
		Case When InvoiceDate >= @Date2 and InvoiceDate < @Date1 Then ReceiptAmount Else 0 End as PreviousReceipt1,
		Case When InvoiceDate >= @Date3 and InvoiceDate < @Date2 Then ReceiptAmount Else 0 End as PreviousReceipt2,
		Case When InvoiceDate >= @Date4 and InvoiceDate < @Date3 Then ReceiptAmount Else 0 End as PreviousReceipt3,
		Case When InvoiceDate >= @Date5 and InvoiceDate < @Date4 Then ReceiptAmount Else 0 End as PreviousReceipt4,
		Case When InvoiceDate >= @Date6 and InvoiceDate < @Date5 Then ReceiptAmount Else 0 End as PreviousReceipt5,
		Case When InvoiceDate >= @Date7 and InvoiceDate < @Date6 Then ReceiptAmount Else 0 End as PreviousReceipt6,
		Case When InvoiceDate >= @Date8 and InvoiceDate < @Date7 Then ReceiptAmount Else 0 End as PreviousReceipt7,
		Case When InvoiceDate >= @Date9 and InvoiceDate < @Date8 Then ReceiptAmount Else 0 End as PreviousReceipt8,
		Case When InvoiceDate >= @Date10 and InvoiceDate < @Date9 Then ReceiptAmount Else 0 End as PreviousReceipt9,
		Case When Invoicedate < @Date10 Then ReceiptAmount Else 0 End as OpeningBalance
Into	#Temp2
From	#Temp1

Select	Unit,UnitNumber,UnitType,Customer,Sum(ReceiptAmount) as TotalReceipt,
		Sum(OpeningBalance) as OpeningBalance,
		Sum(CurrentReceipt) as Receipt1,
		Sum(PreviousReceipt1) as Receipt2,
		Sum(PreviousReceipt2) as Receipt3,
		Sum(PreviousReceipt3) as Receipt4,
		Sum(PreviousReceipt4) as Receipt5,
		Sum(PreviousReceipt5) as Receipt6,
		Sum(PreviousReceipt6) as Receipt7,
		Sum(PreviousReceipt7) as Receipt8,
		Sum(PreviousReceipt8) as Receipt9,
		Sum(PreviousReceipt9) as Receipt10
From	#Temp2
Group By Unit,UnitNumber,UnitType,Customer
Order BY UnitType



Set Nocount Off


GO


