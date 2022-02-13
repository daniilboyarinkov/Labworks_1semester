/*
 * Лабараторная работа №3
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание №5
 */

using System;
namespace Задание_5
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----------------");

            // тройки 
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++) {
                    Console.Write('3');
                }
                Console.Write("\n");
            }

            Console.WriteLine("-----------------");

            // звёздочки
            for (int i=1; i<6; i++)
            {
                for (int j=0; j<i; j++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }

            Console.WriteLine("-----------------");

            // цифры 
            for (int i=1; i<=16; i++)
            {
                Console.Write(Convert.ToString(i) + ' ');
                if (i % 4 == 0)
                {
                    Console.Write("\n");
                }
            }

            Console.WriteLine("-----------------");

            // 1 и 0
            int[] arr = new int[5];
            for (int i=0; i<5; i++)
            {
                arr[i] = 1;
                arr[arr.Length-i-1] = 1;
                foreach (int num in arr)
                {
                    Console.Write(num);
                }
                arr[i] = 0;
                arr[arr.Length-i-1] = 0;    
                Console.Write("\n");
            }

            Console.WriteLine("-----------------");
        }
    }
}
