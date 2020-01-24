'Maxwell Long
'RCET0265
'01-24-20
'SimpleCalculator

Module Module1

    Sub Main()

        Dim firstNumber As String
        Dim secondNumber As String

        Console.WriteLine("Welcome to the simple calculator. Please enter the first number, press enter then the second number.")

        firstNumber = Console.ReadLine
        secondNumber = Console.ReadLine

        Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))

        Console.ReadLine()

    End Sub

End Module
