using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 list = new Class1();
            Console.WriteLine("Pick a number");
            int NumberOne = Convert.ToInt32(Console.ReadLine());

            try
            {

                Console.WriteLine("Pick a second number");
                int Numbertwo = Convert.ToInt32(Console.ReadLine());
                int AddNumber2 = list.AddNumber(NumberOne, Numbertwo);
                Console.WriteLine(AddNumber2);
                Console.ReadLine();

            }
            catch
            {
                int AddNumber1 = list.AddNumber(NumberOne);
                Console.WriteLine(AddNumber1);
                Console.ReadLine();
            }
        }
    }
}
