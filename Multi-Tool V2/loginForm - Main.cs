using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//@author xNovax

namespace Multi_Tool_V2
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        //Start of Variable Declaration
        String readUsername;
        String readPassword;
        String inputUsername;
        String inputPassword;
        int numberOfUsers = Multi_Tool_V2.Properties.Settings.Default.numberOfUsers;
        Boolean firstLoad = Multi_Tool_V2.Properties.Settings.Default.firstLoad;
        //End of Variable Declaration

        //Start of author created methods

        //Checks to see if there is any text in the textboxes.
        //If there is any text in both of the boxes it will enable the login button.
        public void checkForText()
        {
            if ((usernameTextBox.Text == (""))||(passwordTextBox.Text == ("")))
            {
                loginButton.Enabled = false;
            }
            else
            {
                loginButton.Enabled = true;
            }
        }

        //Opens up the userfile and reads the file. If a users username and password inputed match a set from the file they will be allowed in.
        public void checkInformation()
        {
            StreamReader reader = new StreamReader(Multi_Tool_V2.Properties.Resources.userInfo);
            for (int i = 0; i < numberOfUsers; i++)
            {
                readUsername = reader.ReadLine();
                readPassword = reader.ReadLine();
                Console.WriteLine(readUsername);
                Console.WriteLine(readPassword);
            }
            reader.Close();
        }

        //End of author created methods

        //Checks to see if the usernameTextBox's text has changed.
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            inputUsername = usernameTextBox.Text;
        }

        //Checks to see if the passwordTextBox's text has changed.
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            inputPassword = passwordTextBox.Text;
        }

        //Runs this code when the form loads
        private void loginForm_Load(object sender, EventArgs e)
        {
            checkForText();
            //Resets all settings to defaults.
            //Delete the line below before release.
            Properties.Settings.Default.Reset();
        }

        //Runs this code when the user clicks on the login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            checkForText();
            checkInformation();
        }
    }
}
