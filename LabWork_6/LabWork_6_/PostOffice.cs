using System.Collections.Generic;
namespace LabWork_6_
{
    public class PostOffice
    {
        public List<Employee> Employees { get; set; }

        public Dictionary<string, string[]> Poll()
        {
            // хеш-таблица сотрудник: [ответы на вопросы]
            Dictionary<string, string[]> answers = new Dictionary<string, string[]>();
            foreach (var employee in Employees)
            {
                string[] ans = new string[] { employee.Say(),
                    employee.WhatYouDo(),
                    employee is Cashier ? employee.WorkTime().ToString() + " дней" :
                    employee is Operator ? employee.WorkTime().ToString() + " месяцев" :
                    employee is Postman ? employee.WorkTime().ToString() + " лет" : null};
                answers.Add(employee.Say(), ans);
            }
            return answers;
        }
    }
}
