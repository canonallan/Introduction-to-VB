Imports System
Imports System.Windows.Forms


Namespace Introduction_to_VB
    Public Partial Class Form1
        Inherits Form

        Private form2Instance As Form2

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub loadobjectform_Click(sender As Object, e As EventArgs)

            form2Instance = New Form2()
            form2Instance.Show()
        End Sub

        Private Sub button2_Click(sender As Object, e As EventArgs)

            Close()
        End Sub
    End Class
End Namespace
