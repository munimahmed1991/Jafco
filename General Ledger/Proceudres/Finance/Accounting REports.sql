/****** Object:  StoredProcedure [dbo].[AccountingReports]    Script Date: 4/2/2016 4:34:52 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER Procedure [dbo].[AccountingReports] 
				     @CompanyId Varchar(4),@DateFrom DateTime,@DateUpto DateTime,
				     @AccountFrom Varchar(14) = '00000000000000',@AccountTo Varchar(14)  = 'zzzzzzzzzzzzzz',
				     @Project Varchar(3) = 'All',@Location Varchar(4) = 'All',@Sector Varchar(4) = 'All',
				     @BookType Varchar(20) = 'All',@AccountDigit Numeric(9) = 14,@ReportType Varchar(40) = 'Aging',@ControlAccount Varchar(14) = '',@Employee Varchar(10) = '',@Tag Varchar(5) = '',@WithoutAgainstAccount Int = 0,@ExcludeClosingEntry Int = 0,@ReportFilter Varchar(50) = '',@AccountType Varchar(50) = 'All',@VoucherNoFrom Varchar(15) = '',@VoucherNoTo Varchar(15) = '',@AgainstAccount Varchar(14) = '',@Finalize Varchar(4) = 'Both',@InvoicePrefix Varchar(6) = '',@Asset Varchar(10) = '',@PartyAccount Varchar(14) = '',@ProdCardNo Varchar(50) = '',
					 @AccountDigit1 Numeric(9) = 0,@AccountDigit2 Numeric(9) = 0,@AccountDigit3 Numeric(9) = 0,@AccountDigit4 Numeric(9) = 0,@AccountDigit5 Numeric(9) = 0,@AccountDigit6 Numeric(9) = 0,@AccountDigit7 Numeric(9) = 0, 
					 @LastPeriodFrom DateTime = '1/1/2012',@LastPeriodTo DateTime = '1/1/2012',@CurrentPeriodFrom DateTime = '1/1/2012',@CurrentPeriodTo DateTime = '1/1/2012',@eXrATE NUMERIC(9) = 0,@DateType Varchar(50) = 'Voucher Date'
as 
Set Nocount on 


select  'JV' as Booktype,Mst.Voucherno,Mst.CompanyId,P.Code as ProjectCode,P.Name as ProjectName,L.Code as LocationCode,L.Name as LocationName,Dtl.Sector as SectorCode,S.Name as SectorName,Voucherdate,
		Dtl.AccountCode,AccountName,' ' as OppAccount,'Journal Voucher' as OppAccountName,AgainstAccount as AgainstAccount,
		Case When (IsNull(ChqNoMst,'') = '' or IsNull(ChqNoMst,'')  = '0') Then Mst.InvoiceNo Else ChqNoMst End  as ChequeNo,ChequeDate,Case When IsNull(Auto,0) = 1 Then Description Else Case When isnull(DescriptionEntry,'') = '' Then Description Else DescriptionEntry End End as Description,Debit,Credit,ChqClear,ChqClearDate,BankStDate,'M' as EntryType,Tag,EmployeeCode,Auto,IsNull(Finalize,0) as Finalize,AssetCode,InvoiceNo,IsNull(Mst.PartyAccount,'') as PartyAccount,IsNull(ProdCardNo,'') as ProdCardNo
Into	#Temp2
From    tblJvMst Mst,tblJvDtl Dtl,tblAccounts, tblProject P, tblLocation L, tblSector S,tblDefaults
Where   Mst.CompanyId = Dtl.CompanyId 
and		Mst.VoucherNo = Dtl.VoucherNo
and		Dtl.Sector = S.Code
and		S.Location = L.Code
and		L.Project = P.Code
and		Dtl.AccountCode = tblAccounts.AccountCode 
and		Dtl.Sector = Case When @Sector <> 'All' then @Sector else Dtl.Sector end 
and		S.Location = Case When @Location <> 'All' then @Location else S.Location end
and		L.Project = Case When @Project <> 'All' then @Project else L.Project end	
and		Mst.CompanyId = Case When @CompanyId <> 'CONS' then @CompanyID else Mst.CompanyId end 
and		IsNull(Dtl.EmployeeCode,'') = Case When @Employee <> '' Then @Employee Else IsNull(Dtl.EmployeeCode,'') End 
and		IsNull(Dtl.Tag,'') = Case When @Tag <> '' Then @Tag Else IsNull(Dtl.Tag,'') End 
and		IsNull(Closing,0) = Case When @ExcludeClosingEntry = 0 Then IsNull(Closing,0) Else 0 End
and		Substring(IsNull(Mst.InvoiceNo,''),1,Len(@InvoicePrefix)) = Case When @InvoicePrefix = '' Then Substring(IsNUll(Mst.InvoiceNo,''),1,Len(@InvoicePrefix)) Else @InvoicePrefix End 
and		IsNull(AssetCode,'') = Case When @Asset <> '' Then @Asset Else IsNull(AssetCode,'') End 
And		tblDefaults.CompanyId = '0001' 
And		IsNull(Finalize,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Finalize' Then 1 Else IsNull(Finalize,0) End 
And		IsNull(Verified,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Verified' Then 1 Else IsNull(Verified,0) End 
And		IsNull(Authorized,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Authorized' Then 1 Else IsNull(Authorized,0) End 
And		IsNull(Posted,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Posted' Then 1 Else IsNull(Posted,0) End 
And		IsNull(ProdCardNo,'') = Case When @ProdCardNo <> '' Then @ProdCardNo Else IsNull(ProdCardNo,'') End 
And		IsNull(Mst.PartyAccount,'') = Case When @PartyAccount = '' Then IsNull(Mst.PartyAccount,'') Else @Partyaccount End 
--and   Mst.Posted = 1
And 	tblAccounts.AccountType = Case When @AccountType <> 'All' Then @AccountType Else tblAccounts.AccountType End 
Union All
select   Case When Substring(Mst.VoucherNo,3,1) = 'P' Then 'CBP' Else 'CBR' End  as Booktype,Mst.Voucherno,Mst.CompanyId,P.Code as ProjectCode,P.Name as ProjectName,L.Code as LocationCode,L.Name as LocationName,Dtl.Sector as SectorCode,S.Name as SectorName,Voucherdate,
		 Dtl.AccountCode,AccountName,'' as OppAccount,'Cash Book Multiple Entry' as OppAccountName,AgainstAccount,
		 Case When IsNull(Dtl.Chequeno,'') = '' Then ChqNoMst Else ChequeNo End as ChequeNo,ChequeDate,Case When IsNull(Auto,0) = 1 then Description Else DescriptionEntry End as DescriptionEntry,Debit,Credit,ChqClear,ChqClearDate,BankStDate,'M' as EntryType,Tag,EmployeeCode,Auto,IsNull(Finalize,0) as Finalize,AssetCode,'' as InvoiceNo,' ' as PartyAccount,' ' as ProdCardNo
From     tblCbMultiMst Mst,tblCbMultiDtl Dtl,tblAccounts, tblProject P, tblLocation L, tblSector S,tblDefaults
Where    Mst.CompanyId = Dtl.CompanyId 
and		Mst.VoucherNo = Dtl.VoucherNo
and		Dtl.AccountCode = tblAccounts.AccountCode
and		Dtl.Sector = S.Code
and		S.Location = L.Code
and		L.Project = P.Code
and		Dtl.Sector = Case When @Sector <> 'All' then @Sector else Dtl.Sector end 
and		S.Location = Case When @Location <> 'All' then @Location else S.Location end
and		L.Project = Case When @Project <> 'All' then @Project else L.Project end	
and		Mst.CompanyId = Case When @CompanyId <> 'CONS' then @CompanyID else Mst.CompanyId end 
and		IsNull(Dtl.EmployeeCode,'') = Case When @Employee <> '' Then @Employee Else IsNull(Dtl.EmployeeCode,'') End 
and		IsNull(Dtl.Tag,'') = Case When @Tag <> '' Then @Tag Else IsNull(Dtl.Tag,'') End 
and		Substring(IsNull(Mst.ChqNoMst,''),1,4) = Case When @InvoicePrefix = '' Then Substring(IsNUll(Mst.ChqNoMst,''),1,4) Else @InvoicePrefix End 
and		IsNull(AssetCode,'') = Case When @Asset <> '' Then @Asset Else IsNull(AssetCode,'') End 
And		tblDefaults.CompanyId = '0001' 
And		IsNull(Finalize,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Finalize' Then 1 Else IsNull(Finalize,0) End 
And		IsNull(Verified,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Verified' Then 1 Else IsNull(Verified,0) End 
And		IsNull(Authorized,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Authorized' Then 1 Else IsNull(Authorized,0) End 
And		IsNull(Posted,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Posted' Then 1 Else IsNull(Posted,0) End 
--and   Mst.Posted = 1
And 	tblAccounts.AccountType = Case When @AccountType <> 'All' Then @AccountType Else tblAccounts.AccountType End 
Union All
select  Case When Substring(Mst.VoucherNo,3,1) = 'P' Then 'BBP' Else 'BBR' End  as Booktype,Mst.Voucherno,Mst.CompanyId,P.Code as ProjectCode,P.Name as ProjectName,L.Code as LocationCode,L.Name as LocationName,Dtl.Sector as SectorCode,S.Name as SectorName,Voucherdate,
		Dtl.AccountCode,AccountName,'' as OppAccount,'Bank Book Multiple Entry' as OppAccountName,AgainstAccount,
		Case When IsNull(Dtl.Chequeno,'') = '' Then ChqNoMst Else ChequeNo End as ChequeNo,ChequeDate,Case When IsNull(Auto,0) = 1 then Description Else DescriptionEntry End as DescriptionEntry,Debit,Credit,ChqClear,ChqClearDate,BankStDate,'M' as EntryType,Tag,EmployeeCode,Auto,IsNull(Finalize,0) as Finalize,AssetCode,'' as InvoiceNo,' ' as PartyAccount,' ' as ProdCardNo
From    tblBbMultiMst Mst,tblBbMultiDtl Dtl,tblAccounts, tblProject P, tblLocation L, tblSector S,tblDefaults
Where   Mst.CompanyId = Dtl.CompanyId 
and   	Mst.VoucherNo = Dtl.VoucherNo
and   	Dtl.AccountCode = tblAccounts.AccountCode 	
and   	Dtl.Sector = S.Code
and   	S.Location = L.Code
and   	L.Project = P.Code
and   	Dtl.Sector = Case When @Sector <> 'All' then @Sector else Dtl.Sector end 
and   	S.Location = Case When @Location <> 'All' then @Location else S.Location end
and   	L.Project = Case When @Project <> 'All' then @Project else L.Project end	
and   	Mst.CompanyId = Case When @CompanyId <> 'CONS' then @CompanyID else Mst.CompanyId end 
and   	IsNull(Dtl.EmployeeCode,'') = Case When @Employee <> '' Then @Employee Else IsNull(Dtl.EmployeeCode,'') End 
and   	IsNull(Dtl.Tag,'') = Case When @Tag <> '' Then @Tag Else IsNull(Dtl.Tag,'') End 
and		Substring(IsNull(Mst.ChqNoMst,''),1,4) = Case When @InvoicePrefix = '' Then Substring(IsNUll(Mst.ChqNoMst,''),1,4) Else @InvoicePrefix End 
and		IsNull(AssetCode,'') = Case When @Asset <> '' Then @Asset Else IsNull(AssetCode,'') End 
And		IsNull(Finalize,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Finalize' Then 1 Else IsNull(Finalize,0) End 
And		IsNull(Verified,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Verified' Then 1 Else IsNull(Verified,0) End 
And		IsNull(Authorized,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Authorized' Then 1 Else IsNull(Authorized,0) End 
And		IsNull(Posted,0) = Case When IsNull(tblDefaults.LedgerPosting,'') = 'Posted' Then 1 Else IsNull(Posted,0) End 
And		tblDefaults.CompanyId = '0001' 
--and   Mst.Posted = 1
And 	tblAccounts.AccountType = Case When @AccountType <> 'All' Then @AccountType Else tblAccounts.AccountType End 

Select 	'OP' as BookType,CompanyId,' ' as VoucherNo,@DateFrom - 1 as VoucherDate,AccountCode,AccountName,' ' as OppAccount,'Balance B/F' as OppAccountName,' ' as AgainstAccount,' ' as AssetCode,
	' ' as ChequeNo,Null as ChequeDate,' ' as Description,SectorCode,
	Sum(Debit) as Debit,Sum(Credit) as Credit,' ' as PartyAccount
Into	#Temp3
From 	#Temp2 
Where   VoucherDate < @DateFrom
And		PartyAccount = Case When @PartyAccount = '' Then PartyAccount Else @Partyaccount End 
Group By CompanyId,AccountCode,AccountName,SectorCode
Union All
Select	'OP' as BookType,CompanyId,' ' as VoucherNo,@DateFrom - 1 as VoucherDate,tblOpeningBalance.AccountCode,AccountName,' ' as OppAccount,'Balance B/F' as OppAccountName,' ' as AgainstAccount, '' as AssetCode,
		' ' as ChequeNo,Null as ChequeDate,' ' as Description,tblOpeningBalance.Project,
		Sum(Case When IsNull(OpeningBalance,0) > 0 Then OpeningBalance Else 0 End) as Debit,Sum(Case When IsNull(OpeningBalance,0) < 0 Then Abs(OpeningBalance) Else 0 End) as Credit,' ' as PartyAccount
From	tblOpeningBalance,tblAccounts,tblProject,tblLocation,tblSector
Where	tblOpeningBalance.AccountCode = tblAccounts.AccountCode
And		tblOpeningBalance.Project = tblSector.Code
And		tblSector.Location = tblLocation.Code
And		tblLocation.Project = tblProject.Code
And   	tblOpeningBalance.Project = Case When @Sector <> 'All' then @Sector else tblOpeningBalance.Project end 
And   	tblSector.Location = Case When @Location <> 'All' then @Location else tblSector.Location end
And   	tblLocation.Project = Case When @Project <> 'All' then @Project else tblLocation.Project end	
Group By CompanyId,tblOpeningBalance.AccountCode,AccountName,tblOpeningBalance.Project

Select	BookType,CompanyId,VoucherNo,VoucherDate,AccountCode,AccountName,OppAccount,OppAccountName,AgainstAccount,' ' as ChequeNo,ChequeDate,Description,SectorCode,' ' as AssetCode,
		Sum(Debit) as Debit,Sum(Credit) as Credit,0 as Auto,' ' as PartyAccount
Into   	#Temp4
From 	#Temp3
Group By Booktype,CompanyId,VoucherNo,VoucherDate,AccountCode,AccountName,OppAccount,OppAccountName,AgainstAccount,ChequeNo,ChequeDate,Description,SectorCode

Select	Booktype,CompanyId,VoucherNo,VoucherDate,AccountCode,AccountName,OppAccount,OppAccountName,AgainstAccount,ChequeNo,ChequeDate,Description,
		Case When Debit - Credit > 0 then Debit - Credit else 0 end as Debit,
		Case When Credit - Debit > 0 Then Credit - Debit else 0 end as Credit,0 as ChqClear,Null as ChqClearDate,Null as BankStDate,'O' as EntryType,tblLocation.Project as ProjectCode,tblProject.Name as ProjectName,tblSector.Location as LocationCode,tblLocation.Name as LocationName,SectorCode,tblSector.Name as SectorName,' ' as Tag,' ' as EmployeeCode,Auto,0 as Finalize,AssetCode,' ' as InvoiceNo,PartyAccount,' ' as ProdCardNo
Into   	#MasterData
From 	#Temp4,tblProject,tblLocation,tblSector
Where	#Temp4.SectorCode = tblSector.Code
And	tblSector.Location = tblLocation.Code
And	tblLocation.Project = tblProject.Code 
Union All 
Select	BookType,CompanyId,VoucherNo,VoucherDate,#Temp2.AccountCode,#Temp2.AccountName,OppAccount,OppAccountName,AgainstAccount,ChequeNo,ChequeDate,tblAccounts.AccountName + Description as Description,
		Debit,Credit,ChqClear,ChqClearDate,BankStDate,EntryType,ProjectCode,ProjectName,LocationCode,LocationName,SectorCode,SectorName,Tag,EmployeeCode,Auto,Finalize,AssetCode,InvoiceNo,PartyAccount,ProdCardNo
From 	#Temp2,tblAccounts 
Where   VoucherDate Between @DateFrom and @DateUpto 
And		PartyAccount = Case When @PartyAccount = '' Then PartyAccount Else @Partyaccount End 
And		IsNull(PartyAccount,'') <> ''
And tblAccounts.AccountCode = #Temp2.Partyaccount
Union All
Select	BookType,CompanyId,VoucherNo,VoucherDate,#Temp2.AccountCode,#Temp2.AccountName,OppAccount,OppAccountName,AgainstAccount,ChequeNo,ChequeDate,Description as Description,
		Debit,Credit,ChqClear,ChqClearDate,BankStDate,EntryType,ProjectCode,ProjectName,LocationCode,LocationName,SectorCode,SectorName,Tag,EmployeeCode,Auto,Finalize,AssetCode,InvoiceNo,PartyAccount,ProdCardNo
From 	#Temp2
Where   VoucherDate Between @DateFrom and @DateUpto 
And		IsNull(PartyAccount,'') = ''

if @ReportType = 'Audit Trail'
	Begin
		Select    @CompanyId as CompanyId,Booktype,VoucherNo,VoucherDate,AccountCode,AccountName,ChequeNo,ChequeDate,Debit,Credit,Description,EntryType,ProjectName,LocationName,SectorName
		From 	 #MasterData 
		Where  	 Booktype <> 'OP'
		And	 AccountCode Between @AccountFrom and @AccountTo 
		And	 VoucherNo Between Case When @VoucherNoFrom = '' Then '000000000000000' Else @VoucherNoFrom End and Case When @VoucherNoTo = '' Then 'zzzzzzzzzzzzzzz' Else @VoucherNoTo End
		Order By CompanyId,VoucherNo,VoucherDate,Credit,AccountCode
	End

if @ReportType = 'General Ledger'
	Begin
		Select  @CompanyId as CompanyId,'OP' as BookType,VoucherNo,VoucherDate,#MasterData.AccountCode,ltrim(rtrim(AccountName)) + '  (' + #MasterData.AccountCode + ')' as AccountName,'' as OppAccount,'' as OppAccountName,
				'' as ChequeNo,'' as ChequeDate,0 as Debit,0 as Credit,Sum(Debit - Credit) as Balance,'Opening Balance ' as Description,0 as ChqClear,Null as ChqClearDate,Null as BankStDate,'' as EntryType,''as AgainstAccount,'' as  Tag
		Into	#GeneralLedger
		From 	#MasterData  
		Where	#MasterData.AccountCode Between @AccountFrom and @AccountTo 
		And		IsNull(Debit,0) + IsNull(Credit,0) <> 0 
		And		IsNull(BookType,'') = 'OP'
		Group By VoucherNo,VoucherDate,#MasterData.AccountCode,AccountName
		Union All		
		Select  @CompanyId as CompanyId,BookType,#MasterData.VoucherNo,VoucherDate,#MasterData.AccountCode,ltrim(rtrim(AccountName)) + '  (' + #MasterData.AccountCode + ')' as AccountName,OppAccount,OppAccountName,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,
				Ltrim(Rtrim(Isnull(#MasterData.Description,''))) + ' Tag : ' + IsNull( tblTagFile.Name,'') + Case When IsNull(tblFixedAsset.Description,'') <> '' Then ' Asset : ' + tblFixedAsset.Description Else '' End as Description,
				isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,IsNull( tblTagFile.Name,'') as Tag
		From 	#MasterData Left Outer Join tblTagFile
		On		#MasterData.Tag = tblTagFile.Code 
		Left Outer join tblFixedAsset On tblFixedAsset.AssetCode = #MasterData.AssetCode 
		Where	#MasterData.AccountCode Between @AccountFrom and @AccountTo 
		And		IsNull(AgainstAccount,'') = Case When @WithoutAgainstAccount = 1 Then '' Else IsNull(AgainstAccount,'') End 
		And		IsNull(Auto,0) =Case When @WithoutAgainstAccount = 1 Then 0 Else IsNull(Auto,0) End 
		And		IsNull(Debit,0) + IsNull(Credit,0) <> 0 
		And		IsNull(BookType,'') <> 'OP'
		
		Select * From #GeneralLedger Order By CompanyId,#GeneralLedger.AccountCode,VoucherDate,#GeneralLedger.VoucherNo
	End

if @ReportType = 'Trial Balance'
	Begin
		Select 	@CompanyId as CompanyId,Left(AccountCode,@AccountDigit) as AccountCode,
			Case When Sum(Debit) - Sum(Credit) > 0 then Sum(Debit) - Sum(Credit) else 0 end as Debit,
			Case When Sum(Debit) - Sum(Credit) < 0 then Sum(Credit) - Sum(Debit) else 0 end as Credit 
			Into #TrialBalance
			From #MasterData
		Group By CompanyId,AccountCode

		Select   '0001' as CompanyId,#TrialBalance.AccountCode,A.AccountName as AccountName,A.GroupAct,G.AccountName as GroupAccountName,
			Case When Sum(Debit) - Sum(Credit) > 0 then Sum(Debit) - Sum(Credit) else 0 end as Debit,
			Case When Sum(Debit) - Sum(Credit) < 0 then Sum(Credit) - Sum(Debit) else 0 end as Credit 
		Into	#Trial
		From 	#TrialBalance,tblAccounts A,tblAccounts as G
		Where 	#TrialBalance.AccountCode = A.AccountCode
		and	A.GroupAct  = G.AccountCode
		And	#TrialBalance.AccountCode Between @AccountFrom and @AccountTo 
		And	A.GroupAct = Case When @ControlAccount <> '' Then @ControlAccount Else A.GroupAct End 
		Group By #TrialBalance.CompanyId,A.GroupAct,A.AccountName,G.AccountName,#TrialBalance.AccountCode
		Order By CompanyId,#TrialBalance.AccountCode,AccountName,A.GroupAct,GroupAccountName

		if @ReportFilter = 'With Zero Balance'
			Begin 
				Select * From #Trial 
			End
		else
				Select * From #Trial where Debit + Credit <> 0
	End

if @ReportType = 'Consolidated Balance'
	Begin
		Select 	@CompanyId as CompanyId,Left(AccountCode,@AccountDigit) as AccountCode,
			Case When BookType = 'OP' Then Sum(Debit) Else 0 End as OPBalDebit,
			Case When BookType = 'OP' Then Sum(Credit) Else 0 End as OPBalCredit,
			Case When BookType = 'OP' Then Sum(Debit) - Sum(Credit)  Else 0 End as OPBal,
			Case When BookType <> 'OP' Then Sum(Debit) Else 0 End as ActBalDebit,
			Case When BookType <> 'OP' Then Sum(Credit) Else 0 End as ActBalCredit,
			Case When BookType <> 'OP' Then Sum(Debit) - Sum(Credit)  Else 0 End as ActBal,
			Sum(Debit) as ClosingBalDebit,Sum(Credit) as ClosingBalCredit,Sum(Debit) - Sum(Credit) as ClosingBal
		Into 	#ConsolidatedBalance
		From 	#MasterData
		Group By CompanyId,AccountCode,BookType
	
		Select   @CompanyId as CompanyId,#ConsolidatedBalance.AccountCode,AccountName,tblAccounts.GroupAct,
			Sum(OPBalDebit) as OPBalDebit,Sum(OPBalCredit) as OPBalCredit,Sum(OPBal) as OPBal,
			Sum(ActBalDebit) as ActBalDebit,Sum(ActBalCredit) as ActBalCredit,Sum(ActBal) as ActBal,
			Sum(ClosingBalDebit) as ClosingBalDebit,Sum(ClosingBalCredit) as ClosingBalCredit,Sum(ClosingBal) as ClosingBal
		Into 	#ConsBal
		From 	#ConsolidatedBalance,tblAccounts
		Where 	#ConsolidatedBalance.AccountCode = tblAccounts.AccountCode
		Group By #ConsolidatedBalance.CompanyId,#ConsolidatedBalance.AccountCode,AccountName,tblAccounts.GroupAct
		Order By CompanyId,#ConsolidatedBalance.AccountCode,AccountName
	
		if @ReportFilter = 'With Zero Balance'
			Begin 
				Select 	@CompanyId as CompanyId,#ConsBal.AccountCode,#ConsBal.AccountName,tblAccounts.AccountName as GroupAccountName,#ConsBal.GroupAct,
					OPBalDebit,OPBalCredit,OPBal,ActBalDebit,ActBalCredit,ActBal,ClosingBalDebit,ClosingBalCredit,ClosingBal
				From 	#ConsBal,tblAccounts 
				Where	#ConsBal.GroupAct = tblAccounts.AccountCode
				And	#ConsBal.GroupAct = Case When @ControlAccount <> '' Then @ControlAccount Else #ConsBal.GroupAct End 
				And	 #ConsBal.AccountCode Between @AccountFrom and @AccountTo 
				Order By CompanyId,#ConsBal.GroupAct,#ConsBal.AccountName
			End
		else
				Select 	@CompanyId as CompanyId,#ConsBal.AccountCode,#ConsBal.AccountName,tblAccounts.AccountName as GroupAccountName,#ConsBal.GroupAct,
					OPBalDebit,OPBalCredit,OPBal,ActBalDebit,ActBalCredit,ActBal,ClosingBalDebit,ClosingBalCredit,ClosingBal
				From 	#ConsBal,tblAccounts 
				Where	#ConsBal.GroupAct = tblAccounts.AccountCode
				And	#ConsBal.GroupAct = Case When @ControlAccount <> '' Then @ControlAccount Else #ConsBal.GroupAct End 
				And	 #ConsBal.AccountCode Between @AccountFrom and @AccountTo 
				And 	ClosingBal <> 0
				Order By CompanyId,#ConsBal.GroupAct,#ConsBal.AccountName
	
	End

if @ReportType = 'Consolidated Balance Detail'
	Begin
		Select 	@CompanyId as CompanyId,Left(AccountCode,@AccountDigit) as AccountCode,
			Case When BookType = 'OP' Then Sum(Debit) Else 0 End as OPBalDebit,
			Case When BookType = 'OP' Then Sum(Credit) Else 0 End as OPBalCredit,
			Case When BookType = 'OP' Then Sum(Debit) - Sum(Credit)  Else 0 End as OPBal,
			Case When BookType <> 'OP' Then Sum(Debit) Else 0 End as ActBalDebit,
			Case When BookType <> 'OP' Then Sum(Credit) Else 0 End as ActBalCredit,
			Case When BookType <> 'OP' Then Sum(Debit) - Sum(Credit)  Else 0 End as ActBal,
			Sum(Debit) as ClosingBalDebit,Sum(Credit) as ClosingBalCredit,Sum(Debit) - Sum(Credit) as ClosingBal,Tag,ProdCardNo
		Into 	#ConsolidatedBalanceDetail
		From 	#MasterData
		Group By CompanyId,AccountCode,BookType,Tag,ProdCardNo
	
		Select   @CompanyId as CompanyId,#ConsolidatedBalanceDetail.AccountCode,Ltrim(Rtrim(AccountName)) as AccountName,IsNull(ProdCardNo,'') as Description,tblAccounts.GroupAct,
				Sum(OPBalDebit) as OPBalDebit,Sum(OPBalCredit) as OPBalCredit,Sum(OPBal) as OPBal,
				Sum(ActBalDebit) as ActBalDebit,Sum(ActBalCredit) as ActBalCredit,Sum(ActBal) as ActBal,
				Sum(ClosingBalDebit) as ClosingBalDebit,Sum(ClosingBalCredit) as ClosingBalCredit,Sum(ClosingBal) as ClosingBal,ProdCardNo
		Into 	#ConsBalDetail
		From 	#ConsolidatedBalanceDetail Left Outer Join tblTagFile On tblTagFile.Code = #ConsolidatedBalanceDetail.Tag,tblAccounts
		Where 	tblAccounts.AccountCode = #ConsolidatedBalanceDetail.AccountCode
		Group By #ConsolidatedBalanceDetail.CompanyId,#ConsolidatedBalanceDetail.AccountCode,AccountName,tblAccounts.GroupAct,ProdCardNo
		Order By CompanyId,#ConsolidatedBalanceDetail.AccountCode,AccountName
	
		if @ReportFilter = 'With Zero Balance'
			Begin 
				Select 	@CompanyId as CompanyId,#ConsBalDetail.AccountCode,#ConsBalDetail.AccountName,tblAccounts.AccountName as GroupAccountName,#ConsBalDetail.GroupAct,
					OPBalDebit,OPBalCredit,OPBal,ActBalDebit,ActBalCredit,ActBal,ClosingBalDebit,ClosingBalCredit,ClosingBal,Description,ProdCardNo
				From 	#ConsBalDetail,tblAccounts 
				Where	#ConsBalDetail.GroupAct = tblAccounts.AccountCode
				And	#ConsBalDetail.GroupAct = Case When @ControlAccount <> '' Then @ControlAccount Else #ConsBalDetail.GroupAct End 
				And	 #ConsBalDetail.AccountCode Between @AccountFrom and @AccountTo 
				Order By CompanyId,#ConsBalDetail.AccountCode,#ConsBalDetail.ProdCardNo
			End
		else
				Select 	@CompanyId as CompanyId,#ConsBalDetail.AccountCode,#ConsBalDetail.AccountName,tblAccounts.AccountName as GroupAccountName,#ConsBalDetail.GroupAct,
					OPBalDebit,OPBalCredit,OPBal,ActBalDebit,ActBalCredit,ActBal,ClosingBalDebit,ClosingBalCredit,ClosingBal,Description,ProdCardNo
				From 	#ConsBalDetail,tblAccounts 
				Where	#ConsBalDetail.GroupAct = tblAccounts.AccountCode
				And	#ConsBalDetail.GroupAct = Case When @ControlAccount <> '' Then @ControlAccount Else #ConsBalDetail.GroupAct End 
				And	 #ConsBalDetail.AccountCode Between @AccountFrom and @AccountTo 
				And 	ClosingBal <> 0
				Order By CompanyId,#ConsBalDetail.AccountCode,#ConsBalDetail.ProdCardNo
	
	End
if @ReportType = 'Periodic Activity'
	Begin

		Select 	@CompanyId as CompanyId,BookType,case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(AccountCode,@AccountDigit) as AccountCode,Debit - Credit as Balance,Debit,Credit
			Into #PeriodActivity1
			From #MasterData 
		

		Select   @CompanyId as CompanyId,#PeriodActivity1.AccountCode,AccountName,AccountType,
			Case When BookType = 'OP' then Balance else 0 end as Opening,
			Case When VoucherMonth = 1   then Debit else 0 End as JanuaryDebit,
			Case When VoucherMonth = 2   then Debit else 0 End as FebuaryDebit,
			Case When VoucherMonth = 3   then Debit else 0 End as MarchDebit,		
			Case When VoucherMonth = 4   then Debit else 0 End as AprilDebit,
			Case When VoucherMonth = 5   then Debit else 0 End as MayDebit,
			Case When VoucherMonth = 6   then Debit else 0 End as JuneDebit,
			Case When VoucherMonth = 7   then Debit else 0 End as JulyDebit,
			Case When VoucherMonth = 8   then Debit else 0 End as AugustDebit,
			Case When VoucherMonth = 9   then Debit else 0 End as SeptemberDebit,
			Case When VoucherMonth = 10  then Debit else 0 End as OctoberDebit,
			Case When VoucherMonth = 11  then Debit else 0 End as NovemberDebit,
			Case When VoucherMonth = 12  then Debit else 0 End as DecemberDebit,
			Case When VoucherMonth = 1   then Credit else 0 End as JanuaryCredit,
			Case When VoucherMonth = 2   then Credit else 0 End as FebuaryCredit,
			Case When VoucherMonth = 3   then Credit else 0 End as MarchCredit,		
			Case When VoucherMonth = 4   then Credit else 0 End as AprilCredit,
			Case When VoucherMonth = 5   then Credit else 0 End as MayCredit,
			Case When VoucherMonth = 6   then Credit else 0 End as JuneCredit,
			Case When VoucherMonth = 7   then Credit else 0 End as JulyCredit,
			Case When VoucherMonth = 8   then Credit else 0 End as AugustCredit,
			Case When VoucherMonth = 9   then Credit else 0 End as SeptemberCredit,
			Case When VoucherMonth = 10  then Credit else 0 End as OctoberCredit,
			Case When VoucherMonth = 11  then Credit else 0 End as NovemberCredit,
			Case When VoucherMonth = 12  then Credit else 0 End as DecemberCredit,
			Case When VoucherMonth = 1   then Balance else 0 End as January,
			Case When VoucherMonth = 2   then Balance else 0 End as Febuary,
			Case When VoucherMonth = 3   then Balance else 0 End as March,		
			Case When VoucherMonth = 4   then Balance else 0 End as April,
			Case When VoucherMonth = 5   then Balance else 0 End as May,
			Case When VoucherMonth = 6   then Balance else 0 End as June,
			Case When VoucherMonth = 7   then Balance else 0 End as July,
			Case When VoucherMonth = 8   then Balance else 0 End as August,
			Case When VoucherMonth = 9   then Balance else 0 End as September,
			Case When VoucherMonth = 10 then Balance else 0 End as October,
			Case When VoucherMonth = 11 then Balance else 0 End as November,
			Case When VoucherMonth = 12 then Balance else 0 End as December,
			Balance as ClosingBalance				
			Into #PeriodActivity2
			From #PeriodActivity1,tblAccounts
			Where #PeriodActivity1.AccountCode = tblAccounts.AccountCode 
	
		Select   @CompanyId as CompanyId,AccountCode,AccountName,AccountType,	
			Sum(Opening) as Opening,
			Sum(July) as July,Sum(August) as August,Sum(September) as September,
			Sum(October) as October,Sum(November) as November,Sum(December) as December,
			Sum(January) as January,Sum(Febuary) as Febuary,Sum(March) as March,
			Sum(April) as April,Sum(May) as May,Sum(June) as June,
			Sum(JulyDebit) as JulyDebit,Sum(AugustDebit) as AugustDebit,Sum(SeptemberDebit) as SeptemberDebit,
			Sum(OctoberDebit) as OctoberDebit,Sum(NovemberDebit) as NovemberDebit,Sum(DecemberDebit) as DecemberDebit,
			Sum(JanuaryDebit) as JanuaryDebit,Sum(FebuaryDebit) as FebuaryDebit,Sum(MarchDebit) as MarchDebit,
			Sum(AprilDebit) as AprilDebit,Sum(MayDebit) as MayDebit,Sum(JuneDebit) as JuneDebit,
			Sum(JulyCredit) as JulyCredit,Sum(AugustCredit) as AugustCredit,Sum(SeptemberCredit) as SeptemberCredit,
			Sum(OctoberCredit) as OctoberCredit,Sum(NovemberCredit) as NovemberCredit,Sum(DecemberCredit) as DecemberCredit,
			Sum(JanuaryCredit) as JanuaryCredit,Sum(FebuaryCredit) as FebuaryCredit,Sum(MarchCredit) as MarchCredit,
			Sum(AprilCredit) as AprilCredit,Sum(MayCredit) as MayCredit,Sum(JuneCredit) as JuneCredit,
			Sum(ClosingBalance) as ClosingBalance
		From 	#PeriodActivity2
		Where	 AccountCode Between @AccountFrom and @AccountTo 
		Group by CompanyId,AccountCode,AccountName,AccountType
		Order By AccountType,AccountCode

	End

if @ReportType = 'Bank Rec'
	Begin
		Select   CompanyId,BookType,VoucherNo,VoucherDate,AccountCode,ltrim(rtrim(AccountName)) + '  (' + AccountCode + ')' as AccountName,OppAccount,OppAccountName,
			ChequeNo,ChequeDate,Debit,Credit,Description,ChqClear,ChqClearDate,BankStDate,EntryType
		From 	#MasterData 
		Where 	BookType <> 'OP' 
		And	AccountCode Between @AccountFrom and @AccountTo 
		Order By CompanyId,AccountCode,VoucherDate
	End 

if @ReportType = 'Bank Rec1'
	Begin
		Select   CompanyId,BookType,VoucherNo,VoucherDate,AccountCode,ltrim(rtrim(AccountName)) + '  (' + AccountCode + ')' as AccountName,OppAccount,OppAccountName,
			ChequeNo,ChequeDate,Debit,Credit,Description,ChqClear,ChqClearDate,BankStDate,EntryType
		From 	#MasterData 
		Where 	BookType <> 'OP' 
		And 	IsNull(chqclear,0) = 0
		And	AccountCode Between @AccountFrom and @AccountTo 
		Order By CompanyId,AccountCode,VoucherDate
	End 

if @ReportType = 'Bank Rec Summ'
	Begin 
		Select   AccountCode,AccountName,
			Case When BookType = 'OP' Then Debit -Credit Else 0 End as OpeningBalance,
			Case When BookType <> 'OP' then Debit else 0 end as Receipts,
			Case When BookType <> 'OP' then Credit else 0 end as Payments,
			Debit - Credit as ClosingBalance,
			Case When isnull(ChqClear,0) = 0 then Debit else 0 end as ChqNotCleared,
			Case When isnull(ChqClear,0) = 0 then Debit else 0 end as ChqNotPresent
		Into #BankRec
		From #MasterData

		Select   AccountCode,AccountName,
			Sum(OpeningBalance) as OpeningBalance,Sum(Receipts) as Receipts,
			Sum(Payments) as Payments,Sum(OpeningBalance) + Sum(Receipts) - Sum(Payments) as ClosingBalance,
			Sum(ChqNotCleared) as ChqNotCleared,Sum(ChqNotPresent) as ChqNotPresent
		From #BankRec
		Where	AccountCode Between @AccountFrom and @AccountTo 
		Group By AccountCode,AccountName
			
	End 
if @ReportType = 'Liquidity Report'
	Begin
		Select 	@CompanyId as CompanyId,#MasterData.AccountCode as AccountCode,tblAccounts.AccountName,GroupAct,#MasterData.ProjectName,
			Case When BookType = 'OP' then Sum(Debit) - Sum(Credit) else 0 end as OpeningBalance,
			Sum(Case When Debit > 0  and BookType <> 'OP' then Debit else 0 end) as Debit,
			Sum(Case When Credit > 0  and BookType <> 'OP' then Credit else 0 end) as Credit,CreditLimit as Limit
			Into #LiquidityReport
			From #MasterData,tblAccounts
			Where GroupAct Between @AccountFrom And @AccountTo 
			And     #MasterData.AccountCode = tblAccounts.AccountCode 
			And     (tblAccounts.AccountType = 'Cash Book' or tblAccounts.AccountType = 'Bank Book')
		Group By CompanyId,#MasterData.AccountCode,tblaccounts.AccountName,Creditlimit,GroupAct,BookType,#MasterData.ProjectName

		Select   #LiquidityReport.AccountCode,#LiquidityReport.AccountName,#LiquidityReport.GroupAct,tblAccounts.AccountName as GroupName,#LiquidityReport.ProjectName,
			Sum(#LiquidityReport.OpeningBalance) as OpeningBalance,Sum(#LiquidityReport.Debit) as Debit,Sum(#LiquidityReport.Credit) as Credit,
			Sum(#LiquidityReport.Debit - #LiquidityReport.Credit) as IncDcr,Sum(OpeningBalance + Debit - Credit) as YearToDate,Max(#LiquidityReport.Limit) as Limit,Max(#LiquidityReport.Limit) + Sum(OpeningBalance + Debit - Credit) as Availibility
		From 	#LiquidityReport,tblAccounts
		Where 	#LiquidityReport.GroupAct = tblAccounts.AccountCode 
		And	#LiquidityReport.AccountCode Between @AccountFrom and @AccountTo 
		Group By #LiquidityReport.AccountCode,#LiquidityReport.AccountName,#LiquidityReport.GroupAct,tblAccounts.AccountName,#LiquidityReport.ProjectName
		Order By #LiquidityReport.ProjectName,#LiquidityReport.AccountCode
	End

if @ReportType = 'Liquidity Report Cons'
	Begin
		Select 	@CompanyId as CompanyId,#MasterData.AccountCode as AccountCode,tblAccounts.AccountName,GroupAct,#MasterData.ProjectName,
			Case When BookType = 'OP' then Sum(Debit) - Sum(Credit) else 0 end as OpeningBalance,
			Sum(Case When Debit > 0  and BookType <> 'OP' then Debit else 0 end) as Debit,
			Sum(Case When Credit > 0  and BookType <> 'OP' then Credit else 0 end) as Credit,CreditLimit as Limit
			Into #LiquidityReportCons
			From #MasterData,tblAccounts
			Where GroupAct Between @AccountFrom And @AccountTo 
			And     #MasterData.AccountCode = tblAccounts.AccountCode 
			And     (tblAccounts.AccountType = 'Cash Book' or tblAccounts.AccountType = 'Bank Book')
		Group By CompanyId,#MasterData.AccountCode,tblaccounts.AccountName,Creditlimit,GroupAct,BookType,#MasterData.ProjectName

		Select   #LiquidityReportCons.AccountCode,#LiquidityReportCons.AccountName,#LiquidityReportCons.GroupAct,tblAccounts.AccountName as GroupName,
				Sum(#LiquidityReportCons.OpeningBalance) as OpeningBalance,Sum(#LiquidityReportCons.Debit) as Debit,Sum(#LiquidityReportCons.Credit) as Credit,
				Sum(#LiquidityReportCons.Debit - #LiquidityReportCons.Credit) as IncDcr,Sum(OpeningBalance + Debit - Credit) as YearToDate,Max(#LiquidityReportCons.Limit) as Limit,Max(#LiquidityReportCons.Limit) + Sum(OpeningBalance + Debit - Credit) as Availibility,'' as ProjectName
		From 	#LiquidityReportCons,tblAccounts
		Where 	#LiquidityReportCons.GroupAct = tblAccounts.AccountCode 
		And		#LiquidityReportCons.AccountCode Between @AccountFrom and @AccountTo 
		Group By #LiquidityReportCons.AccountCode,#LiquidityReportCons.AccountName,#LiquidityReportCons.GroupAct,tblAccounts.AccountName
		Order By #LiquidityReportCons.AccountCode
	End

if @ReportType = 'Department Report'
	Begin
		Select 	@CompanyId as CompanyId,#MasterData.AccountCode as AccountCode,tblAccounts.AccountName,GroupAct,
			Case When BookType = 'OP' then Sum(Debit) - Sum(Credit) else 0 end as OpeningBalance,
			Sum(Case When Debit > 0  and BookType <> 'OP' then Debit else 0 end) as Debit,
			Sum(Case When Credit > 0  and BookType <> 'OP' then Credit else 0 end) as Credit,CreditLimit as Limit
			Into #DepartmentReport
			From #MasterData,tblAccounts
			Where GroupAct Between @AccountFrom And @AccountTo 
			And     #MasterData.AccountCode = tblAccounts.AccountCode 
			And     IsNull(tblAccounts.Department,0) = 1
		Group By CompanyId,#MasterData.AccountCode,tblaccounts.AccountName,Creditlimit,GroupAct,BookType

		Select   #DepartmentReport.AccountCode,#DepartmentReport.AccountName,#DepartmentReport.GroupAct,tblAccounts.AccountName as GroupName,
			Sum(#DepartmentReport.OpeningBalance) as OpeningBalance,Sum(#DepartmentReport.Debit) as Debit,Sum(#DepartmentReport.Credit) as Credit,
			Sum(#DepartmentReport.Debit - #DepartmentReport.Credit) as IncDcr,Sum(OpeningBalance + Debit - Credit) as YearToDate,Max(#DepartmentReport.Limit) as Limit,Max(#DepartmentReport.Limit) + Sum(OpeningBalance + Debit - Credit) as Availibility
		From 	#DepartmentReport,tblAccounts
		Where 	#DepartmentReport.GroupAct = tblAccounts.AccountCode 
		And	#DepartmentReport.AccountCode Between @AccountFrom and @AccountTo 
		Group By #DepartmentReport.AccountCode,#DepartmentReport.AccountName,#DepartmentReport.GroupAct,tblAccounts.AccountName
	End

if @ReportType = 'Markup Report'
	Begin
		Select 	@CompanyId as CompanyId,Case When BookType <> 'OP' Then VoucherDate Else VoucherDate + 1 End as VoucherDate,#MasterData.AccountCode as AccountCode,tblAccounts.AccountName,GroupAct,
			Case When BookType = 'OP' then Debit - Credit else 0 end as OpeningBalance,
			Case When Debit > 0  and BookType <> 'OP' then Debit else 0 end as Debit,
			Case When Credit > 0  and BookType <> 'OP' then Credit else 0 end as Credit
			Into #Markup
			From #MasterData,tblAccounts
			Where GroupAct Between @AccountFrom And @AccountTo 
			And     #MasterData.AccountCode = tblAccounts.AccountCode 
			And     IsNull(tblAccounts.Markup,0) = 1
			And    AccountType <> 'Bank Book'
		Select 	CompanyId,VoucherDate,AccountCode,AccountName,GroupAct,Sum(OpeningBalance) as OpeningBalance,Sum(Debit) as Debit,Sum(Credit) as Credit,Sum(OpeningBalance+ Debit - Credit) as Balance 
			into #Markup1
			From #Markup
		Group by CompanyId,VoucherDate,AccountCode,AccountName,GroupAct
		
		Select 	u.AccountCode, a.AccountName, u.[Date], u.MarkupRate,  isnull((Select sum(balance) from #Markup1 where voucherDate <= u.[Date] and AccountCode = u.AccountCode),0) as cBalance, round(isnull(((((Select sum(balance) from #Markup1 where voucherDate <= u.[Date] and AccountCode = u.AccountCode) * u.MarkupRate) /100)/365),0),2) as Markup
			
			From tblMarkupRate as u Left outer join tblAccounts a on u.AccountCode = a.AccountCode
			where CompanyId = @companyId
			order by u.[Date]
				
	End
if @ReportType = 'AnalysisOfBudgetAssets'
	Begin
		Select 	@CompanyId as CompanyId,A.AccountCode,A.AccountName,A.AccountLevel,
			Case When Sum(Debit) - Sum(Credit) > 0 then Sum(Debit) - Sum(Credit) else 0 end as Debit,			
			Case When Sum(Debit) - Sum(Credit) < 0 then Sum(Credit) - Sum(Debit) else 0 end as Credit,
			Sum(Debit) - Sum(Credit) as Balance, Case When Sum(Debit) - Sum(Credit) > 0 Then 'DR' else 'CR' End As BalType
		Into #AnalysisOfBudgetAssets			
		From #MasterData Mst Right Outer Join tblAccounts A
		On A.AccountCode = Left(Mst.AccountCode,Len( A.AccountCode))
		Where	A.AccountLevel = 'Control' And Len(A.AccountCode) <= @AccountDigit And AccountNature > 0 And AccountNature < 4
		Group By A.AccountCode,A.AccountName,A.AccountLevel
		Union All
		Select 	@CompanyId as CompanyId,A.AccountCode,A.AccountName,A.AccountLevel,
			Case When Sum(Debit) - Sum(Credit) > 0 then Sum(Debit) - Sum(Credit) else 0 end as Debit,			
			Case When Sum(Debit) - Sum(Credit) < 0 then Sum(Credit) - Sum(Debit) else 0 end as Credit,
			Sum(Debit) - Sum(Credit) as Balance, Case When Sum(Debit) - Sum(Credit) > 0 Then 'DR' else 'CR' End As BalType
		From #MasterData Mst Right Outer Join tblAccounts A
		On A.AccountCode = Left(Mst.AccountCode,Len( A.AccountCode))
		Where	Len(A.AccountCode) <= @AccountDigit And AccountNature > 0 And AccountNature < 4 And A.AccountLevel = 'Detail'
		Group By A.AccountCode,A.AccountName,A.AccountLevel
		Order By A.AccountCode

--		Select 	@CompanyId as CompanyId,Left(Mst.AccountCode,@AccountDigit) as AccountCode,A.AccountName,A.AccountLevel,
--			Case When Sum(Debit) - Sum(Credit) > 0 then Sum(Debit) - Sum(Credit) else 0 end as Debit,			
--			Case When Sum(Debit) - Sum(Credit) < 0 then Sum(Credit) - Sum(Debit) else 0 end as Credit,
--			Sum(Debit) - Sum(Credit) as Balance, Case When Sum(Debit) - Sum(Credit) > 0 Then 'DR' else 'CR' End As BalType
--		Into #AnalysisOfBudgetAssets
--		From #MasterData Mst Left Outer Join tblAccounts A
--		On A.AccountCode =Left(Mst.AccountCode,@AccountDigit)
--		Where	A.AccountNature > 0 And A.AccountNature < 4 --And A.AccountLevel = 'Detail'
--		Group By Left(Mst.AccountCode,@AccountDigit),A.AccountName,A.AccountLevel
--		Order By A.AccountCode

		Select 	Mst.CompanyID,Mst.AccountCode,Space(A.ActLevelDigit*2)+Mst.AccountName as AccountName,Mst.AccountLevel,Isnull(A.TobeMaintain,0) as TobeMaintain,Abs(Mst.Balance) as Balance,Mst.BalType,Abs(Mst.Balance) - Isnull(A.TobeMaintain,0)  as [Difference], Case When Abs(Mst.Balance) - Isnull(A.TobeMaintain,0) = 0 Then 'N' Else Case When Abs(Mst.Balance) - Isnull(A.TobeMaintain,0) > 0 Then 'P' Else 'N' End End as Status
		From #AnalysisOfBudgetAssets Mst,tblAccounts A
		Where	Mst.AccountCode = A.AccountCode
		And	Mst.AccountCode Between @AccountFrom and @AccountTo 
		Order By Mst.AccountCode
	End
if @ReportType = 'AnalysisOfBudgetRE'
	Begin 
		Select 	@CompanyId as CompanyId,A.AccountCode,A.AccountName,A.AccountLevel,
			Case When Sum(Debit) - Sum(Credit) > 0 then Sum(Debit) - Sum(Credit) else 0 end as Debit,			
			Case When Sum(Debit) - Sum(Credit) < 0 then Sum(Credit) - Sum(Debit) else 0 end as Credit,
			Sum(Debit) - Sum(Credit) as Balance, Case When Sum(Debit) - Sum(Credit) > 0 Then 'DR' else 'CR' End As BalType
			Into #AnalysisOfBudgetRE
		From #MasterData Mst Right Outer Join tblAccounts A
		On A.AccountCode = Left(Mst.AccountCode,Len( A.AccountCode))
		Where	A.AccountLevel = 'Control' And Len(A.AccountCode) <= @AccountDigit And AccountNature > 3 And AccountNature < 6
		Group By A.AccountCode,A.AccountName,A.AccountLevel
		Union All
		Select 	@CompanyId as CompanyId,A.AccountCode,A.AccountName,A.AccountLevel,
			Case When Sum(Debit) - Sum(Credit) > 0 then Sum(Debit) - Sum(Credit) else 0 end as Debit,			
			Case When Sum(Debit) - Sum(Credit) < 0 then Sum(Credit) - Sum(Debit) else 0 end as Credit,
			Sum(Debit) - Sum(Credit) as Balance, Case When Sum(Debit) - Sum(Credit) > 0 Then 'DR' else 'CR' End As BalType
		From #MasterData Mst Right Outer Join tblAccounts A
		On A.AccountCode = Left(Mst.AccountCode,Len( A.AccountCode))
		Where	A.AccountLevel = 'Detail' And Len(A.AccountCode) <= @AccountDigit And AccountNature > 3 And AccountNature < 6
		Group By A.AccountCode,A.AccountName,A.AccountLevel
		Order By A.AccountCode
		
		Select 	Mst.CompanyID,Mst.AccountCode,Space(A.ActLevelDigit*2)+Mst.AccountName as AccountName,Mst.AccountLevel,A.BudgetPerYear,
		Case 	When Month(@DateUpto) = 7 Then July
			When Month(@DateUpto) = 8 Then July + August
			When Month(@DateUpto) = 9 Then July + August + September
			When Month(@DateUpto) = 10 Then July + August + September + October
			When Month(@DateUpto) = 11 Then July + August + September + October + November
			When Month(@DateUpto) = 12 Then July + August + September + October + November + December
			When Month(@DateUpto) = 1 Then July + August + September + October + November + December + January
			When Month(@DateUpto) = 2 Then July + August + September + October + November + December + January + February
			When Month(@DateUpto) = 3 Then July + August + September + October + November + December + January + February + March 
			When Month(@DateUpto) = 4 Then July + August + September + October + November + December + January + February + March + April
			When Month(@DateUpto) = 5 Then July + August + September + October + November + December + January + February + March + April + May
			When Month(@DateUpto) = 6 Then July + August + September + October + November + December + January + February + March + April + May + June
		End as BudgetAmount,Mst.Balance as Balance,isnull(A.BudgetPerYear,0) - isnull(Mst.Balance,0) as [Difference]
		From #AnalysisOfBudgetRE Mst,tblAccounts A
		Where	Mst.AccountCode = A.AccountCode		
		And	Mst.AccountCode Between @AccountFrom and @AccountTo 
	End

if @ReportType = 'Balance Sheet'
	Begin
		Select   @CompanyId as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit) as AccountCode,
			ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature
		Into	#BS
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto 
		And	#MasterData.AccountCode = tblAccounts.AccountCode 

		Select 	VoucherNo,VoucherDate,AccountCode,
			Debit - Credit as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,7 as M,
			Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		Into	#BS1 
		From 	#BS
		Where 	VoucherDate < = Cast('7/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('7/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,Debit - Credit as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,8 as M,
			0 as July,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June

		From 	#BS
		Where 	VoucherDate < = Cast('8/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('8/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,Debit - Credit as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,9 as M,
			0 as July,0 as August,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('9/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('9/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,Debit - Credit as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,10 as M,
			0 as July,0 as August,0 as September,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('10/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('10/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,Debit - Credit as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,11 as M,
			0 as July,0 as August,0 as September,0 as October,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('11/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('11/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,Debit - Credit as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,12 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('12/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('12/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			Debit - Credit as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,1 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('1/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('1/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,Debit - Credit as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,2 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('2/28/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('2/28/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,Debit - Credit as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,3 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as March,0 as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('3/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('3/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,Debit - Credit as AprilBal,0 as MayBal,0 as JuneBal,4 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as April,0 as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('4/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('4/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,Debit - Credit as MayBal,0 as JuneBal,5 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as May,0 as June
		From 	#BS
		Where 	VoucherDate < = Cast('5/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('5/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,Debit - Credit as JuneBal,6 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as June
		From 	#BS
		Where 	VoucherDate < = Cast('6/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('6/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		
		
		Select 	#BS1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,
			Sum(#BS1.JulyBal) as JulyBal,Sum(#BS1.AugustBal) as AugustBal,Sum(#BS1.SeptemberBal) as SeptemberBal,Sum(#BS1.OctoberBal) as OctoberBal,Sum(#BS1.NovemberBal) as NovemberBal,Sum(#BS1.DecemberBal) as DecemberBal,
			Sum(#BS1.JanuaryBal) as JanuaryBal,Sum(#BS1.FebuaryBal) as FebuaryBal,Sum(#BS1.MarchBal) as MarchBal,Sum(#BS1.AprilBal) as AprilBal,Sum(#BS1.MayBal) as MayBal,Sum(#BS1.JuneBal) as JuneBal,IsNull(tblAccounts.Department,0) as InterProject,
			Sum(#BS1.July) as July,Sum(#BS1.August) as August,Sum(#BS1.September) as September,Sum(#BS1.October) as October,Sum(#BS1.November) as November,Sum(#BS1.December) as December,
			Sum(#BS1.January) as January,Sum(#BS1.Febuary) as Febuary,Sum(#BS1.March) as March,Sum(#BS1.April) as April,Sum(#BS1.May) as May,Sum(#BS1.June) as June,tblAccounts.AccountNature
		Into 	#BS2
		From	#BS1,tblAccounts
		Where	#BS1.AccountCode = tblAccounts.AccountCode
		Group By #BS1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,IsNull(tblAccounts.Department,0),tblAccounts.AccountNature
		
		
		Select 	#BS2.*,Case When InterProject = 1 Then ' ' Else tblAccounts.AccountName End as GroupActName,Case When InterProject = 1 then 'INTER PROJECT' Else Case When #BS2.AccountNature = 1 Then 'ASSETS' Else Case When #BS2.AccountNature = 2 Then 'LIABILITIES ' Else  'EQUITIES' End End End as Type
		From	#BS2,tblAccounts
		Where 	#BS2.GroupAct = tblAccounts.AccountCode
--		And	(Substring(#BS2.AccountCode,1,2) = '01' or Substring(#BS2.AccountCode,1,2) = '02' or Substring(#BS2.AccountCode,1,2) = '03')
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		Order By InterProject,Type,GroupAct,tblAccounts.AccountCode,#BS2.AccountName 
	End

if @ReportType = 'Balance Sheet Cons'
	Begin
		Select   @CompanyId as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(AccountCode,@AccountDigit) as AccountCode,
			ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount
		Into	#BSCons1
		From	#MasterData
		Where 	VoucherDate <= @DateUpto 
			
		Select 	#BSCons1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,Sum(#BSCons1.Balance) as Balance,AccountNature
		Into 	#BSCons2
		From	#BSCons1,tblAccounts
		Where	#BSCons1.AccountCode = tblAccounts.AccountCode
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)		
		Group By #BSCons1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,AccountNature
		
		
		Select 	#BSCons2.*,tblAccounts.AccountName as GroupActName,Case When #BSCons2.AccountNature = 1 Then 'ASSETS' Else Case When #BSCons2.AccountNature = 2 Then 'LIABILITIES ' Else  'EQUITIES' End End as Type,Balance
		From	#BSCons2,tblAccounts
		Where 	#BSCons2.GroupAct = tblAccounts.AccountCode
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		And		#BSCOns2.Balance <> 0 
		Order By Type,GroupAct,tblAccounts.AccountCode,AccountNature
	End


if @ReportType = 'EmployeeWiseReport'
	Begin
			
		Select Mst.EmployeeCode,E.EmployeeName,CompanyID,VoucherNo,VoucherDate,Description,Sum(Debit) as Amount 
		From #MasterData Mst 
		Left Outer Join PayRoll2009.dbo.tblEmployee E
		on E.EmployeeCode = Mst.EmployeeCode
		Where Mst.EmployeeCode <> '' 
		and isnull(Mst.EmployeeCode,'') <> ''
		--And Isnull(Mst.Tag,'')<>'' 
		and Left(AccountCode,Len(@ControlAccount)) =@ControlAccount
		and Mst.EmployeeCode = Case When @Employee <> '' Then @Employee Else IsNull(Mst.EmployeeCode,'') End 
		And (BookType = 'BBP' or BookType = 'CBP' or BookType ='JV')
		Group By Mst.EmployeeCode,E.EmployeeName,CompanyID,VoucherNo,VoucherDate,Description
		Having Sum(Debit) > 0
	End

if @ReportType = 'TagWiseReport'
	Begin
				
		Select TF.Code as TagCode,TF.Name as TagName,CompanyID,VoucherNo,VoucherDate,Description,Sum(Debit) as Debit,Sum(Credit) as Credit,AccountCode,AccountName 
		from tblTagFile TF
		Left Outer Join #MasterData Mst 
		On TF.Code = Isnull(Mst.Tag,'') 
		Where Mst.Tag = Case When @Tag <> '' Then @Tag Else IsNull(Mst.Tag,'') End 
		and Left(AccountCode,Len(@ControlAccount)) =@ControlAccount
		And (BookType = 'BBP' or BookType = 'CBP' or BookType = 'JV')
		Group By TF.Code,TF.Name,CompanyID,VoucherNo,VoucherDate,Description,AccountCode,AccountName
		Order By TF.Code,AccountCode
	End

if @ReportType= 'ExpenseReport'
	Begin
		Select 	@CompanyId as CompanyId,BookType, Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(Mst.AccountCode,@AccountDigit) as AccountCode,Debit - Credit as Balance
		Into 	#Expense1
		From 	#MasterData Mst,tblAccounts
		Where 	Mst.AccountCode = tblAccounts.AccountCode 
		And		tblAccounts.AccountNature = 5
		And		BookType <> 'OP'

		Select   @CompanyId as CompanyId,#Expense1.AccountCode as AccountCode,AccountName,
			Case When VoucherMonth = 1   then Balance else 0 End as January,
			Case When VoucherMonth = 2   then Balance else 0 End as February,
			Case When VoucherMonth = 3   then Balance else 0 End as March,		
			Case When VoucherMonth = 4   then Balance else 0 End as April,
			Case When VoucherMonth = 5   then Balance else 0 End as May,
			Case When VoucherMonth = 6   then Balance else 0 End as June,
			Case When VoucherMonth = 7   then Balance else 0 End as July,
			Case When VoucherMonth = 8   then Balance else 0 End as August,
			Case When VoucherMonth = 9   then Balance else 0 End as September,
			Case When VoucherMonth = 10 then Balance else 0 End as October,
			Case When VoucherMonth = 11 then Balance else 0 End as November,
			Case When VoucherMonth = 12 then Balance else 0 End as December,
			Balance as ClosingBalance				
		Into 	#Expense2
		From 	#Expense1,tblAccounts
		Where	#Expense1.AccountCode = tblAccounts.AccountCode

		Select   @CompanyId as CompanyId,AccountCode,AccountName,	
			Sum(July) as July,
			Sum(August) as August,
			Sum(September) as September,
			Sum(October) as October,
			Sum(November) as November,
			Sum(December) as December,
			Sum(January) as January,
			Sum(February) as February,
			Sum(March) as March,
			Sum(April) as April,
			Sum(May) as May,
			Sum(June) as June,
			Sum(ClosingBalance) as ClosingBalance
		Into	#Expense3 
		From 	#Expense2
		Group by CompanyId,AccountCode,AccountName


		Select * from #Expense3 Order By AccountCode 
	End

if @ReportType= 'Income Statement'
	Begin
		Select 	@CompanyId as CompanyId,BookType, Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(Mst.AccountCode,@AccountDigit) as AccountCode,Debit - Credit as Balance
		Into 	#IncomeStatement1
		From 	#MasterData Mst,tblAccounts
		Where 	(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
		And		tblAccounts.AccountCode = Left(Mst.AccountCode,@AccountDigit)
		And	BookType <> 'OP'

		Select   @CompanyId as CompanyId,#IncomeStatement1.AccountCode as AccountCode,AccountName,
			Case When VoucherMonth = 1   then Balance else 0 End as January,
			Case When VoucherMonth = 2   then Balance else 0 End as February,
			Case When VoucherMonth = 3   then Balance else 0 End as March,		
			Case When VoucherMonth = 4   then Balance else 0 End as April,
			Case When VoucherMonth = 5   then Balance else 0 End as May,
			Case When VoucherMonth = 6   then Balance else 0 End as June,
			Case When VoucherMonth = 7   then Balance else 0 End as July,
			Case When VoucherMonth = 8   then Balance else 0 End as August,
			Case When VoucherMonth = 9   then Balance else 0 End as September,
			Case When VoucherMonth = 10 then Balance else 0 End as October,
			Case When VoucherMonth = 11 then Balance else 0 End as November,
			Case When VoucherMonth = 12 then Balance else 0 End as December,
			Balance as ClosingBalance				
		Into 	#IncomeStatement2
		From 	tblAccounts,#IncomeStatement1 
		Where	#IncomeStatement1.AccountCode = tblAccounts.AccountCode

		Select   @CompanyId as CompanyId,AccountCode,AccountName,	
			Sum(July) * -1 as July,
			Sum(August) * -1 as August,
			Sum(September) * -1 as September,
			Sum(October) * -1 as October,
			Sum(November) * -1 as November,
			Sum(December) * -1 as December,
			Sum(January) * -1 as January,
			Sum(February) * -1 as February,
			Sum(March) * -1 as March,
			Sum(April) * -1 as April,
			Sum(May) * -1 as May,
			Sum(June) * -1 as June,
			Sum(ClosingBalance) * -1 as ClosingBalance
		Into	#IncomeStatement3 
		From 	#IncomeStatement2
		Group by CompanyId,AccountCode,AccountName
		Union All 
		Select   @CompanyId,AccountCode,AccountName,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,0 as ClosingBalance
		from	tblAccounts 
		Where 	Len(AccountCode) = @AccountDigit
		And	(AccountNature = 5 or AccountNature = 4)
		And	AccountCode Not In (Select AccountCode From #IncomeStatement2)

		Select	#IncomeStatement3.*,
				Case When tblAccounts.AccountType = 'Sales Book' or tblAccounts.AccountType = 'Sales Return Book' or tblAccounts.AccountType = 'Cost of Sales' or tblAccounts.AccountType = 'Discount' Then 1 Else Case When tblAccounts.AccountNature = 4 and tblAccounts.AccountType = 'Others' Then 3 Else Case When tblAccounts.AccountNature = 5 and tblAccounts.AccountType <> 'Cost of Sales' and tblAccounts.AccountType <> 'Tax' Then 2 Else Case When tblAccounts.AccountType = 'Tax' Then 4 Else 5 End End End End as Type
		Into	#IncomeStatement4
		from	#IncomeStatement3,tblAccounts 
		Where	#IncomeStatement3.AccountCode = tblAccounts.AccountCode Order By #IncomeStatement3.AccountCode 

		Select *,Case When Type = 1 Then 'Gross Profit' Else Case When Type = 2 Then '' Else Case When Type = 3 Then 'Profit Before Taxation' Else '' End End End as Description From #IncomeStatement4 Where July + August + September + October + November + December + January + February + March + April + May + June <> 0 Order By Type,AccountCode
	End

--if @ReportType= 'Income Statement Cons'
--	Begin
--		Select 	@CompanyId as CompanyId,BookType, Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(Mst.AccountCode,@AccountDigit) as AccountCode,Debit - Credit as Balance
--		Into 	#IS1
--		From 	#MasterData Mst,tblAccounts
--		Where 	(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
--		And		tblAccounts.AccountCode = Left(Mst.AccountCode,@AccountDigit)
--		And	BookType <> 'OP'
--
--		Select   @CompanyId as CompanyId,#IS1.AccountCode as AccountCode,AccountName,
--			Case When VoucherMonth = 1   then Balance else 0 End as January,
--			Case When VoucherMonth = 2   then Balance else 0 End as February,
--			Case When VoucherMonth = 3   then Balance else 0 End as March,		
--			Case When VoucherMonth = 4   then Balance else 0 End as April,
--			Case When VoucherMonth = 5   then Balance else 0 End as May,
--			Case When VoucherMonth = 6   then Balance else 0 End as June,
--			Case When VoucherMonth = 7   then Balance else 0 End as July,
--			Case When VoucherMonth = 8   then Balance else 0 End as August,
--			Case When VoucherMonth = 9   then Balance else 0 End as September,
--			Case When VoucherMonth = 10 then Balance else 0 End as October,
--			Case When VoucherMonth = 11 then Balance else 0 End as November,
--			Case When VoucherMonth = 12 then Balance else 0 End as December,
--			Balance as ClosingBalance				
--		Into 	#IncomeStatement2
--		From 	tblAccounts,#IncomeStatement1 
--		Where	#IncomeStatement1.AccountCode = tblAccounts.AccountCode
--
--		Select   @CompanyId as CompanyId,AccountCode,AccountName,	
--			Sum(ClosingBalance) * -1 as ClosingBalance
--		Into	#IncomeStatement3 
--		From 	#IncomeStatement2
--		Group by CompanyId,AccountCode,AccountName
--
--		Select	#IncomeStatement3.*,
--				Case When tblAccounts.AccountType = 'Sales Book' or tblAccounts.AccountType = 'Sales Return Book' or tblAccounts.AccountType = 'Cost of Sales' or tblAccounts.AccountType = 'Discount' Then 1 Else Case When tblAccounts.AccountNature = 4 and tblAccounts.AccountType = 'Others' Then 3 Else Case When tblAccounts.AccountNature = 5 and tblAccounts.AccountType <> 'Cost of Sales' and tblAccounts.AccountType <> 'Tax' Then 2 Else Case When tblAccounts.AccountType = 'Tax' Then 4 Else 5 End End End End as Type
--		Into	#IncomeStatement4
--		from	#IncomeStatement3,tblAccounts 
--		Where	#IncomeStatement3.AccountCode = tblAccounts.AccountCode Order By #IncomeStatement3.AccountCode 
--
--		Select *,Case When Type = 1 Then 'Gross Profit' Else Case When Type = 2 Then '' Else Case When Type = 3 Then 'Profit Before Taxation' Else '' End End End as Description From #IncomeStatement4 Where ClosingBalance <> 0 Order By Type,AccountCode
--	End


if @ReportType = 'Monthly Closing'
	Begin
		Select 	@CompanyId as CompanyId,BookType,Mst.AccountCode as AccountCode,Credit - Debit as Balance,SectorCode
		Into 	#MonthlyClosing1
		From 	#MasterData Mst,tblAccounts
		Where 	(tblAccounts.AccountNature = 5 or tblAccounts.AccountNature = 4)
		And		Mst.AccountCode = tblAccounts.AccountCode
		And	BookType <> 'OP'

		Select SectorCode,AccountCode,Sum(Balance) as Balance From #MonthlyClosing1 Group By AccountCode,SectorCode
	End

if @ReportType = 'Monthly Closing Sector'
	Begin
		Select 	@CompanyId as CompanyId,BookType,Mst.AccountCode as AccountCode,Debit - Credit as Balance,SectorCode,VoucherNo
		Into 	#MonthlyClosingSector1
		From 	#MasterData Mst,tblAccounts
		Where 	(tblAccounts.AccountNature = 5 or tblAccounts.AccountNature = 4)
		And		Mst.AccountCode = tblAccounts.AccountCode
		And	BookType <> 'OP'

		Select SectorCode,Sum(Balance) as Balance From #MonthlyClosingSector1 Group By SectorCode
	End

if @ReportType = 'CashFlow'
	Begin
		Select   @CompanyId as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit) as AccountCode,
			ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount
		Into	#CashOpening
		From	#MasterData,tblAccounts
		Where 	VoucherDate <= @DateUpto 
		And	#MasterData.AccountCode = tblAccounts.AccountCode
		And	(tblAccounts.AccountType = 'Cash Book' or tblAccounts.AccountType = 'Bank Book')

		Select 	VoucherNo,VoucherDate,AccountCode,
			Debit - Credit as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,7 as M,0 as ClosingBalance
		Into	#CashOpening1
		From 	#CashOpening
		Where 	VoucherDate < = Cast('6/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('6/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,Debit - Credit as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,8 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('7/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('7/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,Debit - Credit as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,9 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('8/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('8/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,Debit - Credit as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,10 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('9/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('9/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,Debit - Credit as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,11 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('10/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('10/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,Debit - Credit as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,12 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('11/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('11/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			Debit - Credit as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,1 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('12/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('12/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,Debit - Credit as Febuary,0 as March,0 as April,0 as May,0 as June,2 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('1/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('1/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,Debit - Credit as March,0 as April,0 as May,0 as June,3 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('2/28/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('2/28/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,Debit - Credit as April,0 as May,0 as June,4 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('3/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('3/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,Debit - Credit as May,0 as June,5 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('4/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('4/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,Debit - Credit as June,6 as M,0 as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('5/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('5/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,6 as M,Debit - Credit as ClosingBalance
		From 	#CashOpening
		Where 	VoucherDate < = Cast('6/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('6/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto

		
		Select 	#CashOpening1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,
			Sum(#CashOpening1.July) as July,Sum(#CashOpening1.August) as August,Sum(#CashOpening1.September) as September,Sum(#CashOpening1.October) as October,Sum(#CashOpening1.November) as November,Sum(#CashOpening1.December) as December,
			Sum(#CashOpening1.January) as January,Sum(#CashOpening1.Febuary) as Febuary,Sum(#CashOpening1.March) as March,Sum(#CashOpening1.April) as April,Sum(#CashOpening1.May) as May,Sum(#CashOpening1.June) as June,IsNull(tblAccounts.Department,0) as InterProject,Sum(#CashOpening1.ClosingBalance) as ClosingBalance
		Into 	#CashOpening2
		From	#CashOpening1,tblAccounts
		Where	#CashOpening1.AccountCode = tblAccounts.AccountCode
		Group By #CashOpening1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,IsNull(tblAccounts.Department,0)

		Select 	@CompanyId as CompanyId,BookType, Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,AgainstAccount, A.AccountName as AgainstAccountName,Debit - Credit as Balance,a.GroupAct
		Into 	#CashFlow1
		From 	#MasterData Mst,tblAccounts a
		Where 	isnull(AgainstAccount,' ') <> ' '
		And 	a.AccountCode = Mst.AgainstAccount
		And	Mst.AccountCode In (Select AccountCode From tblAccounts Where (AccountType = 'Cash Book' or AccountType = 'Bank Book'))

		Select   @CompanyId as CompanyId,#CashFlow1.AgainstAccount,Ltrim(Rtrim(AgainstAccountName)) + ' (' + Ltrim(Rtrim(AgainstAccount)) + ')' as AgainstAccountName,Case When Balance < 0 then Case When Substring(AgainstAccount,1,2) = '01' Then 'CAPITAL EXPENDITURE' Else 'OPERAITIONAL EXPENDITURE' End Else 'CASH IN FLOW' End as Type,Case When Balance < 0 then Case When Substring(AgainstAccount,1,2) = '01' Then 2 Else 3 End Else 1 End as Seq,
--			Case When BookType = 'OP' then Balance else 0 end as Opening,
			0 as Opening,Case When VoucherMonth = 1   then Balance else 0 End as January,
			Case When VoucherMonth = 2   then Balance else 0 End as February,
			Case When VoucherMonth = 3   then Balance else 0 End as March,		
			Case When VoucherMonth = 4   then Balance else 0 End as April,
			Case When VoucherMonth = 5   then Balance else 0 End as May,
			Case When VoucherMonth = 6   then Balance else 0 End as June,
			Case When VoucherMonth = 7   then Balance else 0 End as July,
			Case When VoucherMonth = 8   then Balance else 0 End as August,
			Case When VoucherMonth = 9   then Balance else 0 End as September,
			Case When VoucherMonth = 10 then Balance else 0 End as October,
			Case When VoucherMonth = 11 then Balance else 0 End as November,
			Case When VoucherMonth = 12 then Balance else 0 End as December,
			Balance as ClosingBalance				
		Into 	#CashFlow2
		From 	#CashFlow1

		Select   0 as Seq,'Opening' as Type,@CompanyId as CompanyId,AccountCode,AccountName,
			0 as Opening,
			Sum(July) as July,
			Sum(August) as August,
			Sum(September) as September,
			Sum(October) as October,
			Sum(November) as November,
			Sum(December) as December,
			Sum(January) as January,
			Sum(Febuary) as February,
			Sum(March) as March,
			Sum(April) as April,
			Sum(May) as May,
			Sum(June) as June,
			Sum(ClosingBalance) as ClosingBalance
		Into	#CashFlow3
		From 	#CashOpening2
		Group by AccountCode,AccountName
		Union All
		Select   Case When Type = 'CASH IN FLOW' Then 1 Else Case When Type = 'CAPITAL EXPENDITURE' Then 2 Else 3 End End as Seq,Type,@CompanyId as CompanyId,AgainstAccount as AccountCode,AgainstAccountName as AccountName,	
			Sum(Opening) as Opening,
			Sum(July) as July,
			Sum(August) as August,
			Sum(September) as September,
			Sum(October) as October,
			Sum(November) as November,
			Sum(December) as December,
			Sum(January) as January,
			Sum(February) as February,
			Sum(March) as March,
			Sum(April) as April,
			Sum(May) as May,
			Sum(June) as June,
			Sum(ClosingBalance) as ClosingBalance
		From 	#CashFlow2
		Group by CompanyId,AgainstAccount,AgainstAccountName,Type,Seq

		Select * From #CashFlow3
		order By Seq,AccountCode 
	End

if @ReportType = 'Payable Report'
	Begin
		Select 	VoucherNo,#MasterData.AccountName,G.AccountName as GroupName,Case When BookType = 'OP' Then Sum(Credit) - Sum(Debit) Else 0 End as OpBal,
			Case When IsNull(InvoiceNo,'') <> '' and Substring(IsNull(InvoiceNo,''),1,2) <> 'DN' Then Sum(Credit) - Sum(Debit) Else 0 End as Purchase,
			Case When Substring(IsNull(VoucherNo,''),1,2) <> 'JV' and BookType <> 'OP' Then Sum(Debit) - Sum(Credit) Else 0 End as Paid,
			Case When (IsNull(InvoiceNo,'') = '' or Substring(IsNull(InvoiceNo,''),1,2) = 'DN') and Substring(IsNull(VoucherNo,''),1,2) = 'JV' Then Sum(Debit) Else 0 End as AdjDebit,
			Case When (IsNull(InvoiceNo,'') = '' or Substring(IsNull(InvoiceNo,''),1,2) = 'DN') and Substring(IsNull(VoucherNo,''),1,2) = 'JV' Then Sum(Credit) Else 0 End as AdjCredit
		Into	#Temp11
		From	#MasterData,tblAccounts,tblAccounts G
		Where	#MasterData.AccountCode = tblAccounts.AccountCode
		And		tblAccounts.GroupAct = G.AccountCode 
		Group BY #MasterData.AccountName,BookType,InvoiceNo,VoucherNo,G.AccountName
		
		
		Select  'Grand Total' as Total,AccountName,Sum(OpBal) as OpBal,Sum(Purchase) as Purchase,Sum(Paid) as Paid,Sum(AdjDebit) as AdjDebit,Sum(AdjCredit) as AdjCredit,Sum(OPBal) + Sum(Purchase) - Sum(Paid) + Sum(AdjCredit) - Sum(AdjDebit) as ClosingBal
		From 	#Temp11
		Group By AccountName having Sum(OPBal) + Sum(Purchase) + Sum(Paid) + Sum(AdjCredit) + Sum(AdjDebit) <> 0 
		Order BY GroupName,AccountName
	End 


if @ReportType = 'Receivable Report'
	Begin
		Select 	VoucherNo,AccountName,Case When BookType = 'OP' Then Sum(Debit) - Sum(Credit) Else 0 End as OpBal,
			Case When IsNull(InvoiceNo,'') <> '' and Substring(IsNull(InvoiceNo,''),1,2) <> 'DN' Then Sum(Debit) - Sum(Credit) Else 0 End as Sales,
			Case When Substring(IsNull(VoucherNo,''),1,2) <> 'JV' and BookType <> 'OP' Then Sum(Credit) - Sum(Debit) Else 0 End as Receive,
			Case When (IsNull(InvoiceNo,'') = '' or Substring(IsNull(InvoiceNo,''),1,2) = 'DN') and Substring(IsNull(VoucherNo,''),1,2) = 'JV' Then Sum(Debit) Else 0 End as AdjDebit,
			Case When (IsNull(InvoiceNo,'') = '' or Substring(IsNull(InvoiceNo,''),1,2) = 'DN') and Substring(IsNull(VoucherNo,''),1,2) = 'JV' Then Sum(Credit) Else 0 End as AdjCredit
		Into #ReceiveReport
		From	#MasterData
		Group BY VoucherNo, AccountName,BookType,InvoiceNo,VoucherNo
		
		
		Select  AccountName,Sum(OpBal) as OpBal,Sum(Sales) as Sales,Sum(Receive) as Receive,Sum(AdjDebit) as AdjDebit,Sum(AdjCredit) as AdjCredit,Sum(OPBal) + Sum(Sales) - Sum(Receive) - Sum(AdjCredit) + Sum(AdjDebit) as ClosingBal
		From 	#ReceiveReport
		Group By AccountName having Sum(OPBal) + Sum(Sales) + Sum(Receive) + Sum(AdjCredit) + Sum(AdjDebit) <> 0 
	End 

if @ReportType = 'Aging'
	Begin
		Select   @CompanyId as CompanyId,BookType,VoucherNo,VoucherDate,#MasterData.AccountCode,#MasterData.AccountName,Debit,Credit,Description,tblAccounts.GroupAct,tblAccounts.AccountType
			into 	##FifoCur
			From 	#MasterData,tblAccounts
			Where	#MasterData.AccountCode = tblAccounts.AccountCode
			And		(tblAccounts.AccountType = 'Customer' or tblAccounts.AccountType = 'Supplier')
		Order By CompanyId,#MasterData.AccountCode,VoucherDate,VoucherNo
	End

If @ReportType = 'NotesBalanceSheet'
	Begin	
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit1) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		Into	#BSNotes
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit1) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit2) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit2) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit3) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit3) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit4) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit4) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit5) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit5) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit6) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		#MasterData.AccountCode = tblAccounts.AccountCode 
		And		Left(#MasterData.AccountCode,@AccountDigit6) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Left(#MasterData.AccountCode,@AccountDigit7) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit7) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)

		Select 	VoucherNo,VoucherDate,AccountCode,
				Debit - Credit as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
				0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,7 as M,
				Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as July,0 as August,0 as September,0 as October,0 as November,0 as December,
				0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		Into	#BSNotes1 
		From 	#BSNotes
		Where 	VoucherDate < = Cast('7/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('7/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,Debit - Credit as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,8 as M,
			0 as July,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('8/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('8/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,Debit - Credit as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,9 as M,
			0 as July,0 as August,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('9/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('9/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,Debit - Credit as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,10 as M,
			0 as July,0 as August,0 as September,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('10/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('10/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,Debit - Credit as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,11 as M,
			0 as July,0 as August,0 as September,0 as October,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('11/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('11/30/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,Debit - Credit as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,12 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('12/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime)
		And	Cast('12/31/' + Cast(Year(@DateFrom) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			Debit - Credit as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,1 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('1/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('1/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,Debit - Credit as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,2 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as Febuary,0 as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('2/28/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('2/28/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,Debit - Credit as MarchBal,0 as AprilBal,0 as MayBal,0 as JuneBal,3 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as March,0 as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('3/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('3/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,Debit - Credit as AprilBal,0 as MayBal,0 as JuneBal,4 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as April,0 as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('4/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('4/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,Debit - Credit as MayBal,0 as JuneBal,5 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as May,0 as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('5/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('5/31/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto
		Union All
		Select 	VoucherNo,VoucherDate,AccountCode,
			0 as JulyBal,0 as AugustBal,0 as SeptemberBal,0 as OctoberBal,0 as NovemberBal,0 as DecemberBal,
			0 as JanuaryBal,0 as FebuaryBal,0 as MarchBal,0 as AprilBal,0 as MayBal,Debit - Credit as JuneBal,6 as M,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,
			0 as January,0 as Febuary,0 as March,0 as April,0 as May,Case When AccountNature = 1 Then Debit - Credit Else Credit - Debit End as June
		From 	#BSNotes
		Where 	VoucherDate < = Cast('6/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime)
		And	Cast('6/30/' + Cast(Year(@DateUpto) as Varchar(4)) as DateTime) < = @DateUpto


		Select 	#BSNotes1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,
			Sum(#BSNotes1.JulyBal) as JulyBal,Sum(#BSNotes1.AugustBal) as AugustBal,Sum(#BSNotes1.SeptemberBal) as SeptemberBal,Sum(#BSNotes1.OctoberBal) as OctoberBal,Sum(#BSNotes1.NovemberBal) as NovemberBal,Sum(#BSNotes1.DecemberBal) as DecemberBal,
			Sum(#BSNotes1.JanuaryBal) as JanuaryBal,Sum(#BSNotes1.FebuaryBal) as FebuaryBal,Sum(#BSNotes1.MarchBal) as MarchBal,Sum(#BSNotes1.AprilBal) as AprilBal,Sum(#BSNotes1.MayBal) as MayBal,Sum(#BSNotes1.JuneBal) as JuneBal,IsNull(tblAccounts.Department,0) as InterProject,
			Sum(#BSNotes1.July) as July,Sum(#BSNotes1.August) as August,Sum(#BSNotes1.September) as September,Sum(#BSNotes1.October) as October,Sum(#BSNotes1.November) as November,Sum(#BSNotes1.December) as December,
			Sum(#BSNotes1.January) as January,Sum(#BSNotes1.Febuary) as Febuary,Sum(#BSNotes1.March) as March,Sum(#BSNotes1.April) as April,Sum(#BSNotes1.May) as May,Sum(#BSNotes1.June) as June,tblAccounts.NoteNo
		Into 	#BSNotes2
		From	#BSNotes1,tblAccounts
		Where	#BSNotes1.AccountCode = tblAccounts.AccountCode
		Group By #BSNotes1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,IsNull(tblAccounts.Department,0),tblAccounts.NoteNo


		Select 	#BSNotes2.*,Case When InterProject = 1 Then ' ' Else  tblAccounts.NoteNo + '     ' + tblAccounts.AccountName End as GroupActName,Case When InterProject = 1 then 'INTER PROJECT' Else Case When tblAccounts.AccountNature = 1 Then 'ASSETS' Else 'LIABILITIES / FUND BALANCE' End End as Type
		From	#BSNotes2,tblAccounts
		Where 	#BSNotes2.GroupAct = tblAccounts.AccountCode
		--		And	(Substring(#BSNotes2.AccountCode,1,2) = '01' or Substring(#BSNotes2.AccountCode,1,2) = '02' or Substring(#BSNotes2.AccountCode,1,2) = '03')
		And		(tblAccounts.AccountNature = 1 or tblAccounts.AccountNature = 2 or tblAccounts.AccountNature = 3)
		And		IsNull(#BSNotes2.JulyBal,0) + IsNull(#BSNotes2.AugustBal,0) + IsNull(#BSNotes2.SeptemberBal,0) + IsNull(#BSNotes2.OctoberBal,0) + IsNull(#BSNotes2.NovemberBal,0) + IsNull(#BSNotes2.DecemberBal,0) + IsNull(#BSNotes2.JanuaryBal,0) + IsNull(#BSNotes2.FebuaryBal,0) + IsNull(#BSNotes2.MarchBal,0) + IsNull(#BSNotes2.AprilBal,0) + IsNull(#BSNotes2.MayBal,0) + IsNull(#BSNotes2.JuneBal,0) <> 0 
		Order By tblAccounts.NoteNo,#BSNotes2.NoteNo
	End

If @ReportType = 'NotesIncomeStatement'
	Begin	
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(#MasterData.AccountCode,@AccountDigit1) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		Into	#ISNotes
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit1) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(#MasterData.AccountCode,@AccountDigit2) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit2) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(#MasterData.AccountCode,@AccountDigit3) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit3) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(#MasterData.AccountCode,@AccountDigit4) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit4) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(#MasterData.AccountCode,@AccountDigit5) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		Left(#MasterData.AccountCode,@AccountDigit5) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
		Union All
		Select  '0001' as CompanyId,BookType,VoucherNo,Case When BookType= 'OP' Then DateAdd(Day,1,VoucherDate) Else VoucherDate End as VoucherDate,Case when Booktype <> 'OP' then Month(VoucherDate) else 0 end  as VoucherMonth,Left(#MasterData.AccountCode,@AccountDigit6) as AccountCode,
				ChequeNo,ChequeDate,Debit,Credit,Debit - Credit as Balance,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,IsNull(AgainstAccount,'') as AgainstAccount,tblAccounts.AccountNature,tblAccounts.GroupAct
		From	#MasterData,tblAccounts 
		Where 	VoucherDate <= @DateUpto
		And		#MasterData.AccountCode = tblAccounts.AccountCode 
		And		Left(#MasterData.AccountCode,@AccountDigit6) = tblAccounts.AccountCode 
		And		(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)

		Select   @CompanyId as CompanyId,#ISNotes.AccountCode as AccountCode,AccountName,
			Case When VoucherMonth = 1   then Balance else 0 End as January,
			Case When VoucherMonth = 2   then Balance else 0 End as February,
			Case When VoucherMonth = 3   then Balance else 0 End as March,		
			Case When VoucherMonth = 4   then Balance else 0 End as April,
			Case When VoucherMonth = 5   then Balance else 0 End as May,
			Case When VoucherMonth = 6   then Balance else 0 End as June,
			Case When VoucherMonth = 7   then Balance else 0 End as July,
			Case When VoucherMonth = 8   then Balance else 0 End as August,
			Case When VoucherMonth = 9   then Balance else 0 End as September,
			Case When VoucherMonth = 10 then Balance else 0 End as October,
			Case When VoucherMonth = 11 then Balance else 0 End as November,
			Case When VoucherMonth = 12 then Balance else 0 End as December,
			Balance as ClosingBalance				
		Into 	#ISNotes1
		From 	tblAccounts,#ISNotes 
		Where	#ISNotes.AccountCode = tblAccounts.AccountCode

		Select   @CompanyId as CompanyId,AccountCode,AccountName,	
			Sum(July) * -1 as July,
			Sum(August) * -1 as August,
			Sum(September) * -1 as September,
			Sum(October) * -1 as October,
			Sum(November) * -1 as November,
			Sum(December) * -1 as December,
			Sum(January) * -1 as January,
			Sum(February) * -1 as February,
			Sum(March) * -1 as March,
			Sum(April) * -1 as April,
			Sum(May) * -1 as May,
			Sum(June) * -1 as June,
			Sum(ClosingBalance) * -1 as ClosingBalance
		Into	#ISNotes2 
		From 	#ISNotes1
		Group by CompanyId,AccountCode,AccountName
		Union All 
		Select   @CompanyId,AccountCode,AccountName,
			0 as July,0 as August,0 as September,0 as October,0 as November,0 as December,0 as January,0 as Febuary,0 as March,0 as April,0 as May,0 as June,0 as ClosingBalance
		from	tblAccounts 
		Where 	Len(AccountCode) = @AccountDigit
		And	(AccountNature = 5 or AccountNature = 4)
		And	AccountCode Not In (Select AccountCode From #IsNotes1)

		Select 	#ISNotes1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,
				Sum(#ISNotes1.July * -1) as July,Sum(#ISNotes1.August * -1) as August,Sum(#ISNotes1.September * -1) as September,Sum(#ISNotes1.October * -1) as October,Sum(#ISNotes1.November * -1) as November,Sum(#ISNotes1.December * -1) as December,
				Sum(#ISNotes1.January * -1) as January,Sum(#ISNotes1.February * -1) as February,Sum(#ISNotes1.March * -1) as March,Sum(#ISNotes1.April * -1) as April,Sum(#ISNotes1.May * -1) as May,Sum(#ISNotes1.June * -1) as June,tblAccounts.NoteNo
		Into 	#ISNotes3
		From	#ISNotes1,tblAccounts
		Where	#ISNotes1.AccountCode = tblAccounts.AccountCode
		Group By #ISNotes1.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,IsNull(tblAccounts.Department,0),tblAccounts.NoteNo


		Select 	#ISNotes3.*,tblAccounts.NoteNo + '     ' + tblAccounts.AccountName as GroupActName
		From	#ISNotes3,tblAccounts
		Where 	#ISNotes3.GroupAct = tblAccounts.AccountCode
		And		(tblAccounts.AccountNature = 5 or tblAccounts.AccountNature = 4)
		And		IsNull(#ISNotes3.July,0) + IsNull(#ISNotes3.August,0) + IsNull(#ISNotes3.September,0) + IsNull(#ISNotes3.October,0) + IsNull(#ISNotes3.November,0) + IsNull(#ISNotes3.December,0) + IsNull(#ISNotes3.January,0) + IsNull(#ISNotes3.February,0) + IsNull(#ISNotes3.March,0) + IsNull(#ISNotes3.April,0) + IsNull(#ISNotes3.May,0) + IsNull(#ISNotes3.June,0) <> 0 
		Order By tblAccounts.NoteNo,#ISNotes3.NoteNo
	End

if @ReportType = 'Monthly Account'
	Begin
		Select  @CompanyId as CompanyId,BookType,VoucherNo,VoucherDate,Left(#MasterData.AccountCode,@AccountDigit) as AccountCode,ltrim(rtrim(#MasterData.AccountName)) + '  (' + #MasterData.AccountCode + ')' as AccountName,OppAccount,OppAccountName,
				ChequeNo,ChequeDate,Debit,Credit,Description,isnull(ChqClear,0) as ChqClear,ChqClearDate,BankStDate,EntryType,
				Debit - Credit as Cumalative,
				Case When VoucherDate Between @CurrentPeriodFrom And @CurrentPeriodTo Then Debit - Credit Else 0 End as CurrentPeriod,
				Case When VoucherDate Between @LastPeriodFrom And @LastPeriodTo Then Debit - Credit Else 0 End as LastPeriod,tblAccounts.AccountType,tblAccounts.AccountNature
		Into	#MonthlyAccounts
		From	#MasterData,tblAccounts 
		Where	tblAccounts.AccountCode = #MasterData.AccountCode
		And		(tblAccounts.AccountNature = 4 or tblAccounts.AccountNature = 5)
		And		#MasterData.BookType <> 'OP'
		And		(tblAccounts.ProjectAccount = '' or tblAccounts.ProjectAccount = Case When @Project = '' Then tblAccounts.ProjectAccount Else @Project End)
		Order By CompanyId,#MasterData.AccountCode,VoucherDate,VoucherNo

		Select	#MonthlyAccounts.AccountCode,tblAccounts.AccountName,tblAccounts.GroupAct,
				Case When #MonthlyAccounts.AccountNature = 4 and #MonthlyAccounts.AccountType <> 'Premium' Then 1 Else Case When #MonthlyAccounts.AccountNature = 4 and #MonthlyAccounts.AccountType = 'Premium' Then 3 Else 2 End End as SetOrder,
				Case When #MonthlyAccounts.AccountNature = 4 and #MonthlyAccounts.AccountType <> 'Premium' Then 'REVENUE' Else Case When #MonthlyAccounts.AccountNature = 4 and #MonthlyAccounts.AccountType = 'Premium' Then 'PREMIUM' Else 'EXPENSES' End End as Type,
				Sum(Cumalative) * -1 as Cumalative,
				Sum(CurrentPeriod) * -1 as CurrentPeriod,
				Sum(LastPeriod) * -1 as LastPeriod
		Into	#MonthlyAccount1
		From	#MonthlyAccounts,tblAccounts
		Where	#MonthlyAccounts.AccountCode = tblAccounts.AccountCode
		Group BY #MonthlyAccounts.AccountCode,tblAccounts.AccountName,#MonthlyAccounts.AccountType,#MonthlyAccounts.AccountNature,tblAccounts.GroupAct

		Select	#MonthlyAccount1.*,CurrentPeriod - LastPeriod as DiffAmount,Case When @AccountDigit = 14 Then tblAccounts.AccountName Else '' End as GroupName 
		From	#MonthlyAccount1,tblAccounts
		Where	#MonthlyAccount1.GroupAct = tblAccounts.AccountCode 
		Order By SetOrder,#MonthlyAccount1.AccountCode
	End

if @ReportType = 'LedgerAgingBalance'
	Begin
		Select 	@CompanyId as CompanyId,Left(AccountCode,@AccountDigit) as AccountCode,
			Case When BookType = 'OP' Then Sum(Debit) Else 0 End as OPBalDebit,
			Case When BookType = 'OP' Then Sum(Credit) Else 0 End as OPBalCredit,
			Case When BookType = 'OP' Then Sum(Debit) - Sum(Credit)  Else 0 End as OPBal,
			Case When BookType <> 'OP' and BookType <> 'JV' Then Sum(Debit) Else 0 End as ReceiptDebit,
			Case When BookType <> 'OP' and BookType <> 'JV' Then Sum(Credit) Else 0 End as ReceiptCredit,
			Case When BookType <> 'OP' and BookType = 'JV' Then Sum(Debit) Else 0 End as BillDebit,
			Case When BookType <> 'OP' and BookType = 'JV' Then Sum(Credit) Else 0 End as BillCredit,
			Case When BookType <> 'OP' Then Sum(Debit) - Sum(Credit)  Else 0 End as ActBal,
			Sum(Debit) as ClosingBalDebit,Sum(Credit) as ClosingBalCredit,Sum(Debit) - Sum(Credit) as ClosingBal
		Into 	#LedgerBalance1
		From 	#MasterData
		Group By CompanyId,AccountCode,BookType
	
		Select   @CompanyId as CompanyId,#LedgerBalance1.AccountCode,AccountName,tblAccounts.GroupAct,
				Sum(OPBalDebit) as OPBalDebit,Sum(OPBalCredit) as OPBalCredit,
				Sum(ReceiptDebit) as ReceiptDebit,Sum(ReceiptCredit) as ReceiptCredit,
				Sum(BillDebit) as BillDebit,Sum(BillCredit) as BillCredit,
				Sum(ClosingBal) as ClosingBal
		Into 	#LedgerBalance
		From 	#LedgerBalance1,tblAccounts
		Where 	#LedgerBalance1.AccountCode = tblAccounts.AccountCode
		And		tblAccounts.AccountType = 'Customer'
		Group By #LedgerBalance1.CompanyId,#LedgerBalance1.AccountCode,AccountName,tblAccounts.GroupAct
		Order By CompanyId,#LedgerBalance1.AccountCode,AccountName

		Select	 AccountCode,
				 Sum(IsNull(BillAmount,0)) as BillAmount,
				 Sum(IsNull(ReceiveAmount,0)) as ReceiveAmount,
				 Sum(BillAmount - ReceiveAmount) as BalAmount
		Into	 #Aging
		From	 OutstandingBills 
		Group By AccountCode 
		Having	 Sum(BillAmount) - Sum(ReceiveAmount) <> 0 
		
		Select	#LedgerBalance.AccountCode,
				#LedgerBalance.AccountName,
				Sum(OPBalDebit) as OPBalDebit,
				Sum(OPBalCredit) as OPBalCredit,
				Sum(ReceiptDebit) as ReceiptDebit,
				Sum(ReceiptCredit) as ReceiptCredit,
				Sum(BillDebit) as BillDebit,
				Sum(BillCredit) as BillCredit,
				Sum(ClosingBal) as ClosingBal,
				0 as BillAmount,
				0 as ReceiveAmount,
				0 as BalAmount
		Into	#Difference 
		From	#LedgerBalance
		Group By #LedgerBalance.AccountCode,#LedgerBalance.AccountName
		Union All
		Select	#Aging.AccountCode,
				'' as AccountName,
				0 as OPBalDebit,
				0 as OPBalCredit,
				0 as ReceiptDebit,
				0 as ReceiptCredit,
				0 as BillDebit,
				0 as BillCredit,
				0 as ClosingBal,
				SUM(BillAmount) as BillAmount,
				SUM(ReceiveAmount) as ReceiveAmount,
				SUM(BalAmount) as BalAmount
		From	#Aging 
		Group By #Aging.AccountCode 
		
		Select	AccountCode,
				MAX(AccountName) as AccountName,
				Sum(OPBalDebit) as OPBalDebit,
				Sum(OPBalCredit) as OPBalCredit,
				Sum(ReceiptDebit) as ReceiptDebit,
				Sum(ReceiptCredit) as ReceiptCredit,
				Sum(BillDebit) as BillDebit,
				Sum(BillCredit) as BillCredit,
				Sum(ClosingBal) as ClosingBal,
				SUM(BillAmount) as BillAmount,
				SUM(ReceiveAmount) as ReceiveAmount,
				SUM(BalAmount) as BalAmount,
				SUM(ClosingBal) - SUM(BalAmount) as DiffAmount,
				Case When SUM(BalAmount) = SUM(ClosingBal) then 'Telly' Else 'Not Telly' End as Status
		From	#Difference 
		Group by AccountCode		
		Having Max(accountname) <> '' and SUM(BillAmount) > 0 		
	End

Set Nocount Off


GO


