Public Class FRMCalculator

    'Project: Visual Basics - Test 1 On New Laptop
    'Programmer: Justin Kocur
    'Date: 18 April 2020
    'Purpose: To re-familiarize myself with VS and VB Code

    'You can only type in numbers in the text box (where the answer is displayed).
    'If you want a negative number, operation sign, etc., use the buttons on the calculator.
    'Negative sign will show up after you enter in a number.
    'Some code may be (and probably is) repetitive

    'You may encounter some bugs in this program

    Dim currentNumber As String = "" 'the current typed in number
    Dim operationSign As Integer = 0 '1 is Remainder; 2 is Add; 3 is Subtract, 4 is Multiply, 5 is Divide
    Dim answer As Decimal = 0 'what the user sees
    Dim parts As Integer = 0 'parts are separated by an operation sign
    Dim numOfDecimals As Integer = 0 'only one decimal point allowed per number
    Dim countNegativeSigns As Integer = 0 'only one negative allowed
    Dim oneSign As Boolean = True 'this maks sure that only one operation sign is used at a time
    Dim buttonClicked As Boolean = False 'makes it so that the computer doesn't mistake
    'the text in TXTOutput from a button press with the user typing in the textbox

    Private Sub BTNNum0_Click(sender As Object, e As EventArgs) Handles BTNNum0.Click
        'controls the back color
        BTNNum0.BackColor = Color.CadetBlue 'this one
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False 'hides message that tells user no number was inputted
        oneSign = True
        buttonClicked = True

        currentNumber += "0"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum1_Click(sender As Object, e As EventArgs) Handles BTNNum1.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.CadetBlue 'this one
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "1"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum2_Click(sender As Object, e As EventArgs) Handles BTNNum2.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.CadetBlue 'this one
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "2"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum3_Click(sender As Object, e As EventArgs) Handles BTNNum3.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.CadetBlue 'this one
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "3"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum4_Click(sender As Object, e As EventArgs) Handles BTNNum4.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.CadetBlue 'this one
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "4"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum5_Click(sender As Object, e As EventArgs) Handles BTNNum5.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.CadetBlue 'this one
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "5"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum6_Click(sender As Object, e As EventArgs) Handles BTNNum6.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.CadetBlue 'this one
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "6"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum7_Click(sender As Object, e As EventArgs) Handles BTNNum7.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.CadetBlue 'this one
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "7"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum8_Click(sender As Object, e As EventArgs) Handles BTNNum8.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.CadetBlue 'this one
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "8"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNNum9_Click(sender As Object, e As EventArgs) Handles BTNNum9.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.CadetBlue 'this one

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False
        oneSign = True
        buttonClicked = True

        currentNumber += "9"
        TXTOutput.Text = currentNumber
        countNegativeSigns = 0

        BTNClear.Text = "CE"
    End Sub

    Private Sub BTNRemainder_Click(sender As Object, e As EventArgs) Handles BTNRemainder.Click

        If oneSign Then
            oneSign = False


            If (currentNumber = "") Then
                LBLInputMsg.Visible = True
            Else
                'controls the back color
                BTNNum0.BackColor = Color.LightCyan
                BTNNum1.BackColor = Color.LightCyan
                BTNNum2.BackColor = Color.LightCyan
                BTNNum3.BackColor = Color.LightCyan
                BTNNum4.BackColor = Color.LightCyan
                BTNNum5.BackColor = Color.LightCyan
                BTNNum6.BackColor = Color.LightCyan
                BTNNum7.BackColor = Color.LightCyan
                BTNNum8.BackColor = Color.LightCyan
                BTNNum9.BackColor = Color.LightCyan

                BTNDecimal.BackColor = Color.LightSteelBlue
                BTNEqual.BackColor = Color.LightSteelBlue

                BTNClear.BackColor = Color.SlateGray
                BTNRemainder.BackColor = Color.FromArgb(64, 64, 64) 'this one
                BTNAddition.BackColor = Color.SlateGray
                BTNSubtraction.BackColor = Color.SlateGray
                BTNMultiplication.BackColor = Color.SlateGray
                BTNDivision.BackColor = Color.SlateGray


                If parts > 0 Then 'must have at least two numbers to perform an operation
                    If (operationSign = 1) Then
                        answer = answer Mod Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 2) Then
                        answer += Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 3) Then
                        answer -= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 4) Then
                        answer *= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 5) Then
                        answer /= Convert.ToDecimal(currentNumber)
                    End If
                Else
                    answer = Convert.ToDecimal(currentNumber)
                End If

                numOfDecimals = 0
                parts += 1
                currentNumber = ""
                operationSign = 1

                TXTOutput.Text = answer.ToString()

            End If


            If buttonClicked = False Then 'this is for if the user types in a number
                If Convert.ToDecimal(TXTOutput.Text) > 0 Then

                    LBLInputMsg.Visible = False

                    If parts > 0 Then
                        If (operationSign = 1) Then
                            answer = answer Mod Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 2) Then
                            answer += Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 3) Then
                            answer -= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 4) Then
                            answer *= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 5) Then
                            answer /= Convert.ToDecimal(TXTOutput.Text)
                        End If
                    Else
                        answer = Convert.ToDecimal(TXTOutput.Text)
                    End If

                    numOfDecimals = 0
                    parts += 1
                    operationSign = 1

                    BTNClear.Text = "CE"

                    TXTOutput.Text = answer.ToString()
                End If
            End If
        End If

        buttonClicked = False
    End Sub

    Private Sub BTNAddition_Click(sender As Object, e As EventArgs) Handles BTNAddition.Click

        Console.WriteLine("Before Add: " + currentNumber)

        If oneSign Then
            oneSign = False

            If (currentNumber = "") Then 'if the user just types
                LBLInputMsg.Visible = True
            Else
                'controls the back color
                BTNNum0.BackColor = Color.LightCyan
                BTNNum1.BackColor = Color.LightCyan
                BTNNum2.BackColor = Color.LightCyan
                BTNNum3.BackColor = Color.LightCyan
                BTNNum4.BackColor = Color.LightCyan
                BTNNum5.BackColor = Color.LightCyan
                BTNNum6.BackColor = Color.LightCyan
                BTNNum7.BackColor = Color.LightCyan
                BTNNum8.BackColor = Color.LightCyan
                BTNNum9.BackColor = Color.LightCyan

                BTNDecimal.BackColor = Color.LightSteelBlue
                BTNEqual.BackColor = Color.LightSteelBlue

                BTNClear.BackColor = Color.SlateGray
                BTNRemainder.BackColor = Color.SlateGray
                BTNAddition.BackColor = Color.FromArgb(64, 64, 64) 'this one
                BTNSubtraction.BackColor = Color.SlateGray
                BTNMultiplication.BackColor = Color.SlateGray
                BTNDivision.BackColor = Color.SlateGray


                If parts > 0 Then
                    If (operationSign = 1) Then
                        answer = answer Mod Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 2) Then
                        answer += Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 3) Then
                        answer -= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 4) Then
                        answer *= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 5) Then
                        answer /= Convert.ToDecimal(currentNumber)
                    End If
                Else
                    answer = Convert.ToDecimal(currentNumber)
                End If

                numOfDecimals = 0
                parts += 1
                currentNumber = ""
                operationSign = 2

                TXTOutput.Text = answer.ToString()


            End If



            If buttonClicked = False Then
                If Convert.ToDecimal(TXTOutput.Text) > 0 Then

                    LBLInputMsg.Visible = False

                    If parts > 0 Then
                        If (operationSign = 1) Then
                            answer = answer Mod Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 2) Then
                            answer += Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 3) Then
                            answer -= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 4) Then
                            answer *= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 5) Then
                            answer /= Convert.ToDecimal(TXTOutput.Text)
                        End If
                    Else
                        answer = Convert.ToDecimal(TXTOutput.Text)
                    End If

                    numOfDecimals = 0
                    parts += 1
                    operationSign = 2

                    BTNClear.Text = "CE"

                    TXTOutput.Text = answer.ToString()
                End If
            End If
        End If

        buttonClicked = False
        Console.WriteLine("After Add: " + currentNumber)
    End Sub

    Private Sub BTNSubtraction_Click(sender As Object, e As EventArgs) Handles BTNSubtraction.Click

        If oneSign Then
            oneSign = False

            'this also works with negative numbers

            If (currentNumber = "") Then 'if the user just types
                If countNegativeSigns = 0 Then
                    currentNumber += "-"
                    countNegativeSigns += 1
                End If
            Else
                If countNegativeSigns < 1 Then
                    'controls the back color
                    BTNNum0.BackColor = Color.LightCyan
                    BTNNum1.BackColor = Color.LightCyan
                    BTNNum2.BackColor = Color.LightCyan
                    BTNNum3.BackColor = Color.LightCyan
                    BTNNum4.BackColor = Color.LightCyan
                    BTNNum5.BackColor = Color.LightCyan
                    BTNNum6.BackColor = Color.LightCyan
                    BTNNum7.BackColor = Color.LightCyan
                    BTNNum8.BackColor = Color.LightCyan
                    BTNNum9.BackColor = Color.LightCyan

                    BTNDecimal.BackColor = Color.LightSteelBlue
                    BTNEqual.BackColor = Color.LightSteelBlue

                    BTNClear.BackColor = Color.SlateGray
                    BTNRemainder.BackColor = Color.SlateGray
                    BTNAddition.BackColor = Color.SlateGray
                    BTNSubtraction.BackColor = Color.FromArgb(64, 64, 64) 'this one
                    BTNMultiplication.BackColor = Color.SlateGray
                    BTNDivision.BackColor = Color.SlateGray


                    If parts > 0 Then
                        If (operationSign = 1) Then
                            answer = answer Mod Convert.ToDecimal(currentNumber)
                        ElseIf (operationSign = 2) Then
                            answer += Convert.ToDecimal(currentNumber)
                        ElseIf (operationSign = 3) Then
                            answer -= Convert.ToDecimal(currentNumber)
                        ElseIf (operationSign = 4) Then
                            answer *= Convert.ToDecimal(currentNumber)
                        ElseIf (operationSign = 5) Then
                            answer /= Convert.ToDecimal(currentNumber)
                        End If
                    Else
                        answer = Convert.ToDecimal(currentNumber)
                    End If

                    numOfDecimals = 0
                    parts += 1
                    currentNumber = ""
                    operationSign = 3

                    TXTOutput.Text = answer.ToString()
                End If
            End If



            If buttonClicked = False Then
                If Convert.ToDecimal(TXTOutput.Text) > 0 Then

                    LBLInputMsg.Visible = False

                    If parts > 0 Then
                        If (operationSign = 1) Then
                            answer = answer Mod Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 2) Then
                            answer += Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 3) Then
                            answer -= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 4) Then
                            answer *= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 5) Then
                            answer /= Convert.ToDecimal(TXTOutput.Text)
                        End If
                    Else
                        answer = Convert.ToDecimal(TXTOutput.Text)
                    End If

                    numOfDecimals = 0
                    parts += 1
                    operationSign = 3

                    BTNClear.Text = "CE"

                    TXTOutput.Text = answer.ToString()
                End If
            End If
        End If

        buttonClicked = False
    End Sub

    Private Sub BTNMultiplication_Click(sender As Object, e As EventArgs) Handles BTNMultiplication.Click

        If oneSign Then
            oneSign = False

            If (currentNumber = "") Then 'if the user just types
                LBLInputMsg.Visible = True
            Else
                'controls the back color
                BTNNum0.BackColor = Color.LightCyan
                BTNNum1.BackColor = Color.LightCyan
                BTNNum2.BackColor = Color.LightCyan
                BTNNum3.BackColor = Color.LightCyan
                BTNNum4.BackColor = Color.LightCyan
                BTNNum5.BackColor = Color.LightCyan
                BTNNum6.BackColor = Color.LightCyan
                BTNNum7.BackColor = Color.LightCyan
                BTNNum8.BackColor = Color.LightCyan
                BTNNum9.BackColor = Color.LightCyan

                BTNDecimal.BackColor = Color.LightSteelBlue
                BTNEqual.BackColor = Color.LightSteelBlue

                BTNClear.BackColor = Color.SlateGray
                BTNRemainder.BackColor = Color.SlateGray
                BTNAddition.BackColor = Color.SlateGray
                BTNSubtraction.BackColor = Color.SlateGray
                BTNMultiplication.BackColor = Color.FromArgb(64, 64, 64) 'this one
                BTNDivision.BackColor = Color.SlateGray


                If parts > 0 Then
                    If (operationSign = 1) Then
                        answer = answer Mod Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 2) Then
                        answer += Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 3) Then
                        answer -= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 4) Then
                        answer *= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 5) Then
                        answer /= Convert.ToDecimal(currentNumber)
                    End If
                Else
                    answer = Convert.ToDecimal(currentNumber)
                End If

                numOfDecimals = 0
                parts += 1
                currentNumber = ""
                operationSign = 4

                TXTOutput.Text = answer.ToString()

            End If




            If buttonClicked = False Then
                If Convert.ToDecimal(TXTOutput.Text) > 0 Then

                    LBLInputMsg.Visible = False

                    If parts > 0 Then
                        If (operationSign = 1) Then
                            answer = answer Mod Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 2) Then
                            answer += Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 3) Then
                            answer -= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 4) Then
                            answer *= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 5) Then
                            answer /= Convert.ToDecimal(TXTOutput.Text)
                        End If
                    Else
                        answer = Convert.ToDecimal(TXTOutput.Text)
                    End If

                    numOfDecimals = 0
                    parts += 1
                    operationSign = 4

                    BTNClear.Text = "CE"

                    TXTOutput.Text = answer.ToString()
                End If
            End If
        End If

        buttonClicked = False
    End Sub

    Private Sub BTNDivision_Click(sender As Object, e As EventArgs) Handles BTNDivision.Click

        If oneSign Then
            oneSign = False

            If (currentNumber = "") Then 'if the user just types
                LBLInputMsg.Visible = True
            Else
                'controls the back color
                BTNNum0.BackColor = Color.LightCyan
                BTNNum1.BackColor = Color.LightCyan
                BTNNum2.BackColor = Color.LightCyan
                BTNNum3.BackColor = Color.LightCyan
                BTNNum4.BackColor = Color.LightCyan
                BTNNum5.BackColor = Color.LightCyan
                BTNNum6.BackColor = Color.LightCyan
                BTNNum7.BackColor = Color.LightCyan
                BTNNum8.BackColor = Color.LightCyan
                BTNNum9.BackColor = Color.LightCyan

                BTNDecimal.BackColor = Color.LightSteelBlue
                BTNEqual.BackColor = Color.LightSteelBlue

                BTNClear.BackColor = Color.SlateGray
                BTNRemainder.BackColor = Color.SlateGray
                BTNAddition.BackColor = Color.SlateGray
                BTNSubtraction.BackColor = Color.SlateGray
                BTNMultiplication.BackColor = Color.SlateGray
                BTNDivision.BackColor = Color.FromArgb(64, 64, 64) 'this one


                If parts > 0 Then
                    If (operationSign = 1) Then
                        answer = answer Mod Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 2) Then
                        answer += Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 3) Then
                        answer -= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 4) Then
                        answer *= Convert.ToDecimal(currentNumber)
                    ElseIf (operationSign = 5) Then
                        answer /= Convert.ToDecimal(currentNumber)
                    End If
                Else
                    answer = Convert.ToDecimal(currentNumber)
                End If

                numOfDecimals = 0
                parts += 1
                currentNumber = ""
                operationSign = 5

                TXTOutput.Text = answer.ToString()

            End If



            If buttonClicked = False Then
                If Convert.ToDecimal(TXTOutput.Text) > 0 Then

                    LBLInputMsg.Visible = False

                    If parts > 0 Then
                        If (operationSign = 1) Then
                            answer = answer Mod Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 2) Then
                            answer += Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 3) Then
                            answer -= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 4) Then
                            answer *= Convert.ToDecimal(TXTOutput.Text)
                        ElseIf (operationSign = 5) Then
                            answer /= Convert.ToDecimal(TXTOutput.Text)
                        End If
                    Else
                        answer = Convert.ToDecimal(TXTOutput.Text)
                    End If

                    numOfDecimals = 0
                    parts += 1
                    operationSign = 5

                    BTNClear.Text = "CE"

                    TXTOutput.Text = answer.ToString()
                End If
            End If
        End If

        buttonClicked = False
    End Sub

    Private Sub BTNEqual_Click(sender As Object, e As EventArgs) Handles BTNEqual.Click

        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.SteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray


        'deals with the last operation that must be computed
        If buttonClicked Then 'if a button was clicked last
            If (operationSign = 1) Then
                answer = answer Mod Convert.ToDecimal(currentNumber)
            ElseIf (operationSign = 2) Then
                answer += Convert.ToDecimal(currentNumber)
            ElseIf (operationSign = 3) Then
                answer -= Convert.ToDecimal(currentNumber)
            ElseIf (operationSign = 4) Then
                answer *= Convert.ToDecimal(currentNumber)
            ElseIf (operationSign = 5) Then
                answer /= Convert.ToDecimal(currentNumber)
            End If
        Else 'if a number was typed in last
            If (operationSign = 1) Then
                answer = answer Mod Convert.ToDecimal(TXTOutput.Text)
            ElseIf (operationSign = 2) Then
                answer += Convert.ToDecimal(TXTOutput.Text)
            ElseIf (operationSign = 3) Then
                answer -= Convert.ToDecimal(TXTOutput.Text)
            ElseIf (operationSign = 4) Then
                answer *= Convert.ToDecimal(TXTOutput.Text)
            ElseIf (operationSign = 5) Then
                answer /= Convert.ToDecimal(TXTOutput.Text)
            End If
        End If

        TXTOutput.Text = answer.ToString()

        currentNumber = answer.ToString
        parts = 0
        numOfDecimals = 0
        countNegativeSigns = 0
        oneSign = True
        buttonClicked = True

        Console.WriteLine("Equal: " + currentNumber)
    End Sub

    Private Sub BTNClear_Click(sender As Object, e As EventArgs) Handles BTNClear.Click

        'clears everything; starts everything over

        Console.WriteLine("Test: " + TXTOutput.Text)

        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray

        LBLInputMsg.Visible = False

        currentNumber = ""
        operationSign = 0
        answer = 0
        parts = 0
        numOfDecimals = 0
        countNegativeSigns = 0
        TXTOutput.Text = "0"
        oneSign = True
        buttonClicked = False

        BTNClear.Text = "AC"
    End Sub

    Private Sub BTNDecimal_Click(sender As Object, e As EventArgs) Handles BTNDecimal.Click

        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.SteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray


        If numOfDecimals = 0 Then
            currentNumber += "."
            TXTOutput.Text = currentNumber
        End If

        numOfDecimals += 1
    End Sub

    Private Sub TXTOutput_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TXTOutput.KeyPress

        'Courtesy of Isuru from StackOverflow

        '97 - 122 = Ascii codes for simple letters
        '65 - 90  = Ascii codes for capital letters
        '48 - 57  = Ascii codes for numbers

        If Asc(e.KeyChar) <> 8 Then
            If Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57 Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub FRMCalculator_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        'controls the back color
        BTNNum0.BackColor = Color.LightCyan
        BTNNum1.BackColor = Color.LightCyan
        BTNNum2.BackColor = Color.LightCyan
        BTNNum3.BackColor = Color.LightCyan
        BTNNum4.BackColor = Color.LightCyan
        BTNNum5.BackColor = Color.LightCyan
        BTNNum6.BackColor = Color.LightCyan
        BTNNum7.BackColor = Color.LightCyan
        BTNNum8.BackColor = Color.LightCyan
        BTNNum9.BackColor = Color.LightCyan

        BTNDecimal.BackColor = Color.LightSteelBlue
        BTNEqual.BackColor = Color.LightSteelBlue

        BTNClear.BackColor = Color.SlateGray
        BTNRemainder.BackColor = Color.SlateGray
        BTNAddition.BackColor = Color.SlateGray
        BTNSubtraction.BackColor = Color.SlateGray
        BTNMultiplication.BackColor = Color.SlateGray
        BTNDivision.BackColor = Color.SlateGray
    End Sub
End Class