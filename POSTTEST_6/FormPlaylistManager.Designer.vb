<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPlaylistManager
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
		components = New ComponentModel.Container()
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
		MenuStrip1 = New MenuStrip()
		mnuDataLagu = New ToolStripMenuItem()
		lblKodeJudul = New Label()
		txtKodePlaylist = New TextBox()
		lblNamaJudul = New Label()
		txtNamaPlaylist = New TextBox()
		lblTglJudul = New Label()
		dtpTanggal = New DateTimePicker()
		lblDescJudul = New Label()
		txtDeskripsi = New TextBox()
		lblCariJudul = New Label()
		txtSearch = New TextBox()
		btnSimpan = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		btnBatal = New Button()
		dgvPlaylist = New DataGridView()
		ErrorProvider1 = New ErrorProvider(components)
		btnDetail = New Button()
		kodePlaylist = New DataGridViewTextBoxColumn()
		namaPlaylist = New DataGridViewTextBoxColumn()
		deskripsi = New DataGridViewTextBoxColumn()
		tanggalDibuat = New DataGridViewTextBoxColumn()
		MenuStrip1.SuspendLayout()
		CType(dgvPlaylist, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {mnuDataLagu})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(882, 28)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' mnuDataLagu
		' 
		mnuDataLagu.Name = "mnuDataLagu"
		mnuDataLagu.Size = New Size(91, 24)
		mnuDataLagu.Text = "Data Lagu"
		' 
		' lblKodeJudul
		' 
		lblKodeJudul.AutoSize = True
		lblKodeJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblKodeJudul.Location = New Point(20, 55)
		lblKodeJudul.Name = "lblKodeJudul"
		lblKodeJudul.Size = New Size(94, 17)
		lblKodeJudul.TabIndex = 1
		lblKodeJudul.Text = "Kode Playlist"
		' 
		' txtKodePlaylist
		' 
		txtKodePlaylist.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtKodePlaylist.BorderStyle = BorderStyle.FixedSingle
		txtKodePlaylist.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtKodePlaylist.Location = New Point(130, 52)
		txtKodePlaylist.Name = "txtKodePlaylist"
		txtKodePlaylist.Size = New Size(150, 25)
		txtKodePlaylist.TabIndex = 2
		' 
		' lblNamaJudul
		' 
		lblNamaJudul.AutoSize = True
		lblNamaJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblNamaJudul.Location = New Point(20, 85)
		lblNamaJudul.Name = "lblNamaJudul"
		lblNamaJudul.Size = New Size(98, 17)
		lblNamaJudul.TabIndex = 3
		lblNamaJudul.Text = "Nama Playlist"
		' 
		' txtNamaPlaylist
		' 
		txtNamaPlaylist.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtNamaPlaylist.BorderStyle = BorderStyle.FixedSingle
		txtNamaPlaylist.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtNamaPlaylist.Location = New Point(130, 82)
		txtNamaPlaylist.Name = "txtNamaPlaylist"
		txtNamaPlaylist.Size = New Size(180, 25)
		txtNamaPlaylist.TabIndex = 4
		' 
		' lblTglJudul
		' 
		lblTglJudul.AutoSize = True
		lblTglJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblTglJudul.Location = New Point(20, 115)
		lblTglJudul.Name = "lblTglJudul"
		lblTglJudul.Size = New Size(106, 17)
		lblTglJudul.TabIndex = 5
		lblTglJudul.Text = "Tanggal Dibuat"
		' 
		' dtpTanggal
		' 
		dtpTanggal.CalendarTitleBackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		dtpTanggal.Format = DateTimePickerFormat.Short
		dtpTanggal.Location = New Point(130, 112)
		dtpTanggal.Name = "dtpTanggal"
		dtpTanggal.Size = New Size(180, 25)
		dtpTanggal.TabIndex = 6
		' 
		' lblDescJudul
		' 
		lblDescJudul.AutoSize = True
		lblDescJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblDescJudul.Location = New Point(20, 150)
		lblDescJudul.Name = "lblDescJudul"
		lblDescJudul.Size = New Size(68, 17)
		lblDescJudul.TabIndex = 7
		lblDescJudul.Text = "Deskripsi"
		' 
		' txtDeskripsi
		' 
		txtDeskripsi.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtDeskripsi.BorderStyle = BorderStyle.FixedSingle
		txtDeskripsi.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtDeskripsi.Location = New Point(130, 147)
		txtDeskripsi.Multiline = True
		txtDeskripsi.Name = "txtDeskripsi"
		txtDeskripsi.Size = New Size(180, 55)
		txtDeskripsi.TabIndex = 8
		' 
		' lblCariJudul
		' 
		lblCariJudul.AutoSize = True
		lblCariJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblCariJudul.Location = New Point(20, 215)
		lblCariJudul.Name = "lblCariJudul"
		lblCariJudul.Size = New Size(86, 17)
		lblCariJudul.TabIndex = 9
		lblCariJudul.Text = "Cari Playlist"
		' 
		' txtSearch
		' 
		txtSearch.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtSearch.BorderStyle = BorderStyle.FixedSingle
		txtSearch.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtSearch.Location = New Point(130, 212)
		txtSearch.Name = "txtSearch"
		txtSearch.Size = New Size(180, 25)
		txtSearch.TabIndex = 10
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		btnSimpan.FlatAppearance.BorderSize = 0
		btnSimpan.FlatStyle = FlatStyle.Flat
		btnSimpan.ForeColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		btnSimpan.Location = New Point(20, 255)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(100, 30)
		btnSimpan.TabIndex = 11
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.FromArgb(CByte(10), CByte(112), CByte(117))
		btnUbah.FlatAppearance.BorderSize = 0
		btnUbah.FlatStyle = FlatStyle.Flat
		btnUbah.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		btnUbah.Location = New Point(130, 255)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(100, 30)
		btnUbah.TabIndex = 12
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
		btnHapus.FlatAppearance.BorderSize = 0
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		btnHapus.Location = New Point(20, 295)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(100, 30)
		btnHapus.TabIndex = 13
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
		btnBatal.FlatAppearance.BorderSize = 0
		btnBatal.FlatStyle = FlatStyle.Flat
		btnBatal.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		btnBatal.Location = New Point(130, 295)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(100, 30)
		btnBatal.TabIndex = 14
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' dgvPlaylist
		' 
		dgvPlaylist.AllowUserToAddRows = False
		dgvPlaylist.BackgroundColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		dgvPlaylist.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvPlaylist.Columns.AddRange(New DataGridViewColumn() {kodePlaylist, namaPlaylist, deskripsi, tanggalDibuat})
		dgvPlaylist.GridColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		dgvPlaylist.Location = New Point(320, 45)
		dgvPlaylist.Name = "dgvPlaylist"
		dgvPlaylist.ReadOnly = True
		dgvPlaylist.RowHeadersWidth = 51
		dgvPlaylist.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvPlaylist.Size = New Size(560, 445)
		dgvPlaylist.TabIndex = 15
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' btnDetail
		' 
		btnDetail.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		btnDetail.Cursor = Cursors.Hand
		btnDetail.FlatAppearance.BorderColor = Color.FromArgb(CByte(10), CByte(112), CByte(117))
		btnDetail.FlatStyle = FlatStyle.Flat
		btnDetail.ForeColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		btnDetail.Location = New Point(20, 340)
		btnDetail.Name = "btnDetail"
		btnDetail.Size = New Size(210, 30)
		btnDetail.TabIndex = 16
		btnDetail.Text = "Detail Playlist"
		btnDetail.UseVisualStyleBackColor = False
		' 
		' kodePlaylist
		' 
		kodePlaylist.DataPropertyName = "kodePlaylist"
		DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle1.SelectionForeColor = Color.White
		kodePlaylist.DefaultCellStyle = DataGridViewCellStyle1
		kodePlaylist.HeaderText = "Kode"
		kodePlaylist.MinimumWidth = 6
		kodePlaylist.Name = "kodePlaylist"
		kodePlaylist.ReadOnly = True
		kodePlaylist.Width = 70
		' 
		' namaPlaylist
		' 
		namaPlaylist.DataPropertyName = "namaPlaylist"
		DataGridViewCellStyle2.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle2.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle2.SelectionForeColor = Color.White
		namaPlaylist.DefaultCellStyle = DataGridViewCellStyle2
		namaPlaylist.HeaderText = "Nama Playlist"
		namaPlaylist.MinimumWidth = 6
		namaPlaylist.Name = "namaPlaylist"
		namaPlaylist.ReadOnly = True
		namaPlaylist.Width = 200
		' 
		' deskripsi
		' 
		deskripsi.DataPropertyName = "deskripsi"
		DataGridViewCellStyle3.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle3.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle3.SelectionForeColor = Color.White
		deskripsi.DefaultCellStyle = DataGridViewCellStyle3
		deskripsi.HeaderText = "Deskripsi"
		deskripsi.MinimumWidth = 6
		deskripsi.Name = "deskripsi"
		deskripsi.ReadOnly = True
		deskripsi.Width = 200
		' 
		' tanggalDibuat
		' 
		tanggalDibuat.DataPropertyName = "tanggalDibuat"
		DataGridViewCellStyle4.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle4.SelectionForeColor = Color.White
		tanggalDibuat.DefaultCellStyle = DataGridViewCellStyle4
		tanggalDibuat.HeaderText = "Tanggal Dibuat"
		tanggalDibuat.MinimumWidth = 6
		tanggalDibuat.Name = "tanggalDibuat"
		tanggalDibuat.ReadOnly = True
		tanggalDibuat.Width = 90
		' 
		' FormPlaylistManager
		' 
		AutoScaleDimensions = New SizeF(9F, 17F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		ClientSize = New Size(882, 533)
		Controls.Add(btnDetail)
		Controls.Add(dgvPlaylist)
		Controls.Add(btnBatal)
		Controls.Add(btnHapus)
		Controls.Add(btnUbah)
		Controls.Add(btnSimpan)
		Controls.Add(txtSearch)
		Controls.Add(lblCariJudul)
		Controls.Add(txtDeskripsi)
		Controls.Add(lblDescJudul)
		Controls.Add(dtpTanggal)
		Controls.Add(lblTglJudul)
		Controls.Add(txtNamaPlaylist)
		Controls.Add(lblNamaJudul)
		Controls.Add(txtKodePlaylist)
		Controls.Add(lblKodeJudul)
		Controls.Add(MenuStrip1)
		Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		MainMenuStrip = MenuStrip1
		MinimumSize = New Size(900, 580)
		Name = "FormPlaylistManager"
		StartPosition = FormStartPosition.CenterScreen
		Text = "SoundVault — Kelola Playlist"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(dgvPlaylist, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents mnuDataLagu As ToolStripMenuItem
	Friend WithEvents lblKodeJudul As Label
	Friend WithEvents txtKodePlaylist As TextBox
	Friend WithEvents lblNamaJudul As Label
	Friend WithEvents txtNamaPlaylist As TextBox
	Friend WithEvents lblTglJudul As Label
	Friend WithEvents dtpTanggal As DateTimePicker
	Friend WithEvents lblDescJudul As Label
	Friend WithEvents txtDeskripsi As TextBox
	Friend WithEvents lblCariJudul As Label
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents btnSimpan As Button
	Friend WithEvents btnUbah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents btnBatal As Button
	Friend WithEvents dgvPlaylist As DataGridView
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents btnDetail As Button
	Friend WithEvents kodePlaylist As DataGridViewTextBoxColumn
	Friend WithEvents namaPlaylist As DataGridViewTextBoxColumn
	Friend WithEvents deskripsi As DataGridViewTextBoxColumn
	Friend WithEvents tanggalDibuat As DataGridViewTextBoxColumn
End Class
