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
    public partial class PlayRobberForm : Form
    {
        private Game game;                //the game that this PlayRobberForm will manipulate
        private string newRobberLocation; //string of location (value,type) of new robber
        private string resourceRobbed;    //string of the resource that was taken from robbed player
        private int playerRobbed;         //the player that was robbed

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public PlayRobberForm()
        {
            InitializeComponent();
        }

        private void txtNewRobberLocation_TextChanged(object sender, EventArgs e)
        {
            newRobberLocation = txtNewRobberLocation.Text;
        }

        private void rdoPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            playerRobbed = 0;
        }

        private void rdoPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            playerRobbed = 1;
        }

        private void rdoPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            playerRobbed = 2;
        }

        private void rdoPlayer4_CheckedChanged(object sender, EventArgs e)
        {
            playerRobbed = 3;
        }

        private void txtResourceRobbed_TextChanged(object sender, EventArgs e)
        {
            resourceRobbed = txtResourceRobbed.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            game.SetRobberLocation(newRobberLocation);

            game.PlayRobber(playerRobbed, resourceRobbed);

            this.Close();
        }
    }
}
