Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized

        LabelUp.Left = (LabelUp.Parent.Width \ 2) - (LabelUp.Width \ 2)
        LabelUp.Top = (LabelUp.Parent.Height \ 2) - (LabelUp.Height \ 2 + 100)
        LabelDown.Left = (LabelDown.Parent.Width \ 2) - (LabelDown.Width \ 2)
        LabelDown.Top = (LabelDown.Parent.Height \ 2) - (LabelDown.Height \ 2)

    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Q Then
            Me.Close()
        End If
    End Sub
End Class
