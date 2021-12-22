USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[PriceChangeReport]    Script Date: 4/2/2016 4:33:03 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER Procedure [dbo].[PriceChangeReport] @DateFrom DateTime,@DateTo DateTime,@Project Varchar(4)

as

Set Nocount On

Select	ChangeDate,tblUnitType.Name as TypeName,tblProjectFile.Name as Project,
		OldCashAmount,NewCashAmount,NewCashAmount - OldCashAmount as ChangeCashAmount,
		OldLoanAmount,NewLoanAmount,NewLoanAmount - OldLoanAmount as ChangeLoanAmount,
		OldTotalRevenue,NewTotalRevenue,NewTotalRevenue - OldTotalRevenue as ChangeTotalRevenue
From	tblPriceChange,tblProjectFile,tblUnitType
Where	tblPriceChange.Project = tblProjectFile.Code
And		tblPriceChange.UnitType = tblUnitType.Code
And		tblPriceChange.ChangeDate Between @DateFrom and @DateTo
And		tblPriceChange.Project = @Project 

Set Nocount Off


GO


