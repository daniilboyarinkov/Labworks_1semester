using System;
namespace LabWork_6_
{
    public class Cashier : Employee
    {
        public override string WhatYouDo() => "Пополняю транспортные карты";

        public override int WorkTime() => Convert.ToInt32((DateTime.Today - DateOfEmployment).TotalDays);
    }
}
