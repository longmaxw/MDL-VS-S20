'Maxwell Long
'RCET0265
'Spring 2020
'Math Contest

Public Class MathContest
    Dim AgeTextBoolean As Boolean
    Dim GradeTextBoolean As Boolean

    Private Sub AgeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles AgeTextBox.KeyDown
        Dim ascii As Integer
        ascii = e.KeyData
        Console.WriteLine(ascii)

        If ascii = 49 Or 48 Or 55 Or 56 Or 57 Then
            AgeTextBoolean = True
        Else
            AgeTextBox.Clear()
        End If

    End Sub

    Private Sub AgeTextBox_LostFocus(sender As Object, e As EventArgs) Handles AgeTextBox.LostFocus
        Dim Integer1 As Integer
        Integer1 = AgeTextBox.Text
        If Integer1 = 7 Then
            AgeTextBoolean = True
        ElseIf Integer1 = 8 Then
            AgeTextBoolean = True
        ElseIf Integer1 = 9 Then
            AgeTextBoolean = True
        ElseIf Integer1 = 10 Then
            AgeTextBoolean = True
        ElseIf Integer1 = 11 Then
            AgeTextBoolean = True
        Else
            AgeTextBoolean = False
            AgeTextBox.Text = ""
            AgeTextBox.Select()
            MessageBox.Show("wrong age, dumbass")
        End If
    End Sub

    Private Sub GradeTextBox_KeyDown(sender As Object, e As KeyEventArgs) Handles GradeTextBox.KeyDown
        Dim ascii As Integer
        ascii = e.KeyData
        Console.WriteLine(ascii)

        If ascii = 49 Or 50 Or 51 Or 52 Then
            GradeTextBoolean = True
        Else
            GradeTextBox.Clear()
            GradeTextBox.Select()
        End If

    End Sub

    Private Sub GradeTextBox_LostFocus(sender As Object, e As EventArgs) Handles GradeTextBox.LostFocus
        Dim Integer2 As Integer
        Integer2 = GradeTextBox.Text
        If Integer2 = 7 Then
            GradeTextBoolean = True
        ElseIf Integer2 = 8 Then
            GradeTextBoolean = True
        ElseIf Integer2 = 9 Then
            GradeTextBoolean = True
        ElseIf Integer2 = 10 Then
            GradeTextBoolean = True
        ElseIf Integer2 = 11 Then
            GradeTextBoolean = True
        Else
            AgeTextBoolean = False
            AgeTextBox.Text = ""
            AgeTextBox.Select()
            MessageBox.Show("wrong age, dumbass")
        End If
    End Sub
End Class
