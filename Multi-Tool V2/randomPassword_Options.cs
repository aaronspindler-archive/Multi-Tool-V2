using System;
using System.Windows.Forms;
using Multi_Tool_V2.Properties;

namespace Multi_Tool_V2
{
    //@author xNovax
    public partial class RandomPassword_Options : Form
    {
        //Start of Global Variable Declaration
        private Boolean normalPasswordSelected;
        private Boolean numberPasswordSelected;
        private Boolean specialCharPasswordSelected;
        //End of Global Variable Declaration
        public RandomPassword_Options()
        {
            InitializeComponent();
        }

        //Start of Author Defined Methods
        public void EnableDisableOptions()
        {
            if (normalPasswordSelected)
            {
                normalPasswordCheckBox.Checked = true;
                numberPasswordCheckBox.Checked = false;
                specialCharCheckBox.Checked = false;

                normalPasswordCheckBox.Enabled = true;
                numberPasswordCheckBox.Enabled = false;
                specialCharCheckBox.Enabled = false;

                normalPasswordSelected = true;
                numberPasswordSelected = false;
                specialCharPasswordSelected = false;
                Settings.Default.randomPasswordType = 0;
            }
            else
            {
                if (numberPasswordSelected)
                {
                    normalPasswordCheckBox.Checked = false;
                    numberPasswordCheckBox.Checked = true;
                    specialCharCheckBox.Checked = false;

                    normalPasswordCheckBox.Enabled = false;
                    numberPasswordCheckBox.Enabled = true;
                    specialCharCheckBox.Enabled = false;

                    normalPasswordSelected = false;
                    numberPasswordSelected = true;
                    specialCharPasswordSelected = false;
                    Settings.Default.randomPasswordType = 1;
                }
                else
                {
                    if (specialCharPasswordSelected)
                    {
                        normalPasswordCheckBox.Checked = false;
                        numberPasswordCheckBox.Checked = false;
                        specialCharCheckBox.Checked = true;

                        normalPasswordCheckBox.Enabled = false;
                        numberPasswordCheckBox.Enabled = false;
                        specialCharCheckBox.Enabled = true;

                        normalPasswordSelected = false;
                        numberPasswordSelected = false;
                        specialCharPasswordSelected = true;
                        Settings.Default.randomPasswordType = 2;
                    }
                    else
                    {
                        normalPasswordCheckBox.Checked = false;
                        numberPasswordCheckBox.Checked = false;
                        specialCharCheckBox.Checked = false;

                        normalPasswordCheckBox.Enabled = true;
                        numberPasswordCheckBox.Enabled = true;
                        specialCharCheckBox.Enabled = true;

                        normalPasswordSelected = false;
                        numberPasswordSelected = false;
                        specialCharPasswordSelected = false;
                        Settings.Default.randomPasswordType = 3;
                    }
                }
            }
            Settings.Default.normalPass = normalPasswordSelected;
            Settings.Default.numberPass = numberPasswordSelected;
            Settings.Default.specialCharPass = specialCharPasswordSelected;
            SaveSetting();
        }

        public void SaveSetting()
        {
            Settings.Default.Save();
        }

        //End of Author Defined Methods

        private void normalPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (normalPasswordCheckBox.Checked)
            {
                normalPasswordSelected = true;
            }
            else
            {
                normalPasswordSelected = false;
            }
            EnableDisableOptions();
        }

        private void numberPasswordCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (numberPasswordCheckBox.Checked)
            {
                numberPasswordSelected = true;
            }
            else
            {
                numberPasswordSelected = false;
            }
            EnableDisableOptions();
        }

        private void specialCharCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (specialCharCheckBox.Checked)
            {
                specialCharPasswordSelected = true;
            }
            else
            {
                specialCharPasswordSelected = false;
            }
            EnableDisableOptions();
        }

        private void randomPassword_Options_Load(object sender, EventArgs e)
        {
            normalPasswordSelected = Settings.Default.normalPass;
            numberPasswordSelected = Settings.Default.numberPass;
            specialCharPasswordSelected = Settings.Default.specialCharPass;
            EnableDisableOptions();
        }

        private void randomPassword_Options_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSetting();
        }
    }
}