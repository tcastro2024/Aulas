using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dependency_Inversion_Principle
{
    public class StudentWrong
    {
        public int StudentId { get; set; } //Make sense have set method?
        public string FirstName { get; set; }
        public int LastName { get; set; }
        public DateTime DoB {  get; set; } 

        public StudentWrong(int studentId)
        {
            this.StudentId = studentId;
        }

        //tight coupling to other class
        private StudentRepository studentRepository = new StudentRepository();

        public StudentWrong()
        {

        }

        public void Save()
        {
            studentRepository.AddStudent(this);
        }
    }
}
