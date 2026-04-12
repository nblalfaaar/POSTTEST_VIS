<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormDetail
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
		lblJudulLaguHeader = New Label()
		lblSubHeader = New Label()
		Label1 = New Label()
		lblKodeVal = New Label()
		Label2 = New Label()
		lblJudulVal = New Label()
		Label3 = New Label()
		lblArtisVal = New Label()
		Label4 = New Label()
		lblGenreVal = New Label()
		Label5 = New Label()
		lblDurasiVal = New Label()
		btnTutup = New Button()
		PictureBox1 = New PictureBox()
		Label6 = New Label()
		lblLinkVal = New Label()
		btnSpotify = New Button()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		pnlHeader.Location = New Point(0, 0)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(344, 65)
		pnlHeader.TabIndex = 0
		' 
		' lblJudulLaguHeader
		' 
		lblJudulLaguHeader.AutoSize = True
		lblJudulLaguHeader.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		lblJudulLaguHeader.Font = New Font("Calisto MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudulLaguHeader.Location = New Point(68, 14)
		lblJudulLaguHeader.Name = "lblJudulLaguHeader"
		lblJudulLaguHeader.Size = New Size(105, 21)
		lblJudulLaguHeader.TabIndex = 2
		lblJudulLaguHeader.Text = "SoundVault"
		' 
		' lblSubHeader
		' 
		lblSubHeader.AutoSize = True
		lblSubHeader.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		lblSubHeader.ForeColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		lblSubHeader.Location = New Point(68, 38)
		lblSubHeader.Name = "lblSubHeader"
		lblSubHeader.Size = New Size(83, 17)
		lblSubHeader.TabIndex = 3
		lblSubHeader.Text = "Detail Lagu"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label1.Location = New Point(20, 82)
		Label1.Name = "Label1"
		Label1.Size = New Size(43, 17)
		Label1.TabIndex = 4
		Label1.Text = "Kode"
		' 
		' lblKodeVal
		' 
		lblKodeVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblKodeVal.Location = New Point(150, 82)
		lblKodeVal.Name = "lblKodeVal"
		lblKodeVal.Size = New Size(170, 18)
		lblKodeVal.TabIndex = 5
		lblKodeVal.Text = "Label2"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label2.Location = New Point(20, 112)
		Label2.Name = "Label2"
		Label2.Size = New Size(43, 17)
		Label2.TabIndex = 6
		Label2.Text = "Judul"
		' 
		' lblJudulVal
		' 
		lblJudulVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudulVal.Location = New Point(150, 112)
		lblJudulVal.Name = "lblJudulVal"
		lblJudulVal.Size = New Size(170, 18)
		lblJudulVal.TabIndex = 7
		lblJudulVal.Text = "Label2"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label3.Location = New Point(20, 142)
		Label3.Name = "Label3"
		Label3.Size = New Size(40, 17)
		Label3.TabIndex = 8
		Label3.Text = "Artis"
		' 
		' lblArtisVal
		' 
		lblArtisVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblArtisVal.Location = New Point(150, 142)
		lblArtisVal.Name = "lblArtisVal"
		lblArtisVal.Size = New Size(170, 18)
		lblArtisVal.TabIndex = 9
		lblArtisVal.Text = "Label2"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label4.Location = New Point(20, 172)
		Label4.Name = "Label4"
		Label4.Size = New Size(47, 17)
		Label4.TabIndex = 10
		Label4.Text = "Genre"
		' 
		' lblGenreVal
		' 
		lblGenreVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblGenreVal.Location = New Point(150, 172)
		lblGenreVal.Name = "lblGenreVal"
		lblGenreVal.Size = New Size(170, 18)
		lblGenreVal.TabIndex = 11
		lblGenreVal.Text = "Label2"
		' 
		' Label5
		' 
		Label5.AutoSize = True
		Label5.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label5.Location = New Point(20, 202)
		Label5.Name = "Label5"
		Label5.Size = New Size(50, 17)
		Label5.TabIndex = 12
		Label5.Text = "Durasi"
		' 
		' lblDurasiVal
		' 
		lblDurasiVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblDurasiVal.Location = New Point(150, 202)
		lblDurasiVal.Name = "lblDurasiVal"
		lblDurasiVal.Size = New Size(170, 18)
		lblDurasiVal.TabIndex = 13
		lblDurasiVal.Text = "Label2"
		' 
		' btnTutup
		' 
		btnTutup.BackColor = Color.FromArgb(CByte(10), CByte(112), CByte(117))
		btnTutup.Cursor = Cursors.Hand
		btnTutup.FlatAppearance.BorderSize = 0
		btnTutup.FlatStyle = FlatStyle.Flat
		btnTutup.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnTutup.ForeColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		btnTutup.Location = New Point(174, 258)
		btnTutup.Name = "btnTutup"
		btnTutup.Size = New Size(150, 32)
		btnTutup.TabIndex = 14
		btnTutup.Text = "Tutup"
		btnTutup.UseVisualStyleBackColor = False
		' 
		' PictureBox1
		' 
		PictureBox1.Image = My.Resources.Resources.image_removebg_preview
		PictureBox1.Location = New Point(14, 12)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(42, 42)
		PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox1.TabIndex = 15
		PictureBox1.TabStop = False
		' 
		' Label6
		' 
		Label6.AutoSize = True
		Label6.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label6.Location = New Point(20, 222)
		Label6.Name = "Label6"
		Label6.Size = New Size(88, 17)
		Label6.TabIndex = 16
		Label6.Text = "Link Spotify"
		' 
		' lblLinkVal
		' 
		lblLinkVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblLinkVal.Location = New Point(150, 222)
		lblLinkVal.Name = "lblLinkVal"
		lblLinkVal.Size = New Size(170, 18)
		lblLinkVal.TabIndex = 17
		lblLinkVal.Text = "Label2"
		' 
		' btnSpotify
		' 
		btnSpotify.BackColor = Color.FromArgb(CByte(29), CByte(185), CByte(84))
		btnSpotify.Cursor = Cursors.Hand
		btnSpotify.FlatAppearance.BorderSize = 0
		btnSpotify.FlatStyle = FlatStyle.Flat
		btnSpotify.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnSpotify.ForeColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		btnSpotify.Location = New Point(20, 258)
		btnSpotify.Name = "btnSpotify"
		btnSpotify.Size = New Size(144, 32)
		btnSpotify.TabIndex = 18
		btnSpotify.Text = "Buka di Spotify"
		btnSpotify.UseVisualStyleBackColor = False
		' 
		' FormDetail
		' 
		AutoScaleDimensions = New SizeF(9F, 17F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		ClientSize = New Size(342, 293)
		Controls.Add(btnSpotify)
		Controls.Add(lblLinkVal)
		Controls.Add(Label6)
		Controls.Add(PictureBox1)
		Controls.Add(btnTutup)
		Controls.Add(lblDurasiVal)
		Controls.Add(Label5)
		Controls.Add(lblGenreVal)
		Controls.Add(Label4)
		Controls.Add(lblArtisVal)
		Controls.Add(Label3)
		Controls.Add(lblJudulVal)
		Controls.Add(Label2)
		Controls.Add(lblKodeVal)
		Controls.Add(Label1)
		Controls.Add(lblSubHeader)
		Controls.Add(lblJudulLaguHeader)
		Controls.Add(pnlHeader)
		Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		FormBorderStyle = FormBorderStyle.FixedDialog
		MaximizeBox = False
		MinimizeBox = False
		Name = "FormDetail"
		StartPosition = FormStartPosition.CenterParent
		Text = "Detail Lagu"
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblJudulLaguHeader As Label
	Friend WithEvents lblSubHeader As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lblKodeVal As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lblJudulVal As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblArtisVal As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents lblGenreVal As Label
	Friend WithEvents Label5 As Label
	Friend WithEvents lblDurasiVal As Label
	Friend WithEvents btnTutup As Button
	Friend WithEvents PictureBox1 As PictureBox
	Friend WithEvents Label6 As Label
	Friend WithEvents lblLinkVal As Label
	Friend WithEvents btnSpotify As Button
End Class
