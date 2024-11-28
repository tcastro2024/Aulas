using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Aula_15___Expressoes_Lambda_e_LINQ
{
    /// <summary>
    /// Auxiliar
    /// </summary>
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public Student() { }
        public Student(string name, int age)
        {
            Name = name;
            Age = age;
        }
        public override string ToString()
        {
            return string.Format("Name: {0}, Age: {1} ", Name, Age);
        }
    }
}
