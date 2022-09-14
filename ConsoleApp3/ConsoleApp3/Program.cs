using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {//example of else if
         //int currentTemperature = 70;
         //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature");
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //// example of else, if, and else if
            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("current temperature it is warmer than room temperature");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("room temperature is warmer than current temperature");
            //}
            //else
            //{
            //    Console.WriteLine("it is not exactly room temperature.");
            //}
            //Console.WriteLine();
            //Console.ReadLine();

            //turinary operataor
            //int currentTemperature = 80;
            //int roomTemperature = 70;
            //string comparisonResult = currentTemperature == roomTemperature ? "It is room temp." : "it is not room temp.";
            //Console.WriteLine(comparisonResult);
            //Console.ReadLine();






            //int roomTemperature = 70;

            //Console.WriteLine("Hi, What is your name?");
            //string name = Console.ReadLine();
            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temperature");
            //}
            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temperature.");
            //}
            //else if (roomTemperature > currentTemperature)
            //{
            //    Console.WriteLine("it is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("uhhhh... Something went wrong!");
            //}
            //Console.ReadLine();



            //Console.WriteLine("What is your favorite number");
            //int favNum = Convert.ToInt32(Console.ReadLine());

            //string result = favNum == 12 ? "You have an awesome favorite number" : "You do not have an awesome favorite number";
            //Console.WriteLine(result);
            //Console.ReadLine();

            //SWITCH STATEMENTS


            //DO WHILE Loop (can create endless loop if you code incorectly, if it cannot equal true then it will run forever. Make sure the options are limited in a way it has to meet condition
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;


            do
            {
                switch (number)
                {
                    case 62:
                        Console.WriteLine("You have guessed 62. try again");
                        Console.WriteLine("guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 29:
                        Console.WriteLine("You guessed 29. Try again");
                        Console.WriteLine("guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55. Try again");
                        Console.WriteLine("guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12. that is the correct number");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong");
                        Console.WriteLine("guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }
            while (!isGuessed);
                
                Console.ReadLine();
            
        }
      
    }
}
