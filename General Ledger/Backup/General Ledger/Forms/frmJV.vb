Imports System.Data
Imports System.Data.SqlClient
Imports C1.Win.C1TrueDBGrid
'Imports AnoynymousTypes
Public Class frmJv
    Private Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum
    Private dbGrid As BindGrid
    Private DBGridDetail As BindGrid
    Public strLoadVoucher As String
    Private Verified As Int16
    Private Authorized As Int16
    Private Posted As Int16

    Private Sub frmJV_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FormCenter(Me)
        Call FillCombo()
        Call ClearControls()
        lblHeading.Text = cFrmType

        If cFrmPrefix = "JV" Then
            Label5.Visible = False
            txtChequeNo.Visible = False

            Label6.Visible = False
            txtPaidTo.Visible = False
        Else
            Label5.Visible = True
            txtChequeNo.Visible = True

            Label6.Visible = True
            txtPaidTo.Visible = True
        End If

        If Not strLoadVoucher = Nothing Then
            txtVoucherNo.Text = strLoadVoucher
            Call DisplayRec()
        End If
    End Sub
    Sub FillCombo()
        Dim AccountName As New BindCombo(tdbAccountName, "Select tblAccounts.AccountCode,Ltrim(RTrim(tblAccounts.AccountName)) + ' (' + LTrim(RTrim(GroupName.AccountName)) + ')' as AccountName,tblAccounts.AccountLevel,tblAccounts.AccountType From tblAccounts,tblAccounts as GroupName Where tblAccounts.GroupAct = GroupName.AccountCode And tblAccounts.AccountLevel = 'Detail' Order By tblAccounts.AccountName", "AccountName", "AccountCode", True, GLConString)
        'Dim Projects As New BindCombo(cmbProject, "Select Code, Name From tblProject", "Name", "Code", False, False)
        Dim Tag As New BindCombo(tdbTag, "Select Code, Prefix, Name from tblTagFile", "Name", "Code", True, GLConString)
        Dim Sector As New BindCombo(tdbLocation, "select s.Code, P.Name + ' - ' + L.Name + ' - ' + s.Name as Sector from tblSector s Left Outer Join tblLocation l on s.Location = l.code Left outer Join tblProject P on L.Project = P.Code", "Sector", "Code", True, GLConString)
        Dim Employee As New BindCombo(tdbEmployee, "Select EmployeeCode, EmployeeName from tblEmployee", "EmployeeName", "EmployeeCode", True, PayRollConString)
    End Sub
    Private Sub Totals()
        Dim cTotalDebit As Double
        Dim cTotalCredit As Double
        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select  'dtc(cFileName2).Select
            cTotalDebit += Convert.ToDouble(IIf(IsDBNull(row("Debit")), 0, row("Debit")))
            cTotalCredit += Convert.ToDouble(IIf(IsDBNull(row("Credit")), 0, row("Credit")))
        Next
        txtTotalDebit.Text = Format(cTotalDebit, "###,###,##0.00")
        txtTotalCredit.Text = Format(cTotalCredit, "###,###,##0.00")
    End Sub
    Private Sub DisplayRec()
        If txtVoucherNo.Text <> Nothing Or txtVoucherNo.Text <> "" Then
            Dim cSql As String = "Select  * from " & cFileName1 & " Where CompanyId = '" & cCompanyId & "' and VoucherNo = '" & txtVoucherNo.Text & "'"
            Dim db As New dbOperations(cSql, GLConString)
            Dim dr As SqlDataReader = db.dbSelectQuery()
            If dr.HasRows Then
                dr.Read()
                If cmbVoucherType.Visible Then
                    If dr!VoucherType = "R" Then
                        cmbVoucherType.SelectedIndex = 1
                    Else
                        cmbVoucherType.SelectedIndex = 0
                    End If
                End If
                txtVoucherNo.Text = dr.Item("VoucherNo")
                'cmbProject.SelectedValue = RemoveNull(dr!Project, "")

                Verified = RemoveNull(dr!Verified, 0)
                Authorized = RemoveNull(dr!Authorized, 0)
                Posted = RemoveNull(dr!Posted, 0)

                Dim d As Date = dr!VoucherDate
                txtDate.Value = CDate(IIf(IsDBNull(dr("VoucherDate")) = True, 0, dr("VoucherDate")))
                txtDescription.Text = IIf(IsDBNull(dr("Description")) = True, 0, dr("Description"))
                txtChequeNo.Text = IIf(IsDBNull(dr("ChqNoMst")) = True, 0, dr("ChqNoMst"))
                txtPaidTo.Text = RemoveNull(dr!PaidTo, "")

                db.Close()
                dr.Close()
                Call SetControls(Actions.Edit)
            Else
                MsgBox("Invalid Voucher Number - Please Enter Valid Voucher Number")
                Exit Sub
            End If
        Else
            Call SetControls(Actions.Initial)
        End If

        dbGrid = New BindGrid(TDBGrid1, "Select CompanyID, VoucherNo, ChequeNo, ChequeDate, Sector, Tag,EmployeeCode, AccountCode,ContraAccount,Auto, DescriptionEntry, Debit, Credit From " & cFileName2 & " Where Voucherno = '" & txtVoucherNo.Text & "' and CompanyId = '" & cCompanyId & "' Order by EmployeeCode,Credit", GLConString)
        '        DBGridDetail = New BindGrid("Select CompanyID, VoucherNo, AccountCode,Sector,Tag,EmployeeCode,DetailCode,Type,Amount From tblVoucherDetail Where VoucherNo = '" & txtVoucherNo.Text & "' And CompanyID = '" & cCompanyId & "'", GLConString)

        If dbGrid.cDataTable.Rows.Count > 0 Then
            Call Totals()
        End If
    End Sub

    Sub ClearControls()
        txtVoucherNo.Text = Nothing
        txtDate.Value = Date.Today.ToShortDateString
        txtDescription.Text = ""
        txtTotalDebit.Text = 0
        txtTotalCredit.Text = 0
        txtChequeNo.Text = ""
        txtPaidTo.Text = ""
        'cmbProject.SelectedValue = ""
        Call DisplayRec()
    End Sub
    Private Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)
                If cmbVoucherType.Visible Then
                    cmbVoucherType.Enabled = False
                End If
                txtVoucherNo.Enabled = False
                txtDate.Enabled = False
                txtDescription.Enabled = False
                txtChequeNo.Enabled = False
                'TDBGrid1.Enabled = False
                txtPaidTo.Enabled = False
                'cmdDeleteLine.Enabled = False
                'cmbProject.Enabled = False

            Case Actions.Edit
                Call SetButtons(Actions.Edit)
                txtVoucherNo.Enabled = False
                If cmbVoucherType.Visible Then
                    cmbVoucherType.Enabled = False
                End If
                txtDate.Enabled = False
                txtDescription.Enabled = False
                txtChequeNo.Enabled = False
                'TDBGrid1.Enabled = False
                txtPaidTo.Enabled = False
                'cmdDeleteLine.Enabled = False
                'cmbProject.Enabled = False

            Case Actions.Entry
                Call SetButtons(Actions.Entry)
                If cmbVoucherType.Visible Then
                    cmbVoucherType.Enabled = False
                End If
                txtVoucherNo.Enabled = False
                txtDate.Enabled = True
                txtDescription.Enabled = True
                txtChequeNo.Enabled = True
                'TDBGrid1.Enabled = True
                txtPaidTo.Enabled = True
                'cmdDeleteLine.Enabled = True
                'If String.IsNullOrEmpty(txtVoucherNo.Text) Then
                'cmbProject.Enabled = True
                'Else
                'cmbProject.Enabled = False
                'End If

        End Select
    End Sub
    Private Sub SetButtons(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                cmdAdd.Enabled = True
                cmdSearch.Enabled = True
                cmdPrint.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = False
                cmdUndo.Enabled = False
                cmdExit.Enabled = True
                cmdRefresh.Enabled = True
            Case Actions.Edit
                cmdAdd.Enabled = False
                cmdSearch.Enabled = True
                cmdPrint.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = True
                cmdRefresh.Enabled = False
            Case Actions.Entry
                cmdAdd.Enabled = False
                cmdSearch.Enabled = False
                cmdPrint.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = True
                cmdRefresh.Enabled = True
        End Select
    End Sub
    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub
    Private cFrmType As String
    Public Property FrmType() As String
        Get
            Return cFrmType
        End Get
        Set(ByVal value As String)
            cFrmType = value
        End Set
    End Property
    Private cFileName1 As String
    Public Property FileName1() As String
        Get
            Return cFileName1
        End Get
        Set(ByVal value As String)
            cFileName1 = value
        End Set
    End Property
    Private cFileName2 As String
    Public Property FileName2() As String
        Get
            Return cFileName2
        End Get
        Set(ByVal value As String)
            cFileName2 = value
        End Set
    End Property
    Public cFrmPrefix As String
    Public Property FrmPrefix() As String
        Get
            Return cFrmPrefix
        End Get
        Set(ByVal value As String)
            cFrmPrefix = value
        End Set
    End Property
    Private Sub cmdAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdd.Click

        If CheckAccess("AddRights", UserId, IIf(cFrmType.StartsWith("G"), UCase(cFrmType), UCase(Strings.Left(cFrmType, 9)))) = -1 Then
            If cmbVoucherType.Visible Then
                cmbVoucherType.Enabled = True
                cmbVoucherType.Focus()
                cmbVoucherType.SelectedIndex = 0
            Else
                Call ClearControls()
                Call SetControls(Actions.Entry)
                txtDescription.Focus()
            End If
            txtDate.Value = Date.Today
            txtDate.Focus()
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, IIf(cFrmType.StartsWith("G"), UCase(cFrmType), UCase(Strings.Left(cFrmType, 9)))) = -1 Then
            If Posted = 1 Then
                MsgBox("Sorry Voucher has been posted for edit or delete you have to Unpost the voucher.", vbInformation, cCompany)
                Exit Sub
            ElseIf Authorized = 1 Then
                MsgBox("Sorry Voucher has been Authorized for edit or delete you have to Unauthorized the voucher.", vbInformation, cCompany)
                Exit Sub
            ElseIf Verified = 1 Then
                MsgBox("Sorry Voucher has been Verified for edit or delete you have to Unverified the voucher.", vbInformation, cCompany)
                Exit Sub
            End If
            If txtVoucherNo.Text <> Nothing Or txtVoucherNo.Text <> "" Then
                Call SetControls(Actions.Entry)
                txtDescription.Focus()
            Else
                MsgBox("No Record Selected for Edit")
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub TDBGrid1_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles TDBGrid1.AfterColUpdate
        If TDBGrid1.Col = 10 Or TDBGrid1.Col = 11 Then
            Call Totals()
        End If
    End Sub

    Private Sub TDBGrid1_BeforeRowColChange(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.CancelEventArgs) Handles TDBGrid1.BeforeRowColChange
        If TDBGrid1.Col = 11 Then
            TDBGrid1.UpdateData()
            TDBGrid1.Update()
            Call Totals()
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        '        Dim cVoucherNo As String
        '        Dim cn As New SqlConnection(DefaultConString)
        '        Dim db As New dbOperations
        '        Dim cCurrDate As Date
        '        Dim Query As New ActionQueryBuilder
        '        TDBGrid1.UpdateData()
        'Code:
        '        ' ------------------------------------------Master File-----------------------------

        '        If txtTotalDebit.Text = Nothing Or txtTotalDebit.Text = "" Then txtTotalDebit.Text = 0
        '        If txtTotalCredit.Text = Nothing Or txtTotalCredit.Text = "" Then txtTotalCredit.Text = 0
        '        If CDbl(txtTotalDebit.Text) - CDbl(txtTotalCredit.Text) <> 0 Then
        '            MsgBox("Debit & Credit Amount Must be Equal", vbInformation, cCompany)
        '            TDBGrid1.Focus()
        '            Exit Sub
        '        End If

        '        If dbGrid.cDataTable.Rows.Count = 0 Or CDbl(txtTotalDebit.Text) = 0 Or CDbl(txtTotalCredit.Text) = 0 Then
        '            MsgBox("Must Be Enter Some Entries in Grid", vbInformation, cCompany)
        '            TDBGrid1.Focus()
        '            Exit Sub
        '        End If

        '        If txtDate.Value > DateTo Or txtDate.Value < DateFrom Then
        '            MsgBox("Date must be between the Accounting Period", vbInformation, cCompany)
        '            txtDate.Focus()
        '            Exit Sub
        '        End If

        '        'Checking Balance of Both Side Sector Wise
        '        Dim cTable As New DataTable("TmpTable")
        '        cTable.Columns.Add(New DataColumn("Project", GetType(String)))
        '        cTable.Columns.Add(New DataColumn("drAmount", GetType(Double)))
        '        cTable.Columns.Add(New DataColumn("crAmount", GetType(Double)))
        '        Dim drpj As SqlDataReader = Nothing
        '        For Each row As DataRow In dbGrid.cDataTable.Rows
        '            Dim pj As New dbOperations("select s.Code,s.Location as LocationCode,l.Project as ProjectCode, P.Name + ' - ' + L.Name + ' - ' + s.Name as Sector from tblSector s Left Outer Join tblLocation l on s.Location = l.code Left outer Join tblProject P on L.Project = P.Code Where s.Code = '" & RemoveNull(row!Sector, "", True) & "'")
        '            drpj = pj.dbSelectQuery()
        '            If drpj.Read Then
        '                Dim r As DataRow = cTable.NewRow
        '                r!Project = drpj!LocationCode + drpj!ProjectCode
        '                r!drAmount = RemoveNull(row!Debit, 0)
        '                r!crAmount = RemoveNull(row!Credit, 0)
        '                cTable.Rows.Add(r)
        '            End If
        '        Next

        '        Dim an As New Anonymous
        '        Dim arr As ArrayList = an.GetProjectWiseTotalAmount(cTable)
        '        For Each i As PAmount In arr
        '            If Not i.drAmount = i.crAmount Then
        '                Dim drp As SqlDataReader
        '                Dim pj As New dbOperations("select s.Code,s.Location as LocationCode,l.Project as ProjectCode, P.Name + ' - ' + L.Name + ' - ' + s.Name as Sector from tblSector s Left Outer Join tblLocation l on s.Location = l.code Left outer Join tblProject P on L.Project = P.Code Where s.Code = '" & Strings.Left(i.Project, 4) & "'")
        '                drp = pj.dbSelectQuery()
        '                Dim tmp As String = Double.Parse(CDbl(i.drAmount) - CDbl(i.crAmount))
        '                If drp.Read Then
        '                    MsgBox("Debit and Credit Side are not Equal" + vbCrLf + "Project : " + drp!Sector + vbCrLf + "Difference : " + tmp, MsgBoxStyle.Information)
        '                End If
        '                Exit Sub
        '            End If
        '        Next
        '        '----------------------------------------------
        '        'If String.IsNullOrEmpty(cmbProject.SelectedValue) Then
        '        '    MsgBox("Book Account Field is mandatory", vbInformation, cCompany)
        '        '    cmbProject.Focus()
        '        '    Exit Sub
        '        'End If


        '        Dim dr As SqlDataReader
        '        Dim cAdd As Boolean
        '        cCurrDate = Date.Today

        '        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select 'dtc(cFileName2).Select
        '            If IsDBNull(row!AccountCode) = True Then
        '                row.Delete()
        '                Call Totals()
        '                GoTo Code
        '            Else
        '                Dim dbChk As New dbOperations("SELECT * FROM tblAccounts WHERE AccountCode= '" & row("AccountCode") & "' and AccountLevel ='Detail'")
        '                Dim drChk As SqlDataReader = dbChk.dbSelectQuery
        '                If Not drChk.HasRows Then
        '                    MsgBox("Account Code is Wrong")
        '                    TDBGrid1.Focus()
        '                    TDBGrid1.Col = 2
        '                    Exit Sub
        '                Else
        '                    drChk.Close()
        '                    dbChk.Close()
        '                    If IsDBNull(row("Debit")) = True Then
        '                        row("Debit") = 0
        '                    End If
        '                    If IsDBNull(row("Credit")) = True Then
        '                        row("Credit") = 0
        '                    End If
        '                End If

        '                If row!AccountCode = "0102013001" And RemoveNull(row!ContraAccount, "") = "" Then
        '                    MsgBox("Please Enter Contra Account")
        '                    Exit Sub
        '                End If
        '            End If
        '        Next

        '        '--------Checck Voucher Detail Deleted or Edited Entry ----
        '        'Dim tbl As IEnumerable(Of DataRow) = DBGridDetail.cDataTable.AsEnumerable.Except(dbGrid.cDataTable.AsEnumerable, New DataRowEqualityComparer("AccountCode"))
        '        'If tbl.Count > 0 Then
        '        '    Dim dt As DataTable = tbl.CopyToDataTable
        '        '    For Each r As DataRow In dt.Rows
        '        '        For Each Row As DataRow In DBGridDetail.cDataTable.Rows
        '        '            If RemoveNull(r!AccountCode, "") = RemoveNull(Row!AccountCode, "") Then
        '        '                Row.Delete()
        '        '            End If
        '        '        Next
        '        '    Next
        '        'End If
        '        'End ----Checck Voucher Detail Deleted or Edited Entry ----

        '        If txtVoucherNo.Text = "" Or txtVoucherNo.Text = Nothing Then
        '            'If cmbVoucherType.Visible Then
        '            If cFrmPrefix = "CB" Or cFrmPrefix = "BB" Then
        '                cVoucherNo = CashBankVoucher(cEntryLocation, "tbl" + IIf(cFrmPrefix = "BB", "BankMst", "CashMst"), cFileName1, txtDate.Value, IIf((cmbVoucherType.SelectedIndex = 1), "R", "P"), cFrmPrefix)
        '            Else
        '                cVoucherNo = OtherVoucher(cEntryLocation, cFileName1, txtDate.Value, cFrmPrefix)
        '            End If
        '            'Else
        '            'db.SetQuery = "Select isnull(Max(cast(right(voucherno,3) as Numeric(9))) + 1,1) as NextVoucherNo From " & cFileName1 & " Where Entrydate = '" & Format(Date.Today, "MM/dd/yyyy") & "' and CompanyId = '" & cCompanyId & "'"
        '            'dr = db.dbSelectQuery()
        '            'If dr.HasRows Then dr.Read()
        '            'cVoucherNo = cFrmPrefix + cEntryLocation + "-" + Strings.Right(CStr(Format(txtDate.Value, "dd/MM/yyyy")), 2) + Strings.Mid(CStr(Format(Date.Today, "dd/MM/yyyy")), 4, 2) + Strings.Left(CStr(Format(txtDate.Value, "dd/MM/yyyy")), 2) + "-" + Strings.Right("000" + Trim(Str(dr("NextVoucherNo"))), 3)
        '            'dr.Close()
        '            'End If
        '            txtVoucherNo.Text = cVoucherNo
        '            cAdd = True
        '        Else 'edit 
        '            cAdd = False
        '        End If
        '        ' ------------------------------------------Master File-----------------------------
        '        Query.Refresh()
        '        Query.SetQueryInformation(cFileName1, "CompanyId = '" & cCompanyId & "' And VoucherNo = '" & txtVoucherNo.Text & "'")
        '        Query.AddFields("CompanyID", cCompanyId, ActionQueryBuilder.DataType.aString)
        '        Query.AddFields("VoucherNo", txtVoucherNo.Text, ActionQueryBuilder.DataType.aString)
        '        Query.AddFields("ChqNoMst", txtChequeNo.Text, ActionQueryBuilder.DataType.aString)
        '        Query.AddFields("EntryDate", cCurrDate, ActionQueryBuilder.DataType.aDate)
        '        Query.AddFields("VoucherDate", txtDate.Value, ActionQueryBuilder.DataType.aDate)
        '        Query.AddFields("Description", txtDescription.Text, ActionQueryBuilder.DataType.aString)
        '        Query.AddFields("PaidTo", txtPaidTo.Text, ActionQueryBuilder.DataType.aString)

        '        'Query.AddFields("Project", cmbProject.SelectedValue, ActionQueryBuilder.DataType.aString)


        '        If cmbVoucherType.Visible Then
        '            Query.AddFields("VoucherType", IIf((cmbVoucherType.SelectedIndex = 1), "R", "P"), ActionQueryBuilder.DataType.aString)
        '        End If

        '        Try
        '            If cAdd = True Then
        '                Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)
        '            Else
        '                Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)
        '            End If
        '            ' -----Detail File------------
        '            dbGrid.RefreshKeyColumns()
        '            dbGrid.SetCriteria = "VoucherNo = '" & txtVoucherNo.Text & "' and CompanyID = '" & cCompanyId & "'"
        '            dbGrid.AddKeyCol("CompanyID", cCompanyId)
        '            dbGrid.AddKeyCol("VoucherNo", txtVoucherNo.Text)
        '            dbGrid.Update()
        '            'End----- Detail File  -----------

        '            '----- Voucher Detail ---------
        '            DBGridDetail.RefreshKeyColumns()
        '            DBGridDetail.SetCriteria = "VoucherNo = '" & txtVoucherNo.Text & "' and CompanyID = '" & cCompanyId & "'"
        '            DBGridDetail.AddKeyCol("CompanyID", cCompanyId)
        '            DBGridDetail.AddKeyCol("VoucherNo", txtVoucherNo.Text)
        '            DBGridDetail.Update()
        '            'End ----- Voucher Detail ---------
        '            '--------------Update Cheque No----------
        '            If cmbVoucherType.Visible = True And cmbVoucherType.SelectedIndex = 0 And Me.cFrmType.StartsWith("Bank") Then
        '                db.SetQuery = ("Update tblChequeDtl SET Issue = 0, VoucherNo = '' Where CompanyID = '" & cCompanyId & "' And VoucherNo = '" & txtVoucherNo.Text & "'")
        '                db.dbActionQuery()
        '                Dim CurrentchqNo As String = Nothing
        '                For Each row As DataRow In dbGrid.cDataTableCollection(0).Select 'dtc(cFileName2).Select
        '                    If Not RemoveNull(row!ChequeNo, Nothing) = "" Then
        '                        If Not row!ChequeNo = CurrentchqNo And RemoveNull(row!Credit, 0) > 0 Then
        '                            db.SetQuery = "Select * from tblAccounts Where AccountType = 'Bank Book' And AccountCode= '" & row("AccountCode") & "' And AccountLevel = 'Detail'"
        '                            dr = db.dbSelectQuery
        '                            If dr.HasRows Then
        '                                db.SetQuery = ("Update tblChequeDtl SET VoucherNo = '" & txtVoucherNo.Text & "', Issue = -1 Where CompanyID = '" & cCompanyId & "' And ChequeNo = '" & row!ChequeNo & "'")
        '                                db.dbActionQuery()
        '                                CurrentchqNo = row!ChequeNo
        '                            End If
        '                        End If
        '                    End If
        '                Next
        '            End If

        '            'GenerateAutoEntry
        '            Dim cDb As New dbOperations
        '            Select Case cFrmType
        '                Case "Journal Voucher"
        '                    cDb.SetQuery = "Exec GenerateAutoJv '" & cCompanyId & "','" & txtVoucherNo.Text & "','JV'"
        '                    cDb.dbActionQuery()
        '                Case "Cash Book Multi"
        '                    cDb.SetQuery = "Exec GenerateAutoJv '" & cCompanyId & "','" & txtVoucherNo.Text & "','CB'"
        '                    cDb.dbActionQuery()
        '                Case "Bank Book Multi"
        '                    cDb.SetQuery = "Exec GenerateAutoJv '" & cCompanyId & "','" & txtVoucherNo.Text & "','BB'"
        '                    cDb.dbActionQuery()
        '            End Select

        '            'End--------------Update Cheque No----------
        '            If cAdd = True Then
        '                If MsgBox("New Voucher No # " + txtVoucherNo.Text + vbCrLf + "Do You Want To Print This Voucher?", vbYesNo + MsgBoxStyle.Question) = vbYes Then
        '                    Call Print()
        '                End If
        '            Else
        '                If MsgBox("Do You Want To Print This Voucher?", vbYesNo + MsgBoxStyle.Question) = vbYes Then
        '                    Call Print()
        '                End If
        '            End If
        '            Call SetControls(Actions.Initial)
        '            Call ClearControls()
        '        Catch ex As SqlException
        '            ' Check Error for Primary Key Constrain
        '            If ex.ErrorCode = -2146232060 Then
        '                txtVoucherNo.Text = ""
        '                GoTo Code
        '            Else
        '                MsgBox("Error While Saving Data")
        '            End If
        '        End Try
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        Select Case cFrmType
            Case "Journal Voucher"
                txtVoucherNo.Text = ShowList("Exec JVList '000000000000000','zzzzzzzzzzzzzzz','" & cCompanyId & "'", "List of " & cFrmType, 3, 0).ToString
            Case "Cash Book Multi"
                txtVoucherNo.Text = ShowList("Exec CashBookMulti '000000000000000','zzzzzzzzzzzzzzz','" & cCompanyId & "'", "List of " & cFrmType, 3, 0).ToString
            Case "Bank Book Multi"
                txtVoucherNo.Text = ShowList("Exec BankBookMulti '000000000000000','zzzzzzzzzzzzzzz','" & cCompanyId & "'", "List of " & cFrmType, 3, 0).ToString
        End Select
        If txtVoucherNo.Text = Nothing Or txtVoucherNo.Text = "" Then
            cmdAdd.Focus()
        Else
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        If CheckAccess("DeleteRights", UserId, IIf(cFrmType.StartsWith("G"), UCase(cFrmType), UCase(Strings.Left(cFrmType, 9)))) = -1 Then
            If Posted = 1 Then
                MsgBox("Sorry Voucher has been posted for edit or delete you have to Unpost the voucher.", vbInformation, cCompany)
                Exit Sub
            ElseIf Authorized = 1 Then
                MsgBox("Sorry Voucher has been Authorized for edit or delete you have to Unauthorized the voucher.", vbInformation, cCompany)
                Exit Sub
            ElseIf Verified = 1 Then
                MsgBox("Sorry Voucher has been Verified for edit or delete you have to Unverified the voucher.", vbInformation, cCompany)
                Exit Sub
            End If
            If Not txtVoucherNo.Text = "" Or Not txtVoucherNo.Text = Nothing Then

                Dim db As New dbOperations

                If MsgBox("Do You Want To Delete This Voucher", vbYesNo) = MsgBoxResult.Yes Then

                    db.SetQuery = "Delete From tblVoucherDetail Where VoucherNo = '" & txtVoucherNo.Text & "' and CompanyId = '" & cCompanyId & "'"
                    db.dbActionQuery()
                    db.SetQuery = "Delete From " & cFileName2 & " Where VoucherNo = '" & txtVoucherNo.Text & "' and CompanyId = '" & cCompanyId & "'"
                    db.dbActionQuery()
                    db.SetQuery = "Delete From " & cFileName1 & " Where VoucherNo = '" & txtVoucherNo.Text & "' and CompanyId = '" & cCompanyId & "'"
                    db.dbActionQuery()

                    '------Update Cheque
                    If cmbVoucherType.SelectedIndex = 0 And Me.cFrmType.StartsWith("Bank") And cmbVoucherType.Visible = True Then
                        db.SetQuery = ("Update tblChequeDtl SET Issue = 0, VoucherNo = '' Where CompanyID = '" & cCompanyId & "' And VoucherNo = '" & txtVoucherNo.Text & "'")
                        db.dbActionQuery()
                    End If
                    '------Update cheque

                    Call ClearControls()
                    Call SetControls(Actions.Initial)
                End If
            Else
                MsgBox("Please Select a record to delete", vbInformation)
            End If
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub
    Private Sub TDBGrid1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TDBGrid1.KeyPress
        'If e.KeyChar = ChrW(Keys.Return) Then
        '    If TDBGrid1.Col = 2 Then
        '        Dim db As New dbOperations("SELECT * FROM tblAccounts WHERE AccountCode= '" & TDBGrid1.Columns("AccountCode").Value & "' and AccountLevel ='Detail'")
        '        Dim dr As SqlDataReader = db.dbSelectQuery
        '        If Not dr.HasRows Then
        '            TDBGrid1.Col = 2
        '            TDBGrid1.EditActive = True
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub TDBGrid1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TDBGrid1.KeyUp
        'If e.KeyCode = 113 Then
        '    If TDBGrid1.Col = 2 Then
        '        TDBGrid1.Columns("AccountCode").Value = ShowList("Select tblAccounts.AccountCode,tblAccounts.AccountName,GroupName.AccountName as ControlAccount,tblAccounts.AccountLevel,tblAccounts.AccountType From tblAccounts,tblAccounts as GroupName Where tblAccounts.GroupAct = GroupName.AccountCode And tblAccounts.AccountLevel = 'Detail' Order By tblAccounts.AccountName", "List of Accounts", 1, 0).ToString
        '        If RemoveNull(TDBGrid1.Columns("AccountCode").Value, Nothing) = "" Or RemoveNull(TDBGrid1.Columns("AccountCode").Text, Nothing) = Nothing Then
        '            TDBGrid1.Col = 2
        '        Else
        '            TDBGrid1.Update()
        '            TDBGrid1.Col = 3
        '            Exit Sub
        '        End If
        '    End If

        '    If TDBGrid1.Col = 3 Then
        '        Call ShowVoucherDetail()
        '    End If
        '    If TDBGrid1.Col = 5 Then
        '        TDBGrid1.Columns("Sector").Value = ShowList("Select S.Code,L.Project as ProjectCode,P.Name as Project,S.Location as LocationCode,l.Name as Location,S.Name as Sector From tblSector s Left Outer Join tblLocation l on s.Location = l.Code Left Outer Join tblProject P on l.Project = P.Code", "List of Sector", 1, 0).ToString
        '        If RemoveNull(TDBGrid1.Columns("Sector").Value, Nothing) = "" Or RemoveNull(TDBGrid1.Columns("Sector").Text, Nothing) = Nothing Then
        '            TDBGrid1.Col = 5
        '        Else
        '            TDBGrid1.Update()
        '            TDBGrid1.Col = 6
        '        End If
        '    End If
        '    If TDBGrid1.Col = 8 And cFrmType = "Bank Book Multi" Then
        '        TDBGrid1.Columns("ChequeNo").Value = ShowList("Select d.ChequeNo, a.AccountName From tblChequeDtl d Left outer Join tblChequeMst m on d.EntryNo = m.EntryNo Left Outer Join tblAccounts a on m.BankAccount = a.AccountCode Where d.Issue = 0 and d.Cancel = 0 And m.BankAccount = '" & Me.TDBGrid1.Columns("AccountCode").Value & "' And d.CompanyID = '" & cCompanyId & "' order by cast(d.ChequeNo as numeric(9))", "List of Cheques", 0, 0).ToString
        '        If RemoveNull(TDBGrid1.Columns("ChequeNo").Value, Nothing) = "" Or RemoveNull(TDBGrid1.Columns("ChequeNo").Text, Nothing) = Nothing Then
        '            TDBGrid1.Col = 8
        '        Else
        '            TDBGrid1.Update()
        '            TDBGrid1.Col = 9
        '        End If
        '    End If
        'End If
    End Sub

    Private Sub TDBGrid1_OnAddNew(ByVal sender As Object, ByVal e As System.EventArgs) Handles TDBGrid1.OnAddNew
        TDBGrid1.Columns("ChequeDate").Text = txtDate.Value
        TDBGrid1.Columns("Description").Text = txtDescription.Text
        TDBGrid1.Columns("ChequeNo").Text = txtChequeNo.Text
    End Sub

    Private Sub cmbVoucherType_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbVoucherType.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            Call ClearControls()
            Call SetControls(Actions.Entry)
            txtDate.Value = Date.Today
            txtDescription.Focus()
        End If
    End Sub

    Private Sub cmdPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPrint.Click
        Call Print()
    End Sub
    Private Sub Print()
        Dim cSql As String = ""
        Dim fPreview As New frmPreview
        Dim rReport As New rptVoucher
        Dim cTitle As String = ""
        Dim cVouchType As String = ""

        cSql = "Exec JvList '" & txtVoucherNo.Text & "','" & txtVoucherNo.Text & "','" & cCompanyId & "'"
        cTitle = "Journal Voucher"

        Dim db As New dbOperations("Select * From tblVoucherSignature Where CompanyId = '" & cCompanyId & "' and VoucherType = '" & cFrmPrefix & "'", GLConString)
        Dim dr As SqlDataReader

        dr = db.dbSelectQuery
        If dr.HasRows Then
            dr.Read()
            rReport.fldSignature1.Text = IIf(IsDBNull(dr!Signature1), "", dr!Signature1)
            rReport.fldSignature2.Text = IIf(IsDBNull(dr!Signature2), "", dr!Signature2)
            rReport.fldSignature3.Text = IIf(IsDBNull(dr!Signature3), "", dr!Signature3)
            rReport.fldSignature4.Text = IIf(IsDBNull(dr!Signature4), "", dr!Signature4)
            rReport.fldSignature5.Text = IIf(IsDBNull(dr!Signature5), "", dr!Signature5)
            rReport.fldSignature6.Text = IIf(IsDBNull(dr!Signature6), "", dr!Signature6)
        End If
        db.Close()

        Dim ds As New DataSet
        Dim da As New SqlDataAdapter(cSql, GLConString)
        da.Fill(ds, "tblVoucherPrint")

        rReport.txtPaidTo.Visible = False
        rReport.lblPaidTo.Visible = False

        rReport.SetLicense("RGN,RGN Warez Group,DD-APN-30-C01339,W44SSM949SWJ449HSHMF")
        rReport.DataSource = ds.Tables("tblVoucherPrint")
        fPreview.arv.Document = rReport.Document
        fPreview.Text = cTitle
        rReport.fldCompany.Text = cCompanyName
        rReport.fldTitle.Text = cTitle
        rReport.fldUserID.Text = UserId
        rReport.fldDivision.Text = cDivision
        fPreview.MdiParent = frmMain

        fPreview.Show()
        rReport.Run(True)
    End Sub

    Private Sub txtDescription_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDescription.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            TDBGrid1.Focus()
            TDBGrid1.Col = 2
        End If
    End Sub

    Private Sub txtDate_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDate.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            txtDescription.Focus()
        End If
    End Sub

    Private Sub TDBGrid1_ButtonClick(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles TDBGrid1.ButtonClick
        'If e.ColIndex = 0 Then
        '    If CheckAccess("DeleteLineRights", UserId, IIf(cFrmType.StartsWith("J"), cFrmType, UCase(Strings.Left(cFrmType, 9)))) = -1 Then
        '        If TDBGrid1.RowCount > 0 Then
        '            TDBGrid1.Delete()
        '            TDBGrid1.UpdateData()
        '            Call Totals()
        '        End If
        '    Else
        '        MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
        '        Exit Sub
        '    End If
        'ElseIf e.ColIndex = 3 Then
        '    Call ShowVoucherDetail()
        'End If
    End Sub
    'Private Sub ShowVoucherDetail()
    '    If RemoveNull(TDBGrid1.Columns("AccountCode").Value, "", True) <> "" Then
    '        Dim db As New dbOperations("SELECT * FROM tblAccounts WHERE AccountCode= '" & TDBGrid1.Columns("AccountCode").Value & "' and AccountLevel ='Detail'")
    '        Dim dr As SqlDataReader = db.dbSelectQuery
    '        If dr.Read Then
    '            If (RemoveNull(dr!AccountType, "", True) = "Bank Book" Or RemoveNull(dr!AccountType, "", True) = "Cash Book") And Not cFrmType = "Journal Voucher" Then
    '                Dim frm As New frmVoucherDetail
    '                If cmbVoucherType.Visible Then
    '                    frm.PStatus = IIf((cmbVoucherType.SelectedIndex = 1), "R", "P")
    '                Else
    '                    frm.PStatus = ""
    '                End If
    '                frm.AccountCode = RemoveNull(TDBGrid1.Columns("AccountCode").Value, "", True)
    '                'frm.ProjectCode = cmbProject.SelectedValue
    '                frm.dg = DBGridDetail
    '                frm.ShowDialog()
    '            End If
    '        End If
    '    End If
    'End Sub
    'Private Sub TDBGrid1_BeforeColUpdate(ByVal sender As System.Object, ByVal e As C1.Win.C1TrueDBGrid.BeforeColUpdateEventArgs) Handles TDBGrid1.BeforeColUpdate
    '    If e.ColIndex = 1 And e.Column.DataColumn.Value <> RemoveNull(e.OldValue, "") Then
    '        For i As Int16 = 0 To DBGridDetail.cDataTable.Rows.Count - 1
    '            Try

    '                If DBGridDetail.cDataTable.Rows(i).Item("AccountCode") = RemoveNull(e.OldValue, "", True) Then
    '                    DBGridDetail.cDataTable.Rows(i).Delete()
    '                    TDBGrid1.UpdateData()
    '                End If
    '            Catch ex As Exception
    '            End Try
    '        Next
    '    End If
    'End Sub

    Private Sub TDBGrid1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TDBGrid1.Click

    End Sub
End Class
