using LabWork_9_.Interfaces;
namespace LabWork_9_.People
{
    class Student : Human, IQRCode, ICanPutOnMask, ICanDisinfectHand
    {
    	public bool IsHaveMask { get; set; }
        public bool IsHaveQR { get; set; }
    }
}
