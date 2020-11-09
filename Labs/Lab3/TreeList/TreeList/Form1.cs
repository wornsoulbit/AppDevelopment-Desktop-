using System;
using System.IO;
using System.Windows.Forms;

namespace TreeList {
    public partial class TreeViewForm : Form {
        
        string subStringDirectory;

        public TreeViewForm()
        {
            InitializeComponent();
        }

        private void PopulateTreeView(string directoryValue, TreeNode parentNode)
        {
            string[] directoryArray = Directory.GetDirectories(directoryValue);

            try
            {
                if (directoryArray.Length != 0)
                {
                    foreach (string directory in directoryArray)
                    {
                        subStringDirectory = Path.GetFileNameWithoutExtension(directory);
                        TreeNode myNode = new TreeNode(subStringDirectory);
                        parentNode.Nodes.Add(myNode);
                        PopulateTreeView(directory, myNode);
                    }
                }
            } catch (UnauthorizedAccessException)
            {
                parentNode.Nodes.Add("Access Denied");
            }
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            TreeViewBox.Nodes.Clear();

            if (Directory.Exists(InputTextBox.Text))
            {
                TreeViewBox.Nodes.Add(InputTextBox.Text);

                PopulateTreeView(InputTextBox.Text, TreeViewBox.Nodes[0]);
            }
        }
    }
}
