using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student();
            s1.FirstName = "Losha";
            s1.LastName = "Jariy";
            s1.Grade = 5;

            Student s2;
            s2 = new Student();
            s2.FirstName = "Dimka";
            s2.LastName = "Oslopov";
            s2.Grade = 2;

            Console.WriteLine($"{s1.FirstName} {s1.LastName} - {s1.Grade}");
            Console.WriteLine($"{s2.FirstName} {s2.LastName} - {s2.Grade}");

            Student s3 = new Student("Vova","Bryk",5);
            s3.ShowStudent();

        }
    }
}
