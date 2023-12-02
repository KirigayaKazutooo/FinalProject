Imports MySql.Data.MySqlClient

Public Class LibrarianReg

    Private Sub LibrarianReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Gender.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Address_TextChanged(sender As Object, e As EventArgs) Handles Address.TextChanged

    End Sub

    Private Sub Bday_ValueChanged(sender As Object, e As EventArgs) Handles Bday.ValueChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub ValidateEmail(email As String)
        If Not email.Contains("@") Then
            MessageBox.Show("Invalid email format. Please include the @ symbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            MessageBox.Show("Email is valid.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ' Perform further processing or actions for a valid email address
            ' ...
        End If
    End Sub

    Private Sub create_Click(sender As Object, e As EventArgs) Handles create.Click
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"

        Dim fullname As String = Fullnames.Text
        Dim username As String = userSave.Text
        Dim password As String = passSave.Text
        Dim role As String = "Librarian"

        Dim userEmail As String = Dmail.Text.Trim()
        If Not userEmail.Contains("@") Then
            MessageBox.Show("Invalid email format. Please include the @ symbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub ' Exit the method to prevent further registration processing
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Librarians (fullname, role, username, password, address, gender, bday, email) VALUES (@fullname, @role, @username, @password, @address, @gender, @bday, @email)"
                Dim command As New MySqlCommand(query, connection)


                command.Parameters.AddWithValue("@fullname", Fullnames.Text)
                command.Parameters.AddWithValue("@role", role)
                command.Parameters.AddWithValue("@username", userSave.Text)
                command.Parameters.AddWithValue("@password", passSave.Text)
                command.Parameters.AddWithValue("@address", Address.Text)
                command.Parameters.AddWithValue("@bday", Bday.Text)
                command.Parameters.AddWithValue("@gender", Gender.Text)
                command.Parameters.AddWithValue("@email", Dmail.Text)

                command.ExecuteNonQuery()
                MsgBox("Registration successful!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        ' Show the main form or perform any other actions
        Form1.Show()
        Me.Hide()
        Me.Close()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub
End Class