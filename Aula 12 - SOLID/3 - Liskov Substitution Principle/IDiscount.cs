﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3___Liskov_Substitution_Principle
{
    public interface IDiscount
    {
        double GetDiscount(double TotalSales);
    }
}
