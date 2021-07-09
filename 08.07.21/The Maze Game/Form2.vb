Public Class Form2

    Dim nick = Form1.user.getNickname()
    Dim points = 0

    Function MoveToStart()
        Dim startPoint = Panel1.Location()
        startPoint.Offset(30, 280)
        Cursor.Position = PointToScreen(startPoint)
    End Function

    Function minusPoint()
        points += 1
        pointsLab.Text = "Mistakes: " & points
    End Function

    Private stopwatch As New Stopwatch
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim elapsedTime As TimeSpan = stopwatch.Elapsed
        timerLab.Text = String.Format("{0:00}:{1:00}:{2:00}:{3:00}", Math.Floor(elapsedTime.TotalHours),
                                      elapsedTime.Minutes, elapsedTime.Seconds, elapsedTime.Milliseconds)
    End Sub
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userLab.Text = "User: " & nick
        Timer1.Start()
        stopwatch.Start()
        MoveToStart()
    End Sub

    Private Sub endBut_Click(sender As Object, e As EventArgs) Handles endBut.Click
        Timer1.Stop()
        stopwatch.Stop()
        MessageBox.Show("Congratulations " & nick & "!" & Environment.NewLine & "Your time: " & timerLab.Text & Environment.NewLine & "Mistakes: " & points)
        finishBut.Enabled = True
        finishBut.Visible = True
    End Sub

    Private Sub finishBut_Click(sender As Object, e As EventArgs) Handles finishBut.Click
        Me.Close()
        Form1.Close()
    End Sub

    Private Sub wall_enter(sender As Object, e As EventArgs) Handles Label3.MouseEnter, timerLab.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MoveToStart()
        minusPoint()
    End Sub
End Class