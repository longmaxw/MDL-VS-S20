'Maxwell Long
'

Option Explicit On

Public Class Form1

    Sub Main()

    End Sub
    Sub WriteToListBox()

        ListBox1.Items.Add(StrDup(55, "-"))

        Dim sum As Integer
        Dim MyArray(12, 2) As Decimal
        Dim rollNumber As Integer = 1000
        Dim row1 As String
        Dim row2 As String
        Dim row3 As String

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
        ListBox1.Items.Add(String.Format("           ~ Roll Of The Dice ~"))
        For i = 2 To 12
            row1 &= String.Format(MyArray(i, 1).ToString().PadLeft(3) & "|")
        Next
        For i = 2 To 12
            row2 &= String.Format(MyArray(i, 2).ToString().PadLeft(3) & "|")
        Next
        ListBox1.Items.Add(row1)
        ListBox1.Items.Add(row2)

        'For i = 1 To 2
        '    For j = 2 To 12
        '        ListBox1.Items.Add(String.Format(MyArray(j, i).ToString().PadLeft(10) & "|"))
        '    Next
        'Next

    End Sub

    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        WriteToListBox()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        ListBox1.Items.Clear()
    End Sub
End Class
