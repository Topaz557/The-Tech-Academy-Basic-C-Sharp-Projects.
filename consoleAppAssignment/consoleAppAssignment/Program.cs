using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppAssignment
{
    class Program
    {
        static void Main()
        {
            string[] names = { "Jesse", "Eric", "Daniel", "Adam" };
            Console.WriteLine("Guess what class all of our students have together");
            string course = Console.ReadLine();
            for (int i = 0; i < names.Length; i++) // triggers the condition when it continues to go through, once it meets condition of being matched with length of array it stops.
            {
                names[i] = names[i] + " " + course; 
            }
            foreach (string text in names)
            {
                Console.WriteLine(text);
            }
            
            Console.ReadLine();

            int holder = 5; 
            while (holder > 4)
            {
                Console.WriteLine("guess a number");
                holder = 4;// here I change the int holder to 4 from 5 to exit infite loop
            }
            int holder2 = 4;
            while (holder2 < 5)
                {
                Console.WriteLine("Guess a number");
                holder2 = 5;
            }
            int holder3 = 6;
            while (holder3 <= 6)
            {
                Console.WriteLine("Guess a number");
                holder3 = 7;
            }
            Console.ReadLine();

            string[] names2 = { "Jesse", "Eric", "Daniel", "Adam" };
            Console.WriteLine("Guess a name and see if it is contained within our string!");
            string holder4 = Console.ReadLine();
            int holder5 = 0;
            bool isGuessed = false;
            while (isGuessed == false)
            {
                foreach (string placeh in names2)
                {
                    if (holder4 == placeh)
                    {
                        Console.WriteLine(holder5);
                    }
                    holder5++;
                }
                if (!names2.Contains(holder4))
                {
                    Console.WriteLine("Name does not exist in the list, guess again");
                    holder5 = 0;
                    holder4 = Console.ReadLine();
                }
                else
                {
                    isGuessed = true;
                }

            }
            Console.ReadLine();


            List<string> names3 = new List<string>  {"Jesse", "Eric", "Daniel", "Adam", "Jesse" };
            Console.WriteLine("Guess a name and see if it is contained within our string twice!");
            string holder6 = Console.ReadLine();
            int holder7 = 0;
            bool isGuessed2 = false;
            while (isGuessed2 == false)
            {
                foreach (string placeh in names3)
                {
                    if (holder6 == placeh)
                    {
                        Console.WriteLine(holder7);
                    }
                    holder7++;
                }
                if (!names3.Contains(holder6))
                {
                    Console.WriteLine("Name does not exist in the list, guess again");
                    holder7 = 0;
                    holder6 = Console.ReadLine();
                }
                else
                {
                    isGuessed2 = true;
                }

            }
            Console.ReadLine();



            List<string> names4 = new List<string> { "Jesse", "Eric", "Daniel", "Adam", "Jesse" };// origonal names list that will be cited
            List<string> names5 = new List<string> { }; // creating blank name list we will transfer names into to check for duplicates
            foreach (string placeh in names4) // Here we create an individual variables for names that can be replaced and cycled through
            {

                if (names5.Contains(placeh)) // check and see if names 5 matches any of the names within names 4
                {
                    Console.WriteLine(placeh + " This is not a unique name");
                }
                else
                {
                    Console.WriteLine(placeh + " This is a unique name"); // this is the else statement, if condition is not met then the name is uniquie
                }
                names5.Add(placeh); // This adds the individual names
            }
            Console.ReadLine();
        }
    }
}
