<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class borrowbook
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
        Me.borrowbooks = New System.Windows.Forms.GroupBox()
        Me.txtAccessNo = New System.Windows.Forms.TextBox()
        Me.txtAccessNos = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgvLibrarian = New System.Windows.Forms.DataGridView()
        Me.studID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fname = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lName = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.course = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.depart = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.gender = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.accessnum = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bookid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.booktitle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearpub = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dateborrow = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.duedate = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.txtdueDate = New System.Windows.Forms.TextBox()
        Me.txtdateBorrow = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtStudID = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtDepartment = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtGender = New System.Windows.Forms.TextBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtCourse = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.txtQuantBorrow = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txtBookTitle = New System.Windows.Forms.TextBox()
        Me.txtYearPub = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtbookID = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAuthor = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.borrowbooks.SuspendLayout()
        CType(Me.dgvLibrarian, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'borrowbooks
        '
        Me.borrowbooks.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.borrowbooks.Controls.Add(Me.txtAccessNo)
        Me.borrowbooks.Controls.Add(Me.txtAccessNos)
        Me.borrowbooks.Controls.Add(Me.Button1)
        Me.borrowbooks.Controls.Add(Me.dgvLibrarian)
        Me.borrowbooks.Controls.Add(Me.Button6)
        Me.borrowbooks.Controls.Add(Me.txtdueDate)
        Me.borrowbooks.Controls.Add(Me.txtdateBorrow)
        Me.borrowbooks.Controls.Add(Me.Label17)
        Me.borrowbooks.Controls.Add(Me.Label16)
        Me.borrowbooks.Controls.Add(Me.Panel3)
        Me.borrowbooks.Controls.Add(Me.Panel2)
        Me.borrowbooks.Font = New System.Drawing.Font("Microsoft Tai Le", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.borrowbooks.ForeColor = System.Drawing.Color.White
        Me.borrowbooks.Location = New System.Drawing.Point(2, 3)
        Me.borrowbooks.Name = "borrowbooks"
        Me.borrowbooks.Size = New System.Drawing.Size(1723, 1130)
        Me.borrowbooks.TabIndex = 5
        Me.borrowbooks.TabStop = False
        Me.borrowbooks.Text = "Borrow Books"
        '
        'txtAccessNo
        '
        Me.txtAccessNo.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessNo.Location = New System.Drawing.Point(1419, 414)
        Me.txtAccessNo.Name = "txtAccessNo"
        Me.txtAccessNo.Size = New System.Drawing.Size(231, 35)
        Me.txtAccessNo.TabIndex = 50
        '
        'txtAccessNos
        '
        Me.txtAccessNos.AutoSize = True
        Me.txtAccessNos.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAccessNos.ForeColor = System.Drawing.Color.White
        Me.txtAccessNos.Location = New System.Drawing.Point(1263, 420)
        Me.txtAccessNos.Name = "txtAccessNos"
        Me.txtAccessNos.Size = New System.Drawing.Size(124, 29)
        Me.txtAccessNos.TabIndex = 49
        Me.txtAccessNos.Text = "Access No."
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(1407, 458)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(278, 41)
        Me.Button1.TabIndex = 48
        Me.Button1.Text = "REVIEW BORROW LIST"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgvLibrarian
        '
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.dgvLibrarian.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvLibrarian.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvLibrarian.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvLibrarian.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.studID, Me.fname, Me.lName, Me.course, Me.depart, Me.gender, Me.accessnum, Me.bookid, Me.booktitle, Me.author, Me.yearpub, Me.stocks, Me.dateborrow, Me.duedate})
        Me.dgvLibrarian.Location = New System.Drawing.Point(20, 518)
        Me.dgvLibrarian.Name = "dgvLibrarian"
        Me.dgvLibrarian.RowHeadersVisible = False
        Me.dgvLibrarian.RowTemplate.Height = 28
        Me.dgvLibrarian.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvLibrarian.Size = New System.Drawing.Size(1682, 539)
        Me.dgvLibrarian.TabIndex = 4
        '
        'studID
        '
        Me.studID.HeaderText = "Student ID"
        Me.studID.Name = "studID"
        '
        'fname
        '
        Me.fname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.fname.HeaderText = "First Name"
        Me.fname.Name = "fname"
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
        'accessnum
        '
        Me.accessnum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.accessnum.HeaderText = "Accession no."
        Me.accessnum.Name = "accessnum"
        '
        'bookid
        '
        Me.bookid.HeaderText = "Book ID"
        Me.bookid.Name = "bookid"
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
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft YaHei", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.Black
        Me.Button6.Location = New System.Drawing.Point(1268, 458)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(126, 41)
        Me.Button6.TabIndex = 47
        Me.Button6.Text = "BORROW"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'txtdueDate
        '
        Me.txtdueDate.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdueDate.Location = New System.Drawing.Point(1021, 458)
        Me.txtdueDate.Name = "txtdueDate"
        Me.txtdueDate.Size = New System.Drawing.Size(231, 35)
        Me.txtdueDate.TabIndex = 46
        '
        'txtdateBorrow
        '
        Me.txtdateBorrow.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdateBorrow.Location = New System.Drawing.Point(1021, 414)
        Me.txtdateBorrow.Name = "txtdateBorrow"
        Me.txtdateBorrow.Size = New System.Drawing.Size(231, 35)
        Me.txtdateBorrow.TabIndex = 45
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.White
        Me.Label17.Location = New System.Drawing.Point(865, 458)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(115, 29)
        Me.Label17.TabIndex = 44
        Me.Label17.Text = "Due Date:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.White
        Me.Label16.Location = New System.Drawing.Point(865, 420)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(150, 29)
        Me.Label16.TabIndex = 43
        Me.Label16.Text = "Date Borrow:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.txtStudID)
        Me.Panel3.Controls.Add(Me.Label15)
        Me.Panel3.Controls.Add(Me.txtDepartment)
        Me.Panel3.Controls.Add(Me.Label14)
        Me.Panel3.Controls.Add(Me.txtGender)
        Me.Panel3.Controls.Add(Me.txtFirstName)
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.txtLastName)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.txtCourse)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.ForeColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(20, 81)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(814, 406)
        Me.Panel3.TabIndex = 42
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(516, 60)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(111, 43)
        Me.Button2.TabIndex = 50
        Me.Button2.Text = "Export"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(18, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(146, 36)
        Me.Label5.TabIndex = 49
        Me.Label5.Text = "Student ID"
        '
        'txtStudID
        '
        Me.txtStudID.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStudID.Location = New System.Drawing.Point(180, 85)
        Me.txtStudID.Name = "txtStudID"
        Me.txtStudID.Size = New System.Drawing.Size(229, 43)
        Me.txtStudID.TabIndex = 48
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(18, 273)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(163, 36)
        Me.Label15.TabIndex = 46
        Me.Label15.Text = "Department"
        '
        'txtDepartment
        '
        Me.txtDepartment.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDepartment.Location = New System.Drawing.Point(180, 270)
        Me.txtDepartment.Name = "txtDepartment"
        Me.txtDepartment.Size = New System.Drawing.Size(291, 43)
        Me.txtDepartment.TabIndex = 47
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(486, 347)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(106, 36)
        Me.Label14.TabIndex = 44
        Me.Label14.Text = "Gender"
        '
        'txtGender
        '
        Me.txtGender.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtGender.Location = New System.Drawing.Point(598, 345)
        Me.txtGender.Name = "txtGender"
        Me.txtGender.Size = New System.Drawing.Size(200, 43)
        Me.txtGender.TabIndex = 45
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(180, 147)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(384, 43)
        Me.txtFirstName.TabIndex = 43
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(15, 154)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(149, 36)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "First Name"
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(180, 209)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(384, 43)
        Me.txtLastName.TabIndex = 28
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(18, 341)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(101, 36)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "Course"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(15, 216)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(145, 36)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "Last Name"
        '
        'txtCourse
        '
        Me.txtCourse.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCourse.Location = New System.Drawing.Point(180, 334)
        Me.txtCourse.Name = "txtCourse"
        Me.txtCourse.Size = New System.Drawing.Size(291, 43)
        Me.txtCourse.TabIndex = 35
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.White
        Me.Label12.Location = New System.Drawing.Point(26, 17)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(210, 29)
        Me.Label12.TabIndex = 24
        Me.Label12.Text = "STUDENT DETAILS:"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label19)
        Me.Panel2.Controls.Add(Me.txtQuantity)
        Me.Panel2.Controls.Add(Me.txtQuantBorrow)
        Me.Panel2.Controls.Add(Me.Label18)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.txtBookTitle)
        Me.Panel2.Controls.Add(Me.txtYearPub)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.txtbookID)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.txtAuthor)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.ForeColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(870, 81)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(832, 318)
        Me.Panel2.TabIndex = 25
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label19.Location = New System.Drawing.Point(25, 255)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(94, 36)
        Me.Label19.TabIndex = 44
        Me.Label19.Text = "Stocks"
        '
        'txtQuantity
        '
        Me.txtQuantity.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantity.Location = New System.Drawing.Point(238, 252)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(193, 43)
        Me.txtQuantity.TabIndex = 45
        '
        'txtQuantBorrow
        '
        Me.txtQuantBorrow.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuantBorrow.Location = New System.Drawing.Point(584, 245)
        Me.txtQuantBorrow.Name = "txtQuantBorrow"
        Me.txtQuantBorrow.Size = New System.Drawing.Size(229, 43)
        Me.txtQuantBorrow.TabIndex = 43
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label18.Location = New System.Drawing.Point(437, 252)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(121, 36)
        Me.Label18.TabIndex = 42
        Me.Label18.Text = "Quantity"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(724, 23)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(89, 36)
        Me.Button4.TabIndex = 41
        Me.Button4.Text = "Search"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txtBookTitle
        '
        Me.txtBookTitle.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBookTitle.Location = New System.Drawing.Point(238, 76)
        Me.txtBookTitle.Name = "txtBookTitle"
        Me.txtBookTitle.Size = New System.Drawing.Size(384, 43)
        Me.txtBookTitle.TabIndex = 28
        '
        'txtYearPub
        '
        Me.txtYearPub.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtYearPub.Location = New System.Drawing.Point(238, 192)
        Me.txtYearPub.Name = "txtYearPub"
        Me.txtYearPub.Size = New System.Drawing.Size(229, 43)
        Me.txtYearPub.TabIndex = 40
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(267, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(203, 36)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Search Book ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(25, 200)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 36)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Year Published"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(25, 137)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(100, 36)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "Author"
        '
        'txtbookID
        '
        Me.txtbookID.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookID.Location = New System.Drawing.Point(476, 20)
        Me.txtbookID.Name = "txtbookID"
        Me.txtbookID.Size = New System.Drawing.Size(229, 43)
        Me.txtbookID.TabIndex = 26
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(25, 83)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 36)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "Book Title"
        '
        'txtAuthor
        '
        Me.txtAuthor.Font = New System.Drawing.Font("Microsoft Tai Le", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAuthor.Location = New System.Drawing.Point(238, 134)
        Me.txtAuthor.Name = "txtAuthor"
        Me.txtAuthor.Size = New System.Drawing.Size(291, 43)
        Me.txtAuthor.TabIndex = 35
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Tai Le", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(26, 17)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 29)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "BOOK DETAILS:"
        '
        'borrowbook
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1734, 1029)
        Me.Controls.Add(Me.borrowbooks)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "borrowbook"
        Me.Text = "borrowbook"
        Me.borrowbooks.ResumeLayout(False)
        Me.borrowbooks.PerformLayout()
        CType(Me.dgvLibrarian, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents borrowbooks As System.Windows.Forms.GroupBox
    Friend WithEvents dgvLibrarian As System.Windows.Forms.DataGridView
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents txtdueDate As System.Windows.Forms.TextBox
    Friend WithEvents txtdateBorrow As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtStudID As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtDepartment As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtGender As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtCourse As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txtQuantity As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantBorrow As System.Windows.Forms.TextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents txtBookTitle As System.Windows.Forms.TextBox
    Friend WithEvents txtYearPub As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtbookID As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAuthor As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents studID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fname As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lName As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents course As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents depart As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents gender As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents accessnum As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bookid As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents booktitle As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents author As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yearpub As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dateborrow As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents duedate As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtAccessNo As System.Windows.Forms.TextBox
    Friend WithEvents txtAccessNos As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class
