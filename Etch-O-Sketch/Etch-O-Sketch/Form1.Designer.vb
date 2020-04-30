<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.ColorButton = New System.Windows.Forms.Button()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.WaveformButton = New System.Windows.Forms.Button()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Size1RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size2RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size3RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size4RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size5RadioButton = New System.Windows.Forms.RadioButton()
        Me.Size6RadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.PictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox.Cursor = System.Windows.Forms.Cursors.Cross
        Me.PictureBox.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(776, 358)
        Me.PictureBox.TabIndex = 0
        Me.PictureBox.TabStop = False
        '
        'ColorButton
        '
        Me.ColorButton.BackColor = System.Drawing.Color.Black
        Me.ColorButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ColorButton.Font = New System.Drawing.Font("Consolas", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ColorButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ColorButton.Location = New System.Drawing.Point(1, 378)
        Me.ColorButton.Name = "ColorButton"
        Me.ColorButton.Size = New System.Drawing.Size(195, 61)
        Me.ColorButton.TabIndex = 1
        Me.ColorButton.Text = "Change Color"
        Me.ColorButton.UseVisualStyleBackColor = False
        '
        'EraseButton
        '
        Me.EraseButton.BackColor = System.Drawing.Color.Black
        Me.EraseButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.EraseButton.Font = New System.Drawing.Font("Consolas", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EraseButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.EraseButton.Location = New System.Drawing.Point(202, 378)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(195, 61)
        Me.EraseButton.TabIndex = 2
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = False
        '
        'WaveformButton
        '
        Me.WaveformButton.BackColor = System.Drawing.Color.Black
        Me.WaveformButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.WaveformButton.Font = New System.Drawing.Font("Consolas", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.WaveformButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.WaveformButton.Location = New System.Drawing.Point(403, 377)
        Me.WaveformButton.Name = "WaveformButton"
        Me.WaveformButton.Size = New System.Drawing.Size(195, 61)
        Me.WaveformButton.TabIndex = 3
        Me.WaveformButton.Text = "Waveforms"
        Me.WaveformButton.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.Info
        Me.Label1.Location = New System.Drawing.Point(96, 159)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.Info
        Me.Label2.Location = New System.Drawing.Point(72, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Info
        Me.Label3.Location = New System.Drawing.Point(374, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 6
        '
        'ExitButton
        '
        Me.ExitButton.BackColor = System.Drawing.Color.Black
        Me.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ExitButton.Font = New System.Drawing.Font("Consolas", 17.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ExitButton.Location = New System.Drawing.Point(604, 378)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(195, 61)
        Me.ExitButton.TabIndex = 7
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 445)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Line Thickness :"
        '
        'Size1RadioButton
        '
        Me.Size1RadioButton.AutoSize = True
        Me.Size1RadioButton.Location = New System.Drawing.Point(169, 445)
        Me.Size1RadioButton.Name = "Size1RadioButton"
        Me.Size1RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.Size1RadioButton.TabIndex = 9
        Me.Size1RadioButton.TabStop = True
        Me.Size1RadioButton.Text = "Size 1"
        Me.Size1RadioButton.UseVisualStyleBackColor = True
        '
        'Size2RadioButton
        '
        Me.Size2RadioButton.AutoSize = True
        Me.Size2RadioButton.Location = New System.Drawing.Point(260, 445)
        Me.Size2RadioButton.Name = "Size2RadioButton"
        Me.Size2RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.Size2RadioButton.TabIndex = 10
        Me.Size2RadioButton.TabStop = True
        Me.Size2RadioButton.Text = "Size 2"
        Me.Size2RadioButton.UseVisualStyleBackColor = True
        '
        'Size3RadioButton
        '
        Me.Size3RadioButton.AutoSize = True
        Me.Size3RadioButton.Location = New System.Drawing.Point(343, 445)
        Me.Size3RadioButton.Name = "Size3RadioButton"
        Me.Size3RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.Size3RadioButton.TabIndex = 11
        Me.Size3RadioButton.TabStop = True
        Me.Size3RadioButton.Text = "Size 3"
        Me.Size3RadioButton.UseVisualStyleBackColor = True
        '
        'Size4RadioButton
        '
        Me.Size4RadioButton.AutoSize = True
        Me.Size4RadioButton.Location = New System.Drawing.Point(435, 445)
        Me.Size4RadioButton.Name = "Size4RadioButton"
        Me.Size4RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.Size4RadioButton.TabIndex = 12
        Me.Size4RadioButton.TabStop = True
        Me.Size4RadioButton.Text = "Size 4"
        Me.Size4RadioButton.UseVisualStyleBackColor = True
        '
        'Size5RadioButton
        '
        Me.Size5RadioButton.AutoSize = True
        Me.Size5RadioButton.Location = New System.Drawing.Point(526, 445)
        Me.Size5RadioButton.Name = "Size5RadioButton"
        Me.Size5RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.Size5RadioButton.TabIndex = 13
        Me.Size5RadioButton.TabStop = True
        Me.Size5RadioButton.Text = "Size 5"
        Me.Size5RadioButton.UseVisualStyleBackColor = True
        '
        'Size6RadioButton
        '
        Me.Size6RadioButton.AutoSize = True
        Me.Size6RadioButton.Location = New System.Drawing.Point(619, 445)
        Me.Size6RadioButton.Name = "Size6RadioButton"
        Me.Size6RadioButton.Size = New System.Drawing.Size(54, 17)
        Me.Size6RadioButton.TabIndex = 14
        Me.Size6RadioButton.TabStop = True
        Me.Size6RadioButton.Text = "Size 6"
        Me.Size6RadioButton.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(800, 467)
        Me.Controls.Add(Me.Size6RadioButton)
        Me.Controls.Add(Me.Size5RadioButton)
        Me.Controls.Add(Me.Size4RadioButton)
        Me.Controls.Add(Me.Size3RadioButton)
        Me.Controls.Add(Me.Size2RadioButton)
        Me.Controls.Add(Me.Size1RadioButton)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.WaveformButton)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.ColorButton)
        Me.Controls.Add(Me.PictureBox)
        Me.Name = "Form1"
        Me.Text = "Etch-o-Skecth"
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents ColorButton As Button
    Friend WithEvents EraseButton As Button
    Friend WithEvents WaveformButton As Button
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ExitButton As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Size1RadioButton As RadioButton
    Friend WithEvents Size2RadioButton As RadioButton
    Friend WithEvents Size3RadioButton As RadioButton
    Friend WithEvents Size4RadioButton As RadioButton
    Friend WithEvents Size5RadioButton As RadioButton
    Friend WithEvents Size6RadioButton As RadioButton
End Class
