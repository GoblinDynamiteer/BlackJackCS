
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

            Hand player1 = new Hand();
            Hand player2 = new Hand();
            Hand player3 = new Hand();
            Hand player4 = new Hand();
            Hand dealer = new Hand();

            for (int i = 0; i < 2; i++)
            {
                player1.Add(deck.Deal());
                player2.Add(deck.Deal());
                player3.Add(deck.Deal());
                player4.Add(deck.Deal());
                dealer.Add(deck.Deal());
            }

            int high, low;

            Console.WriteLine("\nPlayer 1:");
            Console.WriteLine(player1.ShowCard(0).ToString());
            Console.WriteLine(player1.ShowCard(1).ToString());
            player1.Value(out high, out low);
            Console.WriteLine("Score: " + low + " / " + high);

            Console.WriteLine("\nPlayer 2:");
            Console.WriteLine(player2.ShowCard(0).ToString());
            Console.WriteLine(player2.ShowCard(1).ToString());
            player2.Value(out high, out low);
            Console.WriteLine("Score: " + low + " / " + high);

            Console.WriteLine("\nPlayer 3:");
            Console.WriteLine(player3.ShowCard(0).ToString());
            Console.WriteLine(player3.ShowCard(1).ToString());
            player3.Value(out high, out low);
            Console.WriteLine("Score: " + low + " / " + high);

            Console.WriteLine("\nPlayer 4:");
            Console.WriteLine(player4.ShowCard(0).ToString());
            Console.WriteLine(player4.ShowCard(1).ToString());
            player4.Value(out high, out low);
            Console.WriteLine("Score: " + low + " / " + high);

            Console.WriteLine("\nDealer:");
            Console.WriteLine(dealer.ShowCard(0).ToString());
            Console.WriteLine(dealer.ShowCard(1).ToString());
            dealer.Value(out high, out low);
            Console.WriteLine("Score: " + low + " / " + high);

            Console.ReadLine();
        }
    }
}
