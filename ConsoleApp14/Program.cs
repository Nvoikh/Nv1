using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(1, "One");
            myDictionary.Add(6, "Six");

            Hashtable myHashtable = new Hashtable(myDictionary);

            string valueOfOne = (string)myHashtable[1];
            Console.WriteLine($"Value od One = {valueOfOne}");
            myHashtable.ContainsKey(1);
            foreach (DictionaryEntry value in myHashtable)
            {
                Console.WriteLine($"Key: {value.Key}, Value: {value.Value}");
           
            }

        }
    }
}
