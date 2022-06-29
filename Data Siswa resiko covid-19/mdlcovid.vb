Imports System.Data
Imports System.Data.OleDb
Module mdlcovid
    Public conn As OleDbConnection
    Public CMD As OleDbCommand
    Public DS As New DataSet
    Public DA As OleDbDataAdapter
    Public RD As OleDbDataReader
    Public lokasidata As String
    Public Sub konek()
        lokasidata = "provider=microsoft.jet.oledb.4.0;data source=Datasiswa.mdb"
        conn = New OleDbConnection(lokasidata)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
            MsgBox("Koneksi Berhasil")
        Else
            MsgBox("Koneksi Gagal")
        End If
    End Sub
End Module
