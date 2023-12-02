Imports System.Net
Imports System.Net.Mail
Public Class sendEmailForm

    Private Sub sendEmail_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub txtemail_Enter(sender As Object, e As EventArgs) Handles txtemail.Enter
        If txtemail.Text = "Email Address" Then
            txtemail.Text = ""
        End If
    End Sub

    Private Sub txtemail_Leave(sender As Object, e As EventArgs) Handles txtemail.Leave
        If txtemail.Text = "" Then
            txtemail.Text = "Email Address"
        End If
    End Sub

    Private Sub txtpass_Enter(sender As Object, e As EventArgs) Handles txtpass.Enter
        If txtpass.Text = "Password" Then
            txtpass.Text = ""

        End If
    End Sub

    Private Sub txtpass_Leave(sender As Object, e As EventArgs) Handles txtpass.Leave
        If txtpass.Text = "" Then
            txtpass.Text = "Password"

        End If
    End Sub

    Private Sub txtemail2_Enter(sender As Object, e As EventArgs) Handles txtemail2.Enter
        If txtemail2.Text = "Email Address" Then
            txtemail2.Text = ""
        End If
    End Sub

    Private Sub txtemail2_Leave(sender As Object, e As EventArgs) Handles txtemail2.Leave
        If txtemail2.Text = "" Then
            txtemail2.Text = "Email Address"
        End If
    End Sub
    Private Sub txttitle_Enter(sender As Object, e As EventArgs) Handles txttitle.Enter
        If txttitle.Text = "Title" Then
            txttitle.Text = ""
        End If
    End Sub

    Private Sub txttitle_Leave(sender As Object, e As EventArgs) Handles txttitle.Leave
        If txttitle.Text = "" Then
            txttitle.Text = "Title"
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        OpenFileDialog1.ShowDialog()
        txtpath.Text = OpenFileDialog1.FileName
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try
            Dim Email As New MailMessage()
            Dim smtp As New SmtpClient("smtp.gmail.com")
            Email.From = New MailAddress(txtemail.Text)
            Email.Subject = txttitle.Text
            Email.Body = txtbody.Text()
            Email.To.Add(txtemail2.Text)


            Dim attach As System.Net.Mail.Attachment
            attach = New System.Net.Mail.Attachment(txtpath.Text)


            Email.Attachments.Add(attach)

            smtp.Port = 587
            smtp.Credentials = New System.Net.NetworkCredential(txtemail.Text, txtpass.Text)
            smtp.EnableSsl = True
            smtp.Send(Email)

            MessageBox.Show("Message successfully sent")
            txtemail.Text = ""
            txtemail2.Text = ""
            txtpass.Text = ""
            txttitle.Text = ""
            txtpath.Text = ""
            txtbody.Text = ""
        Catch ex As Exception
            MessageBox.Show("Error sending email: " & ex.Message)
        End Try
    End Sub
End Class