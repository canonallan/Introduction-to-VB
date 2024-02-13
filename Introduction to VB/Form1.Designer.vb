Imports System

Namespace Introduction_to_VB
    Partial Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            loadobjectdemo = New Windows.Forms.Button()
            exit1 = New Windows.Forms.Button()
            SuspendLayout()
            ' 
            ' loadobjectdemo
            ' 
            loadobjectdemo.BackColor = Drawing.Color.Yellow
            loadobjectdemo.Font = New Drawing.Font("Rockwell", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            loadobjectdemo.Location = New Drawing.Point(154, 177)
            loadobjectdemo.Name = "loadobjectdemo"
            loadobjectdemo.Size = New Drawing.Size(246, 75)
            loadobjectdemo.TabIndex = 3
            loadobjectdemo.Text = "Load Object Demo"
            loadobjectdemo.UseVisualStyleBackColor = False
            ' 
            ' exit1
            ' 
            exit1.BackColor = Drawing.Color.Red
            exit1.Font = New Drawing.Font("Rockwell", 12.0F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            exit1.Location = New Drawing.Point(436, 177)
            exit1.Name = "exit1"
            exit1.Size = New Drawing.Size(246, 75)
            exit1.TabIndex = 4
            exit1.Text = "Exit"
            exit1.UseVisualStyleBackColor = False
            ' 
            ' j
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(800, 450)
            Controls.Add(exit1)
            Controls.Add(loadobjectdemo)
            Name = "j"
            Text = "Welcoming Form"
            ResumeLayout(False)

        End Sub

#End Region
        Private WithEvents loadobjectdemo As Windows.Forms.Button
        Private WithEvents exit1 As Windows.Forms.Button

        Private Sub loadobjectform_Click(sender As Object, e As EventArgs) Handles loadobjectdemo.Click
            Dim form2Instance As New Form2()
            form2Instance.Show()
        End Sub

        Private Sub button2_Click(sender As Object, e As EventArgs) Handles exit1.Click
            Me.Close()
        End Sub
    End Class
End Namespace

