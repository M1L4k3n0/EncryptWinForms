using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Kvadrat
    {
       public static string Encrypt(string input)
        {
            string _randomLine = "ЙЦУКЕНГШЩЗХФЪЫВАПРОЛДЖЭЧСМИТЬБЮ";
            Random _rand = new Random();
            String _line = input.ToUpper().Replace(" ", "");
            int _d = (int)Math.Ceiling(Math.Sqrt(_line.Length));
            if (_d % 2 != 1)
                _d++;
            Console.WriteLine("Магический квадрат: " + _d.ToString() + "\n");
            int[,] _quad = new int[_d, _d];
            for (int j = 0; j < _d; j++)
            {
                for (int i = 0; i < _d; i++)
                {
                    _quad[i, j] = _d * (((i + 1) + (j + 1) - 1 + (_d / 2)) % _d) + (((i + 1) + 2 * (j + 1) - 2) % _d) + 1;
                    Console.Write(_quad[i, j].ToString() + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Шифрование сообщения:");
            string _cryptedString = "";
            for (int j = 0; j < _d; j++)
            {
                for (int i = 0; i < _d; i++)
                {
                    if ((_quad[i, j] - 1) < _line.Length)
                    {
                        Console.Write(_line[_quad[i, j] - 1] + "\t");
                        _cryptedString += _line[_quad[i, j] - 1];
                    }
                    else
                    {
                        char _randomChar = _randomLine[_rand.Next(0, _randomLine.Length - 1)];
                        Console.Write(_randomChar + "\t");
                        _cryptedString += _randomChar;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nЗашифрованная строка:");
            Console.WriteLine(_cryptedString);
            return _cryptedString;

        }
    }
}
