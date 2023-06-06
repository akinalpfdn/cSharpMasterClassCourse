using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PloymorphismExample
{
    internal class Car
    {
        public string HP { get; set; }
        public string Color { get; set; }

        //has a relationShip
        protected CarIDInfo carIDInfo = new CarIDInfo();

        public void SetCarIDInfo(int idNum,string owner)
        {
            carIDInfo.IDNum = idNum;
            carIDInfo.Owner = owner;
        }

        public void GetCarIDInfo()
        {
            Console.WriteLine("The car has the ID of {0} and owned by {1}",carIDInfo.IDNum,carIDInfo.Owner);
        }

        public Car(string HP, string Color) {
            this.HP = HP;
            this.Color = Color;
        
        }

        public void ShowDetails()
        {
            Console.WriteLine("The Hp of the Car is {0} and Color of the Car is {1}",HP,Color);
        }

        public virtual void Repair()
        { 
            Console.WriteLine("Car was repaired!");
        }
    }
}
