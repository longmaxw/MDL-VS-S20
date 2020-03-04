'Maxwell Long
'RCET0265
'Spring 2020
'Diner Menu

Option Strict On
Option Explicit On


Public Class Maxs_Pub_Form

    Private Sub SoupButton_Click(sender As Object, e As EventArgs) Handles SoupButton.Click
        'type soupmessage
        Dim soupMessage As String
        soupMessage &= "~Soup of the Day~" & vbNewLine & "Beer Soup. Made with " _
            & "choice of draft beer, fried flour, And locally grown potatoes."
        DisplaySpecialLabel.Text = soupMessage
    End Sub

    Private Sub SaladButton_Click(sender As Object, e As EventArgs) Handles SaladButton.Click
        'type saladmessage
        Dim saladMessage As String
        saladMessage &= "Ultimate Caesar Salad" & vbNewLine & "This really Is " _
            & "the best homemade Caesar salad! With romaine lettuce, " _
            & "Parmesan cheese,homemade croutons And a creamy homemade dressing."
        DisplaySpecialLabel.Text = saladMessage
    End Sub

    Private Sub FishButton_Click(sender As Object, e As EventArgs) Handles FishButton.Click
        'type fishmessage
        Dim fishMessage As String
        fishMessage &= "Greasy Salmon" & vbNewLine & "Locally caught, GREASY" _
            & "slab of salmon on a plate."
        DisplaySpecialLabel.Text = fishMessage
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
