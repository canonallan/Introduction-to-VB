Public Class ProgressSimulation

    Private Sub timer_Tick(sender As Object, e As EventArgs) Handles timer.Tick
        progressBar.Value += 10
        lblProgress.Text = $"Progress: {progressBar.Value}%"


        If progressBar.Value >= 100 Then

            timer.Stop()
            MessageBox.Show("Process complete!", "Done")
        End If
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        timer.Start()
    End Sub

    Private Sub progressBar_Click(sender As Object, e As EventArgs) Handles progressBar.Click

    End Sub
End Class