using LabWork_9_.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace LabWork_9_
{
    public class Checkpoint
    {
        public List<IVisitor> VisitorsWantToISIT { get; set; }
        public List<IVisitor> VisitorsCanToISIT { get; private set; } = new List<IVisitor>();
        private int Masks { get; set; }
        private int Anticeptic { get; set; }

        public void Check()
        {
            VisitorsWantToISIT.ForEach(visitor => { 
                if (visitor is IQRCode)
                {
                    if (!(visitor as IQRCode).IsHaveQR)
                    {
                        // Выгоняем
                        return;
                    }
                }
                if (visitor is ICanPutOnMask)
                {
                    if (!(visitor as ICanPutOnMask).IsHaveMask)
                    {
                        // Выдаем маску
                        if (Masks > 0) Masks--;
                        else return;
                        
                    }
                }
                if (visitor is ICanDisinfectHand)
                {
                    // дезинфицируем ему руки
                    if (Anticeptic > 0) {
                        Anticeptic--;

                        // Переносим визитора в другой список
                        VisitorsCanToISIT.Add(visitor);
                        VisitorsWantToISIT.ToList().Remove(visitor);
                    }
                    else return;
                }
            });
        }

        public void SetSIZ(int masks, int anticeptic)
        {
            Masks = masks;
            Anticeptic = anticeptic;
        }
        public string GetSIZ()
        {
            return $"\nНа КПП осталось:\n{Masks} масок\n{Anticeptic} антисептика";
        }
    }
}
