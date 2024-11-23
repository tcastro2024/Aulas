using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Dependency_Inversion_Principle
{
    public class Program
    {
        static void Main(string[] args)
        {
            StudentWrong studentWrong = new StudentWrong(123);

            Console.WriteLine(studentWrong.StudentId);

            //Start without debugging
            //or
            Console.ReadKey(); // to see the vales on console application
        }
    }
}
