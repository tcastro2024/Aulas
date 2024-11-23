using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Liskov_Substitution_Principle
{
    public class Customer : IDiscount, IDatabase //With Liskov_Substitution_Principle
    {
        public virtual void Add()
        {
            // Database code goes here  
        }

        public virtual double GetDiscount(double TotalSales)
        {
            return TotalSales;
        }
    }
}
