Imports System
Imports System.Drawing
Imports System.Windows.Forms

Namespace Introduction_to_VB
    Partial Class Form2
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <paramname="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            pictureBox1 = New Windows.Forms.PictureBox()
            loadpicture = New Windows.Forms.Button()
            [exit] = New Windows.Forms.Button()
            green = New Windows.Forms.RadioButton()
            blue = New Windows.Forms.RadioButton()
            red = New Windows.Forms.RadioButton()
            textBox1 = New Windows.Forms.TextBox()
            italic = New Windows.Forms.CheckBox()
            bold = New Windows.Forms.CheckBox()
            bolditalic = New Windows.Forms.CheckBox()
            garamond = New Windows.Forms.RadioButton()
            magneto = New Windows.Forms.RadioButton()
            tahoma = New Windows.Forms.RadioButton()
            displaytext = New Windows.Forms.Label()
            font = New Windows.Forms.Label()
            fontstyle = New Windows.Forms.Label()
            fontcolor = New Windows.Forms.Label()
            CType(pictureBox1, ComponentModel.ISupportInitialize).BeginInit()
            SuspendLayout()
            ' 
            ' pictureBox1
            ' 
            pictureBox1.Location = New Drawing.Point(77, 185)
            pictureBox1.Name = "pictureBox1"
            pictureBox1.Size = New Drawing.Size(149, 112)
            pictureBox1.TabIndex = 0
            pictureBox1.TabStop = False
            ' 
            ' loadpicture
            ' 
            loadpicture.BackColor = Drawing.Color.Yellow
            loadpicture.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            loadpicture.ForeColor = Drawing.Color.Black
            loadpicture.Location = New Drawing.Point(86, 337)
            loadpicture.Name = "loadpicture"
            loadpicture.Size = New Drawing.Size(155, 38)
            loadpicture.TabIndex = 1
            loadpicture.Text = "Load Picture"
            loadpicture.UseVisualStyleBackColor = False
            ' 
            ' exit
            ' 
            [exit].BackColor = Drawing.Color.Red
            [exit].Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            [exit].ForeColor = Drawing.Color.Black
            [exit].Location = New Drawing.Point(542, 337)
            [exit].Name = "exit"
            [exit].Size = New Drawing.Size(184, 38)
            [exit].TabIndex = 2
            [exit].Text = "Exit"
            [exit].UseVisualStyleBackColor = False
            ' 
            ' green
            ' 
            green.AutoSize = True
            green.BackColor = Drawing.Color.Green
            green.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            green.ForeColor = Drawing.Color.Black
            green.Location = New Drawing.Point(603, 160)
            green.Name = "green"
            green.Size = New Drawing.Size(73, 22)
            green.TabIndex = 4
            green.TabStop = True
            green.Text = "Green"
            green.UseVisualStyleBackColor = False
            ' 
            ' blue
            ' 
            blue.AutoSize = True
            blue.BackColor = Drawing.Color.Navy
            blue.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            blue.ForeColor = Drawing.Color.Black
            blue.Location = New Drawing.Point(603, 203)
            blue.Name = "blue"
            blue.Size = New Drawing.Size(59, 22)
            blue.TabIndex = 5
            blue.TabStop = True
            blue.Text = "Blue"
            blue.UseVisualStyleBackColor = False
            ' 
            ' red
            ' 
            red.AutoSize = True
            red.BackColor = Drawing.Color.Red
            red.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            red.ForeColor = Drawing.Color.Black
            red.Location = New Drawing.Point(603, 250)
            red.Name = "red"
            red.Size = New Drawing.Size(55, 22)
            red.TabIndex = 6
            red.TabStop = True
            red.Text = "Red"
            red.UseVisualStyleBackColor = False
            ' 
            ' textBox1
            ' 
            textBox1.Location = New Drawing.Point(62, 57)
            textBox1.Name = "textBox1"
            textBox1.Size = New Drawing.Size(214, 20)
            textBox1.TabIndex = 7
            ' 
            ' italic
            ' 
            italic.AutoSize = True
            italic.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
            italic.ForeColor = Drawing.Color.Black
            italic.Location = New Drawing.Point(369, 160)
            italic.Name = "italic"
            italic.Size = New Drawing.Size(59, 21)
            italic.TabIndex = 8
            italic.Text = "Italic"
            italic.UseVisualStyleBackColor = True
            ' 
            ' bold
            ' 
            bold.AutoSize = True
            bold.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            bold.ForeColor = Drawing.Color.Black
            bold.Location = New Drawing.Point(369, 208)
            bold.Name = "bold"
            bold.Size = New Drawing.Size(60, 22)
            bold.TabIndex = 9
            bold.Text = "Bold"
            bold.UseVisualStyleBackColor = True
            ' 
            ' bolditalic
            ' 
            bolditalic.AutoSize = True
            bolditalic.BackColor = Drawing.SystemColors.Control
            bolditalic.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold Or Drawing.FontStyle.Italic, Drawing.GraphicsUnit.Point, 0)
            bolditalic.ForeColor = Drawing.Color.Black
            bolditalic.Location = New Drawing.Point(369, 251)
            bolditalic.Name = "bolditalic"
            bolditalic.Size = New Drawing.Size(101, 23)
            bolditalic.TabIndex = 10
            bolditalic.Text = "Bold Italic"
            bolditalic.UseVisualStyleBackColor = False
            ' 
            ' garamond
            ' 
            garamond.AutoSize = True
            garamond.BackColor = Drawing.Color.Yellow
            garamond.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            garamond.ForeColor = Drawing.Color.Black
            garamond.Location = New Drawing.Point(359, 57)
            garamond.Name = "garamond"
            garamond.Size = New Drawing.Size(106, 22)
            garamond.TabIndex = 11
            garamond.TabStop = True
            garamond.Text = "Garamond"
            garamond.UseVisualStyleBackColor = False
            ' 
            ' magneto
            ' 
            magneto.AutoSize = True
            magneto.BackColor = Drawing.Color.Yellow
            magneto.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            magneto.ForeColor = Drawing.Color.Black
            magneto.Location = New Drawing.Point(486, 57)
            magneto.Name = "magneto"
            magneto.Size = New Drawing.Size(92, 22)
            magneto.TabIndex = 12
            magneto.TabStop = True
            magneto.Text = "Magneto"
            magneto.UseVisualStyleBackColor = False
            ' 
            ' tahoma
            ' 
            tahoma.AutoSize = True
            tahoma.BackColor = Drawing.Color.Yellow
            tahoma.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            tahoma.ForeColor = Drawing.Color.Black
            tahoma.Location = New Drawing.Point(616, 57)
            tahoma.Name = "tahoma"
            tahoma.Size = New Drawing.Size(87, 22)
            tahoma.TabIndex = 13
            tahoma.TabStop = True
            tahoma.Text = "Tahoma"
            tahoma.UseVisualStyleBackColor = False
            ' 
            ' displaytext
            ' 
            displaytext.AutoSize = True
            displaytext.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            displaytext.ForeColor = Drawing.Color.Black
            displaytext.Location = New Drawing.Point(92, 21)
            displaytext.Name = "displaytext"
            displaytext.Size = New Drawing.Size(101, 18)
            displaytext.TabIndex = 14
            displaytext.Text = "Display Text"
            ' 
            ' font
            ' 
            font.AutoSize = True
            font.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            font.ForeColor = Drawing.Color.Black
            font.Location = New Drawing.Point(356, 21)
            font.Name = "font"
            font.Size = New Drawing.Size(41, 18)
            font.TabIndex = 15
            font.Text = "Font"
            ' 
            ' fontstyle
            ' 
            fontstyle.AutoSize = True
            fontstyle.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            fontstyle.ForeColor = Drawing.Color.Black
            fontstyle.Location = New Drawing.Point(343, 123)
            fontstyle.Name = "fontstyle"
            fontstyle.Size = New Drawing.Size(81, 18)
            fontstyle.TabIndex = 16
            fontstyle.Text = "Font Style"
            ' 
            ' fontcolor
            ' 
            fontcolor.AutoSize = True
            fontcolor.Font = New Drawing.Font("Rockwell", 11.25F, Drawing.FontStyle.Bold, Drawing.GraphicsUnit.Point, 0)
            fontcolor.ForeColor = Drawing.Color.Black
            fontcolor.Location = New Drawing.Point(575, 113)
            fontcolor.Name = "fontcolor"
            fontcolor.Size = New Drawing.Size(87, 18)
            fontcolor.TabIndex = 17
            fontcolor.Text = "Font Color"
            ' 
            ' Form2
            ' 
            AutoScaleDimensions = New Drawing.SizeF(6.0F, 13.0F)
            AutoScaleMode = Windows.Forms.AutoScaleMode.Font
            ClientSize = New Drawing.Size(800, 450)
            Controls.Add(fontcolor)
            Controls.Add(fontstyle)
            Controls.Add(font)
            Controls.Add(displaytext)
            Controls.Add(tahoma)
            Controls.Add(magneto)
            Controls.Add(garamond)
            Controls.Add(bolditalic)
            Controls.Add(bold)
            Controls.Add(italic)
            Controls.Add(textBox1)
            Controls.Add(red)
            Controls.Add(blue)
            Controls.Add(green)
            Controls.Add([exit])
            Controls.Add(loadpicture)
            Controls.Add(pictureBox1)
            ForeColor = Drawing.Color.Red
            Name = "Form2"
            Text = "Form2"
            AddHandler Load, New EventHandler(AddressOf Form2_Load)
            CType(pictureBox1, ComponentModel.ISupportInitialize).EndInit()
            ResumeLayout(False)
            PerformLayout()

        End Sub

