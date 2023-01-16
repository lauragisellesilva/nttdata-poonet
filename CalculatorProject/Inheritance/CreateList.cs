using System.Collections.Generic;
using System.Linq;

namespace CalculatorProject.Inheritance
{
    public class CreateList
    {
        public List<Student> CreateListStudents(List<Student> students) 
        {
            IEnumerable<Student> studentsList =
                from student in students
                where student.Name.StartsWith("S")
                select student;

            List<Student> likeadStudent = studentsList.ToList();
            return likeadStudent;
        }
    }
}
