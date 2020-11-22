using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LINQToFileDirectory {
    public partial class LINQToFileDirectoryForm : Form {

        string currentDirectory;

        Dictionary<string, int> found = new Dictionary<string, int>();

        public LINQToFileDirectoryForm()
        {
            InitializeComponent();
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            if (InputTextBox.Text != string.Empty && !Directory.Exists(InputTextBox.Text))
            {
                MessageBox.Show("Invalid Directory", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (InputTextBox.Text == string.Empty)
                {
                    currentDirectory = Directory.GetCurrentDirectory();
                } 
                else
                {
                    currentDirectory = InputTextBox.Text;
                }

                DirectoryTextBox.Text = currentDirectory;

                InputTextBox.Clear();
                OutputTextBox.Clear();

                SearchDirectory(currentDirectory);

                CleanDirectory(currentDirectory);

                foreach(var current in found.Keys)
                {
                    OutputTextBox.AppendText(string.Format("* Found {0} {1} files.\r\n", found[current], current));
                }

                found.Clear();
            }
        }

        private void SearchDirectory(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            string[] directories = Directory.GetDirectories(folder);

            var extensions = (from file in files select Path.GetExtension(file)).Distinct();

            foreach (var extension in extensions)
            {
                var extensionCount = (from file in files where Path.GetExtension(file) == extension select file).Count();

                if (found.ContainsKey(extension))
                {
                    found[extension] += extensionCount;
                }
                else
                {
                    found.Add(extension, extensionCount);
                }
            }

            foreach (var subdirectory in directories)
            {
                SearchDirectory(subdirectory);
            }
        }

        private void CleanDirectory(string folder)
        {
            string[] files = Directory.GetFiles(folder);
            string[] directories = Directory.GetDirectories(folder);

            var backupFiles = from file in files where Path.GetExtension(file) == ".bak" select file;

            foreach (var backup in backupFiles)
            {
                DialogResult result = MessageBox.Show("Found backup file " + Path.GetFileName(backup) + ". Delete?", "Delete Backup", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    File.Delete(backup);
                    --found[".bak"];

                    if (found[".bak"] == 0)
                        found.Remove(".bak");
                }
            }

            foreach (var subdirectory in directories)
            {
                CleanDirectory(subdirectory);
            }
        }
    }
}
