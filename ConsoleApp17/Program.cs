using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp17
{
    public delegate void StringDelegate(string text);

    internal class Program
    {
        static void Main(string[] args)
        {
            StringDelegate stringDelegate = ToUpperCase;
           WriteOutput("This is a lower string", stringDelegate);

            //events
            Strings myString = new Strings();
            myString.stringEvent += TextChanged;
            string str;
            do
            {
                str = Console.ReadLine();
                if (!str.Equals("exit")) myString.Value = str;
            } while (!str.Equals("exit"));

        }

        
        static void ToUpperCase(string text) => Console.WriteLine(text.ToUpper());
        static void ToLowerCase(string text) => Console.WriteLine(text.ToUpper());

        static void TextChanged (string text) => Console.WriteLine($"You entered: {text}");
        static void WriteOutput(string text, StringDelegate stringDelegate)
        {
            Console.WriteLine($"Before: {text}");
            stringDelegate(text);
        }
    }

    public class Strings
    {
        private string stringValue;
        public event StringDelegate stringEvent;

        public string Value { set { 
                this.stringValue = value;
                this.stringEvent(this.stringValue);
            } }
    }
}
