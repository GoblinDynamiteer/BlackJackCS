
using System;

namespace BlackjackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Create and print 4 decks */
            Deck deck = new Deck(4);

            foreach (Card card in deck.card)
            {
                Console.Write("{0:000} ", card.GetId());
                Console.Write(card.ToString());
                Console.WriteLine(" Value: {0}", card.GetValue());
            }

            deck.Shuffle();
            int listIndex = 0;

            foreach (Card card in deck.card)
            {
                Console.Write(listIndex++ + " ");
                Console.Write("{0:000} ", card.GetId());
                Console.Write(card.ToString());
                Console.WriteLine(" Value: {0}", card.GetValue());
            }

            Console.ReadLine();
        }
    }
}
