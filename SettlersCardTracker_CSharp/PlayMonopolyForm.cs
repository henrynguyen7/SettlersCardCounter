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
    public partial class PlayMonopolyForm : Form
    {
        private Game game;                  //the game that this PlayMonopolyForm will manipulate
        private string resourceMonopolized; //string of cards that will be monopolized by current player

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public PlayMonopolyForm()
        {
            InitializeComponent();
        }

        private void txtResourceMonopolized_TextChanged(object sender, EventArgs e)
        {
            resourceMonopolized = txtResourceMonopolized.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            game.PlayMonopoly(resourceMonopolized);

            this.Close();
        }
    }
}
