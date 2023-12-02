<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LibrarianReg
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.Bday = New System.Windows.Forms.DateTimePicker()
        Me.create = New System.Windows.Forms.Button()
        Me.passSave = New System.Windows.Forms.TextBox()
        Me.userSave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Dmail = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Fullnames = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(200, 227)
        Me.Address.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(319, 40)
        Me.Address.TabIndex = 83
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Location = New System.Drawing.Point(523, 575)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(346, 24)
        Me.LinkLabel1.TabIndex = 81
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Already have account? Click here."
        '
        'Bday
        '
        Me.Bday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Bday.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bday.Location = New System.Drawing.Point(200, 350)
        Me.Bday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bday.Name = "Bday"
        Me.Bday.Size = New System.Drawing.Size(448, 37)
        Me.Bday.TabIndex = 80
        '
        'create
        '
        Me.create.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.create.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.create.FlatAppearance.BorderSize = 0
        Me.create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.create.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.create.Location = New System.Drawing.Point(541, 481)
        Me.create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(154, 89)
        Me.create.TabIndex = 79
        Me.create.Text = "Register"
        Me.create.UseVisualStyleBackColor = False
        '
        'passSave
        '
        Me.passSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passSave.Location = New System.Drawing.Point(200, 530)
        Me.passSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.passSave.Name = "passSave"
        Me.passSave.Size = New System.Drawing.Size(319, 40)
        Me.passSave.TabIndex = 78
        Me.passSave.UseSystemPasswordChar = True
        '
        'userSave
        '
        Me.userSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userSave.Location = New System.Drawing.Point(200, 469)
        Me.userSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.userSave.Name = "userSave"
        Me.userSave.Size = New System.Drawing.Size(319, 40)
        Me.userSave.TabIndex = 77
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 530)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 33)
        Me.Label8.TabIndex = 76
        Me.Label8.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 469)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 33)
        Me.Label7.TabIndex = 75
        Me.Label7.Text = "Username:"
        '
        'Dmail
        '
        Me.Dmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dmail.Location = New System.Drawing.Point(200, 407)
        Me.Dmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dmail.Name = "Dmail"
        Me.Dmail.Size = New System.Drawing.Size(319, 40)
        Me.Dmail.TabIndex = 74
        '
        'Gender
        '
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male ", "Female", "LGBTQIA+"})
        Me.Gender.Location = New System.Drawing.Point(200, 290)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(319, 37)
        Me.Gender.TabIndex = 73
        Me.Gender.Text = "-Select Gender-"
        '
        'Fullnames
        '
        Me.Fullnames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fullnames.Location = New System.Drawing.Point(200, 162)
        Me.Fullnames.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Fullnames.Name = "Fullnames"
        Me.Fullnames.Size = New System.Drawing.Size(319, 40)
        Me.Fullnames.TabIndex = 72
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(14, 414)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 33)
        Me.Label6.TabIndex = 70
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 290)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 33)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 350)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 33)
        Me.Label4.TabIndex = 68
        Me.Label4.Text = "Birthdate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 234)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 33)
        Me.Label3.TabIndex = 67
        Me.Label3.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 169)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 33)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "Full Name:"
        '
        'LibrarianReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(876, 613)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.Bday)
        Me.Controls.Add(Me.create)
        Me.Controls.Add(Me.passSave)
        Me.Controls.Add(Me.userSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Dmail)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Fullnames)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "LibrarianReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LibrarianReg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents Bday As System.Windows.Forms.DateTimePicker
    Friend WithEvents create As System.Windows.Forms.Button
    Friend WithEvents passSave As System.Windows.Forms.TextBox
    Friend WithEvents userSave As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Dmail As System.Windows.Forms.TextBox
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents Fullnames As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
