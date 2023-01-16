using System;
using System.Collections;
using System.Collections.Generic;

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

            // Polymorphism at work #1: a Rectangle, Triangle and Circle
            // can all be used wherever a Shape is expected. No cast is
            // required because an implicit conversion exists from a derived
            // class to its base class.
            var shapes = new List<Shape>
            {
                new Rectangle(),
                new Triangle(),
                new Circle()
            };

            // Polymorphism at work #2: the virtual method Draw is
            // invoked on each of the derived classes, not the base class.
            foreach (var shape in shapes)
            {
                shape.Draw();
            }
            /* Output:
                Drawing a rectangle
                Performing base class drawing tasks
                Drawing a triangle
                Performing base class drawing tasks
                Drawing a circle
                Performing base class drawing tasks
            */
        }
    }
}
