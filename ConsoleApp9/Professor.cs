using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Professor:Person
    {
        public string Subject {  get; set; }
        public override string GetDetails() => "{FullName} of age {Age}";
    }
}
