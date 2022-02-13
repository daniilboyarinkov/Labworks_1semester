using System;
namespace LabWork_8_
{
    public class Car
    {
        public int ID { get; init; }

        // Двигатель в композиции с каром
        public Engine engine { get; }
        public Car()
        {
            // педали двигателя буквально рандомны
            var rand = new Random();
            engine = new Engine() { PedalSize = rand.Next(1, 100) };
        }
    }
}
