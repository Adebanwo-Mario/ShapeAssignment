using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAssignment
{
   public abstract class Shape
    {
        protected double width;
        protected double height;


        public Shape(double Width)
        {
            width = height = Width;
        }
        public Shape(double Width, double Height)
        {
            width = Width;
            height = Height;
        }
        public abstract double CalculateSurface();
    }
}
