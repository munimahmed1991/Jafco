Imports System.Data
Imports System.Data.SqlClient

Public Class frmProductMaster
    Dim dbGrid As BindGrid

    Enum Actions As Byte
        Initial
        Edit
        Entry
    End Enum

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Sub SetControls(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                Call SetButtons(Actions.Initial)

                tvwProduct.Enabled = True

                txtProductCode.Enabled = True
                cmbProductName.Enabled = False
                cmbUoM.Enabled = False
                cmbStatus.Enabled = False
                cmbProductLevel.Enabled = False
                txtMinOrder.Enabled = False
                cmbProductType.Enabled = False
                txtMinInv.Enabled = False
                txtMaxInv.Enabled = False
                cmbLocation.Enabled = False
                cmbProductAccount.Enabled = False
                cmbGSTCode.Enabled = False

                tdbGridOpening.Enabled = False
            Case Actions.Edit
                Call SetButtons(Actions.Edit)

                tvwProduct.Enabled = True

                txtProductCode.Enabled = False
                cmbProductName.Enabled = False
                cmbUoM.Enabled = False
                cmbStatus.Enabled = False
                cmbProductLevel.Enabled = False
                txtMinOrder.Enabled = False
                txtMinInv.Enabled = False
                txtMaxInv.Enabled = False
                cmbProductType.Enabled = False
                cmbLocation.Enabled = False
                cmbProductAccount.Enabled = False
                cmbGSTCode.Enabled = False

                tdbGridOpening.Enabled = False
            Case Actions.Entry
                Call SetButtons(Actions.Entry)

                tvwProduct.Enabled = False

                txtProductCode.Enabled = False
                cmbProductName.Enabled = True
                cmbUoM.Enabled = True
                cmbStatus.Enabled = True
                cmbProductLevel.Enabled = True
                txtMinOrder.Enabled = True
                txtMinInv.Enabled = True
                txtMaxInv.Enabled = True
                cmbProductType.Enabled = True
                cmbLocation.Enabled = True
                cmbProductAccount.Enabled = True
                cmbGSTCode.Enabled = True

                tdbGridOpening.Enabled = True
        End Select
    End Sub

    Private Sub SetButtons(ByVal a As Actions)
        Select Case a
            Case Actions.Initial
                cmdSearch.Enabled = True
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = False
                cmdUndo.Enabled = False
                cmdExit.Enabled = True

                EditToolStripMenuItem.Enabled = False
            Case Actions.Edit
                cmdSearch.Enabled = True
                cmdEdit.Enabled = True
                cmdDelete.Enabled = True
                cmdSave.Enabled = False
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                EditToolStripMenuItem.Enabled = True
            Case Actions.Entry
                cmdSearch.Enabled = False
                cmdEdit.Enabled = False
                cmdDelete.Enabled = False
                cmdSave.Enabled = True
                cmdUndo.Enabled = True
                cmdExit.Enabled = False

                EditToolStripMenuItem.Enabled = False
        End Select
    End Sub

    Sub ClearControls()
        txtProductCode.Text = ""
        cmbProductName.Text = ""
        cmbStatus.SelectedIndex = 0
        txtMinOrder.Value = 0
        txtMinInv.Value = 0
        txtMaxInv.Value = 0
        cmbProductType.Text = "General"
        cmbGSTCode.SelectedValue = ""
        cmbLocation.SelectedValue = ""
        cmbProductAccount.SelectedValue = ""

        tdbGridOpening.DataSource = Nothing

        tdbGridOpening.Columns("Qty").FooterText = ""

        Call FillCombo()
    End Sub

    Sub FillTree()
        Dim cn As New SqlConnection(ConString)
        Dim Sql As String = "Select * From tblProductMaster"
        Dim DS As New DataSet
        Dim DP As New SqlDataAdapter(Sql, cn)

        Try
            cn.Open()
            DP.Fill(DS, "tblProductMaster")
            Dim dtc As DataTableCollection = DS.Tables
            tvwProduct.BeginUpdate()
            tvwProduct.Nodes.Clear()

            For Each row As DataRow In dtc("tblProductMaster").Select("", "ProductDigit, ProductCode asc")
                If CInt(row("ProductDigit")) = 1 Then
                    Me.tvwProduct.Nodes.Add(row("ProductCode"), row("ProductName") + "(" + row("ProductCode") + ")")
                ElseIf CInt(row("ProductDigit")) = 2 Then
                    Me.tvwProduct.Nodes(Mid(row("ProductCode"), 1, cProductLevel1)).Nodes.Add(row("ProductCode"), row("ProductName") + "(" + row("ProductCode") + ")")
                ElseIf CInt(row("ProductDigit")) = 3 Then
                    Me.tvwProduct.Nodes(Mid(row("ProductCode"), 1, cProductLevel1)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2)).Nodes.Add(row("ProductCode"), row("ProductName") + "(" + row("ProductCode") + ")")
                ElseIf CInt(row("ProductDigit")) = 4 Then
                    Me.tvwProduct.Nodes(Mid(row("ProductCode"), 1, cProductLevel1)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes.Add(row("ProductCode"), row("ProductName") + "(" + row("ProductCode") + ")")
                ElseIf CInt(row("ProductDigit")) = 5 Then
                    Me.tvwProduct.Nodes(Mid(row("ProductCode"), 1, cProductLevel1)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes.Add(row("ProductCode"), row("ProductName") + "(" + row("ProductCode") + ")")
                ElseIf CInt(row("ProductDigit")) = 6 Then
                    Me.tvwProduct.Nodes(Mid(row("ProductCode"), 1, cProductLevel1)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)).Nodes.Add(row("ProductCode"), row("ProductName") + "(" + row("ProductCode") + ")")
                ElseIf CInt(row("ProductDigit")) = 7 Then
                    Me.tvwProduct.Nodes(Mid(row("ProductCode"), 1, cProductLevel1)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)).Nodes(Mid(row("ProductCode"), 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6)).Nodes.Add(row("ProductCode"), row("ProductName") + "(" + row("ProductCode") + ")")
                End If
            Next

            tvwProduct.EndUpdate()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.Close()
            DP.Dispose()
        End Try
    End Sub

    Private Sub frmProductMaster_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        If tvwProduct.Nodes.Count = 0 Then
            Dim cDigit As String

            cDigit = Strings.Left("0000000000000", cProductLevel1)

            Call GetSibling(cDigit)
            Call DisplayRec()
            cmbProductName.Focus()
        End If
    End Sub

    Private Sub frmProductMaster_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call FillTree()
        Call SetControls(Actions.Initial)
        Call FormCenter(Me)
        Call ClearControls()

        tdbGridOpening.Columns("Qty").FooterText = ""

        lblMinInv.Visible = True
        lblMaxInv.Visible = True
        txtMinInv.Visible = True
        txtMaxInv.Visible = True
    End Sub

    Sub FillCombo()
        Dim ProductName As New BindCombo(cmbProductName, "Select ProductName From tblProductMaster Order By ProductName", "ProductName", "ProductName", True, True)
        Dim ProductUoM As New BindCombo(cmbUoM, "Select UoM From tblProductMaster Group By UoM", "UoM", "UoM", True, True)
        Dim Location As New BindCombo(tdbLocation, "Select LocationCode,LocationName From tblLocation  Order By LocationName", "LocationName", "LocationCode", True)
        Dim cLocation As New BindCombo(cmbLocation, "Select LocationCode,LocationName From tblLocation  Order By LocationName", "LocationName", "LocationCode", True, True)
        Dim cColor As New BindCombo(tdbColor, "Select Code,Name From tblColor Order BY Name", "Name", "Code", True)

        If UCase(Mid(cCompanyName, 1, 7)) <> "ROWASKY" Then
            Dim cProductAccount As New BindCombo(cmbProductAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' and AccountType <> 'Customer' and AccountType <> 'Supplier'  Order BY AccountName", "AccountName", "AccountCode", True, True, GLConString)
        Else
            Dim cProductAccount As New BindCombo(cmbProductAccount, "Select AccountCode,AccountName From tblAccounts Where AccountLevel = 'Detail' and AccountType = 'Stock' Order BY AccountName", "AccountName", "AccountCode", True, True, GLConString)
        End If

        Dim cGSTCode As New BindCombo(cmbGSTCode, "Select Code,Name From tblGSTSetup Order By Name", "Name", "Code", True, True)
    End Sub

    Private Sub DisplayRec()
        If txtProductCode.Text <> Nothing Then
            Dim cSql As String = "Select * From tblProductMaster Where ProductCode = '" & txtProductCode.Text & "'"
            Dim db As New dbOperations(cSql)
            Dim dr As SqlDataReader = db.dbSelectQuery()

            If dr.HasRows Then
                dr.Read()

                cmbProductName.Text = RemoveNull(dr.Item("ProductName"), "")
                cmbUoM.Text = RemoveNull(dr.Item("UoM"), "")

                cmbProductLevel.Text = RemoveNull(dr.Item("ProductLevel"), "")
                cmbStatus.SelectedText = RemoveNull(dr.Item("Status"), "Active")
                txtMinOrder.Value = RemoveNull(dr.Item("MinOrder"), 0)
                txtMaxInv.Value = RemoveNull(dr.Item("MaxInv"), 0)
                txtMinInv.Value = RemoveNull(dr.Item("MinInv"), 0)
                cmbProductType.Text = RemoveNull(dr.Item("ProductType"), "General")
                cmbLocation.SelectedValue = RemoveNull(dr.Item("DefaultLocation"), "")
                cmbProductAccount.SelectedValue = RemoveNull(dr!ProductAccount, "")
                cmbGSTCode.SelectedValue = RemoveNull(dr!GSTCode, "")

                Call SetControls(Actions.Edit)
            Else
                If Len(txtProductCode.Text) = cProductLevel1 Or Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 Or Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 Or Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 Or Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 Or Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 Or Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7 Then
                    Call CheckControl(txtProductCode.Text)
                Else
                    MsgBox("Invalid Length of Product", vbInformation)
                    Exit Sub
                End If
            End If
        End If

        dbGrid = New BindGrid(tdbGridOpening, "Select ProductCode,Location,Qty,Rate From tblProductOpening Where ProductCode = '" & txtProductCode.Text & "'")

        Call Totals()
    End Sub

    Private Sub CheckControl(ByVal Product As String)
        Dim cPrdLength As Double
        Dim nGrpCode As String = ""

        cPrdLength = Len(Product)

        Select Case cPrdLength
            Case cProductLevel1
                Call SetControls(Actions.Entry)
                Exit Sub
            Case cProductLevel1 + cProductLevel2
                nGrpCode = Mid(Product, 1, cProductLevel1)
            Case cProductLevel1 + cProductLevel2 + cProductLevel3
                nGrpCode = Mid(Product, 1, cProductLevel1 + cProductLevel2)
            Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4
                nGrpCode = Mid(Product, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)
            Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5
                nGrpCode = Mid(Product, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)
            Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6
                nGrpCode = Mid(Product, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)
            Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7
                nGrpCode = Mid(Product, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6)
        End Select

        Dim cSql As String = "Select * from tblProductMaster Where ProductCode = '" & nGrpCode & "' and ProductLevel = 'Control'"
        Dim db As New dbOperations(cSql)
        Dim dr As SqlDataReader = db.dbSelectQuery()

        If dr.HasRows > 0 Then
            dr.Read()

            Call SetControls("Entry")
            cmbProductName.Focus()
        End If
    End Sub

    Private Sub cmdUndo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdUndo.Click
        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If CheckAccess("EditRights", UserId, "PRODUCT MASTER FILE") = -1 Then
            Call SetControls(Actions.Entry)
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSave.Click
        Dim db As New dbOperations("Select * From tblProductMaster Where ProductCode = '" & txtProductCode.Text & "'")
        Dim dr As SqlDataReader = db.dbSelectQuery()
        Dim cGroupProduct As String = "", cProductDigit As Integer


        If CheckDuplicate("tblProductMaster", "ProductName", cmbProductName.Text, txtProductCode.Text, "ProductCode") = True Then
            MsgBox("Already Exist")
            Exit Sub
        End If

        If Not dr.HasRows Then
            If Len(txtProductCode.Text) = cProductLevel1 Then
                cProductDigit = 1
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 Then
                cProductDigit = 2
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 Then
                cProductDigit = 3
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 Then
                cProductDigit = 4
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 Then
                cProductDigit = 5
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 Then
                cProductDigit = 6
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7 Then
                cProductDigit = 7
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6)
            End If

            'Update TreeView
            If Len(txtProductCode.Text) = cProductLevel1 Then
                Me.tvwProduct.Nodes.Add(txtProductCode.Text, cmbProductName.Text + "(" + txtProductCode.Text + ")")
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes.Add(txtProductCode.Text, cmbProductName.Text + "(" + txtProductCode.Text + ")")
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes.Add(txtProductCode.Text, cmbProductName.Text + "(" + txtProductCode.Text + ")")
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes.Add(txtProductCode.Text, cmbProductName.Text + "(" + txtProductCode.Text + ")")
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes.Add(txtProductCode.Text, cmbProductName.Text + "(" + txtProductCode.Text + ")")
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)).Nodes.Add(txtProductCode.Text, cmbProductName.Text + "(" + txtProductCode.Text + ")")
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6)).Nodes.Add(txtProductCode.Text, cmbProductName.Text + "(" + txtProductCode.Text + ")")
            End If
        Else
            If Len(txtProductCode.Text) = cProductLevel1 Then
                cProductDigit = 1
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 Then
                cProductDigit = 2
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 Then
                cProductDigit = 3
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 Then
                cProductDigit = 4
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 Then
                cProductDigit = 5
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 Then
                cProductDigit = 6
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7 Then
                cProductDigit = 7
                cGroupProduct = Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6)
            End If

            ' Update TreeView
            'Me.tvwProducts.SelectedNode.Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            If Len(txtProductCode.Text) = cProductLevel1 Then
                Me.tvwProduct.Nodes(txtProductCode.Text).Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(txtProductCode.Text).Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(txtProductCode.Text).Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(txtProductCode.Text).Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes(txtProductCode.Text).Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)).Nodes(txtProductCode.Text).Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            ElseIf Len(txtProductCode.Text) = cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7 Then
                Me.tvwProduct.Nodes(Mid(txtProductCode.Text, 1, cProductLevel1)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5)).Nodes(Mid(txtProductCode.Text, 1, cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6)).Nodes(txtProductCode.Text).Text = cmbProductName.Text + "(" + txtProductCode.Text + ")"
            End If
        End If

        Dim Query As New ActionQueryBuilder
        Query.Refresh()
        Query.SetQueryInformation("tblProductMaster", "ProductCode = '" & txtProductCode.Text & "'")

        Query.AddFields("ProductCode", txtProductCode.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ProductName", cmbProductName.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("UoM", cmbUoM.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("GroupProduct", cGroupProduct, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ProductLevel", cmbProductLevel.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ProductDigit", cProductDigit, ActionQueryBuilder.DataType.aString)
        Query.AddFields("Status", cmbStatus.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("MinOrder", txtMinOrder.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("MinInv", txtMinInv.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("MaxInv", txtMaxInv.Value, ActionQueryBuilder.DataType.aDecimal)
        Query.AddFields("ProductType", cmbProductType.Text, ActionQueryBuilder.DataType.aString)
        Query.AddFields("GSTCode", cmbGSTCode.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("DefaultLocation", cmbLocation.SelectedValue, ActionQueryBuilder.DataType.aString)
        Query.AddFields("ProductAccount", cmbProductAccount.SelectedValue, ActionQueryBuilder.DataType.aString)

        If Not dr.HasRows Then
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Insert)

            AddInfo(txtProductCode.Text, "Add Record in PRODUCT MASTER FILE Product Name : " + "" + cmbProductName.Text)
        Else
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Update)

            EditInfo(txtProductCode.Text, "Edit Record in PRODUCT MASTER FILE Product Name : " + "" + cmbProductName.Text)
        End If

        dbGrid.SetCriteria = "ProductCode = '" & txtProductCode.Text & "'"

        dbGrid.RefreshKeyColumns()
        dbGrid.AddKeyCol("ProductCode", txtProductCode.Text)
        dbGrid.Update()

        dr.Close()
        db.Close()

        Call ClearControls()
        Call SetControls(Actions.Initial)
    End Sub

    Private Sub tvwProducts_AfterSelect(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tvwProduct.AfterSelect
        txtProductCode.Text = tvwProduct.SelectedNode.Name ' Mid(tvwProducts.SelectedNode.Name,  2, Len(tvwProducts.SelectedItem.Key))

        Call DisplayRec()
    End Sub

    Private Sub EditToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditToolStripMenuItem.Click
        If Not txtProductCode.Text = "" Then
            Call SetControls(Actions.Entry)

            cmbProductName.Focus()
        Else
            MsgBox("Please Select First")
        End If
    End Sub

    Public Sub GetChildProduct(ByVal Product As String)
        Dim db As New dbOperations()
        Dim cProductLevel As String
        Dim nDigit As Double
        Dim cProductCode As String

        db.SetQuery = "Select * From tblProductMaster Where GroupProduct = '" & Product & "' and ProductDigit <> 1"
        Dim dr As SqlDataReader = db.dbSelectQuery()
        If dr.HasRows Then dr.Read()
        If Not dr.HasRows Then
            cProductLevel = Len(Product)

            Select Case cProductLevel
                Case cProductLevel1
                    nDigit = cProductLevel2
                Case cProductLevel1 + cProductLevel2
                    nDigit = cProductLevel3
                Case cProductLevel1 + cProductLevel2 + cProductLevel3
                    nDigit = cProductLevel4
                Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4
                    nDigit = cProductLevel5
                Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5
                    nDigit = cProductLevel6
                Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6
                    nDigit = cProductLevel7
                Case cProductLevel1 + cProductLevel2 + cProductLevel3 + cProductLevel4 + cProductLevel5 + cProductLevel6 + cProductLevel7
                    MsgBox("Cannot Open Child Account at Level 7")
                    Exit Sub
            End Select

            Call ClearControls()

            txtProductCode.Text = Product + Microsoft.VisualBasic.Strings.Right("00000000000001", CInt(nDigit))

            Call SetControls(Actions.Entry)
        Else
            db.SetQuery = "Select Max(Cast(ProductCode as numeric) + 1) as ProductCode From tblProductMaster Where GroupProduct = '" & Product & "'"
            dr.Close()
            dr = db.dbSelectQuery()
            If dr.HasRows Then dr.Read()

            If Mid(Product, 1, 1) = "0" Then
                cProductCode = Mid("000000000", 1, cProductLevel1 - 1) + Trim(Str(dr.Item("ProductCode")))
            Else
                cProductCode = Trim(Str(dr.Item("ProductCode")))
            End If

            Call ClearControls()
            txtProductCode.Text = cProductCode
            Call SetControls(Actions.Entry)
        End If

        Call DisplayRec()

        db.Close()
    End Sub

    Public Sub GetSibling(ByVal cProduct)
        Dim db As New dbOperations()
        Dim dr As SqlDataReader

        db.SetQuery = "select GroupProduct From tblProductMaster Where ProductCode = '" & cProduct & "'"
        dr = db.dbSelectQuery()

        Dim cdigit As Integer = Len(cProduct)
        Dim gProduct As String

        If dr.HasRows Then
            dr.Read()
            gProduct = dr.Item("GroupProduct")
        Else
            gProduct = ""
            For i As Integer = 1 To cProductLevel1
                gProduct += "0"
            Next

        End If

        If cProduct = gProduct Then
            db.SetQuery = "Select isNull(Max(Cast(ProductCode as numeric)),0) + 1 as ProductCode From tblProductMaster Where LEN(ProductCode) = '" & cdigit & "'"
            dr.Close()
        Else
            db.SetQuery = "Select isNull(Max(Cast(ProductCode as numeric)),0) + 1 as ProductCode From tblProductMaster Where LEN(ProductCode) = '" & cdigit & "' AND GroupProduct = '" & gProduct & "'"
            dr.Close()
        End If

        dr = db.dbSelectQuery()

        If dr.HasRows Then dr.Read()

        Dim cProductCode As String

        Dim strtmp As String = ""
        For i As Integer = 1 To cdigit
            strtmp += "0"
        Next

        cProductCode = Strings.Format(dr!ProductCode, strtmp)
        db.Close()

        Call ClearControls()
        txtProductCode.Text = cProductCode
        Call SetControls(Actions.Entry)

        Call DisplayRec()
    End Sub

    Private Sub tvwProducts_BeforeCollapse(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvwProduct.BeforeCollapse
        e.Node.ImageIndex = 0
        e.Node.SelectedImageIndex = 0
    End Sub

    Private Sub tvwProducts_BeforeExpand(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewCancelEventArgs) Handles tvwProduct.BeforeExpand
        e.Node.ImageIndex = 1
        e.Node.SelectedImageIndex = 1
    End Sub

    Private Sub tvwProducts_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles tvwProduct.Click
        If cmbProductLevel.Text = "Control" Then
            OpenChildProductToolStripMenuItem1.Enabled = True
        ElseIf cmbProductLevel.Text = "Detail" Then
            OpenChildProductToolStripMenuItem1.Enabled = False
        Else
        End If
    End Sub

    Private Sub cmdDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDelete.Click
        Dim db As New dbOperations
        Dim dr As SqlDataReader
        If CheckAccess("DeleteRights", UserId, "PRODUCT MASTER FILE") = -1 Then
            Try
                If MsgBox("Do You Want To Delete This Product", vbYesNo) = MsgBoxResult.Yes Then
                    If cmbProductLevel.Text = "Control" Then
                        db.SetQuery = ("Select * from tblProductMaster Where GroupProduct = '" & txtProductCode.Text & "'  And ProductDigit > 1")
                        dr = db.dbSelectQuery

                        If dr.HasRows Then
                            dr.Close()
                            db.Close()

                            MsgBox("Cannot Delete Control Product which has Detail Product(s)")

                            Exit Sub
                        End If
                    End If

                    db.SetQuery = ("Delete From tblProductMaster Where ProductCode = '" & txtProductCode.Text & "'")
                    db.dbActionQuery()
                    tvwProduct.SelectedNode.Remove()

                    DeleteInfo(txtProductCode.Text, "Delete Record in PRODUCT MASTER FILE Product Name : " + "" + cmbProductName.Text)

                    Call ClearControls()
                    Call SetControls(Actions.Initial)
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MsgBox("Sorry You Dont Have Any Rights to Use This Option", vbInformation, cCompany)
            Exit Sub
        End If
    End Sub

    Private Sub cmdSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearch.Click
        txtProductCode.Text = ShowList("Select tblProductMaster.ProductCode,tblProductMaster.SourceCode,tblProductMaster.ProductName,tblProductMaster.UoM,GroupName.ProductName as ControlProduct,tblProductMaster.ProductLevel,Sum(tblProductOpening.Qty) as OpeningBalance From tblProductMaster as GroupName,tblProductMaster Left Outer Join tblProductOpening On tblProductOpening.ProductCode = tblProductMaster.ProductCode Where tblProductMaster.GroupProduct = GroupName.ProductCode Group By tblProductMaster.ProductCode,tblProductMaster.SourceCode,tblProductMaster.ProductName,tblProductMaster.UoM,GroupName.ProductName,tblProductMaster.ProductLevel Order by tblProductMaster.ProductCode", "List of Products", 1, 0, "").ToString

        If txtProductCode.Text = "" Or txtProductCode.Text = Nothing Then
            cmdSearch.Focus()
        Else
            Call DisplayRec()
        End If
    End Sub

    Private Sub cmbProductName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmbProductName.KeyPress
        If e.KeyChar = ChrW(Keys.Return) Then
            cmbProductLevel.Focus()
        End If
    End Sub

    Private Sub OpenChildProductToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenChildProductToolStripMenuItem1.Click
        If Not txtProductCode.Text = "" Then
            Call GetChildProduct(txtProductCode.Text)

            cmbProductName.Focus()
        Else
            MsgBox("Please Select First")
        End If
    End Sub

    Private Sub OpenProductAtSameLevelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OpenProductAtSameLevelToolStripMenuItem.Click
        If Not txtProductCode.Text = "" Then
            Call GetSibling(txtProductCode.Text)

            cmbProductName.Focus()
        Else
            MsgBox("Please Select First")
        End If
    End Sub

    Private Sub tdbGridOpening_AfterColUpdate(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridOpening.AfterColUpdate
        Call Totals()
    End Sub

    Private Sub tdbGridLocation_ButtonClick(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.ColEventArgs) Handles tdbGridOpening.ButtonClick
        If e.ColIndex = 0 Then
            If tdbGridOpening.RowCount > 0 Then
                tdbGridOpening.Delete()
            End If
        End If
    End Sub

    Sub Totals()
        Dim cTotalQty As Double

        For Each row As DataRow In dbGrid.cDataTableCollection(0).Select
            cTotalQty += Convert.ToDouble(RemoveNull(row("Qty"), 0))
        Next

        tdbGridOpening.Columns("Qty").FooterText = Format(cTotalQty, "###,###,##0.00")
    End Sub

    Private Sub cmdUoMList_Click(sender As Object, e As EventArgs) Handles cmdUoMList.Click
        cmbUoM.Text = ShowList("Select Name from tblUoM Order By Name", "List of UoM", 0, 0)
    End Sub
End Class
