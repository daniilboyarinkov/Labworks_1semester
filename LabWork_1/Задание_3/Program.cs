/*
 * Лабараторная №1
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 */
using System;
namespace Labaratornaya_1
{
    class Program3
    {
        static void Main(string[] args)
        {
            // Без ежемесячного перерасчета процентов
            Console.WriteLine("ДЕПОЗИТНЫЙ КАЛЬКУЛЯТОР");
            Console.WriteLine(" ");
            Console.WriteLine("Введите, пожалуйста, сумму, которую вы готовы положить на депозит ($ США): ");
            decimal s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите, пожалуйста, на сколько месяцев вы планируете взять депозит: ");
            decimal months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Процентная ставка ( % годовых): ");
            decimal percents = Convert.ToInt32(Console.ReadLine());
            decimal duration = (months / 12);
            decimal onep = s * (percents / 100);
            decimal profit = onep * duration;
            Console.WriteLine($"Прибыль: {Math.Round(profit)}$");
            Console.WriteLine($"Общая сумма выплат: {Math.Round(s + profit)}$");

        }
    }
}
