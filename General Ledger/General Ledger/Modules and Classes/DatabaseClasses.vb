Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration
Imports System.Data.Common
Imports System.Collections
Imports System.Text
Imports C1.Win.C1TrueDBGrid
Module DatabaseClasses

    Public Class dbOperations
        Private Sql As String
        Private cn As SqlConnection = New SqlConnection(DefaultConString)
        Private Transaction As SqlTransaction

        Public WriteOnly Property SetQuery()
            Set(ByVal value)
                Me.Sql = value
            End Set
        End Property

        Public Sub New(ByVal Sql As String, Optional ByVal ConString As String = Nothing)
            If ConString <> Nothing Then
                cn.Close()
                cn = New SqlConnection(ConString)
            End If

            Me.Sql = Sql
        End Sub

        Public Sub New(ByVal Sql As String, ByRef dr As SqlDataReader, Optional ByVal ConString As String = Nothing)
            If ConString <> Nothing Then
                cn.Close()
                cn = New SqlConnection(ConString)
            End If

            Me.Sql = Sql
            dr = dbSelectQuery()
        End Sub

        Public Sub New(ByVal Sql As String, ByRef ds As DataSet, ByVal TableName As String, Optional ByVal ConString As String = Nothing)
            If ConString <> Nothing Then
                cn.Close()
                cn = New SqlConnection(ConString)
            End If

            Me.Sql = Sql
            FillDataSet(ds, TableName)
        End Sub

        Public Sub New()
            Me.Sql = ""
        End Sub

        Public Function dbSelectQuery() As SqlDataReader
            cn.Close()
            cn.Open()
            Dim cmd As New SqlCommand(Me.Sql, cn)
            cmd.CommandTimeout = 0

            Return cmd.ExecuteReader()
        End Function

        Public Sub dbActionQuery(Optional ByVal Constring As String = Nothing)
            cn.Close()

            If Constring <> Nothing Then
                cn = New SqlConnection(Constring)
            End If

            cn.Open()
            'Transaction = cn.BeginTransaction("SampleTransaction")
            Dim cmd As New SqlCommand(Me.Sql, cn)
            cmd.Transaction = Transaction

            cmd.ExecuteNonQuery()
            'Transaction.Commit()
            cn.Close()
        End Sub

        Public Sub FillDataSet(ByRef ds As DataSet, ByVal TableName As String)
            Dim da As New SqlDataAdapter(Sql, DefaultConString)
            da.Fill(ds, TableName)
            da.Dispose()
        End Sub

        Public Sub Close()
            cn.Close()
        End Sub
    End Class

    Public Class ActionQueryBuilder

        Private Fields As New Hashtable
        Private DType As New Hashtable
        Private Criteria As String
        Private Table As String
        Private InsertQuery As New StringBuilder
        Private UpdateQuery As New StringBuilder
        Private DeleteQuery As New StringBuilder

        Friend Enum Actions As Byte
            Insert = 0
            Update = 1
            Delete = 2
        End Enum

        Friend Enum DataType As Byte
            aString = 0
            aDate = 1
            aInteger = 2
            aDecimal = 3
            aDateTime = 4
            aParameter = 5
        End Enum

        Public Sub AddFields(ByVal Field As String, ByVal Values As Object, ByVal Type As DataType)
            Fields(Field) = Values
            DType(Field) = Type
        End Sub

        Public Sub SetQueryInformation(ByVal Table As String, ByVal Criteria As String)
            Me.Criteria = Criteria
            Me.Table = Table
        End Sub

        Public Sub SetQueryInformation(ByVal Table As String)
            Me.Table = Table
        End Sub

        Public Sub Refresh()
            Me.Fields.Clear()
            Me.DType.Clear()
            Me.Criteria = Nothing
            Me.Table = Nothing
            Me.InsertQuery.Remove(0, InsertQuery.Length)
            Me.UpdateQuery.Remove(0, UpdateQuery.Length)
            Me.DeleteQuery.Remove(0, DeleteQuery.Length)
        End Sub

        Public Sub ExecuteQuery(ByVal Action As Actions, Optional ByVal Constring As String = Nothing)
            Dim cn As String

            If Constring = Nothing Then
                cn = DefaultConString
            Else
                cn = Constring
            End If

            Dim db As New dbOperations()
            If Action = Actions.Insert Then
                db.SetQuery = Me.GetInsertQuery
                db.dbActionQuery(cn)
            ElseIf Action = Actions.Update Then
                db.SetQuery = Me.GetUpdateQuery
                db.dbActionQuery(cn)
            ElseIf Action = Actions.Delete Then
                db.SetQuery = Me.GetDeleteQuery
                db.dbActionQuery(cn)
            End If
        End Sub

        Public ReadOnly Property GetInsertQuery() As String
            Get
                If Fields.Count > 0 And Not Table = Nothing Then
                    Me.GenerateInsertQuery()
                    Return InsertQuery.ToString
                Else
                    Throw New InvalidOperationException("Please First Set Table Name and Fields.")
                End If
            End Get
        End Property

        Public ReadOnly Property GetUpdateQuery() As String
            Get
                If Me.Fields.Count > 0 And Not Me.Table = Nothing And Not Me.Criteria = Nothing Then
                    Me.GenerateUpdateQuery()
                    Return UpdateQuery.ToString
                Else
                    Throw New InvalidOperationException("Please First Set Table Name, Fields and Criteria.")
                End If
            End Get
        End Property

        Public ReadOnly Property GetDeleteQuery() As String
            Get
                If Not Me.Table = Nothing And Not Me.Criteria = Nothing Then
                    Me.GenerateDeleteQuery()
                    Return DeleteQuery.ToString
                Else
                    Throw New InvalidOperationException("Please First Set Table Name and Criteria.")
                End If
            End Get
        End Property

        Private Sub GenerateInsertQuery()
            With InsertQuery
                .Remove(0, .Length)
                .Append("INSERT INTO " + Table + " (")
                For Each Element As DictionaryEntry In Fields
                    .Append(CStr(Element.Key) + ", ")
                Next
                .Remove(.Length - 2, 2)
                .Append(") VALUES (")
                For Each Element As DictionaryEntry In Fields
                    If CByte(DType(Element.Key)) = DataType.aParameter Then 'CStr(Element.Value).StartsWith("@") = True Then
                        .Append(CStr(Element.Value) + ", ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aDateTime Then ' IsDate(Element.Value) Then
                        Dim dt As Date = Element.Value
                        .Append("'" & Format(dt, "MM/dd/yyyy hh:mm:ss") & "', ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aDate Then
                        Dim dt As Date = Element.Value
                        .Append("'" & Format(dt, "MM/dd/yyyy") & "', ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aInteger Then 'IsNumeric(CStr(Element.Value)) Then
                        .Append(CStr(Convert.ToInt64(Element.Value)) + ", ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aDecimal Then
                        .Append(CStr(Convert.ToDecimal(Element.Value)) + ", ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aString Then
                        .Append("'" + CStr(Element.Value) + "', ")
                    End If
                Next
                .Remove(.Length - 2, 2)
                .Append(")")
                Dim temp As String = .ToString
            End With
        End Sub

        Private Sub GenerateUpdateQuery()
            With UpdateQuery
                .Remove(0, .Length)
                .Append("UPDATE " + Me.Table + " SET ")
                For Each Element As DictionaryEntry In Fields
                    .Append(Element.Key.ToString + " = ")

                    If CByte(DType(Element.Key)) = DataType.aParameter Then 'CStr(Element.Value).StartsWith("@") = True Then
                        .Append(CStr(Element.Value) + ", ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aDateTime Then ' IsDate(Element.Value) Then
                        Dim dt As Date = Element.Value
                        .Append("'" & Format(dt, "MM/dd/yyyy hh:mm:ss") & "', ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aDate Then ' IsDate(Element.Value) Then
                        Dim dt As Date = Element.Value
                        .Append("'" & Format(dt, "MM/dd/yyyy") & "', ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aInteger Then 'IsNumeric(CStr(Element.Value)) Then
                        .Append(CStr(Convert.ToInt64(Element.Value)) + ", ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aDecimal Then
                        .Append(CStr(Convert.ToDecimal(Element.Value)) + ", ")
                    ElseIf CByte(DType(Element.Key)) = DataType.aString Then
                        .Append("'" + CStr(Element.Value) + "', ")
                    End If
                Next
                .Remove(.Length - 2, 2)
                .Append(" WHERE " + Me.Criteria)

            End With
        End Sub

        Private Sub GenerateDeleteQuery()
            With DeleteQuery
                .Remove(0, .Length)
                .Append("DELETE FROM " + Me.Table + " WHERE " + Me.Criteria)
            End With
        End Sub
    End Class

    Public Class BindGrid
        Public ds As New DataSet
        Private da As SqlDataAdapter
        Private KeyCol As New Hashtable
        Private Criteria As String
        Private Query As New ActionQueryBuilder
        Public cDataTableCollection As DataTableCollection = ds.Tables
        Public cDataTable As DataTable
        Public cDataView As DataView
        Public Sub SetPrimaryKey(ByVal ParamArray FieldName() As String)
            Dim Pk(FieldName.Length - 1) As DataColumn
            For i As Integer = 0 To (FieldName.Length - 1)
                Pk(i) = ds.Tables(cDataTable.TableName).Columns(FieldName(i))
            Next
            ds.Tables(cDataTable.TableName).PrimaryKey = Pk
        End Sub
        Public Sub AddKeyCol(ByVal ColumnName As String, ByVal Values As String)
            KeyCol(ColumnName) = Values
        End Sub
        Public Sub New(ByVal Sql As String, Optional ByRef Grid1 As C1TrueDBGrid = Nothing, Optional ByRef Grid2 As C1TrueDBGrid = Nothing, Optional ByRef Grid3 As C1TrueDBGrid = Nothing, Optional ByRef Grid4 As C1TrueDBGrid = Nothing) ' For None or More than One DataGrid)
            da = New SqlDataAdapter(Sql, DefaultConString)
            Dim s1() As String = Strings.Split(UCase(Sql), "FROM", 5)
            Dim s2() As String = Strings.Split(s1(1), " ", s1(1).Length)
            Dim s3() As String = Strings.Split(UCase(Sql), "WHERE ", 5)
            If s3.Length > 1 Then
                Dim s4() As String = Strings.Split(s3(1), "ORDER BY ", s2(1).Length)
                Criteria = s4(0).ToString
            End If

            da.Fill(ds, s2(1).ToString)
            cDataView = New DataView()
            cDataView.Table = ds.Tables(s2(1).ToString)
            If Not Grid1 Is Nothing Then
                Grid1.SetDataBinding(ds, s2(1).ToString, True)
            End If
            If Not Grid2 Is Nothing Then
                Grid2.SetDataBinding(ds, s2(1).ToString, True)
            End If
            If Not Grid3 Is Nothing Then
                Grid3.SetDataBinding(ds, s2(1).ToString, True)
            End If
            If Not Grid4 Is Nothing Then
                Grid4.SetDataBinding(ds, s2(1).ToString, True)
            End If
            cDataTable = ds.Tables(s2(1).ToString)

            'da.Fill(ds, s2(1).ToString)
            'cDataView = New DataView()
            'cDataView.Table = ds.Tables(s2(1).ToString)
            ''Grid.SetDataBinding(ds, s2(1).ToString, True)
            'cDataTable = ds.Tables(s2(1).ToString)

        End Sub
        Public Sub New(ByRef Grid As C1TrueDBGrid, ByVal Sql As String, Optional ByVal ConString As String = Nothing)
            Dim cn As String

            If ConString = Nothing Then
                cn = DefaultConString
            Else
                cn = ConString
            End If

            da = New SqlDataAdapter(Sql, cn)
            Dim s1() As String = Strings.Split(UCase(Sql), "FROM", 5)
            Dim s2() As String = Strings.Split(s1(1), " ", s1(1).Length)
            Dim s3() As String = Strings.Split(UCase(Sql), "WHERE ", 5)
            If s3.Length > 1 Then
                Dim s4() As String = Strings.Split(s3(1), "ORDER BY ", s2(1).Length)
                Criteria = s4(0).ToString
            End If
            da.Fill(ds, s2(1).ToString)
            cDataView = New DataView()
            cDataView.Table = ds.Tables(s2(1).ToString)
            'Grid.SetDataBinding(ds, s2(1).ToString, True)
            Grid.SetDataBinding(cDataView, Nothing, True)
            cDataTable = ds.Tables(s2(1).ToString)
        End Sub

        Public Property SetCriteria() As String
            Get
                Return Criteria
            End Get
            Set(ByVal value As String)
                Criteria = value
            End Set
        End Property

        Public Sub Delete()
            Query.SetQueryInformation(cDataTable.TableName, Me.Criteria)
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete)
        End Sub

        Public Sub RefreshKeyColumns()
            KeyCol.Clear()
        End Sub

        Public Sub Update(Optional ByVal Constring As String = "")

            If KeyCol.Count < 1 Then
                MsgBox("Please First Set Key Column")
                Exit Sub
            End If

            If Criteria = Nothing Or Criteria = "" Then
                MsgBox("Select Query must be with selection criteria")
                Exit Sub
            End If

            For Each Element As DictionaryEntry In KeyCol
                For Each row As DataRow In cDataTableCollection(cDataTable.TableName).Select
                    row(CStr(Element.Key)) = CStr(Element.Value)
                Next
            Next

            'Dim UpdateCmd As SqlCommand
            Dim InsertCmd As SqlCommand
            Dim DeleteCmd As SqlCommand
            Dim cn As New SqlConnection(IIf(Constring = "", DefaultConString, Constring))

            Query.SetQueryInformation(cDataTable.TableName, Me.Criteria)

            'Add Field for Generate Query
            For Each Col As DataColumn In cDataTableCollection(0).Columns
                Query.AddFields(Col.ColumnName, "@" + Col.ColumnName, ActionQueryBuilder.DataType.aParameter)
            Next

            Dim Ins As String = Query.GetInsertQuery
            InsertCmd = New SqlCommand(Ins, cn)

            'Add Parameters
            For Each Col As DataColumn In cDataTableCollection(0).Columns

                Dim dt As String = Col.DataType.Name

                If dt = "DateTime" Then
                    InsertCmd.Parameters.Add("@" + Col.ColumnName, SqlDbType.DateTime, 50, Col.ColumnName)
                ElseIf Strings.Left(dt, 3) = "Int" Then
                    InsertCmd.Parameters.Add("@" + Col.ColumnName, SqlDbType.BigInt, 50, Col.ColumnName)
                ElseIf dt = "Decimal" Then
                    InsertCmd.Parameters.Add("@" + Col.ColumnName, SqlDbType.Decimal, 50, Col.ColumnName)
                ElseIf dt = "String" Then
                    InsertCmd.Parameters.Add("@" + Col.ColumnName, SqlDbType.VarChar, 500, Col.ColumnName)
                Else
                    Throw New InvalidOperationException("Please Set Type for" + " : " + dt)
                End If

            Next

            ' Delete cmd is just for formality
            DeleteCmd = New SqlCommand("Select * FROM " & cDataTable.TableName, cn)
            da.InsertCommand = InsertCmd
            da.UpdateCommand = InsertCmd
            da.DeleteCommand = DeleteCmd

            ' Delete all Record from detail table
            Query.ExecuteQuery(ActionQueryBuilder.Actions.Delete, Constring)

            ' Insert all updated Record to Detail Table 
            da.Update(ds.Tables(cDataTable.TableName))
            da.Dispose()
        End Sub
    End Class

    Public Class BindCombo
        Public Sub New(ByRef Combo As C1TrueDBDropdown, ByVal cSql As String, ByVal DisplayMember As String, ByVal ValueMember As String, ByVal AutoDraw As Boolean, Optional ByVal ConString As String = Nothing)
            Dim ds As New DataSet
            Dim conStr As String
            If ConString = Nothing Then
                conStr = DefaultConString
            Else
                conStr = ConString
            End If
            Dim da As New SqlDataAdapter(cSql, conStr)
            da.Fill(ds, "cTable")
            Combo.SetDataBinding(ds, "cTable", IIf(AutoDraw, False, True))
            Combo.DisplayMember = ds.Tables("cTable").Columns(DisplayMember).ToString
            Combo.ValueMember = ds.Tables("cTable").Columns(ValueMember).ToString
            Combo.ValueTranslate = True
            If AutoDraw = True Then
                For Each Col As C1DisplayColumn In Combo.DisplayColumns
                    Col.AutoSize()
                    If Col.Width > 280 Then
                        Col.Width = 280
                    End If
                Next
            End If
            da.Dispose()
        End Sub

        Public Sub New(ByRef Combo As C1.Win.C1List.C1Combo, ByVal cSql As String, ByVal DisplayMember As String, ByVal ValueMember As String, ByVal AutoCompletion As Boolean, ByVal AutoDropDown As Boolean, Optional ByVal ConString As String = Nothing)
            Dim ds As New DataSet
            Dim conStr As String

            If ConString = Nothing Then
                conStr = DefaultConString
            Else
                conStr = ConString
            End If

            Dim da As New SqlDataAdapter(cSql, conStr)
            da.Fill(ds, "cTable")
            Combo.DataMode = C1.Win.C1List.DataModeEnum.Normal
            Combo.DataSource = ds
            Combo.DataMember = "cTable"
            Combo.DisplayMember = ds.Tables("cTable").Columns(DisplayMember).ToString
            Combo.ValueMember = ds.Tables("cTable").Columns(ValueMember).ToString
            Combo.AutoCompletion = AutoCompletion
            Combo.AutoDropDown = AutoDropDown
            For cCol As Integer = 0 To Combo.Splits(0).DisplayColumns.Count - 1
                Combo.Splits(0).DisplayColumns(cCol).AutoSize()
                If Combo.Splits(0).DisplayColumns(cCol).Width > 280 Then
                    Combo.Splits(0).DisplayColumns(cCol).Width = 280
                End If
            Next
            da.Dispose()
        End Sub

        Public Sub New(ByRef Combo As C1.Win.C1List.C1Combo, ByVal cSql As String, ByVal DisplayMember As String, ByVal ValueMember As String, ByVal AutoCompletion As Boolean, ByVal AutoDropDown As Boolean, ByVal ConString As String, ByVal ParamArray Width() As Integer)
            Dim ds As New DataSet
            Dim da As New SqlDataAdapter(cSql, ConString)
            da.Fill(ds, "cTable")
            Combo.DataMode = C1.Win.C1List.DataModeEnum.Normal
            Combo.DataSource = ds
            Combo.DataMember = "cTable"
            Combo.DisplayMember = ds.Tables("cTable").Columns(DisplayMember).ToString
            Combo.ValueMember = ds.Tables("cTable").Columns(ValueMember).ToString
            Combo.AutoCompletion = AutoCompletion
            Combo.AutoDropDown = AutoDropDown
            For cCol As Integer = 0 To Combo.Splits(0).DisplayColumns.Count - 1
                If Not Width.Length < 1 Then
                    Combo.Splits(0).DisplayColumns(cCol).Width = Width(cCol)
                Else
                    Combo.Splits(0).DisplayColumns(cCol).AutoSize()
                    If Combo.Splits(0).DisplayColumns(cCol).Width > 280 Then
                        Combo.Splits(0).DisplayColumns(cCol).Width = 280
                    End If
                End If
            Next
            da.Dispose()
        End Sub
    End Class

    Public Class DataRowEqualityComparer
        Implements System.Collections.Generic.IEqualityComparer(Of DataRow)
        Private MyColList As ArrayList

        Sub New()
            MyColList = New ArrayList
        End Sub

        Sub New(ByVal ColumnName As String)
            MyColList = New ArrayList
            MyColList.Add(ColumnName)
        End Sub

        Public Sub AddFields(ByVal ColumnName As String)
            MyColList.Add(ColumnName)
        End Sub

        Public Sub Refresh()
            MyColList.Clear()
        End Sub

        Public Function Equals1(ByVal x As System.Data.DataRow, ByVal y As System.Data.DataRow) As Boolean Implements System.Collections.Generic.IEqualityComparer(Of System.Data.DataRow).Equals
            For Each i As String In MyColList
                If Not x(i) = y(i) Then
                    Return False
                End If
            Next
            Return True
        End Function

        Public Function GetHashCode1(ByVal obj As System.Data.DataRow) As Integer Implements System.Collections.Generic.IEqualityComparer(Of System.Data.DataRow).GetHashCode
            Dim HashCode As Integer = 0
            For Each i As String In MyColList
                HashCode = HashCode Xor obj(i).GetHashCode
            Next
            Return HashCode
        End Function
    End Class
    Public Class sound
        Declare Auto Sub PlaySound Lib "winmm.dll" (ByVal pszSound As String, ByVal hmod As IntPtr, ByVal fdwSound As UInt32)

        'SND_SYNC          = 0x0000,  

        ' SND_ASYNC         = 0x0001, 

        ' SND_NODEFAULT     = 0x0002, 

        ' SND_MEMORY        = 0x0004,  

        ' SND_LOOP          = 0x0008,  

        ' SND_NOSTOP        = 0x0010, 

        ' SND_NOWAIT    = 0x00002000, 

        ' SND_ALIAS     = 0x00010000, 

        ' SND_ALIAS_ID  = 0x00110000, 

        ' SND_FILENAME  = 0x00020000, 

        ' SND_RESOURCE  = 0x00040004  

    End Class
End Module
