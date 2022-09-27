using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public  class Employee
    {
        public string firstName { get; set; }
        public string LastName { get; set; }

        public int EmployeeId { get; set; }
        public static bool operator== (Employee employee, Employee employee1) 
        {
            return // if you are having red squiggles check to make sure you have the return statement
            employee.EmployeeId == employee1.EmployeeId;
        }
        public static bool operator!= (Employee employee, Employee employee1)
        {
            return
            employee.EmployeeId != employee1.EmployeeId;
            
        }
        
    
}
}