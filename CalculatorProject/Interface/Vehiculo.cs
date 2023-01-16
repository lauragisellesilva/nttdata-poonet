using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Interface
{
    public abstract class Vehiculo
    {
        public abstract void Arrancar();
        public abstract void Parar();
        public void Test()
        {
            Console.WriteLine("This is a test");
        }
    }
}
