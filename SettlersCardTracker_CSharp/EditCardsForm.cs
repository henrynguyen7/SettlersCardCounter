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
    public partial class EditCardsForm : Form
    {
        private Game game;           //the game that this EditCardsForm will manipulate
        private int playerToModify;  //the specific player that this EditCardsForm will manipulate
        private string changedCards; //string of cards to modify on the player

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public EditCardsForm()
        {
            InitializeComponent();
        }

        public EditCardsForm(int currentPlayer)
        {
            ///<summary>
            ///Overloaded constructor that will default radio button to current player.
            ///</summary>

            InitializeComponent();

            if (currentPlayer == 0)
                rdoPlayer1.Checked = true;
            else if (currentPlayer == 1)
                rdoPlayer2.Checked = true;
            else if (currentPlayer == 2)
                rdoPlayer3.Checked = true;
            else if (currentPlayer == 3)
                rdoPlayer4.Checked = true;
        }

        private void rdoPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            playerToModify = 0;
        }

        private void rdoPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            playerToModify = 1;
        }

        private void rdoPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            playerToModify = 2;
        }

        private void rdoPlayer4_CheckedChanged(object sender, EventArgs e)
        {
            playerToModify = 3;
        }

        private void txtCardsToModify_TextChanged(object sender, EventArgs e)
        {
            changedCards = txtCardsToModify.Text;
        }

        private void btnAddCards_Click(object sender, EventArgs e)
        {
            game.Players[playerToModify].AddCards(changedCards);

            this.Close();
        }

        private void btnRemoveCards_Click(object sender, EventArgs e)
        {
            game.Players[playerToModify].RemoveCards(changedCards);

            this.Close();
        }
    }
}
