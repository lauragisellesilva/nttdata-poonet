using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Interface
{
    //Iclonable solo tiene el método clone()
    internal class Coche : IVehiculo, ICloneable
    {
        public void Arracar()
        {
            Console.WriteLine("Arrancar Coche");
        }
        public void Parar()
        {
            Console.WriteLine("Parar Coche");
        }
        public object Clone()
        {
            return this.Clone();
        }
    }
}
