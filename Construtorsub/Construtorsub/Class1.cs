using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Construtorsub
{
    class Class1
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public Class1(string t, string y)
        {
            firstName = t;
            lastName = y;
            Console.WriteLine(t + y);
        }
        public Class1(string t):this(t, "Harding")
        {
            Console.WriteLine("Hello " + t + " " + lastName);
        }
    }
}

