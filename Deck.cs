
using System;
using System.Collections.Generic;

namespace BlackjackCS
{
    class Card
    {
        private int value;
        private int suit;
        private int cardId;

        public Card(int value, int suit, int id)
        {
            this.value = value;
            this.suit = suit;
            this.cardId = id;
        }

        static public readonly int maxValue = 13;
        static public readonly int maxSuit = 4;

        public readonly string[] valueName = {
            "Ace",
            "Two",
            "Three",
            "Four",
            "Five",
            "Six",
            "Seven",
            "Eight",
            "Nine",
            "Ten",
            "Jack",
            "Queen",
            "King"
        };

        public readonly string[] suitName = {
            "Hearts",
            "Diamonds",
            "Clubs",
            "Spades"
        };

        public override string ToString()
        {
            return string.Format("{0} of {1}",
                valueName[this.value],
                suitName[this.suit]);
        }

        public int GetId()
        {
            return cardId;
        }

        public int GetValue(bool high = true)
        {
            int retval;

            /* Ace */
            if (this.value == 0)
                retval = high ? 11 : 1;

            else
                retval = this.value > 9 ? 10 : this.value + 1;

            return retval;
        }
    }


    class Deck
    {
        public List<Card> card;

        public Deck(int numberOfDecks = 1)
        {
            card = new List<Card>();
            int cardId = 0;

            for (int i = 0; i < numberOfDecks; i++)
            {
                for (int suit = 0; suit < Card.maxSuit; suit++)
                {
                    for (int value = 0; value < Card.maxValue; value++)
                    {
                        card.Add(new Card(value, suit, cardId++));
                    }
                }
            }
        }

        /* Shuffle deck */
        public void Shuffle(int numberOfShuffles = 3000)
        {
            Random rand = new Random();

            for (int i = 0; i < numberOfShuffles; i++)
            {
                SwapCards(
                    rand.Next(0, card.Count),
                    rand.Next(0, card.Count));
            }
        }

        private void SwapCards(int index1, int index2)
        {
            if (index1 == index2)
                return;

            Card temp = card[index1];
            card[index1] = card[index2];
            card[index2] = temp;
        }
    }
}
