/*
 * Лабараторная работа №2
 * 
 * Бояринков Даниил Владимирович
 * Гурппа: КИ21-22Б
 * 
 * Задание №1
 */


using System;
namespace Задание_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите координаты точки M1");
            Console.WriteLine();
            Console.Write("Введите x1 точки M1: ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y1 точки M1: ");
            double y1 = Convert.ToDouble(Console.ReadLine());   
            Console.WriteLine();
            Console.WriteLine("Введите координаты точки M2");
            Console.WriteLine();
            Console.Write("Введите x2 точки M2: ");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите y2 точки M2: ");
            double y2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Расстояние между точками равно: {Math.Sqrt( Math.Pow(x2-x1, 2) + Math.Pow(y2-y1, 2))}");
        }
    }
}
