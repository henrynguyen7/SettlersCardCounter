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
    public partial class BuySettlementForm : Form
    {
        private Player player; //the player that this BuySettlementForm will manipulate
        private string values; //string of values to be purchased by player object
        private string types;  //string of types to be purchased by player object

        public Player Player
        {
            get { return player; }
            set { player = value; }
        }

        public BuySettlementForm()
        {
            InitializeComponent();
        }

        private void txtNewValue_TextChanged(object sender, EventArgs e)
        {
            values = txtNewValue.Text;
        }

        private void txtNewType_TextChanged(object sender, EventArgs e)
        {
            types = txtNewType.Text;
        }

        private void btnBuySettlementSubmit_Click(object sender, EventArgs e)
        {
            player.BuySettlement(values, types);

            this.Close();
        }
    }
}
