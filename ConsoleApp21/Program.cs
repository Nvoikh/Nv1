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
            Func<double,double > square = delegate(double value) { return value * value; };
            Console.WriteLine($"square = {square(2)}");

            Func<double, double> cubic = (double value) => value * value * value; 
            Console.WriteLine($"cubic = {cubic(2)}");

            Func < double> two= Two;
            Console.WriteLine($"two = {two()}");

            
        }

        static double Square (double number) => Math.Pow (number, 2);

        static double Cubic (double number ) => Math.Pow (number, 3);
        static double Two() => 2;

        static void Show() => Console.WriteLine("Hello There !");
     }
}
