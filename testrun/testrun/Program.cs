using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testrun
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(true && true);

            //Console.ReadLine();


            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.ReadLine();

            //Console.WriteLine(true == false);
            //Console.Writeline(true == false);



            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);


            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            //Console.ReadLine();
            int num1 = 7;
            if (num1 < 18 && ((num1 == 7) || num1 == 2) && ((num1 == 8 && num1 > 20) || (num1 < 20 && num1 >2)))
            {
                Console.WriteLine("wow, thats confusing");
            }
            Console.ReadLine();
        }
    }
}
