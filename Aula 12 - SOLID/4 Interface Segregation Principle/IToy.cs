using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface_Segregation_Principle
{
    public interface IToy
    {
        void SetPrice(double price);
        void SetColor(string color);
    }
}
