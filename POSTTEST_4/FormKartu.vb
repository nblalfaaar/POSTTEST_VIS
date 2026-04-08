Public Class FormKartu

	Private Sub FormKartu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		MuatData()
	End Sub

	Private Sub MuatData()
		Dim d As Dictionary(Of String, String) = FormInput.DataAnggota
		If d Is Nothing Then
			lblNama.Text = "(Tidak ada data)"
			Return
		End If

		lblNama.Text = AmbilNilai(d, "Nama")
		lblId.Text = AmbilNilai(d, "IDAnggota")
		lblKomunitas.Text = AmbilNilai(d, "Komunitas")
		lblPeran.Text = AmbilNilai(d, "Peran")
		lblTelepon.Text = AmbilNilai(d, "Telepon")
		lblEmail.Text = AmbilNilai(d, "Email")
		lblHobby.Text = AmbilNilai(d, "Hobbies")

		Dim fotoPath As String = AmbilNilai(d, "FotoPath")
		If fotoPath <> "" AndAlso IO.File.Exists(fotoPath) Then
			Try
				picFotoKartu.Image = Image.FromFile(fotoPath)
			Catch
				picFotoKartu.Image = Nothing
			End Try
		Else
			picFotoKartu.Image = Nothing
		End If
	End Sub

End Class