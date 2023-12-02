Imports MySql.Data.MySqlClient

Public Class viewbooks
    Dim connectionString As String = "server=localhost;user id=root;password=;database=users"
    Private Sub dgvBooks_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick

    End Sub

    Private Sub viewbooks_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBooksData()
    End Sub

    Private Sub LoadBooksData()
        dgvBooks.Rows.Clear()

        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "SELECT bookID, bookTitle, author, yearPub, genre, publisher, quantity, avail FROM librarian"

            Using command As New MySqlCommand(query, connection)
                connection.Open()

                Dim reader As MySqlDataReader = command.ExecuteReader()

                While reader.Read()
                    Dim bookId As String = reader("bookID").ToString()
                    Dim bookTitle As String = reader("bookTitle").ToString()
                    Dim author As String = reader("author").ToString()
                    Dim yearPub As String = reader("yearPub").ToString()
                    Dim genre As String = reader("genre").ToString()
                    Dim publisher As String = reader("publisher").ToString()
                    Dim quantity As String = reader("quantity").ToString()
                    Dim availability As String = reader("avail").ToString()

                    dgvBooks.Rows.Add(bookId, bookTitle, author, yearPub, genre, publisher, quantity, availability)
                End While

                reader.Close()
            End Using

            connection.Close()
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


    End Sub
End Class