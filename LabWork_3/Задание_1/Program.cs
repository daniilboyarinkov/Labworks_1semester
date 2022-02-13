/*
 * Лабараторная работа №3
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание №1
 */

using System;
namespace Задание_1
{
    class Program
    {
        static int ts(int n)
        {
            // 2-ой способ с помощью рекурсии
            if (n < 1) return 0;
            else return n + ts(n - 1);
        }

        static void Main(string[] args)
        {
            // 1-ый способ "перебор в лоб"
            Console.Write("Введите число n: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int total = 0;
            if (n < 1)
            {
                Console.WriteLine("Error: n<1");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    total += i;
                }
            }
            Console.WriteLine($"1-ый способ (перебор). Ответ: {total}");
            Console.WriteLine($"2-ой способ (рекурсия). Ответ: {ts(n)}");
        }

    }
}