using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyoneExample2
{
    class Program
    {
        static void Main(string[] args)
        {

            //struct is a value type that cannot inherit, a class is a reference type// structs need to have a datatype, cannot be null (any datatype cannot be null)
            //structs
            Card card1 = new Card();
            Card card2 = card1;
            card1.Face = Face.Eight;
            card2.Face = Face.King;

            Console.WriteLine(card1.Face);

            Deck deck = new Deck();
            deck.Shuffle(3);
        //    // to break row/debug test do f9
        //    foreach (Card card in deck.Cards)
        //    {
        //        Console.WriteLine(card.Face + " of " + card.Suit);
        //    }
        //    Console.WriteLine(deck.Cards.Count);
        //    Console.ReadLine();
        //}
        
    }
}
