﻿Public Class Game
    Dim array(,) As Integer = {{4, 2, 3, 5, 6, 3, 2, 4}, {1, 1, 1, 1, 1, 1, 1, 1}, {0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0}, {7, 7, 7, 7, 7, 7, 7, 7}, {10, 8, 9, 11, 12, 9, 8, 10}}

    Dim check As Boolean = False
    Dim checkmate As Boolean = False

    Public Sub Game()

    End Sub

    Function test() As Single
        Return 1
    End Function

    Function move(x As Integer, y As Integer, turnColor As Boolean)
        If (turnColor) Then
            array(x + 1, 0) = array(x, 0)
            array(x, 0) = 0
        End If

        Return 0
    End Function

    Function getBoard() As Integer(,)

        Return array

    End Function
End Class