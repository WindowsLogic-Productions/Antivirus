Imports System
Imports System.IO


Public Class Detect


    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        TextBox1.Text = Main.OpenFileDialog1.FileName
        Try
            FileSystem.Unlock(Main.OpenFileDialog1.FileName)
            FileSystem.Kill(Main.OpenFileDialog1.FileName)
            File.Delete(Main.OpenFileDialog1.FileName)
            File.Delete(TextBox1.Text)


        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        FileSystem.Unlock(Main.OpenFileDialog1.FileName)
        FileSystem.Kill(Main.OpenFileDialog1.FileName)
        File.Delete(Main.OpenFileDialog1.FileName)
        File.Delete(TextBox1.Text)
        Me.Close()


    End Sub
End Class