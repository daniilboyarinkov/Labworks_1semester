/*
 * Лабараторная №1
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * 2 задание
 */
using System;
namespace Labaratornaya_1
{
    class Program2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Я могу помочь вам найти S и P вашего прямоугольника по его сторонам;");
            Console.WriteLine("Введите, пожалуйста, длину: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите, пожалуйста, ширину: ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Площадь вашего прямоугольника: {a * b}");
            Console.WriteLine($"Периметр вашего прямоугольника: {(a + b) * 2}");

        }
    }
}
