using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Test<string> firstTest = new Test<string>();
            firstTest.Value = "This is a string ";
            firstTest.Details();

            Test<int> secondTest = new Test<int>();
            secondTest.Value = 5;
            secondTest.Details();

       
        }
        public class Test<T>
        {
            public T Value { get; set; }
            public void Details() => Console.WriteLine($"Parametr type: {typeof(T)}, value: {Value}");
            
        }
    }
}
