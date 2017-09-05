using System.Collections.Generic;
using System;

namespace bjcs
{
    class Hand
    {
        List<Card> cards;
        List<Card> history;
        int scoreHigh, scoreLow;
        bool naturalBlackjack;

        /* Constructor */
        public Hand()
        {
            cards = new List<Card>();
            history = new List<Card>();
            scoreLow = 0;
            scoreHigh = 0;
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
            scoreHigh = scoreLow = 0;

            foreach (Card card in this.cards)
            {
                scoreHigh += card.GetValueHigh();
                scoreLow += card.GetValueLow();
            }

            this.naturalBlackjack = 
                (this.cards.Count == 2 && scoreHigh == 21);
        }

        /* Returns low/high */
        public int ScoreHigh()
        {
            return scoreHigh;
        }

        /* Returns low/high */
        public int ScoreLow()
        {
            return scoreLow;
        }

        public bool hasNatural()
        {
            return naturalBlackjack;
        }

        /* Determine if the hand contains ace(s) */
        private bool HasAces()
        {
            return (this.cards.Exists(
                c => c.GetValueHigh() == 
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
