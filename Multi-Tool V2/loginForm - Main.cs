using System;
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

        //Start of Global Variable Declaration
        string errorCode = ("");
        string username = ("");
        string password = ("");
        Boolean firstLoad = Multi_Tool_V2.Properties.Settings.Default.firstLoad;
        Boolean loginSuccessful = false;
        //End of Global Variable Declaration

        //Start of author created methods

        //Checks the variable firstLoad to see if it is the first time the user has opened the program.
        public void firstTime()
        {
            if (firstLoad == true)
            {
                var messageContents = ("Welcome to xNovax's Multi-Tool V2");
                var messageTitle = ("Welcome");
                MessageBox.Show(messageContents,messageTitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            else
            {
                var messageContents = ("Welcome back");
                var messageTitle = ("Welcome Back");
                MessageBox.Show(messageContents,messageTitle,MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        //Checks the information typed into the textboxes against the usernames and passwords below.
        public void checkInformation()
        {
            if ((username == ("xNovax")) && (password == ("password")))
            {
                loginSuccessful = true;
                recordUsername();
            }
            else
            {
                errorCode = ("Username or Password Incorrect");
                errorOccured();
            }
        }

        //Checks to see if there is any text in the textboxes.
        //If there is any text in both of the boxes it will enable the login button.
        public void checkForText()
        {
            if ((usernameTextBox.Text == ("")) || (passwordTextBox.Text == ("")))
            {
                loginButton.Enabled = false;
            }
            else
            {
                loginButton.Enabled = true;
            }
        }

        //General error message with a customizable error code.
        public void errorOccured()
        {
            var messageBoxContents = ("An error has occured: "+errorCode);
            var messageBoxTitle = ("Error");
            MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void recordUsername()
        {
            Multi_Tool_V2.Properties.Settings.Default.userName = username;
        }

        //End of author created methods

        //Runs this code when the form loads
        private void loginForm_Load(object sender, EventArgs e)
        {
            checkForText();
            firstTime();
        }

        //Checks to see if the usernameTextBox's text has changed.
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            username = usernameTextBox.Text;
        }

        //Checks to see if the passwordTextBox's text has changed.
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            password = passwordTextBox.Text;
        }

        //Runs this code when the user clicks on the login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            checkForText();
            checkInformation();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            errorCode = ("Feature not yet implemented");
            errorOccured();
        }
    }
}
