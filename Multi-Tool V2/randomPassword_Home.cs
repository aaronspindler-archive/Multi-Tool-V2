using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Tool_V2
{
    public partial class randomPassword_Home : Form
    {
        //@author xNovax
        //Start of Global Variable Declaration

        String username = Multi_Tool_V2.Properties.Settings.Default.userName;
        String errorCode = ("");

        //Array of characters that are allowed in the normal password type
        String[] normalPasswordArray = new String[52]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        //Array of characters that are allowed in the numbers password type
        String[] numbersPasswordArray = new String[62]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
        };

        //Array of characters that are allowed in the special password type
        String[] specialPasswordArray = new String[77]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$",
            "%", "^", "&", "*", "_", "-", "+", "=", "<", ">", "?"
        };

        //End of Gloabl Variable Declaration

        public randomPassword_Home()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods

        public void getRandomCharacter()
        {
            
        }

        //General error message with a customizable error code.
        public void errorOccured()
        {
            var messageBoxContents = ("An error has occured: " + errorCode);
            var messageBoxTitle = ("Error");
            MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //End of Author Defined Methods

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void randomPassword_Home_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpo = new randomPassword_Options();
            rpo.Show();
        }
    }
}
