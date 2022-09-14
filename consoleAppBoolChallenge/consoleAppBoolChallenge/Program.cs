using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consoleAppBoolChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess how tall the programmer is");
            string height = (Console.ReadLine());
            bool isGuessed = height == "5'7";


            do
            {
                switch (height)
                {
                    case "5'6":
                        Console.WriteLine("You have guessed 5'6. try again");
                        Console.WriteLine("guess the programers height?");
                        height = (Console.ReadLine());
                        break;
                    case "6'0":
                        Console.WriteLine("You guessed 6'0. Try again");
                        Console.WriteLine("guess the programers height?");
                        height = (Console.ReadLine());
                        break;
                    case "5'8":
                        Console.WriteLine("You guessed 5'8. Try again");
                        Console.WriteLine("guess the programers height?");
                        height = (Console.ReadLine());
                        break;
                    case "5'7":
                        Console.WriteLine("You guessed 5'7. that is the correct number");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("guess the programers height?");
                        height = (Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);


            Console.WriteLine("Guess the programers favorite color");
            string color = (Console.ReadLine());
            bool isGuessed2 = color == "blue";

            while (!isGuessed2)
            {
                if (color == "yellow")
                {
                    Console.WriteLine("That is not the right color, guess again!");
                    Console.WriteLine("Guess the programers favorite color");
                    color = Console.ReadLine();
                }
                else if (color == "green")
                {
                    Console.WriteLine("That is not the right color, guess again!");
                    Console.WriteLine("Guess the programers favorite color");
                    color = Console.ReadLine();
                }

                else if (color == "blue")
                {
                    Console.WriteLine("That is the right color!");
                    isGuessed2 = true;
                }
                else
                {
                    Console.WriteLine("You have guessed the wrong color, guess again!");
                    Console.WriteLine("Guess the programers favorite color");
                    color = Console.ReadLine();
                }
            }
            Console.ReadLine();
        }
    }
}
