Imports System.Data.OleDb
Public Class FormTambahPegawai
    Private Sub FormTambahPegawai_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call isiJabatan()
        Call Koneksi()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        If btnSimpan.Text = "Simpan" Then
            enableTrue()
            btnSimpan.Text = "Baru"
            Connect()
            Dim simpan As String
            Dim hasil As Integer
            simpan = "INSERT INTO tb_pegawai_astriMusidah ( nip_astri, nama_astri, tanggal_Astri, status_astri, anak_astri, id_jabatan_astri ) VALUES('" & txtNIP.Text & "','" & txtNama.Text & "','" & Format(Now, "MM/dd/yyyy") & "','" & txtStatus.Text & "','" & txtAnak.Text & "', '" & txtJabatan.SelectedValue & "')"
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
        ElseIf btnSimpan.Text = "Baru" Then
            enableTrue()
            btnSimpan.Text = "Simpan"
        ElseIf btnSimpan.Text = "Ubah" Then
            Connect()
            enableTrue()
            Dim hasil As Integer
            sql = "UPDATE tb_pegawai_astrimusidah set nama_astri='" & txtNama.Text & "' where id_karyawan_astri='" & TxtId.Text & "'"
            cmd = New OleDbCommand(sql, conn)
            Try
                hasil = cmd.ExecuteNonQuery
                If hasil > 0 Then
                    MessageBox.Show("Data berhasil diubah", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    FormPegawai.Tampil()
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Closedd()
        End If


    End Sub
    Sub isiJabatan()
        Connect()
        Try
            da = New OleDbDataAdapter("Select id_jabatan_astri, jabatan_astri from tb_jabatan_astrimusidah", conn)
            ds = New DataSet
            da.Fill(ds, "tb_pegawai_astriMusidah")
            txtJabatan.DataSource = ds.Tables("tb_pegawai_astriMusidah")
            txtJabatan.DisplayMember = "jabatan_astri"
            txtJabatan.ValueMember = "id_jabatan_astri"
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        

    End Sub

    Private Sub btnJabatan_Click(sender As System.Object, e As System.EventArgs) Handles btnJabatan.Click
        formTambahJabatan.Show()
        formTambahJabatan.StartPosition = FormStartPosition.CenterScreen
    End Sub
    Sub clear()
        txtNIP.Text = ""
        txtNama.Text = ""
        txtJabatan.Text = ""
        txtStatus.Text = ""
        txtAnak.Text = ""
    End Sub
    Sub enableFalse()
        txtNIP.Enabled = False
        txtNama.Enabled = False
        txtStatus.Enabled = False
        txtAnak.Enabled = False
        txtJabatan.Enabled = False
    End Sub
    Sub enableTrue()
        txtNIP.Enabled = True
        txtNama.Enabled = True
        txtStatus.Enabled = True
        txtAnak.Enabled = True
        txtJabatan.Enabled = True
    End Sub
End Class