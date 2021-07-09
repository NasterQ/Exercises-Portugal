Public Class Form1

    Private stopwatch As New Stopwatch
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsedTime As TimeSpan = stopwatch.Elapsed
        timerLab.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsedTime.TotalHours),
                                      elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds)
    End Sub

    Private Sub startBut_Click(sender As Object, e As EventArgs) Handles startBut.Click
        Timer1.Start()
        stopwatch.Start()
    End Sub

    Private Sub stopBut_Click(sender As Object, e As EventArgs) Handles stopBut.Click
        Timer1.Stop()
        stopwatch.Stop()
    End Sub

    Private Sub refBut_Click(sender As Object, e As EventArgs) Handles refBut.Click
        stopwatch.Reset()
        timerLab.Text = "00:00:00:00"
    End Sub
End Class
