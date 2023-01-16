using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Student : NttDataBase
    {
        //TODO: Hacer en student. int age y que cuando me escriban en birthday escriba la propiedad.
        private string name { get; set; }
        private int age { get; set; }
        private string surname { get; set; }
        private DateTime birthday { get; set; }
        private Address address { get; set; }

        public Student(string name, string surname, DateTime birthday, Address address)
        {
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.address = address;
        }

        public string Name   // property
        {
            get { return name; }   // get method
            set { name = value; }  // set method
        }
    }
}
