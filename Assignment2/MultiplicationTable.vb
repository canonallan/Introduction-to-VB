Public Class MultiplicationTable
    Private Sub GenerateMultiplicationTable()

        TextBox1.Clear()


        TextBox1.AppendText("Multiplication Table" & vbCrLf)
        TextBox1.AppendText("* 1 2 3 4 5 6 7" & vbCrLf)


        For i As Integer = 1 To 7
            TextBox1.AppendText(i.ToString() & " ")
            For j As Integer = 1 To 7
                TextBox1.AppendText((i * j).ToString() & " ")
            Next
            TextBox1.AppendText(vbCrLf)
        Next
    End Sub
    Private Sub MultiplicationTable_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        GenerateMultiplicationTable()
        TextBox1.Width = 300
        TextBox1.Height = 200
    End Sub
End Class