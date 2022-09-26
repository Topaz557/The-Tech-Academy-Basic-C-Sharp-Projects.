using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    public class Employee : Person, IQuittable
    {
        public override void  SayName()
        {
            Console.WriteLine(firstName + " " + LastName);
        }
        public void Quit()
        {
            Console.WriteLine("hello");

        }
    }
}
