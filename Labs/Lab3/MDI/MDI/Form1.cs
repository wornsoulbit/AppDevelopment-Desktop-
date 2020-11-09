using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI {
    public partial class MDI : Form {
        public MDI()
        {
            InitializeComponent();
        }

        private void TileVirticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileVertical);
        }

        private void CasadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }

        private void TileHorizontallyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void LavenderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm("Lavender Flowers", "lavenderflowers");
            child.MdiParent = this;
            child.Show();
        }

        private void PurpleFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm("Purple Flowers", "purpleflowers");
            child.MdiParent = this;
            child.Show();
        }

        private void YellowFlowersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChildForm child = new ChildForm("Yellow Flowers", "yellowflowers");
            child.MdiParent = this;
            child.Show();
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
