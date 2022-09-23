using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee class1 = new Employee(); // here we are calling to the employee class, which also pulls the inhertited data from Person class
            class1.firstName = "Sample"; // here we are assiging variable 1
            class1.lastName = "Student";// here we are assining variable 2
            class1.SayName();// here we are calling the superclass
            Console.ReadLine();// here we are returning the value
        }
    }
}
