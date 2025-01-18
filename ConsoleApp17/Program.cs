using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public delegate void StringDelegate(string text);

    internal class Program
    {
        static void Main(string[] args)
        {
            StringDelegate stringDelegate = ToUpperCase;
           WriteOutput("This is a lower string", stringDelegate);

        }
        
        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowerCase(string text) => Console.WriteLine(text.ToUpper());
        static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
            stringDelegate(text);
        }
    }
}
