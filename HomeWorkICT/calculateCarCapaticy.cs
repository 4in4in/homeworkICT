using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkICT
{
    class calculateCarCapacity : calculateCapacity
    {

        public calculateCarCapacity():
            base()
        {
            calculatingType = "Автомобильный поток";
        }
        public override void calculate()
        {
            throw new NotImplementedException();
        }
    }
}
