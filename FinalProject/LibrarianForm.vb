Imports System.Data.SqlClient
Imports MySql.Data.MySqlClient
Imports System.Data

Public Class LibrarianForm
    Dim connectionString As String = "server=localhost;user id=root;password=;database=users"
    Private selectedBookId As String = ""

    Private selectedRowIndex As Integer
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub
    


    Private Sub LibrarianForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
    Private Sub search_LostFocus(sender As Object, e As EventArgs) Handles txtSearch.LostFocus
        If String.IsNullOrWhiteSpace(txtSearch.Text) Then
            txtSearch.Text = "Search"
        End If
    End Sub

    Private Sub search_GotFocus(sender As Object, e As EventArgs) Handles txtSearch.GotFocus
        txtSearch.Text = ""
    End Sub


    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_1(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick_2(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellContentClick


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim bookId As String = txtBookId.Text
        Dim bookTitle As String = txtBookTitle.Text
        Dim author As String = txtAuthor.Text
        Dim yearPublished As String = txtYearPub.Text
        Dim genre As String = txtGenre.Text
        Dim publisher As String = txtPublisher.Text
        Dim quantity As String = txtQuantity.Text
        Dim availability As String = cmbAvailability.Text

        ' Save the data to the database using an INSERT statement
        Using connection As New MySqlConnection(connectionString)
            Dim query As String = "INSERT INTO librarian (bookID, bookTitle, author, yearPub, genre, avail, publisher, quantity) VALUES (@bookID, @bookTitle, @author, @yearPub, @genre, @avail, @publisher, @quantity)"

            Using command As New MySqlCommand(query, connection)
                command.Parameters.AddWithValue("@bookID", txtBookId.Text)
                command.Parameters.AddWithValue("@bookTitle", txtBookTitle.Text)
                command.Parameters.AddWithValue("@author", txtAuthor.Text)
                command.Parameters.AddWithValue("@yearPub", txtYearPub.Text)
                command.Parameters.AddWithValue("@genre", txtGenre.Text)
                command.Parameters.AddWithValue("@publisher", txtPublisher.Text)
                command.Parameters.AddWithValue("@quantity", txtQuantity.Text)
                command.Parameters.AddWithValue("@avail", cmbAvailability.Text)

                connection.Open()
                command.ExecuteNonQuery()
                connection.Close()
            End Using
        End Using

        ' Refresh the DataGridView to display the updated data
        LoadBooksData()

        ' Clear the input fields
        txtBookId.Text = ""
        txtBookTitle.Text = ""
        txtAuthor.Text = ""
        txtYearPub.Text = ""
        txtGenre.Text = ""
        txtPublisher.Text = ""
        txtQuantity.Text = ""
        cmbAvailability.Text = ""
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If dgvBooks.SelectedRows.Count > 0 Then
            Dim selectedRowIndex As Integer = dgvBooks.SelectedRows(0).Index
            Dim bookId As String = dgvBooks.SelectedRows(0).Cells("bkID1").Value.ToString()

            ' Delete the record from the database
            Using connection As New MySqlConnection(connectionString)
                Dim query As String = "DELETE FROM librarian WHERE bookID = @bookID"

                Using command As New MySqlCommand(query, connection)
                    command.Parameters.AddWithValue("@bookID", bookId)

                    connection.Open()
                    command.ExecuteNonQuery()
                    connection.Close()
                End Using
            End Using

            ' Remove the row from the DataGridView
            dgvBooks.Rows.RemoveAt(selectedRowIndex)
        End If
    End Sub

    Private Sub dgvBooks_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvBooks.CellClick


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ' Get the values from the textboxes
        Dim id As Integer = Integer.Parse(txtBookId.Text)
        Dim name As String = txtBookTitle.Text
        Dim author As String = txtAuthor.Text
        Dim yearPub As String = txtYearPub.Text
        Dim genre As String = txtGenre.Text
        Dim publisher As String = txtPublisher.Text
        Dim quantity As String = txtQuantity.Text
        Dim availability As String = cmbAvailability.Text

        ' Update the DataGridView
        For Each row As DataGridViewRow In dgvBooks.Rows
            If row.Cells("bkID1").Value IsNot Nothing AndAlso Integer.Parse(row.Cells("bkID1").Value.ToString()) = id Then
                row.Cells("bkID1").Value = id
                row.Cells("bkTitle1").Value = name
                row.Cells("author1").Value = author
                row.Cells("yearPub1").Value = yearPub
                row.Cells("genre1").Value = genre
                row.Cells("avail1").Value = availability
                row.Cells("publisher1").Value = publisher
                row.Cells("quantity1").Value = quantity
                Exit For
            End If
        Next

        ' Update the database table
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()
                Dim query As String = "UPDATE librarian SET bookTitle = @bookTitle, author = @author, yearPub = @yearPub, genre = @genre, avail = @avail, publisher = @publisher, quantity = @quantity WHERE bookID = @bookID"
                Dim command As New MySqlCommand(query, connection)

                command.Parameters.AddWithValue("@bookID", id)
                command.Parameters.AddWithValue("@bookTitle", name)
                command.Parameters.AddWithValue("@author", author)
                command.Parameters.AddWithValue("@yearPub", yearPub)
                command.Parameters.AddWithValue("@genre", genre)
                command.Parameters.AddWithValue("@avail", availability)
                command.Parameters.AddWithValue("@publisher", publisher)
                command.Parameters.AddWithValue("@quantity", quantity)

                command.ExecuteNonQuery()
                MessageBox.Show("Record updated successfully!")
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub




    Private Sub ClearInputFields()
        txtBookId.Text =
        txtBookTitle.Text = ""
        txtAuthor.Text = ""
        txtYearPub.Text = ""
        txtGenre.Text = ""
        cmbAvailability.Text = ""
        txtPublisher.Text = ""
        txtQuantity.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        txtBookId.Text = String.Empty
        txtBookTitle.Text = String.Empty
        txtAuthor.Text = String.Empty
        txtYearPub.Text = String.Empty
        txtGenre.Text = String.Empty
        txtPublisher.Text = String.Empty
        txtQuantity.Text = String.Empty
        cmbAvailability.Text = String.Empty
        txtSearch.Text = String.Empty

        txtBookId.Focus()
    End Sub

    Private Sub search_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        Dim searchTerm As String = txtSearch.Text.Trim()

        ' Search for the term in the DataGridView
        For Each row As DataGridViewRow In dgvBooks.Rows
            For Each cell As DataGridViewCell In row.Cells
                If cell.Value IsNot Nothing AndAlso cell.Value.ToString().Contains(searchTerm) Then
                    ' Select the matching row and fill the TextBoxes
                    dgvBooks.ClearSelection()
                    row.Selected = True

                    txtBookId.Text = row.Cells("bkID1").Value.ToString()
                    txtBookTitle.Text = row.Cells("bkTitle1").Value.ToString()
                    txtAuthor.Text = row.Cells("author1").Value.ToString()
                    txtYearPub.Text = row.Cells("yearPub1").Value.ToString()
                    txtGenre.Text = row.Cells("genre1").Value.ToString()
                    cmbAvailability.Text = row.Cells("avail1").Value.ToString()
                    txtPublisher.Text = row.Cells("publisher1").Value.ToString()
                    txtQuantity.Text = row.Cells("quantity1").Value.ToString()
                    ' Continue filling in the other TextBoxes with the corresponding column values

                    Exit Sub ' Exit the loop after finding the first match
                End If
            Next
        Next

        ' Clear the TextBoxes if no match is found
        ClearTextBoxes()
    End Sub

    Private Sub dgvRecords_SelectionChanged(sender As Object, e As EventArgs) Handles dgvBooks.SelectionChanged
        ' Update the TextBoxes with the data from the selected row
        If dgvBooks.SelectedRows.Count > 0 Then
            Dim selectedRow As DataGridViewRow = dgvBooks.SelectedRows(0)

            txtBookId.Text = selectedRow.Cells("bkID1").Value.ToString()
            txtBookTitle.Text = selectedRow.Cells("bkTitle1").Value.ToString()
            txtAuthor.Text = selectedRow.Cells("author1").Value.ToString()
            txtYearPub.Text = selectedRow.Cells("yearPub1").Value.ToString()
            txtGenre.Text = selectedRow.Cells("genre1").Value.ToString()
            cmbAvailability.Text = selectedRow.Cells("avail1").Value.ToString()
            txtPublisher.Text = selectedRow.Cells("publisher1").Value.ToString()
            txtQuantity.Text = selectedRow.Cells("quantity1").Value.ToString()

            ' Update the other TextBoxes with the corresponding column values
        End If
    End Sub

    Private Sub ClearTextBoxes()
        ' Clear the TextBoxes
        txtBookId.Text = ""
        txtBookTitle.Text = ""
        txtAuthor.Text = ""
        txtYearPub.Text = ""
        txtGenre.Text = ""
        cmbAvailability.Text = ""
        txtPublisher.Text = ""
        txtQuantity.Text = ""
        ' Clear the other TextBoxes
    End Sub

    Private Sub txtAuthor_TextChanged(sender As Object, e As EventArgs) Handles txtAuthor.TextChanged

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub cmbAvailability_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbAvailability.SelectedIndexChanged

    End Sub

    Private Sub txtGenre_TextChanged(sender As Object, e As EventArgs) Handles txtGenre.TextChanged

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub txtBookTitle_TextChanged(sender As Object, e As EventArgs) Handles txtBookTitle.TextChanged

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub txtBookId_TextChanged(sender As Object, e As EventArgs) Handles txtBookId.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub txtYearPub_TextChanged(sender As Object, e As EventArgs) Handles txtYearPub.TextChanged

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtPublisher_TextChanged(sender As Object, e As EventArgs) Handles txtPublisher.TextChanged

    End Sub

    Private Sub txtQuantity_TextChanged(sender As Object, e As EventArgs) Handles txtQuantity.TextChanged

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        graph.Show()
        Me.Hide()

    End Sub
End Class