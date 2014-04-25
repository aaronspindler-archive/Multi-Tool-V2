using System;
using System.Windows.Forms;
using Multi_Tool_V2.Properties;

//@author xNovax

namespace Multi_Tool_V2
{
    public partial class LoginForm : Form
    {
        //Start of Global Variable Declaration
        public string ErrorCode = ("");
        private Boolean _firstLoad = Settings.Default.firstLoad;
        private string _password = ("");
        private string _username = ("");
        //End of Global Variable Declaration

        public LoginForm()
        {
            InitializeComponent();
        }

        //Start of author created methods

        //Checks the variable firstLoad to see if it is the first time the user has opened the program.
        public void FirstTime()
        {
            if (_firstLoad)
            {
                const string messageContents = ("Welcome to xNovax's Multi-Tool V2");
                const string messageTitle = ("Welcome");
                MessageBox.Show(messageContents, messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                _firstLoad = false;
            }
            else
            {
                const string messageContents = ("Welcome back");
                const string messageTitle = ("Welcome Back");
                MessageBox.Show(messageContents, messageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            Settings.Default.firstLoad = _firstLoad;
            Settings.Default.Save();
        }

        //Checks the information typed into the textboxes against the usernames and passwords below.
        public void CheckInformation()
        {
            if ((_username == ("xNovax")) && (_password == ("password")))
            {
                RecordUsername();
                LaunchHome();
            }
            else
            {
                ErrorCode = ("Username or Password Incorrect");
                ErrorOccured();
            }
        }

        //Checks to see if there is any text in the textboxes.
        //If there is any text in both of the boxes it will enable the login button.
        public void CheckForText()
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
        public void ErrorOccured()
        {
            var messageBoxContents = ("An error has occured: " + ErrorCode);
            const string messageBoxTitle = ("Error");
            MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void RecordUsername()
        {
            Settings.Default.userName = _username;
            Settings.Default.Save();
        }

        public void LaunchHome()
        {
            Hide();
            var programHome = new programHome();
            programHome.Show();
        }

        //End of author created methods

        //Runs this code when the form loads
        private void loginForm_Load(object sender, EventArgs e)
        {
            CheckForText();
            FirstTime();
        }

        //Checks to see if the usernameTextBox's text has changed.
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckForText();
            _username = usernameTextBox.Text;
        }

        //Checks to see if the passwordTextBox's text has changed.
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            CheckForText();
            _password = passwordTextBox.Text;
        }

        //Runs this code when the user clicks on the login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            CheckForText();
            CheckInformation();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            var createUser = new CreateUser();
            createUser.Show();
        }
    }
}