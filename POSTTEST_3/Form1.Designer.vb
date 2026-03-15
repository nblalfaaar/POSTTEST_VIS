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
		picProfil = New PictureBox()
		btnGambar = New Button()
		lblNama = New Label()
		lblUmur = New Label()
		lblTglLahir = New Label()
		lblTelpon = New Label()
		lblAlamat = New Label()
		txtNama = New TextBox()
		txtUmur = New TextBox()
		txtTelpon = New TextBox()
		txtAlamat = New TextBox()
		dtpLahir = New DateTimePicker()
		gbJK = New GroupBox()
		rbCewe = New RadioButton()
		rbCowo = New RadioButton()
		gbHobi = New GroupBox()
		cbMenari = New CheckBox()
		cbMenyanyi = New CheckBox()
		cbOlahraga = New CheckBox()
		cbMembaca = New CheckBox()
		cbMemancing = New CheckBox()
		cbMenulis = New CheckBox()
		cbMenggambar = New CheckBox()
		cbTraveling = New CheckBox()
		cbCoding = New CheckBox()
		cbGaming = New CheckBox()
		btnCetak = New Button()
		CType(picProfil, ComponentModel.ISupportInitialize).BeginInit()
		gbJK.SuspendLayout()
		gbHobi.SuspendLayout()
		SuspendLayout()
		' 
		' picProfil
		' 
		picProfil.BackColor = Color.FromArgb(CByte(18), CByte(34), CByte(72))
		picProfil.BorderStyle = BorderStyle.FixedSingle
		picProfil.Location = New Point(20, 60)
		picProfil.Name = "picProfil"
		picProfil.Size = New Size(110, 130)
		picProfil.SizeMode = PictureBoxSizeMode.StretchImage
		picProfil.TabIndex = 0
		picProfil.TabStop = False
		' 
		' btnGambar
		' 
		btnGambar.BackColor = Color.FromArgb(CByte(26), CByte(58), CByte(143))
		btnGambar.Cursor = Cursors.Hand
		btnGambar.FlatAppearance.BorderColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		btnGambar.FlatStyle = FlatStyle.Flat
		btnGambar.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnGambar.Location = New Point(20, 200)
		btnGambar.Name = "btnGambar"
		btnGambar.Size = New Size(110, 32)
		btnGambar.TabIndex = 1
		btnGambar.Text = "Cari Foto"
		btnGambar.UseVisualStyleBackColor = False
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.BackColor = Color.Transparent
		lblNama.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblNama.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblNama.Location = New Point(160, 25)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(48, 18)
		lblNama.TabIndex = 2
		lblNama.Text = "Nama"
		' 
		' lblUmur
		' 
		lblUmur.AutoSize = True
		lblUmur.BackColor = Color.Transparent
		lblUmur.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblUmur.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblUmur.Location = New Point(160, 70)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(46, 18)
		lblUmur.TabIndex = 3
		lblUmur.Text = "Umur"
		' 
		' lblTglLahir
		' 
		lblTglLahir.AutoSize = True
		lblTglLahir.BackColor = Color.Transparent
		lblTglLahir.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblTglLahir.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblTglLahir.Location = New Point(160, 115)
		lblTglLahir.Name = "lblTglLahir"
		lblTglLahir.Size = New Size(103, 18)
		lblTglLahir.TabIndex = 4
		lblTglLahir.Text = "Tanggal Lahir"
		' 
		' lblTelpon
		' 
		lblTelpon.AutoSize = True
		lblTelpon.BackColor = Color.Transparent
		lblTelpon.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblTelpon.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblTelpon.Location = New Point(160, 160)
		lblTelpon.Name = "lblTelpon"
		lblTelpon.Size = New Size(87, 18)
		lblTelpon.TabIndex = 5
		lblTelpon.Text = "No Telepon"
		' 
		' lblAlamat
		' 
		lblAlamat.AutoSize = True
		lblAlamat.BackColor = Color.Transparent
		lblAlamat.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblAlamat.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblAlamat.Location = New Point(160, 205)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(57, 18)
		lblAlamat.TabIndex = 6
		lblAlamat.Text = "Alamat"
		' 
		' txtNama
		' 
		txtNama.BackColor = Color.FromArgb(CByte(18), CByte(34), CByte(72))
		txtNama.BorderStyle = BorderStyle.FixedSingle
		txtNama.ForeColor = Color.White
		txtNama.Location = New Point(160, 42)
		txtNama.MaxLength = 50
		txtNama.Name = "txtNama"
		txtNama.Size = New Size(280, 25)
		txtNama.TabIndex = 7
		' 
		' txtUmur
		' 
		txtUmur.BackColor = Color.FromArgb(CByte(18), CByte(34), CByte(72))
		txtUmur.BorderStyle = BorderStyle.FixedSingle
		txtUmur.ForeColor = Color.White
		txtUmur.Location = New Point(160, 87)
		txtUmur.MaxLength = 3
		txtUmur.Name = "txtUmur"
		txtUmur.Size = New Size(280, 25)
		txtUmur.TabIndex = 8
		' 
		' txtTelpon
		' 
		txtTelpon.BackColor = Color.FromArgb(CByte(18), CByte(34), CByte(72))
		txtTelpon.BorderStyle = BorderStyle.FixedSingle
		txtTelpon.ForeColor = Color.White
		txtTelpon.Location = New Point(160, 177)
		txtTelpon.MaxLength = 15
		txtTelpon.Name = "txtTelpon"
		txtTelpon.Size = New Size(280, 25)
		txtTelpon.TabIndex = 9
		' 
		' txtAlamat
		' 
		txtAlamat.BackColor = Color.FromArgb(CByte(18), CByte(34), CByte(72))
		txtAlamat.BorderStyle = BorderStyle.FixedSingle
		txtAlamat.ForeColor = Color.White
		txtAlamat.Location = New Point(160, 222)
		txtAlamat.MaxLength = 100
		txtAlamat.Name = "txtAlamat"
		txtAlamat.Size = New Size(280, 25)
		txtAlamat.TabIndex = 10
		' 
		' dtpLahir
		' 
		dtpLahir.CalendarMonthBackground = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		dtpLahir.Format = DateTimePickerFormat.Short
		dtpLahir.Location = New Point(160, 132)
		dtpLahir.Name = "dtpLahir"
		dtpLahir.Size = New Size(280, 25)
		dtpLahir.TabIndex = 11
		' 
		' gbJK
		' 
		gbJK.BackColor = Color.Transparent
		gbJK.Controls.Add(rbCewe)
		gbJK.Controls.Add(rbCowo)
		gbJK.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		gbJK.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
		gbJK.Location = New Point(20, 260)
		gbJK.Name = "gbJK"
		gbJK.Size = New Size(160, 75)
		gbJK.TabIndex = 12
		gbJK.TabStop = False
		gbJK.Text = "Jenis Kelamin"
		' 
		' rbCewe
		' 
		rbCewe.AutoSize = True
		rbCewe.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		rbCewe.Font = New Font("Calisto MT", 9F)
		rbCewe.ForeColor = Color.White
		rbCewe.Location = New Point(12, 48)
		rbCewe.Name = "rbCewe"
		rbCewe.Size = New Size(101, 21)
		rbCewe.TabIndex = 14
		rbCewe.TabStop = True
		rbCewe.Text = "Perempuan"
		rbCewe.UseVisualStyleBackColor = False
		' 
		' rbCowo
		' 
		rbCowo.AutoSize = True
		rbCowo.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		rbCowo.Font = New Font("Calisto MT", 9F)
		rbCowo.ForeColor = Color.White
		rbCowo.Location = New Point(12, 25)
		rbCowo.Name = "rbCowo"
		rbCowo.Size = New Size(91, 21)
		rbCowo.TabIndex = 13
		rbCowo.TabStop = True
		rbCowo.Text = "Laki-Laki"
		rbCowo.UseVisualStyleBackColor = False
		' 
		' gbHobi
		' 
		gbHobi.BackColor = Color.Transparent
		gbHobi.Controls.Add(cbMenari)
		gbHobi.Controls.Add(cbMenyanyi)
		gbHobi.Controls.Add(cbOlahraga)
		gbHobi.Controls.Add(cbMembaca)
		gbHobi.Controls.Add(cbMemancing)
		gbHobi.Controls.Add(cbMenulis)
		gbHobi.Controls.Add(cbMenggambar)
		gbHobi.Controls.Add(cbTraveling)
		gbHobi.Controls.Add(cbCoding)
		gbHobi.Controls.Add(cbGaming)
		gbHobi.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		gbHobi.ForeColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
		gbHobi.Location = New Point(195, 260)
		gbHobi.Name = "gbHobi"
		gbHobi.Size = New Size(430, 145)
		gbHobi.TabIndex = 13
		gbHobi.TabStop = False
		gbHobi.Text = "Hobi"
		' 
		' cbMenari
		' 
		cbMenari.AutoSize = True
		cbMenari.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbMenari.Font = New Font("Calisto MT", 9F)
		cbMenari.ForeColor = Color.White
		cbMenari.Location = New Point(215, 110)
		cbMenari.Name = "cbMenari"
		cbMenari.Size = New Size(76, 21)
		cbMenari.TabIndex = 9
		cbMenari.Text = "Menari"
		cbMenari.UseVisualStyleBackColor = False
		' 
		' cbMenyanyi
		' 
		cbMenyanyi.AutoSize = True
		cbMenyanyi.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbMenyanyi.Font = New Font("Calisto MT", 9F)
		cbMenyanyi.ForeColor = Color.White
		cbMenyanyi.Location = New Point(215, 88)
		cbMenyanyi.Name = "cbMenyanyi"
		cbMenyanyi.Size = New Size(95, 21)
		cbMenyanyi.TabIndex = 8
		cbMenyanyi.Text = "Menyanyi"
		cbMenyanyi.UseVisualStyleBackColor = False
		' 
		' cbOlahraga
		' 
		cbOlahraga.AutoSize = True
		cbOlahraga.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbOlahraga.Font = New Font("Calisto MT", 9F)
		cbOlahraga.ForeColor = Color.White
		cbOlahraga.Location = New Point(215, 66)
		cbOlahraga.Name = "cbOlahraga"
		cbOlahraga.Size = New Size(87, 21)
		cbOlahraga.TabIndex = 7
		cbOlahraga.Text = "Olahraga"
		cbOlahraga.UseVisualStyleBackColor = False
		' 
		' cbMembaca
		' 
		cbMembaca.AutoSize = True
		cbMembaca.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbMembaca.Font = New Font("Calisto MT", 9F)
		cbMembaca.ForeColor = Color.White
		cbMembaca.Location = New Point(215, 44)
		cbMembaca.Name = "cbMembaca"
		cbMembaca.Size = New Size(94, 21)
		cbMembaca.TabIndex = 6
		cbMembaca.Text = "Membaca"
		cbMembaca.UseVisualStyleBackColor = False
		' 
		' cbMemancing
		' 
		cbMemancing.AutoSize = True
		cbMemancing.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbMemancing.Font = New Font("Calisto MT", 9F)
		cbMemancing.ForeColor = Color.White
		cbMemancing.Location = New Point(215, 22)
		cbMemancing.Name = "cbMemancing"
		cbMemancing.Size = New Size(106, 21)
		cbMemancing.TabIndex = 5
		cbMemancing.Text = "Memancing"
		cbMemancing.UseVisualStyleBackColor = False
		' 
		' cbMenulis
		' 
		cbMenulis.AutoSize = True
		cbMenulis.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbMenulis.Font = New Font("Calisto MT", 9F)
		cbMenulis.ForeColor = Color.White
		cbMenulis.Location = New Point(12, 110)
		cbMenulis.Name = "cbMenulis"
		cbMenulis.Size = New Size(82, 21)
		cbMenulis.TabIndex = 4
		cbMenulis.Text = "Menulis"
		cbMenulis.UseVisualStyleBackColor = False
		' 
		' cbMenggambar
		' 
		cbMenggambar.AutoSize = True
		cbMenggambar.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbMenggambar.Font = New Font("Calisto MT", 9F)
		cbMenggambar.ForeColor = Color.White
		cbMenggambar.Location = New Point(12, 88)
		cbMenggambar.Name = "cbMenggambar"
		cbMenggambar.Size = New Size(114, 21)
		cbMenggambar.TabIndex = 3
		cbMenggambar.Text = "Menggambar"
		cbMenggambar.UseVisualStyleBackColor = False
		' 
		' cbTraveling
		' 
		cbTraveling.AutoSize = True
		cbTraveling.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbTraveling.Font = New Font("Calisto MT", 9F)
		cbTraveling.ForeColor = Color.White
		cbTraveling.Location = New Point(12, 66)
		cbTraveling.Name = "cbTraveling"
		cbTraveling.Size = New Size(90, 21)
		cbTraveling.TabIndex = 2
		cbTraveling.Text = "Traveling"
		cbTraveling.UseVisualStyleBackColor = False
		' 
		' cbCoding
		' 
		cbCoding.AutoSize = True
		cbCoding.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbCoding.Font = New Font("Calisto MT", 9F)
		cbCoding.ForeColor = Color.White
		cbCoding.Location = New Point(12, 44)
		cbCoding.Name = "cbCoding"
		cbCoding.Size = New Size(76, 21)
		cbCoding.TabIndex = 1
		cbCoding.Text = "Coding"
		cbCoding.UseVisualStyleBackColor = False
		' 
		' cbGaming
		' 
		cbGaming.AutoSize = True
		cbGaming.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		cbGaming.Font = New Font("Calisto MT", 9F)
		cbGaming.ForeColor = Color.White
		cbGaming.Location = New Point(12, 22)
		cbGaming.Name = "cbGaming"
		cbGaming.Size = New Size(81, 21)
		cbGaming.TabIndex = 0
		cbGaming.Text = "Gaming"
		cbGaming.UseVisualStyleBackColor = False
		' 
		' btnCetak
		' 
		btnCetak.BackColor = Color.FromArgb(CByte(245), CByte(197), CByte(24))
		btnCetak.Cursor = Cursors.Hand
		btnCetak.FlatAppearance.BorderSize = 0
		btnCetak.FlatStyle = FlatStyle.Flat
		btnCetak.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnCetak.ForeColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		btnCetak.Location = New Point(425, 425)
		btnCetak.Name = "btnCetak"
		btnCetak.Size = New Size(200, 38)
		btnCetak.TabIndex = 14
		btnCetak.Text = "Cetak Kartu"
		btnCetak.UseVisualStyleBackColor = False
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(9F, 17F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		ClientSize = New Size(632, 473)
		Controls.Add(btnCetak)
		Controls.Add(gbHobi)
		Controls.Add(gbJK)
		Controls.Add(dtpLahir)
		Controls.Add(txtAlamat)
		Controls.Add(txtTelpon)
		Controls.Add(txtUmur)
		Controls.Add(txtNama)
		Controls.Add(lblAlamat)
		Controls.Add(lblTelpon)
		Controls.Add(lblTglLahir)
		Controls.Add(lblUmur)
		Controls.Add(lblNama)
		Controls.Add(btnGambar)
		Controls.Add(picProfil)
		Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		ForeColor = Color.White
		FormBorderStyle = FormBorderStyle.FixedSingle
		MinimizeBox = False
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Form Cetak Kartu"
		CType(picProfil, ComponentModel.ISupportInitialize).EndInit()
		gbJK.ResumeLayout(False)
		gbJK.PerformLayout()
		gbHobi.ResumeLayout(False)
		gbHobi.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents picProfil As PictureBox
	Friend WithEvents btnGambar As Button
	Friend WithEvents lblNama As Label
	Private lblUmur As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lblTglLahir As Label
	Friend WithEvents lblTelpon As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents txtNama As TextBox
	Friend WithEvents txtUmur As TextBox
	Friend WithEvents txtTelpon As TextBox
	Friend WithEvents txtAlamat As TextBox
	Friend WithEvents dtpLahir As DateTimePicker
	Friend WithEvents gbJK As GroupBox
	Private rbCewe As RadioButton
	Friend WithEvents RadioButton2 As RadioButton
	Friend WithEvents rbCowo As RadioButton
	Friend WithEvents gbHobi As GroupBox
	Private cbMenari As CheckBox
	Friend WithEvents CheckBox10 As CheckBox
	Friend WithEvents cbMenyanyi As CheckBox
	Friend WithEvents CheckBox8 As CheckBox
	Friend WithEvents cbMembaca As CheckBox
	Private cbOlahraga As CheckBox
	Friend WithEvents cbMemancing As CheckBox
	Friend WithEvents cbMenulis As CheckBox
	Friend WithEvents cbMenggambar As CheckBox
	Friend WithEvents cbTraveling As CheckBox
	Friend WithEvents cbCoding As CheckBox
	Friend WithEvents cbGaming As CheckBox
	Friend WithEvents btnCetak As Button

End Class
