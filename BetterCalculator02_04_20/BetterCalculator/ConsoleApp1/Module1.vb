'Maxwell Long
'RCET0265
'02-04-20
'BetterCalculator

Module Module1

    Sub Main()

        Dim myNumber As Integer
        Dim showPattern As String
        Dim doMath As String

        myNumber = 7
        Console.WriteLine("In Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()

        MySub(myNumber)

        doMath(7, 5 "Multiply")
        showPattern(0, 5)
        Console.ReadLine()

    End Sub

    Function MyFunc(myNumber As Integer) As Integer

        'Dim myNumber As Integer
        myNumber -= 3
        Console.WriteLine("In my function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber

    End Function

    Sub doMath(firstNumber As Integer, secondNumber As Integer, operatorChoice As String)
        Dim result As Double

        If operatorChoice = "add" Then
            Console.WriteLine("" & firstNumber & "+" & secondNumber & "=")
            result = firstNumber + secondNumber
        ElseIf operatorChoice = "subtract" Then
            Console.WriteLine("" & firstNumber & "-" & secondNumber & "=")
            result = firstNumber - secondNumber
        ElseIf operatorChoice = "multiply" Then
            Console.WriteLine("" & firstNumber & "*" & secondNumber & "=")
            result = firstNumber * secondNumber
        ElseIf operatorChoice = "divide" Then
            Console.WriteLine("" & firstNumber & "/" & secondNumber & "=")
            result = firstNumber / secondNumber
        End If

        Console.WriteLine(result)
    End Sub

    Sub showPattern(length As Integer)

        Dim character As String
        Dim pattern As String

        character = "*"
        For index = 0 To length
            pattern &= character
            Console.WriteLine(pattern)
        Next


    End Sub

End Module
