Public Class Interest
    Private Sub CalculateAndDisplay()

        ListBox1.Items.Clear()


        Dim principal As Double = 1000000
        Dim annualInterestRate As Double = 0.05


        For year As Integer = 1 To 10
            Dim amount As Double = principal * (1 + annualInterestRate) ^ year
            ListBox1.Items.Add($"Year {year}: KSh {amount:N2}")
        Next
    End Sub
    Private Sub Interest_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CalculateAndDisplay()
    End Sub
End Class