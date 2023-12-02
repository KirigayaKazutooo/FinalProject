Imports MySql.Data.MySqlClient

Public Class RegisterStud

    Private Sub RegisterStud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click

        Dim connectionString As String = "server=localhost;user=root;password=;database=users"

        Dim username As String = userSave.Text
        Dim password As String = passSave.Text
        Dim em As String = Email.Text

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO student (username, password, email, fname, lname, address, bday, gender) VALUES (@username, @password, @email, @fname, @lname, @address, @bday, @gender)"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@fname", Fname.Text)
                command.Parameters.AddWithValue("@lname", Lname.Text)
                command.Parameters.AddWithValue("@address", Address.Text)
                command.Parameters.AddWithValue("@bday", Bday.Text)
                command.Parameters.AddWithValue("@gender", Gender.Text)
                command.Parameters.AddWithValue("@username", userSave.Text)
                command.Parameters.AddWithValue("@password", passSave.Text)
                command.Parameters.AddWithValue("@email", Email.Text)

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

    Private Sub Gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Gender.SelectedIndexChanged

    End Sub

    Private Sub Bd_ValueChanged(sender As Object, e As EventArgs)

    End Sub
End Class