Imports System.Data.OleDb
Module Module1
    Public conn As OleDbConnection
    Public cmd As OleDbCommand
    Public dr As OleDbDataReader
    Public da As OleDbDataAdapter
    Public ds As DataSet
    Sub connec()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=DBHamdan.mdb")
        conn.Open()
    End Sub
End Module
