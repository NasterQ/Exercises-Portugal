Public Class Form2

    ' Creepy function
    Private Sub LoadTiles(tiles)
        tiles.Add(p0)
        tiles.Add(p1)
        tiles.Add(p2)
        tiles.Add(p3)
        tiles.Add(p4)
        tiles.Add(p5)
        tiles.Add(p6)
        tiles.Add(p7)
        tiles.Add(p8)
        tiles.Add(p9)
        tiles.Add(p10)
        tiles.Add(p11)
        tiles.Add(p12)
        tiles.Add(p13)
        tiles.Add(p14)
        tiles.Add(p15)
        tiles.Add(p16)
        tiles.Add(p17)
        tiles.Add(p18)
        tiles.Add(p19)
        tiles.Add(p20)
        tiles.Add(p21)
        tiles.Add(p22)
        tiles.Add(p23)
        tiles.Add(p24)
        tiles.Add(p25)
        tiles.Add(p26)
        tiles.Add(p27)
        tiles.Add(p28)
        tiles.Add(p29)
        tiles.Add(p30)
        tiles.Add(p31)
        tiles.Add(p32)
        tiles.Add(p33)
        tiles.Add(p34)
        tiles.Add(p35)
        tiles.Add(p36)
        tiles.Add(p37)
        tiles.Add(p38)
        tiles.Add(p39)
        tiles.Add(p40)
        tiles.Add(p41)
    End Sub

    Private Sub DisableButtons()
        c1.Enabled = False
        c2.Enabled = False
        c3.Enabled = False
        c4.Enabled = False
        c5.Enabled = False
        c6.Enabled = False
        c7.Enabled = False
    End Sub

    Private Sub EnableButtons()
        c1.Enabled = True
        c2.Enabled = True
        c3.Enabled = True
        c4.Enabled = True
        c5.Enabled = True
        c6.Enabled = True
        c7.Enabled = True
    End Sub
    Private Sub ChangeTurns()
        If turn = 0 Then
            imgTurn.Image = My.Resources.Y_Tokens
            turn = 1
        ElseIf turn = 1 Then
            imgTurn.Image = My.Resources.R_Tokens
            turn = 0
        End If
    End Sub

    Function PlaceToken(t, brd, tls, line)
        Dim count = 0
        Dim placed = -1
        For i = 41 - line To 0 Step -7

            If brd(i) = 0 Or brd(i) = 1 Then
                count += 1
                If count = 6 Then
                    Return False
                End If
                Continue For

            Else
                brd(i) = t
                tCount += 1
                If i = 0 Then
                    placed = -1
                Else
                    placed = i
                End If

                If t = 0 Then
                    tls(i).Image = My.Resources.R_T
                    Exit For
                Else
                    tls(i).Image = My.Resources.Y_T
                    Exit For
                End If

            End If
        Next
        Return placed
    End Function

    Dim turn = 0 ' 0 - red | 1 - yellow
    Dim tCount = 0
    Dim board(42) ' An array for storing tokens put on the board
    Dim tiles = New List(Of PictureBox)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        For i = 0 To 41
            board(i) = -(i + 1)
        Next

        ' Save all tiles in an array
        LoadTiles(tiles)

        ' Align tiles to a board
        Dim xx = 10
        Dim yy = 40

        For i = 0 To 41
            If i Mod 7 = 0 And i <> 0 Then
                ' Go back to the 1st element from left
                yy += 60
                xx = 10
            End If
            tiles(i).Location = New Point(xx, yy)
            xx += 60
        Next

        If Form1.u1.getNickname() <> "" Then
            p1Lab.Text = Form1.u1.getNickname()
        Else
            Form1.u1.setNickname("Player 1")
        End If

        If Form1.u2.getNickname() <> "" Then
            p2Lab.Text = Form1.u2.getNickname()
        Else
            Form1.u2.setNickname("Player 2")
        End If

    End Sub


    ' After a click on a button, chech if someone has won
    Private Sub CheckIfWon(square)
        ' square - index of the last placed token

        ' Check the horizontal victory
#Region "Horizontal Victory"

        ' Find the row | 0 is the 1st row
        Dim row = square \ 7
        ' Find max, min range of indexes for that row
        Dim minR = row * 7
        Dim maxR = minR + 6
        Dim win = False

        Dim tokens = 1
        Dim i = minR
        While True
            If board(i) = board(i + 1) And board(i) = turn Then
                tokens += 1
                If tokens >= 4 Then
                    win = True
                End If
            Else
                tokens = 1
            End If
            i += 1
            If (i + 1) > maxR Then
                Exit While
            End If
        End While

#End Region

        ' Check the vertical victory
#Region "Vertical Victory"
        ' Find the column
        ' col is also a min range of indexes for the column
        Dim col = square Mod 7
        ' Find max range of indexes for that column
        Dim maxC = 35 + col

        tokens = 1

        For i = col To maxC Step 7
            If i >= maxC Then
                Exit For
            End If
            If board(i) = board(i + 7) And board(i) = turn Then
                tokens += 1
                If tokens >= 4 Then
                    win = True
                End If
            Else
                tokens = 1
            End If
        Next
