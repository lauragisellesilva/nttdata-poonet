using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Interface
{
    public class Principal
    {
        public static void Main(string[] args)
        {
            //Instanciamos dos clases del tipo ave pasando de parametro el nombre del ave
            Ave canario = new Ave("Canario");
            Ave cuervo = new Ave("Cuervo");
            //Creamos una instancia de nuestra clase principal para llamar el metodo imprimir()
            Principal main = new Principal();
            main.imprimir(canario);
            main.imprimir(cuervo);

            //cuando hago polimofismo de interfaces, solo me llevo los metodos de la interfaz
            //solo accedo a arrancar y parar -- no puedo acceder a clone() de la otra interfaz
            IVehiculo coche = new Coche();
            coche.Arracar();
            coche.Parar();

            //ICloneable clonable = new Coche();
            //clonable.Clone();

            //polimorfismo de clases
            Vehiculo vehiculo= new Camion();
            vehiculo.Arrancar();
            vehiculo.Parar();
            vehiculo.Test();

            Console.ReadKey();
        }
        /// Imprimir the specified ave.
        /// Este metodo imprimira las propiedades de una clase ave.
        /// 

        /// Ave.
        public void imprimir(Ave ave)
        {
            //Imprimimos el nombre del ave, el numero de patas y el numero de colas
            Console.WriteLine("Soy un {0} tengo {1} Pata(s), {2} Ala(s) y {3} Cola(s)", ave.Nombre, ave.Patas, ave.Alas, ave.Cola);
            //Llamamos a nuestros dos metodos de la interface Comer() y Volar()
            Console.WriteLine("Puedo ");
            ave.Comer();
            Console.WriteLine("y tambien puedo ");
            ave.Volar();
        }
    }
}
