Imports MySql.Data.MySqlClient

Public Class Bobo

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub
    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub
    Private Sub Fname_TextChanged(sender As Object, e As EventArgs) Handles Fname.TextChanged

    End Sub
    Private Sub Lname_TextChanged(sender As Object, e As EventArgs) Handles Lname.TextChanged

    End Sub
    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles Address.TextChanged

    End Sub
    Private Sub Gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Gender.SelectedIndexChanged

    End Sub
    Private Sub Email_TextChanged(sender As Object, e As EventArgs) Handles Email.TextChanged

    End Sub
    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub
    Private Sub userSave_TextChanged(sender As Object, e As EventArgs) Handles userSave.TextChanged

    End Sub
    Private Sub passSave_TextChanged(sender As Object, e As EventArgs) Handles passSave.TextChanged

    End Sub
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub
    Private Sub Bday_ValueChanged(sender As Object, e As EventArgs) Handles Bday.ValueChanged

    End Sub
    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"

        Dim username As String = userSave.Text
        Dim password As String = passSave.Text
        Dim em As String = Email.Text

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO `instructor` (username, password, fname, lname) VALUES (@username, @password, @fname, @lname)"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@fname", Fname.Text)
                command.Parameters.AddWithValue("@lname", Lname.Text)
                command.Parameters.AddWithValue("@username", userSave.Text)
                command.Parameters.AddWithValue("@password", passSave.Text)


                command.ExecuteNonQuery()
                MsgBox("Registration successful!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using




        Form1.Show()
        Me.Hide()
        Me.Close()
    End Sub
End Class