using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Sphere : Shape
    {
        public double Radius { get; set; }

        public Sphere(double radius) {
            Radius = radius;
            Name = "Sphere";
        }
        public override double Volume()
        {
            return (4 / 3) * Math.PI * Math.Pow(Radius, 3);
        }
        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine("\nThe Sphere has a radius of {0}", Radius);
        }
    }
}
