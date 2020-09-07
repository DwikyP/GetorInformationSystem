Imports Microsoft.VisualBasic
Imports System.Data.Sql
Imports System.Data.SqlClient

Public Class SQLControl
    Public SQLCon As New SqlConnection With {.ConnectionString = "Server=BTG-ANDARIAS15;Database=getor;User=sa;Pwd=password"}
    'Public SQLCon As New SqlConnection With {.ConnectionString = "Server=DESKTOP-4M8J5D5;Database=getor;User=sa;Pwd=password"}
    Public SQLCmd As SqlCommand
    Public SQLDA As SqlDataAdapter
    Public SQLDataset As DataSet
    Public SQLDataTable As DataTable

    Public Params As New List(Of SqlParameter)

    Public RecordCount As Integer
    Public Exception As String

    Public Function HasConnection() As Boolean
        Try
            SQLCon.Open()

            SQLCon.Close()
            Return True
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
    End Function

    Public Sub ExecQuery(Query As String)
        ' RESET QUERY STATS
        RecordCount = 0
        Exception = ""

        Try
            SQLCon.Open()

            ' CREATE DB COMMAND
            SQLCmd = New SqlCommand(Query, SQLCon)

            ' LOAD PARAMS INTO DB COMMAND
            Params.ForEach(Sub(p) SQLCmd.Parameters.Add(p))

            ' CLEAR PARAM LIST
            Params.Clear()

            ' EXECUTE COMMAND AND FILL DATASET
            SQLDataset = New DataSet
            SQLDA = New SqlDataAdapter(SQLCmd)
            RecordCount = SQLDA.Fill(SQLDataset)
        Catch ex As Exception
            ' CAPTURE ERRORS
            Exception = "ExecQuery Error: " & vbNewLine & ex.Message
        Finally
            ' CLOSE CONNECTION
            If SQLCon.State = ConnectionState.Open Then SQLCon.Close()
        End Try
    End Sub

    ' ADD PARAM SUB
    Public Sub AddParam(Name As String, Value As Object)
        Dim NewParam As New SqlParameter(Name, Value)
        Params.Add(NewParam)
    End Sub

    ' ERROR CHECKING
    Public Function HasException(Optional Report As Boolean = False) As Boolean
        If String.IsNullOrEmpty(Exception) Then Return False
        If Report = True Then MsgBox(Exception, MsgBoxStyle.Critical, "Exception:")
        Return True
    End Function
End Class
