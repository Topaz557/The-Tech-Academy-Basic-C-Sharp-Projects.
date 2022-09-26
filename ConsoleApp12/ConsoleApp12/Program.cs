using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName  = "Sample";
            employee.LastName = "Student";
            employee.SayName();
            Console.ReadLine();
            IQuittable quittable = new Employee();
            quittable.Quit();
            Console.ReadLine();

            


        }
    }
}
