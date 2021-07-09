Public Class Form1

    Function Generate(ByVal quantity As Integer, ByVal startR As Integer, ByVal stopR As Integer)
        Dim i = 0
        Dim list As New List(Of Integer)
        Dim rep = 0
        While i < quantity
            Dim value As Integer = CInt(Int((stopR * Rnd()) + startR))
            ' Check if it has already occurred
            For j = 0 To (i - 1)
                If list(j) = value Then
                    rep = 1 ' Repeat the process
                End If
            Next

            If rep = 0 Then
                list.Add(value)
                i += 1

            End If
            rep = 0

        End While
        Return list
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Randomize()

        ' Generate 5 numbers 1 - 50
        Dim list = Generate(5, 1, 50)
        n1.Text = list(0)
        n2.Text = list(1)
        n3.Text = list(2)
        n4.Text = list(3)
        n5.Text = list(4)

        ' Generate 2 numbers 1 - 7
        list = Generate(2, 1, 7)
        n6.Text = list(0)
        n7.Text = list(1)

    End Sub
End Class
