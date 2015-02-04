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
using System.Windows.Forms;

//TODO: Add error handling.
//      Finish commenting for functions and parameters.
//      Const modifiers? (Check .NET conventions).
//      Game: Fix logic error in SetRobberLocation().
//      Player: Should throw exception when removing cards which don't exist. 
//      NewGameForm: Exception thrown when game is started with no values.
//      ! MainForm: Implement Undo() (MVC design pattern?).

namespace SettlersCardTracker
{
    public static class Program
    {
        /// <summary>
        /// Settlers of Catan is a physical board game somewhat similar to Risk with
        /// elements of poker, Monopoly, and others. This Settlers Card Tracker 
        /// program keeps tracks of players' cards in a game of Settlers of Catan 
        /// based on rolls of the dice and plays made. The program accepts manual 
        /// input from the user in a GUI and displays constantly-updated information 
        /// with each successive input.
        /// </summary>

        [STAThread]

        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());            
        }        
    }
}
