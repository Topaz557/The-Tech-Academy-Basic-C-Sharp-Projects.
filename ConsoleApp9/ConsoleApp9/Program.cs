using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 list = new Class1();
            Console.WriteLine("enter a number");
            int numberOne = Convert.ToInt32(Console.ReadLine());
            list.divide(numberOne);
            Console.ReadLine();
        }
    }
}
