﻿Imports MySql.Data.MySqlClient

Public Class StudentForm
    Private loggedInStudentID As String = ""
    Private searchTimer As System.Windows.Forms.Timer
    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Dim studentID As String = txtStudID.Text

        ' Check if the student ID is valid
        If Not String.IsNullOrEmpty(studentID) Then
            ' Instantiate an object of the borrowbook class with the student ID
            Dim borrowBookForm As New borrowbook(studentID)
            switchPanel(borrowBookForm) ' Pass the borrowbook form object to the switchPanel method
        Else
            MessageBox.Show("Please enter a valid student ID.")
        End If

    End Sub

    Public Class Student
        Public Property StudentID As String
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Course As String
        Public Property Department As String
        Public Property Gender As String

    End Class

    Public Sub New(studentID As String)
        InitializeComponent()
        loggedInStudentID = studentID
    End Sub


    Private Sub LoginForm_LoginSuccess(studentID As String)
        ' Store the logged-in student ID
        loggedInStudentID = studentID

        ' Retrieve and display the student details
        DisplayStudentDetails(loggedInStudentID)
    End Sub

    Private Sub DisplayStudentDetails(studentID As String)
        Dim studentDetails As Student = RetrieveStudentDetails(studentID)
        If studentDetails IsNot Nothing Then
            ' Populate the textboxes with the student details

            txtStudID.Text = studentDetails.StudentID
            txtFirstName.Text = studentDetails.FirstName
            txtLastName.Text = studentDetails.LastName
            txtCourse.Text = studentDetails.Course
            txtDepartment.Text = studentDetails.Department
            txtGender.Text = studentDetails.Gender

            txtStudID.ReadOnly = True
            txtFirstName.ReadOnly = True
            txtLastName.ReadOnly = True
            txtCourse.ReadOnly = True
            txtDepartment.ReadOnly = True
            txtGender.ReadOnly = True
        Else
            ' If no student is found, clear the TextBox controls
            ClearTextBoxes()
            MessageBox.Show("Student not found.")
        End If
    End Sub

    Private Function RetrieveStudentDetails(studentID As String) As Student
        ' Replace this with your code to query the database and retrieve the student details based on the provided studentID
        ' Return a Student object populated with the retrieved data
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim query As String = "SELECT * FROM Students WHERE student_id = @studentID"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentID", studentID)

                Dim reader As MySqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    ' Create a Student object and populate it with the retrieved data
                    Dim student As New Student()
                    student.StudentID = reader("student_id").ToString()
                    student.FirstName = reader("fname").ToString()
                    student.LastName = reader("lname").ToString()
                    student.Course = reader("course").ToString()
                    student.Department = reader("department").ToString()
                    student.Gender = reader("gender").ToString()

                    Return student
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        Return Nothing ' Return null or an empty object if student details not found
    End Function




Private Sub PictureBox4_Click(sender As Object, e As EventArgs) Handles PictureBox4.Click




End Sub

    Private Sub borrowbooks_Enter(sender As Object, e As EventArgs) Handles borrowbooks.Enter
    End Sub


Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        switchPanel(returnbook)


