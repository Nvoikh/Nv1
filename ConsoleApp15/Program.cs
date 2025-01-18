using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    public class SampleCollection
    {
        private string[] array = new string[60];

        public string this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                SampleCollection sampleCollection = new SampleCollection();
                sampleCollection[0] = "25";
                Console.WriteLine($"The value = {sampleCollection[0]}");
            }
        }
    }
}
