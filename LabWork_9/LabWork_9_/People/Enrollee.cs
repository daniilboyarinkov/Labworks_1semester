using LabWork_9_.Interfaces;
namespace LabWork_9_.People
{
    class Enrollee : Human, IQRCode, ICanDisinfectHand, ICanPutOnMask
    {
    	public bool IsHaveMask { get; set; }
        public bool IsHaveQR { get; set; }
    }
}
