/* Filename: blackjack game menu interface form.
 * Author: Quintin Mudge.
 * Created: 21/09/2017.
 * Operating system: Windows.
 * Version: Window 10.
 * Description: Starting main form of the blackjack game application.
 * Lets the user start a new game or quit the application.
*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Game
{
    /* Starting form of blackjack game application. Creates a user interface
     * with two option buttons to either start a new game or quit the program.
    */
    public partial class startScreen : Form
    {
        public startScreen()
        {
            //Creates the componenets on the form.
            InitializeComponent();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 21/09/2017.
         * Description: Action event listener for clicking the quit button. Exits the application
         * and terminates the form.
        */
        private void QuitButtonClick(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /* Author: Quintin Mudge.
         * Version: 1.
         * Date: 21/09/2017.
         * Description: Action event listener for clicking the start button. Creates a new game
         * form and closes the current form.
        */
        private void NewGameButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            NewGame game = new NewGame();
            game.Closed += (s, args) => this.Close();
            game.Show();
            
        }
    }
}
