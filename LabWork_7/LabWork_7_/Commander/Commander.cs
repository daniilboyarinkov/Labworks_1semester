using System;
using System.Collections.Generic;

namespace LabWork_7_
{
    public class Commander
    {
        public List<Employee> All_Employees = new List<Employee>();
        public List<Employee> Tomorrow_Employees = new List<Employee>();
        public string PrintTeam()
        {
            string result = String.Empty;
            foreach (Employee employee in Tomorrow_Employees)
            {
                result += $"{employee.GetFullName()} \n";
            }
            return result;
        }
        public string PrintBadge(Cashier cashier) => cashier.GetFullName();

        public string PrintBadgeForAllCashiers()
        {
            string result = String.Empty;
            foreach (Employee employee in All_Employees)
            {
                if (employee is Cashier) result += $"{PrintBadge(employee as Cashier)} \n";
            }
            return result;
        }
    }
}
