using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person() { Age = 18, FullName = "Dydyda Petya" };

            Console.WriteLine(person.GetDetails());
            
            Professor professor = new Professor() { Age = 20, FullName = "John Bobby", Subject = "English" };
            professor.GetDetails();
            Student student = new Student() { Age = 21, FullName = "Robo KOp", Grade = 12 };
            student.GetDetails();
        }
    }
}
