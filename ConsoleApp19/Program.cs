using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            HelloClass hello = new HelloClass();
            hello.HelloUniverse();
            hello.HelloWorld();
        }
        public partial class HelloClass {
            public void HelloWorld() => Console.WriteLine("Hello world!");
        }
            public partial class HelloClass {
            public void HelloUniverse() => Console.WriteLine("Hello Petya");
        }
    }
}
