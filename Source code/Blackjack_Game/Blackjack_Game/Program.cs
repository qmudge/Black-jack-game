/* Filename: Main method.
 * Author: Quintin Mudge.
 * Created: 21/09/2017.
 * Operating system: Windows.
 * Version: Windows 10.
 * Description: main entry point for the application.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Blackjack_Game
{
    static class BlackJack
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new startScreen());
        }
    }
}
