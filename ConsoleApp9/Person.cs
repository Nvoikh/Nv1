using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Person : IPerson

    {
        public string FullName { get; set; }
        public int Age { get; set; }

        public string GetDetails() => $"{FullName} of age {Age}";
       

        public string GetDetails(double height) => "{FullName} of age {Age}";

    }
}
