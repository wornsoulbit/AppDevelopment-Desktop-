using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListView {
    public partial class ListViewForm : Form {

        string currentDirectory = Directory.GetCurrentDirectory();

        public ListViewForm()
        {
            InitializeComponent();
        }

        private void ListViewForm_Load(object sender, EventArgs e)
        {
            ImageList1.Images.Add(Properties.Resources.folder);
            ImageList1.Images.Add(Properties.Resources.file);
            LoadFilesInDirectory(currentDirectory);
            DisplayLabel.Text = currentDirectory;
        }

        private void ListView1_Click(object sender, EventArgs e)
        {
            if (ListView1.Items[0].Selected)
            {
                DirectoryInfo directoryObject = new DirectoryInfo(currentDirectory);

                if (directoryObject.Parent != null)
                {
                    LoadFilesInDirectory(directoryObject.Parent.FullName);
                }
            }
            else
            {
                string chosen = ListView1.SelectedItems[0].Text;

                if (Directory.Exists(Path.Combine(currentDirectory, chosen)))
                {
                    LoadFilesInDirectory(Path.Combine(currentDirectory, chosen));
                }
            }

            DisplayLabel.Text = currentDirectory;
        }

        public void LoadFilesInDirectory(string currentDirectoryValue)
        {
            try
            {
                ListView1.Items.Clear();
                ListView1.Items.Add("Go up one level");

                currentDirectory = currentDirectoryValue;
                DirectoryInfo newCurrentDirectory = new DirectoryInfo(currentDirectory);
                DirectoryInfo[] directoryArray = newCurrentDirectory.GetDirectories();
                FileInfo[] fileArray = newCurrentDirectory.GetFiles();

                foreach (DirectoryInfo dir in directoryArray)
                {
                    ListViewItem newDirectoryItem = ListView1.Items.Add(dir.Name);
                    newDirectoryItem.ImageIndex = 0;
                }

                foreach (FileInfo file in fileArray)
                {
                    ListViewItem newFileItem = ListView1.Items.Add(file.Name);
                    newFileItem.ImageIndex = 1;
                } 
            } 
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Warning: Some files may not be visible due to permission settings", "Attention", 0, MessageBoxIcon.Warning);
            }
        }
    }
}
