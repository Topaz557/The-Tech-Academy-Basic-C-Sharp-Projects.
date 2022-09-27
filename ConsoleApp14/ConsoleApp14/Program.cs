using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee();
            employee.firstName = "Jesse";
            employee.LastName = "White";
            employee.EmployeeId = 007;

            Employee employee1 = new Employee();
            employee1.firstName = "Walter";
            employee1.LastName = "White";
            employee1.EmployeeId = 008;

            
          
            if (employee1 == employee){
                Console.WriteLine("The employee ID's are the same");

                
            }
            else
            {
                Console.WriteLine("The employee ID's are Not the same");
            }
            
            Console.ReadLine();
        }
    }
}
