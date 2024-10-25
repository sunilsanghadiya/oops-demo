using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oops_demo
{
    #region Inheritance Example
    public class InheritanceExample
    {
        public class Vehicle
        {
            public string Brand = "LandRover";
            public void Bike()
            {
                Console.WriteLine("LandRover, huuummm...");
            }
        }
        public class Bike : Vehicle
        {
            public string ModalName = "Ducati";
        }

        public class ExecuteVehicle
        {
            static void Main(string[] args)
            {
                Bike myBike = new Bike();
                myBike.Bike();
                Console.WriteLine(myBike.Brand + " " + myBike.ModalName);
            }
        }
    }
    #endregion
}
