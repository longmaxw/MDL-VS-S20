Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()

        Dim userName As String

        'userMessage = their name

        Console.WriteLine("Please type your name and press Enter.")
        userName = Console.ReadLine()
        Console.WriteLine("Hello, " & userName & "! Welcome to our programming class.")
        Console.ReadLine()

    End Sub

End Module
