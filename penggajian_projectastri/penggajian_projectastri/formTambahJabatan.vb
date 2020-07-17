Imports System.Data.OleDb
Public Class formTambahJabatan
    Private Sub formTambahJabatan_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Connect()
        Dim simpan As String
        Dim hasil As Integer
        simpan = "INSERT INTO tb_jabatan_astriMusidah ( jabatan_astri, gajipokok_astri) VALUES('" & txtJabatan.Text & "'," & txtGajiPokok.Text & ")"
        Try
            cmd = New OleDbCommand(simpan, conn)
            hasil = cmd.ExecuteNonQuery
            If hasil > 0 Then
                MessageBox.Show("Berhasil", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Closedd()
    End Sub
End Class