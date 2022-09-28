using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace struct2
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal number = 1200;
            Number x; // to create the object you need to use the name of the struct,
                      // this allows you to pass in the object to get value (can access the data of the struct)
            x.amount = number;
            Console.WriteLine(x.amount);
            Console.ReadLine();
        }
        //start with name of stuct, then target the variables within the struct 
        public struct Number
        {
            public decimal amount;
            
        }
    }
}
