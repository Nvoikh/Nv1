using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> IsEven = IsEven;
            Console.WriteLine(IsEven(5));
        }

        static bool IsEven (int number) =>  number % 2 == 0;

        

        static bool IsLowerCase(string text) => text.Equals(text.ToLower());
        
    }
}
