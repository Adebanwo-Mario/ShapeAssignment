using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAssignment
{
   public class Triangle : Shape
    {
        public Triangle(double Width, double Height) : base(Width, Height)
        {


        }
        public override double CalculateSurface()
        {
            return height * width / 2;
        }
    }
}
