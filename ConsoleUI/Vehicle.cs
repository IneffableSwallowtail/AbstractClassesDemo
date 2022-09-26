using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        public int year = 2010;
        public string make = "Toyota";
        public string model = "Camry";

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"You are driving in your vehicle.");
        }
    }
}
