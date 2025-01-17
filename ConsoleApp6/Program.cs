using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[5];
            numbers[0] = 10;
            numbers[1] = 7;
            numbers[2] = 2;
            numbers[3] = 5;
            numbers[4] = 9;
            Array.Reverse(numbers);
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }
            string[] studentsNames = new string[10];
            double[] studentsResults = new double[4]
            {
                5,6.5,10,11,
            };
        }
    }
}
