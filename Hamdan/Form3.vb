Imports System.Data.OleDb
Public Class Form3

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txtalamat.Text = "" Or txtjurusan.Text = "" Or txtnamains.Text = "" Or Txtnis.Text = "" Or txttahun.Text = "" Then
            MsgBox("Masih ada kolom yang kosong, Periksa terlebih dahulu", MsgBoxStyle.Critical)
        Else

            Call koneksi()
            cmd = New OleDbCommand("INSERT INTO Surat VALUES('" & TextBox2.Text & "','" & TextBox1.Text & "','" & Txtnis.Text & "','" & txtjurusan.Text & "','" & txttahun.Text & "','" & txtalamat.Text & "','" & txtnamains.Text & "','" & rket.Text & "')", conn)
            cmd.ExecuteNonQuery()
            MsgBox("Pengajuan Surat PKL Berhasil Dikirim", MsgBoxStyle.Information)
            kosong()
        End If

    End Sub

    Sub kosong()
        txtalamat.Clear()
        TextBox1.Clear()
        txtjurusan.Clear()
        Txtnis.Clear()
        txttahun.Clear()
        rket.Clear()
        txtnamains.Clear()

    End Sub
End Class