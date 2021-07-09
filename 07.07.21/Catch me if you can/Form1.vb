Public Class Form1

    Function Relocate()
        ' local variable declaration */
        Randomize()
        Dim xx As Integer = CInt(Int((1300 * Rnd()) + 0))
        Dim yy As Integer = CInt(Int((750 * Rnd()) + 0))

        Me.Location = New Point(xx, yy)
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Relocate()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form2.Show()
    End Sub

    Private Sub Form1_MouseHover(sender As Object, e As EventArgs) Handles Me.MouseHover
        Relocate()

    End Sub

    Private Sub Button1_MouseHover(sender As Object, e As EventArgs) Handles Button1.MouseHover
        Relocate()
    End Sub
End Class
