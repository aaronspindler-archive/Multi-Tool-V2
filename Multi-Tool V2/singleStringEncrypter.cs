using System;
using System.Windows.Forms;

namespace Multi_Tool_V2
{
    public partial class singleStringEncrypter : Form
    {
        //@author xNovax
        public singleStringEncrypter()
        {
            InitializeComponent();
        }
        //Start of Global Variable Declaration
        string encryptionKey = ("");
        string plainText = ("");
        string encryptedText = ("");
        //End of Global Variable Declaration

        //Start of Author Defined Methods
        public void checkForText()
        {
            if ((encryptionKey == (""))||(plainText == ("")))
            {
                encryptTextButton.Enabled = false;
            }
            else
            {
                encryptTextButton.Enabled = true;
            }
        }
        //End of Author Defined Methods

        private void singleStringEncrypter_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = ("Logged in as: " + Multi_Tool_V2.Properties.Settings.Default.userName);
            checkForText();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void keyInput_TextChanged(object sender, EventArgs e)
        {
            encryptionKey = keyInput.Text;
            checkForText();
        }

        private void plainTextInput_TextChanged(object sender, EventArgs e)
        {
            plainText = plainTextInput.Text;
            checkForText();
        }

        private void encryptTextBuutton_Click(object sender, EventArgs e)
        {
            checkForText();
        }

        private void encryptedTextOutput_MouseClick(object sender, MouseEventArgs e)
        {

        }
    }
}
