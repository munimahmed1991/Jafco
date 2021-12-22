Public Class Anonymous
    Public Function GetProjectWiseTotalAmount(ByVal cTable As System.Data.DataTable) As ArrayList
        Dim gTot = From p In cTable.AsEnumerable _
                             Group p By Key = p.Field(Of String)("Project") Into Group _
                             Select Project = Key, _
                            drAmt = Group.Sum(Function(p) p("drAmount")), crAmt = Group.Sum(Function(p) p("crAmount"))
        Dim arr As New ArrayList
        For Each g In gTot

            arr.Add(New PAmount() With {.Project = g.Project, .drAmount = g.drAmt, .crAmount = g.crAmt})
        Next
        Return arr
    End Function
End Class
Public Class PAmount
    Public Project As String
    Public drAmount As Double
    Public crAmount As Double
End Class