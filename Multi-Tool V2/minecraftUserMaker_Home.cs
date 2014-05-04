using System;
using System.IO;
using System.Windows.Forms;
using Multi_Tool_V2.Properties;

namespace Multi_Tool_V2
{
    //@author xNovax
    public partial class MinecraftUserMaker_Home : Form
    {
        //Start of Global Variable Declaration

        private const int RANDOMPASSWORDLENGTH = 16;
        private readonly Random _gen = new Random();
        private readonly string[] randomPassword = new string[RANDOMPASSWORDLENGTH];

        private String IP = ("216.221.72.61");
        private string adminPanelPort = ("");
        private string customPassword;
        private Boolean customPasswordUsed;
        private String errorCode = ("");

        private string fileName;
        private string ftpPort = ("18002");
        private string mcServerPort = ("");
        private Boolean progressFull = false;
        private String serverName;
        private string username;

        //End of Global Variable Declaration

        public MinecraftUserMaker_Home()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods
        //General error message with a customizable error code.
        public void errorOccured()
        {
            string messageBoxContents = ("An error has occured: " + errorCode);
            const string messageBoxTitle = ("Error");
            MessageBox.Show(messageBoxContents, messageBoxTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void fillProgress()
        {
            if (progressFull == false)
            {
                for (int i = 0; i < 101; i++)
                {
                    progressBar.Value = (i);
                }
            }
            else
            {
                emptyProgres();
                for (int i = 0; i < 101; i++)
                {
                    progressBar.Value = (i);
                }
            }
        }

        public void emptyProgres()
        {
            if (progressFull)
            {
                progressBar.Value = (0);
            }
            else
            {
                errorCode = ("Whoops, something went wrong!");
                errorOccured();
            }
        }

        public void checkforInfo()
        {
            if (usernameEntry.Text == (""))
            {
                createFileButton.Enabled = false;
            }
            else
            {
                if (usernameEntry.Text != (""))
                {
                    if (customPasswordCheckBox.Checked && (customPasswordEntry.Text == ("")))
                    {
                        createFileButton.Enabled = false;
                    }
                    else
                    {
                        createFileButton.Enabled = true;
                    }
                }
            }
        }

        public void createRandomPassword()
        {
            var allowedStrings = new String[62]
            {
                "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u",
                "v",
                "w", "x", "y", "z", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q",
                "R",
                "S", "T", "U", "V", "W", "X", "Y", "Z", "1", "2", "3", "4", "5", "6", "7", "8", "9", "0"
            };

            for (int i = 0; i < RANDOMPASSWORDLENGTH; i++)
            {
                int randomNum = _gen.Next(62);
                randomPassword[i] = allowedStrings[randomNum];
            }
        }

        public void writeFile()
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var writer = new StreamWriter(saveFileDialog.FileName);
                fileName = saveFileDialog.FileName;

                writer.WriteLine("===========================================================");
                writer.WriteLine("Server Name: " + serverName);
                writer.WriteLine("===========================================================");
                writer.WriteLine("[Control Panel Information]");
                writer.WriteLine("Control Panel Website: http://" + IP + ":" + adminPanelPort);
                writer.WriteLine("Control Panel Username: " + username);

                //What kind of password?
                if (customPasswordUsed)
                {
                    writer.WriteLine("Control Panel Password: " + customPassword);
                }
                else
                {
                    writer.Write("Control Panel Password: ");
                    for (int i = 0; i < RANDOMPASSWORDLENGTH; i++)
                    {
                        writer.Write(randomPassword[i]);
                    }
                    writer.WriteLine();
                }

                writer.WriteLine("===========================================================");
                writer.WriteLine("[FTP Information]");
                writer.WriteLine("FTP IP: " + IP + ":" + ftpPort);
                writer.WriteLine("FTP Username: " + username);

                //What kind of password?
                if (customPasswordUsed)
                {
                    writer.WriteLine("FTP Password: " + customPassword);
                }
                else
                {
                    writer.Write("FTP Password: ");
                    for (int i = 0; i < RANDOMPASSWORDLENGTH; i++)
                    {
                        writer.Write(randomPassword[i]);
                    }
                    writer.WriteLine();
                }

                writer.WriteLine("===========================================================");
                writer.WriteLine("[Minecraft Server Information]");
                writer.WriteLine("Minecraft Server Port: " + IP + ":" + mcServerPort);

                writer.WriteLine("===========================================================");
                writer.WriteLine("[END OF FILE]");
                writer.Close();
            }
        }

        //End of Author Defined Methods

        private void minecraftUserMaker_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = ("Logged in as: " + Settings.Default.userName);
            customPasswordEntry.Enabled = (false);
            checkforInfo();
        }

        private void usernameEntry_TextChanged(object sender, EventArgs e)
        {
            username = usernameEntry.Text;
            checkforInfo();
        }

        private void customPasswordEntry_TextChanged(object sender, EventArgs e)
        {
            customPassword = customPasswordEntry.Text;
            checkforInfo();
        }

        private void customPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (customPasswordCheckBox.Checked)
            {
                customPasswordUsed = true;
                customPasswordEntry.Enabled = true;
            }
            else
            {
                if (customPasswordCheckBox.Checked == false)
                {
                    customPasswordUsed = false;
                    customPasswordEntry.Enabled = false;
                }
            }
            checkforInfo();
        }

        private void serverSelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serverSelector.SelectedIndex == 0)
            {
                serverName = ("Confound Gaming Ultimate Skyblock");
                mcServerPort = ("25566");
                adminPanelPort = ("8080");
            }
            else
            {
                if (serverSelector.SelectedIndex == 1)
                {
                    serverName = ("Reaper Server");
                    mcServerPort = ("8182");
                    adminPanelPort = ("25565");
                }
            }
        }

        private void createFileButton_Click(object sender, EventArgs e)
        {
            createRandomPassword();
            checkforInfo();
            writeFile();
            fillProgress();
            MessageBox.Show(("Minecraft User has now been written to " + fileName), "Completed", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
    }
}