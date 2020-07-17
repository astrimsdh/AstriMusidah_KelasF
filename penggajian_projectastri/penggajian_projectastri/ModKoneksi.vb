Imports System.Data.OleDb
Module ModKoneksi
    Public conn As OleDbConnection = Nothing
    Public cmd As OleDbCommand = Nothing
    Public sql As String = Nothing
    Public reader As OleDbDataReader = Nothing
    Public da As OleDbDataAdapter = Nothing
    Public ds As DataSet
    Public Sub Koneksi()
        Dim SQLconn As String
        SQLconn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source = " & Application.StartupPath & "\penggajian_astrimusidah.mdb"
        conn = New OleDbConnection(SQLconn)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
    Function Connect()
        If Not conn Is Nothing Then
            conn.Close()
        End If
        conn.Open()
        Return conn
    End Function
    Function Closedd()
        conn.Close()
        Return conn
    End Function
End Module
