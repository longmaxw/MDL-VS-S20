Public Class Form1

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
    Sub WriteToListBox()

        ListBox1.Items.Add(StrDup(55, "-"))

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
        ListBox1.Items.Add(String.Format("               ~ Roll Of The Dice ~"))
        For i = 1 To 2
            For j = 2 To 12
                ListBox1.Items.Add(String.Format(MyArray(j, i).ToString().PadLeft(5) & "    |"))
            Next
        Next

    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        WriteToListBox()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
End Class
