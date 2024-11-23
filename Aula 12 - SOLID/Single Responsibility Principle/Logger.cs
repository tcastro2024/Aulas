using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility_Principle
{
    class Logger
    {
        public static void WriteLog()
        {
            Console.WriteLine("Logged Time:" 
                + DateTime.Now.ToLongTimeString() 
                + " Log  Data insertion completed successfully");
        }
    }
}
