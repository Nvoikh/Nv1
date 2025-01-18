using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp21
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Action<double> square = Square;
            square(4);

            Action<double> cubic = Cubic;
            cubic(4);

       Action two= Two;
            two();
            Action show = Show;
            show();


            
        }

        static void Square (double number) => Console.WriteLine(Math.Pow (number, 2));

        static void Cubic (double number ) => Console.WriteLine(Math.Pow (number, 3));
        static void Two() => Console.WriteLine(2);

        static void Show() => Console.WriteLine("Hello There !");
     }
}
