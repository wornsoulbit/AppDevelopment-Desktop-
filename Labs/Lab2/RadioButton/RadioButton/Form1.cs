using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioButton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private MessageBoxIcon iconType;
        private MessageBoxButtons buttonType;



        private void buttonType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == okRadioButton)
                buttonType = MessageBoxButtons.OK;

            else if (sender == okCancelRadioButton)
                buttonType = MessageBoxButtons.OKCancel;

            else if (sender == abortRetryIgnoreRadioButton)
                buttonType = MessageBoxButtons.AbortRetryIgnore;

            else if (sender == yesNoCancelRadioButton)
                buttonType = MessageBoxButtons.YesNoCancel;

            else if (sender == yesNoRadioButton)
                buttonType = MessageBoxButtons.YesNo;

            else
                buttonType = MessageBoxButtons.RetryCancel;
        }

        private void iconType_CheckedChanged(object sender, EventArgs e)
        {
            if (sender == asteriskRadioButton)
                iconType = MessageBoxIcon.Asterisk;

            else if (sender == errorRadioButton)
                iconType = MessageBoxIcon.Error;

            else if (sender == exclamationRadioButton)
                iconType = MessageBoxIcon.Exclamation;

            else if (sender == handRadioButton)
                iconType = MessageBoxIcon.Hand;

            else if (sender == informationRadioButton)
                iconType = MessageBoxIcon.Information;

            else if (sender == questionRadioButton)
                iconType = MessageBoxIcon.Question;

            else if (sender == stopRadioButton)
                iconType = MessageBoxIcon.Stop;

            else
                iconType = MessageBoxIcon.Warning;
        }

        private void button1_Click(object sender, EventArgs e)
        {


        }



        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("This is your Custom MessageBox.", "Custon MessageBox", buttonType, iconType);

            switch (result)
            {
                case DialogResult.OK:
                    label1.Text = "OK was pressed.";
                    break;
                case DialogResult.Cancel:
                    label1.Text = "Cancel was pressed.";
                    break;
                case DialogResult.Abort:
                    label1.Text = "Abort was pressed.";
                    break;
                case DialogResult.Retry:
                    label1.Text = "Retry was pressed.";
                    break;
                case DialogResult.Ignore:
                    label1.Text = "Ignore was pressed.";
                    break;
                case DialogResult.Yes:
                    label1.Text = "Yes was pressed.";
                    break;
                case DialogResult.No:
                    label1.Text = "No was pressed.";
                    break;
            }

        }

        private void okRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yesNoCancelRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void yesNoRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void abortRetryIgnoreRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void okCancelRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void retryCancelRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

