using System;
namespace LabWork_6_
{
    public abstract class Employee
    {
        public string Name { get; init; }
        public DateTime DateOfEmployment { get; init; }

        public string Say() => Name ;
        public virtual int WorkTime() => 0;
        public virtual string WhatYouDo() => null;
    }
}
