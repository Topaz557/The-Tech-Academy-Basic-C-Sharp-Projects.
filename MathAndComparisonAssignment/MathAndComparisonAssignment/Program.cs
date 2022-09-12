using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathAndComparisonAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.ReadLine();

            //writes person 1
            Console.WriteLine("Person 1");
            //asks what your rate is
            Console.WriteLine("What is your hourly rate?");
            int yourHourlyRate = Convert.ToInt32(Console.ReadLine());
            //asks how many hours your working
            Console.WriteLine("How many hours do you work per week?");
            int hoursWorkedWeekly = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            int yourHourlyRate2 = Convert.ToInt32(Console.ReadLine());
            //asks how many hours your working
            Console.WriteLine("How many hours do you work per week?");
            int hoursWorkedWeekly2 = Convert.ToInt32(Console.ReadLine());
            int total1 = (yourHourlyRate * hoursWorkedWeekly * 52);
            int total2 = (yourHourlyRate2 * hoursWorkedWeekly2 * 52);
            Console.WriteLine("annual salary of Person 1 is " + total1);
            Console.WriteLine("annual salary of Person 2 is " + total2);
            Console.ReadLine();
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool Sum = total1 > total2;
            Console.WriteLine(Sum);
            Console.ReadLine();
        }
    }
}
