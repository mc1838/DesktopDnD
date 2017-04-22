Module modConnect
    'NOTE: Fall 2012 - 2013 in School Backup for more stuff...
    'Need to figure out how to get data from DataTable/DataSet to textbox!

    'Public cstring As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\visualbasiccourse\Books.mdb" 'the connection string.
    'Public strConnect As String = "Driver={ODBC Driver 13 for SQL Server};Server=tcp:csc450.database.windows.net,1433;Database=testdb;Uid=mc1838@csc450;Pwd=Project450;Encrypt=yes;TrustServerCertificate=no;Connection Timeout=30;"
    Public strConnect As String = "Data Source=csc450.database.windows.net;Initial Catalog=testdb;Persist Security Info=True;User ID=mc1838;Password=Project450"
    'Public Function SQLSelect(ByVal SQLqry As String) As DataTable
    Public Function SQLSelect(ByVal SQLqry As String) As DataSet
        'Dim strConnect As String = cstring
        Dim commandText As String = ""
        Dim adapter As New SqlClient.SqlDataAdapter
        Dim table As New DataTable
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim ds As New DataSet 'NEW
        commandText = SQLqry
        connection.ConnectionString = strConnect

        Try
            connection.Open()
            command.Connection = connection
            command.CommandText = commandText
            adapter.SelectCommand() = command
            adapter.Fill(table)
            adapter.Fill(ds) 'NEW
            connection.Close()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return ds 'NEW
        'Return table
    End Function

    Public Function SQLExecute(ByVal SQLExecStatement As String) As Integer
        Dim returnValue As Integer = 0
        'Dim strConnect As String = cstring
        Dim commandText As String = SQLExecStatement
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        command.CommandTimeout = 180
        connection.ConnectionString = strConnect
        connection.Open()
        command.Connection = connection
        command.CommandText = commandText
        returnValue = command.ExecuteNonQuery()
        connection.Close()
        Return returnValue
    End Function

    ''Below is the String that goes to Report Box, to be printed at end.
    'Public txtReport As String = "" 'initialize here and format later...

    ''Function by Dr. James G Williams --
    'Public Function AccessSelect(ByVal AccessQry As String) As DataTable
    '    Dim strConnect As String = cstring 'uses my cstring for ConnectionString
    '    Dim commandText As String = AccessQry 'is passed commandText!
    '    Dim adapter As New OleDb.OleDbDataAdapter
    '    Dim table As New DataTable 'to be returned at end
    '    Dim connection As New OleDb.OleDbConnection
    '    Dim command As New OleDb.OleDbCommand
    '    connection.ConnectionString = strConnect
    '    connection.Open()
    '    command.Connection = connection
    '    command.CommandText = commandText
    '    adapter.SelectCommand() = command
    '    adapter.Fill(table)
    '    connection.Close()
    '    Return table 'data table is returned!
    'End Function
End Module
