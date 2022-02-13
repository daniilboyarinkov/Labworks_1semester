namespace LabWork_5_
{
    public class Cat
    {
        private string _name;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                if(string.IsNullOrEmpty(_name))
                {
                    _name = value;
                }
            }
        }
        public int Age { get; init; }
        public int Health { get; private set; } = 100;
        public string Color
        {
            get 
            {
                if (Health > 0) return "Зелёный";
                else return "Белый";
            }
        }
        public void Feed(int foodCount) => Health += foodCount;

        public void Punish(int hit) => Health -= hit;

        public string GetInfo() {return $"Информация о вашей кошке: \n Имя: {Name} \n Возраст: {Age} \n Здоровье: {Health} \n Цвет: {Color}";}

        public string Died(int limit)
        {
            if (Health >= limit) return "Ваша кошка умерла из-за того, что вы ее перекормили...";
            else if (Health <= 0)
            {
                Health = 0;
                return "Ваша кошка умерла из-за того, что у неё закончилось здоровье...";
            }
            else return "Я уже даже не знаю причину...";
        }
    }
}
