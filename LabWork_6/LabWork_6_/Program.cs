using System;
using System.Collections.Generic;
using System.Threading;

namespace LabWork_6_
{
    class Program
    {
        static void Main(string[] args)
        {
            // инициализация персонала
            Cashier c1 = new Cashier { Name="Алексей", DateOfEmployment=DateTime.Parse("21/02/2021")};  // 1
            Cashier c2 = new Cashier { Name="Владимир", DateOfEmployment=DateTime.Parse("1/10/2020")};  // 2
            Cashier c3 = new Cashier { Name="Андрей", DateOfEmployment=DateTime.Parse("4/09/2003")};    // 3 
            Operator o1 = new Operator { Name="Сергей", DateOfEmployment=DateTime.Parse("8/08/2015")};  // 4
            Operator o2 = new Operator { Name="Игорь", DateOfEmployment=DateTime.Parse("12/12/2019")};  // 5
            Operator o3 = new Operator { Name="Авраам", DateOfEmployment=DateTime.Parse("31/01/1999")}; // 6
            Postman p1 = new Postman { Name="Петрович", DateOfEmployment=DateTime.Parse("24/04/1968")}; // 7
            Postman p2 = new Postman { Name="Сергеич", DateOfEmployment=DateTime.Parse("15/03/1942")};  // 8

            // добавление персонала в postoffice коллекцию 
            PostOffice postoffice = new PostOffice();
            postoffice.Employees = new System.Collections.Generic.List<Employee> { c3, o2, o3, c2, o1, p1, c1, p2 };

            // коллекция вопросов 
            List<string> questions = new List<string>();
                questions.Add("А вас как зовут?");
                questions.Add("А что вы тут делаете?");
                questions.Add("И давно вы тут работаете?");

            // Мешаем персоналу работать
            while (true)
            {
                foreach (KeyValuePair<string, string[]> worker_answer in postoffice.Poll())
                {
                    foreach (string answer in worker_answer.Value)
                    {
                        Thread.Sleep(700);
                        Console.WriteLine(questions[Array.IndexOf(worker_answer.Value, answer)]);
                        Console.WriteLine(answer);
                    }
                    Console.WriteLine();
                    Thread.Sleep(1000);
                }
                Thread.Sleep(10000);
            }
        }
    }
}
