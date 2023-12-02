Imports MySql.Data.MySqlClient

Public Class RegisterForm

    Dim x1App As Microsoft.Office.Interop.Excel.Application
    Dim x1WorkBook As Microsoft.Office.Interop.Excel.Workbook
    Dim x1WorkSheet As Microsoft.Office.Interop.Excel.Worksheet

    Private Sub RegisterStud_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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
        Dim username As String = userSave.Text
        Dim password As String = passSave.Text
        Dim email As String = Dmail.Text
        Dim role As String = "Student" ' Assuming this is the role for student registration

        Dim userEmail As String = Dmail.Text.Trim()
        If Not userEmail.Contains("@") Then
            MessageBox.Show("Invalid email format. Please include the @ symbol.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub ' Exit the method to prevent further registration processing
        End If

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "INSERT INTO Students (student_id, username, password, email, role, fname, lname, address, bday, gender, department, course) VALUES (@student_id, @username, @password, @email, @role, @fname, @lname, @address, @bday, @gender, @department, @course)"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@student_id", StudentID.Text)
                command.Parameters.AddWithValue("@username", userSave.Text)
                command.Parameters.AddWithValue("@password", passSave.Text)
                command.Parameters.AddWithValue("@email", Dmail.Text)
                command.Parameters.AddWithValue("@role", role)
                command.Parameters.AddWithValue("@fname", Fname.Text)
                command.Parameters.AddWithValue("@lname", Lname.Text)
                command.Parameters.AddWithValue("@address", Address.Text)
                command.Parameters.AddWithValue("@bday", Bday.Text)
                command.Parameters.AddWithValue("@gender", Gender.Text)
                command.Parameters.AddWithValue("@department", Department.Text)
                command.Parameters.AddWithValue("@course", Course.Text)

                command.ExecuteNonQuery()
                MessageBox.Show("Registration successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub



    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub course_SelectedIndexChanged(sender As Object, e As EventArgs) Handles course.SelectedIndexChanged
        
    End Sub

    Private Sub department_SelectedIndexChanged(sender As Object, e As EventArgs) Handles department.SelectedIndexChanged
        Dim selectedDepartment As String = department.SelectedItem.ToString()

        ' Clear the course combo box
        course.Items.Clear()

        ' Add course options based on the selected department
        Select Case selectedDepartment
            Case "Technology"
                course.Items.Add("BIT")
                course.Items.Add("BSIT")
            Case "Education"
                course.Items.Add("BEED")
                course.Items.Add("BSED")
                course.Items.Add("BTLED")
        End Select

        ' Select the first course option by default
        If course.Items.Count > 0 Then
            course.SelectedIndex = 0
        End If
    End Sub

    Private Sub Dmail_TextChanged(sender As Object, e As EventArgs) Handles Dmail.TextChanged

    End Sub

    Private Sub Fname_TextChanged(sender As Object, e As EventArgs) Handles Fname.TextChanged
        GenerateUsername()
    End Sub

    Private Sub Lname_TextChanged(sender As Object, e As EventArgs) Handles Lname.TextChanged
        GenerateUsername()
    End Sub

    Private Sub GenerateUsername()
        ' Retrieve the values from the Fname and Lname textboxes
        Dim firstName As String = Fname.Text.Trim()
        Dim lastName As String = Lname.Text.Trim()

        ' Generate the username by concatenating the first name and last name with a dot separator
        Dim username As String = String.Format("{0}.{1}", firstName, lastName)

        ' Assign the generated username to the userSave textbox
        userSave.Text = username
    End Sub



    
    Private Sub userSave_TextChanged(sender As Object, e As EventArgs) Handles userSave.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x1App = New Microsoft.Office.Interop.Excel.Application
        x1WorkBook = x1App.Workbooks.Open(Application.StartupPath & "\Library")
        x1WorkSheet = x1WorkBook.Worksheets("Sheet1")
        Dim currCol, currRow, x As Integer
        currCol = 1
        currRow = 8
        With Me
            Dim y As Integer = ListView.Items.Count - 1
            For x = 0 To y
                x1WorkSheet.Cells(currRow, currCol + 0) = .ListView.Items(x).SubItems(0).Text
                x1WorkSheet.Cells(currRow, currCol + 1) = .ListView.Items(x).SubItems(1).Text
                x1WorkSheet.Cells(currRow, currCol + 2) = .ListView.Items(x).SubItems(2).Text
                x1WorkSheet.Cells(currRow, currCol + 3) = .ListView.Items(x).SubItems(3).Text
                x1WorkSheet.Cells(currRow, currCol + 4) = .ListView.Items(x).SubItems(4).Text
                x1WorkSheet.Cells(currRow, currCol + 5) = .ListView.Items(x).SubItems(5).Text
                x1WorkSheet.Cells(currRow, currCol + 6) = .ListView.Items(x).SubItems(6).Text
                x1WorkSheet.Cells(currRow, currCol + 7) = .ListView.Items(x).SubItems(7).Text
                x1WorkSheet.Cells(currRow, currCol + 8) = .ListView.Items(x).SubItems(8).Text
                currRow += 1
            Next
        End With
        x1App.Visible = True
    End Sub

    Private Sub ListView_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView.SelectedIndexChanged

    End Sub
End Class