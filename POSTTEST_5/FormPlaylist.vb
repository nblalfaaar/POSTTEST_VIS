Public Class FormPlaylist

    Private Sub Kosong()
        txtKodeLagu.Clear()
        txtJudulLagu.Clear()
        txtArtis.Clear()
        txtGenre.Clear()
        txtDurasi.Clear()
        txtLink.Clear()
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodeLagu.ReadOnly = False
        txtKodeLagu.Focus()
    End Sub

    Private Sub TampilData()
        dgvLagu.DataSource = GetAllLagu()
    End Sub

    Private Sub FormPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiLagu(ErrorProvider1, txtKodeLagu, txtJudulLagu, txtArtis) Then Exit Sub

        Dim kode As String = txtKodeLagu.Text.Trim()
        If KodeSudahAda(kode) Then
            MessageBox.Show("Kode Lagu sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodeLagu.Focus()
            Exit Sub
        End If

        If SimpanLagu(kode, txtJudulLagu.Text.Trim(), txtArtis.Text.Trim(),
                      txtGenre.Text.Trim(), txtDurasi.Text.Trim(),
                      txtLink.Text.Trim()) Then
            MessageBox.Show("Lagu berhasil disimpan!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiLagu(ErrorProvider1, txtKodeLagu, txtJudulLagu, txtArtis) Then Exit Sub

        If UbahLagu(txtKodeLagu.Text.Trim(), txtJudulLagu.Text.Trim(),
                    txtArtis.Text.Trim(), txtGenre.Text.Trim(),
                    txtDurasi.Text.Trim(), txtLink.Text.Trim()) Then
            MessageBox.Show("Data berhasil diubah!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Data tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodeLagu.Text.Trim() = "" Then
            MessageBox.Show("Pilih dulu data yang akan dihapus.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Hapus lagu """ & txtJudulLagu.Text & """?",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusLagu(txtKodeLagu.Text.Trim()) Then
                MessageBox.Show("Lagu berhasil dihapus.", "Berhasil",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
                Kosong()
            End If
        End If
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        TampilData()
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        If txtKodeLagu.Text.Trim() = "" Then
            MessageBox.Show("Pilih dulu data yang ingin dilihat detailnya.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim f2 As New FormDetail()
        f2.KodeLagu = txtKodeLagu.Text.Trim()
        f2.JudulLagu = txtJudulLagu.Text.Trim()
        f2.Artis = txtArtis.Text.Trim()
        f2.Genre = txtGenre.Text.Trim()
        f2.Durasi = txtDurasi.Text.Trim()
        f2.LinkSpotify = txtLink.Text.Trim()
        f2.ShowDialog()
    End Sub

    Private Sub dgvLagu_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvLagu.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvLagu.Rows(e.RowIndex)
            txtKodeLagu.Text = row.Cells("kodeLagu").Value.ToString()
            txtJudulLagu.Text = row.Cells("judulLagu").Value.ToString()
            txtArtis.Text = row.Cells("artis").Value.ToString()
            txtGenre.Text = row.Cells("genre").Value.ToString()
            txtDurasi.Text = row.Cells("durasi").Value.ToString()
            Dim linkVal = row.Cells("linkSpotify").Value
            txtLink.Text = If(linkVal Is Nothing, "", linkVal.ToString())
            txtKodeLagu.ReadOnly = True
        End If
    End Sub

    Private Sub dgvLagu_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvLagu.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnDetail.PerformClick()
        End If
    End Sub

    Private Sub txtKodeLagu_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtKodeLagu.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetLaguByKode(txtKodeLagu.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtJudulLagu.Text = dt.Rows(0)("judulLagu").ToString()
                txtArtis.Text = dt.Rows(0)("artis").ToString()
                txtGenre.Text = dt.Rows(0)("genre").ToString()
                txtDurasi.Text = dt.Rows(0)("durasi").ToString()
                Dim linkVal = dt.Rows(0)("linkSpotify")
                txtLink.Text = If(IsDBNull(linkVal), "", linkVal.ToString())
                txtKodeLagu.ReadOnly = True
            Else
                txtJudulLagu.Clear()
            End If
            txtJudulLagu.Focus()
        End If
    End Sub

    Private Sub txtJudulLagu_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtJudulLagu.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            txtArtis.Focus()
        End If
    End Sub

    Private Sub txtArtis_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtArtis.KeyPress
        HanyaHuruf(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtGenre.Focus()
        End If
    End Sub

    Private Sub txtDurasi_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtDurasi.KeyPress
        HanyaAngkaKolonTitikDua(e)
        If IsEnterKey(e) Then
            e.Handled = True
            txtLink.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) _
        Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvLagu.DataSource = SearchLagu(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub mnuDataLagu_Click(sender As Object, e As EventArgs) _
        Handles mnuDataLagu.Click
        btnDetail.PerformClick()
    End Sub

End Class