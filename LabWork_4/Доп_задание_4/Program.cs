/*
 * Лабараторная работа №4
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание_7
 * 
 */


using System;
namespace Задание_7
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int[,] matr = new int[10, 10];
            Console.WriteLine("До перестановки: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    matr[i, j] = rand.Next(0, 100);
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matr[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else if (i + j == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matr[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            // Перестановка
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        matr[i, j] ^= matr[i, 10 - j - 1];
                        matr[i, 10 - j - 1] ^= matr[i, j];
                        matr[i, j] ^= matr[i, 10 - j - 1];
                    }
                }
            }
            // отрисовка массива после перестановки
            Console.WriteLine("После перестановки: ");
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write(matr[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else if (i + j == 9)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(matr[i, j] + "\t");
                        Console.ResetColor();
                    }
                    else Console.Write(matr[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
