/****** Object:  StoredProcedure [dbo].[CashBookMulti]    Script Date: 4/2/2016 4:35:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO





ALTER Procedure [dbo].[CashBookMulti] @VoucherFrom Varchar(20),@VoucherTo Varchar(20),@CompanyId Varchar(4),@VoucherType Varchar(1) = 'P',@Project Varchar(4) = '',@DateFrom DateTime = '6/1/2001',@DateTo DateTime = '6/30/2099',@DefaultCurrency Varchar(3) = 'No'

as 

Set Nocount On

select  Mst.Voucherno,VoucherCategory,Case When IsNull(Finalize,0) = 0 Then 'No' Else 'Yes' End as Finalize,Mst.CompanyId,Voucherdate,Dtl.AccountCode,Ltrim(Rtrim(AccountName)) + ' (' + Ltrim(Rtrim(Dtl.AccountCode)) + ') ' as AccountName,Debit,Credit,Case When IsNull(Dtl.Chequeno,'') = '' Then ChqNoMst Else ChequeNo End ChequeNo,ChequeDate,DescriptionEntry as Description,P.Name as Project,L.Name as Location, S.Name as Sector,Dtl.Auto,PaidTo
From    tblCbMultiMst Mst,tblCbMultiDtl Dtl,tblAccounts,tblSector s,tblLocation L,tblProject P
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

--select   Mst.Voucherno,Mst.CompanyId,Voucherdate,Dtl.AccountCode,AccountName,Debit,Credit,Case When IsNull(Finalize,0) = 0 Then 'No' Else 'Yes' End as Finalize,ChqNoMst as ChequeNo,Dtl.ChequeDate,DescriptionEntry,Mst.Project,Dtl.Sector,Dtl.Tag,Dtl.Auto,PaidTo,AgainstAccount
--into 	 #Temp1
--From     tblCbMultiMst Mst,tblCbMultiDtl Dtl,tblAccounts 
--Where    Mst.CompanyId = Dtl.CompanyId 
--and		 Mst.VoucherNo = Dtl.VoucherNo
--and		 Dtl.AccountCode = tblAccounts.AccountCode 	
--and		 Mst.VoucherNo Between @VoucherFrom and @VoucherTo
--and		 Mst.CompanyId = Case When @CompanyId <> 'CONS' Then @CompanyId Else Mst.CompanyId End
--and		 Mst.VoucherType = @VoucherType
--And		 Mst.VoucherDate Between @DateFrom and @DateTo

--Select   VoucherNo,VoucherDate,Mst.AccountCode,Ltrim(Rtrim(Mst.AccountName)) + ' (' + Ltrim(Rtrim(Mst.AccountCode)) + ') ' as AccountName,tblAccounts.AccountName as AgainstAccountName,Debit,Credit,Finalize,ChequeNo,ChequeDate,DescriptionEntry as Description,P.Name as Project,L.Name as Location, S.Name as Sector,T.Name as Tag, EL.Name as EntryLocation,Mst.Auto,PaidTo
--From	 #Temp1 mst 
--left outer join tblTagFile T
--On 	mst.Tag = T.Code
--left outer join tblEntryLocation EL
--On 	Substring(VoucherNo,4,3) = EL.Code
--left outer join tblSector s
--On 	mst.Sector = S.Code
--left outer join tblLocation L
--On	S.Location = L.Code
--left outer join tblProject P
--On 	l.Project = P.code
--Left Outer Join tblAccounts
--On	Mst.AgainstAccount = tblAccounts.AccountCode 
--Where 	P.Code = Case When @Project <> '' Then @Project Else P.Code End 
--Order By VoucherNo,Auto,VoucherDate,Credit

Set Nocount Off

GO


