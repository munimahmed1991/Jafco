Imports System
Imports System.Data
Imports System.Data.SqlClient


Public Class frmGenerateInvoice

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub frmGenerateInvoice_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtDueDateFrom.Value = Nothing
        txtDueDateTo.Value = Nothing

        txtInvoiceDate.Value = Nothing

        Call FormCenter(Me)
        Call FillCombo()
    End Sub

    Sub FillCombo()
        Dim Project As New BindCombo(cmbProject, "Select Code,Name From tblProjectFile", "Name", "Code", True, True)
        Dim UnitType As New BindCombo(cmbUnitType, "Select Code,Name From tblUnitType", "Name", "Code", True, True)
        Dim Block As New BindCombo(cmbBlock, "Select Code,Name From tblBlock", "Name", "Code", True, True)
        Dim Unit As New BindCombo(cmbUnit, "Select Code,UnitNumber From tblUnitFile", "UnitNumber", "Code", True, True)
    End Sub

    Private Sub cmdGenerate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGenerate.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Select Project - Cannot Proceed")
            Exit Sub
        End If

        If txtDueDateFrom.Value = Nothing Then
            MsgBox("Input Due Date From - Cannot Proceed")
            Exit Sub
        End If

        If txtDueDateTo.Value = Nothing Then
            MsgBox("Input Due Date To - Cannot Proceed")
            Exit Sub
        End If

        If txtInvoiceDate.Value = Nothing Then
            MsgBox("Input Invoice Date From - Cannot Proceed")
            Exit Sub
        End If


        Dim cSql As String
        Dim cInvoiceNo As String
        Dim cPrefix As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * From tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cPrefix = dr!Prefix
        End If

        db.Close()
        dr.Close()

        cSql = "Select	tblReservationMst.ReservationNo,Project,Customer,Customer2,UnitType,Unit,"
        cSql += "PaymentType, tblReservationDtl.ExtraCharges, Installment, DueDate, Amount "
        cSql += "From  tblReservationMst, tblReservationDtl "
        cSql += "Where tblReservationMst.ReservationNo = tblReservationDtl.ReservationNo "
        cSql += "And   Ltrim(Rtrim(Unit)) + Ltrim(Rtrim(PaymentType)) + ' ' + Ltrim(Rtrim(Cast(Installment as Varchar(2)))) Not In (Select Ltrim(Rtrim(Unit)) + Ltrim(Rtrim(PaymentType)) + ' ' + Ltrim(Rtrim(Cast(Installment as Varchar(2)))) from tblInvoice) "
        cSql += "And   IsNull(NotDecided,0) = 0  and IsNull(Cancel,0) = 0 "
        cSql += "And   tblReservationMst.Project = '" & cmbProject.SelectedValue & "' "

        If cmbUnitType.SelectedValue <> "" Then
            cSql += "And   tblReservationMst.UnitType = '" & cmbUnitType.SelectedValue & "' "
        End If

        If cmbBlock.SelectedValue <> "" Then
            cSql += "And   tblReservationMst.Unit In (Select Code From tblUnitFile Where Block = '" & cmbBlock.SelectedValue & "' "
        End If

        If cmbUnit.SelectedValue <> "" Then
            cSql += "And   tblReservationMst.Unit = '" & cmbUnit.SelectedValue & "' "
        End If

        cSql += "And   tblReservationDtl.DueDate between '" & Format(txtDueDateFrom.Value, "MM/dd/yyyy") & "' and '" & Format(txtDueDateTo.Value, "MM/dd/yyyy") & "' "

        db = New dbOperations(cSql)
        dr = db.dbSelectQuery

        If dr.HasRows Then
            dr.Read()

            cInvoiceNo = NextSerial("InvoiceNo", "tblInvoice", "00000000", "INV" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "' and IsNull(Penalty,0) = 0")

            cSql = "Insert Into tblInvoice(InvoiceNo,InvoiceDate,Project,Customer1,Customer2,UnitType,Unit,PaymentType,ExtraCharges,DueDate,Amount,Installment,NotDecided) Values('" & cInvoiceNo & "','" & Format(txtInvoiceDate.Value, "MM/dd/yyyy") & "','" & dr!Project & "','" & dr!Customer & "','" & dr!Customer2 & "','" & dr!UnitType & "','" & dr!Unit & "','" & dr!PaymentType & "','" & dr!ExtraCharges & "','" & Format(dr!DueDate, "MM/dd/yyyy") & "'," & dr!Amount & "," & dr!Installment & ",0)"


            db = New dbOperations(cSql)
            db.dbActionQuery()

            db = New dbOperations("Update tblReservationDtl Set InvoiceNo = '" & cInvoiceNo & "' Where PaymentType = '" & dr!PaymentType & "' and Installment = " & dr!Installment & " and ReservationNo In (Select ReservationNo From tbLReservationMst Where Unit = '" & dr!Unit & "')")
            db.dbActionQuery()

            For Each DataRow In dr
                cInvoiceNo = NextSerial("InvoiceNo", "tblInvoice", "00000000", "INV" + cPrefix + "-", "Project = '" & cmbProject.SelectedValue & "' and IsNull(Penalty,0) = 0")

                cSql = "Insert Into tblInvoice(InvoiceNo,InvoiceDate,Project,Customer1,Customer2,UnitType,Unit,PaymentType,ExtraCharges,DueDate,Amount,Installment,NotDecided) Values('" & cInvoiceNo & "','" & Format(txtInvoiceDate.Value, "MM/dd/yyyy") & "','" & dr!Project & "','" & dr!Customer & "','" & dr!Customer2 & "','" & dr!UnitType & "','" & dr!Unit & "','" & dr!PaymentType & "','" & dr!ExtraCharges & "','" & Format(dr!DueDate, "MM/dd/yyyy") & "'," & dr!Amount & "," & dr!Installment & ",0)"

                db = New dbOperations(cSql)
                db.dbActionQuery()

                db = New dbOperations("Update tblReservationDtl Set InvoiceNo = '" & cInvoiceNo & "' Where PaymentType = '" & dr!PaymentType & "' and Installment = " & dr!Installment & " and ReservationNo In (Select ReservationNo From tbLReservationMst Where Unit = '" & dr!Unit & "')")
                db.dbActionQuery()
            Next

            MsgBox("All Invoices Generated Successfully")
        End If
    End Sub

    Private Sub cmdProjectType_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdProjectType.Click
        cmbUnitType.SelectedValue = ShowList("Select tblUnitType.Code,tblUnitType.Name as UnitType,tblProjectFile.Name as Project,CashAmount,LoanAmount,TotalRevenue From tblUnitType,tblProjectFile Where tblUnitType.Project = '" & cmbProject.SelectedValue & "' and tblUnitType.Project = tblProjectFile.Code Order By tblUnitType.Code", "List of Unit Type", 1, 0)
    End Sub

    Private Sub cmdUnit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUnit.Click
        If cmbProject.SelectedValue = "" Then
            MsgBox("Please Select Project First in Search")
            Exit Sub
        End If

        If cmbUnitType.SelectedValue = "" Then
            MsgBox("Please Select Unit Type First in Search")
            Exit Sub
        End If

        Dim cSql As String
        Dim cProject As String

        Dim db As dbOperations
        Dim dr As SqlDataReader

        db = New dbOperations("Select * from tblProjectFile Where Code = '" & cmbProject.SelectedValue & "'")
        dr = db.dbSelectQuery

        If dr.HasRows = True Then
            dr.Read()
        Else
            MsgBox("No Entries Found for the Select Project in Project File")
            Exit Sub
        End If

        cSql = "Select tblUnitFile.Code,tblProjectFile.Name as Project,tblUnitFile.UnitNumber,tblBlock.Name as Block,tblUnitType.Name as UnitType,1 as Unit,tblUnitFile.CashAmount,tblUnitFile.LoanAmount,tblUnitFile.TotalRevenue, "
        cSql = cSql + "IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as ExtraCharges,"
        cSql = cSql + "tblUnitFile.TotalRevenue + IsNull(tblUnitFile.ExtraChargesAmount1,0) + IsNull(tblUnitFile.ExtraChargesAmount2,0) + IsNull(tblUnitFile.ExtraChargesAmount3,0) + IsNull(tblUnitFile.ExtraChargesAmount4,0) + IsNull(tblUnitFile.ExtraChargesAmount5,0) + IsNull(tblUnitFile.ExtraChargesAmount6,0) + IsNull(tblUnitFile.ExtraChargesAmount7,0) + IsNull(tblUnitFile.ExtraChargesAmount8,0) + IsNull(tblUnitFile.ExtraChargesAmount9,0) + IsNull(tblUnitFile.ExtraChargesAmount10,0) + IsNull(tblUnitFile.ExtraChargesAmount11,0) + IsNull(tblUnitFile.ExtraChargesAmount12,0) + IsNull(tblUnitFile.ExtraChargesAmount13,0) + IsNull(tblUnitFile.ExtraChargesAmount14,0) + IsNull(tblUnitFile.ExtraChargesAmount15,0) as GrossTotal"

        If RemoveNull(dr!ExtraCharges1, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges1Apply,0) = 1 Then Charges1.Name Else '' End as ExtraCharges1,IsNull(tblUnitFile.ExtraChargesAmount1,0) as ExtraChargesAmount1 "
        End If

        If RemoveNull(dr!ExtraCharges2, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges2Apply,0) = 1 Then Charges2.Name Else '' End as ExtraCharges2,IsNull(tblUnitFile.ExtraChargesAmount2,0) as ExtraChargesAmount2 "
        End If

        If RemoveNull(dr!ExtraCharges3, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges3Apply,0) = 1 Then Charges3.Name Else '' End as ExtraCharges3,IsNull(tblUnitFile.ExtraChargesAmount3,0) as ExtraChargesAmount3 "
        End If

        If RemoveNull(dr!ExtraCharges4, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges4Apply,0) = 1 Then Charges4.Name Else '' End as ExtraCharges4,IsNull(tblUnitFile.ExtraChargesAmount4,0) as ExtraChargesAmount4 "
        End If

        If RemoveNull(dr!ExtraCharges5, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges5Apply,0) = 1 Then Charges5.Name Else '' End as ExtraCharges5,IsNull(tblUnitFile.ExtraChargesAmount5,0) as ExtraChargesAmount5 "
        End If

        If RemoveNull(dr!ExtraCharges6, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges6Apply,0) = 1 Then Charges6.Name Else '' End as ExtraCharges6,IsNull(tblUnitFile.ExtraChargesAmount6,0) as ExtraChargesAmount6 "
        End If

        If RemoveNull(dr!ExtraCharges7, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges7Apply,0) = 1 Then Charges7.Name Else '' End as ExtraCharges7,IsNull(tblUnitFile.ExtraChargesAmount7,0) as ExtraChargesAmount7 "
        End If

        If RemoveNull(dr!ExtraCharges8, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges8Apply,0) = 1 Then Charges8.Name Else '' End as ExtraCharges8,IsNull(tblUnitFile.ExtraChargesAmount8,0) as ExtraChargesAmount8 "
        End If

        If RemoveNull(dr!ExtraCharges9, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges9Apply,0) = 1 Then Charges9.Name Else '' End as ExtraCharges9,IsNull(tblUnitFile.ExtraChargesAmount9,0) as ExtraChargesAmount9 "
        End If

        If RemoveNull(dr!ExtraCharges10, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges10Apply,0) = 1 Then Charges10.Name Else '' End as ExtraCharges10,IsNull(tblUnitFile.ExtraChargesAmount10,0) as ExtraChargesAmount10 "
        End If

        If RemoveNull(dr!ExtraCharges11, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges11Apply,0) = 1 Then Charges11.Name Else '' End as ExtraCharges11,IsNull(tblUnitFile.ExtraChargesAmount11,0) as ExtraChargesAmount11 "
        End If

        If RemoveNull(dr!ExtraCharges12, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges12Apply,0) = 1 Then Charges12.Name Else '' End as ExtraCharges12,IsNull(tblUnitFile.ExtraChargesAmount12,0) as ExtraChargesAmount12 "
        End If

        If RemoveNull(dr!ExtraCharges13, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges13Apply,0) = 1 Then Charges13.Name Else '' End as ExtraCharges13,IsNull(tblUnitFile.ExtraChargesAmount13,0) as ExtraChargesAmount13 "
        End If

        If RemoveNull(dr!ExtraCharges14, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges14Apply,0) = 1 Then Charges14.Name Else '' End as ExtraCharges14,IsNull(tblUnitFile.ExtraChargesAmount14,0) as ExtraChargesAmount14  "
        End If

        If RemoveNull(dr!ExtraCharges15, "") <> "" Then
            cSql = cSql + ",Case When IsNull(ExtraCharges15Apply,0) = 1 Then Charges15.Name Else '' End as ExtraCharges15,IsNull(tblUnitFile.ExtraChargesAmount15,0) as ExtraChargesAmount15 "
        End If

        cSql = cSql + "From tblUnitFile "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges1 On Charges1.Code = tblUnitFile.ExtraCharges1 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges2 On Charges2.Code = tblUnitFile.ExtraCharges2 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges3 On Charges3.Code = tblUnitFile.ExtraCharges3 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges4 On Charges4.Code = tblUnitFile.ExtraCharges4 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges5 On Charges5.Code = tblUnitFile.ExtraCharges5 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges6 On Charges6.Code = tblUnitFile.ExtraCharges6 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges7 On Charges7.Code = tblUnitFile.ExtraCharges7 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges8 On Charges8.Code = tblUnitFile.ExtraCharges8 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges9 On Charges9.Code = tblUnitFile.ExtraCharges9 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges10 On Charges10.Code = tblUnitFile.ExtraCharges10 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges11 On Charges11.Code = tblUnitFile.ExtraCharges11 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges12 On Charges12.Code = tblUnitFile.ExtraCharges12 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges13 On Charges13.Code = tblUnitFile.ExtraCharges13 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges14 On Charges14.Code = tblUnitFile.ExtraCharges14 "
        cSql = cSql + "Left Outer Join tblExtraCharges Charges15 On Charges15.Code = tblUnitFile.ExtraCharges15 "
        cSql = cSql + ",tblProjectFile,tblUnitType,tblBlock "
        cSql = cSql + "Where tblUnitFile.UnitType = tblUnitType.Code "
        cSql = cSql + "And tblUnitFile.Project = tblProjectFile.Code "
        cSql = cSql + "And tblUnitFile.Block = tblBlock.Code "
        cSql = cSql + "And tblUnitFile.Project = '" & cmbProject.SelectedValue & "' "
        cSql = cSql + "And tblUnitFile.UnitType = '" & cmbUnitType.SelectedValue & "' "
        cSql = cSql + "And tblUnitfile.Code In (Select Unit From tblReservationMst) "
        cSql = cSql + "Order By tblUnitFile.Code "

        cmbUnit.SelectedValue = ShowList(cSql, "List of Units", 1, 0)
    End Sub

    Private Sub cmbUnit_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbUnit.TextChanged

    End Sub
End Class