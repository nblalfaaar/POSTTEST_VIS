<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
		GroupBox1 = New GroupBox()
		btnTambah = New Button()
		txtGenre = New TextBox()
		txtJudul = New TextBox()
		Label2 = New Label()
		Label1 = New Label()
		GroupBox2 = New GroupBox()
		btnHapus = New Button()
		txtHapus = New TextBox()
		Label3 = New Label()
		dgvBuku = New DataGridView()
		colNo = New DataGridViewTextBoxColumn()
		colJudul = New DataGridViewTextBoxColumn()
		colGenre = New DataGridViewTextBoxColumn()
		GroupBox1.SuspendLayout()
		GroupBox2.SuspendLayout()
		CType(dgvBuku, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' GroupBox1
		' 
		GroupBox1.BackColor = Color.FromArgb(CByte(89), CByte(124), CByte(142))
		GroupBox1.Controls.Add(btnTambah)
		GroupBox1.Controls.Add(txtGenre)
		GroupBox1.Controls.Add(txtJudul)
		GroupBox1.Controls.Add(Label2)
		GroupBox1.Controls.Add(Label1)
		GroupBox1.Font = New Font("Californian FB", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		GroupBox1.ForeColor = Color.FromArgb(CByte(244), CByte(239), CByte(235))
		GroupBox1.Location = New Point(11, 30)
		GroupBox1.Name = "GroupBox1"
		GroupBox1.Size = New Size(351, 185)
		GroupBox1.TabIndex = 0
		GroupBox1.TabStop = False
		GroupBox1.Text = "Tambah Buku"
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.FromArgb(CByte(59), CByte(42), CByte(26))
		btnTambah.FlatAppearance.BorderSize = 0
		btnTambah.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(90), CByte(65), CByte(40))
		btnTambah.FlatStyle = FlatStyle.Flat
		btnTambah.Font = New Font("Californian FB", 9F)
		btnTambah.ForeColor = Color.White
		btnTambah.Location = New Point(224, 137)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(84, 29)
		btnTambah.TabIndex = 4
		btnTambah.Text = "Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' txtGenre
		' 
		txtGenre.BackColor = Color.White
		txtGenre.BorderStyle = BorderStyle.FixedSingle
		txtGenre.Font = New Font("Californian FB", 9F)
		txtGenre.Location = New Point(153, 86)
		txtGenre.Name = "txtGenre"
		txtGenre.Size = New Size(155, 25)
		txtGenre.TabIndex = 3
		' 
		' txtJudul
		' 
		txtJudul.BackColor = Color.White
		txtJudul.BorderStyle = BorderStyle.FixedSingle
		txtJudul.Font = New Font("Californian FB", 9F)
		txtJudul.Location = New Point(153, 43)
		txtJudul.Name = "txtJudul"
		txtJudul.Size = New Size(155, 25)
		txtJudul.TabIndex = 2
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.Font = New Font("Californian FB", 9F)
		Label2.ForeColor = Color.FromArgb(CByte(244), CByte(239), CByte(235))
		Label2.Location = New Point(39, 92)
		Label2.Name = "Label2"
		Label2.Size = New Size(44, 18)
		Label2.TabIndex = 1
		Label2.Text = "Genre"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Californian FB", 9F)
		Label1.ForeColor = Color.FromArgb(CByte(244), CByte(239), CByte(235))
		Label1.Location = New Point(39, 45)
		Label1.Name = "Label1"
		Label1.Size = New Size(75, 18)
		Label1.TabIndex = 0
		Label1.Text = "Judul Buku"
		' 
		' GroupBox2
		' 
		GroupBox2.BackColor = Color.FromArgb(CByte(89), CByte(124), CByte(142))
		GroupBox2.Controls.Add(btnHapus)
		GroupBox2.Controls.Add(txtHapus)
		GroupBox2.Controls.Add(Label3)
		GroupBox2.Font = New Font("Californian FB", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		GroupBox2.ForeColor = Color.FromArgb(CByte(244), CByte(239), CByte(235))
		GroupBox2.Location = New Point(379, 30)
		GroupBox2.Name = "GroupBox2"
		GroupBox2.Size = New Size(343, 185)
		GroupBox2.TabIndex = 1
		GroupBox2.TabStop = False
		GroupBox2.Text = "Hapus Buku"
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.FromArgb(CByte(192), CByte(57), CByte(43))
		btnHapus.FlatAppearance.BorderSize = 0
		btnHapus.FlatAppearance.MouseOverBackColor = Color.FromArgb(CByte(220), CByte(80), CByte(60))
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.Font = New Font("Californian FB", 9F)
		btnHapus.ForeColor = Color.White
		btnHapus.Location = New Point(224, 137)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(84, 29)
		btnHapus.TabIndex = 5
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' txtHapus
		' 
		txtHapus.BackColor = Color.White
		txtHapus.BorderStyle = BorderStyle.FixedSingle
		txtHapus.Font = New Font("Californian FB", 9F)
		txtHapus.Location = New Point(153, 45)
		txtHapus.Name = "txtHapus"
		txtHapus.Size = New Size(155, 25)
		txtHapus.TabIndex = 5
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.Font = New Font("Californian FB", 9F)
		Label3.ForeColor = Color.FromArgb(CByte(244), CByte(239), CByte(235))
		Label3.Location = New Point(46, 47)
		Label3.Name = "Label3"
		Label3.Size = New Size(75, 18)
		Label3.TabIndex = 5
		Label3.Text = "Judul Buku"
		' 
		' dgvBuku
		' 
		dgvBuku.AllowUserToAddRows = False
		dgvBuku.AllowUserToDeleteRows = False
		dgvBuku.BackgroundColor = Color.FromArgb(CByte(244), CByte(239), CByte(235))
		dgvBuku.ColumnHeadersHeight = 30
		dgvBuku.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
		dgvBuku.Columns.AddRange(New DataGridViewColumn() {colNo, colJudul, colGenre})
		dgvBuku.GridColor = Color.FromArgb(CByte(212), CByte(197), CByte(176))
		dgvBuku.Location = New Point(11, 234)
		dgvBuku.Name = "dgvBuku"
		dgvBuku.ReadOnly = True
		dgvBuku.RowHeadersVisible = False
		dgvBuku.RowHeadersWidth = 51
		dgvBuku.RowTemplate.Height = 25
		dgvBuku.ScrollBars = ScrollBars.Vertical
		dgvBuku.Size = New Size(711, 108)
		dgvBuku.TabIndex = 2
		' 
		' colNo
		' 
		colNo.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter
		DataGridViewCellStyle1.BackColor = Color.White
		DataGridViewCellStyle1.ForeColor = Color.Black
		colNo.DefaultCellStyle = DataGridViewCellStyle1
		colNo.HeaderText = "No"
		colNo.MinimumWidth = 6
		colNo.Name = "colNo"
		colNo.ReadOnly = True
		colNo.Width = 40
		' 
		' colJudul
		' 
		colJudul.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
		DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle2.BackColor = Color.White
		DataGridViewCellStyle2.ForeColor = Color.Black
		colJudul.DefaultCellStyle = DataGridViewCellStyle2
		colJudul.HeaderText = "Judul"
		colJudul.MinimumWidth = 6
		colJudul.Name = "colJudul"
		colJudul.ReadOnly = True
		' 
		' colGenre
		' 
		colGenre.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
		DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle3.BackColor = Color.White
		DataGridViewCellStyle3.ForeColor = Color.Black
		colGenre.DefaultCellStyle = DataGridViewCellStyle3
		colGenre.HeaderText = "Genre"
		colGenre.MinimumWidth = 6
		colGenre.Name = "colGenre"
		colGenre.ReadOnly = True
		colGenre.Width = 160
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 18F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(47), CByte(65), CByte(86))
		ClientSize = New Size(732, 363)
		Controls.Add(dgvBuku)
		Controls.Add(GroupBox2)
		Controls.Add(GroupBox1)
		Font = New Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Daftar Buku Perpustakaan"
		GroupBox1.ResumeLayout(False)
		GroupBox1.PerformLayout()
		GroupBox2.ResumeLayout(False)
		GroupBox2.PerformLayout()
		CType(dgvBuku, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
	End Sub

	Friend WithEvents GroupBox1 As GroupBox
	Friend WithEvents GroupBox2 As GroupBox
	Friend WithEvents txtJudul As TextBox
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents txtHapus As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents btnHapus As Button
	Friend WithEvents dgvBuku As DataGridView
	Friend WithEvents colNo As DataGridViewTextBoxColumn
	Friend WithEvents colJudul As DataGridViewTextBoxColumn
	Friend WithEvents colGenre As DataGridViewTextBoxColumn

End Class
