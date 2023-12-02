Imports MySql.Data.MySqlClient

Public Class borrowlist

    Public Property StudentID As String

    Public Sub New(studentID As String)
        InitializeComponent()
        Me.StudentID = studentID
    End Sub

    Private Sub borrowlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvBorrowList.Rows.Clear()
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim borrowRecordsTable As String = "borrow_records"
        Dim query As String = "SELECT * FROM " & borrowRecordsTable & " WHERE studentID = @studentID"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Retrieve the borrowed books data
                Dim command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@studentID", StudentID)
                Dim reader As MySqlDataReader = command.ExecuteReader()

                ' Loop through the data and populate the DataGridView
                While reader.Read()
                    Dim accessionNo As Integer = CInt(reader("borrowID"))
                    Dim studentIDValue As String = reader("studentID").ToString()
                    Dim firstName As String = reader("firstName").ToString()
                    Dim lastName As String = reader("lastName").ToString()
                    Dim course As String = reader("course").ToString()
                    Dim department As String = reader("department").ToString()
                    Dim gender As String = reader("gender").ToString()
                    Dim bookTitle As String = reader("bookTitle").ToString()
                    Dim author As String = reader("author").ToString()
                    Dim yearPublished As Integer = CInt(reader("yearPub"))
                    Dim quantityBorrowed As Integer = CInt(reader("quantity"))
                    Dim dateBorrowed As Date = CDate(reader("dateborrowed"))
                    Dim dueDate As Date = CDate(reader("duedate"))

                    ' Add a new row to the DataGridView
                    dgvBorrowList.Rows.Add(accessionNo, studentIDValue, firstName, lastName, course, department, gender, bookTitle, author, yearPublished, quantityBorrowed, dateBorrowed, dueDate)
                End While

                reader.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub dgvBorrowList_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBorrowList.CellContentClick

    End Sub
End Class
