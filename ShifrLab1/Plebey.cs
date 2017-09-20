using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShifrLab1
{
   
    class Plebey
    {
        public static string Encrypt(string input)
        {
            char[,] alfrus = {     {'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ё'},
                                   {'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М'},
                                   {'Н', 'О', 'П', 'Р', 'С', 'Т', 'У'},
                                   {'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ'},
                                   {'Ы', 'Ь', 'Э', 'Ю', 'Я', '0', '1'},
                                   { '2','3', '4', '5', '6', '7', '8'},
                                   {'9', ' ', ',', '.', '!', '?', ';'}
                               };

            
            string message = input;
            string new_message = "";



            for (int i = 0; i < message.Length; i++)
            {
                for (int j = 0; j < alfrus.GetLength(0); j++)
                    for (int k = 0; k < alfrus.GetLength(1); k++)
                        if (Char.ToLower(alfrus[j, k]) == message[i] || Char.ToUpper(alfrus[j, k]) == message[i])
                        {
                            new_message += (Convert.ToString(j+1) + Convert.ToString(k+1)) + " ";
                            break;
                        }

            }
            return new_message;
        }
    }
}


