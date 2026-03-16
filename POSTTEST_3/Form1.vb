Imports System.IO

Public Class Form1

    Dim grupHobi() As CheckBox
    Dim grupJK() As RadioButton

    Private Function CekData() As Boolean
        grupHobi = {cbGaming, cbCoding, cbTraveling, cbMenggambar, cbMenulis,
                    cbMemancing, cbMembaca, cbOlahraga, cbMenyanyi, cbMenari}
        grupJK = {rbCowo, rbCewe}

        If Not ValidasiTextBox(txtNama, "Nama Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtUmur, "Umur Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtTelpon, "No Telepon Tidak Boleh Kosong") Then Return False
        If Not ValidasiTextBox(txtAlamat, "Alamat Tidak Boleh Kosong") Then Return False
        If Not ValidasiRadioButton(grupJK, "Pilih Jenis Kelamin Anda") Then Return False
        If Not ValidasiCheckBox(grupHobi, "Pilih Minimal 1 Hobi") Then Return False
        If Not ValidasiPictureBox(picProfil, "Foto Tidak Boleh Kosong") Then Return False
        Return True
    End Function

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        If CekData() Then
            grupHobi = {cbGaming, cbCoding, cbTraveling, cbMenggambar, cbMenulis,
                        cbMemancing, cbMembaca, cbOlahraga, cbMenyanyi, cbMenari}
            grupJK = {rbCowo, rbCewe}

            DataModule.Nama = txtNama.Text
            DataModule.Umur = txtUmur.Text
            DataModule.Telpon = txtTelpon.Text
            DataModule.Alamat = txtAlamat.Text
            DataModule.JK = GetSelectedRadioButton(grupJK)
            DataModule.Hobi = GetSelectedCheckBox(grupHobi)
            DataModule.Tglahir = dtpLahir.Value

            Form2.Show()
        End If
    End Sub

    Private Sub btnGambar_Click(sender As Object, e As EventArgs) Handles btnGambar.Click
        If ValidasiTextBox(txtNama, "Nama Harus Diisi Dahulu") Then
            Dim NamaFile As String = txtNama.Text.Trim()
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
            openFileDialog.Title = "Pilih Gambar"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                Dim folderPath As String = Path.Combine(Application.StartupPath, "Foto")
                Dim fileName As String = NamaFile & Path.GetExtension(openFileDialog.FileName)
                Dim destinationPath As String = Path.Combine(folderPath, fileName)

                If Not Directory.Exists(folderPath) Then
                    Directory.CreateDirectory(folderPath)
                End If

                File.Copy(openFileDialog.FileName, destinationPath, True)
                DataModule.Foto = destinationPath
                picProfil.Image = Image.FromFile(destinationPath)
                MessageBox.Show("Gambar berhasil disimpan!", "Sukses",
                                 MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub txtNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtNama.KeyPress
        ValidationModule.HanyaHuruf(sender, e)
    End Sub

    Private Sub txtUmur_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtUmur.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

    Private Sub txtTelpon_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtTelpon.KeyPress
        ValidationModule.HanyaAngka(sender, e)
    End Sub

End Class