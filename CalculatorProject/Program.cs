using System;

namespace CalculatorProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Hello word");

            //solo se ejecuta en debug y está dentro del compilado
            //en el ejecutable del release no estaran, porque son instrucciones precompiladas/reprocesadas
            #if DEBUG
                Console.WriteLine("debug version");
            #else
                Console.WriteLine("release version");
            #endif

            //se ejecuta en debugy en reease. y está dentro del compilado
            if (i == 1)
                Console.WriteLine("Hello Laura");
        }
    }
}
