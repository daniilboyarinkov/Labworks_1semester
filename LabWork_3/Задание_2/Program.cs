/*
 * Лабараторная работа №3
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание №2
 */

using System;
namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 35;
            int r = 87;
            for (int n = l; n <= r; n++)
            {
                if (n%7 == 1 || n%7==2 || n % 7 == 5)
                {
                    Console.WriteLine(n);
                }
            }
        }
    }
}
