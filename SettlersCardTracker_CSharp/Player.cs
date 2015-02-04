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
using System.Linq;
using System.Text;

namespace SettlersCardTracker
{
    public class Player
    {
        /// <summary>
        /// A Player object consists of an ID Number, a boolean value
        /// specifying whether that player is the current player, a list
        /// of current cards held in their hand, and a list of owned
        /// resource locations which are Resource objects. When a new player
        /// is instantiated, they are given the cards necessary for beginning
        /// the game. Their other starting values are inputted by the user
        /// in the NewGameForm form object. The player also has a number of
        /// actions (functions) which it can perform to play the game.
        /// For simplicity and portability, a Player will accept mainly 
        /// string arguments and perform formatting by itself.
        /// </summary>

        private int idNumber;                  //the ID number of the player, from 1 to 4
        private bool isCurrentPlayer = false;  //boolean whether the player is the current player
        private List<char> cards;              //list of type cards held in the hand currently
        private List<Resource> ownedResources; //list of currently owned resource spots

        // Public Accessors and Mutators

        public int IDNumber
        {
            get { return idNumber; }
            set { idNumber = value; }
        }

        public bool IsCurrentPlayer
        {
            get { return isCurrentPlayer; }
            set { isCurrentPlayer = value; }
        }

        public List<char> Cards
        {
            get { return cards; }
            set { cards = value; }
        }


        public List<Resource> OwnedResources
        {
            get { return ownedResources; }
            set { ownedResources = value; }
        }

        // Constructors

        public Player()
        {
            ownedResources = new List<Resource>();

            cards = new List<char>();

            cards.Add('B');
            cards.Add('B');
            cards.Add('B');
            cards.Add('B');
            cards.Add('W');
            cards.Add('W');
            cards.Add('W');
            cards.Add('W');
            cards.Add('S');
            cards.Add('S');
            cards.Add('T');
            cards.Add('T');
        }

        public Player(int newIDNumber)
        {
            idNumber = newIDNumber;

            ownedResources = new List<Resource>();

            cards = new List<char>();

            cards.Add('B');
            cards.Add('B');
            cards.Add('B');
            cards.Add('B');
            cards.Add('W');
            cards.Add('W');
            cards.Add('W');
            cards.Add('W');
            cards.Add('S');
            cards.Add('S');
            cards.Add('T');
            cards.Add('T');
        }

        // Player-specific Functions

        //TODO: Prompt user when cards to be removed do not exist in player's hands

        public void Roll(int numberRolled)
        {
            foreach (Resource ownedResource in ownedResources)
            {
                if (ownedResource.IsRobbed == false)
                {
                    if (ownedResource.Value == numberRolled)
                    {
                        cards.Add(ownedResource.Type);
                    }
                }
            }

            cards.Sort();
        }

        public void BuyRoad()
        {
            cards.Remove('W');
            cards.Remove('B');
        }

        public void BuySettlement(string valueString, string typeString)
        {
            string[] values = valueString.Split(',');

            string[] types = typeString.Split(',');

            for (int i = 0; i < values.Count(); ++i)
            {
                ownedResources.Add(new Resource(Convert.ToInt32(values[i]), Convert.ToChar(types[i])));
            }

            cards.Remove('W');
            cards.Remove('B');
            cards.Remove('T');
            cards.Remove('S');
        }

        public void BuyCity(string valueString, string typeString)
        {
            string[] values = valueString.Split(',');

            string[] types = typeString.Split(',');

            for (int i = 0; i < values.Count(); ++i)
            {
                ownedResources.Add(new Resource(Convert.ToInt32(values[i]), Convert.ToChar(types[i])));
            }

            cards.Remove('O');
            cards.Remove('O');
            cards.Remove('O');
            cards.Remove('T');
            cards.Remove('T');
        }

        public void BuyCard()
        {
            cards.Remove('O');
            cards.Remove('T');
            cards.Remove('S');
        }

        public void PlayYearPlenty(string cardsGained)
        {
            string[] subStrings = cardsGained.Split(',');

            foreach (string card in subStrings)
            {
                cards.Add(Convert.ToChar(cardsGained));
            }
        }

        public void AddCards(char cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public void AddCards(string cardsToAdd)
        {
            string[] subStrings = cardsToAdd.Split(',');

            foreach (string card in subStrings)
            {
                cards.Add(Convert.ToChar(card));
            }
        }

        public void RemoveCards(char cardToRemove)
        {
            cards.Remove(cardToRemove);
        }

        public void RemoveCards(string cardsToRemove)
        {
            string[] subStrings = cardsToRemove.Split(',');

            foreach (string card in subStrings)
            {
                cards.Remove(Convert.ToChar(card));
            }
        }

        public string CardsToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (char card in cards)
            {
                builder.Append(card);
            }
            string result = builder.ToString();

            return result;
        }
    }
}
