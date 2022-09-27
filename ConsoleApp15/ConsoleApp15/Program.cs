using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee = new Employee<string>();
            employee.things = new List<string>()
            {
                "Jesse" , "Goerge" , "Jose" , "Andrew" , "Dalton"
            };

            Employee<int> employee1 = new Employee<int>();
            employee1.things = new List<int>()
            {
                8 , 9 , 10 , 11 , 12
            };
            
            for (int i=0; i<employee.things.Count(); i++)
            {
                Console.WriteLine(employee.things[i]);
                Console.WriteLine(employee1.things[i]);
                
        
            }
            Console.ReadLine();
        }


    }
}
