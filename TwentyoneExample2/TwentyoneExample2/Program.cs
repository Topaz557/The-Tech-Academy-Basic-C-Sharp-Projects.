using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TwentyoneExample2
{
    class Program
    {
        static void Main(string[] args)
        {

            
           

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Lets start by telling me your name");
            
            string playerName = Console.ReadLine();
            Console.WriteLine("And how much money did you bring today");
            int Amount = Convert.ToInt32(Console.ReadLine());
              
            Console.WriteLine("Hello {0}. Would you like to join a game of 21 right now?", playerName);  // {0} acts as a placeholder for playername
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, Amount);
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
