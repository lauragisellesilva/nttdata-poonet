using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Interface
{
    internal class Moto : IVehiculo, ICloneable
    {
        public void Arracar()
        {
            Console.WriteLine("Arrancar Moto");
        }
        public void Parar()
        {
            Console.WriteLine("Arrancar Moto");
        }
        public object Clone()
        {
            return new Moto();
        }
    }
}
