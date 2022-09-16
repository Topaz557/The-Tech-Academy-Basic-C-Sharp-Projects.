using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appboolchallenge2
{
    class Program
    {
        static void Main(string[] args)
        {
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
