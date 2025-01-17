using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList sl1 = new SortedList();
            sl1.Add(3, "Number three");
            sl1.Add(4, "Number four");
            sl1.Add(1, "Number one");
            sl1.Add(5, "Number five");
            sl1.Add(2, "Number two");

            sl1.RemoveAt(0);
            
            


            for (int i = 0; i < sl1.Count; i++) {
                Console.WriteLine($"Key: {sl1.GetKey(i)},Value: {sl1.GetByIndex(i)}");
            }

        }
    }

    
}
