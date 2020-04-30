'Maxwell Long
'RCET 0265
'Spring2020
'Etch-A-Sketch


Public Class Form1

    Dim penColor As Color
    Dim myPen As New Pen(Color.Black)
    Dim graph As Graphics
    Dim oldX As Integer
    Dim oldY As Integer

    'Line is drawn while the mouse is clicked and dragged within the picturebox
    Private Sub PictureBox_MouseMove(sender As Object, e As MouseEventArgs) Handles PictureBox.MouseMove

        Me.Text = "x: " & e.X & " y: " & e.Y & " Mouse Button: " & e.Button.ToString
        graph = PictureBox.CreateGraphics
        If e.Button.ToString <> "None" Then
            graph.DrawLine(myPen, oldX, oldY, e.X, e.Y)
        End If

        oldX = e.X
        oldY = e.Y

    End Sub

    Private Sub WaveformButton_Click(sender As Object, e As EventArgs) Handles WaveformButton.Click
        Dim Xvalue As Decimal
        Dim Yvalue As Decimal
        Dim oldY2 = 200
        Dim oldX2 = 0
        Label1.Show()
        Label2.Show()
        Label3.Show()
        myPen.Color = Color.Black
        myPen.Width = (2.0F)
        PictureBox.Refresh() 'erase current drawing

        'Verticle Lines (Y)
        For xVal = 80 To 720 Step 80
            For yVal = 5 To 400 Step 10
                graph.DrawLine(myPen, xVal, yVal, xVal, yVal + 5)
            Next
        Next
        'Horizontal Lines (X)
        For yVal = 40 To 360 Step 40
            For xVal = 5 To 800 Step 10
                graph.DrawLine(myPen, xVal, yVal, xVal + 5, yVal)
            Next
        Next

        'Sinewave
        myPen.Color = Color.Orange
        For X = 1 To 800 'Draw Gridlines
            Yvalue = 200 - (50 * Math.Sin(X / 400 * 2 * Math.PI)) 'Draw sine
            Xvalue = X
            graph.DrawLine(myPen, oldX2, oldY2, Xvalue, Yvalue)
            oldX2 = Xvalue
            oldY2 = Yvalue
        Next

        'Cosine
        myPen.Color = Color.Purple
        oldX2 = 0
        oldY2 = 200
        For X = 1 To 800 'Draw Gridlines
            Yvalue = 200 - (50 * Math.Cos(X / 400 * 2 * Math.PI)) 'Draw waveform
            Xvalue = X
            graph.DrawLine(myPen, oldX2, oldY2, Xvalue, Yvalue)
            oldX2 = Xvalue
            oldY2 = Yvalue
        Next

        'Tangent
        myPen.Color = Color.Green
        oldX2 = 0
        oldY2 = 200
        For X = 1 To 800 'Draw Gridlines
            Yvalue = 200 - (50 * Math.Tan(X / 400 * 2 * Math.PI)) 'Draw waveform
            If Yvalue > 600 Then
                Yvalue = 600
            ElseIf Yvalue < -200 Then
                Yvalue = -200
            End If
            Xvalue = X
            If (X > 95 And X < 105) Or (X > 295 And X < 305) Or (X > 495 And X < 505) Or (X > 695 And X < 705) Then
                'empty
            Else
                graph.DrawLine(myPen, oldX2, oldY2, Xvalue, Yvalue)
            End If
            oldX2 = Xvalue
            oldY2 = Yvalue
        Next
        Label1.Text = ("Sin: Orange")
        Label2.Text = ("Tan: Green")
        Label3.Text = ("Cos: Purple")
    End Sub
    Private Sub EraseButton_Click(sender As Object, e As EventArgs) Handles EraseButton.Click
        Dim oldTop = Me.Top
        'Shakes the Etch-o-Sketch to erase
        For i = 1 To 3
            For j = 1 To 10000000
                If j < 5500000 Then
                    Me.Top = oldTop - 50
                Else
                    Me.Top = oldTop
                End If
            Next
        Next
        PictureBox.Refresh()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
    End Sub
    Private Sub ColorButton_Click(sender As Object, e As EventArgs) Handles ColorButton.Click
        ColorDialog1.ShowDialog() 'opens the color options 
        penColor = ColorDialog1.Color 'user's pen color choice
        myPen.Color = penColor
    End Sub
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub Size1RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Size1RadioButton.CheckedChanged
        myPen.Width = (1.0F)
    End Sub

    Private Sub Size2RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Size2RadioButton.CheckedChanged
        myPen.Width = (2.0F)
    End Sub

    Private Sub Size3RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Size3RadioButton.CheckedChanged
        myPen.Width = (4.0F)
    End Sub

    Private Sub Size4RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Size4RadioButton.CheckedChanged
        myPen.Width = (6.0F)
    End Sub

    Private Sub Size5RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Size5RadioButton.CheckedChanged
        myPen.Width = (8.0F)
    End Sub

    Private Sub Size6RadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles Size6RadioButton.CheckedChanged
        myPen.Width = (10.0F)
    End Sub
End Class
