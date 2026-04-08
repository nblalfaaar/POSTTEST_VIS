<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormInput
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
		MenuStrip1 = New MenuStrip()
		mnuInputData = New ToolStripMenuItem()
		mnuLihatKartu = New ToolStripMenuItem()
		mnuSimpanData = New ToolStripMenuItem()
		mnuBukaData = New ToolStripMenuItem()
		mnuKeluar = New ToolStripMenuItem()
		pnlHeader = New Panel()
		lblSubJudul = New Label()
		picLogo = New PictureBox()
		lblJudul = New Label()
		pnlAksen = New Panel()
		TabControl1 = New TabControl()
		tcDataUtama = New TabPage()
		btnLanjut1 = New Button()
		cboKomunitas = New ComboBox()
		Label6 = New Label()
		rbPerempuan = New RadioButton()
		rbLakiLaki = New RadioButton()
		Label5 = New Label()
		dtpTglLahir = New DateTimePicker()
		Label4 = New Label()
		txtIdAnggota = New TextBox()
		txtNama = New TextBox()
		Label3 = New Label()
		Label2 = New Label()
		Label1 = New Label()
		tcKontakInfo = New TabPage()
		btnLanjut2 = New Button()
		btnKembali2 = New Button()
		txtAlamat = New TextBox()
		Label10 = New Label()
		txtEmail = New TextBox()
		Label9 = New Label()
		mtxtTelepon = New MaskedTextBox()
		Label8 = New Label()
		Label7 = New Label()
		tcProfilAktivitas = New TabPage()
		btnReset = New Button()
		btnKembali3 = New Button()
		btnSimpanCetak = New Button()
		grpAktivitas = New GroupBox()
		chkOlahraga = New CheckBox()
		chkRiset = New CheckBox()
		chkTulis = New CheckBox()
		chkDesain = New CheckBox()
		chkFotografi = New CheckBox()
		chkMusik = New CheckBox()
		chkCoding = New CheckBox()
		chkBaca = New CheckBox()
		grpPeran = New GroupBox()
		rbAnggota = New RadioButton()
		rbAdmin = New RadioButton()
		rbBendahara = New RadioButton()
		rbSekretaris = New RadioButton()
		rbWakil = New RadioButton()
		rbKetua = New RadioButton()
		lblFotoHint = New Label()
		btnBrowseFoto = New Button()
		picFotoProfil = New PictureBox()
		Label11 = New Label()
		ErrorProvider1 = New ErrorProvider(components)
		OpenFileDialog1 = New OpenFileDialog()
		SaveFileDialog1 = New SaveFileDialog()
		OpenFileDialog2 = New OpenFileDialog()
		MenuStrip1.SuspendLayout()
		pnlHeader.SuspendLayout()
		CType(picLogo, ComponentModel.ISupportInitialize).BeginInit()
		TabControl1.SuspendLayout()
		tcDataUtama.SuspendLayout()
		tcKontakInfo.SuspendLayout()
		tcProfilAktivitas.SuspendLayout()
		grpAktivitas.SuspendLayout()
		grpPeran.SuspendLayout()
		CType(picFotoProfil, ComponentModel.ISupportInitialize).BeginInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' MenuStrip1
		' 
		MenuStrip1.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		MenuStrip1.Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		MenuStrip1.ImageScalingSize = New Size(20, 20)
		MenuStrip1.Items.AddRange(New ToolStripItem() {mnuInputData, mnuLihatKartu, mnuSimpanData, mnuBukaData, mnuKeluar})
		MenuStrip1.Location = New Point(0, 0)
		MenuStrip1.Name = "MenuStrip1"
		MenuStrip1.Size = New Size(762, 25)
		MenuStrip1.TabIndex = 0
		MenuStrip1.Text = "MenuStrip1"
		' 
		' mnuInputData
		' 
		mnuInputData.ForeColor = Color.White
		mnuInputData.Name = "mnuInputData"
		mnuInputData.Size = New Size(91, 21)
		mnuInputData.Text = "Input Data"
		' 
		' mnuLihatKartu
		' 
		mnuLihatKartu.ForeColor = Color.White
		mnuLihatKartu.Name = "mnuLihatKartu"
		mnuLihatKartu.Size = New Size(101, 21)
		mnuLihatKartu.Text = " Lihat Kartu"
		' 
		' mnuSimpanData
		' 
		mnuSimpanData.ForeColor = Color.White
		mnuSimpanData.Name = "mnuSimpanData"
		mnuSimpanData.Size = New Size(105, 21)
		mnuSimpanData.Text = "Simpan Data"
		' 
		' mnuBukaData
		' 
		mnuBukaData.ForeColor = Color.White
		mnuBukaData.Name = "mnuBukaData"
		mnuBukaData.Size = New Size(90, 21)
		mnuBukaData.Text = "Buka Data"
		' 
		' mnuKeluar
		' 
		mnuKeluar.ForeColor = Color.White
		mnuKeluar.Name = "mnuKeluar"
		mnuKeluar.Size = New Size(65, 21)
		mnuKeluar.Text = "Keluar"
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		pnlHeader.Controls.Add(lblSubJudul)
		pnlHeader.Controls.Add(picLogo)
		pnlHeader.Controls.Add(lblJudul)
		pnlHeader.Location = New Point(0, 24)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(780, 70)
		pnlHeader.TabIndex = 1
		' 
		' lblSubJudul
		' 
		lblSubJudul.AutoSize = True
		lblSubJudul.ForeColor = Color.FromArgb(CByte(159), CByte(200), CByte(240))
		lblSubJudul.Location = New Point(68, 40)
		lblSubJudul.Name = "lblSubJudul"
		lblSubJudul.Size = New Size(340, 17)
		lblSubJudul.TabIndex = 3
		lblSubJudul.Text = "Sistem Pembuatan Kartu Komunitas Digital Spotify"
		' 
		' picLogo
		' 
		picLogo.BackColor = Color.FromArgb(CByte(74), CByte(144), CByte(217))
		picLogo.Image = My.Resources.Resources.IMGBIN_com___Download_Transparent_PNG_Images__For_Free_removebg_preview
		picLogo.Location = New Point(16, 11)
		picLogo.Name = "picLogo"
		picLogo.Size = New Size(46, 46)
		picLogo.SizeMode = PictureBoxSizeMode.Zoom
		picLogo.TabIndex = 2
		picLogo.TabStop = False
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.Font = New Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudul.ForeColor = Color.White
		lblJudul.Location = New Point(68, 11)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(103, 22)
		lblJudul.TabIndex = 2
		lblJudul.Text = "SpotifyKu"
		' 
		' pnlAksen
		' 
		pnlAksen.BackColor = Color.FromArgb(CByte(74), CByte(144), CByte(217))
		pnlAksen.Location = New Point(0, 94)
		pnlAksen.Name = "pnlAksen"
		pnlAksen.Size = New Size(780, 5)
		pnlAksen.TabIndex = 2
		' 
		' TabControl1
		' 
		TabControl1.Controls.Add(tcDataUtama)
		TabControl1.Controls.Add(tcKontakInfo)
		TabControl1.Controls.Add(tcProfilAktivitas)
		TabControl1.Location = New Point(10, 104)
		TabControl1.Name = "TabControl1"
		TabControl1.SelectedIndex = 0
		TabControl1.Size = New Size(756, 462)
		TabControl1.TabIndex = 3
		' 
		' tcDataUtama
		' 
		tcDataUtama.Controls.Add(btnLanjut1)
		tcDataUtama.Controls.Add(cboKomunitas)
		tcDataUtama.Controls.Add(Label6)
		tcDataUtama.Controls.Add(rbPerempuan)
		tcDataUtama.Controls.Add(rbLakiLaki)
		tcDataUtama.Controls.Add(Label5)
		tcDataUtama.Controls.Add(dtpTglLahir)
		tcDataUtama.Controls.Add(Label4)
		tcDataUtama.Controls.Add(txtIdAnggota)
		tcDataUtama.Controls.Add(txtNama)
		tcDataUtama.Controls.Add(Label3)
		tcDataUtama.Controls.Add(Label2)
		tcDataUtama.Controls.Add(Label1)
		tcDataUtama.Location = New Point(4, 26)
		tcDataUtama.Name = "tcDataUtama"
		tcDataUtama.Padding = New Padding(3)
		tcDataUtama.Size = New Size(748, 432)
		tcDataUtama.TabIndex = 0
		tcDataUtama.Text = "Data Utama"
		tcDataUtama.UseVisualStyleBackColor = True
		' 
		' btnLanjut1
		' 
		btnLanjut1.BackColor = Color.FromArgb(CByte(30), CByte(95), CByte(165))
		btnLanjut1.Cursor = Cursors.Hand
		btnLanjut1.FlatAppearance.BorderSize = 0
		btnLanjut1.FlatStyle = FlatStyle.Flat
		btnLanjut1.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnLanjut1.ForeColor = Color.White
		btnLanjut1.Location = New Point(630, 390)
		btnLanjut1.Name = "btnLanjut1"
		btnLanjut1.Size = New Size(110, 34)
		btnLanjut1.TabIndex = 12
		btnLanjut1.Text = "Lanjut >"
		btnLanjut1.UseVisualStyleBackColor = False
		' 
		' cboKomunitas
		' 
		cboKomunitas.BackColor = Color.White
		cboKomunitas.DropDownStyle = ComboBoxStyle.DropDownList
		cboKomunitas.FormattingEnabled = True
		cboKomunitas.Items.AddRange(New Object() {"K-Pop Fans", "", "Pop Lovers", "", "Indie Music", "", "Jazz Community", "", "Hip-Hop Fans", "", "Podcast Listener", "", "Playlist Curator", "", "Music Editor"})
		cboKomunitas.Location = New Point(16, 258)
		cboKomunitas.Name = "cboKomunitas"
		cboKomunitas.Size = New Size(340, 25)
		cboKomunitas.TabIndex = 11
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label6.Location = New Point(16, 240)
		Label6.Name = "Label6"
		Label6.Size = New Size(130, 17)
		Label6.TabIndex = 10
		Label6.Text = "Jenis Komunitas  *"
		' 
		' rbPerempuan
		' 
		rbPerempuan.AutoSize = True
		rbPerempuan.Location = New Point(130, 200)
		rbPerempuan.Name = "rbPerempuan"
		rbPerempuan.Size = New Size(101, 21)
		rbPerempuan.TabIndex = 9
		rbPerempuan.Text = "Perempuan"
		rbPerempuan.UseVisualStyleBackColor = True
		' 
		' rbLakiLaki
		' 
		rbLakiLaki.AutoSize = True
		rbLakiLaki.Location = New Point(16, 200)
		rbLakiLaki.Name = "rbLakiLaki"
		rbLakiLaki.Size = New Size(85, 21)
		rbLakiLaki.TabIndex = 8
		rbLakiLaki.Text = "Laki-laki"
		rbLakiLaki.UseVisualStyleBackColor = True
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label5.Location = New Point(16, 180)
		Label5.Name = "Label5"
		Label5.Size = New Size(99, 17)
		Label5.TabIndex = 7
		Label5.Text = "Jenis Kelamin"
		' 
		' dtpTglLahir
		' 
		dtpTglLahir.Location = New Point(16, 133)
		dtpTglLahir.Name = "dtpTglLahir"
		dtpTglLahir.Size = New Size(280, 25)
		dtpTglLahir.TabIndex = 6
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label4.Location = New Point(16, 115)
		Label4.Name = "Label4"
		Label4.Size = New Size(96, 17)
		Label4.TabIndex = 5
		Label4.Text = "Tanggal Lahir"
		' 
		' txtIdAnggota
		' 
		txtIdAnggota.BackColor = Color.White
		txtIdAnggota.Location = New Point(380, 68)
		txtIdAnggota.Name = "txtIdAnggota"
		txtIdAnggota.Size = New Size(330, 25)
		txtIdAnggota.TabIndex = 4
		' 
		' txtNama
		' 
		txtNama.BackColor = Color.White
		txtNama.Location = New Point(16, 68)
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(340, 25)
		txtNama.TabIndex = 3
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label3.Location = New Point(380, 50)
		Label3.Name = "Label3"
		Label3.Size = New Size(94, 17)
		Label3.TabIndex = 2
		Label3.Text = "ID Anggota *"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label2.Location = New Point(16, 50)
		Label2.Name = "Label2"
		Label2.Size = New Size(117, 17)
		Label2.TabIndex = 1
		Label2.Text = "Nama Lengkap *"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.Font = New Font("Calisto MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		Label1.Location = New Point(16, 14)
		Label1.Name = "Label1"
		Label1.Size = New Size(166, 20)
		Label1.TabIndex = 0
		Label1.Text = "Data Utama Anggota"
		' 
		' tcKontakInfo
		' 
		tcKontakInfo.Controls.Add(btnLanjut2)
		tcKontakInfo.Controls.Add(btnKembali2)
		tcKontakInfo.Controls.Add(txtAlamat)
		tcKontakInfo.Controls.Add(Label10)
		tcKontakInfo.Controls.Add(txtEmail)
		tcKontakInfo.Controls.Add(Label9)
		tcKontakInfo.Controls.Add(mtxtTelepon)
		tcKontakInfo.Controls.Add(Label8)
		tcKontakInfo.Controls.Add(Label7)
		tcKontakInfo.Location = New Point(4, 29)
		tcKontakInfo.Name = "tcKontakInfo"
		tcKontakInfo.Padding = New Padding(3)
		tcKontakInfo.Size = New Size(748, 429)
		tcKontakInfo.TabIndex = 1
		tcKontakInfo.Text = "Kontak & Info"
		tcKontakInfo.UseVisualStyleBackColor = True
		' 
		' btnLanjut2
		' 
		btnLanjut2.BackColor = Color.FromArgb(CByte(30), CByte(95), CByte(165))
		btnLanjut2.Cursor = Cursors.Hand
		btnLanjut2.FlatAppearance.BorderSize = 0
		btnLanjut2.FlatStyle = FlatStyle.Flat
		btnLanjut2.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnLanjut2.ForeColor = Color.White
		btnLanjut2.Location = New Point(630, 390)
		btnLanjut2.Name = "btnLanjut2"
		btnLanjut2.Size = New Size(110, 34)
		btnLanjut2.TabIndex = 8
		btnLanjut2.Text = "Lanjut >"
		btnLanjut2.UseVisualStyleBackColor = False
		' 
		' btnKembali2
		' 
		btnKembali2.BackColor = Color.FromArgb(CByte(96), CByte(104), CByte(120))
		btnKembali2.Cursor = Cursors.Hand
		btnKembali2.FlatAppearance.BorderSize = 0
		btnKembali2.FlatStyle = FlatStyle.Flat
		btnKembali2.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnKembali2.ForeColor = Color.White
		btnKembali2.Location = New Point(510, 390)
		btnKembali2.Name = "btnKembali2"
		btnKembali2.Size = New Size(110, 34)
		btnKembali2.TabIndex = 7
		btnKembali2.Text = "< Kembali"
		btnKembali2.UseVisualStyleBackColor = False
		' 
		' txtAlamat
		' 
		txtAlamat.BackColor = Color.White
		txtAlamat.Location = New Point(16, 196)
		txtAlamat.Multiline = True
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(700, 70)
		txtAlamat.TabIndex = 6
		' 
		' Label10
		' 
		Label10.AutoSize = True
		Label10.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label10.Location = New Point(16, 178)
		Label10.Name = "Label10"
		Label10.Size = New Size(67, 17)
		Label10.TabIndex = 5
		Label10.Text = "Alamat *"
		' 
		' txtEmail
		' 
		txtEmail.BackColor = Color.White
		txtEmail.Location = New Point(16, 133)
		txtEmail.Name = "txtEmail"
		txtEmail.Size = New Size(380, 25)
		txtEmail.TabIndex = 4
		' 
		' Label9
		' 
		Label9.AutoSize = True
		Label9.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label9.Location = New Point(16, 115)
		Label9.Name = "Label9"
		Label9.Size = New Size(57, 17)
		Label9.TabIndex = 3
		Label9.Text = "Email *"
		' 
		' mtxtTelepon
		' 
		mtxtTelepon.BackColor = Color.White
		mtxtTelepon.Location = New Point(16, 68)
		mtxtTelepon.Mask = "0000-0000-0000"
		mtxtTelepon.Name = "mtxtTelepon"
		mtxtTelepon.Size = New Size(240, 25)
		mtxtTelepon.TabIndex = 2
		' 
		' Label8
		' 
		Label8.AutoSize = True
		Label8.ForeColor = Color.FromArgb(CByte(85), CByte(85), CByte(85))
		Label8.Location = New Point(16, 50)
		Label8.Name = "Label8"
		Label8.Size = New Size(121, 17)
		Label8.TabIndex = 1
		Label8.Text = "Nomor Telepon *"
		' 
		' Label7
		' 
		Label7.AutoSize = True
		Label7.Font = New Font("Calisto MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label7.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		Label7.Location = New Point(16, 14)
		Label7.Name = "Label7"
		Label7.Size = New Size(129, 20)
		Label7.TabIndex = 0
		Label7.Text = "Kontak dan Info"
		' 
		' tcProfilAktivitas
		' 
		tcProfilAktivitas.Controls.Add(btnReset)
		tcProfilAktivitas.Controls.Add(btnKembali3)
		tcProfilAktivitas.Controls.Add(btnSimpanCetak)
		tcProfilAktivitas.Controls.Add(grpAktivitas)
		tcProfilAktivitas.Controls.Add(grpPeran)
		tcProfilAktivitas.Controls.Add(lblFotoHint)
		tcProfilAktivitas.Controls.Add(btnBrowseFoto)
		tcProfilAktivitas.Controls.Add(picFotoProfil)
		tcProfilAktivitas.Controls.Add(Label11)
		tcProfilAktivitas.Location = New Point(4, 29)
		tcProfilAktivitas.Name = "tcProfilAktivitas"
		tcProfilAktivitas.Padding = New Padding(3)
		tcProfilAktivitas.Size = New Size(748, 429)
		tcProfilAktivitas.TabIndex = 2
		tcProfilAktivitas.Text = "Profil & Aktivitas"
		tcProfilAktivitas.UseVisualStyleBackColor = True
		' 
		' btnReset
		' 
		btnReset.BackColor = Color.FromArgb(CByte(176), CByte(48), CByte(48))
		btnReset.Cursor = Cursors.Hand
		btnReset.FlatAppearance.BorderSize = 0
		btnReset.FlatStyle = FlatStyle.Flat
		btnReset.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnReset.ForeColor = Color.White
		btnReset.Location = New Point(16, 360)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(90, 34)
		btnReset.TabIndex = 8
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = False
		' 
		' btnKembali3
		' 
		btnKembali3.BackColor = Color.FromArgb(CByte(96), CByte(104), CByte(120))
		btnKembali3.Cursor = Cursors.Hand
		btnKembali3.FlatAppearance.BorderSize = 0
		btnKembali3.FlatStyle = FlatStyle.Flat
		btnKembali3.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnKembali3.ForeColor = Color.White
		btnKembali3.Location = New Point(455, 360)
		btnKembali3.Name = "btnKembali3"
		btnKembali3.Size = New Size(110, 34)
		btnKembali3.TabIndex = 7
		btnKembali3.Text = "< Kembali"
		btnKembali3.UseVisualStyleBackColor = False
		' 
		' btnSimpanCetak
		' 
		btnSimpanCetak.BackColor = Color.FromArgb(CByte(26), CByte(122), CByte(58))
		btnSimpanCetak.Cursor = Cursors.Hand
		btnSimpanCetak.FlatAppearance.BorderSize = 0
		btnSimpanCetak.FlatStyle = FlatStyle.Flat
		btnSimpanCetak.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSimpanCetak.ForeColor = Color.White
		btnSimpanCetak.Location = New Point(580, 360)
		btnSimpanCetak.Name = "btnSimpanCetak"
		btnSimpanCetak.Size = New Size(160, 34)
		btnSimpanCetak.TabIndex = 6
		btnSimpanCetak.Text = "Simpan dan Cetak"
		btnSimpanCetak.UseVisualStyleBackColor = False
		' 
		' grpAktivitas
		' 
		grpAktivitas.Controls.Add(chkOlahraga)
		grpAktivitas.Controls.Add(chkRiset)
		grpAktivitas.Controls.Add(chkTulis)
		grpAktivitas.Controls.Add(chkDesain)
		grpAktivitas.Controls.Add(chkFotografi)
		grpAktivitas.Controls.Add(chkMusik)
		grpAktivitas.Controls.Add(chkCoding)
		grpAktivitas.Controls.Add(chkBaca)
		grpAktivitas.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		grpAktivitas.Location = New Point(16, 230)
		grpAktivitas.Name = "grpAktivitas"
		grpAktivitas.Size = New Size(716, 90)
		grpAktivitas.TabIndex = 5
		grpAktivitas.TabStop = False
		grpAktivitas.Text = "Hobby / Aktivitas * (min. 1)"
		' 
		' chkOlahraga
		' 
		chkOlahraga.AutoSize = True
		chkOlahraga.Location = New Point(530, 54)
		chkOlahraga.Name = "chkOlahraga"
		chkOlahraga.Size = New Size(87, 21)
		chkOlahraga.TabIndex = 7
		chkOlahraga.Text = "Olahraga"
		chkOlahraga.UseVisualStyleBackColor = True
		' 
		' chkRiset
		' 
		chkRiset.AutoSize = True
		chkRiset.Location = New Point(370, 54)
		chkRiset.Name = "chkRiset"
		chkRiset.Size = New Size(63, 21)
		chkRiset.TabIndex = 6
		chkRiset.Text = "Riset"
		chkRiset.UseVisualStyleBackColor = True
		' 
		' chkTulis
		' 
		chkTulis.AutoSize = True
		chkTulis.Location = New Point(180, 54)
		chkTulis.Name = "chkTulis"
		chkTulis.Size = New Size(82, 21)
		chkTulis.TabIndex = 5
		chkTulis.Text = "Menulis"
		chkTulis.UseVisualStyleBackColor = True
		' 
		' chkDesain
		' 
		chkDesain.AutoSize = True
		chkDesain.Location = New Point(14, 54)
		chkDesain.Name = "chkDesain"
		chkDesain.Size = New Size(74, 21)
		chkDesain.TabIndex = 4
		chkDesain.Text = "Desain"
		chkDesain.UseVisualStyleBackColor = True
		' 
		' chkFotografi
		' 
		chkFotografi.AutoSize = True
		chkFotografi.Location = New Point(530, 24)
		chkFotografi.Name = "chkFotografi"
		chkFotografi.Size = New Size(88, 21)
		chkFotografi.TabIndex = 3
		chkFotografi.Text = "Fotografi"
		chkFotografi.UseVisualStyleBackColor = True
		' 
		' chkMusik
		' 
		chkMusik.AutoSize = True
		chkMusik.Location = New Point(370, 24)
		chkMusik.Name = "chkMusik"
		chkMusik.Size = New Size(71, 21)
		chkMusik.TabIndex = 2
		chkMusik.Text = "Musik"
		chkMusik.UseVisualStyleBackColor = True
		' 
		' chkCoding
		' 
		chkCoding.AutoSize = True
		chkCoding.Location = New Point(180, 24)
		chkCoding.Name = "chkCoding"
		chkCoding.Size = New Size(76, 21)
		chkCoding.TabIndex = 1
		chkCoding.Text = "Coding"
		chkCoding.UseVisualStyleBackColor = True
		' 
		' chkBaca
		' 
		chkBaca.AutoSize = True
		chkBaca.Location = New Point(14, 24)
		chkBaca.Name = "chkBaca"
		chkBaca.Size = New Size(94, 21)
		chkBaca.TabIndex = 0
		chkBaca.Text = "Membaca"
		chkBaca.UseVisualStyleBackColor = True
		' 
		' grpPeran
		' 
		grpPeran.BackColor = Color.Transparent
		grpPeran.Controls.Add(rbAnggota)
		grpPeran.Controls.Add(rbAdmin)
		grpPeran.Controls.Add(rbBendahara)
		grpPeran.Controls.Add(rbSekretaris)
		grpPeran.Controls.Add(rbWakil)
		grpPeran.Controls.Add(rbKetua)
		grpPeran.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		grpPeran.Location = New Point(122, 44)
		grpPeran.Name = "grpPeran"
		grpPeran.Size = New Size(610, 100)
		grpPeran.TabIndex = 4
		grpPeran.TabStop = False
		grpPeran.Text = "Peran dalam Komunitas"
		' 
		' rbAnggota
		' 
		rbAnggota.AutoSize = True
		rbAnggota.Location = New Point(200, 72)
		rbAnggota.Name = "rbAnggota"
		rbAnggota.Size = New Size(83, 21)
		rbAnggota.TabIndex = 5
		rbAnggota.TabStop = True
		rbAnggota.Text = "Anggota"
		rbAnggota.UseVisualStyleBackColor = True
		' 
		' rbAdmin
		' 
		rbAdmin.AutoSize = True
		rbAdmin.Location = New Point(200, 48)
		rbAdmin.Name = "rbAdmin"
		rbAdmin.Size = New Size(74, 21)
		rbAdmin.TabIndex = 4
		rbAdmin.TabStop = True
		rbAdmin.Text = "Admin"
		rbAdmin.UseVisualStyleBackColor = True
		' 
		' rbBendahara
		' 
		rbBendahara.AutoSize = True
		rbBendahara.Location = New Point(200, 24)
		rbBendahara.Name = "rbBendahara"
		rbBendahara.Size = New Size(96, 21)
		rbBendahara.TabIndex = 3
		rbBendahara.TabStop = True
		rbBendahara.Text = "Bendahara"
		rbBendahara.UseVisualStyleBackColor = True
		' 
		' rbSekretaris
		' 
		rbSekretaris.AutoSize = True
		rbSekretaris.Location = New Point(12, 72)
		rbSekretaris.Name = "rbSekretaris"
		rbSekretaris.Size = New Size(91, 21)
		rbSekretaris.TabIndex = 2
		rbSekretaris.TabStop = True
		rbSekretaris.Text = "Sekretaris"
		rbSekretaris.UseVisualStyleBackColor = True
		' 
		' rbWakil
		' 
		rbWakil.AutoSize = True
		rbWakil.Location = New Point(12, 48)
		rbWakil.Name = "rbWakil"
		rbWakil.Size = New Size(111, 21)
		rbWakil.TabIndex = 1
		rbWakil.TabStop = True
		rbWakil.Text = "Wakil Ketua"
		rbWakil.UseVisualStyleBackColor = True
		' 
		' rbKetua
		' 
		rbKetua.AutoSize = True
		rbKetua.Location = New Point(12, 24)
		rbKetua.Name = "rbKetua"
		rbKetua.Size = New Size(68, 21)
		rbKetua.TabIndex = 0
		rbKetua.TabStop = True
		rbKetua.Text = "Ketua"
		rbKetua.UseVisualStyleBackColor = True
		' 
		' lblFotoHint
		' 
		lblFotoHint.AutoSize = True
		lblFotoHint.Font = New Font("Calisto MT", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblFotoHint.ForeColor = Color.FromArgb(CByte(120), CByte(138), CByte(168))
		lblFotoHint.Location = New Point(16, 198)
		lblFotoHint.Name = "lblFotoHint"
		lblFotoHint.Size = New Size(90, 15)
		lblFotoHint.TabIndex = 3
		lblFotoHint.Text = "Belum ada foto"
		' 
		' btnBrowseFoto
		' 
		btnBrowseFoto.BackColor = Color.FromArgb(CByte(70), CByte(95), CByte(130))
		btnBrowseFoto.Cursor = Cursors.Hand
		btnBrowseFoto.FlatAppearance.BorderSize = 0
		btnBrowseFoto.FlatStyle = FlatStyle.Flat
		btnBrowseFoto.ForeColor = Color.White
		btnBrowseFoto.Location = New Point(16, 162)
		btnBrowseFoto.Name = "btnBrowseFoto"
		btnBrowseFoto.Size = New Size(90, 28)
		btnBrowseFoto.TabIndex = 2
		btnBrowseFoto.Text = "Browse"
		btnBrowseFoto.UseVisualStyleBackColor = False
		' 
		' picFotoProfil
		' 
		picFotoProfil.BackColor = Color.FromArgb(CByte(195), CByte(215), CByte(238))
		picFotoProfil.BorderStyle = BorderStyle.FixedSingle
		picFotoProfil.Location = New Point(16, 44)
		picFotoProfil.Name = "picFotoProfil"
		picFotoProfil.Size = New Size(90, 110)
		picFotoProfil.SizeMode = PictureBoxSizeMode.Zoom
		picFotoProfil.TabIndex = 1
		picFotoProfil.TabStop = False
		' 
		' Label11
		' 
		Label11.AutoSize = True
		Label11.Font = New Font("Calisto MT", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label11.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		Label11.Location = New Point(16, 14)
		Label11.Name = "Label11"
		Label11.Size = New Size(151, 20)
		Label11.TabIndex = 0
		Label11.Text = "Profil dan Aktivitas"
		' 
		' ErrorProvider1
		' 
		ErrorProvider1.ContainerControl = Me
		' 
		' OpenFileDialog1
		' 
		OpenFileDialog1.FileName = "OpenFileDialog1"
		' 
		' OpenFileDialog2
		' 
		OpenFileDialog2.FileName = "OpenFileDialog2"
		' 
		' FormInput
		' 
		AutoScaleDimensions = New SizeF(9F, 17F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(240), CByte(245), CByte(252))
		ClientSize = New Size(762, 563)
		Controls.Add(TabControl1)
		Controls.Add(pnlAksen)
		Controls.Add(pnlHeader)
		Controls.Add(MenuStrip1)
		Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		MainMenuStrip = MenuStrip1
		Name = "FormInput"
		StartPosition = FormStartPosition.CenterScreen
		Text = "SpotifyKu-Input Data Anggota"
		MenuStrip1.ResumeLayout(False)
		MenuStrip1.PerformLayout()
		pnlHeader.ResumeLayout(False)
		pnlHeader.PerformLayout()
		CType(picLogo, ComponentModel.ISupportInitialize).EndInit()
		TabControl1.ResumeLayout(False)
		tcDataUtama.ResumeLayout(False)
		tcDataUtama.PerformLayout()
		tcKontakInfo.ResumeLayout(False)
		tcKontakInfo.PerformLayout()
		tcProfilAktivitas.ResumeLayout(False)
		tcProfilAktivitas.PerformLayout()
		grpAktivitas.ResumeLayout(False)
		grpAktivitas.PerformLayout()
		grpPeran.ResumeLayout(False)
		grpPeran.PerformLayout()
		CType(picFotoProfil, ComponentModel.ISupportInitialize).EndInit()
		CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents MenuStrip1 As MenuStrip
	Friend WithEvents mnuInputData As ToolStripMenuItem
	Friend WithEvents mnuLihatKartu As ToolStripMenuItem
	Friend WithEvents mnuSimpanData As ToolStripMenuItem
	Friend WithEvents mnuBukaData As ToolStripMenuItem
	Friend WithEvents mnuKeluar As ToolStripMenuItem
	Friend WithEvents pnlHeader As Panel
	Friend WithEvents picLogo As PictureBox
	Friend WithEvents lblSubJudul As Label
	Friend WithEvents lblJudul As Label
	Friend WithEvents pnlAksen As Panel
	Friend WithEvents TabControl1 As TabControl
	Friend WithEvents tcDataUtama As TabPage
	Friend WithEvents tcKontakInfo As TabPage
	Friend WithEvents tcProfilAktivitas As TabPage
	Friend WithEvents ErrorProvider1 As ErrorProvider
	Friend WithEvents OpenFileDialog1 As OpenFileDialog
	Friend WithEvents SaveFileDialog1 As SaveFileDialog
	Friend WithEvents Label2 As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents txtNama As TextBox
	Friend WithEvents Label3 As Label
	Friend WithEvents txtIdAnggota As TextBox
	Friend WithEvents dtpTglLahir As DateTimePicker
	Friend WithEvents Label4 As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents cboKomunitas As ComboBox
	Friend WithEvents Label6 As Label
	Friend WithEvents rbPerempuan As RadioButton
	Friend WithEvents rbLakiLaki As RadioButton
	Friend WithEvents Label7 As Label
	Friend WithEvents Label9 As Label
	Friend WithEvents mtxtTelepon As MaskedTextBox
	Friend WithEvents Label8 As Label
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents Label10 As Label
	Friend WithEvents txtEmail As TextBox
	Friend WithEvents btnBrowseFoto As Button
	Friend WithEvents picFotoProfil As PictureBox
	Friend WithEvents Label11 As Label
	Friend WithEvents lblFotoHint As Label
	Friend WithEvents grpPeran As GroupBox
	Friend WithEvents rbSekretaris As RadioButton
	Friend WithEvents rbWakil As RadioButton
	Friend WithEvents rbKetua As RadioButton
	Friend WithEvents grpAktivitas As GroupBox
	Friend WithEvents chkBaca As CheckBox
	Friend WithEvents rbAnggota As RadioButton
	Friend WithEvents rbAdmin As RadioButton
	Friend WithEvents rbBendahara As RadioButton
	Friend WithEvents chkTulis As CheckBox
	Friend WithEvents chkDesain As CheckBox
	Friend WithEvents chkFotografi As CheckBox
	Friend WithEvents chkMusik As CheckBox
	Friend WithEvents chkCoding As CheckBox
	Friend WithEvents chkOlahraga As CheckBox
	Friend WithEvents chkRiset As CheckBox
	Friend WithEvents btnSimpanCetak As Button
	Friend WithEvents btnLanjut1 As Button
	Friend WithEvents btnKembali2 As Button
	Friend WithEvents btnLanjut2 As Button
	Friend WithEvents btnKembali3 As Button
	Friend WithEvents OpenFileDialog2 As OpenFileDialog
	Friend WithEvents btnReset As Button

End Class