#End Region

        ' Check the diagonal victory (left-to-right)
#Region "Diagonal Victory L-R"

        tokens = 1
        ' We are going to use column (col) and row (row) to determine if the victory is sought within the game field
        ' Find the starting point in the diagonal
        Dim minDL = square

        ' Calculate how many tiles are there in diagonal to min point
        Dim quantity
        If col <= row Then
            quantity = col
        Else
            quantity = row
        End If

        ' Find the min point
        For i = quantity - 1 To 0 Step -1
            minDL -= 8
        Next

        ' Find the max point
        Dim maxDL = minDL
        ' Calculate min'x point row and column
        Dim rDL = minDL \ 7
        Dim cDL = minDL Mod 7
        If cDL = 0 Then
            quantity = 5 - rDL
        ElseIf rDL = 0 Then
            quantity = 6 - cDL
        End If

        ' Find the max point
        For i = quantity - 1 To 0 Step -1
            maxDL += 8
        Next

        ' Check if someone has won
        For i = minDL To (maxDL - 8) Step 8
            If board(i) = board(i + 8) And board(i) = turn Then
                tokens += 1
                If tokens >= 4 Then
                    win = True
                End If
            Else
                tokens = 1
            End If
        Next

#End Region

        ' Check the diagonal victory (right-to-left)
#Region "Diagonal Victory R-L"

        tokens = 1
        ' Find the starting point in the diagonal
        Dim minDR = square

        ' Calculate how many tiles are there in diagonal to min point
        Dim value = col

        For i = 0 To row
            If i >= 6 - col Then
                value -= 1
            End If
        Next

        ' Find the min point
        For i = value - 1 To 0 Step -1
            minDR += 6
        Next

        ' Find the max point
        Dim maxDR = minDR
        ' Calculate min'x point row and column
        Dim rDR = minDR \ 7
        Dim cDR = minDR Mod 7
        If cDR = 0 Then
            quantity = rDR
        ElseIf rDR = 5 Then
            quantity = 6 - cDR
        End If

        ' Find the max point
        For i = quantity - 1 To 0 Step -1
            maxDR -= 6
        Next

        ' Check if someone has won
        For i = maxDR To (minDR - 6) Step 6
            If board(i) = board(i + 6) And board(i) = turn Then
                tokens += 1
                If tokens >= 4 Then
                    win = True
                End If
            Else
                tokens = 1
            End If
        Next

#End Region

        ' If somebody won, display a message and disable game buttons
        If win Then
            DisableButtons()
            If turn = 0 Then
                MessageBox.Show(Form1.u1.getNickname() & " wins!")
            ElseIf turn = 1 Then
                MessageBox.Show(Form1.u2.getNickname() & " wins!")
            End If
        End If

        If tCount = 42 And win = False Then
            DisableButtons()
            MessageBox.Show("Draw! Nobody wins!")
        End If

    End Sub

    Private Sub c1_Click(sender As Object, e As EventArgs) Handles c1.Click
        Dim success = PlaceToken(turn, board, tiles, 6) ' line index is counted from right to left: 6 - 0
        If success <> False Then
            If success = -1 Then
                success = 0
            End If
            CheckIfWon(success)
            ChangeTurns()
        End If
    End Sub

    Private Sub c2_Click(sender As Object, e As EventArgs) Handles c2.Click
        Dim success = PlaceToken(turn, board, tiles, 5)
        If success <> False Then
            CheckIfWon(success)
            ChangeTurns()
        End If
    End Sub

    Private Sub c3_Click(sender As Object, e As EventArgs) Handles c3.Click
        Dim success = PlaceToken(turn, board, tiles, 4)
        If success <> False Then
            CheckIfWon(success)
            ChangeTurns()
        End If
    End Sub

    Private Sub c4_Click(sender As Object, e As EventArgs) Handles c4.Click
        Dim success = PlaceToken(turn, board, tiles, 3)
        If success <> False Then
            CheckIfWon(success)
            ChangeTurns()
        End If
    End Sub

    Private Sub c5_Click(sender As Object, e As EventArgs) Handles c5.Click
        Dim success = PlaceToken(turn, board, tiles, 2)
        If success <> False Then
            CheckIfWon(success)
            ChangeTurns()
        End If
    End Sub

    Private Sub c6_Click(sender As Object, e As EventArgs) Handles c6.Click
        Dim success = PlaceToken(turn, board, tiles, 1)
        If success <> False Then
            CheckIfWon(success)
            ChangeTurns()
        End If
    End Sub

    Private Sub c7_Click(sender As Object, e As EventArgs) Handles c7.Click
        Dim success = PlaceToken(turn, board, tiles, 0)
        If success <> False Then
            CheckIfWon(success)
            ChangeTurns()
        End If
    End Sub

    Private Sub resBut_Click(sender As Object, e As EventArgs) Handles resBut.Click
        EnableButtons()
        ' Reset images in tiles
        For i = 0 To 41
            tiles(i).Image = My.Resources.B_T
            board(i) = -(i + 1)
        Next
        tCount = 0
    End Sub
End Class