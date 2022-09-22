using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace main_method_submission
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 list = new Class1();
            int math = 20;
            int math2 = list.Multiplication(math);
            Console.WriteLine(math2);

            int math3 = list.Multiplication(.3m);
            Console.WriteLine(math3);

            int math4 = list.Muliplication("3");
            Console.WriteLine(math4);
            Console.ReadLine(); 
        }
       
        
    }
}
