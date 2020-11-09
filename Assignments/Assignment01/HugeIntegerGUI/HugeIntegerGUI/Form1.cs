using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HugeIntegerGUI {
    public partial class HugeIntegerForm : Form {

        private HugeInteger hugeInt1;
        private HugeInteger hugeInt2;
        public HugeIntegerForm()
        {
            InitializeComponent();
            hugeInt1 = new HugeInteger();
            hugeInt2 = new HugeInteger();
            HugeInteger1.MaxLength = 40;
            HugeInteger2.MaxLength = 40;
        }

        private void Input()
        {
            hugeInt1.Input(HugeInteger1.Text);
            hugeInt2.Input(HugeInteger2.Text);
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Input();
            OutputLabel.Text = hugeInt1.Add(hugeInt2).ToString();
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            Input();
            OutputLabel.Text = hugeInt1.Subtract(hugeInt2).ToString();
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            Input();
            OutputLabel.Text = hugeInt1.Multiply(hugeInt2).ToString();
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            Input();
            OutputLabel.Text = hugeInt1.Divide(hugeInt2).ToString();
        }

        private void IsEqualTo_Click(object sender, EventArgs e)
        {
            Input();
            if (hugeInt1.IsEqual(hugeInt2))
                OutputLabel.Text = "Integer 1 is equal to Integer 2";
            else
                OutputLabel.Text = "Integer 1 is not equal to Integer 2";
        }

        private void IsNotEqualTo_Click(object sender, EventArgs e)
        {
            Input();
            if (!hugeInt1.IsEqual(hugeInt2))
                OutputLabel.Text = "Integer 1 is not equal to Integer 2";
            else
                OutputLabel.Text = "Integer 1 is equal to Integer 2";
        }

        private void IsGreaterThan_Click(object sender, EventArgs e)
        {
            Input();
            if (!hugeInt1.IsLessThan(hugeInt2))
                OutputLabel.Text = "Integer 1 is greater than Integer 2";
            else
                OutputLabel.Text = "Integer 1 isn't greater than Integer 2";
        }

        private void IsLessThan_Click(object sender, EventArgs e)
        {
            Input();
            if (hugeInt1.IsLessThan(hugeInt2))
                OutputLabel.Text = "Integer 1 is less than Integer 2";
            else
                OutputLabel.Text = "Integer 1 isn't less than Integer 2";
        }

        private void IsGreaterThanOrEqual_Click(object sender, EventArgs e)
        {
            Input();
            if (hugeInt1.IsLessThanOrEqualTo(hugeInt2))
                OutputLabel.Text = "Integer 1 is greater than or equal Integer 2";
            else
                OutputLabel.Text = "Integer 1 isn't greater than or equal Integer 2";
        }

        private void IsLessThanOrEqual_Click_1(object sender, EventArgs e)
        {
            Input();
            if (!hugeInt1.IsLessThanOrEqualTo(hugeInt2))
                OutputLabel.Text = "Integer 1 is less than or equal Integer 2";
            else
                OutputLabel.Text = "Integer 1 isn't less than or equal Integer 2";
        }
    }
}
