<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtJurusan = New System.Windows.Forms.TextBox()
        Me.TxtJenjang = New System.Windows.Forms.TextBox()
        Me.TxtNama = New System.Windows.Forms.TextBox()
        Me.TxtNim = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.CmbKodeDosen = New System.Windows.Forms.ComboBox()
        Me.CmbKodeMatakuliah = New System.Windows.Forms.ComboBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.TxtNamaDosen = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.TxtKeterangan = New System.Windows.Forms.TextBox()
        Me.TxtTotalNilai = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TxtProses = New System.Windows.Forms.Button()
        Me.TxtUas = New System.Windows.Forms.TextBox()
        Me.TxtUts = New System.Windows.Forms.TextBox()
        Me.TxtTugas = New System.Windows.Forms.TextBox()
        Me.CmbPresensi = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TxtRefresh = New System.Windows.Forms.Button()
        Me.TxtKeluar = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(245, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(195, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "DATA MAHASISWA"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(91, 78)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 1
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(91, 169)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 2
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(91, 121)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(91, 219)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TxtJurusan)
        Me.GroupBox1.Controls.Add(Me.TxtJenjang)
        Me.GroupBox1.Controls.Add(Me.TxtNama)
        Me.GroupBox1.Controls.Add(Me.TxtNim)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(291, 233)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Data Mahasiswa"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 149)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Jurusan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Jenjang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "Nim"
        '
        'TxtJurusan
        '
        Me.TxtJurusan.Location = New System.Drawing.Point(124, 146)
        Me.TxtJurusan.Name = "TxtJurusan"
        Me.TxtJurusan.Size = New System.Drawing.Size(141, 20)
        Me.TxtJurusan.TabIndex = 10
        '
        'TxtJenjang
        '
        Me.TxtJenjang.Location = New System.Drawing.Point(124, 106)
        Me.TxtJenjang.Name = "TxtJenjang"
        Me.TxtJenjang.Size = New System.Drawing.Size(141, 20)
        Me.TxtJenjang.TabIndex = 9
        '
        'TxtNama
        '
        Me.TxtNama.Location = New System.Drawing.Point(124, 67)
        Me.TxtNama.Name = "TxtNama"
        Me.TxtNama.Size = New System.Drawing.Size(141, 20)
        Me.TxtNama.TabIndex = 8
        '
        'TxtNim
        '
        Me.TxtNim.Location = New System.Drawing.Point(124, 32)
        Me.TxtNim.Name = "TxtNim"
        Me.TxtNim.Size = New System.Drawing.Size(141, 20)
        Me.TxtNim.TabIndex = 7
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.CmbKodeDosen)
        Me.GroupBox2.Controls.Add(Me.CmbKodeMatakuliah)
        Me.GroupBox2.Controls.Add(Me.TextBox13)
        Me.GroupBox2.Controls.Add(Me.TxtNamaDosen)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 314)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(291, 218)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Kuliah"
        '
        'CmbKodeDosen
        '
        Me.CmbKodeDosen.FormattingEnabled = True
        Me.CmbKodeDosen.Location = New System.Drawing.Point(124, 31)
        Me.CmbKodeDosen.Name = "CmbKodeDosen"
        Me.CmbKodeDosen.Size = New System.Drawing.Size(121, 21)
        Me.CmbKodeDosen.TabIndex = 19
        '
        'CmbKodeMatakuliah
        '
        Me.CmbKodeMatakuliah.FormattingEnabled = True
        Me.CmbKodeMatakuliah.Location = New System.Drawing.Point(124, 112)
        Me.CmbKodeMatakuliah.Name = "CmbKodeMatakuliah"
        Me.CmbKodeMatakuliah.Size = New System.Drawing.Size(121, 21)
        Me.CmbKodeMatakuliah.TabIndex = 18
        '
        'TextBox13
        '
        Me.TextBox13.Enabled = False
        Me.TextBox13.Location = New System.Drawing.Point(124, 158)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(121, 20)
        Me.TextBox13.TabIndex = 16
        '
        'TxtNamaDosen
        '
        Me.TxtNamaDosen.Enabled = False
        Me.TxtNamaDosen.Location = New System.Drawing.Point(124, 73)
        Me.TxtNamaDosen.Name = "TxtNamaDosen"
        Me.TxtNamaDosen.Size = New System.Drawing.Size(121, 20)
        Me.TxtNamaDosen.TabIndex = 15
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(25, 161)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(59, 13)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Matakuliah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(25, 112)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Kode Matakuliah"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(25, 73)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(69, 13)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "Nama Dosen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(25, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "Kode Dosen"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.TxtKeterangan)
        Me.GroupBox3.Controls.Add(Me.TxtTotalNilai)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.TxtProses)
        Me.GroupBox3.Controls.Add(Me.TxtUas)
        Me.GroupBox3.Controls.Add(Me.TxtUts)
        Me.GroupBox3.Controls.Add(Me.TxtTugas)
        Me.GroupBox3.Controls.Add(Me.CmbPresensi)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Location = New System.Drawing.Point(379, 63)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(290, 355)
        Me.GroupBox3.TabIndex = 7
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Data Nilai"
        '
        'TxtKeterangan
        '
        Me.TxtKeterangan.Enabled = False
        Me.TxtKeterangan.Location = New System.Drawing.Point(113, 305)
        Me.TxtKeterangan.Name = "TxtKeterangan"
        Me.TxtKeterangan.Size = New System.Drawing.Size(147, 20)
        Me.TxtKeterangan.TabIndex = 27
        '
        'TxtTotalNilai
        '
        Me.TxtTotalNilai.Enabled = False
        Me.TxtTotalNilai.Location = New System.Drawing.Point(113, 266)
        Me.TxtTotalNilai.Name = "TxtTotalNilai"
        Me.TxtTotalNilai.Size = New System.Drawing.Size(147, 20)
        Me.TxtTotalNilai.TabIndex = 26
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(32, 305)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(62, 13)
        Me.Label15.TabIndex = 25
        Me.Label15.Text = "Keterangan"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(32, 266)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 24
        Me.Label14.Text = "Total Nilai"
        '
        'TxtProses
        '
        Me.TxtProses.Location = New System.Drawing.Point(66, 210)
        Me.TxtProses.Name = "TxtProses"
        Me.TxtProses.Size = New System.Drawing.Size(75, 23)
        Me.TxtProses.TabIndex = 21
        Me.TxtProses.Text = "Proses"
        Me.TxtProses.UseVisualStyleBackColor = True
        '
        'TxtUas
        '
        Me.TxtUas.Location = New System.Drawing.Point(113, 153)
        Me.TxtUas.Name = "TxtUas"
        Me.TxtUas.Size = New System.Drawing.Size(147, 20)
        Me.TxtUas.TabIndex = 20
        '
        'TxtUts
        '
        Me.TxtUts.Location = New System.Drawing.Point(113, 110)
        Me.TxtUts.Name = "TxtUts"
        Me.TxtUts.Size = New System.Drawing.Size(147, 20)
        Me.TxtUts.TabIndex = 19
        '
        'TxtTugas
        '
        Me.TxtTugas.Location = New System.Drawing.Point(113, 74)
        Me.TxtTugas.Name = "TxtTugas"
        Me.TxtTugas.Size = New System.Drawing.Size(147, 20)
        Me.TxtTugas.TabIndex = 18
        '
        'CmbPresensi
        '
        Me.CmbPresensi.FormattingEnabled = True
        Me.CmbPresensi.Location = New System.Drawing.Point(113, 35)
        Me.CmbPresensi.Name = "CmbPresensi"
        Me.CmbPresensi.Size = New System.Drawing.Size(147, 21)
        Me.CmbPresensi.TabIndex = 17
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(32, 156)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(29, 13)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "UAS"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(32, 113)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(29, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "UTS"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(32, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Tugas"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(32, 35)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(47, 13)
        Me.Label10.TabIndex = 13
        Me.Label10.Text = "Presensi"
        '
        'TxtRefresh
        '
        Me.TxtRefresh.Location = New System.Drawing.Point(414, 447)
        Me.TxtRefresh.Name = "TxtRefresh"
        Me.TxtRefresh.Size = New System.Drawing.Size(75, 23)
        Me.TxtRefresh.TabIndex = 22
        Me.TxtRefresh.Text = "Refresh"
        Me.TxtRefresh.UseVisualStyleBackColor = True
        '
        'TxtKeluar
        '
        Me.TxtKeluar.Location = New System.Drawing.Point(564, 447)
        Me.TxtKeluar.Name = "TxtKeluar"
        Me.TxtKeluar.Size = New System.Drawing.Size(75, 23)
        Me.TxtKeluar.TabIndex = 23
        Me.TxtKeluar.Text = "Keluar"
        Me.TxtKeluar.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(705, 556)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.TxtKeluar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.TxtRefresh)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtJurusan As TextBox
    Friend WithEvents TxtJenjang As TextBox
    Friend WithEvents TxtNama As TextBox
    Friend WithEvents TxtNim As TextBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TxtNamaDosen As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents TxtProses As Button
    Friend WithEvents TxtUas As TextBox
    Friend WithEvents TxtUts As TextBox
    Friend WithEvents TxtTugas As TextBox
    Friend WithEvents CmbPresensi As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TxtRefresh As Button
    Friend WithEvents TxtKeluar As Button
    Friend WithEvents TextBox13 As TextBox
    Friend WithEvents CmbKodeDosen As ComboBox
    Friend WithEvents CmbKodeMatakuliah As ComboBox
    Friend WithEvents TxtKeterangan As TextBox
    Friend WithEvents TxtTotalNilai As TextBox
End Class
