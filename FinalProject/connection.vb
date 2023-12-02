Imports MySql.Data.MySqlClient

Public Class connection
    Public con As New MySqlConnection("server=localhost;database=vbnet_users_db;uid=root;pwd='';")

    Public Sub Connect()
        If con.State = ConnectionState.Open Then
            con.Close()
            con.Open()
        Else
            con.Open()
        End If

        Publication()

    End Sub
End Class
