/*
 * Лабараторная работа №2
 * 
 * Бояринков Даниил Владимирович
 * Гурппа: КИ21-22Б
 * 
 * Задание №3
 */


using System;
namespace Задание_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие решения в одни сутки гарантирует нам что второе время всегда больше первого
            Console.WriteLine("Время начала решения: ");
            Console.Write("h1: ");
            int h1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("m1: ");
            int m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(" ");
            Console.WriteLine("Время окончания решения: ");
            Console.Write("h2: ");
            int h2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("m2: ");
            int m2 = Convert.ToInt32(Console.ReadLine());
            int h_end, m_end;
            if (m2 < m1)
            {
                m_end = m2+60-m1;
                h_end = h2 - h1 - 1;
            }
            else
            {
                m_end = m2 - m1;
                h_end = h2 - h1;
            }
            Console.WriteLine();
            Console.WriteLine($"Решение заняло: {h_end} hours {m_end} mins ИЛИ {h_end*60+m_end} mins всего");
            Console.ReadKey();
        }
    }
}
