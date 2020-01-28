Imports System.Data.OleDb

Public Class Form1

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username atau password belum diisi")
        Else
            Call koneksi()
            cmd = New OleDbCommand("select * from Member where Username='" & TextBox1.Text & "'and Password='" & TextBox2.Text & "'", conn)
            dr = cmd.ExecuteReader
            dr.Read()
            If dr.HasRows Then
                Form2.Label2.Text = dr.Item("level")
                Form2.Show()
                Me.Hide()
            Else
                MsgBox("LOGIN GAGAL", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
End Class
