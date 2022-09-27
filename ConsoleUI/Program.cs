using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate over each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            

            List<Vehicle> vehicles = new List<Vehicle>();

            Car car1 = new Car() { Make = "Chevrolet", Model = "Corvette", Doors = 2 };
            Motorcycle motorcycle1 = new Motorcycle() { Make = "Harley-Davidson", Model = "Softail Standard", Year = 2015, Type = "Cruiser" };
            Vehicle car2 = new Car() { Make = "Ford", Model = "F-150", Year = 2008, Doors = 4 };
            Vehicle motorcycle2 = new Motorcycle() { Make = "Honda", Model = "CRF250F", Year = 2020, Type = "Off-road" };

            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);

            foreach (var vehicle in vehicles)
            {
                Console.Write($"The {vehicle.Year} {vehicle.Make} {vehicle.Model} ");
                if (vehicle is Car)
                {
                    Car v = vehicle as Car;
                    Console.WriteLine($"has {v.Doors} doors.\n");
                }
                else if (vehicle is Motorcycle)
                {
                    Motorcycle m = vehicle as Motorcycle;
                    string vowels = "aeiou";
                    string an;
                    if (vowels.Contains(char.ToLower(m.Type[0])) == true) an = "n";
                    else an = "";
                    Console.WriteLine($"is a{an} {m.Type.ToLower()} motorcycle.\n");
                }
            }

            car1.DriveAbstract();
            car1.DriveVirtual();
            motorcycle2.DriveAbstract();
            motorcycle2.DriveVirtual();
        }
    }
}
