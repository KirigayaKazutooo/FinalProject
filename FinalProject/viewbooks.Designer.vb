<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class viewbooks
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.bkID1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.bkTitle1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.author1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.yearPub1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.genre1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.publisher1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.stocks = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvBooks
        '
        Me.dgvBooks.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dgvBooks.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Menu
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvBooks.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.bkID1, Me.bkTitle1, Me.author1, Me.yearPub1, Me.genre1, Me.publisher1, Me.stocks})
        Me.dgvBooks.Location = New System.Drawing.Point(48, 78)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersVisible = False
        Me.dgvBooks.RowTemplate.Height = 28
        Me.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvBooks.Size = New System.Drawing.Size(1608, 560)
        Me.dgvBooks.TabIndex = 5
        '
        'bkID1
        '
        Me.bkID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bkID1.HeaderText = "Book ID"
        Me.bkID1.Name = "bkID1"
        '
        'bkTitle1
        '
        Me.bkTitle1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.bkTitle1.HeaderText = "Book Title"
        Me.bkTitle1.Name = "bkTitle1"
        '
        'author1
        '
        Me.author1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.author1.HeaderText = "Author"
        Me.author1.Name = "author1"
        '
        'yearPub1
        '
        Me.yearPub1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.yearPub1.HeaderText = "Year Published"
        Me.yearPub1.Name = "yearPub1"
        '
        'genre1
        '
        Me.genre1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.genre1.HeaderText = "Genre"
        Me.genre1.Name = "genre1"
        '
        'publisher1
        '
        Me.publisher1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.publisher1.HeaderText = "Publisher"
        Me.publisher1.Name = "publisher1"
        '
        'stocks
        '
        Me.stocks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.stocks.HeaderText = "Stocks"
        Me.stocks.Name = "stocks"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(795, 644)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 30)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'viewbooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1704, 716)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgvBooks)
        Me.Name = "viewbooks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "viewbooks"
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dgvBooks As System.Windows.Forms.DataGridView
    Friend WithEvents bkID1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bkTitle1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents author1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents yearPub1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents genre1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents publisher1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents stocks As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
