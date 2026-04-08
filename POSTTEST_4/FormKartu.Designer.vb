Imports System.ComponentModel

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormKartu
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(ByVal disposing As Boolean)
		Try
			If disposing AndAlso components IsNot Nothing Then
				components.Dispose()
			End If
		Finally
			MyBase.Dispose(disposing)
		End Try
	End Sub

	'Required by the Windows Form Designer
	Private components As System.ComponentModel.IContainer

	'NOTE: The following procedure is required by the Windows Form Designer
	'It can be modified using the Windows Form Designer.  
	'Do not modify it using the code editor.
	<System.Diagnostics.DebuggerStepThrough()>
	Private Sub InitializeComponent()
		lblJudulForm = New Label()
		lblSubForm = New Label()
		pnlKartu = New Panel()
		pnlBadge = New Panel()
		lblPeran = New Label()
		lblKontakTitle = New Label()
		picIkonEmail = New PictureBox()
		picIkonTelepon = New PictureBox()
		lblHobby = New Label()
		pnlGaris2 = New Panel()
		lblHobbyTitle = New Label()
		lblEmail = New Label()
		lblTelepon = New Label()
		pnlGaris = New Panel()
		lblKomunitas = New Label()
		lblId = New Label()
		lblNama = New Label()
		picFotoKartu = New PictureBox()
		pnlAksen = New Panel()
		Panel1 = New Panel()
		pnlKartu.SuspendLayout()
		pnlBadge.SuspendLayout()
		CType(picIkonEmail, ISupportInitialize).BeginInit()
		CType(picIkonTelepon, ISupportInitialize).BeginInit()
		CType(picFotoKartu, ISupportInitialize).BeginInit()
		pnlAksen.SuspendLayout()
		SuspendLayout()
		' 
		' lblJudulForm
		' 
		lblJudulForm.AutoSize = True
		lblJudulForm.Font = New Font("Calisto MT", 12.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudulForm.ForeColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		lblJudulForm.Location = New Point(16, 12)
		lblJudulForm.Name = "lblJudulForm"
		lblJudulForm.Size = New Size(253, 22)
		lblJudulForm.TabIndex = 0
		lblJudulForm.Text = "Kartu Anggota Komunitas"
		' 
		' lblSubForm
		' 
		lblSubForm.AutoSize = True
		lblSubForm.Font = New Font("Calisto MT", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblSubForm.ForeColor = Color.FromArgb(CByte(100), CByte(130), CByte(170))
		lblSubForm.Location = New Point(16, 38)
		lblSubForm.Name = "lblSubForm"
		lblSubForm.Size = New Size(133, 16)
		lblSubForm.TabIndex = 1
		lblSubForm.Text = "SpotifyKu Digital ID"
		' 
		' pnlKartu
		' 
		pnlKartu.BackColor = Color.FromArgb(CByte(30), CByte(58), CByte(95))
		pnlKartu.Controls.Add(pnlBadge)
		pnlKartu.Controls.Add(lblKontakTitle)
		pnlKartu.Controls.Add(picIkonEmail)
		pnlKartu.Controls.Add(picIkonTelepon)
		pnlKartu.Controls.Add(lblHobby)
		pnlKartu.Controls.Add(pnlGaris2)
		pnlKartu.Controls.Add(lblHobbyTitle)
		pnlKartu.Controls.Add(lblEmail)
		pnlKartu.Controls.Add(lblTelepon)
		pnlKartu.Controls.Add(pnlGaris)
		pnlKartu.Controls.Add(lblKomunitas)
		pnlKartu.Controls.Add(lblId)
		pnlKartu.Controls.Add(lblNama)
		pnlKartu.Controls.Add(picFotoKartu)
		pnlKartu.Controls.Add(pnlAksen)
		pnlKartu.Location = New Point(14, 62)
		pnlKartu.Name = "pnlKartu"
		pnlKartu.Size = New Size(444, 353)
		pnlKartu.TabIndex = 2
		' 
		' pnlBadge
		' 
		pnlBadge.BackColor = Color.FromArgb(CByte(74), CByte(144), CByte(217))
		pnlBadge.Controls.Add(lblPeran)
		pnlBadge.Location = New Point(264, 146)
		pnlBadge.Name = "pnlBadge"
		pnlBadge.Size = New Size(162, 39)
		pnlBadge.TabIndex = 19
		' 
		' lblPeran
		' 
		lblPeran.Font = New Font("Calisto MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblPeran.ForeColor = Color.White
		lblPeran.Location = New Point(1, 14)
		lblPeran.Name = "lblPeran"
		lblPeran.Size = New Size(158, 25)
		lblPeran.TabIndex = 18
		lblPeran.Text = "Peran :"
		lblPeran.TextAlign = ContentAlignment.MiddleCenter
		' 
		' lblKontakTitle
		' 
		lblKontakTitle.AutoSize = True
		lblKontakTitle.Font = New Font("Calisto MT", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblKontakTitle.ForeColor = Color.FromArgb(CByte(159), CByte(200), CByte(240))
		lblKontakTitle.Location = New Point(42, 140)
		lblKontakTitle.Name = "lblKontakTitle"
		lblKontakTitle.Size = New Size(56, 16)
		lblKontakTitle.TabIndex = 17
		lblKontakTitle.Text = "Kontak:"
		' 
		' picIkonEmail
		' 
		picIkonEmail.Image = My.Resources.Resources.email
		picIkonEmail.Location = New Point(16, 200)
		picIkonEmail.Name = "picIkonEmail"
		picIkonEmail.Size = New Size(20, 20)
		picIkonEmail.SizeMode = PictureBoxSizeMode.Zoom
		picIkonEmail.TabIndex = 16
		picIkonEmail.TabStop = False
		' 
		' picIkonTelepon
		' 
		picIkonTelepon.Image = My.Resources.Resources.telepon
		picIkonTelepon.Location = New Point(16, 164)
		picIkonTelepon.Name = "picIkonTelepon"
		picIkonTelepon.Size = New Size(20, 20)
		picIkonTelepon.SizeMode = PictureBoxSizeMode.Zoom
		picIkonTelepon.TabIndex = 15
		picIkonTelepon.TabStop = False
		' 
		' lblHobby
		' 
		lblHobby.ForeColor = Color.FromArgb(CByte(200), CByte(225), CByte(255))
		lblHobby.Location = New Point(42, 284)
		lblHobby.Name = "lblHobby"
		lblHobby.Size = New Size(386, 36)
		lblHobby.TabIndex = 14
		lblHobby.Text = "Hobby"
		' 
		' pnlGaris2
		' 
		pnlGaris2.BackColor = Color.FromArgb(CByte(55), CByte(90), CByte(150))
		pnlGaris2.Location = New Point(16, 248)
		pnlGaris2.Name = "pnlGaris2"
		pnlGaris2.Size = New Size(412, 1)
		pnlGaris2.TabIndex = 13
		' 
		' lblHobbyTitle
		' 
		lblHobbyTitle.AutoSize = True
		lblHobbyTitle.Font = New Font("Calisto MT", 8.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblHobbyTitle.ForeColor = Color.FromArgb(CByte(159), CByte(200), CByte(240))
		lblHobbyTitle.Location = New Point(42, 264)
		lblHobbyTitle.Name = "lblHobbyTitle"
		lblHobbyTitle.Size = New Size(101, 16)
		lblHobbyTitle.TabIndex = 12
		lblHobbyTitle.Text = "Hobi/Aktivitas:"
		' 
		' lblEmail
		' 
		lblEmail.AutoSize = True
		lblEmail.ForeColor = Color.FromArgb(CByte(210), CByte(230), CByte(255))
		lblEmail.Location = New Point(42, 204)
		lblEmail.Name = "lblEmail"
		lblEmail.Size = New Size(62, 17)
		lblEmail.TabIndex = 10
		lblEmail.Text = "Email : -"
		' 
		' lblTelepon
		' 
		lblTelepon.AutoSize = True
		lblTelepon.ForeColor = Color.FromArgb(CByte(210), CByte(230), CByte(255))
		lblTelepon.Location = New Point(42, 168)
		lblTelepon.Name = "lblTelepon"
		lblTelepon.Size = New Size(76, 17)
		lblTelepon.TabIndex = 9
		lblTelepon.Text = "Telepon : -"
		' 
		' pnlGaris
		' 
		pnlGaris.BackColor = Color.FromArgb(CByte(55), CByte(90), CByte(150))
		pnlGaris.Location = New Point(14, 132)
		pnlGaris.Name = "pnlGaris"
		pnlGaris.Size = New Size(412, 1)
		pnlGaris.TabIndex = 6
		' 
		' lblKomunitas
		' 
		lblKomunitas.AutoSize = True
		lblKomunitas.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblKomunitas.ForeColor = Color.FromArgb(CByte(159), CByte(200), CByte(240))
		lblKomunitas.Location = New Point(122, 74)
		lblKomunitas.Name = "lblKomunitas"
		lblKomunitas.Size = New Size(98, 18)
		lblKomunitas.TabIndex = 4
		lblKomunitas.Text = "Komunitas : -"
		' 
		' lblId
		' 
		lblId.AutoSize = True
		lblId.Font = New Font("Calisto MT", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblId.ForeColor = Color.FromArgb(CByte(159), CByte(200), CByte(240))
		lblId.Location = New Point(122, 54)
		lblId.Name = "lblId"
		lblId.Size = New Size(44, 18)
		lblId.TabIndex = 3
		lblId.Text = "ID : -"
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.Font = New Font("Calisto MT", 15.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNama.ForeColor = Color.White
		lblNama.Location = New Point(122, 24)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(80, 28)
		lblNama.TabIndex = 2
		lblNama.Text = "Nama"
		' 
		' picFotoKartu
		' 
		picFotoKartu.BackColor = Color.FromArgb(CByte(55), CByte(90), CByte(150))
		picFotoKartu.Location = New Point(16, 20)
		picFotoKartu.Name = "picFotoKartu"
		picFotoKartu.Size = New Size(90, 110)
		picFotoKartu.SizeMode = PictureBoxSizeMode.Zoom
		picFotoKartu.TabIndex = 1
		picFotoKartu.TabStop = False
		' 
		' pnlAksen
		' 
		pnlAksen.BackColor = Color.FromArgb(CByte(74), CByte(144), CByte(217))
		pnlAksen.Controls.Add(Panel1)
		pnlAksen.Location = New Point(0, 0)
		pnlAksen.Name = "pnlAksen"
		pnlAksen.Size = New Size(444, 6)
		pnlAksen.TabIndex = 0
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.FromArgb(CByte(74), CByte(144), CByte(217))
		Panel1.Location = New Point(0, 0)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(444, 6)
		Panel1.TabIndex = 1
		' 
		' FormKartu
		' 
		AutoScaleDimensions = New SizeF(9.0F, 17.0F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(235), CByte(242), CByte(252))
		ClientSize = New Size(462, 429)
		Controls.Add(pnlKartu)
		Controls.Add(lblSubForm)
		Controls.Add(lblJudulForm)
		Font = New Font("Calisto MT", 9.0F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		Name = "FormKartu"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Kartu Anggota — SpotifyKu"
		pnlKartu.ResumeLayout(False)
		pnlKartu.PerformLayout()
		pnlBadge.ResumeLayout(False)
		CType(picIkonEmail, ISupportInitialize).EndInit()
		CType(picIkonTelepon, ISupportInitialize).EndInit()
		CType(picFotoKartu, ISupportInitialize).EndInit()
		pnlAksen.ResumeLayout(False)
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblJudulForm As Label
	Friend WithEvents lblSubForm As Label
	Friend WithEvents pnlKartu As Panel
	Friend WithEvents lblNama As Label
	Friend WithEvents picFotoKartu As PictureBox
	Friend WithEvents pnlAksen As Panel
	Friend WithEvents lblKomunitas As Label
	Friend WithEvents lblId As Label
	Friend WithEvents lblEmail As Label
	Friend WithEvents lblTelepon As Label
	Friend WithEvents pnlGaris As Panel
	Friend WithEvents pnlGaris2 As Panel
	Friend WithEvents lblHobbyTitle As Label
	Friend WithEvents lblHobby As Label
	Friend WithEvents picIkonTelepon As PictureBox
	Friend WithEvents picIkonEmail As PictureBox
	Friend WithEvents lblKontakTitle As Label
	Friend WithEvents pnlBadge As Panel
	Friend WithEvents lblPeran As Label
	Friend WithEvents Panel1 As Panel
End Class
