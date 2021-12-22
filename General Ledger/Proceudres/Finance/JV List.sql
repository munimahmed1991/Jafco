/****** Object:  StoredProcedure [dbo].[JVList]    Script Date: 4/2/2016 4:35:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER OFF
GO






ALTER Procedure [dbo].[JVList] @VoucherFrom Varchar(20),@VoucherTo Varchar(20),@CompanyId Varchar(4),@Project Varchar(4) = '',@DateFrom Datetime = '6/1/2001',@DateTo DateTime = '6/30/2099',@DefaultCurrency Varchar(3) = 'No'
as 
Set Nocount On

select  Mst.Voucherno,VoucherCategory,Mst.Invoiceno,Dtl.ProdCardNo,Case When IsNUll(Finalize,0) = 0 Then 'No' Else 'Yes' End as Finalize,Voucherdate,Dtl.AccountCode,Ltrim(Rtrim(AccountName)) + ' (' + Ltrim(Rtrim(Dtl.AccountCode)) + ') ' as AccountName,Debit,Credit,ChequeNo,ChequeDate,DescriptionEntry as Description,P.Name as Project,L.Name as Location, S.Name as Sector,tblTagFile.nAME as Tag, '' as EntryLocation,Dtl.Auto
From    tblJvMst Mst,tblJvDtl Dtl Left Outer Join tblTagFile On tblTagFile.Code = Dtl.Tag,tblAccounts,tblSector s,tblLocation L,tblProject P
Where   Mst.CompanyId = Dtl.CompanyId 
And		Mst.VoucherNo = Dtl.VoucherNo
And		Dtl.AccountCode = tblAccounts.AccountCode 	
And		Mst.VoucherNo Between @VoucherFrom and @VoucherTo
And		Mst.CompanyId = Case When @CompanyId <> 'CONS' Then @CompanyId Else Mst.CompanyId End
And		P.Code = Case When @Project <> '' Then @Project Else P.Code End 
And 	Dtl.Sector = S.Code
And		S.Location = L.Code
And 	l.Project = P.code
And		Mst.VoucherDate Between @DateFrom and @DateTo
Order By Mst.VoucherNo,Auto,VoucherDate,Credit


Set Nocount Off




GO


