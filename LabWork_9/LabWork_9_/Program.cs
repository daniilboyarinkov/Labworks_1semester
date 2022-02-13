using LabWork_9_.People;
using LabWork_9_.Animals;
namespace LabWork_9_
{
    class Program
    {
        static void Main(string[] args)
        {
            // инициализируем КПП
            Checkpoint checkpoint = new Checkpoint();
            // Устанавливаем значения SIZ
            checkpoint.SetSIZ(masks: 21, anticeptic: 100);
            System.Console.WriteLine(checkpoint.GetSIZ());
            // Получаем список желающих
            checkpoint.VisitorsWantToISIT = new System.Collections.Generic.List<Interfaces.IVisitor>() {
            new Teacher() { Name = "Иванов Иван Иванович", IsHaveMask = true, IsHaveQR = true},
            new Student() { Name = "Сергеев Сергей Сергеевич", IsHaveMask = false, IsHaveQR = false },
            new Enrollee() { Name = "Андреев Андрей Андреевич", IsHaveMask = false, IsHaveQR = true },
            new Student() { Name = "Просто Студент", IsHaveMask = true, IsHaveQR = false },
            new Dove() { Name = "Просто Голубь" },
            new Dog() { Name = "Достопочейнейший Заслуженный Пес России", IsHaveMask = false },
            new Dog() { Name = "Шарик", IsHaveMask = true },
            new Squirrel() { Name = "Просто Белка" },
            };

            // Проверяем кто из них может пройти
            System.Console.WriteLine($"\nХотят войти: \n");
            checkpoint.VisitorsWantToISIT.ForEach(visitor => System.Console.WriteLine(visitor.Name));
            checkpoint.Check();
            System.Console.WriteLine("\nМогут войти: \n");
            checkpoint.VisitorsCanToISIT.ForEach(visitor => System.Console.WriteLine(visitor.Name));

            //Проверяем сколько масок и антисептика осталось
            System.Console.WriteLine(checkpoint.GetSIZ());
        }
    }
}
