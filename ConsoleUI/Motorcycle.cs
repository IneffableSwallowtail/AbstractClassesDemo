using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
        public override void DriveAbstract()
        {
            Console.WriteLine("You are riding on your motorcycle.");
        }
        public override void DriveVirtual()
        {
            Console.WriteLine("The wind whips against your helmet.");
        }

        public string Type { get; set; }
    }
}
