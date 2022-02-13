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
            Console.Write("N:");
            string N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Вы ввели невозможное значение для N");
                Console.Write("Попробуйте снова: ");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);

            int[,] matr = new int[n, n];
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matr[i, j] = rand.Next(0, 100);
                    Console.Write(matr[i, j] + "\t");
                    arr[j] += matr[i, j];
                }
                Console.WriteLine();
            }
            foreach (int s in arr)
            {
                Console.WriteLine($"сумма строки №{Array.IndexOf(arr, s) + 1} равна {s} ");
            }
            Console.WriteLine();
            Console.WriteLine("Массив: ");
            Console.Write('[');
            foreach (int s in arr)
            {
                if (Array.IndexOf(arr, s) == arr.Length - 1) Console.Write(s);
                else Console.Write(s + ", ");
            }
            Console.Write(']');
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
