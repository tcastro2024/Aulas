using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dependency_Inversion_Principle
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DoB { get; set; }

        private IStudentRepository iStudentRepository;

        public Student(IStudentRepository stdRepo)
        {
            iStudentRepository = stdRepo;
        }

        public void Save()
        {
            iStudentRepository.AddStudent(this);
        }
    }
}
