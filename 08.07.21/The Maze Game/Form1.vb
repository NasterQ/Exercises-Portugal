Public Class Form1

    Public user = New Nickname

    Private Sub goBut_Click(sender As Object, e As EventArgs) Handles goBut.Click
        user.setNickname(nicknameBox.Text)
        Form2.Show()
        Me.Hide()
    End Sub
End Class
