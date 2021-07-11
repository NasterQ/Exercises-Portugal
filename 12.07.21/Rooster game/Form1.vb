Public Class Form1

    Dim sizeG = 9
    Dim turn = 0
    Dim board As New List(Of Integer)
    Dim board_e As New List(Of Label)
    Dim control = True
    Dim turns = 0

    Function ShowMessage(ByVal ch As Integer)
        If ch = 0 Then
            MessageBox.Show("O wins!")
        Else
            MessageBox.Show("X wins!")
        End If
        control = False
        turns = 0
    End Function

    Function Highlight(ByVal tl1 As Integer, ByVal tl2 As Integer, ByVal tl3 As Integer)
        board_e(tl1).ForeColor = Color.LawnGreen
        board_e(tl2).ForeColor = Color.LawnGreen
        board_e(tl3).ForeColor = Color.LawnGreen
    End Function

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Initialize an array: negative numbers mean: there is nothing on the tile
        For i = 0 To sizeG
            board.Add(-(i + 1))
        Next

        board_e.Add(t0)
        board_e.Add(t1)
        board_e.Add(t2)
        board_e.Add(t3)
        board_e.Add(t4)
        board_e.Add(t5)
        board_e.Add(t6)
        board_e.Add(t7)
        board_e.Add(t8)

    End Sub


    ' Game functionality
    Private Sub Char_Click(sender As Object, e As EventArgs) Handles t4.Click, t1.Click, t3.Click, t2.Click, t0.Click, t8.Click, t7.Click, t6.Click, t5.Click

        ' Calculate which field was clicked
        Dim offset = 15 ' for Y offset: +1
        Dim l = sender.Location

        ' Calculate the field's index
        ' For Y: *3 for X: +1
        Dim xx = (l.X - offset) \ 67
        Dim yy = ((l.Y - offset - 1) \ 65) * 3
        Dim index = xx + yy
        If control = False Then
            Return
        End If

        If turn = 0 And board(index) <> 0 And board(index) <> 1 Then
            sender.Text = "O"
            turnLab.Text = "Turn: X"
            turn = 1
            board(index) = 0
            turns += 1
        ElseIf board(index) <> 0 And board(index) <> 1 Then
            sender.Text = "X"
            turn = 0
            turnLab.Text = "Turn: O"
            board(index) = 1
            turns += 1
        End If

        ' Check if won

        If board(0) = board(1) And board(1) = board(2) Then
            Highlight(0, 1, 2)
            ShowMessage(board(0))
        End If

        If board(3) = board(4) And board(4) = board(5) Then
            Highlight(3, 4, 5)
            ShowMessage(board(3))
        End If

        If board(6) = board(7) And board(7) = board(8) Then
            Highlight(6, 7, 8)
            ShowMessage(board(6))
        End If

        If board(0) = board(3) And board(3) = board(6) Then
            Highlight(0, 3, 6)
            ShowMessage(board(0))
        End If

        If board(1) = board(4) And board(4) = board(7) Then
            Highlight(1, 4, 7)
            ShowMessage(board(1))
        End If

        If board(2) = board(5) And board(5) = board(8) Then
            Highlight(2, 5, 8)
            ShowMessage(board(2))
        End If

        If board(0) = board(4) And board(4) = board(8) Then
            Highlight(0, 4, 8)
            ShowMessage(board(0))
        End If

        If board(2) = board(4) And board(4) = board(6) Then
            Highlight(2, 4, 6)
            ShowMessage(board(2))
        End If


        ' Check if draw (all turns have been done and nobody won)
        If turns = 9 And control = True Then
            MessageBox.Show("Draw! Nobody wins!")
            control = False
            turns = 0
        End If

    End Sub

    Private Sub resBut_Click(sender As Object, e As EventArgs) Handles resBut.Click
        For i = 0 To sizeG
            board(i) = (-(i + 1))
        Next

        For i = 0 To 8
            board_e(i).ForeColor = Color.Black
            board_e(i).Text = ""
        Next

        control = True

    End Sub
End Class
