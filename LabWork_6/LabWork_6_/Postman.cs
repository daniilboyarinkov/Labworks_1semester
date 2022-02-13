using System;
namespace LabWork_6_
{
    public class Postman : Employee
    {
        public override string WhatYouDo() => "Разношу почту, не мешайте";

        public override int WorkTime() => Convert.ToInt32((DateTime.Today - DateOfEmployment).TotalDays) / 365;
    }
}
