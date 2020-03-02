Module Module1

    Sub Main()
        Randomize(System.DateTime.Now.Millisecond)
        Console.WriteLine(Timer)
        Dim aRandomInteger As Integer
        Randomize()
        For i = 1 To 10
            aRandomInteger = CInt()
        Next
        'For j = 1 To 2
        '    For i = 1 To 10
        '        Console.WriteLine(Str(Rnd()) & "        " & Str(System.DateTime.now.Milliseconds))
        '    Next
        '    Console.WriteLine()
        'Next
        'Console.WriteLine()

    End Sub
    Function GetRandomIntegerOneToTen(maximum As Integer, minimum As Integer) As Integer
        Dim tempInteger As Integer
        Randomize()
        For i = 1 To 10
            aRandomInteger = CInt((6 * Rnd())
        Next

        Return 0
    End Function
End Module