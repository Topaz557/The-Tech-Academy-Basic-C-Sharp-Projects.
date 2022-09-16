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
            bool holder = false;
            while (holder == false) //KEEP AN EYE ON needed to make bools run correctly
            {
                if (placeHolder > 4)
                {
                    Console.WriteLine("Please choose a number between 0-4, we cannot process numbers higher or lower");
                    placeHolder = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(numArray[placeHolder]);
                    holder = true;
                }
            }
            Console.ReadLine();
            

            List<string> intList = new List<string>();
            intList.Add("Hello");
            intList.Add("Jesse");
            intList.Add("How");
            intList.Add("Are");
            intList.Add("You");
            intList.Add("Today");

            Console.WriteLine("Pick a number between 0-5");
            int Placeholder2 = Convert.ToInt32(Console.ReadLine());
            bool holder2 = false;
            while (holder2 == false) // Keep eye on this code, needed to make bools run correctly
            {
                if (Placeholder2 > 5)
                {
                    Console.WriteLine("Please choose a number between 0-5, we cannot process numbers higher or lower");
                    Placeholder2 = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine(intList[Placeholder2]);
                    holder2 = true;
                }
            }
            Console.ReadLine();

           
           
          
        }
        
    }
}
