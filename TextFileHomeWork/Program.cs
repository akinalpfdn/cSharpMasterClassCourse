using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TextFileHomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
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
            */
            //Console.ReadKey();
            var text = System.IO.File.ReadAllText(@"C:\Users\akina\Downloads\input2.txt");
            Regex regex = new Regex(@"\d{2,3}");
            MatchCollection matches = regex.Matches(text);
            string result = string.Empty;
            foreach (Match match in matches)
            {
                result += (char)int.Parse(match.Groups[0].Value);
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }

    }
    
}
