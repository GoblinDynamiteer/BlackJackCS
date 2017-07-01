
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
            /* Create and print 4 decks */
            Deck deck = new Deck(1);

            int listIndex = 0;

            foreach (Card card in deck.card)
            {
                Console.Write(listIndex++ + " ");
                Console.Write("{0:000} ", card.GetId());
                Console.Write(card.ToString());
                Console.WriteLine(" Value: {0}", card.GetValue());

                if (listIndex == 10) break;
            }

            Console.WriteLine("");
            deck.Shuffle();
            listIndex = 0;

            foreach (Card card in deck.card)
            {
                Console.Write(listIndex++ + " ");
                Console.Write("{0:000} ", card.GetId());
                Console.Write(card.ToString());
                Console.WriteLine(" Value: {0}", card.GetValue());

                if (listIndex == 10) break;
            }

            Hand player = new Hand();
            Hand dealer = new Hand();

            player.Add(deck.Deal());
            player.Add(deck.Deal());

            dealer.Add(deck.Deal());
            dealer.Add(deck.Deal());

            listIndex = 0;
            Console.WriteLine("");

            foreach (Card card in deck.card)
            {
                Console.Write(listIndex++ + " ");
                Console.Write("{0:000} ", card.GetId());
                Console.Write(card.ToString());
                Console.WriteLine(" Value: {0}", card.GetValue());

                if (listIndex == 10) break;
            }

            Console.WriteLine("");

            Console.WriteLine("Player hand: \n{0}\n{1}",
                player.ShowCard(0).ToString(true), player.ShowCard(1).ToString(true)
                );
            Console.WriteLine("Dealer hand: \n{0}\n{1}",
                dealer.ShowCard(0).ToString(true), dealer.ShowCard(1).ToString(true)
                );

            Console.ReadLine();
        }
    }
}
