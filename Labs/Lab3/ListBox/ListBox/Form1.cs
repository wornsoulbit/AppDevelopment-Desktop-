using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox {
    public partial class ListBox : Form {
        public ListBox()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Add(InputTextBox.Text);
            InputTextBox.Clear();
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (DisplayListBox.SelectedIndex != -1)
                DisplayListBox.Items.RemoveAt(DisplayListBox.SelectedIndex);
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            DisplayListBox.Items.Clear();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
