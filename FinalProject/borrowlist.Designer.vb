<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrowlist
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBorrowList = New System.Windows.Forms.DataGridView()
        Me.studID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.booktitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearpub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateborrow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBorrowList
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvBorrowList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvBorrowList.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvBorrowList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBorrowList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.studID, Me.fname, Me.Column1, Me.lName, Me.course, Me.depart, Me.gender, Me.booktitle, Me.author, Me.yearpub, Me.stocks, Me.dateborrow, Me.duedate})
        Me.dgvBorrowList.Location = New System.Drawing.Point(31, 60)
        Me.dgvBorrowList.Name = "dgvBorrowList"
        Me.dgvBorrowList.RowHeadersVisible = False
        Me.dgvBorrowList.RowTemplate.Height = 28
        Me.dgvBorrowList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBorrowList.Size = New System.Drawing.Size(1682, 539)
        Me.dgvBorrowList.TabIndex = 5
        '
        'studID
        '
        Me.studID.HeaderText = "Accession No."
        Me.studID.Name = "studID"
        '
        'fname
        '
        Me.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fname.HeaderText = "Student ID"
        Me.fname.Name = "fname"
        '
        'Column1
        '
        Me.Column1.HeaderText = "First Name"
        Me.Column1.Name = "Column1"
        '
        'lName
        '
        Me.lName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.lName.HeaderText = "Last Name"
        Me.lName.Name = "lName"
        '
        'course
        '
        Me.course.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.course.HeaderText = "Course"
        Me.course.Name = "course"
        '
        'depart
        '
        Me.depart.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.depart.HeaderText = "Department"
        Me.depart.Name = "depart"
        '
        'gender
        '
        Me.gender.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.gender.HeaderText = "Gender"
        Me.gender.Name = "gender"
        '
        'booktitle
        '
        Me.booktitle.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.booktitle.HeaderText = "Book Title"
        Me.booktitle.Name = "booktitle"
        '
        'author
        '
        Me.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.author.HeaderText = "Author"
        Me.author.Name = "author"
        '
        'yearpub
        '
        Me.yearpub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.yearpub.HeaderText = "Year Published"
        Me.yearpub.Name = "yearpub"
        '
        'stocks
        '
        Me.stocks.HeaderText = "Quantity Borrowed"
        Me.stocks.Name = "stocks"
        '
        'dateborrow
        '
        Me.dateborrow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.dateborrow.HeaderText = "Date Borrowed"
        Me.dateborrow.Name = "dateborrow"
        '
        'duedate
        '
        Me.duedate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.duedate.HeaderText = "Due Date"
        Me.duedate.Name = "duedate"
        '
        'borrowlist
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1725, 673)
        Me.Controls.Add(Me.dgvBorrowList)
        Me.Name = "borrowlist"
        Me.Text = "borrowlist"
        CType(Me.dgvBorrowList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBorrowList As System.Windows.Forms.DataGridView
    Friend WithEvents studID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents course As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents booktitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents author As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yearpub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateborrow As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents duedate As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