End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim studentID As String = txtStudID.Text

        ' Check if the student ID is valid
        If Not String.IsNullOrEmpty(studentID) Then
            ' Instantiate an object of the borrowbook class with the student ID
            Dim borrowBookForm As New borrowbook(studentID)
            switchPanel(borrowBookForm) ' Pass the borrowbook form object to the switchPanel method
        Else
            MessageBox.Show("Please enter a valid student ID.")
        End If

    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel4.Controls.Clear()
        panel.TopLevel = False
        Panel4.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub txtAccessionNo_TextChanged(sender As Object, e As EventArgs) Handles txtAccessionNo.TextChanged
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Dispose()
        End If

        ' Create a new timer with a delay of 500 milliseconds (adjust as needed)
        searchTimer = New System.Windows.Forms.Timer()
        searchTimer.Interval = 500
        AddHandler searchTimer.Tick, AddressOf DelayedSearches
        searchTimer.Start()
    End Sub

    Private Sub DelayedSearches(sender As Object, e As EventArgs)
        ' Stop the timer
        searchTimer.Stop()
        RemoveHandler searchTimer.Tick, AddressOf DelayedSearches
        searchTimer.Dispose()
        searchTimer = Nothing

        ' Get the search input from the TextBox
        Dim searchInput As String = txtAccessionNo.Text.Trim()

        ' Check if the search input is empty
        If String.IsNullOrEmpty(searchInput) Then
            ' Clear the TextBox controls
            ClearTextBoxes()
            Return
        End If

        ' Perform the search in the database
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim query As String = "SELECT * FROM librarian WHERE bookId = @book_ID"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@book_ID", searchInput)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Populate the TextBox controls with the retrieved book details
                    txtBookTitle.Text = reader("bookTitle").ToString
                    txtAuthor.Text = reader("author").ToString()
                    txtYearPub.Text = reader("yearPub").ToString()
                    txtQuantity.Text = reader("quantity").ToString()

                    MessageBox.Show("Book found.")
                Else
                    ' If no student is found, clear the TextBox controls
                    ClearTextBoxes()
                    MessageBox.Show("Book not found.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub txtBookTitle_TextChanged(sender As Object, e As EventArgs) Handles txtBookTitle.TextChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibrarian.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' Get the search input from the TextBox
        Dim searchInput As String = txtSearch.Text.Trim()

        ' Perform the search
        SearchStudent(searchInput)
    End Sub

    Private Sub SearchStudent(searchInput As String)
        ' Check if the search input is empty
        If String.IsNullOrEmpty(searchInput) Then
            MessageBox.Show("Please enter a student ID to search.")
            Return
        End If

        ' Perform the search in the database
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim query As String = "SELECT * FROM Students WHERE student_id = @studentID"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentID", searchInput)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Populate the TextBox controls with the retrieved student details
                    txtFirstName.Text = reader("fname").ToString()
                    txtLastName.Text = reader("lname").ToString()
                    txtCourse.Text = reader("course").ToString()
                    txtDepartment.Text = reader("department").ToString()
                    txtGender.Text = reader("gender").ToString()

                    MessageBox.Show("Student found.")
                Else
                    ' If no student is found, clear the TextBox controls
                    ClearTextBoxes()
                    MessageBox.Show("Student not found.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub


    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        ' Reset the timer when the user continues typing
        If searchTimer IsNot Nothing Then
            searchTimer.Stop()
            searchTimer.Dispose()
        End If

        ' Create a new timer with a delay of 500 milliseconds (adjust as needed)
        searchTimer = New System.Windows.Forms.Timer()
        searchTimer.Interval = 500
        AddHandler searchTimer.Tick, AddressOf DelayedSearch
        searchTimer.Start()
    End Sub

    Private Sub DelayedSearch(sender As Object, e As EventArgs)
        ' Stop the timer
        searchTimer.Stop()
        RemoveHandler searchTimer.Tick, AddressOf DelayedSearch
        searchTimer.Dispose()
        searchTimer = Nothing

        ' Get the search input from the TextBox
        Dim searchInput As String = txtSearch.Text.Trim()

        ' Check if the search input is empty
        If String.IsNullOrEmpty(searchInput) Then
            ' Clear the TextBox controls
            ClearTextBoxes()
            Return
        End If

        ' Perform the search in the database
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim query As String = "SELECT * FROM Students WHERE student_id = @studentID"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentID", searchInput)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Populate the TextBox controls with the retrieved student details
                    txtStudID.Text = reader("student_id").ToString
                    txtFirstName.Text = reader("fname").ToString()
                    txtLastName.Text = reader("lname").ToString()
                    txtCourse.Text = reader("course").ToString()
                    txtDepartment.Text = reader("department").ToString()
                    txtGender.Text = reader("gender").ToString()

                    MessageBox.Show("Student found.")
                Else
                    ' If no student is found, clear the TextBox controls
                    ClearTextBoxes()
                    MessageBox.Show("Student not found.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub





    Private Sub ClearTextBoxes()
        ' Clear the TextBox controls
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtCourse.Text = String.Empty
        txtDepartment.Text = String.Empty
        txtGender.Text = String.Empty
    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtStudID.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim searchInput As String = txtAccessionNo.Text.Trim()

        ' Perform the search
        SearchBook(searchInput)
    End Sub

    Private Sub SearchBook(searchInput As String)
        ' Check if the search input is empty
        If String.IsNullOrEmpty(searchInput) Then
            MessageBox.Show("Please enter a Accession no. to search.")
            Return
        End If

        ' Perform the search in the database
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim query As String = "SELECT * FROM librarian WHERE bookID = @book_ID"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@book_ID", searchInput)

                Dim reader As MySqlDataReader = command.ExecuteReader()

                If reader.Read() Then
                    ' Populate the TextBox controls with the retrieved bool details
                    txtBookTitle.Text = reader("bookTitle").ToString()
                    txtAuthor.Text = reader("author").ToString()
                    txtYearPub.Text = reader("yearPub").ToString()
                    txtQuantity.Text = reader("quantity").ToString()

                    MessageBox.Show("Book found.")
                Else
                    ' If no student is found, clear the TextBox controls
                    ClearTextBoxes()
                    MessageBox.Show("Book not found.")
                End If

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private selectedRowIndex As Integer = -1

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim studentID As String = txtStudID.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim course As String = txtCourse.Text.Trim()
        Dim department As String = txtDepartment.Text.Trim()
        Dim gender As String = txtGender.Text.Trim()

        ' Retrieve input values from book details
        Dim bookID As String = txtAccessionNo.Text.Trim()
        Dim bookTitle As String = txtBookTitle.Text.Trim()
        Dim author As String = txtAuthor.Text.Trim()
        Dim yearPublished As String = txtYearPub.Text.Trim()
        Dim quantity As Integer = Integer.Parse(txtQuantity.Text)
        Dim quantityToBorrow As Integer = Integer.Parse(txtQuantBorrow.Text)

        ' Validate input
        If quantityToBorrow <= 0 Or quantityToBorrow > quantity Then
            MessageBox.Show("Invalid quantity to borrow.")
            Return
        End If

        ' Add the borrowed book details and student details to the DataGridView
        Dim rowIndex As Integer = dgvLibrarian.Rows.Add()
        Dim row As DataGridViewRow = dgvLibrarian.Rows(rowIndex)

        row.Cells("studID").Value = studentID
        row.Cells("fname").Value = firstName
        row.Cells("lName").Value = lastName
        row.Cells("course").Value = course
        row.Cells("depart").Value = department
        row.Cells("gender").Value = gender
        row.Cells("accessno").Value = bookID
        row.Cells("booktitle").Value = bookTitle
        row.Cells("author").Value = author
        row.Cells("yearpub").Value = yearPublished
        row.Cells("stocks").Value = quantityToBorrow

        ' Select the newly added row
        dgvLibrarian.ClearSelection()
        dgvLibrarian.Rows(rowIndex).Selected = True
        dgvLibrarian.FirstDisplayedScrollingRowIndex = rowIndex

        ' Perform database updates
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim librarianTable As String = "librarian"
        Dim borrowRecordsTable As String = "borrow_records"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Update the librarian table with the borrowed quantity
                Dim updateQuery As String = "UPDATE " & librarianTable & " SET quantity = quantity - @borrowedQuantity WHERE bookID = @bookID"
                Dim updateCommand As New MySqlCommand(updateQuery, connection)
                updateCommand.Parameters.AddWithValue("@borrowedQuantity", quantityToBorrow)
                updateCommand.Parameters.AddWithValue("@bookID", bookID)
                updateCommand.ExecuteNonQuery()

                ' Insert a new record in the borrow records table with book and student details
                Dim insertQuery As String = "INSERT INTO " & borrowRecordsTable & " (bookID, bookTitle, author, yearPub, quantity, studentID, firstName, lastName, course, department, gender) VALUES (@bookID, @bookTitle, @author, @yearPublished, @quantity, @studentID, @firstName, @lastName, @course, @department, @gender)"
                Dim insertCommand As New MySqlCommand(insertQuery, connection)
                insertCommand.Parameters.AddWithValue("@bookID", bookID)
                insertCommand.Parameters.AddWithValue("@bookTitle", bookTitle)
                insertCommand.Parameters.AddWithValue("@author", author)
                insertCommand.Parameters.AddWithValue("@yearPublished", yearPublished)
                insertCommand.Parameters.AddWithValue("@quantity", quantityToBorrow)
                insertCommand.Parameters.AddWithValue("@studentID", studentID)
                insertCommand.Parameters.AddWithValue("@firstName", firstName)
                insertCommand.Parameters.AddWithValue("@lastName", lastName)
                insertCommand.Parameters.AddWithValue("@course", course)
                insertCommand.Parameters.AddWithValue("@department", department)
                insertCommand.Parameters.AddWithValue("@gender", gender)
                insertCommand.ExecuteNonQuery()

                ' Display a success message
                MessageBox.Show("Book borrowed successfully.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub StudentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStudentDetails(loggedInStudentID)
    End Sub

    Private Sub dgvLibrarian_SelectionChanged(sender As Object, e As EventArgs) Handles dgvLibrarian.SelectionChanged
        If dgvLibrarian.SelectedRows.Count > 0 Then
            selectedRowIndex = dgvLibrarian.SelectedRows(0).Index
        Else
            selectedRowIndex = -1
        End If
    End Sub

    Private Sub dgvLibrarian_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibrarian.CellClick
        If e.RowIndex >= 0 Then
            selectedRowIndex = e.RowIndex
        End If
    End Sub

    Private Sub returnbooks_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel4_Paint(sender As Object, e As PaintEventArgs) Handles Panel4.Paint

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        sendEmailForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        viewbooks.Show()
        Me.hide
    End Sub
End Class