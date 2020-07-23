using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeworkcar.cs
{
    class Carrier
    {
        public Vehicle[] vehicles;

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < vehicles.Length; i++)
            {
                s = s + vehicles[i].ToString();
            }
            return s;
        }
    }
}
