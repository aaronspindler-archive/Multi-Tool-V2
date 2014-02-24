using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
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
        int passwordType;
        Random gen = new Random();
        string randomCharacter;
        decimal numberOfPasswords;
        decimal lengthOfPassword;

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
            passwordType = Multi_Tool_V2.Properties.Settings.Default.randomPasswordType;
            if (passwordType == 0)
            {
                int randNormal = gen.Next(52);
                randomCharacter = normalPasswordArray[randNormal];
            }
            else
            {
                if (passwordType == 1)
                {
                    int randNumber = gen.Next(62);
                    randomCharacter = numbersPasswordArray[randNumber];
                }
                else
                {
                    if (passwordType == 2)
                    {
                        int randSpecial = gen.Next(77);
                        randomCharacter = specialPasswordArray[randSpecial];
                    }
                    else
                    {
                        if (passwordType == 3)
                        {
                            errorCode = ("You have not selected a type of password to print.");
                            errorOccured();
                        }
                        else
                        {
                            if (passwordType == 4)
                            {
                                errorCode = ("You have somehow selected an option that does not exist");
                                errorOccured();
                            }
                        }
                    }
                }
            }
        }

        public void printToFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                for (int i = 0; i < numberOfPasswords; i++)
                {
                    for (int j = 0; j < lengthOfPassword; j++)
                    {
                        getRandomCharacter();
                        writer.Write(randomCharacter);
                    }
                    writer.WriteLine();
                }
                outputLabel.ForeColor = Color.Aqua;
                outputLabel.Text = ("Your passwords have been successfully written to " + saveFileDialog.FileName);
                writer.Close();
            }
            else
            {
                outputLabel.ForeColor = Color.Red;
                outputLabel.Text = ("Error Occured");
                errorCode = ("Please click OK if you want your password to actually be written");
                errorOccured();
            }
        }

        //General error message with a customizable error code.
        public void errorOccured()
        {
            var messageBoxContents = ("An error has occured: " + errorCode);
            var messageBoxTitle = ("Error");
            MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //End of Author Defined Methods

        private void createButton_Click(object sender, EventArgs e)
        {
            getRandomCharacter();
            printToFile();
        }

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

        private void numberOfPasswordsUD_ValueChanged(object sender, EventArgs e)
        {
            numberOfPasswords = numberOfPasswordsUD.Value;
        }

        private void lengthOfPasswordsUD_ValueChanged(object sender, EventArgs e)
        {
            lengthOfPassword = lengthOfPasswordsUD.Value;
        }
    }
}
