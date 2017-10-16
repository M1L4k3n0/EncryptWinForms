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

//using System.Numerics;



using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Generators;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Paddings;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities.Encoders;
using Org.BouncyCastle.Utilities.IO.Pem;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;
using Org.BouncyCastle.Asn1.Pkcs;
using Org.BouncyCastle.Pkcs;
using Org.BouncyCastle.Crypto.Encodings;
using System.Security.Cryptography;
using System.IO;


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

            System.Numerics.BigInteger bi;

            for (int i = 0; i < s.Length; i++)
            {
                int index = Array.IndexOf(characters, s[i]);

                bi = new System.Numerics.BigInteger(index);
                //  bi = BigInteger.Pow(bi, (int)e);

                System.Numerics.BigInteger n_ = new System.Numerics.BigInteger((int)n);

                bi = bi % n_;

                result.Add(bi.ToString());
            }

            return result;
        }

        //расшифровать
        private string RSA_Dedoce(List<string> input, long d, long n)
        {
            string result = "";

            System.Numerics.BigInteger bi;

            foreach (string item in input)
            {
                bi = new System.Numerics.BigInteger(Convert.ToDouble(item));
                bi = System.Numerics.BigInteger.Pow(bi, (int)d);

                System.Numerics.BigInteger n_ = new System.Numerics.BigInteger((int)n);

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

        List<BigInteger> testowa = new List<BigInteger>();
        MHKey key = new MHKey();
        private void button3_Click(object sender, EventArgs e)
        {

            PublicBox.Text = key.privateKey.getAll();
            PrivateBox.Text = key.getList();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var cipherBigIntegers = key.encipher(MEssagebox.Text);
            string ciphertext = "";
            int i = 0;
            foreach (BigInteger elem in cipherBigIntegers)
            {
                ciphertext += elem.ToString();
                i++;
                if (cipherBigIntegers.Count != i)
                    ciphertext += " ";
            }
            textBox_output.Text = ciphertext;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            List<BigInteger> list = new List<BigInteger>();
            string str = ""; //deszyfrowanie wiadomosci
            var txt = MEssagebox.Text; // zaszyfrowana wiadomosc

            // for (int i=0; i < tbMessage.Text.Length + 1; i++)
            foreach (char elem in MEssagebox.Text)
            {
                if (elem != ' ')
                    str += elem;
                else
                {
                    list.Add(new BigInteger(str));
                    str = "";
                }
            }
            list.Add(new BigInteger(str)); //bo wychodzi z petli i nie wpisuje jednego

            textBox_output.Text = key.decipher(list, key.privateKey);
        }
    }
    public class MHKey
    {
        public List<Org.BouncyCastle.Math.BigInteger> e { get; set; }
        public MHPrivateKey privateKey { get; set; }
        public MHKey()
        {
            generator gen = new generator(8);
            Org.BouncyCastle.Math.BigInteger w = gen.w;
            e = new List<Org.BouncyCastle.Math.BigInteger>();
            for (int i = 0; i < gen.a.Count; i++)
            {
                e.Add((w.Multiply(gen.a.ElementAt(i))).Mod(gen.n)); // w*a Mod n ..
            }

            Org.BouncyCastle.Math.BigInteger w1 = Org.BouncyCastle.Math.BigInteger.ValueOf(1);
            Org.BouncyCastle.Math.BigInteger one = Org.BouncyCastle.Math.BigInteger.ValueOf(2);
            while (one.IntValue != 1)
            {
                w1 = w1.Add(Org.BouncyCastle.Math.BigInteger.ValueOf(1)).Mod(gen.n);
                one = w.Multiply(w1).Mod(gen.n);

            }
            privateKey = new MHPrivateKey(gen.a, w.ModInverse(gen.n), gen.n);


        }
        public string getList()
        {
            string str = "";
            foreach (Org.BouncyCastle.Math.BigInteger elem in this.e)
            {
                str += elem + ",";
            }
            return str;
        }
        public void swap(int n, int m)
        {
            Org.BouncyCastle.Math.BigInteger tmp = (Org.BouncyCastle.Math.BigInteger)e.ElementAt(m);
            e.Insert(m, e.ElementAt(n));
            e.Insert(n, tmp);
        }

        public void permutation()
        {
            Random rnd = new Random();
            int tmp, tmp2;

            for (int i = 0; i < e.Count * e.Count; i++)
            {
                tmp = Math.Abs(rnd.Next() % e.Count);
                tmp2 = Math.Abs(rnd.Next() % e.Count);
                swap(tmp, tmp2);
            }
        }

        public List<Org.BouncyCastle.Math.BigInteger> encipher(String plain)
        {
            String binary;
            Org.BouncyCastle.Math.BigInteger tmp;
            List<Org.BouncyCastle.Math.BigInteger> enciphered = new List<Org.BouncyCastle.Math.BigInteger>();
            char[] charArray = plain.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                tmp = Org.BouncyCastle.Math.BigInteger.ValueOf(0);
                binary = charToBinary(charArray[i]);
                char one = '1';
                for (int j = binary.Length - 1; j > -1; j--)
                {
                    if (binary.ElementAt(j) == one)
                    {
                        tmp = tmp.Add((Org.BouncyCastle.Math.BigInteger)e.ElementAt(7 - j));
                    }
                }
                enciphered.Add(tmp);
            }
            return enciphered;
        }

        public String decipher(List<Org.BouncyCastle.Math.BigInteger> cipher, MHPrivateKey key)
        {
            String decrypted = "";
            Org.BouncyCastle.Math.BigInteger temp = Org.BouncyCastle.Math.BigInteger.ValueOf(0);
            int tmp = 0;

            Org.BouncyCastle.Math.BigInteger bits = Org.BouncyCastle.Math.BigInteger.ValueOf(0);

            for (int i = 0; i < cipher.Count; i++)
            {
                temp = cipher.ElementAt(i);
                int bitlen = temp.BitLength;
                int ff = 0;
                while (bitlen < (int)Math.Pow(2, ff))
                {
                    ff++;
                }
                if (ff > bitlen)
                    bitlen = ff;

                for (int j = 0; j < bitlen; j++)
                {
                    if (temp.Mod(Org.BouncyCastle.Math.BigInteger.ValueOf(2)).CompareTo(Org.BouncyCastle.Math.BigInteger.ValueOf(1)) == 0)
                    {
                        bits = bits.Add(key.w1.Multiply(Org.BouncyCastle.Math.BigInteger.ValueOf((long)Math.Pow(2, j))));
                    }
                    temp = temp.ShiftRight(1);
                }
                bits = bits.Mod(key.n);
                List<Org.BouncyCastle.Math.BigInteger> list = key.a;
                Org.BouncyCastle.Math.BigInteger temper;

                int k = key.a.Count - 1;
                while (k >= 0)
                {
                    temper = list.ElementAt(k);
                    if (bits.CompareTo(temper) > -1)
                    {
                        tmp += (int)Math.Pow(2, k);
                        bits = bits.Subtract(temper);
                    }
                    k--;
                }
                decrypted += (binaryToChar(Convert.ToString(tmp, 2))).ToString();

                bits = Org.BouncyCastle.Math.BigInteger.ValueOf(0);
                tmp = 0;
            }
            return decrypted;
        }
        public String charToBinary(char ch)
        {
            String chBin = Convert.ToString((int)ch, 2).PadLeft(8, '0');


            return chBin;
        }
        char binaryToChar(String binStr)
        {
            char[] temp = binStr.ToCharArray();
            int sum = 0;
            for (int i = 0; i < temp.Length; i++)
            {
                sum += (Int32.Parse(char.ToString(temp[i])) << (temp.Length - i - 1));
            }

            return (char)sum;
        }


        public Org.BouncyCastle.Math.BigInteger getGCD(Org.BouncyCastle.Math.BigInteger bd1, Org.BouncyCastle.Math.BigInteger bd2)
        {
            Org.BouncyCastle.Math.BigInteger bigger = (bd1.CompareTo(bd2) > 0) ? bd1 : bd2;
            Org.BouncyCastle.Math.BigInteger smaller = (bd1.CompareTo(bd2) < 0) ? bd1 : bd2;
            Org.BouncyCastle.Math.BigInteger gcd = smaller;
            while (!Org.BouncyCastle.Math.BigInteger.Zero.Equals(smaller))
            {
                gcd = smaller;
                smaller = bigger.Mod(smaller);
                bigger = gcd;
            }
            return gcd;
        }

    }
    public class generator
    {
        public List<Org.BouncyCastle.Math.BigInteger> a { get; set; }
        public Org.BouncyCastle.Math.BigInteger n { get; set; }
        public Org.BouncyCastle.Math.BigInteger w { get; set; }

        public Org.BouncyCastle.Math.BigInteger getGCD(Org.BouncyCastle.Math.BigInteger bd1, Org.BouncyCastle.Math.BigInteger bd2)
        {
            Org.BouncyCastle.Math.BigInteger bigger = (bd1.CompareTo(bd2) > 0) ? bd1 : bd2;
            Org.BouncyCastle.Math.BigInteger smaller = (bd1.CompareTo(bd2) < 0) ? bd1 : bd2;
            Org.BouncyCastle.Math.BigInteger gcd = smaller;
            while (!Org.BouncyCastle.Math.BigInteger.Zero.Equals(smaller))
            {
                gcd = smaller;
                smaller = bigger.Mod(smaller);
                bigger = gcd;
            }
            return gcd;
        }
        public generator(int k)
        {

            a = new List<Org.BouncyCastle.Math.BigInteger>();
            Random rnd = new Random();
            BigInteger tmp;
            BigInteger sum;
            sum = BigInteger.ValueOf(0);
            for (int i = 0; i < k; i++)
            {
                tmp = BigInteger.ValueOf((long)(Math.Pow(2, k + i)));
                a.Add(tmp);
                sum = sum.Add(tmp);
            }
            n = sum.Add(BigInteger.ValueOf(1));
            w = BigInteger.ValueOf(467);
            while (this.getGCD(n, w).CompareTo(BigInteger.ValueOf(1)) != 0)
            {
                w.Add(BigInteger.ValueOf(1));
            }

        }

        public BigInteger getListElement(int i)
        {

            BigInteger tmp = a.ElementAt(i);
            return tmp;
        }
        String getAll()
        {
            String tmp = "";
            for (int i = 0; i < a.Count; i++)
                tmp += "" + a.ElementAt(i) + ",";
            tmp += ";" + w;
            tmp += ";" + n;

            return tmp;
        }
    }

    public class MHPrivateKey
    {
        public List<BigInteger> a { get; set; }
        public BigInteger w1 { get; set; }
        public BigInteger n { get; set; }

        public MHPrivateKey()
        {
            this.a = null;
            this.w1 = null;
            this.n = null;
        }

        public MHPrivateKey(List<BigInteger> a, BigInteger w1, BigInteger n)
        {
            this.a = a;
            this.w1 = w1;
            this.n = n;
        }


        public String getAll()
        {
            String tmp = "a[] = " + a.ElementAt(0);
            for (int i = 1; i < a.Count; i++)
                tmp += "," + a.ElementAt(i);
            tmp += "\n  w^1 = " + w1;
            tmp += "\n  n = " + n;

            return tmp;
        }
    }
}

