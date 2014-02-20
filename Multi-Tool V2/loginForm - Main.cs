using System;
using System.IO;
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

        //Variables to temporarly store what the file reader is reading
        String readUsername;
        String readPassword;
        //Variable that will hold what the user inputs into the usernameField
        String inputUsername;
        //Variable that will hold what the user inputs into the passwordField
        String inputPassword;
        //How many users are there in the text file?
        int numberOfUsers = Multi_Tool_V2.Properties.Settings.Default.numberOfUsers;
        //Is it the first time the user has loaded the program?
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

        //Checks the variable firstLoad to see if it is the first time the user has opened the program.
        public void firstTime()
        {
            if (firstLoad == true)
            {
                
            }
        }

        //Open and read the login file
        public void readFile()
        {
            StreamReader reader = new StreamReader(Multi_Tool_V2.Properties.Resources.userInfo);
            for (int i = 0; i < numberOfUsers; i++)
            {
                readUsername = reader.ReadLine();
                readPassword = reader.ReadLine();
            }
            reader.Close();
        }

        //Checks the inputted information against the information in the text file
        public void checkInformation()
        {
            
        }

        //End of author created methods

        //Runs this code when the form loads
        private void loginForm_Load(object sender, EventArgs e)
        {
            firstTime();
            checkForText();
        }

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

        //Runs this code when the user clicks on the login button
        private void loginButton_Click(object sender, EventArgs e)
        {
            checkForText();
            checkInformation();
        }
    }
}
