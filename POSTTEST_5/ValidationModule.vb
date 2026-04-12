Module ValidationModule

    Public Sub HanyaHuruf(e As KeyPressEventArgs)
        If Char.IsLetter(e.KeyChar) OrElse
           Char.IsWhiteSpace(e.KeyChar) OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Sub HanyaAngkaKolonTitikDua(e As KeyPressEventArgs)
        If Char.IsDigit(e.KeyChar) OrElse
           e.KeyChar = ":"c OrElse
           Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Public Function ValidasiTextBox(ep As ErrorProvider, txt As TextBox, pesan As String) As Boolean
        If txt.Text.Trim() = "" Then
            ep.SetError(txt, pesan)
            Return False
        Else
            ep.SetError(txt, "")
            Return True
        End If
    End Function

    Public Function ValidasiLagu(ep As ErrorProvider,
                                  txtKode As TextBox,
                                  txtJudul As TextBox,
                                  txtArtis As TextBox) As Boolean
        Dim kodeValid As Boolean = ValidasiTextBox(ep, txtKode, "Kode Lagu tidak boleh kosong")
        Dim judulValid As Boolean = ValidasiTextBox(ep, txtJudul, "Judul Lagu tidak boleh kosong")
        Dim artisValid As Boolean = ValidasiTextBox(ep, txtArtis, "Artis tidak boleh kosong")
        Return kodeValid And judulValid And artisValid
    End Function

    Public Function IsEnterKey(e As KeyPressEventArgs) As Boolean
        Return e.KeyChar = ChrW(13)
    End Function

End Module