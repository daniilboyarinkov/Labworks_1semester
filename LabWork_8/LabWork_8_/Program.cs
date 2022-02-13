using System;
using System.Collections.Generic;

namespace LabWork_8_
{
    class Program
    {
        static void Main(string[] args)
        {
            FactoryAF factory = new FactoryAF();
            factory.Customers = new List<Customer>() { 
                new Customer() { FIO="Иванов Ивандолий Иванович" },
                new Customer() { FIO="Алексеев Алексей Алексеевич" },
                new Customer() { FIO="Петрович Петр Петрович" },
                new Customer() { FIO="Дмитриев Дмитрий Дмитриевич" },
                new Customer() { FIO="Абрамов Авраам Авраамович" },
                new Customer() { FIO="Иуда Георгий Иудзаевич" },
                new Customer() { FIO="Киевский Ести Чебуречкин" },
                new Customer() { FIO="Сергеев Серж Серёжович" },
                new Customer() { FIO="Поносоник Поноси Поносонович" },
            };

            Console.WriteLine("ДО ПРОДАЖИ МАШИН");

            Console.WriteLine($"На складе фабрики осталось {factory.Cars.Count} машин");
            factory.Cars.ForEach(car => Console.WriteLine($"\t ID машины: {car.ID} \t Размер педали двигателя: {car.engine.PedalSize}"));

            Console.WriteLine();

            Console.WriteLine($"На данный момент у нас {factory.Customers.Count} покупателей");
            factory.Customers.ForEach(customer => Console.WriteLine($"\t ФИО покупателя: {customer.FIO} \t" +
                $"ID Машины: {(customer.HasCar ? customer.Car.ID : "Ещё нет машины...")}"));

            // Продаем машины
            factory.SaleCar();

            for (int i = 0; i<120; i++)
            {
                Console.Write("*");
            }

            Console.WriteLine();

            Console.WriteLine("ПОСЛЕ ПРОДАЖИ");

            Console.WriteLine($"На складе фабрики осталось {factory.Cars.Count} машин");
            factory.Cars.ForEach(car => Console.WriteLine($"\t ID машины: {car.ID} \t Размер педали двигателя: {car.engine.PedalSize}"));

            Console.WriteLine();

            Console.WriteLine($"На данный момент у нас {factory.Customers.Count} покупателей");
            factory.Customers.ForEach(customer => Console.WriteLine($"\t ФИО покупателя: {customer.FIO} \t" +
                $"ID Машины: {(customer.HasCar ? customer.Car.ID : "Ещё нет машины...")}"));
        }
    }
}
