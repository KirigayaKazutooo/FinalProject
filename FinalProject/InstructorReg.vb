Imports MySql.Data.MySqlClient

Public Class InstructorReg

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
        Dim instructorId As String = InsID.Text
        Dim fullname As String = Fullnames.Text

        Dim username As String = userSave.Text
        Dim password As String = passSave.Text
        Dim role As String = "Instructor"



        Dim userEmail As String = Dmail.Text.Trim()
        If Not userEmail.Contains("@") Then
            MessageBox.Show("Invalid email format. Please include the @ symbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub ' Exit the method to prevent further registration processing
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Instructors (instructor_id, fullname, role, department, username, password, address, bday, gender, email) VALUES (@instructor_id, @fullname, @role, @department, @username, @password, @address, @bday, @gender, @email)"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@instructor_id", InsID.Text)
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

    Private Sub Departments_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Departments.SelectedIndexChanged
  
    End Sub

    Private Sub Gender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Gender.SelectedIndexChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Dmail_TextChanged(sender As Object, e As EventArgs) Handles Dmail.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub InstructorReg_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class