Public Class Form1
    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()

    End Sub

    Private Sub ProgressBar2_Click(sender As Object, e As EventArgs) Handles MyProgressBar.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MyProgressBar.Value += 10
        lblProgress.Text = $"Loading: {MyProgressBar.Value}%"
        If MyProgressBar.Value = 100 Then
            Me.Hide()
            Dim log = New LoginForm
            log.Show()
            Timer1.Enabled = False

        End If




    End Sub
End Class
