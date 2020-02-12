' Last Modified By:   
' Last Modified Date: February 11, 2020
'
' Author: Kyle Chapman
' Date: February 9, 2020
' Description:
'   It's a tic-tac-toe game! Is that supposed to be hypenated?
'   There are 9 buttons in a 2D array. When clicked, they are assigned
'   a letter based on whoever's turn it is and disabled.

Public Class frmTicTacToe

    ' This boolean value shows whether it's X's turn; otherwise it's O's turn
    Dim isTurnX As Boolean = True
    ' This boolean value represents the win condition
    Dim isWinner As Boolean = False
    ' Here's an array of buttons, representing squares on the board
    Dim squares As Button(,)

#Region "Event Handlers"

    ''' <summary>
    ''' On form load, assign the Buttons to the array
    ''' </summary>
    Private Sub frmTicTacToe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        squares = {
    {btnRow0Column0, btnRow0Column1, btnRow0Column2},
    {btnRow1Column0, btnRow1Column1, btnRow1Column2},
    {btnRow2Column0, btnRow2Column1, btnRow2Column2}}
    End Sub

    ''' <summary>
    ''' When a button is clicked, assign it a letter, disable the button, and if there was no winner change the turn
    ''' </summary>
    Private Sub TicTacToeSquareClick(btnSender As Button, e As EventArgs) Handles btnRow0Column0.Click, btnRow0Column1.Click, btnRow0Column2.Click, btnRow1Column0.Click, btnRow1Column1.Click, btnRow1Column2.Click, btnRow2Column0.Click, btnRow2Column1.Click, btnRow2Column2.Click

        ' Set the text on the Button
        If isTurnX Then
            btnSender.Text = "X"
        Else
            btnSender.Text = "O"
        End If

        ' Disable the button
        btnSender.Enabled = False

        ' Evaluate win
        EvaluateWin()

        ' Don't swap turns if somebody has won!
        If Not isWinner Then
            ' Swap turns
            ChangeTurn()
        End If

        ' Put focus on the Reset button
        btnReset.Focus()

    End Sub

    ''' <summary>
    ''' The Reset button clears things and re-enables controls
    ''' </summary>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        SetDefaults()

    End Sub

#End Region

#Region "Procedures"

    ''' <summary>
    ''' This clears the text property of all controls in the array of controls that is passed in
    ''' </summary>
    ''' <param name="controlArray">An array of controls with a text property to clear</param>
    Sub ClearControls(controlArray As Control(,))

        ' For every control in the list that is passed in, empty its Text property
        For Each controlToClear As Control In controlArray
            controlToClear.Text = String.Empty
        Next

    End Sub

    ''' <summary>
    ''' This enables or disables all controls in the array that is passed in
    ''' </summary>
    ''' <param name="controlArray">An array of controls to enable or disable</param>
    ''' <param name="enabledStatus">Boolean: set controls to enabled?</param>
    Sub SetControlsEnabled(controlArray As Control(,), enabledStatus As Boolean)

        ' For every textbox in the list that is passed in, set its Enabled property
        For Each controlToSet As Button In controlArray
            controlToSet.Enabled = enabledStatus
        Next

    End Sub

    ''' <summary>
    ''' Clears things and re-enables controls
    ''' </summary>
    Sub SetDefaults()

        ' Clear all buttons
        ClearControls(squares)
        ' Re-enable any controls that may be disabled
        SetControlsEnabled(squares, True)
        ' Ensure there's no winner
        isWinner = False
        ' ChangeTurn resets the status label and gives the loser the first turn
        ChangeTurn()

    End Sub

    ''' <summary>
    ''' If it's currently X's turn, change it to O's turn, and vice-versa
    ''' </summary>
    Sub ChangeTurn()

        isTurnX = Not isTurnX

        If isTurnX Then
            lblGameStatus.Text = "X's Turn"
        Else
            lblGameStatus.Text = "O's Turn"
        End If

    End Sub

    ''' <summary>
    ''' Determine if the current player has won
    ''' </summary>
    Sub EvaluateWin()

        ' **************************************
        ' This is the part where you code stuff!
        ' **************************************

        ' First, check all rows.
        ' Use a For loop to check if all boxes in the same dimension
        ' have the same value - doesn't even matter what the value is
        ' as long as it's the same!
        For rowCount As Integer = 0 To squares.GetUpperBound(0)
            ' What does "GetUpperBound(0)" mean above?

            ' Something to do with squares(rowCount,0), squares(rowCount,1), etc.
        Next

        ' Next, check all columns.

        ' Finally, we have to check the two diagonals.
        ' It is not going to save us any work to use loops
        ' so let's just do it like this:
        If squares(0, 0).Text <> String.Empty And
            squares(0, 0).Text = squares(1, 1).Text And
            squares(0, 0).Text = squares(2, 2).Text Then
            isWinner = True
        ElseIf squares(0, 2).Text <> String.Empty And
            squares(0, 2).Text = squares(1, 1).Text And
            squares(0, 2).Text = squares(2, 0).Text Then
            isWinner = True
        End If

        ' *************************************************
        ' Here are some notes about extra stuff you can try
        ' *************************************************

        ' You don't have to do any of these things but here are several added value features:

        ' 1) If you want to get a little bit fancy...
        ' Make the winning line show up in a different colour!

        ' 2) If you want to get even fancier...
        ' Make this generate a message when the game is a draw/tie game! (cat game?)

        ' 3) If you want to get *super* fancy...
        ' How might you code this so it would work for boards of an arbitrary and bigger (e.g. 4x4) size?

        ' 4) If you like efficiency...
        ' How could you do everything in this Sub Procedure (other than colors) with a single loop?

        ' 5) Another fanciness option for people who love clean code...
        ' This file currently doesn't have Option Strict On, and turning it on will cause some issues.
        ' Can you determine how to turn Option Strict On and still have it work?

        ' 6) Holy crap you must want to make your life difficult for yourself if you pick this option:
        ' Can you make it so that you can use arrow keys to move between the different squares in a natural way?

        ' *********************************************
        ' This is the part where you stop coding stuff!
        ' *********************************************

        ' If there's a winner, show who it is!
        If isWinner Then
            If isTurnX Then
                lblGameStatus.Text = "X wins!"
            Else
                lblGameStatus.Text = "O wins!"
            End If

            ' Disable all squares to prevent further play
            SetControlsEnabled(squares, False)
        End If

    End Sub

#End Region

End Class
