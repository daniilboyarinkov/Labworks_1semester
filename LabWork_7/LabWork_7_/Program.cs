using System;

namespace LabWork_7_
{
    class Program
    {
        static void Main(string[] args)
        {
            // cписок персонала 
            Cashier c1 = new Cashier { FirstName = "Алексей", LastName="Алексеев", Qualification="стажер" };             // 1
            Cashier c2 = new Cashier { FirstName = "Владимир", LastName = "Володьев", Qualification = "кассир" };        // 2
            Cashier c3 = new Cashier { FirstName = "Андрей", LastName = "Андреев", Qualification = "кассир" };           // 3 
            Cashier c4 = new Cashier { FirstName = "Сергей", LastName = "Иванов", Qualification = "старший кассир" };    // 4
            Loader l1 = new Loader { FirstName = "Игорь", LastName = "Игорев" };                                         // 5
            Loader l2 = new Loader { FirstName = "Авраам", LastName = "Абрамов" };                                       // 6
            Loader l3 = new Loader { FirstName = "Петр", LastName = "Петров" };                                          // 7
            Loader l4 = new Loader { FirstName = "Сергей", LastName = "Сергеев" };                                       // 8

            // Добавление персонала в общий список
            Commander commander = new Commander();
            commander.All_Employees = new System.Collections.Generic.List<Employee> { l4, l2, c2, l1, c4, c1, l3, c3};

            // рандомно генерируем список перонала на завтра
            commander.Tomorrow_Employees = new System.Collections.Generic.List<Employee> {  };
            for (int i=0; i<commander.All_Employees.Count; i++)
            {
                // коэффицент удачи
                Random random = new Random();
                double coefficient = random.NextDouble();
                if (coefficient < 0.67) commander.Tomorrow_Employees.Add(commander.All_Employees[i]);
            }

            //Вывод
            Console.WriteLine($"Сотрудники завтрашнего дня: \n{commander.PrintTeam()} \n");
            Console.WriteLine($"Все кассиры: \n{commander.PrintBadgeForAllCashiers()} \n");
        }
    }
}
