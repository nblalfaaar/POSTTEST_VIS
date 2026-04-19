Imports MySqlConnector

Module DataModule

    Public Function GetAllLagu() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeLagu, judulLagu, artis, genre, durasi, linkSpotify, kodePlaylist " &
                "FROM tblagu ORDER BY kodeLagu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchLagu(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeLagu, judulLagu, artis, genre, durasi, linkSpotify, kodePlaylist " &
                "FROM tblagu " &
                "WHERE kodeLagu LIKE @kw OR judulLagu LIKE @kw OR artis LIKE @kw OR genre LIKE @kw " &
                "ORDER BY kodeLagu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetLaguByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodeLagu, judulLagu, artis, genre, durasi, linkSpotify, kodePlaylist " &
                "FROM tblagu WHERE kodeLagu = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetLaguByPlaylist(kodePlaylist As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
            "SELECT kodeLagu, judulLagu, artis, genre, durasi, linkSpotify " &
            "FROM tblagu WHERE kodePlaylist = @kode ORDER BY kodeLagu ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kodePlaylist)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil lagu playlist: " & ex.Message,
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodeSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tblagu WHERE kodeLagu = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanLagu(kode As String, judul As String,
                                artis As String, genre As String,
                                durasi As String, link As String,
                                kodePlaylist As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tblagu (kodeLagu, judulLagu, artis, genre, durasi, linkSpotify, kodePlaylist) " &
                "VALUES (@kode, @judul, @artis, @genre, @durasi, @link, @kodePlaylist)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@artis", artis)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@link", link)
                    cmd.Parameters.AddWithValue("@kodePlaylist",
                        If(kodePlaylist = "", DBNull.Value, CObj(kodePlaylist)))
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahLagu(kode As String, judul As String,
                              artis As String, genre As String,
                              durasi As String, link As String,
                              kodePlaylist As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tblagu SET judulLagu=@judul, artis=@artis, genre=@genre, " &
                "durasi=@durasi, linkSpotify=@link, kodePlaylist=@kodePlaylist " &
                "WHERE kodeLagu=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@judul", judul)
                    cmd.Parameters.AddWithValue("@artis", artis)
                    cmd.Parameters.AddWithValue("@genre", genre)
                    cmd.Parameters.AddWithValue("@durasi", durasi)
                    cmd.Parameters.AddWithValue("@link", link)
                    cmd.Parameters.AddWithValue("@kodePlaylist",
                        If(kodePlaylist = "", DBNull.Value, CObj(kodePlaylist)))
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusLagu(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tblagu WHERE kodeLagu = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus data: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function GetAllPlaylist() As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodePlaylist, namaPlaylist, deskripsi, tanggalDibuat " &
                "FROM tbplaylist ORDER BY kodePlaylist ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menampilkan playlist: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function SearchPlaylist(keyword As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodePlaylist, namaPlaylist, deskripsi, tanggalDibuat " &
                "FROM tbplaylist " &
                "WHERE kodePlaylist LIKE @kw OR namaPlaylist LIKE @kw " &
                "ORDER BY kodePlaylist ASC"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kw", "%" & keyword & "%")
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mencari playlist: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function GetPlaylistByKode(kode As String) As DataTable
        Dim dt As New DataTable()
        Try
            Dim query As String =
                "SELECT kodePlaylist, namaPlaylist, deskripsi, tanggalDibuat " &
                "FROM tbplaylist WHERE kodePlaylist = @kode"
            Using conn As MySqlConnection = GetConnection()
                Using da As New MySqlDataAdapter(query, conn)
                    da.SelectCommand.Parameters.AddWithValue("@kode", kode)
                    da.Fill(dt)
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengambil playlist: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return dt
    End Function

    Public Function KodePlaylistSudahAda(kode As String) As Boolean
        Try
            Dim query As String = "SELECT COUNT(*) FROM tbplaylist WHERE kodePlaylist = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return Convert.ToInt32(cmd.ExecuteScalar()) > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal memeriksa playlist: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return True
        End Try
    End Function

    Public Function SimpanPlaylist(kode As String, nama As String,
                                    deskripsi As String, tanggal As String) As Boolean
        Try
            Dim query As String =
                "INSERT INTO tbplaylist (kodePlaylist, namaPlaylist, deskripsi, tanggalDibuat) " &
                "VALUES (@kode, @nama, @deskripsi, @tanggal)"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    cmd.ExecuteNonQuery()
                End Using
            End Using
            Return True
        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan playlist: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function UbahPlaylist(kode As String, nama As String,
                                  deskripsi As String, tanggal As String) As Boolean
        Try
            Dim query As String =
                "UPDATE tbplaylist SET namaPlaylist=@nama, deskripsi=@deskripsi, " &
                "tanggalDibuat=@tanggal WHERE kodePlaylist=@kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    cmd.Parameters.AddWithValue("@nama", nama)
                    cmd.Parameters.AddWithValue("@deskripsi", deskripsi)
                    cmd.Parameters.AddWithValue("@tanggal", tanggal)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal mengubah playlist: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

    Public Function HapusPlaylist(kode As String) As Boolean
        Try
            Dim query As String = "DELETE FROM tbplaylist WHERE kodePlaylist = @kode"
            Using conn As MySqlConnection = GetConnection()
                conn.Open()
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@kode", kode)
                    Return cmd.ExecuteNonQuery() > 0
                End Using
            End Using
        Catch ex As Exception
            MessageBox.Show("Gagal menghapus playlist: " & ex.Message,
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return False
        End Try
    End Function

End Module