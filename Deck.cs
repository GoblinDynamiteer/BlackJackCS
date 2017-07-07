
using System;
using System.Collections.Generic;

namespace PlayingCards
{
    class Card
    {
        private int value;
        private int suit;
        private int cardId;
        private bool played;

        public enum Value
        {
            AceLow = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            Jack = 10,
            Queen = 10,
            King = 10,
            AceHigh = 11
        }

        public Card(int value, int suit, int id)
        {
            this.value = value;
            this.suit = suit;
            this.cardId = id;
            this.played = false;
        }

        public void SetPlayed()
        {
            this.played = true;
        }

        public bool isPlayed()
        {
            return this.played;
        }

        static public readonly int maxValue = 13;
        static public readonly int maxSuit = 4;

        readonly string[] valueName = {
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

        readonly string[] suitName = {
            "Hearts",
            "Diamonds",
            "Clubs",
            "Spades"
        };

        /* Eg. Nine of Hearts */
        public string ToString(bool extendedInfo = false)
        {

            if (extendedInfo)
            {
                return string.Format(
                    "Id: {0:000} Played: {1} Name: {2} of {3}",
                        this.cardId,
                        this.played ? "Yes" : "No",
                        valueName[this.value],
                        suitName[this.suit]);
            }

            return string.Format("{0} of {1}",
                valueName[this.value],
                suitName[this.suit]);
        }

        public int GetId()
        {
            return cardId;
        }

        /* Get blackjack value */
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
        int numberOfDecks;
        bool anyCardDealt;

        public Deck(int numberOfDecks = 1)
        {
            card = new List<Card>();
            this.numberOfDecks = numberOfDecks;
            this.anyCardDealt = false;
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

        /* Swap two cards in the deck, for shuffle */
        private void SwapCards(int index1, int index2)
        {
            /* Skip if same card to swap */
            if (index1 == index2)
                return;

            Card temp = card[index1];
            card[index1] = card[index2];
            card[index2] = temp;
        }

        /* Deal and remove first card in stack */
        public Card Deal()
        {
            if (card.Count >= 1)
            {
                this.anyCardDealt = true;
                card[0].SetPlayed();
                Card retVal = card[0];
                card.RemoveAt(0);
                return retVal;
            }

            /* If no cards left in deck */
            return null;
        }

    }
}
