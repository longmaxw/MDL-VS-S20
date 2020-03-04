Module ArrayExample

    Sub Main()
        Dim myArray(3) As Integer

        myArray(1) = 5

        myArray = {1, 2, 3, 4}

        Console.ReadLine()
    End Sub
    Private Sub InfoArrayExample()
        Dim infoArray() As String

        infoArray = Split("Yo,what up,Crunchwrap,fire sauce", ",")

        For Each thingy In infoArray
            Console.WriteLine(thingy)
            infoArray.Contains(thingy)
        Next

        For i = LBound(infoArray) To UBound(infoArray)
            Console.WriteLine("at" & Str(i) & " Value is: " & infoArray(i))
        Next

        Console.ReadLine()
    End Sub

End Module
