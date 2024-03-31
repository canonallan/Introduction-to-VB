Public Class DemoForm
    Public Sub ResizeForm()

        Dim screenWidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim screenHeight As Integer = Screen.PrimaryScreen.Bounds.Height


        Dim newWidth As Integer = screenWidth * 0.75
        Dim newHeight As Integer = screenHeight * 0.5


        Me.Width = newWidth
        Me.Height = newHeight
    End Sub

    Private Sub DemoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ResizeForm()
    End Sub
End Class
