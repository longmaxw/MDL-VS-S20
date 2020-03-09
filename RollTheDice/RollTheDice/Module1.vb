Module Module1



    Private Function getFirstRandomIntegerOneToSix() As Integer

        Dim maxSingle As Single : maxSingle = 5
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        getFirstRandomIntegerOneToSix = Convert.ToInt32(tempSingle) 'return the number

        Console.ReadLine()

    End Function

    Private Function getSecondRandomIntegerOneToSix() As Integer

        Dim maxSingle As Single : maxSingle = 5
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        getSecondRandomIntegerOneToSix = Convert.ToInt32(tempSingle) 'return the number

        Console.WriteLine(getSecondRandomIntegerOneToSix)
        Console.ReadLine()

    End Function
    Sub Main()

        Console.WriteLine(getFirstRandomIntegerOneToSix() + getSecondRandomIntegerOneToSix())
        Console.ReadLine()



    End Sub

End Module
