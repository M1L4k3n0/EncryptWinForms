using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class CharNum
    {
        #region Fields
        /// <summary>
        /// Символ.
        /// </summary>
        private char _ch;
        /// <summary>
        /// Порядковый номер зависящий от алфавита.
        /// </summary>
        private int _numberInWord;
        #endregion Fieds

        #region Properties
        /// <summary>
                /// Символ.
                /// </summary>
        public char Ch
        {
            get { return _ch; }
            set
            {
                if (_ch == value)
                    return;
                _ch = value;
            }
        }
        /// <summary>
        /// Порядковый номер в строке, зависящий от алфавита.
        /// </summary>
        public int NumberInWord
        {
            get { return _numberInWord; }
            set
            {
                if (_numberInWord == value)
                    return;
                _numberInWord = value;
            }
        }
        #endregion Properties
    }

    class Dvoynaya
    {
        public static string Encrypt(string key1, string key2, string input)
        {
            // Первый ключ, количество столбцов
            string firstKey = key1;
            // Второй ключ, количество строк
            string secondKey = key2;
            // Предложение которое шифруем
            string stringUser = input;

            string output = "";
            // Матрица в которой производим шифрование
            char[,] matrix = new char[secondKey.Length, firstKey.Length];

            // Счетчик символов в строке
            int countSymbols = 0;

            // Переводим строки в массивы типа char
            char[] charsFirstKey = firstKey.ToCharArray();
            char[] charsSecondKey = secondKey.ToCharArray();
            char[] charStringUser = stringUser.ToCharArray();

            // Создаем списки в которых будут храниться символы и порядковы номера символов
            List<CharNum> listCharNumFirst =
        new List<CharNum>(firstKey.Length);

            List<CharNum> listCharNumSecond =
              new List<CharNum>(secondKey.Length);

            // Заполняем символами из ключей
            listCharNumFirst = FillListKey(charsFirstKey);
            listCharNumSecond = FillListKey(charsSecondKey);

            // Заполняем порядковыми номерами
            listCharNumFirst = FillingSerialsNumber(listCharNumFirst);
            listCharNumSecond = FillingSerialsNumber(listCharNumSecond);

            ShowKey(listCharNumFirst, "Первый ключ: ");
            ShowKey(listCharNumSecond, "Второй ключ: ");

            // Заполнение матрицы строкой пользователя
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    matrix[i, j] = charStringUser[countSymbols++];
                }
            }

            ShowMatrix(matrix, "Первоначальное значение: ");

            countSymbols = 0;
            // Заполнение матрицы с учетом шифрования. 
            // Переставляем столбцы по порядку следования в первом ключе. 
            // Затем переставляем строки по порядку следования во втором ключа. 
            for (int i = 0; i < listCharNumSecond.Count; i++)
            {
                for (int j = 0; j < listCharNumFirst.Count; j++)
                {
                    matrix[listCharNumSecond[i].NumberInWord,
                     listCharNumFirst[j].NumberInWord] = charStringUser[countSymbols++];
                }
            }

            ShowMatrix(matrix, "Зашифрованное значение: ");
            return ShowMatrix(matrix,"lol");
            Console.ReadKey();
        }

        #region Methods
        /// <summary>
                /// Возвращает порядковый номер символа по алфавиту.
                /// </summary>
                /// <param name="s">Символ, чей порядковый номер, необходимо узнать.</param>
                /// <returns></returns>
        public static int GetNumberInThealphabet(char s)
        {
            string str = @"АаБбВвГгДдЕеЁёЖжЗзИиЙйКкЛлМмНнОоПпРрСсТтУуФфХхЦцЧчШшЩщЪъЫыЬьЭэЮюЯя";

            int number = str.IndexOf(s) / 2;

            return number;
        }

        /// <summary>
                /// Заполнение символами списка с ключом.
                /// </summary>
                /// <param name="chars">массив символов.</param>
                /// <returns>Список символов.</returns>
        public static List<CharNum> FillListKey(char[] chars)
        {
            List<CharNum> listKey = new List<CharNum>(chars.Length);

            for (int i = 0; i < chars.Length; i++)
            {
                CharNum charNum = new CharNum()
                {
                    Ch = chars[i],
                    NumberInWord = GetNumberInThealphabet(chars[i])
                };

                listKey.Add(charNum);
            }
            return listKey;
        }
        /// <summary>
        /// Отображение ключа.
        /// </summary>
        /// <param name="listCharNum">Список в котором содержатся символы с порядковыми номерами.</param>
        public static void ShowKey(List<CharNum> listCharNum, string message)
        {
            Console.WriteLine(message);

            foreach (var i in listCharNum)
            {
                Console.Write(i.Ch + " ");
            }
            Console.WriteLine();

            foreach (var i in listCharNum)
            {
                Console.Write(i.NumberInWord + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }
        /// <summary>
        /// Заполнение символов ключей, порядковыми номерами.
        /// </summary>
        /// <param name="listCharNum"></param>
        /// <returns></returns>
        public static List<CharNum> FillingSerialsNumber(
      List<CharNum> listCharNum)
        {
            int count = 0;

            var result = listCharNum.OrderBy(a =>
              a.NumberInWord);

            foreach (var i in result)
            {
                i.NumberInWord = count++;
            }

            return listCharNum;
        }
        /// <summary>
        /// Отображение матрицы.
        /// </summary>
        /// <param name="matrix">Матрица с символами.</param>
        public static string ShowMatrix(char[,] matrix, string message)
        {
            string outp = "";
            Console.WriteLine(message);
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + " ");
                    outp = string.Format("{0}{1}", outp, matrix[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            return outp;
            Console.WriteLine();
        }

        #endregion Methods
    }

}
