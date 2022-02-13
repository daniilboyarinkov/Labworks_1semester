using System.Collections.Generic;
namespace LabWork_8_
{
    public class FactoryAF
    {
        // покупатели в агрегации с фабрикой
        public List<Customer> Customers { get; set; }
        // кары в композиции с фабрикой
        public List<Car> Cars { get; }
        public FactoryAF()
        {
            Cars = new List<Car>();
            for (int i = 0; i < 7; i++)
            {
                Cars.Add(new Car() { ID = i + 1 });
            }
        }
        public void SaleCar()
        {
            Customers.ForEach(customer => { 
                if (Cars.Count > 0)
                {
                    customer.Car = Cars[0];
                    customer.HasCar = true;
                    Cars.Remove(Cars[0]);
                }
            });

            if (Cars.Count > 0)
            {
                Cars.Clear();
            }
        }
    }
}
