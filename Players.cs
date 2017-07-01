using System.Collections.Generic;
using PlayingCards;

namespace BlackJackPlayers
{
    class Hand
    {
        public List<Card> card;

        public Hand()
        {
            card = new List<Card>();
        }

        public void Add(Card newCard)
        {
            card.Add(newCard);
        }

        public int Value(bool high = false)
        {
            int value = 0;

            /* Fix, can mix high/low value for 
             * several aces in hand */
            foreach (Card card in this.card)
            {
                value += high ? card.GetValue(true) : card.GetValue(false);
            }

            return value;
        }

        public Card ShowCard(int index)
        {
            return card[index];
        }
    }
}
