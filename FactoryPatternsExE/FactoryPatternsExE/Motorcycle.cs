using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPatternsExE
{
    public class Motorcycle : IVehicle
    {
        public Motorcycle()
        {

        }
        public void Build()
        {
            Console.WriteLine("Building a new Motorcycle");
            Drive.InDrive();
        }
    }
}
