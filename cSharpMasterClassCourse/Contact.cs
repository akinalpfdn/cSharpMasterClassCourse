using System;

namespace cSharpMasterClassCourse
{
    public class Contact
    {
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public Contact()
        {
            name = "default";
            phoneNumber = "default";
        }
        public Contact(string name, string phoneNumber)
        {
            this.name = name;
            this.phoneNumber = phoneNumber;
        }
        public void Call()
        {

            Console.WriteLine("Calling to {0}. Phone number is {1}", name, phoneNumber);
        }

    }
}