using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push("Hello there");
            myStack.Push(1);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4.5);
            myStack.Push(null);
            myStack.Push("Top of Stack");
            Console.WriteLine($"Stack Length = {myStack.Count}");
            Console.WriteLine($"The peak of the stack is - {myStack.Pop()}");
            myStack.Pop();
            Console.WriteLine($"mySTack has a 2 => {myStack.Contains(3)}");
            
            Console.WriteLine($"The peak of the stack is - {myStack.Peek()}");

            myStack.Clear();
            foreach (var stackItem in myStack)
            {
                Console.WriteLine(stackItem);
            }
        }
    }
}
