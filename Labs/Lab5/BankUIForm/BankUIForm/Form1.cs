using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankUIForm {
    public partial class BankUIForm : Form {

        protected int TextBoxCount = 4;

        public enum TextBoxIndices
        {
            ACCOUNT, 
            FIRST,
            LAST,
            BALANCE
        }

        public BankUIForm()
        {
            InitializeComponent();
        }

        public void ClearTextBoxes()
        {
            foreach (Control guiControl in Controls)
            {
                if (guiControl is TextBox)
                {
                    ((TextBox)guiControl).Clear();
                }
            }
        }

        public void SetTextBoxValues(string[] values)
        {
            if (values.Length != TextBoxCount)
            {
                throw new ArgumentException("There must be " + TextBoxCount + " strings in the array");
            }
            else
            {
                AccountTextBox.Text = values[(int)TextBoxIndices.ACCOUNT];
                FirstTextBox.Text = values[(int)TextBoxIndices.FIRST];
                LastTextBox.Text = values[(int)TextBoxIndices.LAST];
                BalTextBox.Text = values[(int)TextBoxIndices.BALANCE];
            }
        }

        public string[] GetTextBoxValues()
        {
            string[] values = new string[TextBoxCount];

            values[(int)TextBoxIndices.ACCOUNT] = AccountTextBox.Text;
            values[(int)TextBoxIndices.FIRST] = FirstTextBox.Text;
            values[(int)TextBoxIndices.LAST] = LastTextBox.Text;
            values[(int)TextBoxIndices.BALANCE] = BalTextBox.Text;

            return values;
        }
    }
}
