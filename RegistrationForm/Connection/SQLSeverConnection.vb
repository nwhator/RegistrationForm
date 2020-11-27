Imports System.Data.SqlClient
Module SQLSeverConnection

    ' PROMISE\SERVER
    Public StringConnection As String = "Data Source=PROMISE\SERVER;Initial Catalog=UserLoginDb;Integrated Security=True"

    Function ExecuteSQL(sql As String) As DataTable

        Try

            Dim connection As New SqlConnection
            Dim adapter As SqlDataAdapter
            Dim dt As New DataTable

            connection.ConnectionString = StringConnection
            connection.Open()

            adapter = New SqlDataAdapter(sql, connection)
            adapter.Fill(dt)

            connection.Close()
            connection = Nothing

            Return dt

        Catch ex As Exception
            ' An error occured!
        End Try

    End Function

End Module
