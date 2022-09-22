using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOneGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            int timesShuffled = 0;
            //deck = Shuffle(deck); //You can comment this line out to not shuffle the deck, can uncomment it to shuffle 
            deck = Shuffle(deck, out timesShuffled, 3); // with the 3 we are telling the deck to shuffle three times
           foreach (Card card in deck.Cards)
            {
                Console.WriteLine(card.Face + " of " + card.Suit);
            }
            Console.WriteLine(deck.Cards.Count);
            Console.WriteLine("Times shuffled {0}", timesShuffled);
            Console.ReadLine();
        }

        public static  Deck Shuffle(Deck deck, out int timesShuffled, int times = 1) //out comment
        {
            timesShuffled = 0;
            for (int i = 0; i < times; i++)
            {
                timesShuffled++; //Creating increments, adding one each time a loop is gone through
                List<Card> TempList = new List<Card>();
                Random random = new Random();

                while (deck.Cards.Count > 0)
                {
                    int randomIndex = random.Next(0, deck.Cards.Count);
                    TempList.Add(deck.Cards[randomIndex]);
                    deck.Cards.RemoveAt(randomIndex);
                }
                deck.Cards = TempList;
                
            }
            return deck; // Return value statement
        }
        //public static Deck Shuffle(Deck deck, int times)
        //{
        //    for (int i = 0; i < times; i++)// creating a shuffle method that will shuffle however many times the dealer decides it
        //    {
        //        deck = Shuffle(deck);
        //    }
        //    return deck;
        //}


        // Method overloading, creating as many methods as you want as long as they are kind of different. Compliler will look at rules to see which to use.
    }
}
