Public Class ASCIICharacter
    Private Function GetNextCharacter(inputChar As String) As String

        Dim asciiCode As Integer = Asc(inputChar)
        Dim nextAsciiCode As Integer = asciiCode + 1


        Dim nextChar As String = Chr(nextAsciiCode)

        Return nextChar
    End Function
    Private Sub ASCIICharacter_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim inputChar As String = InputBox("Enter a character:", "Input")

        If Not String.IsNullOrEmpty(inputChar) AndAlso inputChar.Length = 1 Then

            Dim nextChar As String = GetNextCharacter(inputChar)


            MessageBox.Show($"The character following {inputChar} is {nextChar}.", "Result")
        Else
            '
            MessageBox.Show("Invalid input. Please enter a single character.", "Error")
        End If
    End Sub
End Class