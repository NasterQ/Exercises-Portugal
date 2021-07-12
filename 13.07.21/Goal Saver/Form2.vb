Public Class Form2

    Dim living = True
    Dim points = 0

    ' Default config
    Dim speed = 40
    Dim sizeB = 130

    Private Async Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        If Form1.opt.getSpeed() = 1 Then
            speed = 25
        End If

        If Form1.opt.getSize() = 0 Then
            sizeB = 100
            platform.Size = New Size(10, sizeB)
        End If



        Dim Ploc = BackPanel.Bounds
        Dim Xinterval = -5
        Dim Yinterval = 5
        While living

            ' If the ball touched the platform
            If ball.Bounds.IntersectsWith(platform.Bounds) Then
                points += 1
                pointsLab.Text = points

                ' Respawn the ball
                Dim xx As Integer = CInt(Math.Floor((71) * Rnd())) + 310
                Dim yy As Integer = CInt(Math.Floor((171) * Rnd())) + 30
                ball.Location = New Point(xx, yy)

                ' Direction of the ball
                Dim dir_x As Integer = CInt(Math.Floor((5) * Rnd())) + 5
                Dim dir_y As Integer = CInt(Math.Floor((5) * Rnd())) + 5
                Dim negative = CInt(Math.Floor((2) * Rnd())) + 0
                If negative = 0 Then
                    dir_y = -dir_y
                End If

            End If

            Dim Bloc = ball.Location ' Check the ball location

            ' Touch bottom border
            If Bloc.Y >= 230 Then
                Yinterval = -5
            End If

            ' Touch upper border
            If Bloc.Y <= 0 Then
                Yinterval = 5
            End If

            ' Touch left border - die
            If Bloc.X <= 0 Then
                MessageBox.Show("You died!" & Environment.NewLine & "You got: " & points & " points total!")
                Form1.Close()
                Me.Close()
            End If

            ' Move the ball
            ball.Location = New Point(Bloc.X + Xinterval, Bloc.Y + Yinterval)
            Await Task.Delay(speed)

        End While
    End Sub

    Private Sub Form2_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Down Then
            Dim Ploc = platform.Location
            If Not (BackPanelBottom.Bounds.IntersectsWith(platform.Bounds)) Then
                platform.Location = New Point(Ploc.X, Ploc.Y + 5)
            End If
        End If
            If e.KeyCode = Keys.Up Then
            Dim Ploc = platform.Location
            If Not (BackPanelUp.Bounds.IntersectsWith(platform.Bounds)) Then
                platform.Location = New Point(Ploc.X, Ploc.Y - 5)
            End If

        End If
    End Sub
End Class