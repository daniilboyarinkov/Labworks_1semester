using System;
namespace LabWork_5_
{
    class Program
    {
        static void Main(string[] args)
        {
            int limitHealth = 1000;
            Console.WriteLine("Сколько лет вашей кошке? ");
            int age;
            while (true)
            {
                while (!int.TryParse(Console.ReadLine(), out age))
                {
                    Console.Write("Скорее всего вы ввели невозможное значение для возраста кошки " +
                        "\n Попробуйте снова: ");
                }
                if (age <= 0) Console.WriteLine("Ваша кошка ещё не родилась? \n Сколько лет вашей кошке на самом деле?");
                else if (age > 55) Console.WriteLine("Не обманывайте, кошки столько не живут... \n Сколько лет вашей кошке на самом деле?");
                else break;
            }

            // кошка появись
            Cat cat = new Cat() { Age = age };

            // ask user for cat's name
            Console.Write("Как зовут вашу кошку?: ");
            string name = Console.ReadLine();
            while (String.IsNullOrEmpty(name)) {
                Console.WriteLine("Кошка не может не иметь имени...");
                name = Console.ReadLine();
            }

            // set cat's name
            cat.Name = name;

            // check name
            Console.Write("Повторите имя вашей кошки: ");
            cat.Name = Console.ReadLine();

            // цикл игры
            while (cat.Health > 0 && cat.Health < limitHealth)
            {
                Console.WriteLine("\n Меню: \n \t Введите: \n \t 1 - чтобы покормить свою кошку \n \t 2 - чтобы наказать " +
                    "\n \t 3 - чтобы посмотреть информацию про неё");
                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine("На сколько foodCount вы хотите её покормить? (введите число): ");
                        int foodcount;
                        while (!int.TryParse(Console.ReadLine(), out foodcount)) {Console.WriteLine("Вы уверены, что умеете писать числа? " +
                            "\n Попробуйте снова...");}
                        cat.Feed(foodcount);
                        break;
                    case "2":
                        Console.WriteLine("На сколько hits вы хотите её наказать? (введите число): ");
                        int hits;
                        while (!int.TryParse(Console.ReadLine(), out hits)) {Console.WriteLine("Вы уверены, что умеете писать числа? " +
                            "\n Попробуйте снова...");}
                        cat.Punish(hits);
                        break;
                    case "3":
                        Console.WriteLine(cat.GetInfo());
                        break;
                    default:
                        Console.WriteLine("Возможно вы хотели написать что-то другое \n Попробуйте снова...");
                        break;
                }
            }
            Console.WriteLine(cat.Died(limitHealth));
            Console.WriteLine(cat.GetInfo());
            Console.WriteLine("...END...");
            Console.ReadKey();
        }
    }
}
