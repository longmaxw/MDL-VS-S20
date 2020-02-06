Module Module1

    Sub Main()
        'Dim value As Integer
        'Dim userNumber As 

        'userNumber = Console.ReadLine()
        'value = userNumber
        'value.ToString("C")

        'Console.WriteLine("You chose the following number")
        'Console.WriteLine(value)
        'Console.WriteLine("This value in US currency is:")
        'Console.WriteLine(value.ToString("C"))
        'Console.WriteLine("This value in hexadecimal is:")
        'Console.WriteLine(value.ToString("X"))
        'Console.ReadLine()
        TimesTable()

        TooManySpaces()

    End Sub

    Sub TooManySpaces()
        'Dim message As String
        'message = "     Hello     "
        'Console.WriteLine(Len(message))
        'message = Trim(message)
        'Console.WriteLine(Len(message))
        'Console.ReadLine()


    End Sub

    Sub TimesTable()
        Dim result As Integer

        For i = 1 To 10
            For j = 1 To 10
                result = i * j
                Console.Write(result.ToString("C").PadLeft(9) & "  |")

            Next
            Console.WriteLine()
            Console.WriteLine()

        Next
        Console.ReadLine()
    End Sub

End Module
