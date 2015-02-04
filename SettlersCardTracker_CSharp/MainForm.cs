/*********************************************
 * Author: Henry Nguyen
 * Email: Henry@DxConcept.com
 * Date: January 28, 2011
 * Description: Settlers of Catan Card Tracker
 * Revision: 1.0.4.0
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
    public partial class MainForm : Form
    {
        ///<summary>
        ///A MainForm object is derived from a Form container object and 
        ///contains simply the Game object and the main controls needed 
        ///to operate the logic of the game. Every MainForm, upon 
        ///instantiation, creates its own Game object which will then 
        ///be passed around to child forms for modifications, depending 
        ///on the action, and returned to the MainForm when complete.
        ///</summary> 

        private Game game = new Game(); //The game object, one per mainform

        public Game Game
        {
            get { return game; }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            ///<summary>
            ///When a new game is started, MainForm creates a NewGameForm
            ///to request user input regarding the state of the new game.
            ///It then enables its buttons, clears the current cards for all 
            ///players, and updates the players' cards.
            ///</summary>

            NewGameForm newGameForm = new NewGameForm();
            newGameForm.Game = game;
            newGameForm.ShowDialog();

            lblCardsPlayer1.Text = "-";
            lblCardsPlayer2.Text = "-";
            lblCardsPlayer3.Text = "-";
            lblCardsPlayer4.Text = "-";

            EnableButtons(true);
            UpdateCurrentPlayer();
            UpdatePlayersCards();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            //TODO: Keep track of previous game states (in array?) and revert.

            MessageBox.Show("Not yet implemented.");
        }

        private void btnEditCards_Click(object sender, EventArgs e)
        {
            EditCardsForm editCardsForm = new EditCardsForm(game.CurrentPlayer);
            editCardsForm.Game = game;
            editCardsForm.ShowDialog();

            UpdatePlayersCards();
        }

        ///<summary>
        ///On each roll of the dice (as determined by the user's click), 
        ///the MainForm calls the Game to roll that number for each player. 
        ///Then, the MainForm updates the cards (labels).
        ///In case of a roll of 7, which indicates that a Robber is to be 
        ///played, the MainForm tells the Game to play the robber for 
        ///the current player.
        /// </summary>
        
        private void btnRoll1_Click(object sender, EventArgs e)
        {
            game.RollDice(1);

            UpdatePlayersCards();
        }

        private void btnRoll2_Click(object sender, EventArgs e)
        {
            game.RollDice(2);

            UpdatePlayersCards();
        }

        private void btnRoll3_Click(object sender, EventArgs e)
        {
            game.RollDice(3);

            UpdatePlayersCards();
        }

        private void btnRoll4_Click(object sender, EventArgs e)
        {
            game.RollDice(4);

            UpdatePlayersCards();
        }

        private void btnRoll5_Click(object sender, EventArgs e)
        {
            game.RollDice(5);

            UpdatePlayersCards();
        }

        private void btnRoll6_Click(object sender, EventArgs e)
        {
            game.RollDice(6);

            UpdatePlayersCards();
        }

        private void btnRoll7_Click(object sender, EventArgs e)
        {
            PlayRobberForm playRobberForm = new PlayRobberForm();
            playRobberForm.Game = game;
            playRobberForm.ShowDialog();

            UpdatePlayersCards();
        }

        private void btnRoll8_Click(object sender, EventArgs e)
        {
            game.RollDice(8);

            UpdatePlayersCards();
        }

        private void btnRoll9_Click(object sender, EventArgs e)
        {
            game.RollDice(9);

            UpdatePlayersCards();
        }

        private void btnRoll10_Click(object sender, EventArgs e)
        {
            game.RollDice(10);

            UpdatePlayersCards();
        }

        private void btnRoll11_Click(object sender, EventArgs e)
        {
            game.RollDice(11);

            UpdatePlayersCards();
        }

        private void btnRoll12_Click(object sender, EventArgs e)
        {
            game.RollDice(12);

            UpdatePlayersCards();
        }

        // MainForm UX Functions

        private void btnBuyRoad_Click(object sender, EventArgs e)
        {
            game.Players[game.CurrentPlayer].BuyRoad();

            UpdatePlayersCards();
        }

        private void btnBuySettlement_Click(object sender, EventArgs e)
        {
            BuySettlementForm buySettlementForm = new BuySettlementForm();
            buySettlementForm.Player = game.Players[game.CurrentPlayer];
            buySettlementForm.ShowDialog();

            UpdatePlayersCards();
        }

        private void btnBuyCity_Click(object sender, EventArgs e)
        {
            BuyCityForm buyCityForm = new BuyCityForm();
            buyCityForm.Player = game.Players[game.CurrentPlayer];
            buyCityForm.ShowDialog();

            UpdatePlayersCards();
        }

        private void btnBuyCard_Click(object sender, EventArgs e)
        {
            game.Players[game.CurrentPlayer].BuyCard();

            UpdatePlayersCards();
        }

        private void btnPlayRobber_Click(object sender, EventArgs e)
        {
            PlayRobberForm playRobberForm = new PlayRobberForm();
            playRobberForm.Game = game;
            playRobberForm.ShowDialog();

            UpdatePlayersCards();
        }

        private void btnPlayMonopoly_Click(object sender, EventArgs e)
        {
            PlayMonopolyForm playMonopolyForm = new PlayMonopolyForm();
            playMonopolyForm.Game = game;
            playMonopolyForm.ShowDialog();

            UpdatePlayersCards();
        }

        private void btnPlayYearPlenty_Click(object sender, EventArgs e)
        {
            PlayYearPlentyForm playYearPlentyForm = new PlayYearPlentyForm();
            playYearPlentyForm.Player = game.Players[game.CurrentPlayer];
            playYearPlentyForm.ShowDialog();

            UpdatePlayersCards();
        }

        private void btnPlayTrade_Click(object sender, EventArgs e)
        {
            PlayTradeForm playTradeForm = new PlayTradeForm();
            playTradeForm.Game = game;
            playTradeForm.ShowDialog();

            UpdatePlayersCards();
        }

        private void btnEndTurn_Click(object sender, EventArgs e)
        {
            game.EndTurn();
            this.UpdatePlayersCards();
            this.UpdateCurrentPlayer();
        }

        // MainForm Functions

        private void EnableButtons(bool choice)
        {
            this.btnRoll1.Enabled = choice;
            this.btnRoll2.Enabled = choice;
            this.btnRoll3.Enabled = choice;
            this.btnRoll4.Enabled = choice;
            this.btnRoll5.Enabled = choice;
            this.btnRoll6.Enabled = choice;
            this.btnRoll7.Enabled = choice;
            this.btnRoll8.Enabled = choice;
            this.btnRoll9.Enabled = choice;
            this.btnRoll10.Enabled = choice;
            this.btnRoll11.Enabled = choice;
            this.btnRoll12.Enabled = choice;

            this.btnBuyRoad.Enabled = choice;
            this.btnBuySettlement.Enabled = choice;
            this.btnBuyCity.Enabled = choice;
            this.btnBuyCard.Enabled = choice;
            this.btnPlayRobber.Enabled = choice;
            this.btnPlayMonopoly.Enabled = choice;
            this.btnPlayYearPlenty.Enabled = choice;
            this.btnPlayTrade.Enabled = choice;
            this.btnEndTurn.Enabled = choice;

            this.btnEditCards.Enabled = choice;
            this.btnUndo.Enabled = choice;

            this.lblCardsPlayer1.Visible = choice;
            this.lblCardsPlayer2.Visible = choice;
            this.lblCardsPlayer3.Visible = choice;
            this.lblCardsPlayer4.Visible = choice;
        }

        public void UpdateCurrentPlayer()
        {
            ///<summary>
            ///UpdateCurrentPlayer() displays the "Now Playing" label for
            ///the player that is currently playing. Every player has a 
            ///"Now Playing" label but their visibilities are set to false. 
            ///UpdateCurrentPlayer() sets all visibilities to false and then
            ///enables the label as true for whichever player is currently
            ///playing.
            ///</summary>
            
            lblNowPlayingPlayer1.Visible = false;
            lblNowPlayingPlayer2.Visible = false;
            lblNowPlayingPlayer3.Visible = false;
            lblNowPlayingPlayer4.Visible = false;

            if (game.CurrentPlayer == 0)
                lblNowPlayingPlayer1.Visible = true;
            else if (game.CurrentPlayer == 1)
                lblNowPlayingPlayer2.Visible = true;
            else if (game.CurrentPlayer == 2)
                lblNowPlayingPlayer3.Visible = true;
            else if (game.CurrentPlayer == 3)
                lblNowPlayingPlayer4.Visible = true;
        }

        public void UpdatePlayersCards()
        {
            ///<summary>
            ///UpdatePlayersCards() calls the CardsToString() function of
            ///each player to set the text of the label for their cards. The
            ///<code>this.GetType().GetField().GetValue()</code> function allows 
            ///the form to dynamically access the labels without their names 
            ///having to be hard-coded.
            ///</summary>
            
            for (int i = 0; i < game.NumberOfPlayers; ++i)
            {
                Label tempLabel = this.GetType().GetField("lblCardsPlayer" + (i + 1)).
                    GetValue(this) as Label;  

                tempLabel.Text = game.Players[i].CardsToString();
            }
        }
    }
}
