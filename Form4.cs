using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    
    public partial class Form4 : Form
    {
        List<string> tmp =new List<string>();//宣告list儲存種類
        public Form4()
        {
            InitializeComponent();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tmp.Add("穀物類");
            tmp.Add("澱粉類");
            Form5 f = new Form5(tmp);//傳要sort的分類進去
            f.Show(this);//設定Form2為Form1的上層，並開啟Form2視窗。由於在Form1的程式碼內使用this，所以this為Form1的物件本身
            f.TopMost = true;
            tmp.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tmp.Add("肉類");
            tmp.Add("蛋類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            tmp.Add("水果類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tmp.Add("蔬菜類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            tmp.Add("堅果及種子類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            tmp.Add("豆類"); tmp.Add("乳品類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            tmp.Add("藻類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            tmp.Add("魚貝類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            tmp.Add("菇類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            tmp.Add("其他類");
            Form5 f = new Form5(tmp);
            f.Show(this);
            f.TopMost = true;
            tmp.Clear();
        }
    }
}
