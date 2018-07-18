Public Class Form1
    Dim green As Integer = 1
    Dim red As Integer = 2
    Dim curTurn As Integer
    Dim colGreen As New Color()
    Dim winner As Integer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        colGreen = Color.FromArgb(144, 183, 52)
        Dim r As Random = New Random

        curTurn = r.Next(1, 3)

        If curTurn = green Then
            btnTurn.BackColor = colGreen
        Else
            btnTurn.BackColor = Color.Maroon
        End If
    End Sub

    Private Sub MultipleButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click
        Dim btn As Button = CType(sender, Button)
        Dim win As Boolean

        If curTurn = green Then
            btn.BackColor = colGreen
            curTurn = red
            btnTurn.BackColor = Color.Maroon
            win = CheckWinner()
        Else
            btn.BackColor = Color.Maroon
            curTurn = green
            btnTurn.BackColor = colGreen
            win = CheckWinner()
        End If


        If win Then
            If winner = 1 Then
                MsgBox("Winner is Green!")
                btnNewGame.Visible = True
            Else
                MsgBox("Winner is Red!")
                btnNewGame.Visible = True
            End If
        End If

    End Sub

    Public Function CheckWinner()
        If btn0.BackColor = Color.Maroon And btn1.BackColor = Color.Maroon And btn2.BackColor = Color.Maroon Then
            winner = red
            Return True
        ElseIf btn0.BackColor = Color.Maroon And btn3.BackColor = Color.Maroon And btn6.BackColor = Color.Maroon Then
            winner = red
            Return True
        ElseIf btn0.BackColor = Color.Maroon And btn4.BackColor = Color.Maroon And btn8.BackColor = Color.Maroon Then
            winner = red
            Return True
        ElseIf btn1.BackColor = Color.Maroon And btn4.BackColor = Color.Maroon And btn7.BackColor = Color.Maroon Then
            winner = red
            Return True
        ElseIf btn2.BackColor = Color.Maroon And btn4.BackColor = Color.Maroon And btn6.BackColor = Color.Maroon Then
            winner = red
            Return True
        ElseIf btn2.BackColor = Color.Maroon And btn5.BackColor = Color.Maroon And btn8.BackColor = Color.Maroon Then
            winner = red
            Return True
        ElseIf btn6.BackColor = Color.Maroon And btn7.BackColor = Color.Maroon And btn8.BackColor = Color.Maroon Then
            winner = red
            Return True
        ElseIf btn0.BackColor = colGreen And btn1.BackColor = colGreen And btn2.BackColor = colGreen Then
            winner = green
            Return True
        ElseIf btn0.BackColor = colGreen And btn3.BackColor = colGreen And btn6.BackColor = colGreen Then
            winner = green
            Return True
        ElseIf btn0.BackColor = colGreen And btn4.BackColor = colGreen And btn8.BackColor = colGreen Then
            winner = green
            Return True
        ElseIf btn1.BackColor = colGreen And btn4.BackColor = colGreen And btn7.BackColor = colGreen Then
            winner = green
            Return True
        ElseIf btn2.BackColor = colGreen And btn4.BackColor = colGreen And btn6.BackColor = colGreen Then
            winner = green
            Return True
        ElseIf btn2.BackColor = colGreen And btn5.BackColor = colGreen And btn8.BackColor = colGreen Then
            winner = green
            Return True
        ElseIf btn6.BackColor = colGreen And btn7.BackColor = colGreen And btn8.BackColor = colGreen Then
            winner = green
            Return True
        End If

        Return False
    End Function

    Private Sub btnNewGame_Click(sender As Object, e As EventArgs) Handles btnNewGame.Click
        Application.Restart()
    End Sub
End Class
