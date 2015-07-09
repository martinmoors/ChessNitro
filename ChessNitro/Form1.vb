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
    ' Dim chessFields(,) As PictureBox

    Public Sub New()
        Me.InitializeComponent()
        
        'blk = New PictureBox() {PictureBox1, PictureBox2, PictureBox3, PictureBox4, PictureBox5, PictureBox6, PictureBox7, PictureBox8, PictureBox9, PictureBox10, PictureBox11, PictureBox12, PictureBox13, PictureBox14, PictureBox15, PictureBox16, PictureBox17, PictureBox18, PictureBox19, PictureBox20, PictureBox21, PictureBox22, PictureBox23, PictureBox24, PictureBox25, PictureBox26, PictureBox27, PictureBox28, PictureBox29, PictureBox30, PictureBox31, PictureBox32, PictureBox33, PictureBox34, PictureBox35, PictureBox36, PictureBox37, PictureBox38, PictureBox39, PictureBox40, PictureBox41, PictureBox42, PictureBox43, PictureBox44, PictureBox45, PictureBox46, PictureBox47, PictureBox48, PictureBox49, PictureBox50, PictureBox51, PictureBox52, PictureBox53, PictureBox54, PictureBox55, PictureBox56, PictureBox57, PictureBox58, PictureBox59, PictureBox60, PictureBox61, PictureBox62, PictureBox63, PictureBox64}
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


        If (whiteTurn) Then

        Else

        End If
    End Sub

    Sub MyMultipleEventHandler(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click, PictureBox10.Click, PictureBox17.Click, PictureBox18.Click, PictureBox25.Click, PictureBox26.Click, PictureBox2.Click
        Dim thisPic As PictureBox = DirectCast(sender, PictureBox)
        If (numClick.Equals(1)) Then
            Select Case thisPic.Name
                Case "PictureBox9"
                    game.move(1, 0, turn)
                    thisPic.Tag = 0


                Case "PictureBox17"
                    'game.turn(1, 1, turn)
                    thisPic.Tag = 1
                    array = game.getBoard
                    refreshBoard()
                Case "PictureBox10"
                    game.move(1, 1, turn)
                    thisPic.Tag = 0
                Case "PictureBox18"
                    'game.turn(1, 1, turn)
                    thisPic.Tag = 1
                    array = game.getBoard
                    refreshBoard()
            End Select

        End If
        'If (numClick.Equals(2)) Then
        'Select Case thisPic.Name
        '   Case "PictureBox17"
        'PictureBox17.Image = Global.ChessNitro.My.Resources.Resources.bauer
        'PictureBox9.Image = Nothing
        'End Select
        'End If

       


    End Sub

    Private Sub refreshBoard()
        For row = 0 To 7
            For col = 0 To 7

                Select Case array(row, col)






                End Select
                Debug.Write(array(row, col) & " ")

            Next col

        Next row
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
                                    If cntrl.Tag.Equals("2") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.springer
                                    End If
                                Case 3
                                    If cntrl.Tag.Equals("3") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
                                    End If
                                Case 4
                                    If cntrl.Tag.Equals("4") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
                                    End If
                                Case 5
                                    If cntrl.Tag.Equals("5") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenigin
                                    End If
                                Case 6
                                    If cntrl.Tag.Equals("6") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenigin_schwarz
                                    End If
                                Case 7
                                    If cntrl.Tag.Equals("7") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.bauer_schwarz

                                    End If
                                Case 8
                                    If cntrl.Tag.Equals("8") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz

                                    End If
                                Case 9
                                    If cntrl.Tag.Equals("9") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.laeufer
                                    End If
                                Case 10
                                    If cntrl.Tag.Equals("10") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.turm
                                    End If
                                Case 11
                                    If cntrl.Tag.Equals("11") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenigin2_schwarz
                                    End If
                                Case 12
                                    If cntrl.Tag.Equals("12") Then
                                        CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.koenig
                                    End If

                            End Select
                            'CType(cntrl, PictureBox).Image = Global.ChessNitro.My.Resources.Resources.turm
                        End If
                    End If
                End If
            Next
        Next
    End Sub

    Private Sub newGame_Click(sender As Object, e As EventArgs) Handles newGame.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox9.Click
        

        ' Dim number As Integer = array(1, 0)
        '  If (number.Equals(1)) Then
        'firstWhite = True
        '  End If
        ' Dim message As String = Convert.ToString(array(1, 0))
        ' Dim caption As String = "Form Closing"
        ' MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question)
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        Dim number As Integer = array(1, 0)
        If (number.Equals(1)) Then
            firstWhite = True
        End If
        Select Case number
            Case 1

        End Select



        Dim message As String = "Are you sure that you would like to close the form?"
    End Sub

    

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        changeColor()
    End Sub

    Private Sub changeColor()

        If (colorChanged = False) Then
            PictureBox1.Image = Global.ChessNitro.My.Resources.Resources.turm
            PictureBox2.Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz
            PictureBox3.Image = Global.ChessNitro.My.Resources.Resources.laeufer
            PictureBox4.Image = Global.ChessNitro.My.Resources.Resources.koenigin2_schwarz
            PictureBox5.Image = Global.ChessNitro.My.Resources.Resources.koenig
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
            PictureBox60.Image = Global.ChessNitro.My.Resources.Resources.koenigin
            PictureBox61.Image = Global.ChessNitro.My.Resources.Resources.koenigin_schwarz
            PictureBox62.Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
            PictureBox63.Image = Global.ChessNitro.My.Resources.Resources.springer
            PictureBox64.Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
            colorChanged = True
        Else
            PictureBox64.Image = Global.ChessNitro.My.Resources.Resources.turm
            PictureBox63.Image = Global.ChessNitro.My.Resources.Resources.springer_schwarz
            PictureBox62.Image = Global.ChessNitro.My.Resources.Resources.laeufer
            PictureBox61.Image = Global.ChessNitro.My.Resources.Resources.koenigin2_schwarz
            PictureBox60.Image = Global.ChessNitro.My.Resources.Resources.koenig
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
            PictureBox5.Image = Global.ChessNitro.My.Resources.Resources.koenigin
            PictureBox4.Image = Global.ChessNitro.My.Resources.Resources.koenigin_schwarz
            PictureBox3.Image = Global.ChessNitro.My.Resources.Resources.laeufer_weiss
            PictureBox2.Image = Global.ChessNitro.My.Resources.Resources.springer
            PictureBox1.Image = Global.ChessNitro.My.Resources.Resources.turm_weiss
            colorChanged = False
        End If
    End Sub
End Class
