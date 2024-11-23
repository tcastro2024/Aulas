using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dependency_Inversion_Principle
{
    public class StudentRepository
    {
        public void AddStudent(StudentWrong std)
        {
            //Add students
        }

        public void DeleteStudent(StudentWrong std)
        {
            //Delete students
        }

        public void EditStudent(StudentWrong std)
        {
            //Edit students
        }

        public IList<StudentWrong> GetAllStudents()
        {
           return new List<StudentWrong>();
        }
    }
}
