using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestLaunch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Dimka", "Oslopov", 17);
            Console.WriteLine($"First Name - {student.firstName}");
            Console.WriteLine($"Last Name - {student.lastName}");
            Console.WriteLine($"Age - {student.age}");
        }
    }
    public class Student
    {
        internal string firstName;
        internal string lastName;
        internal int age;

        public Student(string firstName, string lastName, int age)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }
    }
}
