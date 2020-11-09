using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualInhertitanceBase {
    public partial class VisualInheritanceBase : Form {
        public VisualInheritanceBase()
        {
            InitializeComponent();
        }

        private void LearnMoreButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bugs, Bugs, Bugs is a product of deitel.com", "Learn More", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
