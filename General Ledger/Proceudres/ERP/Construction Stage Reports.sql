USE [Builders2012]
GO

/****** Object:  StoredProcedure [dbo].[ConstructionStageReport]    Script Date: 4/2/2016 4:31:09 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



ALTER Procedure [dbo].[ConstructionStageReport] @DateTo DateTime,@Project Varchar(4),@UnitType Varchar(10),@UnitNumber Varchar(14)

as

Set Nocount On

Select	tblReservationMst.Project,tblProjectFile.Name as ProjectName,
		tblReservationMst.UnitType,tblUnitType.Name as UnitTypeName,
		tblReservationMst.Unit,tblBlock.Name as Block,tblUnitFile.UnitNumber,
		tblReservationMst.Customer,tblCustomer.Name as CustomerName,tblCustomer.Mobile,
		tblReservationMst.CashAmount,Sum(tblReceiptMst.Amount) as Receipt,Case When Sum(tblReceiptMst.Amount) > 0 and tblReservationMst.CashAmount > 0 Then Round((Sum(tblReceiptMst.Amount) / tblReservationMst.CashAmount) * 100,2) Else 0 End as RecoveryPer
Into	#Temp1
From	tblReservationMst,tblProjectFile,tblUnitType,tblUnitFile,tblCustomer,tblReceiptMst,tblBlock
Where	IsNull(tblReservationMst.Cancel,0) = 0 
And		tblReservationMst.Project = tblProjectFile.Code
And		tblReservationMst.UnitType = tblUnitType.Code
And		tblReservationMst.Unit = tblUnitFile.COde
And		tblReservationMst.Customer = tblCustomer.Code
And		tblReceiptMst.Project = tblReservationMst.Project
And		tblReceiptMst.Unit = tblReservationMst.Unit
And		IsNull(tblReceiptMst.Cancel,0) = 0 
And		IsNull(tblReceiptMst.PDC,0) = 0 
And		tblUnitFile.Block = tblBlock.Code
Group By tblReservationMst.Project,tblProjectFile.Name,
		tblReservationMst.UnitType,tblUnitType.Name,
		tblReservationMst.Unit,tblUnitFile.UnitNumber,
		tblReservationMst.Customer,tblCustomer.Name,tblCustomer.Mobile,tblReservationMst.CashAmount,tblBlock.Name

Select  ProjectName as Project,UnitTypeName as UnitType,Block,UnitNumber as UnitNo,CustomerName as Customer,Mobile,
		CashAmount,Receipt,RecoveryPer,tblConstructionStage.Name as ConstructionStage,1 as Total
From	#Temp1 Left Outer Join tblConstructionStage
On		#Temp1.Project = tblConstructionStage.Project
And		#Temp1.RecoveryPer >= tblConstructionStage.PerRecoveryFrom and #Temp1.RecoveryPer < tblConstructionStage.PerRecoveryTo

Set Nocount Off




GO


