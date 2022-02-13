/*
 * Лабараторная работа №2
 * 
 * Бояринков Даниил Владимирович
 * Гурппа: КИ21-22Б
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
            Console.WriteLine("Введите a, b и c параметры параболической функции (ax^2+bx+c)");
            Console.Write("a: ");
            var a = Console.ReadLine();
            decimal dec_a;
            while (!Decimal.TryParse(a, out dec_a) || Convert.ToDecimal(a) == 0)
            {
                Console.WriteLine("Вы ввели невозможное значение");
                Console.WriteLine("Параметр a не может быть равен 0 и не может быть не числом");
                Console.WriteLine("Попробуйте ввести параметр a снова");
                a = Console.ReadLine();
            }
            dec_a = Convert.ToDecimal(a);
            Console.Write("b: ");
            var B = Console.ReadLine();
            decimal b;
            while (!decimal.TryParse(B, out b))
            {
                Console.WriteLine("Вы ввели невозможное значение для b");
                Console.WriteLine("Попробуйте ввести параметр b снова");
                B = Console.ReadLine();
            }
            b = Convert.ToDecimal(B);
            Console.Write("c: ");
            var C = Console.ReadLine();
            decimal c;
            while (!decimal.TryParse(C, out c))
            {
                Console.WriteLine("Вы ввели невозможное значение для c");
                Console.WriteLine("Попробуйте ввести параметр c снова");
                C = Console.ReadLine();
            }
            c = Convert.ToDecimal(C);
            Console.WriteLine("Вершина параболы:");
            
            Console.WriteLine($"x: {-(b/(2*dec_a))}");
            Console.WriteLine($"y: {(-((b*b)-(4*dec_a*c))/(4*dec_a))}");
            // a = 0
        }
    }
}
