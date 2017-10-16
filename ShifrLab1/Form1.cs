using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;

namespace ShifrLab1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        List<string> array = new List<string>();
        string key;
        string text;
        string alfa = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЪЫЬЭЮЯ";
        int temp;

        private int StrNum(char t)
        {
            int count = 0;
            foreach (string z in array)
            {
                if (z.IndexOf(t) != -1)
                {
                    temp = count;
                    return count;
                }
                count++;
            }
            return 1;
        }

        private int StbNum(char p)
        {
            int x;
            foreach (string z in array)
            {
                x = z.IndexOf(p);
                if (x != -1)
                {
                    temp = x;
                    return x;
                }
            }
            return 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            char[] temp = name.ToCharArray();
            name = Cesar.Encrypt(temp);
            textBox2.Text = name;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            char[] temp = name.ToCharArray();
            name = Losung.Encrypt(temp);
            textBox2.Text = name;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string temp = name;
            name = Plebey.Encrypt(temp);
            textBox2.Text = name;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string temp = name;
            name = Trisemus.Encrypt(temp);
            textBox2.Text = name;

           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                key = "кот";
                text = textBox1.Text.ToLower();
                text = text.Replace(" ", "");
                if (text.Length % 2 != 0)
                {
                    text = string.Format("{0}я", text);
                }
                
                for (int i = 0; i < textBox1.Text.Length; i++)
                    if (!key.Contains(textBox1.Text[i]))
                        key += textBox1.Text[i];

                alfa = alfa.ToLower();

                string str1 = key.ToLower();
                for (int i = 0; i < alfa.Length; i++)
                {
                    if (!str1.Contains(alfa[i]))
                        str1 += alfa[i];
                }

                for (int i = 0; i < str1.Length; i += 8)
                    array.Add(str1.Substring(i, 8));

                for (int j = 0; j < array.Count; j++)
                {
                    textBox2.Text += array[j];
                    textBox2.Text += Environment.NewLine;
                }
                string shifr = "";
                int count = 0;

                for (int k = 0; k < text.Length; k += 2)
                {

                    if (StrNum(text[k]) == StrNum(text[k + 1]))
                    {
                        string str2 = array[temp];

                        count = str2.IndexOf(text[k]);
                        if (count == 7)
                            shifr += str2[0];
                        else shifr += str2[count + 1];

                        count = str2.IndexOf(text[k + 1]);
                        if (count == 7)
                            shifr += str2[0];
                        else shifr += str2[count + 1];

                    }
                    else if (StbNum(text[k]) == StbNum(text[k + 1]))
                    {
                        count = 0;
                        foreach (string f in array)
                        {
                            if (f[temp] == text[k])
                            {
                                if (count == 3)
                                    shifr += array[0][temp];
                                else shifr += array[count + 1][temp];
                            }
                            if (f[temp] == text[k + 1])
                            {
                                if (count == 3)
                                    shifr += array[0][temp];
                                else shifr += array[count + 1][temp];

                            }
                            count++;
                        }
                    }
                    else
                    {
                        shifr += array[StrNum(text[k])][StbNum(text[k + 1])];
                        shifr += array[StrNum(text[k + 1])][StbNum(text[k])];

                    }
                }
                textBox2.Text = shifr;
            }

            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string temp = name;
            name = Vigener.Encode(temp, "КОТ");
            textBox2.Text = name;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
      

       
          
}
