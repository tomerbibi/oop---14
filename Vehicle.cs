using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcar.cs
{
    abstract class Vehicle
    {
        public int _numberOfWheels;
        public string _model;
        public int _maxNumOfPassengers;
        public int _maxSpeed;
        public abstract int GetMaxNumOfPassengers();
        public abstract int GetMaxSpeed();

        public override string ToString()
        {
            return $"model: {_model}, mumber of wheels: {_numberOfWheels}, max number of passengers: {_maxNumOfPassengers}, maximum speed: {_maxSpeed}";
        }
    }
}
