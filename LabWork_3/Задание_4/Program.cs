/*
 * Лабараторная работа №3
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание №4
 */

using System;
namespace Задание_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int all = 15;
            int i = 1;
            while (all > 0)
            {
                Console.WriteLine($"приехала машина №{i}");
                Console.Write($"сколько ящиков погрузить в машину №{i}: ");
                int need = Convert.ToInt32(Console.ReadLine());
                if (need > all)
                {
                    Console.WriteLine($"Извините, на нашем складе осталось только {all} ящиков");
                    Console.WriteLine($"Мы загрузим вам {all} ящиков");
                    need = all;
                }
                all -= need;
                i++;
            }
            Console.WriteLine("На складе больше ящиков нет!!!");
        }
    }
}
