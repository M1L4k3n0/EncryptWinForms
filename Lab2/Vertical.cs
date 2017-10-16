using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Vertical
    {
        public static string Encrypt(string input, string key)
        {
            string output1 = "";
            string output2 = "";
            int k = input.Length;
            string[,] array = new string[7, 9];
            int q = 0;
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                {
                    if (q < input.Length)

                        array[i, j] = Convert.ToString(input[q++]);
                    else if (q <= input.Length && j == 0)
                        break;
                    else array[i, j] = "-";
                }

            for (int i = 0; i < 7; i++)
            {
                for (int j = 0; j < 7; j++)

                    output1 = String.Format("{0} " +
                        "{1}", output1, array[i, j]);
                
            }


            string result = "";
            for (int i = 0; i < 7; i++)
                for (int j = 0; j < 7; j++)
                    if (i == Convert.ToInt32(Convert.ToString(key[j])))
                        for (int t = 0; t < 7; t++)
                            result += array[t, j];
            output2 = string.Format("{0} {1} ", output2, result);
            // richTextBox1.Text += result;




            return output2;
        }   
        
    }
}
