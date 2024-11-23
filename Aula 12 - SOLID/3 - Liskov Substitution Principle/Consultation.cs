using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Liskov_Substitution_Principle
{
    public class Consultation: Customer
    {
        public override double GetDiscount(double TotalSales)
        {
            return base.GetDiscount(TotalSales) - 5;
        }

        //Not make sense "function/method Add()" in a class Consultation
        //this class should only have Gets methods 

        public override void Add()
        {
            throw new Exception("Not allowed");
            //throw new NotImplementedException();
        }
    }
}
