using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcar.cs
{
    class Car : Vehicle
    {
        public int _numberOfDoors;
        public override int GetMaxNumOfPassengers()
        {
            return _maxNumOfPassengers;
        }

        public override int GetMaxSpeed()
        {
            return _maxSpeed;

        }

        public override string ToString()
        {
            return base.ToString() + $", number of doors: {_numberOfDoors}";
        }
    }
}
