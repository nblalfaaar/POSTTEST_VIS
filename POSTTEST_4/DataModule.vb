Imports System.IO
Imports System.Text

Module DataModule

    Public Function BuatIsiFile(
        nama As String,
        idAnggota As String,
        komunitas As String,
        tglLahir As String,
        jenisKelamin As String,
        telepon As String,
        email As String,
        alamat As String,
        peran As String,
        hobbies As String,
        fotoPath As String
    ) As String
        Dim sb As New StringBuilder()
        sb.AppendLine("Nama=" & nama.Trim())
        sb.AppendLine("IDAnggota=" & idAnggota.Trim())
        sb.AppendLine("Komunitas=" & komunitas.Trim())
        sb.AppendLine("TglLahir=" & tglLahir)
        sb.AppendLine("JenisKelamin=" & jenisKelamin)
        sb.AppendLine("Telepon=" & telepon)
        sb.AppendLine("Email=" & email.Trim())
        sb.AppendLine("Alamat=" & alamat.Trim())
        sb.AppendLine("Peran=" & peran)
        sb.AppendLine("Hobbies=" & hobbies)
        sb.Append("FotoPath=" & fotoPath)
        Return sb.ToString()
    End Function

    Public Function SimpanDataKeFile(
        sfd As SaveFileDialog,
        isi As String,
        namaFileDefault As String
    ) As Boolean
        sfd.Filter = "Text File|*.txt|CSV File|*.csv"
        sfd.Title = "Simpan Data Anggota"
        sfd.FileName = namaFileDefault
        If sfd.ShowDialog() = DialogResult.OK Then
            File.WriteAllText(sfd.FileName, isi, Encoding.UTF8)
            Return True
        End If
        Return False
    End Function

    Public Function BukaDataDariFile(ofd As OpenFileDialog) As Dictionary(Of String, String)
        ofd.Filter = "Text File|*.txt|CSV File|*.csv"
        ofd.Title = "Buka Data Anggota"
        If ofd.ShowDialog() <> DialogResult.OK Then
            Return Nothing
        End If

        Dim hasil As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase)
        Dim baris() As String = File.ReadAllLines(ofd.FileName, Encoding.UTF8)
        For Each b As String In baris
            If String.IsNullOrWhiteSpace(b) Then Continue For
            Dim bagian() As String = b.Split(New Char() {"="c}, 2)
            If bagian.Length = 2 Then
                hasil(bagian(0).Trim()) = bagian(1).Trim()
            End If
        Next
        Return hasil
    End Function

    Public Function AmbilNilai(data As Dictionary(Of String, String), key As String) As String
        If data IsNot Nothing AndAlso data.ContainsKey(key) Then
            Return data(key)
        End If
        Return ""
    End Function

End Module