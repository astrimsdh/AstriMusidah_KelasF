Public Class formUtama

    Private Sub formUtama_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnData_Click(sender As System.Object, e As System.EventArgs) Handles btnData.Click
        FormPegawai.StartPosition = FormStartPosition.CenterScreen
        FormPegawai.Show()
        Me.Hide()
    End Sub

    Private Sub btnGaji_Click(sender As System.Object, e As System.EventArgs) Handles btnGaji.Click
        FormPenggajian.StartPosition = FormStartPosition.CenterScreen
        FormPenggajian.Show()
        Me.Hide()
    End Sub

    Private Sub btnKeluar_Click(sender As System.Object, e As System.EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
End Class
