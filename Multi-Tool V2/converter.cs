using System;
using System.Windows.Forms;

namespace Multi_Tool_V2
{
    public partial class Converter : Form
    {
        //@author xNovax
        string errorMessage = ("");
        string valueInput = ("");
        double value = 0;

        public Converter()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods
        public void ErrorOccured()
        {
            MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //End of Author Defined Methods
        private void valueTextBox_TextChanged(object sender, EventArgs e)
        {
            value = Convert.ToDouble(valueInput);
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            if (valueInput == (""))
            {
                errorMessage = ("Please enter a value to convert");
                ErrorOccured();
            }
            else
            {
                
            }
        }

        private void conversionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(conversionType.SelectedIndex)
            {
                case 0:
                    break;
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
                    break;
            }
        }
    }
}