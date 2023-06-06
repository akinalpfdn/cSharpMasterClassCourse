using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismExample
{

    internal class M3 : BMW
    {
        public M3(string HP, string Color, string Model) : base(HP, Color, Model)
        {
        }
        public new void Repair()
        {
            Console.WriteLine("THE BBMW {0}  was repaired!", Model);
        }
    }
}
