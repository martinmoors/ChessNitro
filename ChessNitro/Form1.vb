Public Class Form1
    Dim firstWhite As Boolean = False
    Dim whiteTurn As Boolean = True
    Dim blackTurn As Boolean = False
    Dim colorChanged As Boolean = False
    Dim turn As Boolean = True
    Dim numClick As Integer = 1
    Dim game As New Game
    Dim array(,) As Integer
    Dim blk() As PictureBox
    Dim x As Integer
    Dim y As Integer
    Dim tag As Integer
    Dim testArray() As Integer
    Dim clickedY As Integer

    Public Sub New()
        Me.InitializeComponent()

        refreshBoard()

        Dim posMovesWhite As New Hashtable()

        posMovesWhite.Add(1.1, {0, 1})
        posMovesWhite.Add(1.2, {0, 2})
        posMovesWhite.Add(2.1, {2, 1})
        posMovesWhite.Add(2.2, {2, -1})
        posMovesWhite.Add(2.3, {1, 2})
        posMovesWhite.Add(2.4, {-1, 2})
        'posMovesWhite.Add(3, {n, n})
        'posMovesWhite.Add(3, {-n, n})
        'posMovesWhite.Add(3, {n, -n})
        'posMovesWhite.Add(3, {-n, -n})
        'posMovesWhite.Add(4, {0, n})
        'posMovesWhite.Add(4, {n, 0})
        'posMovesWhite.Add(4, {0, -n})
        'posMovesWhite.Add(4, {-n, 0})
        'posMovesWhite.Add(5, {n, n})
        'posMovesWhite.Add(5, {-n, n})
        'posMovesWhite.Add(5, {n, -n})
        'posMovesWhite.Add(5, {-n, -n})
        'posMovesWhite.Add(5, {0, n})
        'posMovesWhite.Add(5, {n, 0})
        'posMovesWhite.Add(5, {0, -n})
        'posMovesWhite.Add(5, {-n, 0})
        posMovesWhite.Add(6.1, {0, 1})
        posMovesWhite.Add(6.2, {1, 1})
        posMovesWhite.Add(6.3, {1, 0})
        posMovesWhite.Add(6.4, {1, -1})
        posMovesWhite.Add(6.5, {0, -1})
        posMovesWhite.Add(6.6, {-1, -1})
        posMovesWhite.Add(6.7, {-1, 0})
        posMovesWhite.Add(6.8, {-1, 1})

    End Sub

    Sub MyMultipleEventHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click, PictureBox2.Click, PictureBox3.Click, PictureBox4.Click, PictureBox5.Click, PictureBox6.Click, PictureBox7.Click, PictureBox8.Click, PictureBox9.Click, PictureBox10.Click, PictureBox11.Click, PictureBox12.Click, PictureBox13.Click, PictureBox14.Click, PictureBox15.Click, PictureBox16.Click, PictureBox17.Click, PictureBox18.Click, PictureBox19.Click, PictureBox20.Click, PictureBox21.Click, PictureBox22.Click, PictureBox23.Click, PictureBox24.Click, PictureBox25.Click, PictureBox26.Click, PictureBox27.Click, PictureBox28.Click, PictureBox29.Click, PictureBox30.Click, PictureBox31.Click, PictureBox32.Click, PictureBox33.Click, PictureBox34.Click, PictureBox35.Click, PictureBox36.Click, PictureBox37.Click, PictureBox38.Click, PictureBox39.Click, PictureBox40.Click, PictureBox41.Click, PictureBox42.Click, PictureBox43.Click, PictureBox44.Click, PictureBox45.Click, PictureBox46.Click, PictureBox47.Click, PictureBox48.Click, PictureBox49.Click, PictureBox50.Click, PictureBox51.Click, PictureBox52.Click, PictureBox53.Click, PictureBox54.Click, PictureBox55.Click, PictureBox56.Click, PictureBox57.Click, PictureBox58.Click, PictureBox59.Click, PictureBox60.Click, PictureBox61.Click, PictureBox62.Click, PictureBox63.Click, PictureBox64.Click
        Dim thisPic As PictureBox = DirectCast(sender, PictureBox)

        array = game.getBoard()
        If (numClick.Equals(1)) Then
            Select Case thisPic.Name
                Case "PictureBox9"
                    x = 0
                    y = 1
                Case "PictureBox10"
                    x = 1
                    y = 1
                    tag = thisPic.Tag
                Case "PictureBox17"
                    x = 0
                    y = 2
                    tag = thisPic.Tag
                    clickedY = 2
                Case "PictureBox18"
                    x = 1
                    y = 2
                    tag = thisPic.Tag
                Case "PictureBox25"
                    x = 0
                    y = 3
                    tag = thisPic.Tag
                Case "PictureBox26"
                    x = 1
                    y = 3
                    tag = thisPic.Tag
                Case "PictureBox33"
                    x = 0
                    y = 4
                    tag = thisPic.Tag
                Case "PictureBox34"
                    x = 1
                    y = 4
                    tag = thisPic.Tag
                Case "PictureBox41"
                    x = 0
                    y = 5
                    tag = thisPic.Tag
                Case "PictureBox42"
                    x = 1
                    y = 5
                    tag = thisPic.Tag
            End Select
            ' If (array(y + 1, x) = 0) Then
            'thisPic.Tag = 0
            'End If
            numClick = 2
        ElseIf (numClick.Equals(2)) Then

            Select Case thisPic.Name
                Case "PictureBox9"
                    Select Case thisPic.Tag
                        Case 1
                            Select Case x
                                Case 0
                                    x = 0
                                    y = 1
                                    game.move(x, y, tag)
                                    array = game.getBoard
                                    refreshBoard()
                                Case Else
                            End Select
                    End Select
                Case "PictureBox17"
                    Select Case thisPic.Tag
                        Case 0
                            Select Case x
                                Case 0
                                    x = 0
                                    y = 2
                                    game.move(x, y, tag)
                                    array = game.getBoard
                                    refreshBoard()
                                Case Else
                            End Select
                    End Select
                Case "PictureBox18"
                    Select Case x
                        Case 1
                            x = 1
                            y = 2
                            game.move(x, y, tag)
                            array = game.getBoard
                            refreshBoard()
                    End Select
                Case "PictureBox25"
                    Select Case x
                        Case 0
                            x = 0
                            y = 3
                            If (y >= clickedY) Then
                                game.move(x, y, tag)
                            End If
                            array = game.getBoard
                            refreshBoard()
                        Case Else
                    End Select
                Case "PictureBox26"
                    Select Case x
                        Case 1
                            x = 1
                            y = 3
                            game.move(x, y, tag)
                            array = game.getBoard
                            refreshBoard()
                        Case Else
                    End Select
                Case "PictureBox33"
                    Select Case thisPic.Tag
                        Case 0
                            Select Case x
                                Case 0
                                    x = 0
                                    y = 4
                                    game.move(x, y, tag)
                                    array = game.getBoard
                                    refreshBoard()
                                Case Else
                            End Select
                    End Select
                Case "PictureBox34"
                    Select Case x
                        Case 1
                            game.move(x, y, tag)
                            thisPic.Tag = 1
                            array = game.getBoard
                            refreshBoard()
                        Case Else
                    End Select
                Case "PictureBox41"
                    Select Case x
                        Case 0
                            x = 0
                            y = 5
                            game.move(x, y, tag)
                            thisPic.Tag = 1
                            array = game.getBoard
                            refreshBoard()
                        Case Else
                    End Select
                Case "PictureBox42"
                    Select Case x
                        Case 1
                            game.move(x, y, tag)
                            thisPic.Tag = 1
                            array = game.getBoard
                            refreshBoard()
                        Case Else
                    End Select
                Case "PictureBox49"
                    Select Case x
                        Case 0
                            x = 0
                            y = 6
                            game.move(x, y, tag)
                            thisPic.Tag = 1
                            array = game.getBoard
                            refreshBoard()
                        Case Else
                    End Select
                Case "PictureBox50"
                    Select Case x
                        Case 1
                            array = game.getBoard

                            game.move(x, y, tag)

                            thisPic.Tag = 1

                            array = game.getBoard
                            refreshBoard()
                        Case Else
                    End Select
            End Select
            numClick = 1
        End If
    End Sub

    Private Sub refreshBoard()
        array = game.getBoard
        Dim array1D(84) As Integer
        Dim index As Integer
        index = 0
        For Each item In array
            array1D(index) = item
            index += 1
        Next
        index = 0

        For Each cntrl As Control In Me.Controls

            Dim result As Integer

            If TypeOf cntrl Is PictureBox Then
                If Integer.TryParse(cntrl.Tag, result) Then
                    If Not cntrl.Tag.Equals("100") Then
                        CType(cntrl, PictureBox).Tag = array1D(index)
                        index += 1
                    End If
                End If
            End If
        Next

        For row = 0 To 7
            For col = 0 To 7
                Debug.Write(array(row, col) & " ")
                If (col = 7) Then
                    Debug.WriteLine("")
                End If
            Next col
        Next row
        Debug.Write("--------------------" & vbCrLf)

        For Each fig As Integer In array
            For Each cntrl As Control In Me.Controls
                Dim result As Integer
                If TypeOf cntrl Is PictureBox Then
                    If Integer.TryParse(cntrl.Tag, result) Then
                        If Not cntrl.Tag.Equals("100") Then
                            Select Case fig
                                Case 0
                                    If cntrl.Tag = 0 Then
                                        CType(cntrl, PictureBox).Image = Nothing
                                    End If
                                Case 1
                                    If cntrl.Tag = 1 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.bauer
                                    End If
                                Case 2
                                    If cntrl.Tag = 2 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.springer
                                    End If
                                Case 3
                                    If cntrl.Tag = 3 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
                                    End If
                                Case 4
                                    If cntrl.Tag = 4 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
                                    End If
                                Case 5
                                    If cntrl.Tag = 5 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenigin
                                    End If
                                Case 6
                                    If cntrl.Tag = 6 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenigin_schwarz
                                    End If
                                Case 7
                                    If cntrl.Tag = 7 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
                                    End If
                                Case 8
                                    If cntrl.Tag = 8 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz
                                    End If
                                Case 9
                                    If cntrl.Tag = 9 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.laeufer
                                    End If
                                Case 10
                                    If cntrl.Tag = 10 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.turm
                                    End If
                                Case 11
                                    If cntrl.Tag = 11 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenigin2_schwarz
                                    End If
                                Case 12
                                    If cntrl.Tag = 12 Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenig
                                    End If
                            End Select
                        End If
                    End If
                End If
            Next
        Next

    End Sub

    Private Sub newGame_Click(sender As Object, e As EventArgs) Handles newGame.Click
        reset()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        reset()
    End Sub

    Private Sub reset()
        If (colorChanged = False) Then
            PictureBox64.Image = Global.ChessNitro.My.Resources.Resources.turm
            PictureBox63.Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz
            PictureBox62.Image = Global.ChessNitro.My.Resources.Resources.laeufer
            PictureBox61.Image = Global.ChessNitro.My.Resources.Resources.koenig
            PictureBox60.Image = Global.ChessNitro.My.Resources.Resources.koenigin2_schwarz
            PictureBox59.Image = Global.ChessNitro.My.Resources.Resources.laeufer
            PictureBox58.Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz
            PictureBox57.Image = Global.ChessNitro.My.Resources.Resources.turm
            PictureBox56.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox55.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox54.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox53.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox52.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox51.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox50.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox49.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox17.Image = Nothing
            PictureBox18.Image = Nothing
            PictureBox19.Image = Nothing
            PictureBox20.Image = Nothing
            PictureBox21.Image = Nothing
            PictureBox22.Image = Nothing
            PictureBox23.Image = Nothing
            PictureBox24.Image = Nothing
            PictureBox25.Image = Nothing
            PictureBox26.Image = Nothing
            PictureBox27.Image = Nothing
            PictureBox28.Image = Nothing
            PictureBox29.Image = Nothing
            PictureBox30.Image = Nothing
            PictureBox31.Image = Nothing
            PictureBox32.Image = Nothing
            PictureBox33.Image = Nothing
            PictureBox34.Image = Nothing
            PictureBox35.Image = Nothing
            PictureBox36.Image = Nothing
            PictureBox37.Image = Nothing
            PictureBox38.Image = Nothing
            PictureBox39.Image = Nothing
            PictureBox40.Image = Nothing
            PictureBox41.Image = Nothing
            PictureBox42.Image = Nothing
            PictureBox43.Image = Nothing
            PictureBox44.Image = Nothing
            PictureBox45.Image = Nothing
            PictureBox46.Image = Nothing
            PictureBox47.Image = Nothing
            PictureBox48.Image = Nothing
            PictureBox16.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox15.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox14.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox13.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox12.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox11.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox10.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox9.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox8.Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
            PictureBox7.Image = Global.ChessNitro.My.Resources.Resources.springer
            PictureBox6.Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
            PictureBox5.Image = Global.ChessNitro.My.Resources.Resources.koenigin_schwarz
            PictureBox4.Image = Global.ChessNitro.My.Resources.Resources.koenigin
            PictureBox3.Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
            PictureBox2.Image = Global.ChessNitro.My.Resources.Resources.springer
            PictureBox1.Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
            colorChanged = True
        Else
            PictureBox1.Tag = 4
            PictureBox1.Image = Global.ChessNitro.My.Resources.Resources.turm
            PictureBox2.Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz
            PictureBox3.Image = Global.ChessNitro.My.Resources.Resources.laeufer
            PictureBox4.Image = Global.ChessNitro.My.Resources.Resources.koenig
            PictureBox5.Image = Global.ChessNitro.My.Resources.Resources.koenigin2_schwarz
            PictureBox6.Image = Global.ChessNitro.My.Resources.Resources.laeufer
            PictureBox7.Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz
            PictureBox8.Image = Global.ChessNitro.My.Resources.Resources.turm
            PictureBox9.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox10.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox11.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox12.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox13.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox14.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox15.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox16.Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz
            PictureBox17.Image = Nothing
            PictureBox18.Image = Nothing
            PictureBox19.Image = Nothing
            PictureBox20.Image = Nothing
            PictureBox21.Image = Nothing
            PictureBox22.Image = Nothing
            PictureBox23.Image = Nothing
            PictureBox24.Image = Nothing
            PictureBox25.Image = Nothing
            PictureBox26.Image = Nothing
            PictureBox27.Image = Nothing
            PictureBox28.Image = Nothing
            PictureBox29.Image = Nothing
            PictureBox30.Image = Nothing
            PictureBox31.Image = Nothing
            PictureBox32.Image = Nothing
            PictureBox33.Image = Nothing
            PictureBox34.Image = Nothing
            PictureBox35.Image = Nothing
            PictureBox36.Image = Nothing
            PictureBox37.Image = Nothing
            PictureBox38.Image = Nothing
            PictureBox39.Image = Nothing
            PictureBox40.Image = Nothing
            PictureBox41.Image = Nothing
            PictureBox42.Image = Nothing
            PictureBox43.Image = Nothing
            PictureBox44.Image = Nothing
            PictureBox45.Image = Nothing
            PictureBox46.Image = Nothing
            PictureBox47.Image = Nothing
            PictureBox48.Image = Nothing
            PictureBox49.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox50.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox51.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox52.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox53.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox54.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox55.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox56.Image = Global.ChessNitro.My.Resources.Resources.bauer
            PictureBox57.Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
            PictureBox58.Image = Global.ChessNitro.My.Resources.Resources.springer
            PictureBox59.Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
            PictureBox60.Image = Global.ChessNitro.My.Resources.Resources.koenigin_schwarz
            PictureBox61.Image = Global.ChessNitro.My.Resources.Resources.koenigin
            PictureBox62.Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
            PictureBox63.Image = Global.ChessNitro.My.Resources.Resources.springer
            PictureBox64.Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
            colorChanged = False
        End If
    End Sub
End Class
