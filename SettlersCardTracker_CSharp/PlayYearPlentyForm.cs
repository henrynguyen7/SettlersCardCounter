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
    public partial class PlayYearPlentyForm : Form
    {
        private Player player;          //the player that this PlayYearPlentyForm will manipulate
        private string resourcesGained; //string of resources that were gained by the current player

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public PlayYearPlentyForm()
        {
            InitializeComponent();
        }

        private void txtResourcesGained_TextChanged(object sender, EventArgs e)
        {
            resourcesGained = txtResourcesGained.Text;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            player.PlayYearPlenty(resourcesGained);

            this.Close();
        }
    }
}
