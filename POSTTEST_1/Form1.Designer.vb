<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
	Inherits System.Windows.Forms.Form

	'Form overrides dispose to clean up the component list.
	<System.Diagnostics.DebuggerNonUserCode()>
	Protected Overrides Sub Dispose(disposing As Boolean)
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
		lblJudul = New Label()
		lblInputIP = New Label()
		txtInput = New TextBox()
		btnTambah = New Button()
		btnReset = New Button()
		panelIPK = New Panel()
		lblPredikat = New Label()
		lblNilaiIPK = New Label()
		lblIPK = New Label()
		panelIPK.SuspendLayout()
		SuspendLayout()
		' 
		' lblJudul
		' 
		lblJudul.AutoSize = True
		lblJudul.BackColor = Color.Transparent
		lblJudul.Font = New Font("Californian FB", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblJudul.ForeColor = Color.FromArgb(CByte(142), CByte(182), CByte(155))
		lblJudul.Location = New Point(59, 34)
		lblJudul.Name = "lblJudul"
		lblJudul.Size = New Size(369, 39)
		lblJudul.TabIndex = 0
		lblJudul.Text = "Sistem Perhitungan IPK"
		' 
		' lblInputIP
		' 
		lblInputIP.AutoSize = True
		lblInputIP.BackColor = Color.Transparent
		lblInputIP.Font = New Font("Californian FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblInputIP.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
		lblInputIP.Location = New Point(12, 126)
		lblInputIP.Name = "lblInputIP"
		lblInputIP.Size = New Size(68, 16)
		lblInputIP.TabIndex = 1
		lblInputIP.Text = "IP Semester"
		' 
		' txtInput
		' 
		txtInput.BackColor = Color.FromArgb(CByte(15), CByte(52), CByte(96))
		txtInput.BorderStyle = BorderStyle.FixedSingle
		txtInput.Font = New Font("Comic Sans MS", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		txtInput.ForeColor = Color.White
		txtInput.Location = New Point(12, 156)
		txtInput.Name = "txtInput"
		txtInput.Size = New Size(260, 40)
		txtInput.TabIndex = 2
		' 
		' btnTambah
		' 
		btnTambah.BackColor = Color.FromArgb(CByte(79), CByte(255), CByte(176))
		btnTambah.Cursor = Cursors.Hand
		btnTambah.FlatAppearance.BorderSize = 0
		btnTambah.FlatStyle = FlatStyle.Flat
		btnTambah.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnTambah.ForeColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
		btnTambah.Location = New Point(284, 156)
		btnTambah.Name = "btnTambah"
		btnTambah.Size = New Size(90, 40)
		btnTambah.TabIndex = 3
		btnTambah.Text = "+Tambah"
		btnTambah.UseVisualStyleBackColor = False
		' 
		' btnReset
		' 
		btnReset.BackColor = Color.FromArgb(CByte(255), CByte(107), CByte(107))
		btnReset.Cursor = Cursors.Hand
		btnReset.FlatAppearance.BorderSize = 0
		btnReset.FlatStyle = FlatStyle.Flat
		btnReset.Font = New Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		btnReset.ForeColor = Color.White
		btnReset.Location = New Point(380, 156)
		btnReset.Name = "btnReset"
		btnReset.Size = New Size(90, 40)
		btnReset.TabIndex = 4
		btnReset.Text = "Reset"
		btnReset.UseVisualStyleBackColor = False
		' 
		' panelIPK
		' 
		panelIPK.BackColor = Color.FromArgb(CByte(15), CByte(52), CByte(96))
		panelIPK.BorderStyle = BorderStyle.FixedSingle
		panelIPK.Controls.Add(lblPredikat)
		panelIPK.Controls.Add(lblNilaiIPK)
		panelIPK.Controls.Add(lblIPK)
		panelIPK.Location = New Point(12, 234)
		panelIPK.Name = "panelIPK"
		panelIPK.Size = New Size(458, 225)
		panelIPK.TabIndex = 5
		' 
		' lblPredikat
		' 
		lblPredikat.AutoSize = True
		lblPredikat.BackColor = Color.Transparent
		lblPredikat.Font = New Font("Californian FB", 10.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblPredikat.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
		lblPredikat.Location = New Point(14, 138)
		lblPredikat.Name = "lblPredikat"
		lblPredikat.Size = New Size(124, 21)
		lblPredikat.TabIndex = 2
		lblPredikat.Text = "Belum ada data"
		' 
		' lblNilaiIPK
		' 
		lblNilaiIPK.AutoSize = True
		lblNilaiIPK.BackColor = Color.Transparent
		lblNilaiIPK.Font = New Font("Comic Sans MS", 36F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
		lblNilaiIPK.ForeColor = Color.FromArgb(CByte(79), CByte(255), CByte(176))
		lblNilaiIPK.Location = New Point(14, 37)
		lblNilaiIPK.Name = "lblNilaiIPK"
		lblNilaiIPK.Size = New Size(88, 84)
		lblNilaiIPK.TabIndex = 1
		lblNilaiIPK.Text = "—"
		' 
		' lblIPK
		' 
		lblIPK.AutoSize = True
		lblIPK.BackColor = Color.Transparent
		lblIPK.Font = New Font("Californian FB", 7.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		lblIPK.ForeColor = Color.FromArgb(CByte(136), CByte(136), CByte(136))
		lblIPK.Location = New Point(14, 21)
		lblIPK.Name = "lblIPK"
		lblIPK.Size = New Size(75, 16)
		lblIPK.TabIndex = 0
		lblIPK.Text = "IP Kumulatif"
		' 
		' Form1
		' 
		AutoScaleDimensions = New SizeF(8F, 18F)
		AutoScaleMode = AutoScaleMode.Font
		BackColor = Color.FromArgb(CByte(26), CByte(26), CByte(46))
		ClientSize = New Size(482, 516)
		Controls.Add(panelIPK)
		Controls.Add(btnReset)
		Controls.Add(btnTambah)
		Controls.Add(txtInput)
		Controls.Add(lblInputIP)
		Controls.Add(lblJudul)
		Font = New Font("Californian FB", 9F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
		FormBorderStyle = FormBorderStyle.FixedSingle
		MaximizeBox = False
		Name = "Form1"
		StartPosition = FormStartPosition.CenterScreen
		Text = "Kalkulator IPK"
		panelIPK.ResumeLayout(False)
		panelIPK.PerformLayout()
		ResumeLayout(False)
		PerformLayout()
	End Sub

	Friend WithEvents lblJudul As Label
	Friend WithEvents lblInputIP As Label
	Friend WithEvents txtInput As TextBox
	Friend WithEvents btnTambah As Button
	Friend WithEvents btnReset As Button
	Friend WithEvents panelIPK As Panel
	Friend WithEvents lblIPK As Label
	Friend WithEvents lblNilaiIPK As Label
	Friend WithEvents lblPredikat As Label

End Class
