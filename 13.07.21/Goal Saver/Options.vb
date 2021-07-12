Public Class Options

    Public speed, size

    Public Sub setSpeed(spd)
        speed = spd
    End Sub

    Public Sub setSize(sz)
        size = sz
    End Sub

    Public Function getSpeed() As Integer
        Return speed
    End Function
    Public Function getSize() As Integer
        Return size
    End Function

End Class
