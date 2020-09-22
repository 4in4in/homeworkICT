using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkICT
{
    abstract class calculateCapacity
    {
        public string calculatingType { get; set; }

        public calculateCapacity() { }

        private void initCalcutating()
        {
            Console.WriteLine("Вычисление потока: {0}", calculatingType);
        }
        public void templateMethod()
        {
            initCalcutating();
            calculate();
        }

        public abstract void calculate();
    }
}
