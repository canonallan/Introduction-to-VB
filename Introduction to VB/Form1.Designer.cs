namespace Introduction_to_VB
{
    partial class Form1
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
            this.loadobjectdemo = new System.Windows.Forms.Button();
            this.exit1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loadobjectdemo
            // 
            this.loadobjectdemo.BackColor = System.Drawing.Color.Yellow;
            this.loadobjectdemo.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loadobjectdemo.Location = new System.Drawing.Point(154, 177);
            this.loadobjectdemo.Name = "loadobjectdemo";
            this.loadobjectdemo.Size = new System.Drawing.Size(246, 75);
            this.loadobjectdemo.TabIndex = 3;
            this.loadobjectdemo.Text = "Load Object Demo";
            this.loadobjectdemo.UseVisualStyleBackColor = false;
            this.loadobjectdemo.Click += new System.EventHandler(this.loadobjectform_Click);
            // 
            // exit1
            // 
            this.exit1.BackColor = System.Drawing.Color.Red;
            this.exit1.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit1.Location = new System.Drawing.Point(436, 177);
            this.exit1.Name = "exit1";
            this.exit1.Size = new System.Drawing.Size(246, 75);
            this.exit1.TabIndex = 4;
            this.exit1.Text = "Exit";
            this.exit1.UseVisualStyleBackColor = false;
            this.exit1.Click += new System.EventHandler(this.button2_Click);
            // 
            // j
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exit1);
            this.Controls.Add(this.loadobjectdemo);
            this.Name = "j";
            this.Text = "Welcoming Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button loadobjectdemo;
        private System.Windows.Forms.Button exit1;
    }
}

