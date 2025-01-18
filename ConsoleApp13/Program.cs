using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Queue myQueue = new Queue();
            myQueue.Enqueue(1);
            myQueue.Enqueue(2);
            myQueue.Enqueue(31);
            myQueue.Enqueue("This is my sting");
            myQueue.Enqueue(null);
            myQueue.Enqueue("This is last vaalue");
            Console.WriteLine($"Number of elements = {myQueue.Count}");

            //while (myQueue.Count > 0)
            {
             //   Console.WriteLine(myQueue.Dequeue());
             Console.WriteLine($"The peak of myQueue is: {myQueue.Peek()}");
                Console.WriteLine($"Value 30 exist in myQueue => {myQueue.Contains(30)}");
                myQueue.Clear();
                Console.WriteLine($"Number of elements = {myQueue.Count}");
            }
        }
    }
}
