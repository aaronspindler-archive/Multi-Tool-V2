using System;
using System.Windows.Forms;

namespace Multi_Tool_V2
{
    public partial class singleStringDecrypter : Form
    {
        //@author xNovax
        //Start of Global Variable Declaration
        string decryptionKey;
        string encryptedText;
        string decryptedText;
        //End of Global Variable Declaration
        public singleStringDecrypter()
        {
            InitializeComponent();
        }
        //Start of Author Defined Methods
        public void CheckForText()
        {
            if ((decryptionKeyField.Text == ("")) || (encryptedTextField.Text == ("")))
            {
                decryptedTextButton.Enabled = false;
            }
        }
        //End of Author Defined Methods

        private void decryptionKeyField_TextChanged(object sender, EventArgs e)
        {
            CheckForText();
            decryptionKey = decryptionKeyField.Text;
        }

        private void encryptedTextField_TextChanged(object sender, EventArgs e)
        {
            CheckForText();
            encryptedText = encryptedTextField.Text;
        }

        private void decryptedTextButton_Click(object sender, EventArgs e)
        {
            CheckForText();
        }

        private void singleStringDecrypter_Load(object sender, EventArgs e)
        {
            CheckForText();
        }
    }
}
