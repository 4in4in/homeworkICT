using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HomeWorkICT
{
    class Program
    {
        public static Random rnd;
        static void Main()
        {
            rnd = new Random();

            controller ctrl = controller.instance;
            ctrl.startProcess(4);
            ctrl.printReport();
            Console.ReadLine();
        }
    }
}
