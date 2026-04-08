Public Class FormInput

	Public Shared DataAnggota As Dictionary(Of String, String) = Nothing
	Public Shared FotoProfilPath As String = ""

	Private Sub FormInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		TabControl1.SelectedTab = tcDataUtama

		If DataAnggota IsNot Nothing Then
			IsiFormDariData(DataAnggota)
		End If
	End Sub

	Private Sub mnuInputData_Click(sender As Object, e As EventArgs) Handles mnuInputData.Click
		TabControl1.SelectedTab = tcDataUtama
		txtNama.Focus()
	End Sub

	Private Sub mnuLihatKartu_Click(sender As Object, e As EventArgs) Handles mnuLihatKartu.Click
		If DataAnggota Is Nothing Then
			MessageBox.Show(
				"Belum ada data anggota." & Environment.NewLine &
				"Silakan input dan simpan data terlebih dahulu.",
				"Informasi",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			)
			Return
		End If
		Dim frm As New FormKartu()
		frm.ShowDialog()
	End Sub

	Private Sub mnuSimpanData_Click(sender As Object, e As EventArgs) Handles mnuSimpanData.Click
		If DataAnggota Is Nothing Then
			MessageBox.Show(
				"Belum ada data untuk disimpan.",
				"Informasi",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			)
			Return
		End If

		Dim hasil As DialogResult = MessageBox.Show(
			"Simpan data anggota ke file?",
			"Konfirmasi Simpan",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		)

		If hasil = DialogResult.Yes Then
			Dim isi As String = BuatIsiFile(
				AmbilNilai(DataAnggota, "Nama"),
				AmbilNilai(DataAnggota, "IDAnggota"),
				AmbilNilai(DataAnggota, "Komunitas"),
				AmbilNilai(DataAnggota, "TglLahir"),
				AmbilNilai(DataAnggota, "JenisKelamin"),
				AmbilNilai(DataAnggota, "Telepon"),
				AmbilNilai(DataAnggota, "Email"),
				AmbilNilai(DataAnggota, "Alamat"),
				AmbilNilai(DataAnggota, "Peran"),
				AmbilNilai(DataAnggota, "Hobbies"),
				AmbilNilai(DataAnggota, "FotoPath")
			)
			Dim namaFile As String = "anggota_" & AmbilNilai(DataAnggota, "IDAnggota") & ".txt"
			If SimpanDataKeFile(SaveFileDialog1, isi, namaFile) Then
				MessageBox.Show(
					"Data berhasil disimpan.",
					"Berhasil",
					MessageBoxButtons.OK,
					MessageBoxIcon.Information
				)
			End If

		ElseIf hasil = DialogResult.No Then
			MessageBox.Show(
				"Data tidak jadi disimpan.",
				"Informasi",
				MessageBoxButtons.OK,
				MessageBoxIcon.Information
			)
		End If
	End Sub

	Private Sub mnuBukaData_Click(sender As Object, e As EventArgs) Handles mnuBukaData.Click
		Dim data As Dictionary(Of String, String) = BukaDataDariFile(OpenFileDialog2)
		If data Is Nothing Then Return

		DataAnggota = data
		FotoProfilPath = AmbilNilai(data, "FotoPath")
		IsiFormDariData(data)
		TabControl1.SelectedTab = tcDataUtama

		MessageBox.Show(
			"File berhasil dibuka.",
			"Informasi",
			MessageBoxButtons.OK,
			MessageBoxIcon.Information
		)
	End Sub

	Private Sub mnuKeluar_Click(sender As Object, e As EventArgs) Handles mnuKeluar.Click
		Dim hasil As DialogResult = MessageBox.Show(
			"Apakah Anda yakin ingin keluar?",
			"Konfirmasi Keluar",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		)
		If hasil = DialogResult.Yes Then
			Me.Close()
		End If
	End Sub

	Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
		HanyaHuruf(e)
	End Sub

	Private Sub txtNama_TextChanged(sender As Object, e As EventArgs) Handles txtNama.TextChanged
		ValidasiTextBox(ErrorProvider1, txtNama, "Inputan tidak boleh kosong")
	End Sub

	Private Sub txtIdAnggota_TextChanged(sender As Object, e As EventArgs) Handles txtIdAnggota.TextChanged
		ValidasiTextBox(ErrorProvider1, txtIdAnggota, "Inputan tidak boleh kosong")
	End Sub

	Private Sub cboKomunitas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboKomunitas.SelectedIndexChanged
		ValidasiComboBox(ErrorProvider1, cboKomunitas, "Inputan tidak boleh kosong")
	End Sub

	Private Sub mtxtTelepon_TextChanged(sender As Object, e As EventArgs) Handles mtxtTelepon.TextChanged
		ValidasiMaskedTextBox(ErrorProvider1, mtxtTelepon, "Inputan tidak boleh kosong")
	End Sub

	Private Sub txtEmail_TextChanged(sender As Object, e As EventArgs) Handles txtEmail.TextChanged
		ValidasiTextBox(ErrorProvider1, txtEmail, "Inputan tidak boleh kosong")
	End Sub

	Private Sub txtAlamat_TextChanged(sender As Object, e As EventArgs) Handles txtAlamat.TextChanged
		ValidasiTextBox(ErrorProvider1, txtAlamat, "Inputan tidak boleh kosong")
	End Sub

	Private Sub btnLanjut1_Click(sender As Object, e As EventArgs) Handles btnLanjut1.Click
		Dim namaOk = ValidasiTextBox(ErrorProvider1, txtNama, "Inputan tidak boleh kosong")
		Dim idOk = ValidasiTextBox(ErrorProvider1, txtIdAnggota, "Inputan tidak boleh kosong")
		Dim komOk = ValidasiComboBox(ErrorProvider1, cboKomunitas, "Inputan tidak boleh kosong")

		If Not (namaOk And idOk And komOk) Then
			MessageBox.Show(
				"Masih ada inputan yang belum diisi.",
				"Validasi",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning
			)
			Return
		End If
		TabControl1.SelectedTab = tcKontakInfo
	End Sub

	Private Sub btnKembali2_Click(sender As Object, e As EventArgs) Handles btnKembali2.Click
		TabControl1.SelectedTab = tcDataUtama
	End Sub

	Private Sub btnLanjut2_Click(sender As Object, e As EventArgs) Handles btnLanjut2.Click
		Dim telOk = ValidasiMaskedTextBox(ErrorProvider1, mtxtTelepon, "Inputan tidak boleh kosong")
		Dim emailOk = ValidasiTextBox(ErrorProvider1, txtEmail, "Inputan tidak boleh kosong")
		Dim alamatOk = ValidasiTextBox(ErrorProvider1, txtAlamat, "Inputan tidak boleh kosong")

		If Not (telOk And emailOk And alamatOk) Then
			MessageBox.Show(
				"Masih ada inputan yang belum diisi.",
				"Validasi",
				MessageBoxButtons.OK,
				MessageBoxIcon.Warning
			)
			Return
		End If
		TabControl1.SelectedTab = tcProfilAktivitas
	End Sub

	Private Sub btnKembali3_Click(sender As Object, e As EventArgs) Handles btnKembali3.Click
		TabControl1.SelectedTab = tcKontakInfo
	End Sub

	Private Sub btnBrowseFoto_Click(sender As Object, e As EventArgs) Handles btnBrowseFoto.Click
		OpenFileDialog1.Filter = "File Gambar|*.jpg;*.jpeg;*.png;*.bmp"
		OpenFileDialog1.Title = "Pilih Foto Profil"
		If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
			Try
				picFotoProfil.Image = Image.FromFile(OpenFileDialog1.FileName)
				picFotoProfil.SizeMode = PictureBoxSizeMode.Zoom
				FotoProfilPath = OpenFileDialog1.FileName
				lblFotoHint.Text = IO.Path.GetFileName(OpenFileDialog1.FileName)
			Catch ex As Exception
				MessageBox.Show("Gagal memuat foto: " & ex.Message, "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error)
			End Try
		End If
	End Sub

	Private Sub btnSimpanCetak_Click(sender As Object, e As EventArgs) Handles btnSimpanCetak.Click

		Dim namaOk = ValidasiTextBox(ErrorProvider1, txtNama, "Inputan tidak boleh kosong")
		Dim idOk = ValidasiTextBox(ErrorProvider1, txtIdAnggota, "Inputan tidak boleh kosong")
		Dim komOk = ValidasiComboBox(ErrorProvider1, cboKomunitas, "Inputan tidak boleh kosong")
		If Not (namaOk And idOk And komOk) Then
			MessageBox.Show("Masih ada inputan kosong di tab Data Utama!", "Validasi",
				MessageBoxButtons.OK, MessageBoxIcon.Warning)
			TabControl1.SelectedTab = tcDataUtama
			Return
		End If

		Dim telOk = ValidasiMaskedTextBox(ErrorProvider1, mtxtTelepon, "Inputan tidak boleh kosong")
		Dim emailOk = ValidasiTextBox(ErrorProvider1, txtEmail, "Inputan tidak boleh kosong")
		Dim alamatOk = ValidasiTextBox(ErrorProvider1, txtAlamat, "Inputan tidak boleh kosong")
		If Not (telOk And emailOk And alamatOk) Then
			MessageBox.Show("Masih ada inputan kosong di tab Kontak & Info!", "Validasi",
				MessageBoxButtons.OK, MessageBoxIcon.Warning)
			TabControl1.SelectedTab = tcKontakInfo
			Return
		End If

		Dim semuaCheck As CheckBox() = {
			chkBaca, chkCoding, chkMusik, chkFotografi,
			chkDesain, chkTulis, chkRiset, chkOlahraga
		}
		If Not ValidasiCheckBox(ErrorProvider1, semuaCheck, grpAktivitas, "Inputan tidak boleh kosong") Then
			MessageBox.Show("Pilih minimal 1 aktivitas/hobby!", "Validasi",
				MessageBoxButtons.OK, MessageBoxIcon.Warning)
			TabControl1.SelectedTab = tcProfilAktivitas
			Return
		End If

		Dim konfirmasi As DialogResult = MessageBox.Show(
			"Simpan ke memori dan tampilkan kartu anggota?",
			"Konfirmasi Cetak Kartu",
			MessageBoxButtons.YesNoCancel,
			MessageBoxIcon.Question
		)

		If konfirmasi = DialogResult.Yes Then
			SimpanDataKeMemory()
			MessageBox.Show("Data berhasil disimpan!", "Berhasil",
				MessageBoxButtons.OK, MessageBoxIcon.Information)
			Dim frmKartu As New FormKartu()
			frmKartu.ShowDialog()

		ElseIf konfirmasi = DialogResult.No Then
			MessageBox.Show("Data tidak jadi disimpan.", "Informasi",
				MessageBoxButtons.OK, MessageBoxIcon.Information)

		ElseIf konfirmasi = DialogResult.Cancel Then
			MessageBox.Show("Proses dibatalkan.", "Informasi",
				MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
		End If
	End Sub

	Private Sub SimpanDataKeMemory()
		Dim jk As String = If(rbLakiLaki.Checked, "Laki-laki", "Perempuan")

		Dim peran As String = "Anggota"
		If rbKetua.Checked Then peran = "Ketua"
		If rbWakil.Checked Then peran = "Wakil Ketua"
		If rbSekretaris.Checked Then peran = "Sekretaris"
		If rbBendahara.Checked Then peran = "Bendahara"
		If rbAdmin.Checked Then peran = "Admin"

		Dim listHobby As New List(Of String)
		If chkBaca.Checked Then listHobby.Add("Membaca")
		If chkCoding.Checked Then listHobby.Add("Coding")
		If chkMusik.Checked Then listHobby.Add("Musik")
		If chkFotografi.Checked Then listHobby.Add("Fotografi")
		If chkDesain.Checked Then listHobby.Add("Desain")
		If chkTulis.Checked Then listHobby.Add("Menulis")
		If chkRiset.Checked Then listHobby.Add("Riset")
		If chkOlahraga.Checked Then listHobby.Add("Olahraga")

		DataAnggota = New Dictionary(Of String, String) From {
			{"Nama", txtNama.Text.Trim()},
			{"IDAnggota", txtIdAnggota.Text.Trim()},
			{"Komunitas", cboKomunitas.Text},
			{"TglLahir", dtpTglLahir.Value.ToString("dd MMMM yyyy")},
			{"JenisKelamin", jk},
			{"Telepon", mtxtTelepon.Text},
			{"Email", txtEmail.Text.Trim()},
			{"Alamat", txtAlamat.Text.Trim()},
			{"Peran", peran},
			{"Hobbies", String.Join(", ", listHobby)},
			{"FotoPath", FotoProfilPath}
		}
	End Sub

	Private Sub IsiFormDariData(data As Dictionary(Of String, String))
		txtNama.Text = AmbilNilai(data, "Nama")
		txtIdAnggota.Text = AmbilNilai(data, "IDAnggota")

		Dim komIdx As Integer = cboKomunitas.FindStringExact(AmbilNilai(data, "Komunitas"))
		If komIdx >= 0 Then cboKomunitas.SelectedIndex = komIdx

		Dim tgl As DateTime
		If DateTime.TryParse(AmbilNilai(data, "TglLahir"), tgl) Then
			dtpTglLahir.Value = tgl
		End If

		If AmbilNilai(data, "JenisKelamin") = "Laki-laki" Then
			rbLakiLaki.Checked = True
		Else
			rbPerempuan.Checked = True
		End If

		mtxtTelepon.Text = AmbilNilai(data, "Telepon")
		txtEmail.Text = AmbilNilai(data, "Email")
		txtAlamat.Text = AmbilNilai(data, "Alamat")

		Select Case AmbilNilai(data, "Peran")
			Case "Ketua" : rbKetua.Checked = True
			Case "Wakil Ketua" : rbWakil.Checked = True
			Case "Sekretaris" : rbSekretaris.Checked = True
			Case "Bendahara" : rbBendahara.Checked = True
			Case "Admin" : rbAdmin.Checked = True
			Case Else : rbAnggota.Checked = True
		End Select

		Dim h As String = AmbilNilai(data, "Hobbies")
		chkBaca.Checked = h.Contains("Membaca")
		chkCoding.Checked = h.Contains("Coding")
		chkMusik.Checked = h.Contains("Musik")
		chkFotografi.Checked = h.Contains("Fotografi")
		chkDesain.Checked = h.Contains("Desain")
		chkTulis.Checked = h.Contains("Menulis")
		chkRiset.Checked = h.Contains("Riset")
		chkOlahraga.Checked = h.Contains("Olahraga")

		Dim fotoPath As String = AmbilNilai(data, "FotoPath")
		If fotoPath <> "" AndAlso IO.File.Exists(fotoPath) Then
			Try
				picFotoProfil.Image = Image.FromFile(fotoPath)
				lblFotoHint.Text = IO.Path.GetFileName(fotoPath)
				FotoProfilPath = fotoPath
			Catch
			End Try
		End If
	End Sub

	Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
		Dim hasil As DialogResult
		hasil = MessageBox.Show(
			"Apakah data ingin direset?",
			"Konfirmasi Reset",
			MessageBoxButtons.YesNo,
			MessageBoxIcon.Question
		)

		If hasil = DialogResult.Yes Then
			KosongkanForm()
		End If
	End Sub

	Private Sub KosongkanForm()

		txtNama.Clear()
		txtIdAnggota.Clear()
		dtpTglLahir.Value = DateTime.Now
		rbLakiLaki.Checked = False
		rbPerempuan.Checked = False
		cboKomunitas.SelectedIndex = -1

		mtxtTelepon.Clear()
		txtEmail.Clear()
		txtAlamat.Clear()

		rbKetua.Checked = False
		rbWakil.Checked = False
		rbSekretaris.Checked = False
		rbBendahara.Checked = False
		rbAdmin.Checked = False
		rbAnggota.Checked = False

		chkBaca.Checked = False
		chkCoding.Checked = False
		chkMusik.Checked = False
		chkFotografi.Checked = False
		chkDesain.Checked = False
		chkTulis.Checked = False
		chkRiset.Checked = False
		chkOlahraga.Checked = False

		picFotoProfil.Image = Nothing
		FotoProfilPath = ""
		lblFotoHint.Text = "Belum ada foto"

		ErrorProvider1.Clear()

		DataAnggota = Nothing

		TabControl1.SelectedTab = tcDataUtama
		txtNama.Focus()
	End Sub

End Class