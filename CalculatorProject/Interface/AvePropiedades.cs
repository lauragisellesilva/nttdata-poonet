﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Interface
{
    public class AvePropiedades : IAve
    {
        public int Patas = 2;
        public int Alas = 2;
        public int Cola = 1;
        public string Nombre { get; private set; }
        public AvePropiedades(string NAve)
        {
            this.Nombre = NAve;
        }
        public void Comer()
        {
            Console.WriteLine("Ave comiendo");
        }

        public void Volar()
        {
            Console.WriteLine("Ave volando");
        }
    }
}
