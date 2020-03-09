<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContest
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
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.StudentInfoGroupBox = New System.Windows.Forms.GroupBox()
        Me.GradeLabel = New System.Windows.Forms.Label()
        Me.GradeTextBox = New System.Windows.Forms.TextBox()
        Me.AgeLabel = New System.Windows.Forms.Label()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.NameLabel = New System.Windows.Forms.Label()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.CurrentMathProblemGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.MathFunctionGroupBox = New System.Windows.Forms.GroupBox()
        Me.DivisionRadioButton = New System.Windows.Forms.RadioButton()
        Me.MultiplicationRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractionRadioButton = New System.Windows.Forms.RadioButton()
        Me.AdditionRadioButton = New System.Windows.Forms.RadioButton()
        Me.StudentInfoGroupBox.SuspendLayout()
        Me.CurrentMathProblemGroupBox.SuspendLayout()
        Me.MathFunctionGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'SubmitButton
        '
        Me.SubmitButton.Font = New System.Drawing.Font("Bowlby One SC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubmitButton.Location = New System.Drawing.Point(449, 20)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(109, 103)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Font = New System.Drawing.Font("Bowlby One SC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearButton.Location = New System.Drawing.Point(449, 129)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(109, 103)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ExitButton.Font = New System.Drawing.Font("Bowlby One SC", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(449, 238)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(109, 103)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StudentInfoGroupBox
        '
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.GradeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.AgeTextBox)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameLabel)
        Me.StudentInfoGroupBox.Controls.Add(Me.NameTextBox)
        Me.StudentInfoGroupBox.Location = New System.Drawing.Point(13, 13)
        Me.StudentInfoGroupBox.Name = "StudentInfoGroupBox"
        Me.StudentInfoGroupBox.Size = New System.Drawing.Size(430, 98)
        Me.StudentInfoGroupBox.TabIndex = 3
        Me.StudentInfoGroupBox.TabStop = False
        Me.StudentInfoGroupBox.Text = "Student Information"
        '
        'GradeLabel
        '
        Me.GradeLabel.AutoSize = True
        Me.GradeLabel.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GradeLabel.Location = New System.Drawing.Point(333, 21)
        Me.GradeLabel.Name = "GradeLabel"
        Me.GradeLabel.Size = New System.Drawing.Size(76, 28)
        Me.GradeLabel.TabIndex = 5
        Me.GradeLabel.Text = "Grade:"
        '
        'GradeTextBox
        '
        Me.GradeTextBox.Location = New System.Drawing.Point(338, 52)
        Me.GradeTextBox.Name = "GradeTextBox"
        Me.GradeTextBox.Size = New System.Drawing.Size(37, 20)
        Me.GradeTextBox.TabIndex = 4
        '
        'AgeLabel
        '
        Me.AgeLabel.AutoSize = True
        Me.AgeLabel.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AgeLabel.Location = New System.Drawing.Point(272, 21)
        Me.AgeLabel.Name = "AgeLabel"
        Me.AgeLabel.Size = New System.Drawing.Size(54, 28)
        Me.AgeLabel.TabIndex = 5
        Me.AgeLabel.Text = "Age:"
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(277, 52)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.Size = New System.Drawing.Size(37, 20)
        Me.AgeTextBox.TabIndex = 4
        '
        'NameLabel
        '
        Me.NameLabel.AutoSize = True
        Me.NameLabel.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameLabel.Location = New System.Drawing.Point(20, 21)
        Me.NameLabel.Name = "NameLabel"
        Me.NameLabel.Size = New System.Drawing.Size(75, 28)
        Me.NameLabel.TabIndex = 1
        Me.NameLabel.Text = "Name:"
        '
        'NameTextBox
        '
        Me.NameTextBox.Location = New System.Drawing.Point(25, 52)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(232, 20)
        Me.NameTextBox.TabIndex = 0
        '
        'CurrentMathProblemGroupBox
        '
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathProblemGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathProblemGroupBox.Location = New System.Drawing.Point(13, 118)
        Me.CurrentMathProblemGroupBox.Name = "CurrentMathProblemGroupBox"
        Me.CurrentMathProblemGroupBox.Size = New System.Drawing.Size(282, 223)
        Me.CurrentMathProblemGroupBox.TabIndex = 4
        Me.CurrentMathProblemGroupBox.TabStop = False
        Me.CurrentMathProblemGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(20, 124)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(171, 28)
        Me.StudentAnswerLabel.TabIndex = 7
        Me.StudentAnswerLabel.Text = "Student Answer:"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(25, 155)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(232, 20)
        Me.StudentAnswerTextBox.TabIndex = 6
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SecondNumberLabel.Location = New System.Drawing.Point(20, 70)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(170, 28)
        Me.SecondNumberLabel.TabIndex = 5
        Me.SecondNumberLabel.Text = "Second Number:"
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(25, 101)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(232, 20)
        Me.SecondNumberTextBox.TabIndex = 4
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Font = New System.Drawing.Font("Sitka Small", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FirstNumberLabel.Location = New System.Drawing.Point(20, 16)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(149, 28)
        Me.FirstNumberLabel.TabIndex = 3
        Me.FirstNumberLabel.Text = "First Number:"
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(25, 47)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(232, 20)
        Me.FirstNumberTextBox.TabIndex = 2
        '
        'MathFunctionGroupBox
        '
        Me.MathFunctionGroupBox.Controls.Add(Me.DivisionRadioButton)
        Me.MathFunctionGroupBox.Controls.Add(Me.MultiplicationRadioButton)
        Me.MathFunctionGroupBox.Controls.Add(Me.SubtractionRadioButton)
        Me.MathFunctionGroupBox.Controls.Add(Me.AdditionRadioButton)
        Me.MathFunctionGroupBox.Location = New System.Drawing.Point(302, 118)
        Me.MathFunctionGroupBox.Name = "MathFunctionGroupBox"
        Me.MathFunctionGroupBox.Size = New System.Drawing.Size(141, 223)
        Me.MathFunctionGroupBox.TabIndex = 5
        Me.MathFunctionGroupBox.TabStop = False
        Me.MathFunctionGroupBox.Text = "Math Function"
        '
        'DivisionRadioButton
        '
        Me.DivisionRadioButton.AutoSize = True
        Me.DivisionRadioButton.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DivisionRadioButton.Location = New System.Drawing.Point(6, 134)
        Me.DivisionRadioButton.Name = "DivisionRadioButton"
        Me.DivisionRadioButton.Size = New System.Drawing.Size(123, 28)
        Me.DivisionRadioButton.TabIndex = 3
        Me.DivisionRadioButton.TabStop = True
        Me.DivisionRadioButton.Text = "Subtraction"
        Me.DivisionRadioButton.UseVisualStyleBackColor = True
        '
        'MultiplicationRadioButton
        '
        Me.MultiplicationRadioButton.AutoSize = True
        Me.MultiplicationRadioButton.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MultiplicationRadioButton.Location = New System.Drawing.Point(6, 100)
        Me.MultiplicationRadioButton.Name = "MultiplicationRadioButton"
        Me.MultiplicationRadioButton.Size = New System.Drawing.Size(145, 28)
        Me.MultiplicationRadioButton.TabIndex = 2
        Me.MultiplicationRadioButton.TabStop = True
        Me.MultiplicationRadioButton.Text = "Multiplication"
        Me.MultiplicationRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractionRadioButton
        '
        Me.SubtractionRadioButton.AutoSize = True
        Me.SubtractionRadioButton.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SubtractionRadioButton.Location = New System.Drawing.Point(6, 66)
        Me.SubtractionRadioButton.Name = "SubtractionRadioButton"
        Me.SubtractionRadioButton.Size = New System.Drawing.Size(123, 28)
        Me.SubtractionRadioButton.TabIndex = 1
        Me.SubtractionRadioButton.TabStop = True
        Me.SubtractionRadioButton.Text = "Subtraction"
        Me.SubtractionRadioButton.UseVisualStyleBackColor = True
        '
        'AdditionRadioButton
        '
        Me.AdditionRadioButton.AutoSize = True
        Me.AdditionRadioButton.Font = New System.Drawing.Font("Sitka Small", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdditionRadioButton.Location = New System.Drawing.Point(6, 32)
        Me.AdditionRadioButton.Name = "AdditionRadioButton"
        Me.AdditionRadioButton.Size = New System.Drawing.Size(98, 28)
        Me.AdditionRadioButton.TabIndex = 0
        Me.AdditionRadioButton.TabStop = True
        Me.AdditionRadioButton.Text = "Addition"
        Me.AdditionRadioButton.UseVisualStyleBackColor = True
        '
        'MathContest
        '
        Me.AcceptButton = Me.SubmitButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ExitButton
        Me.ClientSize = New System.Drawing.Size(568, 354)
        Me.Controls.Add(Me.MathFunctionGroupBox)
        Me.Controls.Add(Me.CurrentMathProblemGroupBox)
        Me.Controls.Add(Me.StudentInfoGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.SubmitButton)
        Me.Name = "MathContest"
        Me.Text = "Math Contest"
        Me.StudentInfoGroupBox.ResumeLayout(False)
        Me.StudentInfoGroupBox.PerformLayout()
        Me.CurrentMathProblemGroupBox.ResumeLayout(False)
        Me.CurrentMathProblemGroupBox.PerformLayout()
        Me.MathFunctionGroupBox.ResumeLayout(False)
        Me.MathFunctionGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StudentInfoGroupBox As GroupBox
    Friend WithEvents GradeLabel As Label
    Friend WithEvents GradeTextBox As TextBox
    Friend WithEvents AgeLabel As Label
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents NameLabel As Label
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents CurrentMathProblemGroupBox As GroupBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents MathFunctionGroupBox As GroupBox
    Friend WithEvents DivisionRadioButton As RadioButton
    Friend WithEvents MultiplicationRadioButton As RadioButton
    Friend WithEvents SubtractionRadioButton As RadioButton
    Friend WithEvents AdditionRadioButton As RadioButton
End Class
