Imports System.Data.OleDb
Public Class FormPenggajian
    Private Sub FormPenggajian_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        isiNIP()
        Tampil()
        enableFalse()
        btnHapus.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Enabled = True
    End Sub
    Private Sub Tampil()
        Connect()
        Try
            Dim dt As New DataTable
            da = New OleDbDataAdapter("SELECT * FROM tb_penggajian_astri", conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).HeaderText = "Tanggal Daftar"
            DataGridView1.Columns(2).HeaderText = "NIP"
            DataGridView1.Columns(3).HeaderText = "Nama"
            DataGridView1.Columns(4).HeaderText = "Jabatan"
            DataGridView1.Columns(5).HeaderText = "Gaji Pokok"
            DataGridView1.Columns(6).HeaderText = "Tunjangan Istri"
            DataGridView1.Columns(7).HeaderText = "Tunjangan Anak"
            DataGridView1.Columns(8).HeaderText = "Gaji Kotor"
            DataGridView1.Columns(9).HeaderText = "Pajak"
            DataGridView1.Columns(10).HeaderText = "Gaji Bersih"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub btnKembali_Click(sender As System.Object, e As System.EventArgs) Handles btnKembali.Click
        formUtama.Show()
        Me.Close()
    End Sub
    Sub isiNIP()
        Connect()
        sql = "SELECT nip_astri FROM tb_pegawai_astrimusidah"
        cmd = New OleDbCommand(sql, conn)
        reader = cmd.ExecuteReader
        Try
            txtNIP.Items.Clear()
            While reader.Read
                txtNIP.Items.Add(reader.GetString(0))
            End While
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        If btnTambah.Text = "Tambah" Then
            btnTambah.Text = "Simpan"
            btnHapus.Enabled = False
            btnUbah.Enabled = False
            btnTambah.Enabled = True
            enableTrue()
        ElseIf btnTambah.Text = "Simpan" Then
            Connect()
            Dim simpan As String
            Dim hasil As Integer
            simpan = "INSERT INTO tb_penggajian_astri (tglgajian_astri, nip_astri, nama_astri, jabatan_astri, gajipokok_astri, tjn_istri_astri, tjn_anak_astri, gajikotor_astri, pajak_astri, gajibersih_astri) VALUES('" & Format(txtTanggal.Value, "MM/dd/yyyy") & "','" & txtNIP.Text & "','" & txtNama.Text & "','" & txtJabatan.Text & "', " & txtGajiPokok.Text & ", " & txtTjnIstri.Text & ", " & txtTjnAnak.Text & "," & txtGajiKotor.Text & "," & txtPajak.Text & ", " & txtGajiBersih.Text & ")"
            Try
                cmd = New OleDbCommand(simpan, conn)
                hasil = cmd.ExecuteNonQuery
                If hasil > 0 Then
                    MessageBox.Show("Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clear()
                    enableFalse()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            FormPegawai.Tampil()
            Closedd()
            btnTambah.Text = "Tambah"
            Tampil()

        End If
    End Sub
    Sub enableTrue()
        txtNIP.Enabled = True
        txtNama.Enabled = True
        txtTanggal.Enabled = True
        txtJabatan.Enabled = True
        txtGajiPokok.Enabled = True
        txtTjnIstri.Enabled = True
        txtTjnAnak.Enabled = True
        txtGajiKotor.Enabled = True
        txtPajak.Enabled = True
        txtGajiBersih.Enabled = True
    End Sub
    Sub clear()
        txtNIP.Text = ""
        txtNama.Text = ""
        txtTanggal.Text = ""
        txtJabatan.Text = ""
        txtGajiPokok.Text = ""
        txtTjnIstri.Text = ""
        txtTjnAnak.Text = ""
        txtGajiPokok.Text = ""
        txtPajak.Text = ""
        txtGajiKotor.Text = ""
        txtGajiBersih.Text = ""
    End Sub
    Sub enableFalse()
        txtNIP.Enabled = False
        txtNama.Enabled = False
        txtTanggal.Enabled = False
        txtJabatan.Enabled = False
        txtGajiPokok.Enabled = False
        txtTjnIstri.Enabled = False
        txtTjnAnak.Enabled = False
        txtGajiKotor.Enabled = False
        txtPajak.Enabled = False
        txtGajiBersih.Enabled = False
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        ambilData()
        enableTrue()
        btnHapus.Enabled = True
        btnUbah.Enabled = True
        btnTambah.Enabled = False
    End Sub
    Sub ambilData()
        txtTanggal.Value = DataGridView1.SelectedCells(1).Value
        txtNIP.Text = DataGridView1.SelectedCells(2).Value
        txtNama.Text = DataGridView1.SelectedCells(3).Value
        txtJabatan.Text = DataGridView1.SelectedCells(4).Value
        txtGajiPokok.Text = DataGridView1.SelectedCells(5).Value
        txtTjnIstri.Text = DataGridView1.SelectedCells(6).Value
        txtTjnAnak.Text = DataGridView1.SelectedCells(7).Value
        txtGajiKotor.Text = DataGridView1.SelectedCells(8).Value
        txtPajak.Text = DataGridView1.SelectedCells(9).Value
        txtGajiBersih.Text = DataGridView1.SelectedCells(10).Value
    End Sub

    Private Sub txtNIP_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles txtNIP.SelectedIndexChanged
        Dim anak As Integer
        Connect()
        sql = "SELECT nip_astri, nama_astri, jabatan_astri, gajipokok_astri, anak_astri FROM tb_pegawai_astrimusidah, tb_jabatan_astrimusidah WHERE tb_pegawai_astrimusidah.id_jabatan_astri = tb_jabatan_astrimusidah.id_jabatan_astri and tb_pegawai_astrimusidah.nip_astri = '" & txtNIP.Text & "'"
        cmd = New OleDbCommand(sql, conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            txtNama.Text = reader.Item("nama_astri")
            txtJabatan.Text = reader.Item("jabatan_astri")
            txtGajiPokok.Text = reader.Item("gajipokok_astri")
            anak = reader.Item("anak_astri")
        End If
        If reader.Item("anak_astri") >= 3 Then
            txtTjnAnak.Text = Val(txtGajiPokok.Text) * 2 * 0.2
        Else
            txtTjnAnak.Text = Val(txtGajiPokok.Text) * anak * 0.2
        End If
        txtTjnIstri.Text = Val(txtGajiPokok.Text) * 0.3
        txtGajiKotor.Text = Val(txtTjnIstri.Text) + Val(txtTjnAnak.Text) + Val(txtGajiPokok.Text)
        txtPajak.Text = Val(txtGajiKotor.Text) * 0.025
        txtGajiBersih.Text = Val(txtGajiKotor.Text) - Val(txtPajak.Text)

    End Sub

    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        Connect()
        Dim hasil As Integer
        sql = "DELETE FROM tb_penggajian_astri WHERE id_penggajian_astri=" & DataGridView1.SelectedCells(0).Value & ""
        Try
            cmd = New OleDbCommand(sql, conn)
            hasil = cmd.ExecuteNonQuery
            If hasil > 0 Then
                MessageBox.Show("Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Tampil()
        Closedd()
        btnHapus.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Enabled = True
        enableFalse()
    End Sub

    Private Sub btnUbah_Click(sender As System.Object, e As System.EventArgs) Handles btnUbah.Click
        Connect()
        Dim hasil As Integer
        sql = "UPDATE tb_penggajian_astri set tglgajian_astri='" & Format(txtTanggal.Value, "MM/dd/yyyy") & "' , nip_astri = " & txtNIP.Text & ", nama_astri = '" & txtNama.Text & "', jabatan_astri = '" & txtJabatan.Text & "', gajipokok_astri=" & txtGajiPokok.Text & ", tjn_istri_astri=" & txtTjnIstri.Text & ", tjn_anak_astri = " & txtTjnAnak.Text & ", gajikotor_astri = " & txtGajiKotor.Text & ", pajak_astri = " & txtPajak.Text & ", gajibersih_astri=" & txtGajiBersih.Text & " WHERE id_penggajian_astri=" & DataGridView1.SelectedCells(0).Value & ""
        Try
            cmd = New OleDbCommand(sql, conn)
            hasil = cmd.ExecuteNonQuery
            If hasil > 0 Then
                MessageBox.Show("Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                clear()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Tampil()
        enableFalse()
        btnHapus.Enabled = False
        btnUbah.Enabled = False
        btnTambah.Enabled = True
    End Sub

    Private Sub txtCari_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCari.TextChanged
        Connect()
        sql = "SELECT * FROM tb_penggajian_astri WHERE nip_astri like '%" & txtCari.Text & "%' OR nama_astri like '%" & txtCari.Text & "%' "
        cmd = New OleDbCommand(sql, conn)
        reader = cmd.ExecuteReader
        reader.Read()
        If reader.HasRows Then
            da = New OleDbDataAdapter(sql, conn)
            ds = New DataSet
            da.Fill(ds, "hasilCari")
            DataGridView1.DataSource = ds.Tables("hasilCari")
        End If
        Closedd()
    End Sub

    Private Sub btnCetak_Click(sender As System.Object, e As System.EventArgs) Handles btnCetak.Click
        AxCrystalReport1.ReportFileName = "laporanPenggajian.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub
End Class