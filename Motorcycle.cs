using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcar.cs
{
    class Motorcycle: Vehicle
    {
        public int _numberOfHandBreaks;

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
            return base.ToString() + $", number of hand breaks: {_numberOfHandBreaks}";
        }
    }
}
