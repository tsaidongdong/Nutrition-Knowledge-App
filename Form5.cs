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
using System.Text.RegularExpressions;

namespace project
{
    public partial class Form5 : Form
    {
        int find_number = -1;//儲存搜尋到的的第幾個
        string tmp_line;//暫存存下來的字串
        string[] food = new string[2085];//儲存food名
        string[] tmp_food = new string[4];//暫存切開的四個food
        string[] kind = new string[2085];//儲存食物屬於的種類
        string[] chinese_name = new string[2085];//中文名
        string[] english_name = new string[2085];//英文名
        string[] element = new string[2085];//儲存包含的元素

        string tmp_normal;//暫存normal存下來的資料
        string[] calories = new string[2085];//紀錄卡路里
        string[] water = new string[2085];//紀錄水分
        string[] protein = new string[2085];//蛋白質含量
        string[] crude_fat = new string[2085];//粗脂肪
        string[] saturated_fat = new string[2085];//飽和脂肪
        string[] ash = new string[2085];//灰分
        string[] carbohydrate = new string[2085];//總碳水化合物
        string[] fiber = new string[2085];//膳食纖維
        List<string> Sort = new List<string>();//這個分類的總食材
        public Form5(List<string> sort_name)
        {
            InitializeComponent();
            StreamReader food_txt = new StreamReader(@"Food.txt");//讀取food.txt
            StreamReader normal_txt = new StreamReader(@"Normal.txt");//讀取normal.txt
            richTextBox1.Multiline = true;
            richTextBox2.Multiline = true;
            for (int a = 0; a < 2085; a++)//切割food資料
            {
                tmp_line = food_txt.ReadLine();
                food[a] = tmp_line;
                tmp_food = Regex.Split(food[a], "=:=:=:=", RegexOptions.IgnoreCase);//切割暫存下來的food陣列
                kind[a] = tmp_food[0];
                chinese_name[a] = tmp_food[1];
                english_name[a] = tmp_food[2];
                element[a] = tmp_food[3];
                if(sort_name.Contains("其他類") &&a >= 1516) //其他類的分類
                {
                    Sort.Add(tmp_food[1]);
                }
                else if (sort_name.Contains(tmp_food[0]))
                {
                    Sort.Add(tmp_food[1]);
                }
            }


            for (int a = 0; a < 2085; a++)//切割normal資料
            {
                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                calories[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                water[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                protein[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                crude_fat[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                saturated_fat[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                ash[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                carbohydrate[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
                fiber[a] = tmp_food[3];

                tmp_normal = normal_txt.ReadLine();
                tmp_food = Regex.Split(tmp_normal, "-:-:-", RegexOptions.IgnoreCase);
            }
        }

        private void search_KeyDown(object sender, KeyEventArgs e)//顯示出資料
        {
            string imagefile;
            if (find_number != -1 && e.KeyCode == Keys.Return)//按enter查詢
            {
                e.SuppressKeyPress = true;
                label3.Text = chinese_name[find_number];
                label2.Text = english_name[find_number];
                imagefile = @"picture\" + chinese_name[find_number] + ".jpg";
                pictureBox1.Image = Image.FromFile(imagefile);
                richTextBox1.Text = "->" + kind[find_number] + "\n" + "->" + element[find_number];
                richTextBox2.Text = "->修正熱量:\n      " + calories[find_number] + "kcal/100g\n" +
                                    "->水分:\n      " + water[find_number] + "g/100g\n" +
                                    "->粗蛋白:\n      " + protein[find_number] + "g/100g\n" +
                                    "->粗脂肪:\n      " + crude_fat[find_number] + "g/100g\n" +
                                    "->飽和脂肪:\n      " + saturated_fat[find_number] + "g/100g\n" +
                                    "->灰分:\n      " + ash[find_number] + "g/100g\n" +
                                    "->總碳水化合物:\n      " + carbohydrate[find_number] + "g/100g\n" +
                                    "->膳食纖維:\n      " + fiber[find_number] + "g/100g\n";
            }
            find_number = -1;//讓他可以蒐下一個

        }

        private void search_TextChanged(object sender, EventArgs e)//找準確的item
        {
            for (int a = 0; a < 2085; a++)
            {
                if (chinese_name[a] == search.Text &&(Sort.Contains(search.Text)))//避免打到其他分類的食材
                {
                    find_number = a;
                }
            }

        }

        private void search_DropDown(object sender, EventArgs e)//過濾搜尋
        {
            search.Items.Clear();
            foreach(var x in Sort)
            {
                search.Items.Add(x);
            }
            string input;//the input of the search
            input = search.Text;
            for (int a = 0; a < 2085; a++)
            {
                if (!chinese_name[a].Contains(input))
                {
                    search.Items.Remove(chinese_name[a]);
                }
            }
        }

    }
}
