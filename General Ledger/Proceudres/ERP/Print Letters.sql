USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[PrintLetters]    Script Date: 4/2/2016 4:33:25 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER Procedure [dbo].[PrintLetters] @Project Varchar(4),@Month Numeric(9),@Year Numeric(9),@LetterType Varchar(50),@PrintOption Varchar(50),@PrintDate as Datetime

as

Set Nocount on

Select	tblLetters.EntryNo,tblLetters.EntryDate,tblLetters.LetterType,
		Customer,tblCustomer.Name as CustomerName,tblCustomer.TelRes,tblCustomer.Mobile,tblCustomer.Address,
		tblLetters.Unit,tblUnitFile.UnitNumber,tblUnitFile.UnitType,tblUnitType.Name as UnitTypeName,
		IsNull(LetterPrint,0) as LetterPrint,Case When IsNull(LetterPrint,0) = 0 Then @PrintDate Else PrintDate End as PrintDate
From	tblLetters,tblCustomer,tblUnitFile,tblUnitType
Where	tblLetters.Customer = tblCustomer.Code
And		tblLetters.Unit = tblUnitFile.Code
And		tblUnitFile.UnitType = tblUnitType.Code
And		Month(tblLetters.EntryDate) = @Month
And		Year(tblLetters.EntryDate) = @Year
And		tblLetters.LetterType = @LetterType
And		IsNull(tblLetters.LetterPrint,0) = Case When @PrintOption = 'Pending' Then 0 Else Case When @PrintOption = 'Printed' Then 1 Else IsNull(tblLetters.LetterPrint,0) End End
And		tblUnitFile.Project = @Project

Set Nocount oFf



GO


