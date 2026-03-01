Public Class Form1

    ' Variabel untuk menyimpan semua IP Semester
    Dim listIP As New List(Of Double)

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateTampilan()
    End Sub

    ' =====================
    ' TOMBOL TAMBAH
    ' =====================
    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles btnTambah.Click
        Dim inputText As String = txtInput.Text.Trim().Replace(",", ".")
        Dim nilaiIP As Double

        ' Validasi input kosong
        If String.IsNullOrEmpty(inputText) Then
            MessageBox.Show("Masukkan nilai IP Semester terlebih dahulu!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInput.Focus()
            Return
        End If

        ' Validasi angka
        If Not Double.TryParse(inputText, nilaiIP) Then
            MessageBox.Show("Input tidak valid! Masukkan angka antara 0.00 - 4.00",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInput.Clear()
            txtInput.Focus()
            Return
        End If

        ' Validasi rentang nilai
        If nilaiIP < 0 Or nilaiIP > 4 Then
            MessageBox.Show("Nilai IP harus antara 0.00 - 4.00!",
                            "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            txtInput.Clear()
            txtInput.Focus()
            Return
        End If

        ' Tambah ke list dan update tampilan
        listIP.Add(nilaiIP)
        txtInput.Clear()
        txtInput.Focus()
        UpdateTampilan()
    End Sub

    ' =====================
    ' TOMBOL RESET
    ' =====================
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Dim konfirmasi As DialogResult
        konfirmasi = MessageBox.Show("Yakin ingin mereset semua data IPK?",
                                     "Konfirmasi Reset",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question)
        If konfirmasi = DialogResult.Yes Then
            listIP.Clear()
            txtInput.Clear()
            txtInput.Focus()
            UpdateTampilan()
        End If
    End Sub

    ' =====================
    ' UPDATE TAMPILAN
    ' =====================
    Private Sub UpdateTampilan()
        Dim jumlah As Integer = listIP.Count

        If jumlah = 0 Then
            txtNilaiIPK.Text = "-"
            lblPredikat.Text = "Belum ada data"
            Return
        End If

        ' Hitung IPK
        Dim total As Double = 0
        For Each ip As Double In listIP
            total += ip
        Next
        Dim ipk As Double = total / jumlah

        ' Tampilkan IPK
        txtNilaiIPK.Text = ipk.ToString("0.00")

		' Tentukan predikat
		If ipk >= 2.0 And ipk <= 2.75 Then
			lblPredikat.Text = "Cukup"
		ElseIf ipk > 2.75 And ipk <= 3.0 Then
			lblPredikat.Text = "Memuaskan"
		ElseIf ipk > 3.0 Then
			lblPredikat.Text = "Sangat Memuaskan"
		Else
			lblPredikat.Text = "Di Bawah Standar"   ' Tambahan untuk IPK di bawah 2.0
		End If

    End Sub

    ' Enter di textbox = langsung tambah
    Private Sub txtInput_KeyDown(sender As Object, e As KeyEventArgs) Handles txtInput.KeyDown
        If e.KeyCode = Keys.Enter Then
            btnTambah.PerformClick()
        End If
    End Sub

End Class