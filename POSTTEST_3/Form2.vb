Public Class Form2

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblNama.Text = DataModule.Nama
        lblUmur.Text = DataModule.Umur
        lblTLahir.Text = DataModule.Tglahir
        lblJK.Text = DataModule.JK
        lblTelpon.Text = DataModule.Telpon
        lblHobi.Text = DataModule.Hobi
        lblAlamat.Text = DataModule.Alamat

        PictureBox1.Image = Image.FromFile(DataModule.Foto)
    End Sub

End Class