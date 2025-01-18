using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16
{
    internal class Program
    {
        static void Main(string[] args)
        {
			
			Student student = new Student();
            try
            {
                student.Age = -10;
                ValidatStudentAge(student.Age);
            }
            catch (InvalidStudentAgeException e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
			

        }

        private static void ValidatStudentAge(int age)
        {
            if (age < 18) throw new InvalidStudentAgeException (age);
        }
    }
    public class Student
    {
        public int StudentID { get; set; }
        public int Age { get; set; }
    }
    public class InvalidStudentAgeException : Exception
    {
        public InvalidStudentAgeException() { }
        public InvalidStudentAgeException(int age) : base($"Age {age} is not a valid one!")
        {

        }
    }
}
