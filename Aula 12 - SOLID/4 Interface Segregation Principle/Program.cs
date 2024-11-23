using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Interface_Segregation_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Interface_Segregation_Principle
            // Classes should not be forced to depend upon interfaces that they do not use.
            // For another words if Interface have methods that not implement in all classes
            // we should create specifics interfaces.
            //
            // IToyWrong have methods that not adjust all situations
            // in this cases we should create other interfaces suitable for each scenario
            // like for example IToy, IFlyable, IMovable

        }
    }
}
