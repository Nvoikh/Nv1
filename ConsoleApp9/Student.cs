using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Student:Person 
    {
        public int Grade { get; set; }
        public override string GetDetails() => "{FullName} of age {Age}";
        
    }
}
