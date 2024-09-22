

Public Class MainForm
    Private answer As Integer
    Private rand As Random
    Private totalGuesses As Integer
    Private totalRight As Integer
    Private guessLimit As Integer

    Private Sub guessButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles guessButton.Click
        Dim guess As Integer

        If Not Integer.TryParse(guessTextBox.Text, guess) Then
            MessageBox.Show(“You must enter a numeric value here.”, “Bad value”,
                    MessageBoxButtons.OK, MessageBoxIcon.Information)
            guessTextBox.Focus()
            Exit Sub
        End If
        If guess = answer Then
            totalRight += 1
            MessageBox.Show(“Congratulations! You guessed my number! Click on Start New Game to play again.”, “Winner”, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        Else
            If guess < answer Then
                MessageBox.Show(“Sorry! Try a higher number.”, “Incorrect”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show(“Sorry! Try a lower number.”, “Incorrect”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
            guessTextBox.Clear()
        End If
        totalGuesses += 1
        guessLimit += 1

        If guessLimit = 5 Then
            guessLimit = 0
            answer = rand.Next(1, 11)
            MessageBox.Show(“Sorry! You have used all 5 chances. I have a new number. Try to guess it.”, “New game”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
            guessTextBox.Clear()
        End If
    End Sub

    Private Sub MainForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'generate the first random number for the start of the game
        rand = New Random()
        answer = rand.Next(1, 11)
    End Sub

    Private Sub exitButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles exitButton.Click
        MessageBox.Show(“You had “ & totalRight.ToString() & “ correct guesses out of “ & totalGuesses.ToString() _
                        & “ guesses, for a win percentage of “ & (totalRight / totalGuesses).ToString(“p1”),
                        “Your Results”, MessageBoxButtons.OK, MessageBoxIcon.Information)
        End
    End Sub

    Private Sub startButton_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles startButton.Click
        guessLimit = 0
        answer = rand.Next(1, 11)
        MessageBox.Show(“I have a new number. Try to guess it.”, “New game”, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        guessTextBox.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
