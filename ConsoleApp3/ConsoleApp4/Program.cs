using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(WeekDays.Friday);
            Console.WriteLine((int)WeekDays.Thursday);

            Console.WriteLine("GetName()");
            Console.WriteLine(Enum.GetName(typeof(WeekDays),5));
            Console.WriteLine("GetNames()");
            foreach(string str in Enum.GetNames(typeof(WeekDays)))
                Console.WriteLine(str);
            Console.WriteLine("TryParse()");
            WeekDays wdEnum;
            Enum.TryParse<WeekDays>("1", out wdEnum);
            Console.WriteLine(wdEnum);
        }
        enum WeekDays
        {
            Monday = 1,
            Tuesday, 
            Wednesday, 
            Thursday,
            Friday,
            Saturday,
            Sunday
            
        }
    }
}
