using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExE
{
    public class Car : IVehicle
    {
        public Car()
        {

        }
        public bool hasTrunk { get; set; }
        public void Build()
        {
            Console.WriteLine("Building a new car");
            Drive.InDrive();
        }
    }
}
