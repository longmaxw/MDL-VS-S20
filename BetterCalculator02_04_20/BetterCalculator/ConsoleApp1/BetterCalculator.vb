'Maxwell Long
'RCET0265
'02-04-20
'BetterCalculator

Option Explicit On
Option Strict On
Option Compare On

Module BetterCalculator

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userChoice As String
        Dim quitProgram As Boolean
        Dim promptUser As Boolean

        promptUser = True
        quitProgram = False

        Do While quitProgram = Fale
            'prompt user for two numbers

            Console.WriteLine("Please enter a number..")
            Do While promptUser = True
                Try
                    firstNumber = CInt(Console.ReadLine())
                    promptUser = False
                Catch ex As Exception
                    Console.WriteLine("Please enter a whole number")
                    promptUser = True
                End Try
            Loop

            Console.WriteLine("Please enter a second number..")
            Try
                secondNumber = CInt(Console.ReadLine())
            Catch ex As Exception
                Console.WriteLine("Please enter a whole number")
            End Try

            'prompt user for sum or product choice

            'perform proper operation
            Console.WriteLine("Please Choose an Option")
            Console.WriteLine("1. Add")
            Console.WriteLine("2. Multiply")
            userChoice = Console.ReadLine()

            'detirmine user's choice
            If userChoice = "1" Then
                'try
                Console.WriteLine(firstNumber + secondNumber)
                Console.WriteLine(firstNumber + secondNumber)
                'Catch ex As InvalidCastException
                '    Console.WriteLine("Please enter a whole number")
                'Catch ex As Exception
                '    Console.WriteLine("You broke it")
                'End Try
            End If
        Loop

        '  Console.WriteLine("In Sub Main")
        '  Console.WriteLine(myNumber)
        '  Console.ReadLine()

        ' MySub(myNumber)

        'doMath(7, 5 "Multiply")
        For i = 1 To 100 Step 1.5
            showPattern(i, "+")
        Next
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

    Sub showPattern(length As Integer, character As String)

        'Dim character As String
        Dim pattern As String

        Console.WriteLine(Len(character))

        'character = "*"
        pattern = ""

        For index = 0 To length Step 1
            pattern &= character
            Console.WriteLine(pattern)
        Next

        For index = length - 1 To 1 Step -1
            pattern = Left(pattern, index * Len(character))
            Console.WriteLine(pattern)
        Next


    End Sub

    Sub playSound()

        Console.Beep(144, 600) 'd
        Console.Beep(182, 400) 'f
        Console.Beep(144, 200) 'd
        Console.Beep(144, 100) 'd
        Console.Beep(192, 200) 'g
        Console.Beep(144, 200) 'd
        Console.Beep(128, 200) 'c
        Console.Beep(144, 600) 'd
        Console.Beep(216, 400) 'a
        Console.Beep(144, 200) 'd
        Console.Beep(144, 200) 'd

        Console.Beep(392, 250) 'd
        Console.Beep(392, 250) 'd
        Console.Beep(392, 250) 'd
        Console.Beep(392, 250) 'd

    End Sub

End Module
