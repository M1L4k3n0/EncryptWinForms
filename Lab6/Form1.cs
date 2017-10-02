using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 1
            String str = textBox1.Text;
            textBox1Ans.Text = Convert.ToString(Convert.ToInt32(str), 2);

            //2
            String str2 = "104";
            string temp ;
            int mask = Convert.ToInt32(str2);
            mask |= mask >> 1;
            mask |= mask >> 2;
            mask |= mask >> 4;
            mask |= mask >> 8;
            mask |= mask >> 16;
            int inverse = ~Convert.ToInt32(str2) & mask;
            temp = Convert.ToString(~Convert.ToInt32(str2), 2);
            textBox2Ans.Text = temp.ToString();

            //3

            int value = Convert.ToInt32(textBox3.Text);
            string binRep = Convert.ToString(value, 2);
            int onesComplement = Convert.ToInt32(binRep, 2);
            textBox3Ans.Text = Convert.ToString(onesComplement, 2);

            //4

            string ans4 = DoubleConverter.ToExactString(Convert.ToDouble(textBox4.Text));
            textBox4Ans.Text = ans4;


            //5
            double d1 = Convert.ToSingle(textBox5.Text);
            string ds = DoubleToBinaryString(d1);
            textBox5Ans.Text = ds;


        }
        public static string DoubleToBinaryString(double d)
        {
            return Convert.ToString(BitConverter.DoubleToInt64Bits(d), 2);
        }

    }
    }

