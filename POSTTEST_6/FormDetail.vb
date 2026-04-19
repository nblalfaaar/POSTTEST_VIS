Public Class FormDetail

    Public Property KodePlaylist As String
    Public Property NamaPlaylist As String
    Public Property Deskripsi As String
    Public Property TanggalDibuat As String

    Private Sub FormDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNamaHeader.Text = NamaPlaylist
        lblSubHeader.Text = KodePlaylist & " · Detail Playlist"
        lblKodeVal.Text = KodePlaylist
        lblNamaVal.Text = NamaPlaylist
        lblTanggalVal.Text = TanggalDibuat
        lblDeskripsiVal.Text = If(Deskripsi = "", "Tidak ada deskripsi.", Deskripsi)
        MuatLagu()
    End Sub

    Private Sub MuatLagu()
        Dim dt As DataTable = GetLaguByPlaylist(KodePlaylist)
        dgvDetailLagu.DataSource = dt
        lblJumlahLagu.Text = dt.Rows.Count & " lagu dalam playlist ini"
    End Sub

    Private Sub dgvDetailLagu_CellClick(sender As Object, e As DataGridViewCellEventArgs) _
        Handles dgvDetailLagu.CellClick
        If e.RowIndex < 0 Then Exit Sub
        If e.ColumnIndex = dgvDetailLagu.Columns("linkSpotify").Index Then
            Dim linkVal = dgvDetailLagu.Rows(e.RowIndex).Cells("linkSpotify").Value
            Dim link As String = If(linkVal Is Nothing OrElse IsDBNull(linkVal), "", linkVal.ToString())
            If link <> "" Then
                System.Diagnostics.Process.Start(
                    New System.Diagnostics.ProcessStartInfo(link) With {
                        .UseShellExecute = True
                    })
            Else
                MessageBox.Show("Lagu ini tidak memiliki link Spotify.", "Info",
                                MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class