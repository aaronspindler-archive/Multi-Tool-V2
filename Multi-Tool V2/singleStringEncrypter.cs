using System;
using System.Windows.Forms;
using Multi_Tool_V2.Properties;

namespace Multi_Tool_V2
{
    public partial class singleStringEncrypter : Form
    {
        //@author xNovax
        string encryptedText = ("");
        string encryptionKey = ("");
        string errorCode = ("");
        string plainText = ("");

        public singleStringEncrypter()
        {
            InitializeComponent();
        }

        //End of Global Variable Declaration

        //Start of Author Defined Methods
        public void CheckForText()
        {
            if ((encryptionKey == ("")) || (plainText == ("")))
            {
                encryptTextButton.Enabled = false;
            }
            else
            {
                encryptTextButton.Enabled = true;
            }
        }

        public void ErrorOccured()
        {
            MessageBox.Show(errorCode, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void EncryptText()
        {
            
        }

        //End of Author Defined Methods

        private void singleStringEncrypter_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = ("Logged in as: " + Settings.Default.userName);
            CheckForText();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void keyInput_TextChanged(object sender, EventArgs e)
        {
            encryptionKey = keyInput.Text;
            CheckForText();
        }

        private void plainTextInput_TextChanged(object sender, EventArgs e)
        {
            plainText = plainTextInput.Text;
            CheckForText();
        }

        private void encryptTextBuutton_Click(object sender, EventArgs e)
        {
            CheckForText();
        }

        private void encryptedTextOutput_MouseClick(object sender, MouseEventArgs e)
        {
            if (encryptedText != null && encryptedText != (""))
            {
                Clipboard.SetText(encryptedText);
                const string messageText = ("Encrypted Text Copied to Clipboard");
                const string messageTitle = ("Encrypted Text Copied");
                MessageBox.Show(messageText, messageTitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }
    }
}