using System;
using System.Collections;

namespace CalculatorProject.Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList array = new ArrayList();
            Student student = new Student();
            student.Name= "Pepe";

            //Boxing And Autoboxing
            array.Add(student);

            Console.WriteLine(array);

            Console.WriteLine(((Student)array[0]).Name);

            //array[0].Name error
            Object obj = new Student();
            ((Student)obj).Name = "Alberto"; //unboxing
            Console.WriteLine(((Student)obj).Name);
        }
    }
}
