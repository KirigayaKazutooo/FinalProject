Imports MySql.Data.MySqlClient

Public Class returnbook

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub txtreturn_TextChanged(sender As Object, e As EventArgs) Handles txtAccessNo.TextChanged
        Dim accessNo As Integer

        ' Validate and retrieve the access number
        If Not Integer.TryParse(txtAccessNo.Text, accessNo) Then
            MessageBox.Show("Invalid access number.")
            Return
        End If

        ' Perform the search operation in the database
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim borrowRecordsTable As String = "borrow_records"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Retrieve the borrowed book details based on the access number
                Dim selectQuery As String = "SELECT * FROM " & borrowRecordsTable & " WHERE borrowID = @accessNo"
                Dim selectCommand As New MySqlCommand(selectQuery, connection)
                selectCommand.Parameters.AddWithValue("@accessNo", accessNo)

                Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the book details from the reader and populate the textboxes
                        txtAccessNo.Text = accessNo.ToString()
                        txtstudID.Text = reader("studentID").ToString()
                        txtbookID.Text = reader("bookID").ToString()
                        txtbookTitle.Text = reader("bookTitle").ToString()
                        txtdateBorrow.Text = reader("dateborrowed").ToString()
                        txtdueDate.Text = reader("duedate").ToString()

                        ' Close the data reader
                        reader.Close()
                    Else
                        ' No record found
                        MessageBox.Show("No record found with the given access number.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim accessNo As Integer

        ' Validate and retrieve the access number
        If Not Integer.TryParse(txtAccessNo.Text, accessNo) Then
            MessageBox.Show("Invalid access number.")
            Return
        End If

        ' Perform the return operation in the database
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim borrowRecordsTable As String = "borrow_records"
        Dim librarianTable As String = "librarian"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Retrieve the borrowed book details based on the access number
                Dim selectQuery As String = "SELECT * FROM " & borrowRecordsTable & " WHERE borrowID = @accessNo"
                Dim selectCommand As New MySqlCommand(selectQuery, connection)
                selectCommand.Parameters.AddWithValue("@accessNo", accessNo)

                Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the quantity to be returned
                        Dim quantityToReturn As Integer = CInt(reader("quantity"))
                        Dim bookID As String = reader("bookID").ToString()

                        ' Close the data reader before executing the return operation
                        reader.Close()

                        ' Perform the return operation by deleting the record
                        Dim deleteQuery As String = "DELETE FROM " & borrowRecordsTable & " WHERE borrowID = @accessNo"
                        Dim deleteCommand As New MySqlCommand(deleteQuery, connection)
                        deleteCommand.Parameters.AddWithValue("@accessNo", accessNo)
                        deleteCommand.ExecuteNonQuery()

                        ' Update the quantity in the librarian table
                        Dim updateQuery As String = "UPDATE " & librarianTable & " SET quantity = quantity + @quantityToReturn WHERE bookID = @bookID"
                        Dim updateCommand As New MySqlCommand(updateQuery, connection)
                        updateCommand.Parameters.AddWithValue("@quantityToReturn", quantityToReturn)
                        updateCommand.Parameters.AddWithValue("@bookID", bookID)
                        updateCommand.ExecuteNonQuery()

                        ' Display a success message
                        MessageBox.Show("Book returned successfully.")
                    Else
                        ' No record found
                        MessageBox.Show("No record found with the given access number.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles bookreturn.Click
        Dim accessNo As Integer

        ' Validate and retrieve the access number
        If Not Integer.TryParse(txtAccessNo.Text, accessNo) Then
            MessageBox.Show("Invalid access number.")
            Return
        End If

        ' Perform the return operation in the database
        Dim connectionString As String = "server=localhost;user=root;password=;database=users"
        Dim borrowRecordsTable As String = "borrow_records"
        Dim librarianTable As String = "librarian"

        Using connection As New MySqlConnection(connectionString)
            Try
                connection.Open()

                ' Retrieve the borrowed book details based on the access number
                Dim selectQuery As String = "SELECT * FROM " & borrowRecordsTable & " WHERE borrowID = @accessNo"
                Dim selectCommand As New MySqlCommand(selectQuery, connection)
                selectCommand.Parameters.AddWithValue("@accessNo", accessNo)

                Using reader As MySqlDataReader = selectCommand.ExecuteReader()
                    If reader.Read() Then
                        ' Retrieve the quantity to be returned
                        Dim quantityToReturn As Integer = CInt(reader("quantity"))
                        Dim bookID As String = reader("bookID").ToString()

                        ' Close the data reader before executing the return operation
                        reader.Close()

                        ' Perform the return operation by deleting the record
                        Dim deleteQuery As String = "DELETE FROM " & borrowRecordsTable & " WHERE borrowID = @accessNo"
                        Dim deleteCommand As New MySqlCommand(deleteQuery, connection)
                        deleteCommand.Parameters.AddWithValue("@accessNo", accessNo)
                        deleteCommand.ExecuteNonQuery()

                        ' Update the quantity in the librarian table
                        Dim updateQuery As String = "UPDATE " & librarianTable & " SET quantity = quantity + @quantityToReturn WHERE bookID = @bookID"
                        Dim updateCommand As New MySqlCommand(updateQuery, connection)
                        updateCommand.Parameters.AddWithValue("@quantityToReturn", quantityToReturn)
                        updateCommand.Parameters.AddWithValue("@bookID", bookID)
                        updateCommand.ExecuteNonQuery()

                        ' Display a success message
                        MessageBox.Show("Book returned successfully.")
                    Else
                        ' No record found
                        MessageBox.Show("No record found with the given access number.")
                    End If
                End Using
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End Using
    End Sub
End Class