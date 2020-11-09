using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckListBox {
    public partial class CheckBoxListForm : Form {
        public CheckBoxListForm()
        {
            InitializeComponent();
        }

        private void CheckedListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void CheckedListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            string item = CheckedListBox.SelectedItem.ToString();

            if (e.NewValue == CheckState.Checked)
                DisplayListBox.Items.Add(item);
            else
                DisplayListBox.Items.Remove(item);
        }
    }
}
