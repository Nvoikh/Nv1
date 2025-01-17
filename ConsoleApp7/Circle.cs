using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Circle
    {
        private const double PI = 3.14; //Pi
        public double Radius { get; set; }
        public Circle()
        {
            Console.WriteLine("Circle() created");
        }
        public Circle(double radius)
            { this.Radius = radius; }
        public double GetArea () => PI * Math.Pow(Radius, 2);
        public double GetPerimeter() => 2 * PI * Radius;
    }
}
