Public Class ExampleForm1
    Private Sub UpdateButton1_Click(sender As Object, e As EventArgs) Handles UpdateButton1.Click

        Dim userInput As String
        userInput = userText.Text
        Me.Text = userInput

    End Sub

    Private Sub ExitButton2_Click(sender As Object, e As EventArgs) Handles ExitButton2.Click
        Me.Close()
    End Sub

End Class