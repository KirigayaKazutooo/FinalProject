<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructor
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
        Me.Student = New System.Windows.Forms.Button()
        Me.Instructor = New System.Windows.Forms.Button()
        Me.Librarian = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Student
        '
        Me.Student.Location = New System.Drawing.Point(194, 161)
        Me.Student.Name = "Student"
        Me.Student.Size = New System.Drawing.Size(296, 44)
        Me.Student.TabIndex = 0
        Me.Student.Text = "Register as Student"
        Me.Student.UseVisualStyleBackColor = True
        '
        'Instructor
        '
        Me.Instructor.Location = New System.Drawing.Point(194, 228)
        Me.Instructor.Name = "Instructor"
        Me.Instructor.Size = New System.Drawing.Size(296, 44)
        Me.Instructor.TabIndex = 1
        Me.Instructor.Text = "Register as Instructor"
        Me.Instructor.UseVisualStyleBackColor = True
        '
        'Librarian
        '
        Me.Librarian.Location = New System.Drawing.Point(194, 294)
        Me.Librarian.Name = "Librarian"
        Me.Librarian.Size = New System.Drawing.Size(296, 44)
        Me.Librarian.TabIndex = 2
        Me.Librarian.Text = "Register as Librarian"
        Me.Librarian.UseVisualStyleBackColor = True
        '
        'Register1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 572)
        Me.Controls.Add(Me.Librarian)
        Me.Controls.Add(Me.Instructor)
        Me.Controls.Add(Me.Student)
        Me.Name = "Register1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Register1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Student As System.Windows.Forms.Button
    Friend WithEvents Instructor As System.Windows.Forms.Button
    Friend WithEvents Librarian As System.Windows.Forms.Button
End Class
