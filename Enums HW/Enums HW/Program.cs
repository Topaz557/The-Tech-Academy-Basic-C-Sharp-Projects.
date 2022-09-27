using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums_HW
{
     class Program
    {
         static void Main(string[] args)
        {
            Console.WriteLine("What day of the week is it currently?");
            bool dog = false;
            while(!dog)
            try
            {
                string Day = Console.ReadLine();
                DaysOfWeek Day1 = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), Day);
                Console.WriteLine(Day1);
                    dog = true;
            }
            
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week/ make sure the first letter is capitalized.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Pley of the week.");
            }
            Console.ReadLine();


            

        }

         enum DaysOfWeek
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}
