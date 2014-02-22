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

        //Start of Global Variable Declaration

        //Variables to temporarly store what the file reader is reading
        String readUsername = ("1");
        String readPassword = ("1");
        //Variable that will hold what the user inputs into the usernameField
        String inputUsername = ("");
        //Variable that will hold what the user inputs into the passwordField
        String inputPassword = ("");
        //Is it the first time the user has loaded the program?
        Boolean firstLoad = Multi_Tool_V2.Properties.Settings.Default.firstLoad;
        Boolean loginSuccesful;
        String fileName;
        String errorCode = ("");
        Boolean errorOccuredAlready = false;

        //End of Global Variable Declaration

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
                //Creating local variables to store the messageBox information
                var messageBoxContents = ("Please load a user file into the program");
                var messageBoxTitle = ("Load a File");

                if (MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK,MessageBoxIcon.Information) == DialogResult.OK)
                {
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        firstLoad = false;
                        fileName = openFileDialog.FileName;
                        Multi_Tool_V2.Properties.Settings.Default.userFileName = fileName;
                    }
                    else
                    {
                        errorOccured();
                    }
                }
                else
                {
                    errorOccured();
                }
                Multi_Tool_V2.Properties.Settings.Default.firstLoad = firstLoad;
                Multi_Tool_V2.Properties.Settings.Default.Save();
            }
            else
            {
                fileName = Multi_Tool_V2.Properties.Settings.Default.userFileName;
            }
        }

        //Open and read the login file
        public void readFile()
        {
            //Create a file reader that is targeting the userInfo.txt file in the resources.
            StreamReader reader = new StreamReader(fileName);
            //Reads the file until you reach the end of the file or you succesfully get a combination
            do{
                readUsername = reader.ReadLine();
                readPassword = reader.ReadLine();
                checkInformation();
              } while((readUsername != null)||(readPassword != null)||(loginSuccesful != true));

            reader.Close();
        }

        //Checks the inputted information against the information in the text file
        public void checkInformation()
        {
            if ((readUsername == inputUsername) && (readPassword == inputPassword))
            {
                loginSuccesful = true;
            }
            else
            {
                if (errorOccuredAlready == false)
                {
                    loginSuccesful = false;
                    errorCode = ("Username or Password Incorrect");
                    errorOccured();
                    errorOccuredAlready = true;
                }
                else
                {
                    
                }
            }
        }

        public void errorOccured()
        {
            var messageBoxContents = ("An error has occured: "+errorCode);
            var messageBoxTitle = ("Error");
            MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            firstTime();
            readFile();
        }
    }
}
