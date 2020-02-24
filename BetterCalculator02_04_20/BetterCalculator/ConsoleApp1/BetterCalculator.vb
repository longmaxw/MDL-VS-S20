'Maxwell Long
'RCET0265
'02-04-20
'BetterCalculator

Option Explicit On
Option Strict On
Option Compare Text

Module BetterCalculator

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer
        Dim userChoice As String
        Dim quitProgram As Boolean
        Dim promptUser As Boolean

        promptUser = True
        quitProgram = False

        Do While quitProgram = False
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
                Try
                    Console.WriteLine(firstNumber + secondNumber)
                    Console.WriteLine(firstNumber + secondNumber)
                Catch ex As InvalidCastException
                    Console.WriteLine("Please enter a whole number")
                Catch ex As Exception
                    Console.WriteLine("You broke it")
                End Try
            End If
        Loop

        '  Console.WriteLine("In Sub Main")
        '  Console.WriteLine(myNumber)
        '  Console.ReadLine()

        ' MySub(myNumber)

        'doMath(7, 5 "Multiply")
        Console.ReadLine()

    End Sub



End Module
