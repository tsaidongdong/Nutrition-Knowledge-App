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
    public partial class Form2 : Form
    {
        private int[] Female_cal = new int[] {1500,1700,1950,2150,1450,1650,1900,2100,1400,1600,1800,2000,1300,1500,1700,1700 };
        private int[]Male_cal =new int[] {1850,2150,2400,2700,1800,2100,2400,2650,1700,1950,2250,2500,1650,1900,2150,2150};
        public Form2()
        {
            InitializeComponent();
            this.Text = "營養攝取介面";
            this.Size = new Size(650, 400);
           
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            RDA.Visible = false;
        }

        private void Calculate_Click(object sender, EventArgs e)
        {   int Age = 0;
           double Height, Weight,Bmi;
            if (gender.SelectedItem == null||Exercise.SelectedItem==null ||
                 age.Text=="" || height.Text == "" || weight.Text == "")
            {
                MessageBox.Show("please input all information");
            }
            else
            {  
                try
                {
                    Age = int.Parse(age.Text);
                    Height = double.Parse(height.Text);
                    Weight = double.Parse(weight.Text);
                }
                catch
                {
                    MessageBox.Show("please input correct information");
                    return;
                }
                //Bmi
                Bmi = (Weight / (Height / 100) / (Height / 100));
                BMI.Text ="BMI:"+Bmi.ToString("f2");
                if (Bmi <= 16) BMI.ForeColor = Color.LightBlue;
                else if (Bmi>16 && Bmi < 18.5) BMI.ForeColor = Color.White;
                else if(Bmi >=18.5 && Bmi < 24) BMI.ForeColor = Color.Yellow;
                else if (Bmi >=24 && Bmi < 27) BMI.ForeColor = Color.LightPink;
                else if (Bmi >=27 && Bmi < 30) BMI.ForeColor = Color.Red;
                else if (Bmi >= 30 && Bmi < 35) BMI.ForeColor = Color.DarkRed;
                else   BMI.ForeColor = Color.Purple;

                int Ex = Exercise.SelectedIndex;
                //male
                if (gender.SelectedItem.ToString() == "Male")
                {
                   if(Age<=30 && Age > 18)
                    {
                        test.Text = "Need: " + Male_cal[Ex].ToString() + "大卡";
                    }
                    else if (Age <= 50 && Age > 30)
                    {
                        test.Text = "Need: " + Male_cal[4+Ex].ToString() + "大卡";
                    }
                    else if (Age <= 70 && Age > 50)
                    {
                        test.Text = "Need: " + Male_cal[8+Ex].ToString() + "大卡";
                    }
                    else
                    {
                        test.Text = "Need: " + Male_cal[12 + Ex].ToString() + "大卡";
                    }
                }
                //female
                else
                {
                    if (Age <= 30 && Age > 18)
                    {
                        test.Text = "Need: "+Female_cal[Ex].ToString() + "大卡";
                    }
                    else if (Age <= 50 && Age > 30)
                    {
                        test.Text = "Need: " + Female_cal[4 + Ex].ToString() + "大卡";
                    }
                    else if (Age <= 70 && Age > 50)
                    {
                        test.Text = "Need: " + Female_cal[8 + Ex].ToString() + "大卡";
                    }
                    else
                    {
                        test.Text = "Need: " + Female_cal[12 + Ex].ToString() + "大卡";
                    }
                }
                RDA_cal();
                RDA.Visible = true;
            }
           
        }
        private void RDA_cal()
        {   
            int cal =int.Parse (test.Text.Replace("Need: ", "").Replace("大卡", ""));
            Console.WriteLine(cal);
            if (cal < 1500)
            {
                rice.Text = "1.5";
                meat.Text = "3";
                Milk.Text = "1.5";
                veg.Text = "3";
                fruit.Text = "2";
                peanut.Text = "4";
                rice.Size = new Size(2 * 20, 25);
                meat.Size = new Size(3 * 20, 25);
                Milk.Size = new Size(2* 20, 25);
                veg.Size = new Size(3 * 20, 25);
                fruit.Size = new Size(2 * 20, 25);
                peanut.Size = new Size(4 * 20, 25);
            }
            else if(cal >= 1500 && cal < 1800)
            {
                rice.Text = "2.5";
                meat.Text = "4";
                Milk.Text = "1.5";
                veg.Text = "3";
                fruit.Text = "2";
                peanut.Text = "4";
                rice.Size = new Size(2 * 20, 25);
                meat.Size = new Size(4 * 20, 25);
                Milk.Size = new Size( 2 * 20, 25);
                veg.Size = new Size(3 * 20, 25);
                fruit.Size = new Size(2 * 20, 25);
                peanut.Size = new Size(4 * 20, 25);
            }
            else if (cal >= 1800 && cal < 2000)
            {
                rice.Text = "3";
                meat.Text = "5";
                Milk.Text = "1.5";
                veg.Text = "3";
                fruit.Text = "2";
                peanut.Text = "5";
                rice.Size = new Size(3 * 20, 25);
                meat.Size = new Size(5 * 20, 25);
                Milk.Size = new Size( 2 * 20, 25);
                veg.Size = new Size(3 * 20, 25);
                fruit.Size = new Size(2 * 20, 25);
                peanut.Size = new Size(5 * 20, 25);
            }
            else if (cal >= 2000 && cal < 2200)
            {
                rice.Text = "3";
                meat.Text = "6";
                Milk.Text = "1.5";
                veg.Text = "4";
                fruit.Text = "3";
                peanut.Text = "6";
                rice.Size = new Size(3 * 20, 25);
                meat.Size = new Size(6 * 20, 25);
                Milk.Size = new Size( 2 * 20, 25);
                veg.Size = new Size(4 * 20, 25);
                fruit.Size = new Size(3 * 20, 25);
                peanut.Size = new Size(6 * 20, 25);
            }
            else if (cal >= 2200 && cal < 2500)
            {
                rice.Text = "3.5";
                meat.Text = "6";
                Milk.Text = "1.5";
                veg.Text = "4";
                fruit.Text = "3";
                peanut.Text = "6";
                rice.Size = new Size(3 * 20, 25);
                meat.Size = new Size(6 * 20, 25);
                Milk.Size = new Size( 2 * 20, 25);
                veg.Size = new Size(4* 20, 25);
                fruit.Size = new Size(3 * 20, 25);
                peanut.Size = new Size(6 * 20, 25);
            }
            else if (cal >= 2500 && cal<2700)
            {
                rice.Text = "4";
                meat.Text = "7";
                Milk.Text = "1.5";
                veg.Text = "5";
                fruit.Text = "4";
                peanut.Text = "7";
                rice.Size = new Size(4 * 20, 25);
                meat.Size = new Size(7 * 20, 25);
                Milk.Size = new Size( 2 * 20, 25);
                veg.Size = new Size(3 * 20, 25);
                fruit.Size = new Size(4 * 20, 25);
                peanut.Size = new Size(7 * 20, 25);
            }
            else if (cal >= 2700)
            {
                rice.Text = "4";
                meat.Text = "8";
                Milk.Text = "2";
                veg.Text = "5";
                fruit.Text = "4";
                peanut.Text = "8";
                rice.Size = new Size(4 * 20, 25);
                meat.Size = new Size(8 * 20, 25);
                Milk.Size = new Size(2 * 20, 25);
                veg.Size = new Size(5 * 20, 25);
                fruit.Size = new Size(4 * 20, 25);
                peanut.Size = new Size(8 * 20, 25);
            }
            Console.WriteLine(Milk.Text);
        }
        
    }
}
