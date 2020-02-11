Public Class ExampleForm1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Test = "Hello Form"

    End Sub

    Private Sub UpdateButton1_Click(sender As Object, e As EventArgs) Handles UpdateButton1.Click

        Dim userInput As String
        userInput = UserTextBox_Name.Text
        Me.Text = userInput

    End Sub

    Private Sub ExitButton2_Click(sender As Object, e As EventArgs) Handles ExitButton2.Click
        Me.Close()

    End Sub

    Private Sub GoButton3_Click(sender As Object, e As EventArgs) Handles GoButton3.Click
        RadioButton1.Checked = True

    End Sub
End Class