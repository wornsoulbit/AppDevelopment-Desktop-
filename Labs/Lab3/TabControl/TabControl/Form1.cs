using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TabControl {
    public partial class TabControlForm : Form {
        public TabControlForm()
        {
            InitializeComponent();
        }

        private void RedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.ForeColor = Color.Red;
        }

        private void BlackRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.ForeColor = Color.Black;
        }

        private void GreenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.ForeColor = Color.Green;
        }

        private void FontSizeButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Font = new Font(MessageLabel.Font.Name, 12);
        }

        private void FontSizeButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Font = new Font(MessageLabel.Font.Name, 16);
        }

        private void FontSizeButton3_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Font = new Font(MessageLabel.Font.Name, 20);
        }

        private void MessageButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hello!";
        }

        private void MessageButton2_CheckedChanged(object sender, EventArgs e)
        {
            MessageLabel.Text = "Goodbye!";
        }

        private void TabControlForm_Load(object sender, EventArgs e)
        {
            MessageLabel.Text = "Hello!";
            MessageButton1.Checked = true;
            MessageLabel.Font = new Font(MessageLabel.Font.Name, 12);
            FontSizeButton1.Checked = true;
            BlackRadioButton.Checked = true;
        }
    }
}
