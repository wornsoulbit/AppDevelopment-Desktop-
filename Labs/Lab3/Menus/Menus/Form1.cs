using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menus {
    public partial class Menus : Form {
        public Menus()
        {
            InitializeComponent();
        }

        private void ClearColor()
        {
            BlackToolStripMenuItem.Checked = false;
            RedToolStripMenuItem.Checked = false;
            GreenToolStripMenuItem.Checked = false;
            BlueToolStripMenuItem.Checked = false;
        }

        private void ClearFont()
        {
            TimesNewRomanToolStripMenuItem.Checked = false;
            CourierToolStripMenuItem.Checked = false;
            ComicSansToolStripMenuItem.Checked = false;
        }

        private void BlackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Black;
            BlackToolStripMenuItem.Checked = true;
        }

        private void RedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Red;
            RedToolStripMenuItem.Checked = true;
        }

        private void GreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Green;
            GreenToolStripMenuItem.Checked = true;
        }

        private void BlueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearColor();
            label1.ForeColor = Color.Blue;
            BlueToolStripMenuItem.Checked = true;
        }

        private void BoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BoldToolStripMenuItem.Checked = !BoldToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Bold);
        }

        private void ItalicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ItalicToolStripMenuItem.Checked = !ItalicToolStripMenuItem.Checked;
            label1.Font = new Font(label1.Font, label1.Font.Style ^ FontStyle.Italic);
        }

        private void TimesNewRomanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            TimesNewRomanToolStripMenuItem.Checked = true;
            label1.Font = new Font("Times New Roman", label1.Font.Size, label1.Font.Style);
        }

        private void CourierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            CourierToolStripMenuItem.Checked = true;
            label1.Font = new Font("Courier", label1.Font.Size, label1.Font.Style);
        }

        private void ComicSansToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClearFont();
            ComicSansToolStripMenuItem.Checked = true;
            label1.Font = new Font("Comic Sans MS", label1.Font.Size, label1.Font.Style);
        }

        private void Menus_Load(object sender, EventArgs e)
        {
            CourierToolStripMenuItem.Checked = true;
            BlackToolStripMenuItem.Checked = true;
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is an example \nof using menus.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
