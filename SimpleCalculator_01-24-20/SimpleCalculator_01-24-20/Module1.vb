'Maxwell Long
'RCET0265
'01-24-20
'SimpleCalculator

Module Module1

    Sub Main()

        Dim firstNumber As String
        Dim secondNumber As String
        Dim productSum As String

        'greet user and prompt for first number
        Console.WriteLine("Welcome to the simple calculator. Please enter the first number and press enter.")
        firstNumber = Console.ReadLine()

        'prompt user for second number
        Console.WriteLine("Enter a second number and press enter.")
        secondNumber = Console.ReadLine()

        'ask user to decide calculator function
        Console.WriteLine("Would you like the product or the sum? Please type one option or the other. Press enter.")
        productSum = Console.ReadLine()

        'if user types "sum" the console uses addition
        If productSum = "sum" Then
            Console.WriteLine("expression " & firstNumber & "+" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) + CInt(secondNumber))

            'if user types "product the console uses multiplication
        ElseIf productSum = "product" Then
            Console.WriteLine("expression " & firstNumber & "*" & secondNumber & "=")
            Console.WriteLine(CInt(firstNumber) * CInt(secondNumber))

            'display results
        Else
            Console.WriteLine("Invalid entry. Please use numbers only.")
            Console.ReadLine()

        End If

        'prompt user to finish and close window
        Console.WriteLine("Press enter to finish. Thank you for using the Simple Calculator.")
        Console.ReadLine()
    End Sub

End Module
