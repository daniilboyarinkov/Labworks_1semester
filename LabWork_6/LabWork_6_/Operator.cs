using System;
namespace LabWork_6_
{
    public class Operator : Employee
    {
        public override string WhatYouDo() => "Ищу посылку";

        public override int WorkTime() => Convert.ToInt32((DateTime.Today - DateOfEmployment).TotalDays) / 30;
    }
}
