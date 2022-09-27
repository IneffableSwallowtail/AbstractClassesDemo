using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Threading;

namespace ConsoleUI
{
    public abstract class Vehicle
    {
        private int year = 2022;
        private string make = "Make";
        private string model = "Model";

        public int Year 
        { 
            get { return year; }
            set { year = value; }
        }
        public string Make
        {
            get { return make; }
            set { make = value; }
        }
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public abstract void DriveAbstract();
        public virtual void DriveVirtual()
        {
            Console.WriteLine($"You are driving in your vehicle.");
        }
    }
}
