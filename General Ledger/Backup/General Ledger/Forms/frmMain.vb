Imports System.Windows.Forms
Imports System.Configuration

Public Class frmMain
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
        WriteXml("Settings/CurrentUser/View/Toolbar[text()]", Me.ToolBarToolStripMenuItem.Checked.ToString)
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
        WriteXml("Settings/CurrentUser/View/StatusBar[text()]", Me.StatusBarToolStripMenuItem.Checked.ToString)
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private Sub frmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing, ExitToolStripMenuItem1.Click
        If MsgBox("Are you realy want to quit", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.No Then
            e.Cancel = True
        Else
            End
        End If
    End Sub
    Public Sub frmJvShow(ByVal strLoad As String)
        frmJv.FrmType = "Journal Voucher"
        frmJv.cFrmPrefix = "JV"
        frmJv.FileName1 = "tblJvMst"
        frmJv.FileName2 = "tblJvDtl"
        frmJv.strLoadVoucher = strLoad
        frmJv.MdiParent = Me
        frmJv.Show()
    End Sub

    Private Sub LogOffToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogOffToolStripMenuItem.Click, ToolStripButton2.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub ToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem1.Click
        Me.TaskPane.Visible = ToolStripMenuItem1.Checked
        WriteXml("Settings/CurrentUser/View/TaskPane[text()]", ToolStripMenuItem1.Checked.ToString)

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ToolStripLabel3.Text = "        Date :  " & Format(Date.Today(), "MMM dd, yyyy")
        ToolStripLabel4.Text = "        Time :  " & TimeOfDay
        ToolStripLabel13.Text = "Date : " & Format(Date.Today(), "MMM dd, yyyy")
        ToolStripLabel12.Text = "Time : " & TimeOfDay
        ToolStripLabel10.Enabled = My.Computer.Keyboard.CapsLock
        ToolStripLabel17.Enabled = My.Computer.Keyboard.NumLock
        ToolStripLabel16.Enabled = My.Computer.Keyboard.ScrollLock

    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        frmChangePassword.ShowDialog()
    End Sub

    Private Sub SecurityFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SecurityFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "SECURITY FILE") = -1 Then
            FrmSecurityFile.ShowDialog()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub SuppliersFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SuppliersFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "SUPPLIER FILE") = -1 Then
            frmSupplier.MdiParent = Me
            frmSupplier.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CurrencyFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CurrencyFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "CURRENCY FILE") = -1 Then
            frmCurrency.MdiParent = Me
            frmCurrency.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CompanyFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CompanyFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "COMPANY FILE") = -1 Then
            frmCompany.MdiParent = Me
            frmCompany.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CountryFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CountryFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "COUNTRY FILE") = -1 Then
            frmCountry.MdiParent = Me
            frmCountry.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CityFileToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CityFileToolStripMenuItem1.Click
        If CheckAccess("AccessRight", UserId, "CITY FILE") = -1 Then
            frmCity.MdiParent = Me
            frmCity.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub RegionFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegionFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "REGION FILE") = -1 Then
            frmRegion.MdiParent = Me
            frmRegion.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ProjectTypeFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectTypeFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "PROJECT TYPE") = -1 Then
            frmProjectType.MdiParent = Me
            frmProjectType.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ProjectPurposeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectPurposeToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "PROJECT PURPOSE") = -1 Then
            frmProjectPurpose.MdiParent = Me
            frmProjectPurpose.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ExtraChargesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExtraChargesToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "EXTRA CHARGES") = -1 Then
            frmExtraCharges.MdiParent = Me
            frmExtraCharges.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ProjectFIleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProjectFIleToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "PROJECT FILE") = -1 Then
            frmProjectFile.MdiParent = Me
            frmProjectFile.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub UnitsTypeFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitsTypeFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "UNIT TYPE FILE") = -1 Then
            frmUnitType.MdiParent = Me
            frmUnitType.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub UnitsInventoryFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnitsInventoryFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "UNIT FILE") = -1 Then
            frmUnitFile.MdiParent = Me
            frmUnitFile.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub BlockFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BlockFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "BLOCK FILE") = -1 Then
            frmBlock.MdiParent = Me
            frmBlock.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CustomerMasterFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerMasterFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "CUSTOMER FILE") = -1 Then
            frmCustomer.MdiParent = Me
            frmCustomer.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub AreaFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AreaFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "AREA FILE") = -1 Then
            frmAreaFile.MdiParent = Me
            frmAreaFile.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub PaymentTypesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentTypesToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "PAYMENT TYPE") = -1 Then
            frmPaymentType.MdiParent = Me
            frmPaymentType.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub StandardPaymentPlanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles StandardPaymentPlanToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "STANDARD PAYMENT PLAN") = -1 Then
            frmStandardPaymentPlan.MdiParent = Me
            frmStandardPaymentPlan.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CustomerReservationFormToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CustomerReservationFormToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "RESERVATION FORM") = -1 Then
            frmReservation.MdiParent = Me
            frmReservation.cFormType = "Reserve"
            frmReservation.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub InvoicesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InvoicesToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "INVOICE") = -1 Then
            frmInvoice.MdiParent = Me
            frmInvoice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateInvoiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateInvoiceToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "GENERATE INVOICE") = -1 Then
            frmGenerateInvoice.MdiParent = Me
            frmGenerateInvoice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub UpdateUnbookedUnitPricesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateUnbookedUnitPricesToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "UPDATE PRICES") = -1 Then
            frmUpdateUnitPrices.MdiParent = Me
            frmUpdateUnitPrices.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ReceiptsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceiptsToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "RECEIPT") = -1 Then
            frmReceipt.MdiParent = Me
            frmReceipt.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub UpdateVariableToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UpdateVariableToolStripMenuItem.Click
        Dim db As dbOperations
        Dim cSql As String

        db = New dbOperations(cSql)
        db.dbActionQuery()
    End Sub

    Private Sub SchemeFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SchemeFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "SCHEME FILE") = -1 Then
            frmScheme.MdiParent = Me
            frmScheme.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub PriceListToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PriceListToolStripMenuItem.Click
        frmInventoryReport.MdiParent = Me
        frmInventoryReport.Show()
    End Sub

    Private Sub RecoveryReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecoveryReportToolStripMenuItem.Click
        frmRecoveryReport.MdiParent = Me
        frmRecoveryReport.Show()
    End Sub

    Private Sub TransferLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferLetterToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "TRANSFER PLOT") = -1 Then
            frmTransferPlot.MdiParent = Me
            frmTransferPlot.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CancelUnitsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelUnitsToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "CANCEL UNITS") = -1 Then
            frmReservation.MdiParent = Me
            frmReservation.cFormType = "Cancel"
            frmReservation.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateWelcomeLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateWelcomeLetterToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "WELCOME LETTER") = -1 Then
            frmWelcomeLetter.MdiParent = Me
            frmWelcomeLetter.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        If CheckAccess("AccessRight", UserId, "DEMAND NOTICE 1") = -1 Then
            frmDemandNotice.MdiParent = Me
            frmDemandNotice.cDaysFrom = 0
            frmDemandNotice.cDaysTo = 30
            frmDemandNotice.cDemandString = "Demand Notice 1"
            frmDemandNotice.cLetterPrefix = "D1"
            frmDemandNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateDemandNoticeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DEMAND NOTICE 2") = -1 Then
            frmDemandNotice.MdiParent = Me
            frmDemandNotice.cDaysFrom = 31
            frmDemandNotice.cDaysTo = 60
            frmDemandNotice.cDemandString = "Demand Notice 2"
            frmDemandNotice.cLetterPrefix = "D2"
            frmDemandNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateDemandNotice36190DaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DEMAND NOTICE 3") = -1 Then
            frmDemandNotice.MdiParent = Me
            frmDemandNotice.cDaysFrom = 61
            frmDemandNotice.cDaysTo = 90
            frmDemandNotice.cDemandString = "Demand Notice 3"
            frmDemandNotice.cLetterPrefix = "D3"
            frmDemandNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub GenerateDemandNotice4OverNinetyDaysToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DEMAND NOTICE 4") = -1 Then
            frmDemandNotice.MdiParent = Me
            frmDemandNotice.cDaysFrom = 91
            frmDemandNotice.cDaysTo = 120
            frmDemandNotice.cDemandString = "Demand Notice (91-120 Days)"
            frmDemandNotice.cLetterPrefix = "D4"
            frmDemandNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub DocumentsDeficitLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentsDeficitLetterToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "DOCUMENT DEFICIT") = -1 Then
            frmDocumentDeficit.MdiParent = Me
            frmDocumentDeficit.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub LettersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LettersToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "LETTER HISTORY") = -1 Then
            frmLetters.MdiParent = Me
            frmLetters.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub PrintLettersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintLettersToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "PRINT LETTER") = -1 Then
            frmPrintLetters.MdiParent = Me
            frmPrintLetters.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub SentLettersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SentLettersToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "SENT LETTER") = -1 Then
            frmSentLetters.MdiParent = Me
            frmSentLetters.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateInvoicesForNotDecidedPaymentToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateInvoicesForNotDecidedPaymentToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "GENERATE INVOICE NOT DECIDED") = -1 Then
            frmGenerateNotDecidedInvoice.MdiParent = Me
            frmGenerateNotDecidedInvoice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub GeneratePenaltyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GeneratePenaltyToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "GENERATE PENALTY") = -1 Then
            frmGeneratePenalty.MdiParent = Me
            frmGeneratePenalty.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    
    Private Sub TodaysStatusToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TodaysStatusToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "TODAYS STATUS") = -1 Then
            frmTodaysStatus.MdiParent = Me
            frmTodaysStatus.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub TokenMoneyToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TokenMoneyToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "TOKEN MONEY") = -1 Then
            frmTokenMoney.MdiParent = Me
            frmTokenMoney.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub TokenMoneyReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TokenMoneyReportToolStripMenuItem.Click
        frmTokenMoneyReport.MdiParent = Me
        frmTokenMoneyReport.Show()
    End Sub

    Private Sub ConstructionStageToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConstructionStageToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "CONSTRUCTION STAGE") = -1 Then
            frmConstructionStage.MdiParent = Me
            frmConstructionStage.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ConstructionStageReportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConstructionStageReportToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "CONSTRUCTION STAGE REPORT") = -1 Then
            frmConstuctionReport.MdiParent = Me
            frmConstuctionReport.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateConstructionLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "CONSTRUCTION LETTER") = -1 Then
            frmConstructionUpdate.MdiParent = Me
            frmConstructionUpdate.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub FOToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FOToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "RECOVERY FOLLOWUP") = -1 Then
            frmRecoveryFollowup.MdiParent = Me
            frmRecoveryFollowup.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub TaskFToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TaskFToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "TASK FILE") = -1 Then
            frmTaskFile.MdiParent = Me
            frmTaskFile.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ReceptionModuleToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReceptionModuleToolStripMenuItem1.Click
        If CheckAccess("AccessRight", UserId, "RECEPTION MODULE") = -1 Then
            frmReceptionModule.MdiParent = Me
            frmReceptionModule.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub PaymentGroupToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PaymentGroupToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "RECEPTION MODULE") = -1 Then
            frmPaymentGroup.MdiParent = Me
            frmPaymentGroup.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub AgentCompanyFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentCompanyFileToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "AGENT COMPANY") = -1 Then
            frmAgentCompany.MdiParent = Me
            frmAgentCompany.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub AgentFIleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AgentFIleToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "AGENT") = -1 Then
            frmAgent.MdiParent = Me
            frmAgent.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DUE FOR SERVICE LETTER") = -1 Then
            frmServiceDueLetter.MdiParent = Me
            frmServiceDueLetter.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub DueForServiceLetter1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DUE FOR SERVICE LETTER 1") = -1 Then
            frmServiceDueLetter1.MdiParent = Me
            frmServiceDueLetter1.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub HBFCLoanToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "HBFC LOAN") = -1 Then
            frmHBFCLoan.MdiParent = Me
            frmHBFCLoan.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateDemandNotice5ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DEMAND NOTICE 5") = -1 Then
            frmDemandNotice.MdiParent = Me
            frmDemandNotice.cDaysFrom = 121
            frmDemandNotice.cDaysTo = 150
            frmDemandNotice.cDemandString = "Demand Notice (121-150 Days)"
            frmDemandNotice.cLetterPrefix = "D5"
            frmDemandNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub GenerateDemandNotice6151180ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DEMAND NOTICE 6") = -1 Then
            frmDemandNotice.MdiParent = Me
            frmDemandNotice.cDaysFrom = 151
            frmDemandNotice.cDaysTo = 180
            frmDemandNotice.cDemandString = "Demand Notice (151-180 Days)"
            frmDemandNotice.cLetterPrefix = "D6"
            frmDemandNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If

    End Sub

    Private Sub GenerateFinalNoticeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GenerateFinalNoticeToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "DEMAND NOTICE FINAL") = -1 Then
            frmDemandNotice.MdiParent = Me
            frmDemandNotice.cDaysFrom = 181
            frmDemandNotice.cDaysTo = 5000
            frmDemandNotice.cDemandString = "Demand Notice Final"
            frmDemandNotice.cLetterPrefix = "D7"
            frmDemandNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub DueForServiceLetter2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DUE FOR SERVICE LETTER 2") = -1 Then
            frmServiceDueLetter2.MdiParent = Me
            frmServiceDueLetter2.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub HBFCLoan1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "HBFC LOAN 1") = -1 Then
            frmHBFCLoan1.MdiParent = Me
            frmHBFCLoan1.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub HBFCLoan2ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "HBFC LOAN 2") = -1 Then
            frmHBFCLoan2.MdiParent = Me
            frmHBFCLoan2.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub DueForServiceLetter3ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DUE FOR SERVICE LETTER 3") = -1 Then
            frmServiceDueLetter3.MdiParent = Me
            frmServiceDueLetter3.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub DueForServiceLetter4ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "DUE FOR SERVICE LETTER 4") = -1 Then
            frmServiceDueLetter4.MdiParent = Me
            frmServiceDueLetter4.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub HHbToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "HBFC LOAN 3") = -1 Then
            frmHBFCLoan3.MdiParent = Me
            frmHBFCLoan3.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub FinalNoticeServiceToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "FINAL NOTICE SERVICE") = -1 Then
            frmFinalNoticeService.MdiParent = Me
            frmFinalNoticeService.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub HBToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If CheckAccess("AccessRight", UserId, "FINAL NOTICE LOAN") = -1 Then
            frmHBFCLoan4.MdiParent = Me
            frmHBFCLoan4.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub InternalDocumentAuditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InternalDocumentAuditToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "DOCUMENT AUDIT") = -1 Then
            frmDocumentAudit.MdiParent = Me
            frmDocumentAudit.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub CancelLetterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelLetterToolStripMenuItem.Click
     
    End Sub

    Private Sub TransferLetterToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TransferLetterToolStripMenuItem1.Click

    End Sub

    Private Sub SalesmanFileToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalesmanFileToolStripMenuItem.Click

    End Sub

    Private Sub LandInformationToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LandInformationToolStripMenuItem.Click

    End Sub

    Private Sub ReminderNotice1ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReminderNotice1ToolStripMenuItem.Click
        If CheckAccess("AccessRight", UserId, "Reminder Notice 1") = -1 Then
            frmReminderNotice.MdiParent = Me
            frmReminderNotice.cDaysFrom = 0
            frmReminderNotice.cDaysTo = 30
            frmReminderNotice.cDemandString = "Reminder Notice 1"
            frmReminderNotice.cLetterPrefix = "R1"
            frmReminderNotice.Show()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub ToolStripMenuItem4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        frmReceiptReport.MdiParent = Me
        frmReceiptReport.Show()
    End Sub
End Class
