using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    public class Student : IPerson
    {
        public string FullName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Age { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string GetDetails()
        {
            throw new NotImplementedException();
        }

        public string GetDetails(double height)
        {
            throw new NotImplementedException();
        }
    }
}
