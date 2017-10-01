using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Numerics;


namespace Lab5
{
    public partial class Form1 : Form
    {
        char[] characters = new char[] { '#', 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                        'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };


        public Form1()
        {
            InitializeComponent();
        }



        //проверка: простое ли число?
        private bool IsTheNumberSimple(long n)
        {
            if (n < 2)
                return false;

            if (n == 2)
                return true;

            for (long i = 2; i < n; i++)
                if (n % i == 0)
                    return false;

            return true;
        }

        //зашифровать
        private List<string> RSA_Endoce(string s, long e, long n)
        {
            List<string> result = new List<string>();

            BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new BigInteger(index);
              //  bi = BigInteger.Pow(bi, (int)e);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        //расшифровать
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            BigInteger bi;

            foreach (string item in input)
            {
                bi = new BigInteger(Convert.ToDouble(item));
                bi = BigInteger.Pow(bi, (int)d);

                BigInteger n_ = new BigInteger((int)n);

                bi = bi % n_;

                int index = Convert.ToInt32(bi.ToString());

                result += characters[index].ToString();
            }

            return result;
        }

        //вычисление параметра d. d должно быть взаимно простым с m
        private long Calculate_d(long m)
        {
            long d = m - 1;

            for (long i = 2; i <= m; i++)
                if ((m % i == 0) && (d % i == 0)) //если имеют общие делители
                {
                    d--;
                    i = 1;
                }

            return d;
        }

        //вычисление параметра e
        private long Calculate_e(long d, long m)
        {
            long e = 10;

            while (true)
            {
                if ((e * d) % m == 1)
                    break;
                else
                    e++;
            }

            return e;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox_p.Text.Length > 0) && (textBox_q.Text.Length > 0))
            {
                long p = Convert.ToInt64(textBox_p.Text);
                long q = Convert.ToInt64(textBox_q.Text);

                if (IsTheNumberSimple(p) && IsTheNumberSimple(q))
                {
                    string s = textbox_input.Text;

                    s = s.ToUpper();

                    long n = p * q;
                    long m = (p - 1) * (q - 1);
                    long d = Calculate_d(m);
                    long e_ = Calculate_e(d, m);

                    List<string> result = RSA_Endoce(s, e_, n);

                    string output_result = "";
                    foreach (string item in result)
                        output_result = String.Format("{0} {1}", output_result, item);

                    textBox_output.Text = output_result;

                    textBox_d.Text = d.ToString();
                    textBox_n.Text = n.ToString();


                }
                else
                    MessageBox.Show("p или q - не простые числа!");
            }
            else
                MessageBox.Show("Введите p и q!");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string str1, str2;
            Random myrandom = new Random();
            int p = 127, g = 3, da, ca, db, cb, k;
            ca = myrandom.Next(p);//A
            da = fun(p, g, ca);

            cb = myrandom.Next(p);//B
            db = fun(p, g, cb);

            str1 = textBox_el.Text;
            textBox_el1.Text = "";
            textBox_output.Text = "";

            for (int i = 0; i < str1.Length; i++)
            {
                k = str1[i];
                //1kadam
                k = (k * fun(p, db, ca)) % p;
                textBox_el1.Text = textBox_el1.Text + k.ToString() + ".";
                //2kadam
                k = (k * fun(p, da, p - 1 - cb)) % p;
                textBox_output.Text = textBox_output.Text + k.ToString() + " ";

            }

        }
        public int fun(int p, int a, int b)
        {
            int s = 1;
            for (int i = 1; i <= b; i++)
            {

                s = (s * a) % p;
            }
            return s;
        }
       
        }
    }
}
