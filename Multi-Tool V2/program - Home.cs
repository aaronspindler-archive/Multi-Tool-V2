using System;
using System.Windows.Forms;
using Multi_Tool_V2.Properties;

namespace Multi_Tool_V2
{
    public partial class programHome : Form
    {
        //@author xNovax
        //Start of Global Variable Declaration
        private readonly String username = Settings.Default.userName;
        //End of Global Variable Declaration

        public programHome()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods

        //End of Author Defined Methods

        //Making sure the entire program is getting closed when you exit the main form
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Doing the same thing as above but for a different event
        private void programHome_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void programHome_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = ("Logged in as: " + username);
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
        }

        private void randomPasswordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rp = new randomPassword_Home();
            rp.Show();
        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pi = new programInfo();
            pi.Show();
        }

        private void minecraftUserMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mum = new minecraftUserMaker_Home();
            mum.Show();
        }

        private void rollTheDiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rtd = new rtd();
            rtd.Show();
        }
    }
}