/*********************************************
 * Author: Henry Nguyen
 * Email: Henry@DxConcept.com
 * Date: January 28, 2011
 * Description: Settlers of Catan Card Tracker
 * ******************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SettlersCardTracker
{
    public partial class PlayTradeForm : Form
    {
        private Game game;                  //the game that this PlayTradeForm will manipulate
        private int playerTradedWith;       //the player that the current player traded with
        private bool tradedWithBank;        //boolean whether the current player traded with bank
        private string resourcesTradedAway; //string of resources that were given up in the trade
        private string resourcesTradedFor;  //string of resources that were received in the trade

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public PlayTradeForm()
        {
            InitializeComponent();

            rdoBank.Checked = true;
        }

        private void rdoPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            playerTradedWith = 0;
        }

        private void rdoPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            playerTradedWith = 1;
        }

        private void rdoPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            playerTradedWith = 2;
        }

        private void rdoPlayer4_CheckedChanged(object sender, EventArgs e)
        {
            playerTradedWith = 3;
        }

        private void rdoBank_CheckedChanged(object sender, EventArgs e)
        {
            tradedWithBank = true;
        }

        private void txtResourcesTradedAway_TextChanged(object sender, EventArgs e)
        {
            resourcesTradedAway = txtResourcesTradedAway.Text;
        }

        private void txtResourcesTradedFor_TextChanged(object sender, EventArgs e)
        {
            resourcesTradedFor = txtResourcesTradedFor.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (tradedWithBank)
            {
                game.PlayTrade(resourcesTradedAway, resourcesTradedFor);
            }
            else if (!tradedWithBank)
            {
                game.PlayTrade(playerTradedWith, resourcesTradedAway, resourcesTradedFor);
            }

            this.Close();
        }
    }
}
