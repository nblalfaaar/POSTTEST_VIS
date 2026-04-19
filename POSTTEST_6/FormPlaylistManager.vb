Public Class FormPlaylistManager

    Private Sub Kosong()
        txtKodePlaylist.Clear()
        txtNamaPlaylist.Clear()
        txtDeskripsi.Clear()
        dtpTanggal.Value = DateTime.Today
        txtSearch.Clear()
        ErrorProvider1.Clear()
        txtKodePlaylist.ReadOnly = False
        txtKodePlaylist.Focus()
    End Sub

    Private Sub TampilData()
        dgvPlaylist.DataSource = GetAllPlaylist()
    End Sub

    Private Sub FormPlaylistManager_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilData()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        ErrorProvider1.Clear()
        If Not ValidasiPlaylist(ErrorProvider1, txtKodePlaylist, txtNamaPlaylist) Then Exit Sub

        Dim kode As String = txtKodePlaylist.Text.Trim()
        If KodePlaylistSudahAda(kode) Then
            MessageBox.Show("Kode Playlist sudah terdaftar!", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtKodePlaylist.Focus()
            Exit Sub
        End If

        If SimpanPlaylist(kode, txtNamaPlaylist.Text.Trim(),
                          txtDeskripsi.Text.Trim(),
                          dtpTanggal.Value.ToString("yyyy-MM-dd")) Then
            MessageBox.Show("Playlist berhasil disimpan!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        ErrorProvider1.Clear()
        If Not ValidasiPlaylist(ErrorProvider1, txtKodePlaylist, txtNamaPlaylist) Then Exit Sub

        If UbahPlaylist(txtKodePlaylist.Text.Trim(), txtNamaPlaylist.Text.Trim(),
                        txtDeskripsi.Text.Trim(),
                        dtpTanggal.Value.ToString("yyyy-MM-dd")) Then
            MessageBox.Show("Playlist berhasil diubah!", "Berhasil",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)
            TampilData()
            Kosong()
        Else
            MessageBox.Show("Playlist tidak ditemukan.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If txtKodePlaylist.Text.Trim() = "" Then
            MessageBox.Show("Pilih dulu playlist yang akan dihapus.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim konfirmasi As DialogResult = MessageBox.Show(
            "Hapus playlist """ & txtNamaPlaylist.Text & """?" & Environment.NewLine &
            "Lagu-lagu di playlist ini tidak akan terhapus (kodePlaylist akan jadi kosong).",
            "Konfirmasi Hapus",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question)

        If konfirmasi = DialogResult.Yes Then
            If HapusPlaylist(txtKodePlaylist.Text.Trim()) Then
                MessageBox.Show("Playlist berhasil dihapus.", "Berhasil",
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

    Private Sub dgvPlaylist_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvPlaylist.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvPlaylist.Rows(e.RowIndex)
            txtKodePlaylist.Text = row.Cells("kodePlaylist").Value.ToString()
            txtNamaPlaylist.Text = row.Cells("namaPlaylist").Value.ToString()
            Dim descVal = row.Cells("deskripsi").Value
            txtDeskripsi.Text = If(descVal Is Nothing OrElse IsDBNull(descVal), "", descVal.ToString())
            Dim tglVal = row.Cells("tanggalDibuat").Value
            If tglVal IsNot Nothing AndAlso Not IsDBNull(tglVal) Then
                dtpTanggal.Value = Convert.ToDateTime(tglVal)
            End If
            txtKodePlaylist.ReadOnly = True
        End If
    End Sub

    Private Sub txtKodePlaylist_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles txtKodePlaylist.KeyPress
        If IsEnterKey(e) Then
            e.Handled = True
            Dim dt As DataTable = GetPlaylistByKode(txtKodePlaylist.Text.Trim())
            If dt.Rows.Count > 0 Then
                txtNamaPlaylist.Text = dt.Rows(0)("namaPlaylist").ToString()
                Dim descVal = dt.Rows(0)("deskripsi")
                txtDeskripsi.Text = If(IsDBNull(descVal), "", descVal.ToString())
                Dim tglVal = dt.Rows(0)("tanggalDibuat")
                If Not IsDBNull(tglVal) Then
                    dtpTanggal.Value = Convert.ToDateTime(tglVal)
                End If
                txtKodePlaylist.ReadOnly = True
            Else
                txtNamaPlaylist.Clear()
            End If
            txtNamaPlaylist.Focus()
        End If
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) _
        Handles txtSearch.TextChanged
        If txtSearch.Text.Trim() = "" Then
            TampilData()
        Else
            dgvPlaylist.DataSource = SearchPlaylist(txtSearch.Text.Trim())
        End If
    End Sub

    Private Sub mnuDataLagu_Click(sender As Object, e As EventArgs) _
        Handles mnuDataLagu.Click
        Me.Close()
    End Sub

    Private Sub btnDetail_Click(sender As Object, e As EventArgs) Handles btnDetail.Click
        If txtKodePlaylist.Text.Trim() = "" Then
            MessageBox.Show("Pilih dulu playlist yang ingin dilihat detailnya.", "Peringatan",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim fd As New FormDetail()
        fd.KodePlaylist = txtKodePlaylist.Text.Trim()
        fd.NamaPlaylist = txtNamaPlaylist.Text.Trim()
        fd.Deskripsi = txtDeskripsi.Text.Trim()
        fd.TanggalDibuat = dtpTanggal.Value.ToString("dd MMMM yyyy")
        fd.ShowDialog()
    End Sub

    Private Sub dgvPlaylist_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvPlaylist.CellDoubleClick
        If e.RowIndex >= 0 Then
            btnDetail.PerformClick()
        End If
    End Sub

End Class