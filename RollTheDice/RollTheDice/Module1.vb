Module Module1


    'Dim DiceSum As Single

    'Private Function DiceOne() As Integer

    '    Dim maxSingle As Single : maxSingle = 5
    '    Dim minSingle As Single : minSingle = 1
    '    Dim tempSingle As Single
    '    Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
    '    tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
    '    DiceOne = Convert.ToInt32(tempSingle) 'return the number

    '    'Console.WriteLine("Dice One =")
    '    Console.WriteLine(DiceOne)
    '    Console.ReadLine()

    'End Function

    'Private Function DiceTwo() As Integer

    '    Dim maxSingle As Single : maxSingle = 5
    '    Dim minSingle As Single : minSingle = 1
    '    Dim tempSingle As Single
    '    Randomize(System.DateTime.Now.Millisecond) 'set seed to current system millisecond
    '    tempSingle = ((maxSingle - minSingle + 1) * Rnd() + minSingle) 'actually get the random number in the range
    '    DiceTwo = Convert.ToInt32(tempSingle) 'return the number


    '    'Console.WriteLine("Dice Two =")
    '    Console.WriteLine(DiceTwo)
    '    Console.ReadLine()

    'End Function
    'Private Function DiceTotal() As Integer

    '    DiceSum = DiceOne() + DiceTwo()
    '    'Console.WriteLine("Dice One + Dice Two = " & DiceSum)
    '    Console.ReadLine()

    'End Function
    'Function RunningTotals(currentValue As Integer, increment As Boolean, clear As Boolean)
    '    Static counterArray(10) As Integer
    '    Const OFFSET As Integer = 2
    '    If increment = True Then
    '        counterArray(currentValue - OFFSET) += 1
    '    End If
    '    Return counterArray
    'End Function
    Sub Main()
        'For ROLL = 1 To 1000
        '    DiceTotal()
        'Next
        Dim sum As Integer
        Dim MyArray(12, 2) As Decimal
        Dim rollNumber As Integer = 1000
        For i = 1 To rollNumber
            Randomize()
            sum = Int((6 * Rnd()) + 1) + Int((6 * Rnd()) + 1)
            MyArray(sum, 2) += 1
            'myArray(row, column)
            For j = 2 To 12
                MyArray(j, 1) = j
            Next
        Next
        'display's array
        Console.WriteLine("                                  ~ Roll Of The Dice ~")
        For i = 1 To 2
            For j = 2 To 12
                Console.Write(MyArray(j, i).ToString().PadLeft(5) & "  |")
            Next
            Console.WriteLine()
        Next
        Console.ReadLine()

    End Sub
    'Sub RollTwoDice()

    'End Sub
    'Sub WriteArrayToConsole(arrayOfNumbers() As Integer)
    '    Console.WriteLine(Space(19) & "Roll Of The Dice" & Space(19))
    '    Console.WriteLine(StrDup(55, "-"))

    '    For i = LBound(arrayOfNumbers) To UBound(arrayOfNumbers)
    '        Console.Write(CStr(i + 2).PadLeft(4) & "|")
    '    Next
    '    Console.WriteLine()
    '    Console.WriteLine(StrDup(55, "-"))
    '    For i = LBound(arrayOfNumbers) To UBound(arrayOfNumbers)
    '        Console.Write(CStr(arrayOfNumbers(i)).PadLeft(4) & "|")
    '    Next
    'End Sub

End Module
