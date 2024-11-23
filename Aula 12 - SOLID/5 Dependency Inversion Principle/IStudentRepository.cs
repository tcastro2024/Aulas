using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dependency_Inversion_Principle
{
    public interface IStudentRepository
    {
        void AddStudent(Student std);
        void EditStudent(Student std);
        void DeleteStudent(Student std);

        IList<Student> GetAllStudents();
    }
}
