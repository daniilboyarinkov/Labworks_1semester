/*
 * Лабараторная работа №2
 * 
 * Бояринков Даниил Владимирович
 * Гурппа: КИ21-22Б
 * 
 * Задание №3_modified
 */


using System;
namespace Задание_3_modidied
{
    class Program
    {
        static void Main(string[] args)
        {
            // условие: второе время может быть меньше чем первое
            Console.WriteLine("Время начала решения (в формате hours:mins): ");
            string start = Console.ReadLine();
            string[] start_time = start.Split(new char[] { ':', ' '});

            Console.WriteLine("Время оконачния решения (в формате hours:mins): ");
            string end = Console.ReadLine();
            string[] end_time = end.Split(new char[] { ':', ' ' });

            int h1 = Convert.ToInt32(start_time[0]);
            int m1 = Convert.ToInt32(start_time[1]);
            int h2 = Convert.ToInt32(end_time[0]);
            int m2 = Convert.ToInt32(end_time[1]);

            int h_end, m_end;

            // Логика 
            if (m2 < m1)
            {
                h2--;
                m_end = m2 + 60 - m1;
                if (h2 < h1)
                {
                    h_end = h2+24-h1;
                }
                else
                {
                    h_end = h2 - h1;
                }
            }
            else
            {
                m_end = m2 - m1;
                if (h2 < h1)
                {
                    h_end = h2 + 24 - h1;
                }
                else
                {
                    h_end = h2 - h1;
                }
            }
            Console.WriteLine($"Решение заняло: {h_end} hours {m_end} mins ИЛИ {h_end * 60 + m_end} mins всего");
        }
    }
}
