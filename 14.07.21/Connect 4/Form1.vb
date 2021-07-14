Public Class Form1
    Public u1 = New Nickname
    Public u2 = New Nickname
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        u1.setNickname(p1Box.Text)
        u2.setNickname(p2Box.Text)
        Form2.Show()
        Me.Hide()
    End Sub
End Class
