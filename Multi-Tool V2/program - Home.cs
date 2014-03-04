using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Multi_Tool_V2.Properties;

namespace Multi_Tool_V2
{
    public partial class programHome : Form
    {
        //@author xNovax
        //Start of Global Variable Declaration
        private readonly String username = Settings.Default.userName;
        string time = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
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
            //Set the usernamedisplay to your username
            usernameDisplay.Text = ("Logged in as: " + username);
            //Sets the time label when the form loads
            timeDisplay.Text = ("Time: " + time);

            //Runs the timer_tick method everytime the timer ticks
            timer.Tick += new EventHandler(timer_Tick);
            //Start the timer
            timer.Start();
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

        private void encrypterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var sse = new singleStringEncrypter();
            sse.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pp = new ProgramPreferences();
            pp.Show();
        }

        private void decrypterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var ssd = new singleStringDecrypter();
            ssd.Show();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("hh:mm:ss tt", System.Globalization.DateTimeFormatInfo.InvariantInfo);
            timeDisplay.Text = ("Time: " + time);
        }
    }
}