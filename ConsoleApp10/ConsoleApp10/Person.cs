using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    public class Person // Here we are creating a super class 
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public void SayName()
        {
            string fullName = firstName + lastName;
            Console.WriteLine("name: " + fullName);
        }
    }
}
