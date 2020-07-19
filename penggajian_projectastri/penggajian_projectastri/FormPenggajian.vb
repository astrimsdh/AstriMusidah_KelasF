Imports System.Data.OleDb
Public Class FormPenggajian
    Private Sub FormPenggajian_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Call Koneksi()
    End Sub
    Private Sub Tampil()
        Connect()
        Try
            Dim dt As New DataTable
            da = New OleDbDataAdapter("SELECT * FROM tb_penggajian_astri", conn)
            da.Fill(dt)
            DataGridView1.DataSource = dt
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class