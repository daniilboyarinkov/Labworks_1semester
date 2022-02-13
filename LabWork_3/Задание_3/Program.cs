/*
 * Лабараторная работа №3
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание №3
 */

using System;
using System.Collections.Generic;
namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Сколько человек пришло в спортзал сегодня: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] ages = new int[n];
            List<int> ages2 = new List<int>();
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Сколько лет {i} посетителю: ");
                ages[i-1]=(Convert.ToInt32(Console.ReadLine()));
            }
            int min=10000000, max=0, total=0, count=0;
            foreach (int age in ages)
            {
                if (age < min) min = age;
                else if (age > max) max = age;
                total += age;
                count++;
            }
            Console.WriteLine($"Самому старшему - {max}");
            Console.WriteLine($"Самому младшему - {min}");
            Console.WriteLine($"Средний возраст - {total/count}");

        }
    }
}
