/*
 * Лабараторная работа №4
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание_5
 * 
 */

using System;
namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            Console.Write("N: ");
            string N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Вы ввели невозможное значение для N");
                Console.Write("Попробуйте снова: ");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);

            int[][] matr = new int[n][n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i][j] = rand.Next(0, 100);
                    Console.Write(matr[i][j] + "\t");
                }
                Console.WriteLine();
            }

            // Без учета главной диагонали
            int semisumma = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j <= i) continue;
                    else semisumma += matr[i][j];
                }
            }
            Console.WriteLine($"Без учета главной диагонали: {semisumma}");

            // С учетом главной диагонали
            int semisumma1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (j < i) continue;
                    else semisumma1 += matr[i, j];
                }
            }
            Console.WriteLine($"С учетом главной диагонали: {semisumma1}");
            Console.ReadKey();
        }
    }
}