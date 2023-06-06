using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismExample
{
    internal class Audi : Car
    {
        private string Brand = "Audi";
        public string Model;
        public Audi(string HP, string Color, string Model) : base(HP, Color)
        {
            this.Model = Model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The Car's Model is{0} and brand is {1}", Model, Brand);
        }
        public new void Repair()
        {
            Console.WriteLine("{0} {1} was repaired!", Brand, Model);
        }
    }
}
