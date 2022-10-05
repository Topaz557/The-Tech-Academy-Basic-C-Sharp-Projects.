using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Casino;
using Casino.TwentyoneExample2;

namespace TwentyoneExample2
{

    /// <summary>
    /// Random c# abilities
    /// constructor chaining, using a constructor to then inherit properties
    /// Guid = unique identifier, used normally for user identification.
    /// Guid identifier = Guid.NewGuid(); , you can pass in a string, or other values, then the algorithim will generate the GUID
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            //DateTime yearOfBirth = new DateTime(1995, 5, 23, 8, 32, 45);
            //DateTime yearOfGraduation = new DateTime(2013, 6, 1, 16, 34, 22);

            //TimeSpan ageAtGraduation = yearOfGraduation - yearOfBirth;

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start by telling me your name");
            
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today");
            int Amount = Convert.ToInt32(Console.ReadLine());
              
            Console.WriteLine("Hello {0}. Would you like to join a game of 21 right now?", playerName);  // {0} acts as a placeholder for playername
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, Amount);
                player.Id = Guid.NewGuid();
                using (StreamWriter file = new StreamWriter(@"C:\Users\andre\Documents\GitHub\parseText\SampleParse1.txt", true))// takes in a bath from stream writer, then asks us to append (true), reference to file below, then write the card 
                {
                    file.WriteLine(player.Id);
                   
                }
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;
                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }
                game -= player;
                Console.WriteLine("Thank you for playing");
            }
            Console.WriteLine("Feel free to look around the casino. Bye for now");
            Console.Read();
        
        
        
        }
    }
}
