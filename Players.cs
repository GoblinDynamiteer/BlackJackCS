using System.Collections.Generic;
using PlayingCards;
using System;

namespace BlackJackPlayers
{
    class Hand
    {
        List<Card> cards;
        List<Card> history;
        int valueHigh, valueLow;
        bool naturalBlackjack;

        /* Constructor */
        public Hand()
        {
            cards = new List<Card>();
            history = new List<Card>();
            valueLow = 0;
            valueHigh = 0;
            naturalBlackjack = false;
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
            foreach (Card card in this.cards)
            {
                valueLow += card.GetValue(false);
                valueHigh += valueHigh + card.GetValue() < 21 ? 
                    card.GetValue() : card.GetValue(false);
            }

            this.naturalBlackjack = 
                (this.cards.Count == 2 && valueHigh == 21);
        }

        /* Returns low/high */
        public int ValueHigh()
        {
            return valueHigh;
        }

        /* Returns low/high */
        public int ValueLow()
        {
            return valueLow;
        }

        public bool NaturalBlackjack()
        {
            return naturalBlackjack;
        }

        /* Determine if the hand contains ace(s) */
        private bool HasAces()
        {
            return (this.cards.Exists(
                c => c.GetValue(true) == 
                    (int)Card.Value.AceHigh));
        }

        /* Clear hand and copy cards to history */
        public void Clear()
        {
            history.AddRange(cards);
            cards.Clear();
        }

        public override string ToString()
        {
            string retval = "Hand:\n";
            this.cards.ForEach(c => retval += c.ToString() + "\n");
            return retval;
        }

        /* Return card at hand index */
        public Card ShowCard(int index)
        {
            /* Check if correct... */
            if (index >= cards.Count)
            {
                /* Fix */
                Console.WriteLine("DECK EMPTY!");
                return null;
            }

            return cards[index];
        }
    }
}
