<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()> _
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
	<System.Diagnostics.DebuggerStepThrough()> _
	Private Sub InitializeComponent()
		pnlHeader = New Panel()
		Label4 = New Label()
		Label1 = New Label()
		Panel1 = New Panel()
		pnlFooter = New Panel()
		Label2 = New Label()
		PictureBox1 = New PictureBox()
		lblKeyNama = New Label()
		lblKeyUmur = New Label()
		lblKeyTlahir = New Label()
		lblKeyJK = New Label()
		lblKeyTelpon = New Label()
		lblKeyHobi = New Label()
		lblKeyAlamat = New Label()
		lblNama = New Label()
		lblUmur = New Label()
		lblTLahir = New Label()
		lblJK = New Label()
		lblTelpon = New Label()
		lblHobi = New Label()
		lblAlamat = New Label()
		PictureBox2 = New PictureBox()
		pnlHeader.SuspendLayout()
		pnlFooter.SuspendLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(35))
		pnlHeader.Controls.Add(Label4)
		pnlHeader.Controls.Add(Label1)
		pnlHeader.Controls.Add(Panel1)
		pnlHeader.Dock = DockStyle.Top
		pnlHeader.Location = New Point(0, 0)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(582, 65)
		pnlHeader.TabIndex = 0
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.BackColor = Color.Transparent
		Label4.ForeColor = Color.FromArgb(CByte(155), CByte(114), CByte(207))
		Label4.Location = New Point(231, 35)
		Label4.Name = "Label4"
		Label4.Size = New Size(98, 17)
		Label4.TabIndex = 17
		Label4.Text = "Member Card"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.BackColor = Color.Transparent
		Label1.Font = New Font("Calisto MT", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label1.ForeColor = Color.FromArgb(CByte(232), CByte(213), CByte(245))
		Label1.Location = New Point(178, 9)
		Label1.Name = "Label1"
		Label1.Size = New Size(213, 26)
		Label1.TabIndex = 2
		Label1.Text = "Spotify Community"
		Label1.TextAlign = ContentAlignment.MiddleCenter
		' 
		' Panel1
		' 
		Panel1.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		Panel1.Dock = DockStyle.Top
		Panel1.Location = New Point(0, 0)
		Panel1.Name = "Panel1"
		Panel1.Size = New Size(582, 0)
		Panel1.TabIndex = 1
		' 
		' pnlFooter
		' 
		pnlFooter.BackColor = Color.FromArgb(CByte(15), CByte(15), CByte(35))
		pnlFooter.Controls.Add(Label2)
		pnlFooter.Dock = DockStyle.Bottom
		pnlFooter.Location = New Point(0, 313)
		pnlFooter.Name = "pnlFooter"
		pnlFooter.Size = New Size(582, 55)
		pnlFooter.TabIndex = 1
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.BackColor = Color.Transparent
		Label2.Font = New Font("Calisto MT", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		Label2.ForeColor = Color.FromArgb(CByte(155), CByte(114), CByte(207))
		Label2.Location = New Point(178, 13)
		Label2.Name = "Label2"
		Label2.Size = New Size(215, 22)
		Label2.TabIndex = 3
		Label2.Text = "Member Identification"
		Label2.TextAlign = ContentAlignment.MiddleCenter
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.FromArgb(CByte(13), CByte(27), CByte(75))
		PictureBox1.BorderStyle = BorderStyle.FixedSingle
		PictureBox1.Location = New Point(18, 68)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(90, 120)
		PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox1.TabIndex = 2
		PictureBox1.TabStop = False
		' 
		' lblKeyNama
		' 
		lblKeyNama.AutoSize = True
		lblKeyNama.BackColor = Color.Transparent
		lblKeyNama.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblKeyNama.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblKeyNama.Location = New Point(125, 68)
		lblKeyNama.Name = "lblKeyNama"
		lblKeyNama.Size = New Size(53, 18)
		lblKeyNama.TabIndex = 3
		lblKeyNama.Text = "Nama:"
		' 
		' lblKeyUmur
		' 
		lblKeyUmur.AutoSize = True
		lblKeyUmur.BackColor = Color.Transparent
		lblKeyUmur.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblKeyUmur.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblKeyUmur.Location = New Point(125, 90)
		lblKeyUmur.Name = "lblKeyUmur"
		lblKeyUmur.Size = New Size(51, 18)
		lblKeyUmur.TabIndex = 4
		lblKeyUmur.Text = "Umur:"
		' 
		' lblKeyTlahir
		' 
		lblKeyTlahir.AutoSize = True
		lblKeyTlahir.BackColor = Color.Transparent
		lblKeyTlahir.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblKeyTlahir.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblKeyTlahir.Location = New Point(125, 112)
		lblKeyTlahir.Name = "lblKeyTlahir"
		lblKeyTlahir.Size = New Size(108, 18)
		lblKeyTlahir.TabIndex = 5
		lblKeyTlahir.Text = "Tanggal Lahir:"
		' 
		' lblKeyJK
		' 
		lblKeyJK.AutoSize = True
		lblKeyJK.BackColor = Color.Transparent
		lblKeyJK.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblKeyJK.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblKeyJK.Location = New Point(125, 134)
		lblKeyJK.Name = "lblKeyJK"
		lblKeyJK.Size = New Size(104, 18)
		lblKeyJK.TabIndex = 6
		lblKeyJK.Text = "Jenis Kelamin:"
		' 
		' lblKeyTelpon
		' 
		lblKeyTelpon.AutoSize = True
		lblKeyTelpon.BackColor = Color.Transparent
		lblKeyTelpon.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblKeyTelpon.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblKeyTelpon.Location = New Point(125, 156)
		lblKeyTelpon.Name = "lblKeyTelpon"
		lblKeyTelpon.Size = New Size(92, 18)
		lblKeyTelpon.TabIndex = 7
		lblKeyTelpon.Text = "No Telepon:"
		' 
		' lblKeyHobi
		' 
		lblKeyHobi.AutoSize = True
		lblKeyHobi.BackColor = Color.Transparent
		lblKeyHobi.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblKeyHobi.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblKeyHobi.Location = New Point(125, 178)
		lblKeyHobi.Name = "lblKeyHobi"
		lblKeyHobi.Size = New Size(47, 18)
		lblKeyHobi.TabIndex = 8
		lblKeyHobi.Text = "Hobi:"
		' 
		' lblKeyAlamat
		' 
		lblKeyAlamat.AutoSize = True
		lblKeyAlamat.BackColor = Color.Transparent
		lblKeyAlamat.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblKeyAlamat.ForeColor = Color.FromArgb(CByte(184), CByte(204), CByte(244))
		lblKeyAlamat.Location = New Point(125, 250)
		lblKeyAlamat.Name = "lblKeyAlamat"
		lblKeyAlamat.Size = New Size(62, 18)
		lblKeyAlamat.TabIndex = 9
		lblKeyAlamat.Text = "Alamat:"
		' 
		' lblNama
		' 
		lblNama.AutoSize = True
		lblNama.BackColor = Color.Transparent
		lblNama.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblNama.ForeColor = Color.White
		lblNama.Location = New Point(240, 68)
		lblNama.Name = "lblNama"
		lblNama.Size = New Size(0, 18)
		lblNama.TabIndex = 10
		' 
		' lblUmur
		' 
		lblUmur.AutoSize = True
		lblUmur.BackColor = Color.Transparent
		lblUmur.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblUmur.ForeColor = Color.White
		lblUmur.Location = New Point(240, 90)
		lblUmur.Name = "lblUmur"
		lblUmur.Size = New Size(0, 18)
		lblUmur.TabIndex = 11
		' 
		' lblTLahir
		' 
		lblTLahir.AutoSize = True
		lblTLahir.BackColor = Color.Transparent
		lblTLahir.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblTLahir.ForeColor = Color.White
		lblTLahir.Location = New Point(240, 112)
		lblTLahir.Name = "lblTLahir"
		lblTLahir.Size = New Size(0, 18)
		lblTLahir.TabIndex = 12
		' 
		' lblJK
		' 
		lblJK.AutoSize = True
		lblJK.BackColor = Color.Transparent
		lblJK.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblJK.ForeColor = Color.White
		lblJK.Location = New Point(240, 134)
		lblJK.Name = "lblJK"
		lblJK.Size = New Size(0, 18)
		lblJK.TabIndex = 13
		' 
		' lblTelpon
		' 
		lblTelpon.AutoSize = True
		lblTelpon.BackColor = Color.Transparent
		lblTelpon.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblTelpon.ForeColor = Color.White
		lblTelpon.Location = New Point(240, 156)
		lblTelpon.Name = "lblTelpon"
		lblTelpon.Size = New Size(0, 18)
		lblTelpon.TabIndex = 14
		' 
		' lblHobi
		' 
		lblHobi.BackColor = Color.Transparent
		lblHobi.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblHobi.ForeColor = Color.White
		lblHobi.Location = New Point(240, 178)
		lblHobi.Name = "lblHobi"
		lblHobi.Size = New Size(320, 65)
		lblHobi.TabIndex = 15
		' 
		' lblAlamat
		' 
		lblAlamat.BackColor = Color.Transparent
		lblAlamat.Font = New Font("Calisto MT", 9F, FontStyle.Bold)
		lblAlamat.ForeColor = Color.White
		lblAlamat.Location = New Point(240, 247)
		lblAlamat.Name = "lblAlamat"
		lblAlamat.Size = New Size(320, 36)
		lblAlamat.TabIndex = 16
		' 
		' PictureBox2
		' 
		PictureBox2.BackColor = Color.Transparent
		PictureBox2.Image = My.Resources.Resources.IMGBIN_com___Download_Transparent_PNG_Images__For_Free_removebg_preview
		PictureBox2.Location = New Point(445, 81)
		PictureBox2.Name = "PictureBox2"
		PictureBox2.Size = New Size(115, 81)
		PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
		PictureBox2.TabIndex = 17
		PictureBox2.TabStop = False
		' 
		' Form2
		' 
		AutoScaleDimensions = New SizeF(9F, 17F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(22), CByte(33), CByte(62))
		ClientSize = New Size(582, 368)
		Controls.Add(PictureBox2)
		Controls.Add(lblAlamat)
		Controls.Add(lblHobi)
		Controls.Add(lblTelpon)
		Controls.Add(lblJK)
		Controls.Add(lblTLahir)
		Controls.Add(lblUmur)
		Controls.Add(lblNama)
		Controls.Add(lblKeyAlamat)
		Controls.Add(lblKeyHobi)
		Controls.Add(lblKeyTelpon)
		Controls.Add(lblKeyJK)
		Controls.Add(lblKeyTlahir)
		Controls.Add(lblKeyUmur)
		Controls.Add(lblKeyNama)
		Controls.Add(PictureBox1)
		Controls.Add(pnlFooter)
		Controls.Add(pnlHeader)
		Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		FormBorderStyle = FormBorderStyle.FixedSingle
		MaximizeBox = False
		Name = "Form2"
		Text = "Form Hasil kartu"
		pnlHeader.ResumeLayout(False)
		pnlHeader.PerformLayout()
		pnlFooter.ResumeLayout(False)
		pnlFooter.PerformLayout()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents Panel1 As Panel
	Friend WithEvents pnlFooter As Panel
	Friend WithEvents PictureBox1 As PictureBox
	Private lblKeyNama As Label
	Private lblKeyUmur As Label
	Friend WithEvents lblNama As Label
	Friend WithEvents lblUmur As Label
	Private lblTLahir As Label
	Friend WithEvents lblKeyTlahir As Label
	Friend WithEvents lblKeyJK As Label
	Friend WithEvents lblKeyTelpon As Label
	Friend WithEvents lblKeyHobi As Label
	Friend WithEvents lblKeyAlamat As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblJK As Label
	Friend WithEvents lblTelpon As Label
	Friend WithEvents lblHobi As Label
	Friend WithEvents lblAlamat As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents PictureBox2 As PictureBox
End Class
