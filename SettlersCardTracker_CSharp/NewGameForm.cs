/*********************************************
 * Author: Henry Nguyen
 * Email: Henry@DxConcept.com
 * Date: January 28, 2011
 * Description: Settlers of Catan Card Tracker
 * ******************************************/

using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SettlersCardTracker
{
    public partial class NewGameForm : Form
    {
        private Game game; //the game that this NewGameForm will manipulate

        public Game Game
        {
            get { return game; }
            set { game = value; }
        }

        public NewGameForm()
        {
            InitializeComponent();
        }

        private void btnTestCases_Click(object sender, EventArgs e)
        {
            txtFirstValuesForPlayer1.Text = "1,1,1";
            txtFirstValuesForPlayer2.Text = "2,2,2";
            txtFirstValuesForPlayer3.Text = "3,3,3";
            txtFirstValuesForPlayer4.Text = "4,4,4";
            txtFirstTypesForPlayer1.Text = "W,W,W";
            txtFirstTypesForPlayer2.Text = "B,B,B";
            txtFirstTypesForPlayer3.Text = "S,S,S";
            txtFirstTypesForPlayer4.Text = "T,T,T";
            txtSecondValuesForPlayer1.Text = "2,2,2";
            txtSecondValuesForPlayer2.Text = "4,4,4";
            txtSecondValuesForPlayer3.Text = "6,6,6";
            txtSecondValuesForPlayer4.Text = "8,8,8";
            txtSecondTypesForPlayer1.Text = "O,O,O";
            txtSecondTypesForPlayer2.Text = "O,O,O";
            txtSecondTypesForPlayer3.Text = "O,O,O";
            txtSecondTypesForPlayer4.Text = "O,O,O";

            rdoNumOfPlayersIs4.Checked = true;
            rdoFirstToPlaceIsPlayer4.Checked = true;
        }

        private void rdoNumOfPlayersIs1_CheckedChanged(object sender, EventArgs e)
        {
            game.NumberOfPlayers = 1;
        }

        private void rdoNumOfPlayersIs2_CheckedChanged(object sender, EventArgs e)
        {
            game.NumberOfPlayers = 2;
        }

        private void rdoNumOfPlayersIs3_CheckedChanged(object sender, EventArgs e)
        {
            game.NumberOfPlayers = 3;
        }

        private void rdoNumOfPlayersIs4_CheckedChanged(object sender, EventArgs e)
        {
            game.NumberOfPlayers = 4;
        }

        private void rdoFirstToPlaceIsPlayer1_CheckedChanged(object sender, EventArgs e)
        {
            game.FirstPlayer = 1;
        }

        private void rdoFirstToPlaceIsPlayer2_CheckedChanged(object sender, EventArgs e)
        {
            game.FirstPlayer = 2;
        }

        private void rdoFirstToPlaceIsPlayer3_CheckedChanged(object sender, EventArgs e)
        {
            game.FirstPlayer = 3;
        }

        private void rdoFirstToPlaceIsPlayer4_CheckedChanged(object sender, EventArgs e)
        {
            game.FirstPlayer = 4;
        }

        private void btn_newGameStart_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///When the Start Game button is pressed, it calls the Game object to
            ///create the players and set the first player to be the current player
            ///for the first round. It then takes the values from the input fields
            ///on the form and plays the appropriate action for each Player. The
            ///<code>this.GetType().GetField().GetValue()</code> function allows 
            ///the form to dynamically access the textboxes without their names 
            ///having to be hard-coded.
            ///</summary>

            game.CreatePlayers();

            game.SetCurrentPlayer();

            for (int i = 0; i < game.NumberOfPlayers; ++i)
            {
                TextBox firstValues = this.GetType().GetField("txtFirstValuesForPlayer" + (i + 1), 
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).
                    GetValue(this) as TextBox;
                TextBox firstTypes = this.GetType().GetField("txtFirstTypesForPlayer" + (i + 1), 
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).
                    GetValue(this) as TextBox;
                TextBox secondValues = this.GetType().GetField("txtSecondValuesForPlayer" + (i + 1), 
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).
                    GetValue(this) as TextBox;
                TextBox secondTypes = this.GetType().GetField("txtSecondTypesForPlayer" + (i + 1), 
                    System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).
                    GetValue(this) as TextBox;

                game.Players[i].BuySettlement(firstValues.Text, firstTypes.Text);
                game.Players[i].BuySettlement(secondValues.Text, secondTypes.Text);
                game.Players[i].BuyRoad();
                game.Players[i].BuyRoad();

                game.Players[i].AddCards(secondTypes.Text);
            }

            this.Close();
        }

        private void txtFirstValuesForPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstTypesForPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondValuesForPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondTypesForPlayer1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstValuesForPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstTypesForPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondValuesForPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondTypesForPlayer2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstValuesForPlayer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstTypesForPlayer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondValuesForPlayer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondTypesForPlayer3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstValuesForPlayer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstTypesForPlayer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondValuesForPlayer4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSecondTypesForPlayer4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
