Imports System.Data
Imports System.Data.SqlClient
Imports C1.Win
Imports C1.Win.C1TrueDBGrid
Imports C1.C1Preview
Imports System.Text

Public Class frmList
    Private CPD As New C1PrintDocument
    Private dv As DataView
    Public cSearchText As String
    Public ListTitle As String
    Public QueryStr As String
    Public GroupingSumColumns As String
    Public DefaultCol As Integer
    Public ConnectionString As String
    Public ValueReturnColumn1 As Integer
    Public MultiReturnColumn() As Integer
    Public MultiList As Boolean
    Public cGroupColumn As String
    Public cListType As String
    Public cDefaultGrouping As String
    Public cAutoRefresh As String
    Public cDecimal As String
    Public cQueryString As String

    Private Sub frmList_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Activated
        grdList.Focus()
        grdList.Col = DefaultCol
        grdList.FilterActive = True
    End Sub

    Private Sub frmList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = ListTitle
        Call FillGrid(QueryStr)
        Call SetupTheGrid()

        Dim i As Integer = 0

        If GroupingSumColumns <> "" Then
            Dim AllColumnsToFormat() As String = GroupingSumColumns.Split(",")

            If radioCollapseAll.Checked = True Then
                ' can't use for...next, doesn't re-evaluate the upper bound and the Rows collection does change as you expand/collapse
                While (i < grdList.Splits(0).Rows.Count)
                    If grdList.Splits(0).Rows(i).RowType <> C1.Win.C1TrueDBGrid.RowTypeEnum.DataRow Then
                        grdList.CollapseGroupRow(i)
                    End If
                    i = i + 1
                End While
            Else
            End If
        End If

        Dim cSno As String

        cSno = 1

        If cDefaultGrouping <> "" Then
            For Each n As String In cDefaultGrouping.Split(",".ToCharArray())
                grdList.GroupedColumns.Add(grdList.Columns(n))
            Next
        End If

        If cGroupColumn <> "" Then
            For Each n As String In cGroupColumn.Split(",".ToCharArray())
                If cSno = 1 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.BlanchedAlmond
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 2 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.MintCream
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 3 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.GhostWhite
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 4 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Snow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 5 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.NavajoWhite
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                End If

                If cSno = 6 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.LightYellow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 7 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Snow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 8 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Olive
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 9 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Olive
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 10 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.YellowGreen
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                cSno = cSno + 1
            Next
        End If

        If cDefaultGrouping <> "" Then
            grdList.Width = Me.Width - 50

            For Each dc As C1DisplayColumn In grdList.Splits(0).DisplayColumns
                'Width Formating
                dc.AutoSize()

                If dc.DataColumn.DataType.Name = "String" Then
                    If dc.Width < 150 Then
                        dc.Width = 150
                    End If
                Else
                    dc.Width = 75
                End If
            Next
        End If
        If cAutoRefresh = "Yes" Then
            Timer1.Start()
        End If
    End Sub
    Private Sub SetupTheGrid()
        Dim s As Integer = 0

        'Set Format of First Column if MultiList on the fly
        If MultiList Then
            grdList.Splits(0).DisplayColumns(0).HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            grdList.Splits(0).DisplayColumns(0).Style.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            'grdList.Splits(0).DisplayColumns(0).Style.VerticalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center
            grdList.Splits(0).DisplayColumns(0).Style.BackColor = Color.AliceBlue
            grdList.RecordSelectors = False
            grdList.Splits(0).DisplayColumns(0).Frozen = True
            grdList.Splits(0).DisplayColumns(0).DataColumn.Caption = ""
            grdList.Columns(0).ValueItems.Values.Add(New ValueItem(0, False))
            grdList.Columns(0).ValueItems.Values.Add(New ValueItem(1, True))
            grdList.Columns(0).ValueItems.Presentation = PresentationEnum.CheckBox
            grdList.Columns(0).ValueItems.Translate = True
            grdList.Columns(0).ValueItems.CycleOnClick = True
        End If
        
        For Each dc As C1DisplayColumn In grdList.Splits(0).DisplayColumns
            If dc.DataColumn.DataType.Name = "DateTime" Then
                dc.DataColumn.NumberFormat = "dd-MM-yyyy"
            End If

            If dc.DataColumn.DataType.Name = "Decimal" And cDecimal = "No" Then
                dc.DataColumn.NumberFormat = "###,###,##0.00"
            End If

            If dc.DataColumn.DataType.Name = "Decimal" And cDecimal = "Yes" Then
                dc.DataColumn.NumberFormat = "###,###,##0.00"
            End If

            If MultiList Then
                grdList.AllowUpdate = True
                grdList.AllowUpdateOnBlur = True
                If dc.DataColumn.DataField <> "_Sel" Then
                    dc.Locked = True
                End If
            End If

            'Width Formating
            If MultiList And dc.DataColumn.DataField = "_Sel" Then
                dc.Width = 18
            Else
                dc.AutoSize()
            End If
            If dc.Width > 200 Then
                dc.Width = 200
            End If
            s += dc.Width
        Next

        'Minimum and Maximum Column Widths
        If (s + 80) > 780 Then
            Me.Width = 780
            grdList.Width = 750
        ElseIf (s + 80) < 480 Then
            Me.Width = 480
            grdList.Width = 450
        Else
            Me.Width = s + 80
            grdList.Width = s + 50
        End If

        Call FormCenter(Me)
        If grdList.HScrollBar.Visible = True Then
            Try
                grdList.ScrollGrid(1, 0)
                grdList.ScrollGrid(-1, 0)
            Catch
            End Try
        End If

    End Sub

    Private Sub SelectText()
        If grdList.RowCount > 0 And MultiList = False Then
            If Not ValueReturnColumn1 <> -1 Then
                If Me.MultiReturnColumn.Length > 0 Then
                    For a As Integer = 0 To MultiReturnColumn.Length - 1
                        Dim val As Integer = MultiReturnColumn(a)
                        MultipleReturnValue += grdList.Columns(val).Text + "~@~"
                    Next
                End If
            Else
                SearchReturnValue1 = grdList.Columns(Me.ValueReturnColumn1).Text
            End If
            grdList.DataSource = Nothing
        ElseIf MultiList Then
            Dim data = dv.Table.AsEnumerable()
            Dim q = From d In data Where d.Field(Of String)("_Sel") = "1" Select d
            If q.Count > 0 Then
                MultiListDT = q.CopyToDataTable()
                MultiListDT.Columns.Remove("_Sel")
            End If
        End If
        Me.Close()
    End Sub
    Private Sub FillGrid(ByVal Sql As String)
        Dim ds As New DataSet
        Dim Connection As SqlConnection
        Dim command As SqlCommand
        'Dim da As New SqlDataAdapter(IIf(MultiList = True, "Select '0' as _Sel," + Mid(Sql, 7, Len(Sql) - 6), Sql), ConnectionString)

        Dim da As New SqlDataAdapter

        Try
            If MultiList = True Then
                da = New SqlDataAdapter("Select '0' as _Sel," + Mid(Sql, 7, Len(Sql) - 6), ConnectionString)

                grdList.DataSource = Nothing
                da.SelectCommand.CommandTimeout = 0
                da.Fill(ds, "Search")
                dv = New DataView(ds.Tables("Search"))
            Else
                Connection = New SqlConnection(ConnectionString)
                Connection.Open()

                command = New SqlCommand(Sql, Connection)
                command.CommandTimeout = 0
                da.SelectCommand = command

                grdList.DataSource = Nothing
                da.SelectCommand.CommandTimeout = 0
                da.Fill(ds, "Search")
                dv = New DataView(ds.Tables("Search"))

                Connection.Close()
            End If

            grdList.DataSource = dv
            grdList.HeadingStyle.HorizontalAlignment = C1.Win.C1TrueDBGrid.AlignHorzEnum.Center

            If GroupingSumColumns <> "" Then
                Dim AllColumnsToSum() As String = GroupingSumColumns.Split(",")
                If AllColumnsToSum.Length > 1 Then
                    For i As Integer = 0 To AllColumnsToSum.Length - 1
                        grdList.Columns(AllColumnsToSum(i)).Aggregate = AggregateEnum.Sum
                    Next

                Else
                    If AllColumnsToSum(0) <> "" Then
                        grdList.Columns(AllColumnsToSum(0)).Aggregate = AggregateEnum.Sum
                    End If
                End If

                Dim AllColumnsToFormat() As String = GroupingSumColumns.Split(",")
                If AllColumnsToFormat.Length > 1 Then
                    For i As Integer = 0 To AllColumnsToFormat.Length - 1
                        grdList.Columns(AllColumnsToFormat(i)).NumberFormat = "###,###,##0"
                    Next
                Else
                    If AllColumnsToFormat(0) <> "" Then
                        grdList.Columns(AllColumnsToFormat(0)).NumberFormat = "###,###,##0"
                    End If
                End If
            End If

            Call SetupTheGrid()
        Catch ex As Exception
            MsgBox(ex.Message.ToString)
        Finally
            da.Dispose()
        End Try
    End Sub

    Private Sub grdList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs)
        Call SelectText()
    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        grdList.DataSource = Nothing
        Me.Close()
    End Sub

    Private Sub cmdSelect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSelect.Click
        Call SelectText()
    End Sub

    Private Sub grdList_DoubleClick1(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdList.DoubleClick
        If cListType = "List" Then
            If MultiList Then
                grdList.Columns(0).Value = IIf(grdList.Columns(0).Value = 0, 1, 0)
            Else
                Call SelectText()
            End If
        End If
    End Sub

    Private Sub grdList_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles grdList.KeyUp
        If e.KeyCode = 13 Then
            Call SelectText()
        End If
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        grdList.GroupByCaption = ListTitle
        'frmMain.Cursor = Cursors.WaitCursor
        CPD.Body.Children.Add(New RenderC1Printable(grdList))
        CPD.Generate()
        frmMain.Cursor = Cursors.Default
    End Sub
    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        Dim frmPrint As New FrmC1Preview
        frmPrint.CPPC.Document = CPD
        frmPrint.MdiParent = frmMain
        frmPrint.Show()
    End Sub
    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        CPD.Clear()
    End Sub

    Private Sub grdList_FilterChange(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdList.FilterChange
        Dim sb As New StringBuilder()
        For Each dc As C1DataColumn In grdList.Columns
            If dc.FilterText.Length > 0 Then
                If dc.DataType.Name = "String" Then
                    If sb.Length > 0 Then sb.Append(" AND ")
                    sb.Append("[" + dc.DataField + "] like " + "'*" + dc.FilterText + "*'")
                ElseIf dc.DataType.Name = "DateTime" And Len(dc.FilterText) = 10 And IsDate(dc.FilterText) Then
                    If sb.Length > 0 Then sb.Append(" AND ")
                    sb.Append("[" + dc.DataField + "] = " + "#" + String.Format(dc.FilterText, "MM/dd/yyyy") + "#")
                ElseIf dc.DataType.Name = "Decimal" And IsNumeric(dc.FilterText) Then
                    If sb.Length > 0 Then sb.Append(" AND ")
                    sb.Append("[" + dc.DataField + "] = " + "" + dc.FilterText + "")
                End If
            End If
        Next
        Try : dv.RowFilter = sb.ToString() : Catch : End Try
    End Sub

    Private Sub ToolStrip1_ItemClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ToolStripItemClickedEventArgs) Handles ToolStrip1.ItemClicked

    End Sub

    Private Sub radioCollapseAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioCollapseAll.CheckedChanged
        If radioCollapseAll.Checked = True Then
            Dim i As Integer = 0
            ' can't use for...next, doesn't re-evaluate the upper bound and the Rows collection does change as you expand/collapse
            While (i < grdList.Splits(0).Rows.Count)
                If grdList.Splits(0).Rows(i).RowType <> C1.Win.C1TrueDBGrid.RowTypeEnum.DataRow Then
                    grdList.CollapseGroupRow(i)
                End If
                i = i + 1
            End While
        End If
    End Sub

    Private Sub radioExpandAll_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radioExpandAll.CheckedChanged

        Dim i As Integer = 0
        Me.grdList.ExpandGroupRow(i)

        ' can't use for...next, doesn't re-evaluate the upper bound and the Rows collection does change as you expand/collapse
        While (i < Me.grdList.Splits(0).Rows.Count)
            If Me.grdList.Splits(0).Rows(i).RowType <> C1.Win.C1TrueDBGrid.RowTypeEnum.DataRow Then
                Me.grdList.ExpandGroupRow(i)
            End If
            i = i + 1
        End While

    End Sub

    Private Sub grdList_GroupColMove(ByVal sender As Object, ByVal e As C1.Win.C1TrueDBGrid.GroupColMoveEventArgs) Handles grdList.GroupColMove
        Dim j As Integer = 0

        'If e.Position = 0 Then
        If cGroupColumn = "" Then
            If grdList.GroupedColumns.Count = 0 Then
                While (j < grdList.Splits(0).DisplayColumns.Count)
                    If grdList.Splits(0).DisplayColumns(j).GroupHeaderStyle.BackColor <> Color.White Then
                        grdList.Splits(0).DisplayColumns(j).GroupHeaderStyle.BackColor = Color.BlanchedAlmond
                        grdList.Splits(0).DisplayColumns(j).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                    End If

                    j += 1
                End While
            End If
        End If

        For Each dc As C1DisplayColumn In grdList.Splits(0).DisplayColumns
            'Width Formating
            dc.AutoSize()

            If dc.DataColumn.DataType.Name = "String" Then
                If dc.Width < 150 Then
                    dc.Width = 150
                End If
            Else
                dc.Width = 75
            End If
        Next
    End Sub


    Private Sub frmList_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.SizeChanged
        grdList.Height = Me.Height - 100
        grdList.Width = Me.Width - 50
    End Sub

    Private Sub grdList_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles grdList.Click

    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        'grdList.ExportToExcel("D:\ExcelTransfer.xls")

        Call ExportCSV(cQueryString)
    End Sub

    Private Sub ToolStripButton5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton5.Click
        Me.grdList.ExportToPDF("C:\Stock.PDF")
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Text = ListTitle
        Call FillGrid(QueryStr)
        Call SetupTheGrid()

        Dim i As Integer = 0

        If GroupingSumColumns <> "" Then
            Dim AllColumnsToFormat() As String = GroupingSumColumns.Split(",")

            If radioCollapseAll.Checked = True Then
                ' can't use for...next, doesn't re-evaluate the upper bound and the Rows collection does change as you expand/collapse
                While (i < grdList.Splits(0).Rows.Count)
                    If grdList.Splits(0).Rows(i).RowType <> C1.Win.C1TrueDBGrid.RowTypeEnum.DataRow Then
                        grdList.CollapseGroupRow(i)
                    End If
                    i = i + 1
                End While
            Else
            End If
        End If


        Dim cSno As String

        cSno = 1

        If cDefaultGrouping <> "" Then
            For Each n As String In cDefaultGrouping.Split(",".ToCharArray())
                grdList.GroupedColumns.Add(grdList.Columns(n))
            Next
        End If

        If cGroupColumn <> "" Then
            For Each n As String In cGroupColumn.Split(",".ToCharArray())
                If cSno = 1 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.BlanchedAlmond
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 2 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.MintCream
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 3 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.GhostWhite
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 4 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Snow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 5 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.NavajoWhite
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                End If

                If cSno = 6 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.LightYellow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 7 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Snow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 8 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Olive
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 9 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Olive
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 10 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.YellowGreen
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                cSno = cSno + 1
            Next
        End If

        If cDefaultGrouping <> "" Then
            grdList.Width = Me.Width - 50

            For Each dc As C1DisplayColumn In grdList.Splits(0).DisplayColumns
                'Width Formating
                dc.AutoSize()

                If dc.DataColumn.DataType.Name = "String" Then
                    If dc.Width < 150 Then
                        dc.Width = 150
                    End If
                Else
                    dc.Width = 75
                End If
            Next
        End If
    End Sub

    Private Sub cmdRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRefresh.Click
        Me.Text = ListTitle
        Call FillGrid(QueryStr)
        Call SetupTheGrid()

        Dim i As Integer = 0

        If GroupingSumColumns <> "" Then
            Dim AllColumnsToFormat() As String = GroupingSumColumns.Split(",")

            If radioCollapseAll.Checked = True Then
                ' can't use for...next, doesn't re-evaluate the upper bound and the Rows collection does change as you expand/collapse
                While (i < grdList.Splits(0).Rows.Count)
                    If grdList.Splits(0).Rows(i).RowType <> C1.Win.C1TrueDBGrid.RowTypeEnum.DataRow Then
                        grdList.CollapseGroupRow(i)
                    End If
                    i = i + 1
                End While
            Else
            End If
        End If


        Dim cSno As String

        cSno = 1

        If cDefaultGrouping <> "" Then
            For Each n As String In cDefaultGrouping.Split(",".ToCharArray())
                grdList.GroupedColumns.Add(grdList.Columns(n))
            Next
        End If

        If cGroupColumn <> "" Then
            For Each n As String In cGroupColumn.Split(",".ToCharArray())
                If cSno = 1 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.BlanchedAlmond
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 2 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.MintCream
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 3 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.GhostWhite
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 4 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Snow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 5 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.NavajoWhite
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)
                End If

                If cSno = 6 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.LightYellow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 7 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Snow
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 8 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Olive
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 9 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.Olive
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                If cSno = 10 Then
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.BackColor = Color.YellowGreen
                    grdList.Splits(0).DisplayColumns(n).GroupHeaderStyle.Font = New Font("Tahoma", 10, FontStyle.Bold)

                    grdList.Splits(0).DisplayColumns(n).Frozen = True
                End If

                cSno = cSno + 1
            Next
        End If

        If cDefaultGrouping <> "" Then
            grdList.Width = Me.Width - 50

            For Each dc As C1DisplayColumn In grdList.Splits(0).DisplayColumns
                'Width Formating
                dc.AutoSize()

                If dc.DataColumn.DataType.Name = "String" Then
                    If dc.Width < 150 Then
                        dc.Width = 150
                    End If
                Else
                    dc.Width = 75
                End If
            Next
        End If
    End Sub
End Class
