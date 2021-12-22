/****** Object:  StoredProcedure [dbo].[BankBookMulti]    Script Date: 4/2/2016 4:35:42 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER Procedure [dbo].[BankBookMulti] @VoucherFrom Varchar(20),@VoucherTo Varchar(20),@CompanyId Varchar(4),@VoucherType Varchar(1) = 'P',@Project Varchar(4) = '',@DateFrom DateTime = '6/1/2001',@DateTo DateTime = '6/30/2099',@DefaultCurrency Varchar(3) = 'No'

as 

Set Nocount On

Select	Dtl.VoucherNo,Dtl.AccountCode,tblAccounts.AccountName 
Into	#Supplier
From	tblAccounts,tblBBMultiDtl Dtl
Where	tblAccounts.AccountCode = Dtl.AccountCode
And		(tblAccounts.AccountType = 'Supplier' or tblAccounts.AccountType = 'Customer')
Group By Dtl.VoucherNo,Dtl.AccountCode,tblAccounts.AccountName


select  Mst.Voucherno,VoucherCategory,Case When IsNull(Finalize,0) = 0 Then 'No' Else 'Yes' End as Finalize,Mst.CompanyId,Voucherdate,Dtl.AccountCode,Ltrim(Rtrim(tblAccounts.AccountName)) + ' (' + Ltrim(Rtrim(Dtl.AccountCode)) + ') ' as AccountName,#Supplier.AccountName as Supplier,Debit,Credit,Case When IsNull(Dtl.Chequeno,'') = '' Then ChqNoMst Else ChequeNo End ChequeNo,ChequeDate,DescriptionEntry as Description,P.Name as Project,L.Name as Location, S.Name as Sector,Dtl.Auto,PaidTo
From    tblBbMultiMst Mst Left Outer Join #Supplier On #Supplier.VoucherNo = Mst.VoucherNo,tblBbMultiDtl Dtl,tblAccounts,tblSector s,tblLocation L,tblProject P
Where   Mst.CompanyId = Dtl.CompanyId 
and		Mst.VoucherNo = Dtl.VoucherNo
and		Dtl.AccountCode = tblAccounts.AccountCode 	
and		Mst.VoucherNo Between @VoucherFrom and @VoucherTo
and		Mst.CompanyId = Case When @CompanyId <> 'CONS' Then @CompanyId Else Mst.CompanyId End
and		Mst.VoucherType = @VoucherType
And		Mst.VoucherDate Between @DateFrom and @DateTo
And	 	Dtl.Sector = S.Code
And		S.Location = L.Code
And 	l.Project = P.code
And 	P.Code = Case When @Project <> '' Then @Project Else P.Code End 
Order By Dtl.VoucherNo,Auto,VoucherDate,Credit

Set Nocount Off

GO


