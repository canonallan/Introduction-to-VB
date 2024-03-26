Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        TextBox5.ReadOnly = True
        TextBox5.Enabled = False

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim mark1 As Integer = Integer.Parse(TextBox1.Text)
        Dim mark2 As Integer = Integer.Parse(TextBox2.Text)
        Dim mark3 As Integer = Integer.Parse(TextBox3.Text)
        Dim mark4 As Integer = Integer.Parse(TextBox4.Text)


        Dim averageMark As Double = (mark1 + mark2 + mark3 + mark4) / 4


        Dim grade As String = ""
        If averageMark >= 75 Then
            grade = "A"
        ElseIf averageMark >= 65 Then
            grade = "B"
        ElseIf averageMark >= 50 Then
            grade = "C"
        Else
            grade = "Fail"
        End If


        TextBox5.Text = grade
    End Sub
End Class
