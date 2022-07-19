using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExE
{
    static class VechicleFactory
    {
        public static IVehicle GetVehicles(int numWheels)
        {
            if (numWheels == 4)
            {
                return new Car();
            }
            else if (numWheels == 2)
            {
                return new Motorcycle();
            }
            else
            {
                return null;
            }  
        }
    }
}
