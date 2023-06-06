using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TextFileHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var lines = System.IO.File.ReadAllLines(@"C:\Users\akina\Downloads\input.txt");
            if(lines != null)
            {
                string output = "";
                foreach(var line in lines)
                {
                    if(line.Contains("split"))
                    {
                        output += line.Split()[4]+" ";
                    }
                }
                System.IO.File.WriteAllText(@"C:\Users\akina\Downloads\output.txt", output.Trim());
            }
            //Console.ReadKey();
        }

        public static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int
            float floatNumber = float.Parse(stringForFloat);
            int inttNumber = int.Parse(stringForInt);
        }
    }
}
