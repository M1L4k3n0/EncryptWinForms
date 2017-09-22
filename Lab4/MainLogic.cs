using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesProject.Exercises
{
    public class MainLogic   {       


        public static char[][] GetStaticKeySquare()
        {
            return new char[][]
            {
                new char[] { 'ю', 'у', 'и', 'ч', 'к','б' },
                new char[] { 'в', 'г', 'е', 'ф', 'ж','з' },
                new char[] { 'й', 'а', 'л', 'м', 'о','п' },
                new char[] { 'р', 'щ', 'т', 'я', 'ё','х'},
                new char[] { 'ц', 'н', 'ш', 'с', 'ы','ь' },
                new char[] { 'ъ', 'э', 'д' },
            };
        }


        public static char[][] BuildCleanMatrix(int rows, int cols)
        {
            char[][] result = new char[rows][];

            for (int row = 0; row < result.Length; row++)
            {
                result[row] = new char[cols];
            }

            return result;
        }

        public static char[][] Transpose(char[][] matrix)
        {
            char[][] result =
                BuildCleanMatrix(matrix[0].Length, matrix.Length);

            for (int row = 0; row < matrix.Length; row++)
            {
                for (int col = 0; col < matrix[row].Length; col++)
                {
                    result[col][row] = matrix[row][col];
                }
            }

            return result;
        }

        public static string[] SplitByRange(string text, int range)
        {
            string[] result = new string[text.Length / range];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = text.Substring(i * range, range);
            }

            return result;
        }

        public  static string Cipher(
            string clearText, char[][] keySquare, string keyWord)
        {
            string result = string.Empty;

            #region Fase 1
            string adfgx = "ADFGVX";
            string resultTemp = string.Empty;


            foreach (char c in clearText)
            {
                for (int row = 0; row < keySquare.Length; row++)
                {
                    for (int col = 0; col < keySquare[row].Length; col++)
                    {
                        if (keySquare[row][col] == c)
                        {
                            resultTemp += adfgx[row];
                            resultTemp += adfgx[col];
                        }
                    }
                }
            }
            #endregion

            #region Fase 2

            List<string> charMatrix = new List<string>(keyWord.Length);
            foreach (char c in keyWord)
            {
                charMatrix.Add(c.ToString());
            }

            int idx = 0;
            foreach (char c in resultTemp)
            {
                charMatrix[idx] += c;

                idx = idx == charMatrix.Count - 1 ? 0 : idx + 1;
            }

            charMatrix.Sort();

            foreach (string s in charMatrix)
            {
                result += s.Substring(1);
            }
            #endregion

            return result;
        }
    }
}
