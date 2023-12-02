<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegisterStud
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
        Me.create = New System.Windows.Forms.Button()
        Me.passSave = New System.Windows.Forms.TextBox()
        Me.userSave = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Address = New System.Windows.Forms.TextBox()
        Me.Fname = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Bday = New System.Windows.Forms.DateTimePicker()
        Me.Lname = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'create
        '
        Me.create.BackColor = System.Drawing.Color.Gray
        Me.create.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.create.FlatAppearance.BorderSize = 0
        Me.create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.create.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.create.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create.ForeColor = System.Drawing.SystemColors.HighlightText
        Me.create.Location = New System.Drawing.Point(738, 592)
        Me.create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(154, 89)
        Me.create.TabIndex = 37
        Me.create.Text = "Create"
        Me.create.UseVisualStyleBackColor = False
        '
        'passSave
        '
        Me.passSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passSave.Location = New System.Drawing.Point(237, 640)
        Me.passSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.passSave.Name = "passSave"
        Me.passSave.Size = New System.Drawing.Size(319, 40)
        Me.passSave.TabIndex = 36
        Me.passSave.UseSystemPasswordChar = True
        '
        'userSave
        '
        Me.userSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userSave.Location = New System.Drawing.Point(237, 568)
        Me.userSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.userSave.Name = "userSave"
        Me.userSave.Size = New System.Drawing.Size(319, 40)
        Me.userSave.TabIndex = 35
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(51, 645)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 33)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(51, 575)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 33)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Username:"
        '
        'Email
        '
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email.Location = New System.Drawing.Point(237, 488)
        Me.Email.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Email.Name = "Email"
        Me.Email.Size = New System.Drawing.Size(654, 40)
        Me.Email.TabIndex = 32
        '
        'Gender
        '
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male ", "Female", "LGBTQIA+"})
        Me.Gender.Location = New System.Drawing.Point(237, 423)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(319, 37)
        Me.Gender.TabIndex = 31
        Me.Gender.Text = "-Select Gender-"
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(237, 288)
        Me.Address.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(654, 40)
        Me.Address.TabIndex = 29
        '
        'Fname
        '
        Me.Fname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fname.Location = New System.Drawing.Point(237, 146)
        Me.Fname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Fname.Name = "Fname"
        Me.Fname.Size = New System.Drawing.Size(654, 40)
        Me.Fname.TabIndex = 27
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(51, 492)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 33)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(51, 423)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 33)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(51, 361)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 33)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "Birthdate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(51, 292)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 33)
        Me.Label3.TabIndex = 22
        Me.Label3.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(51, 151)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 33)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "First Name"
        '
        'Bday
        '
        Me.Bday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Bday.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bday.Location = New System.Drawing.Point(237, 361)
        Me.Bday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bday.Name = "Bday"
        Me.Bday.Size = New System.Drawing.Size(447, 37)
        Me.Bday.TabIndex = 38
        '
        'Lname
        '
        Me.Lname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lname.Location = New System.Drawing.Point(237, 215)
        Me.Lname.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Lname.Name = "Lname"
        Me.Lname.Size = New System.Drawing.Size(319, 40)
        Me.Lname.TabIndex = 28
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(51, 220)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(164, 33)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Last Name:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("MS PGothic", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(289, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(376, 48)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Student Register"
        '
        'RegisterStud
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(943, 759)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Bday)
        Me.Controls.Add(Me.create)
        Me.Controls.Add(Me.passSave)
        Me.Controls.Add(Me.userSave)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Email)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Lname)
        Me.Controls.Add(Me.Fname)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RegisterStud"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegisterStud"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents create As System.Windows.Forms.Button
    Friend WithEvents passSave As System.Windows.Forms.TextBox
    Friend WithEvents userSave As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Email As System.Windows.Forms.TextBox
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Fname As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Bday As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lname As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class
