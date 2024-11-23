using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface_Segregation_Principle
{
    public interface IToyWrong // Without Interface_Segregation_Principle
    {
        void SetPrice(double price);
        void SetColor(string color);
        void Move();
        void Fly();
    }
}
