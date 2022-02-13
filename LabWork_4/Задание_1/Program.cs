/*
 * Лабараторная работа №4
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание_1
 * 
 */

using System;
namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0, index = 0;

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
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-100, 100);
            }
            // Вывод массива
            foreach (int nm in arr)
            {
                Console.Write(nm + " ");
            }
            Console.WriteLine(" ");
            for (int i = 0; i < n; i++)
            {
                if (arr[i] < 0)
                {
                    num = arr[i];
                    index = Array.IndexOf(arr, arr[i]) + 1;
                }
            }
            Console.WriteLine($"значение: {num}");
            Console.WriteLine($"номер: {index}");
            Console.ReadKey();
        }
    }
}
