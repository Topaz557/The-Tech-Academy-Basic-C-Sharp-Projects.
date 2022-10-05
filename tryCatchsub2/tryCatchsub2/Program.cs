using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tryCatchsub2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());
            // create a while statement with bool set to true to exit loop, false will be meeting the conditions of the exceptions
            try
            {
                if (age < 0)
                {
                    throw new NegativeException();
            }
                if (age == 0)
                {
                    throw new ZeroException();
                }
                Console.WriteLine(DateTime.Now.Year - age);
                

            }

            catch (NegativeException)
            {
                Console.WriteLine("Please enter positive numbers only");
            }
            catch (ZeroException)
            {
                Console.WriteLine("Please do not enter zero");
            }


            catch (Exception)
            {
                Console.WriteLine("Please enter digits only, without any decimals."); 
            }



            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
