USE [Builders2012]
GO

/****** Object:  View [dbo].[ExtraChargesUnit]    Script Date: 4/2/2016 4:34:33 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

ALTER View [dbo].[ExtraChargesUnit]

as

Select	tblUnitFile.Code as Unit,ExtraCharges1 as Code,tblExtraCharges.Name as Name,ExtraChargesAmount1 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges1Apply,0) = 1
And		tblUnitFile.ExtraCharges1 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges2,tblExtraCharges.Name as Name,ExtraChargesAmount2 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges2Apply,0) = 1
And		tblUnitFile.ExtraCharges2 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges3,tblExtraCharges.Name as Name,ExtraChargesAmount3 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges3Apply,0) = 1
And		tblUnitFile.ExtraCharges3 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges4,tblExtraCharges.Name as Name,ExtraChargesAmount4 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges4Apply,0) = 1
And		tblUnitFile.ExtraCharges4 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges5,tblExtraCharges.Name as Name,ExtraChargesAmount5 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges5Apply,0) = 1
And		tblUnitFile.ExtraCharges5 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges6,tblExtraCharges.Name as Name,ExtraChargesAmount6 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges6Apply,0) = 1
And		tblUnitFile.ExtraCharges6 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges7,tblExtraCharges.Name as Name,ExtraChargesAmount7 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges7Apply,0) = 1
And		tblUnitFile.ExtraCharges7 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges8,tblExtraCharges.Name as Name,ExtraChargesAmount8 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges8Apply,0) = 1
And		tblUnitFile.ExtraCharges8 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges9,tblExtraCharges.Name as Name,ExtraChargesAmount9 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges9Apply,0) = 1
And		tblUnitFile.ExtraCharges9 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges10,tblExtraCharges.Name as Name,ExtraChargesAmount10 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges10Apply,0) = 1
And		tblUnitFile.ExtraCharges10 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges11,tblExtraCharges.Name as Name,ExtraChargesAmount11 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges11Apply,0) = 1
And		tblUnitFile.ExtraCharges11 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges12,tblExtraCharges.Name as Name,ExtraChargesAmount12 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges12Apply,0) = 1
And		tblUnitFile.ExtraCharges12 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges13,tblExtraCharges.Name as Name,ExtraChargesAmount13 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges13Apply,0) = 1
And		tblUnitFile.ExtraCharges13 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges14,tblExtraCharges.Name as Name,ExtraChargesAmount14 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges14Apply,0) = 1
And		tblUnitFile.ExtraCharges14 = tblExtraCharges.Code
Union All
Select	tblUnitFile.Code as Unit,ExtraCharges15,tblExtraCharges.Name as Name,ExtraChargesAmount15 as Amount
From	tblUnitFile,tblExtraCharges
Where	IsNull(ExtraCharges15Apply,0) = 1
And		tblUnitFile.ExtraCharges15 = tblExtraCharges.Code

GO


