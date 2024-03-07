using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_AIP
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }
}
/*  
 *  OR I CAN DO THIS:
 *  
 *  
 *   public class Rectangle : Shape
        {
            public override double CalculateArea(double width, double height)
            {
                return width * height;
            }
        }


 *  
 *            */ 

