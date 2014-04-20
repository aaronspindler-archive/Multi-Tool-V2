using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Multi_Tool_V2.Properties;

namespace Multi_Tool_V2
{
    public partial class RandomPassword_Home : Form
    {
        //@author xNovax
        //Start of Global Variable Declaration

        private readonly Random gen = new Random();

        //Array of characters that are allowed in the normal password type
        private readonly String[] normalPasswordArray = new String[52]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z"
        };

        //Array of characters that are allowed in the numbers password type
        private readonly String[] numbersPasswordArray = new String[62]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
        };

        //Array of characters that are allowed in the special password type
        private readonly String[] specialPasswordArray = new String[77]
        {
            "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v",
            "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R",
            "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0", "!", "@", "#", "$",
            "%", "^", "&", "*", "_", "-", "+", "=", "<", ">", "?"
        };

        private readonly String username = Settings.Default.userName;
        String errorCode = ("");
        private decimal lengthOfPassword = 16;
        private decimal numberOfPasswords = 1;
        private int passwordType;
        private string randomCharacter;

        //End of Gloabl Variable Declaration

        public RandomPassword_Home()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods

        public void getRandomCharacter()
        {
            passwordType = Settings.Default.randomPasswordType;
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
                var writer = new StreamWriter(saveFileDialog.FileName);
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
                outputLabel.Text = ("Your passwords have been successfully written to: " + saveFileDialog.FileName);
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
            string messageBoxContents = ("An error has occured: " + errorCode);
            string messageBoxTitle = ("Error");
            MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //End of Author Defined Methods

        private void createButton_Click(object sender, EventArgs e)
        {
            passwordType = Settings.Default.randomPasswordType;
            getRandomCharacter();
            printToFile();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void randomPassword_Home_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rpo = new RandomPassword_Options();
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