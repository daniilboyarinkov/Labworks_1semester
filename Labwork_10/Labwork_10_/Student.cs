using System;

namespace Labwork_10_
{
    public struct Student : IComparable<Student>
    {
        public int Number { get; set; }
        public int CountPhone { get; set; }
        public int CountLaunch { get; set; }
        public int Age { get; set; }
        public enum Position
        {
            High,
            Elementary,
            Preschool
        }
        private Position position;

        public Student(int number, int countPhone, int countLaunch, int age)
        {
            Number = number;
            CountPhone = countPhone;
            CountLaunch = countLaunch;
            Age = age;
            if (Age < 7) position = Position.Preschool;
            else if (Age > 7 & Age < 12) position = Position.Elementary;
            else position = Position.High;
        }

        public int CompareTo(Student other)
        {
            if (this.CountPhone < other.CountPhone) return -1;
            else if (this.CountPhone > other.CountPhone) return 1;
            else
            {
                if (this.position > other.position) return 1;
                else if (this.position < other.position) return -1;
                else return 0;
            }
        }
    }

}