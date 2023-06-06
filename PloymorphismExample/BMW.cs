using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismExample
{
    //classes can also be sealed
    //a BMW is a Car
    // sealed internal class BMW : Car
    internal class BMW : Car
    {
    
        private string Brand = "BMW";
        public string Model;
        public BMW(string HP, string Color,string Model) : base(HP, Color)
        {
            this.Model = Model;
        }

        public new void ShowDetails()
        {
            Console.WriteLine("The Car's Model is{0} and brand is {1}", Model, Brand);
        }
        //to seal for this class' child classes use sealed
        public sealed override void Repair()
        {
            Console.WriteLine("{0} {1} was repaired!",Brand,Model);
        }
    }
}
