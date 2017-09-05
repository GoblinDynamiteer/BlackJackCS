using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bjcs
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

        /* Constructor */
        public Card(int value, int suit, int id)
        {
            this.value = value;
            this.suit = suit;
            this.cardId = id;
            this.played = false;
        }

        /* Set card status to played */
        public void SetPlayed()
        {
            this.played = true;
        }

        /* Return card status */
        public bool isPlayed()
        {
            return this.played;
        }

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

        /* Get card ID */
        public int GetId()
        {
            return cardId;
        }

        /* Get high score value */
        public int GetValueHigh()
        {
            /* 11 for ace */
            int retval = this.value == 0 ? 11 : GetValue();

            return retval;
        }

        /* Get low score value */
        public int GetValueLow()
        {
            /* 1 for ace */
            int retval = this.value == 0 ? 1 : GetValue();

            return retval;
        }

        private int GetValue()
        {
            return this.value > 9 ? 10 : this.value + 1;
        }
    }
}
