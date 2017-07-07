
using System;
using System.Collections.Generic;
using PlayingCards;
using BlackJackPlayers;

namespace BlackjackCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck(4);
            deck.Shuffle();

            Hand hand = new Hand();

            /* Check natural blackjack */

            int count = 0;

            do
            {
                count++;
                hand.Clear();
                hand.Add(deck.Deal());
                hand.Add(deck.Deal());

            } while (!hand.NaturalBlackjack());

            Console.WriteLine("Tries: " + count);
            Console.WriteLine(hand.ToString());
            Console.ReadLine();
        }
    }
}
