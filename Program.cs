using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcar.cs
{
    class Program
    {
        static void PrintVehicle(Vehicle v)
        {
            Console.WriteLine(v._model);
            Console.WriteLine(v.ToString());
        }
        static void PrintVehicles(Vehicle[] v)
        {
            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i].ToString());
            }
        }
        
        static void Main(string[] args)
        {
            Car honda = new Car()
            {
                _model = "cx30",
                _maxNumOfPassengers = 5,
                _maxSpeed = 100,
                _numberOfDoors = 4,
                _numberOfWheels = 4
            };
            Car lamburgini = new Car()
            {
                _model = "g800",
                _maxNumOfPassengers = 2,
                _maxSpeed = 120,
                _numberOfDoors = 2,
                _numberOfWheels = 4
            };
            Motorcycle yamaha = new Motorcycle()
            {
                _numberOfWheels = 2,
                _maxSpeed = 90,
                _maxNumOfPassengers = 2,
                _model = "killer",
                _numberOfHandBreaks = 3
            };
            Motorcycle bmw = new Motorcycle()
            {
                _numberOfWheels = 2,
                _maxSpeed = 130,
                _maxNumOfPassengers = 2,
                _model = "bbg",
                _numberOfHandBreaks = 5
            };
            Carrier c = new Carrier()
            {
                vehicles = new Vehicle[2]
                {
                    honda,
                    bmw
                }
            };
        }
    }
}
