<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPenggajian
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPenggajian))
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJabatan = New System.Windows.Forms.TextBox()
        Me.txtGajiPokok = New System.Windows.Forms.TextBox()
        Me.txtTjnIstri = New System.Windows.Forms.TextBox()
        Me.txtGajiBersih = New System.Windows.Forms.TextBox()
        Me.txtPajak = New System.Windows.Forms.TextBox()
        Me.txtGajiKotor = New System.Windows.Forms.TextBox()
        Me.txtTjnAnak = New System.Windows.Forms.TextBox()
        Me.txtTanggal = New System.Windows.Forms.DateTimePicker()
        Me.txtNIP = New System.Windows.Forms.ComboBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.btnUbah = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AxCrystalReport1 = New AxCrystal.AxCrystalReport()
        Me.btnKembali = New System.Windows.Forms.Button()
        Me.btnCetak = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label13)
        Me.Panel3.Controls.Add(Me.Label12)
        Me.Panel3.Controls.Add(Me.Label11)
        Me.Panel3.Controls.Add(Me.Label9)
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.txtJabatan)
        Me.Panel3.Controls.Add(Me.txtGajiPokok)
        Me.Panel3.Controls.Add(Me.txtTjnIstri)
        Me.Panel3.Controls.Add(Me.txtGajiBersih)
        Me.Panel3.Controls.Add(Me.txtPajak)
        Me.Panel3.Controls.Add(Me.txtGajiKotor)
        Me.Panel3.Controls.Add(Me.txtTjnAnak)
        Me.Panel3.Controls.Add(Me.txtTanggal)
        Me.Panel3.Controls.Add(Me.txtNIP)
        Me.Panel3.Controls.Add(Me.txtNama)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Label8)
        Me.Panel3.Controls.Add(Me.Label10)
        Me.Panel3.Controls.Add(Me.Label2)
        Me.Panel3.Controls.Add(Me.txtCari)
        Me.Panel3.Controls.Add(Me.btnUbah)
        Me.Panel3.Controls.Add(Me.btnHapus)
        Me.Panel3.Controls.Add(Me.btnTambah)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.DataGridView1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 42)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(992, 345)
        Me.Panel3.TabIndex = 18
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 235)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(86, 13)
        Me.Label13.TabIndex = 58
        Me.Label13.Text = "Tunjangan Anak"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(14, 261)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 57
        Me.Label12.Text = "Gaji Kotor"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(14, 287)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Pajak "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(14, 313)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(57, 13)
        Me.Label9.TabIndex = 55
        Me.Label9.Text = "Gaji Bersih"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(14, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Tunjangan Istri"
        '
        'txtJabatan
        '
        Me.txtJabatan.BackColor = System.Drawing.SystemColors.Window
        Me.txtJabatan.Location = New System.Drawing.Point(117, 154)
        Me.txtJabatan.Name = "txtJabatan"
        Me.txtJabatan.ReadOnly = True
        Me.txtJabatan.Size = New System.Drawing.Size(141, 20)
        Me.txtJabatan.TabIndex = 53
        '
        'txtGajiPokok
        '
        Me.txtGajiPokok.BackColor = System.Drawing.SystemColors.Window
        Me.txtGajiPokok.Location = New System.Drawing.Point(117, 180)
        Me.txtGajiPokok.Name = "txtGajiPokok"
        Me.txtGajiPokok.ReadOnly = True
        Me.txtGajiPokok.Size = New System.Drawing.Size(141, 20)
        Me.txtGajiPokok.TabIndex = 52
        '
        'txtTjnIstri
        '
        Me.txtTjnIstri.BackColor = System.Drawing.SystemColors.Window
        Me.txtTjnIstri.Location = New System.Drawing.Point(117, 206)
        Me.txtTjnIstri.Name = "txtTjnIstri"
        Me.txtTjnIstri.ReadOnly = True
        Me.txtTjnIstri.Size = New System.Drawing.Size(141, 20)
        Me.txtTjnIstri.TabIndex = 51
        '
        'txtGajiBersih
        '
        Me.txtGajiBersih.BackColor = System.Drawing.SystemColors.Window
        Me.txtGajiBersih.Location = New System.Drawing.Point(117, 310)
        Me.txtGajiBersih.Name = "txtGajiBersih"
        Me.txtGajiBersih.ReadOnly = True
        Me.txtGajiBersih.Size = New System.Drawing.Size(141, 20)
        Me.txtGajiBersih.TabIndex = 50
        '
        'txtPajak
        '
        Me.txtPajak.BackColor = System.Drawing.SystemColors.Window
        Me.txtPajak.Location = New System.Drawing.Point(117, 284)
        Me.txtPajak.Name = "txtPajak"
        Me.txtPajak.ReadOnly = True
        Me.txtPajak.Size = New System.Drawing.Size(141, 20)
        Me.txtPajak.TabIndex = 49
        '
        'txtGajiKotor
        '
        Me.txtGajiKotor.BackColor = System.Drawing.SystemColors.Window
        Me.txtGajiKotor.Location = New System.Drawing.Point(117, 258)
        Me.txtGajiKotor.Name = "txtGajiKotor"
        Me.txtGajiKotor.ReadOnly = True
        Me.txtGajiKotor.Size = New System.Drawing.Size(141, 20)
        Me.txtGajiKotor.TabIndex = 48
        '
        'txtTjnAnak
        '
        Me.txtTjnAnak.BackColor = System.Drawing.SystemColors.Window
        Me.txtTjnAnak.Location = New System.Drawing.Point(117, 232)
        Me.txtTjnAnak.Name = "txtTjnAnak"
        Me.txtTjnAnak.ReadOnly = True
        Me.txtTjnAnak.Size = New System.Drawing.Size(141, 20)
        Me.txtTjnAnak.TabIndex = 47
        '
        'txtTanggal
        '
        Me.txtTanggal.Location = New System.Drawing.Point(117, 128)
        Me.txtTanggal.Name = "txtTanggal"
        Me.txtTanggal.Size = New System.Drawing.Size(141, 20)
        Me.txtTanggal.TabIndex = 46
        '
        'txtNIP
        '
        Me.txtNIP.FormattingEnabled = True
        Me.txtNIP.Location = New System.Drawing.Point(117, 75)
        Me.txtNIP.Name = "txtNIP"
        Me.txtNIP.Size = New System.Drawing.Size(141, 21)
        Me.txtNIP.TabIndex = 45
        '
        'txtNama
        '
        Me.txtNama.BackColor = System.Drawing.SystemColors.Window
        Me.txtNama.Location = New System.Drawing.Point(117, 102)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(141, 20)
        Me.txtNama.TabIndex = 44
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 183)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(59, 13)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "Gaji Pokok"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(45, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "Jabatan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 41
        Me.Label4.Text = "Tanggal Gajian"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(14, 105)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(35, 13)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "Nama"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(69, 13)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "NIP Pegawai"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(691, 19)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(116, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Cari Data Gaji Pegawai"
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(823, 16)
        Me.txtCari.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(158, 20)
        Me.txtCari.TabIndex = 14
        '
        'btnUbah
        '
        Me.btnUbah.Location = New System.Drawing.Point(181, 33)
        Me.btnUbah.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnUbah.Name = "btnUbah"
        Me.btnUbah.Size = New System.Drawing.Size(77, 27)
        Me.btnUbah.TabIndex = 13
        Me.btnUbah.Text = "Ubah"
        Me.btnUbah.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(98, 33)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(78, 27)
        Me.btnHapus.TabIndex = 12
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(17, 33)
        Me.btnTambah.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(77, 27)
        Me.btnTambah.TabIndex = 11
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(274, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(114, 13)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "List Data Gaji Pegawai"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(277, 49)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(704, 281)
        Me.DataGridView1.TabIndex = 9
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.AxCrystalReport1)
        Me.Panel2.Controls.Add(Me.btnKembali)
        Me.Panel2.Controls.Add(Me.btnCetak)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 387)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(992, 43)
        Me.Panel2.TabIndex = 17
        '
        'AxCrystalReport1
        '
        Me.AxCrystalReport1.Enabled = True
        Me.AxCrystalReport1.Location = New System.Drawing.Point(196, 6)
        Me.AxCrystalReport1.Name = "AxCrystalReport1"
        Me.AxCrystalReport1.OcxState = CType(resources.GetObject("AxCrystalReport1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxCrystalReport1.Size = New System.Drawing.Size(28, 28)
        Me.AxCrystalReport1.TabIndex = 9
        '
        'btnKembali
        '
        Me.btnKembali.Location = New System.Drawing.Point(12, 6)
        Me.btnKembali.Name = "btnKembali"
        Me.btnKembali.Size = New System.Drawing.Size(75, 27)
        Me.btnKembali.TabIndex = 8
        Me.btnKembali.Text = "Kembali"
        Me.btnKembali.UseVisualStyleBackColor = True
        '
        'btnCetak
        '
        Me.btnCetak.Location = New System.Drawing.Point(895, 6)
        Me.btnCetak.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnCetak.Name = "btnCetak"
        Me.btnCetak.Size = New System.Drawing.Size(86, 27)
        Me.btnCetak.TabIndex = 7
        Me.btnCetak.Text = "Cetak Data"
        Me.btnCetak.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(992, 42)
        Me.Panel1.TabIndex = 16
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(372, 9)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(240, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Menu Penggajian"
        '
        'FormPenggajian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(992, 430)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FormPenggajian"
        Me.Text = "FormPenggajian"
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.AxCrystalReport1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJabatan As System.Windows.Forms.TextBox
    Friend WithEvents txtGajiPokok As System.Windows.Forms.TextBox
    Friend WithEvents txtTjnIstri As System.Windows.Forms.TextBox
    Friend WithEvents txtGajiBersih As System.Windows.Forms.TextBox
    Friend WithEvents txtPajak As System.Windows.Forms.TextBox
    Friend WithEvents txtGajiKotor As System.Windows.Forms.TextBox
    Friend WithEvents txtTjnAnak As System.Windows.Forms.TextBox
    Friend WithEvents txtTanggal As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtNIP As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents btnUbah As System.Windows.Forms.Button
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btnKembali As System.Windows.Forms.Button
    Friend WithEvents btnCetak As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents AxCrystalReport1 As AxCrystal.AxCrystalReport
End Class
