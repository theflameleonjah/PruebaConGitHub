Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub btnJuan_Click_1(sender As Object, e As EventArgs) Handles btnJuan.Click
        Dim frm As New FormJuan
        frm.ShowDialog()
    End Sub

    Private Sub btnMonica_Click_1(sender As Object, e As EventArgs) Handles btnMonica.Click
        Dim frm As New formMonica
        frm.ShowDialog()
    End Sub
End Class
