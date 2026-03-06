Public Module Modul1

    Public daftarJudul(99) As String
    Public daftarGenre(99) As String
    Public jumlahBuku As Integer = 0

    ' fungsi validasi input
    Public Function ValidasiInput(ByVal judul As String, ByVal genre As String) As Boolean
        If judul = "" OrElse genre = "" Then
            Return False
        End If
        Return True
    End Function

    ' prosedur tambah buku yang ByVal
    Public Sub TambahBuku(ByVal judul As String, ByVal genre As String)
        If jumlahBuku < 100 Then
            daftarJudul(jumlahBuku) = judul
            daftarGenre(jumlahBuku) = genre
            jumlahBuku += 1
        End If
    End Sub

    ' prosedur hapus buku yang ByRef
    Public Sub HapusBuku(ByVal judulCari As String, ByRef berhasil As Boolean)
        berhasil = False
        For i As Integer = 0 To jumlahBuku - 1
            If daftarJudul(i).ToLower() = judulCari.ToLower() Then
                For j As Integer = i To jumlahBuku - 2
                    daftarJudul(j) = daftarJudul(j + 1)
                    daftarGenre(j) = daftarGenre(j + 1)
                Next j
                jumlahBuku -= 1
                berhasil = True
                Exit For
            End If
        Next i
    End Sub

End Module