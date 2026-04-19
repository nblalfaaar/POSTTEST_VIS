Imports MySqlConnector

Module ConnectionModule

    Public ReadOnly ConnectionString As String =
        "Server=localhost;Port=3306;Database=dbplaylist;User ID=root;Password=;"

    Public Function GetConnection() As MySqlConnection
        Return New MySqlConnection(ConnectionString)
    End Function

End Module