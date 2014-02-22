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

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void programHome_Load(object sender, EventArgs e)
        {
            usernameDisplay.Text = ("Logged in as: " + username);
        }
    }
}
