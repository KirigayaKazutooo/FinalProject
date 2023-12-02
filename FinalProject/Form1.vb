Imports MySql.Data.MySqlClient
Imports System.Data.SqlClient

Public Class Form1
    Private connectionString As String = "server=localhost;userid=root;password=;database=users;"
    Public username As String = "a"
    Public pass As String = "a"

    Dim conn As MySqlConnection

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.None
        Me.Region = CreateRoundRectRegion(New Rectangle(0, 0, Me.Width, Me.Height), 10)
        conn = New MySqlConnection
        conn.ConnectionString = "server=localhost;userid=root;password=;database=users;"
        Try
            conn.Open()
            conn.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        user.Text = "username"
    End Sub

    Private Sub user_GotFocus(sender As Object, e As EventArgs) Handles user.GotFocus
        ' Check if the TextBox contains the default "Username" text
        If user.Text = "usernames" Then
            ' Clear the TextBox
            user.Text = ""
        End If
    End Sub

    Private Sub user_LostFocus(sender As Object, e As EventArgs) Handles user.LostFocus
        ' Check if the TextBox is empty
        If user.Text = "" Then
            ' Set the default "Username" text
            user.Text = "username"
        End If
    End Sub
   


    Private Function CreateRoundRectRegion(ByVal rect As Rectangle, ByVal radius As Integer) As Region
        ' Define a GraphicsPath object to represent the rounded rectangle
        Dim path As New Drawing2D.GraphicsPath()
        path.StartFigure()
        path.AddArc(rect.X, rect.Y, radius * 2, radius * 2, 180, 90)
        path.AddLine(rect.X + radius, rect.Y, rect.Right - radius * 2, rect.Y)
        path.AddArc(rect.Right - radius * 2, rect.Y, radius * 2, radius * 2, 270, 90)
        path.AddLine(rect.Right, rect.Y + radius * 2, rect.Right, rect.Bottom - radius * 2)
        path.AddArc(rect.Right - radius * 2, rect.Bottom - radius * 2, radius * 2, radius * 2, 0, 90)
        path.AddLine(rect.Right - radius * 2, rect.Bottom, rect.X + radius * 2, rect.Bottom)
        path.AddArc(rect.X, rect.Bottom - radius * 2, radius * 2, radius * 2, 90, 90)
        path.AddLine(rect.X, rect.Bottom - radius * 2, rect.X, rect.Y + radius * 2)
        path.CloseFigure()

        ' Create a new region with the rounded rectangle path
        Return New Region(path)
    End Function

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Me.Close()

    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        RegisterRole.Show()
        Me.Hide()
    End Sub


    Private loggedInStudentID As String = ""



    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Me.Hide()
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim username As String = user.Text
        Dim password As String = passwords.Text

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Check the Students table
                Dim query As String = "SELECT role, student_id FROM Students WHERE username = @username AND password = @password"
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    Dim role As String = reader("role").ToString()
                    Dim loggedInStudentID As String = reader("student_id").ToString() ' Store the student ID
                    reader.Close()

                    ' Insert/update the usage statistics
                    UpdateUsageStatistics(username)

                    OpenFormBasedOnRole(role, loggedInStudentID)
                    Me.Hide()
                    Return
                End If

                reader.Close()

                ' Check the Instructors table
                query = "SELECT role FROM Instructors WHERE username = @username AND password = @password"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                reader = command.ExecuteReader()

                If reader.Read() Then
                    Dim role As String = reader("role").ToString()
                    reader.Close()

                    ' Insert/update the usage statistics
                    UpdateUsageStatistics(username)

                    OpenFormBasedOnRole(role, Nothing) ' Pass Nothing for student ID
                    Return
                End If

                reader.Close()

                ' Check the Librarians table
                query = "SELECT role FROM Librarians WHERE username = @username AND password = @password"
                command = New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                command.Parameters.AddWithValue("@password", password)

                reader = command.ExecuteReader()

                If reader.Read() Then
                    Dim role As String = reader("role").ToString()
                    reader.Close()

                    ' Insert/update the usage statistics
                    UpdateUsageStatistics(username)

                    OpenFormBasedOnRole(role, Nothing) ' Pass Nothing for student ID
                    Return
                End If

                reader.Close()

                MessageBox.Show("Invalid username or password.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub UpdateUsageStatistics(username As String)
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim query As String = "INSERT INTO usage_statistics (username, access_count) VALUES (@username, 1) ON DUPLICATE KEY UPDATE access_count = access_count + 1"

        Using connection As New MySqlConnection(connectionString)
            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@username", username)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub OpenFormBasedOnRole(role As String, loggedInStudentID As String)
        ' Open the corresponding form based on the role
        If role = "Student" Then
            Dim studentForm As New StudentForm(loggedInStudentID)
            studentForm.Show()
        ElseIf role = "Instructor" Then
            Dim instructorForm As New InstructorForm()
            instructorForm.Show()
        ElseIf role = "Librarian" Then
            Dim librarianForm As New LibrarianForm()
            librarianForm.Show()
        End If
    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub user_TextChanged(sender As Object, e As EventArgs) Handles user.TextChanged
       
    End Sub
End Class
