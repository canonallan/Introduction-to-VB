<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SalesPerson
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lstSalespersons = New System.Windows.Forms.ListBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDailySales = New System.Windows.Forms.TextBox()
        Me.button = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(151, 18)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Salesperson Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(169, 115)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(175, 20)
        Me.txtName.TabIndex = 1
        '
        'lstSalespersons
        '
        Me.lstSalespersons.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstSalespersons.FormattingEnabled = True
        Me.lstSalespersons.ItemHeight = 16
        Me.lstSalespersons.Location = New System.Drawing.Point(369, 77)
        Me.lstSalespersons.Name = "lstSalespersons"
        Me.lstSalespersons.Size = New System.Drawing.Size(593, 292)
        Me.lstSalespersons.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(92, 18)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Daily Sales"
        '
        'txtDailySales
        '
        Me.txtDailySales.Location = New System.Drawing.Point(169, 155)
        Me.txtDailySales.Name = "txtDailySales"
        Me.txtDailySales.Size = New System.Drawing.Size(175, 20)
        Me.txtDailySales.TabIndex = 4
        '
        'button
        '
        Me.button.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button.Location = New System.Drawing.Point(123, 220)
        Me.button.Name = "button"
        Me.button.Size = New System.Drawing.Size(100, 31)
        Me.button.TabIndex = 5
        Me.button.Text = "Calculate"
        Me.button.UseVisualStyleBackColor = True
        '
        'SalesPerson
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(974, 450)
        Me.Controls.Add(Me.button)
        Me.Controls.Add(Me.txtDailySales)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lstSalespersons)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label1)
        Me.Name = "SalesPerson"
        Me.Text = "SalesPerson"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents lstSalespersons As ListBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtDailySales As TextBox
    Friend WithEvents button As Button
End Class
