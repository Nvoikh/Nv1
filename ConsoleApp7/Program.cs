using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            c1.Radius = 5;
            double a1 = c1.GetArea();
            Console.WriteLine(a1);

            Circle c2 = new Circle(5);
            double a2 = c2.GetArea();
            Console.WriteLine(a2);
        }
    }
}
