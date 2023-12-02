<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class returnbook
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
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtAccessNo = New System.Windows.Forms.TextBox()
        Me.bookreturn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtdueDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtdateBorrow = New System.Windows.Forms.TextBox()
        Me.txtstudID = New System.Windows.Forms.TextBox()
        Me.txtbookTitle = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbookID = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.ForeColor = System.Drawing.Color.Black
        Me.Button4.Location = New System.Drawing.Point(615, 67)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 36)
        Me.Button4.TabIndex = 43
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtAccessNo
        '
        Me.txtAccessNo.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessNo.Location = New System.Drawing.Point(370, 63)
        Me.txtAccessNo.Name = "txtAccessNo"
        Me.txtAccessNo.Size = New System.Drawing.Size(229, 43)
        Me.txtAccessNo.TabIndex = 42
        '
        'bookreturn
        '
        Me.bookreturn.ForeColor = System.Drawing.Color.Black
        Me.bookreturn.Location = New System.Drawing.Point(279, 522)
        Me.bookreturn.Name = "bookreturn"
        Me.bookreturn.Size = New System.Drawing.Size(139, 51)
        Me.bookreturn.TabIndex = 45
        Me.bookreturn.Text = "Return"
        Me.bookreturn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(216, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 26)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Accession no."
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txtdueDate)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txtdateBorrow)
        Me.GroupBox1.Controls.Add(Me.txtstudID)
        Me.GroupBox1.Controls.Add(Me.txtbookTitle)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txtbookID)
        Me.GroupBox1.Controls.Add(Me.txtAccessNo)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.bookreturn)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(232, 22)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(898, 706)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Return Book"
        '
        'txtdueDate
        '
        Me.txtdueDate.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdueDate.Location = New System.Drawing.Point(326, 440)
        Me.txtdueDate.Name = "txtdueDate"
        Me.txtdueDate.Size = New System.Drawing.Size(384, 43)
        Me.txtdueDate.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(113, 448)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 36)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Due Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(113, 385)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 36)
        Me.Label4.TabIndex = 53
        Me.Label4.Text = "Date Borrowed"
        '
        'txtdateBorrow
        '
        Me.txtdateBorrow.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdateBorrow.ForeColor = System.Drawing.Color.Black
        Me.txtdateBorrow.Location = New System.Drawing.Point(326, 382)
        Me.txtdateBorrow.Name = "txtdateBorrow"
        Me.txtdateBorrow.Size = New System.Drawing.Size(384, 43)
        Me.txtdateBorrow.TabIndex = 55
        '
        'txtstudID
        '
        Me.txtstudID.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstudID.Location = New System.Drawing.Point(326, 210)
        Me.txtstudID.Name = "txtstudID"
        Me.txtstudID.Size = New System.Drawing.Size(384, 43)
        Me.txtstudID.TabIndex = 49
        '
        'txtbookTitle
        '
        Me.txtbookTitle.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookTitle.Location = New System.Drawing.Point(326, 326)
        Me.txtbookTitle.Name = "txtbookTitle"
        Me.txtbookTitle.Size = New System.Drawing.Size(384, 43)
        Me.txtbookTitle.TabIndex = 52
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(113, 334)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(138, 36)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Book Title"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(113, 271)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(112, 36)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Book ID"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(113, 217)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(146, 36)
        Me.Label9.TabIndex = 47
        Me.Label9.Text = "Student ID"
        '
        'txtbookID
        '
        Me.txtbookID.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookID.Location = New System.Drawing.Point(326, 268)
        Me.txtbookID.Name = "txtbookID"
        Me.txtbookID.Size = New System.Drawing.Size(384, 43)
        Me.txtbookID.TabIndex = 51
        '
        'returnbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1699, 825)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "returnbook"
        Me.Text = "returnbook"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtAccessNo As System.Windows.Forms.TextBox
    Friend WithEvents bookreturn As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtdueDate As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtdateBorrow As System.Windows.Forms.TextBox
    Friend WithEvents txtstudID As System.Windows.Forms.TextBox
    Friend WithEvents txtbookTitle As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbookID As System.Windows.Forms.TextBox
End Class
