<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstructorReg
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
        Me.Label9 = New System.Windows.Forms.Label()
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
        Me.InsID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Departments = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Address
        '
        Me.Address.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Address.Location = New System.Drawing.Point(199, 512)
        Me.Address.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Address.Name = "Address"
        Me.Address.Size = New System.Drawing.Size(319, 40)
        Me.Address.TabIndex = 63
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(12, 152)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(182, 33)
        Me.Label9.TabIndex = 62
        Me.Label9.Text = "Instructor ID:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("MS PGothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.White
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(516, 734)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(346, 24)
        Me.LinkLabel1.TabIndex = 61
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Already have account? Click here."
        '
        'Bday
        '
        Me.Bday.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.25!)
        Me.Bday.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Bday.Location = New System.Drawing.Point(199, 581)
        Me.Bday.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Bday.Name = "Bday"
        Me.Bday.Size = New System.Drawing.Size(448, 37)
        Me.Bday.TabIndex = 60
        '
        'create
        '
        Me.create.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.create.FlatAppearance.BorderColor = System.Drawing.Color.Gray
        Me.create.FlatAppearance.BorderSize = 0
        Me.create.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver
        Me.create.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.create.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.create.ForeColor = System.Drawing.Color.White
        Me.create.Location = New System.Drawing.Point(555, 628)
        Me.create.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.create.Name = "create"
        Me.create.Size = New System.Drawing.Size(154, 89)
        Me.create.TabIndex = 59
        Me.create.Text = "Register"
        Me.create.UseVisualStyleBackColor = False
        '
        'passSave
        '
        Me.passSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.passSave.Location = New System.Drawing.Point(199, 449)
        Me.passSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.passSave.Name = "passSave"
        Me.passSave.Size = New System.Drawing.Size(319, 40)
        Me.passSave.TabIndex = 58
        Me.passSave.UseSystemPasswordChar = True
        '
        'userSave
        '
        Me.userSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.userSave.Location = New System.Drawing.Point(199, 379)
        Me.userSave.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.userSave.Name = "userSave"
        Me.userSave.Size = New System.Drawing.Size(319, 40)
        Me.userSave.TabIndex = 57
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(12, 452)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(151, 33)
        Me.Label8.TabIndex = 56
        Me.Label8.Text = "Password:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(12, 386)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 33)
        Me.Label7.TabIndex = 55
        Me.Label7.Text = "Username:"
        '
        'Dmail
        '
        Me.Dmail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Dmail.Location = New System.Drawing.Point(199, 695)
        Me.Dmail.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Dmail.Name = "Dmail"
        Me.Dmail.Size = New System.Drawing.Size(319, 40)
        Me.Dmail.TabIndex = 54
        '
        'Gender
        '
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male ", "Female", "LGBTQIA+"})
        Me.Gender.Location = New System.Drawing.Point(199, 638)
        Me.Gender.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(319, 37)
        Me.Gender.TabIndex = 53
        Me.Gender.Text = "-Select Gender-"
        '
        'Fullnames
        '
        Me.Fullnames.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Fullnames.Location = New System.Drawing.Point(199, 212)
        Me.Fullnames.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Fullnames.Name = "Fullnames"
        Me.Fullnames.Size = New System.Drawing.Size(319, 40)
        Me.Fullnames.TabIndex = 51
        '
        'InsID
        '
        Me.InsID.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InsID.Location = New System.Drawing.Point(199, 149)
        Me.InsID.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InsID.Name = "InsID"
        Me.InsID.Size = New System.Drawing.Size(319, 40)
        Me.InsID.TabIndex = 50
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(13, 702)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(97, 33)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(13, 638)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 33)
        Me.Label5.TabIndex = 48
        Me.Label5.Text = "Gender:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(13, 581)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 33)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "Birthdate:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 515)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(130, 33)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Address:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 219)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 33)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Full Name:"
        '
        'Departments
        '
        Me.Departments.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Departments.FormattingEnabled = True
        Me.Departments.ItemHeight = 30
        Me.Departments.Items.AddRange(New Object() {"College of Technology", "College of Education"})
        Me.Departments.Location = New System.Drawing.Point(199, 274)
        Me.Departments.Name = "Departments"
        Me.Departments.Size = New System.Drawing.Size(319, 94)
        Me.Departments.TabIndex = 64
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(13, 297)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(175, 33)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Department:"
        '
        'InstructorReg
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(869, 767)
        Me.Controls.Add(Me.Departments)
        Me.Controls.Add(Me.Address)
        Me.Controls.Add(Me.Label9)
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
        Me.Controls.Add(Me.InsID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.Name = "InstructorReg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "InstructorReg"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Address As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
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
    Friend WithEvents InsID As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Departments As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
