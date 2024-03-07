using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_AIP
{
    public abstract class Shape
    {
        private double Area { get; set; }
        public abstract double CalculateArea();



        /* public abstract class Shape
            {
                public abstract double CalculateArea(double width, double height);
            }
        */

    }
}
