using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle
{
    class AreaCalculator
    {

        #region WITHOUT_OC_PRINCIPLE 

        public double SumRectangleArea(Rectangle_WITHOUT_OC_PRINCIPLE[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Width * shape.Height;
            }

            return area;
        }

        public double SumArea(object[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                if (shape is Rectangle_WITHOUT_OC_PRINCIPLE)
                {
                    Rectangle_WITHOUT_OC_PRINCIPLE rectangle = (Rectangle_WITHOUT_OC_PRINCIPLE)shape;
                    area += rectangle.Width * rectangle.Height;
                }
                else if (shape is Circle_WITHOUT_OC_PRINCIPLE)
                {
                    Circle_WITHOUT_OC_PRINCIPLE circle = (Circle_WITHOUT_OC_PRINCIPLE)shape;
                    area += circle.Radius * circle.Radius * Math.PI;
                }
            }

            return area;
        }

        #endregion

        #region WITH_OC_PRINCIPLE
        public double SumArea(Shape[] shapes)
        {
            double area = 0;
            foreach (var shape in shapes)
            {
                area += shape.Area();
            }
            return area;
        }

        #endregion
    }
}
