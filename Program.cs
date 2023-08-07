using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Линьков_Тимофей_4._8._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество строк: ");
            string row = Console.ReadLine();
            if (int.TryParse(row, out int x))
                Console.WriteLine(x);
            else
                Console.WriteLine("Вы ввели не число, попробуйте еще раз.");

            Console.Write("Введите количество столбцов: ");
            string col = Console.ReadLine();
            if (int.TryParse(col, out int y))
                Console.WriteLine(y);
            else
                Console.WriteLine("Вы ввели не число, попробуйте еще раз.");

            int[,] matrix1 = new int[x, y];
            Random random = new Random();

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    matrix1[i, j] = random.Next(10);
                    Console.Write($"{matrix1[i, j],3}");
                }
                Console.Write("\n\n");
            }
            Console.WriteLine();

            int[,] matrix2 = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    matrix2[i, j] = random.Next(10);
                    Console.Write($"{matrix2[i,j],3}");
                }
                Console.Write("\n\n");
            }
            Console.WriteLine();

            int[,] matrix3 = new int[x, y];
            
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < y; j++)
                {
                    matrix3[i,j] = matrix1[i,j] + matrix2[i,j];
                    Console.Write($"{matrix3[i,j],3}");
                }
                Console.Write("\n\n");
            }
            Console.ReadKey();

        }

    }
}
