<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.guessTextBox = New System.Windows.Forms.TextBox()
        Me.guessButton = New System.Windows.Forms.Button()
        Me.startButton = New System.Windows.Forms.Button()
        Me.exitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(158, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(273, 57)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "I'm thinking of a number between 1 and 10.  Enter your guess and click on the Che" &
    "ck My Guess button."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(222, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Your guess:"
        '
        'guessTextBox
        '
        Me.guessTextBox.Location = New System.Drawing.Point(307, 137)
        Me.guessTextBox.Name = "guessTextBox"
        Me.guessTextBox.Size = New System.Drawing.Size(62, 20)
        Me.guessTextBox.TabIndex = 2
        '
        'guessButton
        '
        Me.guessButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guessButton.Location = New System.Drawing.Point(60, 188)
        Me.guessButton.Name = "guessButton"
        Me.guessButton.Size = New System.Drawing.Size(122, 33)
        Me.guessButton.TabIndex = 3
        Me.guessButton.Text = "&Check My Guess"
        Me.guessButton.UseVisualStyleBackColor = True
        '
        'startButton
        '
        Me.startButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.startButton.Location = New System.Drawing.Point(236, 188)
        Me.startButton.Name = "startButton"
        Me.startButton.Size = New System.Drawing.Size(123, 33)
        Me.startButton.TabIndex = 4
        Me.startButton.Text = "S&tart a New Game"
        Me.startButton.UseVisualStyleBackColor = True
        '
        'exitButton
        '
        Me.exitButton.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.exitButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.exitButton.Location = New System.Drawing.Point(408, 188)
        Me.exitButton.Name = "exitButton"
        Me.exitButton.Size = New System.Drawing.Size(107, 33)
        Me.exitButton.TabIndex = 5
        Me.exitButton.Text = "Exit"
        Me.exitButton.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AcceptButton = Me.guessButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.CancelButton = Me.exitButton
        Me.ClientSize = New System.Drawing.Size(574, 277)
        Me.Controls.Add(Me.exitButton)
        Me.Controls.Add(Me.startButton)
        Me.Controls.Add(Me.guessButton)
        Me.Controls.Add(Me.guessTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MainForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Guess My Number"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents guessTextBox As System.Windows.Forms.TextBox
    Friend WithEvents guessButton As System.Windows.Forms.Button
    Friend WithEvents startButton As System.Windows.Forms.Button
    Friend WithEvents exitButton As System.Windows.Forms.Button

End Class
