using System.Collections.Generic;
using PlayingCards;
using System.Linq;

namespace BlackJackPlayers
{
    class Hand
    {
        List<Card> cards;
        int valueHigh, valueLow;

        /* Constructor */
        public Hand()
        {
            cards = new List<Card>();
            valueLow = 0;
            valueHigh = 0;
        }

        /* Add card to player hand
         * use with Deck.Deal() */
        public void Add(Card newCard)
        {
            cards.Add(newCard);
            this.SetValues();
        }

        /* Return number of cards in hand */
        public int Count()
        {
            return this.cards.Count;
        }

        /* Set hand value(s) */
        private void SetValues()
        {
            valueHigh = valueLow = 0;

            /* Probably unneeded to check for aces.... */
            if (this.HasAces())
            {
                foreach (Card card in this.cards)
                {
                    valueLow += card.GetValue(false);
                    valueHigh += valueHigh + card.GetValue() < 21 ? 
                        card.GetValue() : card.GetValue(false);
                }
            }

            else
            {
                valueHigh = valueLow = this.cards.Sum(
                    p => p.GetValue());
            }
        }

        public bool Value(out int high, out int low)
        {
            high = valueHigh;
            low = valueLow;

            return (this.cards.Count == 2 && valueHigh == 21);
        }

        /* Determine if the hand contains ace(s) */
        private bool HasAces()
        {
            return (this.cards.Exists(
                c => c.GetValue(true) == 
                    (int)Card.Value.AceHigh));
        }

        /* Return card at hand index */
        public Card ShowCard(int index)
        {
            /* Check if correct... */
            if (index >= cards.Count)
            {
                return null;
            }

            return cards[index];
        }
    }
}
