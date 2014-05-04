using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Multi_Tool_V2
{ 
    public partial class ListRandomizer : Form
    {
        //@author xNovax
        public ListRandomizer()
        {
            InitializeComponent();
        }

        //Variables
        string username = Multi_Tool_V2.Properties.Settings.Default.userName;
        int numItems = 0;
        string itemContents = ("");
        List<string> itemList = new List<string>();

        private void listRandomizer_Load(object sender, EventArgs e)
        {
            //Sets the username display's text
            usernameDisplay.Text = "Logged in as: " + username;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void itemInput_TextChanged(object sender, EventArgs e)
        {
            //Sets the variable itemContents to whatever is in the itemInput text box
            itemContents = itemInput.Text;
        }

        private void addItemButton_Click(object sender, EventArgs e)
        {
            //Adds 1 to the number of items
            numItems = numItems + 1;
            //Displays the number that is converted from an int to a string.
            numberOfItemsDisplay.Text = Convert.ToString(numItems);

            itemList.Add(itemContents);
        }

        private void randomizeAndPrintButton_Click(object sender, EventArgs e)
        {
            //Code to Randomize Items


            //Code to Print-Out Items
        }
    }
}
