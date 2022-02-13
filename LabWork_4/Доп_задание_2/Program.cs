/*
 * Лабараторная работа №4
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание_3
 * 
 */

using System;
namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.WriteLine("Введите размеры матрицы: ");
            Console.Write("Кол-во строк: ");
            string N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Вы ввели невозможное значение для N");
                Console.Write("Попробуйте снова: ");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);

            Console.Write("Кол-во столбцов: ");
            string M = Console.ReadLine();
            int m;
            while (!int.TryParse(M, out m))
            {
                Console.WriteLine("Вы ввели невозможное значение для M");
                Console.Write("Попробуйте снова: ");
                M = Console.ReadLine();
            }
            m = Convert.ToInt32(N);

            int[,] matr = new int[n, m];
            int summastroki = 0;
            int[] summastrok = new int[n];

            int max = 0;
            int maxindex = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matr[i, j] = rand.Next(0, 100);
                    summastroki += matr[i, j];
                    Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
                summastrok[i] = summastroki;
                if (summastroki > max)
                {
                    max = summastroki;
                    maxindex = i;
                }
                summastroki = 0;
            }

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Сумма строки №{i + 1} равна: {summastrok[i]}");
            }
            Console.WriteLine($"Строка №{maxindex + 1} обладает наибольшей суммой элементов: {max}");
            Console.ReadKey();
        }
    }
}
