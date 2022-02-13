using System;
namespace LabWork_7_
{
    public abstract class Employee
    {
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string GetFullName() => String.Concat(LastName, " ", FirstName);
    }
}
