﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismExample
{

    internal class Program
    {
        static void Main(string[] args)
        {

            var cars = new List<Car>()
            {
                new Audi("200","blue","A4"),
                new BMW("250","red","M4")
            };
            foreach (Car car in cars)
            {
                car.Repair();
            }
            Car bmwZ3 = new BMW("200", "black", "Z3");
            Car audiA3 = new BMW("200", "red", "A3");
            bmwZ3.SetCarIDInfo(1, "Akinalp");
            audiA3.SetCarIDInfo(2, "Mehmet");
            bmwZ3.GetCarIDInfo();
            audiA3.GetCarIDInfo();
            Console.ReadKey();
        }
    }
}
