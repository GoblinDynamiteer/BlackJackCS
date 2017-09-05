using System;
using System.Collections.Generic;

namespace bjcs
{
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
