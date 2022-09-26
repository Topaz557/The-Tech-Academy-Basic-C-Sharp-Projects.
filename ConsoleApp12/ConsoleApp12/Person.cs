using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public abstract class Person
    {
        public string firstName { get; set; }
        public string LastName { get; set; }
        public abstract void  SayName();
    }
}
