using LabWork_9_.Interfaces;
namespace LabWork_9_.Animals
{
    public class Dog : Animal, ICanPutOnMask
    {
        public bool IsHaveMask { get; set; }
    }
}
