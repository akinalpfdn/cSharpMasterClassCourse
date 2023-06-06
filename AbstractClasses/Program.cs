using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Sphere(4),new Cube(5)};
            foreach(Shape Shape in shapes)
            {
                Shape.GetInfo();
                Console.WriteLine("\n{0} has a volume of {1}",Shape.Name, Shape.Volume());
                Cube iceCube = Shape as Cube;
                if(iceCube == null)
                {
                    Console.WriteLine("This Shape is no Cube");
                }
                else
                {
                    Console.WriteLine("This is a Cube");
                }
            }
            Console.ReadKey();
        }
    }
}
