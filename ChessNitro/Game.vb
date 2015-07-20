Public Class Game
    Dim array(,) As Integer = {{4, 2, 3, 5, 6, 3, 2, 4}, {1, 1, 1, 1, 1, 1, 1, 1}, {0, 0, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0}, {7, 7, 0, 0, 0, 0, 0, 0}, {0, 0, 0, 0, 0, 0, 0, 0}, {7, 7, 7, 7, 7, 7, 7, 7}, {10, 8, 9, 11, 12, 9, 8, 10}}
    Dim firstWhite(8) As Boolean
    Dim firstBlack(8) As Boolean
    Dim check As Boolean = False
    Dim checkmate As Boolean = False


    Public Sub New()
        For index As Integer = 0 To 7
            firstWhite(index) = False
        Next

        For index As Integer = 0 To 7
            firstBlack(index) = False
        Next


    End Sub

    Public Sub Game()

    End Sub

    Function test() As Single
        Return 1
    End Function

    Function move(x As Integer, y As Integer, fig As Integer)

        array(y, x) = array(y - 1, x)
        array(y - 1, x) = 0

        Return 0

    End Function

    Function isNoError(x As Integer, y As Integer)

        Return array(x, y) <> 0
    End Function

    Function test(x As Integer, y As Integer, tag As Integer)
        array(x, y) = tag
        Return 0
    End Function

    Function getBoard() As Integer(,)

        Return array

    End Function

    Function setFirstWhite(pos As Integer)
        firstWhite(pos) = True
    End Function

    Function getFirstWhite(pos As Integer) As Integer
        Return firstWhite(pos)
    End Function
End Class
