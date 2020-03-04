'Maxwell Long
'RCET0265
'Spring 2020
'Address Label Program

Public Class AddressLabelForm
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        DisplayLabel.Text &= FirstNameTextBox.Text
        DisplayLabel.Text &= LastNameTextBox.Text & "" & vbNewLine
        DisplayLabel.Text &= StreetAddressTextBox.Text & "" & vbNewLine
        DisplayLabel.Text &= CityTextBox.Text & ", "
        DisplayLabel.Text &= StateTextBox.Text & "  "
        DisplayLabel.Text &= ZipTextBox.Text
    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        DisplayLabel.Text = ""
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
