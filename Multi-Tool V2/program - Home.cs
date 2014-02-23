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
    public partial class programHome : Form
    {
        //@author xNovax
        //Start of Global Variable Declaration
        String username = Multi_Tool_V2.Properties.Settings.Default.userName;
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
    }
}
