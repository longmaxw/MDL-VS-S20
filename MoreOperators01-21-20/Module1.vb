Option Explicit On
Option Strict On

Module MoreOperators

    Sub Main()
        'prompt user for a message
        'then display the message
        Dim userMessage As String

        'userMessage = "Yo"

        Console.WriteLine("Enter a message. Press enter when done.")
        userMessage = Console.ReadLine()
        Console.WriteLine("You entered " & userMessage & " Nailed It!")
        Console.ReadLine()

    End Sub

End Module
