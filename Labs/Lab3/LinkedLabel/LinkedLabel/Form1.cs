using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinkedLabel {
    public partial class LinkedLabels : Form {
        public LinkedLabels()
        {
            InitializeComponent();
        }

        private void CDriveLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CDriveLinkedLabel.LinkVisited = true;
            System.Diagnostics.Process.Start(@"C:\");
        }

        private void DeitelLinkedLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeitelLinkedLabel.LinkVisited = true;
            System.Diagnostics.Process.Start("http://www.deitel.com");
        }

        private void NotePad_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NotePad.LinkVisited = true;
            System.Diagnostics.Process.Start("notepad");
        }
    }
}
