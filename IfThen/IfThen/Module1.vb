Module Module1

    Sub Main()

        Dim firstNumber As Integer
        Dim secondNumber As Integer

        firstNumber = 5
        secondNumber = 3

        If firstNumber > secondNumber Then
            Console.WriteLine("" & firstNumber & " is greater than " & secondNumber & ".")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("" & firstNumber & " is less than " & secondNumber & ".")
        ElseIf firstNumber = secondNumber Then
            Console.WriteLine("" & firstNumber & " is equal to " & secondNumber & ".")
        End If


        If firstNumber <= secondNumber Then
            Console.WriteLine("" & firstNumber & " is less or equal to than " & secondNumber & ".")
        ElseIf firstNumber >= secondNumber Then
            Console.WriteLine("" & firstNumber & " is greater than or equal to " & secondNumber & ".")
        ElseIf firstNumber <> secondNumber Then
            Console.WriteLine("" & firstNumber & " is not equal to " & secondNumber & ".")
        Else
            Console.WriteLine("Some other thing???")
        End If
        Console.ReadLine()

    End Sub

End Module
