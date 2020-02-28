'Maxwell Long


Module Module1

    Sub Main()
        MsgBox("Here's a movie quote for you :)")
        Console.WriteLine(UserMessages(True, "Anna: Olaf, you’re melting.", False))
        Console.WriteLine(UserMessages(True, "Olaf: Some people are worth melting for.", False))
        Console.WriteLine(UserMessages(True, "Olaf: Just maybe not right this second!", False))
        MsgBox(UserMessages(True, "", False))

    End Sub

    Function UserMessages(addMessage As Boolean, message As String, clearMessage As Boolean) As String

        Static formattedMessages As String '= ""

        If clearMessage = False Then
            If addMessage = True Then
                formattedMessages &= message & vbNewLine
            End If
        Else
            formattedMessages = ""
        End If

        Return formattedMessages

    End Function

End Module
