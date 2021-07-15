Imports System.IO
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        If result = Windows.Forms.DialogResult.OK Then
            Dim path As String = OpenFileDialog1.FileName
            Dim text As String = File.ReadAllText(path)
            FileBox.Text = text
            pathLab.Text = "Path: " & path
        End If

    End Sub

    Private Sub SaveBut_Click(sender As Object, e As EventArgs) Handles SaveBut.Click
        Dim quantity As Integer
        Dim stopA = False
        Dim path As String
        If numberBox.Text = "" Then
            quantity = 1
        Else
            Try
                quantity = numberBox.Text
            Catch ex As Exception
                MessageBox.Show("Input a proper number of files" & Environment.NewLine & "(or leave an empty box for 1)")
                stopA = True
            End Try
        End If

        If stopA Then
            Exit Sub
        End If

        SaveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        If nameBox.Text <> "" Then
            SaveFileDialog1.FileName = nameBox.Text
            If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK _
                 Then
                My.Computer.FileSystem.WriteAllText _
                    (SaveFileDialog1.FileName, ContentBox.Text, True)
                path = SaveFileDialog1.FileName

                Dim newPath = path
                ' Multiple file saving functionality
                For i = 1 To (quantity - 1)
                    If System.IO.File.Exists(path) = True Then
                        ' Create a new name for the file not to overwrite the old one
                        Dim txtPos = path.IndexOf(".txt")
                        newPath = path.Insert(txtPos, "-" & i)
                        Dim file As System.IO.FileStream
                        file = System.IO.File.Create(newPath)
                        file.Close()
                    End If
                    My.Computer.FileSystem.WriteAllText(newPath, ContentBox.Text, True)
                Next
            End If
        End If

    End Sub
End Class
