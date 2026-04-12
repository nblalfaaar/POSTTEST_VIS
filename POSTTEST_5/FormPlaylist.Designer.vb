<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormPlaylist
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
		components = New ComponentModel.Container()
		Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
		MenuStrip1 = New MenuStrip()
		mnuFile = New ToolStripMenuItem()
		mnuDataLagu = New ToolStripMenuItem()
		lblKodeJudul = New Label()
		txtKodeLagu = New TextBox()
		lblJudulJudul = New Label()
		txtJudulLagu = New TextBox()
		lblArtisJudul = New Label()
		txtArtis = New TextBox()
		lblGenreJudul = New Label()
		txtGenre = New TextBox()
		lblDurasiJudul = New Label()
		txtDurasi = New TextBox()
		lblCariJudul = New Label()
		txtSearch = New TextBox()
		btnSimpan = New Button()
		btnUbah = New Button()
		btnHapus = New Button()
		btnBatal = New Button()
		dgvLagu = New DataGridView()
		ErrorProvider1 = New ErrorProvider(components)
		btnDetail = New Button()
		lblLinkJudul = New Label()
		txtLink = New TextBox()
		MySqlCommand1 = New MySqlConnector.MySqlCommand()
		kodeLagu = New DataGridViewTextBoxColumn()
		judulLagu = New DataGridViewTextBoxColumn()
		artis = New DataGridViewTextBoxColumn()
		genre = New DataGridViewTextBoxColumn()
		durasi = New DataGridViewTextBoxColumn()
		linkSpotify = New DataGridViewTextBoxColumn()
		MenuStrip1.SuspendLayout()
		CType(dgvLagu, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.Font = New Font("Calisto MT", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {mnuFile, mnuDataLagu})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(882, 25)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' mnuFile
		' 
		mnuFile.Name = "mnuFile"
		mnuFile.Size = New Size(46, 21)
		mnuFile.Text = "File"
		' 
		' mnuDataLagu
		' 
		mnuDataLagu.Name = "mnuDataLagu"
		mnuDataLagu.Size = New Size(97, 21)
		mnuDataLagu.Text = "Detail Lagu"
		' 
		' lblKodeJudul
		' 
		lblKodeJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblKodeJudul.Location = New Point(20, 55)
		lblKodeJudul.Name = "lblKodeJudul"
		lblKodeJudul.Size = New Size(90, 20)
		lblKodeJudul.TabIndex = 1
		lblKodeJudul.Text = "Kode Lagu"
		' 
		' txtKodeLagu
		' 
		txtKodeLagu.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtKodeLagu.BorderStyle = BorderStyle.FixedSingle
		txtKodeLagu.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtKodeLagu.Location = New Point(115, 52)
		txtKodeLagu.Name = "txtKodeLagu"
		txtKodeLagu.Size = New Size(150, 25)
		txtKodeLagu.TabIndex = 2
		' 
		' lblJudulJudul
		' 
		lblJudulJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblJudulJudul.Location = New Point(20, 85)
		lblJudulJudul.Name = "lblJudulJudul"
		lblJudulJudul.Size = New Size(90, 20)
		lblJudulJudul.TabIndex = 3
		lblJudulJudul.Text = "Judul lagu"
		' 
		' txtJudulLagu
		' 
		txtJudulLagu.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtJudulLagu.BorderStyle = BorderStyle.FixedSingle
		txtJudulLagu.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtJudulLagu.Location = New Point(115, 82)
		txtJudulLagu.Name = "txtJudulLagu"
		txtJudulLagu.Size = New Size(180, 25)
		txtJudulLagu.TabIndex = 4
		' 
		' lblArtisJudul
		' 
		lblArtisJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblArtisJudul.Location = New Point(20, 115)
		lblArtisJudul.Name = "lblArtisJudul"
		lblArtisJudul.Size = New Size(90, 20)
		lblArtisJudul.TabIndex = 5
		lblArtisJudul.Text = "Artis"
		' 
		' txtArtis
		' 
		txtArtis.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtArtis.BorderStyle = BorderStyle.FixedSingle
		txtArtis.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtArtis.Location = New Point(115, 112)
		txtArtis.Name = "txtArtis"
		txtArtis.Size = New Size(180, 25)
		txtArtis.TabIndex = 6
		' 
		' lblGenreJudul
		' 
		lblGenreJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblGenreJudul.Location = New Point(20, 145)
		lblGenreJudul.Name = "lblGenreJudul"
		lblGenreJudul.Size = New Size(90, 20)
		lblGenreJudul.TabIndex = 7
		lblGenreJudul.Text = "Genre"
		' 
		' txtGenre
		' 
		txtGenre.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtGenre.BorderStyle = BorderStyle.FixedSingle
		txtGenre.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtGenre.Location = New Point(115, 142)
		txtGenre.Name = "txtGenre"
		txtGenre.Size = New Size(120, 25)
		txtGenre.TabIndex = 8
		' 
		' lblDurasiJudul
		' 
		lblDurasiJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblDurasiJudul.Location = New Point(20, 175)
		lblDurasiJudul.Name = "lblDurasiJudul"
		lblDurasiJudul.Size = New Size(90, 20)
		lblDurasiJudul.TabIndex = 9
		lblDurasiJudul.Text = "Durasi"
		' 
		' txtDurasi
		' 
		txtDurasi.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtDurasi.BorderStyle = BorderStyle.FixedSingle
		txtDurasi.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtDurasi.Location = New Point(115, 172)
		txtDurasi.Name = "txtDurasi"
		txtDurasi.PlaceholderText = "0:00"
		txtDurasi.Size = New Size(80, 25)
		txtDurasi.TabIndex = 10
		' 
		' lblCariJudul
		' 
		lblCariJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblCariJudul.Location = New Point(20, 245)
		lblCariJudul.Name = "lblCariJudul"
		lblCariJudul.Size = New Size(90, 20)
		lblCariJudul.TabIndex = 11
		lblCariJudul.Text = "Cari Data"
		' 
		' txtSearch
		' 
		txtSearch.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtSearch.BorderStyle = BorderStyle.FixedSingle
		txtSearch.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtSearch.Location = New Point(115, 242)
		txtSearch.Name = "txtSearch"
		txtSearch.PlaceholderText = "kode, judul, artis, genre..."
		txtSearch.Size = New Size(180, 25)
		txtSearch.TabIndex = 12
		' 
		' btnSimpan
		' 
		btnSimpan.BackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		btnSimpan.FlatAppearance.BorderSize = 0
		btnSimpan.FlatStyle = FlatStyle.Flat
		btnSimpan.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSimpan.ForeColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		btnSimpan.Location = New Point(20, 285)
		btnSimpan.Name = "btnSimpan"
		btnSimpan.Size = New Size(100, 30)
		btnSimpan.TabIndex = 13
		btnSimpan.Text = "Simpan"
		btnSimpan.UseVisualStyleBackColor = False
		' 
		' btnUbah
		' 
		btnUbah.BackColor = Color.FromArgb(CByte(10), CByte(112), CByte(117))
		btnUbah.FlatAppearance.BorderSize = 0
		btnUbah.FlatStyle = FlatStyle.Flat
		btnUbah.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnUbah.Location = New Point(130, 285)
		btnUbah.Name = "btnUbah"
		btnUbah.Size = New Size(100, 30)
		btnUbah.TabIndex = 14
		btnUbah.Text = "Ubah"
		btnUbah.UseVisualStyleBackColor = False
		' 
		' btnHapus
		' 
		btnHapus.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
		btnHapus.FlatAppearance.BorderSize = 0
		btnHapus.FlatStyle = FlatStyle.Flat
		btnHapus.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnHapus.Location = New Point(20, 325)
		btnHapus.Name = "btnHapus"
		btnHapus.Size = New Size(100, 30)
		btnHapus.TabIndex = 15
		btnHapus.Text = "Hapus"
		btnHapus.UseVisualStyleBackColor = False
		' 
		' btnBatal
		' 
		btnBatal.BackColor = Color.FromArgb(CByte(192), CByte(0), CByte(0))
		btnBatal.FlatAppearance.BorderSize = 0
		btnBatal.FlatStyle = FlatStyle.Flat
		btnBatal.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnBatal.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		btnBatal.Location = New Point(130, 325)
		btnBatal.Name = "btnBatal"
		btnBatal.Size = New Size(100, 30)
		btnBatal.TabIndex = 16
		btnBatal.Text = "Batal"
		btnBatal.UseVisualStyleBackColor = False
		' 
		' dgvLagu
		' 
		dgvLagu.AllowUserToAddRows = False
		dgvLagu.BackgroundColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		dgvLagu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvLagu.Columns.AddRange(New DataGridViewColumn() {kodeLagu, judulLagu, artis, genre, durasi, linkSpotify})
		DataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft
		DataGridViewCellStyle1.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle1.Font = New Font("Calisto MT", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		DataGridViewCellStyle1.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle1.SelectionForeColor = Color.White
		DataGridViewCellStyle1.WrapMode = DataGridViewTriState.False
		dgvLagu.DefaultCellStyle = DataGridViewCellStyle1
		dgvLagu.GridColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		dgvLagu.Location = New Point(310, 45)
		dgvLagu.Name = "dgvLagu"
		dgvLagu.ReadOnly = True
		dgvLagu.RowHeadersWidth = 51
		dgvLagu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvLagu.Size = New Size(560, 445)
		dgvLagu.TabIndex = 17
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
		btnDetail.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnDetail.ForeColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		btnDetail.Location = New Point(20, 370)
		btnDetail.Name = "btnDetail"
		btnDetail.Size = New Size(210, 30)
		btnDetail.TabIndex = 18
		btnDetail.Text = "Detail"
		btnDetail.UseVisualStyleBackColor = False
		' 
		' lblLinkJudul
		' 
		lblLinkJudul.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblLinkJudul.Location = New Point(20, 205)
		lblLinkJudul.Name = "lblLinkJudul"
		lblLinkJudul.Size = New Size(90, 20)
		lblLinkJudul.TabIndex = 19
		lblLinkJudul.Text = "Link Spotify"
		' 
		' txtLink
		' 
		txtLink.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		txtLink.BorderStyle = BorderStyle.FixedSingle
		txtLink.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		txtLink.Location = New Point(115, 202)
		txtLink.Name = "txtLink"
		txtLink.Size = New Size(180, 25)
		txtLink.TabIndex = 20
		' 
		' MySqlCommand1
		' 
		MySqlCommand1.CommandTimeout = 0
		MySqlCommand1.Connection = Nothing
		MySqlCommand1.Transaction = Nothing
		MySqlCommand1.UpdatedRowSource = UpdateRowSource.None
		' 
		' kodeLagu
		' 
		kodeLagu.DataPropertyName = "kodeLagu"
		kodeLagu.HeaderText = "Kode"
		kodeLagu.MinimumWidth = 6
		kodeLagu.Name = "kodeLagu"
		kodeLagu.ReadOnly = True
		kodeLagu.Width = 70
		' 
		' judulLagu
		' 
		judulLagu.DataPropertyName = "judulLagu"
		judulLagu.HeaderText = "Judul Lagu"
		judulLagu.MinimumWidth = 6
		judulLagu.Name = "judulLagu"
		judulLagu.ReadOnly = True
		judulLagu.Width = 125
		' 
		' artis
		' 
		artis.DataPropertyName = "artis"
		artis.HeaderText = "Artis"
		artis.MinimumWidth = 6
		artis.Name = "artis"
		artis.ReadOnly = True
		artis.Width = 150
		' 
		' genre
		' 
		genre.DataPropertyName = "genre"
		genre.HeaderText = "Genre"
		genre.MinimumWidth = 6
		genre.Name = "genre"
		genre.ReadOnly = True
		genre.Width = 90
		' 
		' durasi
		' 
		durasi.DataPropertyName = "durasi"
		durasi.HeaderText = "Durasi"
		durasi.MinimumWidth = 6
		durasi.Name = "durasi"
		durasi.ReadOnly = True
		durasi.Width = 70
		' 
		' linkSpotify
		' 
		linkSpotify.DataPropertyName = "linkSpotify"
		linkSpotify.HeaderText = "Link Spotify"
		linkSpotify.MinimumWidth = 6
		linkSpotify.Name = "linkSpotify"
		linkSpotify.ReadOnly = True
		linkSpotify.Width = 125
		' 
		' FormPlaylist
		' 
		AutoScaleDimensions = New SizeF(9.0F, 17.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		ClientSize = New Size(882, 533)
		Controls.Add(txtLink)
		Controls.Add(lblLinkJudul)
		Controls.Add(btnDetail)
		Controls.Add(dgvLagu)
		Controls.Add(btnBatal)
		Controls.Add(btnHapus)
		Controls.Add(btnUbah)
		Controls.Add(btnSimpan)
		Controls.Add(txtSearch)
		Controls.Add(lblCariJudul)
		Controls.Add(txtDurasi)
		Controls.Add(lblDurasiJudul)
		Controls.Add(txtGenre)
		Controls.Add(lblGenreJudul)
		Controls.Add(txtArtis)
		Controls.Add(lblArtisJudul)
		Controls.Add(txtJudulLagu)
		Controls.Add(lblJudulJudul)
		Controls.Add(txtKodeLagu)
		Controls.Add(lblKodeJudul)
		Controls.Add(MenuStrip1)
		Font = New Font("Calisto MT", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		MainMenuStrip = MenuStrip1
		MinimumSize = New Size(900, 580)
		Name = "FormPlaylist"
		StartPosition = FormStartPosition.CenterScreen
		Text = "SoundVault — Manajemen Playlist"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		CType(dgvLagu, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents mnuFile As ToolStripMenuItem
	Friend WithEvents mnuDataLagu As ToolStripMenuItem
	Friend WithEvents lblKodeJudul As Label
	Friend WithEvents txtKodeLagu As TextBox
	Friend WithEvents lblJudulJudul As Label
	Friend WithEvents txtJudulLagu As TextBox
	Friend WithEvents lblArtisJudul As Label
	Friend WithEvents txtArtis As TextBox
	Friend WithEvents lblGenreJudul As Label
	Friend WithEvents txtGenre As TextBox
	Friend WithEvents lblDurasiJudul As Label
	Friend WithEvents txtDurasi As TextBox
	Friend WithEvents lblCariJudul As Label
	Friend WithEvents txtSearch As TextBox
	Friend WithEvents btnSimpan As Button
	Friend WithEvents btnUbah As Button
	Friend WithEvents btnHapus As Button
	Friend WithEvents btnBatal As Button
	Friend WithEvents dgvLagu As DataGridView
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents btnDetail As Button
	Friend WithEvents lblLinkJudul As Label
	Friend WithEvents txtLink As TextBox
	Friend WithEvents MySqlCommand1 As MySqlConnector.MySqlCommand
	Friend WithEvents kodeLagu As DataGridViewTextBoxColumn
	Friend WithEvents judulLagu As DataGridViewTextBoxColumn
	Friend WithEvents artis As DataGridViewTextBoxColumn
	Friend WithEvents genre As DataGridViewTextBoxColumn
	Friend WithEvents durasi As DataGridViewTextBoxColumn
	Friend WithEvents linkSpotify As DataGridViewTextBoxColumn

End Class
