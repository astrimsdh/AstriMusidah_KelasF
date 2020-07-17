Imports System.Data.OleDb
Public Class FormTambahPegawai
    Private Sub FormTambahPegawai_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call isiJabatan()
        Call Koneksi()
    End Sub

    Private Sub btnSimpan_Click(sender As System.Object, e As System.EventArgs) Handles btnSimpan.Click
        Connect()
        Dim simpan As String
        Dim hasil As Integer
        simpan = "INSERT INTO tb_pegawai_astriMusidah ( nip_astri, nama_astri, tanggal_Astri, status_astri, anak_astri, id_jabatan_astri ) VALUES('" & txtNIP.Text & "','" & txtNama.Text & "','" & Format(Now, "MM/dd/yyyy") & "','" & txtStatus.Text & "','" & txtAnak.Text & "', '" & txtJabatan.SelectedValue & "')"
        Try
            cmd = New OleDbCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery
            If hasil > 0 Then
                MessageBox.Show("Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        FormPegawai.Tampil()
        Closedd()
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

    Private Sub TxtId_TextChanged(sender As System.Object, e As System.EventArgs) Handles TxtId.TextChanged

    End Sub
End Class