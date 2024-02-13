Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Introduction_to_VB
    Public Partial Class Form2
        Inherits Form
        Public Shared Instance As Form2
        Public Sub New()

            InitializeComponent()
            Instance = Me
        End Sub

        Private Sub Form2_Load(sender As Object, e As EventArgs)

        End Sub




        Private Sub radioButton2_CheckedChanged(sender As Object, e As EventArgs)
            If blue.Checked Then

                textBox1.ForeColor = Color.Blue
            End If
        End Sub

        Private Sub radioButton3_CheckedChanged(sender As Object, e As EventArgs)
            If red.Checked Then

                textBox1.ForeColor = Color.Red
            End If
        End Sub

        Private Sub radioButton3_CheckedChanged_1(sender As Object, e As EventArgs)
            If tahoma.Checked Then

                textBox1.Font = New Font("Tahoma", textBox1.Font.Size)
            End If
        End Sub

        Private Sub checkBox3_CheckedChanged(sender As Object, e As EventArgs)
            If bolditalic.Checked Then

                textBox1.Font = New Font(textBox1.Font, Drawing.FontStyle.Bold Or Drawing.FontStyle.Italic)

            ElseIf bold.Checked Then

                textBox1.Font = New Font(textBox1.Font, Drawing.FontStyle.Bold)

            ElseIf italic.Checked Then

                textBox1.Font = New Font(textBox1.Font, Drawing.FontStyle.Italic)
            Else

                textBox1.Font = New Font(textBox1.Font, Drawing.FontStyle.Regular)
            End If
        End Sub

        Private Sub label1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub label1_Click_1(sender As Object, e As EventArgs)

        End Sub

        Private Sub loadpicture_Click(sender As Object, e As EventArgs)
            Dim openFileDialog As OpenFileDialog = New OpenFileDialog()
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then

                pictureBox1.ImageLocation = openFileDialog.FileName
            End If
        End Sub

        Private Sub pictureBox1_Click(sender As Object, e As EventArgs)

        End Sub

        Private Sub textBox1_TextChanged(sender As Object, e As EventArgs)

        End Sub

        Private Sub garamond_CheckedChanged(sender As Object, e As EventArgs)
            If garamond.Checked Then

                textBox1.Font = New Font("Garamond", textBox1.Font.Size)
            End If
        End Sub

        Private Sub magneto_CheckedChanged(sender As Object, e As EventArgs)
            If magneto.Checked Then

                textBox1.Font = New Font("Magneto", textBox1.Font.Size)
            End If
        End Sub

        Private Sub italic_CheckedChanged(sender As Object, e As EventArgs)
            If italic.Checked Then

                textBox1.Font = New Font(textBox1.Font, Drawing.FontStyle.Italic)
            Else

                textBox1.Font = New Font(textBox1.Font, textBox1.Font.Style And Not Drawing.FontStyle.Italic)
            End If
        End Sub

        Private Sub bold_CheckedChanged(sender As Object, e As EventArgs)
            If bold.Checked Then

                textBox1.Font = New Font(textBox1.Font, Drawing.FontStyle.Bold)
            Else

                textBox1.Font = New Font(textBox1.Font, textBox1.Font.Style And Not Drawing.FontStyle.Bold)
            End If
        End Sub

        Private Sub exit_Click(sender As Object, e As EventArgs)
            Dim form1 As Form1 = New Form1()
            form1.Show()
        End Sub

        Private Sub green_CheckedChanged(sender As Object, e As EventArgs)
            If green.Checked Then

                textBox1.ForeColor = Color.Green
            End If
        End Sub
    End Class
End Namespace
