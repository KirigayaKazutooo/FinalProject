Imports MySql.Data.MySqlClient

Public Class borrowbook

    Dim x1App As Microsoft.Office.Interop.Excel.Application
    Dim x1WorkBook As Microsoft.Office.Interop.Excel.Workbook
    Dim x1WorkSheet As Microsoft.Office.Interop.Excel.Worksheet

    Private loggedInStudentID As String = ""
    Private searchTimer As System.Windows.Forms.Timer
  

    Public Class Student
        Public Property StudentID As String
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Course As String
        Public Property Department As String
        Public Property Gender As String
    End Class

    Public Sub New(studentID As String)
        loggedInStudentID = studentID
        InitializeComponent()
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

                    reader.Close() ' Close the reader before returning the student object
                    Return student
                End If
                reader.Close() ' Close the reader if no student is found
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        Return Nothing ' Return null or an empty object if student details not found
    End Function

    Private Sub txtAccessionNo_TextChanged(sender As Object, e As EventArgs) Handles txtbookID.TextChanged
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
        Dim searchInput As String = txtbookID.Text.Trim()

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
                    txtBookTitle.Text = reader("bookTitle").ToString()
                    txtAuthor.Text = reader("author").ToString()
                    txtYearPub.Text = reader("yearPub").ToString()
                    txtQuantity.Text = reader("quantity").ToString()
                    txtdateBorrow.Text = DateTime.Now.ToString("yyyy-MM-dd") ' Set the current date as the borrowed date
                    txtdueDate.Text = DateTime.Now.AddDays(7).ToString("yyyy-MM-dd") ' Set the due date as 7 days from the borrowed date

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




    Private Sub ClearTextBoxes()
        ' Clear the TextBox controls
        txtFirstName.Text = String.Empty
        txtLastName.Text = String.Empty
        txtCourse.Text = String.Empty
        txtDepartment.Text = String.Empty
        txtGender.Text = String.Empty
    End Sub

    Private Sub borrowbook_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DisplayStudentDetails(loggedInStudentID)
    End Sub

    Private Sub borrowbooks_Enter(sender As Object, e As EventArgs) Handles borrowbooks.Enter

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim searchInput As String = txtbookID.Text.Trim()

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
        Dim query As String = "SELECT * FROM librarian WHERE bookID = @bookID"

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

    

    Private Function GenerateNextBorrowID() As Integer
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim borrowRecordsTable As String = "borrow_records"
        Dim nextBorrowID As Integer = 0

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Retrieve the last auto-incremented borrow_ID from the borrow_records table
                Dim selectQuery As String = "SELECT AUTO_INCREMENT FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = @tableName"
                Dim selectCommand As New MySqlCommand(selectQuery, connection)
                selectCommand.Parameters.AddWithValue("@tableName", borrowRecordsTable)
                Dim result As Object = selectCommand.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    nextBorrowID = Convert.ToInt32(result)
                End If
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using

        Return nextBorrowID
    End Function


    Private selectedRowIndex As Integer = -1
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim studentID As String = txtStudID.Text.Trim()
        Dim firstName As String = txtFirstName.Text.Trim()
        Dim lastName As String = txtLastName.Text.Trim()
        Dim course As String = txtCourse.Text.Trim()
        Dim department As String = txtDepartment.Text.Trim()
        Dim gender As String = txtGender.Text.Trim()

        ' Retrieve input values from book details
        Dim bookID As String = txtbookID.Text.Trim()
        Dim bookTitle As String = txtBookTitle.Text.Trim()
        Dim author As String = txtAuthor.Text.Trim()
        Dim yearPublished As String = txtYearPub.Text.Trim()
        Dim quantity As Integer = Integer.Parse(txtQuantity.Text)
        Dim quantityToBorrow As Integer = Integer.Parse(txtQuantBorrow.Text)
        Dim dateBorrowed As Date = DateTime.Parse(txtdateBorrow.Text)
        Dim dueDate As Date = dateBorrowed.AddDays(7) ' Set the due date as 7 days from the date borrowed

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
        row.Cells("bookid").Value = bookID
        row.Cells("booktitle").Value = bookTitle
        row.Cells("author").Value = author
        row.Cells("yearpub").Value = yearPublished
        row.Cells("stocks").Value = quantityToBorrow
        row.Cells("dateborrow").Value = dateBorrowed
        row.Cells("duedate").Value = dueDate

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
                Dim insertQuery As String = "INSERT INTO " & borrowRecordsTable & " (bookID, bookTitle, author, yearPub, quantity, studentID, firstName, lastName, course, department, gender, dateborrowed, duedate) VALUES (@bookID, @bookTitle, @author, @yearPublished, @quantity, @studentID, @firstName, @lastName, @course, @department, @gender, @dateBorrowed, @dueDate)"
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
                insertCommand.Parameters.AddWithValue("@dateBorrowed", dateBorrowed)
                insertCommand.Parameters.AddWithValue("@dueDate", dueDate)
                insertCommand.ExecuteNonQuery()

                ' Retrieve the last auto-incremented borrow_ID from the borrow_records table
                Dim selectQuery As String = "SELECT LAST_INSERT_ID()"
                Dim selectCommand As New MySqlCommand(selectQuery, connection)
                Dim result As Object = selectCommand.ExecuteScalar()

                If result IsNot Nothing AndAlso Not DBNull.Value.Equals(result) Then
                    Dim borrowID As Integer = Convert.ToInt32(result)
                    txtAccessNo.Text = borrowID.ToString()
                    dgvLibrarian.Rows(rowIndex).Cells("accessnum").Value = borrowID
                End If

                ' Update the quantity label with the new quantity
                quantity -= quantityToBorrow
                txtQuantity.Text = quantity.ToString()

                ' Display a success message
                MessageBox.Show("Book borrowed successfully.")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
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

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ' Retrieve the student ID from a TextBox (assuming it's named txtStudentID)
        Dim studentID As String = txtStudID.Text.Trim()

        ' Create an instance of the BorrowList form and pass the student ID
        Dim borrowListForm As New borrowlist(studentID)

        ' Show the BorrowList form
        borrowListForm.Show()
    End Sub

    Private Sub dgvLibrarian_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLibrarian.CellContentClick

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim excelApp As New Microsoft.Office.Interop.Excel.Application
        Dim workbook As Microsoft.Office.Interop.Excel.Workbook = excelApp.Workbooks.Open(Application.StartupPath & "\Library")
        Dim worksheet As Microsoft.Office.Interop.Excel.Worksheet = workbook.Worksheets("Sheet1")
        Dim currCol, currRow As Integer
        currCol = 1
        currRow = 8

        For x As Integer = 0 To dgvLibrarian.Rows.Count - 1
            currRow += 1 ' Increment the current row index

            If dgvLibrarian.Rows(x).Cells(0).Value IsNot Nothing Then
                worksheet.Cells(currRow, currCol + 0) = dgvLibrarian.Rows(x).Cells(0).Value.ToString()
                worksheet.Cells(currRow, currCol + 1) = dgvLibrarian.Rows(x).Cells(1).Value.ToString()
                worksheet.Cells(currRow, currCol + 2) = dgvLibrarian.Rows(x).Cells(2).Value.ToString()
                worksheet.Cells(currRow, currCol + 3) = dgvLibrarian.Rows(x).Cells(3).Value.ToString()
                worksheet.Cells(currRow, currCol + 4) = dgvLibrarian.Rows(x).Cells(4).Value.ToString()
                worksheet.Cells(currRow, currCol + 5) = dgvLibrarian.Rows(x).Cells(5).Value.ToString()
                worksheet.Cells(currRow, currCol + 6) = dgvLibrarian.Rows(x).Cells(6).Value.ToString()
                worksheet.Cells(currRow, currCol + 7) = dgvLibrarian.Rows(x).Cells(7).Value.ToString()
                worksheet.Cells(currRow, currCol + 8) = dgvLibrarian.Rows(x).Cells(8).Value.ToString()
                worksheet.Cells(currRow, currCol + 8) = dgvLibrarian.Rows(x).Cells(9).Value.ToString()
                worksheet.Cells(currRow, currCol + 8) = dgvLibrarian.Rows(x).Cells(10).Value.ToString()
                worksheet.Cells(currRow, currCol + 8) = dgvLibrarian.Rows(x).Cells(11).Value.ToString()
                worksheet.Cells(currRow, currCol + 8) = dgvLibrarian.Rows(x).Cells(12).Value.ToString()
                worksheet.Cells(currRow, currCol + 8) = dgvLibrarian.Rows(x).Cells(13).Value.ToString()

                currRow += 1
            End If
        Next x

        excelApp.Visible = True
    End Sub


    Private Sub txtAccessNo_TextChanged(sender As Object, e As EventArgs) Handles txtAccessNo.TextChanged

    End Sub

    Private Sub txtGender_TextChanged(sender As Object, e As EventArgs) Handles txtGender.TextChanged

    End Sub
End Class