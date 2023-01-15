using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProject.Inheritance
{
    public class Student : NttDataBase
    {
        private string name { get; set; }
        private string surname { get; set; }
        private DateTime birthday { get; set; }
        private Address address { get; set; }

        public Student(string name, string surname, DateTime birthday, Address address)
        {
            this.address = address;
            this.name = name;
            this.surname = surname;
            this.birthday = birthday;
            this.address = address;
        }
    }
}
