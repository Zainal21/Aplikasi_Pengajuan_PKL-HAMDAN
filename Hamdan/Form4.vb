Imports System.Data.OleDb
Public Class Form4

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tampil()


    End Sub
    Sub tampil()
        Call koneksi()
        da = New OleDbDataAdapter("select * from Surat", conn)
        ds = New DataSet
        da.Fill(ds)
        DataGridView1.DataSource = ds.Tables(0)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        tampil()
        MsgBox("Data Berhasil Disegarkan")
    End Sub
End Class