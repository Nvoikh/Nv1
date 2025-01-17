using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double firstSum = AddNumbers(12.7, 16.35);
            Console.WriteLine($"firstSum = {firstSum}");
            double secondSum = AddNumbers(9.5, 10);
            Console.WriteLine($"secondSum = {secondSum}");
        }
        public static double AddNumbers(double firstNumber, double secondNumber) => firstNumber + secondNumber;
        public static void Hello()
        {
            Console.WriteLine("Hello from a void function.");
        }
    }
   
        
    
}
