using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            var hi = hello;
            hello = "Privet";
            Console.WriteLine(ReferenceEquals(hello, hi));

            StringBuilder sb = new StringBuilder("this is string builder");
            var sbNew = sb;
            sb.Append("this is string builder");
            Console.WriteLine(ReferenceEquals(sb, sbNew));

            StringBuilder sbBuilder = new StringBuilder();
            sbBuilder.Append("i have ");
            sbBuilder.AppendFormat("{0:C}", 25);
            sbBuilder.Insert(0, "John:");
            sbBuilder.Remove(1, 2);
            sbBuilder.Replace(" have ", "had");
            Console.WriteLine(sbBuilder);
        }
    }
}
