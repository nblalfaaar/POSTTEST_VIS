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
		Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle11 As DataGridViewCellStyle = New DataGridViewCellStyle()
		Dim DataGridViewCellStyle12 As DataGridViewCellStyle = New DataGridViewCellStyle()
		pnlHeader = New Panel()
		lblNamaHeader = New Label()
		lblSubHeader = New Label()
		Label1 = New Label()
		lblKodeVal = New Label()
		Label2 = New Label()
		lblNamaVal = New Label()
		Label3 = New Label()
		lblTanggalVal = New Label()
		Label4 = New Label()
		lblDeskripsiVal = New Label()
		lblSectionLagu = New Label()
		dgvDetailLagu = New DataGridView()
		kodeLagu = New DataGridViewTextBoxColumn()
		judulLagu = New DataGridViewTextBoxColumn()
		artis = New DataGridViewTextBoxColumn()
		genre = New DataGridViewTextBoxColumn()
		durasi = New DataGridViewTextBoxColumn()
		linkSpotify = New DataGridViewTextBoxColumn()
		lblJumlahLagu = New Label()
		btnTutup = New Button()
		PictureBox1 = New PictureBox()
		pnlHeader.SuspendLayout()
		CType(dgvDetailLagu, ComponentModel.ISupportInitialize).BeginInit()
		CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
		SuspendLayout()
		' 
		' pnlHeader
		' 
		pnlHeader.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		pnlHeader.Controls.Add(PictureBox1)
		pnlHeader.Location = New Point(0, 0)
		pnlHeader.Name = "pnlHeader"
		pnlHeader.Size = New Size(644, 65)
		pnlHeader.TabIndex = 0
		' 
		' lblNamaHeader
		' 
		lblNamaHeader.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		lblNamaHeader.Font = New Font("Calisto MT", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNamaHeader.Location = New Point(68, 14)
		lblNamaHeader.Name = "lblNamaHeader"
		lblNamaHeader.Size = New Size(380, 22)
		lblNamaHeader.TabIndex = 2
		lblNamaHeader.Text = "Label1"
		' 
		' lblSubHeader
		' 
		lblSubHeader.AutoSize = True
		lblSubHeader.ForeColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		lblSubHeader.Location = New Point(68, 38)
		lblSubHeader.Name = "lblSubHeader"
		lblSubHeader.Size = New Size(52, 17)
		lblSubHeader.TabIndex = 3
		lblSubHeader.Text = "Label1"
		' 
		' Label1
		' 
		Label1.AutoSize = True
		Label1.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label1.Location = New Point(20, 78)
		Label1.Name = "Label1"
		Label1.Size = New Size(43, 17)
		Label1.TabIndex = 4
		Label1.Text = "Kode"
		' 
		' lblKodeVal
		' 
		lblKodeVal.AutoSize = True
		lblKodeVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblKodeVal.Location = New Point(105, 78)
		lblKodeVal.Name = "lblKodeVal"
		lblKodeVal.Size = New Size(52, 18)
		lblKodeVal.TabIndex = 5
		lblKodeVal.Text = "Label2"
		' 
		' Label2
		' 
		Label2.AutoSize = True
		Label2.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label2.Location = New Point(240, 78)
		Label2.Name = "Label2"
		Label2.Size = New Size(98, 17)
		Label2.TabIndex = 6
		Label2.Text = "Nama Playlist"
		' 
		' lblNamaVal
		' 
		lblNamaVal.AutoSize = True
		lblNamaVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNamaVal.Location = New Point(360, 78)
		lblNamaVal.Name = "lblNamaVal"
		lblNamaVal.Size = New Size(52, 18)
		lblNamaVal.TabIndex = 7
		lblNamaVal.Text = "Label2"
		' 
		' Label3
		' 
		Label3.AutoSize = True
		Label3.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label3.Location = New Point(490, 78)
		Label3.Name = "Label3"
		Label3.Size = New Size(58, 17)
		Label3.TabIndex = 8
		Label3.Text = "Tanggal"
		' 
		' lblTanggalVal
		' 
		lblTanggalVal.AutoSize = True
		lblTanggalVal.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblTanggalVal.Location = New Point(490, 103)
		lblTanggalVal.Name = "lblTanggalVal"
		lblTanggalVal.Size = New Size(52, 18)
		lblTanggalVal.TabIndex = 9
		lblTanggalVal.Text = "Label2"
		' 
		' Label4
		' 
		Label4.AutoSize = True
		Label4.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		Label4.Location = New Point(20, 103)
		Label4.Name = "Label4"
		Label4.Size = New Size(68, 17)
		Label4.TabIndex = 10
		Label4.Text = "Deskripsi"
		' 
		' lblDeskripsiVal
		' 
		lblDeskripsiVal.AutoSize = True
		lblDeskripsiVal.Font = New Font("Calisto MT", 9F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
		lblDeskripsiVal.Location = New Point(95, 103)
		lblDeskripsiVal.Name = "lblDeskripsiVal"
		lblDeskripsiVal.Size = New Size(47, 18)
		lblDeskripsiVal.TabIndex = 11
		lblDeskripsiVal.Text = "Label2"
		' 
		' lblSectionLagu
		' 
		lblSectionLagu.AutoSize = True
		lblSectionLagu.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblSectionLagu.ForeColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		lblSectionLagu.Location = New Point(20, 142)
		lblSectionLagu.Name = "lblSectionLagu"
		lblSectionLagu.Size = New Size(90, 18)
		lblSectionLagu.TabIndex = 12
		lblSectionLagu.Text = "Daftar Lagu"
		' 
		' dgvDetailLagu
		' 
		dgvDetailLagu.AllowUserToAddRows = False
		dgvDetailLagu.BackgroundColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		dgvDetailLagu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
		dgvDetailLagu.Columns.AddRange(New DataGridViewColumn() {kodeLagu, judulLagu, artis, genre, durasi, linkSpotify})
		dgvDetailLagu.GridColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		dgvDetailLagu.Location = New Point(0, 163)
		dgvDetailLagu.Name = "dgvDetailLagu"
		dgvDetailLagu.ReadOnly = True
		dgvDetailLagu.RowHeadersWidth = 51
		dgvDetailLagu.SelectionMode = DataGridViewSelectionMode.FullRowSelect
		dgvDetailLagu.Size = New Size(644, 275)
		dgvDetailLagu.TabIndex = 13
		' 
		' kodeLagu
		' 
		kodeLagu.DataPropertyName = "kodeLagu"
		DataGridViewCellStyle7.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle7.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle7.SelectionForeColor = Color.White
		kodeLagu.DefaultCellStyle = DataGridViewCellStyle7
		kodeLagu.HeaderText = "Kode"
		kodeLagu.MinimumWidth = 6
		kodeLagu.Name = "kodeLagu"
		kodeLagu.ReadOnly = True
		kodeLagu.Width = 55
		' 
		' judulLagu
		' 
		judulLagu.DataPropertyName = "judulLagu"
		DataGridViewCellStyle8.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle8.SelectionForeColor = Color.White
		judulLagu.DefaultCellStyle = DataGridViewCellStyle8
		judulLagu.HeaderText = "Judul Lagu"
		judulLagu.MinimumWidth = 6
		judulLagu.Name = "judulLagu"
		judulLagu.ReadOnly = True
		judulLagu.Width = 170
		' 
		' artis
		' 
		artis.DataPropertyName = "artis"
		DataGridViewCellStyle9.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle9.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle9.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle9.SelectionForeColor = Color.White
		artis.DefaultCellStyle = DataGridViewCellStyle9
		artis.HeaderText = "Artis"
		artis.MinimumWidth = 6
		artis.Name = "artis"
		artis.ReadOnly = True
		artis.Width = 120
		' 
		' genre
		' 
		genre.DataPropertyName = "genre"
		DataGridViewCellStyle10.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle10.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle10.SelectionForeColor = Color.White
		genre.DefaultCellStyle = DataGridViewCellStyle10
		genre.HeaderText = "Genre"
		genre.MinimumWidth = 6
		genre.Name = "genre"
		genre.ReadOnly = True
		genre.Width = 70
		' 
		' durasi
		' 
		durasi.DataPropertyName = "durasi"
		DataGridViewCellStyle11.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle11.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle11.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle11.SelectionForeColor = Color.White
		durasi.DefaultCellStyle = DataGridViewCellStyle11
		durasi.HeaderText = "Durasi"
		durasi.MinimumWidth = 6
		durasi.Name = "durasi"
		durasi.ReadOnly = True
		durasi.Width = 60
		' 
		' linkSpotify
		' 
		linkSpotify.DataPropertyName = "linkSpotify"
		DataGridViewCellStyle12.BackColor = Color.FromArgb(CByte(3), CByte(47), CByte(48))
		DataGridViewCellStyle12.ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		DataGridViewCellStyle12.SelectionBackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156))
		DataGridViewCellStyle12.SelectionForeColor = Color.White
		linkSpotify.DefaultCellStyle = DataGridViewCellStyle12
		linkSpotify.HeaderText = "Link Spotify"
		linkSpotify.MinimumWidth = 6
		linkSpotify.Name = "linkSpotify"
		linkSpotify.ReadOnly = True
		linkSpotify.Width = 110
		' 
		' lblJumlahLagu
		' 
		lblJumlahLagu.AutoSize = True
		lblJumlahLagu.ForeColor = Color.FromArgb(CByte(107), CByte(163), CByte(190))
		lblJumlahLagu.Location = New Point(20, 448)
		lblJumlahLagu.Name = "lblJumlahLagu"
		lblJumlahLagu.Size = New Size(82, 17)
		lblJumlahLagu.TabIndex = 14
		lblJumlahLagu.Text = "jumlah lagu"
		' 
		' btnTutup
		' 
		btnTutup.BackColor = Color.FromArgb(CByte(10), CByte(112), CByte(117))
		btnTutup.Cursor = Cursors.Hand
		btnTutup.FlatAppearance.BorderSize = 0
		btnTutup.FlatStyle = FlatStyle.Flat
		btnTutup.Font = New Font("Calisto MT", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnTutup.ForeColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		btnTutup.Location = New Point(524, 444)
		btnTutup.Name = "btnTutup"
		btnTutup.Size = New Size(100, 28)
		btnTutup.TabIndex = 15
		btnTutup.Text = "Tutup"
		btnTutup.UseVisualStyleBackColor = False
		' 
		' PictureBox1
		' 
		PictureBox1.BackColor = Color.FromArgb(CByte(12), CByte(150), CByte(156), CByte(34))
		PictureBox1.Image = My.Resources.Resources.image_removebg_preview
		PictureBox1.Location = New Point(14, 12)
		PictureBox1.Name = "PictureBox1"
		PictureBox1.Size = New Size(42, 42)
		PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
		PictureBox1.TabIndex = 0
		PictureBox1.TabStop = False
		' 
		' FormDetail
		' 
		AutoScaleDimensions = New SizeF(9F, 17F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(3), CByte(23), CByte(22))
		ClientSize = New Size(642, 473)
		Controls.Add(btnTutup)
		Controls.Add(lblJumlahLagu)
		Controls.Add(dgvDetailLagu)
		Controls.Add(lblSectionLagu)
		Controls.Add(lblDeskripsiVal)
		Controls.Add(Label4)
		Controls.Add(lblTanggalVal)
		Controls.Add(Label3)
		Controls.Add(lblNamaVal)
		Controls.Add(Label2)
		Controls.Add(lblKodeVal)
		Controls.Add(Label1)
		Controls.Add(lblSubHeader)
		Controls.Add(lblNamaHeader)
		Controls.Add(pnlHeader)
		Font = New Font("Calisto MT", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		ForeColor = Color.FromArgb(CByte(224), CByte(244), CByte(243))
		FormBorderStyle = FormBorderStyle.FixedDialog
		MaximizeBox = False
		MinimizeBox = False
		Name = "FormDetail"
		StartPosition = FormStartPosition.CenterParent
		Text = "Detail Playlist"
		pnlHeader.ResumeLayout(False)
		CType(dgvDetailLagu, ComponentModel.ISupportInitialize).EndInit()
		CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents pnlHeader As Panel
	Friend WithEvents lblNamaHeader As Label
	Friend WithEvents lblSubHeader As Label
	Friend WithEvents Label1 As Label
	Friend WithEvents lblKodeVal As Label
	Friend WithEvents Label2 As Label
	Friend WithEvents lblNamaVal As Label
	Friend WithEvents Label3 As Label
	Friend WithEvents lblTanggalVal As Label
	Friend WithEvents Label4 As Label
	Friend WithEvents lblDeskripsiVal As Label
	Friend WithEvents lblSectionLagu As Label
	Friend WithEvents dgvDetailLagu As DataGridView
	Friend WithEvents lblJumlahLagu As Label
	Friend WithEvents btnTutup As Button
	Friend WithEvents kodeLagu As DataGridViewTextBoxColumn
	Friend WithEvents judulLagu As DataGridViewTextBoxColumn
	Friend WithEvents artis As DataGridViewTextBoxColumn
	Friend WithEvents genre As DataGridViewTextBoxColumn
	Friend WithEvents durasi As DataGridViewTextBoxColumn
	Friend WithEvents linkSpotify As DataGridViewTextBoxColumn
	Friend WithEvents PictureBox1 As PictureBox
End Class
