Public Class RegisterRole

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Label2_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub Lname_TextChanged(sender As Object, e As EventArgs)

    End Sub
    Private Sub Fname_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        RegisterForm.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        InstructorReg.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        LibrarianReg.Show()
        Me.Hide()
    End Sub
End Class