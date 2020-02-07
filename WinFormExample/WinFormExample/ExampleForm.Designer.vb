<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ExampleForm1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewItem1 As System.Windows.Forms.ListViewItem = New System.Windows.Forms.ListViewItem(New System.Windows.Forms.ListViewItem.ListViewSubItem() {New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, ""), New System.Windows.Forms.ListViewItem.ListViewSubItem(Nothing, "", System.Drawing.Color.Gainsboro, System.Drawing.SystemColors.Window, New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte)))}, -1)
        Me.UpdateButton1 = New System.Windows.Forms.Button()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.ExitButton2 = New System.Windows.Forms.Button()
        Me.UserList = New System.Windows.Forms.ListView()
        Me.ColumnHeader = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'UpdateButton1
        '
        Me.UpdateButton1.Location = New System.Drawing.Point(78, 65)
        Me.UpdateButton1.Name = "UpdateButton1"
        Me.UpdateButton1.Size = New System.Drawing.Size(141, 34)
        Me.UpdateButton1.TabIndex = 0
        Me.UpdateButton1.Text = "Update"
        Me.UpdateButton1.UseVisualStyleBackColor = True
        '
        'UserTextBox
        '
        Me.UserTextBox.Location = New System.Drawing.Point(78, 39)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(288, 20)
        Me.UserTextBox.TabIndex = 1
        '
        'ExitButton2
        '
        Me.ExitButton2.Location = New System.Drawing.Point(225, 65)
        Me.ExitButton2.Name = "ExitButton2"
        Me.ExitButton2.Size = New System.Drawing.Size(141, 34)
        Me.ExitButton2.TabIndex = 2
        Me.ExitButton2.Text = "Exit"
        Me.ExitButton2.UseVisualStyleBackColor = True
        '
        'UserList
        '
        Me.UserList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader})
        Me.UserList.HideSelection = False
        Me.UserList.Items.AddRange(New System.Windows.Forms.ListViewItem() {ListViewItem1})
        Me.UserList.Location = New System.Drawing.Point(372, 39)
        Me.UserList.Name = "UserList"
        Me.UserList.Size = New System.Drawing.Size(343, 319)
        Me.UserList.TabIndex = 3
        Me.UserList.UseCompatibleStateImageBehavior = False
        Me.UserList.View = System.Windows.Forms.View.List
        '
        'ColumnHeader
        '
        Me.ColumnHeader.Text = "userText"
        '
        'ExampleForm1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.UserList)
        Me.Controls.Add(Me.ExitButton2)
        Me.Controls.Add(Me.UserTextBox)
        Me.Controls.Add(Me.UpdateButton1)
        Me.Name = "ExampleForm1"
        Me.Text = "ExampleForm1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents UpdateButton1 As Button
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents ExitButton2 As Button
    Friend WithEvents UserList As ListView
    Private WithEvents ColumnHeader As ColumnHeader
End Class
