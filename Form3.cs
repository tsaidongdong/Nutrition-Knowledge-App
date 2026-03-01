using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace project
{
    public partial class Form3 : Form
    {
        
        public Form3()
        {
            InitializeComponent();

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 f = new Form4();
            f.Show(this);
            f.TopMost = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show(this);
            f.TopMost = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show(this);
            f.TopMost = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            pictureBox3.Visible = false;
            button4.Visible = false;
        }
    }
}
