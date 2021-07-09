Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WebBrowser1.Navigate(linkBox.Text)
    End Sub

    Private Sub linkBox_KeyPress(sender As Object, e As KeyPressEventArgs) Handles linkBox.KeyPress
        If e.KeyChar = Chr(13) Then 'Chr(13) is the Enter Key
            WebBrowser1.Navigate(linkBox.Text)
        End If

    End Sub

    Private Sub WebBrowser1_ProgressChanged(sender As Object, e As WebBrowserProgressChangedEventArgs) Handles WebBrowser1.ProgressChanged
        ProgressBar1.Value = e.CurrentProgress
        ToolStripProgressBar1.Value = e.CurrentProgress
    End Sub

    Private Sub backBut_Click(sender As Object, e As EventArgs) Handles backBut.Click
        WebBrowser1.GoBack()
    End Sub

    Private Sub forBut_Click(sender As Object, e As EventArgs) Handles forBut.Click
        WebBrowser1.GoForward()
    End Sub

    Private Sub refBut_Click(sender As Object, e As EventArgs) Handles refBut.Click
        WebBrowser1.Refresh()
    End Sub
End Class
