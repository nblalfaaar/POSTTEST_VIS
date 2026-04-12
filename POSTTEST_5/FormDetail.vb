Public Class FormDetail

    Public Property KodeLagu As String
    Public Property JudulLagu As String
    Public Property Artis As String
    Public Property Genre As String
    Public Property Durasi As String
    Public Property LinkSpotify As String

    Private Sub FormDetail_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblJudulLaguHeader.Text = JudulLagu
        lblSubHeader.Text = KodeLagu & " · Detail Lagu"
        lblKodeVal.Text = KodeLagu
        lblJudulVal.Text = JudulLagu
        lblArtisVal.Text = Artis
        lblGenreVal.Text = Genre
        lblDurasiVal.Text = Durasi
        lblLinkVal.Text = If(LinkSpotify = "", "Tidak tersedia", LinkSpotify)
        btnSpotify.Enabled = (LinkSpotify <> "")
    End Sub

    Private Sub btnSpotify_Click(sender As Object, e As EventArgs) Handles btnSpotify.Click
        If LinkSpotify <> "" Then
            System.Diagnostics.Process.Start(New System.Diagnostics.ProcessStartInfo(LinkSpotify) With {
                .UseShellExecute = True
            })
        End If
    End Sub

    Private Sub btnTutup_Click(sender As Object, e As EventArgs) Handles btnTutup.Click
        Me.Close()
    End Sub

End Class