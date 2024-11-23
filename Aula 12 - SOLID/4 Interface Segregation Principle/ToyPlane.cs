using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface_Segregation_Principle
{
    public class ToyPlane: IToy, IMovable, IFlyable
    {
        public double price;
        public string color;
        public void SetPrice(double priceParameter)
        {
            //The word "this." is for using the attribute "double price" the class
            this.price = priceParameter;
        }
        public void SetColor(string colorParameter)
        {
            //The word "this." is for using the attribute "string color" the class
            this.color = colorParameter;
        }
        public void Move()
        {
            Console.WriteLine("ToyPalne is moving.");
        }
        public void Fly()
        {
            Console.WriteLine("ToyPalne is Flying.");
        }
    }
}
