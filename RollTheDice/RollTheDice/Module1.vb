Module Module1


    Dim DiceSum As Single

    Private Function DiceOne() As Integer

        Dim maxSingle As Single : maxSingle = 5
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        DiceOne = Convert.ToInt32(tempSingle) 'return the number

        Console.WriteLine("Dice One =")
        Console.WriteLine(DiceOne)
        Console.ReadLine()

    End Function

    Private Function DiceTwo() As Integer

        Dim maxSingle As Single : maxSingle = 5
        Dim minSingle As Single : minSingle = 1
        Dim tempSingle As Single
        Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
        tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
        DiceTwo = Convert.ToInt32(tempSingle) 'return the number


        Console.WriteLine("Dice Two =")
        Console.WriteLine(DiceTwo)
        Console.ReadLine()

    End Function
    Private Function DiceTotal() As Integer

        DiceSum = DiceOne() + DiceTwo()
        Console.WriteLine("Dice One + Dice Two = " & DiceSum)
        Console.ReadLine()

    End Function
    Sub Main()

        Console.WriteLine(DiceTotal)

        Dim Matrix(11,1) as Double

    End Sub

End Module
