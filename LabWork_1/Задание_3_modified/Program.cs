/*
 * Лабараторная работа №1
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание 3 вариант 2
 * 
 */

using System;
namespace LabWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            // с ежемесячным перерасчетом процентов 
            Console.WriteLine("ДЕПОЗИТНЫЙ КАЛЬКУЛЯТОР");
            Console.WriteLine(" ");
            Console.WriteLine("Введите, пожалуйста, сумму, которую вы готовы положить на депозит ($ США): ");
            decimal s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите, пожалуйста, на сколько месяцев вы планируете взять депозит: ");
            decimal months = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Процентная ставка ( % годовых): ");
            decimal percents = Convert.ToInt32(Console.ReadLine());
            decimal new_s = s;
            decimal all_p = 0;
            for (int i = 0; i < months; i++)
            {
                s = new_s;
                decimal p = (s * (percents / 100)) / 12;
                all_p += p;
                new_s = s + p;
            }
            Console.WriteLine($"Прибыль: {Math.Round(all_p, 2)}$");
            Console.WriteLine($"Общая сумма выплат: {Math.Round(new_s, 2)}$");
        }
    }
}
