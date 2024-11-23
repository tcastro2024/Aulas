using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace Single_Responsibility_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
            // https://www.tutorialsteacher.com/csharp/single-responsibility-principle
            // https://www.digitalocean.com/community/conceptual_articles/s-o-l-i-d-the-first-five-principles-of-object-oriented-design
            //Classes only have one responsibility

            DataAccess.InsertData();
            Logger.WriteLog();

            //Start without debugging
            //or
            Console.ReadKey(); // to see the vales on console application
        }
    }
}
