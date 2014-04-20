using System;
using System.Windows.Forms;

namespace Multi_Tool_V2
{
    public partial class RollTheDice : Form
    {
        //@author xNovax
        public RollTheDice()
        {
            InitializeComponent();
        }

        //Start of Global Variable Declaration
        decimal numSidesDice = 1;
        int convertedNumSides = 1;
        Random gen = new Random();
        int rolledNumber;
        //End of Global Variable Declaration

        
        //Start of Author Defined Methods
        public void rollDice()
        {
            rolledNumber = gen.Next(convertedNumSides) + 1;
        }
        //End of Author Defined Methods

        private void numberOfSidesOnDice_ValueChanged(object sender, System.EventArgs e)
        {
            numSidesDice = numberOfSidesOnDice.Value;
            convertedNumSides = Convert.ToInt16(numSidesDice);
        }

        private void getRandomSide_Click(object sender, System.EventArgs e)
        {
            convertedNumSides = Convert.ToInt16(numSidesDice);
            rollDice();
            String rolledNumberString = rolledNumber.ToString();
            rolledNumberLabel.Text = (rolledNumberString);
        }
    }
}