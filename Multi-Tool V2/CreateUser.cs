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
    public partial class CreateUser : Form
    {
        //@author xNovax
        public CreateUser()
        {
            InitializeComponent();
        }

        //Variables
        Boolean isThereTextInField = false;
        string username = ("");
        string password = ("");

        public void checkForText()
        {
            if ((usernameEntry.Text == (""))||(passwordEntry.Text == (""))||(passwordVerifyEntry.Text == ("")))
            {
                isThereTextInField = false;
            }
            else
            {
                isThereTextInField = true;
            }
        }

        public void loadButton()
        {
            if ((isThereTextInField == true)&&(passwordEntry.Text == passwordVerifyEntry.Text))
            {
                createUserButton.Enabled = true;
            }
            else
            {
                createUserButton.Enabled = false;
            }
        }

        private void CreateUser_Load(object sender, EventArgs e)
        {
            checkForText();
            loadButton();
        }

        private void usernameEntry_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            loadButton();
            username = usernameEntry.Text;
        }

        private void passwordEntry_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            loadButton();
            password = passwordEntry.Text;
        }

        private void passwordVerifyEntry_TextChanged(object sender, EventArgs e)
        {
            checkForText();
            loadButton();
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {

        }
    }
}
