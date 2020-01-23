'Maxwell Long
'RCET0265
'Spring 2020
'SayMyName

Option Explicit On
Option Strict On

Module SayMyName

    Sub Main()

        'putting the userName in string format
        Dim userName As String

        'userName = their name

        'prompts user for name
        Console.WriteLine("Please type your name and press Enter.")

        'console reads the users response
        userName = Console.ReadLine()

        'console greets user with name
        Console.WriteLine("Hello, " & userName & "! Welcome to our programming class.")

        'giving the user time to read console message
        Console.ReadLine()

    End Sub

End Module
