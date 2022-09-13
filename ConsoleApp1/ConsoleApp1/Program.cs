using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int yourAge = Convert.ToInt32(Console.ReadLine());

            if (yourAge > 15)
            {
                Console.WriteLine("You are  old enough to get insurance");
            }
            Console.WriteLine("Have you ever had a dui?");
            Console.WriteLine("True or False");
            string input = Console.ReadLine();
            bool isbool = bool.Parse(input);
            Console.WriteLine("How many speeding tickets do you have?");
            int yourTickets = Convert.ToInt32(Console.ReadLine());
            if (yourTickets <= 3 && yourAge > 15 && isbool == false)
            {
                Console.WriteLine("you are qualified");
            }

            Console.WriteLine("Your Age" + yourAge);
            Console.WriteLine("Have you had a DUI?" + isbool);
            Console.WriteLine("You have this many tickets." + yourTickets);
            Console.ReadLine();


        }
    }
}
