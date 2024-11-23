using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface_Segregation_Principle
{
    public class ToyHouse: IToy //, IToyWrong
    {

        public double price;
        public string color;

        #region Constructors
        public ToyHouse() 
        {
        }

        public ToyHouse ( int priceParameter,  string colorParameter )
        {
            this.price = priceParameter;
            this.color = colorParameter;
        }

        #endregion

        #region Methods
        public void SetPrice(double price)
        {
            this.price = price;
        }
        public void SetColor(string color)
        {
            this.color = color;
        }

        #endregion

        #region With IToyWrong

        public void Move()
        {
            throw new Exception("Not allowed");
        }
        public void Fly()
        {
            throw new Exception("Not allowed");
        }
        #endregion
    }
}
