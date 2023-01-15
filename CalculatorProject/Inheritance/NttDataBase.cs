using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class NttDataBase
    {
        private Guid guid;

        //cada vez que se llama a una clase derivada, se llama al constructor vacío de la clase base
        public NttDataBase() { 
            guid = Guid.NewGuid();
        }

        public Guid Guid {
            get { return guid; }
        }
    }
}
