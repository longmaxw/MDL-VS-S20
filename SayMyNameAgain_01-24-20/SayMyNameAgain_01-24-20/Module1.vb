'Maxwell Long
'RCET0265
'Spring 2020
'SayMyNameAgain

Option Explicit On
Option Strict On
Option Compare Text

Module Module1

    Sub Main()

        Dim userName As String

        Console.WriteLine("Please enter your name. Then press enter.")
        userName = Console.ReadLine()

        If userName = "Emily" Then
            Console.WriteLine("Welcome Emily!")
        ElseIf userName = "Joe" Then
            Console.WriteLine("Welcome Joe!")
        ElseIf userName = "Maxwell" Then
            Console.WriteLine("What's up dude.")
        Else
            Console.WriteLine("The name " & userName & " was not recognized. Access denied.")
        End If
        Console.ReadLine()
    End Sub

End Module
