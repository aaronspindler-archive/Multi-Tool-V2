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
        //End of Gloabl Variable Declaration

        public randomPassword_Home()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods
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
