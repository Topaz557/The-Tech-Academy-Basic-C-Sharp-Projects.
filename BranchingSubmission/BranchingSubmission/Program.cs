using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BranchingSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below");
            Console.WriteLine("What is the Packages Weight");
            int packageWeight = Convert.ToInt32(Console.ReadLine());
            if (packageWeight > 50)
            {
                Console.WriteLine("Package to heavy to be shipped via Package Express. Have a good day");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("What is the length of the package");
                int packageLength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the height of the package");
                int packageHeight = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("What is the width of the package");
                int packageWidth = Convert.ToInt32(Console.ReadLine());
                int totalDimension = packageHeight + packageLength + packageWidth;

                if (totalDimension > 50)
                {
                    Console.WriteLine("Package too big to be shipped via Package Express.");
                    Console.ReadLine();
                }
                else
                {
                    int total = packageLength * packageHeight * packageWidth / 100;
                    Console.WriteLine("Your estimated total for shipping this package is:$" + total);
                }

            }
        }
    }
}
