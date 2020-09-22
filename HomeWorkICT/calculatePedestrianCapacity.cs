using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkICT
{
    class calculatePedestrianCapacity : calculateCapacity
    {
        public calculatePedestrianCapacity()
            : base()
        {
            calculatingType = "Пешеходный поток";
        }
        public override void calculate()
        {
            throw new NotImplementedException();
        }
    }
}
