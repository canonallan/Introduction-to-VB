using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduction_to_VB
{
    public partial class Form2 : Form
    {
        public static Form2 Instance;
        public Form2()
        {

            InitializeComponent();
            Instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

      
        

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (blue.Checked)
            {
               
                textBox1.ForeColor = Color.Blue;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (red.Checked)
            {
               
                textBox1.ForeColor = Color.Red;
            }
        }

        private void radioButton3_CheckedChanged_1(object sender, EventArgs e)
        {
            if (tahoma.Checked)
            {
                
                textBox1.Font = new Font("Tahoma", textBox1.Font.Size);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (bolditalic.Checked)
            {
               
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold | FontStyle.Italic);
            }
            
            else if (bold.Checked)
            {
                
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
                   
            else if (italic.Checked)
            {
                       
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            else
            {
                  
                textBox1.Font = new Font(textBox1.Font, FontStyle.Regular);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void loadpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.jpg, *.jpeg, *.png, *.gif) | *.jpg; *.jpeg; *.png; *.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
               
                pictureBox1.ImageLocation = openFileDialog.FileName;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void garamond_CheckedChanged(object sender, EventArgs e)
        {
            if (garamond.Checked) 
            {
               
                textBox1.Font = new Font("Garamond", textBox1.Font.Size);
            }
        }

        private void magneto_CheckedChanged(object sender, EventArgs e)
        {
            if (magneto.Checked) 
            {
               
                textBox1.Font = new Font("Magneto", textBox1.Font.Size);
            }
        }

        private void italic_CheckedChanged(object sender, EventArgs e)
        {
            if (italic.Checked) 
            {
               
                textBox1.Font = new Font(textBox1.Font, FontStyle.Italic);
            }
            else
            {
                
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Italic);
            }
        }

        private void bold_CheckedChanged(object sender, EventArgs e)
        {
            if (bold.Checked) 
            {
                
                textBox1.Font = new Font(textBox1.Font, FontStyle.Bold);
            }
            else
            {
                
                textBox1.Font = new Font(textBox1.Font, textBox1.Font.Style & ~FontStyle.Bold);
            }
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void green_CheckedChanged(object sender, EventArgs e)
        {
            if (green.Checked)
            {
                
                textBox1.ForeColor = Color.Green;
            }
        }
    }
}
