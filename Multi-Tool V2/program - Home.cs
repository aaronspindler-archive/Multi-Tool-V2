using System;
using System.Globalization;
using System.Net;
using System.Windows.Forms;
using Multi_Tool_V2.Properties;

namespace Multi_Tool_V2
{
    public partial class programHome : Form
    {
        //@author xNovax
        //Start of Global Variable Declaration
        private readonly String username = Settings.Default.userName;
        private string time = DateTime.Now.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);
        private string errorMessage = ("");
        //End of Global Variable Declaration

        public programHome()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods
        public void errorOccured()
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
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
            timer.Tick += timer_Tick;
            //Start the timer
            timer.Start();

            //Setting IP Addresses
            try
            {
                //Local IP
                String strHostName = string.Empty;
                // Getting Ip address of local machine...
                // First get the host name of local machine.
                strHostName = Dns.GetHostName();
                // Then using host name, get the IP address list..
                IPHostEntry ipEntry = Dns.GetHostEntry(strHostName);
                IPAddress[] addr = ipEntry.AddressList;

                for (int i = 0; i < addr.Length; i++)
                {
                    localIPDisplay.Text = ("Local IP: " + addr[i].ToString());
                }

                //Public IP
                HTTPGet req = new HTTPGet();
                req.Request("http://checkip.dyndns.org");
                string[] a = req.ResponseBody.Split(':');
                string a2 = a[1].Substring(1);
                string[] a3 = a2.Split('<');
                string a4 = a3[0];

                publicIPdisp.Text = ("Public IP: " + a4);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                errorMessage = ("Could not resolve an IP Address");
                errorOccured();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            time = DateTime.Now.ToString("hh:mm:ss tt", DateTimeFormatInfo.InvariantInfo);
            timeDisplay.Text = ("Time: " + time);
        }

        private void resetSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings.Default.Reset();
            MessageBox.Show("Settings have been reset", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pi = new ProgramInfo();
            pi.Show();
        }

        private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var pp = new ProgramPreferences();
            pp.Show();
        }

        //Tools
        private void randomPasswordGeneratorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rp = new RandomPassword_Home();
            rp.Show();
        }

        private void minecraftUserMakerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var mum = new MinecraftUserMaker_Home();
            mum.Show();
        }

        private void rollTheDiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rtd = new RollTheDice();
            rtd.Show();
        }

        private void listRandomizerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var lr = new ListRandomizer();
            lr.Show();
        }

        private void converterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var cvert = new Converter();
            cvert.Show();
        }

        private void rockPaperScissorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var rps = new RockPaperScissors();
            rps.Show();
        }
    }
}