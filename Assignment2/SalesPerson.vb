Public Class SalesPerson
    Const WeeklyBasePay As Double = 2500
    Const Quota As Double = 1000
    Const CommissionRate As Double = 0.15
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub button_Click(sender As Object, e As EventArgs) Handles button.Click
        Dim name As String = txtName.Text
        Dim dailySales As Double

        If Double.TryParse(txtDailySales.Text, dailySales) Then
            Dim weeklySales As Double = dailySales * 7
            Dim commission As Double = If(weeklySales > Quota, CommissionRate * weeklySales, 0)
            Dim weeklySalary As Double = WeeklyBasePay + commission

            lstSalespersons.Items.Add($"Name: {name}, Daily Sales: {dailySales}, Weekly Sales: {weeklySales}, Weekly Salary: {weeklySalary}")
        Else
            MessageBox.Show("Invalid input for daily sales. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class