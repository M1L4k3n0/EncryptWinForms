using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            string text = Box1.Text;
            string key = Box1Key.Text;
            string cipherText = Odinarnaya.Encipher(text, key, '-');
            Box1Ans.Text = cipherText;

            //2
            BlochnayaOdinarnaya bl = new BlochnayaOdinarnaya();
            bl.SetKey(Box2key.Text);
            Box2Ans.Text = bl.Encrypt(Box2.Text);

            //3

            string st = Box3.Text;            
            char[] starr = st.ToCharArray();
            char[,] matrix = new char[4, 6];
            int k = 0;
            for(int i = 0; i < 4; i++)
            {
                for(int j=0; j < 6; j++)
                {
                       
                    if (k == starr.Length)
                    {
                        k = starr.Length;
                        matrix[i, j] = '_';
                    }
                    else
                    {
                        matrix[i, j] = st[k];
                        k++;
                    }
                    Console.Write(string.Format("{0} ", matrix[i, j]));

                }
                Console.WriteLine();
            }
            string ans = "";

               
                for (int row = 0; row < 4; row++)
                {
                    ans = string.Format("{0}{1}", ans, matrix[row, 0]);
                   
                }
                for (int row = 0; row < 4; row++)
                {
                    ans = string.Format("{0}{1}", ans, matrix[row, 1]);

                }
                for (int row = 0; row < 4; row++)
                {
                    ans = string.Format("{0}{1}", ans, matrix[row, 2]);

                }
                for (int row = 0; row < 4; row++)
                {
                    ans = string.Format("{0}{1}", ans, matrix[row, 3]);

                }
                for (int row = 0; row < 4; row++)
                {
                    ans = string.Format("{0}{1}", ans, matrix[row, 4]);

                }
                for (int row = 0; row < 4; row++)
                {
                    ans = string.Format("{0}{1}", ans, matrix[row, 5]);

                }



            Box3Ans.Text = ans;

            //5
            string[] buf = new string[5] {Box5_1.Text, Box5_2.Text, Box5_3.Text, Box5_4.Text, Box5_5.Text};
            string[] output = Povorot.Calculate(buf);
            Box5Ans_1.Text = output[0];
            Box5Ans_2.Text = output[1];
            Box5Ans_3.Text = output[2];
            Box5Ans_4.Text = output[3];


            //6
            Box6ans.Text = Kvadrat.Encrypt(Box6.Text);

            //7
            Box7Ans.Text = Dvoynaya.Encrypt(Box7key1.Text, Box7key2.Text, Box7.Text);

            //4          Box4ans1.Text = Vertical.Encrypt(Box4.Text, Box4Key.Text);


        }

     
    }
}
