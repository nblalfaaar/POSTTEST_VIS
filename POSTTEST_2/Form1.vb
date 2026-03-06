Public Class Form1

	Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
		If Not ValidasiInput(txtJudul.Text, txtGenre.Text) Then
			MsgBox("Judul dan Genre wajib diisi!", MsgBoxStyle.Exclamation, "Peringatan")
			Exit Sub
		End If

		TambahBuku(txtJudul.Text, txtGenre.Text)
		RefreshGrid()

		txtJudul.Text = ""
		txtGenre.Text = ""
		txtJudul.Focus()
	End Sub

	Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
		If txtHapus.Text = "" Then
			MsgBox("Masukkan judul buku yang ingin dihapus!", MsgBoxStyle.Exclamation, "Peringatan")
			Exit Sub
		End If

		Dim berhasil As Boolean
		HapusBuku(txtHapus.Text, berhasil)

		If berhasil Then
			MsgBox("Buku berhasil dihapus.", MsgBoxStyle.Information, "Info")
		Else
			MsgBox("Judul buku tidak ditemukan!", MsgBoxStyle.Exclamation, "Peringatan")
		End If

		RefreshGrid()
		txtHapus.Text = ""
	End Sub

	Private Sub RefreshGrid()
		dgvBuku.Rows.Clear()
		For i As Integer = 0 To jumlahBuku - 1
			dgvBuku.Rows.Add(i + 1, daftarJudul(i), daftarGenre(i))
		Next i
	End Sub

	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

	End Sub
End Class