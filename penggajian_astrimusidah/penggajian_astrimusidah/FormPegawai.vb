﻿Imports System.Data.OleDb
Public Class FormPegawai

    Private Sub btnKembali_Click(sender As System.Object, e As System.EventArgs) Handles btnKembali.Click
        formUtama.Show()
        Me.Close()
    End Sub

    Private Sub btnTambah_Click(sender As System.Object, e As System.EventArgs) Handles btnTambah.Click
        FormTambahPegawai.Show()
    End Sub

    Private Sub FormPegawai_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
        Tampil()
    End Sub
    Sub Tampil()
        Connect()
        Try
            Dim dt As New DataTable
            da = New OleDbDataAdapter("SELECT id_karyawan_astri, nip_astri, nama_astri, tanggal_astri, status_astri, anak_astri, jabatan_astri FROM tb_pegawai_astriMusidah, tb_jabatan_astriMusidah WHERE tb_pegawai_astriMusidah.id_jabatan_astri = tb_jabatan_astriMusidah.id_jabatan_astri", conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
            DataGridView1.Columns(0).Visible = False
            DataGridView1.Columns(1).HeaderText = "NIP"
            DataGridView1.Columns(2).HeaderText = "Nama"
            DataGridView1.Columns(3).HeaderText = "Tanggal Daftar"
            DataGridView1.Columns(4).HeaderText = "Status"
            DataGridView1.Columns(5).HeaderText = "Anak"
            DataGridView1.Columns(6).HeaderText = "Jabatan"

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        ambil_data()
    End Sub

    Private Sub btnUbah_Click(sender As System.Object, e As System.EventArgs) Handles btnUbah.Click
        ambil_data()
    End Sub
    Sub ambil_data()
        FormTambahPegawai.Show()
        FormTambahPegawai.StartPosition = FormStartPosition.CenterScreen
        FormTambahPegawai.btnSimpan.Text = "Ubah"
        FormTambahPegawai.Label1.Text = "Ubah Data"
        FormTambahPegawai.TxtId.Text = DataGridView1.SelectedCells(0).Value
        FormTambahPegawai.txtNIP.Text = DataGridView1.SelectedCells(1).Value
        FormTambahPegawai.txtNama.Text = DataGridView1.SelectedCells(2).Value
        FormTambahPegawai.txtStatus.Text = DataGridView1.SelectedCells(4).Value
        FormTambahPegawai.txtAnak.Text = DataGridView1.SelectedCells(5).Value
        FormTambahPegawai.txtJabatan.Text = DataGridView1.SelectedCells(6).Value
    End Sub

    Private Sub btnCetak_Click(sender As System.Object, e As System.EventArgs) Handles btnCetak.Click
        AxCrystalReport1.ReportFileName = "laporanPegawai.rpt"
        AxCrystalReport1.WindowState = Crystal.WindowStateConstants.crptMaximized
        AxCrystalReport1.RetrieveDataFiles()
        AxCrystalReport1.Action = 1
    End Sub

    Private Sub btnHapus_Click(sender As System.Object, e As System.EventArgs) Handles btnHapus.Click
        Connect()
        Dim hasil As Integer
        sql = "DELETE FROM tb_pegawai_astrimusidah WHERE id_karyawan_astri=" & DataGridView1.SelectedCells(0).Value & ""
        Try
            cmd = New OleDbCommand(sql, conn)
            hasil = cmd.ExecuteNonQuery
            If hasil > 0 Then
                MessageBox.Show("Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Tampil()
        Closedd()
    End Sub

    Private Sub txtCari_TextChanged(sender As System.Object, e As System.EventArgs) Handles txtCari.TextChanged
        Connect()
        sql = "SELECT * FROM tb_pegawai_astrimusidah WHERE nip_astri like '%" & txtCari.Text & "%' OR nama_astri like '%" & txtCari.Text & "%' "
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
End Class