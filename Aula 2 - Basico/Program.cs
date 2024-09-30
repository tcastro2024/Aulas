using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_2___Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            Student.name = "Alex";
            Student.average = 15.5;

            Console.WriteLine("Average: {0}", Student.average );
            Console.WriteLine("Course: {0}", Student.GetCourse());

            Console.ReadKey();
        }
    }
}
