<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DiagnosisForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim PrintDocument1 As System.Drawing.Printing.PrintDocument
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DiagnosisForm))
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DiagnosisDGV = New System.Windows.Forms.DataGridView()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PatIdCb = New System.Windows.Forms.ComboBox()
        Me.DiagTb = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.MedicineTb = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SymptomsTb = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DiagId = New System.Windows.Forms.MaskedTextBox()
        Me.PatNameTb = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TreatCb = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CostTb = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.FlowLayoutPanel2.SuspendLayout()
        CType(Me.DiagnosisDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.BackColor = System.Drawing.SystemColors.Highlight
        Me.FlowLayoutPanel2.Controls.Add(Me.PictureBox1)
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(200, 132)
        Me.FlowLayoutPanel2.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(767, -1)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "X"
        '
        'DiagnosisDGV
        '
        Me.DiagnosisDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DiagnosisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DiagnosisDGV.GridColor = System.Drawing.Color.DimGray
        Me.DiagnosisDGV.Location = New System.Drawing.Point(421, 65)
        Me.DiagnosisDGV.Name = "DiagnosisDGV"
        Me.DiagnosisDGV.Size = New System.Drawing.Size(571, 477)
        Me.DiagnosisDGV.TabIndex = 82
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button7.FlatAppearance.BorderSize = 0
        Me.Button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button7.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.ForeColor = System.Drawing.Color.White
        Me.Button7.Location = New System.Drawing.Point(340, 539)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 37)
        Me.Button7.TabIndex = 81
        Me.Button7.Text = "Delete"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button6.FlatAppearance.BorderSize = 0
        Me.Button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button6.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(282, 539)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(52, 37)
        Me.Button6.TabIndex = 80
        Me.Button6.Text = "Edit"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button3.FlatAppearance.BorderSize = 0
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(207, 539)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(64, 37)
        Me.Button3.TabIndex = 79
        Me.Button3.Text = "Add"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.RoyalBlue
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(203, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(795, 25)
        Me.Panel1.TabIndex = 71
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.Highlight
        Me.FlowLayoutPanel1.Controls.Add(Me.FlowLayoutPanel2)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(203, 624)
        Me.FlowLayoutPanel1.TabIndex = 70
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Adobe Fan Heiti Std B", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Crimson
        Me.Label1.Location = New System.Drawing.Point(465, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 26)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "DIAGNOSIS"
        '
        'PatIdCb
        '
        Me.PatIdCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatIdCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.PatIdCb.FormattingEnabled = True
        Me.PatIdCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.PatIdCb.Location = New System.Drawing.Point(220, 163)
        Me.PatIdCb.Name = "PatIdCb"
        Me.PatIdCb.Size = New System.Drawing.Size(121, 28)
        Me.PatIdCb.TabIndex = 92
        Me.PatIdCb.Text = "PatientId"
        '
        'DiagTb
        '
        Me.DiagTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.DiagTb.Location = New System.Drawing.Point(220, 400)
        Me.DiagTb.Name = "DiagTb"
        Me.DiagTb.Size = New System.Drawing.Size(164, 20)
        Me.DiagTb.TabIndex = 90
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label7.Location = New System.Drawing.Point(220, 377)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 20)
        Me.Label7.TabIndex = 89
        Me.Label7.Text = "Diagnosis:"
        '
        'MedicineTb
        '
        Me.MedicineTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.MedicineTb.Location = New System.Drawing.Point(220, 343)
        Me.MedicineTb.Name = "MedicineTb"
        Me.MedicineTb.Size = New System.Drawing.Size(164, 20)
        Me.MedicineTb.TabIndex = 88
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label6.Location = New System.Drawing.Point(224, 316)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 87
        Me.Label6.Text = "Medicines"
        '
        'SymptomsTb
        '
        Me.SymptomsTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.SymptomsTb.Location = New System.Drawing.Point(220, 283)
        Me.SymptomsTb.Name = "SymptomsTb"
        Me.SymptomsTb.Size = New System.Drawing.Size(164, 20)
        Me.SymptomsTb.TabIndex = 86
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label5.Location = New System.Drawing.Point(225, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 20)
        Me.Label5.TabIndex = 85
        Me.Label5.Text = "Symptoms:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label4.Location = New System.Drawing.Point(225, 104)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(109, 20)
        Me.Label4.TabIndex = 84
        Me.Label4.Text = "DiagnosisId:"
        '
        'DiagId
        '
        Me.DiagId.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.DiagId.Location = New System.Drawing.Point(220, 127)
        Me.DiagId.Name = "DiagId"
        Me.DiagId.Size = New System.Drawing.Size(164, 20)
        Me.DiagId.TabIndex = 83
        '
        'PatNameTb
        '
        Me.PatNameTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.PatNameTb.Enabled = False
        Me.PatNameTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PatNameTb.Location = New System.Drawing.Point(220, 217)
        Me.PatNameTb.Name = "PatNameTb"
        Me.PatNameTb.Size = New System.Drawing.Size(164, 24)
        Me.PatNameTb.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label3.Location = New System.Drawing.Point(223, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 20)
        Me.Label3.TabIndex = 93
        Me.Label3.Text = "PatientName:"
        '
        'TreatCb
        '
        Me.TreatCb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TreatCb.ForeColor = System.Drawing.SystemColors.Highlight
        Me.TreatCb.FormattingEnabled = True
        Me.TreatCb.Items.AddRange(New Object() {"Male", "Female"})
        Me.TreatCb.Location = New System.Drawing.Point(220, 426)
        Me.TreatCb.Name = "TreatCb"
        Me.TreatCb.Size = New System.Drawing.Size(121, 28)
        Me.TreatCb.TabIndex = 95
        Me.TreatCb.Text = "Treatment:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.Highlight
        Me.Label8.Location = New System.Drawing.Point(220, 457)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 20)
        Me.Label8.TabIndex = 96
        Me.Label8.Text = "Cost:"
        '
        'CostTb
        '
        Me.CostTb.BackColor = System.Drawing.SystemColors.InactiveBorder
        Me.CostTb.Enabled = False
        Me.CostTb.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CostTb.Location = New System.Drawing.Point(220, 480)
        Me.CostTb.Name = "CostTb"
        Me.CostTb.Size = New System.Drawing.Size(164, 24)
        Me.CostTb.TabIndex = 97
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(297, 582)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 37)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "Logout"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.Highlight
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Lucida Fax", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(575, 566)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 37)
        Me.Button2.TabIndex = 99
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PrintDocument1
        '
        PrintDocument1.OriginAtMargins = True
        AddHandler PrintDocument1.PrintPage, AddressOf Me.PrintDocument1_PrintPage
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.UseAntiAlias = True
        Me.PrintPreviewDialog1.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(170, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 19
        Me.PictureBox1.TabStop = False
        '
        'DiagnosisForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(998, 624)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CostTb)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TreatCb)
        Me.Controls.Add(Me.PatNameTb)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PatIdCb)
        Me.Controls.Add(Me.DiagTb)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.MedicineTb)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SymptomsTb)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DiagId)
        Me.Controls.Add(Me.DiagnosisDGV)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "DiagnosisForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DiagnosisForm"
        Me.FlowLayoutPanel2.ResumeLayout(False)
        CType(Me.DiagnosisDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents FlowLayoutPanel2 As FlowLayoutPanel
    Friend WithEvents Label2 As Label
    Friend WithEvents DiagnosisDGV As DataGridView
    Friend WithEvents Button7 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Label1 As Label
    Friend WithEvents PatIdCb As ComboBox
    Friend WithEvents DiagTb As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents MedicineTb As MaskedTextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents SymptomsTb As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents DiagId As MaskedTextBox
    Friend WithEvents PatNameTb As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TreatCb As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CostTb As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
    Friend WithEvents PictureBox1 As PictureBox
End Class
