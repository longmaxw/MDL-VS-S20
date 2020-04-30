Public Class StansGroceryForm

    Private itemsTextFile As String = "C:\Users\broth\source\repos\Grocery.txt"

    Dim itemArray(2, 4) As String
    Dim x As Integer = 0
    Dim y As Integer = 0

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim file As String = "C:\Users\broth\source\repos\Grocery.txt" 'File is located and read.
        FileOpen(1, file, OpenMode.Input) 'Open's File
        Do While Not EOF(1)
            itemArray(x, y) = LineInput(1)
            SelectedItemBox.Items.Add(itemArray(x, y))
            If y < 4 Then
                y = y + 1
            ElseIf y = 4 Then
                y = 0
                x = x + 1
            End If
        Loop
        FileClose()
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        Dim find As Boolean
        find = True
        x = 0
        y = 0
        DisplayListBox.Items.Clear()
        Do While find = True 'Search the array
            Try
                If SearchTextBox.Text = "" Then
                    find = False
                    MsgBox("Please enter a search or select from the dropdown.")
                ElseIf LCase(SearchTextBox.Text) = "zzz" Then
                    find = False
                    Me.Close()
                ElseIf LCase(SearchTextBox.Text) = LCase(itemArray(x, y)) Then
                    find = False
                    DisplayListBox.Items.Add("You will find " & itemArray(x, y) & " on asile " & (x + 1) & ", item #" & (y + 1))
                ElseIf y < 4 Then
                    y = y + 1
                ElseIf y = 4 Then
                    y = 0
                    x = x + 1
                ElseIf x > 4 Then
                    find = False
                    MsgBox("Unfortunately, we don't carry that item in our store." &
                                   "Please check our website for more options or try searching a different name.")
                End If
            Catch ex As Exception
                find = False
                MsgBox("Unfortunately, we don't carry that item in our store." &
                               "Please check our website for more options or try searching a different name.")
                SearchTextBox.Text = ""
            End Try
        Loop

    End Sub

    Private Sub SelectedItemBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles SelectedItemBox.SelectedIndexChanged
        Dim find As Boolean
        find = True
        x = 0
        y = 0
        DisplayListBox.Items.Clear()
        Do While find = True 'Searches the Array
            If SelectedItemBox.Text = itemArray(x, y) Then
                find = False
                DisplayListBox.Items.Add("You will find " & itemArray(x, y) & " on asile #" & (x + 1) & ", item #" & (y + 1))
            ElseIf y < 4 Then
                y = y + 1
            ElseIf y = 4 Then
                y = 0
                x = x + 1
            ElseIf x > 4 Then
                find = False
                MsgBox("Item was not found, try agian.")
            End If
        Loop
    End Sub

    Private Sub TopMenuStrip_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles TopMenuStrip.ItemClicked
        MsgBox("Interface Design: Tim Rossitor" & vbNewLine & "Program by: Maxwell Long" & vbNewLine & "Version 0.1")
    End Sub
End Class

