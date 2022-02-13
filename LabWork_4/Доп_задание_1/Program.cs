/*
 * Лабараторная работа №4
 * 
 * Бояринков Даниил Владимирович
 * Группа: КИ21-22Б
 * 
 * Задание_1
 * 
 */

using System;
namespace Задание_1
{
    class Program
    {

        static void Main(string[] args)
        {
            // генерация нового рандом объекта
            Random rand = new Random();
            Console.Write("N: ");
            string N = Console.ReadLine();
            int n;
            while (!int.TryParse(N, out n))
            {
                Console.WriteLine("Вы ввели невозможное значение для N");
                Console.Write("Попробуйте снова: ");
                N = Console.ReadLine();
            }
            n = Convert.ToInt32(N);

            // Заполнение массива рандомными числами + упорядочивание 
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-1000, 1000);
            }
            Array.Sort(arr);
            foreach (int h in arr)
            {
                Console.Write(Convert.ToString(h) + ' ');
            }
            Console.WriteLine(' ');
            // P и Q
            Console.Write("P: ");
            string P = Console.ReadLine();
            int p;
            while (!int.TryParse(P, out p))
            {
                Console.WriteLine("Вы ввели невозможное значение для P");
                Console.Write("Попробуйте снова: ");
                P = Console.ReadLine();
            }
            p = Convert.ToInt32(P);

            Console.Write("Q: ");
            string Q = Console.ReadLine();
            int q;
            while (!int.TryParse(Q, out q))
            {
                Console.WriteLine("Вы ввели невозможное значение для Q");
                Console.Write("Попробуйте снова: ");
                Q = Console.ReadLine();
            }
            q = Convert.ToInt32(Q);

            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (arr[i] > p && arr[i] < q) count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}

