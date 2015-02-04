/*********************************************
 * Author: Henry Nguyen
 * Email: Henry@DxConcept.com
 * Date: January 28, 2011
 * Description: Settlers of Catan Card Tracker
 * Revision: 1.0.4.0
 * ******************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SettlersCardTracker
{
    public class Game
    {
        /// <summary>
        /// A Game object holds all the necessary variables, objects, and
        /// functions needed to operate the logic of the game. It consists of
        /// variables for the number of players, the first player to commence play,
        /// the current player actually playing, an array of the Player objects,
        /// in addition to functions specifying the actions of the game.
        /// </summary>

        private int numberOfPlayers; //number of players in the game
        private int firstPlayer;     //the first player (not 0-indexed) to start
        private int currentPlayer;   //the current player (0-indexed) currently playing
        private Player[] players;    //an array of the players

        // Public Accessors and Mutators
        
        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set { numberOfPlayers = value; }
        }

        public int FirstPlayer
        {
            get { return firstPlayer; }
            set { firstPlayer = value; }
        }

        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        public Player[] Players
        {
            get { return players; }
            set { players = value; }
        }

        // Game Functions

        public void CreatePlayers()
        {
            players = new Player[numberOfPlayers];

            for (int i = 0; i < numberOfPlayers; ++i)
            {
                players[i] = new Player(i);
            }

            currentPlayer = firstPlayer - 1;
        }

        public void SetCurrentPlayer()
        {
            players[currentPlayer].IsCurrentPlayer = true;
        }

        public void SetCurrentPlayer(int newCurrentPlayer)
        {
            players[newCurrentPlayer].IsCurrentPlayer = true;
        }

        public void RollDice(int numberRolled)
        {
            foreach (Player player in players)
            {
                player.Roll(numberRolled);
            }
        }

        public void PlayMonopoly(string resourceMonopolized)
        {
            ///<summary>
            ///A monopoly card played by a player causes all other players
            ///to remove the cards of a selected resource type and give them
            ///to the player who played the card. A totalCards variable is
            ///initialized to 0. Then, for each player, if the card in their
            ///hand matches the type that has been monopolized, it is counted 
            ///towards both the individual total of such cards (numberOfCards) 
            ///and the overall total of such cards for all players (totalCards).
            ///They are then deleted for all players. Finally, for the player
            ///who played the card, the total number of cards that existed prior
            ///to the deletion are replaced back into the player's list of cards.
            ///</summary>

            int totalCards = 0;

            foreach (Player player in players)
            {
                int numberOfCards = 0;

                foreach (char card in player.Cards)
                {
                    if (card == Convert.ToChar(resourceMonopolized))
                    {
                        ++numberOfCards;
                        ++totalCards;
                    }
                }

                for (int i = 0; i < numberOfCards; ++i)
                {
                    player.RemoveCards(resourceMonopolized);
                }
            }

            for (int i = 0; i < totalCards; ++i)
            {
                players[currentPlayer].AddCards(resourceMonopolized);
            }
        }

        public void SetRobberLocation(string newLocation)
        {
            //TODO: Logic error, see If statement below
            //    : Implement overloaded parameters
            //    : Rename substrings(?)
            //    : Bad pracice of hardcoding array index location

            foreach (Player player in players)
            {
                foreach (Resource resource in player.OwnedResources)
                {
                    resource.IsRobbed = false;
                }
            }

            string[] subString = newLocation.Split(',');

            foreach (Player player in players)
            {
                foreach (Resource resource in player.OwnedResources)
                {
                    if (resource.Value == Convert.ToChar(subString[0]) && 
                        resource.Type == Convert.ToChar(subString[1]))
                    //This may cause some resources to be robbed inadvertently. Works for now.
                    {
                        resource.IsRobbed = true;
                    }
                }
            }
        }

        public void PlayRobber(int playerRobbed, string resourceRobbed)
        {
            players[playerRobbed].RemoveCards(resourceRobbed);

            players[currentPlayer].AddCards(resourceRobbed);
        }

        public void PlayTrade(string resourcesTradedAway, string resourcesTradedFor)
        {
             players[currentPlayer].RemoveCards(resourcesTradedAway);   

             players[currentPlayer].AddCards(resourcesTradedFor);
        }

        public void PlayTrade(int playerTradedWith, string resourcesTradedAway, string resourcesTradedFor)
        {
            players[currentPlayer].RemoveCards(resourcesTradedAway);
            players[currentPlayer].AddCards(resourcesTradedFor);

            players[playerTradedWith].RemoveCards(resourcesTradedFor);
            players[playerTradedWith].AddCards(resourcesTradedAway);
        }

        public void EndTurn()
        {
            players[currentPlayer].IsCurrentPlayer = false;

            if ((currentPlayer + 1) == numberOfPlayers)
            {
                currentPlayer = 0;
            }
            else
            {
                currentPlayer++;
            }

            players[currentPlayer].IsCurrentPlayer = true;
        }
    }
}
