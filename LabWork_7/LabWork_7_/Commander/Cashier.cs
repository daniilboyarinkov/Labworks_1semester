namespace LabWork_7_
{
    public class Cashier : Employee
    {
        public string Qualification { get; set; }

        public new string GetFullName() => $"{base.GetFullName()} \n \t {Qualification} \n";
    }
}
