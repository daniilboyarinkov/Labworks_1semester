/*
 * Лабараторная работа №4
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание_2
 * 
 */

using System;
namespace Задание_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] Matrix = new int[10, 20];

            Random rand = new Random();
            // Flag
            bool F = false;
            bool[] stroki = new bool[10];
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 20; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                    Matrix[i, j] = rand.Next(0, 15);
                    if (Matrix[i, j] == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        F = true;
                    }
                    Console.Write(Matrix[i, j] + " ");
                }
                Console.WriteLine();
                if (F == true)
                {
                    stroki[i] = true;
                    F = false;
                }
            }
            Console.WriteLine("'5' содержится в строках: ");
            for (int i = 0; i < 10; i++)
            {
                if (stroki[i] == true) Console.Write((i + 1).ToString() + ", ");
            }
            Console.ReadKey();
        }
    }
}
