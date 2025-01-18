using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Nullable<int> firstInt = null;
            int? secondInt = -4;
            int thirdInt = 32;
            int forthInt = secondInt ?? 0;

            Nullable<double> firstDouble = null;
            double? secondDouble = null;
            double thirdDouble = 12.24;
            Console.WriteLine($"Integer => firstInt: {firstInt}, secondInt: {secondInt}, thirdInt: {thirdInt} , forthInt {forthInt}");
            Console.WriteLine($"Integer => firstDouble: {firstDouble}, secondDouble: {secondDouble}, thirdDouble: {thirdDouble}");
        }
    }
}
