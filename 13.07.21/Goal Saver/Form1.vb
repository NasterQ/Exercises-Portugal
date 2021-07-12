Imports System.Drawing.Text

Public Class Form1
    Public opt = New Options
    Dim sizeB = 1 ' 0 - small | 1 - big: 10,130
    Dim speed = 0 ' 0 - slow | 1 - fast

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        opt.setSpeed(speed)
        opt.setSize(sizeB)
        Form2.Show()
        Me.Hide()
    End Sub

    Private Sub sizeBigLab_Click(sender As Object, e As EventArgs) Handles sizeBigLab.Click
        If sender.Font.Bold = False Then
            sender.Font = New Font(sizeBigLab.Font, FontStyle.Bold)
            sender.ForeColor = Color.Orange
            sizeB = 1

            ' Unclick the other button
            sizeSmallLab.Font = New Font(sizeSmallLab.Font, FontStyle.Regular)
            sizeSmallLab.ForeColor = Color.White
        End If
    End Sub

    Private Sub sizeSmallLab_Click(sender As Object, e As EventArgs) Handles sizeSmallLab.Click
        If sender.Font.Bold = False Then
            sender.Font = New Font(sizeBigLab.Font, FontStyle.Bold)
            sender.ForeColor = Color.Orange
            sizeB = 0

            ' Unclick the other button
            sizeBigLab.Font = New Font(sizeBigLab.Font, FontStyle.Regular)
            sizeBigLab.ForeColor = Color.White
        End If
    End Sub

    Private Sub speedSlowLab_Click(sender As Object, e As EventArgs) Handles speedSlowLab.Click
        If sender.Font.Bold = False Then
            sender.Font = New Font(speedSlowLab.Font, FontStyle.Bold)
            sender.ForeColor = Color.Orange
            speed = 0

            ' Unclick the other button
            speedFastLab.Font = New Font(speedFastLab.Font, FontStyle.Regular)
            speedFastLab.ForeColor = Color.White
        End If
    End Sub

    Private Sub speedFastLab_Click(sender As Object, e As EventArgs) Handles speedFastLab.Click
        If sender.Font.Bold = False Then
            sender.Font = New Font(speedFastLab.Font, FontStyle.Bold)
            sender.ForeColor = Color.Orange
            speed = 1

            ' Unclick the other button
            speedSlowLab.Font = New Font(speedSlowLab.Font, FontStyle.Regular)
            speedSlowLab.ForeColor = Color.White
        End If
    End Sub
End Class