#End Region

        Private WithEvents pictureBox1 As Windows.Forms.PictureBox
        Private WithEvents loadpicture As Windows.Forms.Button
        Private WithEvents [exit] As Windows.Forms.Button
        Private WithEvents green As Windows.Forms.RadioButton
        Private WithEvents blue As Windows.Forms.RadioButton
        Private WithEvents red As Windows.Forms.RadioButton
        Private WithEvents textBox1 As Windows.Forms.TextBox
        Private WithEvents italic As Windows.Forms.CheckBox
        Private WithEvents bold As Windows.Forms.CheckBox
        Private WithEvents bolditalic As Windows.Forms.CheckBox
        Private WithEvents garamond As Windows.Forms.RadioButton
        Private WithEvents magneto As Windows.Forms.RadioButton
        Private WithEvents tahoma As Windows.Forms.RadioButton
        Private WithEvents displaytext As Windows.Forms.Label
        Private WithEvents font As Windows.Forms.Label
        Private WithEvents fontstyle As Windows.Forms.Label
        Private WithEvents fontcolor As Windows.Forms.Label

        Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' Place your code here
        End Sub

        Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
            ' Place your code here
        End Sub

        Private Sub loadpicture_Click(sender As Object, e As EventArgs) Handles loadpicture.Click
            Dim openFileDialog As New OpenFileDialog()
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif"

            If openFileDialog.ShowDialog() = DialogResult.OK Then
                pictureBox1.ImageLocation = openFileDialog.FileName
            End If
        End Sub

        Private Sub exit_Click(sender As Object, e As EventArgs) Handles [exit].Click
            Dim form1 As New Form1()
            form1.Show()
        End Sub

        Private Sub textBox1_TextChanged(sender As Object, e As EventArgs) Handles textBox1.TextChanged
            ' Place your code here
        End Sub

        Private Sub italic_CheckedChanged(sender As Object, e As EventArgs) Handles italic.CheckedChanged
            If italic.Checked Then


                textBox1.Font = New Font(textBox1.Font, fontstyle.Italic)
            Else
                textBox1.Font = New Font(textBox1.Font, textBox1.Font.Style And Not fontstyle.Italic)
            End If
        End Sub

        Private Sub bold_CheckedChanged(sender As Object, e As EventArgs) Handles bold.CheckedChanged
            If italic.Checked Then
                textBox1.Font = New Font(textBox1.Font, fontstyle.Italic)
            Else
                textBox1.Font = New Font(textBox1.Font, textBox1.Font.Style And Not fontstyle.Italic)
            End If
        End Sub

        Private Sub bolditalic_CheckedChanged(sender As Object, e As EventArgs) Handles bolditalic.CheckedChanged
            If bolditalic.Checked Then
                textBox1.Font = New Font(textBox1.Font, fontstyle.Bold Or fontstyle.Italic)
            Else
                textBox1.Font = New Font(textBox1.Font, textBox1.Font.Style And Not (fontstyle.Bold Or fontstyle.Italic))
            End If
        End Sub

        Private Sub garamond_CheckedChanged(sender As Object, e As EventArgs) Handles garamond.CheckedChanged
            If garamond.Checked Then
                textBox1.Font = New Font("Garamond", textBox1.Font.Size)
            End If
        End Sub

        Private Sub magneto_CheckedChanged(sender As Object, e As EventArgs) Handles magneto.CheckedChanged
            If magneto.Checked Then
                textBox1.Font = New Font("Magneto", textBox1.Font.Size)
            End If
        End Sub

        Private Sub tahoma_CheckedChanged(sender As Object, e As EventArgs) Handles tahoma.CheckedChanged
            If tahoma.Checked Then
                textBox1.Font = New Font("Tahoma", textBox1.Font.Size)
            End If
        End Sub

        Private Sub green_CheckedChanged(sender As Object, e As EventArgs) Handles green.CheckedChanged
            If green.Checked Then
                textBox1.ForeColor = Color.Green
            End If
        End Sub

        Private Sub blue_CheckedChanged(sender As Object, e As EventArgs) Handles blue.CheckedChanged
            If blue.Checked Then
                textBox1.ForeColor = Color.Blue
            End If
        End Sub

        Private Sub red_CheckedChanged(sender As Object, e As EventArgs) Handles red.CheckedChanged
            If red.Checked Then
                textBox1.ForeColor = Color.Red
            End If
        End Sub
    End Class
End Namespace
