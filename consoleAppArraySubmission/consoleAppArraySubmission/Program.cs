using System;
using System.Collections.Generic;
 

namespace consoleAppArraySubmission
{
    class Program
    {
        static void Main()
        {
            int[] numArray = new int[] { 5, 2, 10, 200, 5000 };
            Console.WriteLine("Pick a number between 0-4");
            int placeHolder = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(numArray[placeHolder]);
           

            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Jesse");
            intList.Add("How");
            intList.Add("Are");
            intList.Add("You");
            intList.Add("Today");

            Console.WriteLine("Pick a number between 0-5");
            int Placeholder2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(intList[Placeholder2]);
            Console.ReadLine();

        }
    }
}
