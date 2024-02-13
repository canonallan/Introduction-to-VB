namespace Introduction_to_VB
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loadpicture = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.RadioButton();
            this.blue = new System.Windows.Forms.RadioButton();
            this.red = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.italic = new System.Windows.Forms.CheckBox();
            this.bold = new System.Windows.Forms.CheckBox();
            this.bolditalic = new System.Windows.Forms.CheckBox();
            this.garamond = new System.Windows.Forms.RadioButton();
            this.magneto = new System.Windows.Forms.RadioButton();
            this.tahoma = new System.Windows.Forms.RadioButton();
            this.displaytext = new System.Windows.Forms.Label();
            this.font = new System.Windows.Forms.Label();
            this.fontstyle = new System.Windows.Forms.Label();
            this.fontcolor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(77, 185);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(149, 112);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // loadpicture
            // 
            this.loadpicture.BackColor = System.Drawing.Color.Yellow;
            this.loadpicture.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadpicture.ForeColor = System.Drawing.Color.Black;
            this.loadpicture.Location = new System.Drawing.Point(86, 337);
            this.loadpicture.Name = "loadpicture";
            this.loadpicture.Size = new System.Drawing.Size(155, 38);
            this.loadpicture.TabIndex = 1;
            this.loadpicture.Text = "Load Picture";
            this.loadpicture.UseVisualStyleBackColor = false;
            this.loadpicture.Click += new System.EventHandler(this.loadpicture_Click);
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Red;
            this.exit.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.ForeColor = System.Drawing.Color.Black;
            this.exit.Location = new System.Drawing.Point(542, 337);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(184, 38);
            this.exit.TabIndex = 2;
            this.exit.Text = "Exit";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // green
            // 
            this.green.AutoSize = true;
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.green.ForeColor = System.Drawing.Color.Black;
            this.green.Location = new System.Drawing.Point(603, 160);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(73, 22);
            this.green.TabIndex = 4;
            this.green.TabStop = true;
            this.green.Text = "Green";
            this.green.UseVisualStyleBackColor = false;
            this.green.CheckedChanged += new System.EventHandler(this.green_CheckedChanged);
            // 
            // blue
            // 
            this.blue.AutoSize = true;
            this.blue.BackColor = System.Drawing.Color.Navy;
            this.blue.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.blue.ForeColor = System.Drawing.Color.Black;
            this.blue.Location = new System.Drawing.Point(603, 203);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(59, 22);
            this.blue.TabIndex = 5;
            this.blue.TabStop = true;
            this.blue.Text = "Blue";
            this.blue.UseVisualStyleBackColor = false;
            this.blue.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // red
            // 
            this.red.AutoSize = true;
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.red.ForeColor = System.Drawing.Color.Black;
            this.red.Location = new System.Drawing.Point(603, 250);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(55, 22);
            this.red.TabIndex = 6;
            this.red.TabStop = true;
            this.red.Text = "Red";
            this.red.UseVisualStyleBackColor = false;
            this.red.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 57);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(214, 20);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // italic
            // 
            this.italic.AutoSize = true;
            this.italic.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italic.ForeColor = System.Drawing.Color.Black;
            this.italic.Location = new System.Drawing.Point(369, 160);
            this.italic.Name = "italic";
            this.italic.Size = new System.Drawing.Size(59, 21);
            this.italic.TabIndex = 8;
            this.italic.Text = "Italic";
            this.italic.UseVisualStyleBackColor = true;
            this.italic.CheckedChanged += new System.EventHandler(this.italic_CheckedChanged);
            // 
            // bold
            // 
            this.bold.AutoSize = true;
            this.bold.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bold.ForeColor = System.Drawing.Color.Black;
            this.bold.Location = new System.Drawing.Point(369, 208);
            this.bold.Name = "bold";
            this.bold.Size = new System.Drawing.Size(60, 22);
            this.bold.TabIndex = 9;
            this.bold.Text = "Bold";
            this.bold.UseVisualStyleBackColor = true;
            this.bold.CheckedChanged += new System.EventHandler(this.bold_CheckedChanged);
            // 
            // bolditalic
            // 
            this.bolditalic.AutoSize = true;
            this.bolditalic.BackColor = System.Drawing.SystemColors.Control;
            this.bolditalic.Font = new System.Drawing.Font("Rockwell", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bolditalic.ForeColor = System.Drawing.Color.Black;
            this.bolditalic.Location = new System.Drawing.Point(369, 251);
            this.bolditalic.Name = "bolditalic";
            this.bolditalic.Size = new System.Drawing.Size(101, 23);
            this.bolditalic.TabIndex = 10;
            this.bolditalic.Text = "Bold Italic";
            this.bolditalic.UseVisualStyleBackColor = false;
            this.bolditalic.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // garamond
            // 
            this.garamond.AutoSize = true;
            this.garamond.BackColor = System.Drawing.Color.Yellow;
            this.garamond.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.garamond.ForeColor = System.Drawing.Color.Black;
            this.garamond.Location = new System.Drawing.Point(359, 57);
            this.garamond.Name = "garamond";
            this.garamond.Size = new System.Drawing.Size(106, 22);
            this.garamond.TabIndex = 11;
            this.garamond.TabStop = true;
            this.garamond.Text = "Garamond";
            this.garamond.UseVisualStyleBackColor = false;
            this.garamond.CheckedChanged += new System.EventHandler(this.garamond_CheckedChanged);
            // 
            // magneto
            // 
            this.magneto.AutoSize = true;
            this.magneto.BackColor = System.Drawing.Color.Yellow;
            this.magneto.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magneto.ForeColor = System.Drawing.Color.Black;
            this.magneto.Location = new System.Drawing.Point(486, 57);
            this.magneto.Name = "magneto";
            this.magneto.Size = new System.Drawing.Size(92, 22);
            this.magneto.TabIndex = 12;
            this.magneto.TabStop = true;
            this.magneto.Text = "Magneto";
            this.magneto.UseVisualStyleBackColor = false;
            this.magneto.CheckedChanged += new System.EventHandler(this.magneto_CheckedChanged);
            // 
            // tahoma
            // 
            this.tahoma.AutoSize = true;
            this.tahoma.BackColor = System.Drawing.Color.Yellow;
            this.tahoma.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tahoma.ForeColor = System.Drawing.Color.Black;
            this.tahoma.Location = new System.Drawing.Point(616, 57);
            this.tahoma.Name = "tahoma";
            this.tahoma.Size = new System.Drawing.Size(87, 22);
            this.tahoma.TabIndex = 13;
            this.tahoma.TabStop = true;
            this.tahoma.Text = "Tahoma";
            this.tahoma.UseVisualStyleBackColor = false;
            this.tahoma.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged_1);
            // 
            // displaytext
            // 
            this.displaytext.AutoSize = true;
            this.displaytext.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displaytext.ForeColor = System.Drawing.Color.Black;
            this.displaytext.Location = new System.Drawing.Point(92, 21);
            this.displaytext.Name = "displaytext";
            this.displaytext.Size = new System.Drawing.Size(101, 18);
            this.displaytext.TabIndex = 14;
            this.displaytext.Text = "Display Text";
            // 
            // font
            // 
            this.font.AutoSize = true;
            this.font.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.font.ForeColor = System.Drawing.Color.Black;
            this.font.Location = new System.Drawing.Point(356, 21);
            this.font.Name = "font";
            this.font.Size = new System.Drawing.Size(41, 18);
            this.font.TabIndex = 15;
            this.font.Text = "Font";
            this.font.Click += new System.EventHandler(this.label1_Click);
            // 
            // fontstyle
            // 
            this.fontstyle.AutoSize = true;
            this.fontstyle.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontstyle.ForeColor = System.Drawing.Color.Black;
            this.fontstyle.Location = new System.Drawing.Point(343, 123);
            this.fontstyle.Name = "fontstyle";
            this.fontstyle.Size = new System.Drawing.Size(81, 18);
            this.fontstyle.TabIndex = 16;
            this.fontstyle.Text = "Font Style";
            // 
            // fontcolor
            // 
            this.fontcolor.AutoSize = true;
            this.fontcolor.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fontcolor.ForeColor = System.Drawing.Color.Black;
            this.fontcolor.Location = new System.Drawing.Point(575, 113);
            this.fontcolor.Name = "fontcolor";
            this.fontcolor.Size = new System.Drawing.Size(87, 18);
            this.fontcolor.TabIndex = 17;
            this.fontcolor.Text = "Font Color";
            this.fontcolor.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fontcolor);
            this.Controls.Add(this.fontstyle);
            this.Controls.Add(this.font);
            this.Controls.Add(this.displaytext);
            this.Controls.Add(this.tahoma);
            this.Controls.Add(this.magneto);
            this.Controls.Add(this.garamond);
            this.Controls.Add(this.bolditalic);
            this.Controls.Add(this.bold);
            this.Controls.Add(this.italic);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.red);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.green);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.loadpicture);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button loadpicture;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.RadioButton green;
        private System.Windows.Forms.RadioButton blue;
        private System.Windows.Forms.RadioButton red;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.CheckBox italic;
        private System.Windows.Forms.CheckBox bold;
        private System.Windows.Forms.CheckBox bolditalic;
        private System.Windows.Forms.RadioButton garamond;
        private System.Windows.Forms.RadioButton magneto;
        private System.Windows.Forms.RadioButton tahoma;
        private System.Windows.Forms.Label displaytext;
        private System.Windows.Forms.Label font;
        private System.Windows.Forms.Label fontstyle;
        private System.Windows.Forms.Label fontcolor;
    }
}