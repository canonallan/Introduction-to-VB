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
    public partial class Form1 : Form
    {
        
        private Form2 form2Instance;

        public Form1()
        {
            InitializeComponent();
        }

        private void loadobjectform_Click(object sender, EventArgs e)
        {
            
            form2Instance = new Form2();
            form2Instance.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }
    }
}