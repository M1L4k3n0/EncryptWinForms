using ConsoleRedirection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace protect_inf_LR1
{
    public partial class Form1 : Form
    {
        TextWriter _writer = null;
        public Form1()
        {
            InitializeComponent();
            _writer = new TextBoxStreamWriter(ConsoleBox);
            // Redirect the out Console stream
            Console.SetOut(_writer);
            N = characters.Length;
        }

        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ь', 'Ы', 'Ъ',
                                                        'Э', 'Ю', 'Я', ' ', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

        private int N; //длина алфавита

        //зашифровать
        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            //string s;

            //StreamReader sr = new StreamReader("in.txt");
            //StreamWriter sw = new StreamWriter("out.txt");

            //while (!sr.EndOfStream)
            //{
            //    s = sr.ReadLine();
            //    sw.WriteLine(Encode(textBox1.Text, Generate_Pseudorandom_KeyWord(textBox1.Text.Length, 100)));
            //    sw.Close();

            //}
            //StreamReader or = new StreamReader("out.txt");
            //textBox2.Text = or.ReadLine();
            //sr.Close();
            //or.Close();

            string text  =  textBox1.Text;
            string key = textBoxKeyWord.Text;

            textBox2.Text = Xor.Encryption(text, key); //шифрование. вернет "ыкык"
        

        }

        //расшифровать


        //зашифровать
        private string Encode(string input, string keyword)
        {
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int c = (Array.IndexOf(characters, symbol) +
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[c];

                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }

        //расшифровать
        private string Decode(string input, string keyword)
        {
            input = input.ToUpper();
            keyword = keyword.ToUpper();

            string result = "";

            int keyword_index = 0;

            foreach (char symbol in input)
            {
                int p = (Array.IndexOf(characters, symbol) + N -
                    Array.IndexOf(characters, keyword[keyword_index])) % N;

                result += characters[p];

                keyword_index++;

                if ((keyword_index + 1) == keyword.Length)
                    keyword_index = 0;
            }

            return result;
        }

        private string Generate_Pseudorandom_KeyWord(int lenght, int startSeed)
        {
            Random rand = new Random(startSeed);

            string result = "";

            for (int i = 0; i < lenght; i++)
                result += characters[rand.Next(0, characters.Length)];

            return result;
        }
        static class Xor
        {
            static private string alf = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя 0123456789";
            static private int k, x, z;
            static private string res;

            static public string Encryption(string source, string key)
            {
                res = string.Empty;

                while (key.Length < source.Length)
                {
                    key += key;
                    if (key.Length > source.Length) key = key.Remove(source.Length);
                }
                for (int i = 0; i < source.Length; i++)
                {
                    for (int id = 0; id < alf.Length; id++)
                    {
                        if (key[i] == alf[id])
                        {
                            k = id;

                        }
                        if (source[i] == alf[id])
                        {
                            x = id;

                        }
                        z = (x + k) % alf.Length;
                            Console.Write(String.Format("{0}={1}  ", z, alf[z]));                      
                       
                       
                    }
                    res += alf[z];
                }
                return res;
            }

            static public string Decryption(string source, string key)
            {
                res = string.Empty;

                while (key.Length < source.Length)
                {
                    key += key;
                    if (key.Length > source.Length) key = key.Remove(source.Length);
                }
                for (int i = 0; i < source.Length; i++)
                {
                    for (int id = 0; id < alf.Length; id++)
                    {
                        if (key[i] == alf[id]) k = id;
                        if (source[i] == alf[id]) x = id;
                        z = ((source[i] - key[i]) + alf.Length) % alf.Length;
                      
                    }
                    res += alf[z];
                }
                return res;
            }
        }

    }
}