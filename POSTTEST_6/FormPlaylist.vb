Public Class FormPlaylist

    Private Sub MuatComboPlaylist()
        Dim dt As DataTable = GetAllPlaylist()
        Dim dtDenganKosong As New DataTable()
        dtDenganKosong.Columns.Add("kodePlaylist", GetType(String))
        dtDenganKosong.Columns.Add("namaPlaylist", GetType(String))
        dtDenganKosong.Rows.Add("", "-- Tanpa Playlist --")
        For Each row As DataRow In dt.Rows
            dtDenganKosong.Rows.Add(row("kodePlaylist").ToString(), row("namaPlaylist").ToString())
        Next
        cmbPlaylist.DataSource = dtDenganKosong
        cmbPlaylist.DisplayMember = "namaPlaylist"
        cmbPlaylist.ValueMember = "kodePlaylist"
        cmbPlaylist.SelectedIndex = 0
    End Sub

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
        cmbPlaylist.SelectedIndex = 0
        txtKodeLagu.Focus()
    End Sub

    Private Sub TampilData()
        dgvLagu.DataSource = GetAllLagu()
    End Sub

    Private Sub FormPlaylist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MuatComboPlaylist()
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

        Dim kodePlaylist As String = If(cmbPlaylist.SelectedValue IsNot Nothing,
                                        cmbPlaylist.SelectedValue.ToString(), "")

        If SimpanLagu(kode, txtJudulLagu.Text.Trim(), txtArtis.Text.Trim(),
                      txtGenre.Text.Trim(), txtDurasi.Text.Trim(),
                      txtLink.Text.Trim(), kodePlaylist) Then
            MessageBox.Show("Lagu berhasil disimpan!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiLagu(ErrorProvider1, txtKodeLagu, txtJudulLagu, txtArtis) Then Exit Sub

        Dim kodePlaylist As String = If(cmbPlaylist.SelectedValue IsNot Nothing,
                                        cmbPlaylist.SelectedValue.ToString(), "")

        If UbahLagu(txtKodeLagu.Text.Trim(), txtJudulLagu.Text.Trim(),
                    txtArtis.Text.Trim(), txtGenre.Text.Trim(),
                    txtDurasi.Text.Trim(), txtLink.Text.Trim(), kodePlaylist) Then
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
            txtLink.Text = If(linkVal Is Nothing OrElse IsDBNull(linkVal), "", linkVal.ToString())
            Dim kpVal = row.Cells("kodePlaylist").Value
            Dim kp As String = If(kpVal Is Nothing OrElse IsDBNull(kpVal), "", kpVal.ToString())
            cmbPlaylist.SelectedValue = If(kp = "", "", kp)
            txtKodeLagu.ReadOnly = True
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
                Dim kpVal = dt.Rows(0)("kodePlaylist")
                Dim kp As String = If(IsDBNull(kpVal), "", kpVal.ToString())
                cmbPlaylist.SelectedValue = If(kp = "", "", kp)
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

    Private Sub mnuKelolaPlaylist_Click(sender As Object, e As EventArgs) _
        Handles mnuKelolaPlaylist.Click
        Dim fp As New FormPlaylistManager()
        fp.ShowDialog()
        MuatComboPlaylist()
        TampilData()
    End Sub

End Class