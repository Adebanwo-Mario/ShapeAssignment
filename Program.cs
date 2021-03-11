using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<Shape>();

            list.Add(new Rectangle(4, 7));
            list.Add(new Circle(8));
            list.Add(new Triangle(5, 10));



            Console.WriteLine($"Area of Rectangle: {list[0].CalculateSurface()}");
            Console.WriteLine($"Area of Circle: {list[1].CalculateSurface()}");
            Console.WriteLine($"Area of Triangle: {list[2].CalculateSurface()}");
            Console.ReadKey();
        }
    }
}
