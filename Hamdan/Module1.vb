Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Sub koneksi()
        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=DBHamdan.accdb")
        conn.Open()
    End Sub
End Module
