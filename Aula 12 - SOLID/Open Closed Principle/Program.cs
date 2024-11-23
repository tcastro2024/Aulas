using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://medium.com/@mirzafarrukh13/solid-design-principles-c-de157c500425
            // https://www.tutorialsteacher.com/csharp/open-closed-principle
            // Each class would have only one responsibility, WHY?
            // Code duplicated
            // Change the logic and unpredictable impacts in other features that work before
            // Bad code and hard maintainable

            #region WITHOUT_OC_PRINCIPLE 

            Rectangle_WITHOUT_OC_PRINCIPLE rectangle_WITHOUT_OC_PRINCIPLE = new Rectangle_WITHOUT_OC_PRINCIPLE();

            rectangle_WITHOUT_OC_PRINCIPLE.Width = 4;
            rectangle_WITHOUT_OC_PRINCIPLE.Height = 4;

            AreaCalculator areaCalculator__WITHOUT_OC_PRINCIPLE = new AreaCalculator();

            object[] objects = new object[1];

            objects[0] = rectangle_WITHOUT_OC_PRINCIPLE;

            areaCalculator__WITHOUT_OC_PRINCIPLE.SumArea(objects);

            Console.WriteLine(areaCalculator__WITHOUT_OC_PRINCIPLE.SumArea(objects));

            #endregion

            #region WITH_OC_PRINCIPLE 
            Rectangle rectangle = new Rectangle();

            rectangle.Width = 4;
            rectangle.Height = 4;

            AreaCalculator areaCalculator = new AreaCalculator();

            object[] objects1 = new object[1];

            objects1[0] = rectangle;

            areaCalculator.SumArea(objects);

            Console.WriteLine(areaCalculator.SumArea(objects));

            #endregion

            //Start without debugging
            //or
            Console.ReadKey(); // to see the vales on console application
        }
    }
}
