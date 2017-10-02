using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Povorot
    {
         public  static string[] Calculate(string[] buf)
        {
            const int SIZE = 5;          
            int[,] grid = new int[SIZE, SIZE]{
             {0, 0, 1, 0, 1},
             {1, 1, 0, 1, 0},
             {0, 0, 0, 0, 0},
             {0, 0, 0, 1, 0},
             {0, 0, 0, 0, 0}};
            string[] output = new string[4];

            // вывод зашифрованного сообщения
            for (int i = 0; i < SIZE; i++)
            {
                Console.WriteLine(buf[i]);
            }
            Console.WriteLine("");

            // прямой обход решетки
            Console.WriteLine("0:");
            string temp = "";
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[i, j] == 1)
                    {
                        Console.Write(buf[i][j]);
                        temp = string.Format("{0}{1}", temp, buf[i][j]);
                    }
            output[0] = temp;
            temp = "";
            Console.WriteLine("");
            // поворот решетки на 90 градусов по часовой стрелке
            Console.WriteLine("90:");
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - j - 1, i] == 1)
                    {
                        Console.Write(buf[i][j]);
                        temp = string.Format("{0}{1}", temp, buf[i][j]);
                    }
            Console.WriteLine("");
            output[1] = temp;
            temp = "";
            // поворот решетки на 180 градусов по часовой стрелке
            Console.WriteLine("180:");
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[SIZE - i - 1, SIZE - j - 1] == 1)
                    {
                        Console.Write(buf[i][j]);
                        temp = string.Format("{0}{1}", temp, buf[i][j]);
                    }
            Console.WriteLine("");
            output[2] = temp;
            temp = "";
            // поворот решетки на 270 градусов по часовой стрелке
            Console.WriteLine("270:");
            for (int i = 0; i < SIZE; i++)
                for (int j = 0; j < SIZE; j++)
                    if (grid[j, SIZE - i - 1] == 1)
                    {
                        Console.Write(buf[i][j]);
                        temp = string.Format("{0}{1}", temp, buf[i][j]);
                    }
            output[3] = temp;
           
            return output;
        }
    }
}
