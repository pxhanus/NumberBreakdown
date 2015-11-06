'Patricia Hanus
'151106
'Number Breakdown
'______________________________________________________________________________
Public Class Form1

    Private Sub btnBreakdown_Click(sender As Object, e As EventArgs) Handles btnBreakdown.Click
        Dim numberEntered As Integer
        Dim onesDigit As Integer
        Dim tensDigit As Integer
        Dim hundredsDigit As Integer

        numberEntered = Val(Me.txtNumber.Text)
        If numberEntered < 10 Then
            Me.lblDigits.Text = "The first digit is: " & numberEntered
        ElseIf numberEntered < 100 Then
            Call TwoDigits(numberEntered, tensDigit, onesDigit)
            Me.lblDigits.Text = "The first digit is: " & tensDigit & vbCrLf & _
                "The second digit is: " & onesDigit
        ElseIf numberEntered < 1000 Then
            Call ThreeDigits(numberEntered, hundredsDigit, tensDigit, onesDigit)
            Me.lblDigits.Text = "The first digit is: " & hundredsDigit & vbCrLf & _
                "The second digit is: " & tensDigit & vbCrLf & _
                "The third digit is: " & onesDigit
        Else
            Me.lblDigits.Text = "Invalid entry."
        End If
    End Sub
    '**************************************************************************
    'The digits of a two-digit number are returned in separate parameters.
    '
    'pre:   num is a number less than 100 and greater than -100.
    'post:  firstDigit stores a number between 0 and 9 inclusive.
    'secondDigit stores a number between 0 and 9 inclusive.
    '**************************************************************************
    Sub TwoDigits(ByVal num As Integer, ByRef firstDigit As Integer, ByRef secondDigit As Integer)
        firstDigit = num \ 10
        secondDigit = num Mod 10
    End Sub
    '**************************************************************************
    'The digits of a three-digit number are returned in separate parameters.
    '
    'pre:   num is a number less than 1000 and greater than -1000.
    'post:  firstDigit stores a number between 0 and 9 inclusive.
    '       secondDigit stores a number between 0 and 9 inclusive.
    '       thirdDigit stores a number between 0 and 9 inclusive.
    '**************************************************************************
    Sub ThreeDigits(ByVal num As Integer, ByRef firstDigit As Integer, _
    ByRef secondDigit As Integer, ByRef thirdDigit As Integer)
        firstDigit = num \ 100
        num = num Mod 100
        Call TwoDigits(num, secondDigit, thirdDigit)
    End Sub

    Private Sub txtNumber_TextChanged(sender As Object, e As EventArgs) Handles txtNumber.TextChanged
        Me.lblDigits.Text = Nothing
    End Sub
End Class
