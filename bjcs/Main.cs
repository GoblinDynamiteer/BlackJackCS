using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bjcs
{
    public partial class Main : Form
    {
        Deck deck = new Deck(6);
        Hand hand = new Hand();

        public Main()
        {
            InitializeComponent();

            deck.Shuffle();
        }

        private void btnDeal_Click(object sender, EventArgs e)
        {
            hand.Add(deck.Deal());

            textBoxCards.AppendText(hand.ShowCard(hand.Count() - 1).ToString() + "\r\n");
            textBoxNumberInHand.Text = hand.Count().ToString();

            lblScoreHigh.Text = hand.ScoreHigh().ToString();
            lblScoreLow.Text = hand.ScoreLow().ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            hand.Clear();
            textBoxCards.Clear();
            lblScoreHigh.Text = "0";
            lblScoreLow.Text = "0";
            textBoxNumberInHand.Text = "0";
        }
    }
}
