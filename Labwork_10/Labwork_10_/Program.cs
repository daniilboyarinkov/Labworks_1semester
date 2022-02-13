using System;

namespace Labwork_10_
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime start = DateTime.Now;

            School school = new School();
            school.Students = new System.Collections.Generic.List<Student>();

            Random rand = new Random();

            for (int i=0; i<500000; i++)
            {
                school.Students.Add(new Student(number: i, countPhone: rand.Next(1, 1000), countLaunch: 1, age: rand.Next(3, 17)));
            }

            (Student, Student) MinMaxEmployee = school.FindMinMaxEmployee();
            school.Reward(ref MinMaxEmployee);

            DateTime end = DateTime.Now;
            Console.WriteLine((end-start).TotalSeconds);

            Console.ReadKey();

        }
    }
}