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
    public class Resource
    {
        /// <summary>
        /// A Resource object corresponds to one possible board placement
        /// on the physical game board. It consists of a value which can range 
        /// from 2 to 12 and a type which can be either wood(W), brick(B), 
        /// wheat(T), sheep(S), or ore(O). Each Player object will potentially
        /// own a number of these resources. When the dice rolled by a player
        /// matches the values of resources owned by the players, each player
        /// receives a card of their corresponding type. The resource can also be 
        /// robbed, meaning that no card will be given for a matching roll.
        /// This logic is implemented in the Player class which owns Resources.
        /// </summary>

        private int rValue;    //value as a number (2-12) of resource
        private char rType;    //type (W,B,T,S,O) of resource
        private bool isRobbed; //boolean whether resource spot is currently robbed

        public int Value
        {
            get { return rValue; }
            set { rValue = value; }
        }

        public char Type
        {
            get { return rType; }
            set { rType = value; }
        }

        public bool IsRobbed
        {
            get { return isRobbed; }
            set { isRobbed = value; }
        }

        public Resource(int newValue, char newType)
        {
            rValue = newValue;
            rType = newType;
        }
    }
}