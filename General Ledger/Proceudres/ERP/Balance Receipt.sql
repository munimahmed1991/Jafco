USE [Builders2012]
GO

/****** Object:  View [dbo].[BalanceReceipt]    Script Date: 4/2/2016 4:34:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER View [dbo].[BalanceReceipt]

as

Select	InvoiceNo,InvoiceDate,Unit,IsNull(PaymentType,'') as PaymentType,IsNull(ExtraCharges,'') as ExtraCharges,Amount as InvoiceAmount,0 as ReceiptAmount,Installment
From	tblInvoice
Union All
Select	InvoiceNo,Null as InvoiceDate,Unit,IsNull(PaymentType,'') as PaymentType,IsNull(ExtraCharges,'') as ExtraCharges,0 as InvoiceAmount,ReceiptAmount,Installment
From	tblReceiptDtl Dtl,tblReceiptMst Mst
Where	Mst.ReceiptNo = Dtl.ReceiptNo
And		IsNull(Mst.Cancel,0) = 0 



GO


