USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[PriceList]    Script Date: 4/2/2016 4:33:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO






ALTER Procedure [dbo].[PriceList] @Project Varchar(4),@UnitType Varchar(10),@Block Varchar(4),@Status Varchar(20),@ReportType Varchar(30),@Report Varchar(30),@DateFrom DateTime = Null,@DateTo DateTime = Null

as

Set Nocount On 

Select  ReservationNo as EntryNo,Sum(Amount) as Amount Into #Utilities From tblReservationDtl Where (PaymentType = '0050' or PaymentTYpe = '0057' or PaymentType = '0058') Group By ReservationNo

Select	tblUnitFile.Project,tblUnitFile.UnitType,tblUnitType.Name as UnitTypeName,tblUnitFile.UnitNumber,tblReservationMst.ReservationDate,Case When IsNull(SqYards,0) <> 0 Then CAST(SqYards as Varchar(20)) + ' YDS' Else CAST(SqFeet as Varchar(20)) + ' Sq. Ft.' End as Area,Rooms,
		Block,tblBlock.Name as BlockName,1 as Unit,Case When IsNull(ReservationNo,'') <> '' Then 1 Else 0 End as Booked,
		Case When IsNull(ReservationNo,'') <> '' Then 'Booked' Else 'Available' End as Status,
		Case When IsNull(ReservationNo,'') <> '' Then tblReservationMst.CashAmount Else tblUnitFile.CashAmount End as CashAmount,
		Case When IsNull(ReservationNo,'') <> '' Then tblReservationMst.LoanAmount Else tblUnitFile.LoanAmount End as LoanAmount,
		Case When IsNull(ReservationNo,'') <> '' Then tblReservationMst.CashAmount + tblReservationMst.LoanAmount Else tblUnitFile.CashAmount + tblUnitFile.LoanAmount End as GrossAmount,
		tblUnitType.ExtraCharges1,IsNull(ExtraCharges1.Name,'') as ExtraCharges1Name,tblUnitFile.ExtraChargesAmount1,
		tblUnitType.ExtraCharges2,IsNull(ExtraCharges2.Name,'') as ExtraCharges2Name,tblUnitFile.ExtraChargesAmount2,
		tblUnitType.ExtraCharges3,IsNull(ExtraCharges3.Name,'') as ExtraCharges3Name,tblUnitFile.ExtraChargesAmount3,
		tblUnitType.ExtraCharges4,IsNull(ExtraCharges4.Name,'') as ExtraCharges4Name,tblUnitFile.ExtraChargesAmount4,
		tblUnitType.ExtraCharges5,IsNull(ExtraCharges5.Name,'') as ExtraCharges5Name,tblUnitFile.ExtraChargesAmount5,
		tblUnitType.ExtraCharges6,IsNull(ExtraCharges6.Name,'') as ExtraCharges6Name,tblUnitFile.ExtraChargesAmount6,
		tblUnitType.ExtraCharges7,IsNull(ExtraCharges7.Name,'') as ExtraCharges7Name,tblUnitFile.ExtraChargesAmount7,
		tblUnitType.ExtraCharges8,IsNull(ExtraCharges8.Name,'') as ExtraCharges8Name,tblUnitFile.ExtraChargesAmount8,
		tblUnitType.ExtraCharges9,IsNull(ExtraCharges9.Name,'') as ExtraCharges9Name,tblUnitFile.ExtraChargesAmount9,
		tblUnitType.ExtraCharges10,IsNull(ExtraCharges10.Name,'') as ExtraCharges10Name,tblUnitFile.ExtraChargesAmount10,
		tblUnitType.ExtraCharges11,IsNull(ExtraCharges11.Name,'') as ExtraCharges11Name,tblUnitFile.ExtraChargesAmount11,
		tblUnitType.ExtraCharges12,IsNull(ExtraCharges12.Name,'') as ExtraCharges12Name,tblUnitFile.ExtraChargesAmount12,
		tblUnitType.ExtraCharges13,IsNull(ExtraCharges13.Name,'') as ExtraCharges13Name,tblUnitFile.ExtraChargesAmount13,
		tblUnitType.ExtraCharges14,IsNull(ExtraCharges14.Name,'') as ExtraCharges14Name,tblUnitFile.ExtraChargesAmount14,
		tblUnitType.ExtraCharges15,IsNull(ExtraCharges15.Name,'') as ExtraCharges15Name,tblUnitFile.ExtraChargesAmount15,
		Case When IsNull(ReservationNo,'') <> '' Then tblReservationMst.ExtraCharges Else IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) End as TotalExtraCharges,
		IsNull(tblReservationMst.CashAmount,0) as ReserveCashAmount,
		IsNull(tblReservationMst.LoanAmount,0) as ReserveLoanAmount,
		IsNull(tblReservationMst.ExtraCharges,0) as ReserveExtraCharges,
		IsNull(tblReservationMst.Discount,0) as ReserveDiscount,
		IsNull(#Utilities.Amount,0) as Utilities,
		IsNull(tblReservationMst.CashAmount,0) + IsNull(tblReservationMst.LoanAmount,0) + IsNull(tblReservationMst.ExtraCharges,0) - IsNull(tblReservationMst.Discount,0) as TotalReserveAmount,Case When IsNull(tblProjectFile.LoanNotApplicable,0) = 1 Then '' Else 'Loan Amount' End LoanCaption
Into	#Temp1
From 	tblUnitFile Left Outer Join tblReservationMst Left Outer Join #Utilities On #Utilities.EntryNo = tblReservationMst.ReservationNo On tblReservationMst.Unit = tblUnitFile.Code,tblBlock,tblProjectFile,tblUnitType
Left Outer Join tblExtraCharges ExtraCharges1 On tblUnitType.ExtraCharges1 = ExtraCharges1.Code
Left Outer Join tblExtraCharges ExtraCharges2 On tblUnitType.ExtraCharges2 = ExtraCharges2.Code
Left Outer Join tblExtraCharges ExtraCharges3 On tblUnitType.ExtraCharges3 = ExtraCharges3.Code
Left Outer Join tblExtraCharges ExtraCharges4 On tblUnitType.ExtraCharges4 = ExtraCharges4.Code
Left Outer Join tblExtraCharges ExtraCharges5 On tblUnitType.ExtraCharges5 = ExtraCharges5.Code
Left Outer Join tblExtraCharges ExtraCharges6 On tblUnitType.ExtraCharges6 = ExtraCharges6.Code
Left Outer Join tblExtraCharges ExtraCharges7 On tblUnitType.ExtraCharges7 = ExtraCharges7.Code
Left Outer Join tblExtraCharges ExtraCharges8 On tblUnitType.ExtraCharges8 = ExtraCharges8.Code
Left Outer Join tblExtraCharges ExtraCharges9 On tblUnitType.ExtraCharges9 = ExtraCharges9.Code
Left Outer Join tblExtraCharges ExtraCharges10 On tblUnitType.ExtraCharges10 = ExtraCharges10.Code
Left Outer Join tblExtraCharges ExtraCharges11 On tblUnitType.ExtraCharges11 = ExtraCharges11.Code
Left Outer Join tblExtraCharges ExtraCharges12 On tblUnitType.ExtraCharges12 = ExtraCharges12.Code
Left Outer Join tblExtraCharges ExtraCharges13 On tblUnitType.ExtraCharges13 = ExtraCharges13.Code
Left Outer Join tblExtraCharges ExtraCharges14 On tblUnitType.ExtraCharges14 = ExtraCharges14.Code
Left Outer Join tblExtraCharges ExtraCharges15 On tblUnitType.ExtraCharges15 = ExtraCharges15.Code
Where	tblUnitFile.UnitType = tblUnitType.Code
And		tblUnitFile.Block = tblBlock.Code
And		tblUnitFile.Project = @Project
And		tblUnitFile.UnitType = Case When @UnitType <> '' Then @UnitType Else tblUnitFile.UnitType End
And		tblUnitFile.Block = Case When @Block <> '' Then @Block Else tblUnitFile.Block End 
And		Isnull(tblUnitFile.Cancel,0) = 0 and IsNull(tblReservationMst.Cancel,0) = 0 
And		tblUnitFile.Project = tblProjectFile.Code 
Order By tblUnitFile.UnitType

if @Report = 'Price List' 
	Begin
		if @ReportType = 'Report'
			Begin
				Select *,GrossAmount + TotalExtraCharges as NetAmount From #Temp1 Where Status = Case When @Status <> 'Both' Then @Status Else Status End Order By UnitType 
			End

		if @ReportType = 'Grid'
			Begin
				Select 	UnitTypeName,BlockName,UnitNumber,ReservationDate,Area,Status,
					CashAmount,LoanAmount,GrossAmount as TotalExclExtraCharges,
					Case When ExtraChargesAmount1 <> 0 Then ExtraCharges1Name Else '-' End as ExtraCharges1Name,ExtraChargesAmount1,
					Case When ExtraChargesAmount2 <> 0 Then ExtraCharges2Name Else '-' End as ExtraCharges2Name,ExtraChargesAmount2,
					Case When ExtraChargesAmount3 <> 0 Then ExtraCharges3Name Else '-' End as ExtraCharges3Name,ExtraChargesAmount3,
					Case When ExtraChargesAmount4 <> 0 Then ExtraCharges4Name Else '-' End as ExtraCharges4Name,ExtraChargesAmount4,
					Case When ExtraChargesAmount5 <> 0 Then ExtraCharges5Name Else '-' End as ExtraCharges5Name,ExtraChargesAmount5,
					Case When ExtraChargesAmount6 <> 0 Then ExtraCharges6Name Else '-' End as ExtraCharges6Name,ExtraChargesAmount6,
					Case When ExtraChargesAmount7 <> 0 Then ExtraCharges7Name Else '-' End as ExtraCharges7Name,ExtraChargesAmount7,
					Case When ExtraChargesAmount8 <> 0 Then ExtraCharges8Name Else '-' End as ExtraCharges8Name,ExtraChargesAmount8,
					Case When ExtraChargesAmount9 <> 0 Then ExtraCharges9Name Else '-' End as ExtraCharges9Name,ExtraChargesAmount9,TotalExtraCharges,GrossAmount + TotalExtraCharges as TotalInclExtraCharges
				From	#Temp1
				Where Status = Case When @Status <> 'Both' Then @Status Else Status End
				Order BY UnitType
			End
	End

if @Report = 'Booking' 
	Begin
		if @ReportType = 'Report'
			Begin
				Select	*,GrossAmount + TotalExtraCharges as NetAmount 
				From	#Temp1 
				Where	Status = Case When @Status <> 'Both' Then @Status Else Status End 
				And		ReservationDate Between @DateFrom and @DateTo 
				Order By UnitType 
			End

		if @ReportType = 'Grid'
			Begin
				Select 	UnitTypeName,BlockName,UnitNumber,ReservationDate,Area,Status,
					CashAmount,LoanAmount,GrossAmount as TotalExclExtraCharges,
					Case When ExtraChargesAmount1 <> 0 Then ExtraCharges1Name Else '-' End as ExtraCharges1Name,ExtraChargesAmount1,
					Case When ExtraChargesAmount2 <> 0 Then ExtraCharges2Name Else '-' End as ExtraCharges2Name,ExtraChargesAmount2,
					Case When ExtraChargesAmount3 <> 0 Then ExtraCharges3Name Else '-' End as ExtraCharges3Name,ExtraChargesAmount3,
					Case When ExtraChargesAmount4 <> 0 Then ExtraCharges4Name Else '-' End as ExtraCharges4Name,ExtraChargesAmount4,
					Case When ExtraChargesAmount5 <> 0 Then ExtraCharges5Name Else '-' End as ExtraCharges5Name,ExtraChargesAmount5,
					Case When ExtraChargesAmount6 <> 0 Then ExtraCharges6Name Else '-' End as ExtraCharges6Name,ExtraChargesAmount6,
					Case When ExtraChargesAmount7 <> 0 Then ExtraCharges7Name Else '-' End as ExtraCharges7Name,ExtraChargesAmount7,
					Case When ExtraChargesAmount8 <> 0 Then ExtraCharges8Name Else '-' End as ExtraCharges8Name,ExtraChargesAmount8,
					Case When ExtraChargesAmount9 <> 0 Then ExtraCharges9Name Else '-' End as ExtraCharges9Name,ExtraChargesAmount9,TotalExtraCharges,GrossAmount + TotalExtraCharges as TotalInclExtraCharges
				From	#Temp1
				Where Status = Case When @Status <> 'Both' Then @Status Else Status End
				And		ReservationDate Between @DateFrom and @DateTo 
				Order BY UnitType
			End
	End

if @Report = 'Summary' 
	Begin
		if @ReportType = 'Report'
			Begin
				Select	UnitTypeName + Area as UnitTypeName,BlockName,Area,
						Sum(Unit) as Unit,Sum(CashAmount) as CashAmount,Sum(LoanAmount) as LoanAmount,Sum(TotalExtraCharges) as TotalExtraCharges,Sum(GrossAmount + TotalExtraCharges) as TotalAmount,
						Sum(Booked) as Booked,Sum(ReserveCashAmount) as ReserveCashAmount,Sum(ReserveLoanAmount) as ReserveLoanAmount,Sum(ReserveExtraCharges) as ReserveExtraCharges,Sum(ReserveDiscount) as ReserveDiscount,Sum(TotalReserveAmount) as TotalReserveAmount,Case When Sum(GrossAmount + TotalExtraCharges) > 0 and Sum(TotalReserveAmount) > 0 Then (Sum(TotalReserveAmount) / Sum(GrossAmount + TotalExtraCharges) * 100) Else 0 End as BookedPerAmount
				From	#Temp1
				Group By UnitTypeName,BlockName,Area
				Order By BlockName
			End

		if @ReportType = 'Grid'
			Begin
				Select	UnitTypeName + Area  as UnitTypeName,BlockName,Area,
						Sum(Unit) as Unit,Sum(CashAmount) as CashAmount,Sum(LoanAmount) as LoanAmount,Sum(TotalExtraCharges) as TotalExtraCharges,Sum(GrossAmount + TotalExtraCharges) as TotalAmount,
						Sum(Booked) as Booked,Sum(ReserveCashAmount) as ReserveCashAmount,Sum(ReserveLoanAmount) as ReserveLoanAmount,Sum(ReserveExtraCharges) as ReserveExtraCharges,Sum(ReserveDiscount) as ReserveDiscount,Sum(TotalReserveAmount) as TotalReserveAmount,Case When Sum(Unit) > 0 and Sum(Booked) > 0 Then Sum(Cast(Booked as Numeric(9,2))) / Sum(Cast(Unit as Numeric(9,2))) * 100 Else 0 End as BookedPer,Case When Sum(GrossAmount + TotalExtraCharges) > 0 and Sum(TotalReserveAmount) > 0 Then (Sum(TotalReserveAmount) / Sum(GrossAmount + TotalExtraCharges) * 100) Else 0 End as BookedPerAmount
				From	#Temp1
				Group By UnitTypeName,BlockName,Area
				Order By BlockName
			End
	End

Set Nocount Off







GO


