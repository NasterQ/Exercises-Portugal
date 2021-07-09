Public Class Form1

    ' Exercise 1 & 2
    Private Sub helloBut_Click(sender As Object, e As EventArgs) Handles helloBut.Click
        hello.Text = "Hello world!"
    End Sub

    ' Exercise 3
    Private Sub submitBut_Click(sender As Object, e As EventArgs) Handles submitBut.Click
        greetingsLab.Text = "Hello, " & nameBox.Text & "!"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim details
        If Radio1.Checked Then
            details = "You are from " & countryCombo.SelectedItem & "."
            detailsLab.Text = details
        Else
            details = "You didn't want to display your country."
        End If
        detailsLab.Text = details

    End Sub

    Private Sub Radio2_CheckedChanged(sender As Object, e As EventArgs) Handles Radio2.CheckedChanged

    End Sub

    Private Sub detailsLab_Click(sender As Object, e As EventArgs) Handles detailsLab.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class
