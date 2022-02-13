using System;
using System.Collections.Generic;


namespace Labwork_10_
{
	public class School
	{
		public List<Student> Students { get; set; }

		public (Student, Student) FindMinMaxEmployee()
        {
			Students.Sort();
			return (Students[Students.Count-1], Students[0]);
        }
		public void Reward(ref (Student MinStudent, Student MaxStudent) tuple)
        {
			tuple.MaxStudent.CountLaunch++;
			tuple.MinStudent.CountLaunch--;
        }
	}
}
